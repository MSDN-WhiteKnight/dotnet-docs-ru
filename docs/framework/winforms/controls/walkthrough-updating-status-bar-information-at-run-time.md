---
title: Пошаговое руководство. Обновление строки состояния во время выполнения
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- status bars [Windows Forms], updating at run time
- status bars [Windows Forms], refreshing panels
- StatusBar control [Windows Forms], refreshing panels
- panels [Windows Forms], refreshing status bar
ms.assetid: cc2abb06-c082-49f7-a5a3-2fd1bbcb58d1
ms.openlocfilehash: 7beae9bb886c7c79d4d97375887bfecb0c2a40c1
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59333318"
---
# <a name="walkthrough-updating-status-bar-information-at-run-time"></a>Пошаговое руководство. Обновление строки состояния во время выполнения
> [!IMPORTANT]
>  <xref:System.Windows.Forms.StatusStrip> И <xref:System.Windows.Forms.ToolStripStatusLabel> элементы управления заменяют и расширяют функциональные возможности для <xref:System.Windows.Forms.StatusBar> и <xref:System.Windows.Forms.StatusBarPanel> управляет; Однако <xref:System.Windows.Forms.StatusBar> и <xref:System.Windows.Forms.StatusBarPanel> элементы управления сохраняются для обеспечения обратной совместимости и использования в будущем, если вы Выберите этот параметр.  
  
 Часто программа требует динамического обновления содержимого панелей строки состояния в среде выполнения с учетом изменений в состоянии приложения или других взаимодействий с пользователем. Это обычный способ сообщить пользователям о том, что CAPS LOCK, NUM LOCK или SCROLL LOCK включен, или сообщить ему дату или время в удобном формате.  
  
 В следующем примере используется экземпляр <xref:System.Windows.Forms.StatusBarPanel> класса для размещения часов.  
  
### <a name="to-get-the-status-bar-ready-for-updating"></a>Получение строки состояния, готовой для обновления  
  
1. Создание новой формы Windows Forms.  
  
2. Добавьте элемент управления <xref:System.Windows.Forms.StatusBar> в форму. Подробную информацию см. в разделе [Практическое руководство. Добавление элементов управления в Windows Forms](how-to-add-controls-to-windows-forms.md).  
  
3. Добавьте панель строки состояния для вашей <xref:System.Windows.Forms.StatusBar> элемента управления. Подробную информацию см. в разделе [Практическое руководство. Добавление панелей в элемент управления StatusBar](how-to-add-panels-to-a-statusbar-control.md).  
  
4. Для <xref:System.Windows.Forms.StatusBar> вы добавили в форму элемента управления значение <xref:System.Windows.Forms.StatusBar.ShowPanels%2A> свойства `true`.  
  
5. Добавление форм Windows <xref:System.Windows.Forms.Timer> в форму компонент.  
  
    > [!NOTE]
    >  Windows Forms <xref:System.Windows.Forms.Timer?displayProperty=nameWithType> компонент разработан для среды Windows Forms. Если вам требуется таймер, подходящий для серверной среды, см. раздел [Общие сведения о серверных таймерах](https://docs.microsoft.com/previous-versions/visualstudio/visual-studio-2008/tb9yt5e6(v=vs.90)).  
  
6. Задайте для свойства <xref:System.Windows.Forms.Timer.Enabled%2A> значение `true`.  
  
7. Задайте <xref:System.Windows.Forms.Timer.Interval%2A> свойство <xref:System.Windows.Forms.Timer> значение 30000.  
  
    > [!NOTE]
    >  <xref:System.Windows.Forms.Timer.Interval%2A> Свойство <xref:System.Windows.Forms.Timer> компонент устанавливается равным 30 секундам (30 000 миллисекунд), чтобы гарантировать, отражали точного времени для отображения.  
  
### <a name="to-implement-the-timer-to-update-the-status-bar"></a>Реализация таймера для обновления строки состояния  
  
1. Вставьте следующий код в обработчик событий <xref:System.Windows.Forms.Timer> компонент для обновления панели <xref:System.Windows.Forms.StatusBar> элемента управления.  
  
    ```vb  
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick  
       StatusBar1.Panels(0).Text = Now.ToShortTimeString  
    End Sub  
    ```  
  
    ```csharp  
    private void timer1_Tick(object sender, System.EventArgs e)  
    {  
       statusBar1.Panels[0].Text = DateTime.Now.ToShortTimeString();  
    }  
    ```  
  
    ```cpp  
    private:  
      System::Void timer1_Tick(System::Object ^ sender,  
        System::EventArgs ^ e)  
      {  
        statusBar1->Panels[0]->Text =  
          DateTime::Now.ToShortTimeString();  
      }  
    ```  
  
     Теперь вы готовы запустить приложение и увидеть, как работают часы в панели строки состояния.  
  
### <a name="to-test-the-application"></a>Тестирование приложения  
  
1. Выполните отладку приложения и нажмите клавишу F5, чтобы его запустить. Дополнительные сведения об отладке см. в разделе [Отладка в Visual Studio](/visualstudio/debugger/debugging-in-visual-studio).  
  
    > [!NOTE]
    >  Часы появятся в строке состояния примерно через 30 секунд. Это необходимо для того, чтобы время отображалось максимально точно. И наоборот, чтобы часы появились быстрее, можно уменьшить значение <xref:System.Windows.Forms.Timer.Interval%2A> заданному на шаге 7 в предыдущей процедуре.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.StatusBar>
- <xref:System.Windows.Forms.ToolStripStatusLabel>
- [Практическое руководство. Добавление панелей в элемент управления StatusBar](how-to-add-panels-to-a-statusbar-control.md)
- [Практическое руководство. Идентификация панели элемента управления StatusBar, которую щелкнул пользователь, в Windows Forms](determine-which-panel-wf-statusbar-control-was-clicked.md)
- [Общие сведения об элементе управления StatusBar](statusbar-control-overview-windows-forms.md)
