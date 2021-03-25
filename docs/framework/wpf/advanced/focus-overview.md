---
title: Общие сведения о фокусе
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- applications [WPF], focus
- focus in applications [WPF]
ms.assetid: 0230c4eb-0c8a-462b-ac4b-ae3e511659f4
ms.openlocfilehash: 72b866d714e6a77020bdb74843c3aaa0ba0c3278
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59073888"
---
# <a name="focus-overview"></a>Общие сведения о фокусе
Существует два основных понятия, относящихся к фокусу в WPF: фокус клавиатуры и логический фокус.  Фокус клавиатуры ссылается на элемент, получающий ввод с клавиатуры, а логический фокус ссылается на элемент в области фокуса, имеющий фокус.  Эти понятия подробно освещаются в этом обзоре.  Важно понимать разницу между этими понятиями, чтобы создавать сложные приложения с несколькими областями, в которых можно получить фокус.  
  
 Основные классы, участвующие в управлении фокусом являются <xref:System.Windows.Input.Keyboard> класс, <xref:System.Windows.Input.FocusManager> класс и базовых элементов классы, такие как <xref:System.Windows.UIElement> и <xref:System.Windows.ContentElement>.  Дополнительные сведения о базовых элементах см. в разделе [Общие сведения о базовых элементах](base-elements-overview.md).  
  
 <xref:System.Windows.Input.Keyboard> Класс занимается в основном с фокусом клавиатуры и <xref:System.Windows.Input.FocusManager> занимается в основном с логическим фокусом, однако это не является абсолютным.  Элемент, имеющий фокус клавиатуры, также будет иметь логический фокус, но элемент, имеющий логический фокус, не обязательно будет иметь фокус клавиатуры.  Это видно при использовании <xref:System.Windows.Input.Keyboard> классу задать элемент, имеющий фокус клавиатуры, он также устанавливает логический фокус на элемент.  

