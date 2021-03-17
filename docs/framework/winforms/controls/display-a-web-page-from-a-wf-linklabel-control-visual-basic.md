---
title: Практическое руководство. Отображение веб-страницы из элемента управления LinkLabel в Windows Forms (Visual Basic)
ms.date: 03/30/2017
dev_langs:
- vb
f1_keywords:
- LinkLabel1_LinkClicked
helpviewer_keywords:
- examples [Windows Forms], LinkLabel control
- Web pages [Windows Forms], displaying
- linking [Windows Forms], to Web pages from forms
- Windows Forms, linking to Web pages
- LinkLabel control [Windows Forms], examples
ms.assetid: 477a7398-5971-4de3-b24c-f49f32bdb28a
ms.openlocfilehash: 1be9ff06e749d14b46946e899c6ffb6c3a950d65
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59170031"
---
# <a name="how-to-display-a-web-page-from-a-windows-forms-linklabel-control-visual-basic"></a>Практическое руководство. Отображение веб-страницы из элемента управления LinkLabel в Windows Forms (Visual Basic)
Этот пример отображает веб-страницы в браузере по умолчанию, когда пользователь щелкает форм Windows <xref:System.Windows.Forms.LinkLabel> элемента управления.  
  
## <a name="example"></a>Пример  
  
```vb  
Private Sub Form1_Load(ByVal sender As System.Object, ByVal e _  
As System.EventArgs) Handles MyBase.Load  
    LinkLabel1.Text = "Click here to get more info."  
    LinkLabel1.Links.Add(6, 4, "www.microsoft.com")  
End Sub  
Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal _  
e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles _  
LinkLabel1.LinkClicked  
    System.Diagnostics.Process.Start(e.Link.LinkData.ToString())  
End Sub  
```  
  
## <a name="compiling-the-code"></a>Компиляция кода  
 Для этого примера требуются:  
  
-   Форму Windows с именем `Form1`.  
  
-   элемент управления <xref:System.Windows.Forms.LinkLabel> с именем `LinkLabel1`;  
  
-   Активное подключение к Интернету.  
  
## <a name="net-framework-security"></a>Безопасность платформы .NET Framework  
 Вызов <xref:System.Diagnostics.Process.Start%2A> метод требует полного доверия. Дополнительные сведения см. в разделе <xref:System.Security.SecurityException>.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.LinkLabel>
- [Элемент управления LinkLabel](linklabel-control-windows-forms.md)
