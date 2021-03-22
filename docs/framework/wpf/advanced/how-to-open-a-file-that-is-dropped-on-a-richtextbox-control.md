---
title: Практическое руководство. Открытие файла, перетащенного в элемент управления RichTextBox
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- drag-and-drop [WPF], RichTextBox
- RichTextBox [WPF], drag-and-drop
- drag-and-drop [WPF], open a dropped file
ms.assetid: 6bb8bb54-f576-41db-a9a7-24102ddeb490
ms.openlocfilehash: 8ffa4c9919788060dc4524e127c181ee8282e6f9
ms.sourcegitcommit: 0c48191d6d641ce88d7510e319cf38c0e35697d0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/05/2019
ms.locfileid: "57378927"
---
# <a name="how-to-open-a-file-that-is-dropped-on-a-richtextbox-control"></a>Практическое руководство. Открытие файла, перетащенного в элемент управления RichTextBox
В [!INCLUDE[TLA#tla_winclient](../../../../includes/tlasharptla-winclient-md.md)], <xref:System.Windows.Controls.TextBox>, <xref:System.Windows.Controls.RichTextBox>, и <xref:System.Windows.Documents.FlowDocument> все элементы управления имеют встроенные функции перетаскивания и вставки. Встроенные функции позволяет перетаскивания и вставки текста внутри и между элементами управления. Тем не менее не поддерживает открытие файла путем его перетаскивания на элементе управления. Эти элементы управления также отметить события перетаскивания и вставки, как обработанное. Таким образом по умолчанию, невозможно добавить собственные обработчики событий для обеспечения функциональных возможностей, чтобы открыть перенесенных файлов.  
  
 Чтобы добавить дополнительную обработку событий перетаскивания и вставки в этих элементах управления, используйте <xref:System.Windows.UIElement.AddHandler%28System.Windows.RoutedEvent%2CSystem.Delegate%2CSystem.Boolean%29> метод, чтобы добавить обработчики событий для событий перетаскивания и вставки. Задайте `handledEventsToo` параметр `true` иметь указанный обработчик вызывался для перенаправленного события, которое уже было отмечено как обработанное другим элементом на маршруте события.  
  
> [!TIP]
>  Вы можете заменить встроенные функции и перетаскивать <xref:System.Windows.Controls.TextBox>, <xref:System.Windows.Controls.RichTextBox>, и <xref:System.Windows.Documents.FlowDocument> путем обработки в предварительных версиях события перетаскивания и вставки и пометка события предварительного просмотра как обработанного. Тем не менее это приведет к отключению встроенные функции и перетаскивать и не рекомендуется.  
  
## <a name="example"></a>Пример  
 Следующий пример демонстрирует добавление обработчиков для <xref:System.Windows.DragDrop.DragOver> и <xref:System.Windows.DragDrop.Drop> события на <xref:System.Windows.Controls.RichTextBox>. В этом примере используется <xref:System.Windows.UIElement.AddHandler%28System.Windows.RoutedEvent%2CSystem.Delegate%2CSystem.Boolean%29> метод и наборы `handledEventsToo` параметр `true` таким образом, чтобы обработчики событий будет вызываться, даже если <xref:System.Windows.Controls.RichTextBox> помечает эти события как обработанные. Код в обработчик событий добавляет функциональные возможности для открытия текстового файла, перетащенного в <xref:System.Windows.Controls.RichTextBox>.  
  
 Чтобы протестировать этот пример, перетащите в текстовый файл или файл format (RTF) форматированного текста в обозревателе Windows к <xref:System.Windows.Controls.RichTextBox>. Файл будет открыт в <xref:System.Windows.Controls.RichTextBox>. Если нажать клавишу SHIFT при перетаскивании файла, файл будет открыт в виде обычного текста.  
  
 [!code-xaml[DragDropSnippets#RtbXAML](~/samples/snippets/csharp/VS_Snippets_Wpf/dragdropsnippets/cs/mainwindow.xaml#rtbxaml)]  
  
 [!code-csharp[DragDropSnippets#RtbHandlers](~/samples/snippets/csharp/VS_Snippets_Wpf/dragdropsnippets/cs/mainwindow.xaml.cs#rtbhandlers)]
 
