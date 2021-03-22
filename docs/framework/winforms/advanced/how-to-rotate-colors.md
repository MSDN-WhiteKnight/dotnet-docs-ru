---
title: Практическое руководство. Циклический сдвиг цветов
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- colors [Windows Forms], rotating
- examples [Windows Forms], rotating colors
ms.assetid: e2e4c300-159c-4f4a-9b56-103b0f7cbc05
ms.openlocfilehash: 241d2824fc2d87a0505eb6e790c865bfa7d8ef90
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59175543"
---
# <a name="how-to-rotate-colors"></a>Практическое руководство. Циклический сдвиг цветов
Поворот в четырехмерный цветовом пространстве сложно представить. Мы можно упростить, если договориться сохранять один из компонентов цвета неизменным. Предположим, что требуется сохранить альфа-компонент, составляет 1 (полностью непрозрачный). Затем мы можете визуализировать трехмерное цветовое пространство с осями красного, зеленого и синего, как показано на следующем рисунке.  
  
 ![Рисунок, показывающий поворота оси красного, зеленого и синего.](./media/how-to-rotate-colors/rotation-red-green-blue-axes.gif)  
  
 Цвет может рассматриваться как точка в трехмерном пространстве. Например точка (1, 0, 0) в пространстве представляет красный цвет, а точки (0, 1, 0) в пространстве представляет зеленый цвет.  
  
 Ниже показан последствия поворот цвета (1, 0, 0) через угол 60 градусов в плоскости красный-зеленый. Поворот в плоскости плоскости красный-зеленый может рассматриваться как поворот относительно оси синий.  
  
 ![Рисунок, показывающий Поворот относительно оси синий.](./media/how-to-rotate-colors/rotation-about-blue-axis.gif)  
  
 Ниже показано, как создать матрицу цветов для выполнения поворотов о каждой из трех осей координат (красный, зеленый, синий):  
  
 ![Инициализируйте матрицы цветов для выполнения поворотов относительно трем осям.](./media/how-to-rotate-colors/rotation-about-three-axes.gif)  
  
## <a name="example"></a>Пример  
 В следующем примере выполняются изображения, только один цвет (1 0, 0.6) и применяет поворот на 60 градусов относительно оси синий. Угол поворота заметает плоскость, параллельную плоскости красный зеленый.  
  
 На следующем рисунке показано исходное изображение в левой части и преобразованное изображение справа:  
  
 ![Иллюстрацию исходное изображение, преобразованное изображение.](./media/how-to-rotate-colors/original-color-rotated-images.png)  
  
 На следующем рисунке показан поворот цвета, выполняемые в следующем коде:
  
 ![Рисунок, показывающий визуализации поворот цветов.](./media/how-to-rotate-colors/visualization-color-rotation.gif)  
  
 [!code-csharp[System.Drawing.RotateColors#1](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Drawing.RotateColors/CS/Form1.cs#1)]
   
  
## <a name="compiling-the-code"></a>Компиляция кода  
 Предыдущий пример предназначен для работы с Windows Forms и требует <xref:System.Windows.Forms.PaintEventArgs>`e`, который является параметром <xref:System.Windows.Forms.Control.Paint> обработчик событий. Замените `RotationInput.bmp` в вашей системе путь и имя файла изображения.  
  
## <a name="see-also"></a>См. также

- <xref:System.Drawing.Imaging.ColorMatrix>
- <xref:System.Drawing.Imaging.ImageAttributes>
- [Объекты Graphics и Drawing в Windows Forms](graphics-and-drawing-in-windows-forms.md)
- [Перекрашивание изображений](recoloring-images.md)
