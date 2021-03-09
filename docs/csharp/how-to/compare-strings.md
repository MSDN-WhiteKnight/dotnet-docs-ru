---
title: Практическое руководство. Сравнение строк (руководство по C#)
description: Сведения о том, как сравнивать и упорядочивать строковые значения с учетом или без учета регистра и порядка для определенного языка.
ms.date: 10/03/2018
helpviewer_keywords:
- strings [C#], comparison
- comparing strings [C#]
ms.openlocfilehash: 5c417ccbdd763de5bbb67ae6a17ac1a5ff165065
ms.sourcegitcommit: 42d436ebc2a7ee02fc1848c7742bc7d80e13fc2f
ms.translationtype: HT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/04/2021
ms.locfileid: "102104982"
---
# <a name="how-to-compare-strings-in-c"></a>Сравнение строк в C\#

Сравнивая строки, вы хотите ответить на один из двух вопросов: "Равны ли две эти строки?" или "В каком порядке должны следовать эти строки при их сортировке?".

Однако эту задачу осложняют факторы, влияющие на сравнение строк:

- Вы можете выбрать порядковое или лингвистическое сравнение.
- Вы можете указать, учитывается ли регистр.
- Вы можете выбрать сравнения для конкретного языка и региональных параметров.
- Лингвистические сравнения зависят от языка и региональных параметров, а также от используемой платформы.

[!INCLUDE[interactive-note](~/includes/csharp-interactive-note.md)]

При сравнении строк вы определяете их порядок. Сравнения используются для сортировки последовательности строк. Если последовательность имеет известный порядок, это упрощает поиск как для программного обеспечения, так и для пользователей. Другие сравнения могут проверять совпадение строк. Эти проверки тождественности похожи на проверки равенства, но позволяют игнорировать некоторые различия, например различия в регистре.

## <a name="default-ordinal-comparisons"></a>Порядковые сравнения по умолчанию

Ниже представлены самые распространенные операции по умолчанию:

- <xref:System.String.Equals%2A?displayProperty=nameWithType>
- <xref:System.String.op_Equality%2A?displayProperty=nameWithType> и <xref:System.String.op_Inequality%2A?displayProperty=nameWithType>, т. е. операторы [равенства `==` и `!=`](../language-reference/operators/equality-operators.md#string-equality) соответственно

выполняют порядковое сравнение с учетом регистра и используют текущие значения языка и региональных параметров при необходимости. Это показано в следующем примере:

:::code language="csharp" interactive="try-dotnet-method" source="../../../samples/snippets/csharp/how-to/strings/CompareStrings.cs" id="Snippet1":::

При порядковых сравнениях строк по умолчанию лингвистические правила не учитываются. В них сравнивается двоичное значение каждого объекта <xref:System.Char> в двух строках. Таким образом, в порядковом сравнении по умолчанию также учитывается регистр.

Проверка на равенство с использованием <xref:System.String.Equals%2A?displayProperty=nameWithType>, а также операторов `==` и `!=` отличается от сравнения строк с использованием методов <xref:System.String.CompareTo%2A?displayProperty=nameWithType> и <xref:System.String.Compare(System.String,System.String)?displayProperty=nameWithType)>. Хотя в проверках на равенство выполняется порядковое сравнение с учетом регистра, метод сравнения выполняет сравнение с учетом регистра, с учетом языка и региональных параметров с использованием текущего значения языка и региональных параметров. Поскольку методы сравнения по умолчанию часто выполняют сравнения различных типов, рекомендуется всегда четко определять назначение кода путем вызова перегрузки, которая явно указывает тип выполняемого сравнения.

## <a name="case-insensitive-ordinal-comparisons"></a>Порядковые сравнения без учета регистра

Метод <xref:System.String.Equals(System.String,System.StringComparison)?displayProperty=nameWithType> позволяет указать значение <xref:System.StringComparison> для объекта <xref:System.StringComparison.OrdinalIgnoreCase?displayProperty=nameWithType>
для порядкового сравнения без учета регистра. Также имеется статический метод <xref:System.String.Compare(System.String,System.String,System.StringComparison)?displayProperty=nameWithType>, позволяющий проводить порядковое сравнение без учета регистра, если указать значение <xref:System.StringComparison.OrdinalIgnoreCase?displayProperty=nameWithType> для аргумента <xref:System.StringComparison>. Это показано в следующем коде:

:::code language="csharp" interactive="try-dotnet-method" source="../../../samples/snippets/csharp/how-to/strings/CompareStrings.cs" id="Snippet2":::

При выполнении порядкового сравнения без учета регистра эти методы используют соглашения о регистре для [инвариантного языка и региональных параметров](xref:System.Globalization.CultureInfo.InvariantCulture).

## <a name="linguistic-comparisons"></a>Лингвистические сравнения

Строки могут быть упорядочены с использованием лингвистических правил для текущих значений языка и региональных параметров.
Иногда это называется порядком сортировки слов. При лингвистическом сравнении некоторые символы Юникода, отличные от алфавитно-цифровых, могут иметь особые весовые коэффициенты. Например, дефис "-" может иметь низкий весовой коэффициент, чтобы слова "co-op" и "coop" находились рядом друг с другом в порядке сортировки. Кроме того, некоторые символы Юникода могут быть эквивалентны последовательности экземпляров <xref:System.Char>. В следующем примере используется фраза "Они танцуют на улице." на немецком языке с буквами "ss" (U+0073 U+0073) в одной строке и буквой "ß" (U+00DF) в другой. Лингвистически (в Windows) буквы "ss" равнозначны немецкому символу эсцет "ß" в языках "en-US" и "de-DE".

:::code language="csharp" interactive="try-dotnet-method" source="../../../samples/snippets/csharp/how-to/strings/CompareStrings.cs" id="Snippet3":::

Этот пример демонстрирует зависимость операций лингвистического сравнения от операционной системы. Для интерактивного окна используется узел Linux. Лингвистические и порядковые сравнения дают одинаковые результаты. Если запустить этот пример на узле Windows, отображаются следующие выходные данные:

```console
<coop> is less than <co-op> using invariant culture
<coop> is greater than <co-op> using ordinal comparison
<coop> is less than <cop> using invariant culture
<coop> is less than <cop> using ordinal comparison
<co-op> is less than <cop> using invariant culture
<co-op> is less than <cop> using ordinal comparison
```

В Windows порядок сортировки "cop", "coop" и "co-op" изменяется при переходе от лингвистического сравнения к порядковому. Два предложения на немецком языке также сравниваются по-разному при использовании разных типов сравнения.

## <a name="comparisons-using-specific-cultures"></a>Сравнения с использованием определенных языков и региональных параметров

Этот пример сохраняет объекты <xref:System.Globalization.CultureInfo> для языков "en-US" и "de-DE".
Сравнения выполняются с использованием объекта <xref:System.Globalization.CultureInfo>, чтобы учесть язык и региональные параметры.

Используемые значения языка и региональных параметров влияют на операции лингвистического сравнения. В следующем примере показаны результаты сравнения двух предложений на немецком с использованием языка и региональных параметров "en US" и "de-DE":

:::code language="csharp" interactive="try-dotnet-method" source="../../../samples/snippets/csharp/how-to/strings/CompareStrings.cs" id="Snippet4":::

Сравнения с учетом языка и региональных параметров обычно используются для сравнения и сортировки строк, вводимых пользователями. Символы и правила сортировки этих строк могут различаться в зависимости от языкового стандарта компьютера пользователя. Даже строки, содержащие идентичные символы, могут быть отсортированы по-разному, в зависимости от языка и региональных параметров текущего потока. Кроме того, попробуйте запустить этот пример кода локально на компьютере с Windows, и вы получите следующие результаты:

```console
<coop> is less than <co-op> using en-US culture
<coop> is greater than <co-op> using ordinal comparison
<coop> is less than <cop> using en-US culture
<coop> is less than <cop> using ordinal comparison
<co-op> is less than <cop> using en-US culture
<co-op> is less than <cop> using ordinal comparison
```

Лингвистические сравнения зависят от текущих значений языка и региональных параметров, а также от операционной системы. Это необходимо учитывать при работе со строковыми сравнениями.

## <a name="linguistic-sorting-and-searching-strings-in-arrays"></a>Лингвистическая сортировка и поиск строк в массивах

Приведенные ниже примеры показывают, как сортировать и искать строки в массиве с помощью лингвистического сравнения, зависящего от текущих значений языка и региональных параметров. Используйте статические методы <xref:System.Array>, которые принимают параметр <xref:System.StringComparer?displayProperty=nameWithType>.

В этом примере показано, как сортировать массив строк с использованием текущих значений языка и региональных параметров:

:::code language="csharp" interactive="try-dotnet-method" source="../../../samples/snippets/csharp/how-to/strings/CompareStrings.cs" id="Snippet5":::

После сортировки массива можно выполнить поиск записей с помощью двоичного поиска. Двоичный поиск начинается с середины коллекции, чтобы определить, какая половина коллекции содержит искомую строку. Каждое последующее сравнение делит оставшуюся часть коллекции пополам.  Массив сортируется с использованием <xref:System.StringComparer.CurrentCulture?displayProperty=nameWithType>. Локальная функция `ShowWhere` отображает сведения о том, где была найдена строка. Если строка не найдена, возвращаемое значение указывает, где бы оно находилось, если было бы найдено.

:::code language="csharp" interactive="try-dotnet-method" source="../../../samples/snippets/csharp/how-to/strings/CompareStrings.cs" id="Snippet6":::

## <a name="ordinal-sorting-and-searching-in-collections"></a>Порядковая сортировка и поиск в коллекциях

Следующий код использует класс коллекции <xref:System.Collections.Generic.List%601?displayProperty=nameWithType> для хранения строк. Строки сортируются с помощью метода <xref:System.Collections.Generic.List%601.Sort%2A?displayProperty=nameWithType>. Этому методу нужен делегат, который сравнивает и упорядочивает две строки. Метод <xref:System.String.CompareTo%2A?displayProperty=nameWithType> предоставляет эту функцию сравнения. Запустите пример и следите за порядком. Эта операция сортировки использует порядковую сортировку с учетом регистра. Можно использовать статические методы <xref:System.String.Compare%2A?displayProperty=nameWithType>, чтобы указать разные правила сравнения.

:::code language="csharp" interactive="try-dotnet-method" source="../../../samples/snippets/csharp/how-to/strings/CompareStrings.cs" id="Snippet7":::

После сортировки по списку строк можно осуществлять двоичный поиск. Приведенный ниже пример описывает поиск в отсортированном списке с использованием той же функции сравнения. Локальная функция `ShowWhere` показывает, где находится или находился бы искомый текст:

:::code language="csharp" interactive="try-dotnet-method" source="../../../samples/snippets/csharp/how-to/strings/CompareStrings.cs" id="Snippet8":::

Всегда используйте один и тот же тип сравнения для сортировки и поиска. Использование разных типов сравнения приводит к неожиданным результатам.

Классы коллекций, такие как <xref:System.Collections.Hashtable?displayProperty=nameWithType>, <xref:System.Collections.Generic.Dictionary%602?displayProperty=nameWithType>, и <xref:System.Collections.Generic.List%601?displayProperty=nameWithType>, имеют конструкторы, принимающие параметр <xref:System.StringComparer?displayProperty=nameWithType>, если типом элементов или ключей является `string`. В целом, по возможности следует использовать эти конструкторы и задавать либо <xref:System.StringComparer.Ordinal?displayProperty=nameWithType>, либо <xref:System.StringComparer.OrdinalIgnoreCase?displayProperty=nameWithType>.

## <a name="reference-equality-and-string-interning"></a>Равенство ссылок и интернирование строк

Ни один из примеров не использовал <xref:System.Object.ReferenceEquals%2A>. Этот метод определяет, являются ли две строки одним и тем же объектом, что может привести к несогласованности результатов при сравнении строк. Следующий пример демонстрирует функцию *интернирования строк* в C#. При объявлении программой двух или более идентичных переменных строк компилятор сохраняет их в одном расположении. Вызвав метод <xref:System.Object.ReferenceEquals%2A>, можно увидеть, что две строки фактически ссылаются на один и тот же объект в памяти. Чтобы избежать интернирования, используйте метод <xref:System.String.Copy%2A?displayProperty=nameWithType>. После копирования две строки имеют разное расположение хранения, хотя и имеют одинаковое значение. Запустите следующий пример, показывающий, что строки `a` и `b`*интернированы*, находятся в одном хранилище. Строки `a` и `c` таковыми не являются.

:::code language="csharp" interactive="try-dotnet-method" source="../../../samples/snippets/csharp/how-to/strings/CompareStrings.cs" id="Snippet9":::

> [!NOTE]
> При проверке строк на равенство нужно использовать методы, которые явно указывают, какой вид сравнения следует выполнить. Это делает код намного более понятным и удобочитаемым. Используйте перегрузки методов классов <xref:System.String?displayProperty=nameWithType> и <xref:System.Array?displayProperty=nameWithType>, которые принимают параметр перечисления <xref:System.StringComparison>. Это позволяет указать тип выполняемого сравнения. Старайтесь избегать использования операторов `==` и `!=` при проверке на равенство. Методы экземпляра <xref:System.String.CompareTo%2A?displayProperty=nameWithType> всегда выполняют порядковое сравнение с учетом регистра. Они предназначены, прежде всего, для упорядочивания строк в алфавитном порядке.

Вы можете интернировать строку или получить ссылку на существующую интернированную строку, вызвав метод <xref:System.String.Intern%2A?displayProperty=nameWithType>. Чтобы определить, является ли строка интернированной, вызовите метод <xref:System.String.IsInterned%2A?displayProperty=nameWithType>.

## <a name="see-also"></a>См. также

- <xref:System.Globalization.CultureInfo?displayProperty=nameWithType>
- <xref:System.StringComparer?displayProperty=nameWithType>
- [Строки](../programming-guide/strings/index.md)
- [Сравнение строк](../../standard/base-types/comparing.md)
- [Глобализация и локализация приложений](/visualstudio/ide/globalizing-and-localizing-applications)
