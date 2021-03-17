---
title: Практическое руководство. Локализация приложения
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- localization [WPF], applications
- LocBaml tool [WPF]
- applications [WPF], localizing
ms.assetid: 5001227e-9326-48a4-9dcd-ba1b89ee6653
ms.openlocfilehash: d08f991204b2d74899cbd1aee82c0cc23e175dd4
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59298322"
---
# <a name="how-to-localize-an-application"></a>Практическое руководство. Локализация приложения
В этом учебнике рассматривается создание локализованного приложения с помощью средства LocBaml.  
  
> [!NOTE]
>  Средство LocBaml не является готовым приложением. Оно представлено в качестве примера, в котором используются некоторые API локализации и показывается, как можно написать средство локализации.  
  
<a name="Introduction"></a>   
## <a name="overview"></a>Обзор  
 В этом обзоре предоставляется поэтапный подход к локализации приложений. Сначала необходимо подготовить приложение так, чтобы можно было извлечь текст, который будет переведен. После перевода текста требуется влить переведенный текст в новую копию исходного приложения.  
  
<a name="Requirements"></a>   
## <a name="requirements"></a>Требования  
 В ходе данного обсуждения будет использоваться [!INCLUDE[TLA#tla_msbuild](../../../../includes/tlasharptla-msbuild-md.md)], который является компилятором, запускаемым из командной строки.  
  
 Кроме того, будет рекомендовано использовать файл проекта. Инструкции по использованию [!INCLUDE[TLA2#tla_msbuild](../../../../includes/tla2sharptla-msbuild-md.md)] и файлы проекта, см. в разделе [сборки и развертывания](../app-development/building-and-deploying-wpf-applications.md).  
  
 Во всех примерах в этом разделе в качестве языка и региональных параметров используется en-US (английский (США)). Это позволяет проходить по шагам примеров без установки другого языка.  
  
<a name="create_sample_app"></a>   
## <a name="create-a-sample-application"></a>Создание примера приложения  
 На этом шаге вы будете выполнять подготовку приложения к локализации. В примерах [!INCLUDE[TLA#tla_winclient](../../../../includes/tlasharptla-winclient-md.md)] предоставляется приложение HelloApp, которое будет использоваться для примеров кода в этом разделе. Если вы хотите использовать этот пример, скачайте [!INCLUDE[TLA#tla_xaml](../../../../includes/tlasharptla-xaml-md.md)] файлов из [средства LocBaml](https://go.microsoft.com/fwlink/?LinkID=160016).  
  
1. Разработайте свое приложение до точки, в которой хотите начать локализацию.  
  
2. Укажите язык разработки в файле проекта, чтобы [!INCLUDE[TLA2#tla_msbuild](../../../../includes/tla2sharptla-msbuild-md.md)] создал основную сборку и вспомогательную сборку (файл с расширением .resources.dll), которая будет содержать ресурсы нейтрального языка. Файл проекта в примере HelloApp — HelloApp.csproj. В этом файле можно найти язык разработки, заданный следующим образом:  
  
     `<UICulture>en-US</UICulture>`  
  
3. Добавьте ИД пользователей в свои файлы [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)]. ИД пользователей используются для отслеживания изменений в файлах и для идентификации элементов, которые должны быть переведены. Чтобы добавить ИД пользователей в файлы, запустите **updateuid** в файле проекта:  
  
     **msbuild -t:updateuid helloapp.csproj**  
  
     Чтобы проверить, что отсутствующие или дублированные ИД пользователей, запустите **checkuid**:  
  
     **MSBuild - t: checkuid helloapp.csproj**  
  
     После выполнения команды **updateuid**, файлы должны содержать ИД пользователей. Например, в файле Pane1.xaml приложения HelloApp вы должны найти следующее:  
  
     `<StackPanel x:Uid="StackPanel_1">`  
  
     `<TextBlock x:Uid="TextBlock_1">Hello World</TextBlock>`  
  
     `<TextBlock x:Uid="TextBlock_2">Goodbye World</TextBlock>`  
  
     `</StackPanel>`  
  
<a name="create_dll"></a>   
## <a name="create-the-neutral-language-resources-satellite-assembly"></a>Создание вспомогательной сборки ресурсов нейтрального языка  
 После настройки приложения для создания вспомогательной сборки для ресурсов нейтрального языка можно построить приложение. При этом будет создана основная сборка приложения, а также вспомогательная сборка ресурсов нейтрального языка, которая требуется LocBaml для локализации. Построение приложения  
  
1. Скомпилируйте HelloApp, чтобы создать [!INCLUDE[TLA#tla_dll](../../../../includes/tlasharptla-dll-md.md)]:  
  
     **msbuild helloapp.csproj**  
  
2. Новая основная сборка приложения, HelloApp.exe, создается в следующей папке:  
  
     `C:\HelloApp\Bin\Debug\`  
  
3. Новая вспомогательная сборка ресурсов нейтрального языка, HelloApp.resources.dll, создается в следующей папке:  
  
     `C:\HelloApp\Bin\Debug\en-US\`  
  
<a name="build_locbaml"></a>   
## <a name="build-the-locbaml-tool"></a>Построение средства LocBaml  
  
1. Все файлы, необходимые для построения LocBaml, находятся в примерах [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)]. Загрузить файлы C# с [средства LocBaml](https://go.microsoft.com/fwlink/?LinkID=160016).  
  
2. Из командной строки запустите файл проекта (locbaml.csproj), чтобы построить это средство:  
  
     **msbuild locbaml.csproj**  
  
3. Перейдите в каталог Bin\Release, чтобы найти созданный исполняемый файл (locbaml.exe). Например: C:\LocBaml\Bin\Release\locbaml.exe.  
  
4. При запуске LocBaml вы можете указать следующие параметры.  
  
    -   **синтаксический анализ** или **-p:** Анализирует Baml, ресурсы или [!INCLUDE[TLA2#tla_dll](../../../../includes/tla2sharptla-dll-md.md)] файлы для создания файла CSV или txt.  
  
    -   **создать** или **-g:** Создает локализованный двоичный файл, используя переведенный файл.  
  
    -   **out** или **-o** {*каталог_файла*] **:** Имя выходного файла.  
  
    -   **язык и региональные параметры** или **- cul** {*языка и региональных параметров*] **:** Языковой стандарт выходных сборок.  
  
    -   **Перевод** или **- trans** {*translation.csv*] **:** Переведенный или локализованного файла.  
  
    -   **asmpath** or **-asmpath:** {*filedirectory*] **:** Если ваш [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] код содержит пользовательские элементы управления, необходимо предоставить **asmpath** в сборку пользовательского элемента управления.  
  
    -   **nologo:** Отображение логотипа или сведений об авторских правах.  
  
    -   **verbose:** Отображает сведения режима подробного протоколирования.  
  
    > [!NOTE]
    >  Если при запуске этого средства вам потребуется список параметров, введите **LocBaml.exe** и нажмите клавишу ВВОД.  
  
<a name="parse_dll"></a>   
## <a name="use-locbaml-to-parse-a-file"></a>Использование LocBaml для анализа файла  
 Теперь, после создания средства LocBaml, вы можете выполнить анализ файла HelloApp.resources.dll, чтобы извлечь текстовое содержимое, которое будет локализовано.  
  
1. Скопируйте LocBaml.exe в папку приложения bin\debug, где была создана основная сборка приложения.  
  
2. Чтобы выполнить анализ файла вспомогательной сборки и сохранить результат в виде CSV-файла, используйте следующую команду:  
  
     **/Parse LocBaml.exe HelloApp.resources.dll /out:Hello.csv**  
  
    > [!NOTE]
    >  Если входной файл HelloApp.resources.dll не находится в том же каталоге, что и LocBaml.exe, переместите один из файлов таким образом, чтобы оба файла были в одном каталоге.  
  
3. При выполнении анализа файлов с помощью LocBaml выходные данные состоят из семи полей, разделенных запятыми (CSV-файлы) или знаками табуляции (TXT-файлы). Ниже показан проанализированный CSV-файл для HelloApp.resources.dll:

   | |
   |-|
   |HelloApp.g.en-US.resources:window1.baml,Stack1:System.Windows.Controls.StackPanel.$Content,Ignore,FALSE, FALSE,,#Text1;#Text2;|
   |HelloApp.g.en-US.resources:window1.baml,Stack1:System.Windows.Controls.StackPanel.$Content,Ignore,FALSE, FALSE,,#Text1;#Text2;|
   |HelloApp.g.en-US.resources:window1.baml,Stack1:System.Windows.Controls.StackPanel.$Content,Ignore,FALSE, FALSE,,#Text1;#Text2;|

   Это следующие семь полей.  
  
   1.  **Имя BAML**. Имя ресурса BAML по отношению к вспомогательной сборке исходного языка.  
  
   2.  **Ключ ресурса**. Идентификатор локализованного ресурса.  
  
   3.  **Категория**. Тип значения. См. в разделе [атрибуты и комментарии локализации](localization-attributes-and-comments.md).  
  
   4.  **Удобочитаемость**. Может ли значение быть прочитано средством локализации. См. в разделе [атрибуты и комментарии локализации](localization-attributes-and-comments.md).  
  
   5.  **Изменяемость**. Может ли значение изменяться средством локализации. См. в разделе [атрибуты и комментарии локализации](localization-attributes-and-comments.md).  
  
   6.  **Комментарии**. Дополнительное описание значения, помогающее определить способ локализации значения. См. в разделе [атрибуты и комментарии локализации](localization-attributes-and-comments.md).  
  
   7.  **Значение**. Текстовое значение для перевода на нужный язык.  
  
   В следующей таблице показывается, как эти поля соответствуют разделенным значениям CSV-файла.  
  
   |Имя BAML|Ключ ресурса|Категория|Удобочитаемость|Изменяемость|Комментарии|Значение|  
   |---------------|------------------|--------------|-----------------|-------------------|--------------|-----------|
   |HelloApp.g.en-US.resources:window1.baml|Stack1:System.Windows.Controls.StackPanel.$Content|Пропустить|false|false||#Text1;#Text2|
   |HelloApp.g.en-US.resources:window1.baml|Text1:System.Windows.Controls.TextBlock.$Content|Нет|true|true||Hello World|
   |HelloApp.g.en-US.resources:window1.baml|Text1:System.Windows.Controls.TextBlock.$Content|Нет|true|true||Goodbye World|
  
   Обратите внимание, что все значения для **комментарии** поля не содержат значений; Если поле не имеет значения, оно пустое. Также Обратите внимание, что элемент в первой строке ни читаемым, ни изменяемым и имеет «Ignore» как его **категории** значение, все это указывает, что значение не локализуемое.  
  
4. Чтобы облегчить поиск локализуемых элементов в проанализированных файлах, особенно в больших файлах, можно сортировать или фильтровать элементы по **категории**, **удобочитаемость**, и **Изменяемости**. Например можно отфильтровать нечитаемые и неизменяемые значения.  
  
<a name="translate_loc_content"></a>   
## <a name="translate-the-localizable-content"></a>Перевод локализуемого содержимого  
 Используйте любое доступное средство для перевода извлеченного содержимого. Для этого рекомендуется записать ресурсы в CSV-файл и просматривать их в [!INCLUDE[TLA#tla_xl](../../../../includes/tlasharptla-xl-md.md)], внося переведенный текст в последний столбец (значение).  
  
<a name="merge_translations"></a>   
## <a name="use-locbaml-to-generate-a-new-resourcesdll-file"></a>Использование LocBaml для создания нового файла .resources.dll  
 Содержимое, которое было идентифицировано при анализе файла HelloApp.resources.dll с помощью LocBaml, переведено, и его необходимо влить обратно в исходное приложение. Используйте **создания** или **-g** параметр, чтобы создать новый. файл resources.dll.  
  
1. Чтобы создать новый файл HelloApp.resources.dll, используйте следующий синтаксис. Пометьте язык и региональные параметры как en-US (/cul:en-US).  
  
     **LocBaml.exe /generate HelloApp.resources.dll /trans:Hello.csv /out:c:\ /cul:en-US**  
  
    > [!NOTE]
    >  Если входной файл Hello.csv не находится в том же каталоге, что и исполняемый файл LocBaml.exe, переместите один из файлов таким образом, чтобы оба файла были в одном каталоге.  
  
2. Замените старый файл HelloApp.resources.dll в каталоге C:\HelloApp\Bin\Debug\en-US\HelloApp.resources.dll на новый созданный файл HelloApp.resources.dll.  
  
3. Теперь в вашем приложении фразы Hello World и Goodbye World должны быть переведены.  
  
4. Для перевода на другой язык используйте язык, на который вы переводите. В следующем примере показано, как переводить на канадский французский.  
  
     **LocBaml.exe / создать HelloApp.resources.dll /trans:Hellofr-CA.csv /out:c: \ /cul:fr-ЦС**  
  
5. В той же основной сборке приложения создайте новую папку для выбранного языка и региональных параметров, в которой будет размещена новая вспомогательная сборка. Для канадского французского папку можно назвать fr-CA.  
  
6. Скопируйте созданную вспомогательную сборку в новую папку.  
  
7. Чтобы протестировать новую вспомогательную сборку, необходимо изменить язык и региональные параметры, с которыми будет выполняться приложение. Это можно сделать одним из двух способов.  
  
    -   Изменить региональные параметры операционной системы (**запустить** &#124; **панели управления** &#124; **язык и региональные стандарты**).  
  
    -   В своем приложении добавьте в файл App.xaml.cs следующий код:  
  
   [!code-xaml[LocBamlChangeCultureSnippets#LocBamlChangeCultureMARKUP](~/samples/snippets/csharp/VS_Snippets_Wpf/LocBamlChangeCultureSnippets/CSharp/App.xaml#locbamlchangeculturemarkup)]
   [!code-csharp[LocBamlChangeCultureSnippets#LocBamlChangeCultureCODEBEHIND](~/samples/snippets/csharp/VS_Snippets_Wpf/LocBamlChangeCultureSnippets/CSharp/App.xaml.cs#locbamlchangeculturecodebehind)]
   [!code-vb[LocBamlChangeCultureSnippets#LocBamlChangeCultureCODEBEHIND](~/samples/snippets/visualbasic/VS_Snippets_Wpf/LocBamlChangeCultureSnippets/VisualBasic/Application.xaml.vb#locbamlchangeculturecodebehind)]  
  
<a name="Some_Tips_for_Using_LocBaml"></a>   
## <a name="some-tips-for-using-locbaml"></a>Советы по использованию LocBaml  
  
-   Все зависимые сборки, которые определяют пользовательские элементы управления, должны быть скопированы в локальный каталог LocBaml или установлены в глобальном кэше сборок. Это необходимо потому, что API локализации должен иметь доступ к зависимым сборкам при чтении [!INCLUDE[TLA#tla_baml](../../../../includes/tlasharptla-baml-md.md)].  
  
-   Если основная сборка имеет подпись, созданная библиотека DLL ресурсов также должна быть подписана для ее загрузки.  
  
-   Версия библиотеки DLL локализованных ресурсов должна быть синхронизирована с основной сборкой.  
  
<a name="Whats_Next"></a>   
## <a name="whats-next"></a>Что дальше?  
 Теперь у вас есть базовое представление о том, как использовать средство LocBaml.  Вы можете создать файл, содержащий ИД пользователей. С помощью средства LocBaml вы можете анализировать файл для извлечения локализуемого содержимого и после перевода этого содержимого можете создать файл .resources.dll, объединяющий переведенное содержимое. В этом разделе не рассматриваются все возможные детали, но теперь у вас есть знания, необходимые для использования LocBaml для локализации приложений.  
  
## <a name="see-also"></a>См. также

- [Глобализация для WPF](globalization-for-wpf.md)
- [Обзор использования автоматической разметки](use-automatic-layout-overview.md)
