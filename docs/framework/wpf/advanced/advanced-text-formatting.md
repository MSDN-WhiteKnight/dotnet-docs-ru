---
title: Дополнительное форматирование текста
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- formatting [WPF]
- text [WPF]
- typography [WPF], text formatting
ms.assetid: f0a7986e-f5b2-485c-a27d-f8e922022212
ms.openlocfilehash: fa707ed9c409a2e6933629a658bfe650b43f3233
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59085731"
---
# <a name="advanced-text-formatting"></a>Дополнительное форматирование текста
Windows Presentation Foundation (WPF) предоставляет набор надежных [!INCLUDE[TLA#tla_api#plural](../../../../includes/tlasharptla-apisharpplural-md.md)] для включения текста в приложении. Макет и [!INCLUDE[TLA#tla_ui](../../../../includes/tlasharptla-ui-md.md)][!INCLUDE[TLA2#tla_api#plural](../../../../includes/tla2sharptla-apisharpplural-md.md)], такие как <xref:System.Windows.Controls.TextBlock>, обеспечивают наиболее распространенные и общие использовать элементы для представления текста. Рисование [!INCLUDE[TLA2#tla_api#plural](../../../../includes/tla2sharptla-apisharpplural-md.md)], такие как <xref:System.Windows.Media.GlyphRunDrawing> и <xref:System.Windows.Media.FormattedText>, предоставляют средства для включения форматированного текста в рисунки. На наиболее продвинутом уровне [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)] предоставляет расширяемый механизм форматирования текста для управления каждым аспектом представления текста: управление хранением текста, исполнением форматирования текста и внедренными объектами.  
  
 В этом разделе содержатся вводные [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)] форматирование текста. Этот раздел посвящен реализации клиента и использовании [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)] механизм форматирования текста.  
  
