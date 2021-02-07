---
description: 'Дополнительные сведения о: Каллбаккбехавиор'
title: CallbackBehavior
ms.date: 03/30/2017
ms.assetid: 42acd302-2b62-4849-a2d1-a03084343ecd
ms.openlocfilehash: fa9e403324afe818e247d1f751cce0ce7d5a6fb6
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99757765"
---
# <a name="callbackbehavior"></a>CallbackBehavior

CallbackBehavior  
  
## <a name="syntax"></a>Синтаксис  
  
```csharp
class CallbackBehavior : Behavior  
{  
  boolean AutomaticSessionShutdown;  
  string ConcurrencyMode;  
  boolean IgnoreExtensionDataObject;  
  boolean IncludeExceptionDetailInFaults;  
  boolean MaxItemsInObjectGraph;  
  boolean UseSynchronizationContext;  
  boolean ValidateMustUnderstand;  
};  
```  
  
## <a name="methods"></a>Методы  

 Класс CallbackBehavior не определяет никакие методы.  
  
## <a name="properties"></a>Свойства  

 Класс CallbackBehavior имеет следующие свойства.  
  
### <a name="automaticsessionshutdown"></a>AutomaticSessionShutdown  

 Тип данных: boolean  
  
 Тип доступа: только для чтения  
  
 Если сеанс имеет значение true, он автоматически закрывается при закрытии службой дуплексного сеанса.  
  
### <a name="concurrencymode"></a>ConcurrencyMode  

 Тип данных: строка  
Тип доступа: только для чтения  
  
 Указывает, поддерживает служба один поток, несколько потоков или повторные входящие вызовы.  
  
### <a name="ignoreextensiondataobject"></a>IgnoreExtensionDataObject  

 Тип данных: boolean  
  
 Тип доступа: только для чтения  
  
 Значение, указывающее, требуется ли передать неизвестные данные сериализации по сети.  
  
### <a name="includeexceptiondetailinfaults"></a>IncludeExceptionDetailInFaults  

 Тип данных: boolean  
  
 Тип доступа: только для чтения  
  
 Если это свойство включено, подробная информация об исключениях в обратном вызове прикрепляется к ошибкам, возвращаемым в службу.  
  
### <a name="maxitemsinobjectgraph"></a>MaxItemsInObjectGraph  

 Тип данных: boolean  
  
 Тип доступа: только для чтения  
  
 Максимальное количество элементов, допустимое в сериализованном объекте.  
  
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

- <xref:System.ServiceModel.CallbackBehaviorAttribute>
