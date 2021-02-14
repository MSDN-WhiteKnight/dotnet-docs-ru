---
title: Отмена асинхронных задач после определенного периода времени (C#)
description: Узнайте, как запланировать отмену всех связанных задач, которые не были завершены в течение определенного периода времени.
ms.date: 02/03/2021
ms.topic: tutorial
ms.assetid: 194282c2-399f-46da-a7a6-96674e00b0b3
ms.openlocfilehash: 98c42a2df6153d668b99b6dec49ffe380293b205
ms.sourcegitcommit: 65af0f0ad316858882845391d60ef7e303b756e8
ms.translationtype: HT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/05/2021
ms.locfileid: "99585381"
---
# <a name="cancel-async-tasks-after-a-period-of-time-c"></a>Отмена асинхронных задач после определенного периода времени (C#)

Если не нужно дожидаться, пока завершится выполнение асинхронной операции, ее можно отменить по истечении определенного периода времени с помощью метода <xref:System.Threading.CancellationTokenSource.CancelAfter%2A?displayProperty=nameWithType>. Этот метод планирует отмену всех связанных задач, не завершенных в течение времени, установленного выражением `CancelAfter`.

В этом примере добавляется код, составленный в разделе [Отмена списка задач (C#)](cancel-an-async-task-or-a-list-of-tasks.md), для загрузки списка веб-сайтов и отображения длины содержимого каждого из них.

Темы, рассматриваемые в этом руководстве:

> [!div class="checklist"]
>
> - Обновление существующего консольного приложения .NET
> - Планирование отмены

## <a name="prerequisites"></a>Предварительные требования

Для работы с данным учебником требуется следующее:

- Предполагается, что вы создали приложение в учебнике [Отмена списка задач (C#)](cancel-an-async-task-or-a-list-of-tasks.md).
- [Пакет SDK для .NET 5.0 или более поздней версии](https://dotnet.microsoft.com/download/dotnet/5.0)
- Интегрированная среда разработки (IDE)
  - [Мы рекомендуем Visual Studio, Visual Studio Code или Visual Studio для Mac](https://visualstudio.microsoft.com)

## <a name="update-application-entry-point"></a>Обновление точки входа приложения

Замените существующий метод `Main` следующим кодом.

```csharp
static async Task Main()
{
    Console.WriteLine("Application started.");

    try
    {
        s_cts.CancelAfter(3500);

        await SumPageSizesAsync();
    }
    catch (TaskCanceledException)
    {
        Console.WriteLine("\nTasks cancelled: timed out.\n");
    }
    finally
    {
        s_cts.Dispose();
    }

    Console.WriteLine("Application ending.");
}
```

Обновленный метод `Main` записывает в консоль несколько инструкций. В операторе [try-catch](../../../language-reference/keywords/try-catch.md) вызов <xref:System.Threading.CancellationTokenSource.CancelAfter(System.Int32)?displayProperty=nameWithType> позволяет запланировать отмену. Эта операция будет сообщать об отмене по истечении определенного периода времени.

Затем ожидается метод `SumPageSizesAsync`. Если обработка всех URL-адресов выполняется быстрее запланированной отмены, приложение завершается. Однако если запланированная отмена запускается до обработки всех URL-адресов, создается <xref:System.Threading.Tasks.TaskCanceledException>.

### <a name="example-application-output"></a>Пример выходных данных приложения

```console
Application started.

https://docs.microsoft.com                                       37,357
https://docs.microsoft.com/aspnet/core                           85,589
https://docs.microsoft.com/azure                                398,939
https://docs.microsoft.com/azure/devops                          73,663

Tasks cancelled: timed out.

Application ending.
```

## <a name="complete-example"></a>Полный пример

Приведенный ниже код — это полный текст файла *Program.cs* для примера.

:::code language="csharp" source="snippets/cancel-tasks/cancel-task-after-period-of-time/Program.cs":::

## <a name="see-also"></a>См. также раздел

- <xref:System.Threading.CancellationToken>
- <xref:System.Threading.CancellationTokenSource>
- [Асинхронное программирование с использованием ключевых слов Async и Await (C#)](index.md)
- [Отмена списка задач (C#)](cancel-an-async-task-or-a-list-of-tasks.md)
