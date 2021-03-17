---
title: Синтаксис DateTime XAML
ms.date: 03/30/2017
helpviewer_keywords:
- DateTime XAML syntax [WPF], strings for
- DateTime XAML syntax [WPF], where used
- short date format [WPF], DateTime
- DateTime XAML syntax [WPF]
- DateTime XAML text [WPF]
- DateTime XAML syntax [WPF], format strings for
ms.assetid: 5901710a-609b-40c8-9d65-f0016cd9090b
ms.openlocfilehash: d7fe5f15f79ab068e88c3fb6f7b7cac0986aa636
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59146501"
---
# <a name="datetime-xaml-syntax"></a>Синтаксис DateTime XAML
Некоторые элементы управления, такие как <xref:System.Windows.Controls.Calendar> и <xref:System.Windows.Controls.DatePicker>, имеют свойства, использующие <xref:System.DateTime> типа. Несмотря на то что начальные дата и время для этих элементов управления обычно указываются в коде программной части во время выполнения, их можно указать в коде XAML. Средство синтаксического анализа XAML WPF обрабатывает анализ <xref:System.DateTime> значения с помощью встроенных текстового синтаксиса XAML. В этом разделе описаны особенности <xref:System.DateTime> синтаксис текста XAML.  

<a name="where_datetime_xaml_syntax_is_used"></a>   
## <a name="when-to-use-datetime-xaml-syntax"></a>Когда требуется использовать синтаксис DateTime XAML  
 Задание дат в XAML не всегда обязательно, а иногда даже может быть нежелательно. Например, можно использовать <xref:System.DateTime.Now%2A?displayProperty=nameWithType> свойство для инициализации даты во время выполнения, или сделать все корректировки дат для календаря в коде программной части на основе ввода пользователя. Однако существуют сценарии, где можно жестко закодировать даты в <xref:System.Windows.Controls.Calendar> и <xref:System.Windows.Controls.DatePicker> в шаблоне элемента управления. <xref:System.DateTime> Необходимо использовать синтаксис XAML для этих сценариев.  
  
### <a name="datetime-xaml-syntax-is-a-native-behavior"></a>Синтаксис DateTime XAML является собственным поведением  
 <xref:System.DateTime> — Это класс, который определен в библиотеках базовых классов среды CLR. Из-за связи библиотеки базовых классов с остальной части среды CLR, он уже не сможете применить <xref:System.ComponentModel.TypeConverterAttribute> класс и использовать преобразователь типов для обработки строк из XAML и преобразовать их <xref:System.DateTime> в объектной модели времени выполнения. Нет класса `DateTimeConverter`, предоставляющего поведение преобразования: поведение преобразования, описанное в этом разделе, является собственным для средства синтаксического анализа XAML WPF.  
  
<a name="format_strings_for_datetime_xaml_syntax"></a>   
## <a name="format-strings-for-datetime-xaml-syntax"></a>Строки формата для синтаксиса DateTime XAML  
 Можно указать формат <xref:System.DateTime> строку формата. Строки формата формализуют синтаксис текста, который может использоваться для создания значения. <xref:System.DateTime> значения для существующие элементы управления WPF обычно только используют компоненты даты <xref:System.DateTime> и не компоненты времени.  
  
 При указании <xref:System.DateTime> в XAML, можно использовать любой из этих строк формата взаимозаменяемо.  
  
 Можно также использовать форматы и строки формата, которые не рассматриваются в этом разделе. С технической точки зрения XAML для любого <xref:System.DateTime> значение, которое указывается и затем анализируется средством синтаксического анализа XAML WPF использует внутренний вызов <xref:System.DateTime.Parse%2A?displayProperty=nameWithType>, таким образом можно использовать любой строкой, принимаемое <xref:System.DateTime.Parse%2A?displayProperty=nameWithType> вашей XAML ввода. Дополнительные сведения см. в разделе <xref:System.DateTime.Parse%2A?displayProperty=nameWithType>.  
  
> [!IMPORTANT]
>  Синтаксис DateTime XAML всегда использует `en-us` как <xref:System.Globalization.CultureInfo> для собственного преобразования. Это поведение не зависит от <xref:System.Windows.FrameworkElement.Language%2A> значение или `xml:lang` значение в XAML, так как преобразование типов на уровне атрибутов XAML работает без этого контекста. Не пытайтесь выполнять интерполяцию показанных здесь строк формата из-за различий региональных параметров, таких как порядок отображения дня и месяца. Показанные здесь строки формата — это именно те строки формата, которые используются при синтаксическом анализе XAML независимо от других параметров языка и региональных параметров.  
  
 В следующих разделах описаны некоторые распространенные <xref:System.DateTime> форматирования строк.  
  
### <a name="short-date-pattern-d"></a>Шаблон краткого формата даты (d)  
 Ниже приведен краткий формат даты для <xref:System.DateTime> в XAML:  
  
 `M/d/YYYY`  
  
 Это самая простая форма, определяющая все необходимые сведения для типичного использования элементами управления WPF. На нее не влияют случайные смещения часового пояса (по сравнению с компонентом времени), и поэтому она предпочтительнее других форматов.  
  
 Например, чтобы указать дату 1 июня 2010 г., используйте следующую строку.  
  
 `3/1/2010`  
  
 Дополнительные сведения см. в разделе <xref:System.Globalization.DateTimeFormatInfo.ShortDatePattern%2A?displayProperty=nameWithType>.  
  
### <a name="sortable-datetime-pattern-s"></a>Сортируемый шаблон даты и времени (s)  
 Далее показано, что данные в элементе <xref:System.DateTime> шаблон в XAML:  
  
 `yyyy'-'MM'-'dd'T'HH':'mm':'ss`  
  
 Например, чтобы указать дату 1 июня 2010 г., используйте следующую строку (все компоненты времени вводятся как 0).  
  
 `2010-06-01T000:00:00`  
  
### <a name="rfc1123-pattern-r"></a>Шаблон RFC1123 (r)  
 Шаблон RFC1123 удобен, поскольку он может быть строкой ввода из других генераторов данных, также использующих шаблон RFC1123, в ситуациях инвариантных значений языка и региональных параметров. Ниже показан шаблон RFC1123 <xref:System.DateTime> шаблон в XAML:  
  
 `ddd, dd MMM yyyy HH':'mm':'ss 'UTC'`  
  
 Например, чтобы указать дату 1 июня 2010 г., используйте следующую строку (все компоненты времени вводятся как 0).  
  
 `Mon, 01 Jun 2010 00:00:00 UTC`  
  
### <a name="other-formats-and-patterns"></a>Другие форматы и шаблоны  
 Как уже говорилось ранее, <xref:System.DateTime> в XAML может быть указан как любая строка, которая является приемлемой как входные для <xref:System.DateTime.Parse%2A?displayProperty=nameWithType>. Сюда входят другие формализованные форматы (например <xref:System.Globalization.DateTimeFormatInfo.UniversalSortableDateTimePattern%2A>) и форматы, которые не формализованы как определенный <xref:System.Globalization.DateTimeFormatInfo> формы. Например, в форме `YYYY/mm/dd` допустимо как входные для <xref:System.DateTime.Parse%2A?displayProperty=nameWithType>. Этот раздел не является попыткой описать все возможные форматы: вместо этого рекомендуется использование шаблона короткого формата даты.  
  
## <a name="see-also"></a>См. также

- [Обзор XAML (WPF)](xaml-overview-wpf.md)
