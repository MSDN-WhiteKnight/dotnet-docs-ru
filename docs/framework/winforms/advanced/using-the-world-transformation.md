---
title: Использование объемного преобразования
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- graphics [Windows Forms], world transformation
- world transformation [Windows Forms], examples
ms.assetid: 1e717711-1361-448e-aa49-0f3ec43110c9
ms.openlocfilehash: f40d7e8cb814344365e8b88c2659751903b79d77
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59139962"
---
# <a name="using-the-world-transformation"></a>Использование объемного преобразования
Мировое преобразование — это свойство <xref:System.Drawing.Graphics> класса. Числа, определяющие мировое преобразование хранятся в <xref:System.Drawing.Drawing2D.Matrix> объект, представляющий матрицу 3 × 3. <xref:System.Drawing.Drawing2D.Matrix> И <xref:System.Drawing.Graphics> классы имеют различные методы для установки числа в матрицу мирового преобразования.  
  
## <a name="different-types-of-transformations"></a>Различные типы преобразований  
 В следующем примере код сначала создает прямоугольник 50 × 50 и помещает его в точку начала координат (0, 0). Начало координат находится в левом верхнем углу клиентской области.  
  
 [!code-csharp[System.Drawing.MiscLegacyTopics#11](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Drawing.MiscLegacyTopics/CS/Class1.cs#11)]
   
  
 Следующий код применяет преобразование масштабирования, который расширяет прямоугольник, соотношение 1,75 по оси x и к прямоугольнику с коэффициентом 0,5 по оси y:  
  
 [!code-csharp[System.Drawing.MiscLegacyTopics#12](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Drawing.MiscLegacyTopics/CS/Class1.cs#12)]
   
  
 Результатом является прямоугольник, который больше времени по оси x и короче по оси y исходного.  
  
 Чтобы повернуть прямоугольник вместо его масштабирования, используйте следующий код:  
  
 [!code-csharp[System.Drawing.MiscLegacyTopics#13](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Drawing.MiscLegacyTopics/CS/Class1.cs#13)]
   
  
 Чтобы преобразовать прямоугольник, используйте следующий код:  
  
 [!code-csharp[System.Drawing.MiscLegacyTopics#14](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Drawing.MiscLegacyTopics/CS/Class1.cs#14)]
   
  
## <a name="see-also"></a>См. также

- <xref:System.Drawing.Drawing2D.Matrix>
- [Системы координат и преобразования](coordinate-systems-and-transformations.md)
- [Использование преобразований в управляемом GDI+](using-transformations-in-managed-gdi.md)
