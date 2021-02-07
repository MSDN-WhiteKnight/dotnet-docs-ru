---
description: 'Дополнительные сведения: async (Visual Basic)'
title: Async
ms.date: 07/20/2015
f1_keywords:
- vb.Async
helpviewer_keywords:
- Async [Visual Basic]
- Async keyword [Visual Basic]
ms.assetid: 1be8b4b5-9689-41b5-bd33-b906bfd53bc5
ms.openlocfilehash: a20c80ace06e386e7c106acc2b7e6258abca13b2
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99701161"
---
# <a name="async-visual-basic"></a>Async (Visual Basic)

`Async`Модификатор указывает, что метод или [лямбда-выражение](../../programming-guide/language-features/procedures/lambda-expressions.md) , которое он изменяет, является асинхронным. Такие методы называются *асинхронными методами*.

Асинхронный метод представляет собой удобный способ для выполнения работы, которая может занять длительное время, без блокировки потока вызывающего объекта. Вызывающий метод асинхронного метода может возобновить свою работу, не дожидаясь завершения асинхронного метода.

> [!NOTE]
> Ключевые слова `Async` и `Await` появились в Visual Studio 2012. Общие сведения о асинхронном программировании см. в статье [Асинхронное программирование с использованием Async и await](../../programming-guide/concepts/async/index.md).

В следующем примере показана структура асинхронного метода. По соглашению имена асинхронных методов заканчиваются на "Async".

```vb
Public Async Function ExampleMethodAsync() As Task(Of Integer)
    ' . . .

    ' At the Await expression, execution in this method is suspended and,
    ' if AwaitedProcessAsync has not already finished, control returns
    ' to the caller of ExampleMethodAsync. When the awaited task is
    ' completed, this method resumes execution.
    Dim exampleInt As Integer = Await AwaitedProcessAsync()

    ' . . .

    ' The return statement completes the task. Any method that is
    ' awaiting ExampleMethodAsync can now get the integer result.
    Return exampleInt
End Function
```

Как правило, метод, измененный с помощью `Async` ключевого слова, содержит по крайней мере одно выражение или оператор [await](async.md) . Метод выполняется синхронно до тех пор, пока не достигнет первого `Await` , после чего он приостанавливается до тех пор, пока не завершится ожидаемая задача. Пока Управление возвращается вызывающему методу метода. Если метод не содержит `Await` выражение или оператор, метод не приостанавливается и выполняется как синхронный метод. Предупреждение компилятора предупреждает о любых асинхронных методах, которые не содержат, `Await` так как такая ситуация может указывать на ошибку. Дополнительные сведения см. в описании [ошибки компилятора](../error-messages/bc42358.md).

`Async`Ключевое слово является незарезервированным ключевым словом. Это ключевое слово при изменении метода или лямбда-выражения. Во всех остальных контекстах он интерпретируется как идентификатор.

## <a name="return-types"></a>Типы возвращаемых данных

Асинхронный метод является либо [подпроцедурой, либо процедурой](../../programming-guide/language-features/procedures/sub-procedures.md) [функции](../../programming-guide/language-features/procedures/function-procedures.md) , имеющей тип возвращаемого значения <xref:System.Threading.Tasks.Task> или <xref:System.Threading.Tasks.Task%601> . Метод не может объявлять никакие параметры [ByRef](byref.md) .

Указывается `Task(Of TResult)` для возвращаемого типа асинхронного метода, если оператор [return](../statements/return-statement.md) метода имеет операнд типа TResult. Класс `Task` используется при отсутствии содержательного значения, возвращаемого методом при его завершении. Это значит, что вызов метода возвращает `Task` , но после `Task` завершения любая `Await` инструкция, ожидающая, `Task` не формирует результирующее значение.

Асинхронные подпрограммы используются в основном для определения обработчиков событий, где `Sub` требуется процедура. Вызывающая сторона асинхронной подпрограммы не может ожидать ее и не может перехватывать исключения, которые вызывает метод.

Дополнительные сведения и примеры см. в разделе [Асинхронные типы возвращаемых значений](../../programming-guide/concepts/async/async-return-types.md).

## <a name="example"></a>Пример

В следующих примерах показан асинхронный обработчик событий, асинхронное лямбда-выражение и асинхронный метод. Полный пример использования этих элементов см. в разделе [Пошаговое руководство. доступ к Интернету с помощью Async и await](../../programming-guide/concepts/async/walkthrough-accessing-the-web-by-using-async-and-await.md). Код пошагового руководства можно скачать в разделе [Примеры кода от разработчиков](https://code.msdn.microsoft.com/Async-Sample-Accessing-the-9c10497f).

```vb
' An event handler must be a Sub procedure.
Async Sub button1_Click(sender As Object, e As RoutedEventArgs) Handles button1.Click
    textBox1.Clear()
    ' SumPageSizesAsync is a method that returns a Task.
    Await SumPageSizesAsync()
    textBox1.Text = vbCrLf & "Control returned to button1_Click."
End Sub

' The following async lambda expression creates an equivalent anonymous
' event handler.
AddHandler button1.Click, Async Sub(sender, e)
                              textBox1.Clear()
                              ' SumPageSizesAsync is a method that returns a Task.
                              Await SumPageSizesAsync()
                              textBox1.Text = vbCrLf & "Control returned to button1_Click."
                          End Sub

' The following async method returns a Task(Of T).
' A typical call awaits the Byte array result:
'      Dim result As Byte() = Await GetURLContents("https://msdn.com")
Private Async Function GetURLContentsAsync(url As String) As Task(Of Byte())

    ' The downloaded resource ends up in the variable named content.
    Dim content = New MemoryStream()

    ' Initialize an HttpWebRequest for the current URL.
    Dim webReq = CType(WebRequest.Create(url), HttpWebRequest)

    ' Send the request to the Internet resource and wait for
    ' the response.
    Using response As WebResponse = Await webReq.GetResponseAsync()
        ' Get the data stream that is associated with the specified URL.
        Using responseStream As Stream = response.GetResponseStream()
            ' Read the bytes in responseStream and copy them to content.
            ' CopyToAsync returns a Task, not a Task<T>.
            Await responseStream.CopyToAsync(content)
        End Using
    End Using

    ' Return the result as a byte array.
    Return content.ToArray()
End Function
```

## <a name="see-also"></a>См. также

- <xref:System.Runtime.CompilerServices.AsyncStateMachineAttribute>
- [Оператор Await](../operators/await-operator.md)
- [Асинхронное программирование с использованием ключевых слов Async и Await](../../programming-guide/concepts/async/index.md)
- [Пошаговое руководство: Получение доступа к Интернету с помощью модификатора Async и оператора Await (C#)](../../programming-guide/concepts/async/walkthrough-accessing-the-web-by-using-async-and-await.md)
