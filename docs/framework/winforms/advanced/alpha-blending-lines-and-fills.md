---
title: Альфа-смешение цвета для линий и заливок
ms.date: 03/30/2017
helpviewer_keywords:
- lines [Windows Forms], adding transparency
- examples [Windows Forms], alpha blending
- alpha blending [Windows Forms], using with lines
- alpha blending
- lines [Windows Forms], alpha blending
- fills [Windows Forms], alpha blending
- alpha blending [Windows Forms], using with fills
- shapes [Windows Forms], adding transparency
ms.assetid: 5440f48c-3ac9-44c3-b170-c1c110bdbab8
ms.openlocfilehash: 7a8286fb741effaf668b87e90da04f79d1490de2
ms.sourcegitcommit: 160a88c8087b0e63606e6e35f9bd57fa5f69c168
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/09/2019
ms.locfileid: "57716001"
---
# <a name="alpha-blending-lines-and-fills"></a>Альфа-смешение цвета для линий и заливок
В [!INCLUDE[ndptecgdiplus](../../../../includes/ndptecgdiplus-md.md)], цвет является 32-разрядное значение с 8 бит для альфа, красного, зеленого и синего. Значение альфа определяет прозрачность цвета, области, к которому цвет смешивается с цветом фона. Альфа-значения в диапазоне от 0 до 255, где 0 соответствует полностью прозрачный цвет, а 255 представляет полностью непрозрачный цвет.  
  
 Альфа-смешение представляет собой по пикселю смешение данных исходного и фонового цвета. Каждый из трех компонентов (красный, зеленый, синий) исходного цвета смешивается с соответствующими компонентами объекта цвет фона по следующей формуле:  
  
 Отображаемый_цвет = Исходный_цвет × альфа / 255 + backgroundColor × (255 – альфа) / 255  
  
 Например предположим, что красного компонента цвета источника — 150 и красного компонента цвета фона равно 100. Если альфа-значение равно 200, красный компонент отображаемого цвета вычисляется следующим образом:  
  
 150 × 200 / 255 + 100 × (255 – 200) / 255 = 139  
  
## <a name="in-this-section"></a>В этом разделе  
 [Практическое руководство. Рисование непрозрачных и полупрозрачных линий](how-to-draw-opaque-and-semitransparent-lines.md)  
 Показано, как для рисования линий, компоненты с альфа смешением.  
  
 [Практическое руководство. Рисование непрозрачными и полупрозрачными кистями](how-to-draw-with-opaque-and-semitransparent-brushes.md)  
 Объясняется, как альфа-смешение, с помощью кистей.  
  
 [Практическое руководство. Использование режима комбинирования для управления альфа-смешением](how-to-use-compositing-mode-to-control-alpha-blending.md)  
 Описание управления альфа-смешение цвета с помощью <xref:System.Drawing.Drawing2D.CompositingMode>.  
  
 [Практическое руководство. Использование матрицы цветов для задания значений прозрачности в изображениях](how-to-use-a-color-matrix-to-set-alpha-values-in-images.md)  
 Содержит сведения об использовании <xref:System.Drawing.Imaging.ColorMatrix> объект для управления альфа-смешением.
