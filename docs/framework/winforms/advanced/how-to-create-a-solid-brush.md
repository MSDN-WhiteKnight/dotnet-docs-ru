---
title: Практическое руководство. Создание сплошной кисти
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- solid color brushes
- brushes [Windows Forms], examples
- brushes [Windows Forms], creating solid
ms.assetid: 85c3fe7d-fb1d-4591-8a9f-d75b556b90af
ms.openlocfilehash: ed9ec1f52b41c83b3cc6e36dedf97f1c00db42e6
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59213445"
---
# <a name="how-to-create-a-solid-brush"></a>Практическое руководство. Создание сплошной кисти
В этом примере создается <xref:System.Drawing.SolidBrush> объект, который может использоваться <xref:System.Drawing.Graphics> для заливки фигур.  
  
## <a name="example"></a>Пример  
 
 [!code-csharp[System.Drawing.ConceptualHowTos#1](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Drawing.ConceptualHowTos/CS/form1.cs#1)]
   
  
## <a name="robust-programming"></a>Отказоустойчивость  
 После окончания их использования, необходимо вызвать <xref:System.IDisposable.Dispose%2A> на объекты, которые потребляют системные ресурсы, такие как объекты кисти.  
  
## <a name="see-also"></a>См. также

- <xref:System.Drawing.SolidBrush>
- <xref:System.Drawing.Brush>
- [Приступая к программированию графики](getting-started-with-graphics-programming.md)
- [Кисти и закрашенные фигуры в GDI+](brushes-and-filled-shapes-in-gdi.md)
- [Использование кисти для заливки фигур](using-a-brush-to-fill-shapes.md)
