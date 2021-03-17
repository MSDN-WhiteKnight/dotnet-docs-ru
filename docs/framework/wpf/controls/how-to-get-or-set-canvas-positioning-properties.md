---
title: Практическое руководство. Получение или определение свойств размещения холста
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- Canvas control [WPF], setting positioning properties
ms.assetid: 1636b950-2b5a-4507-8a10-c5034cc58b1c
ms.openlocfilehash: 06508e1198736ccb1cbda41641dff4bc634ef82b
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59194413"
---
# <a name="how-to-get-or-set-canvas-positioning-properties"></a>Практическое руководство. Получение или определение свойств размещения холста
В этом примере показано, как использовать методы размещения элемента <xref:System.Windows.Controls.Canvas> для размещения содержимого дочерних элементов. В этом примере используется содержимое в <xref:System.Windows.Controls.ListBoxItem> для представления значений размещения и преобразования их в экземпляры <xref:System.Double>, который является обязательным аргументом для позиционирования. Значения преобразуются обратно в строки и отображаются в виде текста в <xref:System.Windows.Controls.TextBlock> элемента с помощью <xref:System.Windows.Controls.Canvas.GetLeft%2A> метод.  
  
## <a name="example"></a>Пример  
 В следующем примере создается <xref:System.Windows.Controls.ListBox> элемент, который содержит одиннадцать выбираемых <xref:System.Windows.Controls.ListBoxItem> элементов. <xref:System.Windows.Controls.Primitives.Selector.SelectionChanged> Триггеров событий `ChangeLeft` пользовательский метод, который определяет последующего блока кода.  
  
 Каждый <xref:System.Windows.Controls.ListBoxItem> представляет <xref:System.Double> значение, которое является одним из аргументов, <xref:System.Windows.Controls.Canvas.SetLeft%2A> метод <xref:System.Windows.Controls.Canvas> принимает. Чтобы использовать <xref:System.Windows.Controls.ListBoxItem> для представления экземпляра <xref:System.Double>, необходимо сначала преобразовать <xref:System.Windows.Controls.ListBoxItem> для правильного типа данных.  
  
 [!code-xaml[CanvasPositioningProperties#1](~/samples/snippets/csharp/VS_Snippets_Wpf/CanvasPositioningProperties/CSharp/Window1.xaml#1)]  
  
 Когда пользователь изменяет <xref:System.Windows.Controls.ListBox> выбора, он вызывает `ChangeLeft` пользовательский метод. Этот метод передает <xref:System.Windows.Controls.ListBoxItem> для <xref:System.Windows.LengthConverter> объект, который преобразует <xref:System.Windows.Controls.ContentControl.Content%2A> из <xref:System.Windows.Controls.ListBoxItem> к экземпляру <xref:System.Double> (Обратите внимание, что это значение уже был преобразован в <xref:System.String> с помощью <xref:System.Windows.Controls.Control.ToString%2A> метод). Это значение затем передается обратно в <xref:System.Windows.Controls.Canvas.SetLeft%2A> и <xref:System.Windows.Controls.Canvas.GetLeft%2A> методы <xref:System.Windows.Controls.Canvas> Чтобы изменить положение `text1` объекта.  
  
 [!code-csharp[CanvasPositioningProperties#2](~/samples/snippets/csharp/VS_Snippets_Wpf/CanvasPositioningProperties/CSharp/Window1.xaml.cs#2)]
 [!code-vb[CanvasPositioningProperties#2](~/samples/snippets/visualbasic/VS_Snippets_Wpf/CanvasPositioningProperties/VisualBasic/Window1.xaml.vb#2)]  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Controls.Canvas>
- <xref:System.Windows.Controls.ListBoxItem>
- <xref:System.Windows.LengthConverter>
- [Общие сведения о панелях](panels-overview.md)
