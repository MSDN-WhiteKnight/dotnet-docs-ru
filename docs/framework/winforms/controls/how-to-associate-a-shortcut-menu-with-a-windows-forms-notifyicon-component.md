---
title: Практическое руководство. Связывание контекстного меню с компонентом NotifyIcon в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- context menus [Windows Forms], for background processes
- NotifyIcon component [Windows Forms], associating shortcut menus
- shortcut menus [Windows Forms], for background processes
ms.assetid: d68f3926-08d3-4f7d-949f-1981b29cf188
ms.openlocfilehash: f2a086cc25eb6996b2643742a887bccf481916d6
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59337062"
---
# <a name="how-to-associate-a-shortcut-menu-with-a-windows-forms-notifyicon-component"></a>Практическое руководство. Связывание контекстного меню с компонентом NotifyIcon в Windows Forms
> [!NOTE]
>  Несмотря на то что <xref:System.Windows.Forms.MenuStrip> и <xref:System.Windows.Forms.ContextMenuStrip> заменяют и расширяют функциональные возможности для <xref:System.Windows.Forms.MainMenu> и <xref:System.Windows.Forms.ContextMenu> элементы управления из предыдущих версий <xref:System.Windows.Forms.MainMenu> и <xref:System.Windows.Forms.ContextMenu> можно сохранить для обратной совместимости и использования в будущем, если выбран.  
  
 <xref:System.Windows.Forms.NotifyIcon> Компонента в области уведомлений панели задач отображается значок. Как правило приложения позволяют щелкните правой кнопкой мыши этот значок, чтобы отправлять команды в приложение, которое она представляет. Связав <xref:System.Windows.Forms.ContextMenu> компонент <xref:System.Windows.Forms.NotifyIcon> компонент, эти функции можно добавить в приложения.  
  
> [!NOTE]
>  Если требуется обновлять приложение, чтобы свести к минимуму во время запуска при отображении экземпляра <xref:System.Windows.Forms.NotifyIcon> набор компонентов на панели задач главной формы <xref:System.Windows.Forms.Form.WindowState%2A> свойства <xref:System.Windows.Forms.FormWindowState.Minimized> и убедитесь, что <xref:System.Windows.Forms.NotifyIcon> компонента <xref:System.Windows.Forms.NotifyIcon.Visible%2A> свойство имеет значение `true`.  
  
### <a name="to-associate-a-shortcut-menu-with-the-notifyicon-component-at-design-time"></a>Чтобы связать контекстное меню с компонентом NotifyIcon во время разработки  
  
1. Добавить <xref:System.Windows.Forms.NotifyIcon> форму, компоненты и установить важные свойства, такие как <xref:System.Windows.Forms.NotifyIcon.Icon%2A> и <xref:System.Windows.Forms.NotifyIcon.Visible%2A> свойства.  
  
     Дополнительные сведения см. в разделе [Как Добавление значков приложения на панель задач с Windows Forms компонентом NotifyIcon](app-icons-to-the-taskbar-with-wf-notifyicon.md).  
  
2. Добавление <xref:System.Windows.Forms.ContextMenu> компонента в форму Windows.  
  
     Добавление элементов меню в контекстное меню, представляющий команды, что вы хотите сделать доступными во время выполнения. Это хорошая возможность добавить меню усовершенствования этих пунктов меню, таких как ключи доступа.  
  
3. Задайте <xref:System.Windows.Forms.NotifyIcon.ContextMenu%2A> свойство <xref:System.Windows.Forms.NotifyIcon> компонент в контекстном меню, который был добавлен.  
  
     При щелчке значка на панели задач, отображается в контекстном меню.  
  
### <a name="to-associate-a-shortcut-menu-with-the-notifyicon-component-programmatically"></a>Чтобы связать контекстное меню с компонентом NotifyIcon программным способом  
  
1. Создайте экземпляр <xref:System.Windows.Forms.NotifyIcon> класс и <xref:System.Windows.Forms.ContextMenu> класса, независимо от параметров свойств, необходимые для приложения (<xref:System.Windows.Forms.NotifyIcon.Icon%2A> и <xref:System.Windows.Forms.NotifyIcon.Visible%2A> свойства <xref:System.Windows.Forms.NotifyIcon> компонент, пункты меню для <xref:System.Windows.Forms.ContextMenu> компонент).  
  
