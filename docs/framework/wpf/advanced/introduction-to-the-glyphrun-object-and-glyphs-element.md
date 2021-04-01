---
title: Знакомство с объектом GlyphRun и элементом Glyphs
ms.date: 03/30/2017
helpviewer_keywords:
- typography [WPF], Glyphs element
- Glyphs elements [WPF]
- GlyphRun object [WPF]
- text [WPF], glyphs
- glyphs [WPF]
- typography [WPF], GlyphRun object
ms.assetid: 746ca769-a331-4435-9b95-f72a883b67c1
ms.openlocfilehash: 0e5ec2b89f015c7e061b59fea755eb368f1ac7a1
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59341053"
---
# <a name="introduction-to-the-glyphrun-object-and-glyphs-element"></a>Знакомство с объектом GlyphRun и элементом Glyphs
В этом разделе описывается <xref:System.Windows.Media.GlyphRun> объекта и <xref:System.Windows.Documents.Glyphs> элемент.  

<a name="text_glyphrunovw_intro"></a>   
## <a name="introduction-to-glyphrun"></a>Общие сведения о GlyphRun  
 Windows Presentation Foundation (WPF) обеспечивает расширенную поддержку текста включая разметку на уровне глифа с прямым доступом к <xref:System.Windows.Documents.Glyphs> для клиентов, которым требуется перехватывать и сохранять текст после форматирования. Эти функции обеспечивают критически важную поддержку различных требований к отрисовке текста в каждом из следующих сценариев.  
  
1. Отображение на экране документов фиксированного формата.  
  
2. Сценарии печати.  
  
    -   XAML как язык принтера.  
  
    -   [!INCLUDE[TLA#tla_mxdw](../../../../includes/tlasharptla-mxdw-md.md)].  
  
    -   Предыдущие драйверы принтера, вывод из приложений [!INCLUDE[TLA#tla_win32](../../../../includes/tlasharptla-win32-md.md)] в фиксированный формат.  
  
    -   Формат очереди печати.  
  
3. Представление документов фиксированного формата, включая клиенты предыдущих версий Windows и другие вычислительные устройства.  
  
> [!NOTE]
>  <xref:System.Windows.Documents.Glyphs> и <xref:System.Windows.Media.GlyphRun> предназначены для представления документов фиксированного формата и сценариев печати. Windows Presentation Foundation (WPF) предоставляет несколько элементов для общего макета и UI  сценариях, например <xref:System.Windows.Controls.Label> и <xref:System.Windows.Controls.TextBlock>. Дополнительные сведения о макете и сценариях UI см. в статье [Оформление в WPF](typography-in-wpf.md).  
  
<a name="text_glyphrunovw_glyphrunobject"></a>   
## <a name="the-glyphrun-object"></a>Объект GlyphRun  
 <xref:System.Windows.Media.GlyphRun> Объект представляет последовательность глифов из одной грани одного шрифта одного размера и с одним стилем отрисовки.  
  
 <xref:System.Windows.Media.GlyphRun> включает детали шрифта, такие как глиф <xref:System.Windows.Documents.Glyphs.Indices%2A> и отдельные позиции глифов. Он также включает в себя исходный [!INCLUDE[TLA#tla_unicode](../../../../includes/tlasharptla-unicode-md.md)] кодовые точки, был произведен запуск из сведения о сопоставлении смещения буфера символ — глиф и флаги каждого символа и глифа.  
  
 <xref:System.Windows.Media.GlyphRun> имеет соответствующий высокоуровневый <xref:System.Windows.FrameworkElement>, <xref:System.Windows.Documents.Glyphs>. <xref:System.Windows.Documents.Glyphs> может использоваться в дереве элементов и в XAML разметку, представляющую <xref:System.Windows.Media.GlyphRun> выходных данных.  
  
<a name="text_glyphrunovw_glyphselement"></a>   
## <a name="the-glyphs-element"></a>Элемент Glyphs  
 <xref:System.Windows.Documents.Glyphs> Элемент представляет выходные данные <xref:System.Windows.Media.GlyphRun> в XAML. Следующий синтаксис разметки используется для описания <xref:System.Windows.Documents.Glyphs> элемент.  
  
 [!code-xaml[GlyphsOvwSample1#1](~/samples/snippets/csharp/VS_Snippets_Wpf/GlyphsOvwSample1/CS/default.xaml#1)]  
  
 Следующие определения свойств соответствуют первым четырем атрибутам в примере разметки.  
  
|Свойство|Описание|  
|--------------|-----------------|  
|<xref:System.Windows.Documents.Glyphs.FontUri%2A>|Указывает идентификатор ресурса: имя файла, URI, или ссылку на ресурс в файле .exe или приложения контейнера.|  
|<xref:System.Windows.Documents.Glyphs.FontRenderingEmSize%2A>|Указывает размер шрифта в единицах графической поверхности (по умолчанию — 0,96 дюйма).|  
|<xref:System.Windows.Documents.Glyphs.StyleSimulations%2A>|Задает флаги для полужирного шрифта и курсива.|  
|<xref:System.Windows.Documents.Glyphs.BidiLevel%2A>|Задает уровень двунаправленного макета. Четные и нулевые значения подразумевают макет слева направо; нечетные значения подразумевают макет справа налево.|  
  
<a name="text_glyphrunovw_indicesproperty"></a>   
### <a name="indices-property"></a>Свойство Indices  
 <xref:System.Windows.Documents.Glyphs.Indices%2A> Свойство является строкой спецификаций глифа. Если последовательность глифов образует единый кластер, спецификации первого глифа в кластере предшествует спецификация того, сколько глифов и сколько кодовых точек объединяются для формирования кластера. <xref:System.Windows.Documents.Glyphs.Indices%2A> Свойство собирает в одной строке следующие свойства.  
  
-   Индексы глифов  
  
-   Дополнительная ширина глифа  
  
-   Объединение векторов присоединения глифа  
  
-   Сопоставление кластера от кодовых точек к глифам  
  
-   Флаги глифов  
  
 Спецификация глифа имеет следующий вид.  
  
 `[GlyphIndex][,[Advance][,[uOffset][,[vOffset][,[Flags]]]]]`  
  
<a name="text_glyphrunovw_glyphmetrics"></a>   
## <a name="glyph-metrics"></a>Метрики глифа  
 Каждый глиф определяет метрику, задающую способ выравнивания с другими <xref:System.Windows.Documents.Glyphs>. На следующем рисунке определяются различные типографические качества двух разных символов глифа.  
  
 ![Схема измерений глифа](./media/glyph-example.png "glyph_example")  
  
<a name="text_glyphrunovw_glyphsmarkup"></a>   
## <a name="glyphs-markup"></a>Разметка глифа  
 В следующем примере кода показано, как использовать различные свойства <xref:System.Windows.Documents.Glyphs> элемент XAML.  
  
 [!code-xaml[GlyphsOvwSamp2#1](~/samples/snippets/csharp/VS_Snippets_Wpf/GlyphsOvwSamp2/CS/default.xaml#1)]  
  
## <a name="see-also"></a>См. также

- [Оформление в WPF](typography-in-wpf.md)
- [Документы в WPF](documents-in-wpf.md)
- [Текста](optimizing-performance-text.md)
