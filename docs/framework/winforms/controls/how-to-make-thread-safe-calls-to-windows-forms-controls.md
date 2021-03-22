---
title: Практическое руководство. Сделать потокобезопасных вызовов элементов управления Windows Forms
ms.date: 02/19/2019
dev_langs:
- csharp
- vb
f1_keywords:
- EHInvalidOperation.WinForms.IllegalCrossThreadCall
helpviewer_keywords:
- thread safety [Windows Forms], calling controls [Windows Forms]
- calling controls [Windows Forms], thread safety [Windows Forms]
- CheckForIllegalCrossThreadCalls property [Windows Forms]
- Windows Forms controls [Windows Forms], multithreading
- BackgroundWorker class [Windows Forms], examples
- threading [Windows Forms], cross-thread calls
- controls [Windows Forms], multithreading
ms.assetid: 138f38b6-1099-4fd5-910c-390b41cbad35
ms.openlocfilehash: 3211df1f0e585780039471b80b5b913613ad9bbd
ms.sourcegitcommit: 160a88c8087b0e63606e6e35f9bd57fa5f69c168
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/09/2019
ms.locfileid: "57714012"
---
# <a name="how-to-make-thread-safe-calls-to-windows-forms-controls"></a>Практическое руководство. Сделать потокобезопасных вызовов элементов управления Windows Forms

Многопотоковость позволяет повысить производительность приложений Windows Forms, но доступ к элементам управления Windows Forms не по своей природе потокобезопасными. Многопоточность можно предоставить код, чтобы очень серьезных и сложных ошибок. Два или более потоков, управление элементом управления можно перевести в несогласованном состоянии и привести к гонки, взаимоблокировки и перестает отвечать или зависает. При реализации многопоточности в приложении, убедитесь, что для вызова элементов управления между потоками в потокобезопасным способом. Дополнительные сведения см. в разделе [управляемых потоков рекомендации](../../../standard/threading/managed-threading-best-practices.md). 

Безопасно вызвать элемент управления Windows Forms из потока, который не создавали этого элемента управления двумя способами. Можно использовать <xref:System.Windows.Forms.Control.Invoke%2A?displayProperty=fullName> метод для вызова делегата, созданного в основном потоке, который в свою очередь вызывает элемент управления. Или можно реализовать <xref:System.ComponentModel.BackgroundWorker?displayProperty=nameWithType>, который использует модель на основе событий для разделения работы, выполненной в фоновом потоке из отчетов о результатах. 

## <a name="unsafe-cross-thread-calls"></a>Ориентированные вызовы между потоками

Вызов элемента управления непосредственно из потока, который не создавали его небезопасно. В следующем фрагменте кода показано небезопасный вызов <xref:System.Windows.Forms.TextBox?displayProperty=nameWithType> элемента управления. `Button1_Click` Обработчик событий создает новую `WriteTextUnsafe` поток, который задает основной поток <xref:System.Windows.Forms.TextBox.Text%2A?displayProperty=nameWithType> свойство напрямую. 

```csharp
private void Button1_Click(object sender, EventArgs e)
{
    thread2 = new Thread(new ThreadStart(WriteTextUnsafe));
    thread2.Start();
}
private void WriteTextUnsafe()
{
    textBox1.Text = "This text was set unsafely.";
}
```

```vb
Private Sub Button1_Click(ByVal sender As Object, e As EventArgs) Handles Button1.Click
    Thread2 = New Thread(New ThreadStart(AddressOf WriteTextUnsafe))
    Thread2.Start()
End Sub

Private Sub WriteTextUnsafe()
    TextBox1.Text = "This text was set unsafely."
End Sub
```

Отладчик Visual Studio обнаруживает эти вызовы небезопасный потока, вызывая <xref:System.InvalidOperationException> с сообщением, **не является допустимым, операция в нескольких потоках. Элемент управления «» получить доступ из потока, отличного от потока, он был создан.** <xref:System.InvalidOperationException> Всегда возникает ориентированные вызовы между потоками во время отладки Visual Studio и может возникнуть во время выполнения приложения. Вам следует устранить проблему, однако исключение можно отключить, установив <xref:System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls%2A?displayProperty=nameWithType> свойства `false`.

## <a name="safe-cross-thread-calls"></a>Безопасные вызовы между потоками 

В следующих примерах кода демонстрируются два способа безопасно вызвать элемент управления Windows Forms из потока, который не создавали его: 
1. <xref:System.Windows.Forms.Control.Invoke%2A?displayProperty=fullName> Метод, который вызывает делегат из основного потока для вызова элемента управления. 
2. Объект <xref:System.ComponentModel.BackgroundWorker?displayProperty=nameWithType> компонент, который предоставляет модель на основе событий. 

В обоих примерах фона поток бездействует одну секунду имитировать работу, выполняемую в этом потоке. 

