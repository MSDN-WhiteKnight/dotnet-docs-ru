---
description: 'Дополнительные сведения: отмена асинхронных задач по истечении определенного периода времени (Visual Basic)'
title: Отмена асинхронных задач после определенного периода времени
ms.date: 07/20/2015
ms.assetid: a48045a3-6a99-42af-b824-af340f0b9a5d
ms.openlocfilehash: fa1711017128dd32f29adfd87a540676371d02cf
ms.sourcegitcommit: 10e719780594efc781b15295e499c66f316068b8
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/14/2021
ms.locfileid: "100431637"
---
# <a name="cancel-async-tasks-after-a-period-of-time-visual-basic"></a>Отмена асинхронных задач после определенного периода времени (Visual Basic)

Если не нужно дожидаться, пока завершится выполнение асинхронной операции, ее можно отменить по истечении определенного периода времени с помощью метода <xref:System.Threading.CancellationTokenSource.CancelAfter%2A?displayProperty=nameWithType>. Этот метод планирует отмену всех связанных задач, не завершенных в течение времени, установленного выражением `CancelAfter`.

В этом примере добавляется код, написанный в статье [Cancel an Async Task or a List of Tasks (Visual Basic)](cancel-an-async-task-or-a-list-of-tasks.md) (Отмена асинхронной задачи или списка задач (Visual Basic)), для скачивания списка веб-сайтов и отображения длины содержимого каждого из них.

> [!NOTE]
> Для выполнения примеров необходимо, чтобы на компьютере были установлены Visual Studio версии 2012 и выше и .NET Framework версии 4.5 и выше.

## <a name="downloading-the-example"></a>Загрузка примера

