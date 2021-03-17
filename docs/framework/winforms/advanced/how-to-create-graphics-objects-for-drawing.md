---
title: Практическое руководство. Создание графических объектов для рисования
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- graphics [Windows Forms], creating
- images [Windows Forms], creating
- GDI+, creating images
ms.assetid: 162861f9-f050-445e-8abb-b2c43a918b8b
ms.openlocfilehash: 79eae4d37c056fc95ac73c78e00dd1a2b68bcd24
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59324205"
---
# <a name="how-to-create-graphics-objects-for-drawing"></a>Практическое руководство. Создание графических объектов для рисования
Перед тем как рисовать линии и фигуры, отображать текст или изображения и управлять ими с помощью [!INCLUDE[ndptecgdiplus](../../../../includes/ndptecgdiplus-md.md)], необходимо создать объект <xref:System.Drawing.Graphics>. <xref:System.Drawing.Graphics> представляет поверхность для рисования [!INCLUDE[ndptecgdiplus](../../../../includes/ndptecgdiplus-md.md)] и является объектом, который используется для создания графических изображений.  
  
 Работа с графикой состоит из двух этапов:  
  
1. Создание объекта <xref:System.Drawing.Graphics>.  
  
2. Использование объекта <xref:System.Drawing.Graphics> для рисования линий и фигур, отображения текста или изображений и управления ими.  
  
## <a name="creating-a-graphics-object"></a>Создание объектов Graphics  
 Объекты Graphics могут создаваться различными способами.  
  
#### <a name="to-create-a-graphics-object"></a>Чтобы создать объект Graphics  
  
-   Получите ссылку на объект Graphics как часть <xref:System.Windows.Forms.PaintEventArgs> в событии <xref:System.Windows.Forms.Control.Paint>  формы или элемента управления. Это обычный способ получения ссылки на объект Graphics при создании кода рисования для элемента управления. Аналогичным образом можно получить объект Graphics как свойство <xref:System.Drawing.Printing.PrintPageEventArgs> при обработке события <xref:System.Drawing.Printing.PrintDocument.PrintPage> для <xref:System.Drawing.Printing.PrintDocument>.  
  
     - или -  
  
-   Вызовите метод <xref:System.Windows.Forms.Control.CreateGraphics%2A> элемента управления или формы, чтобы получить ссылку на <xref:System.Drawing.Graphics>, представляющий поверхность рисования объекта формы или элемента управления. Используйте этот метод, чтобы рисовать на уже существующей форме или элементе управления.  
  
     - или -  
  
-   Создайте объект <xref:System.Drawing.Graphics> из любого объекта, который наследует от <xref:System.Drawing.Image>. Этот подход полезен в тех случаях, когда нужно изменить уже существующий образ.  
  
     В следующих разделах приводятся сведения о каждом из этих процессов.  
  
## <a name="painteventargs-in-the-paint-event-handler"></a>PaintEventArgs в обработчике события рисования  
 При программировании <xref:System.Windows.Forms.PaintEventHandler> для элементов управления или <xref:System.Drawing.Printing.PrintDocument.PrintPage> для <xref:System.Drawing.Printing.PrintDocument> объект Graphics предоставляется как одно из свойств объекта <xref:System.Windows.Forms.PaintEventArgs> или <xref:System.Drawing.Printing.PrintPageEventArgs>.  
  
#### <a name="to-obtain-a-reference-to-a-graphics-object-from-the-painteventargs-in-the-paint-event"></a>Для получения ссылки на объект Graphics из PaintEventArgs в событии рисования  
  
1. Объявите объект <xref:System.Drawing.Graphics>.  
  
2. Присвойте переменной ссылку на объект <xref:System.Drawing.Graphics>, передаваемый как часть <xref:System.Windows.Forms.PaintEventArgs>.  
  
3. Вставьте код для рисования формы или элемента управления.  
  
     В следующем примере показано, как ссылаться на объект <xref:System.Drawing.Graphics> из <xref:System.Windows.Forms.PaintEventArgs> в событии <xref:System.Windows.Forms.Control.Paint>:  
  
    ```vb  
    Private Sub Form1_Paint(sender As Object, pe As PaintEventArgs) Handles _  
       MyBase.Paint  
       ' Declares the Graphics object and sets it to the Graphics object  
       ' supplied in the PaintEventArgs.  
       Dim g As Graphics = pe.Graphics  
       ' Insert code to paint the form here.  
    End Sub  
    ```  
  
    ```csharp  
    private void Form1_Paint(object sender,   
       System.Windows.Forms.PaintEventArgs pe)   
    {  
       // Declares the Graphics object and sets it to the Graphics object  
       // supplied in the PaintEventArgs.  
       Graphics g = pe.Graphics;  
       // Insert code to paint the form here.  
    }  
    ```  
  
    ```cpp  
    private:  
       void Form1_Paint(System::Object ^ sender,  
          System::Windows::Forms::PaintEventArgs ^ pe)  
       {  
          // Declares the Graphics object and sets it to the Graphics object  
          // supplied in the PaintEventArgs.  
          Graphics ^ g = pe->Graphics;  
          // Insert code to paint the form here.  
       }  
    ```  
  
