---
title: Практическое руководство. Кодирование и декодирование изображения в формате PNG
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- PNG encoding [WPF]
- decoding PNG images [WPF]
- PNG decoding [WPF]
- encoding image formats [WPF]
- decoding image formats [WPF]
- encoding PNG images [WPF]
ms.assetid: 3d31d186-af73-47f0-b5a7-c26ae46409a6
ms.openlocfilehash: 46d4a7ffbfe7a6a620c26447cce30f3a0bd35adc
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59090858"
---
# <a name="how-to-encode-and-decode-a-png-image"></a>Практическое руководство. Кодирование и декодирование изображения в формате PNG
Следующие примеры показывают, как декодировать и кодировать [!INCLUDE[TLA#tla_png](../../../../includes/tlasharptla-png-md.md)] изображений, используя заданный <xref:System.Windows.Media.Imaging.PngBitmapDecoder> и <xref:System.Windows.Media.Imaging.PngBitmapEncoder> объектов.  
  
## <a name="example"></a>Пример  
 В этом примере показано, как декодировать [!INCLUDE[TLA2#tla_png](../../../../includes/tla2sharptla-png-md.md)] изображений с помощью <xref:System.Windows.Media.Imaging.PngBitmapDecoder> из <xref:System.IO.FileStream>.  
  
 [!code-cpp[PngBitmapDecoderEncoder#1](~/samples/snippets/cpp/VS_Snippets_Wpf/PngBitmapDecoderEncoder/CPP/PngEncoderDecoder.cpp#1)]
 [!code-csharp[PngBitmapDecoderEncoder#1](~/samples/snippets/csharp/VS_Snippets_Wpf/PngBitmapDecoderEncoder/CSharp/PngEncoderDecoder.cs#1)]
   
  
## <a name="example"></a>Пример  
 В этом примере показаны способы кодирования <xref:System.Windows.Media.Imaging.BitmapSource> в [!INCLUDE[TLA2#tla_png](../../../../includes/tla2sharptla-png-md.md)] изображений с помощью <xref:System.Windows.Media.Imaging.PngBitmapEncoder>.  
  
 [!code-cpp[PngBitmapDecoderEncoder#4](~/samples/snippets/cpp/VS_Snippets_Wpf/PngBitmapDecoderEncoder/CPP/PngEncoderDecoder.cpp#4)]
 [!code-csharp[PngBitmapDecoderEncoder#4](~/samples/snippets/csharp/VS_Snippets_Wpf/PngBitmapDecoderEncoder/CSharp/PngEncoderDecoder.cs#4)]
   
  
## <a name="see-also"></a>См. также

- [Общие сведения об обработке изображений](imaging-overview.md)