> [!NOTE]
>  Все примеры кода в этом документе можно найти в [пример расширенного форматирования текста](https://go.microsoft.com/fwlink/?LinkID=159965).  

<a name="prereq"></a>   
## <a name="prerequisites"></a>Предварительные требования  
 В этом разделе предполагается, что вы знакомы с высоким уровнем [!INCLUDE[TLA2#tla_api#plural](../../../../includes/tla2sharptla-apisharpplural-md.md)] используемыми для представления текста. Большинство сценариев не требует расширенного форматирования текста [!INCLUDE[TLA2#tla_api#plural](../../../../includes/tla2sharptla-apisharpplural-md.md)] описанных в этом разделе. Введение в другой текстовой [!INCLUDE[TLA2#tla_api#plural](../../../../includes/tla2sharptla-apisharpplural-md.md)], см. в разделе [документы в WPF](documents-in-wpf.md).  
  
<a name="section1"></a>   
## <a name="advanced-text-formatting"></a>Дополнительное форматирование текста  
 Макет текста и [!INCLUDE[TLA2#tla_ui](../../../../includes/tla2sharptla-ui-md.md)] элементов управления в [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)] предоставляют свойства форматирования, которые дают возможность легко включать в приложение форматированный текст. Эти элементы управления предоставляют ряд свойств для обработки представления текста, включая гарнитуру, размер и цвет. В обычных условиях эти элементы управления могут обрабатывать большинство вариантов представления текста в приложении. Тем не менее некоторые расширенные сценарии требуют управления хранением текста, а также его представлением. [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)] предоставляет расширяемый механизм форматирования текста для этой цели.  
  
 Найти дополнительные функции форматирования текста в [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)] состоят из механизма форматирования, хранилища текста фрагментов текста и свойств форматирования текста. Механизм форматирования текста, <xref:System.Windows.Media.TextFormatting.TextFormatter>, создает строки текста, используемые для представления. Это достигается путем запуска процесса форматирования строки и вызова модуля форматирования текста <xref:System.Windows.Media.TextFormatting.TextFormatter.FormatLine%2A>. Модуль форматирования текста получает фрагментов текста из хранилища текста, вызывая магазина <xref:System.Windows.Media.TextFormatting.TextSource.GetTextRun%2A> метод. <xref:System.Windows.Media.TextFormatting.TextRun> Объекты затем формируются в <xref:System.Windows.Media.TextFormatting.TextLine> объектов модулем форматирования текста и передаются в приложение для проверки или отображения.  
  
<a name="section2"></a>   
## <a name="using-the-text-formatter"></a>Использование модуля форматирования текста  
 <xref:System.Windows.Media.TextFormatting.TextFormatter> является [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)] механизма форматирования текста и предоставляет службы для форматирования и переноса строк текста. Модуль форматирования текста может обрабатывать различные форматы текстовых символов и стили абзацев и включает поддержку международного макета текста.  
  
 В отличие от традиционного текстового [!INCLUDE[TLA#tla_api](../../../../includes/tlasharptla-api-md.md)], <xref:System.Windows.Media.TextFormatting.TextFormatter> взаимодействует с клиентом макета текста через набор методов обратного вызова. Требуется клиент для предоставления этих методов в реализации <xref:System.Windows.Media.TextFormatting.TextSource> класса. Следующая диаграмма иллюстрирует взаимодействие макета текста между клиентским приложением и <xref:System.Windows.Media.TextFormatting.TextFormatter>.  
  
 ![Схема клиента структуры текста и TextFormatter](./media/advanced-text-formatting/text-layout-textformatter-interaction.png)  
  
 Модуль форматирования текста используется для извлечения форматированных строк текста из хранилища текста, который представляет собой реализацию <xref:System.Windows.Media.TextFormatting.TextSource>. Для этого сначала создается экземпляр модуля форматирования текста с помощью <xref:System.Windows.Media.TextFormatting.TextFormatter.Create%2A> метод. Этот метод создает экземпляр модуля форматирования текста и задает максимальные значения высоты и ширины строки. Как только создается экземпляр модуля форматирования текста, процесс создания строки, начатую посредством вызова <xref:System.Windows.Media.TextFormatting.TextFormatter.FormatLine%2A> метод. <xref:System.Windows.Media.TextFormatting.TextFormatter> обратный вызов к источнику текста для получения текста и параметров форматирования для фрагментов текста эту форму строки.  
  
 В следующем примере показан процесс форматирования хранилища текста. <xref:System.Windows.Media.TextFormatting.TextFormatter> Объект используется для извлечения строк текста из хранилища текста и последующего форматирования строк текста для рисования в <xref:System.Windows.Media.DrawingContext>.  
  
 [!code-csharp[TextFormatterExample#100](~/samples/snippets/csharp/VS_Snippets_Wpf/TextFormatterExample/CSharp/Window1.xaml.cs#100)]
   
  
<a name="section3"></a>   
## <a name="implementing-the-client-text-store"></a>Реализация клиентского хранилища текста  
 При расширении механизма форматирования текста необходимо реализовать все аспекты хранилища текста и управлять ими. Это довольно сложная задача. Хранилище текста отвечает за отслеживание свойств фрагментов текста, свойств абзаца, встроенных объектов и других подобных элементов. Он также предоставляет модуль форматирования текста с отдельными <xref:System.Windows.Media.TextFormatting.TextRun> объектов, которые использует модуль форматирования текста для создания <xref:System.Windows.Media.TextFormatting.TextLine> объектов.  
  
 Для обработки виртуализации хранилища текста, хранилища текста должен быть производным от <xref:System.Windows.Media.TextFormatting.TextSource>. <xref:System.Windows.Media.TextFormatting.TextSource> Определяет метод, используемый модулем форматирования текста для извлечения фрагментов текста из хранилища текста. <xref:System.Windows.Media.TextFormatting.TextSource.GetTextRun%2A> — Это метод, используемый модулем форматирования текста для извлечения текста цепочек, используемых в форматировании строки. Вызов <xref:System.Windows.Media.TextFormatting.TextSource.GetTextRun%2A> неоднократно осуществляется модулем форматирования текста, пока не произойдет одно из следующих условий:  
  
-   Объект <xref:System.Windows.Media.TextFormatting.TextEndOfLine> или подкласс возвращается.  
  
-   Суммарная ширина фрагментов текста превышает ширину строк, указанную в вызове для создания модуля форматирования текста или вызов модуля форматирования текста <xref:System.Windows.Media.TextFormatting.TextFormatter.FormatLine%2A> метод.  
  
-   Объект [!INCLUDE[TLA#tla_unicode](../../../../includes/tlasharptla-unicode-md.md)] возвращается последовательность новой строки, например «CF», «LF» или «CRLF,».  
  
<a name="section4"></a>   
## <a name="providing-text-runs"></a>Предоставление фрагментов текста  
 Ядром процесса форматирования текста является взаимодействие между модулем форматирования текста и хранилищем текста. Реализация <xref:System.Windows.Media.TextFormatting.TextSource> предоставляет модуль форматирования текста с <xref:System.Windows.Media.TextFormatting.TextRun> объектов и свойств, с помощью которых форматируются исполнения текста. Это взаимодействие обрабатывается <xref:System.Windows.Media.TextFormatting.TextSource.GetTextRun%2A> метод, который вызывается модулем форматирования текста.  
  
 В следующей таблице показаны некоторые из предварительно определенных <xref:System.Windows.Media.TextFormatting.TextRun> объектов.  
  
|Тип TextRun|Использование|  
|------------------|-----------|  
|<xref:System.Windows.Media.TextFormatting.TextCharacters>|Специализированный фрагмент текста, который используется для передачи представления глифов символов обратно в модуль форматирования текста.|  
|<xref:System.Windows.Media.TextFormatting.TextEmbeddedObject>|Специализированный фрагмент текста, который используется для предоставления содержимого, в котором измерение, проверка нажатия и рисование выполняются в целом (например, кнопка или изображение в тексте).|  
|<xref:System.Windows.Media.TextFormatting.TextEndOfLine>|Специализированный фрагмент текста, который используется для обозначения конца строки.|  
|<xref:System.Windows.Media.TextFormatting.TextEndOfParagraph>|Специализированный фрагмент текста, который используется для обозначения конца абзаца.|  
|<xref:System.Windows.Media.TextFormatting.TextEndOfSegment>|Специализированный фрагмент текста, используемый для обозначения конца сегмента, например конца области, затронутых предыдущим <xref:System.Windows.Media.TextFormatting.TextModifier> запуска.|  
|<xref:System.Windows.Media.TextFormatting.TextHidden>|Специализированный фрагмент текста, который используется для отметки диапазона скрытых символов.|  
|<xref:System.Windows.Media.TextFormatting.TextModifier>|Специализированный фрагмент текста, который используется для изменения свойств фрагментов текста в своей области. Область расширяется до следующего соответствия <xref:System.Windows.Media.TextFormatting.TextEndOfSegment> текстовой цепочки или следующего <xref:System.Windows.Media.TextFormatting.TextEndOfParagraph>.|  
  
 Любые из стандартных <xref:System.Windows.Media.TextFormatting.TextRun> объектов может быть подклассом. Это позволяет источнику текста предоставлять модуль форматирования текста с фрагментами текста, включающими пользовательские данные.  
  
 В следующем примере демонстрируется <xref:System.Windows.Media.TextFormatting.TextSource.GetTextRun%2A> метод. Это хранилище текста возвращает <xref:System.Windows.Media.TextFormatting.TextRun> объектов для форматирования текста для обработки.  
  
 [!code-csharp[TextFormatterExample#101](~/samples/snippets/csharp/VS_Snippets_Wpf/TextFormatterExample/CSharp/CustomTextSource.cs#101)]
   
  
> [!NOTE]
>  В этом примере хранилище текста предоставляет одни и те же свойства текста всему тексту. Расширенные хранилища текста могут потребоваться для реализации собственного управления диапазонами, чтобы позволить отдельным символам иметь разные свойства.  
  
<a name="section5"></a>   
## <a name="specifying-formatting-properties"></a>Задание свойств форматирования  
 <xref:System.Windows.Media.TextFormatting.TextRun> объекты форматируются с помощью свойств, предоставляемых хранилищем текста. Эти свойства бывают двух типов <xref:System.Windows.Media.TextFormatting.TextParagraphProperties> и <xref:System.Windows.Media.TextFormatting.TextRunProperties>. <xref:System.Windows.Media.TextFormatting.TextParagraphProperties> обрабатывать все свойства абзаца, например <xref:System.Windows.TextAlignment> и <xref:System.Windows.FlowDirection>. <xref:System.Windows.Media.TextFormatting.TextRunProperties> — Это свойства, которые могут быть разными для каждого текста в абзаце, например кисть переднего плана, <xref:System.Windows.Media.Typeface>и размер шрифта. Для реализации пользовательских абзацев и текст, типов свойств, приложение должно создавать классы, производные от <xref:System.Windows.Media.TextFormatting.TextParagraphProperties> и <xref:System.Windows.Media.TextFormatting.TextRunProperties> соответственно.  
  
## <a name="see-also"></a>См. также

- [Оформление в WPF](typography-in-wpf.md)
- [Документы в WPF](documents-in-wpf.md)
