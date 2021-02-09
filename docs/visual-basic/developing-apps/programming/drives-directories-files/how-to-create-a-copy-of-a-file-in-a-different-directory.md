---
description: 'Подробнее о следующем: Практическое руководство. Создание копии файла в другом каталоге в Visual Basic'
title: Практическое руководство. Создание копии файла в другом каталоге
ms.date: 07/20/2015
helpviewer_keywords:
- My.Computer.FileSystem.CopyFile method, copying files [Visual Basic]
- files [Visual Basic], copying
- CopyFile method [Visual Basic], copying files in Visual Basic
- I/O [Visual Basic], copying files
ms.assetid: 88e2145c-d414-45a5-ad03-6f5d58ecca26
ms.openlocfilehash: 128a813ec3e5c759d5320d59a1e83f9d66af3bbd
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: HT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99797644"
---
# <a name="how-to-create-a-copy-of-a-file-in-a-different-directory-in-visual-basic"></a>Практическое руководство. Создание копии файла в другом каталоге в Visual Basic

Метод `My.Computer.FileSystem.CopyFile` позволяет копировать файлы. Его параметры обеспечивают возможность перезаписи существующих файлов, переименования файлов и отображения хода выполнения операции, а также отмены операции пользователем.  
  
### <a name="to-copy-a-text-file-to-another-folder"></a>Копирование текстового файла в другую папку  
  
- Используйте для копирования файла метод `CopyFile`, исходный файл и целевой каталог. Параметр `overwrite` позволяет указать, следует ли перезаписывать существующие файлы. В следующем примере кода демонстрируется использование метода `CopyFile`.  
  
     [!code-vb[VbFileIOMisc#24](~/samples/snippets/visualbasic/VS_Snippets_VBCSharp/VbFileIOMisc/VB/Class1.vb#24)]  
  
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
- [Практическое руководство. Создание копии файла в том же каталоге](how-to-create-a-copy-of-a-file-in-the-same-directory.md)
- [Практическое руководство. Копирование каталога в другой каталог](how-to-copy-a-directory-to-another-directory.md)
- [Практическое руководство. Переименование файла](how-to-rename-a-file.md)
