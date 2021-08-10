---
title: Общие сведения о двусторонних возможностях в WPF
ms.date: 03/30/2017
helpviewer_keywords:
- Span elements [WPF]
- bidirectional features [WPF]
ms.assetid: fd850e25-7dba-408c-b521-8873e51dc968
ms.openlocfilehash: 575598f48b3cfdf636be78a9de6e0c9a7fd9c208
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59079829"
---
# <a name="bidirectional-features-in-wpf-overview"></a>Общие сведения о двусторонних возможностях в WPF
В отличие от других платформ разработки WPF имеет множество функций, поддерживающих быструю разработку двунаправленного содержимого, например, направленного как слева направо и справа налево в одном документе. В то же время WPF имеет превосходный интерфейс для пользователей, которым необходимы двунаправленные возможности, такие как арабский и иврит, пользователям, говорящим.  
  
 В следующих разделах описаны различные возможности двунаправленного письма с примерами, иллюстрирующими способы достижения наилучшего отображения двунаправленного содержимого на экране. В большинстве примеров используется XAML, хотя вы можете легко применить концепции, чтобы C# или Microsoft Visual Basic.  

<a name="FlowDirection"></a>   
## <a name="flowdirection"></a>FlowDirection  
 Основным свойством, определяющим направление потока содержимого в WPF приложение <xref:System.Windows.FrameworkElement.FlowDirection%2A>. Это свойство может быть присвоено одно из двух значений перечисления, <xref:System.Windows.FlowDirection.LeftToRight> или <xref:System.Windows.FlowDirection.RightToLeft>. Свойство доступно для всех WPF элементы, которые наследуются от <xref:System.Windows.FrameworkElement>.  
  
 В следующем примере задается направление потока <xref:System.Windows.Controls.TextBox> элемент.  
  
 **Направление потока слева направо**  
  
 [!code-xaml[LTRRTL#LTR](~/samples/snippets/csharp/VS_Snippets_Wpf/LTRRTL/CS/Pane1.xaml#ltr)]  
  
 **Направление потока справа налево**  
  
 [!code-xaml[LTRRTL#RTL](~/samples/snippets/csharp/VS_Snippets_Wpf/LTRRTL/CS/Pane1.xaml#rtl)]  
  
 На следующем рисунке показано, как работает указанный код.  
    
 ![Рисунок, иллюстрирующий различными направлениями потоков.](./media/bidirectional-features-in-wpf-overview/left-right-right-left.png)  
  
 Элемент в пределах UI  дерева будут наследовать <xref:System.Windows.FrameworkElement.FlowDirection%2A> из своего контейнера. В следующем примере <xref:System.Windows.Controls.TextBlock> находится внутри <xref:System.Windows.Controls.Grid>, который находится внутри <xref:System.Windows.Window>. Установка <xref:System.Windows.FrameworkElement.FlowDirection%2A> для <xref:System.Windows.Window> это значение для <xref:System.Windows.Controls.Grid> и <xref:System.Windows.Controls.TextBlock> также.  
  
 В следующем примере показано задание <xref:System.Windows.FrameworkElement.FlowDirection%2A>.  
  
 [!code-xaml[FlowDirection#FlowDirection](~/samples/snippets/csharp/VS_Snippets_Wpf/FlowDirection/CS/Window1.xaml#flowdirection)]  
  
 Верхний уровень <xref:System.Windows.Window> имеет <xref:System.Windows.FlowDirection.RightToLeft><xref:System.Windows.FlowDirection>, поэтому все элементы, содержащиеся в нем, наследуют то же <xref:System.Windows.FrameworkElement.FlowDirection%2A>. Элемент мог переопределить заданное <xref:System.Windows.FrameworkElement.FlowDirection%2A> его необходимо добавить явное изменение направления как во втором <xref:System.Windows.Controls.TextBlock> в предыдущем примере, который изменяет на <xref:System.Windows.FlowDirection.LeftToRight>. Если аргумент <xref:System.Windows.FrameworkElement.FlowDirection%2A> определен, по умолчанию <xref:System.Windows.FlowDirection.LeftToRight> применяется.  
  
 На следующем рисунке показан в предыдущем примере выходных данных:

 ![Рисунок, иллюстрирующий изменение направления потока явной.](./media/bidirectional-features-in-wpf-overview/explicit-direction-change.png)  

<a name="FlowDocument"></a>   
## <a name="flowdocument"></a>FlowDocument  
 Многие платформы разработки, такие как HTML, Win32 и Java, обеспечивают специальную поддержку разработки двунаправленного содержимого. Языки разметки, такие как HTML предоставляют авторам содержимого необходимые средства разметки для отображения текста в любом требуемом направлении, например HTML 4.0 тег, «dir», который принимает в качестве значения «rtl» или «ltr». Этот тег аналогичен <xref:System.Windows.FrameworkElement.FlowDirection%2A> свойство, но <xref:System.Windows.FrameworkElement.FlowDirection%2A> свойство работает в более сложных способов для разметки текста и может использоваться для нетекстового содержимого.  
  
 В WPF, <xref:System.Windows.Documents.FlowDocument> является универсальным UI элемент, который может содержать сочетание текста, таблиц, изображений и других элементов. Этот элемент используется в примерах, описанных ниже.  
  
 Добавление текста к <xref:System.Windows.Documents.FlowDocument> можно сделать более таким образом один. Простой способ сделать это – <xref:System.Windows.Documents.Paragraph> которого является элемент уровня блока, используемый для группировки содержимого, такие как текст. Добавление текста в элементы встроенного уровня, в примерах используются <xref:System.Windows.Documents.Span> и <xref:System.Windows.Documents.Run>. <xref:System.Windows.Documents.Span> — Это элемент содержимого потока встроенного уровня, используемый для группировки других встроенных элементов, хотя <xref:System.Windows.Documents.Run> является элемент предназначен для содержания цепочки неформатированного текста содержимого потока встроенного уровня. Объект <xref:System.Windows.Documents.Span> может содержать несколько <xref:System.Windows.Documents.Run> элементов.  
  
 Первый пример документа содержит документ, который имеет несколько сетевых совместно используемых имен; например `\\server1\folder\file.ext`. Независимо от того на каком языке написан документ, в котором содержится эта сетевая ссылка, на арабском или английском, нам хотелось бы, чтобы он выглядел всегда одинаково. Приведенный ниже рисунок иллюстрирует использование элемента Span и показана ссылка в арабском <xref:System.Windows.FlowDirection.RightToLeft> документа:

 ![Рисунок, иллюстрирующий использование элемента Span. ](./media/bidirectional-features-in-wpf-overview/flow-direction-span-element.png "FlowDocument")  
  
 Поскольку текст <xref:System.Windows.FlowDirection.RightToLeft>, все специальные символы, такие как "\\«, разделяют текст справа налево. Результаты в ссылке, не отображаются в правильном порядке, поэтому для решения проблемы, текст необходимо внедрить, чтобы сохранить отдельного <xref:System.Windows.Documents.Run> передаваемых <xref:System.Windows.FlowDirection.LeftToRight>. Создавать отдельные <xref:System.Windows.Documents.Run> для каждого языка, более эффективный способ решения проблемы является внедрить реже используемый текст на английском языке в больших арабский <xref:System.Windows.Documents.Span>.  
  
 Следующий рисунок иллюстрирует это с помощью элемента Run, внедренный в элемент Span:

 ![Пример выполнения элемента внедрен в элемент Span.](./media/bidirectional-features-in-wpf-overview/embedded-span-element.png)  
  
 В следующем примере показано использование <xref:System.Windows.Documents.Run> и <xref:System.Windows.Documents.Span> элементов в документах.  
  
 [!code-xaml[RunSpan#RunSpan](~/samples/snippets/csharp/VS_Snippets_Wpf/RunSpan/CS/Window1.xaml#runspan)]  
  
<a name="SpanElements"></a>   
## <a name="span-elements"></a>Элементы Span  
 <xref:System.Windows.Documents.Span> Элемент работает в качестве разделителя между фрагментами текста с различными направлениями потоков.  Даже <xref:System.Windows.Documents.Span> считаются элементы с одинаковыми направлениями потока имеют разные двунаправленные области, т. е <xref:System.Windows.Documents.Span> элементы упорядочены в контейнере <xref:System.Windows.FlowDirection>, только содержимое внутри <xref:System.Windows.Documents.Span> элемент следует за <xref:System.Windows.FlowDirection> из <xref:System.Windows.Documents.Span>.  
  
 На следующем рисунке показано направление потока нескольких <xref:System.Windows.Controls.TextBlock> элементов.  
    
 ![Рисунок, иллюстрирующий текстовые блоки с различными направлениями потоков.](./media/bidirectional-features-in-wpf-overview/flow-direction-text-blocks.png)  
  
 В следующем примере показано, как использовать <xref:System.Windows.Documents.Span> и <xref:System.Windows.Documents.Run> элементов для получения результатов, представленных на предыдущем рисунке.  
  
 [!code-xaml[Span#Span](~/samples/snippets/csharp/VS_Snippets_Wpf/Span/CS/Window1.xaml#span)]  
  
 В <xref:System.Windows.Controls.TextBlock> элементы в этом примере <xref:System.Windows.Documents.Span> элементы располагаются в соответствии с <xref:System.Windows.FlowDirection> их родительские элементы, но текст внутри каждого <xref:System.Windows.Documents.Span> элемент последовательности согласно своему собственному <xref:System.Windows.FlowDirection>. Это применимо для латинского, арабского или любого другого языка.  
  
### <a name="adding-xmllang"></a>Добавление XML: lang  
 Приведенный ниже рисунок показывает другой пример, использующий числа и арифметические выражения, такие как `"200.0+21.4=221.4"`. Обратите внимание на то, что только <xref:System.Windows.FlowDirection> имеет значение.  
    
 ![Рисунок, иллюстрирующий отображение чисел с использованием только FlowDirection.](./media/bidirectional-features-in-wpf-overview/numbers-flow-right-left.png)  
  
 Пользователи данного приложения будут разочарованы выходные данные, даже если <xref:System.Windows.FlowDirection> правильно чисел не так, как должны быть отформатированы числа на арабском языке.  
  
 Элементы XAML могут включать XML атрибут (`xml:lang`), определяющий язык каждого элемента. XAML также поддерживает XML языковой принцип при котором `xml:lang` значения, применяющиеся к родительским элементам в дереве, используются дочерние элементы. В предыдущем примере так как язык не был определен для <xref:System.Windows.Documents.Run> элемента или любой из его свойство top на уровне элементов, по умолчанию `xml:lang` использовался, который является `en-US` для XAML. Внутренняя алгоритму формирования чисел Windows Presentation Foundation (WPF) числа выбираются в соответствии с языком – в данном случае английский. Чтобы арабские числа отображались правильно `xml:lang` необходимо задать.  
  
 На следующем рисунке показан пример с `xml:lang` добавлен.  
    
 ![Рисунок, иллюстрирующий арабские числа с направлением потока справа налево.](./media/bidirectional-features-in-wpf-overview/arabic-numbers-flow-right-left.png)  
  
 В следующем примере добавляется `xml:lang` в приложение.  
  
 [!code-xaml[LangAttribute#LangAttribute](~/samples/snippets/csharp/VS_Snippets_Wpf/LangAttribute/CS/Window1.xaml#langattribute)]  
  
 Имейте в виду, что во многих языках применяются различные `xml:lang` значения в зависимости от целевого региона, например, `"ar-SA"` и `"ar-EG"` представляют собой два диалекта арабского языка. В предыдущих примерах показано, что необходимо определить оба `xml:lang` и <xref:System.Windows.FlowDirection> значения.  
  
<a name="FlowDirectionNontext"></a>   
## <a name="flowdirection-with-non-text-elements"></a>Направление потока применительно к нетекстовым элементам  
 <xref:System.Windows.FlowDirection> Определяет не только направление текста в текстовом элементе, но также направление потока в практически любом другом UI элемент. Показано на следующем рисунке <xref:System.Windows.Controls.ToolBar> , использующая горизонтальную <xref:System.Windows.Media.LinearGradientBrush> для рисования фона с левой к правой градиента.  

 ![Рисунок, показывающий элемент toolbar с слева правой градиента.](./media/bidirectional-features-in-wpf-overview/toolbar-left-right-gradient.png)  
  
 После задания <xref:System.Windows.FlowDirection> для <xref:System.Windows.FlowDirection.RightToLeft>, не только <xref:System.Windows.Controls.ToolBar> кнопки будут располагаться справа налево, но даже <xref:System.Windows.Media.LinearGradientBrush> перестраивает свои смещения в направлении справа налево.  
  
 На следующем рисунке показано перестроение элемента <xref:System.Windows.Media.LinearGradientBrush>.  
    
 ![Рисунок, показывающий элемент toolbar с правом градиент слева.](./media/bidirectional-features-in-wpf-overview/toolbar-right-left-gradient.png)  
  
 В следующем примере рисуется <xref:System.Windows.FlowDirection.RightToLeft><xref:System.Windows.Controls.ToolBar>. (Чтобы нарисовать его слева направо, удалите <xref:System.Windows.FlowDirection> атрибут <xref:System.Windows.Controls.ToolBar>.  
  
 [!code-xaml[Gradient#Gradient](~/samples/snippets/csharp/VS_Snippets_Wpf/Gradient/CS/Window1.xaml#gradient)]  
  
<a name="FlowDirectionExceptions"></a>   
### <a name="flowdirection-exceptions"></a>Исключения направления потока  
 Существует несколько вариантов где <xref:System.Windows.FlowDirection> некорректно. В этом разделе рассматриваются два таких исключения.  
  
 **Изображение**  
  
 <xref:System.Windows.Controls.Image> Представляет элемент управления, отображающий изображение. В XAML он может использоваться с <xref:System.Windows.Controls.Image.Source%2A> свойство, определяющее URI из <xref:System.Windows.Controls.Image> для отображения.  
  
 В отличие от других UI элементов, <xref:System.Windows.Controls.Image> не наследует <xref:System.Windows.FlowDirection> из контейнера. Тем не менее если <xref:System.Windows.FlowDirection> явно присвоено <xref:System.Windows.FlowDirection.RightToLeft>, <xref:System.Windows.Controls.Image> отображается перевернутым по горизонтали. Это сделано для удобства разработчиков двунаправленного содержимого. В некоторых случаях горизонтальным отражением достигается требуемый эффект.  
  
 На следующем рисунке показано перевернутое <xref:System.Windows.Controls.Image>.  
    
 ![Рисунок, иллюстрирующий перевернутое изображение.](./media/bidirectional-features-in-wpf-overview/flipped-image-example.png)  
  
 В следующем примере показано, что <xref:System.Windows.Controls.Image> не наследует <xref:System.Windows.FlowDirection> из <xref:System.Windows.Controls.StackPanel> , которая его содержит. **Примечание** необходимо иметь файл с именем **ms_logo.jpg** на C:\ диск для запуска этого примера.  
  
 [!code-xaml[Image#Image](~/samples/snippets/csharp/VS_Snippets_Wpf/Image/CS/Window1.xaml#image)]  
  
 **Примечание** включенные в загружаемые файлы — **ms_logo.jpg** файл. В коде предполагается, что JPG-файл находится не внутри проекта, а где-нибудь на диске C:\. Необходимо скопировать JPG-файл из файлов проекта на диск C:\ или изменить код так, чтобы выполнялся поиск файла внутри проекта. Чтобы сделать это, измените `Source="file://c:/ms_logo.jpg"` для `Source="ms_logo.jpg"`.  
  
 **Пути**  
  
 В дополнение к <xref:System.Windows.Controls.Image>, еще один интересный элемент <xref:System.Windows.Shapes.Path>. Контур — это объект, который может нарисовать последовательность соединенных линий и кривых. Он ведет себя так же, как <xref:System.Windows.Controls.Image> относительно его <xref:System.Windows.FlowDirection>, например его <xref:System.Windows.FlowDirection.RightToLeft><xref:System.Windows.FlowDirection> является горизонтальным отражением элемента его <xref:System.Windows.FlowDirection.LeftToRight> один. Однако в отличие от <xref:System.Windows.Controls.Image>, <xref:System.Windows.Shapes.Path> наследует его <xref:System.Windows.FlowDirection> из контейнера и не требуется указывать явно.  
  
 В следующем примере рисуется простая стрелка, использующая три линии. Первая стрелка наследует <xref:System.Windows.FlowDirection.RightToLeft> направление из потока <xref:System.Windows.Controls.StackPanel> таким образом, чтобы его начальная и конечная точки отсчитываются от корня на правой стороне. Вторая стрелка, который явно <xref:System.Windows.FlowDirection.RightToLeft><xref:System.Windows.FlowDirection> также начинается справа от оператора. Однако третья стрелка начинается от корня с левой стороны. Дополнительные сведения о рисовании см. в разделе <xref:System.Windows.Media.LineGeometry> и <xref:System.Windows.Media.GeometryGroup>.  
  
 [!code-xaml[Paths#Paths](~/samples/snippets/csharp/VS_Snippets_Wpf/Paths/CS/Window1.xaml#paths)]  
  
 На следующем рисунке показан в предыдущем примере выходных данных с помощью стрелки, нарисованные с помощью `Path` элемент:

 ![Рисунок, иллюстрирующий стрелки, нарисованные с помощью элемента Path.](./media/bidirectional-features-in-wpf-overview/arrows-drawn-path-element.png)  
  
 <xref:System.Windows.Controls.Image> И <xref:System.Windows.Shapes.Path> приведены два примера того, как Windows Presentation Foundation (WPF) использует <xref:System.Windows.FlowDirection>. Рядом с макетом UI элементы в определенном направлении в контейнере, <xref:System.Windows.FlowDirection> можно использовать с элементами, такие как <xref:System.Windows.Controls.InkPresenter> отображаемое на поверхности, <xref:System.Windows.Media.LinearGradientBrush>, <xref:System.Windows.Media.RadialGradientBrush>. Каждый раз, когда требуется расположить справа налево содержимое, которое имитирует расположение слева направо, или наоборот, Windows Presentation Foundation (WPF) предоставит вам такую возможность.  
  
<a name="NumberSubstitution"></a>   
## <a name="number-substitution"></a>Подстановки чисел  
 Исторически сложилось так, что Windows поддерживала подстановку чисел, позволяя представления различных культурных фигур для одних цифр во время сохранения внутреннего хранения этих цифр, объединенных в разных языковых стандартах, например, числа хранятся в их известное шестнадцатеричных значений, 0x40, 41, а отображаются в соответствии с выбранного языка.  
  
 Это позволяет приложениям обрабатывать числовые данные без необходимости преобразовать их с одного языка на другой, например, пользователь может открыть [!INCLUDE[TLA#tla_xl](../../../../includes/tlasharptla-xl-md.md)] электронную таблицу в локализованных арабский Windows числа на арабском языке и открыть его в европейскую версию Windows он увидит европейское представление тех же чисел. Это также необходимо для других символов, например запятая или символ процента, так как они обычно сопровождают числа в одном документе.  
  
 Windows Presentation Foundation (WPF) продолжает традицию и добавляет новые для этого средства, позволяющие пользователю более точно контролировать время и способ подстановки используется. Эта функция может использоваться со всеми языками, но особенно полезна она в обработке двунаправленного содержимого, когда представление чисел для разных региональных стандартов становится проблемой для разработчиков приложений, предназначенных для использования в разных странах.  
  
 Основным свойством, управляющим способом подстановки чисел работает Windows Presentation Foundation (WPF) является <xref:System.Windows.Media.NumberSubstitution.Substitution%2A> свойства зависимостей. <xref:System.Windows.Media.NumberSubstitution> Класс указывает, как должны отображаться числа в тексте. Он имеет три открытых свойства, определяющих его поведение. Ниже приведен краткий обзор каждого из свойств.  
  
 **CultureSource:**  
  
 Это свойство задает способ определения регионального стандарта для чисел. Оно принимает одно из трех <xref:System.Windows.Media.NumberCultureSource> значений перечисления.  
  
-   Переопределение: Региональный стандарт для чисел, — это <xref:System.Windows.Media.NumberSubstitution.CultureOverride%2A> свойство.  
  
-   Text: Региональный стандарт для чисел определяется по региональному стандарту текстовой цепочки. В разметке, это было бы `xml:lang`, или его псевдоним `Language` свойство (<xref:System.Windows.FrameworkElement.Language%2A> или <xref:System.Windows.FrameworkContentElement.Language%2A>). Кроме того, он используется по умолчанию для классов, производных от <xref:System.Windows.FrameworkContentElement>. Эти классы включают <xref:System.Windows.Documents.Paragraph?displayProperty=nameWithType>, <xref:System.Windows.Documents.Table?displayProperty=nameWithType>, <xref:System.Windows.Documents.TableCell?displayProperty=nameWithType> и т. д.  
  
-   Пользователь: Региональный стандарт для чисел определяется по региональному стандарту текущего потока. Это свойство имеет значение по умолчанию для всех подклассов <xref:System.Windows.FrameworkElement> например <xref:System.Windows.Controls.Page>, <xref:System.Windows.Window> и <xref:System.Windows.Controls.TextBlock>.  
  
 **CultureOverride**.  
  
 <xref:System.Windows.Media.NumberSubstitution.CultureOverride%2A> Свойство используется только в том случае, если <xref:System.Windows.Media.NumberSubstitution.CultureSource%2A> свойству <xref:System.Windows.Media.NumberCultureSource.Override> и учитывается, в противном случае. Оно определяет региональный стандарт для чисел. Значение `null`, значение по умолчанию, интерпретируется как en US.  
  
 **Substitution**.  
  
 Это свойство определяет выполняемый тип подстановки чисел. Оно принимает одно из следующих <xref:System.Windows.Media.NumberSubstitutionMethod> значений перечисления.  
  
-   <xref:System.Windows.Media.NumberSubstitutionMethod.AsCulture>: Метод подстановки определяется на основании региональных параметров чисел <xref:System.Globalization.NumberFormatInfo.DigitSubstitution%2A?displayProperty=nameWithType> свойство. Это значение по умолчанию.  
  
-   <xref:System.Windows.Media.NumberSubstitutionMethod.Context>: Если региональный стандарт для чисел арабский "или" Персидский языка и региональных параметров, он указывает, что цифры зависят от контекста.  
  
-   <xref:System.Windows.Media.NumberSubstitutionMethod.European>: Числа всегда визуализируются как европейские цифры.  
  
-   <xref:System.Windows.Media.NumberSubstitutionMethod.NativeNational>: Числа отображаются с использованием национальных цифр для региональный стандарт для чисел, как указано в региональных параметрах <xref:System.Globalization.CultureInfo.NumberFormat%2A>.  
  
-   <xref:System.Windows.Media.NumberSubstitutionMethod.Traditional>: Числа отображаются с использованием традиционных цифр для языка и региональных чисел. Для большинства языков и региональных параметров, это так же, как <xref:System.Windows.Media.NumberSubstitutionMethod.NativeNational>. Тем не менее <xref:System.Windows.Media.NumberSubstitutionMethod.NativeNational> результатов цифр на римские для некоторых арабских языков, тогда как это значение в арабских цифрах для всех арабских языков.  
  
 О чем говорят эти значения разработчикам двунаправленного содержимого? В большинстве случаев разработчику достаточно только для определения <xref:System.Windows.FlowDirection> и язык каждого текстового UI элемент, например `Language="ar-SA"` и <xref:System.Windows.Media.NumberSubstitution> логики отвечает за отображение чисел в соответствии с правильным UI. В следующем примере показано использование английских и арабских чисел в Windows Presentation Foundation (WPF) приложения, работающего в арабской версии Windows.  
  
 [!code-xaml[Numbers#Numbers](~/samples/snippets/csharp/VS_Snippets_Wpf/Numbers/CS/Window1.xaml#numbers)]  
  
 Приведенный ниже рисунок показывает результат выполнения предыдущего примера, если у вас в арабской версии Windows с помощью арабских и английских чисел, отображаемых:

 ![Рисунок, показывающий английских и арабских чисел.](./media/bidirectional-features-in-wpf-overview/arabic-english-numbers.png)  
  
 <xref:System.Windows.FlowDirection> Был важные таким образом, поскольку настройка параметра <xref:System.Windows.FlowDirection> для <xref:System.Windows.FlowDirection.LeftToRight> вместо этого будут отображаться европейские цифры. В следующих разделах рассматривается, как сделать одинаковое отображение цифр по всему документу. Если этот пример не выполняется на арабской версии Windows, все цифры отображаются на экране как европейские цифры.  
  
 **Определение правил подстановки**  
  
 В реальном приложении может возникнуть необходимость установить язык программным путем. Например, вы хотите задать `xml:lang` атрибут, который будет таким же, как используется в системе UI, или требуется изменять язык в зависимости от состояния приложения.  
  
 Если вы хотите внести изменения на основании состояния приложения, использование других возможностей, предоставляемых Windows Presentation Foundation (WPF).  
  
 Во-первых, установите компонент приложения `NumberSubstitution.CultureSource="Text"`. С помощью этого параметра гарантирует, что параметры не будут извлекаться из UI для текстовых элементов, содержащих «User» по умолчанию, таких как <xref:System.Windows.Controls.TextBlock>.  
  
Пример:  

```xaml  
<TextBlock
   Name="text1" NumberSubstitution.CultureSource="Text">
   1234+5679=6913
</TextBlock>
```

В соответствующем C# кода; задание `Language` свойство, к примеру, чтобы `"ar-SA"`.  
  
```csharp
text1.Language = System.Windows.Markup.XmlLanguage.GetLanguage("ar-SA");
```

Если необходимо задать `Language` свойства языка пользовательского интерфейса текущего пользователя с помощью следующего кода.  
  
```csharp
text1.Language = System.Windows.Markup.XmlLanguage.GetLanguage(System.Globalization.CultureInfo.CurrentUICulture.IetfLanguageTag);
```

 <xref:System.Globalization.CultureInfo.CurrentCulture%2A?displayProperty=nameWithType> представляет текущий язык и региональные параметры, используемые текущим потоком во время выполнения.  
  
 Окончательный XAML пример должен быть аналогично приведенному ниже.  
  
 [!code-xaml[Numbers2#Numbers2](~/samples/snippets/csharp/VS_Snippets_Wpf/Numbers2/CS/Window1.xaml#numbers2)]  
  
 Окончательный C# пример должен быть следующего вида.  
  
 [!code-csharp[NumbersCSharp#NumbersCSharp](~/samples/snippets/csharp/VS_Snippets_Wpf/NumbersCSharp/CSharp/Window1.xaml.cs#numberscsharp)]  
  
 Приведенный ниже рисунок показывает, как выглядит окно для любого языка программирования, отображение арабских чисел:
     
 ![Рисунок, иллюстрирующий отображение арабских чисел.](./media/bidirectional-features-in-wpf-overview/displays-arabic-numbers.png)  
  
 **Использование свойства подстановки**  
  
 Способ подстановки числа работает Windows Presentation Foundation (WPF) зависит от языка текстового элемента и его <xref:System.Windows.FlowDirection>. Если <xref:System.Windows.FlowDirection> слева направо, а затем будут отображаться европейские цифры. Тем не менее если ему предшествует текст на арабском языке или задан язык «ar» и <xref:System.Windows.FlowDirection> является <xref:System.Windows.FlowDirection.RightToLeft>, вместо этого будут отображаться арабские цифры.  
  
 В некоторых случаях может потребоваться создание универсального приложения, например с европейскими цифрами для всех пользователей. Или арабские цифры в <xref:System.Windows.Documents.Table> ячейки с определенным <xref:System.Windows.Style>. Один простой способ выполнения задачи, использующего <xref:System.Windows.Media.NumberSubstitution.Substitution%2A> свойство.  
  
 В следующем примере первый <xref:System.Windows.Controls.TextBlock> имеет <xref:System.Windows.Media.NumberSubstitution.Substitution%2A> свойство задано, поэтому отображаются арабские цифры должным образом. Однако во втором <xref:System.Windows.Controls.TextBlock>задана подстановка в европейском стандарте переопределяет замену по умолчанию для арабских чисел и отображаются европейские цифры.  
  
 [!code-xaml[Numbers3#Numbers3](~/samples/snippets/csharp/VS_Snippets_Wpf/Numbers3/CS/Window1.xaml#numbers3)]
