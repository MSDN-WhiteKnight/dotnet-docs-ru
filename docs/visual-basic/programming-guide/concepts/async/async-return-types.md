---
description: 'Дополнительные сведения: Асинхронные типы возвращаемых значения (Visual Basic)'
title: Асинхронные типы возвращаемых значений
ms.date: 07/20/2015
ms.assetid: 07890291-ee72-42d3-932a-fa4d312f2c60
ms.openlocfilehash: 12a7f577a89ff8f8037de879f9e37d6fdb917aa8
ms.sourcegitcommit: 10e719780594efc781b15295e499c66f316068b8
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/14/2021
ms.locfileid: "100438922"
---
# <a name="async-return-types-visual-basic"></a>Async Return Types (Visual Basic) (Типы возвращаемых значений Async (Visual Basic))

Асинхронные методы имеют три возможных типа возврата: <xref:System.Threading.Tasks.Task%601>, <xref:System.Threading.Tasks.Task> и void. В Visual Basic тип возвращаемого значения void записывается как процедура [Sub](../../language-features/procedures/sub-procedures.md). Дополнительные сведения о асинхронных методах см. [в разделе Асинхронное программирование с использованием Async и await (Visual Basic)](index.md).

Каждый тип возвращаемого значения рассматривается в одном из следующих разделов, а полный пример, в котором используются все три типа, вы найдете в конце этого раздела.

> [!NOTE]
> Для выполнения этого примера на компьютере должны быть установлены Visual Studio 2012 или более поздней версии и .NET Framework 4.5 или более поздней версии.

## <a name="taskt-return-type"></a><a name="BKMK_TaskTReturnType"></a> Тип возвращаемого значения Task(T)

<xref:System.Threading.Tasks.Task%601>Тип возвращаемого значения используется для асинхронного метода, содержащего оператор [return](../../../language-reference/statements/return-statement.md) , в котором операнд имеет тип `TResult` .

В следующем примере асинхронный метод `TaskOfT_MethodAsync` содержит оператор return, который возвращает целое число. Поэтому в объявлении метода должен указываться тип возвращаемого значения `Task(Of Integer)`.

```vb
' TASK(OF T) EXAMPLE
Async Function TaskOfT_MethodAsync() As Task(Of Integer)

    ' The body of an async method is expected to contain an awaited
    ' asynchronous call.
    ' Task.FromResult is a placeholder for actual work that returns a string.
    Dim today As String = Await Task.FromResult(Of String)(DateTime.Now.DayOfWeek.ToString())

    ' The method then can process the result in some way.
    Dim leisureHours As Integer
    If today.First() = "S" Then
        leisureHours = 16
    Else
        leisureHours = 5
    End If

    ' Because the return statement specifies an operand of type Integer, the
    ' method must have a return type of Task(Of Integer).
    Return leisureHours
End Function
```

При вызове `TaskOfT_MethodAsync` из выражения await это выражение await извлекает целочисленное значение (значение `leisureHours`), хранящееся в задаче, которая возвращается `TaskOfT_MethodAsync`. Дополнительные сведения о выражениях await см. в разделе [оператор await](../../../language-reference/operators/await-operator.md).

В следующем коде вызывается и ожидается метод `TaskOfT_MethodAsync`. Результат назначается переменной `result1`.

```vb
' Call and await the Task(Of T)-returning async method in the same statement.
Dim result1 As Integer = Await TaskOfT_MethodAsync()
```

Чтобы лучше понять, как это происходит, отделите вызов метода `TaskOfT_MethodAsync` от применения `Await`, как показано в следующем коде. Вызов метода `TaskOfT_MethodAsync`, который не ожидается немедленно, возвращает `Task(Of Integer)`, как и следовало ожидать из объявления метода. В данном примере эта задача назначается переменной `integerTask`. Поскольку `integerTask` является <xref:System.Threading.Tasks.Task%601>, она содержит свойство <xref:System.Threading.Tasks.Task%601.Result> типа `TResult`. В этом примере TResult представляет собой целочисленный тип. Если выражение `Await` применяется к `integerTask`, выражение await вычисляется как содержимое свойства <xref:System.Threading.Tasks.Task%601.Result%2A> объекта `integerTask`. Это значение присваивается переменной `result2`.

