---
title: Критическое изменение. Теперь StringInfo и TextElementEnumerator совместимы с UAX29
description: Сведения о критическом изменении глобализации в .NET 5, где кластеры графем процесса StringInfo и TextElementEnumerator совместимы с последней версией стандарта Unicode.
ms.date: 04/07/2020
ms.openlocfilehash: cf770e30bfadf1973bbe018cc9d2783ed6234723
ms.sourcegitcommit: 9c589b25b005b9a7f87327646020eb85c3b6306f
ms.translationtype: HT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/06/2021
ms.locfileid: "102256709"
---
# <a name="stringinfo-and-textelementenumerator-are-now-uax29-compliant"></a>Теперь StringInfo и TextElementEnumerator совместимы с UAX29

До этого изменения <xref:System.Globalization.StringInfo?displayProperty=fullName> и <xref:System.Globalization.TextElementEnumerator?displayProperty=fullName> обрабатывали все кластеры графем неправильно. Некоторые графемы были разбиты на составные компоненты, а не объединялись. Теперь <xref:System.Globalization.StringInfo> и <xref:System.Globalization.TextElementEnumerator> обрабатывают кластеры графем в соответствии с последней версией стандарта Юникода.

Кроме того, метод <xref:Microsoft.VisualBasic.Strings.StrReverse%2A?displayProperty=fullName>, который меняет порядок символов строки в Visual Basic на обратный, теперь также соответствует стандарту Юникода для кластеров графем.

## <a name="change-description"></a>Описание изменений

[Графема](https://www.unicode.org/glossary/#grapheme) или [расширенный кластер графем](https://www.unicode.org/glossary/#extended_grapheme_cluster) — это отдельный воспринимаемый пользователем символ, который может состоять из нескольких кодовых точек Юникода. Например, строка, содержащая тайский символ "кам" (:::no-loc text="กำ":::), состоит из двух следующих символов:

- :::no-loc text="ก"::: (= '\u0e01') — тайский символ "ко кай"
- :::no-loc text=" ำ"::: (= '\u0e33') — тайский символ "сара ам"

При отображении пользователю операционная система объединяет эти два символа для формирования одного отображаемого символа (или графемы) "кам" или :::no-loc text="กำ":::. Эмодзи также могут состоять из нескольких символов, объединенных для единообразного отображения.

> [!TIP]
> В документации по .NET при ссылке на графему иногда применяется термин "текстовый элемент".

Классы <xref:System.Globalization.StringInfo> и <xref:System.Globalization.TextElementEnumerator> проверяют строки и возвращают сведения о содержащихся в них графемах. В .NET Framework (все версии) и .NET Core 3.x и более ранних версий эти два класса используют пользовательскую логику, которая обрабатывает некоторые комбинирующие классы, но не полностью соответствует [стандарту Юникода](https://www.unicode.org/reports/tr29/tr29-35.html#Grapheme_Cluster_Boundaries). Например, классы <xref:System.Globalization.StringInfo> и <xref:System.Globalization.TextElementEnumerator> ошибочно разделяют один тайский символ "кам" на составляющие компоненты вместо того, чтобы объединить их. Эти классы также ошибочно разбивают символ эмодзи "🤷🏽‍♀️" на четыре кластера (пожимание плечами, модификатор тона кожи, модификатор пола и невидимый объединяющий блок) вместо того, чтобы объединить их в один кластер графем.

Начиная с .NET 5 классы <xref:System.Globalization.StringInfo> и <xref:System.Globalization.TextElementEnumerator> удовлетворяют требованиям стандарта Юникода, как указано в [приложении к стандарту Юникод \#29, редакция 35, раздел 3](https://www.unicode.org/reports/tr29/tr29-35.html). В частности, теперь они возвращают [расширенные кластеры графем](https://www.unicode.org/glossary/#extended_grapheme_cluster) для всех комбинирующих классов.

Рассмотрим следующий код C#:

```csharp
using System.Globalization;

static void Main(string[] args)
{
    PrintGraphemes("กำ");
    PrintGraphemes("🤷🏽‍♀️");
}

static void PrintGraphemes(string str)
{
    Console.WriteLine($"Printing graphemes of \"{str}\"...");
    int i = 0;

    TextElementEnumerator enumerator = StringInfo.GetTextElementEnumerator(str);
    while (enumerator.MoveNext())
    {
        Console.WriteLine($"Grapheme {++i}: \"{enumerator.Current}\"");
    }

    Console.WriteLine($"({i} grapheme(s) total.)");
    Console.WriteLine();
}
```

В .NET Framework и .NET Core 3.x и более ранних версий графемы разделяются, а выходные данные в консоли выглядят следующим образом:

```txt
Printing graphemes of "กำ"...
Grapheme 1: "ก"
Grapheme 2: "ำ"
(2 grapheme(s) total.)

Printing graphemes of "🤷🏽‍♀️"...
Grapheme 1: "🤷"
Grapheme 2: "🏽"
Grapheme 3: "‍"
Grapheme 4: "♀️"
(4 grapheme(s) total.)
```

В .NET 5 и более поздних версий графемы объединяются, а выходные данные в консоли выглядят следующим образом:

```txt
Printing graphemes of "กำ"...
Grapheme 1: "กำ"
(1 grapheme(s) total.)

Printing graphemes of "🤷🏽‍♀️"...
Grapheme 1: "🤷🏽‍♀️"
(1 grapheme(s) total.)
```

Кроме того, начиная с .NET 5 метод <xref:Microsoft.VisualBasic.Strings.StrReverse%2A?displayProperty=fullName>, который меняет порядок символов строки в Visual Basic на обратный, также соответствует стандарту Юникода для кластеров графем.

Эти изменения являются частью более обширного набора улучшений для Юникода и UTF-8 в .NET, включая API перечисления расширенных кластеров графем, который дополняет интерфейсы API перечисления скалярных значений Юникода, появившиеся с типом <xref:System.Text.Rune?displayProperty=fullName> в .NET Core 3.0.

## <a name="version-introduced"></a>Представленная версия

.NET 5.0

## <a name="recommended-action"></a>Рекомендованное действие

Никаких дополнительных действий от вас не требуется. Ваши приложения будут автоматически обеспечивать более полное соответствие стандартам в различных сценариях, связанных с глобализацией.

## <a name="affected-apis"></a>Затронутые API

- <xref:System.Globalization.StringInfo?displayProperty=fullName>
- <xref:System.Globalization.TextElementEnumerator?displayProperty=fullName>
- <xref:Microsoft.VisualBasic.Strings.StrReverse%2A?displayProperty=fullName>

<!--

### Affected APIs

- `T:System.Globalization.StringInfo`
- `T:System.Globalization.TextElementEnumerator`
- `Overload:Microsoft.VisualBasic.Strings.StrReverse`

### Category

Globalization

-->
