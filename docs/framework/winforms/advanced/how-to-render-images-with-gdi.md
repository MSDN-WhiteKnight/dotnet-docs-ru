---
title: Практическое руководство. Отрисовка изображений с использованием GDI+
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- images [Windows Forms], creating
- GDI+, rendering existing images
ms.assetid: c128b79a-3e31-47d8-9e66-3470f570a056
ms.openlocfilehash: e038da545bb3f56cc757710bcaa93aa2c86bfa67
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59342554"
---
# <a name="how-to-render-images-with-gdi"></a>Практическое руководство. Отрисовка изображений с использованием GDI+
Для вывода изображений, которые существуют в виде файлов в приложениях, можно использовать [!INCLUDE[ndptecgdiplus](../../../../includes/ndptecgdiplus-md.md)]. Это сделать, создав новый объект <xref:System.Drawing.Image> класс (такие как <xref:System.Drawing.Bitmap>), создавая <xref:System.Drawing.Graphics> объекта, который ссылается на поверхность рисования, вы хотите использовать и вызов <xref:System.Drawing.Graphics.DrawImage%2A> метод <xref:System.Drawing.Graphics> объекта. Изображение будет выведено на поверхность для рисования, представленную классом Graphics. Можно создавать и редактировать файлы изображений во время разработки с помощью редактора изображений и отображать их во время выполнения, используя [!INCLUDE[ndptecgdiplus](../../../../includes/ndptecgdiplus-md.md)]. Дополнительные сведения см. в разделе [Редактор изображений для значков](/cpp/windows/image-editor-for-icons).  
  
### <a name="to-render-an-image-with-gdi"></a>Вывод изображения с помощью GDI+  
  
1. Создайте объект, представляющий изображение, которое необходимо отобразить. Этот объект должен быть членом класса, который наследует от <xref:System.Drawing.Image>, такие как <xref:System.Drawing.Bitmap> или <xref:System.Drawing.Imaging.Metafile>. Пример:  
  
    ```vb  
    ' Uses the System.Environment.GetFolderPath to get the path to the   
    ' current user's MyPictures folder.  
    Dim myBitmap as New Bitmap _  
       (System.Environment.GetFolderPath _  
          (System.Environment.SpecialFolder.MyPictures))  
    ```  
  
    ```csharp  
    // Uses the System.Environment.GetFolderPath to get the path to the   
    // current user's MyPictures folder.  
    Bitmap myBitmap = new Bitmap  
       (System.Environment.GetFolderPath  
          (System.Environment.SpecialFolder.MyPictures));  
    ```  
  
    ```cpp  
    // Uses the System.Environment.GetFolderPath to get the path to the   
    // current user's MyPictures folder.  
    Bitmap^ myBitmap = gcnew Bitmap  
       (System::Environment::GetFolderPath  
          (System::Environment::SpecialFolder::MyPictures));  
    ```  
  
2. Создание <xref:System.Drawing.Graphics> , представляющий поверхность рисования, вы хотите использовать. Дополнительные сведения см. в разделе [Как Создание объектов Graphics для рисования](how-to-create-graphics-objects-for-drawing.md).  
  
    ```vb  
    ' Creates a Graphics object that represents the drawing surface of   
    ' Button1.  
    Dim g as Graphics = Button1.CreateGraphics  
    ```  
  
    ```csharp  
    // Creates a Graphics object that represents the drawing surface of   
    // Button1.  
    Graphics g = Button1.CreateGraphics();  
    ```  
  
    ```cpp  
    // Creates a Graphics object that represents the drawing surface of   
    // Button1.  
    Graphics^ g = button1->CreateGraphics();  
    ```  
  
3. Вызовите <xref:System.Drawing.Graphics.DrawImage%2A> графического объекта для вывода изображения. Необходимо указать как само выводимое изображение, так и координаты вывода.  
  
    ```vb  
    g.DrawImage(myBitmap, 1, 1)  
    ```  
  
    ```csharp  
    g.DrawImage(myBitmap, 1, 1);  
    ```  
  
    ```cpp  
    g->DrawImage(myBitmap, 1, 1);  
    ```  
  
## <a name="see-also"></a>См. также

- [Приступая к программированию графики](getting-started-with-graphics-programming.md)
- [Практическое руководство. Создание графических объектов для рисования](how-to-create-graphics-objects-for-drawing.md)
- [Перья, линии и прямоугольники в GDI+](pens-lines-and-rectangles-in-gdi.md)
- [Практическое руководство. Отрисовка текста в Windows Forms](how-to-draw-text-on-a-windows-form.md)
- [Объекты Graphics и Drawing в Windows Forms](graphics-and-drawing-in-windows-forms.md)
- [Рисование линий и замкнутых фигур](/cpp/windows/drawing-lines-or-closed-figures-image-editor-for-icons)
- [Редактор изображений для значков](/cpp/windows/image-editor-for-icons)