Скачать полный проект Windows Presentation Foundation (WPF) можно со страницы [Пример асинхронности. Тонкая настройка приложения](https://code.msdn.microsoft.com/Async-Fine-Tuning-Your-a676abea). Затем выполните следующие шаги.

1. Распакуйте загруженный файл, а затем запустите Visual Studio.

2. В строке меню выберите **Файл**, **Открыть**, **Проект/Решение**.

3. В диалоговом окне **Открытие проекта** откройте папку с примером кода, который вы распаковали, а затем откройте файл решения (с разрешением .sln) для AsyncFineTuningVB.

4. В **обозревателе решений** откройте контекстное меню проекта **CancelAfterTime** и выберите команду **Назначить запускаемым проектом**.

5. Нажмите клавишу F5, чтобы запустить проект.

     Нажмите сочетание клавиш CTRL+F5, чтобы запустить проект без отладки.

6. Выполните программу несколько раз, чтобы убедиться, что ее выходные данные могут содержать выходные данные по всем веб-сайтам, по некоторым из них или не содержать никакие данные по веб-сайтам.

 Если вы не хотите скачивать проект, можете просмотреть файл MainWindow.xaml.vb в конце этого раздела.

## <a name="building-the-example"></a>Построение примера

Пример в этом разделе добавляется в проект, созданный в статье [Cancel an Async Task or a List of Tasks (Visual Basic)](cancel-an-async-task-or-a-list-of-tasks.md) (Отмена асинхронной задачи или списка задач (Visual Basic)). В примере используется тот же пользовательский интерфейс, хотя кнопка **Отмена** не используется явно.

Для самостоятельной сборки примера шаг за шагом следуйте инструкциям в разделе "Загрузка примера", но выберите в качестве **запускаемого проекта** проект **CancelAfterOneTask**. Добавьте изменения, приведенные в данном разделе, в этот проект.

Чтобы задать максимальный период времени, по истечении которого задачи будут отмечены как отмененные, добавьте вызов `CancelAfter` в `startButton_Click`, как показано в приведенном ниже примере. Добавления помечены звездочками.

```vb
Private Async Sub startButton_Click(sender As Object, e As RoutedEventArgs)

    ' Instantiate the CancellationTokenSource.
    cts = New CancellationTokenSource()

    resultsTextBox.Clear()

    Try
        ' ***Set up the CancellationTokenSource to cancel after 2.5 seconds. (You
        ' can adjust the time.)
        cts.CancelAfter(2500)

        Await AccessTheWebAsync(cts.Token)
        resultsTextBox.Text &= vbCrLf & "Downloads complete."

    Catch ex As OperationCanceledException
        resultsTextBox.Text &= vbCrLf & "Downloads canceled." & vbCrLf

    Catch ex As Exception
        resultsTextBox.Text &= vbCrLf & "Downloads failed." & vbCrLf
    End Try

    ' Set the CancellationTokenSource to Nothing when the download is complete.
    cts = Nothing
End Sub
```

Выполните программу несколько раз, чтобы убедиться, что ее выходные данные могут содержать выходные данные по всем веб-сайтам, по некоторым из них или не содержать никакие данные по веб-сайтам. Ниже приведен пример выходных данных.

```console
Length of the downloaded string: 35990.

Length of the downloaded string: 407399.

Length of the downloaded string: 226091.

Downloads canceled.
```

## <a name="complete-example"></a>Полный пример

Приведенный ниже код — полный текст файла MainWindow.xaml.vb для примера. Звездочками помечаются элементы, добавленные для этого примера.

Обратите внимание на то, что необходимо добавить ссылку для <xref:System.Net.Http>.

Вы можете скачать проект из статьи [Пример асинхронности. Тонкая настройка приложения](https://code.msdn.microsoft.com/Async-Fine-Tuning-Your-a676abea).

```vb
' Add an Imports directive and a reference for System.Net.Http.
Imports System.Net.Http

' Add the following Imports directive for System.Threading.
Imports System.Threading

Class MainWindow

    ' Declare a System.Threading.CancellationTokenSource.
    Dim cts As CancellationTokenSource

    Private Async Sub startButton_Click(sender As Object, e As RoutedEventArgs)

        ' Instantiate the CancellationTokenSource.
        cts = New CancellationTokenSource()

        resultsTextBox.Clear()

        Try
            ' ***Set up the CancellationTokenSource to cancel after 2.5 seconds. (You
            ' can adjust the time.)
            cts.CancelAfter(2500)

            Await AccessTheWebAsync(cts.Token)
            resultsTextBox.Text &= vbCrLf & "Downloads complete."

        Catch ex As OperationCanceledException
            resultsTextBox.Text &= vbCrLf & "Downloads canceled." & vbCrLf

        Catch ex As Exception
            resultsTextBox.Text &= vbCrLf & "Downloads failed." & vbCrLf
        End Try

        ' Set the CancellationTokenSource to Nothing when the download is complete.
        cts = Nothing
    End Sub

    ' You can still include a Cancel button if you want to.
    Private Sub cancelButton_Click(sender As Object, e As RoutedEventArgs)

        If cts IsNot Nothing Then
            cts.Cancel()
        End If
    End Sub

    ' Provide a parameter for the CancellationToken.
    ' Change the return type to Task because the method has no return statement.
    Async Function AccessTheWebAsync(ct As CancellationToken) As Task

        Dim client As HttpClient = New HttpClient()

        ' Call SetUpURLList to make a list of web addresses.
        Dim urlList As List(Of String) = SetUpURLList()

        ' Process each element in the list of web addresses.
        For Each url In urlList
            ' GetAsync returns a Task(Of HttpResponseMessage).
            ' Argument ct carries the message if the Cancel button is chosen.
            ' Note that the Cancel button can cancel all remaining downloads.
            Dim response As HttpResponseMessage = Await client.GetAsync(url, ct)

            ' Retrieve the website contents from the HttpResponseMessage.
            Dim urlContents As Byte() = Await response.Content.ReadAsByteArrayAsync()

            resultsTextBox.Text &=
                vbCrLf & $"Length of the downloaded string: {urlContents.Length}." & vbCrLf
        Next
    End Function

    ' Add a method that creates a list of web addresses.
    Private Function SetUpURLList() As List(Of String)

        Dim urls = New List(Of String) From
            {
                "https://msdn.microsoft.com",
                "https://msdn.microsoft.com/library/hh290138.aspx",
                "https://msdn.microsoft.com/library/hh290140.aspx",
                "https://msdn.microsoft.com/library/dd470362.aspx",
                "https://msdn.microsoft.com/library/aa578028.aspx",
                "https://msdn.microsoft.com/library/ms404677.aspx",
                "https://msdn.microsoft.com/library/ff730837.aspx"
            }
        Return urls
    End Function

End Class

' Sample output:

' Length of the downloaded string: 35990.

' Length of the downloaded string: 407399.

' Length of the downloaded string: 226091.

' Downloads canceled.
```

## <a name="see-also"></a>См. также

- [Асинхронное программирование с использованием ключевых слов Async и Await (Visual Basic)](index.md)
- [Пошаговое руководство. Получение доступа к Интернету с помощью модификатора Async и оператора Await (Visual Basic)](walkthrough-accessing-the-web-by-using-async-and-await.md)
- [Cancel an Async Task or a List of Tasks (Visual Basic)](cancel-an-async-task-or-a-list-of-tasks.md) (Отмена асинхронной задачи или списка задач в Visual Basic)
- [Fine-Tuning Your Async Application (Visual Basic)](fine-tuning-your-async-application.md) (Настройка асинхронного приложения (Visual Basic))
- [Пример использования Async. Настройка приложения](https://code.msdn.microsoft.com/Async-Fine-Tuning-Your-a676abea)
