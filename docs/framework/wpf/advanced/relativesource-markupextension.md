---
title: Расширение разметки RelativeSource
ms.date: 03/30/2017
f1_keywords:
- RelativeSource
helpviewer_keywords:
- RelativeSource markup extensions [WPF]
- XAML [WPF], RelativeSource markup extension
ms.assetid: 26be4721-49b5-4717-a92e-7d54ad0d3a81
ms.openlocfilehash: a6a7d615a3a54fbc75bb86b295fdf80433a31dc5
ms.sourcegitcommit: 5137208fa414d9ca3c58cdfd2155ac81bc89e917
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/06/2019
ms.locfileid: "57476338"
---
# <a name="relativesource-markupextension"></a>Расширение разметки RelativeSource

Задает свойства <xref:System.Windows.Data.RelativeSource> источника привязки, которые будут использоваться в [расширения разметки привязки](binding-markup-extension.md), или при задании <xref:System.Windows.Data.Binding.RelativeSource%2A> свойство <xref:System.Windows.Data.Binding> определенного в XAML.

## <a name="xaml-attribute-usage"></a>Использование атрибута XAML

```xml
<Binding RelativeSource="{RelativeSource modeEnumValue}" .../>
```

## <a name="xaml-attribute-usage-nested-within-binding-extension"></a>Использование атрибута XAML (вложенный в расширение Binding)

```xml
<object property="{Binding RelativeSource={RelativeSource modeEnumValue} ...}" .../>
```

## <a name="xaml-object-element-usage"></a>Использование элемента объекта XAML

```xml
<Binding>
  <Binding.RelativeSource>
    <RelativeSource Mode="modeEnumValue"/>
  </Binding.RelativeSource>
</Binding>
```

- или -

```xml
<Binding>
  <Binding.RelativeSource>
    <RelativeSource
      Mode="FindAncestor"
      AncestorType="{x:Type typeName}"
      AncestorLevel="intLevel"
    />
  </Binding.RelativeSource>
</Binding>
```

## <a name="xaml-values"></a>Значения XAML

|||
|-|-|
|`modeEnumValue`|Один из следующих вариантов:<br /><br /> -Строковая лексема `Self`; соответствует <xref:System.Windows.Data.RelativeSource> , созданного с помощью его <xref:System.Windows.Data.RelativeSource.Mode%2A> свойство значение <xref:System.Windows.Data.RelativeSourceMode.Self>.<br />-Строковая лексема `TemplatedParent`; соответствует <xref:System.Windows.Data.RelativeSource> , созданного с помощью его <xref:System.Windows.Data.RelativeSource.Mode%2A> свойство значение <xref:System.Windows.Data.RelativeSourceMode.TemplatedParent>.<br />-Строковая лексема `PreviousData`; соответствует <xref:System.Windows.Data.RelativeSource> , созданного с помощью его <xref:System.Windows.Data.RelativeSource.Mode%2A> свойство значение <xref:System.Windows.Data.RelativeSourceMode.PreviousData>.<br />-Сведения см. ниже на `FindAncestor` режим.|
|`FindAncestor`|Строковая лексема `FindAncestor`. Использовании этой лексемы осуществляет переход в режим, где `RelativeSource` задает тип предка и (при необходимости) уровень предка. Это соответствует <xref:System.Windows.Data.RelativeSource> при создании со свойством <xref:System.Windows.Data.RelativeSource.Mode%2A>, для которого задано значение <xref:System.Windows.Data.RelativeSourceMode.FindAncestor>.|
|`typeName`|Требуется для режима `FindAncestor`. Имя типа, которое заполняет свойство <xref:System.Windows.Data.RelativeSource.AncestorType%2A>.|
|`intLevel`|Необязательно для режима `FindAncestor`. Уровень предка (вычисляется в направлении родителя в логическом дереве).|

## <a name="remarks"></a>Примечания

`{RelativeSource TemplatedParent}` Использование привязки — это ключевая методика, которая решает большего размера концепцию разделения элемента управления пользовательского интерфейса и логики элемента управления. Это делает возможным привязку из определения шаблона к созданному по шаблону родительскому элементу (экземпляр объекта времени выполнения, в котором применяется шаблон). В этом случае [расширения разметки TemplateBinding](templatebinding-markup-extension.md) на самом деле является сокращением для следующего выражения привязки: `{Binding RelativeSource={RelativeSource TemplatedParent}}`. `TemplateBinding` или `{RelativeSource TemplatedParent}` использования включены только соответствующие в XAML, который определяет шаблон. Дополнительные сведения см. в разделе [расширения разметки TemplateBinding](templatebinding-markup-extension.md)

`{RelativeSource FindAncestor}` является главным образом используется в шаблонах элементов управления или прогнозируемый автономных композициях пользовательского интерфейса, для случаев, где элемент управления всегда должен быть в визуальном дереве определенного типа предка. Например, элементы в элементе управления элементами могут использовать вхождения `FindAncestor` для привязки к свойствам предка элемента управления элементами. Либо элементы, которые являются частью композиции элемента управления в шаблоне, могут использовать привязки `FindAncestor` к родительским элементам в той же структуре композиции.

