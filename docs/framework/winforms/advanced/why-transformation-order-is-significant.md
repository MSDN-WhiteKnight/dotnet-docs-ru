---
title: Значение порядка преобразований
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- transformations [Windows Forms], order significance
ms.assetid: 37d5f9dc-a5cf-4475-aa5d-34d714e808a9
ms.openlocfilehash: 4a65e588984241affea3083810b4901266480ea4
ms.sourcegitcommit: 160a88c8087b0e63606e6e35f9bd57fa5f69c168
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/09/2019
ms.locfileid: "57710398"
---
# <a name="why-transformation-order-is-significant"></a>Значение порядка преобразований
Один <xref:System.Drawing.Drawing2D.Matrix> объект может хранить одно преобразование, либо последовательность преобразований. Второй называется составным преобразованием. Матрица составного преобразования получается путем перемножения матриц отдельных преобразований.  
  
## <a name="composite-transform-examples"></a>Примеры составных преобразований  
 Составное преобразование важен порядок отдельных преобразований. Например если сначала повернуть, а затем масштабирование, а затем преобразовать, возвращается другой результат не Если вы сначала выполнить преобразование, поворот, а затем масштабирование. В [!INCLUDE[ndptecgdiplus](../../../../includes/ndptecgdiplus-md.md)], построение составных преобразований в направлении слева направо. Если S, R и T являются матрицы масштабирования, вращения и перемещения, соответственно, затем продукта SRT (в таком порядке) приводится матрица составного преобразования, которое сначала масштабирует, затем поворачивает, а затем преобразует. Матрицы продукта SRT отличается от матрицы TRS продукта.  
  
 Одна из причин важен порядок — что преобразования как поворот и масштабирование выполняются относительно начала координат. Масштабирование объекта, который выравнивается по центру в начале координат дает другой результат, чем масштабирование объекта, который был перемещен из начала координат. Аналогично поворот объекта, который выравнивается по центру в начале координат выдает различный результат от поворота объекта, который был перемещен из начала координат.  
  
 В следующем примере объединяются масштабирования, вращения и перемещения (в таком порядке) для формирования составного преобразования. Аргумент <xref:System.Drawing.Drawing2D.MatrixOrder.Append> передается <xref:System.Drawing.Graphics.RotateTransform%2A> метод указывает, что поворот будет выполняться масштабирование. Аналогично аргумент <xref:System.Drawing.Drawing2D.MatrixOrder.Append> передается <xref:System.Drawing.Graphics.TranslateTransform%2A> метод указывает, что перевод последует поворот. <xref:System.Drawing.Drawing2D.MatrixOrder.Append> и <xref:System.Drawing.Drawing2D.MatrixOrder.Prepend> являются членами <xref:System.Drawing.Drawing2D.MatrixOrder> перечисления.  
  
 [!code-csharp[System.Drawing.MiscLegacyTopics#21](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Drawing.MiscLegacyTopics/CS/Class1.cs#21)]
 [!code-vb[System.Drawing.MiscLegacyTopics#21](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Drawing.MiscLegacyTopics/VB/Class1.vb#21)]  
  
 В следующем примере создается те же вызовы методов, что и в предыдущем примере, но изменять порядок вызовов. Полученный порядок операций сначала перевести, затем поворот, шкала, которая дает очень другой результат, масштабирование, повернуть, а затем перевести.  
  
 [!code-csharp[System.Drawing.MiscLegacyTopics#22](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Drawing.MiscLegacyTopics/CS/Class1.cs#22)]
 [!code-vb[System.Drawing.MiscLegacyTopics#22](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Drawing.MiscLegacyTopics/VB/Class1.vb#22)]  
  
 Чтобы изменить порядок последовательности вызовов методов является одним из способов изменения направления отдельных преобразований, составное преобразование. Второй способ управления порядком операций является изменение порядка следования матриц. Следующий пример является таким же, как в предыдущем примере, за исключением случаев, <xref:System.Drawing.Drawing2D.MatrixOrder.Append> было изменено на <xref:System.Drawing.Drawing2D.MatrixOrder.Prepend>. Умножение матриц осуществляется в порядке SRT, где S, R и T являются матрицами масштабирования, поворота и сдвига соответственно. Порядок составного преобразования сначала осуществляется масштабирование, затем поворот, затем сдвиг.  
  
 [!code-csharp[System.Drawing.MiscLegacyTopics#23](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Drawing.MiscLegacyTopics/CS/Class1.cs#23)]
 [!code-vb[System.Drawing.MiscLegacyTopics#23](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Drawing.MiscLegacyTopics/VB/Class1.vb#23)]  
  
 Результат предыдущего примера одинаков в результате в первом примере в этом разделе. Это обусловлено тем, были изменены на обратный порядок вызовов методов и порядок перемножения матрицы.  
  
## <a name="see-also"></a>См. также

- <xref:System.Drawing.Drawing2D.Matrix>
- [Системы координат и преобразования](coordinate-systems-and-transformations.md)
- [Использование преобразований в управляемом GDI+](using-transformations-in-managed-gdi.md)
