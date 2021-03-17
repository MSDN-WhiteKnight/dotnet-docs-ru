---
title: Практическое руководство. Создание надстройки, возвращающей пользовательский интерфейс
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- creating an add-in that returns a UI [WPF]
- implementing add-in pipeline segments [WPF]
- add-in [WPF], returns a UI
ms.assetid: 57f274b7-4c66-4b72-92eb-81939a393776
ms.openlocfilehash: faed11bb02037ea42b31402d431e1bcdd8b70339
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59115756"
---
# <a name="how-to-create-an-add-in-that-returns-a-ui"></a>Практическое руководство. Создание надстройки, возвращающей пользовательский интерфейс
В этом примере показано, как создать надстройку, возвращающий Windows Presentation Foundation (WPF) на узел автономного приложения WPF.  
  
 Надстройка возвращает пользовательский Интерфейс, который является пользовательский элемент управления WPF. Содержимое пользовательского элемента управления составляет одна кнопка, при нажатии которой отображается окно сообщения. Автономное приложение WPF размещает надстройку и отображает пользовательский элемент управления (возвращенный надстройкой) как содержимое главного окна приложения.  
  
 **Предварительные требования**  
  
 В этом примере представлены расширения WPF модель надстроек платформы .NET Framework, реализовать этот сценарий и предполагается следующее:  
  
-   Знание модели надстроек платформы .NET Framework, включая конвейер, надстройка и разработку основного приложения. Если вы не знакомы с этими понятиями, см. в разделе [надстройки и расширения](/previous-versions/dotnet/netframework-4.0/bb384200(v%3dvs.100)). Учебник, в котором демонстрируется реализация конвейера, надстройки и ведущего приложения, см. в разделе [Пошаговое руководство: Создание расширяемого приложения](../../add-ins/walkthrough-create-extensible-app.md).  
  
-   Знание расширений WPF в .NET Framework модель надстроек, которые можно найти здесь: [Общие сведения о надстройках WPF](wpf-add-ins-overview.md).  
  
## <a name="example"></a>Пример  
 Создание надстройки, возвращающей пользовательский Интерфейс WPF требуется специальный код для каждого сегмента конвейера, надстройки и ведущего приложения.  

