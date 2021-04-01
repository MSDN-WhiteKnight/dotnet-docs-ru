---
title: Привязка расширения разметки
ms.date: 03/30/2017
f1_keywords:
- Binding
helpviewer_keywords:
- Binding markup extensions [WPF]
- XAML [WPF], Binding markup extension
ms.assetid: 83d6e2a4-1b0c-4fc8-bd96-b5e98800ab63
ms.openlocfilehash: 3455c7ccdedb432fc05c7dc9e80f0f7509f4fa0c
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59170317"
---
# <a name="binding-markup-extension"></a>Привязка расширения разметки
Откладывает значение свойства значением привязкой к данным, создавая объект промежуточного выражения и интерпретируя контекст данных, который применяется к элементу и его привязке во время выполнения.  
  
## <a name="binding-expression-usage"></a>Использование выражений привязки  
  
```  
<object property="{Binding}" .../>  
-or-  
<object property="{Binding  bindProp1=value1[, bindPropN=valueN]*}" ...  
/>  
-or-  
<object property="{Binding path}" .../>  
-or  
<object property="{Binding path[, bindPropN=valueN]*}" .../>  
```  
  
## <a name="syntax-notes"></a>Заметки о синтаксисе  
 В этих синтаксисов `[]` и `*` не являются литералами. Они являются частью нотации, чтобы указать, что ноль или более *платформы*`=`*значение* пар, можно создать с помощью `,` разделитель между ними и предыдущими *платформы*  `=` *значение* пары.  
  
 Каких-либо свойств, перечисленных в разделе «Привязка свойства, можно будет задать с расширением Binding» может вместо этого задать с помощью атрибутов <xref:System.Windows.Data.Binding> объектного элемента. Тем не менее, не является полноценным использование расширения разметки из <xref:System.Windows.Data.Binding>, это просто XAML обработки атрибутов, задайте свойства среды CLR <xref:System.Windows.Data.Binding> класса. Другими словами `<Binding` *Свойство_привязки_1*`="`*значение1* `"[` *bindPropN*`="`*valueN* `"]*/>` — это эквивалентный синтаксис атрибутов <xref:System.Windows.Data.Binding> объекта использование элемента вместо `Binding` использование выражений. Дополнительные сведения об использовании атрибута XAML конкретные свойства <xref:System.Windows.Data.Binding>, см. в разделе «Использование атрибута XAML» соответствующие свойства <xref:System.Windows.Data.Binding> в библиотеке классов .NET Framework.  
  
## <a name="xaml-values"></a>Значения XAML  
  
|||  
|-|-|  
|`bindProp1, bindPropN`|Имя <xref:System.Windows.Data.Binding> или <xref:System.Windows.Data.BindingBase> задаваемого свойства. Не все <xref:System.Windows.Data.Binding> свойства можно задать с помощью `Binding` расширения и некоторые свойства могут устанавливаться в `Binding` выражение только с помощью дополнительные вложенные расширения разметки. Ознакомьтесь с разделом «Привязка свойства, можно будет задать с расширением Binding».|  
|`value1, valueN`|Задаваемое значение свойства. Способ обработки значения атрибута в конечном счете, характерные для типа и логики конкретную <xref:System.Windows.Data.Binding> задаваемое свойство.|  
|`path`|Строка пути, который задает неявный <xref:System.Windows.Data.Binding.Path%2A?displayProperty=nameWithType> свойство. См. также [синтаксис PropertyPath XAML](propertypath-xaml-syntax.md).|  
  
## <a name="unqualified-binding"></a>Неполное {Binding}  
 `{Binding}` Использовании в «Использование выражений привязки» создает <xref:System.Windows.Data.Binding> объекта со значениями по умолчанию, включая начальные <xref:System.Windows.Data.Binding.Path%2A?displayProperty=nameWithType> из `null`. Это по-прежнему полезно во многих сценариях, поскольку созданный <xref:System.Windows.Data.Binding> может полагаться на ключевых свойств привязки например <xref:System.Windows.Data.Binding.Path%2A?displayProperty=nameWithType> и <xref:System.Windows.Data.Binding.Source%2A?displayProperty=nameWithType> задаваемое в контекст данных времени выполнения. Дополнительные сведения о концепцию контекста данных, см. в разделе [привязки данных](../data/data-binding-wpf.md).  
  
