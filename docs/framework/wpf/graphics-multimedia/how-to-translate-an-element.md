---
title: Практическое руководство. Перемещение элемента
ms.date: 03/30/2017
helpviewer_keywords:
- graphics [WPF], translations
ms.assetid: 461c8273-15df-42f6-8672-89ba22887cc0
ms.openlocfilehash: 9c1b873a89820e85efb99789f483c4832fb23cf7
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59231192"
---
# <a name="how-to-translate-an-element"></a>Практическое руководство. Перемещение элемента
В этом примере показано, как для переноса (перемещения) элемента с помощью <xref:System.Windows.Media.TranslateTransform>.  
  
 <xref:System.Windows.Media.TranslateTransform> Класс особенно полезен для перемещения элементов внутри панелей, которые не поддерживают абсолютное позиционирование. Например, применяя <xref:System.Windows.Media.TranslateTransform> для <xref:System.Windows.UIElement.RenderTransform%2A> свойства элемента, можно переместить элемент в пределах <xref:System.Windows.Controls.StackPanel> или <xref:System.Windows.Controls.DockPanel>.  
  
 Используйте <xref:System.Windows.Media.TranslateTransform.X%2A> свойство <xref:System.Windows.Media.TranslateTransform> Чтобы задать интервал в пикселях для перемещения элемента вдоль оси x. Используйте <xref:System.Windows.Media.TranslateTransform.Y%2A> свойство, чтобы задать интервал в пикселях для перемещения элемента вдоль оси y. Наконец, примените <xref:System.Windows.Media.TranslateTransform> для <xref:System.Windows.UIElement.RenderTransform%2A> свойство элемента.  
  
 В следующем примере используется <xref:System.Windows.Media.TranslateTransform> для перемещения элемента на 50 пикселей вправо и 50 пикселей вниз.  
  
## <a name="example"></a>Пример  
 [!code-xaml[transformsSample#53](~/samples/snippets/csharp/VS_Snippets_Wpf/transformsSample/CS/TranslateTransformExample.xaml#53)]  
  
 Полный пример см. в разделе [Примеры двумерных преобразований](https://go.microsoft.com/fwlink/?LinkID=158252).  
  
## <a name="see-also"></a>См. также

- [Общие сведения о классах Transform](transforms-overview.md)
