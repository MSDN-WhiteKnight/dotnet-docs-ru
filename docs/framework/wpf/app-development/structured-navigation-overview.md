---
title: Общие сведения о структурной навигации
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- structured navigation [WPF]
ms.assetid: 025d30ef-fec5-436d-ad7a-5d5483331c26
ms.openlocfilehash: 0cf2a37eaa812d27dc3d111b1459c9daae72dc5a
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59320075"
---
# <a name="structured-navigation-overview"></a>Общие сведения о структурной навигации
Содержимое, которое может размещаться в Приложение обозревателя XAML (XBAP), <xref:System.Windows.Controls.Frame>, или <xref:System.Windows.Navigation.NavigationWindow> состоит из страниц, которые могут быть идентифицированы пакетом [!INCLUDE[TLA#tla_uri#plural](../../../../includes/tlasharptla-urisharpplural-md.md)] и просматриваться с помощью гиперссылок. Структура страниц и способы навигации по ним с помощью гиперссылок называется топологией навигации. Такая топология подходит для различных типов приложений, особенно тех, в которых необходим переход по документам. В таких приложениях пользователь может перемещаться с одной страницы на другую даже при отсутствии связи между ними.  
  
 Тем не менее другие типы приложений содержат страницы, которым необходимо ссылаться друг на друга. Например, рассмотрим приложение управления персоналом, в котором есть одна страница со списком всех сотрудников организации — страница "Список сотрудников". На этой странице пользователи также могут добавить нового сотрудника, щелкнув гиперссылку. При ее щелчке открывается новая страница "Добавить сотрудника", на которой собираются сведения о новом сотруднике и возвращаются на страницу "Список сотрудников". При этом создается новый сотрудник и обновляется список. Этот стиль навигации аналогичен вызову метода для выполнения обработки и возврата значения, который называется структурным программированием. Таким образом, этот стиль навигации называется *структурной навигацией*.  
  
 <xref:System.Windows.Controls.Page> Класс не реализует поддержку структурной навигации. Вместо этого <xref:System.Windows.Navigation.PageFunction%601> класс является производным от <xref:System.Windows.Controls.Page> и расширяет его с помощью основных конструкций, необходимых для структурной навигации. В этом разделе показано, как установить структурной навигации с помощью <xref:System.Windows.Navigation.PageFunction%601>.  

<a name="Structured_Navigation"></a>   
## <a name="structured-navigation"></a>Структурная навигация  
 Когда одна страница вызывает другую в структурной навигации, необходимы некоторые или все из следующих видов поведения.  
  
-   Переход выполняется с вызывающей страницы на вызываемую. При этом могут передаваться параметры, необходимые вызываемой странице.  
  
-   Когда пользователь завершает работу с вызывающей страницей, вызванная страница может возвращать вызывающей странице следующее:  
  
    -   Возврат информации о состоянии, которая описывает, как была завершена работа с вызывающей страницей (например, пользователь нажал кнопку "ОК" или "Отмена").  
  
    -   Возврат данных, которые были получены от пользователя (например, сведения о новом сотруднике).  
  
-   Когда вызывающая страница возвращается к вызываемой, вызванная страница удаляется из журнала навигации, чтобы изолировать один экземпляр вызываемой страницы от другого.  
  
 Эти виды поведения показаны на следующем рисунке:  
  
 ![Снимок экрана показан поток между вызывающей и вызываемой страницей.](./media/structured-navigation-overview/flow-between-calling-page-called-page.png)  
  
 Эти поведения можно реализовать с помощью <xref:System.Windows.Navigation.PageFunction%601> качестве вызываемой страницы.  
  
<a name="Structured_Navigation_with_PageFunction"></a>   
## <a name="structured-navigation-with-pagefunction"></a>Структурная навигация с помощью PageFunction  
 В этом разделе показано, как реализовать основной механизм структурной навигации с одним <xref:System.Windows.Navigation.PageFunction%601>. В этом образце <xref:System.Windows.Controls.Page> вызовы <xref:System.Windows.Navigation.PageFunction%601> для получения <xref:System.String> от пользователя и вернуть его.  
  
### <a name="creating-a-calling-page"></a>Создание вызывающей страницы  
 Страница, которая вызывает <xref:System.Windows.Navigation.PageFunction%601> может быть либо <xref:System.Windows.Controls.Page> или <xref:System.Windows.Navigation.PageFunction%601>. В этом примере это <xref:System.Windows.Controls.Page>, как показано в следующем коде.  
  
 [!code-xaml[StructuredNavigationSample#CallingPageDefaultMARKUP1](~/samples/snippets/csharp/VS_Snippets_Wpf/StructuredNavigationSample/CSharp/CallingPage.xaml#callingpagedefaultmarkup1)]  
[!code-xaml[StructuredNavigationSample#CallingPageDefaultMARKUP2](~/samples/snippets/csharp/VS_Snippets_Wpf/StructuredNavigationSample/CSharp/CallingPage.xaml#callingpagedefaultmarkup2)]  
  
 [!code-csharp[StructuredNavigationSample#CallingPageDefaultCODEBEHIND1](~/samples/snippets/csharp/VS_Snippets_Wpf/StructuredNavigationSample/CSharp/CallingPage.xaml.cs#callingpagedefaultcodebehind1)]
   
[!code-csharp[StructuredNavigationSample#CallingPageDefaultCODEBEHIND2](~/samples/snippets/csharp/VS_Snippets_Wpf/StructuredNavigationSample/CSharp/CallingPage.xaml.cs#callingpagedefaultcodebehind2)]
  
[!code-csharp[StructuredNavigationSample#CallingPageDefaultCODEBEHIND3](~/samples/snippets/csharp/VS_Snippets_Wpf/StructuredNavigationSample/CSharp/CallingPage.xaml.cs#callingpagedefaultcodebehind3)]
  
  
### <a name="creating-a-page-function-to-call"></a>Создание страничной функции для вызова  
 Поскольку вызывающая страница может использовать вызываемую страницу для сбора и возврата данных от пользователя, <xref:System.Windows.Navigation.PageFunction%601> реализуется в виде универсального класса, тип аргумента которого определяет тип значения, возвращаемого вызываемой страницей. Следующий код показывает начальную реализацию вызываемой страницы, используя <xref:System.Windows.Navigation.PageFunction%601>, который возвращает <xref:System.String>.  
  
 [!code-xaml[StructuredNavigationSample#CalledPageFunctionMARKUP](~/samples/snippets/csharp/VS_Snippets_Wpf/StructuredNavigationSample/CSharp/CalledPageFunction.xaml#calledpagefunctionmarkup)]  
  
 [!code-csharp[StructuredNavigationSample#CalledPageFunctionCODEBEHIND1](~/samples/snippets/csharp/VS_Snippets_Wpf/StructuredNavigationSample/CSharp/CalledPageFunction.xaml.cs#calledpagefunctioncodebehind1)]
   
[!code-csharp[StructuredNavigationSample#CalledPageFunctionCODEBEHIND2](~/samples/snippets/csharp/VS_Snippets_Wpf/StructuredNavigationSample/CSharp/CalledPageFunction.xaml.cs#calledpagefunctioncodebehind2)]
  
  
 Объявление <xref:System.Windows.Navigation.PageFunction%601> похоже на объявление <xref:System.Windows.Controls.Page> с добавлением аргументов типа. Как видно из примера кода, аргументы типа указаны и в разметке XAML с помощью атрибута `x:TypeArguments`, и в коде программной части с помощью стандартного синтаксиса аргумента универсального типа.  
  
 Не нужно использовать только классы .NET Framework в качестве аргументов типа. Объект <xref:System.Windows.Navigation.PageFunction%601> может быть вызван для сбора данных отдельного домена, которые абстрагированы как пользовательский тип. Ниже показано, как использовать пользовательский тип в качестве аргумента типа для <xref:System.Windows.Navigation.PageFunction%601>.  
  
 [!code-csharp[CustomTypePageFunctionSnippets#CustomTypeCODE1](~/samples/snippets/csharp/VS_Snippets_Wpf/CustomTypePageFunctionSnippets/CSharp/CustomType.cs#customtypecode1)]
   
[!code-csharp[CustomTypePageFunctionSnippets#CustomTypeCODE2](~/samples/snippets/csharp/VS_Snippets_Wpf/CustomTypePageFunctionSnippets/CSharp/CustomType.cs#customtypecode2)]
  
  
 [!code-xaml[CustomTypePageFunctionSnippets#CustomTypePageFunctionMARKUP1](~/samples/snippets/csharp/VS_Snippets_Wpf/CustomTypePageFunctionSnippets/CSharp/CustomTypePageFunction.xaml#customtypepagefunctionmarkup1)]  
[!code-xaml[CustomTypePageFunctionSnippets#CustomTypePageFunctionMARKUP2](~/samples/snippets/csharp/VS_Snippets_Wpf/CustomTypePageFunctionSnippets/CSharp/CustomTypePageFunction.xaml#customtypepagefunctionmarkup2)]  
  
 [!code-csharp[CustomTypePageFunctionSnippets#CustomTypePageFunctionCODEBEHIND1](~/samples/snippets/csharp/VS_Snippets_Wpf/CustomTypePageFunctionSnippets/CSharp/CustomTypePageFunction.xaml.cs#customtypepagefunctioncodebehind1)]
   
[!code-csharp[CustomTypePageFunctionSnippets#CustomTypePageFunctionCODEBEHIND2](~/samples/snippets/csharp/VS_Snippets_Wpf/CustomTypePageFunctionSnippets/CSharp/CustomTypePageFunction.xaml.cs#customtypepagefunctioncodebehind2)]
  
  
 Аргументы типа для <xref:System.Windows.Navigation.PageFunction%601> обеспечивают основу для связи между вызывающей и вызываемой страницами, которые рассматриваются в следующих разделах.  
  
 Как вы увидите, тип, который идентифицируется с помощью объявления <xref:System.Windows.Navigation.PageFunction%601> играет важную роль в возврате данных из <xref:System.Windows.Navigation.PageFunction%601> вызывающей странице.  
  
### <a name="calling-a-pagefunction-and-passing-parameters"></a>Вызов PageFunction и передача параметров  
 Чтобы вызвать страницу, вызывающая страница должна создать экземпляр вызываемой страницы и перейдите к нему с помощью <xref:System.Windows.Navigation.NavigationService.Navigate%2A> метод. Это позволяет вызывающей странице передавать вызываемой начальные данные, например, значения по умолчанию для данных, собираемых вызываемой страницей.  
  
 В следующем коде показана вызываемая страница с нестандартным конструктором, который принимает параметры от вызывающей страницы.  
  
 [!code-csharp[StructuredNavigationSample#AcceptsInitialDataCODEBEHIND1](~/samples/snippets/csharp/VS_Snippets_Wpf/StructuredNavigationSample/CSharp/CalledPageFunction.xaml.cs#acceptsinitialdatacodebehind1)]
   
[!code-csharp[StructuredNavigationSample#AcceptsInitialDataCODEBEHIND2](~/samples/snippets/csharp/VS_Snippets_Wpf/StructuredNavigationSample/CSharp/CalledPageFunction.xaml.cs#acceptsinitialdatacodebehind2)]
  
[!code-csharp[StructuredNavigationSample#AcceptsInitialDataCODEBEHIND3](~/samples/snippets/csharp/VS_Snippets_Wpf/StructuredNavigationSample/CSharp/CalledPageFunction.xaml.cs#acceptsinitialdatacodebehind3)]
  
[!code-csharp[StructuredNavigationSample#AcceptsInitialDataCODEBEHIND4](~/samples/snippets/csharp/VS_Snippets_Wpf/StructuredNavigationSample/CSharp/CalledPageFunction.xaml.cs#acceptsinitialdatacodebehind4)]
  
  
 В следующем коде показано вызывающая страница, обрабатывающая <xref:System.Windows.Documents.Hyperlink.Click> событие <xref:System.Windows.Documents.Hyperlink> для создания экземпляра вызываемой страницы и передачи ей исходного строкового параметра.  
  
 [!code-xaml[StructuredNavigationSample#PassingDataMARKUP2](~/samples/snippets/csharp/VS_Snippets_Wpf/StructuredNavigationSample/CSharp/CallingPage.xaml#passingdatamarkup2)]  
[!code-csharp[StructuredNavigationSample#PassingDataCODEBEHIND1](~/samples/snippets/csharp/VS_Snippets_Wpf/StructuredNavigationSample/CSharp/CallingPage.xaml.cs#passingdatacodebehind1)]
  
[!code-csharp[StructuredNavigationSample#PassingDataCODEBEHIND2](~/samples/snippets/csharp/VS_Snippets_Wpf/StructuredNavigationSample/CSharp/CallingPage.xaml.cs#passingdatacodebehind2)]
  
[!code-csharp[StructuredNavigationSample#PassingDataCODEBEHIND3](~/samples/snippets/csharp/VS_Snippets_Wpf/StructuredNavigationSample/CSharp/CallingPage.xaml.cs#passingdatacodebehind3)]
  
  
 Необязательно передавать параметры вызываемой странице. Вместо этого можно сделать следующее.  
  
-   Из вызывающей страницы:  
  
    1.  Создать экземпляр вызываемой <xref:System.Windows.Navigation.PageFunction%601> с помощью конструктора по умолчанию.  
  
    2.  Параметры в Store <xref:System.Windows.Application.Properties%2A>.  
  
    3.  Перейдите к вызываемому <xref:System.Windows.Navigation.PageFunction%601>.  
  
-   Из вызванной <xref:System.Windows.Navigation.PageFunction%601>:  
  
    -   Получить и использовать параметры, сохраненные в <xref:System.Windows.Application.Properties%2A>.  
  
 Однако вскоре вы увидите, что и в этом случае потребуется код для создания экземпляра и перехода к вызываемой странице для сбора данных, возвращаемых вызываемой страницей. По этой причине <xref:System.Windows.Navigation.PageFunction%601> должен поддерживаться; в противном случае — значение, в следующий раз вы переходите <xref:System.Windows.Navigation.PageFunction%601>, WPF создает <xref:System.Windows.Navigation.PageFunction%601> с помощью конструктора по умолчанию.  
  
 Однако до возврата вызываемой страницы она должна вернуть данные, которые могут быть получены вызывающей страницей.  
  
### <a name="returning-task-result-and-task-data-from-a-task-to-a-calling-page"></a>Возврат результата и данных задачи из задачи на вызывающую страницу  
 Когда пользователь закончит использовать вызываемую страницу (в данном примере он нажимает кнопку "ОК" или "Отмена"), необходим возврат вызываемой страницы. Поскольку вызывающая страница использовала вызываемую для сбора данных от пользователя, вызывающей странице необходимо два типа информации:  
  
1. Отменил ли пользователь вызываемую страницу (нажав кнопку "ОК" или "Отмена" в этом примере). Это позволяет вызывающей странице определить, следует ли обрабатывать данные, собранные вызывающей страницей от пользователя.  
  
2. Данные, предоставленные пользователем.  
  
 Для получения сведений, <xref:System.Windows.Navigation.PageFunction%601> реализует <xref:System.Windows.Navigation.PageFunction%601.OnReturn%2A> метод. В следующем коде показан его вызов.  
  
 [!code-csharp[StructuredNavigationSample#ReturnCODEBEHIND1](~/samples/snippets/csharp/VS_Snippets_Wpf/StructuredNavigationSample/CSharp/CalledPageFunction.xaml.cs#returncodebehind1)]
   
[!code-csharp[StructuredNavigationSample#ReturnCODEBEHIND2](~/samples/snippets/csharp/VS_Snippets_Wpf/StructuredNavigationSample/CSharp/CalledPageFunction.xaml.cs#returncodebehind2)]
  
  
 В этом примере, если пользователь нажимает кнопку "Отмена", значение `null` возвращается вызывающей странице. Если нажата кнопка "ОК", возвращается строковый параметр, предоставленный пользователем. <xref:System.Windows.Navigation.PageFunction%601.OnReturn%2A> является `protected virtual` метод, который вы вызываете для возврата данных вызывающей странице. Данные необходимо упаковать в экземпляре универсального <xref:System.Windows.Navigation.ReturnEventArgs%601> тип, тип аргумента которого определяет тип значения, <xref:System.Windows.Navigation.ReturnEventArgs%601.Result%2A> возвращает. Таким образом, при объявлении <xref:System.Windows.Navigation.PageFunction%601> с определенным аргументом типа, вы заявляете, что <xref:System.Windows.Navigation.PageFunction%601> возвращает экземпляр типа, указанного аргументом типа. В этом примере аргумент типа и, следовательно, возвращаемое значение имеет тип <xref:System.String>.  
  
 Когда <xref:System.Windows.Navigation.PageFunction%601.OnReturn%2A> называется вызывающей странице требуется способ получения возвращаемого значения <xref:System.Windows.Navigation.PageFunction%601>. По этой причине <xref:System.Windows.Navigation.PageFunction%601> реализует <xref:System.Windows.Navigation.PageFunction%601.Return> событие для вызывающей страницы для обработки. При <xref:System.Windows.Navigation.PageFunction%601.OnReturn%2A> вызове <xref:System.Windows.Navigation.PageFunction%601.Return> вызывается, поэтому вызывающая страница может зарегистрироваться с <xref:System.Windows.Navigation.PageFunction%601.Return> для получения уведомлений.  
  
 [!code-csharp[StructuredNavigationSample#ProcessResultCODEBEHIND1](~/samples/snippets/csharp/VS_Snippets_Wpf/StructuredNavigationSample/CSharp/CallingPage.xaml.cs#processresultcodebehind1)]
   
[!code-csharp[StructuredNavigationSample#ProcessResultCODEBEHIND2](~/samples/snippets/csharp/VS_Snippets_Wpf/StructuredNavigationSample/CSharp/CallingPage.xaml.cs#processresultcodebehind2)]
  
  
### <a name="removing-task-pages-when-a-task-completes"></a>Удаление страниц задачи после завершения задачи  
 Когда вызываемая страница возвращается и пользователь не отменяет ее, вызывающая страница будет обрабатывать данные, предоставленные пользователем и возвращенные вызываемой страницей. Сбор данных таким способом, как правило, является изолированным действием. Когда возвращается вызываемая страница, вызывающей странице необходимо создать новую вызывающую страницу и перейти к ней для сбора дополнительных данных.  
  
 Однако, если вызываемая страница не удалена из журнала, пользователь сможет перейти обратно к предыдущему экземпляру вызывающей страницы. Ли <xref:System.Windows.Navigation.PageFunction%601> сохраняется в журнале, определяется <xref:System.Windows.Navigation.PageFunctionBase.RemoveFromJournal%2A> свойство. По умолчанию — страничная функция автоматически удаляется, когда <xref:System.Windows.Navigation.PageFunction%601.OnReturn%2A> называется, поскольку <xref:System.Windows.Navigation.PageFunctionBase.RemoveFromJournal%2A> присваивается `true`. Чтобы сохранить страничную функцию в журнале навигации после <xref:System.Windows.Navigation.PageFunction%601.OnReturn%2A> вызывается, задайте <xref:System.Windows.Navigation.PageFunctionBase.RemoveFromJournal%2A> для `false`.  
  
<a name="Other_Types_of_Structured_Navigation"></a>   
## <a name="other-types-of-structured-navigation"></a>Другие типы структурной навигации  
 В этом разделе показан самый простой метод <xref:System.Windows.Navigation.PageFunction%601> для поддержки вызова/возврата структурной навигации. На этой основе можно создавать более сложные типы структурной навигации.  
  
 Например, иногда вызывающей странице требуется несколько страниц для сбора достаточного количества данных от пользователя или выполнения задачи. Использование нескольких страниц называется "мастер".  
  
 В других случаях для эффективной работы приложения могут иметь сложные топологии переходов, зависящие от структурной навигации. Дополнительную информацию см. в разделе [Общие сведения о топологиях навигации](navigation-topologies-overview.md).  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Navigation.PageFunction%601>
- <xref:System.Windows.Navigation.NavigationService>
- [Общие сведения о топологии переходов](navigation-topologies-overview.md)