## <a name="implicit-path"></a>Неявный путь  
 `Binding` Использует расширение разметки <xref:System.Windows.Data.Binding.Path%2A?displayProperty=nameWithType> как концептуальной «свойство по умолчанию», где `Path=` должен появляться в выражении. Если указать `Binding` выражение с неявный путь неявный путь должно быть первым в выражении, до любого другого `bindProp` = `value` где <xref:System.Windows.Data.Binding> свойство указано по имени. Например: `{Binding PathString}`, где `PathString` — это строка, значение которого будет значение <xref:System.Windows.Data.Binding.Path%2A?displayProperty=nameWithType> в <xref:System.Windows.Data.Binding> созданные расширения разметки. Можно добавить неявный путь с другими именованными свойствами после разделителя запятую, к примеру, `{Binding LastName, Mode=TwoWay}`.  
  
## <a name="binding-properties-that-can-be-set-with-the-binding-extension"></a>Свойства привязки, которые можно задать с помощью расширения привязки  
 Синтаксис, показанный в этом разделе использует универсальный `bindProp` = `value` аппроксимацией, поскольку имеется много свойств чтения и записи из <xref:System.Windows.Data.BindingBase> или <xref:System.Windows.Data.Binding> , можно задать с помощью `Binding` расширение разметки / синтаксис выражения. Они могут задаваться в любом порядке, за исключением неявным <xref:System.Windows.Data.Binding.Path%2A?displayProperty=nameWithType>. (Вы можете в явном виде `Path=`, в этом случае его можно установить в любом порядке). По сути, можно задать ноль или несколько свойств в списке ниже, с помощью `bindProp` = `value` пар, разделенных запятыми.  
  
 Некоторые из этих значений свойств требуют типы объектов, которые не поддерживает собственный тип преобразование из текстового синтаксиса в XAML и таким образом требуется расширения разметки, чтобы задать в качестве значения атрибута. Проверьте в разделе "Использование атрибута XAML" в библиотеке классов .NET Framework для каждого свойства, Дополнительные сведения; Строка, используйте синтаксис атрибута XAML с или без дальнейшего расширения разметки использования является по сути таким же, как значение, указываемое в `Binding` выражения, за исключением, не размещайте кавычки вокруг каждой `bindProp` = `value` в `Binding` выражение.  
  
-   <xref:System.Windows.Data.BindingBase.BindingGroupName%2A>: строка, определяющая группу возможных привязки. Это — это понятие сравнительно сложный привязки; см. в разделе справочника, посвященных <xref:System.Windows.Data.BindingBase.BindingGroupName%2A>.  
  
-   <xref:System.Windows.Data.Binding.BindsDirectlyToSource%2A>: Логическое значение может быть либо `true` или `false`. Значение по умолчанию — `false`.  
  
-   <xref:System.Windows.Data.Binding.Converter%2A>: можно задать в качестве `bindProp` = `value` строки в выражении, но для этого требуется ссылка на объект для значения, такие как [расширение разметки StaticResource](staticresource-markup-extension.md). В этом случае, значение является экземпляром класса пользовательский преобразователь.  
  
-   <xref:System.Windows.Data.Binding.ConverterCulture%2A>: может задаваться в выражение в виде идентификатора на основе стандартов; см. в разделе справки по <xref:System.Windows.Data.Binding.ConverterCulture%2A>.  
  
-   <xref:System.Windows.Data.Binding.ConverterParameter%2A>: можно задать в качестве `bindProp` = `value` строки в выражение, но это зависит от типа параметра, переданного. Если передача ссылочного типа для значения, это использование требуется ссылка на объект, например вложенный [расширение разметки StaticResource](staticresource-markup-extension.md).  
  
-   <xref:System.Windows.Data.Binding.ElementName%2A>: взаимно исключают друг друга и <xref:System.Windows.Data.Binding.RelativeSource%2A> и <xref:System.Windows.Data.Binding.Source%2A>; каждый из этих свойств привязки представляет определенную методологию привязки. См. в разделе [Общие сведения о привязке данных](../data/data-binding-overview.md).  
  
