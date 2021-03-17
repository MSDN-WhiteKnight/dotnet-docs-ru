---
title: Общие сведения о модели содержимого TextElement
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- documents [WPF], flow documents
- TextElement content model [WPF]
- flow content elements [WPF], TextElement content model
ms.assetid: d0a7791c-b090-438c-812f-b9d009d83ee9
ms.openlocfilehash: 990642d288481fff8eeef900a86070d54790f151
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59336191"
---
# <a name="textelement-content-model-overview"></a>Общие сведения о модели содержимого TextElement
В этом обзоре модель содержимого описываются поддерживаемом содержимом для <xref:System.Windows.Documents.TextElement>. <xref:System.Windows.Documents.Paragraph> Класс — это разновидность <xref:System.Windows.Documents.TextElement>. Модель содержимого описывает объекты/элементы, которые могут содержаться в других объектах. В этом обзоре представлена модель содержимого для объектов, производных от <xref:System.Windows.Documents.TextElement>. Дополнительные сведения см. в разделе [Общие сведения о документе нефиксированного](flow-document-overview.md).  

<a name="text_element_classes"></a>   
## <a name="content-model-diagram"></a>Схема модели содержимого  
 На следующей схеме представлена модель содержимого для классов, производных от <xref:System.Windows.Documents.TextElement> а также других отличных `TextElement` классов, соответствующих этой модели.  
  
 ![Схема: Схема вместимости потока содержимого](./media/flow-content-schema.png "Flow_Content_Schema")  
  
 Как видно из предыдущей диаграммы, потомки для элемента не обязательно определяются тем, класс, производный от <xref:System.Windows.Documents.Block> класса или <xref:System.Windows.Documents.Inline> класса. Например <xref:System.Windows.Documents.Span> ( <xref:System.Windows.Documents.Inline>-производный класс) может иметь только <xref:System.Windows.Documents.Inline> дочерние элементы, но <xref:System.Windows.Documents.Figure> (также <xref:System.Windows.Documents.Inline>-производный класс) может иметь только <xref:System.Windows.Documents.Block> дочерних элементов. Таким образом, схему можно использовать для быстрого определения элемента, который может содержаться в другом элементе. В качестве примера используем схему, чтобы определить, как создать содержимое нефиксированного <xref:System.Windows.Controls.RichTextBox>.  
  
