---
title: 'Оптимизация производительности: Текста'
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- rendering text [WPF]
- hyperlinks [WPF]
- formatted text [WPF]
- text [WPF], performance
- glyphs [WPF]
ms.assetid: 66b1b9a7-8618-48db-b616-c57ea4327b98
ms.openlocfilehash: 0cc1ac9adf40948a5109b37336d45a2be833e54f
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59317211"
---
# <a name="optimizing-performance-text"></a>Оптимизация производительности: Текста
WPF включает поддержку представления текстового контента с помощью многофункциональных UI  элементов управления. В целом можно разделить отрисовку текста на три уровня.  
  
1. С помощью <xref:System.Windows.Documents.Glyphs> и <xref:System.Windows.Media.GlyphRun> объекты непосредственно.  
  
2. С помощью <xref:System.Windows.Media.FormattedText> объекта.  
  
3. Использование высокоуровневых элементов управления, таких как <xref:System.Windows.Controls.TextBlock> и <xref:System.Windows.Documents.FlowDocument> объектов.  
  
 В этом разделе даются рекомендации по повышению производительности отрисовки текста.  

<a name="Glyph_Level"></a>   
## <a name="rendering-text-at-the-glyph-level"></a>Отрисовка текста на уровне глифа  
 Windows Presentation Foundation (WPF) обеспечивает расширенную поддержку текста включая разметку на уровне глифа с прямым доступом к <xref:System.Windows.Documents.Glyphs> для клиентов, которым требуется перехватывать и сохранять текст после форматирования. Эти функции обеспечивают критически важную поддержку различных требований к отрисовке текста в каждом из следующих сценариев.  
  
-   Отображение на экране документов фиксированного формата.  
  
