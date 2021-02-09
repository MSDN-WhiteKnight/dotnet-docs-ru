---
description: 'Подробнее о следующем: Практическое руководство. Создание копии файла в том же каталоге в Visual Basic'
title: Практическое руководство. Создание копии файла в том же каталоге
ms.date: 07/20/2015
f1_keywords:
- File.Copy
helpviewer_keywords:
- My.Computer.FileSystem.CopyFile method, copying files [Visual Basic]
- files [Visual Basic], copying
- CopyFile method [Visual Basic], copying files in Visual Basic
- I/O [Visual Basic], copying files
ms.assetid: b2fdda86-e666-42c2-9706-9527e9fa68ff
ms.openlocfilehash: 27fecc22a9317dd45e663aa37884c6c1f1e36349
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: HT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99797618"
---
# <a name="how-to-create-a-copy-of-a-file-in-the-same-directory-in-visual-basic"></a>Практическое руководство. Создание копии файла в том же каталоге в Visual Basic

Для копирования файлов используйте метод `My.Computer.FileSystem.CopyFile`. Эти параметры обеспечивают возможность перезаписи существующих файлов, переименования файлов и отображения хода выполнения операции, а также отмены операции пользователем.  
  
### <a name="to-create-a-copy-of-a-file-in-the-same-folder"></a>Создание копии файла в том же каталоге  
  
- Используйте метод `CopyFile`, указав конечный файл и расположение. В следующем примере создается копия `test.txt` с именем `test2.txt`.  
  
     [!code-vb[VbVbcnMyFileSystem#51](~/samples/snippets/visualbasic/VS_Snippets_VBCSharp/VbVbcnMyFileSystem/VB/Class1.vb#51)]  
  
### <a name="to-create-a-copy-of-a-file-in-the-same-folder-overwriting-existing-files"></a>Создание копии файла в том же каталоге, перезапись существующих файлов  
  
- Используйте метод `CopyFile`, указав конечный файл и расположение и задав для параметра `overwrite` значение `True`. В следующем примере создается копия `test.txt` с именем `test2.txt` и перезаписываются существующие файлы с этим именем.  
  
     [!code-vb[VbVbcnMyFileSystem#52](~/samples/snippets/visualbasic/VS_Snippets_VBCSharp/VbVbcnMyFileSystem/VB/Class1.vb#52)]  
  
## <a name="robust-programming"></a>Отказоустойчивость  

 Исключение может возникнуть в следующих случаях:  
  
- Путь является недопустимым, так как он представляет собой строку нулевой длины (пустую строку), либо содержит только пробелы, либо содержит недопустимые знаки, либо представляет собой путь к устройству (начинается с символов \\\\.\\) (<xref:System.ArgumentException>).  
  
- Системе не удалось получить абсолютный путь (<xref:System.ArgumentException>).  
  
- Путь не является допустимым, поскольку он равен `Nothing` (<xref:System.ArgumentNullException>).  
  
- Исходный файл является недопустимым или не существует (<xref:System.IO.FileNotFoundException>).  
  
- Объединенный путь указывает на существующий каталог (<xref:System.IO.IOException>).  
  
- Конечный файл существует, а параметр `overwrite` имеет значение `False` (<xref:System.IO.IOException>).  
  
- У пользователя нет необходимых разрешений для доступа к файлу (<xref:System.IO.IOException>).  
  
- Файл в папке назначения с тем же именем уже используется (<xref:System.IO.IOException>).  
  
- Имя файла или папки в пути содержит двоеточие (:) или имеет недопустимый формат (<xref:System.NotSupportedException>).  
  
- Параметр `ShowUI` имеет значение `True`, параметр `onUserCancel` имеет значение `ThrowException`, и пользователь отменил операцию (<xref:System.OperationCanceledException>).  
  
- `ShowUI` имеет значение `True`, параметр `onUserCancel` имеет значение `ThrowException`, и возникла неопределенная ошибка ввода-вывода (<xref:System.OperationCanceledException>).  
  
- Длина пути превышает максимальную длину, определенную в системе (<xref:System.IO.PathTooLongException>).  
  
- У пользователя отсутствует необходимое разрешение (<xref:System.UnauthorizedAccessException>).  
  
- У пользователя отсутствуют необходимые разрешения на просмотр пути (<xref:System.Security.SecurityException>).  
  
## <a name="see-also"></a>См. также раздел

- <xref:Microsoft.VisualBasic.FileIO.FileSystem>
- <xref:Microsoft.VisualBasic.FileIO.FileSystem.CopyFile%2A>
- <xref:Microsoft.VisualBasic.FileIO.UICancelOption>
- [Практическое руководство. Копирование файлов с определенным шаблоном в каталог](how-to-copy-files-with-a-specific-pattern-to-a-directory.md)
- [Практическое руководство. Создание копии файла в другом каталоге](how-to-create-a-copy-of-a-file-in-a-different-directory.md)
- [Практическое руководство. Копирование каталога в другой каталог](how-to-copy-a-directory-to-another-directory.md)
- [Практическое руководство. Переименование файла](how-to-rename-a-file.md)
