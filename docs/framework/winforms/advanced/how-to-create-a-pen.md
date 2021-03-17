---
title: Практическое руководство. Создание пера
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- graphics [Windows Forms], creating pens
- pens [Windows Forms], creating
- Pen object
ms.assetid: 7fbea8b7-7ac1-4413-9c17-733a850381e3
ms.openlocfilehash: 69fe6157c710ae63df9dbf391a5d355d1c3f9765
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59148113"
---
# <a name="how-to-create-a-pen"></a>Практическое руководство. Создание пера
В этом примере создается <xref:System.Drawing.Pen> объекта.  
  
## <a name="example"></a>Пример  
 [!code-cpp[System.Drawing.ConceptualHowTos#3](~/samples/snippets/cpp/VS_Snippets_Winforms/System.Drawing.ConceptualHowTos/cpp/form1.cpp#3)]
 [!code-csharp[System.Drawing.ConceptualHowTos#3](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Drawing.ConceptualHowTos/CS/form1.cs#3)]
 [!code-vb[System.Drawing.ConceptualHowTos#3](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Drawing.ConceptualHowTos/VB/form1.vb#3)]  
  
## <a name="robust-programming"></a>Отказоустойчивость  
 После завершения использования объектов, которые потребляют системные ресурсы, такие как <xref:System.Drawing.Pen> объектов, необходимо вызвать <xref:System.Drawing.Pen.Dispose%2A> на них.  
  
## <a name="see-also"></a>См. также

- <xref:System.Drawing.Pen>
- [Приступая к программированию графики](getting-started-with-graphics-programming.md)
- [Перья, линии и прямоугольники в GDI+](pens-lines-and-rectangles-in-gdi.md)
