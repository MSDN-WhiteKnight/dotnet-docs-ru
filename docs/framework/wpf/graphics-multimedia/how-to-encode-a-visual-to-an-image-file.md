---
title: Практическое руководство. Кодирование визуального элемента в файл изображения
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- image files [WPF], encoding from visuals
- encoding image formats [WPF]
- visuals [WPF], encoding to an image file
ms.assetid: 2036385b-ea47-4d54-8027-5797f52c8149
ms.openlocfilehash: 872c19af0cfcf4fc980643c37e9a6028457c03b3
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59096788"
---
# <a name="how-to-encode-a-visual-to-an-image-file"></a>Практическое руководство. Кодирование визуального элемента в файл изображения
В этом примере показаны способы кодирования <xref:System.Windows.Media.Visual> объекта в файл изображения с помощью <xref:System.Windows.Media.Imaging.RenderTargetBitmap> и <xref:System.Windows.Media.Imaging.PngBitmapEncoder>.  
  
## <a name="example"></a>Пример  
 <xref:System.Windows.Media.DrawingVisual> Создается с помощью <xref:System.Windows.Media.Imaging.BitmapImage> и <xref:System.Windows.Media.FormattedText> который отображается <xref:System.Windows.Media.Imaging.RenderTargetBitmap>. Визуализированный точечный рисунок затем используется для создания <xref:System.Windows.Media.Imaging.BitmapFrame> добавляемым к <xref:System.Windows.Media.Imaging.PngBitmapEncoder> для создания нового [!INCLUDE[TLA#tla_png](../../../../includes/tlasharptla-png-md.md)] файл.  
  
 [!code-csharp[ImagingSnippetGallery_procedural_snip#RTBEncodeInline1](~/samples/snippets/csharp/VS_Snippets_Wpf/ImagingSnippetGallery_procedural_snip/CSharp/RenderTargetBitmapExample_Encode.cs#rtbencodeinline1)]
   
  
 Объект <xref:System.Windows.Media.Imaging.PngBitmapEncoder> использовался в этом примере, но содержит производного <xref:System.Windows.Media.Imaging.BitmapEncoder> объекты можно было бы для создания файла образа.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Media.DrawingContext>
- [Общие сведения об обработке изображений](imaging-overview.md)
- [Обзор объектов Drawing](drawing-objects-overview.md)
- [Использование объектов DrawingVisual](using-drawingvisual-objects.md)
