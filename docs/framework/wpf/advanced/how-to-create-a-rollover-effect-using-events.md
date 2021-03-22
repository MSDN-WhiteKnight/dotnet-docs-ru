---
title: Практическое руководство. Создание эффекта выделения с помощью событий
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- colors of elements [WPF], changing
- rollover effect [WPF]
- element colors [WPF], changing
ms.assetid: 3b20d028-6f1c-4b25-95d2-fa68cefbdb4c
ms.openlocfilehash: 87740a215136863199d962a2704cf691f27fc3bc
ms.sourcegitcommit: 0c48191d6d641ce88d7510e319cf38c0e35697d0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/05/2019
ms.locfileid: "57369101"
---
# <a name="how-to-create-a-rollover-effect-using-events"></a>Практическое руководство. Создание эффекта выделения с помощью событий
В этом примере показано, как изменение цвета элемента, как указатель мыши и покидает область, занимаемая элементом.  
  
 В этом примере состоит из [!INCLUDE[TLA#tla_xaml](../../../../includes/tlasharptla-xaml-md.md)] файл и файл с выделенным кодом.  
  
> [!NOTE]
>  В этом примере показано, как использовать события, но для достижения такого же эффекта рекомендуется использовать <xref:System.Windows.Trigger> в стиле. Более подробную информацию см. в разделе [Стилизация и использование шаблонов](../controls/styling-and-templating.md).  
  
## <a name="example"></a>Пример  
 Следующие [!INCLUDE[TLA2#tla_titlexaml](../../../../includes/tla2sharptla-titlexaml-md.md)] создает пользовательский интерфейс, который состоит из <xref:System.Windows.Controls.Border> вокруг <xref:System.Windows.Controls.TextBlock>и присоединяет <xref:System.Windows.Input.Mouse.MouseEnter> и <xref:System.Windows.UIElement.MouseLeave> обработчики событий для <xref:System.Windows.Controls.Border>.  
  
 [!code-xaml[mouseenterMouseleave#MouseEnterLeaveSampleXAML](~/samples/snippets/csharp/VS_Snippets_Wpf/mouseenterMouseleave/CSharp/Window1.xaml#mouseenterleavesamplexaml)]  
  
 Следующий код создает <xref:System.Windows.UIElement.MouseEnter> и <xref:System.Windows.UIElement.MouseLeave> обработчики событий.  Когда указатель мыши попадает <xref:System.Windows.Controls.Border>, фон <xref:System.Windows.Controls.Border> изменяется на красный.  Когда указатель мыши покидает <xref:System.Windows.Controls.Border>, фон <xref:System.Windows.Controls.Border> изменяется обратно на белое.  
  
 [!code-csharp[mouseenterMouseleave#MouseEnterLeaveSampleEventHandlers](~/samples/snippets/csharp/VS_Snippets_Wpf/mouseenterMouseleave/CSharp/Window1.xaml.cs#mouseenterleavesampleeventhandlers)]
 
