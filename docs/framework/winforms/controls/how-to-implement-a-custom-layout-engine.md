---
title: Практическое руководство. Реализация пользовательского механизма размещения элементов управления в форме
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- layout engines [Windows Forms], custom
- TableLayoutPanel control [Windows Forms], layout engine
- layout engines [Windows Forms], implementing
- FlowLayoutPanel control [Windows Forms], layout engine
ms.assetid: f91aa91c-29f4-4089-95ca-5d48b774b00e
ms.openlocfilehash: 8e5043e2b42b1e7449c6dab51691b6d57e28cd53
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59083378"
---
# <a name="how-to-implement-a-custom-layout-engine"></a>Практическое руководство. Реализация пользовательского механизма размещения элементов управления в форме
В следующем примере кода демонстрируется создание пользовательского механизма размещения, выполняющий простые потоковый макет. Он реализует элемент управления панели, с именем `DemoFlowPanel`, переопределяющий <xref:System.Windows.Forms.Control.LayoutEngine%2A> свойство, чтобы предоставить экземпляр `DemoFlowLayout` класса.  
  
## <a name="example"></a>Пример  
 [!code-cpp[System.Windows.Forms.Layout.LayoutEngine#1](~/samples/snippets/cpp/VS_Snippets_Winforms/System.Windows.Forms.Layout.LayoutEngine/cpp/DemoFlowLayout.cpp#1)]
 [!code-csharp[System.Windows.Forms.Layout.LayoutEngine#1](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.Layout.LayoutEngine/CS/DemoFlowLayout.cs#1)]
   
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.Layout.LayoutEngine>
- <xref:System.Windows.Forms.Control.LayoutEngine%2A?displayProperty=nameWithType>
