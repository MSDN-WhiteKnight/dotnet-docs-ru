---
title: Практическое руководство. Отображение диалоговых окон для Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- Windows Forms, displaying
- Windows Forms dialog boxes [Windows Forms], displaying
- Windows Forms, calling one form from another
- dialog boxes [Windows Forms], displaying for Windows Forms
ms.assetid: aaac1b38-c651-495a-8d3d-5a9bfb32fee3
ms.openlocfilehash: b99f2273dae88faf86448da6e1d2986a83803abf
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59311088"
---
# <a name="how-to-display-dialog-boxes-for-windows-forms"></a>Практическое руководство. Отображение диалоговых окон для Windows Forms
Отображать диалоговое окно таким же образом, как отобразить любые другие формы в приложении. Начальная форма загружается автоматически при запуске приложения. Чтобы сделать вторую форму или диалоговое окно отображаться в приложении, напишите код для загрузки и отображения. Аналогичным образом чтобы форма или диалоговое окно поле исчезают, напишите код для выгрузки его или скрывать.  
  
### <a name="to-display-a-dialog-box"></a>Чтобы отобразить диалоговое окно  
  
1. Перейдите к обработчику событий, с которым вы хотите открыть диалоговое окно. Это может произойти при выборе команды меню, при нажатии кнопки или при возникновении любого другого события.  
  
2. В обработчике событий добавьте код, чтобы открыть диалоговое окно. В этом примере событие нажатия кнопки используется для отображения диалогового окна:  
  
    ```vb  
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click  
       Dim dlg1 as new Form()  
       dlg1.ShowDialog()  
    End Sub  
    ```  
  
    ```csharp  
    private void button1_Click(object sender, System.EventArgs e)   
    {  
       Form dlg1 = new Form();  
       dlg1.ShowDialog();  
    }  
    ```  
  
    ```cpp  
    private:   
      void button1_Click(System::Object ^ sender,  
        System::EventArgs ^ e)  
      {  
        Form ^ dlg1 = gcnew Form();  
        dlg1->ShowDialog();  
      }  
    ```
