---
description: Дополнительные сведения см. в статье как запросить предложения, содержащие указанный набор слов (LINQ) (Visual Basic)
title: Практическое руководство. Запрос к предложениям, содержащим указанный набор слов (LINQ)
ms.date: 07/20/2015
ms.assetid: a5ae8ced-61fe-4c10-bb8a-95630e50f603
ms.openlocfilehash: b6d2f428e499b8b22fa5bc13015f2405430c1bbd
ms.sourcegitcommit: 10e719780594efc781b15295e499c66f316068b8
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/14/2021
ms.locfileid: "100435100"
---
# <a name="how-to-query-for-sentences-that-contain-a-specified-set-of-words-linq-visual-basic"></a>Практическое руководство. Запрос к предложениям, содержащим указанный набор слов (LINQ) (Visual Basic)

В этом примере показан поиск предложений, содержащих совпадения для каждого из указанного набора слов в текстовом файле. Хотя массив терминов для поиска в этом примере жестко закодирован, его можно заполнять динамически во время выполнения. В этом примере запрос возвращает предложения, которые содержат слова "Historically", "data" и "integrated".

## <a name="example"></a>Пример

```vb
Class FindSentences

    Shared Sub Main()
        Dim text As String = "Historically, the world of data and the world of objects " &
        "have not been well integrated. Programmers work in C# or Visual Basic " &
        "and also in SQL or XQuery. On the one side are concepts such as classes, " &
        "objects, fields, inheritance, and .NET Framework APIs. On the other side " &
        "are tables, columns, rows, nodes, and separate languages for dealing with " &
        "them. Data types often require translation between the two worlds; there are " &
        "different standard functions. Because the object world has no notion of query, a " &
        "query can only be represented as a string without compile-time type checking or " &
        "IntelliSense support in the IDE. Transferring data from SQL tables or XML trees to " &
        "objects in memory is often tedious and error-prone."

        ' Split the text block into an array of sentences.
        Dim sentences As String() = text.Split(New Char() {".", "?", "!"})

        ' Define the search terms. This list could also be dynamically populated at runtime
        Dim wordsToMatch As String() = {"Historically", "data", "integrated"}

        ' Find sentences that contain all the terms in the wordsToMatch array
        ' Note that the number of terms to match is not specified at compile time
        Dim sentenceQuery = From sentence In sentences
                            Let w = sentence.Split(New Char() {" ", ",", ".", ";", ":"},
                                                   StringSplitOptions.RemoveEmptyEntries)
                            Where w.Distinct().Intersect(wordsToMatch).Count = wordsToMatch.Count()
                            Select sentence

        ' Execute the query
        For Each str As String In sentenceQuery
            Console.WriteLine(str)
        Next

        ' Keep console window open in debug mode.
        Console.WriteLine("Press any key to exit.")
        Console.ReadKey()
    End Sub

End Class
' Output:
' Historically, the world of data and the world of objects have not been well integrated
```

Запрос сначала разделяет текст на предложения, а затем разделяет предложения на массив строк, содержащих слова. Для каждого из этих массивов метод <xref:System.Linq.Enumerable.Distinct%2A> удаляет все повторяющиеся слова, после чего выполняет операцию <xref:System.Linq.Enumerable.Intersect%2A> в отношении массива слов и массива `wordsToMatch`. Если число пересечений совпадает с размером массива `wordsToMatch`, все слова были найдены и возвращается исходное предложение.

В вызове <xref:System.String.Split%2A> знаки пунктуации используются как разделители для того, чтобы удалить их из строки. Если этого не сделать, то, например, можно получить строку "Historically," которая не будет совпадать с "Historically" в массиве `wordsToMatch`. В зависимости от знаков препинания в исходном тексте может потребоваться использовать дополнительные разделители.

## <a name="compile-the-code"></a>Компиляция кода

Создайте проект консольного приложения Visual Basic с `Imports` инструкцией для пространства имен System. LINQ.

## <a name="see-also"></a>См. также раздел

- [LINQ и строки (Visual Basic)](linq-and-strings.md)
