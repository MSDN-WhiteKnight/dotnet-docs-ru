---
title: Практическое руководство. Кодирование и декодирование изображения в формате TIFF
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- TIFF encoding [WPF]
- encoding TIFF images [WPF]
- encoding image formats [WPF]
- decoding TIFF images [WPF]
- decoding image formats [WPF]
- TIFF decoding [WPF]
ms.assetid: 1dfe3209-fc73-40e6-ad1c-71c1c58b3364
ms.openlocfilehash: 0b2b638d3aa81e48a1378794435d59da1b323aa2
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59107436"
---
# <a name="how-to-encode-and-decode-a-tiff-image"></a>Практическое руководство. Кодирование и декодирование изображения в формате TIFF
Следующие примеры показывают, как декодировать и кодировать [!INCLUDE[TLA#tla_tiff](../../../../includes/tlasharptla-tiff-md.md)] изображений, используя заданный <xref:System.Windows.Media.Imaging.TiffBitmapDecoder> и <xref:System.Windows.Media.Imaging.TiffBitmapEncoder> объектов.  
  
## <a name="example"></a>Пример  
 В этом примере показано, как декодировать TIFF изображений с помощью <xref:System.Windows.Media.Imaging.TiffBitmapDecoder> из <xref:System.Uri>.  
  
 
 [!code-csharp[TiffBitmapDecoderEncoder#1](~/samples/snippets/csharp/VS_Snippets_Wpf/TiffBitmapDecoderEncoder/CSharp/TiffEncoderDecoder.cs#1)]
   
  
## <a name="example"></a>Пример  
 В этом примере показаны способы кодирования <xref:System.Windows.Media.Imaging.BitmapSource> в TIFF изображений с помощью <xref:System.Windows.Media.Imaging.TiffBitmapEncoder>.  
  
 
 [!code-csharp[TiffBitmapDecoderEncoder#4](~/samples/snippets/csharp/VS_Snippets_Wpf/TiffBitmapDecoderEncoder/CSharp/TiffEncoderDecoder.cs#4)]
   
  
## <a name="see-also"></a>См. также

- [Общие сведения об обработке изображений](imaging-overview.md)
