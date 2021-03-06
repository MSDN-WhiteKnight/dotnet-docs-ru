---
title: Общие сведения о переходах
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- loose XAML files [WPF]
- windows [WPF]
- Start page [WPF]
- HTML files [WPF]
- structured navigation [WPF]
- fragment navigation [WPF]
- URIs (Uniform Resource Identifiers)
- custom objects [WPF]
- Uniform Resource Identifiers (URIs)
- pages [WPF]
- frames [WPF]
- navigation hosts [WPF]
- journals [WPF]
- lifetimes [WPF]
- retaining content state [WPF]
- content state [WPF]
- programmatic navigation [WPF]
- hyperlinks [WPF]
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
---

# <a name="navigation-overview"></a>Общие сведения о переходах
Windows Presentation Foundation (WPF) поддерживает навигацию в стиле браузера, которую можно использовать в приложениях двух типов: автономных приложениях и XAML-приложениях браузера (XBAP). Чтобы упаковать содержимое для навигации WPF предоставляет класс <xref:System.Windows.Controls.Page>. Можно переходить от одной <xref:System.Windows.Controls.Page> к другой декларативно, с помощью <xref:System.Windows.Documents.Hyperlink>, или программно, с помощью <xref:System.Windows.Navigation.NavigationService>. WPF использует журнал, чтобы запоминать страницы, на которые был осуществлен переход и позволяет возвращаться к ним.  
  
 <xref:System.Windows.Controls.Page>, <xref:System.Windows.Documents.Hyperlink>, <xref:System.Windows.Navigation.NavigationService> и журнал образуют основу для поддержки навигации, предлагаемой WPF. В этом обзоре подробно рассматриваются эти возможности, а также расширенная поддержка переходов, включающая переход к свободным XAML файлам, HTML и произвольным объектам.  
  
> [!NOTE]
>  В этом разделе термин «браузер» относится только к браузерам, в которых можно разместить WPF-приложения, т.е. Internet Explorer и Firefox.  

## <a name="navigation-in-wpf-applications"></a>Переходы в приложениях WPF  
 В этом разделе содержится обзор основных возможностей перехода в WPF. Эти возможности доступны для автономных приложений и XBAP, но в этом разделе они представлены в контексте XBAP.  
  
> [!NOTE]
>  В этом разделе не обсуждаются построение и развертывание XBAP. Дополнительные сведения о XBAP см. в разделе [Обзор приложений браузера XAML WPF](wpf-xaml-browser-applications-overview.md).  
  
 В этом разделе объясняются и демонстрируются следующие аспекты переходов.  
  
