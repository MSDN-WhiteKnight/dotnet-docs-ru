---
title: Расширение разметки StaticResource
ms.date: 03/30/2017
f1_keywords:
- StaticResource
- StaticResourceExtension
helpviewer_keywords:
- XAML [WPF], StaticResource markup extension
- StaticResource markup extensions [WPF]
ms.assetid: 97af044c-71f1-4617-9a94-9064b68185d2
ms.openlocfilehash: 8319e451268152e95326c02027157db72df631b8
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59125150"
---
# <a name="staticresource-markup-extension"></a>Расширение разметки StaticResource
Предоставляет значение для любого [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] свойства атрибута, посмотрев на ссылку на уже заданного ресурса. Поведение подстановки для этого ресурса аналогичен во время загрузки, который будет искать ресурсы, которые были ранее загружены из разметки текущего [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] странице, а также других источников приложения и автоматически создаст значение ресурсов как значение свойства в объектах во время выполнения.  
  
## <a name="xaml-attribute-usage"></a>Использование атрибута XAML  
  
```xml  
<object property="{StaticResource key}" .../>  
```  
  
## <a name="xaml-object-element-usage"></a>Использование элемента объекта XAML  
  
```xml  
<object>  
  <object.property>  
<StaticResource ResourceKey="key" .../>  
  </object.property>  
</object>  
```  
  
## <a name="xaml-values"></a>Значения XAML  
  
|||  
|-|-|  
|`key`|Ключ для запрашиваемого ресурса. Этот ключ была изначально назначена по [директивы x: Key](../../xaml-services/x-key-directive.md) Если ресурс был создан в разметке или был предоставлен в виде `key` параметра при вызове <xref:System.Windows.ResourceDictionary.Add%2A?displayProperty=nameWithType> Если ресурс был создан в коде.|  
  
## <a name="remarks"></a>Примечания  
  
> [!IMPORTANT]
>  Объект `StaticResource` не следует пытаться сделать прямую ссылку на ресурс, определенный лексически далее в [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] файл. Попытка выполнить такую операцию не поддерживается, и даже если эта ссылка не произойдет сбой, попытка прямой ссылки повлечет снижение производительности во время загрузки при внутренней хэш-таблиц, представляющих <xref:System.Windows.ResourceDictionary> производится поиск. Для получения наилучших результатов настройте композицию словарей ресурсов таким образом, что можно избежать прямых ссылок. Если не удается избежать опережающие ссылки, используйте [расширение разметки DynamicResource](dynamicresource-markup-extension.md) вместо этого.  
  
 Указанный <xref:System.Windows.StaticResourceExtension.ResourceKey%2A> должен соответствовать имеющийся ресурс, определенный с помощью [директивы x: Key](../../xaml-services/x-key-directive.md) на определенном уровне страницы, приложения, доступный элемент управления темы и внешним ресурсам или системных ресурсов. Поиск ресурсов происходит в указанном порядке. Дополнительные сведения о поведение подстановки ресурса для статических и динамических ресурсов, см. в разделе [ресурсы XAML](xaml-resources.md).  
  
 Ключ ресурса может быть любой строкой, определенные в [Грамматика XamlName](../../xaml-services/xamlname-grammar.md). Ключ ресурса также может быть других типов объектов, таких как <xref:System.Type>. Объект <xref:System.Type> ключ — это основа для элементов управления можно стилями темы, через ключ неявного стиля. Дополнительные сведения см. в разделе [Общие сведения о разработке элементов управления](../controls/control-authoring-overview.md).  
  
 Декларативные альтернативные методы ссылкой на ресурс — как [расширение разметки DynamicResource](dynamicresource-markup-extension.md).  
  
 Синтаксис атрибутов является наиболее распространенным синтаксисом, используемым с этим расширением разметки. Строковая лексема, указываемая после строки идентификатора `StaticResource`, присваивается в качестве значения <xref:System.Windows.StaticResourceExtension.ResourceKey%2A> соответствующего класса расширения <xref:System.Windows.StaticResourceExtension>.  
  
 `StaticResource` может использоваться в синтаксисе элемента объекта. В этом случае укажите значение параметра <xref:System.Windows.StaticResourceExtension.ResourceKey%2A> свойство является обязательным.  
  
 `StaticResource` Можно также использовать в использовании атрибут verbose, который указывает <xref:System.Windows.StaticResourceExtension.ResourceKey%2A> как свойство = значение пары:  
  
```xml  
<object property="{StaticResource ResourceKey=key}" .../>  
```  
  
 Подробное определение зачастую удобно использовать для расширений, которые имеют несколько устанавливаемых свойств, а также в том случае, если некоторые свойства являются необязательными. Так как `StaticResource` имеет только одно устанавливаемое свойство, которое является обязательным, это использование не является типичным.  
  
 В WPF [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] реализации обработчика обработка данного расширения разметки определяется <xref:System.Windows.StaticResourceExtension> класса.  
  
 `StaticResource` является расширением разметки. Расширения разметки обычно реализуются, если требуется заменить значения атрибутов на нелитеральные значения или имена обработчиков и если требуется больше, чем простая настройка преобразователей типов на работу с определенными типами или свойствами. Все расширения разметки в [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] используют символы "{" и "}" в синтаксисе их атрибутов, который является соглашением, по которому обработчик [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] распознает, что расширение разметки должно обработать атрибут. Дополнительные сведения см. в разделе [Расширения разметки и XAML WPF](markup-extensions-and-wpf-xaml.md).  
  
## <a name="see-also"></a>См. также

- [Стилизация и использование шаблонов](../controls/styling-and-templating.md)
- [Обзор XAML (WPF)](xaml-overview-wpf.md)
- [Расширения разметки и XAML WPF](markup-extensions-and-wpf-xaml.md)
- [Ресурсы XAML](xaml-resources.md)
- [Ресурсы и код](resources-and-code.md)
