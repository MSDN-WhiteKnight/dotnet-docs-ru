---
title: Практическое руководство. Закраска области с применением радиального градиента
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- brushes [WPF], painting with radial gradients
- radial gradients [WPF], painting with
- painting [WPF], with radial gradients
ms.assetid: b5d0fc8a-8986-4796-b003-a75b41a48928
ms.openlocfilehash: c3bcc11dea4b1f223f629415591ab03588881dde
ms.sourcegitcommit: 0c48191d6d641ce88d7510e319cf38c0e35697d0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/05/2019
ms.locfileid: "57379787"
---
# <a name="how-to-paint-an-area-with-a-radial-gradient"></a>Практическое руководство. Закраска области с применением радиального градиента
В этом примере показано, как использовать <xref:System.Windows.Media.RadialGradientBrush> класс для закраски области с применением радиального градиента.  
  
## <a name="example"></a>Пример  
 В следующем примере используется <xref:System.Windows.Media.RadialGradientBrush> для закрашивания прямоугольника с применением радиального градиента, которая переходит с желтого красного, синего и зеленого.  
  
 [!code-csharp[BrushesIntroduction_snip#SimpleRadialGradientExampleWholePage](~/samples/snippets/csharp/VS_Snippets_Wpf/BrushesIntroduction_snip/CSharp/RadialGradientBrushSnippet.cs#simpleradialgradientexamplewholepage)]
 [!code-vb[BrushesIntroduction_snip#SimpleRadialGradientExampleWholePage](~/samples/snippets/visualbasic/VS_Snippets_Wpf/BrushesIntroduction_snip/visualbasic/radialgradientbrushsnippet.vb#simpleradialgradientexamplewholepage)]
 [!code-xaml[BrushesIntroduction_snip#SimpleRadialGradientExampleWholePage](~/samples/snippets/xaml/VS_Snippets_Wpf/BrushesIntroduction_snip/XAML/RadialGradientBrushSnippet.xaml#simpleradialgradientexamplewholepage)]  
  
 На рисунке показан градиент из предыдущего примера. Выделены градиента.  
  
 ![Ограничения градиента в радиальном градиенте](./media/wcpsdk-graphicsmm-4gradientstops-rg.png "wcpsdk_graphicsmm_4gradientstops_rg")  
  
> [!NOTE]
>  В примерах в этом разделе используется система координат по умолчанию для задания точек управления. Система координат по умолчанию определяется относительно ограничивающего прямоугольника: 0 указывает 0 процентов ограничивающего прямоугольника, а 1 указывает 100 процентов ограничивающего прямоугольника. Эту систему координат можно изменить, задав <xref:System.Windows.Media.GradientBrush.MappingMode%2A> в соответствии с значением <xref:System.Windows.Media.BrushMappingMode.Absolute>. Абсолютная система координат не привязана к ограничивающему прямоугольнику. Значения интерпретируются непосредственно в локальной области.  
  
 Для дополнительных <xref:System.Windows.Media.RadialGradientBrush> примеры, см. в разделе [пример использования кистей](https://go.microsoft.com/fwlink/?LinkID=159973). Дополнительные сведения о градиенты и других типов кистей см. в разделе [закраске сплошным цветом и градиентом Обзор](painting-with-solid-colors-and-gradients-overview.md).
