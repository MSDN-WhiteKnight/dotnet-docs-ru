---
description: 'Дополнительные сведения: профили отслеживания'
title: Профили отслеживания
ms.date: 03/30/2017
ms.assetid: 22682566-1cd9-4672-9791-fb3523638e18
ms.openlocfilehash: 9748f0452a1699e08760372f826f2458d82f4b79
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99755152"
---
# <a name="tracking-profiles"></a>Профили отслеживания

Профили отслеживания содержат запросы отслеживания, позволяющие участнику подписываться на события рабочего потока, создаваемые в момент изменения состояния экземпляра рабочего процесса во время выполнения.

## <a name="tracking-profiles"></a>Профили отслеживания

С помощью профилей отслеживания можно определять, какие данные отслеживания создаются для экземпляра рабочего процесса. Если этот профиль не указан, создаются все события отслеживания. Если профиль указан, будут создаваться события, определенные в профиле отслеживания. Исходя из потребностей можно написать профиль с обычной гранулярностью, который будет подписан на небольшой набор изменений состояния высокого уровня в рабочем процессе. И наоборот, можно создать очень детальный профиль, результирующие события которого будут достаточно подробными для воспроизведения всего потока выполнения в дальнейшем.

Профили отслеживания сами являются XML-элементами в стандартном платформа .NET Framework файле конфигурации или задаются в коде. В следующем примере показан профиль отслеживания [!INCLUDE[netfx_current_long](../../../includes/netfx-current-long-md.md)] в файле конфигурации, который позволяет участнику отслеживания подписаться на события рабочих процессов `Started` и `Completed`.

```xml
<system.serviceModel>
    ...
    <tracking>
     <profiles>
      <trackingProfile name="Sample Tracking Profile">
        <workflow activityDefinitionId="*">
          <workflowInstanceQueries>
            <workflowInstanceQuery>
              <states>
                <state name="Started"/>
                <state name="Completed"/>
              </states>
            </workflowInstanceQuery>
          </workflowInstanceQueries>
        </workflow>
      </trackingProfile>
    </profiles>
  </tracking>
    ...
</system.serviceModel>
```

В следующем примере показан соответствующий профиль отслеживания, созданный с помощью кода.

```csharp
TrackingProfile profile = new TrackingProfile()
{
    Name = "CustomTrackingProfile",
    Queries =
    {
        new WorkflowInstanceQuery()
        {
            // Limit workflow instance tracking records for started and
            // completed workflow states.
            States = { WorkflowInstanceStates.Started, WorkflowInstanceStates.Completed },
        }
    }
};
```

Записи отслеживания фильтруются посредством режима видимости в рамках профиля отслеживания при помощи атрибута <xref:System.Activities.Tracking.ImplementationVisibility>. Составное действие является действием верхнего уровня, которое содержит другие действия, образующие его реализацию. Режим видимости задает записи отслеживания, созданные из композитных действий в действии рабочего процесса, с целью указания, отслеживаются ли действия, образующие реализацию. Режим видимости применяется на уровне профиля отслеживания. Фильтрацией записей отслеживания для отдельно взятых действий в рабочем процессе управляют при помощи запросов в профиле отслеживания. Дополнительные сведения см. в разделе **типы запросов профиля отслеживания** в этом документе.

Два режима видимости, задаваемые атрибутом `implementationVisibility` в профиле отслеживания, - `RootScope` и `All`. Использование режима `RootScope` удаляет записи отслеживания для действий, образующих реализацию действия в том случае, когда композитное действие не является корневым действием в рабочем процессе. Это предполагает, что, когда действие, реализуемое при помощи других действий, добавляется в рабочий процесс и параметр `implementationVisibility` имеет значение RootScope, будут отслеживаться только события верхнего уровня внутри этого композитного действия. Если действие является корневым для рабочего процесса, реализация действия - это сам рабочий процесс, а записи отслеживания создаются для действий, образующих реализацию. Использование режима «Все» позволяет создавать записи отслеживания для корневого действия и всех его композитных действий.

Например, предположим, что *MyActivity* является составным действием, реализация которого содержит два действия: *Activity1* и *Activity2*. При добавлении этого действия в рабочий процесс и включении отслеживания с помощью профиля отслеживания с параметром `implementationVisibility` `RootScope` , записи отслеживания создаются только для *MyActivity*. Однако для действий *Activity1* и *Activity2* не создаются никакие записи.

Однако если для `implementationVisibility` атрибута профиля отслеживания задано значение `All` , записи отслеживания передаются не только для *MyActivity*, но и для действий *Activity1* и *Activity2*.

Флажок `implementationVisibility` применяется для следующих типов записей отслеживания:

- ActivityStateRecord