> [!WARNING]
> Свойство <xref:System.Threading.Tasks.Task%601.Result%2A> является блокирующим свойством. При попытке доступа к нему до завершения его задачи поток, который в текущий момент активен, блокируется до того момента, пока задача не будет завершена, а ее значение не станет доступным. В большинстве случаев следует получать доступ к этому значению с помощью `Await` вместо прямого обращения к свойству.

```vb
' Call and await in separate statements.
Dim integerTask As Task(Of Integer) = TaskOfT_MethodAsync()

' You can do other work that does not rely on resultTask before awaiting.
textBox1.Text &= "Application can continue working while the Task(Of T) runs. . . . " & vbCrLf

Dim result2 As Integer = Await integerTask
```

Операторы отображения в следующем коде проверяют, одинаковы ли значения переменной `result1`, переменной `result2` и свойства `Result`. Помните, что свойство `Result` является блокирующим свойством, и к нему не стоит обращаться до того, как его задача закончит ожидание.

```vb
' Display the values of the result1 variable, the result2 variable, and
' the resultTask.Result property.
textBox1.Text &= vbCrLf & $"Value of result1 variable:   {result1}" & vbCrLf
textBox1.Text &= $"Value of result2 variable:   {result2}" & vbCrLf
textBox1.Text &= $"Value of resultTask.Result:  {integerTask.Result}" & vbCrLf
```

## <a name="task-return-type"></a><a name="BKMK_TaskReturnType"></a> Тип возвращаемого значения задачи

Асинхронные методы, не содержащие оператор return или содержащие оператор return, который не возвращает операнд, обычно имеют тип возврата <xref:System.Threading.Tasks.Task>. Такие методы будут [подпрограммными](../../language-features/procedures/sub-procedures.md) процедурами, если они были написаны для синхронного выполнения. Если для асинхронного метода вы используете тип возвращаемого значения `Task`, вызывающий метод может использовать оператор `Await` для приостановки выполнения вызывающего объекта до завершения вызванного асинхронного метода.

В следующем примере асинхронный метод `Task_MethodAsync` не содержит оператор return. Следовательно, вы указываете для метода тип возвращаемого значения `Task`, который позволяет ожидать `Task_MethodAsync`. Определение типа `Task` не включает свойство `Result` для хранения возвращаемого значения.

```vb
' TASK EXAMPLE
Async Function Task_MethodAsync() As Task

    ' The body of an async method is expected to contain an awaited
    ' asynchronous call.
    ' Task.Delay is a placeholder for actual work.
    Await Task.Delay(2000)
    textBox1.Text &= vbCrLf & "Sorry for the delay. . . ." & vbCrLf

    ' This method has no return statement, so its return type is Task.
End Function
```

`Task_MethodAsync` вызывается и ожидается с помощью оператора await (вместо выражения await), похожего на оператор вызова для синхронного метода, возвращающего `Sub` или void. Применение `Await` оператора в данном случае не приводит к созданию значения.

В следующем коде вызывается и ожидается метод `Task_MethodAsync`.

```vb
' Call and await the Task-returning async method in the same statement.
Await Task_MethodAsync()
```

Как и в предыдущем <xref:System.Threading.Tasks.Task%601> примере, можно разделить вызов `Task_MethodAsync` из приложения `Await` оператора, как показано в следующем коде. Однако следует помнить, что `Task` не содержит свойство `Result`, и при применении оператора await к `Task` никакое значение не создается.

В следующем коде вызов `Task_MethodAsync` отделяется от ожидания задачи, которая возвращает `Task_MethodAsync`.

```vb
' Call and await in separate statements.
Dim simpleTask As Task = Task_MethodAsync()

' You can do other work that does not rely on simpleTask before awaiting.
textBox1.Text &= vbCrLf & "Application can continue working while the Task runs. . . ." & vbCrLf

Await simpleTask
```

