---
title: Практическое руководство. Определение отмеченных элементов в элементе управления CheckedListBox в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- check boxes [Windows Forms], determining checked state
- CheckedListBox control [Windows Forms], determining checked state
ms.assetid: 178b477d-27c9-489c-8914-44a9623a4d41
ms.openlocfilehash: 10793053934dce0bb83113004a79f1c265f5f267
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59316574"
---
# <a name="how-to-determine-checked-items-in-the-windows-forms-checkedlistbox-control"></a>Практическое руководство. Определение отмеченных элементов в элементе управления CheckedListBox в Windows Forms
При представлении данных в формах Windows <xref:System.Windows.Forms.CheckedListBox> элемента управления, вы можете либо прохода по коллекции хранятся в <xref:System.Windows.Forms.CheckedListBox.CheckedItems%2A> свойство или Пройдите по списку с помощью <xref:System.Windows.Forms.CheckedListBox.GetItemChecked%2A> метод, чтобы определить, какие элементы установлены. <xref:System.Windows.Forms.CheckedListBox.GetItemChecked%2A> Метод принимает номер элемента в качестве аргумента и возвращает `true` или `false`. Вопреки ожиданиям <xref:System.Windows.Forms.ListBox.SelectedItems%2A> и <xref:System.Windows.Forms.ListBox.SelectedIndices%2A> свойства не определяют элементы, которые проверяются; они определяют, какие элементы будут выделены.  
  
### <a name="to-determine-checked-items-in-a-checkedlistbox-control"></a>Чтобы определить, какие элементы в элементе управления CheckedListBox  
  
1. Итерации по <xref:System.Windows.Forms.CheckedListBox.CheckedItems%2A> коллекции, начиная с 0, так как коллекции (с нуля). Обратите внимание на то, что этот метод выдаст номер элемента в список помеченных элементов, а не в полном списке. Если первый элемент в списке не проверяется, и второй элемент выделен, приведенный ниже код будет отображать текст, например «отмеченного элемента 1 = MyListItem2».  
  
    ```vb  
    ' Determine if there are any items checked.  
    If CheckedListBox1.CheckedItems.Count <> 0 Then  
       ' If so, loop through all checked items and print results.  
       Dim x As Integer  
       Dim s As String = ""  
       For x = 0 To CheckedListBox1.CheckedItems.Count - 1  
          s = s & "Checked Item " & (x + 1).ToString & " = " & CheckedListBox1.CheckedItems(x).ToString & ControlChars.CrLf  
       Next x  
       MessageBox.Show(s)  
    End If  
    ```  
  
    ```csharp  
    // Determine if there are any items checked.  
    if(checkedListBox1.CheckedItems.Count != 0)  
    {  
       // If so, loop through all checked items and print results.  
       string s = "";  
       for(int x = 0; x < checkedListBox1.CheckedItems.Count ; x++)  
       {  
          s = s + "Checked Item " + (x+1).ToString() + " = " + checkedListBox1.CheckedItems[x].ToString() + "\n";  
       }  
       MessageBox.Show(s);  
    }  
    ```  
  
    ```cpp  
    // Determine if there are any items checked.  
    if(checkedListBox1->CheckedItems->Count != 0)  
    {  
       // If so, loop through all checked items and print results.  
       String ^ s = "";  
       for(int x = 0; x < checkedListBox1->CheckedItems->Count; x++)  
       {  
          s = String::Concat(s, "Checked Item ", (x+1).ToString(),  
             " = ", checkedListBox1->CheckedItems[x]->ToString(),  
             "\n");  
       }  
       MessageBox::Show(s);  
    }  
    ```  
  
     - или  
  
2. Пошаговое выполнение <xref:System.Windows.Forms.CheckedListBox.Items%2A> коллекции, начиная с 0, поскольку коллекция является отсчитываемый от нуля и вызовите <xref:System.Windows.Forms.CheckedListBox.GetItemChecked%2A> для каждого элемента. Обратите внимание, что этот метод выдаст номер элемента в общий список, поэтому если первый элемент в списке не проверяется и второй элемент установлен, то он выдаст примерно «элемент 2 = MyListItem2».  
  
    ```vb  
    Dim i As Integer  
    Dim s As String  
    s = "Checked Items:" & ControlChars.CrLf  
    For i = 0 To (CheckedListBox1.Items.Count - 1)  
       If CheckedListBox1.GetItemChecked(i) = True Then  
          s = s & "Item " & (i + 1).ToString & " = " & CheckedListBox1.Items(i).ToString & ControlChars.CrLf  
       End If  
    Next  
    MessageBox.Show(s)  
    ```  
  
    ```csharp  
    int i;  
    string s;   
    s = "Checked items:\n" ;  
    for (i = 0; i <= (checkedListBox1.Items.Count-1); i++)  
    {  
       if (checkedListBox1.GetItemChecked(i))  
       {  
          s = s + "Item " + (i+1).ToString() + " = " + checkedListBox1.Items[i].ToString() + "\n";  
       }  
    }  
    MessageBox.Show (s);  
    ```  
  
    ```cpp  
    int i;  
    String ^ s;   
    s = "Checked items:\n" ;  
    for (i = 0; i <= (checkedListBox1->Items->Count-1); i++)  
    {  
       if (checkedListBox1->GetItemChecked(i))  
       {  
          s = String::Concat(s, "Item ", (i+1).ToString(), " = ",  
             checkedListBox1->Item[i]->ToString(), "\n");  
       }  
    }  
    MessageBox::Show(s);  
    ```  
  
## <a name="see-also"></a>См. также

- [Создание списка для выбора элементов в Windows Forms](windows-forms-controls-used-to-list-options.md)
