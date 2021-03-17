---
title: Практическое руководство. Изменение внешнего вида элемента управления LinkLabel в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- LinkLabel properties
- LinkLabel control [Windows Forms], changing appearance of links
- links [Windows Forms], changing appearance
- examples [Windows Forms], LinkLabel control
- LinkLabel control [Windows Forms], examples
ms.assetid: fdc5854f-5162-4457-8cbe-1042feb2d132
ms.openlocfilehash: f0a5805561509501ca38a7fec6b4731af190e3c3
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59322021"
---
# <a name="how-to-change-the-appearance-of-the-windows-forms-linklabel-control"></a>Практическое руководство. Изменение внешнего вида элемента управления LinkLabel в Windows Forms
Можно изменить текст, отображаемый элементом <xref:System.Windows.Forms.LinkLabel> управления для различных целей. Например это распространенная практика, чтобы уведомить пользователя, что текст можно щелкнуть мышью текст, появляющийся определенным цветом и подчеркиванием. Пользователь щелкает этот текст, цвет меняется на другой цвет. Чтобы контролировать это поведение, можно задать пять различных свойств: <xref:System.Windows.Forms.LinkLabel.LinkBehavior%2A>, <xref:System.Windows.Forms.LinkLabel.LinkArea%2A>, <xref:System.Windows.Forms.LinkLabel.LinkColor%2A>, <xref:System.Windows.Forms.LinkLabel.VisitedLinkColor%2A>, и <xref:System.Windows.Forms.LinkLabel.LinkVisited%2A> свойства.  
  
### <a name="to-change-the-appearance-of-a-linklabel-control"></a>Чтобы изменить внешний вид элемента управления LinkLabel  
  
1. Задайте <xref:System.Windows.Forms.LinkLabel.LinkColor%2A> и <xref:System.Windows.Forms.LinkLabel.VisitedLinkColor%2A> свойства, чтобы нужные цвета.  
  
     Это можно сделать программным образом или во время разработки в **свойства** окна.  
  
    ```vb  
    ' You can set the color using decimal values for red, green, and blue  
    LinkLabel1.LinkColor = Color.FromArgb(0, 0, 255)  
    ' Or you can set the color using defined constants  
    LinkLabel1.VisitedLinkColor = Color.Purple  
    ```  
  
    ```csharp  
    // You can set the color using decimal values for red, green, and blue  
    linkLabel1.LinkColor = Color.FromArgb(0, 0, 255);  
    // Or you can set the color using defined constants  
    linkLabel1.VisitedLinkColor = Color.Purple;  
    ```  
  
    ```cpp  
    // You can set the color using decimal values for red, green, and blue  
    linkLabel1->LinkColor = Color::FromArgb(0, 0, 255);  
    // Or you can set the color using defined constants  
    linkLabel1->VisitedLinkColor = Color::Purple;  
    ```  
  
2. Задайте <xref:System.Windows.Forms.LinkLabel.Text%2A> свойство соответствующий заголовок.  
  
     Это можно сделать программным образом или во время разработки в **свойства** окна.  
  
    ```vb  
    LinkLabel1.Text = "Click here to see more."  
    ```  
  
    ```csharp  
    linkLabel1.Text = "Click here to see more.";  
    ```  
  
    ```cpp  
    linkLabel1->Text = "Click here to see more.";  
    ```  
  
3. Задать <xref:System.Windows.Forms.LinkLabel.LinkArea%2A> свойства, чтобы определить, какая часть заголовка будет представлена в качестве ссылки.  
  
     <xref:System.Windows.Forms.LinkLabel.LinkArea%2A> Представлено <xref:System.Windows.Forms.LinkArea> содержащий два числа, положение начального знака и число символов. Это можно сделать программным образом или во время разработки в **свойства** окна.  
  
    ```vb  
    LinkLabel1.LinkArea = new LinkArea(6,4)  
    ```  
  
    ```csharp  
    linkLabel1.LinkArea = new LinkArea(6,4);  
    ```  
  
    ```cpp  
    linkLabel1->LinkArea = LinkArea(6,4);  
    ```  
  
4. Задайте <xref:System.Windows.Forms.LinkLabel.LinkBehavior%2A> свойства <xref:System.Windows.Forms.LinkBehavior.AlwaysUnderline>, <xref:System.Windows.Forms.LinkBehavior.HoverUnderline>, или <xref:System.Windows.Forms.LinkBehavior.NeverUnderline>.  
  
     Если он становится равным <xref:System.Windows.Forms.LinkBehavior.HoverUnderline>, часть заголовка, определяется <xref:System.Windows.Forms.LinkLabel.LinkArea%2A> будет подчеркнуто только при наведении указателя на нем.  
  
5. В <xref:System.Windows.Forms.LinkLabel.LinkClicked> задать обработчик событий, <xref:System.Windows.Forms.LinkLabel.LinkVisited%2A> свойства `true`.  
  
     При ссылке это распространенная практика, чтобы изменить его внешний вид, обычно по цвету. Текст изменится на цвет, определенный параметром <xref:System.Windows.Forms.LinkLabel.VisitedLinkColor%2A> свойство.  
  
    ```vb  
    Protected Sub LinkLabel1_LinkClicked (ByVal sender As Object, _  
       ByVal e As EventArgs) Handles LinkLabel1.LinkClicked  
       ' Change the color of the link text  
       ' by setting LinkVisited to True.  
       LinkLabel1.LinkVisited = True  
       ' Then do whatever other action is appropriate  
    End Sub  
    ```  
  
    ```csharp  
    protected void LinkLabel1_LinkClicked(object sender, System.EventArgs e)  
    {  
       // Change the color of the link text by setting LinkVisited   
       // to True.  
       linkLabel1.LinkVisited = true;  
       // Then do whatever other action is appropriate  
    }  
    ```  
  
    ```cpp  
    private:  
       System::Void linkLabel1_LinkClicked(System::Object ^  sender,  
          System::Windows::Forms::LinkLabelLinkClickedEventArgs ^  e)  
       {  
          // Change the color of the link text by setting LinkVisited   
          // to True.  
          linkLabel1->LinkVisited = true;  
          // Then do whatever other action is appropriate  
       }  
    ```  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.LinkLabel.LinkArea%2A>
- <xref:System.Windows.Forms.LinkLabel.LinkColor%2A>
- <xref:System.Windows.Forms.LinkLabel.VisitedLinkColor%2A>
- <xref:System.Windows.Forms.LinkLabel.LinkVisited%2A>
- [Общие сведения об элементе управления LinkLabel](linklabel-control-overview-windows-forms.md)
- [Практическое руководство. Создание связи с объектом или веб-страницей с помощью элемента управления LinkLabel в Windows Forms](link-to-an-object-or-web-page-with-wf-linklabel-control.md)
- [Элемент управления LinkLabel](linklabel-control-windows-forms.md)
