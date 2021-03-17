---
title: Дополнительные вопросы безопасности в формах Windows Forms
ms.date: 03/30/2017
helpviewer_keywords:
- Windows Forms, secure calls to Windows API
- security [Windows Forms]
- security [Windows Forms], calling APIs
- Clipboard [Windows Forms], securing access
ms.assetid: 15abda8b-0527-47c7-aedb-77ab595f2bf1
ms.openlocfilehash: a101b5838b843f0130d16aab6eb199c7a54ca6b9
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59139533"
---
# <a name="additional-security-considerations-in-windows-forms"></a>Дополнительные вопросы безопасности в формах Windows Forms
[!INCLUDE[dnprdnshort](../../../includes/dnprdnshort-md.md)] параметры безопасности может привести к вашему приложению работать по-разному в среде с частичным доверием на локальном компьютере. [!INCLUDE[dnprdnshort](../../../includes/dnprdnshort-md.md)] ограничивает доступ, помимо прочего, к таким важным локальным ресурсам, как файловая система, сеть и неуправляемые API. Параметры безопасности влияют на возможность вызова Microsoft Windows API или другие API, которые не могут быть проверены системой безопасности. Безопасность также влияет на другие аспекты приложения, включая доступ к файлам и данным, и вывод на печать. Дополнительные сведения о доступе к файлам и данным в среде с частичным доверием см. в разделе [Более безопасный доступ к файлам и данным в Windows Forms](more-secure-file-and-data-access-in-windows-forms.md). Дополнительные сведения о выводе на печать в среде с частичным доверием см. в разделе [Более безопасная печать в Windows Forms](more-secure-printing-in-windows-forms.md).  
  
 В следующих разделах рассматриваются способы работы с буфером обмена, окнами и вызов Windows API из приложений, работающих в среде с частичным доверием.  
  
## <a name="clipboard-access"></a>Доступ к буферу обмена  
 <xref:System.Security.Permissions.UIPermission> Класс управляет доступом к буфера обмена, а также <xref:System.Security.Permissions.UIPermissionClipboard> значение перечисления указывает уровень доступа. В следующей таблице приведены возможные уровни разрешения.  
  