- FaultPropagationRecord

- CancelRequestedRecord

- ActivityScheduledRecord

> [!NOTE]
> Запись CustomTrackingRecords, создаваемая из реализации действия, не фильтруется параметром implementationVisibility.

Функция `implementationVisibility` задается как <xref:System.Activities.Tracking.ImplementationVisibility.RootScope> в профиле отслеживания в коде следующим образом:

```csharp
TrackingProfile sampleTrackingProfile = new TrackingProfile()
{
    Name = "Sample Tracking Profile",
    ImplementationVisibility = ImplementationVisibility.RootScope
};
```

Функция `implementationVisibility` может задается как <xref:System.Activities.Tracking.ImplementationVisibility.All> в профиле отслеживания в файле конфигурации следующим образом:

```xml
<tracking>
      <profiles>
        <trackingProfile name="Shipping Monitoring" implementationVisibility="All">
          <workflow activityDefinitionId="*">
...
         </workflow>
        </trackingProfile>
      </profiles>
</tracking>
```

Параметр `ImplementationVisibility` в профиле отслеживания является необязательным. По умолчанию он имеет значение `RootScope`. Значения для этого атрибута также учитывают регистр.

### <a name="tracking-profile-query-types"></a>Отслеживание типов запросов профиля

Профили отслеживания структурированы в форме объявляющих подписок на записи отслеживания, которые позволяют выполнять запросы к среде выполнения рабочего процесса в отношении определенных записей отслеживания. Существует множество типов запросов, которые позволяют подписаться на различные классы объектов <xref:System.Activities.Tracking.TrackingRecord>. Профили отслеживания могут быть заданы в конфигурации или посредством кода. Ниже приводятся наиболее распространенные типы запросов.

- <xref:System.Activities.Tracking.WorkflowInstanceQuery> - используйте этот запрос для отслеживания изменений жизненного цикла экземпляра рабочего процесса, таких как ранее представленные события `Started` и `Completed`. Запрос <xref:System.Activities.Tracking.WorkflowInstanceQuery> используется для подписки на следующие объекты <xref:System.Activities.Tracking.TrackingRecord>.

  - <xref:System.Activities.Tracking.WorkflowInstanceRecord>

  - <xref:System.Activities.Tracking.WorkflowInstanceAbortedRecord>

  - <xref:System.Activities.Tracking.WorkflowInstanceUnhandledExceptionRecord>

  - <xref:System.Activities.Tracking.WorkflowInstanceTerminatedRecord>

  - <xref:System.Activities.Tracking.WorkflowInstanceSuspendedRecord>

  Состояния, на которые можно подписаться, задаются классом <xref:System.Activities.Tracking.WorkflowInstanceStates>.

  Конфигурация или код, используемые для подписки на записи отслеживания на уровне экземпляра рабочего процесса для состояния экземпляра `Started` при помощи запроса <xref:System.Activities.Tracking.WorkflowInstanceQuery>, показаны в следующем примере.

  ```xml
  <workflowInstanceQueries>
      <workflowInstanceQuery>
        <states>
          <state name="Started"/>
        </states>
      </workflowInstanceQuery>
  </workflowInstanceQueries>
  ```

  ```csharp
  TrackingProfile sampleTrackingProfile = new TrackingProfile()
  {
      Name = "Sample Tracking Profile",
      Queries =
      {
          new WorkflowInstanceQuery()
          {
              States = { WorkflowInstanceStates.Started}
          }
      }
  };
  ```

- <xref:System.Activities.Tracking.ActivityStateQuery> - используйте этот запрос для отслеживания изменений жизненного цикла действий, составляющих экземпляр рабочего процесса. Например, вы можете захотеть отследить каждый раз, когда действие "отправить электронное письмо" завершается в рамках экземпляра рабочего процесса. Этот запрос необходим, чтобы участник <xref:System.Activities.Tracking.TrackingParticipant> мог подписаться на объекты <xref:System.Activities.Tracking.ActivityStateRecord>. Состояния, доступные для подписки, указаны в <xref:System.Activities.Tracking.ActivityStates>.

  Конфигурация и код, используемые для подписки на записи отслеживания состояний действий при помощи запроса <xref:System.Activities.Tracking.ActivityStateQuery> для действия `SendEmailActivity`, показаны в следующем примере.

  ```xml
  <activityStateQueries>
    <activityStateQuery activityName="SendEmailActivity">
      <states>
        <state name="Closed"/>
      </states>
    </activityStateQuery>
  </activityStateQueries>
  ```

  ```csharp
  TrackingProfile sampleTrackingProfile = new TrackingProfile()
  {
      Name = "Sample Tracking Profile",
      Queries =
      {
          new ActivityStateQuery()
          {
              ActivityName = "SendEmailActivity",
              States = { ActivityStates.Closed }
          }
      }
  };
  ```

  > [!NOTE]
  > Если несколько элементов activityStateQuery имеют одинаковые имена, то только состояния в последнем элементе используются в профиле отслеживания.

