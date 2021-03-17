---
title: Практическое руководство. Использование кэшированного элемента в качестве кисти
ms.date: 03/30/2017
helpviewer_keywords:
- BitmapCache [WPF], using
- cached element [WPF], use as a brush
- BitmapCacheBrush [WPF], using
- CacheMode [WPF], using
ms.assetid: d36e944a-866e-4baf-98c4-fd6a75f6fdd0
ms.openlocfilehash: 78df242c7f00b69e36ea4ab6751f51509d9e2220
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59229372"
---
# <a name="how-to-use-a-cached-element-as-a-brush"></a>Практическое руководство. Использование кэшированного элемента в качестве кисти
Используйте <xref:System.Windows.Media.BitmapCacheBrush> класс для эффективного повторного использования кэшированного элемента. Для кэширования элемента, создайте новый экземпляр класса <xref:System.Windows.Media.BitmapCache> класса и его назначение этого элемента <xref:System.Windows.UIElement.CacheMode%2A> свойство.  
  
## <a name="example"></a>Пример  
 В следующем примере кода показано, как повторно использовать кэшированный элемент. Кэшируемый элемент представляет <xref:System.Windows.Controls.Image> элемент управления, отображающий большое изображение. <xref:System.Windows.Controls.Image> Управления кэшируется как растровое изображение с помощью <xref:System.Windows.Media.BitmapCache> класса, а кэш используется повторно, назначьте этот <xref:System.Windows.Media.BitmapCacheBrush>. Кисть, которая назначается фон двадцать пять кнопок для отображения эффективное повторное использование.  
  
 [!code-xaml[System.Windows.Media.BitmapCacheBrush#_BitmapCacheBrushXAML](~/samples/snippets/csharp/VS_Snippets_Wpf/system.windows.media.bitmapcachebrush/cs/window1.xaml#_bitmapcachebrushxaml)]  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Media.BitmapCache>
- <xref:System.Windows.Media.BitmapCacheBrush>
- <xref:System.Windows.UIElement.CacheMode%2A>
- [Практическое руководство. Повышение производительности отрисовки за счет кэширования элемента](how-to-improve-rendering-performance-by-caching-an-element.md)
