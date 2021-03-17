---
title: Практическое руководство. Отображение значков ошибок при проверке введенных в форму данных с помощью компонента ErrorProvider в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- errors [Windows Forms], displaying to users
- error icons
- ErrorProvider component [Windows Forms], displaying error icons
- error messages [Windows Forms], displaying icons
ms.assetid: 3b681a32-9db4-497b-a34b-34980eabee46
ms.openlocfilehash: 9487d4f82878ffefe17c576b16f654293ef01106
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59316509"
---
# <a name="how-to-display-error-icons-for-form-validation-with-the-windows-forms-errorprovider-component"></a>Практическое руководство. Отображение значков ошибок при проверке введенных в форму данных с помощью компонента ErrorProvider в Windows Forms
Вы можете использовать формы Windows <xref:System.Windows.Forms.ErrorProvider> компонент для отображения значка ошибки, когда пользователь вводит недопустимые данные. Необходимо иметь по крайней мере два элемента управления в форме для перехода между ними и тем самым вызвать код проверки.  
  
### <a name="to-display-an-error-icon-when-a-controls-value-is-invalid"></a>Для отображения значков ошибок при недопустимом значение элемента управления  
  
1. Добавьте два элемента управления, например, текстовые поля, в форму Windows.  
  
2. Добавить <xref:System.Windows.Forms.ErrorProvider> в форму компонент.  
  
3. Выберите первый элемент управления и добавьте код для его <xref:System.Windows.Forms.Control.Validating> обработчик событий. Чтобы этот код для запуска должным образом процедура должны быть подключены к событию. Дополнительные сведения см. в разделе [Как Создание обработчиков событий во время выполнения для форм Windows Forms](../how-to-create-event-handlers-at-run-time-for-windows-forms.md).  
  
     Следующий код проверяет допустимость данных, которые пользователь ввел; Если данные являются недопустимыми, <xref:System.Windows.Forms.ErrorProvider.SetError%2A> вызывается метод. Первый аргумент <xref:System.Windows.Forms.ErrorProvider.SetError%2A> метод указывает, какой элемент управления для отображения значка рядом с полем. Вторым аргументом является текст ошибки для отображения.  
  
    ```vb  
    Private Sub TextBox1_Validating(ByVal Sender As Object, _  
       ByVal e As System.ComponentModel.CancelEventArgs) Handles _  
       TextBox1.Validating  
          If Not IsNumeric(TextBox1.Text) Then  
             ErrorProvider1.SetError(TextBox1, "Not a numeric value.")  
          Else  
             ' Clear the error.  
             ErrorProvider1.SetError(TextBox1, "")  
          End If  
    End Sub  
    ```  
  
    ```csharp  
    protected void textBox1_Validating (object sender,  
       System.ComponentModel.CancelEventArgs e)  
    {  
       try  
       {  
          int x = Int32.Parse(textBox1.Text);  
          errorProvider1.SetError(textBox1, "");  
       }  
       catch (Exception ex)  
       {  
          errorProvider1.SetError(textBox1, "Not an integer value.");  
       }  
    }  
    ```  
  
    ```cpp  
    private:  
       System::Void textBox1_Validating(System::Object ^  sender,  
          System::ComponentModel::CancelEventArgs ^  e)  
       {  
          try  
          {  
             int x = Int32::Parse(textBox1->Text);  
             errorProvider1->SetError(textBox1, "");  
          }  
          catch (System::Exception ^ ex)  
          {  
             errorProvider1->SetError(textBox1, "Not an integer value.");  
          }  
       }  
    ```  
  
     (Visual C# [!INCLUDE[vcprvc](../../../../includes/vcprvc-md.md)]) поместите следующий код в конструктор формы для регистрации обработчика событий.  
  
    ```csharp  
    this.textBox1.Validating += new  
    System.ComponentModel.CancelEventHandler(this.textBox1_Validating);  
    ```  
  
    ```cpp  
    this->textBox1->Validating += gcnew  
       System::ComponentModel::CancelEventHandler  
       (this, &Form1::textBox1_Validating);  
    ```  
  
4. Запустите проект. Введите недопустимые (в этом примере нечисловые) данные в первый элемент управления, а затем перейдите ко второму. Если отображается значок ошибки, установите на нем указателя мыши, чтобы просмотреть текст ошибки.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.ErrorProvider.SetError%2A>
- [Общие сведения о компоненте ErrorProvider](errorprovider-component-overview-windows-forms.md)
- [Практическое руководство. Индикация ошибок данных, содержащихся в объекте DataSet, с помощью компонента ErrorProvider в Windows Forms](view-errors-within-a-dataset-with-wf-errorprovider-component.md)
