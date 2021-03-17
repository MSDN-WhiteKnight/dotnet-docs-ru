---
title: Практическое руководство. Блокировка доступа ко вкладкам
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- tab pages [Windows Forms], hiding in forms
- TabControl control [Windows Forms], disabling pages
ms.assetid: adcc6618-8a34-4ee1-bbe3-47e732de6a59
ms.openlocfilehash: 21592fdd74c43d40310e0fcbc96af6565a42e08b
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59336074"
---
# <a name="how-to-disable-tab-pages"></a>Практическое руководство. Блокировка доступа ко вкладкам
В некоторых случаях требуется ограничить доступ к данным, которые можно использовать в приложении Windows Forms. Примером этого могут быть, когда у вас есть данные, отображаемые на страницах вкладок элемента управления вкладки; Администраторы могут иметь сведения на странице вкладки, который требуется запретить гостей или пользователей более низкого уровня.  
  
### <a name="to-disable-tab-pages-programmatically"></a>Чтобы отключить страницы вкладок программными средствами  
  
1. Написание кода для обработки элемента управления вкладка <xref:System.Windows.Forms.TabControl.SelectedIndexChanged> событий. Это событие, возникающее, когда пользователь переходит с одной вкладки к следующему.  
  
2. Проверьте учетные данные. В зависимости от представленной здесь информации, вы можете проверить имя пользователя, который пользователь вошел в систему или другие формы учетные данные перед предоставлением пользователю для просмотра на вкладке.  
  
3. Если пользователь имеет соответствующие учетные данные, отобразите вкладку, которая была нажата. Если пользователь не имеет соответствующие учетные данные, отобразить окно сообщения, или другой элемент пользовательского интерфейса, указывающий, что они не имеют доступ и вернуться на исходную вкладку.  
  
    > [!NOTE]
    >  При реализации этой функции в приложении, можно выполнять проверку учетных данных во время формы <xref:System.Windows.Forms.Form.Load> событий. Это дает возможность скрыть вкладку до отображения пользовательского интерфейса, который является более понятную для программирования. Используемые ниже методы (проверка учетных данных и отключение вкладки в <xref:System.Windows.Forms.TabControl.SelectedIndexChanged> событий) для иллюстративных целей.  
  
4. При необходимости при наличии более двух страниц вкладок, отображения страницы вкладки, отличной от первоначальной.  
  
     В следующем примере <xref:System.Windows.Forms.CheckBox> элемент управления используется вместо проверки учетных данных, в качестве критерия для доступа к вкладке зависит от приложения. Когда <xref:System.Windows.Forms.TabControl.SelectedIndexChanged> событие возникает, если проверка учетных данных имеет значение true (то есть флажок установлен) и выбрана вкладка `TabPage2` (вкладка с конфиденциальными данными, в этом примере), затем `TabPage2` отображается. В противном случае `TabPage3` отображается и отображается окно сообщения об отсутствии необходимых прав доступа. В приведенном ниже коде предполагается, что форма <xref:System.Windows.Forms.CheckBox> управления (`CredentialCheck`) и <xref:System.Windows.Forms.TabControl> элемента управления с тремя вкладками.  
  
    ```vb  
    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged  
       ' Check Credentials Here  
  
       If CredentialCheck.Checked = True And _   
       TabControl1.SelectedTab Is TabPage2 Then  
          TabControl1.SelectedTab = TabPage2  
       ElseIf CredentialCheck.Checked = False _   
       And TabControl1.SelectedTab Is TabPage2 Then  
          MessageBox.Show _   
         ("Unable to load tab. You have insufficient access privileges.")  
          TabControl1.SelectedTab = TabPage3  
       End If  
    End Sub  
    ```  
  
    ```csharp  
    private void tabControl1_SelectedIndexChanged(object sender, System.EventArgs e)  
    {  
        // Check Credentials Here  
  
        if ((CredentialCheck.Checked == true) && (tabControl1.SelectedTab == tabPage2))   
        {  
            tabControl1.SelectedTab = tabPage2;  
        }  
        else if ((CredentialCheck.Checked == false) && (tabControl1.SelectedTab == tabPage2))  
        {  
            MessageBox.Show("Unable to load tab. You have insufficient access privileges.");  
            tabControl1.SelectedTab = tabPage3;  
        }  
    }  
    ```  
  
    ```cpp  
    private:  
       System::Void tabControl1_SelectedIndexChanged(  
          System::Object ^ sender,  
          System::EventArgs ^  e)  
       {  
          // Check Credentials Here  
          if ((CredentialCheck->Checked == true) &&  
              (tabControl1->SelectedTab == tabPage2))  
          {  
             tabControl1->SelectedTab = tabPage2;  
          }  
          else if ((CredentialCheck->Checked == false) &&  
                   (tabControl1->SelectedTab == tabPage2))  
          {  
             MessageBox::Show(String::Concat("Unable to load tab. ",  
                "You have insufficient access privileges."));  
             tabControl1->SelectedTab = tabPage3;  
          }  
       }  
    ```  
  
     (Visual C#, Visual C++) Поместите следующий код в конструктор формы для регистрации обработчика событий.  
  
    ```csharp  
    this.tabControl1.SelectedIndexChanged +=   
       new System.EventHandler(this.tabControl1_SelectedIndexChanged);  
    ```  
  
    ```cpp  
    this->tabControl1->SelectedIndexChanged +=  
       gcnew System::EventHandler(this, &Form1::tabControl1_SelectedIndexChanged);  
    ```  
  
## <a name="see-also"></a>См. также

- [Общие сведения об элементе управления TabControl](tabcontrol-control-overview-windows-forms.md)
- [Практическое руководство. Добавление элемента управления на вкладку](how-to-add-a-control-to-a-tab-page.md)
- [Практическое руководство. Добавление и удаление вкладок с помощью элемента управления TabControl в Windows Forms](how-to-add-and-remove-tabs-with-the-windows-forms-tabcontrol.md)
- [Практическое руководство. Изменение внешнего вида элемента управления TabControl в Windows Forms](how-to-change-the-appearance-of-the-windows-forms-tabcontrol.md)