## <a name="creategraphics-method"></a>Метод CreateGraphics  
 Можно также использовать метод <xref:System.Windows.Forms.Control.CreateGraphics%2A> элемента управления или формы, чтобы получить ссылку на объект <xref:System.Drawing.Graphics>, представляющий поверхность рисования формы или элемента управления.  
  
#### <a name="to-create-a-graphics-object-with-the-creategraphics-method"></a>Чтобы создать объект Graphics с помощью метода CreateGraphics  
  
-   Вызовите метод <xref:System.Windows.Forms.Control.CreateGraphics%2A> формы или элемента управления, на которых необходимо отрисовывать графику.  
  
    ```vb  
    Dim g as Graphics  
    ' Sets g to a Graphics object representing the drawing surface of the  
    ' control or form g is a member of.  
    g = Me.CreateGraphics  
    ```  
  
    ```csharp  
    Graphics g;  
    // Sets g to a graphics object representing the drawing surface of the  
    // control or form g is a member of.  
    g = this.CreateGraphics();  
    ```  
  
    ```cpp  
    Graphics ^ g;  
    // Sets g to a graphics object representing the drawing surface of the  
    // control or form g is a member of.  
    g = this->CreateGraphics();  
    ```  
  
## <a name="create-from-an-image-object"></a>Создание из объекта Image  
 Кроме того, можно создать объект Graphics из любого объекта, производного от класса <xref:System.Drawing.Image>.  
  
#### <a name="to-create-a-graphics-object-from-an-image"></a>Чтобы создать объект Graphics из изображения  
  
-   Вызовите метод <xref:System.Drawing.Graphics.FromImage%2A?displayProperty=nameWithType>, указав имя переменной типа Image, из которой требуется создать объект <xref:System.Drawing.Graphics>.  
  
     В следующем примере показано, как использовать объект <xref:System.Drawing.Bitmap>:  
  
    ```vb  
    Dim myBitmap as New Bitmap("C:\Documents and Settings\Joe\Pics\myPic.bmp")  
    Dim g as Graphics = Graphics.FromImage(myBitmap)  
    ```  
  
    ```csharp  
    Bitmap myBitmap = new Bitmap(@"C:\Documents and   
       Settings\Joe\Pics\myPic.bmp");  
    Graphics g = Graphics.FromImage(myBitmap);  
    ```  
  
    ```cpp  
    Bitmap ^ myBitmap = gcnew  
       Bitmap("D:\\Documents and Settings\\Joe\\Pics\\myPic.bmp");  
    Graphics ^ g = Graphics::FromImage(myBitmap);  
    ```  
  
> [!NOTE]
>  Вы можете создавать объекты <xref:System.Drawing.Graphics> только из неиндексированных BMP-файлов, например, 16, 24 и 32-разрядных BMP-файлов. Каждый пиксель неиндексированного BMP-файла содержит сведения о цвете, в отличие от пикселей индексированного BMP-файла, содержащих указатели на таблицу цветов.  
  
## <a name="drawing-and-manipulating-shapes-and-images"></a>Рисование и изменение фигур и изображений  
 После создания объект <xref:System.Drawing.Graphics> можно использовать для рисования линий и фигур, отрисовки текста, а также показа и изменения изображений. Основные объекты, которые используются с объектами <xref:System.Drawing.Graphics>:  
  
-   Класс <xref:System.Drawing.Pen>, используемый для рисования линий, контуров и отрисовки других геометрических объектов.  
  
-   Класс <xref:System.Drawing.Brush>, используемый для заливки графических областей, например фигур, изображений или текста.  
  
-   Класс <xref:System.Drawing.Font>, содержащий описание фигур, которые должны использоваться при отрисовке текста.  
  
-   Структура <xref:System.Drawing.Color>, представляющая различные цвета для отображения.  
  
#### <a name="to-use-the-graphics-object-you-have-created"></a>Чтобы использовать объект Graphics, который вы создали  
  
-   Используйте любой из вышеперечисленных объектов для рисования того, что вам нужно.  
  
     Дополнительные сведения см. в следующих разделах:  
  
    |Для отрисовки|См.|  
    |---------------|---------|  
    |Прямых линий|[Практическое руководство. Рисований линий в Windows Forms](how-to-draw-a-line-on-a-windows-form.md)|  
    |Фигур|[Практическое руководство. Рисование линии или контурной фигуры](how-to-draw-an-outlined-shape.md)|  
    |Текста|[Практическое руководство. Отрисовка текста в Windows Forms](how-to-draw-text-on-a-windows-form.md)|  
    |Изображений|[Практическое руководство. Отрисовка изображений с использованием GDI+](how-to-render-images-with-gdi.md)|  
  
## <a name="see-also"></a>См. также

- [Приступая к программированию графики](getting-started-with-graphics-programming.md)
- [Объекты Graphics и Drawing в Windows Forms](graphics-and-drawing-in-windows-forms.md)
- [Прямые и кривые линии и фигуры](lines-curves-and-shapes.md)
- [Практическое руководство. Отрисовка изображений с использованием GDI+](how-to-render-images-with-gdi.md)