2. Задайте <xref:System.Windows.Forms.NotifyIcon.ContextMenu%2A> свойство <xref:System.Windows.Forms.NotifyIcon> компонент в контекстном меню, который был добавлен.  
  
     При щелчке значка на панели задач, отображается в контекстном меню.  
  
    > [!NOTE]
    >  В следующем примере кода создается базовая структура меню. Необходимо будет настроить доступные меню, разрабатываемого приложения вы разрабатываете. Кроме того, необходимо написать код для обработки <xref:System.Windows.Forms.MenuItem.Click> события для этих пунктов меню.  
  
    ```vb  
    Public ContextMenu1 As New ContextMenu  
    Public NotifyIcon1 As New NotifyIcon  
  
    Public Sub CreateIconMenuStructure()  
       ' Add menu items to shortcut menu.  
       ContextMenu1.MenuItems.Add("&Open Application")  
       ContextMenu1.MenuItems.Add("S&uspend Application")  
       ContextMenu1.MenuItems.Add("E&xit")  
  
       ' Set properties of NotifyIcon component.  
       NotifyIcon1.Icon = New System.Drawing.Icon _   
          (System.Environment.GetFolderPath _   
          (System.Environment.SpecialFolder.Personal)  _   
          & "\Icon.ico")  
       NotifyIcon1.Text = "Right-click me!"  
       NotifyIcon1.Visible = True  
       NotifyIcon1.ContextMenu = ContextMenu1  
    End Sub  
    ```  
  
```csharp  
public NotifyIcon notifyIcon1 = new NotifyIcon();  
public ContextMenu contextMenu1 = new ContextMenu();  
  
public void createIconMenuStructure()  
{  
   // Add menu items to shortcut menu.  
   contextMenu1.MenuItems.Add("&Open Application");  
   contextMenu1.MenuItems.Add("S&uspend Application");  
   contextMenu1.MenuItems.Add("E&xit");  
  
   // Set properties of NotifyIcon component.  
   notifyIcon1.Icon = new System.Drawing.Icon  
      (System.Environment.GetFolderPath  
      (System.Environment.SpecialFolder.Personal)  
      + @"\Icon.ico");  
   notifyIcon1.Visible = true;  
   notifyIcon1.Text = "Right-click me!";  
   notifyIcon1.Visible = true;  
   notifyIcon1.ContextMenu = contextMenu1;  
}  
```  
  
```cpp  
public:  
   System::Windows::Forms::NotifyIcon ^ notifyIcon1;  
   System::Windows::Forms::ContextMenu ^ contextMenu1;  
  
   void createIconMenuStructure()  
   {  
      // Add menu items to shortcut menu.  
      contextMenu1->MenuItems->Add("&Open Application");  
      contextMenu1->MenuItems->Add("S&uspend Application");  
      contextMenu1->MenuItems->Add("E&xit");  
  
      // Set properties of NotifyIcon component.  
      notifyIcon1->Icon = gcnew System::Drawing::Icon  
          (String::Concat(System::Environment::GetFolderPath  
          (System::Environment::SpecialFolder::Personal),  
          "\\Icon.ico"));  
      notifyIcon1->Text = "Right-click me!";  
      notifyIcon1->Visible = true;  
      notifyIcon1->ContextMenu = contextMenu1;  
   }  
```  
  
> [!NOTE]
>  Необходимо инициализировать `notifyIcon1` и `contextMenu1,` что можно сделать, включив следующие инструкции в конструктор формы:  
  
```cpp  
notifyIcon1 = gcnew System::Windows::Forms::NotifyIcon();  
contextMenu1 = gcnew System::Windows::Forms::ContextMenu();  
```  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.NotifyIcon>
- <xref:System.Windows.Forms.NotifyIcon.Icon%2A>
- [Практическое руководство. Добавление значков приложения на панель задач с помощью компонента NotifyIcon в Windows Forms](app-icons-to-the-taskbar-with-wf-notifyicon.md)
- [Компонент NotifyIcon](notifyicon-component-windows-forms.md)
- [Общие сведения о компоненте управления NotifyIcon](notifyicon-component-overview-windows-forms.md)
