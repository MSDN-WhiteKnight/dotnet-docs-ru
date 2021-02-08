---
description: См. Дополнительные сведения о операторе await (Visual Basic)
title: Оператор Await
ms.date: 07/20/2015
f1_keywords:
- vb.Await
helpviewer_keywords:
- Await operator [Visual Basic]
- Await [Visual Basic]
ms.assetid: 6b1ce283-e92b-4ba7-b081-7be7b3d37af9
ms.openlocfilehash: 04e32f31de970b389ae38fc3a4cdc6ab3f873f3d
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99774139"
---
# <a name="await-operator-visual-basic"></a>Оператор Await (Visual Basic)

`Await`Оператор применяется к операнду в асинхронном методе или лямбда-выражении для приостановки выполнения метода до тех пор, пока не завершится ожидаемая задача. Задача представляет выполняющуюся работу.

Метод, в котором `Await` используется, должен иметь модификатор [Async](../modifiers/async.md) . Такой метод, определенный с помощью модификатора `Async` и обычно содержащий одно или несколько выражений `Await`, называется *асинхронным методом*.

> [!NOTE]
> Ключевые слова `Async` и `Await` появились в Visual Studio 2012. Общие сведения о асинхронном программировании см. в статье [Асинхронное программирование с использованием Async и await](../../programming-guide/concepts/async/index.md).

