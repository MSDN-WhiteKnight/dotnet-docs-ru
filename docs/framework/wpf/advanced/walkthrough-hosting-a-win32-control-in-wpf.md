---
title: Пошаговое руководство. Размещение элемента управления Win32 в WPF
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- hosting Win32 control in WPF [WPF]
- Win32 code [WPF], WPF interoperation
ms.assetid: a676b1eb-fc55-4355-93ab-df840c41cea0
ms.openlocfilehash: 834160358d7b3e8e7f4c7c4f4fd06d403086e7e5
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59307708"
---
# <a name="walkthrough-hosting-a-win32-control-in-wpf"></a>Пошаговое руководство. Размещение элемента управления Win32 в WPF
Windows Presentation Foundation (WPF) предоставляет среду с широкими возможностями для создания приложений. Тем не менее, при наличии значительных инвестиций в коде Win32, возможно, более эффективно использовать по крайней мере некоторые этого кода в приложении WPF, а не переписывать его заново. WPF предоставляет простой механизм для размещения окна Win32, на странице WPF.  
  
 В этом разделе рассматриваются приложения, [размещения элемента управления ListBox Win32 в WPF](https://github.com/Microsoft/WPF-Samples/tree/master/Migration%20and%20Interoperability/WPFHostingWin32Control), что узлы управления полем со списком Win32. Эта общая процедура может быть расширена для размещения любого окна Win32.  

<a name="requirements"></a>   
## <a name="requirements"></a>Требования  
 В этом разделе предполагается Знакомство с программированием для WPF и Windows API. Основные сведения о программировании WPF, см. в разделе [Приступая к работе](../getting-started/index.md). Введение в программирование Windows API, см. в разделе любой из многочисленных книг по этой теме, в частности *программирования Windows* Чарльза Петцольда.  
  
 Поскольку пример, используемый в этом разделе, реализован в C#, он позволяет использовать службы вызова платформы (PInvoke) для доступа к Windows API. Знакомство с PInvoke, желательно, но не обязательно.  
  
> [!NOTE]
>  Этот учебник включает ряд примеров кода из связанного примера. Однако для удобства чтения он не содержит полный пример кода. Можно получить или просмотреть полный код из [размещения элемента управления ListBox Win32 в WPF](https://github.com/Microsoft/WPF-Samples/tree/master/Migration%20and%20Interoperability/WPFHostingWin32Control).  
  
<a name="basic_procedure"></a>   
## <a name="the-basic-procedure"></a>Основная процедура  
 В этом разделе рассматривается основная процедура размещения окна Win32 на странице WPF. В остальных разделах подробно описывается каждый шаг.  
  
 Основная процедура размещения  
  
1. Реализация страницы WPF для размещения окна. Один из способов — создание <xref:System.Windows.Controls.Border> элемент резервирующего раздел страницы для размещенного окна.  
  
2. Реализация класса для размещения элемента управления, который наследует от <xref:System.Windows.Interop.HwndHost>.  
  
3. В этом классе переопределите <xref:System.Windows.Interop.HwndHost> член класса <xref:System.Windows.Interop.HwndHost.BuildWindowCore%2A>.  
  
4. Создайте размещенного окна в качестве дочернего окна, содержащего страницу WPF. Несмотря на то, что применяется в программировании WPF не требуется явно использовать, размещающая страница представляет собой окно с маркером (HWND). Вы получаете страницу HWND через `hwndParent` параметр <xref:System.Windows.Interop.HwndHost.BuildWindowCore%2A> метод. Размещаемое окно необходимо создать в качестве дочернего объекта этого окна HWND.  
  
5. Создав главное окно, верните HWND размещаемого окна. Если вы хотите разместить один или несколько элементов управления Win32, обычно создать главное окно как дочерний элемент HWND и дочерние элементы управления главного окна. Размещение элементов управления в главном окне предоставляет простой способ для страницы WPF для получения уведомлений от элементов управления, которое обрабатывает некоторые конкретные проблемы Win32 с уведомлениями за пределы HWND.  
  
6. Обрабатывайте некоторые сообщения, которые отправляются в главное окно, например уведомления от дочерних элементов управления. Это можно сделать двумя способами.  
  
    -   Если вы предпочитаете обрабатывать сообщения в классе размещения, переопределите <xref:System.Windows.Interop.HwndHost.WndProc%2A> метод <xref:System.Windows.Interop.HwndHost> класса.  
  
    -   Если вы предпочитаете заставить WPF обрабатывать сообщения, обрабатывать <xref:System.Windows.Interop.HwndHost> класс <xref:System.Windows.Interop.HwndHost.MessageHook> событие в фоновом коде. Это событие возникает для каждого сообщения, получаемого размещаемым окном. Если выбран этот параметр, необходимо переопределить <xref:System.Windows.Interop.HwndHost.WndProc%2A>, но требуется минимальная реализация.  
  
7. Переопределить <xref:System.Windows.Interop.HwndHost.DestroyWindowCore%2A> и <xref:System.Windows.Interop.HwndHost.WndProc%2A> методы <xref:System.Windows.Interop.HwndHost>. Необходимо переопределить эти методы для удовлетворения <xref:System.Windows.Interop.HwndHost> контракт, но вам может потребоваться лишь минимальная реализация.  
  
8. В файле кода программной части создайте экземпляр класса, размещающего элемент управления и дочернего элемента <xref:System.Windows.Controls.Border> элемент, который предназначен для размещения окна.  
  
9. Обмениваться данными с размещенным окном, отправляя ему [!INCLUDE[TLA#tla_win](../../../../includes/tlasharptla-win-md.md)] сообщения и обрабатывая сообщения из его дочерних окон, таких как уведомления, отправленные элементами управления.  
  
<a name="page_layout"></a>   
## <a name="implement-the-page-layout"></a>Реализация макета страницы  
 Макет для страницы WPF, на котором размещается элемент управления ListBox состоит из двух регионов. В левой части страницы содержит несколько элементов управления WPF, которые предоставляют [!INCLUDE[TLA#tla_ui](../../../../includes/tlasharptla-ui-md.md)] , позволяющий работать с элементом управления Win32. В правом верхнем углу страницы имеется квадратная область для размещенного элемента управления ListBox.  
  
 Код для реализации этого макета довольно прост. Корневой элемент — <xref:System.Windows.Controls.DockPanel> , имеет два дочерних элемента. Во-первых, <xref:System.Windows.Controls.Border> элемент, на котором размещается элемент управления ListBox. Он занимает квадрат размером 200 x 200 в верхнем правом углу страницы. Второй — <xref:System.Windows.Controls.StackPanel> элемент, который содержит набор элементов управления WPF, отображающих сведения и позволяют работать с элементом управления ListBox, задав предоставленные свойства взаимодействия. Для каждого из элементов, являющихся потомками <xref:System.Windows.Controls.StackPanel>, справочные материалы для различных элементов, о том, что эти элементы и их назначение, перечислены в следующем примере кода, но не будут описаны здесь (basic модели взаимодействия не требуются, они предоставлены для добавления интерактивности в пример).  
  
 [!code-xaml[WPFHostingWin32Control#WPFUI](~/samples/snippets/csharp/VS_Snippets_Wpf/WPFHostingWin32Control/CSharp/Page1.xaml#wpfui)]  
  
<a name="host_class"></a>   
## <a name="implement-a-class-to-host-the-microsoft-win32-control"></a>Реализация размещения элемента управления Microsoft Win32 в классе  
 Ядром этого образца является класс, который фактически размещает в себе элемент управления, ControlHost.cs. Он наследует от <xref:System.Windows.Interop.HwndHost>. Конструктор принимает два параметра, высоту и ширину, которые соответствуют высоте и ширине <xref:System.Windows.Controls.Border> элемент, на котором размещается элемент управления ListBox. Эти значения используются Далее, чтобы убедиться, что размер элемента управления соответствует <xref:System.Windows.Controls.Border> элемент.  
  
 [!code-csharp[WPFHostingWin32Control#ControlHostClass](~/samples/snippets/csharp/VS_Snippets_Wpf/WPFHostingWin32Control/CSharp/ControlHost.cs#controlhostclass)]
 [!code-vb[WPFHostingWin32Control#ControlHostClass](~/samples/snippets/visualbasic/VS_Snippets_Wpf/WPFHostingWin32Control/VisualBasic/ControlHost.vb#controlhostclass)]  
  
 Кроме того, имеется набор констант. Эти константы в основном берутся из файла Winuser.h и позволяют использовать обычные имена при вызове функции Win32.  
  
 [!code-csharp[WPFHostingWin32Control#ControlHostConstants](~/samples/snippets/csharp/VS_Snippets_Wpf/WPFHostingWin32Control/CSharp/ControlHost.cs#controlhostconstants)]
 [!code-vb[WPFHostingWin32Control#ControlHostConstants](~/samples/snippets/visualbasic/VS_Snippets_Wpf/WPFHostingWin32Control/VisualBasic/ControlHost.vb#controlhostconstants)]  
  
<a name="buildwindowcore"></a>   
### <a name="override-buildwindowcore-to-create-the-microsoft-win32-window"></a>Переопределение класса BuildWindowCore для создания окна Microsoft Win32  
 Можно переопределить этот метод для создания окна Win32, которое будет размещено на странице и создайте подключение между окном и страницей. Поскольку в этом примере также показано размещение элемента управления ListBox, создаются два окна. Первый — это окно, которое фактически размещено на странице WPF. Элемент управления ListBox создается в качестве дочернего элемента этого окна.  
  
 Это делается для того, чтобы упростить получение уведомлений от элемента управления. <xref:System.Windows.Interop.HwndHost> Класс позволяет обрабатывать сообщения, отправляемые в окно, на котором он размещен. Если напрямую управлять узла Win32, вы получите сообщения, отправленные внутренний цикл сообщений элемента управления. Можно отображать элемент управления и отправлять ему сообщения, но не получать уведомления, которые элемент управления отправляет своему родительскому окну. Это означает, среди прочего, что нет способа обнаружения взаимодействия пользователя с элементом управления. Вместо этого следует создать главное окно и сделать элемент управления дочерним элементом этого окна. Это позволит обрабатывать сообщения для главного окна, включая уведомления, отправляемые элементом управления. Для удобства, поскольку главное окно — это всего лишь программа-оболочка для элемента управления, мы будем называть этот пакет "элементом управления ListBox".  
  
<a name="create_the_window_and_listbox"></a>   
#### <a name="create-the-host-window-and-listbox-control"></a>Создание главного окна и элемента управления ListBox  
 Можно использовать PInvoke для создания главного окна для элемента управления путем создания и регистрации класса окна и т. д. Однако гораздо проще создать окно с помощью готового "статического" класса окон. Это позволит реализовать в окне процедуру, необходимую для получения уведомлений из элемента управления, и требует минимальной работы с кодом.  
  
 HWND элемента управления предоставляется через доступное только для чтения свойство, чтобы главная страница могла использовать его для отправки сообщения элементу управления.  
  
 [!code-csharp[WPFHostingWin32Control#IntPtrProperty](~/samples/snippets/csharp/VS_Snippets_Wpf/WPFHostingWin32Control/CSharp/ControlHost.cs#intptrproperty)]
 [!code-vb[WPFHostingWin32Control#IntPtrProperty](~/samples/snippets/visualbasic/VS_Snippets_Wpf/WPFHostingWin32Control/VisualBasic/ControlHost.vb#intptrproperty)]  
  
 Элемент управления ListBox создается в качестве дочернего элемента главного окна. Высота и ширина обоих окон задается с помощью значений, передаваемых конструктору (см. выше). Это гарантирует, что размер главного окна и элемента управления идентичен размеру отведенной для них области на странице.  После создания окон образец возвращает <xref:System.Runtime.InteropServices.HandleRef> , содержащий HWND главного окна.  
  
 [!code-csharp[WPFHostingWin32Control#BuildWindowCore](~/samples/snippets/csharp/VS_Snippets_Wpf/WPFHostingWin32Control/CSharp/ControlHost.cs#buildwindowcore)]
 [!code-vb[WPFHostingWin32Control#BuildWindowCore](~/samples/snippets/visualbasic/VS_Snippets_Wpf/WPFHostingWin32Control/VisualBasic/ControlHost.vb#buildwindowcore)]  
  
 [!code-csharp[WPFHostingWin32Control#BuildWindowCoreHelper](~/samples/snippets/csharp/VS_Snippets_Wpf/WPFHostingWin32Control/CSharp/ControlHost.cs#buildwindowcorehelper)]
 [!code-vb[WPFHostingWin32Control#BuildWindowCoreHelper](~/samples/snippets/visualbasic/VS_Snippets_Wpf/WPFHostingWin32Control/VisualBasic/ControlHost.vb#buildwindowcorehelper)]  
  
<a name="destroywindow_wndproc"></a>   
### <a name="implement-destroywindow-and-wndproc"></a>Реализация классов DestroyWindow и WndProc  
 В дополнение к <xref:System.Windows.Interop.HwndHost.BuildWindowCore%2A>, необходимо также переопределить <xref:System.Windows.Interop.HwndHost.WndProc%2A> и <xref:System.Windows.Interop.HwndHost.DestroyWindowCore%2A> методы <xref:System.Windows.Interop.HwndHost>. В этом примере сообщения для элемента управления обрабатываются <xref:System.Windows.Interop.HwndHost.MessageHook> обработчик, поэтому реализация <xref:System.Windows.Interop.HwndHost.WndProc%2A> и <xref:System.Windows.Interop.HwndHost.DestroyWindowCore%2A> сводится к минимуму. В случае использования <xref:System.Windows.Interop.HwndHost.WndProc%2A>, задайте `handled` для `false` указывают, что сообщение не было обработано и возвращают значение 0. Для <xref:System.Windows.Interop.HwndHost.DestroyWindowCore%2A>, достаточно уничтожить окно.  
  
 [!code-csharp[WPFHostingWin32Control#WndProcDestroy](~/samples/snippets/csharp/VS_Snippets_Wpf/WPFHostingWin32Control/CSharp/ControlHost.cs#wndprocdestroy)]
 [!code-vb[WPFHostingWin32Control#WndProcDestroy](~/samples/snippets/visualbasic/VS_Snippets_Wpf/WPFHostingWin32Control/VisualBasic/ControlHost.vb#wndprocdestroy)]  
  
 [!code-csharp[WPFHostingWin32Control#WndProcDestroyHelper](~/samples/snippets/csharp/VS_Snippets_Wpf/WPFHostingWin32Control/CSharp/ControlHost.cs#wndprocdestroyhelper)]
 [!code-vb[WPFHostingWin32Control#WndProcDestroyHelper](~/samples/snippets/visualbasic/VS_Snippets_Wpf/WPFHostingWin32Control/VisualBasic/ControlHost.vb#wndprocdestroyhelper)]  
  
<a name="host_the_control"></a>   
## <a name="host-the-control-on-the-page"></a>Размещение элемента управления на странице  
 Чтобы разместить элемент управления на странице, сначала создайте новый экземпляр класса `ControlHost` класса. Передайте значения высоты и ширины пограничного элемента, который содержит элемент управления (`ControlHostElement`) для `ControlHost` конструктор. Это позволит гарантировать, что ListBox имеет правильный размер. Затем необходимо разместить элемент управления на странице, назначив `ControlHost` объект <xref:System.Windows.Controls.Decorator.Child%2A> свойство узла <xref:System.Windows.Controls.Border>.  
  
 Образец присоединяет обработчик к <xref:System.Windows.Interop.HwndHost.MessageHook> событие `ControlHost` для получения сообщений из элемента управления. Это событие вызывается для каждого сообщения, отправляемого в главное окно. В данном случае это сообщения, отправленные в окно, которое служит оболочкой текущего элемента управления ListBox, включая уведомления от элемента управления. В этом примере вызывается метод SendMessage, чтобы получать информацию от элемента управления и менять его содержимое. Подробные сведения о том, как страница обменивается данными с элементом управления, рассматриваются в следующем разделе.  
  
> [!NOTE]
>  Обратите внимание на то, что существует два объявления PInvoke для класса SendMessage. Это необходимо, поскольку один использует `wParam` параметр для передачи строки, а другой используется для передачи целое число. Необходимо отдельно объявить каждую сигнатуру, чтобы обеспечить правильный маршалинг данных.  
  
 [!code-csharp[WPFHostingWin32Control#HostWindowClass](~/samples/snippets/csharp/VS_Snippets_Wpf/WPFHostingWin32Control/CSharp/Page1.xaml.cs#hostwindowclass)]
 [!code-vb[WPFHostingWin32Control#HostWindowClass](~/samples/snippets/visualbasic/VS_Snippets_Wpf/WPFHostingWin32Control/VisualBasic/Page1.xaml.vb#hostwindowclass)]  
  
 [!code-csharp[WPFHostingWin32Control#ControlMsgFilterSendMessage](~/samples/snippets/csharp/VS_Snippets_Wpf/WPFHostingWin32Control/CSharp/Page1.xaml.cs#controlmsgfiltersendmessage)]
 [!code-vb[WPFHostingWin32Control#ControlMsgFilterSendMessage](~/samples/snippets/visualbasic/VS_Snippets_Wpf/WPFHostingWin32Control/VisualBasic/Page1.xaml.vb#controlmsgfiltersendmessage)]  
  
<a name="communication"></a>   
## <a name="implement-communication-between-the-control-and-the-page"></a>Обмен данными между элементом управления и страницей  
 Управление элементом управления, отправляя ему сообщения Windows. Элемент управления уведомляет вас, когда пользователь взаимодействует с ним, отправляя уведомления в главное окно. [Размещения элемента управления ListBox Win32 в WPF](https://github.com/Microsoft/WPF-Samples/tree/master/Migration%20and%20Interoperability/WPFHostingWin32Control) пример включает в себя пользовательский Интерфейс, который содержит несколько примеров того, как это работает:  
  
-   Добавить элемент в список  
  
-   Удалить выбранный элемент из списка  
  
-   Отобразить текст выбранного в настоящее время элемента  
  
-   Отобразить число элементов в списке  
  
 Пользователь может также выбрать элемент в поле со списком, щелкнув его, так же, как и для — в стандартном приложении Win32. Отображаемые данные обновляются каждый раз, когда пользователь меняет состояние списка, выбирая, добавляя или изменяя документы.  
  
 Чтобы добавить элементы, отправьте списку [ `LB_ADDSTRING` сообщение](/windows/desktop/Controls/lb-addstring). Чтобы удалить элементы, отправьте [ `LB_GETCURSEL` ](/windows/desktop/Controls/lb-getcursel) необходимо получить индекс текущего выделенного фрагмента и затем [ `LB_DELETESTRING` ](/windows/desktop/Controls/lb-deletestring) для удаления элемента. Образец также отправляет [ `LB_GETCOUNT` ](/windows/desktop/Controls/lb-getcount)и использует возвращаемое значение для обновления экрана, показывающий количество элементов. Оба экземпляра [ `SendMessage` ](/windows/desktop/api/winuser/nf-winuser-sendmessage) использовать одно из объявлений PInvoke, рассмотренных в предыдущем подразделе.  
  
 [!code-csharp[WPFHostingWin32Control#AppendDeleteText](~/samples/snippets/csharp/VS_Snippets_Wpf/WPFHostingWin32Control/CSharp/Page1.xaml.cs#appenddeletetext)]
 [!code-vb[WPFHostingWin32Control#AppendDeleteText](~/samples/snippets/visualbasic/VS_Snippets_Wpf/WPFHostingWin32Control/VisualBasic/Page1.xaml.vb#appenddeletetext)]  
  
 Когда пользователь выбирает элемент, или изменяет их выделение, элемент управления уведомляет главное окно, отправляя ему [ `WM_COMMAND` сообщение](/windows/desktop/menurc/wm-command), который вызывает <xref:System.Windows.Interop.HwndHost.MessageHook> событий для страницы. Обработчик получает те же сведения, что и процедура главного окна в главном окне. Он также передает ссылку на логическое значение, равное `handled`. Можно задать `handled` для `true` для указания, что сообщение было обработано и дальнейшая обработка не требуется.  
  
 [`WM_COMMAND`](/windows/desktop/menurc/wm-command) отправляется по различным причинам, поэтому следует проанализировать идентификатор уведомления, чтобы определить, является ли это событие, которое вы хотите обрабатывать. Этот идентификатор содержится в старшем слове `wParam` параметра. Пример использует побитовые операторы для получения идентификатора. Если пользователь сделать выбор или изменил его, идентификатор будет [ `LBN_SELCHANGE` ](/windows/desktop/Controls/lbn-selchange).  
  
 Когда [ `LBN_SELCHANGE` ](/windows/desktop/Controls/lbn-selchange) — получено, пример кода также получает индекс выбранного элемента путем отправки элемента управления [ `LB_GETCURSEL` сообщение](/windows/desktop/Controls/lb-getcursel). Чтобы получить текст, сначала нужно создать <xref:System.Text.StringBuilder>. Затем следует отправить элемент управления [ `LB_GETTEXT` сообщение](/windows/desktop/Controls/lb-gettext). Передайте пустой <xref:System.Text.StringBuilder> объекта в виде `wParam` параметра. Когда [ `SendMessage` ](/windows/desktop/api/winuser/nf-winuser-sendmessage) возвращении <xref:System.Text.StringBuilder> будет содержать текст выбранного элемента. Такое использование [ `SendMessage` ](/windows/desktop/api/winuser/nf-winuser-sendmessage) требует объявления еще один PInvoke.  
  
 Наконец, установите `handled` для `true` для указания, что сообщение было обработано.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Interop.HwndHost>
- [Взаимодействие WPF и Win32](wpf-and-win32-interoperation.md)
- [Пошаговое руководство. Создание классического приложения WPF](../getting-started/walkthrough-my-first-wpf-desktop-application.md)
