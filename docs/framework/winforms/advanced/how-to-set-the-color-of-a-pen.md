---
title: Практическое руководство. Установка цвета пера
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- pens [Windows Forms], setting color
- colored pens
ms.assetid: a9df06f9-a6d5-4d9b-a2d1-583943540775
ms.openlocfilehash: dc067f5a131951bf3af7adc68e11b948d40fc0ca
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59213419"
---
# <a name="how-to-set-the-color-of-a-pen"></a>Практическое руководство. Установка цвета пера
В этом примере изменяется цвет в существующем <xref:System.Drawing.Pen> объекта  
  
## <a name="example"></a>Пример  
 [!code-cpp[System.Drawing.ConceptualHowTos#9](~/samples/snippets/cpp/VS_Snippets_Winforms/System.Drawing.ConceptualHowTos/cpp/form1.cpp#9)]
 [!code-csharp[System.Drawing.ConceptualHowTos#9](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Drawing.ConceptualHowTos/CS/form1.cs#9)]
   
  
## <a name="compiling-the-code"></a>Компиляция кода  
 Для этого примера требуются:  
  
-   Объект <xref:System.Drawing.Pen> объект с именем `myPen`.  
  
## <a name="robust-programming"></a>Отказоустойчивость  
 Следует вызывать <xref:System.Drawing.Pen.Dispose%2A> на какие объекты используют системные ресурсы (такие как <xref:System.Drawing.Pen> объекты) после завершения их использования.  
  
## <a name="see-also"></a>См. также

- <xref:System.Drawing.Pen>
- [Приступая к программированию графики](getting-started-with-graphics-programming.md)
- [Практическое руководство. Создание пера](how-to-create-a-pen.md)
- [Рисование линий и фигур с помощью пера](using-a-pen-to-draw-lines-and-shapes.md)
- [Перья, линии и прямоугольники в GDI+](pens-lines-and-rectangles-in-gdi.md)
