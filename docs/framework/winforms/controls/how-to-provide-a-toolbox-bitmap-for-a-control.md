---
title: Практическое руководство. Предоставление точечного рисунка панели элементов для элемента управления
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- Toolbox [Windows Forms], adding bitmaps for custom controls
- custom controls [Windows Forms], Toolbox bitmaps
- bitmaps [Windows Forms], custom controls
ms.assetid: 0ed0840a-616d-41ba-a27d-3573241932ad
ms.openlocfilehash: 7c26e00acd4278ced53ad29c748ac076e0215a23
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59337712"
---
# <a name="how-to-provide-a-toolbox-bitmap-for-a-control"></a>Практическое руководство. Предоставление точечного рисунка панели элементов для элемента управления
Если вы хотите иметь специальный значок для элемента управления отображаются в **элементов**, можно указать образ с помощью <xref:System.Drawing.ToolboxBitmapAttribute>. Он представляет собой *атрибут* — особый вид классов, который можно прикреплять к другим классам. Дополнительные сведения об атрибутах см. в разделе [Обзор атрибутов (Visual Basic)](../../../visual-basic/programming-guide/concepts/attributes/index.md) для Visual Basic или [атрибуты (C#)](../../../csharp/programming-guide/concepts/attributes/index.md) для C#.  
  
 С помощью <xref:System.Drawing.ToolboxBitmapAttribute>, можно указать строку, которая указывает путь и имя файла для точечного рисунка 16 x 16 пикселей. Это изображение появится рядом с элементом управления при добавлении на **панель элементов**. Можно также указать <xref:System.Type>, в этом случае загружается растровое изображение, связанное с этим типом. Если задан и <xref:System.Type> и строку, элемент управления ищет ресурс изображения с именем, заданным параметром строки, в сборку, содержащую тип, заданный параметром <xref:System.Type> параметр.  
  
### <a name="to-specify-a-toolbox-bitmap-for-your-control"></a>Указание растрового изображения для отображения элемента управления на панели элементов  
  
1. Добавить <xref:System.Drawing.ToolboxBitmapAttribute> к объявлению класса элемента управления перед `Class` ключевое слово для visual Basic, а также над объявлением класса для Visual C#.  
  
    ```vb  
    ' Specifies the bitmap associated with the Button type.  
    <ToolboxBitmap(GetType(Button))> Class MyControl1  
    ' Specifies a bitmap file.  
    End Class  
    <ToolboxBitmap("C:\Documents and Settings\Joe\MyPics\myImage.bmp")> _  
       Class MyControl2  
    End Class  
    ' Specifies a type that indicates the assembly to search, and the name   
    ' of an image resource to look for.  
    <ToolboxBitmap(GetType(MyControl), "MyControlBitmap")> Class MyControl  
    End Class  
    ```  
  
    ```csharp  
    // Specifies the bitmap associated with the Button type.  
    [ToolboxBitmap(typeof(Button))]  
    class MyControl1 : UserControl  
    {  
    }  
    // Specifies a bitmap file.  
    [ToolboxBitmap(@"C:\Documents and Settings\Joe\MyPics\myImage.bmp")]  
    class MyControl2 : UserControl  
    {  
    }  
    // Specifies a type that indicates the assembly to search, and the name   
    // of an image resource to look for.  
    [ToolboxBitmap(typeof(MyControl), "MyControlBitmap")]  
    class MyControl : UserControl  
    {  
    }  
    ```  
  
2. Перестройте проект.  
  
    > [!NOTE]
    >  Для автоматически созданных элементов управления и компонентов растровое изображение на панели элементов не отображается. Чтобы увидеть растровое изображение, перезагрузите элемент управления с помощью диалогового окна **Выбор элементов панели элементов**. Дополнительные сведения см. в разделе [Пошаговое руководство: Автоматическое заполнение панели элементов пользовательскими компонентами](walkthrough-automatically-populating-the-toolbox-with-custom-components.md).  
  
## <a name="see-also"></a>См. также

- <xref:System.Drawing.ToolboxBitmapAttribute>
- [Пошаговое руководство. Автоматическое заполнение панели элементов пользовательскими компонентами](walkthrough-automatically-populating-the-toolbox-with-custom-components.md)
- [Создание элементов управления Windows Forms во время разработки](developing-windows-forms-controls-at-design-time.md)
- [Общие сведения об атрибутах (Visual Basic)](../../../visual-basic/programming-guide/concepts/attributes/index.md)
- [Атрибуты (C#)](../../../csharp/programming-guide/concepts/attributes/index.md)
