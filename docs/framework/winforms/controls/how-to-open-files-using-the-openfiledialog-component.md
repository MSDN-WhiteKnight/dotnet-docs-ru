---
title: Практическое руководство. Открывать файлы с помощью компонента OpenFileDialog
ms.date: 02/11/2019
dev_langs:
- csharp
- vb
helpviewer_keywords:
- OpenFileDialog component [Windows Forms], opening files
- OpenFile method [Windows Forms], OpenFileDialog component
- files [Windows Forms], opening with OpenFileDialog component
ms.assetid: 9d88367a-cc21-4ffd-be74-89fd63767d35
ms.openlocfilehash: 7f4e96f1714a182647665f12e29d38f2b8037478
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59159111"
---
# <a name="how-to-open-files-with-the-openfiledialog"></a>Практическое руководство. Открытие файлов с использованием OpenFileDialog 

<xref:System.Windows.Forms.OpenFileDialog?displayProperty=nameWithType> Компонент открывает диалоговое окно Windows для просмотра и выбора файлов. Чтобы открыть и прочитать выбранных файлов, можно использовать <xref:System.Windows.Forms.OpenFileDialog.OpenFile%2A?displayProperty=nameWithType> метод, или создать экземпляр <xref:System.IO.StreamReader?displayProperty=nameWithType> класса. В следующих примерах оба подхода. 

В .NET Framework, для получения или задания <xref:System.Windows.Forms.FileDialog.FileName%2A> свойство требуется уровень привилегий предоставляемый <xref:System.Security.Permissions.FileIOPermission?displayProperty=nameWithType> класса. Примеры выполняют <xref:System.Security.Permissions.FileIOPermission> разрешение проверки и может создавать исключения из-за недостатка привилегий, если выполняются в контексте частичного доверия. Дополнительные сведения см. в разделе [основы управления доступом для кода](../../misc/code-access-security-basics.md).

Можно создавать и запускать эти примеры приложений .NET Framework из C# или командной строки Visual Basic. Дополнительные сведения см. в разделе [сборка с помощью csc.exe из командной строки](../../../csharp/language-reference/compiler-options/command-line-building-with-csc-exe.md) или [построения из командной строки](../../../visual-basic/reference/command-line-compiler/building-from-the-command-line.md). 

Начиная с .NET Core 3.0, вы можете также создавать и выполнять примеры как Windows приложений .NET Core из папки с .NET Core Windows Forms  *\<имя_папки > .csproj* файл проекта. 

## <a name="example-read-a-file-as-a-stream-with-streamreader"></a>Пример Чтение файла в виде потока с помощью StreamReader  
  
В следующем примере используется Windows Forms <xref:System.Windows.Forms.Button> элемента управления <xref:System.Windows.Forms.Control.Click> обработчик событий, чтобы открыть <xref:System.Windows.Forms.OpenFileDialog> с <xref:System.Windows.Forms.CommonDialog.ShowDialog%2A> метод. Когда пользователь выберет файл, а также выбирает **ОК**, экземпляр <xref:System.IO.StreamReader> класс читает файл и выведет его содержимое в текстовое поле формы. Дополнительные сведения о чтении из файловых потоков, см. в разделе <xref:System.IO.FileStream.BeginRead%2A?displayProperty=nameWithType> и <xref:System.IO.FileStream.Read%2A?displayProperty=nameWithType>.  

 [!code-csharp[OpenFileDialog#1](~/samples/snippets/winforms/open-files/example1/cs/Form1.cs)]
   

## <a name="example-open-a-file-from-a-filtered-selection-with-openfile"></a>Пример Откройте файл из отфильтрованные объекты с помощью OpenFile 

В следующем примере используется <xref:System.Windows.Forms.Button> элемента управления <xref:System.Windows.Forms.Control.Click> обработчик событий, чтобы открыть <xref:System.Windows.Forms.OpenFileDialog> с фильтром, который показывает только текстовые файлы. Когда пользователь выберет в текстовый файл, а также выбирает **ОК**, <xref:System.Windows.Forms.OpenFileDialog.OpenFile%2A> метод используется, чтобы открыть файл в блокноте.

 [!code-csharp[OpenFileDialog#2](~/samples/snippets/winforms/open-files/example2/cs/Form1.cs)]
   

## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.OpenFileDialog>
- [OpenFileDialog - компонент](openfiledialog-component-windows-forms.md)
