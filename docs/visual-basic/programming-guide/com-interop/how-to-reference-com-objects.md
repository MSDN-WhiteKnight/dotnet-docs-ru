---
description: Дополнительные сведения см. в статье как ссылаться на COM-объекты из Visual Basic
title: Практическое руководство. Ссылка на COM-объект в Visual Basic
ms.date: 07/20/2015
helpviewer_keywords:
- COM interop [Visual Basic], referencing COM objects
- referencing objects, COM objects from Visual Basic
- objects [Visual Basic], referencing
- COM objects, referencing
- interop assemblies
ms.assetid: 9c518fb4-27d9-4112-9e6a-5a7d0210af6f
ms.openlocfilehash: f0c08e5be9144bdefc3fe0b4609bad2421889d52
ms.sourcegitcommit: 10e719780594efc781b15295e499c66f316068b8
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/14/2021
ms.locfileid: "100477571"
---
# <a name="how-to-reference-com-objects-from-visual-basic"></a>Практическое руководство. Ссылка на COM-объект в Visual Basic

В Visual Basic добавление ссылок на COM-объекты, имеющие библиотеки типов, требует создания сборки взаимодействия для библиотеки COM. Ссылки на члены COM-объекта направляются в сборку взаимодействия, а затем пересылаются на фактический COM-объект. Ответы от COM-объекта направляются в сборку взаимодействия и пересылаются в приложение платформа .NET Framework.  
  
 Вы можете ссылаться на COM-объект без использования сборки взаимодействия, внедрив сведения о типе для COM-объекта в сборку .NET. Чтобы внедрить сведения о типе, задайте `Embed Interop Types` для свойства значение, чтобы `True` получить ссылку на COM-объект. При компиляции с помощью компилятора командной строки используйте `/link` параметр для ссылки на БИБЛИОТЕКУ com. Дополнительные сведения см. в разделе [-Link (Visual Basic)](../../reference/command-line-compiler/link.md).  
  
 Visual Basic автоматически создает сборки взаимодействия при добавлении ссылки на библиотеку типов из интегрированной среды разработки (IDE). При работе из командной строки можно использовать служебную программу Tlbimp для создания сборок взаимодействия вручную.  
  
### <a name="to-add-references-to-com-objects"></a>Добавление ссылок на COM-объекты  
  
1. В меню **проект** выберите команду **Добавить ссылку** , а затем откройте вкладку **com** в диалоговом окне.  
  
2. Выберите компонент, который вы хотите использовать, из списка COM-объектов.  
  
3. Чтобы упростить доступ к сборке взаимодействия, добавьте `Imports` оператор в начало класса или модуля, в котором будет использоваться COM-объект. Например, в следующем примере кода выполняется импорт пространства имен `INKEDLib` для объектов, упоминаемых в `Microsoft InkEdit Control 1.0` библиотеке.  
  
     [!code-vb[VbVbalrInterop#40](~/samples/snippets/visualbasic/VS_Snippets_VBCSharp/VbVbalrInterop/VB/Class1.vb#40)]  
  
### <a name="to-create-an-interop-assembly-using-tlbimp"></a>Создание сборки взаимодействия с помощью программы Tlbimp  
  
1. Добавьте расположение программы Tlbimp в путь поиска, если он еще не является частью пути поиска, и вы не находитесь в каталоге, в котором он находится.  
  
2. Вызовите программу Tlbimp из командной строки, предоставив следующую информацию:  
  
    - Имя и расположение библиотеки DLL, содержащей библиотеку типов  
  
    - Имя и расположение пространства имен, в которое следует поместить данные  
  
    - Имя и расположение целевой сборки взаимодействия  
  
     Примером является следующий код:  
  
    ```console  
    Tlbimp test3.dll /out:NameSpace1 /out:Interop1.dll  
    ```  
  
     Программу Tlbimp можно использовать для создания сборок взаимодействия для библиотек типов, даже для незарегистрированных COM-объектов. Однако COM-объекты, на которые ссылаются сборки взаимодействия, должны быть правильно зарегистрированы на компьютере, где они будут использоваться. Вы можете зарегистрировать COM-объект с помощью служебной программы regsvr32, входящей в состав операционной системы Windows.  
  
## <a name="see-also"></a>См. также раздел

- [COM-взаимодействие](index.md)
- [Tlbimp.exe (программа экспорта библиотек типов)](../../../framework/tools/tlbimp-exe-type-library-importer.md)
- [Tlbexp.exe (программа экспорта библиотек типов)](../../../framework/tools/tlbexp-exe-type-library-exporter.md)
- [Пошаговое руководство. Реализация наследования с использованием COM-объектов](walkthrough-implementing-inheritance-with-com-objects.md)
- [Устранение неполадок взаимодействия](troubleshooting-interoperability.md)
- [Оператор Imports (пространство имен .NET и тип)](../../language-reference/statements/imports-statement-net-namespace-and-type.md)
