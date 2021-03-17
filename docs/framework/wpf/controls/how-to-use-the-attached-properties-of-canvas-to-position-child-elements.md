---
title: Практическое руководство. Использование вложенных свойств холста для расположения дочерних элементов
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- attached properties [WPF Designer]
- Canvas control [WPF], attached properties
ms.assetid: 48f1d25d-3820-4107-a4cc-d6c1e5664a44
ms.openlocfilehash: 347c8502bd4c5fafcde7a142327f85bfb75b9954
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59159631"
---
# <a name="how-to-use-the-attached-properties-of-canvas-to-position-child-elements"></a>Практическое руководство. Использование вложенных свойств холста для расположения дочерних элементов
В этом примере показано использование вложенных свойств <xref:System.Windows.Controls.Canvas> для размещения дочерних элементов.  
  
## <a name="example"></a>Пример  
 В следующем примере добавляется четыре <xref:System.Windows.Controls.Button> элементы как дочерние элементы родительского элемента <xref:System.Windows.Controls.Canvas>. Каждый элемент представлен <xref:System.Windows.Controls.Canvas.Bottom%2A>, <xref:System.Windows.Controls.Canvas.Left%2A>, <xref:System.Windows.Controls.Canvas.Right%2A>, и <xref:System.Windows.Controls.Canvas.Top%2A>.
Каждый <xref:System.Windows.Controls.Button> располагается относительно родительского элемента <xref:System.Windows.Controls.Canvas> и в соответствии с назначенным значением свойства.  
  
 [!code-cpp[CanvasAttachedProperties#1](~/samples/snippets/cpp/VS_Snippets_Wpf/CanvasAttachedProperties/CPP/CanvasAttachedProps.cpp#1)]
 [!code-csharp[CanvasAttachedProperties#1](~/samples/snippets/csharp/VS_Snippets_Wpf/CanvasAttachedProperties/CSharp/CanvasAttachedProps.cs#1)]
 [!code-vb[CanvasAttachedProperties#1](~/samples/snippets/visualbasic/VS_Snippets_Wpf/CanvasAttachedProperties/VisualBasic/CanvasAttachedProps.vb#1)]  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Controls.Canvas>
- <xref:System.Windows.Controls.Canvas.Bottom%2A>
- <xref:System.Windows.Controls.Canvas.Left%2A>
- <xref:System.Windows.Controls.Canvas.Right%2A>
- <xref:System.Windows.Controls.Canvas.Top%2A>
- <xref:System.Windows.Controls.Button>
- [Общие сведения о панелях](panels-overview.md)
- [Практические руководства](canvas-how-to-topics.md)
- [Общие сведения о вложенных свойствах зависимостей](../advanced/attached-properties-overview.md)