-   <xref:System.Windows.Data.BindingBase.FallbackValue%2A>: можно задать в качестве `bindProp` = `value` строки в выражение, но это зависит от типа передаваемого значения. Если передача ссылочного типа, требуется ссылка на объект, например вложенный [расширение разметки StaticResource](staticresource-markup-extension.md).  
  
-   <xref:System.Windows.Data.Binding.IsAsync%2A>: Логическое значение может быть либо `true` или `false`. Значение по умолчанию — `false`.  
  
-   <xref:System.Windows.Data.Binding.Mode%2A>: *значение* является именем константы из <xref:System.Windows.Data.BindingMode> перечисления. Например, `{Binding Mode=OneWay}`.  
  
-   <xref:System.Windows.Data.Binding.NotifyOnSourceUpdated%2A>: Логическое значение может быть либо `true` или `false`. Значение по умолчанию — `false`.  
  
-   <xref:System.Windows.Data.Binding.NotifyOnTargetUpdated%2A>: Логическое значение может быть либо `true` или `false`. Значение по умолчанию — `false`.  
  
-   <xref:System.Windows.Data.Binding.NotifyOnValidationError%2A>: Логическое значение может быть либо `true` или `false`. Значение по умолчанию — `false`.  
  
-   <xref:System.Windows.Data.Binding.Path%2A>: строка, описывающая пути в объекте данных или общих объектов модели. Формат предоставляет несколько разных соглашений для обхода объектной модели, который не может быть адекватно описан в этом разделе. См. в разделе [синтаксис PropertyPath XAML](propertypath-xaml-syntax.md).  
  
-   <xref:System.Windows.Data.Binding.RelativeSource%2A>: взаимно исключают друг друга и с <xref:System.Windows.Data.Binding.ElementName%2A> и <xref:System.Windows.Data.Binding.Source%2A>; каждый из этих свойств привязки представляет определенную методологию привязки. См. в разделе [Общие сведения о привязке данных](../data/data-binding-overview.md). Требуется вложенный [расширение разметки RelativeSource](relativesource-markupextension.md) использования для указания значения.  
  
-   <xref:System.Windows.Data.Binding.Source%2A>: взаимно исключают друг друга и <xref:System.Windows.Data.Binding.RelativeSource%2A> и <xref:System.Windows.Data.Binding.ElementName%2A>; каждый из этих свойств привязки представляет определенную методологию привязки. См. в разделе [Общие сведения о привязке данных](../data/data-binding-overview.md). Обычно требуется использование вложенного расширения, [расширение разметки StaticResource](staticresource-markup-extension.md) , ссылающийся на источник данных объекта из словаря ресурсов с ключом.  
  
-   <xref:System.Windows.Data.BindingBase.StringFormat%2A>: строка, описывающая соглашение формат строки для связанных данных. Это — это понятие сравнительно сложный привязки; см. в разделе справочника, посвященных <xref:System.Windows.Data.BindingBase.StringFormat%2A>.  
  
-   <xref:System.Windows.Data.BindingBase.TargetNullValue%2A>: можно задать в качестве `bindProp` = `value` строки в выражение, но это зависит от типа параметра, переданного. Если передача ссылочного типа для значения, требуется ссылка на объект, например вложенный [расширение разметки StaticResource](staticresource-markup-extension.md).  
  
-   <xref:System.Windows.Data.Binding.UpdateSourceTrigger%2A>: *значение* является именем константы из <xref:System.Windows.Data.UpdateSourceTrigger> перечисления. Например, `{Binding UpdateSourceTrigger=LostFocus}`. Потенциально определенные элементы управления имеют разные значения по умолчанию для этого свойства привязки. См. раздел <xref:System.Windows.Data.Binding.UpdateSourceTrigger%2A>.  
  
-   <xref:System.Windows.Data.Binding.ValidatesOnDataErrors%2A>: Логическое значение может быть либо `true` или `false`. Значение по умолчанию — `false`. См. заметки.  
  
-   <xref:System.Windows.Data.Binding.ValidatesOnExceptions%2A>: Логическое значение может быть либо `true` или `false`. Значение по умолчанию — `false`. См. заметки.  
  
