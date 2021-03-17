---
title: Отрисовка элементов управления Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- custom controls [Windows Forms], rendering
- OnPaintBackground method [Windows Forms], invoking in Windows Forms custom controls
- custom controls [Windows Forms], graphics resources
- custom controls [Windows Forms], invalidation and painting
ms.assetid: aae8e1e6-4786-432b-a15e-f4c44760d302
ms.openlocfilehash: 8de87e17d1baedccfe18bfded3ccab7ab59f0a09
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59125688"
---
# <a name="rendering-a-windows-forms-control"></a>Отрисовка элементов управления Windows Forms
Визуализации — это процесс создания визуального представления на экране пользователя. Windows Forms используется [!INCLUDE[ndptecgdi](../../../../includes/ndptecgdi-md.md)] (новая Windows графическая библиотека) для подготовки к просмотру. Управляемые классы, предоставляющие доступ к [!INCLUDE[ndptecgdi](../../../../includes/ndptecgdi-md.md)] в <xref:System.Drawing?displayProperty=nameWithType> пространства имен и его подпространства имен.  
  
 Следующие элементы участвуют в отрисовке элемента управления.  
  
-   Рисования функциональных возможностях, предоставляемых базовым классом <xref:System.Windows.Forms.Control?displayProperty=nameWithType>.  
  
-   Основные [!INCLUDE[ndptecgdi](../../../../includes/ndptecgdi-md.md)] графической библиотеки.  
  
-   Геометрия области рисования.  
  
-   Процедура освобождения графических ресурсов.  
  
## <a name="drawing-functionality-provided-by-control"></a>Функции рисования, обеспечиваемые элементом управления  
 Базовый класс <xref:System.Windows.Forms.Control> предоставляет функциональные возможности рисования посредством его <xref:System.Windows.Forms.Control.Paint> событий. Элемент управления вызывает <xref:System.Windows.Forms.Control.Paint> событие при каждой попытке обновления его отображения. Дополнительные сведения о событиях в .NET Framework, см. в разделе [обработка и вызов событий](../../../standard/events/index.md).  
  
 Класс данных события для <xref:System.Windows.Forms.Control.Paint> событий, <xref:System.Windows.Forms.PaintEventArgs>, содержащий данные, необходимые для рисования элемента управления — дескриптора графический объект и объект прямоугольник, представляющий область для рисования. Эти объекты отображаются в полужирным шрифтом в следующем фрагменте кода.  
  
```vb  
Public Class PaintEventArgs  
   Inherits EventArgs  
   Implements IDisposable  
  
   Public ReadOnly Property ClipRectangle() As System.Drawing.Rectangle  
      ...  
   End Property  
  
   Public ReadOnly Property Graphics() As System.Drawing.Graphics  
      ...  
   End Property  
   ' Other properties and methods.  
   ...  
End Class  
```  
  
```csharp  
public class PaintEventArgs : EventArgs, IDisposable {  
public System.Drawing.Rectangle ClipRectangle {get;}  
public System.Drawing.Graphics Graphics {get;}  
// Other properties and methods.  
...  
}  
```  
  
 <xref:System.Drawing.Graphics> — Это управляемый класс, инкапсулирующий функциональность рисования, как описано в разделе, [!INCLUDE[ndptecgdi](../../../../includes/ndptecgdi-md.md)] далее в этом разделе. <xref:System.Windows.Forms.PaintEventArgs.ClipRectangle%2A> Является экземпляром класса <xref:System.Drawing.Rectangle> структурировать и определяет доступные области, в котором можно нарисовать элемент управления. Разработчик элемента управления можно рассчитать <xref:System.Windows.Forms.PaintEventArgs.ClipRectangle%2A> с помощью <xref:System.Windows.Forms.PaintEventArgs.ClipRectangle%2A> свойства элемента управления, как описано в описании геометрии далее в этом разделе.  
  
 Элемент управления должен предоставить логику отрисовки путем переопределения <xref:System.Windows.Forms.Control.OnPaint%2A> метод, который наследует от <xref:System.Windows.Forms.Control>. <xref:System.Windows.Forms.Control.OnPaint%2A> Получает доступ к графический объект и прямоугольника для рисования с помощью <xref:System.Drawing.Design.PaintValueEventArgs.Graphics%2A> и <xref:System.Windows.Forms.PaintEventArgs.ClipRectangle%2A> свойства <xref:System.Windows.Forms.PaintEventArgs> переданным ему экземпляром.  
  
