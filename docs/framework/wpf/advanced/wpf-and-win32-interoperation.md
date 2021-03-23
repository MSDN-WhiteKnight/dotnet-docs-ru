---
title: Взаимодействие WPF и Win32
ms.date: 03/30/2017
helpviewer_keywords:
- hosting WPF content in Win32 window [WPF]
- HWND interop [WPF]
- Win32 code [WPF], WPF interoperation
- interoperability [WPF], Win32
ms.assetid: 0ffbde0d-701d-45a3-a6fa-dd71f4d9772e
ms.openlocfilehash: 71c454edc6a124f732f1e6b56e25c28671fa11b6
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59314416"
---
# <a name="wpf-and-win32-interoperation"></a>Взаимодействие WPF и Win32
В этом разделе приводится общее описание метода обеспечения взаимодействия WPF и кода [!INCLUDE[TLA2#tla_win32](../../../../includes/tla2sharptla-win32-md.md)]. [!INCLUDE[TLA#tla_winclient](../../../../includes/tlasharptla-winclient-md.md)] предоставляет среду с широкими возможностями для создания приложений. Однако если имеется сложный код [!INCLUDE[TLA#tla_win32](../../../../includes/tlasharptla-win32-md.md)], возможно, более эффективным будет повторное использование части этого кода.  

<a name="basics"></a>   
## <a name="wpf-and-win32-interoperation-basics"></a>Основы взаимодействия WPF и Win32  
 Существуют два основных метода взаимодействия между WPF и кодом [!INCLUDE[TLA2#tla_win32](../../../../includes/tla2sharptla-win32-md.md)].  
  
-   Размещение содержимого WPF в окне [!INCLUDE[TLA2#tla_win32](../../../../includes/tla2sharptla-win32-md.md)]. С помощью этого способа можно использовать дополнительные графические возможности WPF в структуре стандартных окон и приложений [!INCLUDE[TLA2#tla_win32](../../../../includes/tla2sharptla-win32-md.md)].  
  
-   Размещение окна [!INCLUDE[TLA2#tla_win32](../../../../includes/tla2sharptla-win32-md.md)] в содержимом WPF. С помощью этого способа можно использовать существующий пользовательский элемент управления [!INCLUDE[TLA2#tla_win32](../../../../includes/tla2sharptla-win32-md.md)] в контексте другого содержимого WPF и передавать данные через границы.  
  
 Каждый из этих способов детально представлен в этом разделе. Для иллюстрации, Дополнительные примеры кода, на котором размещается WPF в [!INCLUDE[TLA2#tla_win32](../../../../includes/tla2sharptla-win32-md.md)], см. в разделе [Пошаговое руководство: Размещение содержимого WPF в Win32](walkthrough-hosting-wpf-content-in-win32.md). Для иллюстрации, Дополнительные примеры кода, на котором размещается [!INCLUDE[TLA2#tla_win32](../../../../includes/tla2sharptla-win32-md.md)] в WPF, см. в разделе [Пошаговое руководство: Размещение элемента управления Win32 в WPF](walkthrough-hosting-a-win32-control-in-wpf.md).  
  
<a name="projects"></a>   
## <a name="wpf-interoperation-projects"></a>Проекты взаимодействия WPF  
 WPF [!INCLUDE[TLA2#tla_api#plural](../../../../includes/tla2sharptla-apisharpplural-md.md)] are managed code, but most existing [!INCLUDE[TLA2#tla_win32](../../../../includes/tla2sявляются управляемым кодом, но большинство существующих [!INCLUDE[TLA2#tla_win32](../../../../includes/tla2sharptla-win32-md.md)] программы создаются в виде неуправляемого [!INCLUDE[TLA2#tla_cpp](../../../../includes/tla2sharptla-cpp-md.md)].enНевозможно вызвать WPF [!INCLUDE[TLA2#tla_api#plural](../../../../includes/tla2sharptla-apisharpplural-md.md)] из подлинной неуправляемой программы.nОднако используя параметр `/clr` с компилятором [!INCLUDE[TLA#tla_visualcpp](../../../../includes/tlasharptla-visualcpp-md.md)], можно создать смешанную управляемую-неуправляемую программу, где могут равномерно смешиваться управляемые и неуправляемые вызовы [!INCLUDE[TLA2#tla_api](../../../../includes/tla2sharptla-api-md.md)].  
  
 Существует одна сложность на уровне проекта, которая заключается в том, что нельзя скомпилировать файлы [!INCLUDE[TLA#tla_xaml](../../../../includes/tlasharptla-xaml-md.md)] в проект [!INCLUDE[TLA2#tla_cpp](../../../../includes/tla2sharptla-cpp-md.md)].  Имеется несколько методов разделения проектов для решения данной проблемы.  
  
-   Создать библиотеку DLL C#, содержащий все вашей [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] страницы в форме скомпилированной сборки, а затем вашей [!INCLUDE[TLA2#tla_cpp](../../../../includes/tla2sharptla-cpp-md.md)] включите в исполняемый файл [!INCLUDE[TLA2#tla_dll](../../../../includes/tla2sharptla-dll-md.md)] как ссылку.  
  
-   Создайте на C# исполняемый файл для WPF содержимого и его ссылаться [!INCLUDE[TLA2#tla_cpp](../../../../includes/tla2sharptla-cpp-md.md)] [!INCLUDE[TLA2#tla_dll](../../../../includes/tla2sharptla-dll-md.md)] , содержащий [!INCLUDE[TLA2#tla_win32](../../../../includes/tla2sharptla-win32-md.md)] содержимого.  
  
-   Используйте <xref:System.Windows.Markup.XamlReader.Load%2A> загружать все [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] во время выполнения вместо компиляции вашей [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)].  
  
-   Не используйте [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] вообще и записать все ваши WPF в коде, создавая дерево элементов из <xref:System.Windows.Application>.  
  
 Используйте любой наиболее подходящий способ.  
  
> [!NOTE]
>  Если вы еще не пользовались [!INCLUDE[TLA#tla_cppcli](../../../../includes/tlasharptla-cppcli-md.md)], то можете заметить некоторые "новые" ключевые слова, например `gcnew` и `nullptr`, в примерах кода взаимодействия. Эти ключевые слова заменяют более старый синтаксис с двойным подчеркиванием (`__gc`) и обеспечивают более естественный синтаксис для управляемого кода в [!INCLUDE[TLA2#tla_cpp](../../../../includes/tla2sharptla-cpp-md.md)].  Дополнительные сведения о возможностях управляемого кода [!INCLUDE[TLA#tla_cppcli](../../../../includes/tlasharptla-cppcli-md.md)] см. в статьях [Расширения компонентов для платформ среды выполнения](/cpp/windows/component-extensions-for-runtime-platforms) и [Знакомство с C ++/ CLI](https://go.microsoft.com/fwlink/?LinkId=98739).  
  
<a name="hwnds"></a>   
## <a name="how-wpf-uses-hwnds"></a>Как в WPF используются дескрипторы HWND  
 Для эффективного использования взаимодействия HWND в WPF необходимо понимать, как в WPF используются дескрипторы HWND. Для любого HWND нельзя смешивать отрисовку WPF с отрисовкой [!INCLUDE[TLA2#tla_dx](../../../../includes/tla2sharptla-dx-md.md)] или отрисовкой [!INCLUDE[TLA2#tla_gdi](../../../../includes/tla2sharptla-gdi-md.md)] / [!INCLUDE[TLA2#tla_gdiplus](../../../../includes/tla2sharptla-gdiplus-md.md)]. Это имеет ряд последствий. В первую очередь для смешивания этих моделей отрисовки необходимо создать решение взаимодействия и использовать специальные сегменты взаимодействия для каждой модели отрисовки, которая выбрана для использования. Кроме того, получаемое при отрисовке изображение создает ограничение airspace для решения взаимодействия, которое можно применить. Концепция airspace более подробно рассматривается в разделе [Общие сведения об областях применения технологий](technology-regions-overview.md).  
  
 Все элементы WPF на экране в конечном счете поддерживаются дескриптором окна HWND. При создании WPF <xref:System.Windows.Window>, WPF создает HWND верхнего уровня и использует <xref:System.Windows.Interop.HwndSource> поместить <xref:System.Windows.Window> и его WPF содержимое внутри HWND.  Остальная часть содержимого WPF в приложении также использует этот единственный дескриптор HWND. Исключением являются меню, поля с раскрывающимся списком и другие всплывающие окна. Эти элементы создают свое собственное окно верхнего уровня, поэтому меню WPF может выйти за край HWND окна, которое его содержит. При использовании <xref:System.Windows.Interop.HwndHost> для размещения HWND внутри WPF, WPF информирует [!INCLUDE[TLA2#tla_win32](../../../../includes/tla2sharptla-win32-md.md)] как разместить новый дочерний дескриптор HWND относительно WPF <xref:System.Windows.Window> HWND.  
  
 С HWND связано понятие прозрачности внутри и между каждым дескриптором HWND. Оно также рассматривается в разделе [Общие сведения об областях применения технологий](technology-regions-overview.md).  
  
<a name="hosting_a_wpf_page"></a>   
## <a name="hosting-wpf-content-in-a-microsoft-win32-window"></a>Размещение содержимого WPF в окне Microsoft Win32  
 Ключом к размещению WPF на [!INCLUDE[TLA2#tla_win32](../../../../includes/tla2sharptla-win32-md.md)] окно <xref:System.Windows.Interop.HwndSource> класса. Этот класс заключает содержимое WPF в окно [!INCLUDE[TLA2#tla_win32](../../../../includes/tla2sharptla-win32-md.md)] таким образом, что содержимое WPF может быть включено в [!INCLUDE[TLA#tla_ui](../../../../includes/tlasharptla-ui-md.md)] в качестве дочернего окна. Следующий подход объединяет [!INCLUDE[TLA2#tla_win32](../../../../includes/tla2sharptla-win32-md.md)] и WPF в одном приложении.  
  
1. Реализуйте содержимое WPF (содержимое корневого элемента) в виде управляемого класса. Как правило, класс наследуется от одного из классов, которые может содержать несколько дочерних элементов или использоваться в качестве корневого элемента, например <xref:System.Windows.Controls.DockPanel> или <xref:System.Windows.Controls.Page>. В последующих шагах этот класс называется классом содержимого WPF, а его экземпляры называются объектами содержимого WPF.  
  
2. Реализуйте приложение [!INCLUDE[TLA2#tla_win32](../../../../includes/tla2sharptla-win32-md.md)] с помощью [!INCLUDE[TLA2#tla_cppcli](../../../../includes/tla2sharptla-cppcli-md.md)]. При запуске существующего неуправляемого приложения [!INCLUDE[TLA2#tla_cpp](../../../../includes/tla2sharptla-cpp-md.md)], как правило, можно разрешить ему вызывать управляемый код путем изменения параметров проекта с целью включения флага компилятора `/clr` (полное описание объектов, необходимых для поддержки компиляции `/clr`, в этом разделе не приводится).  
  
3. Установите в качестве потоковой модели однопотоковое подразделение (STA). WPF Эта потоковая модель используется.  
  
4. Обработайте уведомления WM_CREATE в процедуре окна.  
  
5. В обработчике (или функции, которую вызывает обработчик) выполните указанные ниже действия.  
  
    1.  Создайте новый <xref:System.Windows.Interop.HwndSource> объект с HWND родительского окна как его `parent` параметра.  
  
    2.  Создайте экземпляр вашего класса содержимого WPF.  
  
    3.  Назначьте ссылку WPF объект содержимого <xref:System.Windows.Interop.HwndSource> объект <xref:System.Windows.Interop.HwndSource.RootVisual%2A> свойство.  
  
    4.  <xref:System.Windows.Interop.HwndSource> Объект <xref:System.Windows.Interop.HwndSource.Handle%2A> свойство содержит дескриптор окна (HWND). Чтобы получить HWND, который можно использовать в неуправляемой части приложения, приведите `Handle.ToPointer()` к HWND.  
  
6. Реализуйте управляемый класс, содержащий статическое поле, которое хранит ссылку на объект содержимого WPF. Этот класс позволяет получить ссылку на WPF объекта содержимого из вашей [!INCLUDE[TLA2#tla_win32](../../../../includes/tla2sharptla-win32-md.md)] код, но более важно, защищает ваш <xref:System.Windows.Interop.HwndSource> от случайного удаления сборщиком мусора.  
  
7. Получите уведомления от объекта содержимого WPF, присоединив обработчик к одному или нескольким событиям объекта содержимого WPF.  
  
8. Для взаимодействия с объектом содержимого WPF используйте ссылку, которую сохранили в статическом поле, чтобы задать свойства, методы вызова и т. д.  
  
> [!NOTE]
>  Определить класс содержимого WPF для шага 1 можно частично или полностью в [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] с помощью разделяемого класса по умолчанию класса содержимого. Для этого нужно создать отдельную сборку и сослаться на нее. Несмотря на то, что обычно содержат <xref:System.Windows.Application> объекта в процессе компиляции [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] в сборку, вы не доходят до использования его <xref:System.Windows.Application> как часть взаимодействие, просто используйте один или несколько корневых классов для [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] файлов называется Чтобы для приложения и ссылаться на их разделяемые классы. Оставшаяся часть процедуры практически аналогична описанной выше.  
>   
>  Каждое из этих действий будет показано в коде в разделе [Пошаговое руководство: Размещение содержимого WPF в Win32](walkthrough-hosting-wpf-content-in-win32.md).  
  
<a name="hosting_an_hwnd"></a>   
## <a name="hosting-a-microsoft-win32-window-in-wpf"></a>Размещение окна Microsoft Win32 в WPF  
 Ключом к размещению [!INCLUDE[TLA2#tla_win32](../../../../includes/tla2sharptla-win32-md.md)] окно в другие WPF содержимое <xref:System.Windows.Interop.HwndHost> класса. Он заключает окно в элемент WPF, который можно добавить в дерево элементов WPF. <xref:System.Windows.Interop.HwndHost> также поддерживает [!INCLUDE[TLA2#tla_api#plural](../../../../includes/tla2sharptla-apisharpplural-md.md)] , которые позволяют выполнять такие задачи, как обработка сообщений для размещенного окна. Ниже описываются основные действия.  
  
1. Создайте дерево элементов для приложения WPF (посредством кода или разметки). Найдите соответствующую и допустимую точку в дереве элементов, где <xref:System.Windows.Interop.HwndHost> реализация может быть добавлен как дочерний элемент. В оставшихся действиях процедуры этот элемент называется элементом резервирования.  
  
2. Являются производными от <xref:System.Windows.Interop.HwndHost> для создания объекта, который содержит ваши [!INCLUDE[TLA2#tla_win32](../../../../includes/tla2sharptla-win32-md.md)] содержимого.  
  
3. В размещаемом классе переопределите <xref:System.Windows.Interop.HwndHost> метод <xref:System.Windows.Interop.HwndHost.BuildWindowCore%2A>. Возвратите HWND размещенного окна. Вероятно, вам может потребоваться заключить существующие элементы управления в дочернее окно возвращаемого окна. Заключение элементов управления в основное окно представляет собой простой способ получения уведомлений от элементов управления для содержимого WPF. Этот способ позволяет избежать некоторых проблем [!INCLUDE[TLA2#tla_win32](../../../../includes/tla2sharptla-win32-md.md)], касающихся обработки сообщений на границе размещаемых элементов управления.  
  
4. Переопределить <xref:System.Windows.Interop.HwndHost> методы <xref:System.Windows.Interop.HwndHost.DestroyWindowCore%2A> и <xref:System.Windows.Interop.HwndHost.WndProc%2A>. Цель этого — выполнить очистку и удалить ссылки на размещаемое содержимое, особенно если созданы ссылки на неуправляемые объекты.  
  
5. В файле кода программной части создайте экземпляр класса, размещающего элемент управления, и сделайте его дочерним классом элемента резервирования. Обычно используется обработчик событий например <xref:System.Windows.FrameworkElement.Loaded>, или использовать конструктор разделяемого класса. Но можно также добавить содержимое взаимодействия с помощью поведения среды выполнения.  
  
6. Обработайте сообщения выбранного окна, такие как уведомления элементов управления. Существуют два подхода. Оба предоставляют идентичный доступ к потоку сообщений, поэтому выбор во многом определяется удобством программирования.  
  
    -   Реализуйте обработку сообщений для всех сообщений (не только сообщений о завершении работы) в переопределении <xref:System.Windows.Interop.HwndHost> метод <xref:System.Windows.Interop.HwndHost.WndProc%2A>.  
  
    -   Разместите WPF обработку сообщения путем обработки элемента <xref:System.Windows.Interop.HwndHost.MessageHook> событий. Это событие вызывается для каждого сообщения, которое отправляется в главную процедуру размещенного окна.  
  
    -   Не удается обработать сообщения от windows, которые не соответствуют процесс, используя <xref:System.Windows.Interop.HwndHost.WndProc%2A>.  
  
7. Для взаимодействия с размещенным окном используйте вызов неуправляемого кода с целью вызова неуправляемой функции `SendMessage`.  
  
 Следующие действия создают приложение, которое работает с вводом мыши. Вы можете добавить поддержку табуляции для размещенного окна, реализовав <xref:System.Windows.Interop.IKeyboardInputSink> интерфейс.  
  
 Каждое из этих действий будет показано в коде в разделе [Пошаговое руководство: Размещение элемента управления Win32 в WPF](walkthrough-hosting-a-win32-control-in-wpf.md).  
  
### <a name="hwnds-inside-wpf"></a>Дескрипторы HWND внутри WPF  
 Можно представить себе <xref:System.Windows.Interop.HwndHost> как специальный элемент управления. (С технической точки зрения <xref:System.Windows.Interop.HwndHost> — <xref:System.Windows.FrameworkElement> производного класса не <xref:System.Windows.Controls.Control> производного класса, но его можно считать элементом управления применительно к соответствующему взаимодействию.) <xref:System.Windows.Interop.HwndHost> абстрагирует базовые [!INCLUDE[TLA2#tla_win32](../../../../includes/tla2sharptla-win32-md.md)] характер размещенного содержимого таким образом, что в оставшейся части WPF считает размещенное содержимое другим объектом, схожих с элементами управления, который должен отрисовывать и обработки входных данных. <xref:System.Windows.Interop.HwndHost> обычно ведет себя подобно любому другому WPF <xref:System.Windows.FrameworkElement>, несмотря на то, что существуют некоторые важные различия, связанные с выводом (рисование и графика) и вводом (мышь и клавиатура), зависимости от ограничений какие базовыми дескрипторами HWND на может поддерживать.  
  
#### <a name="notable-differences-in-output-behavior"></a>Важные различия в режиме вывода  
  
-   <xref:System.Windows.FrameworkElement>, который является <xref:System.Windows.Interop.HwndHost> базового класса, имеет несколько свойств, которые подразумевают изменение пользовательского интерфейса. К ним относятся свойства, такие как <xref:System.Windows.FrameworkElement.FlowDirection%2A?displayProperty=nameWithType>, которые меняют расположение элементов внутри этого элемента в качестве родительского. Однако большая часть этих свойств не сопоставляется с возможными эквивалентами [!INCLUDE[TLA2#tla_win32](../../../../includes/tla2sharptla-win32-md.md)], даже если такие эквиваленты могут существовать. Многие из этих свойств и их значений слишком специфичны для технологии отрисовки, чтобы сопоставление было целесообразным. Таким образом, такие как установка свойств <xref:System.Windows.FrameworkElement.FlowDirection%2A> на <xref:System.Windows.Interop.HwndHost> не оказывает влияния.  
  
-   <xref:System.Windows.Interop.HwndHost> не может быть повернута, масштабируемой, неравномерные или иным преобразовывать.  
  
-   <xref:System.Windows.Interop.HwndHost> не поддерживает <xref:System.Windows.UIElement.Opacity%2A> свойств (альфа-смешение). Если содержимое внутри <xref:System.Windows.Interop.HwndHost> выполняет <xref:System.Drawing> операций, которые включают данные альфа-канала, который сам не является нарушением, но <xref:System.Windows.Interop.HwndHost> как единое целое поддерживает только значение Opacity = 1,0 (100%).  
  
-   <xref:System.Windows.Interop.HwndHost> будет появляться поверх других WPF элементов в том же окне верхнего уровня. Тем не менее <xref:System.Windows.Controls.ToolTip> или <xref:System.Windows.Controls.ContextMenu> сгенерированное меню является отдельным окном верхнего уровня и поэтому будет работать правильно с <xref:System.Windows.Interop.HwndHost>.  
  
-   <xref:System.Windows.Interop.HwndHost> не учитывает отсеченную область родительского <xref:System.Windows.UIElement>. Это является потенциальной проблемой при попытке поместить <xref:System.Windows.Interop.HwndHost> класс внутри области прокрутки или <xref:System.Windows.Controls.Canvas>.  
  
#### <a name="notable-differences-in-input-behavior"></a>Важные различия в режиме ввода  
  
-   В общем случае, когда устройства ввода находятся в пределах <xref:System.Windows.Interop.HwndHost> размещенных [!INCLUDE[TLA2#tla_win32](../../../../includes/tla2sharptla-win32-md.md)] регион, события ввода поступают непосредственно к [!INCLUDE[TLA2#tla_win32](../../../../includes/tla2sharptla-win32-md.md)].  
  
-   Когда указатель мыши находится над <xref:System.Windows.Interop.HwndHost>, приложение не получает WPF события мыши, а для параметра WPF свойство <xref:System.Windows.UIElement.IsMouseOver%2A> будет `false`.  
  
-   Хотя <xref:System.Windows.Interop.HwndHost> имеет фокус клавиатуры, приложение не получит WPF события и значение WPF свойство <xref:System.Windows.UIElement.IsKeyboardFocusWithin%2A> будет `false`.  
  
-   Когда фокус находится внутри <xref:System.Windows.Interop.HwndHost> и изменения в другой элемент управления внутри <xref:System.Windows.Interop.HwndHost>, приложение не получит WPF события <xref:System.Windows.UIElement.GotFocus> или <xref:System.Windows.UIElement.LostFocus>.  
  
-   Связанные свойства пера и события являются аналогами и не предоставляют сведений, когда перо находится над <xref:System.Windows.Interop.HwndHost>.  
  
<a name="tabbing_mnemonics_accelerators"></a>   
## <a name="tabbing-mnemonics-and-accelerators"></a>Переходы, назначенные клавиши и сочетания клавиш  
 <xref:System.Windows.Interop.IKeyboardInputSink> И <xref:System.Windows.Interop.IKeyboardInputSite> интерфейсы позволяют создавать взаимодействие с помощью клавиатуры для смешанных WPF и [!INCLUDE[TLA2#tla_win32](../../../../includes/tla2sharptla-win32-md.md)] приложений:  
  
-   Переход между компонентами [!INCLUDE[TLA2#tla_win32](../../../../includes/tla2sharptla-win32-md.md)] и WPF  
  
-   Назначенные клавиши и сочетания клавиш, которые работают, когда фокус находится внутри компонента Win32 или WPF.  
  
 <xref:System.Windows.Interop.HwndHost> И <xref:System.Windows.Interop.HwndSource> оба класса позволяют реализовывать <xref:System.Windows.Interop.IKeyboardInputSink>, но они могут обрабатывать входящие сообщения, необходимые для более сложных сценариев. Переопределите соответствующие методы, чтобы получить нужное поведение клавиатуры.  
  
 Интерфейсы обеспечивают поддержку только для событий перехода между областями WPF и [!INCLUDE[TLA2#tla_win32](../../../../includes/tla2sharptla-win32-md.md)]. Внутри области [!INCLUDE[TLA2#tla_win32](../../../../includes/tla2sharptla-win32-md.md)] поведение перехода полностью контролируется логикой перехода, реализованной в [!INCLUDE[TLA2#tla_win32](../../../../includes/tla2sharptla-win32-md.md)], если таковая имеется.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Interop.HwndHost>
- <xref:System.Windows.Interop.HwndSource>
- <xref:System.Windows.Interop>
- [Пошаговое руководство. Размещение элемента управления Win32 в WPF](walkthrough-hosting-a-win32-control-in-wpf.md)
- [Пошаговое руководство. Размещение содержимого WPF в Win32](walkthrough-hosting-wpf-content-in-win32.md)
