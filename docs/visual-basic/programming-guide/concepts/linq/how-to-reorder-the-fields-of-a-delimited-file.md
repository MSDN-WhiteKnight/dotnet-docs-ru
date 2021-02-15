---
description: Дополнительные сведения о том, как изменить порядок полей файла с разделителями (LINQ) (Visual Basic).
title: Практическое руководство. Изменение порядка полей файла с разделителями (LINQ)
ms.date: 07/20/2015
ms.assetid: c451c7db-663b-4daf-b8ba-a2093095d672
ms.openlocfilehash: bfb06c396dbe33628ea146622c9c4ebe9534aae4
ms.sourcegitcommit: 10e719780594efc781b15295e499c66f316068b8
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/14/2021
ms.locfileid: "100435009"
---
# <a name="how-to-reorder-the-fields-of-a-delimited-file-linq-visual-basic"></a>Как изменить порядок полей файла с разделителями (LINQ) (Visual Basic)

CSV-файл — это текстовый файл, который часто используется для хранения данных электронных таблиц или других табличных данных, представленных строками и столбцами. Использование метода <xref:System.String.Split%2A> для разделения полей упрощает создание запросов к CSV-файлам и управление ими с помощью LINQ. Фактически та же технология может использоваться для изменения порядка частей любой структурированной строки текста, а не только CSV-файлов.

В следующем примере предполагается, что три столбца представляют "фамилию", "имя" и "идентификатор" учащихся. Поля группируются в алфавитном порядке по фамилии учащихся. Запрос создает новую последовательность, в которой столбец идентификатора отображается первым, за ним следует второй столбец, который объединяет имя и фамилию учащегося. Порядок строк изменен в соответствии с полем идентификатора. Результаты сохраняются в новый файл, и исходные данные не изменяются.

### <a name="to-create-the-data-file"></a>Создание файла данных

1. Скопируйте следующие строки в обычный текстовый файл с именем spreadsheet1.csv. Сохраните файл в папке проекта.

    ```csv
    Adams,Terry,120
    Fakhouri,Fadi,116
    Feng,Hanying,117
    Garcia,Cesar,114
    Garcia,Debra,115
    Garcia,Hugo,118
    Mortensen,Sven,113
    O'Donnell,Claire,112
    Omelchenko,Svetlana,111
    Tucker,Lance,119
    Tucker,Michael,122
    Zabokritski,Eugene,121
    ```

## <a name="example"></a>Пример

```vb
Class CSVFiles

    Shared Sub Main()

        ' Create the IEnumerable data source.
        Dim lines As String() = System.IO.File.ReadAllLines("../../../spreadsheet1.csv")

        ' Execute the query. Put field 2 first, then
        ' reverse and combine fields 0 and 1 from the old field
        Dim lineQuery = From line In lines
                        Let x = line.Split(New Char() {","})
                        Order By x(2)
                        Select x(2) & ", " & (x(1) & " " & x(0))

        ' Execute the query and write out the new file. Note that WriteAllLines
        ' takes a string array, so ToArray is called on the query.
        System.IO.File.WriteAllLines("../../../spreadsheet2.csv", lineQuery.ToArray())

        ' Keep console window open in debug mode.
        Console.WriteLine("Spreadsheet2.csv written to disk. Press any key to exit")
        Console.ReadKey()
    End Sub
End Class
' Output to spreadsheet2.csv:
' 111, Svetlana Omelchenko
' 112, Claire O'Donnell
' 113, Sven Mortensen
' 114, Cesar Garcia
' 115, Debra Garcia
' 116, Fadi Fakhouri
' 117, Hanying Feng
' 118, Hugo Garcia
' 119, Lance Tucker
' 120, Terry Adams
' 121, Eugene Zabokritski
' 122, Michael Tucker
```

## <a name="see-also"></a>См. также раздел

- [LINQ и строки (Visual Basic)](linq-and-strings.md)
- [LINQ и каталоги файлов (Visual Basic)](linq-and-file-directories.md)
- [Как создать XML из CSV-файлов](../../../../standard/linq/generate-xml-csv-files.md)
