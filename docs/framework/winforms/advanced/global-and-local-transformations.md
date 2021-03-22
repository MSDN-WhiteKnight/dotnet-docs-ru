---
title: Глобальные и локальные преобразования
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- matrices [Windows Forms], using transformations
- transformations [Windows Forms], global
- transformations [Windows Forms], local
ms.assetid: b601d66d-d572-4f11-9d2e-92f0dc8893f3
ms.openlocfilehash: e4ed103e781cc2e59d62c11f3233357c77b81cb9
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59213757"
---
# <a name="global-and-local-transformations"></a>Глобальные и локальные преобразования
Глобальное преобразование — это преобразование, применяемое к каждому элементу, рисуемой элементом заданного <xref:System.Drawing.Graphics> объекта. Напротив локальное преобразование — это преобразование, применяемое к конкретному элементу для отрисовки.  
  
## <a name="global-transformations"></a>Глобальные преобразования  
 Чтобы создать глобальное преобразование, сконструировать <xref:System.Drawing.Graphics> объекта и обработки его <xref:System.Drawing.Graphics.Transform%2A> свойство. <xref:System.Drawing.Graphics.Transform%2A> Свойство <xref:System.Drawing.Drawing2D.Matrix> объекта, поэтому он может содержать любую последовательность аффинных преобразований. Преобразование, заданное <xref:System.Drawing.Graphics.Transform%2A> свойство называется мировое преобразование. <xref:System.Drawing.Graphics> Класс предоставляет несколько методов для построения составного мировое преобразование: <xref:System.Drawing.Graphics.MultiplyTransform%2A>, <xref:System.Drawing.Graphics.RotateTransform%2A>, <xref:System.Drawing.Graphics.ScaleTransform%2A>, и <xref:System.Drawing.Graphics.TranslateTransform%2A>. В следующем примере рисуется эллипс дважды: один раз, перед созданием мировое преобразование и один раз после. Преобразование сначала масштабируется с коэффициентом 0,5 по оси y, а затем преобразует 50 единиц по оси x и затем поворачивается на 30 градусов.  
  
 [!code-csharp[System.Drawing.CoordinateSystems#21](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Drawing.CoordinateSystems/CS/Class1.cs#21)]
   
  
 На следующем рисунке изображены матрицы преобразования.  
  
 ![Преобразования](./media/aboutgdip05-art14.gif "AboutGdip05_art14")  
  
> [!NOTE]
>  В приведенном выше примере эллипс поворачивается вокруг точки отсчета в систему координат, которая находится в левом верхнем углу клиентской области. В результате получается другой результат, чем поворот эллипса относительно его собственного центра.  
  
## <a name="local-transformations"></a>Локальные преобразования  
 Локальное преобразование применяется к конкретному элементу для отрисовки. Например <xref:System.Drawing.Drawing2D.GraphicsPath> объект имеет <xref:System.Drawing.Drawing2D.GraphicsPath.Transform%2A> метод, который позволяет превращать точки данных этого пути. В следующем примере рисуется прямоугольник без преобразований и путь, содержащий преобразование поворота. (Предполагается, что имеется не мировое преобразование).  
  
 [!code-csharp[System.Drawing.CoordinateSystems#22](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Drawing.CoordinateSystems/CS/Class1.cs#22)]
   
  
 Вы можете объединить мировое преобразование локального преобразования позволяет получать различные результаты. Например можно использовать мировое преобразование координат и использовать локальные преобразования для поворота и масштабирования объектов, нарисованных на новую систему координат.  
  
 Предположим, требуется, чтобы в системе координат с его происхождения 200 пикселей от левого края клиентской области и 150 пикселей от верхнего края клиентской области. Кроме того Предположим, что в единицы измерения должна использоваться точка, ось x вправо, а ось y, указывающая вверх. Система координат по умолчанию имеет ось y направлена вниз, поэтому вам нужно выполнить отражение относительно горизонтальной оси. Ниже показана матрица такое отражение.  
  
 ![Преобразования](./media/aboutgdip05-art15.gif "AboutGdip05_art15")  
  
 Затем Предположим, что необходимо выполнить сдвиг вправо 200 единиц и 150 единицы работы.  
  
 Следующий пример устанавливает систему координат, описанное заданием мировое преобразование объекта <xref:System.Drawing.Graphics> объекта.  
  
 [!code-csharp[System.Drawing.CoordinateSystems#23](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Drawing.CoordinateSystems/CS/Class1.cs#23)]
   
  
 Следующий код (он размещен в конце предыдущего примера) создает путь, состоящий из одного прямоугольника, его нижнего левого угла, в начале координат новой системы координат. То прямоугольник заливается один раз без локального преобразований и один раз с применением локального преобразования. Локальное преобразование заключается горизонтального масштабирования с коэффициентом 2, а затем поворот на 30 градусов.  
  
 [!code-csharp[System.Drawing.CoordinateSystems#24](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Drawing.CoordinateSystems/CS/Class1.cs#24)]
   
  
 Ниже показан новый системы координат и двух прямоугольников.  
  
 ![Преобразования](./media/aboutgdip05-art16.gif "AboutGdip05_art16")  
  
## <a name="see-also"></a>См. также

- [Системы координат и преобразования](coordinate-systems-and-transformations.md)
- [Использование преобразований в управляемом GDI+](using-transformations-in-managed-gdi.md)
