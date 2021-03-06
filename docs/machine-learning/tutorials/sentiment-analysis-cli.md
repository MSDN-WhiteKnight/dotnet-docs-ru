---
title: Анализ тональности с помощью интерфейса командной строки ML.NET
description: Автоматическое создание модели машинного обучения и связанного кода C# на основе примера набора данных
author: cesardl
ms.author: cesardl
ms.date: 06/03/2020
ms.custom: mvc,mlnet-tooling
ms.topic: tutorial
ms.openlocfilehash: 47c38bb0b66a6fc08dd319583847dd83baedcd1e
ms.sourcegitcommit: 42d436ebc2a7ee02fc1848c7742bc7d80e13fc2f
ms.translationtype: HT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/04/2021
ms.locfileid: "102103703"
---
# <a name="analyze-sentiment-using-the-mlnet-cli"></a>Анализ тональности с помощью интерфейса командной строки ML.NET

Узнайте, как с помощью ML.NET CLI автоматически создать модель ML.NET и базовый код C#. Вы предоставите набор данных и задачу машинного обучения, которую требуется реализовать, а CLI с помощью подсистемы AutoML создаст исходный код для формирования и развертывания модели, а также модель классификации.

Работая с этим учебником, вы выполните следующие действия:
> [!div class="checklist"]
>
> - подготовку данных для выбранной задачи машинного обучения;
> - запуск команды mlnet classification из CLI;
> - просмотреть результаты показателей качества;
> - изучение созданного кода C# для использования модели в приложении;
> - анализ созданного кода C#, который использовался для обучения модели.

