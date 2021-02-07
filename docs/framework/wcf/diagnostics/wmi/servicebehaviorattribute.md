---
description: 'Дополнительные сведения о: ServiceBehaviorAttribute'
title: ServiceBehaviorAttribute
ms.date: 03/30/2017
ms.assetid: 5faa266f-587f-4e03-828d-1c7dd5acfe65
ms.openlocfilehash: 57ffa9103523618db752b3be6d43bb16603d1728
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99715578"
---
# <a name="servicebehaviorattribute"></a>ServiceBehaviorAttribute

ServiceBehaviorAttribute  
  
## <a name="syntax"></a>Синтаксис  
  
```csharp
class ServiceBehaviorAttribute : Behavior  
{  
  boolean AutomaticSessionShutdown;  
  string ConcurrencyMode;  
  string ConfigurationName;  
  boolean IgnoreExtensionDataObject;  
  boolean IncludeExceptionDetailInFaults;  
  string InstanceContextMode;  
  sint32 MaxItemsInObjectGraph;  
  string Name;  
  string Namespace;  
  boolean ReleaseServiceInstanceOnTransactionComplete;  
  boolean TransactionAutoCompleteOnSessionClose;  
  string TransactionIsolationLevel;  
  datetime TransactionTimeout;  
  boolean UseSynchronizationContext;  
  boolean ValidateMustUnderstand;  
};  
```  
  
## <a name="methods"></a>Методы  

 Класс ServiceBehaviorAttribute не определяет никаких методов.  
  
## <a name="properties"></a>Свойства  

 Класс ServiceBehaviorAttribute имеет следующие свойства.  
  
### <a name="automaticsessionshutdown"></a>AutomaticSessionShutdown  

 Тип данных: boolean  
  
 Тип доступа: только для чтения  
  
 Указывает, следует ли автоматически закрывать сеанс, когда клиент закрывает выходной сеанс.  
  
### <a name="concurrencymode"></a>ConcurrencyMode  

 Тип данных: строка  
Тип доступа: только для чтения  
  
 Указывает, поддерживает служба один поток, несколько потоков или повторные входящие вызовы.  
  
### <a name="configurationname"></a>ConfigurationName  

 Тип данных: строка  
  
 Тип доступа: только для чтения  
  
 Имя конфигурации службы.  
  
### <a name="ignoreextensiondataobject"></a>IgnoreExtensionDataObject  

 Тип данных: boolean  
  
 Тип доступа: только для чтения  
  
 Указывает, требуется ли передать неизвестные данные сериализации по сети.  
  
### <a name="includeexceptiondetailinfaults"></a>IncludeExceptionDetailInFaults  

 Тип данных: boolean  
  
 Тип доступа: только для чтения  
  
 Указывает, включать ли информацию об управляемых исключениях в сведения об ошибках SOAP, возвращаемые клиентам для отладки.  
  
### <a name="instancecontextmode"></a>InstanceContextMode  

 Тип данных: строка  
  
 Тип доступа: только для чтения  
  
 Указывает, когда создается новый объект службы.  
  
### <a name="maxitemsinobjectgraph"></a>MaxItemsInObjectGraph  

 Тип данных: sint32  
  
 Тип доступа: только для чтения  
  
 Максимальное количество элементов, допустимое в сериализованном объекте.  
  
### <a name="name"></a>Имя  

 Тип данных: строка  
  
 Тип доступа: только для чтения  
  
 Имя атрибута службы в WSDL.  
  
### <a name="namespace"></a>Пространство имен  

 Тип данных: строка  
  
 Тип доступа: только для чтения  
  
 Целевое пространство имен службы в WSDL.  
  
### <a name="releaseserviceinstanceontransactioncomplete"></a>ReleaseServiceInstanceOnTransactionComplete  

 Тип данных: boolean  
  
 Тип доступа: только для чтения  
  
 Указывает, производится ли повторное использование объекта службы после завершения текущей транзакции.  
  
### <a name="transactionautocompleteonsessionclose"></a>TransactionAutoCompleteOnSessionClose  

 Тип данных: boolean  
  
 Тип доступа: только для чтения  
  
 Указывает, завершаются ли ожидающие транзакции при закрытии текущего сеанса.  
  
### <a name="transactionisolationlevel"></a>TransactionIsolationLevel  

 Тип данных: строка  
  
 Тип доступа: только для чтения  
  
 Указывает уровень изоляции транзакции.  
  
### <a name="transactiontimeout"></a>TransactionTimeout  

 Тип данных: datetime  
  
 Тип доступа: только для чтения  
  
 Период времени, в течение которого транзакция должна быть завершена.  
  
### <a name="usesynchronizationcontext"></a>UseSynchronizationContext  

 Тип данных: boolean  
  
 Тип доступа: только для чтения  
  
 Указывает, использовать ли текущий контекст синхронизации для выбора потока выполнения.  
  
### <a name="validatemustunderstand"></a>ValidateMustUnderstand  

 Тип данных: boolean  
  
 Тип доступа: только для чтения  
  
 Указывает, кем выполняется принудительная обработка заголовка SOAP MustUnderstand: системой или приложением.  
  
## <a name="requirements"></a>Требования  
  
|MOF|Объявлено в файле Servicemodel.mof.|  
|---------|-----------------------------------|  
|Пространство имен|Определено в root\ServiceModel.|  
  
## <a name="see-also"></a>См. также

- <xref:System.ServiceModel.ServiceBehaviorAttribute>
