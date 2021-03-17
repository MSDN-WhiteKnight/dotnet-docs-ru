---
title: Использование объектов DrawingVisual
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- visual layer [WPF], DrawingVisual objects
- DrawingVisual objects in visual layer [WPF]
ms.assetid: 0b4e711d-e640-40cb-81c3-8f5c59909b7d
ms.openlocfilehash: 01e10a4b0f0bf4959850caf3951ad4ea915edb4e
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59121723"
---
# <a name="using-drawingvisual-objects"></a>Использование объектов DrawingVisual
В этом разделе представлен обзор использования <xref:System.Windows.Media.DrawingVisual> объекты в [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] визуальном уровне.  
  
<a name="drawingvisual_object"></a>   
## <a name="drawingvisual-object"></a>Объект DrawingVisual  
 <xref:System.Windows.Media.DrawingVisual> — упрощенный класс, используемый для отрисовки фигур, изображений и текста. Этот класс считается упрощенным, так как не предоставляет средств для работы с разметкой и обработку событий, что повышает его производительность. Поэтому этот класс идеально подходит для фоновых рисунков или клипов.  
  
<a name="drawingvisual_host_container"></a>   
## <a name="drawingvisual-host-container"></a>Контейнер размещения DrawingVisual  
 Чтобы использовать <xref:System.Windows.Media.DrawingVisual> объектов, необходимо создать контейнер размещения для объектов. Объект контейнера размещения должен быть производным от <xref:System.Windows.FrameworkElement> класс, который предоставляет макет и обработка событий поддерживает, что <xref:System.Windows.Media.DrawingVisual> класса отсутствует. Объект контейнера размещения не отображает видимых свойств, так как его основное назначение — включать дочерние объекты. Тем не менее <xref:System.Windows.UIElement.Visibility%2A> свойство контейнера узла должно быть присвоено <xref:System.Windows.Visibility.Visible>; в противном случае будет отображаться ни один из его дочерних элементов.  
  
 При создании объекта контейнера размещения для визуальных объектов, вам необходимо сохранить ссылки визуального объекта в <xref:System.Windows.Media.VisualCollection>. Используйте <xref:System.Windows.Media.VisualCollection.Add%2A> метод для добавления визуального объекта в контейнер размещения. В следующем примере создается объект контейнера размещения, а также добавляются три визуальных объектов его <xref:System.Windows.Media.VisualCollection>.  
  
 [!code-csharp[DrawingVisualSample#100](~/samples/snippets/csharp/VS_Snippets_Wpf/DrawingVisualSample/CSharp/Window1.xaml.cs#100)]
 [!code-vb[DrawingVisualSample#100](~/samples/snippets/visualbasic/VS_Snippets_Wpf/DrawingVisualSample/visualbasic/window1.xaml.vb#100)]  
  
> [!NOTE]
>  Полный код примера, из которого был взят предыдущий пример кода, см. в разделе [Проверка нажатия с помощью примера DrawingVisuals](https://go.microsoft.com/fwlink/?LinkID=159994).  
  
<a name="creating_drawingvisual_objects"></a>   
## <a name="creating-drawingvisual-objects"></a>Создание объектов DrawingVisual  
 При создании <xref:System.Windows.Media.DrawingVisual> объекта, он не имеет графического содержимого. Можно добавить текст, графика или содержимое изображения путем извлечения объекта <xref:System.Windows.Media.DrawingContext> и рисования в него. Объект <xref:System.Windows.Media.DrawingContext> возвращается путем вызова <xref:System.Windows.Media.DrawingVisual.RenderOpen%2A> метод <xref:System.Windows.Media.DrawingVisual> объекта.  
  
 Чтобы нарисовать прямоугольник в <xref:System.Windows.Media.DrawingContext>, использовать <xref:System.Windows.Media.DrawingContext.DrawRectangle%2A> метод <xref:System.Windows.Media.DrawingContext> объекта. Существуют аналогичные методы для рисования других объектов. После завершения рисования содержимое в <xref:System.Windows.Media.DrawingContext>, вызовите <xref:System.Windows.Media.DrawingContext.Close%2A> метод для закрытия <xref:System.Windows.Media.DrawingContext> и сохранить содержимое.  
  
 В следующем примере <xref:System.Windows.Media.DrawingVisual> создания объекта и прямоугольник в его <xref:System.Windows.Media.DrawingContext>.  
  
 [!code-csharp[DrawingVisualSample#101](~/samples/snippets/csharp/VS_Snippets_Wpf/DrawingVisualSample/CSharp/Window1.xaml.cs#101)]
 [!code-vb[DrawingVisualSample#101](~/samples/snippets/visualbasic/VS_Snippets_Wpf/DrawingVisualSample/visualbasic/window1.xaml.vb#101)]  
  
<a name="creating_overrides"></a>   
## <a name="creating-overrides-for-frameworkelement-members"></a>Создание переопределений для членов класса FrameworkElement  
 Объект контейнера размещения отвечает за управление своей коллекцией визуальных объектов. Для этого требуется, чтобы контейнера размещения реализован переопределения члена производного <xref:System.Windows.FrameworkElement> класса.  
  
 Ниже приводятся два члена класса, которые необходимо переопределить.  
  
-   <xref:System.Windows.FrameworkElement.GetVisualChild%2A>: Возвращает дочерний элемент по указанному индексу из коллекции дочерних элементов.  
  
-   <xref:System.Windows.FrameworkElement.VisualChildrenCount%2A>: Получает количество визуальных дочерних элементов внутри этого элемента.  
  
 В следующем примере, переопределения для двух <xref:System.Windows.FrameworkElement> члены реализуются.  
  
 [!code-csharp[DrawingVisualSample#102](~/samples/snippets/csharp/VS_Snippets_Wpf/DrawingVisualSample/CSharp/Window1.xaml.cs#102)]
 [!code-vb[DrawingVisualSample#102](~/samples/snippets/visualbasic/VS_Snippets_Wpf/DrawingVisualSample/visualbasic/window1.xaml.vb#102)]  
  
<a name="providing_hit_testing_support"></a>   
## <a name="providing-hit-testing-support"></a>Поддержка проверки нажатия  
 Объект контейнера размещения может предоставлять обработку событий в случае, даже если он не содержит ни одного видимого свойства, однако его <xref:System.Windows.UIElement.Visibility%2A> свойству должно быть присвоено <xref:System.Windows.Visibility.Visible>. Это позволяет создать процедуру обработки событий для контейнера размещения. Эта процедура сможет перехватывать события мыши, например отпускание левой кнопки мыши. Процедура обработки события можно реализовать проверку попадания путем вызова <xref:System.Windows.Media.VisualTreeHelper.HitTest%2A> метод. Метод <xref:System.Windows.Media.HitTestResultCallback> параметр ссылается на определяемой пользователем процедуры, можно использовать для определения результата проверки нажатия.  
  
 В следующем примере реализована поддержка проверки нажатия для объекта узла контейнера и его дочерних объектов.  
  
 [!code-csharp[DrawingVisualSample#103](~/samples/snippets/csharp/VS_Snippets_Wpf/DrawingVisualSample/CSharp/Window1.xaml.cs#103)]
 [!code-vb[DrawingVisualSample#103](~/samples/snippets/visualbasic/VS_Snippets_Wpf/DrawingVisualSample/visualbasic/window1.xaml.vb#103)]  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Media.DrawingVisual>
- <xref:System.Windows.Media.VisualTreeHelper.HitTest%2A>
- [Общие сведения об отрисовке графики в WPF](wpf-graphics-rendering-overview.md)
- [Проверка попадания на визуальном уровне](hit-testing-in-the-visual-layer.md)
