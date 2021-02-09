---
description: 'Узнайте подробнее о: Практическое руководство. Чтение из текстовых файлов с фиксированной шириной полей в Visual Basic'
title: Практическое руководство. Чтение из текстовых файлов с фиксированной шириной полей
ms.date: 07/20/2015
helpviewer_keywords:
- fixed-width text file
- reading text files [Visual Basic], fixed-width
- files [Visual Basic], parsing
- text files [Visual Basic], tasks
- text files [Visual Basic], reading
ms.assetid: 99be5692-967a-4e85-993e-cd18139a5a69
ms.openlocfilehash: 4f5868fa68009851cc65eeaf5ff6431ac22840d3
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: HT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99797462"
---
# <a name="how-to-read-from-fixed-width-text-files-in-visual-basic"></a>Практическое руководство. Чтение из текстовых файлов с фиксированной шириной полей в Visual Basic

Объект `TextFieldParser` позволяет легко и эффективно анализировать структурированные текстовые файлы, например файлы журналов.  
  
 Свойство `TextFieldType` определяет, является ли анализируемый файл файлом с разделителями или с полями фиксированной ширины текста. В текстовом файле с полями фиксированного размера поле в конце может иметь переменную ширину. Чтобы указать, что поле в конце имеет переменную длину, определите для его ширины значение меньше или равное нулю.  
  
### <a name="to-parse-a-fixed-width-text-file"></a>Анализ текстового файла с полями фиксированной ширины  
  
1. Создайте `TextFieldParser`. Следующий код создает объект `TextFieldParser` с именем `Reader` и открывает файл `test.log`.  
  
     [!code-vb[VbFileIORead#9](~/samples/snippets/visualbasic/VS_Snippets_VBCSharp/VbFileIORead/VB/Class1.vb#9)]  
  
2. Определение свойство `TextFieldType` как `FixedWidth`, задав ширину и формат. Следующий код определяет столбцы текста; первый имеет ширину 5 символов, второй 10, третий 11, а четвертый столбец имеет переменную ширину.  
  
     [!code-vb[VbFileIORead#10](~/samples/snippets/visualbasic/VS_Snippets_VBCSharp/VbFileIORead/VB/Class1.vb#10)]  
  
3. Просмотрите поля в файле. Если какие-либо строки повреждены, выведите сообщение об ошибке и продолжите анализ.  
  
     [!code-vb[VbFileIORead#11](~/samples/snippets/visualbasic/VS_Snippets_VBCSharp/VbFileIORead/VB/Class1.vb#11)]  
  
4. Закройте блоки `While` и `Using` операторами `End While` и `End Using`.  
  
     [!code-vb[VbFileIORead#12](~/samples/snippets/visualbasic/VS_Snippets_VBCSharp/VbFileIORead/VB/Class1.vb#12)]  
  
## <a name="example"></a>Пример  

 В этом примере производится чтение данных из файла `test.log`.  
  
 [!code-vb[VbFileIORead#13](~/samples/snippets/visualbasic/VS_Snippets_VBCSharp/VbFileIORead/VB/Class1.vb#13)]  
  
## <a name="robust-programming"></a>Отказоустойчивость  

 При следующих условиях возможно возникновение исключения:  
  
- Строка не может быть проанализирована с использованием указанного формата (<xref:Microsoft.VisualBasic.FileIO.MalformedLineException>). Сообщение исключения содержит строку, вызвавшую исключение, а свойство <xref:Microsoft.VisualBasic.FileIO.TextFieldParser.ErrorLine%2A> присвоено тексту, который содержится в этой строке.  
  
- Указанный файл не существует (<xref:System.IO.FileNotFoundException>).  
  
- Ситуация частичного доверия, в которой пользователь не имеет достаточных разрешений для доступа к файлу. (<xref:System.Security.SecurityException>).  
  
- Слишком длинный путь (<xref:System.IO.PathTooLongException>).  
  
- У пользователя нет необходимых разрешений для доступа к файлу (<xref:System.UnauthorizedAccessException>).  
  
## <a name="see-also"></a>См. также раздел

- <xref:Microsoft.VisualBasic.FileIO.TextFieldParser?displayProperty=nameWithType>
- [Практическое руководство. Чтение из текстовых файлов с разделителями-запятыми](how-to-read-from-comma-delimited-text-files.md)
- [Практическое руководство. Чтение из текстовых файлов различных форматов](how-to-read-from-text-files-with-multiple-formats.md)
- [Анализ текстовых файлов с помощью объекта TextFieldParser](parsing-text-files-with-the-textfieldparser-object.md)
- [Пошаговое руководство: Операции с файлами и каталогами в Visual Basic](walkthrough-manipulating-files-and-directories.md)
- [Устранение неполадок: Чтение из текстовых файлов и запись в такие файлы](troubleshooting-reading-from-and-writing-to-text-files.md)
