---
description: 'Дополнительные сведения: <service>'
title: <service>
ms.date: 03/30/2017
ms.assetid: 13123dd6-c4a9-4a04-a984-df184b851788
ms.openlocfilehash: c3870a170847d773996625235c75591ced75e315
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99786789"
---
# \<service>

Элемент `service` содержит параметры для службы Windows Communication Foundation (WCF). Он также содержит конечные точки, предоставляющие доступ к службе.  
  
[**\<configuration>**](../configuration-element.md)\
&nbsp;&nbsp;[**\<system.serviceModel>**](system-servicemodel.md)\
&nbsp;&nbsp;&nbsp;&nbsp;[**\<services>**](services.md)\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**\<service>**  
  
## <a name="syntax"></a>Синтаксис  
  
```xml  
<service behaviorConfiguration="String"
         name="String">
</service>
```  
  
## <a name="attributes-and-elements"></a>Атрибуты и элементы  

 В следующих разделах описаны атрибуты, дочерние и родительские элементы.  
  
### <a name="attributes"></a>Атрибуты  
  
|Атрибут|Описание|  
|---------------|-----------------|  
|behaviorConfiguration|Строка, содержащая имя поведения, которое следует использовать для создания экземпляра службы. Имя поведения должно входить в область действия в точке определения службы. Значение по умолчанию - пустая строка.|  
|name|Требуемый строковый атрибут, указывающий тип службы, экземпляр которой создается. Этот параметр должен иметь значение допустимого типа. Формат должен быть `Namespace.Class.`.|  
  
### <a name="child-elements"></a>Дочерние элементы  
  
|Элемент|Описание|  
|-------------|-----------------|  
|[\<endpoint>](endpoint-element.md)|Коллекция элементов `endpoint`, которые обеспечивают доступ к данной службе.|  
|[\<host>](host.md)|Задает узел данного экземпляра службы. Это элемент типа <xref:System.ServiceModel.Configuration.HostElement>.|  
  
### <a name="parent-elements"></a>Родительские элементы  
  
|Элемент|Описание|  
|-------------|-----------------|  
|[\<services>](services.md)|Корневой элемент всех элементов конфигурации WCF.|  
  
## <a name="remarks"></a>Remarks  

 Службы задаются в разделе `services` файла конфигурации. Сборка может содержать любое число служб. Для каждой службы используется собственный раздел конфигурации `service`. В этом разделе определяются контракт, поведение и конечные точки конкретной службы.  
  
 Элемент `behaviorConfiguration` также является необязательным. Он указывает поведение, используемое службой. Поведение, заданное в данном атрибуте, должно быть связано с поведением в области в том же файле конфигурации.  
  
 Каждая служба предоставляет доступ к одной или нескольким конечным точкам, которые имеют собственные адреса и привязки. Все привязки в файле конфигурации должны быть определены в области файла. Привязки связаны с конечными точками с помощью сочетания атрибутов `name` и `bindingConfiguration`. Атрибут `name` описывает раздел, в котором определена привязка. Атрибут `bindingConfiguration` указывает, какая конфигурация из раздела привязок используется. В разделе привязки может определяться несколько конфигураций.  
  
## <a name="example"></a>Пример  

 Ниже приведен пример конфигурации службы.  
  
```xml  
<service behaviorConfiguration="testChannelBehavior"
         name="HelloWorld">
  <endpoint address="/HelloWorld2/"
            name="test"
            bindingNamespace="http://www.cohowinery.com/"
            binding="basicHttpBinding"
            contract="IHelloWorld" />
</service>
```  
  
## <a name="see-also"></a>См. также

- <xref:System.ServiceModel.Configuration.ServiceElement>
- [Настройка служб](../../../wcf/configuring-services.md)
