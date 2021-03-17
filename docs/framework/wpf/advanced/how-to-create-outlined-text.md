---
title: Практическое руководство. Создание контурного текста
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- typography [WPF], linear gradient brush
- outlined text [WPF]
- gradient brush [WPF]
- linear gradient brush [WPF]
- typography [WPF], outline effects
ms.assetid: 4aa3cf6e-1953-4f26-8230-7c1409e5f28d
ms.openlocfilehash: 237bdc097cd2a3fbfff6dd79bce401c2d091e211
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59162232"
---
# <a name="how-to-create-outlined-text"></a>Практическое руководство. Создание контурного текста
В большинстве случаев при добавлении декоративных элементов в текстовые строки в вашей [!INCLUDE[TLA#tla_winclient](../../../../includes/tlasharptla-winclient-md.md)] приложения, вы используете текст в виде коллекции дискретных символов или глифов. Например, можно создать кисть линейного градиента и применить его к <xref:System.Windows.Controls.Control.Foreground%2A> свойство <xref:System.Windows.Controls.TextBox> объекта. При отображении или измените текстовое поле, кисти линейного градиента применяется автоматически в текущий набор символов в текстовой строке.  
  
 ![Текст, отображенный при помощи кисти линейного градиента](./media/how-to-create-outlined-text/text-linear-gradient.jpg)    
  
 Тем не менее, можно также преобразовать текст в <xref:System.Windows.Media.Geometry> объектами, позволяет создавать другие типы визуально форматированного текста. Например, можно создать <xref:System.Windows.Media.Geometry> объект, основанный на контуре строки текста.  
  
 ![Оконтуривание текста с использованием кисти линейного градиента](./media/how-to-create-outlined-text/text-outline-linear-gradient.jpg)  
  
 Если текст преобразуется в <xref:System.Windows.Media.Geometry> объекта, он больше не является набором символов — изменение символов в текстовой строке невозможно. Тем не менее можно повлиять на внешний вид преобразованного текст, изменив его свойства штриха и заливки. Штрих — это контур преобразованного текста; заливка — это область внутри контура преобразованного текста.  
  
 Следующие примеры иллюстрируют несколько способов создания визуальных эффектов посредством изменения штриха и заливки преобразованного текста.  
  
 ![Текст с различными цветами для заполнения штриха](./media/how-to-create-outlined-text/fill-stroke-text-effect.jpg)  
  
 ![Текст с кистью изображения, примененной к штриху](./media/how-to-create-outlined-text/image-brush-application.jpg)
  
 Можно также изменить ограничивающий прямоугольник или выделения преобразованного текста. Следующий пример иллюстрирует способ создания визуальных эффектов посредством изменения штриха и выделения преобразованного текста.  
  
 ![Текст с кистью изображения, примененной для вычерчивания и выделения](./media/how-to-create-outlined-text/image-brush-text-application.jpg)

## <a name="example"></a>Пример  
 Ключ, чтобы преобразовать текст в <xref:System.Windows.Media.Geometry> объекта заключается в использовании <xref:System.Windows.Media.FormattedText> объекта. После создания этот объект можно использовать <xref:System.Windows.Media.FormattedText.BuildGeometry%2A> и <xref:System.Windows.Media.FormattedText.BuildHighlightGeometry%2A> методы, чтобы преобразовать текст в <xref:System.Windows.Media.Geometry> объектов. Первый метод возвращает геометрию форматированного текста. Второй метод возвращает ограничивающий прямоугольник геометрии форматированного текста. В следующем примере кода показано, как создать <xref:System.Windows.Media.FormattedText> объекта и извлечение геометрических форм форматированного текста и его ограничивающего прямоугольника.  
  
 [!code-csharp[OutlineTextControlViewer#CreateText](~/samples/snippets/csharp/VS_Snippets_Wpf/OutlineTextControlViewer/CSharp/OutlineTextControl.cs#createtext)]
 [!code-vb[OutlineTextControlViewer#CreateText](~/samples/snippets/visualbasic/VS_Snippets_Wpf/OutlineTextControlViewer/visualbasic/outlinetextcontrol.vb#createtext)]  
  
 Чтобы отобразить извлеченные <xref:System.Windows.Media.Geometry> объектов, необходимо получить доступ к <xref:System.Windows.Media.DrawingContext> объекта, который отображает преобразованный текст. В этих примерах кода это делается путем создания объекта пользовательского элемента управления, производный от класса, поддерживающего пользовательской отрисовки.  
  
 Для отображения <xref:System.Windows.Media.Geometry> объектов в пользовательском элементе управления, переопределите для <xref:System.Windows.UIElement.OnRender%2A> метод. Переопределенный метод должен использовать <xref:System.Windows.Media.DrawingContext.DrawGeometry%2A> метод для отображения <xref:System.Windows.Media.Geometry> объектов.  
  
 [!code-csharp[OutlineTextControlViewer#OnRender](~/samples/snippets/csharp/VS_Snippets_Wpf/OutlineTextControlViewer/CSharp/OutlineTextControl.cs#onrender)]
 [!code-vb[OutlineTextControlViewer#OnRender](~/samples/snippets/visualbasic/VS_Snippets_Wpf/OutlineTextControlViewer/visualbasic/outlinetextcontrol.vb#onrender)]  
  
  Источник объекта пример настраиваемого пользовательского элемента управления, см. в разделе [OutlineTextControl.cs для C# ](https://github.com/dotnet/samples/blob/master/snippets/csharp/VS_Snippets_Wpf/OutlineTextControlViewer/CSharp/OutlineTextControl.cs) и [OutlineTextControl.vb для Visual Basic](https://github.com/dotnet/samples/blob/master/snippets/visualbasic/VS_Snippets_Wpf/OutlineTextControlViewer/visualbasic/outlinetextcontrol.vb). 
  
## <a name="see-also"></a>См. также

- [Рисование форматированного текста](drawing-formatted-text.md)
