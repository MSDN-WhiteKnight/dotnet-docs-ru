---
description: Дополнительные сведения см. в статье Настройка сохраняемости с помощью WorkflowServiceHost.
title: Практическое руководство. Как настроить сохраняемость с помощью WorkflowServiceHost
ms.date: 03/30/2017
ms.assetid: e31cd4df-13a3-4a9a-9be8-5243e0055356
ms.openlocfilehash: 79945fb791cc25bdf362302fa884636942fb5692
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99780041"
---
# <a name="how-to-configure-persistence-with-workflowservicehost"></a>Практическое руководство. Как настроить сохраняемость с помощью WorkflowServiceHost

В данном разделе описывается способ настройки функции хранилища экземпляров рабочих процессов SQL для включения сохраняемости рабочих процессов, размещенных в <xref:System.ServiceModel.Activities.WorkflowServiceHost>, с помощью файла конфигурации. Перед использованием возможности хранилища экземпляров рабочих процессов SQL необходимо создать базу данных SQL, которая используется для хранения экземпляров рабочих процессов. Дополнительные сведения см. [в разделе инструкции. Включение сохраняемости SQL для рабочих процессов и служб рабочих](../../windows-workflow-foundation/how-to-enable-sql-persistence-for-workflows-and-workflow-services.md)процессов.  
  
### <a name="to-configure-the-sql-workflow-instance-store-in-configuration"></a>Настройка хранилища экземпляров рабочих процессов SQL в конфигурации  
  
1. Свойства хранилища экземпляров рабочих процессов SQL можно настроить с помощью объекта <xref:System.ServiceModel.Activities.Description.SqlWorkflowInstanceStoreBehavior> - поведения службы, позволяющего менять параметры с помощью конфигурации XML. В следующем примере конфигурации показано, как настроить хранилище экземпляров рабочих процессов SQL с помощью `sqlWorkflowInstanceStore` элемента поведения <> в файле конфигурации.  
  
    ```xml  
    <serviceBehaviors>  
        <behavior name="">  
            <sqlWorkflowInstanceStore
                 connectionString="provider=System.Data.SqlClient;Data Source=(local);Initial Catalog=DefaultPersistenceProviderDb;Integrated Security=True;Async=true"  
                 instanceEncodingOption="GZip | None"  
                 instanceCompletionAction="DeleteAll | DeleteNothing"  
                 instanceLockedExceptionAction="NoRetry | SimpleRetry | AggressiveRetry"  
                 hostLockRenewalPeriod="00:00:30"
                 runnableInstancesDetectionPeriod="00:00:05">  
            </sqlWorkflowInstanceStore>  
        </behavior>  
    </serviceBehaviors>  
    ```  
  
     Дополнительные сведения о настройке хранилища экземпляров рабочих процессов SQL см. [в разделе инструкции. Включение сохраняемости SQL для рабочих процессов и служб рабочих](../../windows-workflow-foundation/how-to-enable-sql-persistence-for-workflows-and-workflow-services.md)процессов. Дополнительные сведения об отдельных параметрах `sqlWorkflowInstanceStore` элемента поведения <> см. в разделе [хранилище экземпляров рабочих процессов SQL](../../windows-workflow-foundation/sql-workflow-instance-store.md). Фабрика приложений Windows Server имеет собственное хранилище сохраняемости. Дополнительные сведения см. в статье [сохраняемость в Windows Server App Fabric](/previous-versions/appfabric/ee677272(v=azure.10)).  
  
    > [!NOTE]
    > В предыдущем примере конфигурации используется упрощенная конфигурация. Дополнительные сведения см. в разделе [упрощенная конфигурация](../simplified-configuration.md) .  
  
### <a name="to-configure-the-sql-workflow-instance-store-in-code"></a>Настройка хранилища экземпляров рабочих процессов SQL в коде  
  
1. Свойства хранилища экземпляров рабочих процессов SQL можно настроить с помощью объекта <xref:System.ServiceModel.Activities.Description.SqlWorkflowInstanceStoreBehavior>, определяющего поведение службы, позволяющее менять параметры с помощью кода. В следующем примере показано, как настроить хранилище экземпляров рабочих процессов SQL с помощью элемента поведения <xref:System.ServiceModel.Activities.Description.SqlWorkflowInstanceStoreBehavior> в коде.  
  
    ```csharp  
    host.Description.Behaviors.Add(new SqlWorkflowInstanceStoreBehavior  
    {  
       ConnectionString = "provider=System.Data.SqlClient;Data Source=(local);Initial Catalog=DefaultPersistenceProviderDb;Integrated Security=True;Async=true",  
       InstanceEncodingOption = "GZip | None",  
       InstanceCompletionAction = "DeleteAll | DeleteNothing",  
       InstanceLockedExceptionAction = "NoRetry | SimpleRetry | AggressiveRetry",  
       HostLockRenewalPeriod = new TimeSpan(00, 00, 30),  
       RunnableInstancesDetectionPeriod = new TimeSpan(00, 00, 05)  
    });  
    ```  
  
     Дополнительные сведения о настройке хранилища экземпляров рабочих процессов SQL см. [в разделе инструкции. Включение сохраняемости SQL для рабочих процессов и служб рабочих](../../windows-workflow-foundation/how-to-enable-sql-persistence-for-workflows-and-workflow-services.md)процессов. Дополнительные сведения об отдельных параметрах <xref:System.ServiceModel.Activities.Description.SqlWorkflowInstanceStoreBehavior> элемента Behavior см. в разделе [хранилище экземпляров рабочих процессов SQL](../../windows-workflow-foundation/sql-workflow-instance-store.md). Фабрика приложений Windows Server имеет собственное хранилище сохраняемости. Дополнительные сведения см. в статье [сохраняемость в Windows Server App Fabric](/previous-versions/appfabric/ee677272(v=azure.10)).  
  
    > [!NOTE]
    > В предыдущем примере конфигурации используется упрощенная конфигурация. Дополнительные сведения см. в разделе [упрощенная конфигурация](../simplified-configuration.md) .  
  
     Пример настройки сохраняемости программным способом см. в разделе [Включение сохраняемости для рабочих процессов и служб рабочих](../../windows-workflow-foundation/how-to-enable-persistence-for-workflows-and-workflow-services.md)процессов.  
  
## <a name="see-also"></a>См. также

- [Службы рабочего процесса](workflow-services.md)
- [Сохраняемость рабочего процесса](../../windows-workflow-foundation/workflow-persistence.md)
- [Сохраняемость Windows Server App Fabric](/previous-versions/appfabric/ee677272(v=azure.10))
