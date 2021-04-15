---
title: Расширение разметки ComponentResourceKey
ms.date: 03/30/2017
f1_keywords:
- ComponentResourceKey
- ComponentResourceKeyExtension
helpviewer_keywords:
- ComponentResourceKey markup extension [WPF]
- XAML [WPF], ComponentResourceKey markup extension
ms.assetid: d6bcdbe6-61b3-40a7-b381-4e02185b5a85
ms.openlocfilehash: 5f72d6c3273cfda4276383cfe72f90196e5d4340
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59169758"
---
# <a name="componentresourcekey-markup-extension"></a>Расширение разметки ComponentResourceKey
Определяет и ссылается на ключи для ресурсов, загруженные из внешних блоков. Это позволяет при поиске ресурса для указания типа целевого объекта сборки, вместо явного словаря ресурса в сборке или в классе.  
  
## <a name="xaml-attribute-usage-setting-key-compact"></a>Использование атрибута XAML (Установка ключа, compact)  
  
```xml  
<object x:Key="{ComponentResourceKey {x:Type targetTypeName}, targetID}" .../>  
```  
  
## <a name="xaml-attribute-usage-setting-key-verbose"></a>Использование атрибута XAML (Установка ключа, подробный)  
  
```xml  
<object x:Key="{ComponentResourceKey TypeInTargetAssembly={x:Type targetTypeName}, ResourceID=targetID}" .../>  
```  
  
## <a name="xaml-attribute-usage-requesting-resource-compact"></a>Использование атрибута XAML (запрос ресурса, compact)  
  
```xml  
<object property="{DynamicResource {ComponentResourceKey {x:Type targetTypeName}, targetID}}" .../>  
```  
  
## <a name="xaml-attribute-usage-requesting-resource-verbose"></a>Использование атрибута XAML (запрос ресурса, подробный)  
  
```xml  
<object property="{DynamicResource {ComponentResourceKey TypeInTargetAssembly={x:Type targetTypeName}, ResourceID=targetID}}" .../>  
```  
  
## <a name="xaml-values"></a>Значения XAML  
  
|||  
|-|-|  
|`targetTypeName`|Имя открытого CLR тип, определенный в сборке ресурсов.|  
|`targetID`|Ключ ресурса. Когда ресурсы ищутся, `targetID` будут аналогичны [директивы x: Key](../../xaml-services/x-key-directive.md) ресурса.|  
  
## <a name="remarks"></a>Примечания  
 Как показано выше, варианты использования {`ComponentResourceKey`} расширение разметки можно найти в двух местах:  
  
-   Определение ключа в словарь ресурсов темы, предоставленный автором элемента управления.  
  
-   При доступе к ресурсу темы из сборки, являются создания новых шаблонов элемента управления, но хотите использовать значения свойств, поступающие от ресурсов, предоставляемых темы для элемента управления.  
  
 Для ссылки на ресурсы компонента, поступающие от темы, обычно рекомендуется использовать `{DynamicResource}` вместо `{StaticResource}`. Это показано в варианты использования. `{DynamicResource}` рекомендуется, поскольку тема сама по себе может быть изменена пользователем. Если требуется ресурс компонента, который наиболее близко соответствует намерениям автора элемента управления для поддержки темы, следует включить также быть динамической ссылке ресурсов компонента.  
  
 <xref:System.Windows.ComponentResourceKey.TypeInTargetAssembly%2A> Определяет тип, который существует в целевой сборке, где фактически определен ресурс. Объект `ComponentResourceKey` может быть определена и использовать независимо от точно зная, где <xref:System.Windows.ComponentResourceKey.TypeInTargetAssembly%2A> определен, но в конечном счете, необходимо разрешить тип с помощью указанных сборок.  
  
 Распространенным вариантом применения для <xref:System.Windows.ComponentResourceKey> заключается в определении ключи, которые далее представляются в виде членов класса. Для данного использования можно использовать <xref:System.Windows.ComponentResourceKey> конструктора класса, не расширения разметки. Дополнительные сведения см. в разделе <xref:System.Windows.ComponentResourceKey>, или в разделе «Определение и создание ссылок на ключи для темы ресурсов» раздела [Общие сведения о разработке управления](../controls/control-authoring-overview.md).  
  
 Для установки ключей и ссылки на с ключом ресурсы, синтаксис атрибутов обычно используется для `ComponentResourceKey` расширение разметки.  
  
 Зависит от compact синтаксис, показанный <xref:System.Windows.ComponentResourceKey.%23ctor%2A?displayProperty=nameWithType> сигнатура конструктора и использование позиционного параметра расширения разметки. Порядок, в котором `targetTypeName` и `targetID` получают важен. Подробный синтаксис зависит от <xref:System.Windows.ComponentResourceKey.%23ctor%2A?displayProperty=nameWithType> конструктор по умолчанию, а затем устанавливает <xref:System.Windows.ComponentResourceKey.TypeInTargetAssembly%2A> и <xref:System.Windows.ComponentResourceKey.ResourceId%2A> способом, который является аналогом true синтаксис объектного элемента. В подробном синтаксисе порядок, в котором задаются свойства не имеет значения. Связь и механизмы из этих двух вариантов (компактный и verbose) описан более подробно в разделе [расширения разметки и XAML WPF](markup-extensions-and-wpf-xaml.md).  
  
 С технической точки зрения значение `targetID` может быть любой объект, у нее не в виде строки. Тем не менее, оно наиболее распространенных в WPF используется для выравнивания `targetID` значение с помощью форм, представляют собой строки, и если такие строки допустимы в [Грамматика XamlName](../../xaml-services/xamlname-grammar.md).  
  
 `ComponentResourceKey` может использоваться в синтаксисе элемента объекта. В этом случае укажите значение параметра оба <xref:System.Windows.ComponentResourceKey.TypeInTargetAssembly%2A> и <xref:System.Windows.ComponentResourceKey.ResourceId%2A> свойства, необходимые для правильной инициализации расширения.  
  
 В WPF XAML реализацию средства чтения, обработка данного расширения разметки определяется <xref:System.Windows.ComponentResourceKey> класса.  
  
 `ComponentResourceKey` является расширением разметки. Расширения разметки обычно реализуются, если требуется заменить значения атрибутов на нелитеральные значения или имена обработчиков и если требуется больше, чем простая настройка преобразователей типов на работу с определенными типами или свойствами. Все расширения разметки в XAML используют символы "{" и "}" в синтаксисе их атрибутов, который является соглашением, по которому обработчик XAML распознает, что расширение разметки должно обработать атрибут. Дополнительные сведения см. в разделе [Расширения разметки и XAML WPF](markup-extensions-and-wpf-xaml.md).  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.ComponentResourceKey>
- <xref:System.Windows.Controls.ControlTemplate>
- [Общие сведения о разработке элементов управления](../controls/control-authoring-overview.md)
- [Обзор XAML (WPF)](xaml-overview-wpf.md)
- [Расширения разметки и XAML WPF](markup-extensions-and-wpf-xaml.md)
