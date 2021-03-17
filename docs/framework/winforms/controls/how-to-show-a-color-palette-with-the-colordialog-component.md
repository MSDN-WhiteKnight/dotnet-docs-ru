---
title: Практическое руководство. Отображение цветовой палитры с помощью компонента ColorDialog
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- palettes [Windows Forms], showing color
- color dialog box [Windows Forms], showing color palettes
- colors [Windows Forms], allowing users to select
- color palettes [Windows Forms], dialog box
- ColorDialog component [Windows Forms], showing color palettes
- color palettes [Windows Forms], showing in ColorDialog component
- colors [Windows Forms], showing palettes
ms.assetid: ee050f61-dbc8-4436-ba22-51360981ab48
ms.openlocfilehash: 587b2c3a502ec8a1cb2f4f7c0d981baa0f18ead6
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59298023"
---
# <a name="how-to-show-a-color-palette-with-the-colordialog-component"></a>Практическое руководство. Отображение цветовой палитры с помощью компонента ColorDialog
[ColorDialog](colordialog-component-windows-forms.md) компонент отображает палитру цветов и возвращает свойство, содержащее цвет, выбранном пользователем.  
  
### <a name="to-choose-a-color-using-the-colordialog-component"></a>Чтобы выбрать цвет с помощью компонента ColorDialog  
  
1. Отобразить диалоговое окно с помощью <xref:System.Windows.Forms.CommonDialog.ShowDialog%2A> метод.  
  
2. Используйте <xref:System.Windows.Forms.DialogResult> свойства, чтобы определить, как окно было закрыто.  
  
3. Используйте <xref:System.Windows.Forms.ColorDialog.Color%2A> свойство <xref:System.Windows.Forms.ColorDialog> компонента для присвоения выбранный цвет.  
  
     В следующем примере <xref:System.Windows.Forms.Button> элемента управления <xref:System.Windows.Forms.Control.Click> обработчик событий открывает <xref:System.Windows.Forms.ColorDialog> компонента. Если цвет — выбран и пользователь нажимает **ОК**, <xref:System.Windows.Forms.Button> цвет фона элемента управления имеет значение на выбранный цвет. В примере предполагается, в форме есть <xref:System.Windows.Forms.Button> управления и <xref:System.Windows.Forms.ColorDialog> компонента.  
  
    ```vb  
    Private Sub Button1_Click(ByVal sender As System.Object, _  
    ByVal e As System.EventArgs) Handles Button1.Click  
       If ColorDialog1.ShowDialog() = DialogResult.OK Then  
          Button1.BackColor = ColorDialog1.Color  
       End If  
    End Sub  
    ```  
  
    ```csharp  
    private void button1_Click(object sender, System.EventArgs e)  
    {  
       if(colorDialog1.ShowDialog() == DialogResult.OK)  
       {  
          button1.BackColor = colorDialog1.Color;  
       }  
    }  
    ```  
  
    ```cpp  
    private:  
       void button1_Click(System::Object ^ sender,   
          System::EventArgs ^ e)  
       {  
          if(colorDialog1->ShowDialog() == DialogResult::OK)  
          {  
             button1->BackColor = colorDialog1->Color;  
          }  
       }  
    ```  
  
     (Visual C# [!INCLUDE[vcprvc](../../../../includes/vcprvc-md.md)]) поместите следующий код в конструктор формы для регистрации обработчика событий.  
  
    ```csharp  
    this.button1.Click += new System.EventHandler(this.button1_Click);  
    ```  
  
    ```cpp  
    this->button1->Click +=   
       gcnew System::EventHandler(this, &Form1::button1_Click);  
    ```  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.ColorDialog>
- [Компонент ColorDialog](colordialog-component-windows-forms.md)
