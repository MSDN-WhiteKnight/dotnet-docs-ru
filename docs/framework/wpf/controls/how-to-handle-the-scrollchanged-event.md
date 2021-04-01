---
title: Практическое руководство. Обработка события ScrollChanged
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- ScrollViewer control [WPF], raising ScrollChanged events
- ScrollChanged events [WPF]
ms.assetid: 42c695d8-ee28-49d4-80fd-fc71e9be7f29
ms.openlocfilehash: 54f20a4b8c6e6fcc190257fcf5de4374415d68b4
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59206152"
---
# <a name="how-to-handle-the-scrollchanged-event"></a>Практическое руководство. Обработка события ScrollChanged
## <a name="example"></a>Пример  
 В этом примере демонстрируется обработка <xref:System.Windows.Controls.ScrollViewer.ScrollChanged> событие <xref:System.Windows.Controls.ScrollViewer>.  
  
 Объект <xref:System.Windows.Documents.FlowDocument> элемент с <xref:System.Windows.Documents.Paragraph> определить компоненты в XAML. Когда <xref:System.Windows.Controls.ScrollViewer.ScrollChanged> событие возникает из-за взаимодействия с пользователем, вызывается обработчик и текст записывается <xref:System.Windows.Controls.TextBlock> означает, что возникло событие.  
  
 [!code-xaml[scrollchangedeventargsLayout#1](~/samples/snippets/csharp/VS_Snippets_Wpf/scrollchangedeventargsLayout/CSharp/Window1.xaml#1)]  
[!code-xaml[scrollchangedeventargsLayout#2](~/samples/snippets/csharp/VS_Snippets_Wpf/scrollchangedeventargsLayout/CSharp/Window1.xaml#2)]  
  
 [!code-csharp[scrollchangedeventargsLayout#3](~/samples/snippets/csharp/VS_Snippets_Wpf/scrollchangedeventargsLayout/CSharp/Window1.xaml.cs#3)]
   
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Controls.ScrollViewer>
- <xref:System.Windows.Controls.ScrollViewer.ScrollChanged>
- <xref:System.Windows.Controls.ScrollChangedEventHandler>
- <xref:System.Windows.Controls.ScrollChangedEventArgs>