- <xref:System.Activities.Tracking.ActivityScheduledQuery> - этот запрос позволяет отслеживать действие, запланированное к исполнению родительским действием. Этот запрос необходимо, чтобы участник <xref:System.Activities.Tracking.TrackingParticipant> мог подписаться на объекты <xref:System.Activities.Tracking.ActivityScheduledRecord>.

  Конфигурация и код, используемые для подписки на записи, связанные с дочерним действием `SendEmailActivity`, планируемым при помощи запроса <xref:System.Activities.Tracking.ActivityScheduledQuery>, показаны в следующем примере.

  ```xml
  <activityScheduledQueries>
    <activityScheduledQuery activityName="ProcessNotificationsActivity" childActivityName="SendEmailActivity" />
  </activityScheduledQueries>
  ```

  ```csharp
  TrackingProfile sampleTrackingProfile = new TrackingProfile()
  {
      Name = "Sample Tracking Profile",
      Queries =
      {
          new ActivityScheduledQuery()
          {
              ActivityName = "ProcessNotificationsActivity",
              ChildActivityName = "SendEmailActivity"
          }
      }
  };
  ```

- <xref:System.Activities.Tracking.FaultPropagationQuery> - используйте такой запрос для отслеживания обработки ошибок, возникающих во время действия. Этот запрос необходимо, чтобы участник <xref:System.Activities.Tracking.TrackingParticipant> мог подписаться на объекты <xref:System.Activities.Tracking.FaultPropagationRecord>.

  Конфигурация и код, используемые для подписки на записи, связанные с распространением ошибок при помощи запроса <xref:System.Activities.Tracking.FaultPropagationQuery>, показаны в следующем примере.

  ```xml
  <faultPropagationQueries>
    <faultPropagationQuery faultSourceActivityName="SendEmailActivity" faultHandlerActivityName="NotificationsFaultHandler" />
  </faultPropagationQueries>
  ```

  ```csharp
  TrackingProfile sampleTrackingProfile = new TrackingProfile()
  {
      Name = "Sample Tracking Profile",
      Queries =
      {
          new FaultPropagationQuery()
          {
              FaultSourceActivityName = "SendEmailActivity",
              FaultHandlerActivityName = "NotificationsFaultHandler"
          }
      }
  };
  ```

- <xref:System.Activities.Tracking.CancelRequestedQuery> - используйте этот запрос для отслеживания запросов по отмене дочернего действия родительским действием. Этот запрос необходимо, чтобы участник <xref:System.Activities.Tracking.TrackingParticipant> мог подписаться на объекты <xref:System.Activities.Tracking.CancelRequestedRecord>.

  В следующем примере показана конфигурация и код, используемые для подписки на записи, связанные с отменой действий с помощью <xref:System.Activities.Tracking.CancelRequestedQuery> .

  ```xml
  <cancelRequestedQueries>
    <cancelRequestedQuery activityName="ProcessNotificationsActivity" childActivityName="SendEmailActivity" />
  </cancelRequestedQueries>
  ```

  ```csharp
  TrackingProfile sampleTrackingProfile = new TrackingProfile()
  {
      Name = "Sample Tracking Profile",
      Queries =
      {
          new CancelRequestedQuery()
          {
              ActivityName = "ProcessNotificationsActivity",
              ChildActivityName = "SendEmailActivity"
          }
      }
  };
  ```

- <xref:System.Activities.Tracking.CustomTrackingQuery> - используйте этот запрос для отслеживания событий, определенных в действиях кода. Этот запрос необходимо, чтобы участник <xref:System.Activities.Tracking.TrackingParticipant> мог подписаться на объекты <xref:System.Activities.Tracking.CustomTrackingRecord>.

  Конфигурация и код, используемые для подписки на записи, связанные с пользовательскими записями отслеживания при помощи запроса <xref:System.Activities.Tracking.CustomTrackingQuery>, показаны в следующем примере.

  ```xml
  <customTrackingQueries>
    <customTrackingQuery name="EmailAddress" activityName="SendEmailActivity" />
  </customTrackingQueries>
  ```

  ```csharp
  TrackingProfile sampleTrackingProfile = new TrackingProfile()
  {
      Name = "Sample Tracking Profile",
      Queries =
      {
          new CustomTrackingQuery()
          {
              Name = "EmailAddress",
              ActivityName = "SendEmailActivity"
          }
      }
  };
  ```