<a name="Keyboard_Focus"></a>   
## <a name="keyboard-focus"></a>Фокус клавиатуры  
 Фокус клавиатуры относится к элементу, получающему ввод с клавиатуры.  На всем рабочем столе может быть только один элемент, в котором находится фокус клавиатуры.  В WPF, будет иметь элемент, имеющий фокус клавиатуры <xref:System.Windows.IInputElement.IsKeyboardFocused%2A> присвоено `true`.  Статическое свойство <xref:System.Windows.Input.Keyboard.FocusedElement%2A> на <xref:System.Windows.Input.Keyboard> класс получает элемент, который в данный момент имеет фокус клавиатуры.  
  
 Чтобы элемент мог получить фокус клавиатуры <xref:System.Windows.UIElement.Focusable%2A> и <xref:System.Windows.UIElement.IsVisible%2A> свойства базовых элементов должно быть присвоено `true`.  Некоторые классы, такие как <xref:System.Windows.Controls.Panel> базового класса, имеют <xref:System.Windows.UIElement.Focusable%2A> присвоено `false` по умолчанию; таким образом, необходимо задать <xref:System.Windows.UIElement.Focusable%2A> для `true` Если требуется, чтобы элемент мог получить фокус клавиатуры.  
  
 Фокус клавиатуры можно получить с помощью взаимодействия пользователя с UI, например перехода к элементу или щелчка мышью определенных элементов.  Фокус клавиатуры также могут быть получены программно с помощью <xref:System.Windows.Input.Keyboard.Focus%2A> метод <xref:System.Windows.Input.Keyboard> класса.  <xref:System.Windows.Input.Keyboard.Focus%2A> Метод пытается передать фокус клавиатуры для указанного элемента.  Возвращаемый элемент — это элемент, имеющий фокус клавиатуры, который может отличаться от запрошенного, если старый или новый объект фокуса блокирует запрос.  
  
 В следующем примере используется <xref:System.Windows.Input.Keyboard.Focus%2A> метод, чтобы установить фокус на <xref:System.Windows.Controls.Button>.  
  
 [!code-csharp[focussample#FocusSampleSetFocus](~/samples/snippets/csharp/VS_Snippets_Wpf/FocusSample/CSharp/Window1.xaml.cs#focussamplesetfocus)]
   
  
 <xref:System.Windows.UIElement.IsKeyboardFocused%2A> Свойство в классах базовых элементов получает значение, указывающее, имеет ли элемент фокус клавиатуры.  <xref:System.Windows.UIElement.IsKeyboardFocusWithin%2A> Свойство в классах базовых элементов получает значение, указывающее, имеет ли элемент или один из его визуальных дочерних элементов фокус клавиатуры.  
  
 При настройке начального фокуса при запуске приложения, элемент должен получить фокус должен быть в визуальном дереве первоначального окна, загружаемого этим приложением, и элемент должен иметь <xref:System.Windows.UIElement.Focusable%2A> и <xref:System.Windows.UIElement.IsVisible%2A> присвоено `true`.  Рекомендуется устанавливать исходный фокус начинается в <xref:System.Windows.FrameworkElement.Loaded> обработчик событий.  Объект <xref:System.Windows.Threading.Dispatcher> обратного вызова также можно путем вызова <xref:System.Windows.Threading.Dispatcher.Invoke%2A> или <xref:System.Windows.Threading.Dispatcher.BeginInvoke%2A>.  
  
<a name="Logical_Focus"></a>   
## <a name="logical-focus"></a>Логический фокус  
 Логический фокус относится к <xref:System.Windows.Input.FocusManager.FocusedElement%2A?displayProperty=nameWithType> в области фокуса.  Область фокуса — элемент, который отслеживает <xref:System.Windows.Input.FocusManager.FocusedElement%2A> внутри своей области.  Когда фокус клавиатуры покидает область фокуса, элемент с фокусом теряет фокус клавиатуры, но сохраняет логический фокус.  При возвращении фокуса клавиатуры в область фокуса элемент с логическим фокусом получит фокус клавиатуры.  Это позволяет переносить фокус клавиатуры между несколькими областями фокуса, но гарантирует, что элемент с фокусом в области фокуса останется элементом с фокусом клавиатуры, когда фокус вернется в эту область.  
  
 В приложении может быть несколько элементов, имеющих логический фокус, но в отдельной области фокуса может быть только один элемент, имеющий логический фокус.  
  
 Элемент, имеющий фокус клавиатуры, имеет логический фокус для области фокуса, которой он принадлежит.  
  
 Элемент может быть включен в область фокуса в XAML , задав <xref:System.Windows.Input.FocusManager> присоединенное свойство <xref:System.Windows.Input.FocusManager.IsFocusScope%2A> для `true`.  В коде, элемент может быть включен в область фокуса путем вызова <xref:System.Windows.Input.FocusManager.SetIsFocusScope%2A>.  
  
 В нижеследующем примере <xref:System.Windows.Controls.StackPanel> в область фокуса, задав <xref:System.Windows.Input.FocusManager.IsFocusScope%2A> вложенного свойства зависимостей.  
  
 [!code-xaml[MarkupSnippets#MarkupIsFocusScopeXAML](~/samples/snippets/csharp/VS_Snippets_Wpf/MarkupSnippets/CSharp/Window1.xaml#markupisfocusscopexaml)]  
  
 [!code-csharp[FocusSnippets#FocusSetIsFocusScope](~/samples/snippets/csharp/VS_Snippets_Wpf/FocusSnippets/CSharp/Window1.xaml.cs#focussetisfocusscope)]
   
  
 <xref:System.Windows.Input.FocusManager.GetFocusScope%2A> Возвращает область фокуса для заданного элемента.  
  
 Классы в WPF являются областями фокуса по умолчанию <xref:System.Windows.Window>, <xref:System.Windows.Controls.MenuItem>, <xref:System.Windows.Controls.ToolBar>, и <xref:System.Windows.Controls.ContextMenu>.  
  
 <xref:System.Windows.Input.FocusManager.GetFocusedElement%2A> Получает элемент с фокусом для заданной области фокуса.  <xref:System.Windows.Input.FocusManager.SetFocusedElement%2A> Задает элемент с фокусом в заданной области фокуса.  <xref:System.Windows.Input.FocusManager.SetFocusedElement%2A> обычно используется для задания исходного элемента с фокусом.  
  
 В следующем примере элемент с фокусом задается в области фокуса и возвращает элемент с фокусом для области фокуса.  
  
 [!code-csharp[FocusSnippets#FocusGetSetFocusedElement](~/samples/snippets/csharp/VS_Snippets_Wpf/FocusSnippets/CSharp/Window1.xaml.cs#focusgetsetfocusedelement)]
   
  
<a name="Keyboard_Navigation"></a>   
## <a name="keyboard-navigation"></a>Навигация с помощью клавиатуры  
 <xref:System.Windows.Input.KeyboardNavigation> Класс отвечает за реализацию навигации с фокусом клавиатуры по умолчанию, когда нажата одна из клавиш навигации.  Клавиши навигации: Клавиши TAB, SHIFT + TAB, CTRL + TAB, CTRL + SHIFT + TAB, Стрелка вверх, Стрелка вниз, Стрелка влево и Стрелка вправо.  
  
 Поведение навигации контейнера навигации можно изменить при помощи вложенных <xref:System.Windows.Input.KeyboardNavigation> свойства <xref:System.Windows.Input.KeyboardNavigation.TabNavigation%2A>, <xref:System.Windows.Input.KeyboardNavigation.ControlTabNavigation%2A>, и <xref:System.Windows.Input.KeyboardNavigation.DirectionalNavigation%2A>.  Эти свойства имеют тип <xref:System.Windows.Input.KeyboardNavigationMode> и возможные значения: <xref:System.Windows.Input.KeyboardNavigationMode.Continue>, <xref:System.Windows.Input.KeyboardNavigationMode.Local>, <xref:System.Windows.Input.KeyboardNavigationMode.Contained>, <xref:System.Windows.Input.KeyboardNavigationMode.Cycle>, <xref:System.Windows.Input.KeyboardNavigationMode.Once>, и <xref:System.Windows.Input.KeyboardNavigationMode.None>.  Значение по умолчанию — <xref:System.Windows.Input.KeyboardNavigationMode.Continue>, который означает, что элемент не является контейнером навигации.  
  
 В следующем примере создается <xref:System.Windows.Controls.Menu> с количеством <xref:System.Windows.Controls.MenuItem> объектов.  <xref:System.Windows.Input.KeyboardNavigation.TabNavigation%2A> Присоединенное свойство имеет значение <xref:System.Windows.Input.KeyboardNavigationMode.Cycle> на <xref:System.Windows.Controls.Menu>.  При изменении фокуса с помощью клавиши tab в <xref:System.Windows.Controls.Menu>, фокус перемещается из каждого элемента, и при достижении последнего элемента переходит к первому элементу.  
  
 [!code-xaml[MarkupSnippets#MarkupKeyboardNavigationTabNavigationXAML](~/samples/snippets/csharp/VS_Snippets_Wpf/MarkupSnippets/CSharp/Window1.xaml#markupkeyboardnavigationtabnavigationxaml)]  
  
 [!code-csharp[MarkupSnippets#MarkupKeyboardNavigationTabNavigationCODE](~/samples/snippets/csharp/VS_Snippets_Wpf/MarkupSnippets/CSharp/Window1.xaml.cs#markupkeyboardnavigationtabnavigationcode)]
   
  
<a name="Manipulating_Focus_Programmatically"></a>   
## <a name="navigating-focus-programmatically"></a>Перемещение фокуса программными средствами  
 Дополнительные [!INCLUDE[TLA#tla_api](../../../../includes/tlasharptla-api-md.md)] для работы с фокусом являются <xref:System.Windows.UIElement.MoveFocus%2A> и <xref:System.Windows.UIElement.PredictFocus%2A>.  
  
 <xref:System.Windows.FrameworkElement.MoveFocus%2A> изменения фокуса к следующему элементу в приложении.  Объект <xref:System.Windows.Input.TraversalRequest> используется для указания направления.   <xref:System.Windows.Input.FocusNavigationDirection> Передается <xref:System.Windows.UIElement.MoveFocus%2A> указывает, можно перемещать фокус разных направлениях, таких как <xref:System.Windows.Input.FocusNavigationDirection.First>, <xref:System.Windows.Input.FocusNavigationDirection.Last>, <xref:System.Windows.Input.FocusNavigationDirection.Up> и <xref:System.Windows.Input.FocusNavigationDirection.Down>.  
  
 В следующем примере используется <xref:System.Windows.FrameworkElement.MoveFocus%2A> Чтобы изменить элемент с фокусом.  
  
 [!code-csharp[focussample#FocusSampleMoveFocus](~/samples/snippets/csharp/VS_Snippets_Wpf/FocusSample/CSharp/Window1.xaml.cs#focussamplemovefocus)]
   
  
 <xref:System.Windows.FrameworkElement.PredictFocus%2A> Возвращает объект, который должен получить фокус, если фокус должен быть изменен.  В настоящее время только <xref:System.Windows.Input.FocusNavigationDirection.Up>, <xref:System.Windows.Input.FocusNavigationDirection.Down>, <xref:System.Windows.Input.FocusNavigationDirection.Left>, и <xref:System.Windows.Input.FocusNavigationDirection.Right> поддерживаются <xref:System.Windows.FrameworkElement.PredictFocus%2A>.  
  
<a name="Focus_Events"></a>   
## <a name="focus-events"></a>События фокуса  
 События, связанные с фокусом клавиатуры: <xref:System.Windows.Input.Keyboard.PreviewGotKeyboardFocus>, <xref:System.Windows.Input.Keyboard.GotKeyboardFocus> и <xref:System.Windows.Input.Keyboard.PreviewLostKeyboardFocus>, <xref:System.Windows.Input.Keyboard.LostKeyboardFocus>.  События определяются как вложенные события в <xref:System.Windows.Input.Keyboard> класса, но более легко доступны как эквивалентные перенаправленные события в классах базовых элементов.  Дополнительные сведения о событиях см. в разделе [Общие сведения о перенаправленных событиях](routed-events-overview.md).  
  
 <xref:System.Windows.Input.Keyboard.GotKeyboardFocus> вызывается, когда элемент получает фокус клавиатуры.  <xref:System.Windows.Input.Keyboard.LostKeyboardFocus> вызывается, когда элемент теряет фокус клавиатуры.  Если <xref:System.Windows.Input.Keyboard.PreviewGotKeyboardFocus> событий или <xref:System.Windows.Input.Keyboard.PreviewLostKeyboardFocusEvent> событие обрабатывается и <xref:System.Windows.RoutedEventArgs.Handled%2A> присваивается `true`, а затем фокус не изменится.  
  
 В следующем примере подключается <xref:System.Windows.UIElement.GotKeyboardFocus> и <xref:System.Windows.UIElement.LostKeyboardFocus> обработчики событий для <xref:System.Windows.Controls.TextBox>.  
  
 [!code-xaml[keyboardsample#KeyboardSampleXAMLHandlerHookup](~/samples/snippets/csharp/VS_Snippets_Wpf/KeyboardSample/CSharp/Window1.xaml#keyboardsamplexamlhandlerhookup)]  
  
 Когда <xref:System.Windows.Controls.TextBox> получает фокус клавиатуры, <xref:System.Windows.Controls.Control.Background%2A> свойство <xref:System.Windows.Controls.TextBox> изменяется на <xref:System.Windows.Media.Brushes.LightBlue%2A>.  
  
 [!code-csharp[keyboardsample#KeyboardSampleGotFocus](~/samples/snippets/csharp/VS_Snippets_Wpf/KeyboardSample/CSharp/Window1.xaml.cs#keyboardsamplegotfocus)]
   
  
 Когда <xref:System.Windows.Controls.TextBox> теряет фокус клавиатуры, <xref:System.Windows.Controls.Control.Background%2A> свойство <xref:System.Windows.Controls.TextBox> изменяется обратно на белое.  
  
 [!code-csharp[keyboardsample#KeyboardSampleLostFocus](~/samples/snippets/csharp/VS_Snippets_Wpf/KeyboardSample/CSharp/Window1.xaml.cs#keyboardsamplelostfocus)]
   
  
 События, связанные с логическим фокусом: <xref:System.Windows.UIElement.GotFocus> и <xref:System.Windows.UIElement.LostFocus>.  Эти события определяются в <xref:System.Windows.Input.FocusManager> как Прикрепленные события, но <xref:System.Windows.Input.FocusManager> не предоставляет оболочки событий среды CLR.  <xref:System.Windows.UIElement> и <xref:System.Windows.ContentElement> предоставляют эти события более удобным.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Input.FocusManager>
- <xref:System.Windows.UIElement>
- <xref:System.Windows.ContentElement>
- [Общие сведения о входных данных](input-overview.md)
- [Общие сведения о базовых элементах](base-elements-overview.md)