Как правило, задача, к которой применяется `Await` оператор, является возвращаемым значением из вызова метода, реализующего [асинхронную модель на основе задач](https://www.microsoft.com/download/details.aspx?id=19957), то есть <xref:System.Threading.Tasks.Task> или <xref:System.Threading.Tasks.Task%601> .

В следующем коде <xref:System.Net.Http.HttpClient> метод <xref:System.Net.Http.HttpClient.GetByteArrayAsync%2A> возвращает `getContentsTask` , `Task(Of Byte())` . Задача является обещанием для создания действительного массива байтов после завершения операции. Оператор `Await` применяется к `getContentsTask` для приостановки выполнения в `SumPageSizesAsync` до завершения `getContentsTask`. В то же время управление возвращается вызывающему объекту `SumPageSizesAsync`. Когда `getContentsTask` завершается, результатом выражения `Await` является массив байтов.

```vb
Private Async Function SumPageSizesAsync() As Task

    ' To use the HttpClient type in desktop apps, you must include a using directive and add a
    ' reference for the System.Net.Http namespace.
    Dim client As HttpClient = New HttpClient()
    ' . . .
    Dim getContentsTask As Task(Of Byte()) = client.GetByteArrayAsync(url)
    Dim urlContents As Byte() = Await getContentsTask

    ' Equivalently, now that you see how it works, you can write the same thing in a single line.
    'Dim urlContents As Byte() = Await client.GetByteArrayAsync(url)
    ' . . .
End Function
```

> [!IMPORTANT]
> Полный пример см. в разделе [Пошаговое руководство. Получение доступа к Интернету с помощью модификатора Async и оператора Await](../../programming-guide/concepts/async/walkthrough-accessing-the-web-by-using-async-and-await.md). Вы можете скачать этот пример в разделе [Примеры кода для разработчиков](https://code.msdn.microsoft.com/Async-Sample-Accessing-the-9c10497f) на веб-сайте Майкрософт. Этот пример представлен в проекте AsyncWalkthrough_HttpClient.

Если `Await` применяется к результату вызова метода, который возвращает `Task(Of TResult)` , то типом `Await` выражения является TResult. Если `Await` применяется к результату вызова метода, возвращающего `Task` , `Await` выражение не возвращает значение. В следующем примере демонстрируется это различие.

```vb
' Await used with a method that returns a Task(Of TResult).
Dim result As TResult = Await AsyncMethodThatReturnsTaskTResult()

' Await used with a method that returns a Task.
Await AsyncMethodThatReturnsTask()
```

`Await`Выражение или оператор не блокирует поток, в котором он выполняется. Вместо этого компилятор регистрирует оставшуюся часть асинхронного метода после `Await` выражения в качестве продолжения ожидающей задачи. Затем управление возвращается в объект, вызывающий асинхронный метод. Когда задача завершается, она вызывает свое продолжение и выполнение асинхронного метода возобновляется с того момента, где оно было остановлено.

`Await`Выражение может находиться только в теле непосредственно вмещающего метода или лямбда-выражения, помеченного `Async` модификатором. Термин *await* выступает в качестве ключевого слова только в этом контексте. В другом месте он интерпретируется как идентификатор. В `Async` методе или лямбда-выражении `Await` выражение не может встречаться в выражении запроса, `Catch` в `Finally` блоке или [конструкции try... Перехватить... Оператор finally](../statements/try-catch-finally-statement.md)в выражении переменной цикла управления `For` `For Each` цикла или в теле оператора [SyncLock](../statements/synclock-statement.md) .

## <a name="exceptions"></a>Исключения

Большинство асинхронных методов возвращает <xref:System.Threading.Tasks.Task> или <xref:System.Threading.Tasks.Task%601>. Свойства возвращаемой задачи содержат сведения о ее состоянии и журнале, например завершена ли задача, вызвал ли асинхронный метод исключение или был отменен и каков окончательный результат. Оператор `Await` обращается к этим свойствам.

Если вы ожидаете возвращающий задачу асинхронный метод, который вызывает исключение, то оператор `Await` повторно создает это исключение.

Если ожидается асинхронный метод, возвращающий задачу, который отменяется, `Await` оператор повторно создает исключение <xref:System.OperationCanceledException> .

Одна задача, которая находится в состоянии сбоя, может отражать несколько исключений.  Например, задача может быть результатом вызова метода <xref:System.Threading.Tasks.Task.WhenAll%2A?displayProperty=nameWithType>. Если вы ожидаете такую задачу, операция await повторно вызывает только одно из исключений. Однако невозможно предсказать, какие исключения создаются повторно.

Примеры обработки ошибок в асинхронных методах см. в разделе [try... Перехватить... Оператор finally](../statements/try-catch-finally-statement.md).

## <a name="example"></a>Пример

В следующем примере Windows Forms демонстрируется использование `Await` в асинхронном методе `WaitAsynchronouslyAsync`. Сравните поведение этого метода с поведением `WaitSynchronously`. Без `Await` оператора `WaitSynchronously` работает синхронно, несмотря на использование `Async` модификатора в его определении и вызов <xref:System.Threading.Thread.Sleep%2A?displayProperty=nameWithType> в его теле.

```vb
Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    ' Call the method that runs asynchronously.
    Dim result As String = Await WaitAsynchronouslyAsync()

    ' Call the method that runs synchronously.
    'Dim result As String = Await WaitSynchronously()

    ' Display the result.
    TextBox1.Text &= result
End Sub

' The following method runs asynchronously. The UI thread is not
' blocked during the delay. You can move or resize the Form1 window
' while Task.Delay is running.
Public Async Function WaitAsynchronouslyAsync() As Task(Of String)
    Await Task.Delay(10000)
    Return "Finished"
End Function

' The following method runs synchronously, despite the use of Async.
' You cannot move or resize the Form1 window while Thread.Sleep
' is running because the UI thread is blocked.
Public Async Function WaitSynchronously() As Task(Of String)
    ' Import System.Threading for the Sleep method.
    Thread.Sleep(10000)
    Return "Finished"
End Function
```

## <a name="see-also"></a>См. также

- [Асинхронное программирование с использованием ключевых слов Async и Await](../../programming-guide/concepts/async/index.md)
- [Пошаговое руководство: Получение доступа к Интернету с помощью модификатора Async и оператора Await (C#)](../../programming-guide/concepts/async/walkthrough-accessing-the-web-by-using-async-and-await.md)
- [Асинхронный режим](../modifiers/async.md)
