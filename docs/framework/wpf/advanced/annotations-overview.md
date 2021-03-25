---
title: Общие сведения о заметках
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- highlights [WPF]
- documents [WPF], annotations
- sticky notes [WPF]
ms.assetid: 716bf474-29bd-4c74-84a4-8e0744bdad62
ms.openlocfilehash: faf2e9bbe23acfd46ee98e1f0fca01b7563ede73
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59122451"
---
# <a name="annotations-overview"></a>Общие сведения о заметках
Добавление заметок или примечаний на печатные документы — это настолько обыденное действие, что мы воспринимаем его как должное. Такие примечания или комментарии являются "заметками", которые мы добавляем в документ для пометки информации или выделения интересующих элементов, к которым будем обращаться в дальнейшем. Хотя написание заметок на печатных документах является простым и обыденным, возможность добавлять личные примечания в электронные документы, как правило, очень ограниченна, если вообще доступна.  
  
 В этом разделе рассматриваются распространенные типы заметок, в частности записки и выделения и показано, как [!INCLUDE[TLA#tla_caf](../../../../includes/tlasharptla-caf-md.md)] облегчает использование этих типов заметок в приложениях с помощью документов Windows Presentation Foundation (WPF) элементы управления для просмотра.  WPF включить элементы управления для просмотра документа, поддерживающие заметки <xref:System.Windows.Controls.FlowDocumentReader> и <xref:System.Windows.Controls.FlowDocumentScrollViewer>, а также, как элементы управления, производного от <xref:System.Windows.Controls.Primitives.DocumentViewerBase> например <xref:System.Windows.Controls.DocumentViewer> и <xref:System.Windows.Controls.FlowDocumentPageViewer>.  

<a name="caf1_type_stickynotes"></a>   
## <a name="sticky-notes"></a>Записки  
 Обычная записка содержит информацию, написанную на маленьком листке цветной бумаги, который затем "приклеивается" к документу. Цифровые записки предоставляют аналогичные функциональные возможности для электронных документов, однако обеспечивают дополнительную гибкость благодаря включению многих других типов содержимого, например печатного текста, рукописных заметок (например, рукописного ввода [!INCLUDE[TLA#tla_tpc](../../../../includes/tlasharptla-tpc-md.md)]) или веб-ссылок.  
  
 Ниже показаны некоторые примеры заметок: выделение, текстовая записка и рукописная записка.  
  
 ![Выделение, текстовая и рукописная записка](./media/caf-stickynote.jpg "CAF_StickyNote")  
  
 В следующем примере показан метод, который можно использовать для включения поддержки заметок в приложении.  
  
 [!code-csharp[DocViewerAnnotationsXml#DocViewXmlStartAnnotations](~/samples/snippets/csharp/VS_Snippets_Wpf/DocViewerAnnotationsXml/CSharp/Window1.xaml.cs#docviewxmlstartannotations)]
   
  
<a name="caf1_type_callouts"></a>   
## <a name="highlights"></a>Выделение  
 Люди используют различные способы для привлечения внимания к интересующим элементам в бумажном документе, такие как подчеркивание, выделение, заключение слов в предложении в кружок или рисование пометок и примечаний на полях.  Заметки типа "выделение" в [!INCLUDE[TLA#tla_caf](../../../../includes/tlasharptla-caf-md.md)] предоставляют подобную функцию для информации, отображаемой в элементах управления для просмотра документа WPF.  
  
 На следующем рисунке показан пример заметки-выделения.  
  
 ![Заметка-выделение](./media/caf-callouts.png "CAF_Callouts")  
  
 Пользователи обычно создают заметки, сначала выбирая некоторый текст или интересующий элемент, а затем щелкните правой кнопкой мыши для отображения <xref:System.Windows.Controls.ContextMenu> для параметров заметки.  В следующем примере показан XAML можно использовать для объявления <xref:System.Windows.Controls.ContextMenu> с маршрутизированных команд, доступных пользователям для создания заметок и управления ими.  
  
 [!code-xaml[DocViewerAnnotationsXps#CreateDeleteAnnotations](~/samples/snippets/csharp/VS_Snippets_Wpf/DocViewerAnnotationsXps/CSharp/Window1.xaml#createdeleteannotations)]  
  
<a name="caf1_framework_data_anchoring"></a>   
## <a name="data-anchoring"></a>Привязка данных  
 [!INCLUDE[TLA2#tla_caf](../../../../includes/tla2sharptla-caf-md.md)] привязывает заметки к данным, выбранным пользователем, а не только к расположению. Таким образом, при изменении представления документа, например когда пользователь прокручивает его или изменяет размер окна отображения, заметка остается привязанной к выбранным данным. Например, на следующем графике показана заметка, которую пользователь задал для выделенного текста. При изменении представления документа (прокрутка, изменение размера, масштаба и т. д.) заметка-выделение перемещается вместе с исходным фрагментом данных.  
  
 ![Привязка данных заметки](./media/caf-dataanchoring.png "CAF_DataAnchoring")  
  
<a name="matching_annotations_with_annotated_objects"></a>   
## <a name="matching-annotations-with-annotated-objects"></a>Сопоставление заметок с объектами заметок  
 Можно сопоставить заметки с соответствующими объектами заметок. Например, рассмотрим простое приложение для чтения документа, имеющее панель комментариев. Панель комментариев может быть полем со списком, в котором отображается текст из списка заметок, привязанных к документу. Когда пользователь выбирает элемент в списке, приложение загружает в представление абзац в документе, к которому привязан соответствующий объект заметки.  
  
 Ниже приведен пример, демонстрирующий реализацию обработчика событий такого списка, который служит в качестве панели комментариев.  
  
 [!code-csharp[FlowDocumentAnnotatedViewer#Handler](~/samples/snippets/csharp/VS_Snippets_Wpf/FlowDocumentAnnotatedViewer/CSharp/Window1.xaml.cs#handler)]
   
  
 Другой пример сценария касается приложений, позволяющих производить обмен заметками и записками между читателями документа по электронной почте. Эта функция позволяет таким приложениям направлять пользователя на страницу, содержащую заметку для обмена.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Controls.Primitives.DocumentViewerBase>
- <xref:System.Windows.Controls.DocumentViewer>
- <xref:System.Windows.Controls.FlowDocumentPageViewer>
- <xref:System.Windows.Controls.FlowDocumentScrollViewer>
- <xref:System.Windows.Controls.FlowDocumentReader>
- <xref:System.Windows.Annotations.IAnchorInfo>
- [Схема примечаний](annotations-schema.md)
- [Общие сведения о ContextMenu](../controls/contextmenu-overview.md)
- [Общие сведения о системе команд](commanding-overview.md)
- [Общие сведения о документах нефиксированного формата](flow-document-overview.md)
- [Практическое руководство. Добавление команды в объект MenuItem](https://docs.microsoft.com/previous-versions/dotnet/netframework-3.5/ms741839(v=vs.90))