В синтаксисе объектного элемента для режима `FindAncestor`, показанного выше в разделах синтаксиса XAML, второй синтаксис объектного элемента используется специально для режима `FindAncestor`. Режим `FindAncestor` требует значения <xref:System.Windows.Data.RelativeSource.AncestorType%2A>. Необходимо задать <xref:System.Windows.Data.RelativeSource.AncestorType%2A> как атрибут [расширение разметки x: Type](../../xaml-services/x-type-markup-extension.md) ссылка на тип искомого предка. Значение <xref:System.Windows.Data.RelativeSource.AncestorType%2A> используется при обработке запроса привязки во время выполнения.

Для режима `FindAncestor` необязательное свойство <xref:System.Windows.Data.RelativeSource.AncestorLevel%2A> может помочь устранить неоднозначность поиска предка в случаях, где в дереве элементов, возможно, существует более одного предка данного типа.

Дополнительные сведения об использовании режима `FindAncestor` см. в разделе <xref:System.Windows.Data.RelativeSource>.

`{RelativeSource Self}` полезно для сценариев, где одно свойство экземпляра должно зависеть от значения другого свойства и тот же экземпляр, и нет общего отношения свойства зависимостей (например, приведение) уже существует между этими двумя свойствами. Хотя изредка случается, что в объекте существует два свойства, таким образом, значения буквально одинаковыми (и идентичными типами), также можно применить `Converter` параметр привязку, в которой `{RelativeSource Self}`и использовать этот преобразователь выполнить преобразование между исходной и типы целевых объектов. Другой сценарий для `{RelativeSource Self}` как часть <xref:System.Windows.MultiDataTrigger>.

Например, следующий код XAML определяет такой элемент <xref:System.Windows.Shapes.Rectangle>, что независимо от того, какое значение вводится для свойства <xref:System.Windows.FrameworkElement.Width%2A>, объектом <xref:System.Windows.Shapes.Rectangle> всегда является квадрат: `<Rectangle Width="200" Height="{Binding RelativeSource={RelativeSource Self}, Path=Width}" .../>`

`{RelativeSource PreviousData}` используется в шаблонах данных, или в случаях, когда привязки используют коллекцию в качестве источника данных. Можно использовать `{RelativeSource PreviousData}` для выделения связей между соседними элементами данных в коллекции. Соответствующей методикой является установление привязки <xref:System.Windows.Data.MultiBinding> между текущим и предыдущим элементами в источнике данных и использование преобразователя в этой привязке для определения различия между двумя элементами и их свойствами.

В следующем примере первый элемент <xref:System.Windows.Controls.TextBlock> в шаблоне элементов отображает текущий номер. Второй <xref:System.Windows.Controls.TextBlock> привязка является <xref:System.Windows.Data.MultiBinding> которая номинально состоит двух <xref:System.Windows.Data.Binding> составляющих: текущей записи и привязки, в которой намеренно используется предыдущая запись данных с помощью `{RelativeSource PreviousData}`. Затем преобразователь в объекте <xref:System.Windows.Data.MultiBinding> вычисляет разницу и возвращает ее в привязку.

```xml
<ListBox Name="fibolist">
    <ListBox.ItemTemplate>
        <DataTemplate>
            <StackPanel Orientation="Horizontal">
            <TextBlock Text="{Binding}"/>
            <TextBlock>, difference = </TextBlock>
                <TextBlock>
                    <TextBlock.Text>
                        <MultiBinding Converter="{StaticResource DiffConverter}">
                            <Binding/>
                            <Binding RelativeSource="{RelativeSource PreviousData}"/>
                        </MultiBinding>
                    </TextBlock.Text>
                </TextBlock>
            </StackPanel>
        </DataTemplate>
    </ListBox.ItemTemplate>
```

Описание привязки данных, так как не рассматриваются здесь, см. в разделе [Общие сведения о привязке данных](../data/data-binding-overview.md).

В [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] реализации обработчика XAML обработка данного расширения разметки определяется <xref:System.Windows.Data.RelativeSource> класса.

`RelativeSource` является расширением разметки. Расширения разметки обычно реализуются, если требуется заменить значения атрибутов на нелитеральные значения или имена обработчиков и если требуется больше, чем простая настройка преобразователей типов на работу с определенными типами или свойствами. Все расширения разметки в XAML используют `{` и `}` символов в синтаксисе их атрибутов, который является соглашением, по которому обработчик XAML узнает, что расширение разметки должно обработать атрибут. Дополнительные сведения см. в разделе [Расширения разметки и XAML WPF](markup-extensions-and-wpf-xaml.md).

## <a name="see-also"></a>См. также

- <xref:System.Windows.Data.Binding>
- [Стилизация и использование шаблонов](../controls/styling-and-templating.md)
- [Общие сведения о языке XAML (WPF)](xaml-overview-wpf.md)
- [Расширения разметки и XAML WPF](markup-extensions-and-wpf-xaml.md)
- [Общие сведения о привязке данных](../data/data-binding-overview.md)
- [Общие сведения об объявлении привязок](../data/binding-declarations-overview.md)
- [Расширение разметки x:Type](../../xaml-services/x-type-markup-extension.md)
