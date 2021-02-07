---
description: 'Дополнительные сведения о: BC30145: не удается выпустить сборку: <error message>'
title: 'Не удается выпустить сборку: <error message>'
ms.date: 08/14/2018
f1_keywords:
- vbc30145
- bc30145
helpviewer_keywords:
- BC30145
ms.assetid: 2e7eb2b9-eda6-4bdb-95cc-72c7f0be7528
ms.openlocfilehash: 015ab6e1d186495d72bddd65678ab15088c0f1b2
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99674887"
---
# <a name="bc30145-unable-to-emit-assembly-error-message"></a>BC30145: не удалось выпустить сборку: \<error message>

Компилятор Visual Basic вызывает компоновщик сборок (*Al.exe*, также известный как ALink) для создания сборки с манифестом, а компоновщик сообщает об ошибке на этапе эмиссии создания сборки.

**Идентификатор ошибки:** BC30145

## <a name="to-correct-this-error"></a>Исправление ошибки

1. Изучите сообщение об ошибке в кавычках и ознакомьтесь с разделом [Al.exe](../../../framework/tools/al-exe-assembly-linker.md) для получения дополнительных пояснений и рекомендаций.

2. Попробуйте подписать сборку вручную, используя [Al.exe](../../../framework/tools/al-exe-assembly-linker.md) или [Sn.exe (средство строгих имен)](../../../framework/tools/sn-exe-strong-name-tool.md).

3. Если ошибка не устранена, соберите сведения об условиях ее возникновения и уведомите службу технической поддержки Майкрософт.

### <a name="to-sign-the-assembly-manually"></a>Подпись сборки вручную

1. Используйте [Sn.exe (средство строгих имен)](../../../framework/tools/sn-exe-strong-name-tool.md)) для создания файла пары открытого и закрытого ключей.

   Этот файл имеет расширение *SNK* .

2. Удалите из проекта ссылку COM, вызывающую ошибку.

3. Откройте [Командная строка разработчика для Visual Studio](../../../framework/tools/developer-command-prompt-for-vs.md).

   В Windows 10 введите **командную строку разработчика** в поле поиска на панели задач. Затем выберите **Командная строка разработчика для VS 2017** в списке результатов.

4. Измените каталог на каталог, в который нужно поместить обертку сборки.

5. Введите следующую команду:

    ```cmd
    tlbimp <path to COM reference file> /out:<output assembly name> /keyfile:<path to .snk file>
    ```

   Пример реальной команды, которую можно ввести:

    ```cmd
    tlbimp c:\windows\system32\msi.dll /out:Interop.WindowsInstaller.dll /keyfile:"c:\documents and settings\mykey.snk"
    ```

   > [!TIP]
   > Если путь или файл содержит пробелы, используйте двойные кавычки.

6. В Visual Studio добавьте ссылку на сборку .NET в только что созданный файл.

## <a name="see-also"></a>См. также

- [Al.exe](../../../framework/tools/al-exe-assembly-linker.md)
- [Sn.exe (средство строгих имен)](../../../framework/tools/sn-exe-strong-name-tool.md)
- [Практическое руководство. Создание пары открытого и закрытого ключей](../../../standard/assembly/create-public-private-key-pair.md)
- [Обращайтесь к нам](/visualstudio/ide/feedback-options)
