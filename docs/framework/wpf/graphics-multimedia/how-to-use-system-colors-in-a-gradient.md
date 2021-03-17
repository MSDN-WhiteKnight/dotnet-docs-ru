---
title: Практическое руководство. Использование системных цветов в градиенте
ms.date: 03/30/2017
helpviewer_keywords:
- gradients [WPF], system colors in
- system colors in gradients [WPF]
ms.assetid: 11942e7e-6300-4b50-8ed1-f50e8d20e7d2
ms.openlocfilehash: 55c99640907a0c372f8c7bbc50b9b45c9f15ef3c
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59229444"
---
# <a name="how-to-use-system-colors-in-a-gradient"></a>Практическое руководство. Использование системных цветов в градиенте
Чтобы использовать системный цвет в градиенте, используйте  *\<SystemColor >* цвет и  *\<SystemColor >* ColorKey статические свойства класса <xref:System.Windows.SystemColors> для получения ссылки на цвет, где  *\<SystemColor >* имя требуемого системного цвета. Используйте  *\<SystemColor >* свойства ColorKey, если вы хотите создать динамическую ссылку, которая обновляется автоматически по мере изменения темы системы. В противном случае используйте  *\<SystemColor >* свойства цветов.  
  
## <a name="example"></a>Пример  
 В следующем примере для создания градиента используются динамические ресурсы системных цветов.  
  
 [!code-xaml[brushsamples_snip#GraphicsMMDynamicSystemColorGradientExampleWholePage](~/samples/snippets/csharp/VS_Snippets_Wpf/brushsamples_snip/CS/DynamicSystemColorExample.xaml#graphicsmmdynamicsystemcolorgradientexamplewholepage)]  
  
 В следующем примере для создания градиента используются статические ресурсы системных цветов.  
  
 [!code-xaml[brushsamples_snip#GraphicsMMStaticSystemColorGradientExampleWholePage](~/samples/snippets/csharp/VS_Snippets_Wpf/brushsamples_snip/CS/StaticSystemColorExample.xaml#graphicsmmstaticsystemcolorgradientexamplewholepage)]  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.SystemColors>
- [Заливка области с помощью системной кисти](how-to-paint-an-area-with-a-system-brush.md)
- [Общие сведения о закраске сплошным цветом и градиентом](painting-with-solid-colors-and-gradients-overview.md)
