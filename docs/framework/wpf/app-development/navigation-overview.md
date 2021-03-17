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
ms.assetid: 86ad2143-606a-4e34-bf7e-51a2594248b8
ms.openlocfilehash: 826cfc0ea7f681e1f7cbe858008c24a4941f0e11
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59335086"
---
# <a name="navigation-overview"></a>Общие сведения о переходах
Windows Presentation Foundation (WPF) поддерживает навигацию в стиле браузера, можно использовать в приложениях двух типов: автономных приложениях и [!INCLUDE[TLA#tla_xbap#plural](../../../../includes/tlasharptla-xbapsharpplural-md.md)]. Чтобы упаковать содержимое для навигации [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)] предоставляет <xref:System.Windows.Controls.Page> класса. Можно переходить от одного <xref:System.Windows.Controls.Page> в другой декларативно, с помощью <xref:System.Windows.Documents.Hyperlink>, или программно, с помощью <xref:System.Windows.Navigation.NavigationService>. [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)] использует журнал, чтобы запоминать страницы, на которые был осуществлен переход и для перехода к ним.  
  
 <xref:System.Windows.Controls.Page>, <xref:System.Windows.Documents.Hyperlink>, <xref:System.Windows.Navigation.NavigationService>, и журнал образуют основу для поддержки навигации, предлагаемой [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)]. В этом обзоре рассматриваются эти возможности подробно перед описанием расширенной поддержки переходов, включающий переход к свободным [!INCLUDE[TLA#tla_xaml](../../../../includes/tlasharptla-xaml-md.md)] файлы, [!INCLUDE[TLA#tla_html](../../../../includes/tlasharptla-html-md.md)] файлы и объекты.  
  
> [!NOTE]
>  В этом разделе термин «браузер» относится только к браузерам, которые можно разместить [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)] приложений, которые в настоящее время включает в себя [!INCLUDE[TLA#tla_ie](../../../../includes/tlasharptla-ie-md.md)] и Firefox. Когда специфические [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)] функции, поддерживаемые только одним определенным браузером, версия браузера.  

## <a name="navigation-in-wpf-applications"></a>Переходы в приложениях WPF  
 В этом разделе содержится обзор основных возможностей перехода в [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)]. Эти возможности доступны для автономных приложениях и [!INCLUDE[TLA2#tla_xbap#plural](../../../../includes/tla2sharptla-xbapsharpplural-md.md)], несмотря на то, что в этом разделе они представлены в контексте [!INCLUDE[TLA2#tla_xbap](../../../../includes/tla2sharptla-xbap-md.md)].  
  
> [!NOTE]
>  В этом разделе не обсуждаются построение и развертывание [!INCLUDE[TLA2#tla_xbap#plural](../../../../includes/tla2sharptla-xbapsharpplural-md.md)]. Дополнительные сведения о [!INCLUDE[TLA2#tla_xbap#plural](../../../../includes/tla2sharptla-xbapsharpplural-md.md)], см. в разделе [Обзор приложений браузера XAML WPF](wpf-xaml-browser-applications-overview.md).  
  
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
 В [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)], вы можете перейти к нескольким типам содержимого, включают объекты .NET Framework, пользовательских объектов, значений перечисления, пользовательские элементы управления, [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] файлы, и [!INCLUDE[TLA#tla_html](../../../../includes/tlasharptla-html-md.md)] файлы. Тем не менее, обнаружится, что наиболее распространенным и удобным способом упаковки содержимого является с помощью <xref:System.Windows.Controls.Page>. Кроме того <xref:System.Windows.Controls.Page> реализует особые возможности перехода в целях улучшения их внешнего вида и упрощения разработки.  
  
 С помощью <xref:System.Windows.Controls.Page>, можно декларативно реализовать доступную для перехода страницу [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] содержимого с помощью разметки, как показано ниже.  
  
 [!code-xaml[NavigationOverviewSnippets#Page1XAML](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/Page1.xaml#page1xaml)]  
  
 Объект <xref:System.Windows.Controls.Page> , реализованный в [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] имеет разметки `Page` качестве корневого элемента и требует [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)][!INCLUDE[TLA#tla_xml](../../../../includes/tlasharptla-xml-md.md)] объявление пространства имен. `Page` Элемент содержит содержимое, которое вы хотите перейти и отобразить. Добавления содержимого задается `Page.Content` элемента свойства, как показано в следующем примере разметки.  
  
 [!code-xaml[NavigationOverviewSnippets#Page2XAML](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/Page2.xaml#page2xaml)]  
  
 `Page.Content` может содержать только один дочерний элемент; в предыдущем примере, содержимым является отдельная строка «Hello, Page!» На практике обычно используется элемент управления макета как дочерний элемент (см. в разделе [макета](../advanced/layout.md)) для создания и хранения вашего содержимого.  
  
 Дочерние элементы `Page` считаются содержимым класса <xref:System.Windows.Controls.Page> и, следовательно, не нужно использовать явное `Page.Content` объявления. Следующая разметка является декларативным эквивалентом предыдущего примера.  
  
 [!code-xaml[NavigationOverviewSnippets#Page3XAML](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/Page3.xaml#page3xaml)]  
  
 В этом случае `Page.Content` автоматически задается вместе с дочерними элементами элемента `Page` элемент. Дополнительные сведения см. в разделе [Модель содержимого WPF](../controls/wpf-content-model.md).  
  
 Только для разметки <xref:System.Windows.Controls.Page> полезно для отображения содержимого. Тем не менее <xref:System.Windows.Controls.Page> также может отображать элементы управления, позволяющие пользователям взаимодействовать со страницей, и он может отвечать на действия пользователя, выполняя обработку событий и вызывая логику приложения. Интерактивная <xref:System.Windows.Controls.Page> реализуется с помощью комбинации разметки и кода программной части, как показано в следующем примере.  
  
 [!code-xaml[XBAPAppDefSnippets#HomePageMARKUP](~/samples/snippets/csharp/VS_Snippets_Wpf/XBAPAppDefSnippets/CSharp/HomePage.xaml#homepagemarkup)]  
  
 [!code-csharp[XBAPAppDefSnippets#HomePageCODEBEHIND](~/samples/snippets/csharp/VS_Snippets_Wpf/XBAPAppDefSnippets/CSharp/HomePage.xaml.cs#homepagecodebehind)]
 [!code-vb[XBAPAppDefSnippets#HomePageCODEBEHIND](~/samples/snippets/visualbasic/VS_Snippets_Wpf/XBAPAppDefSnippets/VisualBasic/HomePage.xaml.vb#homepagecodebehind)]  
  
 Чтобы разрешить совместную работу файла разметки и файла кода программной части, требуется следующая конфигурация.  
  
-   В разметке `Page` элемент должен включать `x:Class` атрибута. При построении приложения существование `x:Class` в разметке вызывает файл [!INCLUDE[TLA#tla_msbuild](../../../../includes/tlasharptla-msbuild-md.md)] для создания `partial` класс, производный от <xref:System.Windows.Controls.Page> и имеет имя, которое задается параметром `x:Class` атрибута. Это требует добавления параметра [!INCLUDE[TLA2#tla_xml](../../../../includes/tla2sharptla-xml-md.md)] объявление пространства имен для [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] схемы ( `xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"` ). Созданный `partial` класс реализует `InitializeComponent`, который вызывается для регистрации событий и задания свойств, реализованных в разметке.  
  
-   В коде программной части класс должен быть `partial` класс с тем же именем, который задается параметром `x:Class` атрибут в разметке и он должен быть производным от <xref:System.Windows.Controls.Page>. Это позволяет файл кода должно быть связано с `partial` класса, созданного для файла разметки при построении приложения (см. в разделе [построение приложения WPF](building-a-wpf-application-wpf.md)).  
  
-   В коде программной части <xref:System.Windows.Controls.Page> класс должен реализовывать конструктор, который вызывает `InitializeComponent` метод. `InitializeComponent` реализуется разметки созданным файлом `partial` класс для регистрации событий и задания свойств, которые определены в разметке.  
  
> [!NOTE]
>  При добавлении нового <xref:System.Windows.Controls.Page> в проект, использующий [!INCLUDE[TLA#tla_visualstu](../../../../includes/tlasharptla-visualstu-md.md)], <xref:System.Windows.Controls.Page> реализуется с помощью разметки и кода программной части и включает необходимую конфигурацию для создания связи между файлами разметки и кода как описанные здесь.  
  
 При наличии <xref:System.Windows.Controls.Page>, можно перейти к нему. Чтобы указать первый <xref:System.Windows.Controls.Page> переходит приложение, необходимо настроить начальную <xref:System.Windows.Controls.Page>.  
  
<a name="Configuring_a_Start_Page"></a>   
### <a name="configuring-a-start-page"></a>Настройка начальной страницы  
 [!INCLUDE[TLA2#tla_xbap#plural](../../../../includes/tla2sharptla-xbapsharpplural-md.md)] требуется определенная инфраструктура приложений, размещенных в браузере. В [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)], <xref:System.Windows.Application> класс является частью определения приложения, которое устанавливает необходимую инфраструктуру приложений (см. в разделе [Общие сведения об управлении приложением](application-management-overview.md)).  
  
 Определение приложения обычно реализуется с помощью разметки и кода программной части с файл разметки настраивается как [!INCLUDE[TLA2#tla_msbuild](../../../../includes/tla2sharptla-msbuild-md.md)]`ApplicationDefinition` элемента. Ниже приведен определение приложения для [!INCLUDE[TLA2#tla_xbap](../../../../includes/tla2sharptla-xbap-md.md)].  
  
 [!code-xaml[XBAPAppDefSnippets#XBAPApplicationDefinitionMARKUP](~/samples/snippets/csharp/VS_Snippets_Wpf/XBAPAppDefSnippets/CSharp/App.xaml#xbapapplicationdefinitionmarkup)]  
  
 [!code-csharp[XBAPAppDefSnippets#XBAPApplicationDefinitionCODEBEHIND](~/samples/snippets/csharp/VS_Snippets_Wpf/XBAPAppDefSnippets/CSharp/App.xaml.cs#xbapapplicationdefinitioncodebehind)]
 [!code-vb[XBAPAppDefSnippets#XBAPApplicationDefinitionCODEBEHIND](~/samples/snippets/visualbasic/VS_Snippets_Wpf/XBAPAppDefSnippets/VisualBasic/Application.xaml.vb#xbapapplicationdefinitioncodebehind)]  
  
 [!INCLUDE[TLA2#tla_xbap](../../../../includes/tla2sharptla-xbap-md.md)] Можно использовать определение приложения, чтобы указать начальный <xref:System.Windows.Controls.Page>, который является <xref:System.Windows.Controls.Page> , автоматически загружаемый при [!INCLUDE[TLA2#tla_xbap](../../../../includes/tla2sharptla-xbap-md.md)] запускается. Это можно сделать, задав <xref:System.Windows.Application.StartupUri%2A> свойство с [!INCLUDE[TLA#tla_uri](../../../../includes/tlasharptla-uri-md.md)] для нужной <xref:System.Windows.Controls.Page>.  
  
> [!NOTE]
>  В большинстве случаев <xref:System.Windows.Controls.Page> скомпилированный или развертываются вместе с приложением. В этих случаях [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)] , идентифицирующий <xref:System.Windows.Controls.Page> — это пакет [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)], который является [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)] соответствует *пакет* схемы. Пакет [!INCLUDE[TLA2#tla_uri#plural](../../../../includes/tla2sharptla-urisharpplural-md.md)] рассматриваются далее в [URI типа Pack в WPF](pack-uris-in-wpf.md). Для перехода к содержимому можно также использовать схему HTTP, которая рассматривается далее.  
  
 Можно задать <xref:System.Windows.Application.StartupUri%2A> декларативно в разметке, как показано в следующем примере.  
  
 [!code-xaml[NavigationOverviewSnippets#XBAPApplicationDefinitionMARKUP](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/App.xaml#xbapapplicationdefinitionmarkup)]  
  
 В этом примере `StartupUri` относительный пакет установлен атрибут [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)] , определяющим HomePage.xaml. Когда [!INCLUDE[TLA2#tla_xbap](../../../../includes/tla2sharptla-xbap-md.md)] является запуске HomePage.xaml автоматически переход и отображаются. Это показано на следующем рисунке, показывающий [!INCLUDE[TLA2#tla_xbap](../../../../includes/tla2sharptla-xbap-md.md)] , запущенное с веб-сервера.  
  
 ![XBAP-страница](./media/navigation-overview/xbap-launched-from-a-web-server.png "это показывает, приложение XBAP, запускаемых из веб-сервера.")  
  
> [!NOTE]
>  Дополнительные сведения о разработке и развертывании [!INCLUDE[TLA2#tla_xbap#plural](../../../../includes/tla2sharptla-xbapsharpplural-md.md)], см. в разделе [Обзор приложений браузера XAML WPF](wpf-xaml-browser-applications-overview.md) и [развертывание приложений WPF](deploying-a-wpf-application-wpf.md).  
  
<a name="ConfiguringAXAMLPage"></a>   
### <a name="configuring-the-host-windows-title-width-and-height"></a>Настройка заголовка, ширины и высоты основного окна  
 Одно дело, вы могли заметить в предыдущем примере — что заголовком как браузера, так и панели вкладок является [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)] для [!INCLUDE[TLA2#tla_xbap](../../../../includes/tla2sharptla-xbap-md.md)]. Заголовок не только длинный, но также не является ни привлекательным, ни информативным. По этой причине <xref:System.Windows.Controls.Page> предлагает способ для изменения заголовка, задав <xref:System.Windows.Controls.Page.WindowTitle%2A> свойство. Кроме того, можно настроить ширину и высоту окна браузера, задав <xref:System.Windows.Controls.Page.WindowWidth%2A> и <xref:System.Windows.Controls.Page.WindowHeight%2A>, соответственно.  
  
 <xref:System.Windows.Controls.Page.WindowTitle%2A>, <xref:System.Windows.Controls.Page.WindowWidth%2A>, и <xref:System.Windows.Controls.Page.WindowHeight%2A> можно задать декларативно в разметке, как показано в следующем примере.  
  
 [!code-xaml[NavigationOverviewSnippets#HomePageMARKUP](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/HomePage.xaml#homepagemarkup)]  
  
 Результат показан на примере ниже.  
  
 ![Заголовок окна, высота, ширина](./media/navigation-overview/window-title-width-height.png "отображается заголовок окна, высота и ширина, можно настроить.")  
  
<a name="NavigatingBetweenXAMLPages"></a>   
### <a name="hyperlink-navigation"></a>Переход по гиперссылке  
 Типичный [!INCLUDE[TLA2#tla_xbap](../../../../includes/tla2sharptla-xbap-md.md)] состоит из нескольких страниц. Самый простой способ перехода от одной страницы к другой — для использования <xref:System.Windows.Documents.Hyperlink>. Можно декларативно добавить <xref:System.Windows.Documents.Hyperlink> для <xref:System.Windows.Controls.Page> с помощью `Hyperlink` элемент, который показан в следующем примере разметки.  
  
 [!code-xaml[NavigationOverviewSnippets#HyperlinkXAML1](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/PageWithHyperlink.xaml#hyperlinkxaml1)]  
[!code-xaml[NavigationOverviewSnippets#HyperlinkXAML2](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/PageWithHyperlink.xaml#hyperlinkxaml2)]  
[!code-xaml[NavigationOverviewSnippets#HyperlinkXAML3](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/PageWithHyperlink.xaml#hyperlinkxaml3)]  
  
 Объект `Hyperlink` элемент требует следующего:  
  
-   Пакет [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)] из <xref:System.Windows.Controls.Page> для перехода, определяемом параметрами `NavigateUri` атрибута.  
  
-   Содержимого, что пользователь может щелкнуть для инициации перехода, например текст и изображения (для содержимого, `Hyperlink` элемент может содержать, см. в разделе <xref:System.Windows.Documents.Hyperlink>).  
  
 На следующем рисунке показан [!INCLUDE[TLA2#tla_xbap](../../../../includes/tla2sharptla-xbap-md.md)] с <xref:System.Windows.Controls.Page> с <xref:System.Windows.Documents.Hyperlink>.  
  
 ![Страница с гиперссылкой](./media/navigation-overview/xbap-with-a-page-with-a-hyperlink.png "это показывает, приложение XBAP, страница с гиперссылкой.")  
  
 Как и следовало ожидать, щелкнув <xref:System.Windows.Documents.Hyperlink> вызывает [!INCLUDE[TLA2#tla_xbap](../../../../includes/tla2sharptla-xbap-md.md)] для перехода к <xref:System.Windows.Controls.Page> , определяемому `NavigateUri` атрибута. Кроме того [!INCLUDE[TLA2#tla_xbap](../../../../includes/tla2sharptla-xbap-md.md)] добавляет запись для предыдущего <xref:System.Windows.Controls.Page> в список последних страниц в [!INCLUDE[TLA2#tla_ie](../../../../includes/tla2sharptla-ie-md.md)]. Это показано на следующем рисунке.  
  
 !["И" Назад кнопки](./media/navigation-overview/back-and-forward-navigation.png "Навигация с помощью кнопок Назад и вперед.")  
  
 Помимо поддержки перехода от одного <xref:System.Windows.Controls.Page> в другую, <xref:System.Windows.Documents.Hyperlink> также поддерживает переход к фрагменту.  
  
<a name="FragmentNavigation"></a>   
### <a name="fragment-navigation"></a>Переход к фрагменту  
 *Переход к фрагменту* — это переход к фрагменту содержимого в любом текущего <xref:System.Windows.Controls.Page> или другой <xref:System.Windows.Controls.Page>. В [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)], фрагмент содержимого представляет собой данные, содержащиеся в именованном элементе. Именованный элемент — элемент, имеющий его `Name` набором атрибутов. В следующей разметке показан именованный `TextBlock` элемент, содержащий фрагмент содержимого.  
  
 [!code-xaml[NavigationOverviewSnippets#PageWithContentFragmentsMARKUP1](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/PageWithFragments.xaml#pagewithcontentfragmentsmarkup1)]  
[!code-xaml[NavigationOverviewSnippets#PageWithContentFragmentsMARKUP2](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/PageWithFragments.xaml#pagewithcontentfragmentsmarkup2)]  
[!code-xaml[NavigationOverviewSnippets#PageWithContentFragmentsMARKUP3](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/PageWithFragments.xaml#pagewithcontentfragmentsmarkup3)]  
  
 Для <xref:System.Windows.Documents.Hyperlink> для перехода к фрагменту содержимого `NavigateUri` атрибут должен содержать следующее:  
  
-   [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)] Из <xref:System.Windows.Controls.Page> с для перехода к фрагменту содержимого.  
  
-   Символ "#".  
  
-   Имя элемента на <xref:System.Windows.Controls.Page> , включающего фрагмент содержимого.  
  
 Фрагмент [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)] имеет следующий формат.  
  
 *URI_страницы* `#` *имя_элемента*.  
  
 Ниже приведен пример `Hyperlink` , настроенной на переход к фрагменту содержимого.  
  
 [!code-xaml[NavigationOverviewSnippets#PageThatNavigatesXAML1](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/PageThatNavigatesToFragment.xaml#pagethatnavigatesxaml1)]  
[!code-xaml[NavigationOverviewSnippets#PageThatNavigatesXAML2](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/PageThatNavigatesToFragment.xaml#pagethatnavigatesxaml2)]  
[!code-xaml[NavigationOverviewSnippets#PageThatNavigatesXAML3](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/PageThatNavigatesToFragment.xaml#pagethatnavigatesxaml3)]  
  
> [!NOTE]
>  В этом разделе описывается реализация переходов фрагмента по умолчанию в [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)]. [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)] Кроме того, позволяет реализовать собственную схему переходов фрагмента, которая отчасти требует обработки <xref:System.Windows.Navigation.NavigationService.FragmentNavigation?displayProperty=nameWithType> событий.  
  
> [!IMPORTANT]
>  Вы можете перейти к фрагментам на свободных [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] страниц (только для разметки [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] файлы с `Page` как корневой элемент) только в том случае, если страницы можно просмотреть с помощью [!INCLUDE[TLA2#tla_http](../../../../includes/tla2sharptla-http-md.md)].  
>   
>  Тем не менее свободный [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] страницу можно перейти к своим собственным фрагментам.  
  
<a name="NavigationService"></a>   
### <a name="navigation-service"></a>Служба переходов  
 Хотя <xref:System.Windows.Documents.Hyperlink> позволяет пользователю инициировать переход к конкретному <xref:System.Windows.Controls.Page>, работа по поиску и загрузке страницы выполняется с <xref:System.Windows.Navigation.NavigationService> класса. По сути <xref:System.Windows.Navigation.NavigationService> предоставляет возможность обработки запроса перехода со стороны клиентского кода, такие как <xref:System.Windows.Documents.Hyperlink>. Кроме того <xref:System.Windows.Navigation.NavigationService> реализует поддержку более высокого уровня для отслеживания и влияние на запроса перехода.  
  
 Когда <xref:System.Windows.Documents.Hyperlink> нажатии [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)] вызовы <xref:System.Windows.Navigation.NavigationService.Navigate%2A?displayProperty=nameWithType> для обнаружения и загрузки <xref:System.Windows.Controls.Page> в указанный пакет [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)]. Скачанный <xref:System.Windows.Controls.Page> преобразуется в дерево объектов, корневой объект которого является экземпляром Скачанный <xref:System.Windows.Controls.Page>. Ссылка на корневой <xref:System.Windows.Controls.Page> объект хранится в <xref:System.Windows.Navigation.NavigationService.Content%2A?displayProperty=nameWithType> свойство. Пакет [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)] для содержимого, к которому был осуществлен переход, сохраняется в <xref:System.Windows.Navigation.NavigationService.Source%2A?displayProperty=nameWithType> свойство, хотя <xref:System.Windows.Navigation.NavigationService.CurrentSource%2A?displayProperty=nameWithType> сохраняет пакет [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)] для последней страницы, к которому был осуществлен переход.  
  
> [!NOTE]
>  Существует возможность [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)] приложению требуется более одного активного <xref:System.Windows.Navigation.NavigationService>. Дополнительные сведения см. в разделе [узлы переходов](#Navigation_Hosts) далее в этом разделе.  
  
<a name="Programmatic_Navigation_with_the_Navigation_Service"></a>   
### <a name="programmatic-navigation-with-the-navigation-service"></a>Программный переход с помощью службы переходов  
 Не нужно знать о <xref:System.Windows.Navigation.NavigationService> Если переход реализован декларативно в разметке с помощью <xref:System.Windows.Documents.Hyperlink>, так как <xref:System.Windows.Documents.Hyperlink> использует <xref:System.Windows.Navigation.NavigationService> от вашего имени. Это означает, что пока прямой или непрямой родитель объекта <xref:System.Windows.Documents.Hyperlink> является узлом перехода (см. в разделе [узлы переходов](#Navigation_Hosts)), <xref:System.Windows.Documents.Hyperlink> будут иметь возможность находить и использовать службу переходов этого узла для обработки запрос навигации.  
  
 Тем не менее, существуют ситуации, когда необходимо использовать <xref:System.Windows.Navigation.NavigationService> напрямую, включая следующие:  
  
-   Если вам нужно создать экземпляр <xref:System.Windows.Controls.Page> с помощью конструктора не по умолчанию.  
  
-   Если вам нужно задать свойства <xref:System.Windows.Controls.Page> перед переходом к нему.  
  
-   Когда <xref:System.Windows.Controls.Page> что необходимо осуществлять переходы можно определить только во время выполнения.  
  
 В этих случаях необходимо написать код для программной инициации перехода посредством вызова <xref:System.Windows.Navigation.NavigationService.Navigate%2A> метод <xref:System.Windows.Navigation.NavigationService> объекта. Для этого требуется получить ссылку на <xref:System.Windows.Navigation.NavigationService>.  
  
#### <a name="getting-a-reference-to-the-navigationservice"></a>Получение ссылки на службу переходов  
 По причинам, охваченных [узлы переходов](#Navigation_Hosts) разделе [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)] приложение может иметь более одного <xref:System.Windows.Navigation.NavigationService>. Это означает, что в коде необходимо предусмотреть способ поиска <xref:System.Windows.Navigation.NavigationService>, который обычно является <xref:System.Windows.Navigation.NavigationService> , приводящую к текущему <xref:System.Windows.Controls.Page>. Можно получить ссылку на <xref:System.Windows.Navigation.NavigationService> путем вызова `static`<xref:System.Windows.Navigation.NavigationService.GetNavigationService%2A?displayProperty=nameWithType> метод. Чтобы получить <xref:System.Windows.Navigation.NavigationService> , переход к конкретному <xref:System.Windows.Controls.Page>, передать ссылку на <xref:System.Windows.Controls.Page> в качестве аргумента <xref:System.Windows.Navigation.NavigationService.GetNavigationService%2A> метод. Следующий код показывает способ получения <xref:System.Windows.Navigation.NavigationService> для текущего <xref:System.Windows.Controls.Page>.  
  
 [!code-csharp[NavigationOverviewSnippets#GetNSCODEBEHIND1](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/GetNSPage.xaml.cs#getnscodebehind1)]  
[!code-csharp[NavigationOverviewSnippets#GetNSCODEBEHIND2](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/GetNSPage.xaml.cs#getnscodebehind2)]
[!code-vb[NavigationOverviewSnippets#GetNSCODEBEHIND2](~/samples/snippets/visualbasic/VS_Snippets_Wpf/NavigationOverviewSnippets/VisualBasic/GetNSPage.xaml.vb#getnscodebehind2)]  
  
 Как быстро найти <xref:System.Windows.Navigation.NavigationService> для <xref:System.Windows.Controls.Page>, <xref:System.Windows.Controls.Page> реализует <xref:System.Windows.Controls.Page.NavigationService%2A> свойство. Эти действия показаны в следующем примере.  
  
 [!code-csharp[NavigationOverviewSnippets#GetNSShortcutCODEBEHIND1](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/GetNSPageShortCut.xaml.cs#getnsshortcutcodebehind1)]  
[!code-csharp[NavigationOverviewSnippets#GetNSShortcutCODEBEHIND2](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/GetNSPageShortCut.xaml.cs#getnsshortcutcodebehind2)]
[!code-vb[NavigationOverviewSnippets#GetNSShortcutCODEBEHIND2](~/samples/snippets/visualbasic/VS_Snippets_Wpf/NavigationOverviewSnippets/VisualBasic/GetNSPageShortCut.xaml.vb#getnsshortcutcodebehind2)]  
  
> [!NOTE]
>  Объект <xref:System.Windows.Controls.Page> может получить только ссылку на его <xref:System.Windows.Navigation.NavigationService> при <xref:System.Windows.Controls.Page> вызывает <xref:System.Windows.FrameworkElement.Loaded> событий.  
  
#### <a name="programmatic-navigation-to-a-page-object"></a>Программный переход к объекту страницы  
 В следующем примере показано, как использовать <xref:System.Windows.Navigation.NavigationService> осуществить программный переход к <xref:System.Windows.Controls.Page>. Программный переход является обязательным, поскольку <xref:System.Windows.Controls.Page> то есть, куда выполняется переход могут быть созданы только с помощью конструктора, единый, не по умолчанию. <xref:System.Windows.Controls.Page> С нестандартным конструктором показан в следующей разметке и коде.  
  
 [!code-xaml[NavigationOverviewSnippets#PageWithNonDefaultConstructorXAML](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/PageWithNonDefaultConstructor.xaml#pagewithnondefaultconstructorxaml)]  
  
 [!code-csharp[NavigationOverviewSnippets#PageWithNonDefaultConstructorCODEBEHIND](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/PageWithNonDefaultConstructor.xaml.cs#pagewithnondefaultconstructorcodebehind)]
 [!code-vb[NavigationOverviewSnippets#PageWithNonDefaultConstructorCODEBEHIND](~/samples/snippets/visualbasic/VS_Snippets_Wpf/NavigationOverviewSnippets/VisualBasic/PageWithNonDefaultConstructor.xaml.vb#pagewithnondefaultconstructorcodebehind)]  
  
 <xref:System.Windows.Controls.Page> , Осуществляющий переход к <xref:System.Windows.Controls.Page> с нестандартным конструктором показан в следующей разметке и коде.  
  
 [!code-xaml[NavigationOverviewSnippets#NSNavigationPageXAML](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/NSNavigationPage.xaml#nsnavigationpagexaml)]  
  
 [!code-csharp[NavigationOverviewSnippets#NSNavigationPageCODEBEHIND](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/NSNavigationPage.xaml.cs#nsnavigationpagecodebehind)]
 [!code-vb[NavigationOverviewSnippets#NSNavigationPageCODEBEHIND](~/samples/snippets/visualbasic/VS_Snippets_Wpf/NavigationOverviewSnippets/VisualBasic/NSNavigationPage.xaml.vb#nsnavigationpagecodebehind)]  
  
 При <xref:System.Windows.Documents.Hyperlink> об этом <xref:System.Windows.Controls.Page> является щелчке, запускается переход путем создания экземпляра <xref:System.Windows.Controls.Page> перейдите к с помощью конструктора не по умолчанию и вызвав <xref:System.Windows.Navigation.NavigationService.Navigate%2A?displayProperty=nameWithType> метод. <xref:System.Windows.Navigation.NavigationService.Navigate%2A> принимает ссылку на объект, <xref:System.Windows.Navigation.NavigationService> производится переход, типа pack [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)].  
  
#### <a name="programmatic-navigation-with-a-pack-uri"></a>Программный переход с URI типа pack  
 Если вам необходимо создать в пакете [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)] программным образом (если только определения пакета [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)] во время выполнения, например), можно использовать <xref:System.Windows.Navigation.NavigationService.Navigate%2A?displayProperty=nameWithType> метод. Эти действия показаны в следующем примере.  
  
 [!code-xaml[NavigationOverviewSnippets#NSUriNavigationPageXAML](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/NSUriNavigationPage.xaml#nsurinavigationpagexaml)]  
  
 [!code-csharp[NavigationOverviewSnippets#NSUriNavigationPageCODEBEHIND](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/NSUriNavigationPage.xaml.cs#nsurinavigationpagecodebehind)]
 [!code-vb[NavigationOverviewSnippets#NSUriNavigationPageCODEBEHIND](~/samples/snippets/visualbasic/VS_Snippets_Wpf/NavigationOverviewSnippets/VisualBasic/NSUriNavigationPage.xaml.vb#nsurinavigationpagecodebehind)]  
  
#### <a name="refreshing-the-current-page"></a>Обновление текущей страницы  
 Объект <xref:System.Windows.Controls.Page> не загружается, если он имеет тот же пакет [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)] пакета [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)] , хранящееся в <xref:System.Windows.Navigation.NavigationService.Source%2A?displayProperty=nameWithType> свойство. Чтобы принудительно [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)] попытку загрузить текущую страницу, можно последовательно вызвать методы <xref:System.Windows.Navigation.NavigationService.Refresh%2A?displayProperty=nameWithType> метод, как показано в следующем примере.  
  
 [!code-xaml[NavigationOverviewSnippets#NSRefreshNavigationPageXAML1](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/NSRefreshNavigationPage.xaml#nsrefreshnavigationpagexaml1)]  
  
 [!code-csharp[NavigationOverviewSnippets#NSRefreshNavigationPageCODEBEHIND1](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/NSRefreshNavigationPage.xaml.cs#nsrefreshnavigationpagecodebehind1)]
 [!code-vb[NavigationOverviewSnippets#NSRefreshNavigationPageCODEBEHIND1](~/samples/snippets/visualbasic/VS_Snippets_Wpf/NavigationOverviewSnippets/VisualBasic/NSRefreshNavigationPage.xaml.vb#nsrefreshnavigationpagecodebehind1)]  
[!code-csharp[NavigationOverviewSnippets#NSRefreshNavigationPageCODEBEHIND2](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/NSRefreshNavigationPage.xaml.cs#nsrefreshnavigationpagecodebehind2)]
[!code-vb[NavigationOverviewSnippets#NSRefreshNavigationPageCODEBEHIND2](~/samples/snippets/visualbasic/VS_Snippets_Wpf/NavigationOverviewSnippets/VisualBasic/NSRefreshNavigationPage.xaml.vb#nsrefreshnavigationpagecodebehind2)]  
  
<a name="Navigation_Lifetime"></a>   
### <a name="navigation-lifetime"></a>Время существования перехода  
 Как вы уже видели, существует множество способов инициации перехода. Когда переход инициирован и навигации во время выполнения, можно отслеживать и повлиять на него с помощью следующих событий, которые реализуются <xref:System.Windows.Navigation.NavigationService>:  
  
-   <xref:System.Windows.Navigation.NavigationService.Navigating>. Появляется, когда запрошен новый переход. Можно использовать для отмены перехода.  
  
-   <xref:System.Windows.Navigation.NavigationService.NavigationProgress>. Происходит периодически во время загрузки, тем самым предоставляя информацию о ходе процесса навигации.  
  
-   <xref:System.Windows.Navigation.NavigationService.Navigated>. Появляется, когда страница найдена и загружена.  
  
-   <xref:System.Windows.Navigation.NavigationService.NavigationStopped>. Происходит, когда переход остановлен (путем вызова <xref:System.Windows.Navigation.NavigationService.StopLoading%2A>), или при запросе нового перехода во время выполнения текущего перехода.  
  
-   <xref:System.Windows.Navigation.NavigationService.NavigationFailed>. Появляется при возникновении ошибки во время перехода к запрошенному содержимому.  
  
-   <xref:System.Windows.Navigation.NavigationService.LoadCompleted>. Появляется, когда содержимое, к которому был осуществлен переход, загружено и проанализировано и начинается его отрисовка.  
  
-   <xref:System.Windows.Navigation.NavigationService.FragmentNavigation>. Появляется в начале перехода к фрагменту содержимого, который происходит:  
  
    -   немедленно, если нужный фрагмент находится в текущем содержимом;  
  
    -   после загрузки исходного содержимого, если нужный фрагмент находится в другом содержимом.  
  
 События перехода вызываются в порядке, который показан на следующем рисунке.  
  
 ![Таблица потока навигации страницы](./media/navigation-overview/order-of-navigation-events.png "блок-схема событий навигации страницы")  
  
 В общем случае <xref:System.Windows.Controls.Page> не связан с этими событиями. Более вероятно, что приложение связано с ними, и по этой причине эти события также вызываются с помощью <xref:System.Windows.Application> класса:  
  
-   <xref:System.Windows.Application.Navigating?displayProperty=nameWithType>  
  
-   <xref:System.Windows.Application.NavigationProgress?displayProperty=nameWithType>  
  
-   <xref:System.Windows.Application.Navigated?displayProperty=nameWithType>  
  
-   <xref:System.Windows.Application.NavigationFailed?displayProperty=nameWithType>  
  
-   <xref:System.Windows.Application.NavigationStopped?displayProperty=nameWithType>  
  
-   <xref:System.Windows.Application.LoadCompleted?displayProperty=nameWithType>  
  
-   <xref:System.Windows.Application.FragmentNavigation?displayProperty=nameWithType>  
  
 Каждый раз <xref:System.Windows.Navigation.NavigationService> возникает событие <xref:System.Windows.Application> класс вызывает соответствующее событие. <xref:System.Windows.Controls.Frame> и <xref:System.Windows.Navigation.NavigationWindow> обеспечивают те же события, для обнаружения переходов в соответствующих областях.  
  
 В некоторых случаях <xref:System.Windows.Controls.Page> могут заинтересовать эти события. Например <xref:System.Windows.Controls.Page> может обрабатывать <xref:System.Windows.Navigation.NavigationService.Navigating?displayProperty=nameWithType> событие, чтобы определить необходимость отмены перехода. Эти действия показаны в следующем примере.  
  
 [!code-xaml[NavigationOverviewSnippets#CancelNavigationPageXAML](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/CancelNavigationPage.xaml#cancelnavigationpagexaml)]  
  
 [!code-csharp[NavigationOverviewSnippets#CancelNavigationPageCODEBEHIND](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/CancelNavigationPage.xaml.cs#cancelnavigationpagecodebehind)]
 [!code-vb[NavigationOverviewSnippets#CancelNavigationPageCODEBEHIND](~/samples/snippets/visualbasic/VS_Snippets_Wpf/NavigationOverviewSnippets/VisualBasic/CancelNavigationPage.xaml.vb#cancelnavigationpagecodebehind)]  
  
 Если регистрируется обработчик с событием перехода из <xref:System.Windows.Controls.Page>, как предыдущий пример, необходимо также отменить регистрацию обработчика событий. Если этого не сделать, могут возникнуть побочные эффекты, как [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)] запоминает переходы <xref:System.Windows.Controls.Page> с помощью журнала.  
  
<a name="NavigationHistory"></a>   
### <a name="remembering-navigation-with-the-journal"></a>Запоминание перехода в журнале  
 [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)] использует два стека для запоминания страниц, на которые был осуществлен переход: стек переходов назад и вперед. При переходе из текущего <xref:System.Windows.Controls.Page> в новый <xref:System.Windows.Controls.Page> или вперед к существующему <xref:System.Windows.Controls.Page>, текущий <xref:System.Windows.Controls.Page> добавляется *стек переходов назад*. При переходе из текущего <xref:System.Windows.Controls.Page> вернитесь к предыдущему <xref:System.Windows.Controls.Page>, текущий <xref:System.Windows.Controls.Page> добавляется *вперед*. Стек "Назад", стек "Вперед" и функциональные возможности для управления ими в совокупности называются журналом. Каждый элемент в стеке переходов назад и вперед — это экземпляр <xref:System.Windows.Navigation.JournalEntry> класса и называется *записи журнала*.  
  
#### <a name="navigating-the-journal-from-internet-explorer"></a>Перемещение по журналу в браузере Internet Explorer  
 По существу, журнала работает так же, как **обратно** и **вперед** кнопки в [!INCLUDE[TLA2#tla_ie](../../../../includes/tla2sharptla-ie-md.md)] сделать. Это показано на следующем рисунке.  
  
 !["И" Назад кнопки](./media/navigation-overview/back-and-forward-navigation.png "Навигация с помощью кнопок Назад и вперед.")  
  
 Для [!INCLUDE[TLA2#tla_xbap#plural](../../../../includes/tla2sharptla-xbapsharpplural-md.md)] , размещаемых в [!INCLUDE[TLA2#tla_ie](../../../../includes/tla2sharptla-ie-md.md)], [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)] осуществляет интеграцию журнала в области навигации [!INCLUDE[TLA2#tla_ui](../../../../includes/tla2sharptla-ui-md.md)] из [!INCLUDE[TLA2#tla_ie](../../../../includes/tla2sharptla-ie-md.md)]. Это позволяет пользователям перемещаться по страницам в [!INCLUDE[TLA2#tla_xbap](../../../../includes/tla2sharptla-xbap-md.md)] с помощью **обратно**, **вперед**, и **последние страницы** кнопки в [!INCLUDE[TLA2#tla_ie](../../../../includes/tla2sharptla-ie-md.md)]. Журнал не интегрирован в [!INCLUDE[TLA2#tla_ie6](../../../../includes/tla2sharptla-ie6-md.md)] таким же образом, что и для [!INCLUDE[TLA2#tla_ie7](../../../../includes/tla2sharptla-ie7-md.md)] или Internet Explorer 8. Вместо этого [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)] отображает навигации замените [!INCLUDE[TLA2#tla_ui](../../../../includes/tla2sharptla-ui-md.md)].  
  
> [!IMPORTANT]
>  В [!INCLUDE[TLA2#tla_ie](../../../../includes/tla2sharptla-ie-md.md)], при переходе со страницы и обратно [!INCLUDE[TLA2#tla_xbap](../../../../includes/tla2sharptla-xbap-md.md)], в журнале сохраняются только записи журнала для страниц, которые не поддерживались в активном состоянии. Обсуждение поддержки страниц в активном состоянии, см. в разделе [время существования страницы и журнал](#PageLifetime) далее в этом разделе.  
  
 По умолчанию текст для каждого <xref:System.Windows.Controls.Page> , отображаемый в **последние страницы** список [!INCLUDE[TLA2#tla_ie](../../../../includes/tla2sharptla-ie-md.md)] — [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)] для <xref:System.Windows.Controls.Page>. В большинстве случаев это не особенно важно для пользователя. К счастью можно изменить текст, используя следующие параметры.  
  
1. Вложенный `JournalEntry.Name` значение атрибута.  
  
2. `Page.Title` Значение атрибута.  
  
3. `Page.WindowTitle` Значение атрибута и [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)] для текущего <xref:System.Windows.Controls.Page>.  
  
4. Интерфейс [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)] для текущего объекта <xref:System.Windows.Controls.Page>. (Значение по умолчанию)  
  
 Порядок, в котором перечислены параметры, совпадает с порядком приоритета для поиска текста. Например если `JournalEntry.Name` не установлен, другие значения игнорируются.  
  
 В следующем примере используется `Page.Title` атрибут, чтобы изменить текст, отображаемый в записи журнала.  
  
 [!code-xaml[NavigationOverviewSnippets#PageTitleMARKUP1](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/PageWithTitle.xaml#pagetitlemarkup1)]  
[!code-xaml[NavigationOverviewSnippets#PageTitleMARKUP2](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/PageWithTitle.xaml#pagetitlemarkup2)]  
  
 [!code-csharp[NavigationOverviewSnippets#PageTitleCODEBEHIND1](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/PageWithTitle.xaml.cs#pagetitlecodebehind1)]
 [!code-vb[NavigationOverviewSnippets#PageTitleCODEBEHIND1](~/samples/snippets/visualbasic/VS_Snippets_Wpf/NavigationOverviewSnippets/VisualBasic/PageWithTitle.xaml.vb#pagetitlecodebehind1)]  
[!code-csharp[NavigationOverviewSnippets#PageTitleCODEBEHIND2](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/PageWithTitle.xaml.cs#pagetitlecodebehind2)]
[!code-vb[NavigationOverviewSnippets#PageTitleCODEBEHIND2](~/samples/snippets/visualbasic/VS_Snippets_Wpf/NavigationOverviewSnippets/VisualBasic/PageWithTitle.xaml.vb#pagetitlecodebehind2)]  
  
#### <a name="navigating-the-journal-using-wpf"></a>Перемещение по журналу с помощью WPF  
 Несмотря на то, что пользователь может перемещаться по журналу с помощью **обратно**, **вперед**, и **последние страницы** в [!INCLUDE[TLA2#tla_ie](../../../../includes/tla2sharptla-ie-md.md)], можно также перейти по журналу с помощью обоих декларативные и программные механизмы, предоставляемые [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)]. Одна из причин для этого — предоставление пользовательских переходов [!INCLUDE[TLA2#tla_ui#plural](../../../../includes/tla2sharptla-uisharpplural-md.md)] на страницах.  
  
 Можно декларативно добавить поддержку журнального перехода с помощью команд перехода, предоставляемых <xref:System.Windows.Input.NavigationCommands>. Следующий пример демонстрирует, как использовать `BrowseBack` команды перехода.  
  
 [!code-xaml[NavigationOverviewSnippets#NavigationCommandsPageXAML1](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/NavigationCommandsPage.xaml#navigationcommandspagexaml1)]  
[!code-xaml[NavigationOverviewSnippets#NavigationCommandsPageXAML2](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/NavigationCommandsPage.xaml#navigationcommandspagexaml2)]  
[!code-xaml[NavigationOverviewSnippets#NavigationCommandsPageXAML3](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/NavigationCommandsPage.xaml#navigationcommandspagexaml3)]  
[!code-xaml[NavigationOverviewSnippets#NavigationCommandsPageXAML4](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/NavigationCommandsPage.xaml#navigationcommandspagexaml4)]  
  
 Можно программно перемещаться по журналу с помощью одного из следующих членов <xref:System.Windows.Navigation.NavigationService> класса:  
  
-   <xref:System.Windows.Navigation.NavigationService.GoBack%2A>  
  
-   <xref:System.Windows.Navigation.NavigationService.GoForward%2A>  
  
-   <xref:System.Windows.Navigation.NavigationService.CanGoBack%2A>  
  
-   <xref:System.Windows.Navigation.NavigationService.CanGoForward%2A>  
  
 Журнал можно также управлять программным образом, как описано в [сохранение состояния содержимого с помощью журнала переходов](#RetainingContentStateWithNavigationHistory) далее в этом разделе.  
  
<a name="PageLifetime"></a>   
### <a name="page-lifetime-and-the-journal"></a>Время существования страницы и журнал  
 Рассмотрите возможность [!INCLUDE[TLA2#tla_xbap](../../../../includes/tla2sharptla-xbap-md.md)] с несколькими страницами, которые содержат форматированное содержимое, включая графики, анимации и мультимедиа. Объем памяти для подобных страниц может быть довольно большим, особенно если используются видеоматериалы и звуковые файлы. Учитывая, что в журнале «запоминаются», которые были посещенные страницы [!INCLUDE[TLA2#tla_xbap](../../../../includes/tla2sharptla-xbap-md.md)] может быстро расходовать значительный объем памяти.  
  
 По этой причине, по умолчанию журнала выполняется для хранения <xref:System.Windows.Controls.Page> метаданные в каждой записи журнала, а не ссылку на <xref:System.Windows.Controls.Page> объекта. При переходе к записи журнала его <xref:System.Windows.Controls.Page> метаданные используются для создания нового экземпляра указанного <xref:System.Windows.Controls.Page>. Как следствие каждый <xref:System.Windows.Controls.Page> , к которому осуществляется переход имеет время существования, который показан на следующем рисунке.  
  
 ![Время существования страницы](./media/navigation-overview/navigated-page-lifetime.png "отображается время существования, при переходе со страницы.")  
  
 Хотя при использовании поведения журнала по умолчанию можно сэкономить потребление памяти, производительность отрисовки каждой страницы может уменьшиться; повторное создание экземпляров <xref:System.Windows.Controls.Page> может быть много времени, особенно в том случае, если он имеет много содержимого. Если необходимо сохранить <xref:System.Windows.Controls.Page> экземпляра в журнале, можно рисовать на два способа это сделать. Во-первых, можно осуществить программный переход к <xref:System.Windows.Controls.Page> путем вызова метода <xref:System.Windows.Navigation.NavigationService.Navigate%2A?displayProperty=nameWithType> метод.  
  
 Во-вторых, можно указать, что [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)] сохранял экземпляр <xref:System.Windows.Controls.Page> в журнале, задав <xref:System.Windows.Controls.Page.KeepAlive%2A> свойства `true` (по умолчанию используется `false`). Как показано в следующем примере, можно задать <xref:System.Windows.Controls.Page.KeepAlive%2A> декларативно в разметке.  
  
 [!code-xaml[NavigationOverviewSnippets#KeepAlivePageXAML](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/KeepAlivePage.xaml#keepalivepagexaml)]  
  
 Время существования <xref:System.Windows.Controls.Page> это поддерживается в активном состоянии, немного отличается от другой — нет. В первый раз <xref:System.Windows.Controls.Page> , остается активным осуществляется переход, так же, как создается экземпляр <xref:System.Windows.Controls.Page> , не сохраняется. Тем не менее так как экземпляр <xref:System.Windows.Controls.Page> сохраняется в журнале, он никогда не инициализируется повторно для до тех пор, пока он остается в журнале. Следовательно Если <xref:System.Windows.Controls.Page> имеет логику инициализации, который должен вызываться каждый раз <xref:System.Windows.Controls.Page> к которому осуществляется переход, следует переместить ее из конструктора в обработчик для <xref:System.Windows.FrameworkElement.Loaded> событий. Как показано на следующем рисунке, <xref:System.Windows.FrameworkElement.Loaded> и <xref:System.Windows.FrameworkElement.Unloaded> события по-прежнему вызываются каждый раз <xref:System.Windows.Controls.Page> осуществляется переход и обратно, соответственно.  
  
 ![При возникновении событий загрузки и выгрузки](./media/navigation-overview/loaded-and-unloaded-events.png "загрузки и выгрузки события, возникающие при переходе со страницы и обратно.")  
  
 Когда <xref:System.Windows.Controls.Page> — не поддерживается в активном состоянии, можно выполнять одно из следующих:  
  
-   Сохранять ссылку или любую его часть.  
  
-   Регистрировать обработчики событий с событиями, которые не реализованы в объекте.  
  
 Выполнения любой из этих действий будут созданы ссылки, которые вынудят <xref:System.Windows.Controls.Page> должно храниться в памяти, даже в том случае, если он был удален из журнала.  
  
 В общем случае следует отдавать предпочтение по умолчанию <xref:System.Windows.Controls.Page> поведение не <xref:System.Windows.Controls.Page> проверки активности. Однако при этом существуют реализации состояния, которые описаны в следующем разделе.  
  
<a name="RetainingContentStateWithNavigationHistory"></a>   
### <a name="retaining-content-state-with-navigation-history"></a>Сохранение состояния содержимого с помощью журнала переходов  
 Если <xref:System.Windows.Controls.Page> не поддерживаться в рабочем состоянии, но имеет элементы управления, которые собирают данные от пользователя, что происходит с данными, если пользователь переходит с и обратно <xref:System.Windows.Controls.Page>? С точки зрения пользователя следует ожидать появления ранее введенных данных. К сожалению так как новый экземпляр класса <xref:System.Windows.Controls.Page> создается при каждом переходе, элементы управления, что собранные данные, инициализируются заново и данные будут потеряны.  
  
 К счастью, журнал обеспечивает запоминание данных через <xref:System.Windows.Controls.Page> при переходах, включая данные элементов управления. В частности, записи журнала для каждого <xref:System.Windows.Controls.Page> действует как временный контейнер для связанного <xref:System.Windows.Controls.Page> состояния. Ниже показано, как используется эта поддержка при <xref:System.Windows.Controls.Page> перехода из:  
  
1. Запись для текущего <xref:System.Windows.Controls.Page> добавляется в журнал.  
  
2. Состояние <xref:System.Windows.Controls.Page> хранится в записи журнала для этой страницы, которая добавляется в стек переходов назад.  
  
3. Новый <xref:System.Windows.Controls.Page> , к которому осуществляется переход.  
  
 Если страницы <xref:System.Windows.Controls.Page> будет осуществлен переход обратно, с помощью журнала, выполняются следующие действия:  
  
1. <xref:System.Windows.Controls.Page> Создается (самая верхняя запись журнала в стеке переходов назад).  
  
2. <xref:System.Windows.Controls.Page> Обновляется с состоянием, которое было сохранено в записи журнала для <xref:System.Windows.Controls.Page>.  
  
3. <xref:System.Windows.Controls.Page> Выполняется переход к.  
  
 [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)] автоматически использует эту поддержку, при использовании следующих элементов управления на <xref:System.Windows.Controls.Page>:  
  
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
  
 Если <xref:System.Windows.Controls.Page> использует эти элементы управления, содержащиеся в них данные запоминаются при <xref:System.Windows.Controls.Page> при переходах, как показано **любимого цвета** <xref:System.Windows.Controls.ListBox> на следующем рисунке.  
  
 ![Страница с элементами управления, помнящими состояние](./media/navigation-overview/data-remembered-across-page-navigations.png "введенные данные запоминаются при переходах между страницами.")  
  
 Когда <xref:System.Windows.Controls.Page> имеет элементы управления, не упомянутые в предыдущем списке, или когда состояние сохраняется в пользовательских объектах, необходимо написать код для сохранения в журнале состояния <xref:System.Windows.Controls.Page> переходов.  
  
 Если необходимо запомнить небольшие части состояния <xref:System.Windows.Controls.Page> при переходах, можно использовать свойства зависимостей (см. в разделе <xref:System.Windows.DependencyProperty>), настроенные с помощью <xref:System.Windows.FrameworkPropertyMetadata.Journal%2A?displayProperty=nameWithType> флаг метаданных.  
  
 Если состояние, ваш <xref:System.Windows.Controls.Page> необходимо запомнить при переходах состоит из нескольких фрагментов данных, может оказаться меньше кода с большим объемом инкапсуляцию состояния в одном классе и реализовать <xref:System.Windows.Navigation.IProvideCustomContentState> интерфейс.  
  
 Если вам необходимо перейти по различным состояниям одного <xref:System.Windows.Controls.Page>, не переходя с <xref:System.Windows.Controls.Page> , можно использовать <xref:System.Windows.Navigation.IProvideCustomContentState> и <xref:System.Windows.Navigation.NavigationService.AddBackEntry%2A?displayProperty=nameWithType>.  
  
<a name="Cookies"></a>   
### <a name="cookies"></a>Файлы cookie  
 Другим образом, как [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)] приложения могут хранить данные с помощью файлов cookie, которые создаются, обновляются и удалить с помощью <xref:System.Windows.Application.SetCookie%2A> и <xref:System.Windows.Application.GetCookie%2A> методы. Файлы cookie, можно создать в [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)] будут использовать другие виды веб-приложений это те же cookie; файлы cookie представляют собой произвольные фрагменты данных, которые хранятся в приложении на клиентском компьютере во время или между сеансами приложения. Данные файлов cookie обычно представлены в форме пары "имя — значение" в следующем формате.  
  
 *имя* `=` *значение*  
  
 При передаче данных <xref:System.Windows.Application.SetCookie%2A>, вместе с <xref:System.Uri> расположения, для которого задается файл cookie, файл cookie создается в памяти, и он доступен только в течение текущего сеанса приложения. Этот тип файла cookie называется *файл cookie сеанса*.  
  
 Чтобы сохранить файл cookie на протяжении нескольких сеансов приложения, необходимо добавить в файл cookie дату окончания срока действия, используя следующий формат.  
  
 *ИМЯ* `=` *ЗНАЧЕНИЕ* `; expires=DAY, DD-MMM-YYYY HH:MM:SS GMT`  
  
 Файл cookie с датой окончания срока действия хранится в текущем [!INCLUDE[TLA#tla_mswin](../../../../includes/tlasharptla-mswin-md.md)] папке временных файлов Интернета для установки до истечения срока действия файла cookie. Такой файл cookie называется *постоянный файл cookie* так, как он сохраняется между сеансами приложения.  
  
 Получить сеанс и постоянные файлы cookie, вызвав <xref:System.Windows.Application.GetCookie%2A> , передавая <xref:System.Uri> расположения, где был задан файл cookie с <xref:System.Windows.Application.SetCookie%2A> метод.  
  
 Ниже приведены некоторые способы поддержки файлов cookie в [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)]:  
  
-   [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)] Автономные приложения и [!INCLUDE[TLA2#tla_xbap#plural](../../../../includes/tla2sharptla-xbapsharpplural-md.md)] можно создать и управлении файлами cookie.  
  
-   Файлы cookie, создаваемых с [!INCLUDE[TLA2#tla_xbap](../../../../includes/tla2sharptla-xbap-md.md)] можно получить из браузера.  
  
-   [!INCLUDE[TLA2#tla_xbap#plural](../../../../includes/tla2sharptla-xbapsharpplural-md.md)] на том же домене можно создавать и совместно использовать файлы cookie.  
  
-   [!INCLUDE[TLA2#tla_xbap#plural](../../../../includes/tla2sharptla-xbapsharpplural-md.md)] и [!INCLUDE[TLA2#tla_html](../../../../includes/tla2sharptla-html-md.md)] страниц из одного домена можно создавать и совместно использовать файлы cookie.  
  
-   Файлы cookie отправляются при [!INCLUDE[TLA2#tla_xbap#plural](../../../../includes/tla2sharptla-xbapsharpplural-md.md)] и свободные [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] страниц создания веб-запросов.  
  
-   Оба верхнего уровня [!INCLUDE[TLA2#tla_xbap#plural](../../../../includes/tla2sharptla-xbapsharpplural-md.md)] и [!INCLUDE[TLA2#tla_xbap#plural](../../../../includes/tla2sharptla-xbapsharpplural-md.md)] размещенные в IFRAMES доступны файлы cookie.  
  
-   Поддержка файлов cookie в [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)] одинаков для всех поддерживаемых браузерах.  
  
-   В [!INCLUDE[TLA2#tla_ie](../../../../includes/tla2sharptla-ie-md.md)], политика P3P, которая относится к файлам cookie, соблюдается системой [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)], особенно в отношении Майкрософт и сторонних [!INCLUDE[TLA2#tla_xbap#plural](../../../../includes/tla2sharptla-xbapsharpplural-md.md)].  
  
<a name="Structured_Navigation"></a>   
### <a name="structured-navigation"></a>Структурная навигация  
 Если вам нужно передать данные из одного <xref:System.Windows.Controls.Page> в другую, можно передать данные как аргументы конструктора не по умолчанию <xref:System.Windows.Controls.Page>. Обратите внимание, что если вы используете этот способ, то необходимо поддерживать <xref:System.Windows.Controls.Page> активном состоянии; Если нет, в следующий раз, перейдите к <xref:System.Windows.Controls.Page>, [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)] заново создается <xref:System.Windows.Controls.Page> с помощью конструктора по умолчанию.  
  
 Кроме того ваши <xref:System.Windows.Controls.Page> можно реализовать свойства, заданные с данными, которые необходимо передать. Все усложняется тем не менее, если <xref:System.Windows.Controls.Page> требуется для передачи данных обратно в <xref:System.Windows.Controls.Page> , приводящую к нему. Проблема в том, что изначально переходы не поддерживают механизмы, гарантирующие, что <xref:System.Windows.Controls.Page> возвращается после перехода из него. По существу переходы не поддерживают семантику вызова/возврата. Чтобы решить эту проблему, [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)] предоставляет <xref:System.Windows.Navigation.PageFunction%601> класс, который можно использовать, чтобы убедиться, что <xref:System.Windows.Controls.Page> возвращается в прогнозируемом и структурированном виде. Дополнительные сведения см. в разделе [Общие сведения о структурной навигации](structured-navigation-overview.md).  
  
<a name="The_NavigationWindow_Class"></a>   
## <a name="the-navigationwindow-class"></a>Класс NavigationWindow  
 К этому моменту мы рассмотрели целый ряд служб переходов, которые с наибольшей вероятностью будут использоваться для построения приложений с содержимым, допускающим переходы. Эти службы обсуждались в контексте [!INCLUDE[TLA2#tla_xbap#plural](../../../../includes/tla2sharptla-xbapsharpplural-md.md)], несмотря на то, что они не ограничиваются [!INCLUDE[TLA2#tla_xbap#plural](../../../../includes/tla2sharptla-xbapsharpplural-md.md)]. Воспользуйтесь преимуществами опыт работы современных пользователей для включения навигации в стиле браузера в автономные приложения, современные операционные системы и приложений Windows. Вот наиболее распространенные примеры.  
  
-   **Word тезауруса**: Переход по вариантам слов.  
  
-   **Обозреватель файлов**: Просмотр файлов и папок.  
  
-   **Мастеры**: Разбиение сложной задачи на несколько страниц, которые можно перемещаться. Например, мастер компонентов Windows, который обрабатывает добавление и удаление компонентов Windows.  
  
 Включение навигации в стиле браузера в автономных приложениях, можно использовать <xref:System.Windows.Navigation.NavigationWindow> класса. <xref:System.Windows.Navigation.NavigationWindow> является производным от <xref:System.Windows.Window> и расширяет его такой же поддержкой навигации, [!INCLUDE[TLA2#tla_xbap#plural](../../../../includes/tla2sharptla-xbapsharpplural-md.md)] предоставить. Можно использовать <xref:System.Windows.Navigation.NavigationWindow> как главное окно автономного приложения или как дополнительное окно, например диалоговое окно.  
  
 Для реализации <xref:System.Windows.Navigation.NavigationWindow>, как и в случае с классами самого верхнего уровня в [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)] (<xref:System.Windows.Window>, <xref:System.Windows.Controls.Page>, и так далее), используйте комбинацию разметки и кода. Эти действия показаны в следующем примере.  
  
 [!code-xaml[IntroToNavNavigationWindowSnippets#NavigationWindowMARKUP](~/samples/snippets/csharp/VS_Snippets_Wpf/IntroToNavNavigationWindowSnippets/CSharp/MainWindow.xaml#navigationwindowmarkup)]  
  
 [!code-csharp[IntroToNavNavigationWindowSnippets#NavigationWindowCODEBEHIND](~/samples/snippets/csharp/VS_Snippets_Wpf/IntroToNavNavigationWindowSnippets/CSharp/MainWindow.xaml.cs#navigationwindowcodebehind)]
 [!code-vb[IntroToNavNavigationWindowSnippets#NavigationWindowCODEBEHIND](~/samples/snippets/visualbasic/VS_Snippets_Wpf/IntroToNavNavigationWindowSnippets/VisualBasic/MainWindow.xaml.vb#navigationwindowcodebehind)]  
  
 Этот код создает <xref:System.Windows.Navigation.NavigationWindow> , автоматически переходит к <xref:System.Windows.Controls.Page> (HomePage.xaml) при <xref:System.Windows.Navigation.NavigationWindow> открыт. Если <xref:System.Windows.Navigation.NavigationWindow> является главное окно приложения, можно использовать `StartupUri` атрибут, чтобы запустить его. Это показано в следующем примере разметки.  
  
 [!code-xaml[IntroToNavNavigationWindowSnippets#AppLaunchNavWindow](~/samples/snippets/csharp/VS_Snippets_Wpf/IntroToNavNavigationWindowSnippets/CSharp/App.xaml#applaunchnavwindow)]  
  
 На следующем рисунке показан <xref:System.Windows.Navigation.NavigationWindow> как главное окно автономного приложения.  
  
 ![Главное окно](./media/navigation-overview/navigation-window-as-main-window.png "окно навигации, что и главное окно")  
  
 Из рисунка, можно увидеть, что <xref:System.Windows.Navigation.NavigationWindow> имеет заголовок, несмотря на то, что он не задан <xref:System.Windows.Navigation.NavigationWindow> реализации кода из предыдущего примера. Вместо этого заголовок задается с помощью <xref:System.Windows.Controls.Page.WindowTitle%2A> свойство, которое показано в следующем коде.  
  
 [!code-xaml[IntroToNavNavigationWindowSnippets#HomePageMARKUP1](~/samples/snippets/csharp/VS_Snippets_Wpf/IntroToNavNavigationWindowSnippets/CSharp/HomePage.xaml#homepagemarkup1)]  
[!code-xaml[IntroToNavNavigationWindowSnippets#HomePageMARKUP2](~/samples/snippets/csharp/VS_Snippets_Wpf/IntroToNavNavigationWindowSnippets/CSharp/HomePage.xaml#homepagemarkup2)]  
  
 Установка <xref:System.Windows.Controls.Page.WindowWidth%2A> и <xref:System.Windows.Controls.Page.WindowHeight%2A> свойства также влияет на <xref:System.Windows.Navigation.NavigationWindow>.  
  
 Обычно вы реализуете собственный <xref:System.Windows.Navigation.NavigationWindow> при необходимости настроить его поведение или внешний вид. Если вы этого не сделали, можно использовать команду быстрого вызова. Если указать пакет [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)] из <xref:System.Windows.Controls.Page> как <xref:System.Windows.Application.StartupUri%2A> в автономном приложении, <xref:System.Windows.Application> автоматически создает <xref:System.Windows.Navigation.NavigationWindow> узел <xref:System.Windows.Controls.Page>. В следующем примере разметки показано, как это сделать.  
  
 [!code-xaml[IntroToNavNavigationWindowSnippets#AppLaunchPage](~/samples/snippets/csharp/VS_Snippets_Wpf/IntroToNavNavigationWindowSnippets/CSharp/AnotherApp.xaml#applaunchpage)]  
  
 Если необходимо, чтобы дополнительное окно приложения например диалоговое окно, чтобы быть <xref:System.Windows.Navigation.NavigationWindow>, чтобы открыть его, можно использовать код в следующем примере.  
  
 [!code-csharp[IntroToNavNavigationWindowSnippets#CreateNWDialogBox](~/samples/snippets/csharp/VS_Snippets_Wpf/IntroToNavNavigationWindowSnippets/CSharp/DialogOwnerWindow.xaml.cs#createnwdialogbox)]
 [!code-vb[IntroToNavNavigationWindowSnippets#CreateNWDialogBox](~/samples/snippets/visualbasic/VS_Snippets_Wpf/IntroToNavNavigationWindowSnippets/VisualBasic/DialogOwnerWindow.xaml.vb#createnwdialogbox)]  
  
 На рисунке ниже показан результат.  
  
 ![Диалоговое окно](./media/navigation-overview/navigation-window-as-dialog-box.png "окно навигации как диалоговое окно")  
  
 Как вы видите, <xref:System.Windows.Navigation.NavigationWindow> отображает [!INCLUDE[TLA2#tla_ie](../../../../includes/tla2sharptla-ie-md.md)]-стиль **обратно** и **вперед** кнопки, которые позволяют пользователям перемещаться по журналу. Эти кнопки предоставляют пользователям те же возможности, что показаны на следующем рисунке.  
  
 !["И" Назад кнопок в NavigationWindow](./media/navigation-overview/back-and-forward-buttons-in-navigation-window.png "\"и\" Назад кнопки в окне навигации")  
  
 Если страницы предоставляют свои собственные поддержку перемещения по журналу и пользовательский Интерфейс, можно скрыть **обратно** и **вперед** кнопок, отображаемых по <xref:System.Windows.Navigation.NavigationWindow> , задав значение <xref:System.Windows.Navigation.NavigationWindow.ShowsNavigationUI%2A> свойства `false`.  
  
 Кроме того, можно использовать поддержку настройки в [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)] для замены [!INCLUDE[TLA2#tla_ui](../../../../includes/tla2sharptla-ui-md.md)] из <xref:System.Windows.Navigation.NavigationWindow> сам.  
  
<a name="Frame_in_Standalone_Applications"></a>   
## <a name="the-frame-class"></a>Класс Frame  
 Как обозреватель так и <xref:System.Windows.Navigation.NavigationWindow> представляют собой окна, предоставляющие содержимое. В некоторых случаях приложения имеют содержимое, которое не обязательно должно размещаться в целом окне. Такое содержимое помещается внутрь другого содержимого. Можно вставить содержимое с возможностью переходов в другое содержимое с помощью <xref:System.Windows.Controls.Frame> класса. <xref:System.Windows.Controls.Frame> предоставляет такую же поддержку как <xref:System.Windows.Navigation.NavigationWindow> и [!INCLUDE[TLA2#tla_xbap#plural](../../../../includes/tla2sharptla-xbapsharpplural-md.md)].  
  
 В следующем примере показано, как добавить <xref:System.Windows.Controls.Frame> для <xref:System.Windows.Controls.Page> декларативно с помощью `Frame` элемент.  
  
 [!code-xaml[NavigationOverviewSnippets#FrameHostPageXAML1](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/FrameHostPage.xaml#framehostpagexaml1)]  
[!code-xaml[NavigationOverviewSnippets#FrameHostPageXAML2](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/FrameHostPage.xaml#framehostpagexaml2)]  
[!code-xaml[NavigationOverviewSnippets#FrameHostPageXAML3](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/FrameHostPage.xaml#framehostpagexaml3)]  
  
 Эта разметка задает `Source` атрибут `Frame` элемент в пакет [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)] для <xref:System.Windows.Controls.Page> , <xref:System.Windows.Controls.Frame> должен перейти сначала. На следующем рисунке показан [!INCLUDE[TLA2#tla_xbap](../../../../includes/tla2sharptla-xbap-md.md)] с <xref:System.Windows.Controls.Page> с <xref:System.Windows.Controls.Frame> , осуществляющий переходы между несколькими страницами.  
  
 ![Фрейм, осуществивший несколько страниц](./media/navigation-overview/frame-navigation-between-multiple-pages.png "отобразится навигации по кадрам между несколькими страницами.")  
  
 Вы не обязательно использовать только <xref:System.Windows.Controls.Frame> внутри содержимого <xref:System.Windows.Controls.Page>. Обычно для размещения <xref:System.Windows.Controls.Frame> внутри содержимого <xref:System.Windows.Window>.  
  
 По умолчанию <xref:System.Windows.Controls.Frame> использует собственный журнал только при отсутствии другого журнала. Если <xref:System.Windows.Controls.Frame> является частью содержимого, которое размещено внутри <xref:System.Windows.Navigation.NavigationWindow> или [!INCLUDE[TLA2#tla_xbap](../../../../includes/tla2sharptla-xbap-md.md)], <xref:System.Windows.Controls.Frame> использует журнал, который принадлежит <xref:System.Windows.Navigation.NavigationWindow> или [!INCLUDE[TLA2#tla_xbap](../../../../includes/tla2sharptla-xbap-md.md)]. Иногда Однако <xref:System.Windows.Controls.Frame> может потребоваться отвечать за собственный журнал. Одна из причин для этого является необходимость разрешения переходов в журнале в этих страницах, расположенных на серверах <xref:System.Windows.Controls.Frame>. Это показано на следующем рисунке.  
  
 ![Схема фрейма и страницы](./media/navigation-overview/journal-navigation-within-pages-hosted-by-a-frame.png "отобразится журнал навигации в пределах страницы, размещенные во фрейме.")  
  
 В этом случае можно настроить <xref:System.Windows.Controls.Frame> с помощью параметра собственный журнал <xref:System.Windows.Controls.Frame.JournalOwnership%2A> свойство <xref:System.Windows.Controls.Frame> для <xref:System.Windows.Navigation.JournalOwnership.OwnsJournal>. Это показано в следующем примере разметки.  
  
 [!code-xaml[NavigationOverviewSnippets#FrameHostPageOwnJournalXAML1](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/FrameHostPageOwnJournal.xaml#framehostpageownjournalxaml1)]  
[!code-xaml[NavigationOverviewSnippets#FrameHostPageOwnJournalXAML2](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/FrameHostPageOwnJournal.xaml#framehostpageownjournalxaml2)]  
[!code-xaml[NavigationOverviewSnippets#FrameHostPageOwnJournalXAML3](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/FrameHostPageOwnJournal.xaml#framehostpageownjournalxaml3)]  
  
 На следующем рисунке показано влияние перехода <xref:System.Windows.Controls.Frame> , использует собственный журнал.  
  
 ![Кадр, который использует собственный журнал](./media/navigation-overview/frame-uses-its-own-journal.png "это показано влияние перехода в пределах кадра, который использует собственный журнал.")  
  
 Обратите внимание, что записи журнала отображаются в области навигации [!INCLUDE[TLA2#tla_ui](../../../../includes/tla2sharptla-ui-md.md)] в <xref:System.Windows.Controls.Frame>, а не с помощью [!INCLUDE[TLA2#tla_ie](../../../../includes/tla2sharptla-ie-md.md)].  
  
> [!NOTE]
>  Если <xref:System.Windows.Controls.Frame> является частью содержимого, размещенного в <xref:System.Windows.Window>, <xref:System.Windows.Controls.Frame> использует собственный журнал и, следовательно, отображает собственный навигации [!INCLUDE[TLA2#tla_ui](../../../../includes/tla2sharptla-ui-md.md)].  
  
 Если вам требуется <xref:System.Windows.Controls.Frame> для предоставления собственный журнал без отображения панели навигации [!INCLUDE[TLA2#tla_ui](../../../../includes/tla2sharptla-ui-md.md)], можно скрыть навигации [!INCLUDE[TLA2#tla_ui](../../../../includes/tla2sharptla-ui-md.md)] , задав <xref:System.Windows.Controls.Frame.NavigationUIVisibility%2A> для <xref:System.Windows.Visibility.Hidden>. Это показано в следующем примере разметки.  
  
 [!code-xaml[NavigationOverviewSnippets#FrameHostPageHidesUIXAML1](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/FrameHostPageOwnHiddenJournal.xaml#framehostpagehidesuixaml1)]  
[!code-xaml[NavigationOverviewSnippets#FrameHostPageHidesUIXAML2](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/FrameHostPageOwnHiddenJournal.xaml#framehostpagehidesuixaml2)]  
[!code-xaml[NavigationOverviewSnippets#FrameHostPageHidesUIXAML3](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/FrameHostPageOwnHiddenJournal.xaml#framehostpagehidesuixaml3)]  
  
<a name="Navigation_Hosts"></a>   
## <a name="navigation-hosts"></a>Узлы переходов  
 <xref:System.Windows.Controls.Frame> и <xref:System.Windows.Navigation.NavigationWindow> являются классами, которые известны как узлы переходов. Объект *узла навигации* является классом, который может перейти к содержимому и отобразить. В этой ситуации каждом узле переходов используются собственная <xref:System.Windows.Navigation.NavigationService> и журнала. На следующем рисунке показана основная структура узла переходов.  
  
 ![Схемы перехода](./media/navigation-overview/navigation-host-construction.png "основная структура узла переходов")  
  
 По сути, это позволяет <xref:System.Windows.Navigation.NavigationWindow> и <xref:System.Windows.Controls.Frame> обеспечить такую же поддержку переходов, [!INCLUDE[TLA2#tla_xbap](../../../../includes/tla2sharptla-xbap-md.md)] предоставляет при размещении в браузере.  
  
 Помимо использования <xref:System.Windows.Navigation.NavigationService> и журнала, узлы переходов реализуют те же члены, <xref:System.Windows.Navigation.NavigationService> реализует. Это показано на следующем рисунке.  
  
 ![Журнал во фрейме и в NavigationWindow](./media/navigation-overview/navigation-window-and-frame.png "окно навигации и кадра")  
  
 Это позволяет программировать поддержку переходов непосредственно с ними. Это можно использовать, если необходимо предоставить навигации [!INCLUDE[TLA2#tla_ui](../../../../includes/tla2sharptla-ui-md.md)] для <xref:System.Windows.Controls.Frame> , размещенного в <xref:System.Windows.Window>. Кроме того, оба типа реализуют дополнительные, связанных с навигацией члены, включая `BackStack` (<xref:System.Windows.Navigation.NavigationWindow.BackStack%2A?displayProperty=nameWithType>, <xref:System.Windows.Controls.Frame.BackStack%2A?displayProperty=nameWithType>) и `ForwardStack` (<xref:System.Windows.Navigation.NavigationWindow.ForwardStack%2A?displayProperty=nameWithType>, <xref:System.Windows.Controls.Frame.ForwardStack%2A?displayProperty=nameWithType>), которые позволяют перебирать записи журнала в серверной части стек и переслать стека, соответственно.  
  
 Как упоминалось ранее, в приложении может существовать несколько журналов. На следующем рисунке показано пример, когда это возможно.  
  
 ![Несколько журналов в одном приложении](./media/navigation-overview/multiple-journals-in-one-application.png "это пример более одного журнала в приложении.")  
  
<a name="Navigating_to_Content_Other_than_Pages"></a>   
## <a name="navigating-to-content-other-than-xaml-pages"></a>Переход к содержимому, отличному от страниц XAML  
 В этом разделе <xref:System.Windows.Controls.Page> и пакет [!INCLUDE[TLA2#tla_xbap#plural](../../../../includes/tla2sharptla-xbapsharpplural-md.md)] использовался для демонстрируют различные возможности переходов [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)]. Тем не менее <xref:System.Windows.Controls.Page> то есть скомпилированный в приложение не является единственным типом содержимого, к которому можно осуществить переход и пакет [!INCLUDE[TLA2#tla_xbap#plural](../../../../includes/tla2sharptla-xbapsharpplural-md.md)] — не единственный способ определения содержимого.  
  
 Как показано в этом разделе, можно также осуществлять переходы к свободным [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] файлы, [!INCLUDE[TLA2#tla_html](../../../../includes/tla2sharptla-html-md.md)] файлы и объекты.  
  
<a name="Navigating_to_Loose_XAML_Files"></a>   
### <a name="navigating-to-loose-xaml-files"></a>Переход к свободным файлам XAML  
 Свободный [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] файл является файлом со следующими характеристиками:  
  
-   Содержит только [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] (то есть без кода).  
  
-   имеет объявление соответствующего пространства имен;  
  
-   имя файла имеет расширение XAML.  
  
 Например, рассмотрим следующее содержимое, сохраненное как свободный [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] файле Person.xaml.  
  
 [!code-xaml[NavigationOverviewSnippets#LooseXAML](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/Person.xaml#loosexaml)]  
  
 Если дважды щелкнуть файл, браузер откроется, выполнит переход к содержимому и отобразит его. Это показано на следующем рисунке.  
  
 ![Отображение содержимого в файле Person.XAML](./media/navigation-overview/contents-of-person-xaml-file.png "показано содержимое файла Person.XAML.")  
  
 Можно отобразить свободный [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] файл из следующего:  
  
-   веб-узел на локальном компьютере, в интрасети или Интернете;  
  
-   Объект [!INCLUDE[TLA#tla_unc](../../../../includes/tlasharptla-unc-md.md)] общую папку.  
  
-   локальный диск.  
  
 Свободный [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] файл можно добавить в Избранное браузера или сделать домашней страницей браузера.  
  
> [!NOTE]
>  Дополнительные сведения о публикации и запуске свободных [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] страниц, см. в разделе [развертывание приложений WPF](deploying-a-wpf-application-wpf.md).  
  
 Единственным ограничением в отношении свободных [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] является возможность размещения только содержимое, которое безопасно для запуска в режиме частичного доверия. Например `Window` не может быть корневым элементом свободного [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] файл. Дополнительные сведения см. в разделе [Безопасность частичного доверия в WPF](../wpf-partial-trust-security.md).  
  
<a name="Navigating_to_HTML_Files_Using_Frame"></a>   
### <a name="navigating-to-html-files-by-using-frame"></a>Переход к файлам HTML элемента управления Frame  
 Как можно догадаться, можно также перейти к [!INCLUDE[TLA2#tla_html](../../../../includes/tla2sharptla-html-md.md)]. Необходимо просто предоставить [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)] , используется схема http. Например, следующая [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] показывает <xref:System.Windows.Controls.Frame> , осуществляющий переход к [!INCLUDE[TLA2#tla_html](../../../../includes/tla2sharptla-html-md.md)] страницы.  
  
 [!code-xaml[NavigationOverviewSnippets#FrameHtmlNavMARKUP](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/FrameHTMLNavPage.xaml#framehtmlnavmarkup)]  
  
 Переход к [!INCLUDE[TLA2#tla_html](../../../../includes/tla2sharptla-html-md.md)] требуются специальные разрешения. Например, нельзя перейти из [!INCLUDE[TLA2#tla_xbap](../../../../includes/tla2sharptla-xbap-md.md)] , запущенного в песочнице безопасности частичного доверия для зоны Интернета. Дополнительные сведения см. в разделе [Безопасность частичного доверия в WPF](../wpf-partial-trust-security.md).  
  
<a name="Navigating_to_HTML_Files_Using_WebBrowser"></a>   
### <a name="navigating-to-html-files-by-using-the-webbrowser-control"></a>Переход к файлам HTML с помощью элемента управления WebBrowser  
 <xref:System.Windows.Controls.WebBrowser> Управления поддерживает [!INCLUDE[TLA2#tla_html](../../../../includes/tla2sharptla-html-md.md)] размещение документов, навигации и скриптов и управляемого кода взаимодействия. Подробные сведения о <xref:System.Windows.Controls.WebBrowser> управления, см. в разделе <xref:System.Windows.Controls.WebBrowser>.  
  
 Как и <xref:System.Windows.Controls.Frame>, переходе по адресу [!INCLUDE[TLA2#tla_html](../../../../includes/tla2sharptla-html-md.md)] с помощью <xref:System.Windows.Controls.WebBrowser> требуются специальные разрешения. Например, из приложений с частичным доверием можно перейти только к [!INCLUDE[TLA2#tla_html](../../../../includes/tla2sharptla-html-md.md)] расположенный на исходном узле. Дополнительные сведения см. в разделе [Безопасность частичного доверия в WPF](../wpf-partial-trust-security.md).  
  
<a name="Navigating_to_Objects"></a>   
### <a name="navigating-to-custom-objects"></a>Переход к пользовательским объектам  
 Если у вас есть данные, которые хранятся в виде пользовательских объектов, один из способов отображения этих данных является создание <xref:System.Windows.Controls.Page> с содержимым, привязанным к таким объектам (см. в разделе [Общие сведения о привязке данных](../data/data-binding-overview.md)). Если не требуется создание всей страницы только для отображения объектов, то можно перейти непосредственно к ним.  
  
 Рассмотрите возможность `Person` класс, который реализуется в следующем коде.  
  
 [!code-csharp[NavigateToObjectSnippets#PersonClassCODE](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigateToObjectSnippets/CSharp/Person.cs#personclasscode)]
 [!code-vb[NavigateToObjectSnippets#PersonClassCODE](~/samples/snippets/visualbasic/VS_Snippets_Wpf/NavigateToObjectSnippets/VisualBasic/Person.vb#personclasscode)]  
  
 Для перехода к нему вызовите <xref:System.Windows.Navigation.NavigationWindow.Navigate%2A?displayProperty=nameWithType> метод, как показано в следующем примере кода.  
  
 [!code-xaml[NavigateToObjectSnippets#PageThatNavsToObject1](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigateToObjectSnippets/CSharp/HomePage.xaml#pagethatnavstoobject1)]  
[!code-xaml[NavigateToObjectSnippets#PageThatNavsToObject2](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigateToObjectSnippets/CSharp/HomePage.xaml#pagethatnavstoobject2)]  
[!code-xaml[NavigateToObjectSnippets#PageThatNavsToObject3](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigateToObjectSnippets/CSharp/HomePage.xaml#pagethatnavstoobject3)]  
  
 [!code-csharp[NavigateToObjectSnippets#PageThatNavsToObjectCODEBEHIND](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigateToObjectSnippets/CSharp/HomePage.xaml.cs#pagethatnavstoobjectcodebehind)]
 [!code-vb[NavigateToObjectSnippets#PageThatNavsToObjectCODEBEHIND](~/samples/snippets/visualbasic/VS_Snippets_Wpf/NavigateToObjectSnippets/VisualBasic/HomePage.xaml.vb#pagethatnavstoobjectcodebehind)]  
  
 На рисунке ниже показан результат.  
  
 ![Страница, осуществляющая переход в класс](./media/navigation-overview/page-navigates-to-an-object.png "ниже приведен пример страницы, который осуществляет переход к объекту.")  
  
 Из этого рисунка можно видеть, что ничего полезного не отобразилось. На самом деле, возвращаемое значение — это значение, которое отображается `ToString` метод **Person** объекта; по умолчанию это единственное значение, которое [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)] можно использовать для представления объекта. Можно переопределить `ToString` метод для возврата более значимой информации, несмотря на то, что он будет по-прежнему быть только строковым значением. Один из методов, воспользуйтесь преимуществами возможностей представления [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)] является использование шаблона данных. Можно реализовать шаблон данных, [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)] можно связать с объектом определенного типа. В следующем коде показано шаблон данных для `Person` объекта.  
  
 [!code-xaml[NavigateToObjectSnippets#DataTemplateMARKUP](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigateToObjectSnippets/CSharp/App.xaml#datatemplatemarkup)]  
  
 Здесь шаблон данных связан с `Person` типа с помощью `x:Type` расширение разметки в `DataType` атрибута. Затем шаблон данных привязывает `TextBlock` элементов (см. в разделе <xref:System.Windows.Controls.TextBlock>) к свойствам `Person` класса. На следующем рисунке показан обновленный внешний вид `Person` объекта.  
  
 ![Переход к классу с шаблоном данных](./media/navigation-overview/navigating-to-a-class.png "переход к классу, который содержит шаблон данных.")  
  
 Преимуществом этого способа является связность, которая обеспечивается возможностью повторного использования шаблона данных для согласованного отображения объектов в любом месте приложения.  
  
 Дополнительные сведения о шаблонах данных см. в разделе [Общие сведения о шаблонах данных](../data/data-templating-overview.md).  
  
<a name="Security"></a>   
## <a name="security"></a>Безопасность  
 [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)] Поддержка навигации позволяет [!INCLUDE[TLA2#tla_xbap#plural](../../../../includes/tla2sharptla-xbapsharpplural-md.md)] осуществлять переходы через Интернет, а также позволяет приложениям сторонних размещения содержимого. Для защиты приложений и пользователей от опасных [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)] предоставляет широкий набор функций безопасности, которые рассматриваются в [безопасности](../security-wpf.md) и [Безопасность частичного доверия WPF](../wpf-partial-trust-security.md).  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Application.SetCookie%2A>
- <xref:System.Windows.Application.GetCookie%2A>
- [Общие сведения об управлении приложением](application-management-overview.md)
- [URI типа "pack" в WPF](pack-uris-in-wpf.md)
- [Общие сведения о структурной навигации](structured-navigation-overview.md)
- [Общие сведения о топологии переходов](navigation-topologies-overview.md)
- [Практические руководства](navigation-how-to-topics.md)
- [Развертывание приложения WPF](deploying-a-wpf-application-wpf.md)
