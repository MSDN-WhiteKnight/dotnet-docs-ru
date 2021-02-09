---
description: 'Подробнее о следующем: Практическое руководство. Чтение текстовых файлов различных форматов в Visual Basic'
title: Практическое руководство. Чтение из текстовых файлов различных форматов
ms.date: 07/20/2015
helpviewer_keywords:
- TextFieldParser object, reading from a file
- TextFieldType enumeration
- My.Computer.FileSystem.WriteAllText method, parsing structured text files
- WriteAllText method [Visual Basic], parsing structured text files
- PeekChars method [Visual Basic], determining format of text
- reading text files [Visual Basic], multiple formats
- I/O [Visual Basic], reading text files
- text files [Visual Basic], reading
ms.assetid: 8d185eb2-79ca-42cd-95a7-d3ff44a5a0f8
ms.openlocfilehash: 90d981ad051fb395d57604434cf9ba6b74603e7d
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: HT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99797449"
---
# <a name="how-to-read-from-fext-files-with-multiple-formats-in-visual-basic"></a>Практическое руководство. Чтение текстовых файлов различных форматов в Visual Basic

Объект <xref:Microsoft.VisualBasic.FileIO.TextFieldParser> позволяет легко и эффективно анализировать структурированные текстовые файлы, например файлы журналов. Обработать файл, имеющий содержимое в нескольких форматах, можно с помощью метода `PeekChars`, который позволяет определять формат каждой анализируемой строки на протяжении всего файла.
  
### <a name="to-parse-a-text-file-with-multiple-formats"></a>Анализ текстового файла с содержимым в нескольких форматах

1. Добавьте текстовый файл с именем *testfile.txt* в проект. Добавьте в текстовый файл следующее содержимое:

    ```text
    Err  1001 Cannot access resource.
    Err  2014 Resource not found.
    Acc  10/03/2009User1      Administrator.
    Err  0323 Warning: Invalid access attempt.
    Acc  10/03/2009User2      Standard user.
    Acc  10/04/2009User2      Standard user.
    ```

2. Определите ожидаемый формат и формат, используемый при сообщении об ошибке. Последним элементом в каждом массиве является -1, поэтому предполагается, что ширина последнего поля может изменяться. Это происходит, когда последний элемент массива меньше или равен нулю.

     [!code-vb[VbFileIORead#4](~/samples/snippets/visualbasic/VS_Snippets_VBCSharp/VbFileIORead/VB/Class1.vb#4)]

3. Создайте объект <xref:Microsoft.VisualBasic.FileIO.TextFieldParser>, определив ширину и формат.

     [!code-vb[VbFileIORead#5](~/samples/snippets/visualbasic/VS_Snippets_VBCSharp/VbFileIORead/VB/Class1.vb#5)]

4. Переберите в цикле строки, проверяя формат перед чтением.

     [!code-vb[VbFileIORead#6](~/samples/snippets/visualbasic/VS_Snippets_VBCSharp/VbFileIORead/VB/Class1.vb#6)]

5. Выведите сообщения об ошибках на консоль.

     [!code-vb[VbFileIORead#7](~/samples/snippets/visualbasic/VS_Snippets_VBCSharp/VbFileIORead/VB/Class1.vb#7)]

## <a name="example"></a>Пример

Далее приведен полный пример, считывающий из файла `testfile.txt`:

 [!code-vb[VbFileIORead#8](~/samples/snippets/visualbasic/VS_Snippets_VBCSharp/VbFileIORead/VB/Class1.vb#8)]

## <a name="robust-programming"></a>Отказоустойчивость

При следующих условиях возможно возникновение исключения:  
  
- Строка не может быть проанализирована с использованием указанного формата (<xref:Microsoft.VisualBasic.FileIO.MalformedLineException>). Сообщение исключения содержит строку, вызвавшую исключение, а свойство <xref:Microsoft.VisualBasic.FileIO.TextFieldParser.ErrorLine%2A> присвоено тексту, который содержится в этой строке.
- Указанный файл не существует (<xref:System.IO.FileNotFoundException>).
- Ситуация частичного доверия, в которой пользователь не имеет достаточных разрешений для доступа к файлу. (<xref:System.Security.SecurityException>).
- Слишком длинный путь (<xref:System.IO.PathTooLongException>).
- У пользователя нет необходимых разрешений для доступа к файлу (<xref:System.UnauthorizedAccessException>).

## <a name="see-also"></a>См. также раздел

- <xref:Microsoft.VisualBasic.FileIO.TextFieldParser?displayProperty=nameWithType>
- <xref:Microsoft.VisualBasic.FileIO.TextFieldParser.PeekChars%2A>
- <xref:Microsoft.VisualBasic.FileIO.MalformedLineException>
- <xref:Microsoft.VisualBasic.FileIO.FileSystem.WriteAllText%2A>
- <xref:Microsoft.VisualBasic.FileIO.TextFieldParser.EndOfData%2A>
- <xref:Microsoft.VisualBasic.FileIO.TextFieldParser.TextFieldType%2A>
- [Практическое руководство. Чтение из текстовых файлов с разделителями-запятыми](how-to-read-from-comma-delimited-text-files.md)
- [Практическое руководство. Чтение из текстовых файлов с полями фиксированного размера](how-to-read-from-fixed-width-text-files.md)
- [Анализ текстовых файлов с помощью объекта TextFieldParser](parsing-text-files-with-the-textfieldparser-object.md)
