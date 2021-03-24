---
title: Ресурсы, Содержимое и Файлы данных WPF-приложения
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- WPF application [WPF], files
- loose resources [WPF]
- content files [WPF]
- Site of Origin files [WPF]
- resource files [WPF]
- remote files [WPF]
- embedded resources [WPF]
- files [WPF]
- referencing application files [WPF]
- application development [WPF], files
- application management [WPF]
ms.assetid: 7ad2943b-3961-41d3-8fc6-1582d43f5d99
ms.openlocfilehash: 075f70e3ef053507dfe3d408246d179bb57c5891
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59211931"
---
# <a name="wpf-application-resource-content-and-data-files"></a>Ресурсы, Содержимое и Файлы данных WPF-приложения
[!INCLUDE[TLA#tla_win](../../../../includes/tlasharptla-win-md.md)] приложения часто зависят от файлов, которые содержат неисполняемые данные, такие как [!INCLUDE[TLA#tla_xaml](../../../../includes/tlasharptla-xaml-md.md)], изображения, видео и аудио. Windows Presentation Foundation (WPF) предоставляет специальную поддержку при настройке, распознавании и использовании этих типов файлов данных, которые называются файлы данных приложения. Эта поддержка относится к определенному набору типов файлов данных приложения, включая следующие:  
  
-   **Файлы ресурсов**: Файлы данных, которые компилируются в исполняемый файл или библиотека WPF сборки.  
  
-   **Файлы содержимого**: Автономные файлы данных, имеющие явную связь с исполняемой WPF сборки.  
  
-   **Файлы исходного узла**: Автономные файлы данных, которые не имеют никакой связи с исполняемой WPF сборки.  
  
 Важным отличием между этими тремя типами файлов является то, что файлы ресурсов и файлы содержимого известны во время построения. Сборка содержит информацию о них. Для файлов исходного узла, тем не менее, сборка может вообще не знает о них, или содержать неявные сведения через пакетную [!INCLUDE[TLA#tla_uri](../../../../includes/tlasharptla-uri-md.md)] ссылки; в последнем случае регистр нет никакой гарантии, что указанный файл исходного узла действительно существует.  
  
 Чтобы сослаться на файлы данных приложения, Windows Presentation Foundation (WPF) использует пакет [!INCLUDE[TLA#tla_uri](../../../../includes/tlasharptla-uri-md.md)] схему, которая подробно описана [URI типа Pack в WPF](pack-uris-in-wpf.md)).  
  
 В этом разделе описывается настройка и использование файлов данных приложения.  

<a name="Resource_Files"></a>   
## <a name="resource-files"></a>Файлы ресурсов  
 Если файл данных приложения всегда должен быть доступен для приложения, то единственный способ гарантировать доступность — скомпилировать его в главную исполняемую сборку приложения или в одну из его указанных ссылками сборок. Этот тип файлов данных приложения называется *файл ресурсов*.  
  
 Нужно использовать файлы ресурсов, если:  
  
-   Не нужно обновлять содержимое файла ресурсов после его компиляции в сборку.  
  
-   Необходимо упростить распространение приложения за счет уменьшения количества зависимостей между файлами.  
  
-   Файлы данных приложения должны быть локализуемыми (см. в разделе [Обзор локализации и глобализации WPF](../advanced/wpf-globalization-and-localization-overview.md)).  
  
> [!NOTE]
>  Файлы ресурсов, описанные в этом разделе, отличаются от файлов ресурсов, описанных в [ресурсы XAML](../advanced/xaml-resources.md) и отличаются от внедренных или связанных ресурсов, описанных в [управление ресурсами приложения (.NET) ](/visualstudio/ide/managing-application-resources-dotnet).  
  
### <a name="configuring-resource-files"></a>Настройка файлов ресурсов  
 В WPF, файл ресурсов — это файл, который включен в [!INCLUDE[TLA#tla_msbuild](../../../../includes/tlasharptla-msbuild-md.md)] проект в качестве `Resource` элемента.  
  
```xml  
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003" ... >  
  ...  
  <ItemGroup>  
    <Resource Include="ResourceFile.xaml" />  
  </ItemGroup>  
  ...  
</Project>  
```  
  
> [!NOTE]
>  В [!INCLUDE[TLA#tla_visualstu](../../../../includes/tlasharptla-visualstu-md.md)], создайте файл ресурсов путем добавления файла в проект и присвоения его `Build Action` для `Resource`.  
  
 Когда проект будет собран, [!INCLUDE[TLA2#tla_msbuild](../../../../includes/tla2sharptla-msbuild-md.md)] компилирует ресурс в сборку.  
  
### <a name="using-resource-files"></a>Использование файлов ресурсов  
 Чтобы загрузить файл ресурсов, можно вызвать <xref:System.Windows.Application.GetResourceStream%2A> метод <xref:System.Windows.Application> класса, передавая им в пакете [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)] , определяющий нужный файл ресурсов. <xref:System.Windows.Application.GetResourceStream%2A> Возвращает <xref:System.Windows.Resources.StreamResourceInfo> объект, который предоставляет файл ресурсов как <xref:System.IO.Stream> и описывает его тип содержимого.  
  
 Например, приведенный ниже показано, как использовать <xref:System.Windows.Application.GetResourceStream%2A> загрузить <xref:System.Windows.Controls.Page> ресурсов файла и задать его в качестве содержимого <xref:System.Windows.Controls.Frame> (`pageFrame`):  
  
 [!code-csharp[WPFAssemblyResourcesSnippets#LoadAPageResourceFileManuallyCODE](~/samples/snippets/csharp/VS_Snippets_Wpf/WPFAssemblyResourcesSnippets/CSharp/ResourcesSample/ApplicationGetResourceStreamSnippetWindow.xaml.cs#loadapageresourcefilemanuallycode)]
   
  
 Во время вызова методов <xref:System.Windows.Application.GetResourceStream%2A> вы получаете доступ к <xref:System.IO.Stream>, необходимо выполнить дополнительные действия преобразования его в тип свойства, которое будет настраиваться с помощью. Вместо этого можно позволить WPF позаботиться об открытии и преобразовании <xref:System.IO.Stream> , загрузив файл ресурсов непосредственно в свойство типа, с помощью кода.  
  
 В следующем примере показано, как загрузить <xref:System.Windows.Controls.Page> непосредственно в <xref:System.Windows.Controls.Frame> (`pageFrame`) с помощью кода.  
  
 [!code-csharp[WPFAssemblyResourcesSnippets#LoadPageResourceFileFromCODE](~/samples/snippets/csharp/VS_Snippets_Wpf/WPFAssemblyResourcesSnippets/CSharp/ResourcesSample/ApplicationGetResourceStreamSnippetWindow.xaml.cs#loadpageresourcefilefromcode)]
   
  
 В следующем примере показан эквивалент разметки предыдущего примера.  
  
 [!code-xaml[WPFAssemblyResourcesSnippets#LoadPageResourceFileFromXAML](~/samples/snippets/csharp/VS_Snippets_Wpf/WPFAssemblyResourcesSnippets/CSharp/ResourcesSample/ApplicationGetResourceStreamSnippetWindow.xaml#loadpageresourcefilefromxaml)]  
  
### <a name="application-code-files-as-resource-files"></a>Файлы кода приложения как файлы ресурсов  
 На специальный набор WPF файлы кода приложения можно ссылаться с помощью пакета [!INCLUDE[TLA2#tla_uri#plural](../../../../includes/tla2sharptla-urisharpplural-md.md)], включая windows, страницы, документы нефиксированного формата и словари ресурсов. Например, можно задать <xref:System.Windows.Application.StartupUri%2A?displayProperty=nameWithType> свойства с помощью пакета [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)] , ссылающийся на окно или страницу, который вы хотите загрузить при запуске приложения.  
  
 [!code-xaml[WPFAssemblyResourcesSnippets#SetApplicationStartupURI](~/samples/snippets/csharp/VS_Snippets_Wpf/WPFAssemblyResourcesSnippets/CSharp/ResourcesSample/App.xaml#setapplicationstartupuri)]  
  
 Вы можете это сделать, если [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] файл включен в [!INCLUDE[TLA#tla_msbuild](../../../../includes/tlasharptla-msbuild-md.md)] проект в качестве `Page` элемента.  
  
```xml  
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003" ... >  
  ...  
  <ItemGroup>  
    <Page Include="MainWindow.xaml" />  
  </ItemGroup>  
  ...  
</Project>  
```  
  
> [!NOTE]
>  В [!INCLUDE[TLA2#tla_visualstu](../../../../includes/tla2sharptla-visualstu-md.md)], добавляется новый <xref:System.Windows.Window>, <xref:System.Windows.Navigation.NavigationWindow>, <xref:System.Windows.Controls.Page>, <xref:System.Windows.Documents.FlowDocument>, или <xref:System.Windows.ResourceDictionary> в проект, `Build Action` для разметки по умолчанию файл `Page`.  
  
 При создании проекта с `Page` элементы компилируется, [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] элементы преобразуются в двоичный формат и компилируются в связанную сборку. Следовательно, эти файлы можно использовать таким же образом, как и обычные файлы ресурсов.  
  
> [!NOTE]
>  Если [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] файл настроен как `Resource` элемент и не содержит файл с выделенным кодом, необработанный [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] компилируется в сборку, а не в двоичную версию необработанного [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)].  
  
<a name="Content_Files"></a>   
## <a name="content-files"></a>Файлы с содержимым  
 Объект *содержимого файла* распространяется как свободный файл исполняемой сборкой. Несмотря на то, что они не компилируются в сборку, сборки компилируются с метаданными, которые устанавливают связь с каждым файлом содержимого.  
  
 Файлы содержимого необходимо использовать, если приложению требуется определенный набор файлов данных приложения, которые нужно обновлять без повторной компиляции использующей их сборки.  
  
### <a name="configuring-content-files"></a>Настройка файлов содержимого  
 Чтобы добавить файл содержимого в проект, файл данных приложения должен быть включен как `Content` элемента. Кроме того, так как файл содержимого не компилируется непосредственно в сборку, необходимо задать [!INCLUDE[TLA2#tla_msbuild](../../../../includes/tla2sharptla-msbuild-md.md)]`CopyToOutputDirectory` элемента метаданных, чтобы указать, что файл содержимого копируется в расположение относительно сборки построения. Если требуется ресурс копируются в выходную папку сборки при каждом построении проекта, задать `CopyToOutputDirectory` элемента метаданных `Always` значение. В противном случае убедитесь, что только новая версия ресурса копируется в выходную папку построения с помощью `PreserveNewest` значение.  
  
 Ниже показан файл, настроенный как файл содержимого, который копируется в папку выходных данных построения только при добавлении новой версии ресурса в проект.  
  
```xml  
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003" ... >  
  ...  
  <ItemGroup>  
    <Content Include="ContentFile.xaml">  
      <CopyToOutputDirectory>PreserveNewest</CopyToOutputDirectory>  
    </Content>  
  </ItemGroup>  
  ...  
</Project>  
```  
  
> [!NOTE]
>  В [!INCLUDE[TLA2#tla_visualstu](../../../../includes/tla2sharptla-visualstu-md.md)], создать файл содержимого путем добавления файла в проект и присвоения его `Build Action` для `Content`и задайте его `Copy to Output Directory` для `Copy always` (то же, что `Always`) и `Copy if newer` (то же, что `PreserveNewest`).  
  
 Когда проект будет собран, <xref:System.Windows.Resources.AssemblyAssociatedContentFileAttribute> атрибут компилируется в метаданные сборки для каждого файла содержимого.  
  
 `[assembly: AssemblyAssociatedContentFile("ContentFile.xaml")]`  
  
 Значение <xref:System.Windows.Resources.AssemblyAssociatedContentFileAttribute> указывает путь к файлу содержимого относительно его положения в проекте. Например, если файл содержимого был расположен во вложенной папке проекта, Дополнительные сведения о пути были бы включены в <xref:System.Windows.Resources.AssemblyAssociatedContentFileAttribute> значение.  
  
 `[assembly: AssemblyAssociatedContentFile("Resources/ContentFile.xaml")]`  
  
 <xref:System.Windows.Resources.AssemblyAssociatedContentFileAttribute> Значение также является значением пути к файлу содержимого в выходной папке сборки.  
  
### <a name="using-content-files"></a>Использование файлов содержимого  
 Чтобы загрузить файл содержимого, можно вызвать <xref:System.Windows.Application.GetContentStream%2A> метод <xref:System.Windows.Application> класса, передавая им в пакете [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)] , определяющий нужный файл содержимого. <xref:System.Windows.Application.GetContentStream%2A> Возвращает <xref:System.Windows.Resources.StreamResourceInfo> объект, который представляет файл содержимого в качестве <xref:System.IO.Stream> и описывает его тип содержимого.  
  
 Например, приведенный ниже показано, как использовать <xref:System.Windows.Application.GetContentStream%2A> загрузить <xref:System.Windows.Controls.Page> содержимого файла и задать его в качестве содержимого <xref:System.Windows.Controls.Frame> (`pageFrame`).  
  
 [!code-csharp[WPFAssemblyResourcesSnippets#LoadAPageContentFileManuallyCODE](~/samples/snippets/csharp/VS_Snippets_Wpf/WPFAssemblyResourcesSnippets/CSharp/ResourcesSample/ApplicationGetContentStreamSnippetWindow.xaml.cs#loadapagecontentfilemanuallycode)]
   
  
 Во время вызова методов <xref:System.Windows.Application.GetContentStream%2A> вы получаете доступ к <xref:System.IO.Stream>, необходимо выполнить дополнительные действия преобразования его в тип свойства, которое будет настраиваться с помощью. Вместо этого можно позволить WPF позаботиться об открытии и преобразовании <xref:System.IO.Stream> , загрузив файл ресурсов непосредственно в свойство типа, с помощью кода.  
  
 В следующем примере показано, как загрузить <xref:System.Windows.Controls.Page> непосредственно в <xref:System.Windows.Controls.Frame> (`pageFrame`) с помощью кода.  
  
 [!code-csharp[WPFAssemblyResourcesSnippets#LoadPageContentFileFromCODE](~/samples/snippets/csharp/VS_Snippets_Wpf/WPFAssemblyResourcesSnippets/CSharp/ResourcesSample/ApplicationGetContentStreamSnippetWindow.xaml.cs#loadpagecontentfilefromcode)]
   
  
 В следующем примере показан эквивалент разметки предыдущего примера.  
  
 [!code-xaml[WPFAssemblyResourcesSnippets#LoadPageContentFileFromXAML](~/samples/snippets/csharp/VS_Snippets_Wpf/WPFAssemblyResourcesSnippets/CSharp/ResourcesSample/ApplicationGetContentStreamSnippetWindow.xaml#loadpagecontentfilefromxaml)]  
  
<a name="Site_of_Origin_Files"></a>   
## <a name="site-of-origin-files"></a>Файлы исходного узла  
 Файлы ресурсов имеют явную связь со сборками, которые они распространяются, в соответствии с определением <xref:System.Windows.Resources.AssemblyAssociatedContentFileAttribute>. Но иногда необходимо установить неявную либо несуществующую связь между сборкой и файлом данных приложения, например, в следующих случаях:  
  
-   Файл не существует во время компиляции.  
  
-   Неизвестно, какие файлы потребуются для сборки до времени выполнения.  
  
-   Нужна возможность обновлять файлы без повторной компиляции сборки, связанной с ними.  
  
-   Приложение использует большие файлы данных, такие как аудио и видео, и необходимо, чтобы пользователи могли их загружать только при необходимости.  
  
 Можно загрузить эти типы файлов с помощью традиционных [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)] схем, таких как file:/// и http://.  
  
 [!code-xaml[WPFAssemblyResourcesSnippets#AbsolutePackUriFileHttpReferenceXAML](~/samples/snippets/csharp/VS_Snippets_Wpf/WPFAssemblyResourcesSnippets/CSharp/ResourcesSample/AbsolutePackUriPage.xaml#absolutepackurifilehttpreferencexaml)]  
  
 Однако схемы file:/// и http:// требуют полного доверия приложения. Если приложение является [!INCLUDE[TLA#tla_xbap](../../../../includes/tlasharptla-xbap-md.md)] было запущено из Интернета или интрасети, и он запрашивает только набор разрешений, которые разрешены для приложений, запускаемых из этих местоположений, свободные файлы могут быть загружены только из узла приложения (источника место запуска). Такие файлы называются *исходного узла* файлов.  
  
 Файлы исходного узла являются единственным вариантом для приложений с частичным доверием, хотя и не ограничиваются такими приложениями. Приложениям с полным доверием, возможно, все равно придется загружать файлы данных приложений, о которых они не знают во время построения. Хотя приложения с полным доверием могут использовать схему file:///, вероятнее всего, файлы данных приложения будут установлены в одну папку или вложенную папку со сборкой приложения. В этом случае использовать ссылки на исходный узел проще, чем использовать file:///, так как последнее требует разработки полного пути к файлу.  
  
> [!NOTE]
>  Файлы, не кэшируются с исходного узла [!INCLUDE[TLA#tla_xbap](../../../../includes/tlasharptla-xbap-md.md)] на клиентском компьютере, в отличие от файлов содержимого. Следовательно, они загружаются только по специальному запросу. Если [!INCLUDE[TLA#tla_xbap](../../../../includes/tlasharptla-xbap-md.md)] приложения содержит большие мультимедийные файлы, их настройка в качестве файлов исходного узла означает, что первоначальный запуск приложения выполняется гораздо быстрее, а файлы загружаются только по запросу.  
  
### <a name="configuring-site-of-origin-files"></a>Настройка файлов исходного узла  
 Если файлы исходного узла не существуют или неизвестны во время компиляции, необходимо использовать традиционные механизмы обеспечения необходимые файлы доступны во время выполнения, включая использование либо `XCopy` программы командной строки или [!INCLUDE[TLA#tla_wininstall](../../../../includes/tlasharptla-wininstall-md.md)].  
  
 Если во время компиляции известны файлы, которые должны быть расположены на исходном узле, но все еще требуется избежать явных зависимостей, можно добавить эти файлы в [!INCLUDE[TLA#tla_msbuild](../../../../includes/tlasharptla-msbuild-md.md)] проект в качестве `None` элемента. Как и для файлов содержимого, необходимо задать [!INCLUDE[TLA2#tla_msbuild](../../../../includes/tla2sharptla-msbuild-md.md)]`CopyToOutputDirectory` атрибут, чтобы указать, что файл исходного узла копируется в расположение относительно сборки построения, указывая либо `Always` значение или `PreserveNewest` значение.  
  
```xml  
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003" ... >  
  ...  
  <None Include="PageSiteOfOriginFile.xaml">  
    <CopyToOutputDirectory>Always</CopyToOutputDirectory>  
  </None>  
  ...  
</Project>  
```  
  
> [!NOTE]
>  В [!INCLUDE[TLA2#tla_visualstu](../../../../includes/tla2sharptla-visualstu-md.md)], создайте файл исходного узла путем добавления файла в проект и присвоения его `Build Action` для `None`.  
  
 Когда проект будет собран, [!INCLUDE[TLA2#tla_msbuild](../../../../includes/tla2sharptla-msbuild-md.md)] копирует указанные файлы в выходной папке сборки.  
  
### <a name="using-site-of-origin-files"></a>Использование файлов исходного узла  
 Чтобы загрузить файл исходного узла, можно вызвать <xref:System.Windows.Application.GetRemoteStream%2A> метод <xref:System.Windows.Application> класса, передавая им в пакете [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)] , определяющий нужный файл исходного узла. <xref:System.Windows.Application.GetRemoteStream%2A> Возвращает <xref:System.Windows.Resources.StreamResourceInfo> объект, который предоставляет файл исходного как узла <xref:System.IO.Stream> и описывает его тип содержимого.  
  
 Например, приведенный ниже показано, как использовать <xref:System.Windows.Application.GetRemoteStream%2A> загрузить <xref:System.Windows.Controls.Page> исходного узла файла и задать его в качестве содержимого <xref:System.Windows.Controls.Frame> (`pageFrame`).  
  
 [!code-csharp[WPFAssemblyResourcesSnippets#LoadAPageSOOFileManuallyCODE](~/samples/snippets/csharp/VS_Snippets_Wpf/WPFAssemblyResourcesSnippets/CSharp/ResourcesSample/SOOPage.xaml.cs#loadapagesoofilemanuallycode)]
   
  
 Во время вызова методов <xref:System.Windows.Application.GetRemoteStream%2A> вы получаете доступ к <xref:System.IO.Stream>, необходимо выполнить дополнительные действия преобразования его в тип свойства, которое будет настраиваться с помощью. Вместо этого можно позволить WPF позаботиться об открытии и преобразовании <xref:System.IO.Stream> , загрузив файл ресурсов непосредственно в свойство типа, с помощью кода.  
  
 В следующем примере показано, как загрузить <xref:System.Windows.Controls.Page> непосредственно в <xref:System.Windows.Controls.Frame> (`pageFrame`) с помощью кода.  
  
 [!code-csharp[WPFAssemblyResourcesSnippets#LoadPageSOOFileFromCODE](~/samples/snippets/csharp/VS_Snippets_Wpf/WPFAssemblyResourcesSnippets/CSharp/ResourcesSample/SOOPage.xaml.cs#loadpagesoofilefromcode)]
   
  
 В следующем примере показан эквивалент разметки предыдущего примера.  
  
 [!code-xaml[WPFAssemblyResourcesSnippets#LoadPageSOOFileFromXAML](~/samples/snippets/csharp/VS_Snippets_Wpf/WPFAssemblyResourcesSnippets/CSharp/ResourcesSample/SOOPage.xaml#loadpagesoofilefromxaml)]  
  
<a name="Rebuilding_after_Changing_Build_Type"></a>   
## <a name="rebuilding-after-changing-build-type"></a>Повторное построение после изменения типа построения  
 После изменения типа построения файла данных приложения необходимо перестроить все приложение, чтобы обеспечить применение этих изменений. Если просто выполнить построение приложения, изменения не применяются.  
  
## <a name="see-also"></a>См. также

- [URI типа "pack" в WPF](pack-uris-in-wpf.md)