```vb  
Protected Overridable Sub OnPaint(pe As PaintEventArgs)  
```  
  
```csharp  
protected virtual void OnPaint(PaintEventArgs pe);  
```  
  
 <xref:System.Windows.Forms.Control.OnPaint%2A> Метод базового <xref:System.Windows.Forms.Control> класс не реализует какой-либо функциональности, но просто вызывает делегаты событий, зарегистрированные в <xref:System.Windows.Forms.Control.Paint> событий. При переопределении <xref:System.Windows.Forms.Control.OnPaint%2A>, как правило, следует вызвать <xref:System.Windows.Forms.Control.OnPaint%2A> получать метод базового класса, чтобы зарегистрированные делегаты <xref:System.Windows.Forms.Control.Paint> событий. Тем не менее, элементы управления, их всю поверхность рисования не следует вызывать базовый класс <xref:System.Windows.Forms.Control.OnPaint%2A>, как это вызовет мерцание. Пример переопределения <xref:System.Windows.Forms.Control.OnPaint%2A> событий, см. в разделе [как: Создание элемента управления Windows Forms, показывающего прогресс](how-to-create-a-windows-forms-control-that-shows-progress.md).  
  
> [!NOTE]
>  Они не вызывают <xref:System.Windows.Forms.Control.OnPaint%2A> непосредственно из вашего элемента управления; вместо этого вызовите <xref:System.Windows.Forms.Control.Invalidate%2A> метод (наследуется от <xref:System.Windows.Forms.Control>) или другим методом, который вызывает <xref:System.Windows.Forms.Control.Invalidate%2A>. <xref:System.Windows.Forms.Control.Invalidate%2A> В свою очередь вызывает метод <xref:System.Windows.Forms.Control.OnPaint%2A>. <xref:System.Windows.Forms.Control.Invalidate%2A> Метод перегружен, и, в зависимости от аргументов предоставляемое <xref:System.Windows.Forms.Control.Invalidate%2A> `e`, перерисовывает элемент управления, некоторые или все его области экрана.  
  
 Базовый <xref:System.Windows.Forms.Control> класс определяет другой метод, который используется для рисования — <xref:System.Windows.Forms.Control.OnPaintBackground%2A> метод.  
  
```vb  
Protected Overridable Sub OnPaintBackground(pevent As PaintEventArgs)  
```  
  
```csharp  
protected virtual void OnPaintBackground(PaintEventArgs pevent);  
```  
  
 <xref:System.Windows.Forms.Control.OnPaintBackground%2A> Закрашивает фон (и тем самым фигуры) окна и гарантированно будет выполняться быстро, при <xref:System.Windows.Forms.Control.OnPaint%2A> рисует детали и могут работать медленнее, так как индивидуальные запросы на рисование объединены в один <xref:System.Windows.Forms.Control.Paint> событие, которое охватывает все области, которые должны быть перерисовки. Может возникнуть необходимость вызвать <xref:System.Windows.Forms.Control.OnPaintBackground%2A> Если, к примеру, требуется нарисовать градиентной заливкой фон для элемента управления.  
  
 Хотя <xref:System.Windows.Forms.Control.OnPaintBackground%2A> имеет аналогичное номенклатуру и принимает того же аргумента как `OnPaint` метода <xref:System.Windows.Forms.Control.OnPaintBackground%2A> не является методом значение true, событие. Существует не `PaintBackground` событий и <xref:System.Windows.Forms.Control.OnPaintBackground%2A> вызывает делегаты событий. При переопределении метода <xref:System.Windows.Forms.Control.OnPaintBackground%2A> метода производного класса не требуется для вызова <xref:System.Windows.Forms.Control.OnPaintBackground%2A> метод базового класса.  
  
## <a name="gdi-basics"></a>Основные сведения о GDI +  
 <xref:System.Drawing.Graphics> Класс предоставляет методы для рисования различных фигур, таких как круги, треугольники, дуги и эллипсы, а также методы для отображения текста. <xref:System.Drawing?displayProperty=nameWithType> Пространство имен и его подпространства имен содержат классы, инкапсулирующие графические элементы, такие как фигуры (круги, прямоугольники, дуги и другие), цвета, шрифты, кистей и т. д. Дополнительные сведения о [!INCLUDE[ndptecgdi](../../../../includes/ndptecgdi-md.md)], см. в разделе [использование управляемых графических классов](../advanced/using-managed-graphics-classes.md). Основы [!INCLUDE[ndptecgdi](../../../../includes/ndptecgdi-md.md)] также описаны в [как: Создание элемента управления Windows Forms, показывающего прогресс](how-to-create-a-windows-forms-control-that-shows-progress.md).  
  