Можно создавать и запускать эти примеры приложений .NET Framework из C# или командной строки Visual Basic. Дополнительные сведения см. в разделе [сборка с помощью csc.exe из командной строки](../../../csharp/language-reference/compiler-options/command-line-building-with-csc-exe.md) или [построения из командной строки (Visual Basic)](../../../visual-basic/reference/command-line-compiler/building-from-the-command-line.md). 

Начиная с .NET Core 3.0, вы можете также создавать и выполнять примеры как Windows приложений .NET Core из папки с .NET Core Windows Forms  *\<имя_папки > .csproj* файл проекта. 

## <a name="example-use-the-invoke-method-with-a-delegate"></a>Пример Метод Invoke с помощью делегата

Ниже приведен пример шаблона для обеспечения потокобезопасных вызовов к элементу управления Windows Forms. Он запрашивает <xref:System.Windows.Forms.Control.InvokeRequired%2A?displayProperty=fullName> свойство, которое сравнивает элемент управления создание идентификатор потока, чтобы идентификатор вызывающего потока. Если идентификаторы совпадают, он вызывает элемент управления напрямую. Если идентификаторы различаются, он вызывает <xref:System.Windows.Forms.Control.Invoke%2A?displayProperty=nameWithType> метод с делегатом из основного потока, который выполняет фактический вызов к элементу управления.

`SafeCallDelegate` Позволяет задавать <xref:System.Windows.Forms.TextBox> элемента управления <xref:System.Windows.Forms.TextBox.Text%2A> свойство. `WriteTextSafe` Запросы метод <xref:System.Windows.Forms.Control.InvokeRequired%2A>. Если <xref:System.Windows.Forms.Control.InvokeRequired%2A> возвращает `true`, `WriteTextSafe` передает `SafeCallDelegate` для <xref:System.Windows.Forms.Control.Invoke%2A> метод фактически вызывающим элемент управления. Если <xref:System.Windows.Forms.Control.InvokeRequired%2A> возвращает `false`, `WriteTextSafe` задает <xref:System.Windows.Forms.TextBox.Text%2A?displayProperty=nameWithType> напрямую. `Button1_Click` Обработчик событий создает новый поток и запускает `WriteTextSafe` метод. 

 [!code-csharp[ThreadSafeCalls#1](~/samples/snippets/winforms/thread-safe/example1/cs/Form1.cs)]
   

## <a name="example-use-a-backgroundworker-event-handler"></a>Пример Используйте обработчик событий компонента BackgroundWorker

Простой способ реализации многопоточности является с <xref:System.ComponentModel.BackgroundWorker?displayProperty=nameWithType> компонент, который использует модель на основе событий. Фоновый поток запускает <xref:System.ComponentModel.BackgroundWorker.DoWork?displayProperty=nameWithType> событие, которое не взаимодействует с основным потоком. Основной поток выполняет <xref:System.ComponentModel.BackgroundWorker.ProgressChanged?displayProperty=nameWithType> и <xref:System.ComponentModel.BackgroundWorker.RunWorkerCompleted?displayProperty=nameWithType> обработчиков событий, которые можно вызывать элементы управления в основном потоке.

Звонки с потоками с помощью <xref:System.ComponentModel.BackgroundWorker>, создать метод в фоновый поток для выполнения работы и привяжите его к <xref:System.ComponentModel.BackgroundWorker.DoWork> событий. Создайте другой метод в основном потоке, передавать результаты фоновой работы и привяжите его к <xref:System.ComponentModel.BackgroundWorker.ProgressChanged> или <xref:System.ComponentModel.BackgroundWorker.RunWorkerCompleted> событий. Чтобы запустить фоновый поток, вызовите <xref:System.ComponentModel.BackgroundWorker.RunWorkerAsync%2A?displayProperty=nameWithType>. 

В примере используется <xref:System.ComponentModel.BackgroundWorker.RunWorkerCompleted> обработчик событий, чтобы задать <xref:System.Windows.Forms.TextBox> элемента управления <xref:System.Windows.Forms.TextBox.Text%2A> свойство. В качестве примера использования <xref:System.ComponentModel.BackgroundWorker.ProgressChanged> событий, см. в разделе <xref:System.ComponentModel.BackgroundWorker>. 

 [!code-csharp[ThreadSafeCalls#2](~/samples/snippets/winforms/thread-safe/example2/cs/Form1.cs)]
   

## <a name="see-also"></a>См. также

- <xref:System.ComponentModel.BackgroundWorker>
- [Практическое руководство. Выполнение операции в фоновом режиме](how-to-run-an-operation-in-the-background.md)
- [Практическое руководство. Реализация формы, в который выполняется фоновая операция](how-to-implement-a-form-that-uses-a-background-operation.md)
- [Разработка пользовательских элементов управления Windows Forms в .NET Framework](developing-custom-windows-forms-controls.md)
