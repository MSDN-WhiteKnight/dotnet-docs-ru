---
description: 'Дополнительные сведения: 1032-Счедулерунтимеворкитем'
title: 1032 - ScheduleRuntimeWorkItem
ms.date: 03/30/2017
ms.assetid: 54688101-becf-42f3-80ca-f53a7b527620
ms.openlocfilehash: d96226b4ab0f856218d292c9c2481bca6c463c8a
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99668049"
---
# <a name="1032---scheduleruntimeworkitem"></a>1032 - ScheduleRuntimeWorkItem

## <a name="properties"></a>Свойства  
  
|||  
|-|-|  
|ID|1032|  
|Keywords|WFRuntime|  
|Level|Подробный|  
|Канал|Microsoft-Windows-Application Server-Applications/Debug|  
  
## <a name="description"></a>Описание  

 Указывает, что элемент RuntimeWorkItem был запланирован.  
  
## <a name="message"></a>Сообщение  

 Рабочий элемент среды выполнения запланирован для действия «%1», DisplayName «%2», InstanceId «%3».  
  
## <a name="details"></a>Сведения  
  
|Имя элемента данных|Тип элемента данных|Описание|  
|--------------------|--------------------|-----------------|  
|Действие|xs:string|Имя типа действия.|  
|DisplayName|xs:string|Отображаемое имя действия.|  
|InstanceId|xs:string|Идентификатор экземпляра действия.|  
|Домен приложения|xs:string|Строка, возвращаемая AppDomain.CurrentDomain.FriendlyName.|
