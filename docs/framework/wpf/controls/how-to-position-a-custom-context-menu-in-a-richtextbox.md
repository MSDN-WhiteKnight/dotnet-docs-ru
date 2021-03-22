---
title: Практическое руководство. Расположение пользовательского контекстного меню в RichTextBox
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- custom context menus [WPF], positioning
- positioning custom context menus [WPF]
- RichTextBox control [WPF], positioning custom context menus
- context menus [WPF], positioning
ms.assetid: bf77c930-a546-4573-9a56-9af345ba189a
ms.openlocfilehash: f9407f59c3daafd09fa5b84006f33ef2f3ebd31f
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59209428"
---
# <a name="how-to-position-a-custom-context-menu-in-a-richtextbox"></a>Практическое руководство. Расположение пользовательского контекстного меню в RichTextBox
В этом примере показано, как расположение пользовательского контекстного меню для <xref:System.Windows.Controls.RichTextBox>.  
  
 При реализации пользовательского контекстного меню для **RichTextBox** вы несете ответственность за обработку размещения контекстного меню.  По умолчанию пользовательское контекстное меню открывается в центре **RichTextBox**.  
  
## <a name="example"></a>Пример  
 Чтобы переопределить поведение расположения по умолчанию, добавьте прослушиватель для <xref:System.Windows.FrameworkContentElement.ContextMenuOpening> событий.  В приведенном ниже примере показано, как это сделать программным способом.  
  
 [!code-csharp[RichTextBox_ContextMenu#_AddListener](~/samples/snippets/csharp/VS_Snippets_Wpf/RichTextBox_ContextMenu/CSharp/app.xaml.cs#_addlistener)]
   
  
## <a name="example"></a>Пример  
 В следующем примере показана реализация соответствующего <xref:System.Windows.FrameworkContentElement.ContextMenuOpening> прослушиватель событий.  
  
 [!code-csharp[RichTextBox_ContextMenu#_ListenerBody](~/samples/snippets/csharp/VS_Snippets_Wpf/RichTextBox_ContextMenu/CSharp/app.xaml.cs#_listenerbody)]
   
  
## <a name="see-also"></a>См. также

- [Общие сведения о RichTextBox](richtextbox-overview.md)
- [Общие сведения о TextBox](textbox-overview.md)
