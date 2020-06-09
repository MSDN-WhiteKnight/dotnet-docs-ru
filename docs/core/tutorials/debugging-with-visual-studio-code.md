---
title: Отладка консольного приложения .NET Core в Visual Studio Code
description: Узнайте, как выполнить отладку консольного приложения .NET Core в Visual Studio Code.
ms.date: 05/26/2020
ms.openlocfilehash: eaeb97f54442006d2f0e29483a68dc3de89b5778
ms.sourcegitcommit: 71b8f5a2108a0f1a4ef1d8d75c5b3e129ec5ca1e
ms.translationtype: HT
ms.contentlocale: ru-RU
ms.lasthandoff: 05/29/2020
ms.locfileid: "84202493"
---
# <a name="tutorial-debug-a-net-core-console-application-using-visual-studio-code"></a>Учебник. Отладка консольного приложения .NET Core с помощью Visual Studio Code

В этом учебнике представлены средства отладки, доступные в Visual Studio Code для работы с приложениями .NET Core.

## <a name="prerequisites"></a>Предварительные требования

- В этом руководстве используется консольное приложение, созданное в руководстве [Создание консольного приложения .NET Core в Visual Studio Code](with-visual-studio-code.md).

## <a name="use-debug-build-configuration"></a>Использование конфигурации отладочной сборки

В .NET Core используются две конфигурации сборки — *отладочная* и для *выпуска*. Вы воспользуетесь отладочной конфигурацией сборки для отладки и конфигурацией для выпуска для окончательного выпуска программы.

В отладочной конфигурации программы компилируется с полной символической отладочной информацией и без оптимизации. Оптимизация усложняет отладку, поскольку усложняется связь между исходным кодом и сгенерированными инструкциями. Конфигурация для выпуска полностью оптимизирована и не содержит символической отладочной информации.

 По умолчанию Visual Studio Code использует отладочную конфигурацию сборки, поэтому ее не нужно изменять перед отладкой.

## <a name="set-a-breakpoint"></a>Установка точки останова

Точка останова приостанавливает выполнение приложения на инструкции, *предшествующей* той строке, в которой установлена точка останова.

1. В файле *Program.cs* установите *точку останова* в строке, где отображается имя, дата и время, щелкнув в левом поле окна изменения кода. Левое поле находится слева от номеров строк. Кроме того, установить точку останова можно, поместив курсор в строку кода и нажав клавишу <kbd>F9</kbd>.

   Как видно на следующем рисунке, строку с точкой останова Visual Studio Code обозначает красной точкой в левом поле.

   :::image type="content" source="media/debugging-with-visual-studio-code/breakpoint-set.png" alt-text="Заданная точка останова":::

## <a name="set-up-for-terminal-input"></a>Настройка входных данных терминала

Точка останова находится после вызова метода `Console.ReadLine`. **Консоль отладки** не принимает входные данные терминала для выполняющейся программы. Чтобы использовать выходные данные терминала во время отладки, можно использовать встроенный терминал (одно из окон Visual Studio Code) или внешний терминал. В этом учебнике используется встроенный терминал.

1. Откройте файл *.vscode/launch.json*.

1. Измените параметр `console` на `integratedTerminal`.

   От:

   ```
   "console": "internalConsole",
   ```

   В:

   ```
   "console": "integratedTerminal",
   ```

1. Сохраните изменения.

## <a name="start-debugging"></a>Начать отладку

1. Откройте окно отладки, щелкнув значок "Отладка" в меню слева.

   :::image type="content" source="media/debugging-with-visual-studio-code/select-debug-pane.png" alt-text="Открытие вкладки "Отладка" в Visual Studio Code":::

1. Начните отладку, нажав зеленую стрелку в верхней части области, рядом с элементом **запуска .NET Core (консоль)** .  Также отладку можно запустить с помощью клавиши <kbd>F5</kbd>.

   :::image type="content" source="media/debugging-with-visual-studio-code/start-debugging.png" alt-text="Запуск отладки":::

1. Выберите вкладку **Терминал**, чтобы отобразить запрос "What is your name?" (Как вас зовут?), который появляется перед ожиданием ответа.

   :::image type="content" source="media/debugging-with-visual-studio-code/select-terminal.png" alt-text="Выбор вкладки "Терминал"":::

1. Введите строку в окне **Терминал** в ответ на запрос имени, а затем нажмите клавишу <kbd>ВВОД</kbd>.

   Выполнение программы остановится, когда будет достигнута точка останова, то есть перед выполнением метода `Console.WriteLine`. В окне **Локальные** окна **Переменные** отображаются значения переменных, которые определены в текущем выполняемом методе.

   :::image type="content" source="media/debugging-with-visual-studio-code/breakpoint-hit.png" alt-text="Достижение точки останова, отображение окна "Локальные"":::