## <a name="geometry-of-the-drawing-region"></a>Геометрия области рисования  
 <xref:System.Windows.Forms.Control.ClientRectangle%2A> Свойства элемента управления задает прямоугольную область, доступную для элемента управления на экране пользователя, хотя <xref:System.Windows.Forms.PaintEventArgs.ClipRectangle%2A> свойство <xref:System.Windows.Forms.PaintEventArgs> задает область, которая фактически закрашивается. (Помните, что рисование выполняется в <xref:System.Windows.Forms.Control.Paint> событие метода, принимающего <xref:System.Windows.Forms.PaintEventArgs> экземпляр в качестве аргумента). Элемент управления может потребоваться рисовать только часть ее доступной области, как в случае изменения отображения элемента управления при небольшом разделе. В этих случаях разработчик элемента управления следует вычислять фактическое прямоугольника для рисования и передать его <xref:System.Windows.Forms.Control.Invalidate%2A>. Перегруженные версии <xref:System.Windows.Forms.Control.Invalidate%2A> , принимающих <xref:System.Drawing.Rectangle> или <xref:System.Drawing.Region> в качестве аргумента, используют этот аргумент для создания <xref:System.Windows.Forms.PaintEventArgs.ClipRectangle%2A> свойство <xref:System.Windows.Forms.PaintEventArgs>.  
  
 В следующем фрагменте кода показано как `FlashTrackBar` прямоугольную область для рисования вычисляет пользовательского элемента управления. `client` Обозначает переменную <xref:System.Windows.Forms.PaintEventArgs.ClipRectangle%2A> свойство. Полный пример см. в разделе [как: Создание элемента управления Windows Forms, показывающего прогресс](how-to-create-a-windows-forms-control-that-shows-progress.md).  
  
 [!code-csharp[System.Windows.Forms.FlashTrackBar#6](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.FlashTrackBar/CS/FlashTrackBar.cs#6)]
 [!code-vb[System.Windows.Forms.FlashTrackBar#6](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Windows.Forms.FlashTrackBar/VB/FlashTrackBar.vb#6)]  
  
## <a name="freeing-graphics-resources"></a>Освобождение ресурсов графики  
 Графические объекты ресурсоемки, потому что они используют системные ресурсы. Такие объекты содержат экземпляры <xref:System.Drawing.Graphics?displayProperty=nameWithType> класса, а также экземпляры <xref:System.Drawing.Brush?displayProperty=nameWithType>, <xref:System.Drawing.Pen?displayProperty=nameWithType>и другие графические классы. Очень важно, создания ресурса графики, только в том случае, когда она необходима и отпустите его сразу после его использования. Если вы создаете тип, реализующий <xref:System.IDisposable> интерфейс, вызовите его <xref:System.IDisposable.Dispose%2A> метод, когда вы закончите с ним для освобождения ресурсов.  
  
 В следующем фрагменте кода показано как `FlashTrackBar` пользовательский элемент управления создает и освобождает <xref:System.Drawing.Brush> ресурсов. Полный исходный код, см. в разделе [как: Создание элемента управления Windows Forms, показывающего прогресс](how-to-create-a-windows-forms-control-that-shows-progress.md).  
  
 [!code-csharp[System.Windows.Forms.FlashTrackBar#5](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.FlashTrackBar/CS/FlashTrackBar.cs#5)]
 [!code-vb[System.Windows.Forms.FlashTrackBar#5](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Windows.Forms.FlashTrackBar/VB/FlashTrackBar.vb#5)]  
  
 [!code-csharp[System.Windows.Forms.FlashTrackBar#4](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.FlashTrackBar/CS/FlashTrackBar.cs#4)]
 [!code-vb[System.Windows.Forms.FlashTrackBar#4](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Windows.Forms.FlashTrackBar/VB/FlashTrackBar.vb#4)]  
  
 [!code-csharp[System.Windows.Forms.FlashTrackBar#3](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.FlashTrackBar/CS/FlashTrackBar.cs#3)]
 [!code-vb[System.Windows.Forms.FlashTrackBar#3](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Windows.Forms.FlashTrackBar/VB/FlashTrackBar.vb#3)]  
  
## <a name="see-also"></a>См. также

- [Практическое руководство. Создание элемента управления, показывающего прогресс в форме Windows Forms](how-to-create-a-windows-forms-control-that-shows-progress.md)
