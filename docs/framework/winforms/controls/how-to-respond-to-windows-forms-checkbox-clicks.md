---
title: Практическое руководство. Обработка события щелчка элемента управления CheckBox в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- Click event [Windows Forms], CheckBox control
- CheckBox control [Windows Forms], Click events
- events [Windows Forms], Click events
- double-clicks
- check boxes [Windows Forms], responding to events
ms.assetid: c39f901e-8899-43b6-aa31-939cbf7089fb
ms.openlocfilehash: ce616f45ceaa3db117c6981d2987ac09bba7b3fb
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59319902"
---
# <a name="how-to-respond-to-windows-forms-checkbox-clicks"></a>Практическое руководство. Обработка события щелчка элемента управления CheckBox в Windows Forms
Каждый раз, когда пользователь щелкает форм Windows <xref:System.Windows.Forms.CheckBox> управления <xref:System.Windows.Forms.Control.Click> событием. Можно программировать приложения для выполнения некоторых операций, в зависимости от состояния флажка.  
  
### <a name="to-respond-to-checkbox-clicks"></a>Реагировать на щелчка элемента управления CheckBox  
  
1. В <xref:System.Windows.Forms.Control.Click> обработчик событий, используйте <xref:System.Windows.Forms.CheckBox.Checked%2A> свойство, чтобы определить состояние элемента управления, а также выполнять любые необходимые действия.  
  
    ```vb  
    Private Sub CheckBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox1.Click  
       ' The CheckBox control's Text property is changed each time the   
       ' control is clicked, indicating a checked or unchecked state.  
       If CheckBox1.Checked = True Then  
          CheckBox1.Text = "Checked"  
       Else  
          CheckBox1.Text = "Unchecked"  
       End If  
    End Sub  
    ```  
  
    ```csharp  
    private void checkBox1_Click(object sender, System.EventArgs e)  
    {  
       // The CheckBox control's Text property is changed each time the   
       // control is clicked, indicating a checked or unchecked state.  
       if (checkBox1.Checked)  
       {  
          checkBox1.Text = "Checked";  
       }  
       else  
       {  
          checkBox1.Text = "Unchecked";  
       }  
    }  
    ```  
  
    ```cpp  
    private:  
       void checkBox1_CheckedChanged(System::Object ^ sender,  
          System::EventArgs ^ e)  
       {  
          if (checkBox1->Checked)  
          {  
             checkBox1->Text = "Checked";  
          }  
          else  
          {  
             checkBox1->Text = "Unchecked";  
          }  
       }  
    ```  
  
    > [!NOTE]
    >  Если пользователь пытается получить дважды щелкните <xref:System.Windows.Forms.CheckBox> элемента управления, каждый щелчок будет обрабатываться отдельно, то есть, <xref:System.Windows.Forms.CheckBox> управления не поддерживает события двойного щелчка.  
  
    > [!NOTE]
    >  Когда <xref:System.Windows.Forms.CheckBox.AutoCheck%2A> свойство `true` (по умолчанию), <xref:System.Windows.Forms.CheckBox> автоматически установлен или снят, при щелчке. В противном случае необходимо вручную задать <xref:System.Windows.Forms.CheckBox.Checked%2A> свойство при <xref:System.Windows.Forms.Control.Click> событием.  
  
     Можно также использовать <xref:System.Windows.Forms.CheckBox> управления, чтобы определить направление дальнейших действий.  
  
### <a name="to-determine-a-course-of-action-when-a-check-box-is-clicked"></a>Чтобы определить порядок действий при типа "флажок" нажата  
  
1. Оператор case для запроса значения <xref:System.Windows.Forms.CheckBox.CheckState%2A> свойства, чтобы определить направление дальнейших действий. Когда <xref:System.Windows.Forms.CheckBox.ThreeState%2A> свойству `true`, <xref:System.Windows.Forms.CheckBox.CheckState%2A> свойство может вернуть три возможных значения, представляющие флажком, поле снятому или сторонним неопределенном состоянии, в котором отображается поле с серым цветом внешний вид, чтобы указать параметр будет недоступен.  
  
    ```vb  
    Private Sub CheckBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox1.Click  
       Select Case CheckBox1.CheckState  
          Case CheckState.Checked  
             ' Code for checked state.  
          Case CheckState.Unchecked  
             ' Code for unchecked state.  
          Case CheckState.Indeterminate  
             ' Code for indeterminate state.  
       End Select   
    End Sub  
    ```  
  
    ```csharp  
    private void checkBox1_Click(object sender, System.EventArgs e)  
    {  
       switch(checkBox1.CheckState)  
       {  
          case CheckState.Checked:  
             // Code for checked state.  
             break;  
          case CheckState.Unchecked:  
             // Code for unchecked state.  
             break;  
          case CheckState.Indeterminate:  
             // Code for indeterminate state.  
             break;  
       }  
    }  
    ```  
  
    ```cpp  
    private:  
       void checkBox1_CheckedChanged(System::Object ^ sender,  
          System::EventArgs ^ e)  
       {  
          switch(checkBox1->CheckState) {  
             case CheckState::Checked:  
                // Code for checked state.  
                break;  
             case CheckState::Unchecked:  
                // Code for unchecked state.  
                break;  
             case CheckState::Indeterminate:  
                // Code for indeterminate state.  
                break;  
          }  
       }  
    ```  
  
    > [!NOTE]
    >  Когда <xref:System.Windows.Forms.CheckBox.ThreeState%2A> свойству `true`, <xref:System.Windows.Forms.CheckBox.Checked%2A> возвращает `true` для обоих <xref:System.Windows.Forms.CheckState.Checked> и <xref:System.Windows.Forms.CheckState.Indeterminate>.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.CheckBox>
- [Общие сведения об элементе управления CheckBox](checkbox-control-overview-windows-forms.md)
- [Практическое руководство. Задание параметров с помощью элементов управления CheckBox в Windows Forms](how-to-set-options-with-windows-forms-checkbox-controls.md)
- [Элемент управления CheckBox](checkbox-control-windows-forms.md)
