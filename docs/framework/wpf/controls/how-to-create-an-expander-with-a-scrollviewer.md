---
title: Практическое руководство. Создание расширителя с элементом ScrollViewer
ms.date: 03/30/2017
helpviewer_keywords:
- controls [WPF], Expander
- ScrollViewer control [WPF], with Expander control
- Expander control [WPF], creating
- controls [WPF], ScrollViewer
ms.assetid: 2ad124d2-2406-4157-aaf2-64e067298f01
ms.openlocfilehash: ef0bc5d344f7d465de9209708430d3e61d40d4f7
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59114654"
---
# <a name="how-to-create-an-expander-with-a-scrollviewer"></a>Практическое руководство. Создание расширителя с элементом ScrollViewer
В этом примере показано, как создать <xref:System.Windows.Controls.Expander> элемент управления, который содержит сложное содержимое, например изображение и текст. Пример также помещает содержимое <xref:System.Windows.Controls.Expander> в <xref:System.Windows.Controls.ScrollViewer> элемента управления.  
  
## <a name="example"></a>Пример  
 В следующем примере показано, как создать <xref:System.Windows.Controls.Expander>. В примере используется <xref:System.Windows.Controls.Primitives.BulletDecorator> управления, который содержит изображение и текст, чтобы определить <xref:System.Windows.Controls.HeaderedContentControl.Header%2A>. Объект <xref:System.Windows.Controls.ScrollViewer> управления предоставляет метод для прокрутки развернутого содержимого.  
  
 Обратите внимание, что в этом примере <xref:System.Windows.FrameworkElement.Height%2A> свойство <xref:System.Windows.Controls.ScrollViewer> вместо содержимого. Если <xref:System.Windows.FrameworkElement.Height%2A> устанавливается на содержимом, <xref:System.Windows.Controls.ScrollViewer> не позволяет пользователю выполнять прокрутку содержимого. <xref:System.Windows.FrameworkElement.Width%2A> Установлено свойство <xref:System.Windows.Controls.Expander> управления и этот параметр применяется к <xref:System.Windows.Controls.HeaderedContentControl.Header%2A> и развернутому содержимому.  
  
 [!code-xaml[ExpanderRichContent#CreateExpander](~/samples/snippets/csharp/VS_Snippets_Wpf/ExpanderRichContent/CSharp/Window1.xaml#createexpander)]  
  
 [!code-csharp[ExpanderRichContent#CreateExpanderCode](~/samples/snippets/csharp/VS_Snippets_Wpf/ExpanderRichContent/CSharp/Window1.xaml.cs#createexpandercode)]  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Controls.Expander>
- [Общие сведения об элементе управления Expander](expander-overview.md)
- [Практические руководства](expander-how-to-topics.md)