## <a name="void-return-type"></a><a name="BKMK_VoidReturnType"></a> Тип возвращаемого значения void

Процедуры в основном используются `Sub` в обработчиках событий, где нет возвращаемого типа (называемого типом возвращаемого значения void в других языках). Тип возврата void также можно использовать для переопределения методов, возвращающих void, или для методов, выполняющих действия, которые можно классифицировать как "запустить и забыть". Тем не менее вы должны возвращать `Task` везде, где это возможно, поскольку нельзя ожидать асинхронный метод, возвращающий void. Любой вызывающий объект такого метода должен иметь возможность завершить свою работу, не дожидаясь завершения вызванного асинхронного метода, и он не должен зависеть ни от каких значений и исключений, создаваемых асинхронным методом.

Вызывающий объект асинхронного метода, возвращающего void, не может перехватывать исключения, создаваемые методом, и такие необработанные исключения могут привести к сбою приложения. Если исключение возникает в асинхронном методе, который возвращает <xref:System.Threading.Tasks.Task> или <xref:System.Threading.Tasks.Task%601>, исключение хранится в возвращенной задаче и повторно вызывается при ожидании задачи. Поэтому убедитесь, что любой асинхронный метод, который может вызвать исключение, имеет тип возвращаемого значения <xref:System.Threading.Tasks.Task> или <xref:System.Threading.Tasks.Task%601> и что вызовы метода являются ожидаемыми.

Дополнительные сведения о перехвате исключений в асинхронных методах см. в статье [об операторе Try...Catch...Finally](../../../language-reference/statements/try-catch-finally-statement.md).

Следующий код определяет асинхронный обработчик событий.

```vb
' SUB EXAMPLE
Async Sub button1_Click(sender As Object, e As RoutedEventArgs) Handles button1.Click

    textBox1.Clear()

    ' Start the process and await its completion. DriverAsync is a
    ' Task-returning async method.
    Await DriverAsync()

    ' Say goodbye.
    textBox1.Text &= vbCrLf & "All done, exiting button-click event handler."
End Sub
```

## <a name="complete-example"></a><a name="BKMK_Example"></a> Полный пример

Следующий проект Windows Presentation Foundation (WPF) содержит примеры кода из этого раздела.

 Чтобы запустить проект, выполните следующие действия.

1. Запустите Visual Studio.

2. В строке меню выберите **Файл**, **Создать**, **Проект**.

     Откроется диалоговое окно **Новый проект** .

3. В категории **установленные** **шаблоны** выберите **Visual Basic**, а затем выберите **Windows**. В списке типов проектов выберите **Приложение WPF**.

4. Введите `AsyncReturnTypes` в качестве имени проекта и нажмите кнопку **ОК**.

     В **обозревателе решений** появится новый проект.

5. В редакторе кода Visual Studio перейдите на вкладку **MainWindow.xaml** .

     Если вкладка не отображается, откройте контекстное меню для MainWindow.xaml в **обозревателе решений** и выберите пункт **Открыть**.

6. В окне **XAML** MainWindow.xaml замените код на следующий.

    ```vb
    <Window x:Class="MainWindow"
            xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
            xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
            Title="MainWindow" Height="350" Width="525">
        <Grid>
            <Button x:Name="button1" Content="Start" HorizontalAlignment="Left" Margin="214,28,0,0" VerticalAlignment="Top" Width="75" HorizontalContentAlignment="Center" FontWeight="Bold" FontFamily="Aharoni" Click="button1_Click"/>
            <TextBox x:Name="textBox1" Margin="0,80,0,0" TextWrapping="Wrap" FontFamily="Lucida Console"/>

        </Grid>
    </Window>
    ```

     Простое окно, содержащее текстовое поле и кнопку, отобразится в окне **конструктора** для MainWindow.xaml.

7. В **Обозреватель решений** откройте контекстное меню файла MainWindow. XAML. vb и выберите пункт **Просмотреть код**.

