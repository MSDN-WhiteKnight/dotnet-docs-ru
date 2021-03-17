---
title: Практическое руководство. Удаление данных рукописного ввода в пользовательском элементе управления
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- custom controls [WPF], erasing ink on
- ink [WPF], erasing on custom control
ms.assetid: d88c50f9-b4d8-4962-a28b-67d6a15a5fe0
ms.openlocfilehash: 60e2af64cb0c5b313f4f1201cab70da6a88f61e7
ms.sourcegitcommit: 0c48191d6d641ce88d7510e319cf38c0e35697d0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/05/2019
ms.locfileid: "57365897"
---
# <a name="how-to-erase-ink-on-a-custom-control"></a>Практическое руководство. Удаление данных рукописного ввода в пользовательском элементе управления
<xref:System.Windows.Ink.IncrementalStrokeHitTester> Определяет, пересекается ли текущий росчерк одним росчерком.  Это полезно для создания элемента управления, который позволяет пользователю стирать части штриха, способ пользователь может на <xref:System.Windows.Controls.InkCanvas> при <xref:System.Windows.Controls.InkCanvas.EditingMode%2A> присваивается <xref:System.Windows.Controls.InkCanvasEditingMode.EraseByPoint>.  
  
## <a name="example"></a>Пример  
 В следующем примере создается пользовательский элемент управления, позволяющий пользователю стирать части штрихов.  В этом примере создается элемент управления, содержащий рукописного ввода при инициализации.  Чтобы создать элемент управления, который собирает данные рукописного ввода, см. в разделе [Создание элемента управления рукописным ввода](creating-an-ink-input-control.md).  
  
 [!code-csharp[HowToEraseInk#1](~/samples/snippets/csharp/VS_Snippets_Wpf/HowToEraseInk/CSharp/InkEraser.cs#1)]
 [!code-vb[HowToEraseInk#1](~/samples/snippets/visualbasic/VS_Snippets_Wpf/HowToEraseInk/VisualBasic/InkEraser.vb#1)]
