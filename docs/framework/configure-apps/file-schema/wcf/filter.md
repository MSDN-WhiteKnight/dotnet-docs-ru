---
description: 'Дополнительные сведения: <filter>'
title: <filter>
ms.date: 03/30/2017
ms.assetid: 3266700b-904b-44e4-93a7-e06a1a445100
ms.openlocfilehash: 993d2265ac3a714475e8cbe9e8a2c3f93c46bde2
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99664682"
---
# \<filter>

Определяет фильтр маршрутизации, определяющий тип Windows Communication Foundation (WCF), который <xref:System.ServiceModel.Dispatcher.MessageFilter> будет использоваться при оценке входящих сообщений, а также любые вспомогательные данные или параметры, необходимые для фильтра.

[**\<system.serviceModel>**](system-servicemodel.md)\
&nbsp;&nbsp;[**\<routing>**](routing.md)\
&nbsp;&nbsp;&nbsp;&nbsp;[**\<filters>**](filters-of-routing.md)\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**\<filter>**  
  
## <a name="syntax"></a>Синтаксис  
  
```xml  
<routing>
  <filters>
    <filter customType="String"
            filterData="String"
            filterType="Action/Address/AddressPrefix/And/Custom/Endpoint/MatchAll/XPath"
            name="String" />
  </filters>
</routing>
```  
  
## <a name="attributes-and-elements"></a>Элементы и атрибуты

В следующих разделах описаны атрибуты, дочерние и родительские элементы.

### <a name="attributes"></a>Атрибуты

| Атрибут  | Описание |
| ---------- | ----------- |
| customType | Строка, содержащая полное имя для пользовательского типа, используемого в качестве фильтра. Если параметр `filterType` имеет значение `custom` , этот атрибут содержит полное имя типа создаваемого класса.  `filterData` может также содержать значения, используемые при вычислении настраиваемого фильтра типов. |
| filterData | Строка, содержащая данные фильтра. Дополнительные сведения об указании этого атрибута см. в разделе <xref:System.ServiceModel.Routing.Configuration.FilterElement.FilterData%2A>. |
| filterType | Строка, содержащая тип фильтра. Этот атрибут имеет тип <xref:System.ServiceModel.Routing.Configuration.FilterType>.  Дополнительные сведения о том, как это работает с атрибутом `filterData`, см. в разделе <xref:System.ServiceModel.Routing.Configuration.FilterElement.FilterData%2A>. |
| name       | Строка, содержащая уникальное имя этого элемента фильтра. |

### <a name="child-elements"></a>Дочерние элементы

Отсутствует.

### <a name="parent-elements"></a>Родительские элементы

| Элемент | Описание |
| ------- | ----------- |
| [\<routing>](routing.md) | Раздел конфигурации для определения набора фильтров маршрутизации, которые определяют тип Windows Communication Foundation (WCF), <xref:System.ServiceModel.Dispatcher.MessageFilter> используемый при оценке входящих сообщений. |

## <a name="see-also"></a>См. также

- <xref:System.ServiceModel.Routing.Configuration.FilterElement?displayProperty=nameWithType>
- <xref:System.ServiceModel.Routing.Configuration.FilterElement.FilterData%2A?displayProperty=nameWithType>
- <xref:System.ServiceModel.Routing.Configuration.FilterType?displayProperty=nameWithType>
