---
title: Практическое руководство. Заливка области с помощью системной кисти
ms.date: 03/30/2017
helpviewer_keywords:
- system brushes [WPF], painting with
- painting [WPF], with system brushes
- brushes [WPF], painting with system brushes [WPF]
ms.assetid: 5141a763-9235-42cb-a6bb-afc75513eac7
ms.openlocfilehash: e713903e2cfbb63cb64ceb94621317f9e76dea70
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59195050"
---
# <a name="how-to-paint-an-area-with-a-system-brush"></a>Практическое руководство. Заливка области с помощью системной кисти
<xref:System.Windows.SystemColors> Класс предоставляет доступ к системным кистям и цветам, такие как <xref:System.Windows.SystemColors.ControlBrush%2A>, <xref:System.Windows.SystemColors.ControlBrushKey%2A>, и <xref:System.Windows.SystemColors.DesktopBrush%2A>. Системная кисть — это <xref:System.Windows.Media.SolidColorBrush> объект, который закрашивает область с помощью указанного системного цвета. Системная кисть всегда дает сплошную заливку; ее нельзя использовать для создания градиентной заливки.  
  
 Системные кисти можно использовать как статический или динамический ресурс. Используйте динамический ресурс, если нужно автоматическое обновление кисти при изменении пользователем кисти во время выполнения приложения; в противном случае используйте статический ресурс. Класс SystemColors содержит разнообразные статические свойства, которые следуют строгому правилу именования:  
  
-   *\<SystemColor>* Brush  
  
     Возвращает статическую ссылку на <xref:System.Windows.Media.SolidColorBrush> указанного системного цвета.  
  
-   *\<SystemColor>* BrushKey  
  
     Возвращает динамическую ссылку <xref:System.Windows.Media.SolidColorBrush> указанного системного цвета.  
  
-   *\<SystemColor>* Color  
  
     Возвращает статическую ссылку на <xref:System.Windows.Media.Color> структуру указанного системного цвета.  
  
-   *\<SystemColor>* ColorKey  
  
     Возвращает динамическую ссылку <xref:System.Windows.Media.Color> структуру указанного системного цвета.  
  
 Системный цвет является <xref:System.Windows.Media.Color> структуры, который может использоваться для настройки кисти. Например, можно создать с помощью системных цветов, задав градиент <xref:System.Windows.Media.GradientStop.Color%2A> свойства <xref:System.Windows.Media.LinearGradientBrush> градиента объекта с системными цветами. Например, см. в разделе [использование системных цветов в градиенте](how-to-use-system-colors-in-a-gradient.md).  
  
## <a name="example"></a>Пример  
 В следующем примере используется динамическая ссылка на системную кисть для установки фона кнопки.  
  
 [!code-xaml[brushsamples_snip#GraphicsMMDynamicSystemColorDesktopBrushKeyExampleWholePage](~/samples/snippets/csharp/VS_Snippets_Wpf/brushsamples_snip/CS/DynamicSystemBrushExample.xaml#graphicsmmdynamicsystemcolordesktopbrushkeyexamplewholepage)]  
  
 В следующем примере используется статическая ссылка на системную кисть для установки фона кнопки.  
  
 [!code-xaml[brushsamples_snip#GraphicsMMStaticSystemColorDesktopBrushExampleWholePage](~/samples/snippets/csharp/VS_Snippets_Wpf/brushsamples_snip/CS/StaticSystemBrushExample.xaml#graphicsmmstaticsystemcolordesktopbrushexamplewholepage)]  
  
 Пример, демонстрирующий использование системных цветов в градиенте, см. в разделе [использование системных цветов в градиенте](how-to-use-system-colors-in-a-gradient.md).  
  
## <a name="see-also"></a>См. также

- [Использование системных цветов в градиенте](how-to-use-system-colors-in-a-gradient.md)
- [Общие сведения о закраске сплошным цветом и градиентом](painting-with-solid-colors-and-gradients-overview.md)