## <a name="change-variable-values"></a>Изменение значений переменных

Окно **Консоль отладки** служит для взаимодействия с приложением, которое вы отлаживаете. Вы можете изменить значения переменных и посмотреть, как это повлияет на работу программы.

1. Выберите вкладку **Консоль отладки**.

1. Введите `name = "Gracie"` в запросе в нижней части окна **Консоль отладки** и нажмите клавишу <kbd>ВВОД</kbd>.

   :::image type="content" source="media/debugging-with-visual-studio-code/change-variable-values.png" alt-text="Изменение значений переменных":::

1. Введите `date = DateTime.Parse("2019-11-16T17:25:00Z").ToUniversalTime()` в нижней части окна **Консоль отладки** и нажмите клавишу <kbd>ВВОД</kbd>.

   В окне **Переменные** отображаются новые значения переменных `name` и `date`.

1. Продолжите выполнение программы, нажав кнопку **Продолжить** на панели инструментов. Еще один способ продолжить — нажать клавишу <kbd>F5</kbd>.

   :::image type="content" source="media/debugging-with-visual-studio-code/continue-debugging.png" alt-text="Продолжение отладки":::

1. Снова выберите вкладку **Терминал**.

   Значения, отображаемые в окне консоли, соответствуют изменениям, произведенным в окне **Консоль отладки**.

   :::image type="content" source="media/debugging-with-visual-studio-code/changed-variable-values.png" alt-text="Окно терминала с указанными значениями":::

1. Нажмите любую клавишу, чтобы выйти из приложения и остановить отладку.

## <a name="set-a-conditional-breakpoint"></a>Установка условной точки останова

Программа отображает строку, которую вводит пользователь. Что произойдет, если пользователь ничего не введет? Это можно проверить с помощью полезной функции отладки, которая называется *условной точкой останова*.

1. Щелкните правой кнопкой мыши красную точку, обозначающую точку останова (или щелкните ее, удерживая нажатой клавишу <kbd>CTRL</kbd> в macOS). В контекстном меню выберите **Изменить точку останова**, чтобы открыть диалоговое окно, в котором можно ввести условное выражение.

   :::image type="content" source="media/debugging-with-visual-studio-code/breakpoint-context-menu.png" alt-text="Контекстное меню точки останова":::

1. Выберите `Expression` в раскрывающемся списке, введите следующее условное выражение и нажмите клавишу <kbd>ВВОД</kbd>.

   ```csharp
   String.IsNullOrEmpty(name)
   ```

   :::image type="content" source="media/debugging-with-visual-studio-code/conditional-expression.png" alt-text="Ввод условного выражения":::

   При каждом достижении точки останова отладчик вызывает метод `String.IsNullOrEmpty(name)` и останавливается на этой строке только в том случае, если вызов метода возвращает `true`.

   Вместо условного выражения можно указать *количество обращений* (в этом случае выполнение программы будет прерываться до тех пор, пока не будет достигнуто заданное количество обращений) или *условие фильтра* (в этом случае выполнение программы будет прерываться на основе таких атрибутов, как идентификатор потока, имя процесса и имя потока).

1. Запустите отладку программы, нажав клавишу <kbd>F5</kbd>.

1. Когда на вкладке **Терминал** появится предложение ввести имя, нажмите клавишу <kbd>ВВОД</kbd>.

   Поскольку указанное вами условие соблюдается (`name` имеет значение `null` или <xref:System.String.Empty?displayProperty=nameWithType>), выполнение программы будет остановлено при достижении точки останова, то есть перед выполнением метода `Console.WriteLine`.

   В окне **Переменные** указывается, что значение переменной `name` `""`или <xref:System.String.Empty?displayProperty=nameWithType>.

1. Убедитесь в том, что переменная содержит пустую строку, введя следующий оператор в окне **Консоль отладки** и нажав клавишу <kbd>ВВОД</kbd>. Результат равен `true`.

   ```csharp
   name == String.Empty
   ```

   :::image type="content" source="media/debugging-with-visual-studio-code/expression-in-debug-console.png" alt-text="Значение true в окне "Консоль отладки" после выполнения оператора":::

1. Нажмите кнопку **Продолжить** на панели инструментов, чтобы возобновить выполнение программы.

1. Перейдите на вкладку **Терминалов** и нажмите любую клавишу, чтобы выйти из программы и прекратить отладку.

1. Очистите точку останова. Для этого щелкните красную точку в левом поле окна с кодом. Или нажмите клавишу <kbd>F9</kbd> при выбранной строке кода.