<a name="Contract"></a>   
## <a name="implementing-the-contract-pipeline-segment"></a>Реализация сегмента конвейера контракта  
 Метод должен быть определен контрактом для возвращения пользовательского интерфейса и его возвращаемое значение должно быть типа <xref:System.AddIn.Contract.INativeHandleContract>. Это демонстрируется путем `GetAddInUI` метод `IWPFAddInContract` контракта в следующем коде.  
  
 [!code-csharp[SimpleAddInReturnsAUISample#ContractCode](~/samples/snippets/csharp/VS_Snippets_Wpf/SimpleAddInReturnsAUISample/CSharp/Contracts/IWPFAddInContract.cs#contractcode)]
 [!code-vb[SimpleAddInReturnsAUISample#ContractCode](~/samples/snippets/visualbasic/VS_Snippets_Wpf/SimpleAddInReturnsAUISample/VisualBasic/Contracts/IWPFAddInContract.vb#contractcode)]  
  
<a name="AddInView"></a>   
## <a name="implementing-the-add-in-view-pipeline-segment"></a>Реализация сегмента конвейера представления надстройки  
 Поскольку надстройка реализует [!INCLUDE[TLA2#tla_ui#plural](../../../../includes/tla2sharptla-uisharpplural-md.md)] предоставляет в качестве подклассов <xref:System.Windows.FrameworkElement>, метод представления надстройки, которое связано с `IWPFAddInView.GetAddInUI` должен возвращать значение типа <xref:System.Windows.FrameworkElement>. В следующем коде показано представление надстройки контракта, реализованное как интерфейс.  
  
 [!code-csharp[SimpleAddInReturnsAUISample#AddInViewCode](~/samples/snippets/csharp/VS_Snippets_Wpf/SimpleAddInReturnsAUISample/CSharp/AddInViews/IWPFAddInView.cs#addinviewcode)]
 [!code-vb[SimpleAddInReturnsAUISample#AddInViewCode](~/samples/snippets/visualbasic/VS_Snippets_Wpf/SimpleAddInReturnsAUISample/VisualBasic/AddInViews/IWPFAddInView.vb#addinviewcode)]  
  
<a name="AddInSideAdapter"></a>   
## <a name="implementing-the-add-in-side-adapter-pipeline-segment"></a>Реализация сегмента конвейера адаптера надстройки  
 Метод контракта возвращает <xref:System.AddIn.Contract.INativeHandleContract>, но Надстройка возвращает <xref:System.Windows.FrameworkElement> (как указано представлением надстройки). Следовательно <xref:System.Windows.FrameworkElement> должны быть преобразованы в <xref:System.AddIn.Contract.INativeHandleContract> перед пересечением границы изоляции. Эту работу выполняет адаптер стороне надстройки, вызвав <xref:System.AddIn.Pipeline.FrameworkElementAdapters.ViewToContractAdapter%2A>, как показано в следующем коде.  
  
 [!code-csharp[SimpleAddInReturnsAUISample#AddInSideAdapterCode](~/samples/snippets/csharp/VS_Snippets_Wpf/SimpleAddInReturnsAUISample/CSharp/AddInSideAdapters/WPFAddIn_ViewToContractAddInSideAdapter.cs#addinsideadaptercode)]
 [!code-vb[SimpleAddInReturnsAUISample#AddInSideAdapterCode](~/samples/snippets/visualbasic/VS_Snippets_Wpf/SimpleAddInReturnsAUISample/VisualBasic/AddInSideAdapters/WPFAddIn_ViewToContractAddInSideAdapter.vb#addinsideadaptercode)]  
  
<a name="HostView"></a>   
## <a name="implementing-the-host-view-pipeline-segment"></a>Реализация сегмента конвейера представления в основном приложении  
 Так как основное приложение будет отображать <xref:System.Windows.FrameworkElement>, метод представления главного приложения, которое связано с `IWPFAddInHostView.GetAddInUI` должен возвращать значение типа <xref:System.Windows.FrameworkElement>. В следующем коде показано представление контракта в основном приложении, реализованное как интерфейс.  
  
 [!code-csharp[SimpleAddInReturnsAUISample#HostViewCode](~/samples/snippets/csharp/VS_Snippets_Wpf/SimpleAddInReturnsAUISample/CSharp/HostViews/IWPFAddInHostView.cs#hostviewcode)]
 [!code-vb[SimpleAddInReturnsAUISample#HostViewCode](~/samples/snippets/visualbasic/VS_Snippets_Wpf/SimpleAddInReturnsAUISample/VisualBasic/HostViews/IWPFAddInHostView.vb#hostviewcode)]  
  
<a name="HostSideAdapter"></a>   
## <a name="implementing-the-host-side-adapter-pipeline-segment"></a>Реализация сегмента конвейера адаптера приложения  
 Метод контракта возвращает <xref:System.AddIn.Contract.INativeHandleContract>, но основное приложение ожидает <xref:System.Windows.FrameworkElement> (как указано представлением узла). Следовательно <xref:System.AddIn.Contract.INativeHandleContract> должны быть преобразованы в <xref:System.Windows.FrameworkElement> после пересечения границы изоляции. Эту работу выполняет адаптер на стороне узла, вызвав <xref:System.AddIn.Pipeline.FrameworkElementAdapters.ContractToViewAdapter%2A>, как показано в следующем коде.  
  
 [!code-csharp[SimpleAddInReturnsAUISample#HostSideAdapterCode](~/samples/snippets/csharp/VS_Snippets_Wpf/SimpleAddInReturnsAUISample/CSharp/HostSideAdapters/WPFAddIn_ContractToViewHostSideAdapter.cs#hostsideadaptercode)]
 [!code-vb[SimpleAddInReturnsAUISample#HostSideAdapterCode](~/samples/snippets/visualbasic/VS_Snippets_Wpf/SimpleAddInReturnsAUISample/VisualBasic/HostSideAdapters/WPFAddIn_ContractToViewHostSideAdapter.vb#hostsideadaptercode)]  
  
<a name="AddIn"></a>   
## <a name="implementing-the-add-in"></a>Реализация надстройки  
 Адаптер на стороне надстройки и надстройка созданного представления надстройки (`WPFAddIn1.AddIn`) должен реализовывать `IWPFAddInView.GetAddInUI` метод для возврата <xref:System.Windows.FrameworkElement> объекта ( <xref:System.Windows.Controls.UserControl> в этом примере). Реализация <xref:System.Windows.Controls.UserControl>, `AddInUI`, показано в следующем примере кода.  
  
 [!code-xaml[SimpleAddInReturnsAUISample#AddInUIMarkup](~/samples/snippets/csharp/VS_Snippets_Wpf/SimpleAddInReturnsAUISample/CSharp/WPFAddIn1/AddInUI.xaml#addinuimarkup)]  
  
 [!code-csharp[SimpleAddInReturnsAUISample#AddInUICodeBehind](~/samples/snippets/csharp/VS_Snippets_Wpf/SimpleAddInReturnsAUISample/CSharp/WPFAddIn1/AddInUI.xaml.cs#addinuicodebehind)]
 [!code-vb[SimpleAddInReturnsAUISample#AddInUICodeBehind](~/samples/snippets/visualbasic/VS_Snippets_Wpf/SimpleAddInReturnsAUISample/VisualBasic/WPFAddIn1/AddInUI.xaml.vb#addinuicodebehind)]  
  
 Реализация `IWPFAddInView.GetAddInUI` надстройкой просто должен возвращать новый экземпляр класса `AddInUI`, как показано в следующем примере кода.  
  
 [!code-csharp[SimpleAddInReturnsAUISample#AddInCode](~/samples/snippets/csharp/VS_Snippets_Wpf/SimpleAddInReturnsAUISample/CSharp/WPFAddIn1/AddIn.cs#addincode)]
 [!code-vb[SimpleAddInReturnsAUISample#AddInCode](~/samples/snippets/visualbasic/VS_Snippets_Wpf/SimpleAddInReturnsAUISample/VisualBasic/WPFAddIn1/AddIn.vb#addincode)]  
  
<a name="App"></a>   
## <a name="implementing-the-host-application"></a>Реализация ведущего приложения  
 Адаптер и созданного представления узла, ведущее приложение может использовать модель надстроек платформы .NET Framework, чтобы открыть конвейер, получить серверное представление надстройки, и вызовите `IWPFAddInHostView.GetAddInUI` метод. Эти действия показаны в следующем коде.  
  
 [!code-csharp[SimpleAddInReturnsAUISample#GetUICode](~/samples/snippets/csharp/VS_Snippets_Wpf/SimpleAddInReturnsAUISample/CSharp/Host/MainWindow.xaml.cs#getuicode)]
 [!code-vb[SimpleAddInReturnsAUISample#GetUICode](~/samples/snippets/visualbasic/VS_Snippets_Wpf/SimpleAddInReturnsAUISample/VisualBasic/Host/MainWindow.xaml.vb#getuicode)]  
  
## <a name="see-also"></a>См. также

- [Надстройки и расширения среды](/previous-versions/dotnet/netframework-4.0/bb384200(v%3dvs.100))
- [Общие сведения о надстройках WPF](wpf-add-ins-overview.md)
