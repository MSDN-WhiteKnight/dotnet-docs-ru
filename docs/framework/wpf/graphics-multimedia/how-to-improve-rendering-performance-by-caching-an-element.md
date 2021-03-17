---
title: Практическое руководство. Повышение производительности отрисовки за счет кэширования элемента
ms.date: 03/30/2017
helpviewer_keywords:
- rendering performance [WPF], caching an element
- BitmapCache [WPF], improving rendering performance
- CacheMode [WPF], improving rendering performance
- performance [WPF], caching an element
- UIElement [WPF], caching
ms.assetid: 4739c1fc-60ba-4c46-aba6-f6c1a2688f19
ms.openlocfilehash: 118e8b0cca52c44788c9d5b291d710f765e7af2a
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59153378"
---
# <a name="how-to-improve-rendering-performance-by-caching-an-element"></a>Практическое руководство. Повышение производительности отрисовки за счет кэширования элемента
Используйте <xref:System.Windows.Media.BitmapCache> класс повышать производительность отрисовки сложных <xref:System.Windows.UIElement>. Для кэширования элемента, создайте новый экземпляр класса <xref:System.Windows.Media.BitmapCache> класса и его назначение этого элемента <xref:System.Windows.UIElement.CacheMode%2A> свойство. Вы можете повторно использовать <xref:System.Windows.Media.BitmapCache> эффективно в <xref:System.Windows.Media.BitmapCacheBrush>.  
  
## <a name="example"></a>Пример  
 В следующем примере кода показано, как создать составной элемент и кэшировать его как растровое изображение, что повышает производительность, когда элемент анимируется. Элемент представляет собой полотно, содержащее геометрические фигуры с большим числом вершин. Объект <xref:System.Windows.Media.BitmapCache> имеет значения по умолчанию назначено значений <xref:System.Windows.UIElement.CacheMode%2A> Canvas, и анимация демонстрирует гладкое масштабирование кэшированного растрового изображения.  
  
 [!code-xaml[System.Windows.Media.BitmapCache#_BitmapCacheXAML](~/samples/snippets/csharp/VS_Snippets_Wpf/system.windows.media.bitmapcache/cs/window1.xaml#_bitmapcachexaml)]  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Media.BitmapCache>
- <xref:System.Windows.Media.BitmapCacheBrush>
- <xref:System.Windows.UIElement.CacheMode%2A>
- [Практическое руководство. Использование кэшированного элемента в качестве кисти](how-to-use-a-cached-element-as-a-brush.md)
