---
description: 'Дополнительные сведения: как разделить файл на несколько файлов с помощью групп (LINQ) (Visual Basic)'
title: Практическое руководство. Разделение файла на несколько файлов с помощью групп (LINQ)
ms.date: 07/20/2015
ms.assetid: 5e8b2a2b-0b1d-4933-8a2b-03e91dfaf77f
ms.openlocfilehash: 545b572e6cd2414823a46db9c757a1876b56a5a5
ms.sourcegitcommit: 10e719780594efc781b15295e499c66f316068b8
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/14/2021
ms.locfileid: "100465630"
---
# <a name="how-to-split-a-file-into-many-files-by-using-groups-linq-visual-basic"></a>Инструкции. Разбиение файла на несколько файлов с помощью групп (LINQ) (Visual Basic)

В этом примере показан один из способов объединения содержимого двух файлов и последующего создания набора новых файлов, данные в котором будут организованы иначе.

### <a name="to-create-the-data-files"></a>Создание файлов данных

1. Скопируйте эти имена в текстовый файл с именем names1.txt и сохраните его в папке проекта:

    ```text
    Bankov, Peter
    Holm, Michael
    Garcia, Hugo
    Potra, Cristina
    Noriega, Fabricio
    Aw, Kam Foo
    Beebe, Ann
    Toyoshima, Tim
    Guy, Wey Yuan
    Garcia, Debra
    ```

2. Скопируйте эти имена в текстовый файл с именем names2.txt и сохраните его в папке проекта. Обратите внимание на то, что имена этих двух файлов похожи.

    ```text
    Liu, Jinghao
    Bankov, Peter
    Holm, Michael
    Garcia, Hugo
    Beebe, Ann
    Gilchrist, Beth
    Myrcha, Jacek
    Giakoumakis, Leo
    McLin, Nkenge
    El Yassir, Mehdi
    ```

## <a name="example"></a>Пример

```vb
Class SplitWithGroups

    Shared Sub Main()

        Dim fileA As String() = System.IO.File.ReadAllLines("../../../names1.txt")
        Dim fileB As String() = System.IO.File.ReadAllLines("../../../names2.txt")

        ' Concatenate and remove duplicate names based on
        Dim mergeQuery As IEnumerable(Of String) = fileA.Union(fileB)

        ' Group the names by the first letter in the last name
        Dim groupQuery = From name In mergeQuery
                     Let n = name.Split(New Char() {","})
                     Order By n(0)
                     Group By groupKey = n(0)(0)
                     Into groupName = Group

        ' Create a new file for each group that was created
        ' Note that nested foreach loops are required to access
        ' individual items with each group.
        For Each gGroup In groupQuery
            Dim fileName As String = "..'..'..'testFile_" & gGroup.groupKey & ".txt"
            Dim sw As New System.IO.StreamWriter(fileName)
            Console.WriteLine(gGroup.groupKey)
            For Each item In gGroup.groupName
                Console.WriteLine("   " & item.name)
                sw.WriteLine(item.name)
            Next
            sw.Close()
        Next

        ' Keep console window open in debug mode.
        Console.WriteLine("Files have been written. Press any key to exit.")
        Console.ReadKey()

    End Sub
End Class
' Console Output:
' A
'    Aw, Kam Foo
' B
'    Bankov, Peter
'    Beebe, Ann
' E
'    El Yassir, Mehdi
' G
'    Garcia, Hugo
'    Garcia, Debra
'    Giakoumakis, Leo
'    Gilchrist, Beth
'    Guy, Wey Yuan
' H
'    Holm, Michael
' L
'    Liu, Jinghao
' M
'    McLin, Nkenge
'    Myrcha, Jacek
' N
'    Noriega, Fabricio
' P
'    Potra, Cristina
' T
'    Toyoshima, Tim
```

Программа записывает отдельный файл для каждой группы в ту же папку, где находятся файлы данных.

## <a name="compile-the-code"></a>Компиляция кода

Создайте проект консольного приложения Visual Basic с `Imports` инструкцией для пространства имен System. LINQ.

## <a name="see-also"></a>См. также раздел

- [LINQ и строки (Visual Basic)](linq-and-strings.md)
- [LINQ и каталоги файлов (Visual Basic)](linq-and-file-directories.md)
