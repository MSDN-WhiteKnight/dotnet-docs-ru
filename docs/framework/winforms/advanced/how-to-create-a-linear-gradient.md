---
title: Практическое руководство. Создание линейного градиента
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- linear gradients [Windows Forms], creating
- gradients [Windows Forms], creating linear
- colors [Windows Forms], creating linear gradients
- gradients
ms.assetid: 6c88e1cc-1217-4399-ac12-cb37592b9f01
ms.openlocfilehash: 540b6d422be5d5c0898f019592a755258145d14d
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59125025"
---
# <a name="how-to-create-a-linear-gradient"></a>Практическое руководство. Создание линейного градиента
[!INCLUDE[ndptecgdiplus](../../../../includes/ndptecgdiplus-md.md)] поддерживает горизонтальные, вертикальные и диагональные линейные градиенты. По умолчанию цвет в линейном градиенте меняется равномерно. Тем не менее можно настроить линейный градиент, таким образом, чтобы цвет меняется образом неоднородной.  
  
 В следующем примере заполняется линии, эллипсы и прямоугольник с горизонтальной кисти линейного градиента.  
  
 <xref:System.Drawing.Drawing2D.LinearGradientBrush.%23ctor%2A> Конструктор принимает четыре аргумента: две точки и два цвета. Первая точка (0, 10) связан с первый цвет (красный цвет), и второй точки (200, 10) связан со вторым цветом (синий). Как и следовало ожидать, линии, соединяющей (0, 10) для (200, 10) плавно меняется от красного к синему.  
  
 Вторые точек (50, 10) и (200, 10), не важны. Важно то, что две точки имеют одну координату второй — соединительных линий по горизонтали. Эллипс и прямоугольника также постепенно меняются от красного к синему как горизонтальные координаты от 0 до 200.  
  
 Ниже показаны строки, эллипс и прямоугольник. Обратите внимание на то, что цвет градиента, повторяет саму себя как горизонтальная координата выйдет за пределы 200.  
  
 ![Линейный градиент](./media/cslineargradient1.png "cslineargradient1")  
  
### <a name="to-use-horizontal-linear-gradients"></a>Использование горизонтальных линейных градиентов  
  
-   Передайте непрозрачный синий, красный и непрозрачный как третий и четвертый аргумент, соответственно.  
  
     [!code-csharp[System.Drawing.UsingaGradientBrush#21](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Drawing.UsingaGradientBrush/CS/Class1.cs#21)]
     [!code-vb[System.Drawing.UsingaGradientBrush#21](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Drawing.UsingaGradientBrush/VB/Class1.vb#21)]  
  
 В предыдущем примере цветовые компоненты линейно меняются при переходе из горизонтальную координату 0 горизонтальную координату 200. Например точки, в которых первая координата на равном расстоянии от 0 до 200 будет иметь синего компонента, который находится на равном расстоянии от 0 до 255.  
  
 [!INCLUDE[ndptecgdiplus](../../../../includes/ndptecgdiplus-md.md)] позволяет настраивать цвет меняется в зависимости от одного края градиент другой способ изменения. Предположим, что вы хотите создать градиентную кисть, которая изменяется от черного к красному согласно следующей таблице.  
  
|Горизонтальная координата|RGB компонентов|  
|---------------------------|--------------------|  
|0|(0, 0, 0)|  
|40|(128, 0, 0)|  
|200|(255, 0, 0)|  
  
 Обратите внимание, что красный компонент имеет половинную интенсивность, когда горизонтальная координата представляет только 20 процентов пути от 0 до 200.  
  
 В следующем примере задается <xref:System.Drawing.Drawing2D.LinearGradientBrush.Blend%2A> свойство <xref:System.Drawing.Drawing2D.LinearGradientBrush> объект должен быть сопоставлен три относительный интенсивности три относительные позиции. Как и в предыдущей таблице относительная интенсивность 0,5, связанный с относительное положение 0,2. Код заполняет эллипса и прямоугольник с градиентной кисти.  
  
 Ниже показан окончательный вид эллипса и прямоугольника.  
  
 ![Линейный градиент](./media/cslineargradient2.png "cslineargradient2")  
  
### <a name="to-customize-linear-gradients"></a>Настройка линейных градиентов  
  
-   Передайте непрозрачный черный и непрозрачный красный как третий и четвертый аргумент, соответственно.  
  
     [!code-csharp[System.Drawing.UsingaGradientBrush#22](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Drawing.UsingaGradientBrush/CS/Class1.cs#22)]
     [!code-vb[System.Drawing.UsingaGradientBrush#22](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Drawing.UsingaGradientBrush/VB/Class1.vb#22)]  
  
 Градиенты в предыдущих примерах были по горизонтали; то есть цвет постепенно изменяется при переходе по любой горизонтальной линии. Можно также определить вертикальные и диагональные градиенты.  
  
 В следующем примере передается точки (0, 0) и (200, 100), чтобы <xref:System.Drawing.Drawing2D.LinearGradientBrush.%23ctor%2A> конструктор. Связан синий цвет (0, 0) и зеленый цвет, связанные с (200, 100). Строки (с помощью пера шириной 10) и эллипс заполняются кисти линейного градиента.  
  
 Ниже показаны строки, а также эллипса. Обратите внимание, что цвет эллипса постепенно при переходе по любой строке, — параллельное выполнение на строку, обрабатываемым (0, 0) и (200, 100).  
  
 ![Линейный градиент](./media/cslineargradient3.png "cslineargradient3")  
  
### <a name="to-create-diagonal-linear-gradients"></a>Чтобы создать диагональный линейным градиентом  
  
-   Передайте непрозрачный синий и непрозрачный зеленый как третий и четвертый аргумент, соответственно.  
  
     [!code-csharp[System.Drawing.UsingaGradientBrush#23](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Drawing.UsingaGradientBrush/CS/Class1.cs#23)]
     [!code-vb[System.Drawing.UsingaGradientBrush#23](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Drawing.UsingaGradientBrush/VB/Class1.vb#23)]  
  
## <a name="see-also"></a>См. также

- [Заливка фигур с помощью градиентной кисти](using-a-gradient-brush-to-fill-shapes.md)
- [Объекты Graphics и Drawing в Windows Forms](graphics-and-drawing-in-windows-forms.md)
