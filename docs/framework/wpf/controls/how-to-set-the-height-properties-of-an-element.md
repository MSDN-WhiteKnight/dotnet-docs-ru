---
title: Практическое руководство. Определение свойств высоты элемента
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- height properties [WPF]
- Panel control [WPF], height properties of elements
ms.assetid: 5ab9e781-dbb8-469a-a3c8-cf38ce312647
ms.openlocfilehash: fb655630336c3b69afdc726a2e3c5a2cb8838667
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59221591"
---
# <a name="how-to-set-the-height-properties-of-an-element"></a>Практическое руководство. Определение свойств высоты элемента
## <a name="example"></a>Пример  
 В этом примере визуально показаны различия в поведении между четырьмя свойствами, связанных с высотой в отрисовки [!INCLUDE[TLA#tla_winclient](../../../../includes/tlasharptla-winclient-md.md)].  
  
 <xref:System.Windows.FrameworkElement> Класс предоставляет четыре свойства, описывающие характеристики высоты элемента. Эти четыре свойства могут конфликтовать и когда это значение, которое имеет более высокий приоритет определяется следующим образом: <xref:System.Windows.FrameworkElement.MinHeight%2A> значение имеет приоритет над <xref:System.Windows.FrameworkElement.MaxHeight%2A> значение, которое в свою очередь имеет приоритет над <xref:System.Windows.FrameworkElement.Height%2A> значение. Четвертое свойство <xref:System.Windows.FrameworkElement.ActualHeight%2A>, доступен только для чтения и сообщает о фактической высоте, определенной при взаимодействии с процессом макета.  
  
 Следующие [!INCLUDE[TLA#tla_xaml](../../../../includes/tlasharptla-xaml-md.md)] примерах <xref:System.Windows.Shapes.Rectangle> элемент (`rect1`) как дочерний <xref:System.Windows.Controls.Canvas>. Можно изменить свойства высоты <xref:System.Windows.Shapes.Rectangle> с помощью ряда <xref:System.Windows.Controls.ListBox> элементы, представляющие значения свойств <xref:System.Windows.FrameworkElement.MinHeight%2A>, <xref:System.Windows.FrameworkElement.MaxHeight%2A>, и <xref:System.Windows.FrameworkElement.Height%2A>. Таким образом визуально отображается приоритет каждого свойства.  
  
 [!code-xaml[HeightMinHeightMaxHeight#1](~/samples/snippets/csharp/VS_Snippets_Wpf/HeightMinHeightMaxHeight/CSharp/Window1.xaml#1)]  
[!code-xaml[HeightMinHeightMaxHeight#2](~/samples/snippets/csharp/VS_Snippets_Wpf/HeightMinHeightMaxHeight/CSharp/Window1.xaml#2)]  
  
 В следующих примерах кода обработки событий, <xref:System.Windows.Controls.Primitives.Selector.SelectionChanged> вызывает событие. Каждый обработчик принимает входные данные из <xref:System.Windows.Controls.ListBox>, анализирует его как <xref:System.Double>и применяет значение к указанному свойству высоты. Значения высоты также преобразуются в строку и записываются в различные <xref:System.Windows.Controls.TextBlock> элементы (определение этих элементов не представлено в выбранной XAML).  
  
 [!code-csharp[HeightMinHeightMaxHeight#3](~/samples/snippets/csharp/VS_Snippets_Wpf/HeightMinHeightMaxHeight/CSharp/Window1.xaml.cs#3)]
   
  
 Полный пример см. в разделе [пример свойств высоты](https://go.microsoft.com/fwlink/?LinkID=159993).  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.FrameworkElement>
- <xref:System.Windows.Controls.ListBox>
- <xref:System.Windows.FrameworkElement.ActualHeight%2A>
- <xref:System.Windows.FrameworkElement.MaxHeight%2A>
- <xref:System.Windows.FrameworkElement.MinHeight%2A>
- <xref:System.Windows.FrameworkElement.Height%2A>
- [Определение свойств ширины элемента](how-to-set-the-width-properties-of-an-element.md)
- [Общие сведения о панелях](panels-overview.md)
- [Пример свойств высоты](https://go.microsoft.com/fwlink/?LinkID=159993)
