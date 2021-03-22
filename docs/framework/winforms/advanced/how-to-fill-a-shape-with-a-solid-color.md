---
title: Практическое руководство. Заливка фигуры сплошным цветом
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- colors [Windows Forms], adding to shapes
- shapes [Windows Forms], filling
ms.assetid: 06088b31-bac9-4ef3-9ebe-06c2c764d6df
ms.openlocfilehash: d6fe7a252029ff80f21d99f7342fabb1d29fbe24
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59211677"
---
# <a name="how-to-fill-a-shape-with-a-solid-color"></a>Практическое руководство. Заливка фигуры сплошным цветом
Чтобы заливка фигуры сплошным цветом, создайте <xref:System.Drawing.SolidBrush> , а затем передать, <xref:System.Drawing.SolidBrush> объект в качестве аргумента одному из методов заливки класса <xref:System.Drawing.Graphics> класса. В следующем примере показано, как заливка эллипса красный цвет.  
  
## <a name="example"></a>Пример  
 В следующем коде <xref:System.Drawing.SolidBrush.%23ctor%2A> конструктор принимает <xref:System.Drawing.Color> объект в качестве единственного аргумента. Значения, используемые <xref:System.Drawing.Color.FromArgb%2A> метод представляют альфа, красного, зеленого и синего компонентов цвета. Каждое из этих значений должен быть в диапазоне от 0 до 255. Первое число 255 означает, что цвет — полностью непрозрачный и второй 255 указывает, что красный компонент является полная насыщенность. Два нуля означает, что зеленый и синий компоненты равна 0.  
  
 Четыре цифры (0, 0, 100, 60), передаваемый <xref:System.Drawing.Graphics.FillEllipse%2A> метод укажите расположение и размер прямоугольника, ограничивающего эллипса. Прямоугольник имеет в левом верхнем углу (0, 0), шириной 100, а высота — 60.  
  
 [!code-csharp[System.Drawing.UsingABrush#11](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Drawing.UsingABrush/CS/Class1.cs#11)]
   
  
## <a name="compiling-the-code"></a>Компиляция кода  
 Предыдущий пример предназначен для работы с Windows Forms и требует <xref:System.Windows.Forms.PaintEventArgs> `e`, который является параметром <xref:System.Windows.Forms.Control.Paint> обработчик событий.  
  
## <a name="see-also"></a>См. также

- [Использование кисти для заливки фигур](using-a-brush-to-fill-shapes.md)