> [!NOTE]
> Здесь описано, как использовать средство ML.NET CLI, которое сейчас доступно в режиме предварительной версии. Этот материал может быть изменен. Дополнительные сведения см. на странице [ML.NET](https://dotnet.microsoft.com/apps/machinelearning-ai/ml-dotnet).

ML.NET CLI входит в состав ML.NET, и его основной целью является упрощение изучения ML.NET для разработчиков .NET, поэтому, чтобы приступить к работе, не нужно писать код с нуля.

Для создания качественных моделей и исходного кода ML.NET на основе предоставляемых наборов обучающих данных средство ML.NET CLI можно запускать в любой командной строке (Windows, Mac или Linux).

## <a name="pre-requisites"></a>Предварительные требования

- [Пакет SDK для .NET Core 3.1](https://dotnet.microsoft.com/download/dotnet/3.1) или более поздней версии
- (Необязательно.) [Visual Studio 2019](https://visualstudio.microsoft.com/vs/)
- [ML.NET CLI](../how-to-guides/install-ml-net-cli.md)

Вы можете запускать проекты, написанные на C#, из Visual Studio или с помощью `dotnet run` (.NET Core CLI).

## <a name="prepare-your-data"></a>подготавливать данные;

Мы будем работать с существующим набором данных, используемым в сценарии "Анализ тональности", который представляет собой задачу машинного обучения двоичной классификации. Вы точно так же можете использовать собственный набор данных, а модель и код будут созданы автоматически.

1. Скачайте [ZIP-файл набора данных предложений с меткой тональности UCI (ссылка дана в следующем примечании)](http://archive.ics.uci.edu/ml/machine-learning-databases/00331/sentiment%20labelled%20sentences.zip) и распакуйте его в любую папку.

    > [!NOTE]
    > Наборы данных в этом руководстве взяты из документа From Group to Individual Labels using Deep Features ("От групповых до индивидуальных меток с использованием функций глубокого обучения"), Котциас (Kotzias) и KDD 2015, и размещены в репозитории машинного обучения UCI Д. Дуа (D. Dua) и Э. Карра Танискиду (E. Karra Taniskidou) (2017). UCI Machine Learning Repository (Репозиторий машинного обучения UCI) [http://archive.ics.uci.edu/ml ]. Ирвайн, Калифорния: Калифорнийский университет, Школа информационных технологий и компьютерных наук.

2. Скопируйте файл `yelp_labelled.txt` в созданную ранее папку (например, `/cli-test`).

3. Откройте предпочитаемую командную строку и перейдите к папке, куда был скопирован файл набора данных. Пример:

    ```console
    cd /cli-test
    ```

    Используйте любой текстовый редактор, например Visual Studio Code, чтобы открыть и проанализировать файл набора данных `yelp_labelled.txt`. Вы увидите следующую структуру:

    - У файла нет заголовка. Вы будете использовать индекс столбца.

    - Существует только два столбца:

        | Текст (индекс столбца — 0) | Надпись (индекс столбца — 1)|
        |--------------------------|-------|
        | Ого... Отличное место. | 1 |
        | Корочка так себе. | 0 |
        | Невкусно, и текстура просто отвратительна. | 0 |
        | …ЕЩЕ БОЛЬШЕ СТРОК ТЕКСТА… | …(1 или 0)… |

    Закройте файл набора данных в редакторе.

    Теперь вы готовы использовать CLI в сценарии "Анализ тональности".

    > [!NOTE]
    > После завершения работы с этим руководством попробуйте применить собственные наборы данных, при условии что они подходят для любой задачи машинного обучения, поддерживаемой в предварительной версии ML.NET CLI, — *"Двоичная классификация", "Классификация", "Регрессия"* и *"Рекомендация"* .

## <a name="run-the-mlnet-classification-command"></a>Выполнение команды mlnet classification

1. Выполните следующую команду ML.NET CLI:

    ```console
    mlnet classification --dataset "yelp_labelled.txt" --label-col 1 --has-header false --train-time 10
    ```

    Эта команда запускает **`mlnet classification`команду**:
    - для **задачи машинного обучения** *классификации*;
    - использует **файл набора данных `yelp_labelled.txt`** в качестве обучающего и тестового набора данных (CLI внутренним образом применит перекрестную проверку или разделит его на два набора данных — один для обучения и один для тестирования);
    - где **целевой столбец** (обычно называемый **меткой**), который нужно спрогнозировать представляет собой **столбец с индексом 1** (то есть второй столбец, поскольку индекс отсчитывается от нуля);
    - **не использует заголовок файла** с именами столбцов, так как у этого конкретного файла набора данных нет заголовка;
    - **целевое время изучения или обучения** в эксперименте составляет **10 секунд**.

    Вы увидите выходные данные CLI, аналогичные следующим:

    ![Классификация CLI ML.NET в PowerShell](./media/mlnet-cli/mlnet-classification-powershell.gif)

    В данном случае, когда у средства CLI было всего 10 секунд и небольшой набор данных, ему удалось выполнить довольно много итераций, то есть провести обучение несколько раз на основе сочетаний различных алгоритмов или конфигурации с преобразованиями различных внутренних данных и гиперпараметров алгоритма.

    В итоге за 10 секунд найдена модель высшего качества с определенным алгоритмом обучения и конкретной конфигурацией. В зависимости от времени изучения команда может выдать другой результат. Выбор производится с учетом нескольких отображаемых метрик, таких как `Accuracy`.

    **Общие сведения о метриках качества модели**

    Первая и самая простая для понимания метрика оценки модели двоичной классификации — точность. "Точность — это доля правильных прогнозов на основе тестового набора данных". Чем ближе к 100 % (1,00), тем лучше.

    Однако бывают случаи, когда оценки с помощью одной метрики точности недостаточно, особенно если метка (0 и 1 в данном случае) несбалансирована в тестовом наборе данных.

    Сведения о [дополнительных метриках и **подробные сведения о метриках** ML.NET (точность, AUC, AUCPR, F1-мера, которые используются для оценки различных моделей)](../resources/metrics.md).

    > [!NOTE]
    > Можно взять этот же набор данных и указать для `--max-exploration-time` несколько минут (например, три минуты или 180 секунд), и в результате вы получите модель еще лучшего качества с другой конфигурацией обучающего конвейера для этого набора данных (размером 1000 строк).

    Чтобы найти готовую для работы модель высшего или хорошего качества, предназначенную для крупных наборов данных, необходимо проводить эксперименты с помощью CLI, указывая более продолжительное время изучения в зависимости от размера набора данных. На самом деле во многих случаях может потребоваться несколько часов, особенно если речь идет о наборе данных с большим числом строк и столбцов.

1. В результате выполнения предыдущей команды создаются следующие активы:

    - готовый к использованию ZIP-файл сериализованной модели ("модели высшего качества");
    - код C# для запуска или оценки созданной модели (для прогнозирования в приложениях пользователей);
    - обучающий код C#, используемый для создания этой модели (в целях обучения);
    - файл журнала со всеми изученными итерациями, содержащими подробные сведения о каждом опробованном алгоритме с сочетанием его гиперпараметров и преобразований данных.

    Первые два актива (ZIP-файл модели и код C# для запуска этой модели) можно использовать непосредственно в приложениях конечных пользователей (веб-приложениях и службах ASP.NET Core, классических приложениях и т. д.) для прогнозирования с помощью созданной модели машинного обучения.

    Третий актив, обучающий код, показывает, какой код ML.NET API использовало средство CLI для обучения созданной модели, поэтому можно определить, какой конкретный алгоритм обучения и гиперпараметры были выбраны средством CLI.

Эти активы ресурсы рассматриваются в следующих шагах руководства.

## <a name="explore-the-generated-c-code-to-use-for-running-the-model-to-make-predictions"></a>Изучение созданного кода C# для запуска модели прогнозирования

1. В Visual Studio (2017 или 2019) откройте созданное решение в папке `SampleClassification`, находящейся в исходной конечной папке (имя папки в учебнике — `/cli-test`). Вы увидите решение, аналогичное следующему:

    > [!NOTE]
    > В этом руководстве рекомендуется использовать Visual Studio, но можно также изучить созданный код C# (два проекта) в любом текстовом редакторе и запустить созданное консольное приложение с помощью `dotnet CLI` на компьютерах с ОС macOS, Windows или Linux.

    ![Решение VS, созданное с помощью CLI](./media/mlnet-cli/mlnet-cli-solution-explorer.png)

    - Созданную **библиотеку классов**, содержащую сериализованную модель машинного обучения (в ZiP-файле) и классы данных (модели данных), можно использовать непосредственно в приложениях конечных пользователей даже путем прямого указания на нее (или путем перемещения кода).
    - Созданное **консольное приложение** содержит код выполнения, который нужно проверить, после чего можно многократно использовать код оценки (код, который запускает модель машинного обучения для прогнозирования), перемещая этот простой код (всего несколько строк) в приложения конечных пользователей для прогнозирования.

1. Откройте файлы классов **ModelInput.cs** и **ModelOutput.cs** в проекте библиотеки классов. Вы увидите, что это классы данных или классы POCO, используемые для хранения данных. Это стереотипный код, который удобно использовать, если в наборе данных десятки или даже сотни столбцов.
    - Класс `ModelInput` используется при чтении данных из набора данных.
    - Класс `ModelOutput` используется для получения результата прогнозирования (данные прогнозирования).

1. Откройте файл Program.cs и изучите код. С помощью всего нескольких строк вы сможете запустить модель и создать пример прогноза.

    ```csharp
    static void Main(string[] args)
    {
        // Create single instance of sample data from first line of dataset for model input
        ModelInput sampleData = new ModelInput()
        {
            Col0 = @"Wow... Loved this place.",
        };

        // Make a single prediction on the sample data and print results
        var predictionResult = ConsumeModel.Predict(sampleData);

        Console.WriteLine("Using model to make single prediction -- Comparing actual Col1 with predicted Col1 from sample data...\n\n");
        Console.WriteLine($"Col0: {sampleData.Col0}");
        Console.WriteLine($"\n\nPredicted Col1 value {predictionResult.Prediction} \nPredicted Col1 scores: [{String.Join(",", predictionResult.Score)}]\n\n");
        Console.WriteLine("=============== End of process, hit any key to finish ===============");
        Console.ReadKey();
    }
    ```

    - В первых строках этого кода создается *один образец данных*, который в этом случае основывается на первой строке набора данных, используемого для составления прогноза. Вы также можете создать собственные жестко запрограммированные данные, обновив следующий код.

        ```csharp
        ModelInput sampleData = new ModelInput()
        {
            Col0 = "The ML.NET CLI is great for getting started. Very cool!"
        };
        ```

    - В следующей строке кода к заданным входным данным применяется метод `ConsumeModel.Predict()`, который позволяет составить прогноз и возвращает результаты (на основе схемы ModelOutput.cs).
    - В последних строках кода выводятся свойства образца данных (в этом случае комментарии), а также прогноз тональности и соответствующие оценки положительной (1) и отрицательной тональности (2).

1. Запустите проект с помощью исходного примера данных, загруженного из первой строки набора данных, или предоставьте пример собственных настраиваемых жестко закодированных данных. Вы должны получить прогноз, аналогичный следующему:

![Запуск приложения CLI ML.NET из Visual Studio](./media/mlnet-cli/mlnet-cli-console-app.png))

1. Попробуйте изменить пример жестко закодированных данных на другие предложения с различной тональностью и посмотрите, как модель прогнозирует положительную или отрицательную тональность.

## <a name="infuse-your-end-user-applications-with-ml-model-predictions"></a>Внедрение приложений для конечных пользователей с прогнозами модели машинного обучения

Запускать модель в приложении конечного пользователя и делать прогнозы можно с помощью аналогичного кода для оценки модели машинного обучения.

Например, этот код можно переместить прямо в классическое приложение Windows, такое как **WPF** и **WinForms**, и запустить модель так же, как в консольном приложении.

Однако способ реализации этих строк кода для запуска модели машинного обучения необходимо оптимизировать (то есть кэшировать и один раз загрузить ZIP-файл модели) и использовать одноэлементные модели, а не создавать их при каждом запросе, особенно в том случае, если приложение (веб-приложение или распределенная служба) должно быть масштабируемым, как описано в следующем разделе.

### <a name="running-mlnet-models-in-scalable-aspnet-core-web-apps-and-services-multi-threaded-apps"></a>Запуск моделей ML.NET в масштабируемых веб-приложениях и службах ASP.NET Core (многопоточных приложениях)

Процесс создания объекта модели (объекта `ITransformer`, загруженного из ZIP-файла модели) и объекта `PredictionEngine` должен быть оптимизирован, особенно при запуске в масштабируемых веб-приложениях и распределенных службах. Оптимизация первого объекта модели (`ITransformer`) не вызывает трудностей. Так как объект `ITransformer` является потокобезопасным, его можно кэшировать как одноэлементный или статический, чтобы загружать модель всего один раз.

Для второго объекта `PredictionEngine` сделать это не так просто, поскольку объект `PredictionEngine` не является потокобезопасным и вы не можете создать его экземпляр в виде одноэлементного или статического объекта в приложении ASP.NET Core. Проблема потокобезопасности и масштабируемости подробно рассматривается в этой [публикации блога](https://devblogs.microsoft.com/cesardelatorre/how-to-optimize-and-run-ml-net-models-on-scalable-asp-net-core-webapis-or-web-apps/).

Но сейчас все стало намного проще. Мы разработали упрощенный подход и создали отличный **пакет интеграции .NET Core** для использования в приложениях и службах ASP.NET Core. Его нужно зарегистрировать в службах внедрения зависимостей приложения и затем использовать напрямую из кода. См. инструкции в следующих руководствах и примерах:

- [Учебник. Запуск моделей ML.NET в масштабируемых веб-приложениях и веб-API ASP.NET Core](../how-to-guides/serve-model-web-api-ml-net.md)
- [Пример. Масштабируемая модель ML.NET в веб-API ASP.NET Core](https://aka.ms/mlnet-sample-netcoreintegrationpkg)

## <a name="explore-the-generated-c-code-that-was-used-to-train-the-best-quality-model"></a>Изучение созданного кода C#, который использовался для модели высшего качества

Для получения более глубоких знаний изучите созданный код C#, который использовался для обучения модели средством CLI.

Сейчас этот обучающий код модели создается в пользовательском классе с именем `ModelBuilder` и доступен для изучения.

Что еще более важно, можно сравнить созданный для этого конкретного сценария (модель анализа тональности) обучающий код с кодом, приведенным в следующем учебнике.

- Сравните: [Учебник. Использование ML.NET для анализа тональности методом двоичной классификации](sentiment-analysis.md).

Будет интересно сравнить выбранный алгоритм и конфигурацию конвейера в этом руководстве с кодом, созданным с помощью средства CLI. В зависимости от продолжительности поиска оптимальных моделей вы можете выбрать особый алгоритм с собственными гиперпараметрами и конфигурацией конвейера.

В этом руководстве вы узнали, как:
> [!div class="checklist"]
>
> - подготовить данные для выбранной задачи машинного обучения (устраняемой проблемы);
> - запускать команду mlnet classification из средства CLI;
> - просмотреть результаты показателей качества;
> - понять созданный код C# код для запуска модели (код, используемый в приложении конечных пользователей);
> - изучить созданный код C#, который использовался для модели высшего качества (в целях обучения).

## <a name="see-also"></a>См. также

- [Автоматизация обучения модели с помощью интерфейса командной строки ML.NET](../automate-training-with-cli.md)
- [Учебник. Запуск моделей ML.NET в масштабируемых веб-приложениях и веб-API ASP.NET Core](../how-to-guides/serve-model-web-api-ml-net.md)
- [Пример. Масштабируемая модель ML.NET в веб-API ASP.NET Core](https://aka.ms/mlnet-sample-netcoreintegrationpkg)
- [Справочное руководство по команде auto-train в ML.NET CLI](../reference/ml-net-cli-reference.md)
- [Данные телеметрии в интерфейсе командной строки ML.NET](../resources/ml-net-cli-telemetry.md)
