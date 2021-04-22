---
title: Размещение содержимого Win32 в WPF
ms.date: 03/30/2017
helpviewer_keywords:
- interoperability [WPF], tutorials
- Win32 code [WPF], WPF interoperation
- interoperability [WPF], Win32
ms.assetid: 3cc8644a-34f3-4082-9ddc-77623e4df2d8
ms.openlocfilehash: 8773cac1e421ecdca036e88d79797dae16f72b17
ms.sourcegitcommit: 68eb5c4928e2b082f178a42c16f73fedf52c2ab8
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/05/2019
ms.locfileid: "59055083"
---
# <a name="hosting-win32-content-in-wpf"></a>Размещение содержимого Win32 в WPF

## <a name="prerequisites"></a>Предварительные требования

См. в разделе [взаимодействие WPF и Win32](wpf-and-win32-interoperation.md).

## <a name="a-walkthrough-of-win32-inside-windows-presentation-framework-hwndhost"></a>Пошаговое руководство на основе Win32 в Windows Presentation Framework (HwndHost)

Для повторного использования [!INCLUDE[TLA2#tla_win32](../../../../includes/tla2sharptla-win32-md.md)] содержимое внутри WPF приложения, используют <xref:System.Windows.Interop.HwndHost>, который является элементом управления, который заставляет HWND выглядеть WPF содержимого. Как <xref:System.Windows.Interop.HwndSource>, <xref:System.Windows.Interop.HwndHost> проста в использовании: являются производными от <xref:System.Windows.Interop.HwndHost> и реализовать `BuildWindowCore` и `DestroyWindowCore` методы, затем экземпляр вашего <xref:System.Windows.Interop.HwndHost> производного класса и поместите его внутри вашей WPF приложение.

Если ваш [!INCLUDE[TLA2#tla_win32](../../../../includes/tla2sharptla-win32-md.md)] логики уже упакован как элемент управления, то `BuildWindowCore` реализации нечто большее, чем вызов `CreateWindow`. Например, чтобы создать [!INCLUDE[TLA2#tla_win32](../../../../includes/tla2sharptla-win32-md.md)] управления LISTBOX в [!INCLUDE[TLA#tla_cpp](../../../../includes/tlasharptla-cpp-md.md)]:

```cpp
virtual HandleRef BuildWindowCore(HandleRef hwndParent) override {
    HWND handle = CreateWindowEx(0, L"LISTBOX",
    L"this is a Win32 listbox",
    WS_CHILD | WS_VISIBLE | LBS_NOTIFY
    | WS_VSCROLL | WS_BORDER,
    0, 0, // x, y
    30, 70, // height, width
    (HWND) hwndParent.Handle.ToPointer(), // parent hwnd
    0, // hmenu
    0, // hinstance
    0); // lparam

    return HandleRef(this, IntPtr(handle));
}

virtual void DestroyWindowCore(HandleRef hwnd) override {
    // HwndHost will dispose the hwnd for us
}
```

Но предположим, что [!INCLUDE[TLA2#tla_win32](../../../../includes/tla2sharptla-win32-md.md)] код не столь автономно? Если таким образом, можно создать [!INCLUDE[TLA2#tla_win32](../../../../includes/tla2sharptla-win32-md.md)] диалоговое окно и внедрить его содержимое в одно крупное WPF приложения. В этом примере это в Microsoft Visual Studio и [!INCLUDE[TLA#tla_cpp](../../../../includes/tlasharptla-cpp-md.md)], несмотря на то, что это также можно сделать на другом языке или из командной строки.

Начните с простого диалога, который компилируется в [!INCLUDE[TLA#tla_cpp](../../../../includes/tlasharptla-cpp-md.md)] [!INCLUDE[TLA2#tla_dll](../../../../includes/tla2sharptla-dll-md.md)] проекта.

Затем поместим диалог в большее WPF приложения:

- Скомпилируйте [!INCLUDE[TLA2#tla_dll](../../../../includes/tla2sharptla-dll-md.md)] как управляемый (`/clr`)

- Включить диалоговое окно в элемент управления

- Определить класс, производный от <xref:System.Windows.Interop.HwndHost> с `BuildWindowCore` и `DestroyWindowCore` методы

- Переопределить `TranslateAccelerator` метод для обработки ключей диалоговое окно

- Переопределить `TabInto` метод для поддержки переходов

- Переопределить `OnMnemonic` метод для поддержки назначенных клавиш

- Создать экземпляр <xref:System.Windows.Interop.HwndHost> подкласс и поместить его в правом WPF элемент

### <a name="turn-the-dialog-into-a-control"></a>Включить диалоговое окно в элемент управления

Диалоговое окно можно превратить в дочерний элемент с использованием стилей WS_CHILD и DS_CONTROL HWND. Перейдите в файл ресурсов (.rc), где определено диалоговое окно и найти начало определения диалогового окна:

```
IDD_DIALOG1 DIALOGEX 0, 0, 303, 121
STYLE DS_SETFONT | DS_MODALFRAME | DS_FIXEDSYS | WS_POPUP | WS_CAPTION | WS_SYSMENU
```

Измените второй строки, чтобы:

```
STYLE DS_SETFONT | WS_CHILD | WS_BORDER | DS_CONTROL
```

Это действие не полностью его в автономное элемента управления; необходимо по-прежнему вызвать `IsDialogMessage()` , [!INCLUDE[TLA2#tla_win32](../../../../includes/tla2sharptla-win32-md.md)] может обрабатывать определенные сообщения, но изменение элемента управления предоставляют простой способ размещения этих элементов управления внутри другого HWND.

## <a name="subclass-hwndhost"></a>Подкласс HwndHost

Импортируйте такие пространства имен:

```cpp
namespace ManagedCpp
{
    using namespace System;
    using namespace System::Windows;
    using namespace System::Windows::Interop;
    using namespace System::Windows::Input;
    using namespace System::Windows::Media;
    using namespace System::Runtime::InteropServices;
```

Создайте класс, производный от <xref:System.Windows.Interop.HwndHost> и переопределить `BuildWindowCore` и `DestroyWindowCore` методов:

```cpp
public ref class MyHwndHost : public HwndHost, IKeyboardInputSink {
    private:
        HWND dialog;

    protected:
        virtual HandleRef BuildWindowCore(HandleRef hwndParent) override {
            InitializeGlobals();
            dialog = CreateDialog(hInstance,
                MAKEINTRESOURCE(IDD_DIALOG1),
                (HWND) hwndParent.Handle.ToPointer(),
                (DLGPROC) About);
            return HandleRef(this, IntPtr(dialog));
        }

        virtual void DestroyWindowCore(HandleRef hwnd) override {
            // hwnd will be disposed for us
        }
```

Здесь используется `CreateDialog` Создание диалогового окна, которое на самом деле элемент управления. Так как это один из первых методов, вызванных внутри [!INCLUDE[TLA2#tla_dll](../../../../includes/tla2sharptla-dll-md.md)], необходимо выполнить некоторые стандартные [!INCLUDE[TLA2#tla_win32](../../../../includes/tla2sharptla-win32-md.md)] инициализацию путем вызова функции, будут определены позже, вызывается `InitializeGlobals()`:

```cpp
bool initialized = false;
    void InitializeGlobals() {
        if (initialized) return;
        initialized = true;

        // TODO: Place code here.
        MSG msg;
        HACCEL hAccelTable;

        // Initialize global strings
        LoadString(hInstance, IDS_APP_TITLE, szTitle, MAX_LOADSTRING);
        LoadString(hInstance, IDC_TYPICALWIN32DIALOG, szWindowClass, MAX_LOADSTRING);
        MyRegisterClass(hInstance);
```

### <a name="override-translateaccelerator-method-to-handle-dialog-keys"></a>Переопределите метод TranslateAccelerator обрабатывать ключи диалоговое окно

Если запустить этот пример, получится элемент управления диалогового окна, отображающий, но будет игнорировать всю обработку, которая делает клавиатуры диалоговое окно функциональной диалоговое окно. Теперь необходимо переопределить `TranslateAccelerator` реализации (который поставляется вместе с `IKeyboardInputSink`, интерфейс, <xref:System.Windows.Interop.HwndHost> реализует). Этот метод вызывается, когда приложение получает WM_KEYDOWN и WM_SYSKEYDOWN.

```cpp
#undef TranslateAccelerator
        virtual bool TranslateAccelerator(System::Windows::Interop::MSG% msg,
            ModifierKeys modifiers) override
        {
            ::MSG m = ConvertMessage(msg);

            // Win32's IsDialogMessage() will handle most of our tabbing, but doesn't know
            // what to do when it reaches the last tab stop
            if (m.message == WM_KEYDOWN && m.wParam == VK_TAB) {
                HWND firstTabStop = GetDlgItem(dialog, IDC_EDIT1);
                HWND lastTabStop = GetDlgItem(dialog, IDCANCEL);
                TraversalRequest^ request = nullptr;

                if (GetKeyState(VK_SHIFT) && GetFocus() == firstTabStop) {
                    // this code should work, but there’s a bug with interop shift-tab in current builds
                    request = gcnew TraversalRequest(FocusNavigationDirection::Last);
                }
                else if (!GetKeyState(VK_SHIFT) && GetFocus() == lastTabStop) {
                    request = gcnew TraversalRequest(FocusNavigationDirection::Next);
                }

                if (request != nullptr)
                    return ((IKeyboardInputSink^) this)->KeyboardInputSite->OnNoMoreTabStops(request);

            }

            // Only call IsDialogMessage for keys it will do something with.
            if (msg.message == WM_SYSKEYDOWN || msg.message == WM_KEYDOWN) {
                switch (m.wParam) {
                    case VK_TAB:
                    case VK_LEFT:
                    case VK_UP:
                    case VK_RIGHT:
                    case VK_DOWN:
                    case VK_EXECUTE:
                    case VK_RETURN:
                    case VK_ESCAPE:
                    case VK_CANCEL:
                        IsDialogMessage(dialog, &m);
                        // IsDialogMessage should be called ProcessDialogMessage --
                        // it processes messages without ever really telling you
                        // if it handled a specific message or not
                        return true;
                }
            }

            return false; // not a key we handled
        }
```

Это много кода, поэтому она может использовать более подробные пояснения. Во-первых, код, используя [!INCLUDE[TLA#tla_cpp](../../../../includes/tlasharptla-cpp-md.md)] и [!INCLUDE[TLA#tla_cpp](../../../../includes/tlasharptla-cpp-md.md)] макросы; вы должны знать, что уже макрос с именем `TranslateAccelerator`, который определен в winuser.h:

```cpp
#define TranslateAccelerator  TranslateAcceleratorW
```

Поэтому убедитесь, что определение `TranslateAccelerator` метода и не `TranslateAcceleratorW` метод.

Таким же образом есть неуправляемый код winuser.h MSG и управляемое `Microsoft::Win32::MSG` структуры. Чтобы устранить неоднозначность между ними с помощью [!INCLUDE[TLA#tla_cpp](../../../../includes/tlasharptla-cpp-md.md)] `::` оператор.

```cpp
virtual bool TranslateAccelerator(System::Windows::Interop::MSG% msg,
    ModifierKeys modifiers) override
{
    ::MSG m = ConvertMessage(msg);
}

Both MSGs have the same data, but sometimes it is easier to work with the unmanaged definition, so in this sample you can define the obvious conversion routine:

```cpp
::MSG ConvertMessage(System::Windows::Interop::MSG% msg) {
    ::MSG m;
    m.hwnd = (HWND) msg.hwnd.ToPointer();
    m.lParam = (LPARAM) msg.lParam.ToPointer();
    m.message = msg.message;
    m.wParam = (WPARAM) msg.wParam.ToPointer();

    m.time = msg.time;

    POINT pt;
    pt.x = msg.pt_x;
    pt.y = msg.pt_y;
    m.pt = pt;

    return m;
}
```

К `TranslateAccelerator`. Основным критерием является вызов [!INCLUDE[TLA2#tla_win32](../../../../includes/tla2sharptla-win32-md.md)] функция `IsDialogMessage` делать столько работы, возможно, но `IsDialogMessage` не имеет доступа к любому за пределами диалогового окна. По мере выполнения вне диалогового окна, заставляя следующую за последним элементом управления в нашем диалоге, вам потребуется установить фокус на WPF часть путем вызова `IKeyboardInputSite::OnNoMoreStops`.

```cpp
// Win32's IsDialogMessage() will handle most of the tabbing, but doesn't know
// what to do when it reaches the last tab stop
if (m.message == WM_KEYDOWN && m.wParam == VK_TAB) {
    HWND firstTabStop = GetDlgItem(dialog, IDC_EDIT1);
    HWND lastTabStop = GetDlgItem(dialog, IDCANCEL);
    TraversalRequest^ request = nullptr;

    if (GetKeyState(VK_SHIFT) && GetFocus() == firstTabStop) {
        request = gcnew TraversalRequest(FocusNavigationDirection::Last);
    }
    else if (!GetKeyState(VK_SHIFT) && GetFocus() ==  lastTabStop) { {
        request = gcnew TraversalRequest(FocusNavigationDirection::Next);
    }

    if (request != nullptr)
        return ((IKeyboardInputSink^) this)->KeyboardInputSite->OnNoMoreTabStops(request);
}
```

Теперь вызовите `IsDialogMessage`. Но один из ответственности `TranslateAccelerator` метод сообщается WPF ли нажатие клавиши или нет. Если вы не обрабатывает его, событие ввода может Туннелировать и поднимаются по остальной части приложения. Здесь, будут предоставлены особенности обработки клавиатуры и характера архитектура ввода в [!INCLUDE[TLA2#tla_win32](../../../../includes/tla2sharptla-win32-md.md)]. К сожалению `IsDialogMessage` не возвращает никоим образом обрабатывает ли конкретное нажатие клавиши. Что еще хуже, он вызывает `DispatchMessage()` на нажатия клавиш, он не должен обрабатывать!  Чтобы вы могли реконструировать `IsDialogMessage`и вызвать его только для ключей, вы знаете, что он будет обрабатывать:

```cpp
// Only call IsDialogMessage for keys it will do something with.
if (msg.message == WM_SYSKEYDOWN || msg.message == WM_KEYDOWN) {
    switch (m.wParam) {
        case VK_TAB:
        case VK_LEFT:
        case VK_UP:
        case VK_RIGHT:
        case VK_DOWN:
        case VK_EXECUTE:
        case VK_RETURN:
        case VK_ESCAPE:
        case VK_CANCEL:
            IsDialogMessage(dialog, &m);
            // IsDialogMessage should be called ProcessDialogMessage --
            // it processes messages without ever really telling you
            // if it handled a specific message or not
            return true;
    }
```

### <a name="override-tabinto-method-to-support-tabbing"></a>Переопределение метода TabInto для поддержки переходов

Теперь, когда вы реализовали `TranslateAccelerator`, пользователь может совершать переходы внутри диалогового окна поле и выйти в большее WPF приложения. Но пользователь не может перейти обратно в диалоговом окне. Чтобы разрешить это, переопределите `TabInto`:

```cpp
public:
    virtual bool TabInto(TraversalRequest^ request) override {
        if (request->FocusNavigationDirection == FocusNavigationDirection::Last) {
            HWND lastTabStop = GetDlgItem(dialog, IDCANCEL);
            SetFocus(lastTabStop);
        }
        else {
            HWND firstTabStop = GetDlgItem(dialog, IDC_EDIT1);
            SetFocus(firstTabStop);
        }
        return true;
    }
```

`TraversalRequest` Параметр указывает, является ли действие tab или shift.

### <a name="override-onmnemonic-method-to-support-mnemonics"></a>Переопределение метода OnMnemonic для поддержки назначенных клавиш

Обработка событий клавиатуры почти завершена, но имеется еще один аспекте — назначенные клавиши не работают. Если пользователь нажимает клавишу alt-F, фокус не переходит в «First name:» поле ввода. Таким образом, необходимо переопределить `OnMnemonic` метод:

```cpp
virtual bool OnMnemonic(System::Windows::Interop::MSG% msg, ModifierKeys modifiers) override {
    ::MSG m = ConvertMessage(msg);

    // If it's one of our mnemonics, set focus to the appropriate hwnd
    if (msg.message == WM_SYSCHAR && GetKeyState(VK_MENU /*alt*/)) {
        int dialogitem = 9999;
        switch (m.wParam) {
            case 's': dialogitem = IDOK; break;
            case 'c': dialogitem = IDCANCEL; break;
            case 'f': dialogitem = IDC_EDIT1; break;
            case 'l': dialogitem = IDC_EDIT2; break;
            case 'p': dialogitem = IDC_EDIT3; break;
            case 'a': dialogitem = IDC_EDIT4; break;
            case 'i': dialogitem = IDC_EDIT5; break;
            case 't': dialogitem = IDC_EDIT6; break;
            case 'z': dialogitem = IDC_EDIT7; break;
        }
        if (dialogitem != 9999) {
            HWND hwnd = GetDlgItem(dialog, dialogitem);
            SetFocus(hwnd);
            return true;
        }
    }
    return false; // key unhandled
};
```

Почему бы не вызвать `IsDialogMessage` здесь?  Имеют ту же проблему как — необходимо иметь возможность сообщить WPF кода, обработал ли код нажатие клавиши или нет, и `IsDialogMessage` не предусмотрена. Есть также вторая проблема, так как `IsDialogMessage` отказывается обрабатывать мнемонический символ, если фокус HWND не содержится в диалоговом окне.

### <a name="instantiate-the-hwndhost-derived-class"></a>Создать экземпляр производного класса HwndHost

Наконец, после того, вся поддержка ключа и вкладку на месте, можно поместить в <xref:System.Windows.Interop.HwndHost> в большее WPF приложения. Если основное приложение создается на языке XAML, чтобы поместить его в нужном месте проще всего оставить пустым <xref:System.Windows.Controls.Border> элемент, где необходимо поместить <xref:System.Windows.Interop.HwndHost>. Вы создадите <xref:System.Windows.Controls.Border> с именем `insertHwndHostHere`:

```xaml
<Window x:Class="WPFApplication1.Window1"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    Title="Windows Presentation Framework Application"
    Loaded="Window1_Loaded"
    >
    <StackPanel>
        <Button Content="WPF button"/>
        <Border Name="insertHwndHostHere" Height="200" Width="500"/>
        <Button Content="WPF button"/>
    </StackPanel>
</Window>
```

Затем все, что остается лишь найти правильное место в коде для создания экземпляра <xref:System.Windows.Interop.HwndHost> и подключите его к <xref:System.Windows.Controls.Border>. В этом примере будет поместить его в конструктор для <xref:System.Windows.Window> производного класса:

```csharp
public partial class Window1 : Window {
    public Window1() {
    }

    void Window1_Loaded(object sender, RoutedEventArgs e) {
        HwndHost host = new ManagedCpp.MyHwndHost();
        insertHwndHostHere.Child = host;
    }
}
```

Что позволяет:

![Снимок экрана приложения WPF](./media/interoparch09.PNG "InteropArch09")

## <a name="see-also"></a>См. также

- [Взаимодействие WPF и Win32](wpf-and-win32-interoperation.md)