-   [Реализация страницы](#CreatingAXAMLPage)  
  
-   [Настройка начальной страницы](#Configuring_a_Start_Page)  
  
-   [Настройка заголовка, ширины и высоты основного окна](#ConfiguringAXAMLPage)  
  
-   [Переход по гиперссылке](#NavigatingBetweenXAMLPages)  
  
-   [Переход к фрагменту](#FragmentNavigation)  
  
-   [Служба переходов](#NavigationService)  
  
-   [Программный переход с помощью службы переходов](#Programmatic_Navigation_with_the_Navigation_Service)  
  
-   [Время существования перехода](#Navigation_Lifetime)  
  
-   [Запоминание перехода в журнале](#NavigationHistory)  
  
-   [Время существования страницы и журнал](#PageLifetime)  
  
-   [Сохранение состояния содержимого с помощью журнала переходов](#RetainingContentStateWithNavigationHistory)  
  
-   [Файлы cookie](#Cookies)  
  
-   [Структурная навигация](#Structured_Navigation)  
  
<a name="CreatingAXAMLPage"></a>   
### <a name="implementing-a-page"></a>Реализация страницы  
 В WPF вы можете перейти к нескольким типам содержимого, включая объекты .NET Framework, пользовательские объекты, значения перечисления, пользовательские элементы управления, XAML файлы и HTML файлы. Тем не менее наиболее распространенным и удобным способом упаковки содержимого является <xref:System.Windows.Controls.Page>. Кроме того, <xref:System.Windows.Controls.Page> реализует особые возможности перехода в целях улучшения внешнего вида приложений и упрощения их разработки.
  
 С помощью <xref:System.Windows.Controls.Page> можно декларативно реализовать доступную для перехода страницу XAML содержимого с помощью разметки, как показано ниже.  
  
 [!code-xaml[NavigationOverviewSnippets#Page1XAML](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/Page1.xaml#page1xaml)]  
  
 Объект <xref:System.Windows.Controls.Page>, реализованный в XAML, имеет корневой элемент разметки `Page` и требует объявление XML-пространства имен WPF. Элемент `Page` содержит содержимое, к которому необходимо осуществить переход. Для добавления содержимого задается свойство `Page.Content`, как показано в следующем примере разметки.
  
 [!code-xaml[NavigationOverviewSnippets#Page2XAML](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/Page2.xaml#page2xaml)]  
  
 `Page.Content` может содержать только один дочерний элемент; в предыдущем примере, содержимым является отдельная строка «Hello, Page!». На практике обычно как дочерний элемент для создания и хранения содержимого используется элемент управления макетом (см. в разделе [макет](../advanced/layout.md)).
  
 Дочерний элемент `Page` считаются содержимым класса <xref:System.Windows.Controls.Page> и, следовательно, не нужно использовать явное присвоение `Page.Content`. Следующая разметка является декларативным эквивалентом предыдущего примера.
  
 [!code-xaml[NavigationOverviewSnippets#Page3XAML](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/Page3.xaml#page3xaml)]  
  
 В этом случае `Page.Content` автоматически задается дочерним элементом `Page`. Дополнительные сведения см. в разделе [Модель содержимого WPF](../controls/wpf-content-model.md).  
  
 Определение <xref:System.Windows.Controls.Page> только в разметке полезно для отображения содержимого. Тем не менее <xref:System.Windows.Controls.Page> также может отображать элементы управления, позволяющие пользователям взаимодействовать со страницей, и он может отвечать на действия пользователя, выполняя обработку событий и вызывая логику приложения. Интерактивная <xref:System.Windows.Controls.Page> реализуется с помощью комбинации разметки и кода программной части, как показано в следующем примере.
  
 [!code-xaml[XBAPAppDefSnippets#HomePageMARKUP](~/samples/snippets/csharp/VS_Snippets_Wpf/XBAPAppDefSnippets/CSharp/HomePage.xaml#homepagemarkup)]  
  
 [!code-csharp[XBAPAppDefSnippets#HomePageCODEBEHIND](~/samples/snippets/csharp/VS_Snippets_Wpf/XBAPAppDefSnippets/CSharp/HomePage.xaml.cs#homepagecodebehind)]
   
  
 Чтобы разрешить совместную работу файла разметки и файла кода программной части, требуется следующая конфигурация.  
  
-   В разметке `Page` элемент должен включать атрибут `x:Class`. При построении приложения существование `x:Class` в разметке указывает Microsoft Build Engine (MSBuild) создать `partial` класс, производный от <xref:System.Windows.Controls.Page> и имеющий имя, заданное параметром атрибута `x:Class`. Это требует добавления в XML объявления пространства имен для схемы XAML ( `xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"` ). Созданный `partial` класс реализует `InitializeComponent`, который вызывается для регистрации событий и задания свойств, реализованных в разметке.
  
-   В коде программной части должен быть `partial` класс с тем же именем, который был задан параметром атрибута `x:Class` в разметке и он должен быть производным от <xref:System.Windows.Controls.Page>. Это позволяет связать файл кода с `partial` классом, созданным для файла разметки при построении приложения (см. в разделе [построение приложения WPF](building-a-wpf-application-wpf.md)).
  
-   В коде программной части класс <xref:System.Windows.Controls.Page> должен реализовывать конструктор, который вызывает `InitializeComponent`. Метод `InitializeComponent` реализуется в `partial` классе, созданном на основе реазметки, для регистрации событий и задания свойств, которые определены в разметке.  
  
> [!NOTE]
>  При добавлении нового <xref:System.Windows.Controls.Page> в проект, использующий Microsoft Visual Studio, <xref:System.Windows.Controls.Page> реализуется с помощью разметки и кода программной части и включает необходимую конфигурацию для создания связи между файлами разметки и кода, как было описано здесь.
  
 Имея созданную <xref:System.Windows.Controls.Page>, можно осуществить переход к ней. Чтобы указать первую <xref:System.Windows.Controls.Page>, к которой приложение переходит, необходимо настроить начальную <xref:System.Windows.Controls.Page>.
  
<a name="Configuring_a_Start_Page"></a>   
### <a name="configuring-a-start-page"></a>Настройка начальной страницы  
 XBAP требуется определенная инфраструктура для размещения в обозревателе. В WPF класс <xref:System.Windows.Application> является частью определения приложения, которое устанавливает необходимую инфраструктуру приложения (см. в разделе [Общие сведения об управлении приложением](application-management-overview.md)).
  
 Определение приложения обычно реализуется с помощью разметки и кода программной части, с файлом разметки, настроенным как элемент `ApplicationDefinition`  MSBuild. Ниже приведен определение приложения для XBAP.
  
 [!code-xaml[XBAPAppDefSnippets#XBAPApplicationDefinitionMARKUP](~/samples/snippets/csharp/VS_Snippets_Wpf/XBAPAppDefSnippets/CSharp/App.xaml#xbapapplicationdefinitionmarkup)]  
  
 [!code-csharp[XBAPAppDefSnippets#XBAPApplicationDefinitionCODEBEHIND](~/samples/snippets/csharp/VS_Snippets_Wpf/XBAPAppDefSnippets/CSharp/App.xaml.cs#xbapapplicationdefinitioncodebehind)]
   
  
 Можно использовать определение приложения XBAP, чтобы указать начальную <xref:System.Windows.Controls.Page>, которая автоматически открывается при запуске приложения. Это можно сделать, присвоив свойству <xref:System.Windows.Application.StartupUri%2A> URI нужной <xref:System.Windows.Controls.Page>.
  
> [!NOTE]
>  В большинстве случаев <xref:System.Windows.Controls.Page> компилируется и развертывается вместе с приложением. В этих случаях URI, идентифицирующий <xref:System.Windows.Controls.Page> — это pack URI, который соответствует схеме *pack*. Pack URI рассматриваются далее в разделе [URI типа Pack в WPF](pack-uris-in-wpf.md). Для перехода к содержимому можно также использовать схему HTTP, которая рассматривается далее.  
  
 Можно задать <xref:System.Windows.Application.StartupUri%2A> декларативно в разметке, как показано в следующем примере.  
  
 [!code-xaml[NavigationOverviewSnippets#XBAPApplicationDefinitionMARKUP](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/App.xaml#xbapapplicationdefinitionmarkup)]  
  
 В этом примере `StartupUri` присваивается относительный pack URI файла `HomePage.xaml`. При запуске XBAP будет автоматически осуществлен переход к HomePage.xaml. Это показано на следующем рисунке, показывающем XBAP, запущенное с веб-сервера.
  
 ![XBAP-страница](./media/navigation-overview/xbap-launched-from-a-web-server.png "показывает, приложение XBAP, запускаемое с веб-сервера")  
  
> [!NOTE]
>  Дополнительные сведения о разработке и развертывании XBAP, см. в разделах [Обзор приложений браузера XAML WPF](wpf-xaml-browser-applications-overview.md) и [развертывание приложений WPF](deploying-a-wpf-application-wpf.md).  

<a name="ConfiguringAXAMLPage"></a>   
### <a name="configuring-the-host-windows-title-width-and-height"></a>Настройка заголовка, ширины и высоты основного окна  
 Одна деталь, которую вы могли заметить в предыдущем примере — то, что заголовком как браузера, так и панели вкладок является URI XBAP. Этот заголовок не только слишком длинный, но также он не является ни привлекательным, ни информативным. По этой причине <xref:System.Windows.Controls.Page> предлагает способ для изменения заголовка заданием свойства <xref:System.Windows.Controls.Page.WindowTitle%2A>. Кроме того, можно настроить ширину и высоту окна браузера, задав свойства <xref:System.Windows.Controls.Page.WindowWidth%2A> и <xref:System.Windows.Controls.Page.WindowHeight%2A>, соответственно.  
  
 Свойства <xref:System.Windows.Controls.Page.WindowTitle%2A>, <xref:System.Windows.Controls.Page.WindowWidth%2A>, и <xref:System.Windows.Controls.Page.WindowHeight%2A> можно задать декларативно в разметке, как показано в следующем примере.  
  
 [!code-xaml[NavigationOverviewSnippets#HomePageMARKUP](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/HomePage.xaml#homepagemarkup)]  
  
 Результат показан на примере ниже.  
  
 ![Заголовок окна, высота, ширина](./media/navigation-overview/window-title-width-height.png "отображается заголовок окна, высота и ширина, можно настроить.")  
  
<a name="NavigatingBetweenXAMLPages"></a>   
### <a name="hyperlink-navigation"></a>Переход по гиперссылке  
 Типичный XBAP состоит из нескольких страниц. Самый простой способ перехода от одной страницы к другой — использование <xref:System.Windows.Documents.Hyperlink>. Можно декларативно добавить <xref:System.Windows.Documents.Hyperlink> на <xref:System.Windows.Controls.Page> с помощью элемента `Hyperlink`, который показан в следующем примере разметки.  
  
 [!code-xaml[NavigationOverviewSnippets#HyperlinkXAML1](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/PageWithHyperlink.xaml#hyperlinkxaml1)]  
[!code-xaml[NavigationOverviewSnippets#HyperlinkXAML2](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/PageWithHyperlink.xaml#hyperlinkxaml2)]  
[!code-xaml[NavigationOverviewSnippets#HyperlinkXAML3](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/PageWithHyperlink.xaml#hyperlinkxaml3)]  
  
 Объект `Hyperlink` требует следующего:  
  
-   Pack URI <xref:System.Windows.Controls.Page> для перехода, определяемый атрибутом `NavigateUri`.  
  
-   Содержимого, которое пользователь может щелкнуть для осуществления перехода, например текст и изображения (перечень содержимого, которое может содержать `Hyperlink`, см. в разделе <xref:System.Windows.Documents.Hyperlink>).
  
 На следующем рисунке показан XBAP с <xref:System.Windows.Controls.Page>, на которую добавлен <xref:System.Windows.Documents.Hyperlink>.  
  
 ![Страница с гиперссылкой](./media/navigation-overview/xbap-with-a-page-with-a-hyperlink.png "это показывает, приложение XBAP, страница с гиперссылкой.")  
  
 Как и следовало ожидать, щелчок по <xref:System.Windows.Documents.Hyperlink> вызывает в XBAP переход к <xref:System.Windows.Controls.Page>, определяемому атрибутом `NavigateUri`. Кроме того, XBAP добавляет запись для предыдущего <xref:System.Windows.Controls.Page> в список последних страниц в Internet Explorer. Это показано на следующем рисунке.  
  
 ![Кнопка Назад в Internet Explorer](./media/navigation-overview/back-and-forward-navigation.png "Навигация с помощью кнопок Назад и вперед.")  
  
 Помимо поддержки перехода от одного <xref:System.Windows.Controls.Page> к другой, <xref:System.Windows.Documents.Hyperlink> также поддерживает переход к фрагменту.  
  
<a name="FragmentNavigation"></a>   
### <a name="fragment-navigation"></a>Переход к фрагменту  
 *Переход к фрагменту* — это переход к фрагменту содержимого на текущей или другой <xref:System.Windows.Controls.Page>. В WPF, фрагмент содержимого представляет собой данные, содержащиеся в именованном элементе. Именованный элемент — это элемент, имеющий атрибут `Name`. В следующей разметке показан именованный `TextBlock`, содержащий фрагмент содержимого.  
  
 [!code-xaml[NavigationOverviewSnippets#PageWithContentFragmentsMARKUP1](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/PageWithFragments.xaml#pagewithcontentfragmentsmarkup1)]  
[!code-xaml[NavigationOverviewSnippets#PageWithContentFragmentsMARKUP2](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/PageWithFragments.xaml#pagewithcontentfragmentsmarkup2)]  
[!code-xaml[NavigationOverviewSnippets#PageWithContentFragmentsMARKUP3](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/PageWithFragments.xaml#pagewithcontentfragmentsmarkup3)]  
  
 Для перехода к фрагменту атрибут `NavigateUri` элемента <xref:System.Windows.Documents.Hyperlink> должен содержать следующее:  
  
-   URI <xref:System.Windows.Controls.Page>, к фрагменту содержимого которой нужно перейти.  
  
-   Символ "#".  
  
-   Имя элемента на <xref:System.Windows.Controls.Page>, включающего фрагмент содержимого.  
  
 Фрагмент URI имеет следующий формат.  
  
 *URI_страницы* `#` *имя_элемента*.  
  
 Ниже приведен пример `Hyperlink`, настроенной на переход к фрагменту содержимого.  
  
 [!code-xaml[NavigationOverviewSnippets#PageThatNavigatesXAML1](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/PageThatNavigatesToFragment.xaml#pagethatnavigatesxaml1)]  
[!code-xaml[NavigationOverviewSnippets#PageThatNavigatesXAML2](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/PageThatNavigatesToFragment.xaml#pagethatnavigatesxaml2)]  
[!code-xaml[NavigationOverviewSnippets#PageThatNavigatesXAML3](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/PageThatNavigatesToFragment.xaml#pagethatnavigatesxaml3)]  
  
> [!NOTE]
>  В этом разделе описывается реализация переходов фрагмента по умолчанию в WPF. WPF, кроме того, позволяет реализовать собственную схему переходов фрагмента, которая, в частности,  требует обработки событий <xref:System.Windows.Navigation.NavigationService.FragmentNavigation?displayProperty=nameWithType>.  
  
> [!IMPORTANT]
>  Вы можете перейти к фрагментам на свободных XAML-страницах (только для разметки XAML с корневым элементом `Page`) только в том случае, если эти страницы доступны через HTTP.  
>  
>  Тем не менее, свободная XAML-страница может переходить к своим собственным фрагментам.
  
<a name="NavigationService"></a>   
### <a name="navigation-service"></a>Служба переходов  
 Хотя <xref:System.Windows.Documents.Hyperlink> позволяет пользователю осуществить переход к конкретному <xref:System.Windows.Controls.Page>, работа по поиску и загрузке страницы выполняется с помощью класса <xref:System.Windows.Navigation.NavigationService>. По сути, <xref:System.Windows.Navigation.NavigationService> предоставляет возможность обработки запроса перехода со стороны клиентского кода, например от элемента <xref:System.Windows.Documents.Hyperlink>. Кроме того, <xref:System.Windows.Navigation.NavigationService> реализует поддержку более высокого уровня для отслеживания и влияния на запросы перехода.
  
 При нажатии <xref:System.Windows.Documents.Hyperlink>, WPF вызывает <xref:System.Windows.Navigation.NavigationService.Navigate%2A?displayProperty=nameWithType> для обнаружения и загрузки <xref:System.Windows.Controls.Page> по указанному Pack URI. Загруженный <xref:System.Windows.Controls.Page> преобразуется в дерево объектов, корневым объектом которого является загруженный экземпляр <xref:System.Windows.Controls.Page>. Ссылка на корневой объект <xref:System.Windows.Controls.Page> хранится в свойстве  <xref:System.Windows.Navigation.NavigationService.Content%2A?displayProperty=nameWithType>. Pack URI для содержимого, к которому был осуществлен переход, сохраняется в свойстве <xref:System.Windows.Navigation.NavigationService.Source%2A?displayProperty=nameWithType>, при этом свойство <xref:System.Windows.Navigation.NavigationService.CurrentSource%2A?displayProperty=nameWithType> сохраняет Pack URI для последней страницы, к которой был осуществлен переход.  
  
> [!NOTE]
>  WPF приложение может иметь более одного активного <xref:System.Windows.Navigation.NavigationService>. Дополнительные сведения см. в разделе [узлы переходов](#Navigation_Hosts) далее в этой статье.
  
<a name="Programmatic_Navigation_with_the_Navigation_Service"></a>   
### <a name="programmatic-navigation-with-the-navigation-service"></a>Программный переход с помощью службы переходов  
 Вам не нужно знать о <xref:System.Windows.Navigation.NavigationService>, если переход реализован декларативно в разметке с помощью <xref:System.Windows.Documents.Hyperlink>, так как <xref:System.Windows.Documents.Hyperlink> использует <xref:System.Windows.Navigation.NavigationService> за вас. Это означает, что пока прямой или непрямой родитель объекта <xref:System.Windows.Documents.Hyperlink> является узлом перехода (см. в разделе [узлы переходов](#Navigation_Hosts)), <xref:System.Windows.Documents.Hyperlink> будут иметь возможность находить и использовать службу переходов этого узла для обработки запросов навигации.
  
 Тем не менее, существуют ситуации, когда необходимо использовать <xref:System.Windows.Navigation.NavigationService> напрямую, включая следующие:  
  
-   Если вам нужно создать экземпляр <xref:System.Windows.Controls.Page> с помощью конструктора не по умолчанию.  
  
-   Если вам нужно задать свойства <xref:System.Windows.Controls.Page> перед переходом к нему.  
  
-   Когда <xref:System.Windows.Controls.Page>, к которой необходимо осуществлять переход, можно определить только во время выполнения.  
  
 В этих случаях необходимо написать код для программного осуществления перехода посредством вызова метода <xref:System.Windows.Navigation.NavigationService.Navigate%2A> у объекта <xref:System.Windows.Navigation.NavigationService>. Для этого требуется получить ссылку на <xref:System.Windows.Navigation.NavigationService>.  
  
#### <a name="getting-a-reference-to-the-navigationservice"></a>Получение ссылки на службу переходов  
 По причинам, описанным в разделе [узлы переходов](#Navigation_Hosts), WPF приложение может иметь более одного <xref:System.Windows.Navigation.NavigationService>. Это означает, что в коде необходимо предусмотреть способ поиска нужного <xref:System.Windows.Navigation.NavigationService>, который обычно является тем <xref:System.Windows.Navigation.NavigationService>, который привел к текущей <xref:System.Windows.Controls.Page>. Можно получить ссылку на <xref:System.Windows.Navigation.NavigationService> путем вызова статического метода <xref:System.Windows.Navigation.NavigationService.GetNavigationService%2A?displayProperty=nameWithType>. Чтобы получить <xref:System.Windows.Navigation.NavigationService>, который привел к конкретной <xref:System.Windows.Controls.Page>, передайте ссылку на <xref:System.Windows.Controls.Page> в качестве аргумента <xref:System.Windows.Navigation.NavigationService.GetNavigationService%2A>. Следующий код показывает способ получения <xref:System.Windows.Navigation.NavigationService> для текущей <xref:System.Windows.Controls.Page>.
  
[!code-csharp[NavigationOverviewSnippets#GetNSCODEBEHIND1](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/GetNSPage.xaml.cs#getnscodebehind1)]  
[!code-csharp[NavigationOverviewSnippets#GetNSCODEBEHIND2](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/GetNSPage.xaml.cs#getnscodebehind2)]
  
  
 Для быстрого поиска <xref:System.Windows.Navigation.NavigationService>, <xref:System.Windows.Controls.Page> реализует свойство <xref:System.Windows.Controls.Page.NavigationService%2A>. Его использование показано в следующем примере.
  
 [!code-csharp[NavigationOverviewSnippets#GetNSShortcutCODEBEHIND1](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/GetNSPageShortCut.xaml.cs#getnsshortcutcodebehind1)]  
[!code-csharp[NavigationOverviewSnippets#GetNSShortcutCODEBEHIND2](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/GetNSPageShortCut.xaml.cs#getnsshortcutcodebehind2)]
  
  
> [!NOTE]
>  Объект <xref:System.Windows.Controls.Page> может получить только ссылку на его <xref:System.Windows.Navigation.NavigationService> только после срабатывания события <xref:System.Windows.FrameworkElement.Loaded>.
  
#### <a name="programmatic-navigation-to-a-page-object"></a>Программный переход к объекту страницы  
 В следующем примере показано, как использовать <xref:System.Windows.Navigation.NavigationService> для программного перехода к <xref:System.Windows.Controls.Page>. Программный переход является обязательным, поскольку <xref:System.Windows.Controls.Page>, к которой выполняется переход, может быть создана только с помощью конструктора не по умолчанию с параметрами. Элемент <xref:System.Windows.Controls.Page> с нестандартным конструктором показан в следующей разметке и коде.  
  
 [!code-xaml[NavigationOverviewSnippets#PageWithNonDefaultConstructorXAML](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/PageWithNonDefaultConstructor.xaml#pagewithnondefaultconstructorxaml)]  
  
 [!code-csharp[NavigationOverviewSnippets#PageWithNonDefaultConstructorCODEBEHIND](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/PageWithNonDefaultConstructor.xaml.cs#pagewithnondefaultconstructorcodebehind)]
   
  
 <xref:System.Windows.Controls.Page>, которая осуществляет переход к <xref:System.Windows.Controls.Page> с нестандартным конструктором, показана в следующей разметке и коде.  
  
 [!code-xaml[NavigationOverviewSnippets#NSNavigationPageXAML](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/NSNavigationPage.xaml#nsnavigationpagexaml)]  
  
 [!code-csharp[NavigationOverviewSnippets#NSNavigationPageCODEBEHIND](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/NSNavigationPage.xaml.cs#nsnavigationpagecodebehind)]
   
  
 При щелчке по <xref:System.Windows.Documents.Hyperlink> на этой <xref:System.Windows.Controls.Page> запускается переход путем создания экземпляра <xref:System.Windows.Controls.Page> с помощью конструктора не по умолчанию и вызова метода <xref:System.Windows.Navigation.NavigationService.Navigate%2A?displayProperty=nameWithType>. Метод <xref:System.Windows.Navigation.NavigationService.Navigate%2A> принимает ссылку на объект для перехода, а не pack URI.
  
#### <a name="programmatic-navigation-with-a-pack-uri"></a>Программный переход с URI типа pack  
 Если вам необходимо сформировать pack URI программно (например, если  pack URI можно определить только во время выполнения), можно использовать метод <xref:System.Windows.Navigation.NavigationService.Navigate%2A?displayProperty=nameWithType>. Его использование показано в следующем примере.
  
 [!code-xaml[NavigationOverviewSnippets#NSUriNavigationPageXAML](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/NSUriNavigationPage.xaml#nsurinavigationpagexaml)]  
  
 [!code-csharp[NavigationOverviewSnippets#NSUriNavigationPageCODEBEHIND](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/NSUriNavigationPage.xaml.cs#nsurinavigationpagecodebehind)]
   
  
#### <a name="refreshing-the-current-page"></a>Обновление текущей страницы  
 Объект <xref:System.Windows.Controls.Page> не загружается, если он имеет тот же pack URI, что и URI, хранящий в свойстве <xref:System.Windows.Navigation.NavigationService.Source%2A?displayProperty=nameWithType>. Чтобы WPF принудительно загрузил текущую страницу, можно вызвать метод <xref:System.Windows.Navigation.NavigationService.Refresh%2A?displayProperty=nameWithType>, как показано в следующем примере.
  
 [!code-xaml[NavigationOverviewSnippets#NSRefreshNavigationPageXAML1](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/NSRefreshNavigationPage.xaml#nsrefreshnavigationpagexaml1)]  
  
 [!code-csharp[NavigationOverviewSnippets#NSRefreshNavigationPageCODEBEHIND1](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/NSRefreshNavigationPage.xaml.cs#nsrefreshnavigationpagecodebehind1)]
   
[!code-csharp[NavigationOverviewSnippets#NSRefreshNavigationPageCODEBEHIND2](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/NSRefreshNavigationPage.xaml.cs#nsrefreshnavigationpagecodebehind2)]
  
  
<a name="Navigation_Lifetime"></a>   
### <a name="navigation-lifetime"></a>Время существования перехода  
 Как вы уже видели, существует множество способов осуществления перехода. При вызове перехода и во время его осуществления, можно отслеживать и влиять на него с помощью следующих событий, которые реализуются <xref:System.Windows.Navigation.NavigationService>:  
  
-   <xref:System.Windows.Navigation.NavigationService.Navigating>. Происходит, когда запрошен новый переход. Можно использовать для отмены перехода.  
  
-   <xref:System.Windows.Navigation.NavigationService.NavigationProgress>. Происходит периодически во время загрузки, тем самым предоставляя информацию о ходе процесса навигации.  
  
-   <xref:System.Windows.Navigation.NavigationService.Navigated>. Происходит, когда страница найдена и загружена.  
  
-   <xref:System.Windows.Navigation.NavigationService.NavigationStopped>. Происходит, когда переход остановлен (путем вызова <xref:System.Windows.Navigation.NavigationService.StopLoading%2A>), или при запросе нового перехода во время выполнения текущего перехода.  
  
-   <xref:System.Windows.Navigation.NavigationService.NavigationFailed>. Происходит при возникновении ошибки во время перехода к запрошенному содержимому.  
  
-   <xref:System.Windows.Navigation.NavigationService.LoadCompleted>. Происходит, когда содержимое, к которому был осуществлен переход, загружено и проанализировано и начинается его отрисовка.  
  
-   <xref:System.Windows.Navigation.NavigationService.FragmentNavigation>. Происходит в начале перехода к фрагменту содержимого:  
  
    -   немедленно, если нужный фрагмент находится в текущем содержимом;  
  
    -   после загрузки исходного содержимого, если нужный фрагмент находится в другом содержимом.  
  
 События перехода вызываются в порядке, который показан на следующем рисунке.  
  
 ![Таблица потока навигации страницы](./media/navigation-overview/order-of-navigation-events.png "блок-схема событий навигации страницы")  
  
 В общем случае <xref:System.Windows.Controls.Page> не связан с этими событиями. Более вероятно, что они связаны с приложением, и по этой причине эти события также вызываются с помощью класса <xref:System.Windows.Application>:  
  
-   <xref:System.Windows.Application.Navigating?displayProperty=nameWithType>  
  
-   <xref:System.Windows.Application.NavigationProgress?displayProperty=nameWithType>  
  
-   <xref:System.Windows.Application.Navigated?displayProperty=nameWithType>  
  
-   <xref:System.Windows.Application.NavigationFailed?displayProperty=nameWithType>  
  
-   <xref:System.Windows.Application.NavigationStopped?displayProperty=nameWithType>  
  
-   <xref:System.Windows.Application.LoadCompleted?displayProperty=nameWithType>  
  
-   <xref:System.Windows.Application.FragmentNavigation?displayProperty=nameWithType>  
  
 Каждый раз, когда возникает событие <xref:System.Windows.Navigation.NavigationService>, вызывается соответствующее событие <xref:System.Windows.Application>. Элементы <xref:System.Windows.Controls.Frame> и <xref:System.Windows.Navigation.NavigationWindow> обеспечивают те же события, для обнаружения переходов в соответствующих областях.  
  
 В некоторых случаях <xref:System.Windows.Controls.Page> могут заинтересовать эти события. Например <xref:System.Windows.Controls.Page> может обрабатывать событие <xref:System.Windows.Navigation.NavigationService.Navigating?displayProperty=nameWithType>, чтобы определить необходимость отмены перехода. Эти действия показаны в следующем примере.
  
 [!code-xaml[NavigationOverviewSnippets#CancelNavigationPageXAML](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/CancelNavigationPage.xaml#cancelnavigationpagexaml)]  
  
 [!code-csharp[NavigationOverviewSnippets#CancelNavigationPageCODEBEHIND](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/CancelNavigationPage.xaml.cs#cancelnavigationpagecodebehind)]
   
  
 Если вы регистрируете обработчик с событием перехода из <xref:System.Windows.Controls.Page>, как в предыдущем примере, необходимо также впоследствии отменить регистрацию обработчика событий. Если этого не сделать, могут возникнуть побочные эффекты относительно того, как WPF запоминает переходы <xref:System.Windows.Controls.Page> с помощью журнала.

<a name="NavigationHistory"></a>   
### <a name="remembering-navigation-with-the-journal"></a>Запоминание переходов в журнале  
 WPF использует два стека для запоминания страниц, на которые был осуществлен переход: стек переходов назад и вперед. При переходе из текущего <xref:System.Windows.Controls.Page> к новой  <xref:System.Windows.Controls.Page> или вперед к существующей <xref:System.Windows.Controls.Page>, текущая <xref:System.Windows.Controls.Page> добавляется в *стек переходов назад*. При переходе из текущей <xref:System.Windows.Controls.Page> к предыдущей <xref:System.Windows.Controls.Page>, текущая <xref:System.Windows.Controls.Page> добавляется в *стек переходов вперед*. Стек "Назад", стек "Вперед" и функциональные возможности для управления ими в совокупности называются журналом. Каждый элемент в стеке переходов назад и вперед — это экземпляр класса <xref:System.Windows.Navigation.JournalEntry> и называется *запись журнала*. 
  
#### <a name="navigating-the-journal-from-internet-explorer"></a>Перемещение по журналу в браузере Internet Explorer  
 По существу, журнал работает так же, как и кнопки **назад** и **вперед** в Internet Explorer. Это показано на следующем рисунке.  
  
 !["И" Назад кнопки](./media/navigation-overview/back-and-forward-navigation.png "Навигация с помощью кнопок Назад и вперед.")  
  
 Для XBAP, размещаемых в Internet Explorer, WPF осуществляет интеграцию журнала в области навигации UI с Internet Explorer. Это позволяет пользователям перемещаться по страницам в XBAP с помощью кнопок **назад**, **вперед**, и **последние страницы** в Internet Explorer. Журнал не интегрирован в Microsoft Internet Explorer 6 таким же образом, что и в Internet Explorer 7 или Internet Explorer 8. Вместо этого WPF отображает замещающий его UI навигации.
  
> [!IMPORTANT]
>  В Internet Explorer, при переходе со XBAP страницы и обратно, в журнале сохраняются только записи журнала для страниц, которые не поддерживались в активном состоянии. Обсуждение поддержки страниц в активном состоянии см. в разделе [время существования страницы и журнал](#PageLifetime) далее в этом разделе.  
  
 По умолчанию текст для каждого <xref:System.Windows.Controls.Page>, отображаемый в списке **последние страницы** Internet Explorer — URI для <xref:System.Windows.Controls.Page>. В большинстве случаев это не особенно важно для пользователя. К счастью, можно изменить текст, используя следующие параметры.  
  
1. Значение атрибута `JournalEntry.Name`.  
  
2. Значение атрибута `Page.Title`.  
  
3. Значение атрибута `Page.WindowTitle` и URI для текущей <xref:System.Windows.Controls.Page>.  
  
4. URI интерфейса для текущего объекта <xref:System.Windows.Controls.Page>. (Значение по умолчанию)  
  
 Порядок, в котором перечислены параметры, совпадает с порядком приоритета для поиска текста. Например если `JournalEntry.Name` не установлен, другие значения игнорируются.  
  
 В следующем примере используется атрибут `Page.Title`, чтобы изменить текст, отображаемый в записи журнала.  
  
 [!code-xaml[NavigationOverviewSnippets#PageTitleMARKUP1](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/PageWithTitle.xaml#pagetitlemarkup1)]  
[!code-xaml[NavigationOverviewSnippets#PageTitleMARKUP2](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/PageWithTitle.xaml#pagetitlemarkup2)]  
  
 [!code-csharp[NavigationOverviewSnippets#PageTitleCODEBEHIND1](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/PageWithTitle.xaml.cs#pagetitlecodebehind1)]
   
[!code-csharp[NavigationOverviewSnippets#PageTitleCODEBEHIND2](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/PageWithTitle.xaml.cs#pagetitlecodebehind2)]
  
  
#### <a name="navigating-the-journal-using-wpf"></a>Перемещение по журналу с помощью WPF  
 Несмотря на то, что пользователь может перемещаться по журналу с помощью кнопок **назад**, **вперед** и **последние страницы** в Internet Explorer, можно также переходить по журналу с помощью декларативного и программного механизмов, предоставляемых WPF. Одна из причин для этого — предоставление пользовательских переходов UI на страницах.
  
 Можно декларативно добавить поддержку журнального перехода с помощью команд перехода, предоставляемых <xref:System.Windows.Input.NavigationCommands>. Следующий пример демонстрирует, как использовать команду перехода `BrowseBack`.  
  
 [!code-xaml[NavigationOverviewSnippets#NavigationCommandsPageXAML1](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/NavigationCommandsPage.xaml#navigationcommandspagexaml1)]  
[!code-xaml[NavigationOverviewSnippets#NavigationCommandsPageXAML2](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/NavigationCommandsPage.xaml#navigationcommandspagexaml2)]  
[!code-xaml[NavigationOverviewSnippets#NavigationCommandsPageXAML3](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/NavigationCommandsPage.xaml#navigationcommandspagexaml3)]  
[!code-xaml[NavigationOverviewSnippets#NavigationCommandsPageXAML4](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/NavigationCommandsPage.xaml#navigationcommandspagexaml4)]  
  
 Можно программно перемещаться по журналу с помощью одного из следующих членов класса <xref:System.Windows.Navigation.NavigationService>:  
  
-   <xref:System.Windows.Navigation.NavigationService.GoBack%2A>  
  
-   <xref:System.Windows.Navigation.NavigationService.GoForward%2A>  
  
-   <xref:System.Windows.Navigation.NavigationService.CanGoBack%2A>  
  
-   <xref:System.Windows.Navigation.NavigationService.CanGoForward%2A>  
  
 Журналом можно также управлять программным образом, как описано в разделе [сохранение состояния содержимого с помощью журнала переходов](#RetainingContentStateWithNavigationHistory) далее.
  
<a name="PageLifetime"></a>   
### <a name="page-lifetime-and-the-journal"></a>Время существования страницы и журнал  
 Рассмотрим XBAP с несколькими страницами, которые содержат форматированное содержимое, включая графики, анимации и мультимедиа. Объем памяти для подобных страниц может быть довольно большим, особенно если используются видеоматериалы и звуковые файлы. Учитывая, что в журнале посещенные страницы XBAP запоминаются в журнале, они могут быстро израсходовать значительный объем памяти.
  
 По этой причине, по умолчанию журнал хранит в каждой записи журнала метаданные <xref:System.Windows.Controls.Page>, а не ссылку на объекта <xref:System.Windows.Controls.Page>. При переходе к записи журнала метаданные <xref:System.Windows.Controls.Page> используются для создания нового экземпляра указанной <xref:System.Windows.Controls.Page>. Как следствие, каждая <xref:System.Windows.Controls.Page>, к которой осуществляется переход, имеет время существования, которое показано на следующем рисунке.  
  
 ![Время существования страницы](./media/navigation-overview/navigated-page-lifetime.png "отображается время существования, при переходе со страницы.")  
  
 Хотя при использовании поведения журнала по умолчанию можно сэкономить потребление памяти, производительность отрисовки каждой страницы может уменьшиться; повторное создание экземпляров <xref:System.Windows.Controls.Page> может занимать много времени, особенно в том случае, если он имеет много содержимого. Если необходимо сохранить экземпляр <xref:System.Windows.Controls.Page> в журнале, есть два способа это сделать. Во-первых, можно осуществить программный переход к <xref:System.Windows.Controls.Page> путем вызова метода <xref:System.Windows.Navigation.NavigationService.Navigate%2A?displayProperty=nameWithType>.  
  
 Во-вторых, можно указать, чтобы WPF сохранял экземпляр <xref:System.Windows.Controls.Page> в журнале, задав свойству <xref:System.Windows.Controls.Page.KeepAlive%2A> значение `true` (по умолчанию используется `false`). Как показано в следующем примере, можно задать <xref:System.Windows.Controls.Page.KeepAlive%2A> декларативно в разметке.
  
 [!code-xaml[NavigationOverviewSnippets#KeepAlivePageXAML](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/KeepAlivePage.xaml#keepalivepagexaml)]  
  
 Время существования <xref:System.Windows.Controls.Page>, которая поддерживается в активном состоянии, немного отличается от обычных. При первом переходе на такую  <xref:System.Windows.Controls.Page> так же создается экземпляр <xref:System.Windows.Controls.Page>. Тем не менее, так как экземпляр <xref:System.Windows.Controls.Page> сохраняется в журнале, он никогда не инициализируется повторно, пока он остается в журнале. Следовательно, если <xref:System.Windows.Controls.Page> имеет логику инициализации, которая должна вызываться каждый раз при переходе, следует переместить ее из конструктора в обработчик события <xref:System.Windows.FrameworkElement.Loaded>. Как показано на следующем рисунке, события  <xref:System.Windows.FrameworkElement.Loaded> и <xref:System.Windows.FrameworkElement.Unloaded> по-прежнему вызываются каждый раз при переходе к <xref:System.Windows.Controls.Page> и обратно, соответственно.
  
 ![Возникновение событий загрузки и выгрузки](./media/navigation-overview/loaded-and-unloaded-events.png "события загрузки и выгрузки, возникающие при переходе со страницы и обратно.")  
  
 Когда <xref:System.Windows.Controls.Page> не поддерживается в активном состоянии, можно выполнять одно из следующих:

-   Сохранять ссылку или любую его часть.  
-   Зарегистрировать обработчики событий, которые не реализованы в объекте.

 При выполнении любого из этих действий будут созданы ссылки, которые будут удерживать <xref:System.Windows.Controls.Page> в памяти, даже в том случае, если он был удален из журнала.  
  
 В общем случае следует отдавать предпочтение поведение по умолчанию для <xref:System.Windows.Controls.Page>, без поддержки в активном состоянии. Однако это имеет особое влияние на ее состояние, что описано в следующем разделе.
  
<a name="RetainingContentStateWithNavigationHistory"></a>   
### <a name="retaining-content-state-with-navigation-history"></a>Сохранение состояния содержимого с помощью журнала переходов  
 Если <xref:System.Windows.Controls.Page> не поддерживается в активном состоянии, но имеет элементы управления, которые собирают данные от пользователя, что происходит с данными, если пользователь переходит к <xref:System.Windows.Controls.Page> и обратно? С точки зрения пользователя следует ожидать появления ранее введенных данных. К сожалению, так как новый экземпляр класса <xref:System.Windows.Controls.Page> создается при каждом переходе, элементы управления, которые собирают данные, инициализируются заново и данные будут потеряны.
  
 К счастью, журнал обеспечивает запоминание данных при переходах между разными <xref:System.Windows.Controls.Page>, включая данные элементов управления. В частности, записи журнала для каждого <xref:System.Windows.Controls.Page> действуют как временный контейнер для связанного состояния <xref:System.Windows.Controls.Page>. Ниже показано, как используется эта поддержка при переходе с <xref:System.Windows.Controls.Page>:  
  
1. Запись для текущей <xref:System.Windows.Controls.Page> добавляется в журнал.  
  
2. Состояние <xref:System.Windows.Controls.Page> сохраняется в записи журнала для этой страницы, которая добавляется в стек переходов назад.  
  
3. Осуществляется переход к новой <xref:System.Windows.Controls.Page>.  
  
 Если осуществляется обратный переход к <xref:System.Windows.Controls.Page> с помощью журнала, выполняются следующие действия:
  
1. Создается <xref:System.Windows.Controls.Page> (самая верхняя запись журнала в стеке переходов назад).  
  
2. <xref:System.Windows.Controls.Page> обновляется с использованием состояниея, которое было сохранено в записи журнала для <xref:System.Windows.Controls.Page>.  
  
3. Выполняется переход к <xref:System.Windows.Controls.Page>.  
  
 WPF автоматически использует эту поддержку для следующих элементов управления на <xref:System.Windows.Controls.Page>:  
  
-   <xref:System.Windows.Controls.CheckBox>  
  
-   <xref:System.Windows.Controls.ComboBox>  
  
-   <xref:System.Windows.Controls.Expander>  
  
-   <xref:System.Windows.Controls.Frame>  
  
-   <xref:System.Windows.Controls.ListBox>  
  
-   <xref:System.Windows.Controls.ListBoxItem>  
  
-   <xref:System.Windows.Controls.MenuItem>  
  
-   <xref:System.Windows.Controls.ProgressBar>  
  
-   <xref:System.Windows.Controls.RadioButton>  
  
-   <xref:System.Windows.Controls.Slider>  
  
-   <xref:System.Windows.Controls.TabControl>  
  
-   <xref:System.Windows.Controls.TabItem>  
  
-   <xref:System.Windows.Controls.TextBox>  
  
 Если <xref:System.Windows.Controls.Page> использует эти элементы управления, содержащиеся в них данные запоминаются при переходах между <xref:System.Windows.Controls.Page>, как показано для <xref:System.Windows.Controls.ListBox> **Favourite color**  на следующем рисунке.
  
 ![Страница с элементами управления, помнящими состояние](./media/navigation-overview/data-remembered-across-page-navigations.png "введенные данные запоминаются при переходах между страницами.")  
  
 Когда <xref:System.Windows.Controls.Page> имеет элементы управления, не упомянутые в предыдущем списке, или когда состояние сохраняется в пользовательских объектах, необходимо написать код для сохранения в журнале переходов состояния <xref:System.Windows.Controls.Page>.  
  
 Если необходимо запомнить небольшие части состояния <xref:System.Windows.Controls.Page> при переходах, можно использовать свойства зависимостей (см. в разделе <xref:System.Windows.DependencyProperty>), настроенные с помощью флага метаданных <xref:System.Windows.FrameworkPropertyMetadata.Journal%2A?displayProperty=nameWithType>.  
  
 Если состояние <xref:System.Windows.Controls.Page>, которое необходимо сохранить при переходах, состоит из нескольких фрагментов данных, можно сократить код, инкапсулировав состояние в одном классе и реализовав интерфейс <xref:System.Windows.Navigation.IProvideCustomContentState>.  
  
 Если вам необходимо перейти по различным состояниям одного <xref:System.Windows.Controls.Page>, не переходя с <xref:System.Windows.Controls.Page>, можно использовать <xref:System.Windows.Navigation.IProvideCustomContentState> и <xref:System.Windows.Navigation.NavigationService.AddBackEntry%2A?displayProperty=nameWithType>.
  
<a name="Cookies"></a>   
### <a name="cookies"></a>Файлы cookie  
 Другой способ сохранения файлов в приложениях WPF — использование файлов cookie, которые создаются, обновляются и удаляются с помощью методов <xref:System.Windows.Application.SetCookie%2A> и <xref:System.Windows.Application.GetCookie%2A>. Файлы cookie в WPF аналогичны файлам cookie, используемым в других видах веб-приложений; файлы cookie представляют собой произвольные фрагменты данных, которые хранятся в приложении на клиентском компьютере во время сеансов приложения или между ними. Данные файлов cookie обычно представлены в следующем формате.
  
 *имя* `=` *значение*  
  
 При передаче данных в метод <xref:System.Windows.Application.SetCookie%2A>, вместе с <xref:System.Uri> расположения, для которого задается файл cookie, этот файл cookie создается в памяти, и он доступен только в течение текущего сеанса приложения. Этот тип файла cookie называется *файл cookie сеанса*.  
  
 Чтобы сохранить файл cookie на протяжении нескольких сеансов приложения, необходимо добавить в файл cookie дату окончания срока действия, используя следующий формат.  
  
 *ИМЯ* `=` *ЗНАЧЕНИЕ* `; expires=DAY, DD-MMM-YYYY HH:MM:SS GMT`  
  
 Файл cookie с датой окончания срока действия хранится в текущей папке временных файлов Интернета Windows до истечения его срока действия. Такой файл cookie называется *постоянный файл cookie*, так как он сохраняется между сеансами приложения.
  
 Получить сеанс и постоянные файлы cookie можно, вызвав метод <xref:System.Windows.Application.GetCookie%2A>, передавая в него <xref:System.Uri> расположения, где был задан файл cookie с помощью метода <xref:System.Windows.Application.SetCookie%2A>.  
  
 Ниже приведены некоторые способы поддержки файлов cookie в WPF:  
  
-   Автономные приложения WPF и приложения XBAP могут создавать файлы cookie и управлять ими.  
  
-   Файлы cookie, создаваемые XBAP, можно получить из браузера.
  
-   XBAP из одного домена могут создавать и совместно использовать файлы cookie.
  
-   XBAP и HTML-страницы из одного домена могут создавать и совместно использовать файлы cookie.
  
-   Файлы cookie отправляются, когда XBAP и свободные XAML-страницы отправляют веб-запросы.
  
-   И XBAP верхнего уровня, и XBAP, размещенным в IFRAME, доступны файлы cookie.
  
-   Поддержка файлов cookie в WPF одинакова для всех поддерживаемых браузеров.
  
-   В Internet Explorer, политика P3P относительно cookie соблюдается системой WPF, особенно в отношении собственных и сторонних XBAP.  
  
<a name="Structured_Navigation"></a>   
### <a name="structured-navigation"></a>Структурированная навигация  
 Если вам нужно передать данные из одной <xref:System.Windows.Controls.Page> в другую, можно передать данные как аргументы конструктора не по умолчанию <xref:System.Windows.Controls.Page>. Обратите внимание, что если вы используете этот способ, то необходимо поддерживать <xref:System.Windows.Controls.Page> в активном состоянии; если этого не сделать, в следующий раз при переходе к <xref:System.Windows.Controls.Page>, WPF заново создаст <xref:System.Windows.Controls.Page> с помощью конструктора по умолчанию.
  
 Кроме того, ваша <xref:System.Windows.Controls.Page> может реализовать свойства, которые необходимо передать вместе с данными. Все усложняется, если <xref:System.Windows.Controls.Page> необходимо передать данные обратно в <xref:System.Windows.Controls.Page>, с которой был осуществлен переход. Проблема в том, что изначально переходы не поддерживают механизмы, гарантирующие, что будет осуществлен возврат к <xref:System.Windows.Controls.Page> после перехода с него. По существу, переходы не поддерживают семантику вызова/возврата. Чтобы решить эту проблему, WPF предоставляет класс <xref:System.Windows.Navigation.PageFunction%601>, который можно использовать, чтобы гарантировать возврат к <xref:System.Windows.Controls.Page> в прогнозируемом и структурированном виде. Дополнительные сведения см. в разделе [Общие сведения о структурированной навигации](structured-navigation-overview.md).  

<a name="The_NavigationWindow_Class"></a>
## <a name="the-navigationwindow-class"></a>Класс NavigationWindow
 К этому моменту мы рассмотрели целый ряд служб переходов, которые с наибольшей вероятностью будут использоваться для построения приложений с содержимым, допускающим переходы. Эти службы обсуждались в контексте приложений XBAP, несмотря на то, что они не ограничиваются XBAP. Современные автономные приложения Windows также пользуются преимуществами навигации. Вот наиболее распространенные примеры.
  
-   **Тезаурус Word**: Переход по вариантам слов.
  
-   **Обозреватель файлов**: Просмотр файлов и папок.
  
-   **Мастеры**: Разбиение сложной задачи на несколько страниц, которые можно перемещаться. Например, мастер компонентов Windows, который обрабатывает добавление и удаление компонентов Windows.
  
 Для включения навигации в стиле браузера в автономных приложениях можно использовать класс <xref:System.Windows.Navigation.NavigationWindow>. <xref:System.Windows.Navigation.NavigationWindow> является производным от <xref:System.Windows.Window> и расширяет его такой же поддержкой навигации, как и предоставляемой XBAP. Можно использовать <xref:System.Windows.Navigation.NavigationWindow> как главное окно автономного приложения или как дополнительное окно, например диалоговое.
  
 Для реализации <xref:System.Windows.Navigation.NavigationWindow>, как и в случае с большинством классов верхнего уровня в WPF (<xref:System.Windows.Window>, <xref:System.Windows.Controls.Page> и так далее), используется комбинация разметки и кода. Это показано в следующем примере.
  
 [!code-xaml[IntroToNavNavigationWindowSnippets#NavigationWindowMARKUP](~/samples/snippets/csharp/VS_Snippets_Wpf/IntroToNavNavigationWindowSnippets/CSharp/MainWindow.xaml#navigationwindowmarkup)]  
  
 [!code-csharp[IntroToNavNavigationWindowSnippets#NavigationWindowCODEBEHIND](~/samples/snippets/csharp/VS_Snippets_Wpf/IntroToNavNavigationWindowSnippets/CSharp/MainWindow.xaml.cs#navigationwindowcodebehind)]
   
  
 Этот код создает <xref:System.Windows.Navigation.NavigationWindow>, которое автоматически переходит к <xref:System.Windows.Controls.Page> (HomePage.xaml) при открытии <xref:System.Windows.Navigation.NavigationWindow>. Если <xref:System.Windows.Navigation.NavigationWindow> является главным окном приложения, можно использовать атрибут `StartupUri`, чтобы запустить его. Это показано в следующем примере разметки.
  
 [!code-xaml[IntroToNavNavigationWindowSnippets#AppLaunchNavWindow](~/samples/snippets/csharp/VS_Snippets_Wpf/IntroToNavNavigationWindowSnippets/CSharp/App.xaml#applaunchnavwindow)]  
  
 На следующем рисунке показан <xref:System.Windows.Navigation.NavigationWindow> как главное окно автономного приложения.  
  
 ![Главное окно](./media/navigation-overview/navigation-window-as-main-window.png "окно навигации в качестве главного окна")  
  
 Из рисунка, можно увидеть, что <xref:System.Windows.Navigation.NavigationWindow> имеет заголовок, несмотря на то, что он не задан в реализации <xref:System.Windows.Navigation.NavigationWindow>. Вместо этого заголовок задается с помощью свойства <xref:System.Windows.Controls.Page.WindowTitle%2A>, которое показано в следующем коде.  
  
 [!code-xaml[IntroToNavNavigationWindowSnippets#HomePageMARKUP1](~/samples/snippets/csharp/VS_Snippets_Wpf/IntroToNavNavigationWindowSnippets/CSharp/HomePage.xaml#homepagemarkup1)]  
[!code-xaml[IntroToNavNavigationWindowSnippets#HomePageMARKUP2](~/samples/snippets/csharp/VS_Snippets_Wpf/IntroToNavNavigationWindowSnippets/CSharp/HomePage.xaml#homepagemarkup2)]  
  
 Установка <xref:System.Windows.Controls.Page.WindowWidth%2A> и <xref:System.Windows.Controls.Page.WindowHeight%2A> также влияет на <xref:System.Windows.Navigation.NavigationWindow>.  
  
 Обычно вы реализуете собственный <xref:System.Windows.Navigation.NavigationWindow> при необходимости настроить его поведение или внешний вид. Если вы этого не сделали, можно использовать команду быстрого вызова. Если указать pack URI <xref:System.Windows.Controls.Page> как <xref:System.Windows.Application.StartupUri%2A> в автономном приложении, <xref:System.Windows.Application> автоматически создает <xref:System.Windows.Navigation.NavigationWindow> для размещения <xref:System.Windows.Controls.Page>. В следующем примере разметки показано, как это сделать.
  
 [!code-xaml[IntroToNavNavigationWindowSnippets#AppLaunchPage](~/samples/snippets/csharp/VS_Snippets_Wpf/IntroToNavNavigationWindowSnippets/CSharp/AnotherApp.xaml#applaunchpage)]  
  
 Если необходимо, чтобы дополнительным окном приложения, например диалоговым, было <xref:System.Windows.Navigation.NavigationWindow>, можно использовать код как в следующем примере.
  
 [!code-csharp[IntroToNavNavigationWindowSnippets#CreateNWDialogBox](~/samples/snippets/csharp/VS_Snippets_Wpf/IntroToNavNavigationWindowSnippets/CSharp/DialogOwnerWindow.xaml.cs#createnwdialogbox)]
   
  
 На рисунке ниже показан результат.  
  
 ![Диалоговое окно](./media/navigation-overview/navigation-window-as-dialog-box.png "окно навигации как диалоговое окно")  
  
 Как вы видите, <xref:System.Windows.Navigation.NavigationWindow> отображает кнопки **обратно** и **вперед** в стиле Internet Explorer, которые позволяют пользователям перемещаться по журналу. Эти кнопки предоставляют пользователям возможности, показанные на следующем рисунке.  
  
 !["И" Кнопка Назад в NavigationWindow](./media/navigation-overview/back-and-forward-buttons-in-navigation-window.png "\"и\" Кнопка Назад в окне навигации")  
  
 Если страницы предоставляют свою собственную поддержку перемещения по журналу и пользовательский интерфейс для этого, можно скрыть кнопки **обратно** и **вперед**, отображаемые в <xref:System.Windows.Navigation.NavigationWindow>, задав значение свойства <xref:System.Windows.Navigation.NavigationWindow.ShowsNavigationUI%2A> равным `false`.
  
 Кроме того, можно использовать поддержку нестандартного UI в WPF для замены самого UI <xref:System.Windows.Navigation.NavigationWindow>.
  
<a name="Frame_in_Standalone_Applications"></a>   
## <a name="the-frame-class"></a>Класс Frame
 Как обозреватель, так и <xref:System.Windows.Navigation.NavigationWindow> представляют собой окна с содержимым для навигации. В некоторых случаях приложения имеют содержимое, которое не обязательно должно размещаться в целом окне. Такое содержимое помещается внутрь другого содержимого. Можно вставить содержимое с возможностью переходов в другое содержимое с помощью класса <xref:System.Windows.Controls.Frame>. <xref:System.Windows.Controls.Frame> предоставляет такую же поддержку, как и <xref:System.Windows.Navigation.NavigationWindow> и XBAP.
  
 В следующем примере показано, как добавить <xref:System.Windows.Controls.Frame> для <xref:System.Windows.Controls.Page> декларативно с помощью элемента `Frame`.  
  
 [!code-xaml[NavigationOverviewSnippets#FrameHostPageXAML1](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/FrameHostPage.xaml#framehostpagexaml1)]  
[!code-xaml[NavigationOverviewSnippets#FrameHostPageXAML2](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/FrameHostPage.xaml#framehostpagexaml2)]  
[!code-xaml[NavigationOverviewSnippets#FrameHostPageXAML3](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/FrameHostPage.xaml#framehostpagexaml3)]  
  
 Эта разметка присваивает атрибуту `Source` элемента `Frame` значение pack URI для <xref:System.Windows.Controls.Page>, на котороую <xref:System.Windows.Controls.Frame> должен первоначально перейти. На следующем рисунке показано XBAP с <xref:System.Windows.Controls.Page> во <xref:System.Windows.Controls.Frame>, осуществляющее переходы между несколькими страницами.
  
 ![Фрейм, осуществивший несколько страниц](./media/navigation-overview/frame-navigation-between-multiple-pages.png "отобразится навигации по кадрам между несколькими страницами.")  
  
 Не обязательно использовать <xref:System.Windows.Controls.Frame> внутри содержимого <xref:System.Windows.Controls.Page>. Также <xref:System.Windows.Controls.Frame> часто размещается внутри содержимого <xref:System.Windows.Window>.
  
 По умолчанию <xref:System.Windows.Controls.Frame> использует собственный журнал только при отсутствии другого журнала. Если <xref:System.Windows.Controls.Frame> является частью содержимого, которое размещено внутри <xref:System.Windows.Navigation.NavigationWindow> или XBAP, <xref:System.Windows.Controls.Frame> использует журнал, который принадлежит <xref:System.Windows.Navigation.NavigationWindow> или XBAP. Иногда, однако, <xref:System.Windows.Controls.Frame> может потребоваться собственный журнал. Одной из причин для этого является необходимость в журнале переходов среди страниц, расположенных во <xref:System.Windows.Controls.Frame>. Это показано на следующем рисунке.
  
 ![Схема фрейма и страницы](./media/navigation-overview/journal-navigation-within-pages-hosted-by-a-frame.png "журнал навигации в пределах страниц, размещенных во фрейме")  
  
 В этом случае можно настроить <xref:System.Windows.Controls.Frame> на использование собственного журнала установкой свойства <xref:System.Windows.Controls.Frame.JournalOwnership%2A> для <xref:System.Windows.Controls.Frame> в значение <xref:System.Windows.Navigation.JournalOwnership.OwnsJournal>. Это показано в следующем примере разметки.  
  
 [!code-xaml[NavigationOverviewSnippets#FrameHostPageOwnJournalXAML1](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/FrameHostPageOwnJournal.xaml#framehostpageownjournalxaml1)]  
[!code-xaml[NavigationOverviewSnippets#FrameHostPageOwnJournalXAML2](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/FrameHostPageOwnJournal.xaml#framehostpageownjournalxaml2)]  
[!code-xaml[NavigationOverviewSnippets#FrameHostPageOwnJournalXAML3](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/FrameHostPageOwnJournal.xaml#framehostpageownjournalxaml3)]  
  
 На следующем рисунке показан <xref:System.Windows.Controls.Frame>, использующий собственный журнал.  
  
 ![Frame, который использует собственный журнал](./media/navigation-overview/frame-uses-its-own-journal.png "показано влияние перехода в пределах Frame, который использует собственный журнал.")  
  
 Обратите внимание, что записи журнала отображаются в области навигации UI в <xref:System.Windows.Controls.Frame>, а не в Internet Explorer.
  
> [!NOTE]
>  Если <xref:System.Windows.Controls.Frame> является частью содержимого, размещенного в <xref:System.Windows.Window>, <xref:System.Windows.Controls.Frame> использует собственный журнал и, следовательно, отображает собственный UI навигации.

 Если вам требуется <xref:System.Windows.Controls.Frame> с собственным журналом без отображения панели навигации UI, можно скрыть навигацию UI, присвоив <xref:System.Windows.Controls.Frame.NavigationUIVisibility%2A> значение <xref:System.Windows.Visibility.Hidden>. Это показано в следующем примере разметки.
  
 [!code-xaml[NavigationOverviewSnippets#FrameHostPageHidesUIXAML1](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/FrameHostPageOwnHiddenJournal.xaml#framehostpagehidesuixaml1)]  
[!code-xaml[NavigationOverviewSnippets#FrameHostPageHidesUIXAML2](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/FrameHostPageOwnHiddenJournal.xaml#framehostpagehidesuixaml2)]  
[!code-xaml[NavigationOverviewSnippets#FrameHostPageHidesUIXAML3](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/FrameHostPageOwnHiddenJournal.xaml#framehostpagehidesuixaml3)]  

<a name="Navigation_Hosts"></a>
## <a name="navigation-hosts"></a>Узлы переходов  
 <xref:System.Windows.Controls.Frame> и <xref:System.Windows.Navigation.NavigationWindow> являются классами, которые известны как узлы переходов. Объект *узла навигации* является классом, который может перейти к содержимому и отобразить. В этой ситуации каждом узле переходов используются собственная <xref:System.Windows.Navigation.NavigationService> и журнала. На следующем рисунке показана основная структура узла переходов.  
  
 ![Схемы перехода](./media/navigation-overview/navigation-host-construction.png "основная структура узла переходов")  
  
 По сути, это позволяет <xref:System.Windows.Navigation.NavigationWindow> и <xref:System.Windows.Controls.Frame> обеспечить такую же поддержку переходов, XBAP предоставляет при размещении в браузере.  
  
 Помимо использования <xref:System.Windows.Navigation.NavigationService> и журнала, узлы переходов реализуют те же члены, <xref:System.Windows.Navigation.NavigationService> реализует. Это показано на следующем рисунке.  
  
 ![Журнал во фрейме и в NavigationWindow](./media/navigation-overview/navigation-window-and-frame.png "окно навигации и кадра")  
  
 Это позволяет программировать поддержку переходов непосредственно с ними. Это можно использовать, если необходимо предоставить навигации UI для <xref:System.Windows.Controls.Frame> , размещенного в <xref:System.Windows.Window>. Кроме того, оба типа реализуют дополнительные, связанных с навигацией члены, включая `BackStack` (<xref:System.Windows.Navigation.NavigationWindow.BackStack%2A?displayProperty=nameWithType>, <xref:System.Windows.Controls.Frame.BackStack%2A?displayProperty=nameWithType>) и `ForwardStack` (<xref:System.Windows.Navigation.NavigationWindow.ForwardStack%2A?displayProperty=nameWithType>, <xref:System.Windows.Controls.Frame.ForwardStack%2A?displayProperty=nameWithType>), которые позволяют перебирать записи журнала в серверной части стек и переслать стека, соответственно.  
  
 Как упоминалось ранее, в приложении может существовать несколько журналов. На следующем рисунке показано пример, когда это возможно.  
  
 ![Несколько журналов в одном приложении](./media/navigation-overview/multiple-journals-in-one-application.png "это пример более одного журнала в приложении.")  
  
<a name="Navigating_to_Content_Other_than_Pages"></a>   
## <a name="navigating-to-content-other-than-xaml-pages"></a>Переход к содержимому, отличному от страниц XAML  
 В этом разделе <xref:System.Windows.Controls.Page> и пакет XBAP использовался для демонстрируют различные возможности переходов WPF. Тем не менее <xref:System.Windows.Controls.Page> то есть скомпилированный в приложение не является единственным типом содержимого, к которому можно осуществить переход и пакет XBAP — не единственный способ определения содержимого.  
  
 Как показано в этом разделе, можно также осуществлять переходы к свободным XAML файлы, HTML файлы и объекты.  
  
<a name="Navigating_to_Loose_XAML_Files"></a>   
### <a name="navigating-to-loose-xaml-files"></a>Переход к свободным файлам XAML  
 Свободный XAML файл является файлом со следующими характеристиками:  
  
-   Содержит только XAML (то есть без кода).  
  
-   имеет объявление соответствующего пространства имен;  
  
-   имя файла имеет расширение XAML.  
  
 Например, рассмотрим следующее содержимое, сохраненное как свободный XAML файле Person.xaml.  
  
 [!code-xaml[NavigationOverviewSnippets#LooseXAML](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/Person.xaml#loosexaml)]  
  
 Если дважды щелкнуть файл, браузер откроется, выполнит переход к содержимому и отобразит его. Это показано на следующем рисунке.  
  
 ![Отображение содержимого в файле Person.XAML](./media/navigation-overview/contents-of-person-xaml-file.png "показано содержимое файла Person.XAML.")  
  
 Можно отобразить свободный XAML файл из следующего:  
  
-   веб-узел на локальном компьютере, в интрасети или Интернете;  
  
-   Объект [!INCLUDE[TLA#tla_unc](../../../../includes/tlasharptla-unc-md.md)] общую папку.  
  
-   локальный диск.  
  
 Свободный XAML файл можно добавить в Избранное браузера или сделать домашней страницей браузера.  
  
> [!NOTE]
>  Дополнительные сведения о публикации и запуске свободных XAML страниц, см. в разделе [развертывание приложений WPF](deploying-a-wpf-application-wpf.md).  
  
 Единственным ограничением в отношении свободных XAML является возможность размещения только содержимое, которое безопасно для запуска в режиме частичного доверия. Например `Window` не может быть корневым элементом свободного XAML файл. Дополнительные сведения см. в разделе [Безопасность частичного доверия в WPF](../wpf-partial-trust-security.md).  
  
<a name="Navigating_to_HTML_Files_Using_Frame"></a>   
### <a name="navigating-to-html-files-by-using-frame"></a>Переход к файлам HTML элемента управления Frame  
 Как можно догадаться, можно также перейти к HTML. Необходимо просто предоставить URI , используется схема http. Например, следующая XAML показывает <xref:System.Windows.Controls.Frame> , осуществляющий переход к HTML страницы.  
  
 [!code-xaml[NavigationOverviewSnippets#FrameHtmlNavMARKUP](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/FrameHTMLNavPage.xaml#framehtmlnavmarkup)]  
  
 Переход к HTML требуются специальные разрешения. Например, нельзя перейти из XBAP , запущенного в песочнице безопасности частичного доверия для зоны Интернета. Дополнительные сведения см. в разделе [Безопасность частичного доверия в WPF](../wpf-partial-trust-security.md).  
  
<a name="Navigating_to_HTML_Files_Using_WebBrowser"></a>   
### <a name="navigating-to-html-files-by-using-the-webbrowser-control"></a>Переход к файлам HTML с помощью элемента управления WebBrowser  
 <xref:System.Windows.Controls.WebBrowser> Управления поддерживает HTML размещение документов, навигации и скриптов и управляемого кода взаимодействия. Подробные сведения о <xref:System.Windows.Controls.WebBrowser> управления, см. в разделе <xref:System.Windows.Controls.WebBrowser>.  
  
 Как и <xref:System.Windows.Controls.Frame>, переходе по адресу HTML с помощью <xref:System.Windows.Controls.WebBrowser> требуются специальные разрешения. Например, из приложений с частичным доверием можно перейти только к HTML расположенный на исходном узле. Дополнительные сведения см. в разделе [Безопасность частичного доверия в WPF](../wpf-partial-trust-security.md).  
  
<a name="Navigating_to_Objects"></a>   
### <a name="navigating-to-custom-objects"></a>Переход к пользовательским объектам  
 Если у вас есть данные, которые хранятся в виде пользовательских объектов, один из способов отображения этих данных является создание <xref:System.Windows.Controls.Page> с содержимым, привязанным к таким объектам (см. в разделе [Общие сведения о привязке данных](../data/data-binding-overview.md)). Если не требуется создание всей страницы только для отображения объектов, то можно перейти непосредственно к ним.  
  
 Рассмотрите возможность `Person` класс, который реализуется в следующем коде.  
  
 [!code-csharp[NavigateToObjectSnippets#PersonClassCODE](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigateToObjectSnippets/CSharp/Person.cs#personclasscode)]
   
  
 Для перехода к нему вызовите <xref:System.Windows.Navigation.NavigationWindow.Navigate%2A?displayProperty=nameWithType> метод, как показано в следующем примере кода.  
  
 [!code-xaml[NavigateToObjectSnippets#PageThatNavsToObject1](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigateToObjectSnippets/CSharp/HomePage.xaml#pagethatnavstoobject1)]  
[!code-xaml[NavigateToObjectSnippets#PageThatNavsToObject2](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigateToObjectSnippets/CSharp/HomePage.xaml#pagethatnavstoobject2)]  
[!code-xaml[NavigateToObjectSnippets#PageThatNavsToObject3](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigateToObjectSnippets/CSharp/HomePage.xaml#pagethatnavstoobject3)]  
  
 [!code-csharp[NavigateToObjectSnippets#PageThatNavsToObjectCODEBEHIND](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigateToObjectSnippets/CSharp/HomePage.xaml.cs#pagethatnavstoobjectcodebehind)]
   
  
 На рисунке ниже показан результат.  
  
 ![Страница, осуществляющая переход в класс](./media/navigation-overview/page-navigates-to-an-object.png "ниже приведен пример страницы, который осуществляет переход к объекту.")  
  
 Из этого рисунка можно видеть, что ничего полезного не отобразилось. На самом деле, возвращаемое значение — это значение, которое отображается `ToString` метод **Person** объекта; по умолчанию это единственное значение, которое WPF можно использовать для представления объекта. Можно переопределить `ToString` метод для возврата более значимой информации, несмотря на то, что он будет по-прежнему быть только строковым значением. Один из методов, воспользуйтесь преимуществами возможностей представления WPF является использование шаблона данных. Можно реализовать шаблон данных, WPF можно связать с объектом определенного типа. В следующем коде показано шаблон данных для `Person` объекта.  
  
 [!code-xaml[NavigateToObjectSnippets#DataTemplateMARKUP](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigateToObjectSnippets/CSharp/App.xaml#datatemplatemarkup)]  
  
 Здесь шаблон данных связан с `Person` типа с помощью `x:Type` расширение разметки в `DataType` атрибута. Затем шаблон данных привязывает `TextBlock` элементов (см. в разделе <xref:System.Windows.Controls.TextBlock>) к свойствам `Person` класса. На следующем рисунке показан обновленный внешний вид `Person` объекта.  
  
 ![Переход к классу с шаблоном данных](./media/navigation-overview/navigating-to-a-class.png "переход к классу, который содержит шаблон данных.")  
  
 Преимуществом этого способа является связность, которая обеспечивается возможностью повторного использования шаблона данных для согласованного отображения объектов в любом месте приложения.  
  
 Дополнительные сведения о шаблонах данных см. в разделе [Общие сведения о шаблонах данных](../data/data-templating-overview.md).  
  
<a name="Security"></a>   
## <a name="security"></a>Безопасность  
 WPF Поддержка навигации позволяет XBAP осуществлять переходы через Интернет, а также позволяет приложениям сторонних размещения содержимого. Для защиты приложений и пользователей от опасных WPF предоставляет широкий набор функций безопасности, которые рассматриваются в [безопасности](../security-wpf.md) и [Безопасность частичного доверия WPF](../wpf-partial-trust-security.md).  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Application.SetCookie%2A>
- <xref:System.Windows.Application.GetCookie%2A>
- [Общие сведения об управлении приложением](application-management-overview.md)
- [URI типа "pack" в WPF](pack-uris-in-wpf.md)
- [Общие сведения о структурной навигации](structured-navigation-overview.md)
- [Общие сведения о топологии переходов](navigation-topologies-overview.md)
- [Практические руководства](navigation-how-to-topics.md)
- [Развертывание приложения WPF](deploying-a-wpf-application-wpf.md)
