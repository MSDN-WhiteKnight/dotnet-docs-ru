---
title: Практическое руководство. Определение того, является ли файл сборкой
description: В этой статье показано, как вручную или программным способом определить, является ли файл сборкой .NET.
ms.sourcegitcommit: d8020797a6657d0fbbdff362b80300815f682f94
ms.contentlocale: ru-RU
---

# <a name="how-to-determine-if-a-file-is-an-assembly"></a>Практическое руководство. Определение того, является ли файл сборкой

Файл является сборкой только в том случае, если он является управляемым и содержит запись сборки в своих метаданных. Дополнительные сведения о сборках и метаданных см. в разделе [Манифест сборки](manifest.md).  
  
## <a name="how-to-manually-determine-if-a-file-is-an-assembly"></a>Как вручную определить, является ли файл сборкой  
  
1. Запустите [Ildasm.exe (дизассемблер IL)](../../framework/tools/ildasm-exe-il-disassembler.md).  
  
2. Загрузите файл, который нужно проверить.  
  
3. Если программа **ILDASM** сообщает, что файл не является переносимым исполняемым файлом (PE), то он не является сборкой. Дополнительные сведения см. в разделе [Практическое руководство. Просмотр содержимого сборки](view-contents.md).  
  
## <a name="how-to-programmatically-determine-if-a-file-is-an-assembly"></a>Как программно определить, является ли файл сборкой

### С использованием класса AssemblyName
  
1. Вызовите метод <xref:System.Reflection.AssemblyName.GetAssemblyName%2A?displayProperty=nameWithType>, указав полный путь к файлу и имя файла, который вы хотите проверить.  
  
2. Если возникает исключение <xref:System.BadImageFormatException>, значит файл не является сборкой.  
  
## <a name="example"></a>Пример  

Этот пример кода проверяет, является ли библиотека DLL сборкой.  

[!code-csharp[](snippets/identify/csharp/ExampleAssemblyName.cs#AssemblyName)]

Метод <xref:System.Reflection.AssemblyName.GetAssemblyName%2A> загружает тестовый файл и освобождает его после того, как информация будет прочитана.  

### С использованием класса PEReader

1. Установите NuGet пакет [System.Reflection.Metadata](https://www.nuget.org/packages/System.Reflection.Metadata/).

2. Создайте экземпляр <xref:System.IO.FileStream?displayProperty=nameWithType> для чтения данных из файла, который вы хотите проверить.

3. Создайте экземпляр <xref:System.Reflection.PortableExecutable.PEReader?displayProperty=nameWithType>, передав созданный на предыдущем шаге файловый поток в его конструктор.

4. Проверьте значение свойства <xref:System.Reflection.PortableExecutable.PEReader.HasMetadata>. Если оно равно `false`, файл не является сборкой.

5. Вызовите метод <xref:System.Reflection.Metadata.PEReaderExtensions.GetMetadataReader%2A> на экземпляре `PEReader` для создания `MetadataReader`.

6. Проверьте значение свойства <xref:System.Reflection.Metadata.MetadataReader.IsAssembly>. Если оно равно `true`, файл является сборкой.

В отличие от <xref:System.Reflection.AssemblyName.GetAssemblyName%2A>, класс <xref:System.Reflection.PortableExecutable.PEReader> не создает исключение при попытке чтения неуправляемых исполняемых файлов. Это позволяет избежать потерь производительности на генерацию исключений, если вам нужно проверять такие файлы. Исключения все равно нужно обрабатывать, на случай, если файл не существует или не является исполняемым файлом.

Этот пример кода показывает, является ли файл сборкой, используя <xref:System.Reflection.PortableExecutable.PEReader>.

[!code-csharp[](snippets/identify/csharp/ExamplePeReader.cs#PeReader)]

## <a name="see-also"></a>См. также

- <xref:System.Reflection.AssemblyName>
- [Руководство по программированию на C#](../../csharp/programming-guide/index.md)
- [Основные понятия программирования (Visual Basic)](../../visual-basic/programming-guide/concepts/index.md)
- [Сборки в .NET](index.md)