1. Объект <xref:System.Windows.Controls.RichTextBox> должен содержать <xref:System.Windows.Documents.FlowDocument> который в свою очередь, должен содержать <xref:System.Windows.Documents.Block>-объект, производный от. Ниже приведен соответствующий сегмент из предыдущей диаграммы.  
  
     ![Схема: Правила вместимости RichTextBox](./media/flow-ovw-schemawalkthrough1.png "Flow_Ovw_SchemaWalkThrough1")  
  
     Разметка может выглядеть следующим образом.  
  
     [!code-xaml[FlowOvwSnippets_snip#SchemaWalkThrough1](~/samples/snippets/csharp/VS_Snippets_Wpf/FlowOvwSnippets_snip/CS/MiscSnippets.xaml#schemawalkthrough1)]  
  
2. Согласно схеме, существует несколько <xref:System.Windows.Documents.Block> элементов для выбора из в том числе <xref:System.Windows.Documents.Paragraph>, <xref:System.Windows.Documents.Section>, <xref:System.Windows.Documents.Table>, <xref:System.Windows.Documents.List>, и <xref:System.Windows.Documents.BlockUIContainer> (см. классы, производные от Block на схеме выше). Предположим, мы хотим <xref:System.Windows.Documents.Table>. В соответствии с предыдущей схеме <xref:System.Windows.Documents.Table> содержит <xref:System.Windows.Documents.TableRowGroup> содержащий <xref:System.Windows.Documents.TableRow> элементы, которые содержат <xref:System.Windows.Documents.TableCell> элементы, которые содержат <xref:System.Windows.Documents.Block>-объект, производный от. Ниже приведен соответствующий сегмент для <xref:System.Windows.Documents.Table> из предыдущей схемы.  
  
     ![Схема: Родительский&#47;дочерний элементы для таблицы](./media/flow-ovw-schemawalkthrough2.png "Flow_Ovw_SchemaWalkThrough2")  
  
     Ниже приведена соответствующая разметка.  
  
     [!code-xaml[FlowOvwSnippets_snip#SchemaWalkThrough2](~/samples/snippets/csharp/VS_Snippets_Wpf/FlowOvwSnippets_snip/CS/MiscSnippets.xaml#schemawalkthrough2)]  
  
3. Опять же один или несколько <xref:System.Windows.Documents.Block> требуются элементы <xref:System.Windows.Documents.TableCell>. Для удобства поместим часть текста в ячейку. Это можно сделать с помощью <xref:System.Windows.Documents.Paragraph> с <xref:System.Windows.Documents.Run> элемент. Ниже приведен соответствующий сегмент из схемы, показывающий, что <xref:System.Windows.Documents.Paragraph> может занять <xref:System.Windows.Documents.Inline> элемент, который <xref:System.Windows.Documents.Run> ( <xref:System.Windows.Documents.Inline> элемент) может принять только обычный текст.  
  
     ![Схема: Родительский&#47;дочерний элементы для параграфа](./media/flow-ovw-schemawalkthrough3.png "Flow_Ovw_SchemaWalkThrough3")  
  
     ![Схема: Родительский&#47;дочерний элементы для запуска](./media/flow-ovw-schemawalkthrough4.png "Flow_Ovw_SchemaWalkThrough4")  
  
 Ниже приведен полный пример в виде разметки.  
  
 [!code-xaml[FlowOvwSnippets_snip#SchemaExampleWholePage](~/samples/snippets/csharp/VS_Snippets_Wpf/FlowOvwSnippets_snip/CS/SchemaExample.xaml#schemaexamplewholepage)]  
  
<a name="Using_the_Content_Property"></a>   
## <a name="working-with-textelement-content-programmatically"></a>Работа с содержимым TextElement с помощью программных средств  
 Содержание <xref:System.Windows.Documents.TextElement> состоит, коллекций и поэтому программное управление содержимое <xref:System.Windows.Documents.TextElement> объектов выполняется с использованием этих коллекций. Существуют три различные коллекции, используемые <xref:System.Windows.Documents.TextElement> -производные классы:  
  
-   <xref:System.Windows.Documents.InlineCollection>: Представляет коллекцию элементов <xref:System.Windows.Documents.Inline>. <xref:System.Windows.Documents.InlineCollection> Определяет допустимое дочернее содержимое элементов <xref:System.Windows.Documents.Paragraph>, <xref:System.Windows.Documents.Span>, и <xref:System.Windows.Controls.TextBlock> элементов.  
  
-   <xref:System.Windows.Documents.BlockCollection>: Представляет коллекцию элементов <xref:System.Windows.Documents.Block>. <xref:System.Windows.Documents.BlockCollection> Определяет допустимое дочернее содержимое элементов <xref:System.Windows.Documents.FlowDocument>, <xref:System.Windows.Documents.Section>, <xref:System.Windows.Documents.ListItem>, <xref:System.Windows.Documents.TableCell>, <xref:System.Windows.Documents.Floater>, и <xref:System.Windows.Documents.Figure> элементов.  
  
-   <xref:System.Windows.Documents.ListItemCollection>: Элемент содержимого потока, который представляет определенный элемент содержимого в виде упорядоченного или неупорядоченного <xref:System.Windows.Documents.List>.  
  
 Можно управлять (добавлять или удалять элементы) из этих коллекций с помощью соответствующих свойств **Inlines**, **блоки**, и **ListItems**. Следующие примеры показывают, как управлять содержимым Span с помощью **Inlines** свойство.  
  
> [!NOTE]
>  В таблице используется несколько коллекций для управления содержимым, но они не рассматриваются в данном руководстве. Дополнительные сведения см. в разделе [Общие сведения о таблицах](table-overview.md).  
  
 В следующем примере создается новый <xref:System.Windows.Documents.Span> объекта, а затем используется `Add` метод для добавления двух текстовых выполняется как дочернего содержимого объекта <xref:System.Windows.Documents.Span>.  
  
 [!code-csharp[SpanSnippets#_SpanInlinesAdd](~/samples/snippets/csharp/VS_Snippets_Wpf/SpanSnippets/CSharp/Window1.xaml.cs#_spaninlinesadd)]
 [!code-vb[SpanSnippets#_SpanInlinesAdd](~/samples/snippets/visualbasic/VS_Snippets_Wpf/SpanSnippets/visualbasic/window1.xaml.vb#_spaninlinesadd)]  
  
 В следующем примере создается новый <xref:System.Windows.Documents.Run> элемент и вставляет его в начале <xref:System.Windows.Documents.Span>.  
  
 [!code-csharp[SpanSnippets#_SpanInlinesInsert](~/samples/snippets/csharp/VS_Snippets_Wpf/SpanSnippets/CSharp/Window1.xaml.cs#_spaninlinesinsert)]
 [!code-vb[SpanSnippets#_SpanInlinesInsert](~/samples/snippets/visualbasic/VS_Snippets_Wpf/SpanSnippets/visualbasic/window1.xaml.vb#_spaninlinesinsert)]  
  
 В следующем примере удаляется последний <xref:System.Windows.Documents.Inline> элемент <xref:System.Windows.Documents.Span>.  
  
 [!code-csharp[SpanSnippets#_SpanInlinesRemoveLast](~/samples/snippets/csharp/VS_Snippets_Wpf/SpanSnippets/CSharp/Window1.xaml.cs#_spaninlinesremovelast)]
 [!code-vb[SpanSnippets#_SpanInlinesRemoveLast](~/samples/snippets/visualbasic/VS_Snippets_Wpf/SpanSnippets/visualbasic/window1.xaml.vb#_spaninlinesremovelast)]  
  
 В следующем примере удаляется все содержимое (<xref:System.Windows.Documents.Inline> элементы) из <xref:System.Windows.Documents.Span>.  
  
 [!code-csharp[SpanSnippets#_SpanInlinesClear](~/samples/snippets/csharp/VS_Snippets_Wpf/SpanSnippets/CSharp/Window1.xaml.cs#_spaninlinesclear)]
 [!code-vb[SpanSnippets#_SpanInlinesClear](~/samples/snippets/visualbasic/VS_Snippets_Wpf/SpanSnippets/visualbasic/window1.xaml.vb#_spaninlinesclear)]  
  
<a name="Types_that_Share_this_Content_Model"></a>   
## <a name="types-that-share-this-content-model"></a>Типы, совместно использующие модель содержимого  
 Следующие типы наследуют от <xref:System.Windows.Documents.TextElement> класса и может использоваться для отображения содержимого, описанного в этом обзоре.  
  
 <xref:System.Windows.Documents.Bold>, <xref:System.Windows.Documents.Figure>, <xref:System.Windows.Documents.Floater>, <xref:System.Windows.Documents.Hyperlink>, <xref:System.Windows.Documents.InlineUIContainer>, <xref:System.Windows.Documents.Italic>, <xref:System.Windows.Documents.LineBreak>, <xref:System.Windows.Documents.List>, <xref:System.Windows.Documents.ListItem>, <xref:System.Windows.Documents.Paragraph>, <xref:System.Windows.Documents.Run>, <xref:System.Windows.Documents.Section>, <xref:System.Windows.Documents.Span>, <xref:System.Windows.Documents.Table>, <xref:System.Windows.Documents.Underline>.  
  
 Обратите внимание, что этот список включает только неабстрактные типы, распространяемые с [!INCLUDE[TLA2#tla_winfxsdk](../../../../includes/tla2sharptla-winfxsdk-md.md)]. Вы можете использовать другие типы, наследующие от <xref:System.Windows.Documents.TextElement>.  
  
<a name="Types_that_Can_Contain_ContentControl_Objects"></a>   
## <a name="types-that-can-contain-textelement-objects"></a>Типы, которые могут содержать объекты TextElement  
 См. в разделе [модель содержимого WPF](../controls/wpf-content-model.md).  
  
## <a name="see-also"></a>См. также

- [Управление FlowDocument с помощью свойства Blocks](how-to-manipulate-a-flowdocument-through-the-blocks-property.md)
- [Управление элементами потокового содержимого с помощью свойства Blocks](how-to-manipulate-flow-content-elements-through-the-blocks-property.md)
- [Управление FlowDocument с помощью свойства Blocks](how-to-manipulate-a-flowdocument-through-the-blocks-property.md)
- [Управление столбцами таблицы с помощью свойства Columns](how-to-manipulate-table-columns-through-the-columns-property.md)
- [Управление группами строк таблицы пользователя с помощью свойства RowGroups](how-to-manipulate-table-row-groups-through-the-rowgroups-property.md)