1. При появлении предупреждения о том, что условие точки останова будет потеряно, выберите **Удалить точку останова**.

## <a name="step-through-a-program"></a>Пошаговое выполнение программы

Visual Studio Code позволяет выполнять программу пошагово, отслеживая результат ее выполнения. Для этого обычно задают точку останова и запускают программу в небольшой части ее кода. Поскольку наша программа невелика, давайте выполним ее пошагово.

1. Установите точку останова на открывающей фигурной скобке метода `Main`.

1. Нажмите клавишу <kbd>F5</kbd> , чтобы начать отладку.

   Visual Studio Code выделит строку точки останова.

   На этом этапе в окне **Переменные** показано, что массив `args` пуст, а `name` и `date` имеют значения по умолчанию.

1. Выберите **Шаг с заходом** или нажмите клавишу <kbd>F11</kbd>.

   :::image type="content" source="media/debugging-with-visual-studio-code/step-into.png" alt-text="Кнопка "Шаг с заходом"":::

   Будет выделена следующая строка.

1. Выберите **Шаг с заходом** или нажмите клавишу <kbd>F11</kbd>.

   Visual Studio Code выполняет `Console.WriteLine` для запроса имени и выделяет следующую строку выполнения. Следующая строка — это `Console.ReadLine` для `name`. Содержимое окна **Переменные** останется без изменений, а на вкладке **Терминал** появится сообщение "What is your name?" (Как вас зовут?).

1. Выберите **Шаг с заходом** или нажмите клавишу <kbd>F11</kbd>.

   Visual Studio выделит назначение переменной `name`. В окне **Переменные** видно, что `name` по-прежнему `null`.

1. Ответьте на этот запрос, введя строку на вкладке "Терминал" и нажав клавишу <kbd>ВВОД</kbd>.

   На вкладке **Терминал** может не отображаться введенная строка, однако метод <xref:System.Console.ReadLine%2A?displayProperty=nameWithType> будет записывать входные данные.

1. Выберите **Шаг с заходом** или нажмите клавишу <kbd>F11</kbd>.

   Visual Studio Code выделит назначение переменной `date`. В окне **Переменные** отображается значение, полученное в результате вызова метода <xref:System.Console.ReadLine%2A?displayProperty=nameWithType>. На вкладке **Терминал** также отображается строка, указанная в командной строке.

1. Выберите **Шаг с заходом** или нажмите клавишу <kbd>F11</kbd>.

   В окне **Переменные** отображается значение переменной `date`, которому было присвоено свойство <xref:System.DateTime.Now?displayProperty=nameWithType>.

1. Выберите **Шаг с заходом** или нажмите клавишу <kbd>F11</kbd>.

   Visual Studio Code вызывает метод <xref:System.Console.WriteLine(System.String,System.Object,System.Object)?displayProperty=nameWithType>. В окне консоли отображается форматированная строка.

1. Выберите **Шаг с выходом** или нажмите клавиши <kbd>SHIFT</kbd>+<kbd>F11</kbd>.

   :::image type="content" source="media/debugging-with-visual-studio-code/step-out.png" alt-text="Кнопка "Шаг с выходом"":::

1. Выберите вкладку **Терминал**.

   В окне терминала отобразится сообщение "Нажмите любую клавишу, чтобы выйти..."

1. Нажмите любую клавишу для выхода из программы.

## <a name="select-release-build-configuration"></a>Выбор конфигурации сборки для выпуска

После тестирования отладочной версии приложения следует скомпилировать и протестировать версию в режиме выпуска. Версию для выпуска компилятор собирает с использованием методов оптимизации, которые могут влиять на поведение приложения. Например, оптимизации компилятора для повышения производительности могут привести к состоянию конкуренции в многопоточных приложениях.

Чтобы создать и протестировать версию консольного приложения для выпуска, откройте **терминал** и выполните следующую команду:

```dotnetcli
dotnet run --configuration Release
```

## <a name="additional-resources"></a>Дополнительные ресурсы

* [Debugging in Visual Studio Code](https://code.visualstudio.com/docs/editor/debugging) (Отладка в Visual Studio Code)

## <a name="next-steps"></a>Следующие шаги

В этом учебнике вы использовали средства отладки Visual Studio Code. Сведения о публикации развертываемой версии приложения см. в разделе [Публикация приложения](cli-create-console-app.md#publish-your-app).

<!--In the next tutorial, you publish a deployable version of the app.

> [!div class="nextstepaction"]
> [Publish a .NET Core console application with Visual Studio Code](publishing-with-visual-studio-code.md)
-->