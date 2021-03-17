---
title: Практическое руководство. Перечисление содержимого изображения визуального элемента
ms.date: 03/30/2017
helpviewer_keywords:
- retrieving the DrawingGroup value of a Visual [WPF]
- enumerating the contents of a Visual [WPF]
ms.assetid: 2974ddb3-2997-4713-8fd2-e93d549c58a8
ms.openlocfilehash: 4f0afc1075fe66c7f154fcef3cd883709db55316
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59108008"
---
# <a name="how-to-enumerate-drawing-content-of-a-visual"></a>Практическое руководство. Перечисление содержимого изображения визуального элемента
<xref:System.Windows.Media.Drawing> Объекта предоставляют объектную модель для перечисления содержимого <xref:System.Windows.Media.Visual>.  
  
## <a name="example"></a>Пример  
 В следующем примере метод <xref:System.Windows.Media.VisualTreeHelper.GetDrawing%2A> используется для извлечения значения <xref:System.Windows.Media.DrawingGroup> из <xref:System.Windows.Media.Visual> и перечисления содержимого группы.  
  
> [!NOTE]
>  При перечислении содержимого визуального элемента извлекаются объекты <xref:System.Windows.Media.Drawing>, а не базовое представление данных отрисовки в виде списка инструкций векторной графики. Дополнительные сведения см. в разделе [Общие сведения об отрисовке графики в WPF](wpf-graphics-rendering-overview.md).  
  
 [!code-csharp[DrawingMiscSnippets_snip#GraphicsMMRetrieveDrawings](~/samples/snippets/csharp/VS_Snippets_Wpf/DrawingMiscSnippets_snip/CSharp/EnumerateDrawingsExample.xaml.cs#graphicsmmretrievedrawings)]  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Media.Drawing>
- <xref:System.Windows.Media.DrawingGroup>
- <xref:System.Windows.Media.VisualTreeHelper>
- [Обзор объектов Drawing](drawing-objects-overview.md)
- [Общие сведения об отрисовке графики в WPF](wpf-graphics-rendering-overview.md)
