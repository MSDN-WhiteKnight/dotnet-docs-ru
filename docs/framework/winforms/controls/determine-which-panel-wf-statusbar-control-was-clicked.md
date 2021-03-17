---
title: Практическое руководство. Идентификация панели элемента управления StatusBar, которую щелкнул пользователь, в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- status bars [Windows Forms], determining panel clicked
- panels [Windows Forms], determining clicked
- StatusBar control [Windows Forms], coding panel click events
- StatusBar control [Windows Forms], determining panel clicked
- PanelClick event [Windows Forms], determining panel clicked
- Panel control [Windows Forms], determining click
ms.assetid: d14c6092-04b2-4a07-8ddf-0dd11277ff5f
ms.openlocfilehash: 1c28f8eaba5c35f762d6fc57ebbddbbb71769c81
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59304289"
---
# <a name="how-to-determine-which-panel-in-the-windows-forms-statusbar-control-was-clicked"></a>Практическое руководство. Идентификация панели элемента управления StatusBar, которую щелкнул пользователь, в Windows Forms
> [!IMPORTANT]
>  <xref:System.Windows.Forms.StatusStrip> И <xref:System.Windows.Forms.ToolStripStatusLabel> элементы управления заменяют и расширяют функциональные возможности для <xref:System.Windows.Forms.StatusBar> и <xref:System.Windows.Forms.StatusBarPanel> управляет; Однако <xref:System.Windows.Forms.StatusBar> и <xref:System.Windows.Forms.StatusBarPanel> элементы управления сохраняются для обеспечения обратной совместимости и использования в будущем, если вы Выберите этот параметр.  
  
 Для программы [элемента управления StatusBar](statusbar-control-windows-forms.md) элемента управления, чтобы отвечать на щелчок пользователя, используйте инструкции case в <xref:System.Windows.Forms.StatusBar.PanelClick> событий. Событие содержит аргумент (аргумент панели), который содержит ссылку на нажатый элемент <xref:System.Windows.Forms.StatusBarPanel>. Используя эту ссылку, можно определить индекс выбранной панели и программировать соответствующим образом.  
  
> [!NOTE]
>  Убедитесь, что <xref:System.Windows.Forms.StatusBar> элемента управления <xref:System.Windows.Forms.StatusBar.ShowPanels%2A> свойству `true`.  
  
### <a name="to-determine-which-panel-was-clicked"></a>Чтобы определить, какая панель была выбрана  
  
1. В <xref:System.Windows.Forms.StatusBar.PanelClick> обработчик событий, используйте `Select Case` (в Visual Basic) или `switch case` (Visual C# или [!INCLUDE[vcprvc](../../../../includes/vcprvc-md.md)]) инструкцию, чтобы определить, какая панель была нажата, путем проверки индекса выбранной панели в аргументах события.  
  
     В следующем примере кода необходимо наличие, в форме из <xref:System.Windows.Forms.StatusBar> управления `StatusBar1`и два <xref:System.Windows.Forms.StatusBarPanel> объектов, `StatusBarPanel1` и `StatusBarPanel2`.  
  
    ```vb  
    Private Sub StatusBar1_PanelClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.StatusBarPanelClickEventArgs) Handles StatusBar1.PanelClick  
       Select Case StatusBar1.Panels.IndexOf(e.StatusBarPanel)  
         Case 0  
           MessageBox.Show("You have clicked Panel One.")  
         Case 1  
           MessageBox.Show("You have clicked Panel Two.")  
       End Select  
    End Sub  
    ```  
  
    ```csharp  
    private void statusBar1_PanelClick(object sender,   
    System.Windows.Forms.StatusBarPanelClickEventArgs e)  
    {  
       switch (statusBar1.Panels.IndexOf(e.StatusBarPanel))  
       {  
          case 0 :  
             MessageBox.Show("You have clicked Panel One.");  
             break;  
          case 1 :  
             MessageBox.Show("You have clicked Panel Two.");  
             break;  
       }  
    }  
    ```  
  
    ```cpp  
    private:  
       void statusBar1_PanelClick(System::Object ^  sender,  
          System::Windows::Forms::StatusBarPanelClickEventArgs ^  e)  
       {  
          switch (statusBar1->Panels->IndexOf(e->StatusBarPanel))  
          {  
             case 0 :  
                MessageBox::Show("You have clicked Panel One.");  
                break;  
             case 1 :  
                MessageBox::Show("You have clicked Panel Two.");  
                break;  
          }  
       }  
    ```  
  
     (Visual C# [!INCLUDE[vcprvc](../../../../includes/vcprvc-md.md)]) поместите следующий код в конструктор формы для регистрации обработчика событий.  
  
    ```csharp  
    this.statusBar1.PanelClick += new   
       System.Windows.Forms.StatusBarPanelClickEventHandler   
       (this.statusBar1_PanelClick);  
    ```  
  
    ```cpp  
    this->statusBar1->PanelClick += gcnew  
       System::Windows::Forms::StatusBarPanelClickEventHandler  
       (this, &Form1::statusBar1_PanelClick);  
    ```  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.StatusBar>
- <xref:System.Windows.Forms.ToolStripStatusLabel>
- [Практическое руководство. Определение размера панелей строки состояния](how-to-set-the-size-of-status-bar-panels.md)
- [Пошаговое руководство. Обновление строки состояния во время выполнения](walkthrough-updating-status-bar-information-at-run-time.md)
- [Общие сведения об элементе управления StatusBar](statusbar-control-overview-windows-forms.md)
