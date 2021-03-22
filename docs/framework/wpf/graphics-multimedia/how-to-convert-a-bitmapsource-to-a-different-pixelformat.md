---
title: Практическое руководство. Преобразование объекта BitmapSource в другой индексированный формат PixelFormat
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- BitmapSource objects [WPF], converting to indexed pixel format
- converting images [WPF]
- converting [WPF], BitmapSource objects to indexed pixel formats
- converting [WPF], BitmapSource objects to palettized pixel format
- BitmapSource objects [WPF], converting to palettized pixel format
ms.assetid: cd9df1e4-d5dc-4f57-b67b-4ec67e086b33
ms.openlocfilehash: ea042599369da8435198e4206f89f3fa356a80c2
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59153287"
---
# <a name="how-to-convert-a-bitmapsource-to-a-different-pixelformat"></a>Практическое руководство. Преобразование объекта BitmapSource в другой индексированный формат PixelFormat
В этом примере показано, как преобразовать <xref:System.Windows.Media.Imaging.BitmapSource> объекта (<xref:System.Windows.Media.Imaging.BitmapImage>) на другой <xref:System.Windows.Media.PixelFormat> с помощью <xref:System.Windows.Media.Imaging.FormatConvertedBitmap>.  
  
## <a name="example"></a>Пример  
 [!code-csharp[ImagingSnippetGallery_procedural_snip#PixelFormatConversion](~/samples/snippets/csharp/VS_Snippets_Wpf/ImagingSnippetGallery_procedural_snip/CSharp/PixelFormatsExample.cs#pixelformatconversion)]
   
  
## <a name="see-also"></a>См. также

- [Общие сведения об обработке изображений](imaging-overview.md)
