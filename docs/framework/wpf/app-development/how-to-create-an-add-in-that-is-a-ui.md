---
title: Практическое руководство. Создание надстройки, являющейся пользовательским интерфейсом
ms.date: 03/30/2017
helpviewer_keywords:
- creating an add-in that is a UI [WPF]
- add-ins [WPF], UI
- creating UI add-ins [WPF]
- UI add-ins [WPF], creating
- implementing UI add-ins [WPF]
- pipeline segments [WPF], creating add-ins
ms.assetid: 86375525-282b-4039-8352-8680051a10ea
ms.openlocfilehash: 9b7fa33d9af8d364491d1c72813cb62f34378557
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59100305"
---
# <a name="how-to-create-an-add-in-that-is-a-ui"></a>Практическое руководство. Создание надстройки, являющейся пользовательским интерфейсом
В этом примере показано, как создать надстройку, Windows Presentation Foundation (WPF), размещаемый в автономное приложение WPF.  
  
 Надстройка — это пользовательский Интерфейс, который является пользовательский элемент управления WPF. Содержимое пользовательского элемента управления составляет одна кнопка, при нажатии которой отображается окно сообщения. Автономное приложение WPF размещает пользовательского интерфейса надстройки как содержимое главного окна приложения.  
  
 **Предварительные требования**  
  
 В этом примере представлены расширения WPF модель надстроек платформы .NET Framework, реализовать этот сценарий и предполагается следующее:  
  
-   Знание модели надстроек платформы .NET Framework, включая конвейер, надстройка и разработку основного приложения. Если вы не знакомы с этими понятиями, см. в разделе [надстройки и расширения](/previous-versions/dotnet/netframework-4.0/bb384200(v%3dvs.100)). Учебник, в котором демонстрируется реализация конвейера, надстройки и ведущего приложения, см. в разделе [Пошаговое руководство: Создание расширяемого приложения](/previous-versions/dotnet/netframework-4.0/bb788290(v%3dvs.100)).  
  
-   Знание расширений WPF в .NET Framework модель. См. в разделе [Общие сведения о надстройках WPF](wpf-add-ins-overview.md).  
  
## <a name="example"></a>Пример  
 Создание надстройки, являющейся пользовательским Интерфейсом WPF требуется специальный код для каждого сегмента конвейера, надстройки и ведущего приложения.  

