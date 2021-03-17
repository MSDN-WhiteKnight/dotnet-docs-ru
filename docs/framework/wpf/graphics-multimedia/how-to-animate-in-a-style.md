---
title: Как анимировать свойства в стиле (WPF)
ms.date: 03/30/2017
helpviewer_keywords:
- animation [WPF], properties [WPF], within styles
- styles [WPF], animating properties within
ms.assetid: 6a791f3d-6b1f-4972-a2f9-35880bcfd954
ms.openlocfilehash: 5fb18a2d927746c3437ec01d2a19327be373cae3
ms.sourcegitcommit: 0c48191d6d641ce88d7510e319cf38c0e35697d0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/05/2019
ms.locfileid: "57373963"
---
# <a name="how-to-animate-in-a-style"></a>Как анимация с использованием стилей

В этом примере показано, как анимировать свойства в стиле. При анимации в стиле, элемент структуры, для которой определяется стиль можно сделать целью напрямую. Чтобы обратиться к фиксируемому объекту, вам необходимо «поставить точку» из свойства элемента со стилем.

В следующем примере определяются внутри стиля и применяются для нескольких анимаций <xref:System.Windows.Controls.Button>. Когда пользователь перемещает указатель мыши над кнопкой, его из непрозрачного переходит в полупрозрачности и обратно еще раз, многократно. Когда пользователь перемещает указатель мыши кнопки, он становится полностью непрозрачным. При нажатии кнопки, цвет его фона изменяется с оранжевого на белый и обратно. Так как <xref:System.Windows.Media.SolidColorBrush> используется для закрашивания кнопки нельзя обратиться напрямую, она осуществляется вниз с помощью кнопки <xref:System.Windows.Controls.Control.Background%2A> свойство.

## <a name="example"></a>Пример

[!code-xaml[timingbehaviors_snip#21](~/samples/snippets/csharp/VS_Snippets_Wpf/timingbehaviors_snip/CSharp/StyleStoryboardsExample.xaml#21)]

Обратите внимание, что при анимации в стиле, возможно, к целевым объектам, которые не существуют. Например, предположим, что стиль использует <xref:System.Windows.Media.SolidColorBrush> переопределяется свойство фона кнопки, но в определенный момент стиль и фона кнопки задается с помощью <xref:System.Windows.Media.LinearGradientBrush>.  Для анимации <xref:System.Windows.Media.SolidColorBrush> не создается исключение; анимация завершатся сбоем без уведомления.

Дополнительные сведения о синтаксисе планирования раскадровки, см. в разделе [Общие сведения о раскадровках](storyboards-overview.md). Дополнительные сведения об анимации см. в разделе [Общие сведения об анимации](animation-overview.md). Дополнительные сведения о стилях см. в разделе [Стилизация и использование шаблонов](../controls/styling-and-templating.md).
