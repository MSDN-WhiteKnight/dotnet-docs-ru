---
description: 'Дополнительные сведения: <sqlWorkflowInstanceStore>'
title: <sqlWorkflowInstanceStore>
ms.date: 03/30/2017
ms.topic: reference
ms.assetid: 8a4e4214-fc51-4f4d-b968-0427c37a9520
ms.openlocfilehash: 8fcf5dd970adf5aa668d90b012c94e04c5373752
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99782015"
---
# \<sqlWorkflowInstanceStore>

Поведение службы, позволяющее настроить функцию <xref:System.Activities.DurableInstancing.SqlWorkflowInstanceStore>, поддерживающую сохранение сведений о состоянии для экземпляров службы рабочего процесса в базу данных SQL Server 2005 или SQL Server 2008. Дополнительные сведения об этой функции см. в разделе [хранилище экземпляров рабочих процессов SQL](../../../windows-workflow-foundation/sql-workflow-instance-store.md).  
  
[**\<configuration>**](../configuration-element.md)\
&nbsp;&nbsp;[**\<system.ServiceModel>**](system-servicemodel-of-workflow.md)\
&nbsp;&nbsp;&nbsp;&nbsp;[**\<behaviors>**](behaviors-of-workflow.md)\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[**\<serviceBehaviors>**](servicebehaviors-of-workflow.md)\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[**\<behavior>**](behavior-of-servicebehaviors-of-workflow.md)\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**\<sqlWorkflowInstanceStore>**  
  
## <a name="syntax"></a>Синтаксис  
  
```xml  
<behaviors>
  <serviceBehaviors>
    <behavior name="String">
      <sqlWorkflowInstanceStore connectionStringName="String"
                                hostLockRenewalPeriod="TimeSpan"
                                instanceCompletionAction="DeleteNothing/DeleteAll"
                                instanceEncodingAction="None/GZip"
                                instanceLockedExceptionAction="NoRetry/BasicRetry/AggressiveRetry"
                                runnableInstancesDetectionPeriod="TimeSpan" />
    </behavior>
  </serviceBehaviors>
</behaviors>  
```  
  
## <a name="attributes-and-elements"></a>Атрибуты и элементы  

 В следующих разделах описаны атрибуты, дочерние и родительские элементы.  
  
### <a name="attributes"></a>Атрибуты  
  
|Атрибут|Описание|  
|---------------|-----------------|  
|connectionString|Строка, содержащая строку подключения, используемую для соединения с основной базой данной сохраняемости.|  
|connectionStringName|Строка, содержащая именованную строку соединения с сервером базы данных. Примером именованной строки подключения является "DefaultConnectionString".|  
|хостлоккреневалпериод|Значение Timespan, определяющее время, в течение которого узел должен обновить блокировку на экземпляре. Если узел не возобновит блокировку в указанный период времени, то экземпляр будет разблокирован и может быть принят другим узлом.<br /><br /> При выгрузке рабочего процесса подразумевается, что было произведено его сохранение. Если этот атрибут имеет нулевое значение, экземпляр рабочего процесса сохраняется и выгружается сразу после того, как становится неактивным. Если задать этому атрибуту значение TimeSpan.MaxValue, операция выгрузки будет фактически отключена. Простаивающие экземпляры рабочего процесса не выгружаются.|  
|instanceCompletionAction|Значение, которое указывает, будут сохранены данные экземпляра рабочего процесса в хранилище сохраняемости после завершения работы экземпляра рабочего процесса или удалены на этом этапе. Это значение имеет тип <xref:System.Activities.DurableInstancing.InstanceCompletionAction>.<br /><br /> Перечисленные действия состоят из удаления данных экземпляра из хранилища сохраняемости или отказа от удаления данных после завершения операции экземпляром.<br /><br /> Если экземпляры сохраняются после завершения, то это вызывает быстрый рост базы данных постоянного хранения, что влияет на производительность базы данных. Следует настроить политику очищения базы данных для периодического удаления этих записей, чтобы гарантировать уровень производительности базы данных, удовлетворяющий требованиям пользователя.|  
|instanceEncodingOption|Необязательное значение, которое указывает, производится ли сжатие информации о состоянии экземпляра при использовании алгоритма GZip, прежде чем она будет сохранена в хранилище сохраняемости. Это значение имеет тип <xref:System.Activities.DurableInstancing.InstanceEncodingOption>. Для этого свойства возможны значения <xref:System.Activities.DurableInstancing.InstanceEncodingOption.None> , которые не задают сжатие, и <xref:System.Activities.DurableInstancing.InstanceEncodingOption.GZip> , которое указывает, что данные экземпляра сжимаются и используют алгоритм gzip.|  
|instanceLockedExceptionAction|Значение, определяющее действие, которое возникает в ответ на исключение, если узел пытается заблокировать экземпляр, который в настоящий момент заблокирован другим узлом. Это значение имеет тип <xref:System.Activities.DurableInstancing.InstanceLockedExceptionAction>.<br /><br /> Допустимые варианты для данного поля: Нет (None), простой повтор (Basic Retry) и агрессивный повтор (Aggressive Retry). По умолчанию используется None. В следующем списке приводятся описания этих трех вариантов.<br /><br /> — Нет. Узел службы не пытается заблокировать экземпляр и передает исключение <xref:System.Runtime.DurableInstancing.InstanceLockedException> вызывающему.<br />— Обычная повторная попытка. Узел службы повторно пытается заблокировать экземпляр с линейным интервалом повторений и передает исключение вызывающему в конце последовательности.<br />-Агрессивное повторение. Узел службы повторно пытается заблокировать экземпляр (с экспоненциально увеличивающейся задержкой) и передает исключение <xref:System.Runtime.DurableInstancing.InstanceLockedException> вызывающему в конце последовательности.|  
|runnableInstancesDetectionPeriod||  
  
### <a name="child-elements"></a>Дочерние элементы  

 Отсутствует.  
  
### <a name="parent-elements"></a>Родительские элементы  
  
|Элемент|Описание|  
|-------------|-----------------|  
|[\<behavior> из \<serviceBehaviors>](behavior-of-servicebehaviors-of-workflow.md)|Указывает элемент поведения.|  
  
## <a name="see-also"></a>См. также

- <xref:System.ServiceModel.Activities.Description.SqlWorkflowInstanceStoreBehavior>
- <xref:System.ServiceModel.Activities.Configuration.SqlWorkflowInstanceStoreElement>
- <xref:System.Activities.DurableInstancing.SqlWorkflowInstanceStore>
- [Хранилище экземпляров рабочих процессов SQL](../../../windows-workflow-foundation/sql-workflow-instance-store.md)
