---
description: 'Дополнительные сведения: <parameter>'
title: <parameter>
ms.date: 03/30/2017
ms.assetid: 0fb41e2d-64f7-44ab-993e-05892eac6d82
ms.openlocfilehash: fb04cfb5bf451cdb99c23ae41ea8fafeb13f0d11
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99683818"
---
# \<parameter>

Указывает общий параметр, если объявленный тип является общим типом.  
  
[**\<configuration>**](../configuration-element.md)\
&nbsp;&nbsp;[**\<system.runtime.serialization>**](system-runtime-serialization.md)\
&nbsp;&nbsp;&nbsp;&nbsp;[**\<dataContractSerializer>**](datacontractserializer.md)\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[**\<declaredTypes>**](declaredtypes.md)\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[**\<add>**](add-of-declaredtypes-element.md)\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[**\<knownType>**](knowntype.md)\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**\<parameter>**  
  
## <a name="syntax"></a>Синтаксис  
  
```xml  
<parameter index="Integer"
           type="String" />
```  
  
## <a name="attributes-and-elements"></a>Атрибуты и элементы  

 В следующих разделах описаны атрибуты, дочерние и родительские элементы.  
  
### <a name="attributes"></a>Атрибуты  
  
|Атрибут|Описание|  
|---------------|-----------------|  
|index|Если объявленный тип является общим типом, указывает общий параметр, который возвращает известный тип.|  
|тип|Строка, которая описывает известный тип, используемый для сериализации и десериализации.|  
  
## <a name="index-attribute"></a>Атрибут index  
  
|Значение|Описание|  
|-----------|-----------------|  
|"0"|Первый параметр в общем типе. Например, у <xref:System.Collections.Generic.List%601> есть только один параметр. Если он используется как объявленный тип, индексу присваивается значение 0.|  
|"1"|Второй параметр в общем типе. Например, у <xref:System.Collections.Generic.Dictionary%602> есть два параметра. Если известный тип возвращается вторым параметром, атрибуту index присваивается значение 1.|  
  
### <a name="child-elements"></a>Дочерние элементы  

 Отсутствует.  
  
### <a name="parent-elements"></a>Родительские элементы  
  
|Элемент|Описание|  
|-------------|-----------------|  
|[\<knownType>](knowntype.md)|Указывает известный тип, который может возвращаться полем или свойством объявленного типа.|  
  
## <a name="remarks"></a>Remarks  

 Дополнительные сведения об известных типах см. в статье о [известных типах контрактов данных](../../../wcf/feature-details/data-contract-known-types.md) и <xref:System.Runtime.Serialization.DataContractSerializer> .  
  
 [\<dataContractSerializer>](datacontractserializer-element.md)Пример использования этого элемента см. в разделе.  
  
 У данного элемента конфигурации не может одновременно быть оба атрибута. Если заданы оба атрибута, возникает исключение <xref:System.Configuration.ConfigurationErrorsException>.  
  
## <a name="see-also"></a>См. также

- <xref:System.Runtime.Serialization.DataContractSerializer>
- [Известные типы контрактов данных](../../../wcf/feature-details/data-contract-known-types.md)
- [\<dataContractSerializer>](datacontractserializer-element.md)
- [\<add>](add-of-declaredtypes-element.md)
