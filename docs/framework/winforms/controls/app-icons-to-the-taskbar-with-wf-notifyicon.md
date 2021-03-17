---
title: Практическое руководство. Добавление значков приложения на панель задач с помощью компонента NotifyIcon в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
f1_keywords:
- TrayIcon
helpviewer_keywords:
- status area icons
- icons [Windows Forms], adding to taskbar
- NotifyIcon component
- taskbar [Windows Forms], adding icons
ms.assetid: d28c0fe6-aaf2-4df7-ad74-928d861a8510
ms.openlocfilehash: 52c18b959361079aac6b95dc5d4584bf464a306a
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59304523"
---
# <a name="how-to-add-application-icons-to-the-taskbar-with-the-windows-forms-notifyicon-component"></a>Практическое руководство. Добавление значков приложения на панель задач с помощью компонента NotifyIcon в Windows Forms
Windows Forms <xref:System.Windows.Forms.NotifyIcon> компонент отображает один значок в области уведомлений панели задач. Чтобы отобразить несколько значков в области состояния, необходимо иметь несколько <xref:System.Windows.Forms.NotifyIcon> компонентов в форме. Чтобы задать значок, отображаемый для элемента управления, используйте <xref:System.Windows.Forms.NotifyIcon.Icon%2A> свойство. Можно также написать код <xref:System.Windows.Forms.NotifyIcon.DoubleClick> обработчик событий, так что-то происходит, когда пользователь дважды щелкает значок. Например вы можете создать диалоговое окно отображается для пользователя настроить фоновый процесс, представленный этим значком.  
  
> [!NOTE]
>  <xref:System.Windows.Forms.NotifyIcon> Компонент используется только, чтобы оповестить пользователей о возникших на действие или событие, или произошло изменение в состоянии какого-либо рода. Следует использовать меню, панелей инструментов и других элементов пользовательского интерфейса для стандартное взаимодействие с приложениями.  
  
### <a name="to-set-the-icon"></a>Чтобы задать значок  
  
1. Присвойте значение <xref:System.Windows.Forms.NotifyIcon.Icon%2A> свойства. Значение должно быть типа `System.Drawing.Icon` и может быть загружена из ICO-файл. Файл значка можно указать в коде или нажав кнопку с многоточием (![экрана VisualStudioEllipsesButton](../media/vbellipsesbutton.png "vbEllipsesButton")) рядом с полем <xref:System.Windows.Forms.NotifyIcon.Icon%2A> свойство в  **Свойства** окна, а затем выбрав файл в **откройте** диалоговое окно, которое отображается.  
  
2. Задайте для свойства <xref:System.Windows.Forms.NotifyIcon.Visible%2A> значение `true`.  
  
3. Задайте <xref:System.Windows.Forms.NotifyIcon.Text%2A> свойство соответствующую строку всплывающей подсказки.  
  
     В следующем примере кода, задайте путь — расположение значка **Мои документы** папки. Это расположение используется в том случае, так как можно предположить, что большинство компьютеров под управлением ОС Windows будет включать эту папку. Эта папка также позволяет уровень доступа к минимальным системе безопасно запускать приложение. В следующем примере требуется форма с <xref:System.Windows.Forms.NotifyIcon> управления уже добавлен. Он также требуется файл значка с именем `Icon.ico`.  
  
    ```vb  
    ' You should replace the bold icon in the sample below  
    ' with an icon of your own choosing.  
    NotifyIcon1.Icon = New _   
       System.Drawing.Icon(System.Environment.GetFolderPath _  
       (System.Environment.SpecialFolder.Personal) _  
       & "\Icon.ico")  
    NotifyIcon1.Visible = True  
    NotifyIcon1.Text = "Antivirus program"  
    ```  
  
    ```csharp  
    // You should replace the bold icon in the sample below  
    // with an icon of your own choosing.  
    // Note the escape character used (@) when specifying the path.  
    notifyIcon1.Icon =   
       new System.Drawing.Icon (System.Environment.GetFolderPath  
       (System.Environment.SpecialFolder.Personal)  
       + @"\Icon.ico");  
    notifyIcon1.Visible = true;  
    notifyIcon1.Text = "Antivirus program";  
    ```  
  
    ```cpp  
    // You should replace the bold icon in the sample below  
    // with an icon of your own choosing.  
    notifyIcon1->Icon = gcnew   
       System::Drawing::Icon(String::Concat  
       (System::Environment::GetFolderPath  
       (System::Environment::SpecialFolder::Personal),  
       "\\Icon.ico"));  
    notifyIcon1->Visible = true;  
    notifyIcon1->Text = "Antivirus program";  
    ```  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.NotifyIcon>
- <xref:System.Windows.Forms.NotifyIcon.Icon%2A>
- [Практическое руководство. Связывание контекстного меню с компонентом NotifyIcon в Windows Forms](how-to-associate-a-shortcut-menu-with-a-windows-forms-notifyicon-component.md)
- [Компонент NotifyIcon](notifyicon-component-windows-forms.md)
- [Общие сведения о компоненте управления NotifyIcon](notifyicon-component-overview-windows-forms.md)
