---
description: 'Дополнительные сведения о: СервицетоендпоинтассоЦиатион'
title: ServiceToEndpointAssociation
ms.date: 03/30/2017
ms.assetid: 03c3cd15-e1b2-4dc2-bdc2-59fdccdae110
ms.openlocfilehash: 1ae2ce2bcc0b3494b00fffa750f3ca46d26fe08f
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99715344"
---
# <a name="servicetoendpointassociation"></a>ServiceToEndpointAssociation

Сопоставляет службу конечной точке.  
  
## <a name="syntax"></a>Синтаксис  
  
```csharp
class ServiceToEndpointAssociation  
{  
  Service ref;  
  Endpoint ref;  
};  
```  
  
## <a name="methods"></a>Методы  

 Класс ServiceToEndpointAssociation не определяет никаких методов.  
  
## <a name="properties"></a>Свойства  

 Класс ServiceToEndpointAssociation имеет следующие свойства.  
  
### <a name="ref"></a>ref  

 Тип данных: Service  
  
 Тип доступа: только для чтения  
Квалификаторы: ключ  
  
 Служба, связанная с конечной точкой.  
  
### <a name="ref"></a>ref  

 Тип данных: Endpoint  
  
 Тип доступа: только для чтения  
Квалификаторы: ключ  
  
 Конечная точка, связанная со службой.  
  
## <a name="requirements"></a>Требования  
  
|MOF|Объявлено в файле Servicemodel.mof.|  
|---------|-----------------------------------|  
|Пространство имен|Определено в root\ServiceModel.|