-   <xref:System.Windows.Data.Binding.XPath%2A>: строка, описывающая путь в XMLDOM из источника данных XML. См. в разделе [привязка к данным XML с помощью XMLDataProvider и запросов XPath](../data/how-to-bind-to-xml-data-using-an-xmldataprovider-and-xpath-queries.md).  
  
 Ниже приведены свойства <xref:System.Windows.Data.Binding> , нельзя задать с помощью `Binding` расширение разметки /`{Binding}` форма выражения.  
  
-   <xref:System.Windows.Data.Binding.UpdateSourceExceptionFilter%2A>: это свойство ожидает, что ссылка на реализацию обратного вызова. Обратные вызовы и методы, отличные от обработчиков событий нельзя ссылаться в синтаксисе XAML.  
  
-   <xref:System.Windows.Data.Binding.ValidationRules%2A>: свойство принимает базовую коллекцию <xref:System.Windows.Controls.ValidationRule> объектов. Это можно выразить как элемент свойства в <xref:System.Windows.Data.Binding> объект элемента, но имеет не доступны метод разбора атрибута для использования в `Binding` выражение. См. в разделе справочника по <xref:System.Windows.Data.Binding.ValidationRules%2A>.  
  
-   <xref:System.Windows.Data.Binding.XmlNamespaceManager%2A>  
  
## <a name="remarks"></a>Примечания  
  
> [!IMPORTANT]
>  С точки зрения приоритет свойств зависимостей `Binding` выражение эквивалентно локально заданное значение. Если вы задано локальное значение для свойства, которое ранее было `Binding` выражения, `Binding` полностью удаляется. Дополнительные сведения см. в разделе [Приоритет значений свойств зависимостей](dependency-property-value-precedence.md).  
  
 Описание привязки данных на базовом уровне не рассматривается в этом разделе. См. в разделе [Общие сведения о привязке данных](../data/data-binding-overview.md).  
  
> [!NOTE]
>  <xref:System.Windows.Data.MultiBinding> и <xref:System.Windows.Data.PriorityBinding> не поддерживают XAML синтаксиса расширения. Можно использовать свойства элементов. См. в разделе справочные разделы по <xref:System.Windows.Data.MultiBinding> и <xref:System.Windows.Data.PriorityBinding>.  
  
 Логические значения для XAML учитывается регистр. Например можно указать либо `{Binding NotifyOnValidationError=true}` или `{Binding NotifyOnValidationError=True}`.  
  
 Привязки, которые включают в себя проверку данных обычно определяются явно `Binding` элемент, а не как `{Binding ...}` выражения, а параметр <xref:System.Windows.Data.Binding.ValidatesOnDataErrors%2A> или <xref:System.Windows.Data.Binding.ValidatesOnExceptions%2A> в выражении используется редко. Это обусловлено дополнительное свойство <xref:System.Windows.Data.Binding.ValidationRules%2A> невозможно легко задать в виде выражения. Дополнительные сведения см. в разделе [проверки привязки реализуют](../data/how-to-implement-binding-validation.md).  
  
 `Binding` является расширением разметки. Расширения разметки обычно реализуются, если требуется заменить значения атрибутов на нелитеральные значения или обработчик имена и если требуется более, чем преобразователи типов с атрибутами для определенных типов или свойств. Все расширения разметки в XAML используют `{` и `}` символов в синтаксисе их атрибутов, который является соглашением, по которому обработчик XAML узнает, что расширение разметки должно обработать содержимое строки. Дополнительные сведения см. в разделе [Расширения разметки и XAML WPF](markup-extensions-and-wpf-xaml.md).  
  
 `Binding` является расширением нетипичное разметки тем, что <xref:System.Windows.Data.Binding> класс, реализующий функциональные возможности расширения для реализации XAML в WPF также реализует несколько методов и свойств, которые не связаны с XAML. Другие элементы призваны сделать <xref:System.Windows.Data.Binding> более гибким, автономное класс, который можно решить многие сценарии привязки данных в дополнение к работает как расширение разметки XAML.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Data.Binding>
- [Общие сведения о привязке данных](../data/data-binding-overview.md)
- [Обзор XAML (WPF)](xaml-overview-wpf.md)
- [Расширения разметки и XAML WPF](markup-extensions-and-wpf-xaml.md)
