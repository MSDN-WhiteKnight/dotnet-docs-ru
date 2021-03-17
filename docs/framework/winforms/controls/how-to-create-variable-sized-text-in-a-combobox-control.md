---
title: Практическое руководство. Индивидуальное форматирование строк, отображаемых в элементе управления ComboBox
ms.date: 03/30/2017
dev_langs:
- vb
helpviewer_keywords:
- text [Windows Forms], drawing in combo boxes
- examples [Windows Forms], ComboBox control
- combo boxes [Windows Forms], drawing text
- ComboBox control [Windows Forms], examples [C#]
- ComboBox control [Windows Forms], drawing custom text
ms.assetid: ce39b9ea-e626-49fe-bd5a-f567f6d157df
ms.openlocfilehash: 9155893b3d47707e0e55ee33e30d7998654f9e93
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59085614"
---
# <a name="how-to-create-variable-sized-text-in-a-combobox-control"></a>Практическое руководство. Индивидуальное форматирование строк, отображаемых в элементе управления ComboBox
В этом примере показано пользовательское рисование текста в <xref:System.Windows.Forms.ComboBox> элемента управления. Если элемент удовлетворяет определенным критериям, он попадает более крупным шрифтом и красным.  
  
## <a name="example"></a>Пример  
  
```vb  
Private Sub ComboBox1_MeasureItem(ByVal sender As Object, ByVal e As _  
System.Windows.Forms.MeasureItemEventArgs) Handles ComboBox1.MeasureItem  
    Dim bFont As New Font("Arial", 8, FontStyle.Bold)  
    Dim lFont As New Font("Arial", 12, FontStyle.Bold)  
    Dim siText As SizeF  
  
    If ComboBox1.Items().Item(e.Index) = "Two" Then  
        siText = e.Graphics.MeasureString(ComboBox1.Items().Item(e.Index), _  
lFont)  
    Else  
        siText = e.Graphics.MeasureString(ComboBox1.Items().Item(e.Index), bFont)  
    End If  
  
    e.ItemHeight = siText.Height  
    e.ItemWidth = siText.Width  
End Sub  
  
Private Sub ComboBox1_DrawItem(ByVal sender As Object, ByVal e As _  
System.Windows.Forms.DrawItemEventArgs) Handles ComboBox1.DrawItem  
    Dim g As Graphics = e.Graphics  
    Dim bFont As New Font("Arial", 8, FontStyle.Bold)  
    Dim lFont As New Font("Arial", 12, FontStyle.Bold)  
  
    If ComboBox1.Items().Item(e.Index) = "Two" Then  
        g.DrawString(ComboBox1.Items.Item(e.Index), lfont, Brushes.Red, _  
e.Bounds.X, e.Bounds.Y)  
    Else  
        g.DrawString(ComboBox1.Items.Item(e.Index), bFont, Brushes.Black, e.Bounds.X, e.Bounds.Y)  
    End If  
End Sub  
```  
  
## <a name="compiling-the-code"></a>Компиляция кода  
 Для этого примера требуются:  
  
-   Форма Windows.  
  
-   Объект <xref:System.Windows.Forms.ComboBox> управления с именем `ListBox1` с тремя элементами в <xref:System.Windows.Forms.ComboBox.Items%2A> свойство. В этом примере имена трех элементов `"One", Two", and Three"`. <xref:System.Windows.Forms.ComboBox.DrawMode%2A> Свойство `ComboBox1` должно быть присвоено <xref:System.Windows.Forms.DrawMode.OwnerDrawVariable>.  
  
    > [!NOTE]
    >  Эта методика применяется также к <xref:System.Windows.Forms.ListBox> элемента управления, можно заменить <xref:System.Windows.Forms.ListBox> для <xref:System.Windows.Forms.ComboBox>.  
  
-   Ссылки на пространства имен <xref:System.Windows.Forms?displayProperty=nameWithType> и <xref:System.Drawing?displayProperty=nameWithType>.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.ComboBox.DrawItem>
- <xref:System.Windows.Forms.DrawItemEventArgs>
- <xref:System.Windows.Forms.ComboBox.MeasureItem>
- [Элементы управления Windows Forms со встроенной поддержки рисования владельцем](controls-with-built-in-owner-drawing-support.md)
- [Элемент управления ListBox](listbox-control-windows-forms.md)
- [Элемент управления ComboBox](combobox-control-windows-forms.md)