- <xref:System.Activities.Tracking.BookmarkResumptionQuery> - используйте этот запрос для отслеживания возобновления закладки в экземпляре рабочего процесса. Этот запрос необходим, чтобы участник <xref:System.Activities.Tracking.TrackingParticipant> мог подписаться на объекты <xref:System.Activities.Tracking.BookmarkResumptionRecord>.

  Конфигурация и код, используемые для подписки на записи, связанные с возобновлением закладок при помощи запроса <xref:System.Activities.Tracking.BookmarkResumptionQuery>, показаны в следующем примере.

  ```xml
  <bookmarkResumptionQueries>
    <bookmarkResumptionQuery name="SentEmailBookmark" />
  </bookmarkResumptionQueries>
  ```

  ```csharp
  TrackingProfile sampleTrackingProfile = new TrackingProfile()
  {
      Name = "Sample Tracking Profile",
      Queries =
      {
          new BookmarkResumptionQuery()
          {
              Name = "sentEmailBookmark"
          }
      }
  };
  ```

### <a name="annotations"></a>Заметки

Заметки позволяют произвольно добавлять теги для записей отслеживания со значением, которое можно изменить после построения. Например, может потребоваться, чтобы несколько записей отслеживания в нескольких рабочих процессах были помечены как "почтовый сервер" = = "почта Server1". Это упростит поиск всех записей с этим тегом при последующем составлении запроса записей отслеживания.

Для этого к запросу отслеживания добавляется заметка, как показано в следующем примере.

```xml
<activityStateQuery activityName="SendEmailActivity">
  <states>
    <state name="Closed"/>
  </states>
  <annotations>
    <annotation name="MailServer" value="Mail Server1"/>
  </annotations>
</activityStateQuery>
```

### <a name="how-to-create-a-tracking-profile"></a>Создание профиля отслеживания

Элементы отслеживания запросов используются для создания профиля отслеживания с помощью XML-файла конфигурации или [!INCLUDE[netfx_current_long](../../../includes/netfx-current-long-md.md)] кода. Ниже приводится пример профиля отслеживания, созданного при помощи файла конфигурации.

```xml
<system.serviceModel>
  <tracking>
    <profiles>
      <trackingProfile name="Sample Tracking Profile ">
        <workflow activityDefinitionId="*">
          <!--Specify the tracking profile query elements to subscribe for tracking records-->
        </workflow>
      </trackingProfile>
    </profiles>
  </tracking>
</system.serviceModel>
```

> [!WARNING]
> Для WF с использованием узла служб рабочих процессов профиль отслеживания обычно создается при помощи файла конфигурации. Также можно создать профиль отслеживания при помощи кода, используя профиль отслеживания и API-интерфейс запросов отслеживания.

Профиль, настроенный как XML-файл конфигурации, применяется к участнику отслеживания при помощи расширения поведения. Он добавляется к WorkflowServiceHost, как описано в следующем разделе [Настройка отслеживания для рабочего процесса](configuring-tracking-for-a-workflow.md).

Детализация записей отслеживания, создаваемых узлом, определяется параметрами конфигурации в профиле отслеживания. Участник отслеживания подписывается на записи отслеживания путем добавления запросов в профиль отслеживания. Чтобы подписываться на все записи отслеживания, профиль отслеживания должен указать все запросы отслеживания, используя " \* " в полях "имя" в каждом запросе.

Ниже приводятся некоторые распространенные примеры профилей отслеживания.

- Профиль отслеживания для получения записей экземпляра рабочего процесса и ошибок.

  ```xml
  <trackingProfile name="Instance and Fault Records">
    <workflow activityDefinitionId="*">
      <workflowInstanceQueries>
        <workflowInstanceQuery>
          <states>
            <state name="*" />
          </states>
        </workflowInstanceQuery>
      </workflowInstanceQueries>
      <activityStateQueries>
        <activityStateQuery activityName="*">
          <states>
            <state name="Faulted"/>
          </states>
        </activityStateQuery>
      </activityStateQueries>
    </workflow>
  </trackingProfile>
  ```

- Профиль отслеживания для получения всех пользовательских записей отслеживания.

  ```xml
  <trackingProfile name="Instance_And_Custom_Records">
    <workflow activityDefinitionId="*">
      <customTrackingQueries>
        <customTrackingQuery name="*" activityName="*" />
      </customTrackingQueries>
    </workflow>
  </trackingProfile>
  ```

## <a name="see-also"></a>См. также

- [Отслеживание SQL](./samples/sql-tracking.md)
- [Мониторинг Windows Server App Fabric](/previous-versions/appfabric/ee677251(v=azure.10))
- [Мониторинг приложений с помощью App Fabric](/previous-versions/appfabric/ee677276(v=azure.10))
