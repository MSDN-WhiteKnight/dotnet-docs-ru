---
description: 'Дополнительные сведения: 1013-Комплетиксекутеактивитиворкитем'
title: 1013 - CompleteExecuteActivityWorkItem
ms.date: 03/30/2017
ms.assetid: 31fc57b3-ef2f-48f0-a5de-b4e2c5c9ded7
ms.openlocfilehash: 815f859c40a02e8c06e44603a80ab964dc4e64bd
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99792951"
---
# <a name="1013---completeexecuteactivityworkitem"></a>1013 - CompleteExecuteActivityWorkItem

## <a name="properties"></a>Свойства  
  
|||  
|-|-|  
|ID|1013|  
|Keywords|WFRuntime|  
|Level|Подробный|  
|Канал|Microsoft-Windows-Application Server-Applications/Debug|  
  
## <a name="description"></a>Описание  

 Указывает, что ExecuteActivityWorkItem завершено  
  
## <a name="message"></a>Сообщение  

 Завершено выполнение ExecuteActivityWorkItem для действия «%1», DisplayName «%2», InstanceId «%3».  
  
## <a name="details"></a>Сведения  
  
|Имя элемента данных|Тип элемента данных|Описание|  
|--------------------|--------------------|-----------------|  
|Действие|xs:string|Имя типа действия.|  
|DisplayName|xs:string|Отображаемое имя действия.|  
|InstanceId|xs:string|Идентификатор экземпляра действия.|  
|Домен приложения|xs:string|Строка, возвращаемая AppDomain.CurrentDomain.FriendlyName.|
