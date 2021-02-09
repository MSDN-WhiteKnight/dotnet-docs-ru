---
description: 'Подробнее о следующем: Практическое руководство. Переименование файла в Visual Basic'
title: Практическое руководство. Переименование файла
ms.date: 07/20/2015
helpviewer_keywords:
- I/O [Visual Basic], renaming files
- files [Visual Basic], renaming
ms.assetid: 0ea7e0c8-2cb2-4bf5-a00d-7b6e3c08a3bc
ms.openlocfilehash: cf182fa94befdfdcb1568052a0193d483670cf49
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: HT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99797410"
---
# <a name="how-to-rename-a-file-in-visual-basic"></a>Практическое руководство. Переименование файла в Visual Basic

Метод `RenameFile` объекта `My.Computer.FileSystem` можно использовать, чтобы переименовать файл, указав текущее расположение, имя файла и новое имя файла. Этот метод нельзя использовать для перемещения файла. Для перемещения и переименования файла используется метод `MoveFile`.  
  
### <a name="to-rename-a-file"></a>Переименование файла  
  
- Используйте метод `My.Computer.FileSystem.RenameFile`, чтобы переименовать файл. В этом примере переименовывается файл с именем `Test.txt` в `SecondTest.txt`.  
  
     [!code-vb[VbVbcnMyFileSystem#9](~/samples/snippets/visualbasic/VS_Snippets_VBCSharp/VbVbcnMyFileSystem/VB/Class1.vb#9)]  
  
 Этот пример кода также доступен в качестве фрагмента кода IntelliSense. В средстве выбора фрагментов кода фрагмент находится в разделе **файловая система: обработка дисков, папок и файлов**. Дополнительные сведения см. в статье [Фрагменты кода](/visualstudio/ide/code-snippets).  
  
## <a name="robust-programming"></a>Отказоустойчивость  

 При следующих условиях возможно возникновение исключения:  
  
- Путь является недопустимым, так как он представляет собой строку нулевой длины (пустую строку), либо содержит только пробелы, либо содержит недопустимые знаки, либо представляет собой путь к устройству (начинается с символов \\\\.\\) (<xref:System.ArgumentException>).  
  
- `newName` содержит сведения о пути (<xref:System.ArgumentException>).  
  
- Путь не является допустимым, поскольку он равен `Nothing` (<xref:System.ArgumentNullException>).  
  
- Параметр`newName` имеет значение `Nothing` или является пустой строкой (<xref:System.ArgumentNullException>).  
  
- Исходный файл является недопустимым или не существует (<xref:System.IO.FileNotFoundException>).  
  
- Имеется существующий файл или каталог с именем, указанным в `newName` (<xref:System.IO.IOException>).  
  
- Длина пути превышает максимальную длину, определенную в системе (<xref:System.IO.PathTooLongException>).  
  
- Имя файла или каталога в пути содержит двоеточие (:) или имеет недопустимый формат (<xref:System.NotSupportedException>).  
  
- У пользователя отсутствуют необходимые разрешения на просмотр пути (<xref:System.Security.SecurityException>).  
  
- У пользователя отсутствует необходимое разрешение (<xref:System.UnauthorizedAccessException>).  
  
## <a name="see-also"></a>См. также раздел

- <xref:Microsoft.VisualBasic.FileIO.FileSystem.RenameFile%2A>
- [Практическое руководство. Перемещение файла](how-to-move-a-file.md)
- [Создание, удаление и перемещение файлов и каталогов](creating-deleting-and-moving-files-and-directories.md)
- [Практическое руководство. Создание копии файла в том же каталоге](how-to-create-a-copy-of-a-file-in-the-same-directory.md)
- [Практическое руководство. Создание копии файла в другом каталоге](how-to-create-a-copy-of-a-file-in-a-different-directory.md)