<a name="Contract"></a>   
## <a name="implementing-the-contract-pipeline-segment"></a>Реализация сегмента конвейера контракта  
 Если надстройка является пользовательским Интерфейсом, контракт для надстройки должен реализовывать <xref:System.AddIn.Contract.INativeHandleContract>. В примере `IWPFAddInContract` реализует <xref:System.AddIn.Contract.INativeHandleContract>, как показано в следующем коде.  
  
 [!code-csharp[SimpleAddInIsAUISample#ContractCode](~/samples/snippets/csharp/VS_Snippets_Wpf/SimpleAddInIsAUISample/CSharp/Contracts/IWPFAddInContract.cs#contractcode)]  
  
<a name="AddInViewPipeline"></a>   
## <a name="implementing-the-add-in-view-pipeline-segment"></a>Реализация сегмента конвейера представления надстройки  
 Поскольку надстройка реализуется как подкласс <xref:System.Windows.FrameworkElement> тип, представление надстройки также должно быть подклассом <xref:System.Windows.FrameworkElement>. Ниже показано представление надстройки контракта, реализованное как `WPFAddInView` класса.  
  
 [!code-csharp[SimpleAddInIsAUISample#AddInViewCode](~/samples/snippets/csharp/VS_Snippets_Wpf/SimpleAddInIsAUISample/CSharp/AddInViews/WPFAddInView.cs#addinviewcode)]  
  
 Здесь представление надстройки является производным от <xref:System.Windows.Controls.UserControl>. Следовательно, пользовательского интерфейса надстройки также должен быть производным от <xref:System.Windows.Controls.UserControl>.  
  
<a name="AddInSideAdapter"></a>   
## <a name="implementing-the-add-in-side-adapter-pipeline-segment"></a>Реализация сегмента конвейера адаптера надстройки  
 Контракт — <xref:System.AddIn.Contract.INativeHandleContract>, надстройка — <xref:System.Windows.FrameworkElement> (как указано в сегменте конвейера представления надстройки). Таким образом <xref:System.Windows.FrameworkElement> должны быть преобразованы в <xref:System.AddIn.Contract.INativeHandleContract> перед пересечением границы изоляции. Эту работу выполняет адаптер стороне надстройки, вызвав <xref:System.AddIn.Pipeline.FrameworkElementAdapters.ViewToContractAdapter%2A>, как показано в следующем коде.  
  
 [!code-csharp[SimpleAddInIsAUISample#AddInSideAdapterCode](~/samples/snippets/csharp/VS_Snippets_Wpf/SimpleAddInIsAUISample/CSharp/AddInSideAdapters/WPFAddIn_ViewToContractAddInSideAdapter.cs#addinsideadaptercode)]  
  
 В модели надстройки, где надстройка возвращает пользовательский Интерфейс (см. в разделе [создание надстройки, возвращающей пользовательский Интерфейс](how-to-create-an-add-in-that-returns-a-ui.md)), преобразовать адаптер надстройки <xref:System.Windows.FrameworkElement> для <xref:System.AddIn.Contract.INativeHandleContract> путем вызова <xref:System.AddIn.Pipeline.FrameworkElementAdapters.ViewToContractAdapter%2A>. <xref:System.AddIn.Pipeline.FrameworkElementAdapters.ViewToContractAdapter%2A> также должен вызываться в этой модели, несмотря на то, что вам нужно реализовать метод, с которым следует записывать код для его вызова. Это делается путем переопределения <xref:System.AddIn.Pipeline.ContractBase.QueryContract%2A> и реализация кода, который вызывает <xref:System.AddIn.Pipeline.FrameworkElementAdapters.ViewToContractAdapter%2A> Если код, который вызывает <xref:System.AddIn.Pipeline.ContractBase.QueryContract%2A> ожидает <xref:System.AddIn.Contract.INativeHandleContract>. В этом случае вызывающий объект будет адаптером приложения, который рассматривается в следующем подразделе.  
  
> [!NOTE]
>  Необходимо также переопределить <xref:System.AddIn.Pipeline.ContractBase.QueryContract%2A> в этой модели, чтобы разрешить переходы между ведущим приложением пользовательский Интерфейс и интерфейс пользователя надстройки. Дополнительные сведения см. в разделе «Add-In ограничения WPF» в [Общие сведения о надстройках WPF](wpf-add-ins-overview.md).  
  
 Так как адаптер на стороне надстройки реализует интерфейс, который является производным от <xref:System.AddIn.Contract.INativeHandleContract>, необходимо также реализовать <xref:System.AddIn.Contract.INativeHandleContract.GetHandle%2A>, несмотря на то, что этот параметр игнорируется при <xref:System.AddIn.Pipeline.ContractBase.QueryContract%2A> переопределяется.  
  
<a name="HostViewPipeline"></a>   
## <a name="implementing-the-host-view-pipeline-segment"></a>Реализация сегмента конвейера представления в основном приложении  
 В этой модели ведущее приложение обычно ожидает, что хост-представление, быть <xref:System.Windows.FrameworkElement> подкласс. Адаптер необходимо преобразовать <xref:System.AddIn.Contract.INativeHandleContract> для <xref:System.Windows.FrameworkElement> после <xref:System.AddIn.Contract.INativeHandleContract> пересекает границу изоляции. Поскольку метод не вызывается ведущим приложением для получения <xref:System.Windows.FrameworkElement>, представления главного приложения должно «вернуть» <xref:System.Windows.FrameworkElement> , включая его. Следовательно, представление главного приложения должен быть производным от подкласс <xref:System.Windows.FrameworkElement> , могут содержать другие UI, такие как <xref:System.Windows.Controls.UserControl>. Ниже показано представление узла контракта, реализованное как `WPFAddInHostView` класса.  

<a name="HostSideAdapter"></a>   
## <a name="implementing-the-host-side-adapter-pipeline-segment"></a>Реализация сегмента конвейера адаптера приложения  
 Контракт — <xref:System.AddIn.Contract.INativeHandleContract>, а ведущее приложение ожидает <xref:System.Windows.Controls.UserControl> (как указано представлением узла). Следовательно <xref:System.AddIn.Contract.INativeHandleContract> должны быть преобразованы в <xref:System.Windows.FrameworkElement> после пересечения границы изоляции и перед заданием в качестве содержимого представления в ведущем приложении (который является производным от <xref:System.Windows.Controls.UserControl>).  
  
 Эту работу выполняет адаптер приложения, как показано в следующем коде.  

 Как видите, адаптер получает <xref:System.AddIn.Contract.INativeHandleContract> путем вызова адаптер на стороне надстройки <xref:System.AddIn.Pipeline.ContractBase.QueryContract%2A> метода (именно на этом этапе где <xref:System.AddIn.Contract.INativeHandleContract> пересекает границу изоляции).  
  
 Адаптер, затем преобразует <xref:System.AddIn.Contract.INativeHandleContract> для <xref:System.Windows.FrameworkElement> путем вызова <xref:System.AddIn.Pipeline.FrameworkElementAdapters.ContractToViewAdapter%2A>. Наконец <xref:System.Windows.FrameworkElement> задается как содержимое представления главного приложения.  
  
<a name="AddIn"></a>   
## <a name="implementing-the-add-in"></a>Реализация надстройки  
 При наличии адаптера надстройки и представления надстройки можно реализовать надстройку, производя ее от представления надстройки, как показано в следующем коде.  

 В этом примере можно увидеть одно любопытное преимущество данной модели: разработчикам должны реализовать только надстройку (поскольку это пользовательский интерфейс), а не класс надстройки и пользовательского интерфейса надстройки.  
  
<a name="HostApp"></a>   
## <a name="implementing-the-host-application"></a>Реализация ведущего приложения  
 Адаптер на стороне узла и созданного представления узла, ведущее приложение может использовать .NET Framework в модели надстройки, чтобы открыть конвейер и получить серверное представление надстройки. Эти действия показаны в следующем коде.  

 Ведущее приложение использует типичный код модели надстроек платформы .NET Framework для активации надстройки, которая неявным образом возвращает представление главного приложения ведущим приложением. Ведущее приложение затем отображает представление главного приложения (который является <xref:System.Windows.Controls.UserControl>) из <xref:System.Windows.Controls.Grid>.  
  
 Код для обработки взаимодействия с помощью пользовательского интерфейса выполняется в домен приложения надстройки. Эти взаимодействия включают следующее.  
  
-   Обработка <xref:System.Windows.Controls.Button><xref:System.Windows.Controls.Primitives.ButtonBase.Click> событий.  
  
-   Отображение <xref:System.Windows.MessageBox>.  
  
 Это действие полностью изолировано от ведущего приложения.  
  
## <a name="see-also"></a>См. также

- [Надстройки и расширения среды](/previous-versions/dotnet/netframework-4.0/bb384200(v%3dvs.100))
- [Общие сведения о надстройках WPF](wpf-add-ins-overview.md)
