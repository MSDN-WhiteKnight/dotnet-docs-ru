---
description: 'Подробнее о следующем: Практическое руководство. Копирование файлов в каталог с использованием шаблона в Visual Basic'
title: Практическое руководство. Копирование файлов с определенным шаблоном в каталог
ms.date: 07/20/2015
helpviewer_keywords:
- My.Computer.FileSystem.CopyFile method, copying files [Visual Basic]
- files [Visual Basic], copying
- CopyFile method [Visual Basic], copying files in Visual Basic
- I/O [Visual Basic], copying files
ms.assetid: f205d2ad-bbe5-4d55-8a40-acda21aa82dd
ms.openlocfilehash: 2a5163e6420d747a724fec9b8ede8dbcc6a938be
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: HT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99797631"
---
# <a name="how-to-copy-files-with-a-specific-pattern-to-a-directory-in-visual-basic"></a>Практическое руководство. Копирование файлов в каталог с использованием шаблона в Visual Basic

Метод <xref:Microsoft.VisualBasic.MyServices.FileSystemProxy.GetFiles%2A> возвращает доступную только для чтения коллекцию строк, представляющих имена путей для файлов. Для указания определенного шаблона можно использовать параметр `wildCards` .  
  
 Если соответствующие файлы не найдены, возвращается пустая коллекция.  
  
 Для копирования файлов в каталог можно использовать метод <xref:Microsoft.VisualBasic.FileIO.FileSystem.CopyFile%2A> .  
  
### <a name="to-copy-files-with-a-specific-pattern-to-a-directory"></a>Копирование файлов с определенным шаблоном в каталог  
  
1. Используйте метод `GetFiles` для возврата списка файлов. В этом примере возвращены все RTF-файлы в указанном каталоге.  
  
     [!code-vb[VbFileIOMisc#36](~/samples/snippets/visualbasic/VS_Snippets_VBCSharp/VbFileIOMisc/VB/Class1.vb#36)]  
  
2. Используйте метод `CopyFile` для копирования файлов. В этом примере файлы копируются в каталог с именем `testdirectory`.  
  
     [!code-vb[VbVbcnMyFileSystem#88](~/samples/snippets/visualbasic/VS_Snippets_VBCSharp/VbVbcnMyFileSystem/VB/Class1.vb#88)]  
  
3. Закройте оператор `For` с помощью оператора `Next` .  
  
     [!code-vb[VbVbcnMyFileSystem#89](~/samples/snippets/visualbasic/VS_Snippets_VBCSharp/VbVbcnMyFileSystem/VB/Class1.vb#89)]  
  
## <a name="example"></a>Пример  

 В следующем примере, который представляет вышеописанные фрагменты в завершенной форме, RTF-файлы копируются из указанного каталога в каталог с именем `testdirectory`.  
  
 [!code-vb[VbFileIOMisc#37](~/samples/snippets/visualbasic/VS_Snippets_VBCSharp/VbFileIOMisc/VB/Class1.vb#37)]  
  
## <a name="net-framework-security"></a>Безопасность .NET Framework  

 При следующих условиях возможно возникновение исключения:  
  
- Путь является недопустимым, так как он представляет собой строку нулевой длины (пустую строку), либо содержит только пробелы, либо содержит недопустимые знаки, либо представляет собой путь к устройству (начинается с символов \\\\.\\) (<xref:System.ArgumentException>).  
  
- Путь не является допустимым, поскольку он равен `Nothing` (<xref:System.ArgumentNullException>).  
  
- Каталог не существует (<xref:System.IO.DirectoryNotFoundException>).  
  
- Каталог указывает на существующий файл (<xref:System.IO.IOException>).  
  
- Длина пути превышает максимальную длину, определенную в системе (<xref:System.IO.PathTooLongException>).  
  
- Имя файла или каталога в пути содержит двоеточие (:) или имеет недопустимый формат (<xref:System.NotSupportedException>).  
  
- У пользователя отсутствуют необходимые разрешения на просмотр пути (<xref:System.Security.SecurityException>). У пользователя отсутствуют необходимые разрешения (<xref:System.UnauthorizedAccessException>).  
  
## <a name="see-also"></a>См. также раздел

- <xref:Microsoft.VisualBasic.FileIO.FileSystem.CopyFile%2A>
- <xref:Microsoft.VisualBasic.MyServices.FileSystemProxy.GetFiles%2A>
- [Практическое руководство. Поиск подкаталогов по заданному шаблону](how-to-find-subdirectories-with-a-specific-pattern.md)
- [Устранение неполадок: Чтение из текстовых файлов и запись в такие файлы](troubleshooting-reading-from-and-writing-to-text-files.md)
- [Практическое руководство. Получение коллекции содержащихся в каталоге файлов](how-to-get-the-collection-of-files-in-a-directory.md)
