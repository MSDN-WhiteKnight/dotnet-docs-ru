---
title: Пошаговое руководство. Размещение часов WPF в Win32
ms.date: 03/30/2017
helpviewer_keywords:
- interoperability [WPF], tutorials
- Win32 code [WPF], WPF interoperation
- interoperability [WPF], Win32
ms.assetid: 555e55a7-0851-4ec8-b1c6-0acba7e9b648
ms.openlocfilehash: a13e21281a4bdb365c3a0541d88cd94b6476492e
ms.sourcegitcommit: 5137208fa414d9ca3c58cdfd2155ac81bc89e917
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/06/2019
ms.locfileid: "57494952"
---
# <a name="walkthrough-hosting-a-wpf-clock-in-win32"></a>Пошаговое руководство. Размещение часов WPF в Win32

Чтобы поместить WPF внутри [!INCLUDE[TLA2#tla_win32](../../../../includes/tla2sharptla-win32-md.md)] приложения, используют <xref:System.Windows.Interop.HwndSource>, который предоставляет HWND, который содержит ваши WPF содержимое. Сначала вы создаете <xref:System.Windows.Interop.HwndSource>, предоставив ему параметры, аналогичные CreateWindow. Указать <xref:System.Windows.Interop.HwndSource> о WPF содержимого, которое требуется поместить. Наконец, вы получаете HWND из <xref:System.Windows.Interop.HwndSource>. В этом пошаговом руководстве описывается создание смешанного WPF внутри [!INCLUDE[TLA2#tla_win32](../../../../includes/tla2sharptla-win32-md.md)] приложение, которое повторно реализует операционной системы **свойства даты и времени** диалоговое окно.

## <a name="prerequisites"></a>Предварительные требования

См. в разделе [взаимодействие WPF и Win32](wpf-and-win32-interoperation.md).

## <a name="how-to-use-this-tutorial"></a>Как использовать этот учебник

Основное внимание в этом учебнике уделяется важным шагам в процессе создания приложения взаимодействия. Пример, поддерживаемый руководства [пример взаимодействия часов Win32](https://go.microsoft.com/fwlink/?LinkID=160051), но этот пример характеризует работу конечного продукта. Этом учебнике приведены шаги, как если бы вы начали с существующим [!INCLUDE[TLA2#tla_win32](../../../../includes/tla2sharptla-win32-md.md)] собственного проекта, возможно с уже существующим проектом и добавили размещенных WPF в приложение. Вы можете сравнить ваш конечный продукт с [пример взаимодействия часов Win32](https://go.microsoft.com/fwlink/?LinkID=160051).

## <a name="a-walkthrough-of-windows-presentation-framework-inside-win32-hwndsource"></a>Пошаговое руководство по WPF внутри Win32 (HwndSource)

На следующем рисунке показан конечный продукт, который должен получиться в результате выполнения инструкций из этого учебника:

![Диалоговое окно "Свойства даты и времени"](./media/interoparch06.PNG "InteropArch06")

Это диалоговое окно можно воссоздать, создав C++ [!INCLUDE[TLA2#tla_win32](../../../../includes/tla2sharptla-win32-md.md)] в проекте [!INCLUDE[TLA#tla_visualstu](../../../../includes/tlasharptla-visualstu-md.md)]и использование редактора диалоговых окон для создания следующих:

![Диалоговое окно "Свойства даты и времени"](./media/interoparch07.PNG "InteropArch07")

(Необходимо использовать [!INCLUDE[TLA#tla_visualstu](../../../../includes/tlasharptla-visualstu-md.md)] использовать <xref:System.Windows.Interop.HwndSource>, и вам не нужно использовать C++ для написания [!INCLUDE[TLA2#tla_win32](../../../../includes/tla2sharptla-win32-md.md)] программы, но это является весьма распространенный способ сделать это и хорошо подходит для пошагового объяснения в учебнике).

Вам необходимо выполнить пять вложенных шагов, чтобы поставить WPF часов в диалоговое окно:

1. Включение вашего [!INCLUDE[TLA2#tla_win32](../../../../includes/tla2sharptla-win32-md.md)] проект, чтобы вызывать управляемый код (**/CLR**), изменив параметры проекта в [!INCLUDE[TLA#tla_visualstu](../../../../includes/tlasharptla-visualstu-md.md)].

2. Создание WPF <xref:System.Windows.Controls.Page> в отдельной библиотеке DLL.

3. Поместите этот WPF <xref:System.Windows.Controls.Page> внутри <xref:System.Windows.Interop.HwndSource>.

4. Получите HWND для, <xref:System.Windows.Controls.Page> с помощью <xref:System.Windows.Interop.HwndSource.Handle%2A> свойство.

5. Используйте [!INCLUDE[TLA2#tla_win32](../../../../includes/tla2sharptla-win32-md.md)] выбрать место для размещения HWND внутри более крупной [!INCLUDE[TLA2#tla_win32](../../../../includes/tla2sharptla-win32-md.md)] приложения

## <a name="clr"></a>/clr

Первым делом необходимо преобразовать этот неуправляемый [!INCLUDE[TLA2#tla_win32](../../../../includes/tla2sharptla-win32-md.md)] проект, в который можно вызывать управляемый код. Используйте параметр компилятора/CLR, который будет связан с необходимыми библиотеками DLL, вы хотите использовать и скорректирует основной метод для использования с WPF.

Чтобы включить использование управляемого кода в проекте C++: Правой кнопкой мыши проект win32clock и выберите **свойства**. На **Общие** страницы свойств (по умолчанию), измените поддержку общеязыковой на `/clr`.

Добавьте ссылки на библиотеки DLL, необходимые для WPF: PresentationCore.dll, PresentationFramework.dll, System.dll, WindowsBase.dll, UIAutomationProvider.dll и UIAutomationTypes.dll. (Следующие инструкции предполагают, что операционная система установлена на диске C:.)

1. Щелкните правой кнопкой мыши проект win32clock и выберите **ссылки...** , а внутри этого диалогового окна:

2. Щелкните правой кнопкой мыши проект win32clock и выберите **ссылки...** .

3. Нажмите кнопку **добавить новую ссылку**, перейдите на вкладку, введите C:\Program Files\Reference Assemblies\Microsoft\Framework\v3.0\PresentationCore.dll и нажмите кнопку ОК.

4. Повторите для PresentationFramework.dll: C:\Program Files\Reference Assemblies\Microsoft\Framework\v3.0\PresentationFramework.dll.

5. Повторите для WindowsBase.dll: C:\Program Files\Reference Assemblies\Microsoft\Framework\v3.0\WindowsBase.dll.

6. Повторите для UIAutomationTypes.dll: C:\Program Files\Reference Assemblies\Microsoft\Framework\v3.0\UIAutomationTypes.dll.

7. Повторите для UIAutomationProvider.dll: C:\Program Files\Reference Assemblies\Microsoft\Framework\v3.0\UIAutomationProvider.dll.

8. Нажмите кнопку **добавить новую ссылку**, выберите System.dll и нажмите кнопку **ОК**.

9. Нажмите кнопку **ОК** чтобы выйти из страниц свойств win32clock для добавления ссылок.

 Наконец, добавьте `STAThreadAttribute` для `_tWinMain` метод для использования с WPF:

```cpp
[System::STAThreadAttribute]
int APIENTRY _tWinMain(HINSTANCE hInstance,
                     HINSTANCE hPrevInstance,
                     LPTSTR    lpCmdLine,
                     int       nCmdShow)
```

Этот атрибут сообщает CLR , когда он инициализирует [!INCLUDE[TLA#tla_com](../../../../includes/tlasharptla-com-md.md)], его следует использовать модель однопотокового подразделения (STA), который необходим для WPF (и [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)]).

## <a name="create-a-windows-presentation-framework-page"></a>Создание страницы WPF

Создайте библиотеку DLL, которая определяет WPF <xref:System.Windows.Controls.Page>. Часто бывает проще всего создать WPF <xref:System.Windows.Controls.Page> как автономное приложение и записать и отладить WPF таким способом часть. После этого проект можно преобразовать в библиотеку DLL, щелкните правой кнопкой мыши проект, щелкнув **свойства**, перейдя в приложение и изменив тип выходных данных на библиотеку классов Windows.

WPF Проект библиотеки dll можно объединить с [!INCLUDE[TLA2#tla_win32](../../../../includes/tla2sharptla-win32-md.md)] (одно решение, которое содержит два проекта) — проект, щелкните правой кнопкой мыши решение, выберите **добавить/существующий проект**.

Чтобы использовать эту WPF dll из [!INCLUDE[TLA2#tla_win32](../../../../includes/tla2sharptla-win32-md.md)] проекта, необходимо добавить ссылку:

1. Щелкните правой кнопкой мыши проект win32clock и выберите **ссылки...** .

2. Нажмите кнопку **добавить новую ссылку**.

3. Щелкните вкладку **Проекты**. Выберите WPFClock, нажмите кнопку "ОК".

4. Нажмите кнопку **ОК** чтобы выйти из страниц свойств win32clock для добавления ссылок.

## <a name="hwndsource"></a>HwndSource

Далее используется <xref:System.Windows.Interop.HwndSource> вносить WPF <xref:System.Windows.Controls.Page> вид HWND. Добавьте этот блок кода в файл C++:

```cpp
namespace ManagedCode
{
    using namespace System;
    using namespace System::Windows;
    using namespace System::Windows::Interop;
    using namespace System::Windows::Media;

    HWND GetHwnd(HWND parent, int x, int y, int width, int height) {
        HwndSource^ source = gcnew HwndSource(
            0, // class style
            WS_VISIBLE | WS_CHILD, // style
            0, // exstyle
            x, y, width, height,
            "hi", // NAME
            IntPtr(parent)        // parent window
            );

        UIElement^ page = gcnew WPFClock::Clock();
        source->RootVisual = page;
        return (HWND) source->Handle.ToPointer();
    }
}
}
```

 это большой фрагмент кода, который требует определенных пояснений. Первая часть представляет собой различные операторы, поэтому полностью квалифицировать все вызовы не нужно:

```cpp
namespace ManagedCode
{
    using namespace System;
    using namespace System::Windows;
    using namespace System::Windows::Interop;
    using namespace System::Windows::Media;
```

 Затем вы определяете функцию, которая создает WPF содержимого, помещает <xref:System.Windows.Interop.HwndSource> , и возвращает HWND:

```cpp
HWND GetHwnd(HWND parent, int x, int y, int width, int height) {
```

Сначала вы создаете <xref:System.Windows.Interop.HwndSource>, параметры которого аналогичны CreateWindow:

```cpp
HwndSource^ source = gcnew HwndSource(
    0, // class style
    WS_VISIBLE | WS_CHILD, // style
    0, // exstyle
    x, y, width, height,
    "hi", // NAME
    IntPtr(parent) // parent window
);
```

Затем вы создаете WPF класса содержимого, вызывая его конструктор:

```cpp
UIElement^ page = gcnew WPFClock::Clock();
```

Затем вы подключаете страницу, чтобы <xref:System.Windows.Interop.HwndSource>:

```cpp
source->RootVisual = page;
```

 И в последней строке вы возвращаете HWND для <xref:System.Windows.Interop.HwndSource>:

```cpp
return (HWND) source->Handle.ToPointer();
```

## <a name="positioning-the-hwnd"></a>Размещение класса HWND

Теперь, когда создан HWND, содержащий WPF часы, необходимо поместить этот HWND в [!INCLUDE[TLA2#tla_win32](../../../../includes/tla2sharptla-win32-md.md)] диалоговое окно. Если известно, где разместить HWND, было бы просто передать размер и расположение для `GetHwnd` функцию, определенную ранее. Однако для определения диалогового окна вы использовали файл ресурсов, поэтому вы не совсем уверены, где размещаются HWND. Можно использовать [!INCLUDE[TLA#tla_visualstu](../../../../includes/tlasharptla-visualstu-md.md)] редактор диалоговых окон, чтобы поместить [!INCLUDE[TLA2#tla_win32](../../../../includes/tla2sharptla-win32-md.md)] СТАТИЧЕСКОГО элемента управления, где требуется часов («вставить часы здесь») и использовать его для размещения WPF часов.

Месте обработки WM_INITDIALOG можно использовать `GetDlgItem` Чтобы получить HWND для местозаполнителя STATIC:

```cpp
HWND placeholder = GetDlgItem(hDlg, IDC_CLOCK);
```

Затем вычисляется размер и положение местозаполнителя STATIC, чтобы можно было поместить WPF clock в этом месте:

Прямоугольник RECT;

```cpp
GetWindowRect(placeholder, &rectangle);
int width = rectangle.right - rectangle.left;
int height = rectangle.bottom - rectangle.top;
POINT point;
point.x = rectangle.left;
point.y = rectangle.top;
result = MapWindowPoints(NULL, hDlg, &point, 1);
```

Затем местозаполнитель STATIC скрывается:

```cpp
ShowWindow(placeholder, SW_HIDE);
```

И создайте WPF HWND в этом расположении часов:

```cpp
HWND clock = ManagedCode::GetHwnd(hDlg, point.x, point.y, width, height);
```

Чтобы сделать это руководство интересным и создать настоящие WPF часов, вам нужно будет создать WPF управления часов на этом этапе. Это делается, в основном, с помощью разметки, с использованием нескольких обработчиков событий в коде программной части. Поскольку это руководство о взаимодействии, а не о разработке элементов управления, полный код для WPF часов предоставляется здесь как блок кода без отдельных указаний по его построению и что означает каждая часть. Вы можете экспериментировать с этим кодом, чтобы изменить внешний вид и функциональность элемента управления.

Ниже приводится пример разметки:

[!code-xaml[Win32Clock#AllClockXAML](~/samples/snippets/csharp/VS_Snippets_Wpf/Win32Clock/CS/Clock.xaml#allclockxaml)]

И сопутствующий код программной части:

[!code-csharp[Win32Clock#AllClockCS](~/samples/snippets/csharp/VS_Snippets_Wpf/Win32Clock/CS/Clock.xaml.cs#allclockcs)]

Результат выглядит следующим образом:

![Диалоговое окно "Свойства даты и времени"](./media/interoparch08.PNG "InteropArch08")

Чтобы сравнить конечный результат с кодом, сформировавшим этот снимок экрана, см. в разделе [пример взаимодействия часов Win32](https://go.microsoft.com/fwlink/?LinkID=160051).

## <a name="see-also"></a>См. также

- <xref:System.Windows.Interop.HwndSource>
- [Взаимодействие WPF и Win32](wpf-and-win32-interoperation.md)
- [Пример взаимодействия с часами Win32](https://go.microsoft.com/fwlink/?LinkID=160051)