|Значение UIPermissionClipboard|Описание|  
|---------------------------------|-----------------|  
|<xref:System.Security.Permissions.UIPermissionClipboard.AllClipboard>|Буфер обмена можно использовать без ограничений.|  
|<xref:System.Security.Permissions.UIPermissionClipboard.OwnClipboard>|Буфер обмена можно использовать с некоторыми ограничениями. Возможность размещения данных в буфере обмена (операции с командами копирования и вырезания) не ограничена. Встроенные элементы управления, которые принимают операцию вставки, например текстовое поле, могут принимать данные из буфера обмена, но пользовательские элементы управления не могут программно считывать данные из буфера обмена.|  
|<xref:System.Security.Permissions.UIPermissionClipboard.NoClipboard>|Буфер обмена использовать нельзя.|  
  
 По умолчанию в зону локальной интрасети получает <xref:System.Security.Permissions.UIPermissionClipboard.AllClipboard> доступа и зона Интернета получает <xref:System.Security.Permissions.UIPermissionClipboard.OwnClipboard> доступа. Это означает, что приложение может копировать данные в буфер обмена, но не может программно вставлять или считывать данные из буфера обмена. Благодаря таким ограничениям программы, не имеющие полного доверия, не могут считывать содержимое из буфера обмена, скопированное другим приложением. Если приложению требуется полный доступ к буферу обмена, но у вас нет соответствующих разрешений, для приложения необходимо повысить уровень разрешений. Дополнительные сведения о повышении уровня разрешений см. в разделе [Общее администрирование политик безопасности](https://docs.microsoft.com/previous-versions/dotnet/netframework-4.0/ed5htz45(v=vs.100)).  
  
## <a name="window-manipulation"></a>Управление окнами  
 <xref:System.Security.Permissions.UIPermission> Класс также управляет разрешениями для выполнения работы с окнами и других действий, связанных с пользовательского интерфейса, а также <xref:System.Security.Permissions.UIPermissionWindow> значение перечисления указывает уровень доступа. В следующей таблице приведены возможные уровни разрешения.  
  
 По умолчанию в зону локальной интрасети получает <xref:System.Security.Permissions.UIPermissionWindow.AllWindows> доступа и зона Интернета получает <xref:System.Security.Permissions.UIPermissionWindow.SafeTopLevelWindows> доступа. Это означает, что в зоне Интернета приложение может выполнять большинство операций с окнами и пользовательским интерфейсом, но внешний вид окна будет изменяться. В измененном окне при первом запуске отображается всплывающее уведомление. В таком окне также изменен заголовок, а в строке заголовка должна быть кнопка "Закрыть". Всплывающее уведомление и строка заголовка информируют пользователя приложения о том, что данное приложение выполняется в режиме частичного доверия.  
  
|Значение UIPermissionWindow|Описание|  
|------------------------------|-----------------|  
|<xref:System.Security.Permissions.UIPermissionWindow.AllWindows>|Пользователи могут использовать все окна и события пользовательского ввода без каких-либо ограничений.|  
|<xref:System.Security.Permissions.UIPermissionWindow.SafeTopLevelWindows>|Пользователи могут использовать для рисования только более безопасные окна верхнего уровня и дочерние окна, а также события пользовательского ввода для пользовательского интерфейса в таких окнах и дочерних окнах. Такие более безопасные окна имеют специальные метки, а также ограничения на минимальный и максимальный размер. Эти ограничения предотвращают потенциально опасные атаки с подменой, такие как имитация экрана входа в систему или рабочего стола системы и ограничивают программный доступ к родительским windows API, связанные с фокусом и использование <xref:System.Windows.Forms.ToolTip> элемента управления,|  
|<xref:System.Security.Permissions.UIPermissionWindow.SafeSubWindows>|Пользователи могут использовать для рисования только более безопасные дочерние окна, а также события пользовательского ввода для пользовательского интерфейса в таких дочерних окнах. Примером такого более безопасного дочернего окна является элемент управления, отображаемый в браузере.|  
|<xref:System.Security.Permissions.UIPermissionWindow.NoWindows>|Пользователи не могут использовать никакие окна и события пользовательского интерфейса. Пользовательский интерфейс использовать нельзя.|  
  
 Каждый уровень разрешений, определенный <xref:System.Security.Permissions.UIPermissionWindow> перечисление позволяет выполнять меньшее количество действий, чем на уровень выше. В следующих таблицах указаны действия, которые ограничены <xref:System.Security.Permissions.UIPermissionWindow.SafeTopLevelWindows> и <xref:System.Security.Permissions.UIPermissionWindow.SafeSubWindows> значения. Точные разрешения, необходимые для каждого члена, представлены в справочном разделе для этого члена в документации по библиотеке классов .NET Framework.  
  
 <xref:System.Security.Permissions.UIPermissionWindow.SafeTopLevelWindows> разрешение ограничивает действия, приведенные в следующей таблице.  
  
|Компонент|Ограниченные действия|  
|---------------|------------------------|  
|<xref:System.Windows.Forms.Application>|— Задание значения для свойства <xref:System.Windows.Forms.Application.SafeTopLevelCaptionFormat%2A>.|  
|<xref:System.Windows.Forms.Control>|— Получение <xref:System.Windows.Forms.Control.Parent%2A> свойство.<br />— Задание значения для свойства `Region`.<br />— Вызов <xref:System.Windows.Forms.Control.FindForm%2A> , <xref:System.Windows.Forms.Control.Focus%2A>, <xref:System.Windows.Forms.Control.FromChildHandle%2A> и <xref:System.Windows.Forms.Control.FromHandle%2A>, <xref:System.Windows.Forms.Control.PreProcessMessage%2A>, <xref:System.Windows.Forms.Control.ReflectMessage%2A>, или <xref:System.Windows.Forms.Control.SetTopLevel%2A> метод.<br />— Вызов <xref:System.Windows.Forms.Control.GetChildAtPoint%2A> метод, если возвращенный элемент управления не является дочерним элементом вызывающего элемента управления.<br />— Изменение фокуса элемента управления в контейнерном элементе управления.|  
|<xref:System.Windows.Forms.Cursor>|— Задание значения для свойства <xref:System.Windows.Forms.Cursor.Clip%2A>.<br />— Вызов <xref:System.Windows.Forms.Control.Hide%2A> метод.|  
|<xref:System.Windows.Forms.DataGrid>|— Вызов <xref:System.Windows.Forms.ContainerControl.ProcessTabKey%2A> метод.|  
|<xref:System.Windows.Forms.Form>|— Получение <xref:System.Windows.Forms.Form.ActiveForm%2A> или <xref:System.Windows.Forms.Form.MdiParent%2A> свойство.<br />— Задание <xref:System.Windows.Forms.Form.ControlBox%2A>, <xref:System.Windows.Forms.Form.ShowInTaskbar%2A>, или <xref:System.Windows.Forms.Form.TopMost%2A> свойство.<br />— Задание <xref:System.Windows.Forms.Form.Opacity%2A> свойство ниже 50%.<br />— Задание <xref:System.Windows.Forms.Form.WindowState%2A> свойства <xref:System.Windows.Forms.FormWindowState.Minimized> программным способом.<br />— Вызов <xref:System.Windows.Forms.Form.Activate%2A> метод.<br />— Использование <xref:System.Windows.Forms.FormBorderStyle.None>, <xref:System.Windows.Forms.FormBorderStyle.FixedToolWindow>, и <xref:System.Windows.Forms.FormBorderStyle.SizableToolWindow><xref:System.Windows.Forms.FormBorderStyle> значений перечисления.|  
|<xref:System.Windows.Forms.NotifyIcon>|— Использование <xref:System.Windows.Forms.NotifyIcon> компонент полностью запрещено.|  
  
 <xref:System.Security.Permissions.UIPermissionWindow.SafeSubWindows> Ограничивает действия, перечисленные в следующей таблице, кроме ограничений, налагаемых по <xref:System.Security.Permissions.UIPermissionWindow.SafeTopLevelWindows> значение.  
  
|Компонент|Ограниченные действия|  
|---------------|------------------------|  
|<xref:System.Windows.Forms.CommonDialog>|-Отображение диалогового окна производным от <xref:System.Windows.Forms.CommonDialog> класса.|  
|<xref:System.Windows.Forms.Control>|— Вызов <xref:System.Windows.Forms.Control.CreateGraphics%2A> метод.<br />— Задание значения для свойства <xref:System.Windows.Forms.Control.Cursor%2A>.|  
|<xref:System.Windows.Forms.Control.Cursor%2A>|— Задание значения для свойства <xref:System.Windows.Forms.Cursor.Current%2A>.|  
|<xref:System.Windows.Forms.MessageBox>|— Вызов <xref:System.Windows.Forms.Form.Show%2A> метод.|  
  
### <a name="hosting-third-party-controls"></a>Размещение элементов управления сторонних производителей  
 Если ваши формы размещают элементы управления сторонних производителей, могут возникать другие операции управления окнами. Элемент управления стороннего производителя — любой пользовательский <xref:System.Windows.Forms.UserControl> наличие не разработан и скомпилирован, самостоятельно. Несмотря на то, что вариантом размещения воспользоваться довольно сложно, теоретически элемент управления стороннего производителя может расширить свою поверхность отрисовки и полностью занять область вашей формы. Затем такой элемент управления может сымитировать важное диалоговое окно и запросить у ваших пользователей такие сведения, как сочетание имени пользователя и пароля или номера банковских счетов.  
  
 Чтобы ограничить такой потенциальный риск, используйте элементы управления только доверенных сторонних производителей. Если вы используете элементы управления стороннего производителя, загруженные из непроверяемого источника, рекомендуем просмотреть исходный код на предмет наличия потенциальной уязвимости. Убедившись, что источник не является вредоносным, скомпилируйте сборку самостоятельно и проверьте, соответствует ли исходный код сборке.  
  
## <a name="windows-api-calls"></a>Вызовы API Windows  
 При разработке приложения требуется вызов функции из интерфейса Windows API, вы обращаетесь к неуправляемым кодом. В этом случае действия кода с окном или операционной системе не удается определить, при работе с вызовами Windows API или значения. <xref:System.Security.Permissions.SecurityPermission> Класс и <xref:System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode> значение <xref:System.Security.Permissions.SecurityPermissionFlag> перечисления управления доступом к неуправляемому коду. Приложение можно получать доступ к неуправляемым кодом только в том случае, если ему предоставлено <xref:System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode> разрешение. По умолчанию вызывать неуправляемый код могут только приложения, которые выполняются локально.  
  
 Некоторые элементы Windows Forms предоставляют неуправляемый доступ, требующий <xref:System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode> разрешение. В следующей таблице перечислены элементы <xref:System.Windows.Forms> пространства имен, которым требуется это разрешение. Дополнительные сведения о разрешениях, требуемых для элемента, см. в разделе документации по библиотеке классов .NET Framework.  
  
|Компонент|Член|  
|---------------|------------|  
|<xref:System.Windows.Forms.Application>|Метод -   <xref:System.Windows.Forms.Application.AddMessageFilter%2A><br />-   <xref:System.Windows.Forms.Application.CurrentInputLanguage%2A> Свойство<br />Метод -   `Exit`<br />Метод -   <xref:System.Windows.Forms.Application.ExitThread%2A><br />-   <xref:System.Windows.Forms.Application.ThreadException> Событие|  
|<xref:System.Windows.Forms.CommonDialog>|Метод -   <xref:System.Windows.Forms.CommonDialog.HookProc%2A><br />-   <xref:System.Windows.Forms.CommonDialog.OwnerWndProc%2A>\ метод<br />Метод -   <xref:System.Windows.Forms.CommonDialog.Reset%2A><br />Метод -   <xref:System.Windows.Forms.CommonDialog.RunDialog%2A>|  
|<xref:System.Windows.Forms.Control>|Метод -   <xref:System.Windows.Forms.Control.CreateParams%2A><br />Метод -   <xref:System.Windows.Forms.Control.DefWndProc%2A><br />Метод -   <xref:System.Windows.Forms.Control.DestroyHandle%2A><br />Метод -   <xref:System.Windows.Forms.Control.WndProc%2A>|  
|<xref:System.Windows.Forms.Help>|-   <xref:System.Windows.Forms.Help.ShowHelp%2A> Методы<br />Метод -   <xref:System.Windows.Forms.Help.ShowHelpIndex%2A>|  
|<xref:System.Windows.Forms.NativeWindow>|-   <xref:System.Windows.Forms.NativeWindow> Класс|  
|<xref:System.Windows.Forms.Screen>|Метод -   <xref:System.Windows.Forms.Screen.FromHandle%2A>|  
|<xref:System.Windows.Forms.SendKeys>|Метод -   <xref:System.Windows.Forms.SendKeys.Send%2A><br />Метод -   <xref:System.Windows.Forms.SendKeys.SendWait%2A>|  
  
 Если приложение не имеет разрешения на вызов неуправляемого кода, приложение должно запросить <xref:System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode> разрешение, или необходимо подумать о других способах реализации таких возможностей, во многих случаях Windows Forms предоставляет управляемую альтернативу Windows Функции API. Если альтернативного способа нет, а приложению необходимо получать доступ к неуправляемому коду, повысьте уровень разрешений для такого приложения.  
  
 Благодаря разрешению на вызов неуправляемого кода приложение может выполнять практически любые действия. Следовательно, разрешение на вызов неуправляемого кода должно предоставляться только приложениям из доверенного источника. Кроме того, в зависимости от приложения, часть функциональных возможностей приложения, вызывающих неуправляемый код, может быть необязательной или использоваться только в среде с полным доверием. Дополнительные сведения об опасных разрешениях см. в разделе [Опасные разрешения и администрирование политик](../misc/dangerous-permissions-and-policy-administration.md). Дополнительные сведения о повышении уровня разрешений см. в разделе [Общее администрирование политик безопасности](https://docs.microsoft.com/previous-versions/dotnet/netframework-4.0/ed5htz45(v=vs.100)).  
  
## <a name="see-also"></a>См. также

- [Более безопасный доступ к файлам и данным в Windows Forms](more-secure-file-and-data-access-in-windows-forms.md)
- [Более безопасная печать в Windows Forms](more-secure-printing-in-windows-forms.md)
- [Общие сведения о безопасности в Windows Forms](security-in-windows-forms-overview.md)
- [Безопасность Windows Forms](windows-forms-security.md)
- [Защита приложений ClickOnce](/visualstudio/deployment/securing-clickonce-applications)
