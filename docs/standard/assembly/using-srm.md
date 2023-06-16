---
title: Использование библиотеки System.Reflection.Metadata
description: В этой статье описывается библиотека System.Reflection.Metadata, которая позволяет программно обрабатывать и генерировать управляемые сборки в .NET.
ms.contentlocale: ru-RU
author: MSDN-WhiteKnight
---

# Использование библиотеки System.Reflection.Metadata

В .NET для программной обработки сборок обычно используется отражение (reflection). Однако, отражение может работать только со сборками, загруженными в текущий контекст выполнения, поэтому оно имеет определенные ограничения: можно прочитать только сборки для той же целевой платформы, что и выполняемое приложение, все зависимости считываемой сборки должны быть доступны и др. Кроме того, отражение является довольно тяжелым и медленным механизмом. Компиляторам и утилитам для статического анализа нужен более быстрый низкоуровневый инструмент. Таким инструментом является библиотека **System.Reflection.Metadata**, созданная командой разработчиков .NET. Эта библиотека собирается из исходников в репозитории [.NET Runtime](https://github.com/dotnet/runtime). Для ее использования в .NET Framework необходимо подключить пакет NuGet [System.Reflection.Metadata](https://www.nuget.org/packages/System.Reflection.Metadata).

Эта библиотека является низкоуровневой и оперирует таблицами и кучами, составляющими формат метаданных CLI. Этот формат определен стандартом ECMA-335, подробнее см. [Standard ECMA-335 - Common Language Infrastructure (CLI)](http://www.ecma-international.org/publications/standards/Ecma-335.htm) на сайте ECMA. System.Reflection.Metadata рекомендуется к использованию разработчикам компиляторов и различных библиотек для работы со сборками. Тем, кому нужен более высокоуровневый инструмент, работающий по аналогии с отражением, лучше использовать <xref:System.Reflection.MetadataLoadContext>.

## Класс MetadataReader

Для чтения содержимого метаданных сборок используется класс <xref:System.Reflection.Metadata.MetadataReader>. Для создания объекта этого класса можно использовать конструктор, например  <xref:System.Reflection.Metadata.MetadataReader.%23ctor(System.Byte%2A,System.Int32)> создает <xref:System.Reflection.Metadata.MetadataReader> на основе данных в указанном участке памяти. Для считывания метаданных из файла сборки формата Portable Executable, создайте экземпляр <xref:System.Reflection.PortableExecutable.PEReader> и используйте метод расширения  <xref:System.Reflection.Metadata.PEReaderExtensions.GetMetadataReader(System.Reflection.PortableExecutable.PEReader)>.

Следующий пример показывает, как создать <xref:System.Reflection.Metadata.MetadataReader> для сборки и считать из него все определения типов:

    using var fs = new FileStream("Example.dll", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
    using var peReader = new PEReader(fs);

    MetadataReader mr = peReader.GetMetadataReader();

    foreach (TypeDefinitionHandle tdefh in mr.TypeDefinitions)
    {
        TypeDefinition tdef = mr.GetTypeDefinition(tdefh);

        string ns = mr.GetString(tdef.Namespace);
        string name = mr.GetString(tdef.Name);
        Console.WriteLine($"{ns}.{name}");
    }

## Класс MethodBodyBlock

Тело метода в сборке .NET содержит инструкции Common Intermediate Language (CIL), которые определяют логику метода, а также информацию о его локальных переменных и блоках обработки исключений. Класс <xref:System.Reflection.Metadata.MethodBodyBlock> предназначен для считывания этой информации. Для получения экземпляра `MethodBodyBlock` конкретного метода используется метод <xref:System.Reflection.Metadata.PEReaderExtensions.GetMethodBody%2A>.

Следующий пример показывает, как получить тела всех методов в указанном определении типа и отобразить информацию о них:

    static void PrintMethods(PEReader reader, MetadataReader mr, TypeDefinition tdef)
    {
        MethodDefinitionHandleCollection methods = tdef.GetMethods();

        foreach (MethodDefinitionHandle mdefh in methods)
        {
            MethodDefinition mdef = mr.GetMethodDefinition(mdefh);
            string mname = mr.GetString(mdef.Name);
            Console.WriteLine($"Method: {mname}");

            // Get the relative address of the method body in the executable
            int rva = mdef.RelativeVirtualAddress;

            if (rva == 0)
            {
                Console.WriteLine("Method body not found");
                Console.WriteLine();
                continue;
            }

            // Get method body information
            MethodBodyBlock mb = reader.GetMethodBody(rva);
            Console.WriteLine($"  Maximum stack size: {mb.MaxStack}");
            Console.WriteLine($"  Local variables initialized: {mb.LocalVariablesInitialized}");

            byte[] il = mb.GetILBytes();
            Console.WriteLine($"  Method body size: {il.Length}");
            Console.WriteLine($"  Exception regions: {mb.ExceptionRegions.Length}");
            Console.WriteLine();

            foreach (var region in mb.ExceptionRegions)
            {
                Console.WriteLine(region.Kind.ToString());
                Console.WriteLine($"  Try block offset: {region.TryOffset}");
                Console.WriteLine($"  Try block length: {region.TryLength}");
                Console.WriteLine($"  Handler offset: {region.HandlerOffset}");
                Console.WriteLine($"  Handler length: {region.HandlerLength}");
                Console.WriteLine();
            }
        }
    }

## Класс MetadataBuilder 

Класс <xref:System.Reflection.Metadata.Ecma335.MetadataBuilder> позволяет программно генерировать сборки .NET. Эти сборки можно сохранить в файл, в отличие от динамических сборок, сгенерированных с помощью класса <xref:System.Reflection.Emit.AssemblyBuilder>, который не поддерживает сохранение сборок в файл в .NET 5+ и .NET Core. 
API `MetadataBuilder` оперирует низкоуровневыми структурами метаданных, например, таблицами или бинарными объектами BLOB. Если вам нужен более простой способ динамической генерации сборок с использованием C#, см. <xref:Microsoft.CodeAnalysis.CSharp.CSharpCompilation> в Roslyn API.

Следующий пример показывает, как создать <xref:System.Reflection.Metadata.Ecma335.MetadataBuilder>:

    var peStream = new FileStream(
        "ConsoleApplication.dll", FileMode.OpenOrCreate, FileAccess.ReadWrite
    );

    using (peStream)
    {
        var ilBuilder = new BlobBuilder();
        var metadataBuilder = new MetadataBuilder();
    }
    
Следующий пример показывает, как добавить определение модуля и сборки в `MetadataBuilder`:

    Guid guid = new Guid("17D5DBE1-1143-3FAD-AAB3-1002F92068E7");
    
    metadataBuilder.AddModule(
        0,
        metadataBuilder.GetOrAddString("ConsoleApplication.dll"),
        metadataBuilder.GetOrAddGuid(guid),
        default(GuidHandle),
        default(GuidHandle));

    metadataBuilder.AddAssembly(
        metadataBuilder.GetOrAddString("ConsoleApplication"),
        version: new Version(1, 0, 0, 0),
        culture: default(StringHandle),
        publicKey: default(BlobHandle),
        flags: 0,
        hashAlgorithm: AssemblyHashAlgorithm.None);
        
Более подробный пример создания сборки см. на GitHub: [Generate .NET Core assembly using MetadataBuilder](https://github.com/MSDN-WhiteKnight/CodeSamples/tree/master/System.Reflection.Metadata/MetadataBuilder).

## См. также

- [Сборки в .NET](index.md)
- [Манифест сборки](manifest.md)
- [Отражение](https://docs.microsoft.com/dotnet/framework/reflection-and-codedom/reflection)
- [Практическое руководство. Проверка содержимого сборки с помощью MetadataLoadContext](inspect-contents-using-metadataloadcontext.md)
- <xref:System.Reflection.Metadata>