8. Замените код в MainWindow.xaml.vb на приведенный далее.

    ```vb
    Class MainWindow

        ' SUB EXAMPLE
        Async Sub button1_Click(sender As Object, e As RoutedEventArgs) Handles button1.Click

            textBox1.Clear()

            ' Start the process and await its completion. DriverAsync is a
            ' Task-returning async method.
            Await DriverAsync()

            ' Say goodbye.
            textBox1.Text &= vbCrLf & "All done, exiting button-click event handler."
        End Sub

        Async Function DriverAsync() As Task

            ' Task(Of T)
            ' Call and await the Task(Of T)-returning async method in the same statement.
            Dim result1 As Integer = Await TaskOfT_MethodAsync()

            ' Call and await in separate statements.
            Dim integerTask As Task(Of Integer) = TaskOfT_MethodAsync()

            ' You can do other work that does not rely on resultTask before awaiting.
            textBox1.Text &= "Application can continue working while the Task(Of T) runs. . . . " & vbCrLf

            Dim result2 As Integer = Await integerTask

            ' Display the values of the result1 variable, the result2 variable, and
            ' the resultTask.Result property.
            textBox1.Text &= vbCrLf & $"Value of result1 variable:   {result1}" & vbCrLf
            textBox1.Text &= $"Value of result2 variable:   {result2}" & vbCrLf
            textBox1.Text &= $"Value of resultTask.Result:  {integerTask.Result}" & vbCrLf

            ' Task
            ' Call and await the Task-returning async method in the same statement.
            Await Task_MethodAsync()

            ' Call and await in separate statements.
            Dim simpleTask As Task = Task_MethodAsync()

            ' You can do other work that does not rely on simpleTask before awaiting.
            textBox1.Text &= vbCrLf & "Application can continue working while the Task runs. . . ." & vbCrLf

            Await simpleTask
        End Function

        ' TASK(OF T) EXAMPLE
        Async Function TaskOfT_MethodAsync() As Task(Of Integer)

            ' The body of an async method is expected to contain an awaited
            ' asynchronous call.
            ' Task.FromResult is a placeholder for actual work that returns a string.
            Dim today As String = Await Task.FromResult(Of String)(DateTime.Now.DayOfWeek.ToString())

            ' The method then can process the result in some way.
            Dim leisureHours As Integer
            If today.First() = "S" Then
                leisureHours = 16
            Else
                leisureHours = 5
            End If

            ' Because the return statement specifies an operand of type Integer, the
            ' method must have a return type of Task(Of Integer).
            Return leisureHours
        End Function

        ' TASK EXAMPLE
        Async Function Task_MethodAsync() As Task

            ' The body of an async method is expected to contain an awaited
            ' asynchronous call.
            ' Task.Delay is a placeholder for actual work.
            Await Task.Delay(2000)
            textBox1.Text &= vbCrLf & "Sorry for the delay. . . ." & vbCrLf

            ' This method has no return statement, so its return type is Task.
        End Function

    End Class
    ```

9. Нажмите клавишу F5, чтобы запустить программу, а затем нажмите кнопку **Start** .

     Должны отобразиться следующие выходные данные:

    ```console
    Application can continue working while the Task<T> runs. . . .

    Value of result1 variable:   5
    Value of result2 variable:   5
    Value of integerTask.Result: 5

    Sorry for the delay. . . .

    Application can continue working while the Task runs. . . .

    Sorry for the delay. . . .

    All done, exiting button-click event handler.
    ```

## <a name="see-also"></a>См. также раздел

- <xref:System.Threading.Tasks.Task.FromResult%2A>
- [Пошаговое руководство. Получение доступа к Интернету с помощью модификатора Async и оператора Await (Visual Basic)](walkthrough-accessing-the-web-by-using-async-and-await.md)
- [Control Flow in Async Programs (Visual Basic)](control-flow-in-async-programs.md) (Поток управления в асинхронных программах (Visual Basic))
- [Асинхронный режим](../../../language-reference/modifiers/async.md)
- [Оператор Await](../../../language-reference/operators/await-operator.md)