-   Сценарии печати.  
  
    -   XAML как язык принтера.  
  
    -   [!INCLUDE[TLA#tla_mxdw](../../../../includes/tlasharptla-mxdw-md.md)].  
  
    -   Предыдущие драйверы принтера, вывод из приложений [!INCLUDE[TLA#tla_win32](../../../../includes/tlasharptla-win32-md.md)] в фиксированный формат.  
  
    -   Формат очереди печати.  
  
-   Представление документов фиксированного формата, включая клиенты предыдущих версий Windows и другие вычислительные устройства.  
  
> [!NOTE]
>  <xref:System.Windows.Documents.Glyphs> и <xref:System.Windows.Media.GlyphRun> предназначены для представления документов фиксированного формата и сценариев печати. Windows Presentation Foundation (WPF) предоставляет несколько элементов для общего макета и UI  сценариях, например <xref:System.Windows.Controls.Label> и <xref:System.Windows.Controls.TextBlock>. Дополнительные сведения о макете и сценариях UI см. в статье [Оформление в WPF](typography-in-wpf.md).  
  
 Следующие примеры показывают, как следует указывать свойства для <xref:System.Windows.Documents.Glyphs> объекта в XAML. <xref:System.Windows.Documents.Glyphs> Представляет выходные данные <xref:System.Windows.Media.GlyphRun> в XAML. В примерах предполагается, что шрифты Arial, Courier New и Times New Roman устанавливаются в папку **C:\WINDOWS\Fonts** на локальном компьютере.  
  
 [!code-xaml[GlyphsOvwSample1#1](~/samples/snippets/csharp/VS_Snippets_Wpf/GlyphsOvwSample1/CS/default.xaml#1)]  
  
### <a name="using-drawglyphrun"></a>Использование DrawGlyphRun  
 Если у вас есть пользовательский элемент управления, и вы хотите отобразить глифы, используйте <xref:System.Windows.Media.DrawingContext.DrawGlyphRun%2A> метод.  
  
 WPF также предоставляет службы более низкого уровня для пользовательского форматирования с помощью объекта текста <xref:System.Windows.Media.FormattedText> объекта. Наиболее эффективным способом отрисовки текста в Windows Presentation Foundation (WPF) является создание текстового контента на уровне глифа с помощью <xref:System.Windows.Documents.Glyphs> и <xref:System.Windows.Media.GlyphRun>. Однако ценой этой эффективности будет потеря прост в использовании форматирования RTF, которые являются встроенными функциями из Windows Presentation Foundation (WPF) элементы управления, такие как <xref:System.Windows.Controls.TextBlock> и <xref:System.Windows.Documents.FlowDocument>.  
  
<a name="FormattedText_Object"></a>   
## <a name="formattedtext-object"></a>Объект FormattedText  
 <xref:System.Windows.Media.FormattedText> Объект позволяет рисовать многострочный текст, в котором каждый символ в текст можно форматировать по отдельности. Дополнительные сведения см. в разделе [Рисование форматированного текста](drawing-formatted-text.md).  
  
 Чтобы создать форматированный текст, вызовите <xref:System.Windows.Media.FormattedText.%23ctor%2A> конструктор для создания <xref:System.Windows.Media.FormattedText> объекта. После создания исходной строки форматированного текста можно применить ряд стилей форматирования. Если в приложении требуется реализовать собственный макет, а затем <xref:System.Windows.Media.FormattedText> объект является более предпочтительной, чем использование элемента управления, такие как <xref:System.Windows.Controls.TextBlock>. Дополнительные сведения о <xref:System.Windows.Media.FormattedText> объекта, см. в разделе [Рисование форматированного текста](drawing-formatted-text.md) .  
  
 <xref:System.Windows.Media.FormattedText> Предоставляет возможность низкоуровневого форматирования текста. К одному или более символам можно применить несколько стилей форматирования. Например, можно вызвать оба <xref:System.Windows.Media.FormattedText.SetFontSize%2A> и <xref:System.Windows.Media.FormattedText.SetForegroundBrush%2A> методы для изменения форматирования первые пять символов в тексте.  
  
 В следующем примере кода создается <xref:System.Windows.Media.FormattedText> объекта и готовит его к просмотру.  
  
 [!code-csharp[formattedtextsnippets#FormattedTextSnippets1](~/samples/snippets/csharp/VS_Snippets_Wpf/FormattedTextSnippets/CSharp/Window1.xaml.cs#formattedtextsnippets1)]
   
  
<a name="FlowDocument_TextBlock_Label"></a>   
## <a name="flowdocument-textblock-and-label-controls"></a>Элементы управления FlowDocument, TextBlock и Label  
 WPF содержит несколько элементов управления для рисования текста на экране. Каждый элемент управления предназначен для своего сценария и имеет собственный список функций и ограничений.  
  
### <a name="flowdocument-impacts-performance-more-than-textblock-or-label"></a>FlowDocument влияет на производительность больше, чем TextBlock и Label  
 В общем случае <xref:System.Windows.Controls.TextBlock> элемент должен использоваться при необходимости, например короткого предложения в ограниченная поддержка текста UI . <xref:System.Windows.Controls.Label> может использоваться, если требуется Минимальная текстовая поддержка. <xref:System.Windows.Documents.FlowDocument> Элемент — это контейнер для документов плавающей верстки, поддерживающих представление форматированного контента и таким образом, имеет большее влияние на производительность, чем при использовании <xref:System.Windows.Controls.TextBlock> или <xref:System.Windows.Controls.Label> элементов управления.  
  
 Дополнительные сведения о <xref:System.Windows.Documents.FlowDocument>, см. в разделе [Общие сведения о документе нефиксированного](flow-document-overview.md).  
  
### <a name="avoid-using-textblock-in-flowdocument"></a>Избегайте использования TextBlock в FlowDocument  
 <xref:System.Windows.Controls.TextBlock> Элемент является производным от <xref:System.Windows.UIElement>. <xref:System.Windows.Documents.Run> Элемент является производным от <xref:System.Windows.Documents.TextElement>, который является менее затратным в использовании, чем <xref:System.Windows.UIElement>-объект, производный от. По возможности используйте <xref:System.Windows.Documents.Run> вместо <xref:System.Windows.Controls.TextBlock> для отображения текстового содержимого в <xref:System.Windows.Documents.FlowDocument>.  
  
 В следующем примере разметки показано два способа настройки текстового контента в <xref:System.Windows.Documents.FlowDocument>:  
  
 [!code-xaml[Performance#PerformanceSnippet13](~/samples/snippets/csharp/VS_Snippets_Wpf/Performance/CSharp/FlowDocument.xaml#performancesnippet13)]  
  
### <a name="avoid-using-run-to-set-text-properties"></a>Избегайте использования Run для задания свойств текста  
 В целом, использование <xref:System.Windows.Documents.Run> в <xref:System.Windows.Controls.TextBlock> является более производительным, чем неиспользование явного <xref:System.Windows.Documents.Run> объекта вообще. Если вы используете <xref:System.Windows.Documents.Run> устанавливаете свойства текста, задайте эти свойства непосредственно на <xref:System.Windows.Controls.TextBlock> вместо этого.  
  
 В следующем примере разметки показано два способа задания свойства текста, в этом случае <xref:System.Windows.Controls.TextBlock.FontWeight%2A> свойство:  
  
 [!code-xaml[Performance#PerformanceSnippet12](~/samples/snippets/csharp/VS_Snippets_Wpf/Performance/CSharp/Window1.xaml#performancesnippet12)]  
  
 В следующей таблице показаны стоимость отображения 1000 <xref:System.Windows.Controls.TextBlock> объекты с и без явного <xref:System.Windows.Documents.Run>.  
  
|**Тип TextBlock**|**Время создания (мс)**|**Время отрисовки (мс)**|  
|------------------------|------------------------------|----------------------------|  
|Установка свойств текста с помощью Run|146|540|  
|Установка свойств текста с помощью TextBlock|43|453|  
  
### <a name="avoid-databinding-to-the-labelcontent-property"></a>Избегайте привязки данных к свойству Label.Content  
 Представьте себе ситуацию, где у вас есть <xref:System.Windows.Controls.Label> объект, который постоянно обновляется из <xref:System.String> источника. При привязке данных <xref:System.Windows.Controls.Label> элемента <xref:System.Windows.Controls.ContentControl.Content%2A> свойства <xref:System.String> исходный объект, может наблюдаться низкая производительность. Каждый раз, когда источник <xref:System.String> обновляется, старый <xref:System.String> объект удаляется, а новый <xref:System.String> создается заново, поскольку <xref:System.String> является неизменяемым, его невозможно изменить. Это, в свою очередь, вызовет переход <xref:System.Windows.Controls.ContentPresenter> из <xref:System.Windows.Controls.Label> объект, который удаляет свое устаревшее содержимое и создает новое содержимое для отображения новых <xref:System.String>.  
  
 Решение этой проблемы довольно простое. Если <xref:System.Windows.Controls.Label> не установлено пользовательское <xref:System.Windows.Controls.ContentControl.ContentTemplate%2A> значение, замените <xref:System.Windows.Controls.Label> с <xref:System.Windows.Controls.TextBlock> и выполнить привязку данных его <xref:System.Windows.Controls.TextBlock.Text%2A> значение исходной строки.  
  
|**Свойство с привязкой данных**|**Время обновления (мс)**|  
|-----------------------------|----------------------------|  
|Label.Content|835|  
|TextBlock.Text|242|  
  
<a name="Hyperlink"></a>   
## <a name="hyperlink"></a>Гиперссылка  
 <xref:System.Windows.Documents.Hyperlink> Объект — это элемент содержимого потока встроенного уровня, позволяющим размещать гиперссылки в содержимом потока.  
  
### <a name="combine-hyperlinks-in-one-textblock-object"></a>Объединение гиперссылок в одном объекте TextBlock  
 Вы можете оптимизировать использование нескольких <xref:System.Windows.Documents.Hyperlink> элементов, объединив их в одном <xref:System.Windows.Controls.TextBlock>. Это позволяет минимизировать число объектов, создаваемых в приложении. Например, может потребоваться отобразить несколько гиперссылок, как показано ниже.  
  
 Домашняя страница MSN | Мой MSN  
  
 В следующем примере разметки показано несколько <xref:System.Windows.Controls.TextBlock> элементы, используемые для отображения гиперссылок:  
  
 [!code-xaml[Performance#PerformanceSnippet9](~/samples/snippets/csharp/VS_Snippets_Wpf/Performance/CSharp/Hyperlink.xaml#performancesnippet9)]  
  
 В следующем примере разметки показан более эффективный способ отображения гиперссылок, на этот раз с помощью одного <xref:System.Windows.Controls.TextBlock>:  
  
 [!code-xaml[Performance#PerformanceSnippet10](~/samples/snippets/csharp/VS_Snippets_Wpf/Performance/CSharp/Hyperlink.xaml#performancesnippet10)]  
  
### <a name="showing-underlines-on-hyperlinks-only-on-mouseenter-events"></a>Отображение подчеркивания гиперссылок только при возникновении события MouseEnter  
 Объект <xref:System.Windows.TextDecoration> объект — это визуальное украшение, можно добавить к тексту, однако он может быть производительность при создании. При внесении широкое использование <xref:System.Windows.Documents.Hyperlink> элементов, рассмотрите возможность отображать подчеркивание только при возникновении события, такие как <xref:System.Windows.ContentElement.MouseEnter> событий. Дополнительные сведения см. в разделе [Определение того, подчеркнута ли ссылка](how-to-specify-whether-a-hyperlink-is-underlined.md).  
  
  На следующем рисунке показано, как запускается событием MouseEnter подчеркнутой гиперссылки:

  ![Гиперссылки, отображающие TextDecorations](./media/how-to-specify-whether-a-hyperlink-is-underlined/text-decorations-hyperlinks.png)   
  
 В следующем примере разметки демонстрируется <xref:System.Windows.Documents.Hyperlink> определен с подчеркиванием и без него:  
  
 [!code-xaml[Performance#PerformanceSnippet11](~/samples/snippets/csharp/VS_Snippets_Wpf/Performance/CSharp/Hyperlink.xaml#performancesnippet11)]  
  
 В следующей таблице показаны затраты производительности на отображение 1000 <xref:System.Windows.Documents.Hyperlink> элементы с подчеркиванием и без него.  
  
|**Гиперссылка**|**Время создания (мс)**|**Время отрисовки (мс)**|  
|-------------------|------------------------------|----------------------------|  
|С подчеркиванием|289|1130|  
|Без подчеркивания|299|776|  
  
<a name="Text_Formatting_Features"></a>   
## <a name="text-formatting-features"></a>Возможности форматирования текста  
 WPF предоставляет службы, такие как автоматическая расстановка переносов форматирования RTF. Эти службы могут влиять на производительность приложения и должны использоваться только при необходимости.  
  
### <a name="avoid-unnecessary-use-of-hyphenation"></a>Избегайте излишнего использования расстановки переносов  
 Автоматическая расстановка переносов находит точки останова дефиса для строк текста и разрешает дополнительные позиции разрыва для строк в <xref:System.Windows.Controls.TextBlock> и <xref:System.Windows.Documents.FlowDocument> объектов. По умолчанию возможность автоматического переноса в этих объектах отключена. Эту функцию можно включить, установив свойство IsHyphenationEnabled объекта в значение `true`. Однако включение этой функции заставляет WPF инициировать взаимодействие [!INCLUDE[TLA#tla_com](../../../../includes/tlasharptla-com-md.md)], которое может повлиять на производительность приложения. Рекомендуется не использовать автоматическую расстановку переносов, если это не является обязательным.  
  
### <a name="use-figures-carefully"></a>Внимательно используйте рисунки  
 Объект <xref:System.Windows.Documents.Figure> элемент представляет часть неформатированного содержимого, которое может быть абсолютно позиционировано внутри страницы содержимого. В некоторых случаях <xref:System.Windows.Documents.Figure> может привести к целой страницы автоматическое переформатирование, если ее положение конфликтует с уже размещенным содержимым. Можно свести к минимуму вероятность ненужного переформатирования либо путем группировки <xref:System.Windows.Documents.Figure> элементов друг с другом, либо объявить их в верхней части содержимого в сценарии фиксированного размера страницы.  
  
### <a name="optimal-paragraph"></a>Оптимальный абзац  
 Средство оптимального абзаца из <xref:System.Windows.Documents.FlowDocument> размещает абзацы, чтобы пустое пространство распределялось максимально равномерно. По умолчанию средство оптимального абзаца отключено. Вы можете включить эту функцию, задав объекта <xref:System.Windows.Documents.FlowDocument.IsOptimalParagraphEnabled%2A> свойства `true`. Однако включение этой функции влияет на производительность приложения. Рекомендуется не использовать средство оптимального абзаца без необходимости.  
  
## <a name="see-also"></a>См. также

- [Улучшение производительности приложений WPF](optimizing-wpf-application-performance.md)
- [Планирование производительности приложения](planning-for-application-performance.md)
- [Использование преимуществ оборудования](optimizing-performance-taking-advantage-of-hardware.md)
- [Разметка и разработка](optimizing-performance-layout-and-design.md)
- [Двумерная графика и изображения](optimizing-performance-2d-graphics-and-imaging.md)
- [Поведение объекта](optimizing-performance-object-behavior.md)
- [Ресурсы приложений](optimizing-performance-application-resources.md)
- [Привязка данных](optimizing-performance-data-binding.md)
- [Дополнительные рекомендации по повышению производительности](optimizing-performance-other-recommendations.md)
