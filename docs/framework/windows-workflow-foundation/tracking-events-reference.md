---
description: 'Дополнительные сведения: Справочник по событиям отслеживания'
title: Отслеживание ссылок на события
ms.date: 03/30/2017
ms.assetid: c1c1ee87-f80a-449b-acd0-50d81eef116e
ms.openlocfilehash: 64df938dc7e37ebc8b3da8f10939bebe1e638be1
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99755191"
---
# <a name="tracking-events-reference"></a>Отслеживание ссылок на события

При выполнении рабочего процесса в [!INCLUDE[netfx_current_short](../../../includes/netfx-current-short-md.md)] создаются события отслеживания при переходе его через различные этапы времени существования. Узел можно подписать на эти события, что позволит получать последние сведения о состоянии рабочего процесса на протяжении времени его существования. Создаваемые события отслеживания описываются в этом разделе.  
  
## <a name="event-reference"></a>Ссылка на событие  
  
|Идентификатор события|Уровень события|Сообщение о событии|Keywords|  
|--------------|-----------------|-------------------|--------------|  
|[100 ― WorkflowInstanceRecord](100-workflowinstancerecord.md)|Сведения|TrackRecord=WorkflowInstanceRecord, InstanceId=%1, RecordNumber=%2, EventTime=%3, ActivityDefinitionId=%4, State=%5, Annotations=%6, ProfileName=%7|EndToEndMonitoring, Troubleshooting, HealthMonitoring, WFTracking|  
|[101 ― WorkflowInstanceUnhandledExceptionRecord](101-workflowinstanceunhandledexceptionrecord.md)|Ошибка|TrackRecord=WorkflowInstanceUnhandledExceptionRecord, InstanceId=%1, RecordNumber=%2, EventTime=%3, ActivityDefinitionId=%4, SourceName=%5, SourceId=%6, SourceInstanceId=%7, SourceTypeName=%8, Exception=%9, Annotations=%10, ProfileName=%11|EndToEndMonitoring, Troubleshooting, HealthMonitoring, WFTracking|  
|[102 ― WorkflowInstanceAbortedRecord](102-workflowinstanceabortedrecord.md)|Предупреждение|TrackRecord=WorkflowInstanceAbortedRecord, InstanceId=%1, RecordNumber=%2, EventTime=%3, ActivityDefinitionId=%4, Reason=%5, Annotations=%6, ProfileName=%7|EndToEndMonitoring, Troubleshooting, HealthMonitoring, WFTracking|  
|[103 ― ActivityStateRecord](103-activitystaterecord.md)|Сведения|TrackRecord = ActivityStateRecord, InstanceID = %1, RecordNumber=%2, EventTime=%3, State = %4, Name=%5, ActivityId=%6, ActivityInstanceId=%7, ActivityTypeName=%8, Arguments=%9, Variables=%10, Annotations=%11, ProfileName = %12|EndToEndMonitoring, Troubleshooting, HealthMonitoring, WFTracking|  
|[104 ― ActivityScheduledRecord](104-activityscheduledrecord.md)|Сведения|TrackRecord=ActivityScheduledRecord, InstanceId=%1, RecordNumber=%2, EventTime=%3, Name =%4, ActivityId=%5, ActivityInstanceId=%6, ActivityTypeName=%7, ChildActivityName=%8, ChildActivityId=%9, ChildActivityInstanceId=%10, ChildActivityTypeName=%11, Annotations=%12, ProfileName=%13|EndToEndMonitoring, Troubleshooting, HealthMonitoring, WFTracking|  
|[105 ― FaultPropagationRecord](105-faultpropagationrecord.md)|Предупреждение|TrackRecord = FaultPropagationRecord, InstanceID=%1, RecordNumber=%2, EventTime=%3, FaultSourceActivityName=%4, FaultSourceActivityId=%5, FaultSourceActivityInstanceId=%6, FaultSourceActivityTypeName=%7, FaultHandlerActivityName=%8, FaultHandlerActivityId=%9, FaultHandlerActivityInstanceId=%10, FaultHandlerActivityTypeName=%11, Fault=%12, IsFaultSource=%13, Annotations=%14, ProfileName=%15|EndToEndMonitoring, Troubleshooting, HealthMonitoring, WFTracking|  
|[106 ― CancelRequestRecord](106-cancelrequestrecord.md)|Сведения|TrackRecord=CancelRequestedRecord, InstanceId=%1, RecordNumber=%2, EventTime=%3, Name=%4, ActivityId=%5, ActivityInstanceId=%6, ActivityTypeName=%7, ChildActivityName=%8, ChildActivityId=%9, ChildActivityInstanceId=%10, ChildActivityTypeName=%11, Annotations=%12, ProfileName=%13|EndToEndMonitoring, Troubleshooting, HealthMonitoring, WFTracking|  
|[107 ― BookmarkResumptionRecord](107-bookmarkresumptionrecord.md)|Сведения|TrackRecord=BookmarkResumptionRecord, InstanceId=%1, RecordNumber=%2,EventTime=%3, Name=%4, SubInstanceID=%5, OwnerActivityName=%6, OwnerActivityId=%7, OwnerActivityInstanceId=%8, OwnerActivityTypeName=%9, Annotations=%10, ProfileName=%11|EndToEndMonitoring, Troubleshooting, HealthMonitoring, WFTracking|  
|[108 ― CustomTrackingRecordInfo](108-customtrackingrecordinfo.md)|Сведения|TrackRecord=CustomTrackingRecord, InstanceId=%1, RecordNumber=%2, EventTime=%3, Name=%4, ActivityName=%5, ActivityId=%6, ActivityInstanceId=%7, ActivityTypeName=%8, Data=%9, Annotations=%10, ProfileName=%11|UserEvents, EndToEndMonitoring, Troubleshooting, HealthMonitoring, WFTracking|  
|[110 ― CustomTrackingRecordWarning](110-customtrackingrecordwarning.md)|Предупреждение|TrackRecord=CustomTrackingRecord, InstanceId=%1, RecordNumber=%2, EventTime=%3, Name=%4, ActivityName=%5, ActivityId=%6, ActivityInstanceId=%7, ActivityTypeName=%8, Data=%9, Annotations=%10, ProfileName=%11|UserEvents, EndToEndMonitoring, Troubleshooting, HealthMonitoring, WFTracking|  
|[111 - CustomTrackingRecordError](111-customtrackingrecorderror.md)|Ошибка|TrackRecord=CustomTrackingRecord, InstanceId=%1, RecordNumber=%2, EventTime=%3, Name=%4, ActivityName=%5, ActivityId=%6, ActivityInstanceId=%7, ActivityTypeName=%8, Data=%9, Annotations=%10, ProfileName=%11|UserEvents, EndToEndMonitoring, Troubleshooting, HealthMonitoring, WFTracking|  
|[112 ― WorkflowInstanceSuspendedRecord](112-workflowinstancesuspendedrecord.md)|Сведения|TrackRecord=WorkflowInstanceSuspendedRecord, InstanceId=%1, RecordNumber=%2, EventTime=%3, ActivityDefinitionId=%4, Reason=%5, Annotations=%6, ProfileName=%7|EndToEndMonitoring, Troubleshooting, HealthMonitoring, WFTracking|  
|[113 - WorkflowInstanceTerminatedRecord](113-workflowinstanceterminatedrecord.md)|Ошибка|TrackRecord=WorkflowInstanceTerminatedRecord, InstanceId=%1, RecordNumber=%2, EventTime=%3, ActivityDefinitionId=%4, Reason=%5, Annotations=%6, ProfileName=%7|EndToEndMonitoring, Troubleshooting, HealthMonitoring, WFTracking|  
|[114 - WorkflowInstanceRecordWithId](114-workflowinstancerecordwithid.md)|Сведения|TrackRecord= WorkflowInstanceRecord, InstanceID = %1, RecordNumber = %2, EventTime = %3, ActivityDefinitionId = %4, State = %5, Annotations = %6, ProfileName = %7, WorkflowDefinitionIdentity = %8|HealthMonitoring, WFTracking|  
|[115 - WorkflowInstanceAbortedRecordWithId](115-workflowinstanceabortedrecordwithid.md)|Предупреждение|TrackRecord = WorkflowInstanceAbortedRecord, InstanceID = %1, RecordNumber = %2, EventTime = %3, ActivityDefinitionId = %4, Reason = %5, Annotations = %6, ProfileName = %7, WorkflowDefinitionIdentity = %8|HealthMonitoring, WFTracking|  
|[116 ― WorkflowInstanceSuspendedRecord](116-workflowinstancesuspendedrecordwithid.md)|Сведения|TrackRecord = WorkflowInstanceSuspendedRecord, InstanceID = %1, RecordNumber = %2, EventTime = %3, ActivityDefinitionId = %4, Reason = %5, Annotations = %6, ProfileName = %7, WorkflowDefinitionIdentity = %8|HealthMonitoring, WFTracking|  
|[117 - WorkflowInstanceTerminatedRecordWithId](117-workflowinstanceterminatedrecordwithid.md)|Ошибка|TrackRecord = WorkflowInstanceTerminatedRecord, InstanceID = %1, RecordNumber = %2, EventTime = %3, ActivityDefinitionId = %4, Reason = %5, Annotations = %6, ProfileName = %7, WorkflowDefinitionIdentity = %8|HealthMonitoring, WFTracking|  
|[118 ― WorkflowInstanceUnhandledExceptionRecord](118-workflowinstanceunhandledexceptionrecordwithid.md)|Ошибка|TrackRecord = WorkflowInstanceUnhandledExceptionRecord, InstanceID = %1, RecordNumber = %2, EventTime = %3, ActivityDefinitionId = %4, SourceName = %5, SourceId = %6, SourceInstanceId = %7, SourceTypeName=%8, Exception=%9, Annotations= %10, ProfileName = %11, WorkflowDefinitionIdentity = %12|HealthMonitoring, WFTrackingHealthMonitoring, WFTracking|  
|[119 ― WorkflowInstanceUpdatedRecord](119-workflowinstanceupdatedrecord.md)|Сведения|TrackRecord= WorkflowInstanceUpdatedRecord, InstanceID = %1, RecordNumber = %2, EventTime = %3, ActivityDefinitionId = %4, State = %5, OriginalDefinitionIdentity = %6, UpdatedDefinitionIdentity = %7, Annotations = %8, ProfileName = %9|HealthMonitoring, WFTracking|  
|[225 - TraceCorrelationKeys](225-tracecorrelationkeys.md)|Сведения|Вычисленный ключ корреляции «%1» с использованием значений «%2» в родительской области «%3».|Устранение неполадок для служб WFServices|  
|[440 - StartSignpostEvent1](440-startsignpostevent.md)|Сведения|Граница действия.|Устранение неполадок для служб WFServices|  
|[441 - StopSignpostEvent1](441-stopsignpostevent.md)|Сведения|Граница действия.|Устранение неполадок для служб WFServices|  
|[1001 - WorkflowApplicationCompleted](1001-workflowapplicationcompleted.md)|Сведения|Элемент WorkflowInstance с идентификатором «%1» завершил работу в состоянии Closed.|WFRuntime|  
|[1002 - WorkflowApplicationTerminated](1002-workflowapplicationterminated.md)|Сведения|WorkflowApplication с идентификатором «%1» остановлено. Был прерван в состоянии сбоя с исключением.|WFRuntime|  
|[1003 - WorkflowInstanceCanceled](1003-workflowinstancecanceled.md)|Сведения|Элемент WorkflowInstance с идентификатором «%1» завершил работу в состоянии Canceled.|WFRuntime|  
|[1004 ― WorkflowInstanceAborted](1004-workflowinstanceaborted.md)|Сведения|Выполнение элемента WorkflowInstance с идентификатором «%1» было прервано в результате исключения.|WFRuntime|  
|[1005 - WorkflowApplicationIdled](1005-workflowapplicationidled.md)|Сведения|WorkflowApplication с идентификатором «%1» перешло в состояние простоя.|WFRuntime|  
|[1006 - WorkflowApplicationUnhandledException](1006-workflowapplicationunhandledexception.md)|Ошибка|Элемент WorkflowInstance с идентификатором "%1" обнаружил необработанное исключение.  Исключение произошло из действия "%2", DisplayName: "%3".  Будет выполнено следующее действие: %4.|WFRuntime|  
|[1007 - WorkflowApplicationPersisted](1007-workflowapplicationpersisted.md)|Сведения|Элемент WorkflowApplication с идентификатором «%1» сохранен.|WFRuntime|  
|[1008 - WorkflowApplicationUnloaded](1008-workflowapplicationunloaded.md)|Сведения|Элемент WorkflowInstance с идентификатором «%1» выгружен из памяти.|WFRuntime|  
|[1009 - ActivityScheduled](1009-activityscheduled.md)|Сведения|Родительское действие «%1» (отображаемое имя «%2», ИД экземпляра «%3») запланировало дочернее действие «%4» (отображаемое имя «%5», ИД экземпляра «%6»).|WFRuntime|  
|[1010 - ActivityCompleted](1010-activitycompleted.md)|Сведения|Родительское действие «%1» (отображаемое имя «%2», ИД экземпляра «%3») запланировало дочернее действие «%4» (отображаемое имя «%5», ИД экземпляра «%6»).|WFRuntime|  
|[1011 - ScheduleExecuteActivityWorkItem](1011-scheduleexecuteactivityworkitem.md)|Подробный|ExecuteActivityWorkItem запланирован для действия «%1», DisplayName «%2», InstanceId «%3».|WFRuntime|  
|[1012 - StartExecuteActivityWorkItem](1012-startexecuteactivityworkitem.md)|Подробный|Начато выполнение ExecuteActivityWorkItem для действия «%1», DisplayName «%2», InstanceId «%3».|WFRuntime|  
|[1013 - CompleteExecuteActivityWorkItem](1013-completeexecuteactivityworkitem.md)|Подробный|Завершено выполнение ExecuteActivityWorkItem для действия «%1», DisplayName «%2», InstanceId «%3».|WFRuntime|  
|[1014 - ScheduleCompletionWorkItem](1014-schedulecompletionworkitem.md)|Подробный|Комплетионворкитем был запланирован для родительского действия "%1", DisplayName: "%2", InstanceId: "%3".  Завершено действие «%4», DisplayName «%5», InstanceId «%6».|WFRuntime|  
|[1015 - StartCompletionWorkItem](1015-startcompletionworkitem.md)|Подробный|Начато выполнение CompletionWorkItem для родительского действия «%1», DisplayName «%2», InstanceId «%3». Завершено действие «%4», DisplayName «%5», InstanceId «%6».|WFRuntime|  
|[1016 - CompleteCompletionWorkItem](1016-completecompletionworkitem.md)|Подробный|CompletionWorkItem завершен для родительского действия «%1», DisplayName «%2», InstanceId «%3». Завершено действие «%4», DisplayName «%5», InstanceId «%6».|WFRuntime|  
|[1017 - ScheduleCancelActivityWorkItem](1017-schedulecancelactivityworkitem.md)|Подробный|CancelActivityWorkItem запланирован для действия «%1», DisplayName «%2», InstanceId «%3».|WFRuntime|  
|[1018 - StartCancelActivityWorkItem](1018-startcancelactivityworkitem.md)|Подробный|Начато выполнение CancelActivityWorkItem для действия «%1», DisplayName «%2», InstanceId «%3».|WFRuntime|  
|[1019 - CompleteCancelActivityWorkItem](1019-completecancelactivityworkitem.md)|Подробный|CancelActivityWorkItem завершен для действия «%1», DisplayName «%2», InstanceId «%3».|WFRuntime|  
|[1020 - CreateBookmark](1020-createbookmark.md)|Подробный|Создана закладка для действия "%1", DisplayName: "%2", InstanceId: "%3".  BookmarkName: %4, BookmarkScope: %5.|WFRuntime|  
|[1021 - ScheduleBookmarkWorkItem](1021-schedulebookmarkworkitem.md)|Подробный|Букмаркворкитем был запланирован для действия "%1", DisplayName: "%2", InstanceId: "%3".  BookmarkName: %4, BookmarkScope: %5.|WFRuntime|  
|[1022 - StartBookmarkWorkItem](1022-startbookmarkworkitem.md)|Подробный|Запуск выполнения Букмаркворкитем для действия "%1", DisplayName: "%2", InstanceId: "%3".  BookmarkName: %4, BookmarkScope: %5.|WFRuntime|  
|[1023 - CompleteBookmarkWorkItem](1023-completebookmarkworkitem.md)|Подробный|BookmarkWorkItem завершен для действия «%1», DisplayName «%2», InstanceId «%3». BookmarkName: %4, BookmarkScope: %5.|WFRuntime|  
|[1024 - CreateBookmarkScope](1024-createbookmarkscope.md)|Подробный|Создан объект BookmarkScope: %1.|WFRuntime|  
|[1025 - BookmarkScopeInitialized](1025-bookmarkscopeinitialized.md)|Подробный|Объект BookmarkScope с идентификатором TemporaryId: «%1» инициализирован идентификатором «%2».|WFRuntime|  
|[1026 - ScheduleTransactionContextWorkItem](1026-scheduletransactioncontextworkitem.md)|Подробный|TransactionContextWorkItem запланирован для действия «%1», DisplayName «%2», InstanceId «%3».|WFRuntime|  
|[1027 - StartTransactionContextWorkItem](1027-starttransactioncontextworkitem.md)|Подробный|Начато выполнение TransactionContextWorkItem для родительского действия «%1», DisplayName «%2», InstanceId «%3».|WFRuntime|  
|[1028 - CompleteTransactionContextWorkItem](1028-completetransactioncontextworkitem.md)|Подробный|TransactionContextWorkItem завершен для действия «%1», DisplayName «%2», InstanceId «%3».|WFRuntime|  
|[1029 - ScheduleFaultWorkItem](1029-schedulefaultworkitem.md)|Подробный|Фаултворкитем был запланирован для действия "%1", DisplayName: "%2", InstanceId: "%3".  Исключение распространено из действия «%4», DisplayName «%5», InstanceId «%6».|WFRuntime|  
|[1030 - StartFaultWorkItem](1030-startfaultworkitem.md)|Подробный|Запуск выполнения Фаултворкитем для действия "%1", DisplayName: "%2", InstanceId: "%3".  Исключение распространено из действия «%4», DisplayName «%5», InstanceId «%6».|WFRuntime|  
|[1031 - CompleteFaultWorkItem](1031-completefaultworkitem.md)|Подробный|FaultWorkItem завершено для действия «%1», DisplayName «%2», InstanceId «%3». Исключение распространено из действия «%4», DisplayName «%5», InstanceId «%6».|WFRuntime|  
|[1032 - ScheduleRuntimeWorkItem](1032-scheduleruntimeworkitem.md)|Подробный|Рабочий элемент среды выполнения запланирован для действия «%1», DisplayName «%2», InstanceId «%3».|WFRuntime|  
|[1033 - StartRuntimeWorkItem](1033-startruntimeworkitem.md)|Подробный|Начато выполнение рабочего элемента среды выполнения для действия «%1», DisplayName «%2», InstanceId «%3».|WFRuntime|  
|[1034 - CompleteRuntimeWorkItem](1034-completeruntimeworkitem.md)|Подробный|Рабочий элемент среды выполнения завершен для действия «%1», DisplayName «%2», InstanceId «%3».|WFRuntime|  
|[1035 - RuntimeTransactionSet](1035-runtimetransactionset.md)|Подробный|Транзакция среды выполнения была задана действием "%1", DisplayName: "%2", InstanceId: "%3".  Выполнение изолировано с действием "%4", DisplayName: "%5", InstanceId: "%6".|WFRuntime|  
|[1036 - RuntimeTransactionCompletionRequested](1036-runtimetransactioncompletionrequested.md)|Подробный|Действие «%1», DisplayName «%2», InstanceId «%3» запланировало завершение транзакции времени выполнения.|WFRuntime|  
|[1037 - RuntimeTransactionComplete](1037-runtimetransactioncomplete.md)|Подробный|Транзакция среды выполнения завершена с состоянием «%1».|WFRuntime|  
|[1038 - EnterNoPersistBlock](1038-enternopersistblock.md)|Подробный|Выполняется вход в непостоянный блок.|WFRuntime|  
|[1039 - ExitNoPersistBlock](1039-exitnopersistblock.md)|Подробный|Выполняется выход из непостоянного блока.|WFRuntime|  
|[1040 - InArgumentBound](1040-inargumentbound.md)|Подробный|В аргументе «%1» действия «%2», DisplayName «%3», InstanceId «%4» были связаны со значением %5.|WFActivities|  
|[1041 - WorkflowApplicationPersistableIdle](1041-workflowapplicationpersistableidle.md)|Сведения|Идентификатор WorkflowApplication: "%1" находится в состоянии бездействия и является сохраняемым.  Будет выполнено следующее действие: %2.|WFRuntime|  
|[1101 - WorkflowActivityStart](1101-workflowactivitystart.md)|Сведения|Элемент WorkflowInstance с идентификатором «%1», действие E2E|WFRuntime|  
|[1102 - WorkflowActivityStop](1102-workflowactivitystop.md)|Сведения|Элемент WorkflowInstance с идентификатором «%1», действие E2E|WFRuntime|  
|[1103 - WorkflowActivitySuspend](1103-workflowactivitysuspend.md)|Сведения|Элемент WorkflowInstance с идентификатором «%1», действие E2E|WFRuntime|  
|[1104 - WorkflowActivityResume](1104-workflowactivityresume.md)|Сведения|Элемент WorkflowInstance с идентификатором «%1», действие E2E|WFRuntime|  
|[1124 - InvokeMethodIsStatic](1124-invokemethodisstatic.md)|Сведения|Метод InvokeMethod «%1»: метод является статическим.|WFRuntime|  
|[1125 - InvokeMethodIsNotStatic](1125-invokemethodisnotstatic.md)|Сведения|Метод InvokeMethod «%1»: метод не является статическим.|WFRuntime|  
|[1126 - InvokedMethodThrewException](1126-invokedmethodthrewexception.md)|Сведения|Возникло исключение в методе, вызванном операцией «%1». %2|WFRuntime|  
|[1131 - InvokeMethodUseAsyncPattern](1131-invokemethoduseasyncpattern.md)|Сведения|Метод InvokeMethod «%1»: в методе используется асинхронная модель «%2» и «%3».|WFRuntime|  
|[1132 - InvokeMethodDoesNotUseAsyncPattern](1132-invokemethoddoesnotuseasyncpattern.md)|Сведения|Метод InvokeMethod «%1»: в методе не используется асинхронная модель.|WFRuntime|  
|[1140 - FlowchartStart](1140-flowchartstart.md)|Сведения|Блок-схема «%1»: запуск запланирован.|WFActivities|  
|[1141 - FlowchartEmpty](1141-flowchartempty.md)|Предупреждение|Блок-схема «%1» была выполнена без узлов. Возникло исключение в методе, вызванном операцией «%1». %2|WFActivities|  
|[1143 - FlowchartNextNull](1143-flowchartnextnull.md)|Сведения|Блок-схема «%1»/FlowStep - следующий узел имеет значение NULL. Выполнение блок-схемы будет завершено.|WFActivities|  
|[1146 - FlowchartSwitchCase](1146-flowchartswitchcase.md)|Сведения|Блок-схема «%1»/FlowSwitch: выбран вариант Case «%2».|WFActivities|  
|[1147 - FlowchartSwitchDefault](1147-flowchartswitchdefault.md)|Сведения|Блок-схема «%1»/FlowSwitch: выбрано действие Default Case.|WFActivities|  
|[1148 - FlowchartSwitchCaseNotFound](1148-flowchartswitchcasenotfound.md)|Сведения|Блок-схема «%1»/FlowSwitch - не удалось найти ни действие Case, ни действие Default Case, соответствующее результату выражения Expression. Выполнение блок-схемы будет завершено.|WFActivities|  
|[1150 - CompensationState](1150-compensationstate.md)|Сведения|CompensableActivity «%1» находится в состоянии «%2».|WFActivities|  
|[1223 - SwitchCaseNotFound](1223-switchcasenotfound.md)|Сведения|Действию Switch «%1» не удалось найти действие Case, соответствующее результату выражения Expression.|WFActivities|  
|[1449 - WfMessageReceived](1449-wfmessagereceived.md)|Сведения|Сообщение, полученное рабочим процессом|WFServices|  
|[1450 - WfMessageSent](1450-wfmessagesent.md)|Сведения|Сообщение, отправленное из рабочего процесса|WFServices|  
|[2021 - ExecuteWorkItemStart](2021-executeworkitemstart.md)|Подробный|Запуск выполнения рабочего элемента|WFRuntime|  
|[2022 - ExecuteWorkItemStop](2022-executeworkitemstop.md)|Подробный|Остановка выполнения рабочего элемента|WFRuntime|  
|[2023 - SendMessageChannelCacheMiss](2023-sendmessagechannelcachemiss.md)|Подробный|Промах SendMessageChannelCache|WFRuntime|  
|[2024 - InternalCacheMetadataStart](2024-internalcachemetadatastart.md)|Подробный|InternalCacheMetadata запущено в действии «%1».|WFRuntime|  
|[2025 - InternalCacheMetadataStop](2025-internalcachemetadatastop.md)|Подробный|InternalCacheMetadata остановлено для действия «%1».|WFRuntime|  
|[2026 - CompileVbExpressionStart](2026-compilevbexpressionstart.md)|Подробный|Компиляция выражения VB «%1»|WFRuntime|  
|[2027 - CacheRootMetadataStart](2027-cacherootmetadatastart.md)|Подробный|CacheRootMetadata запущено для действия «%1»|WFRuntime|  
|[2028 - CacheRootMetadataStop](2028-cacherootmetadatastop.md)|Подробный|CacheRootMetadata остановлено для действия %1.|WFRuntime|  
|[2029 - CompileVbExpressionStop](2029-compilevbexpressionstop.md)|Подробный|Компиляция выражения VB завершена.|WFRuntime|  
|[2576 - TryCatchExceptionFromTry](2576-trycatchexceptionfromtry.md)|Сведения|В действии TryCatch «%1» было перехвачено исключение типа «%2».|WFActivities|  
|[2577 - TryCatchExceptionDuringCancelation](2577-trycatchexceptionduringcancelation.md)|Предупреждение|При отмене дочернего действия для действия TryCatch «%1» произошло исключение.|WFActivities|  
|[2578 - TryCatchExceptionFromCatchOrFinally](2578-trycatchexceptionfromcatchorfinally.md)|Предупреждение|В действии Catch или Finally, связанном с действием TryCatch «%1», произошло исключение.|WFActivities|  
|[3501 - InferredContractDescription](3501-inferredcontractdescription.md)|Сведения|Описание ContractDescription с параметрами Name=«%1» и Namespace=«%2» было выведено из WorkflowService.|WFServices|  
|[3502 - InferredOperationDescription](3502-inferredoperationdescription.md)|Сведения|Описание OperationDescription с параметром Name=«%1» в контракте «%2» было выведено из WorkflowService. IsOneWay=%3.|WFServices|  
|[3503 - DuplicateCorrelationQuery](3503-duplicatecorrelationquery.md)|Предупреждение|Обнаружен повторяющийся запрос CorrelationQuery с параметром Where=«%1». Это дубликат не будет использоваться при расчете корреляции.|WFServices|  
|[3507 - ServiceEndpointAdded](3507-serviceendpointadded.md)|Сведения|Конечная точка службы была добавлена для адреса «%1», привязки «%2» и контракта «%3».|WFServices|  
|[3508 - TrackingProfileNotFound](3508-trackingprofilenotfound.md)|Подробный|Не найден TrackingProfile «%1» для ActivityDefinitionId «%2». Профиль TrackingProfile не найден в файле конфигурации, или обнаружено несоответствие ActivityDefinitionId.|WFServices|  
|[3550 - BufferOutOfOrderMessageNoInstance](3550-bufferoutofordermessagenoinstance.md)|Сведения|Операция «%1» сейчас не может быть выполнена. Следующая попытка будет предпринята, когда экземпляр службы будет готов к обработке именно этой операции.|WFServices|  
|[3551 - BufferOutOfOrderMessageNoBookmark](3551-bufferoutofordermessagenobookmark.md)|Сведения|Операция «%2» в экземпляре службы «%1» не может быть выполнена в данный момент. Следующая попытка будет предпринята, когда экземпляр службы будет готов к обработке именно этой операции.|WFServices|  
|[3552 – MaxPendingMessagesPerChannelExceeded](3552-maxpendingmessagesperchannelexceeded.md)|Предупреждение|Был достигнут предел регулирования «MaxPendingMessagesPerChannel» для «%1». Для увеличения этого предела настройте свойство MaxPendingMessagesPerChannel для поведения BufferedReceiveServiceBehavior.|Квота WFServices|  
|[3557 - TransactedReceiveScopeEndCommitFailed](3557-transactedreceivescopeendcommitfailed.md)|Сведения|Вызов EndCommit для CommittableTransaction с id = «%1» привел к созданию исключения TransactionException со следующим сообщением: «%2».|WFServices|  
|[4201 - EndSqlCommandExecute](4201-endsqlcommandexecute.md)|Подробный|Окончание выполнения команды SQL: %1|WFInstanceStore|  
|[4202 - StartSqlCommandExecute](4202-startsqlcommandexecute.md)|Подробный|Запуск выполнения команды SQL: %1|WFInstanceStore|  
|[4203 - RenewLockSystemError](4203-renewlocksystemerror.md)|Ошибка|Не удалось увеличить срок окончания блокировки, срок окончания блокировки уже истек или владелец блокировки удален. Прерывание блокировки SqlWorkflowInstanceStore.|WFInstanceStore|  
|[4205 - FoundProcessingError](4205-foundprocessingerror.md)|Ошибка|Не удалось выполнить команду: %1|WFInstanceStore|  
|[4206 - UnlockInstanceException](4206-unlockinstanceexception.md)|Ошибка|При попытке разблокировать экземпляр обнаружено исключение «%1».|WFInstanceStore|  
|[4207 - MaximumRetriesExceededForSqlCommand](4207-maximumretriesexceededforsqlcommand.md)|Сведения|Выполнено максимальное количество повторов команды SQL. Дальнейшие попытки выполняться не будут.|Квота WFInstanceStore|  
|[4208 - RetryingSqlCommandDueToSqlError](4208-retryingsqlcommandduetosqlerror.md)|Сведения|Выполняется повтор команды SQL из-за ошибки SQL с номером %1.|WFInstanceStore|  
|[4209 - TimeoutOpeningSqlConnection](4209-timeoutopeningsqlconnection.md)|Ошибка|Истекло время ожидания при открытии соединения SQL. Не удалось выполнить операцию за выделенное время ожидания %1. Возможно, выделенное для этой операции время было частью более длительного времени ожидания.|WFInstanceStore|  
|[4210 - SqlExceptionCaught](4210-sqlexceptioncaught.md)|Предупреждение|Обнаружено исключение SQL с номером %1, сообщение %2.|WFInstanceStore|  
|[4211 - QueuingSqlRetry](4211-queuingsqlretry.md)|Предупреждение|Повторная попытка поместить SQL в очередь с задержкой %1 мс.|WFInstanceStore|  
|[4212 - LockRetryTimeout](4212-lockretrytimeout.md)|Предупреждение|Истекло время ожидания при попытке получить блокировку экземпляра.  Не удалось выполнить операцию за выделенное время ожидания %1. Возможно, выделенное для этой операции время было частью более длительного времени ожидания.|WFInstanceStore|  
|[4213 - RunnableInstancesDetectionError](4213-runnableinstancesdetectionerror.md)|Ошибка|Не удалось обнаружить доступные для выполнения экземпляры, поскольку обнаружено следующее исключение|WFInstanceStore|  
|[4214 - InstanceLocksRecoveryError](4214-instancelocksrecoveryerror.md)|Ошибка|Не удалось восстановить блокировки экземпляров, поскольку обнаружено следующее исключение|WFInstanceStore|  
|[39456 - TrackingRecordDropped](39456-trackingrecorddropped.md)|Предупреждение|Размер записи отслеживания %1 превышает максимально допустимое значение, разрешенное в сеансе трассировки событий Windows для поставщика %2|WFTracking|  
|[39457 - TrackingRecordRaised](39457-trackingrecordraised.md)|Сведения|Запись отслеживания %1 повышена до %2.|WFRuntime|  
|[39458 - TrackingRecordTruncated](39458-trackingrecordtruncated.md)|Предупреждение|Усеченная запись отслеживания %1 записана в сеанс трассировки событий Windows с использованием поставщика %2. Данные переменных, заметок, пользователей удалены|WFTracking|  
|[39459 - TrackingDataExtracted](39459-trackingdataextracted.md)|Подробный|Отслеживание данных %1, извлеченных в действии %2.|WFRuntime|  
|[39460 - TrackingValueNotSerializable](39460-trackingvaluenotserializable.md)|Предупреждение|Извлеченный аргумент или переменная «%1» не сериализуется.|WFTracking|  
|[57398 - MaxInstancesExceeded](57398-maxinstancesexceeded.md)|Предупреждение|Система достигла предела, заданного для ограничителя «MaxConcurrentInstances». Для этого ограничителя был задан предел %1. Значение ограничителя можно изменить, изменив атрибут maxConcurrentInstances в элементе serviceThrottle или свойство MaxConcurrentInstances для поведения ServiceThrottlingBehavior.|WFServices|
