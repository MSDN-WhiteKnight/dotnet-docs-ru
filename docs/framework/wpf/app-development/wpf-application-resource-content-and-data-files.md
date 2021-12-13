---
title: Ресурсы, Содержимое и Файлы данных WPF-приложения
ms.date: 03/30/2017
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
---

# <a name="wpf-application-resource-content-and-data-files"></a>Ресурсы, Содержимое и Файлы данных WPF-приложения
 Приложения Microsoft Windows часто используют файлы, которые содержат неисполняемые данные, такие как XAML, изображения, видео и аудио. Windows Presentation Foundation (WPF) предоставляет специальную поддержку для настройки, распознавания и использовании этих типов файлов данных, которые называются файлами данных приложения. Эта поддержка относится к определенному набору типов файлов данных приложения, включая следующие:  
  
-   **Файлы ресурсов**: Файлы данных, которые компилируются в исполняемый файл или библиотеку WPF.  
  
-   **Файлы содержимого**: Автономные файлы данных, имеющие явную связь с исполняемой сборкой WPF.  
  
-   **Файлы исходного узла**: Автономные файлы данных, которые не имеют никакой связи с исполняемой сборкой WPF.  
  
 Важным отличием между этими тремя типами файлов является то, что файлы ресурсов и файлы содержимого известны во время построения. Сборка содержит информацию о них. В случае файлов исходного узла, напротив, сборка может вообще не знать о них, или содержать неявные сведения через ссылки pack URI; в последнем случае нет никакой гарантии, что указанный файл исходного узла действительно существует.
  
 Чтобы ссылаться на файлы данных приложения, Windows Presentation Foundation (WPF) использует схему pack URI, которая подробно описана в статье [URI типа Pack в WPF](pack-uris-in-wpf.md)).  
  
 В этом разделе описывается настройка и использование файлов данных приложения.

<a name="Resource_Files"></a>   
## <a name="resource-files"></a>Файлы ресурсов  
 Если файл данных приложения всегда должен быть доступен для приложения, то единственный способ гарантировать доступность — скомпилировать его в главную исполняемую сборку приложения или в одну сборок, на которые она ссылается. Этот тип файлов данных приложения называется *файл ресурсов*.  
  
 Используйте файлы ресурсов, если:  
  
-   Не требуется обновлять содержимое файла ресурсов после его компиляции в сборку.  
  
-   Необходимо упростить распространение приложения за счет уменьшения количества зависимостей между файлами.  
  
-   Файлы данных приложения должны быть локализуемыми (см. раздел [Обзор локализации и глобализации WPF](../advanced/wpf-globalization-and-localization-overview.md)).  
  
> [!NOTE]
>  Файлы ресурсов, описанные в этом разделе, отличаются от файлов ресурсов, описанных в разделе [ресурсы XAML](../advanced/xaml-resources.md), а также от внедренных или связанных ресурсов, описанных в разделе [управление ресурсами приложения (.NET) ](/visualstudio/ide/managing-application-resources-dotnet).  
  
### <a name="configuring-resource-files"></a>Настройка файлов ресурсов  
 В WPF, файл ресурсов — это файл, который включен в проект Microsoft Build Engine (MSBuild) в качестве элемента `Resource`.  
  
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
>  В Microsoft Visual Studio, файл ресурсов создается путем добавления файла в проект и присвоения его свойству `Build Action` значения `Resource`.
  
 При сборке проекта MSBuild компилирует ресурс в сборку.
  
### <a name="using-resource-files"></a>Использование файлов ресурсов  
 Чтобы загрузить файл ресурсов, можно вызвать метод <xref:System.Windows.Application.GetResourceStream%2A> класса <xref:System.Windows.Application>, передавая ему pack URI, определяющий нужный файл ресурсов. <xref:System.Windows.Application.GetResourceStream%2A> возвращает <xref:System.Windows.Resources.StreamResourceInfo>, который предоставляет файл ресурсов как <xref:System.IO.Stream> и описывает тип его содержимого.  
  
 В приведенном ниже примере показано, как использовать <xref:System.Windows.Application.GetResourceStream%2A> для загрузки из файла ресурсов <xref:System.Windows.Controls.Page> и задать его в качестве содержимого <xref:System.Windows.Controls.Frame> (`pageFrame`):
  
 [!code-csharp[WPFAssemblyResourcesSnippets#LoadAPageResourceFileManuallyCODE](~/samples/snippets/csharp/VS_Snippets_Wpf/WPFAssemblyResourcesSnippets/CSharp/ResourcesSample/ApplicationGetResourceStreamSnippetWindow.xaml.cs#loadapageresourcefilemanuallycode)]
   
  
 Во время вызова методов <xref:System.Windows.Application.GetResourceStream%2A> вы получаете доступ к <xref:System.IO.Stream>. Для преобразования его в тип свойства, с которым можно работать, могут понадобиться дополнительные действия. Вместо этого можно позволить WPF позаботиться об открытии и преобразовании <xref:System.IO.Stream>, загрузив файл ресурсов непосредственно в свойство определенного типа.  

 В следующем примере показано, как загрузить <xref:System.Windows.Controls.Page> непосредственно в <xref:System.Windows.Controls.Frame> (`pageFrame`) с помощью кода.  
  
 [!code-csharp[WPFAssemblyResourcesSnippets#LoadPageResourceFileFromCODE](~/samples/snippets/csharp/VS_Snippets_Wpf/WPFAssemblyResourcesSnippets/CSharp/ResourcesSample/ApplicationGetResourceStreamSnippetWindow.xaml.cs#loadpageresourcefilefromcode)]
   
  
 В следующем примере показан эквивалент предыдущего примера, реализованный в коде.
  
 [!code-xaml[WPFAssemblyResourcesSnippets#LoadPageResourceFileFromXAML](~/samples/snippets/csharp/VS_Snippets_Wpf/WPFAssemblyResourcesSnippets/CSharp/ResourcesSample/ApplicationGetResourceStreamSnippetWindow.xaml#loadpageresourcefilefromxaml)]  
  
### <a name="application-code-files-as-resource-files"></a>Файлы кода приложения как файлы ресурсов  
 С помощью pack URI можно ссылаться на определенный набор файлов кода WPF, включая окна, страницы, документы нефиксированного формата и словари ресурсов. Например, можно задать свойство  <xref:System.Windows.Application.StartupUri%2A?displayProperty=nameWithType> с помощью pack URI, ссылающегося на окно или страницу, который вы хотите загрузить при запуске приложения.
  
 [!code-xaml[WPFAssemblyResourcesSnippets#SetApplicationStartupURI](~/samples/snippets/csharp/VS_Snippets_Wpf/WPFAssemblyResourcesSnippets/CSharp/ResourcesSample/App.xaml#setapplicationstartupuri)]  
  
 Вы можете это сделать, если файл XAML включен в проект MSBuild в качестве элемента `Page`.  
  
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
>  В [!INCLUDE[TLA2#tla_visualstu](../../../../includes/tla2sharptla-visualstu-md.md)] при добавлении нового <xref:System.Windows.Window>, <xref:System.Windows.Navigation.NavigationWindow>, <xref:System.Windows.Controls.Page>, <xref:System.Windows.Documents.FlowDocument> или <xref:System.Windows.ResourceDictionary> в проект, значением по умолчанию свойства `Build Action` для файла разметки будет `Page`.
  
 При создании проекта с `Page` элементы компилируется, XAML элементы преобразуются в двоичный формат и компилируются в связанную сборку. Следовательно, эти файлы можно использовать таким же образом, как и обычные файлы ресурсов.
  
> [!NOTE]
>  Если XAML файл настроен как элемент `Resource` и не содержит файл кода, XAML компилируется в сборку необработанным, а не преобразуется в двоичную версию XAML.
  
<a name="Content_Files"></a>   
## <a name="content-files"></a>Файлы с содержимым  
 *Файл содержимого* распространяется как свободный файл вместе с исполняемой сборкой. Несмотря на то, что они не компилируются в сборку, в сборку компилируются метаданные, которые устанавливают связь с каждым файлом содержимого.
  
 Файлы содержимого следует использовать, если приложению требуется определенный набор файлов данных приложения, которые нужно обновлять без перекомпиляции использующей их сборки.
  
### <a name="configuring-content-files"></a>Настройка файлов содержимого  
 Чтобы добавить файл содержимого в проект, файл данных приложения должен быть включен как элемент `Content`. Кроме того, так как файл содержимого не компилируется непосредственно в сборку, необходимо задать элемент метаданных MSBuild `CopyToOutputDirectory`, чтобы указать, что файл содержимого копируется в расположение собираемой сборки. Если требуется копировать ресурс в выходную папку сборки при каждом построении проекта, задайте `CopyToOutputDirectory` равным `Always`. В противном случае убедитесь, обеспечьте копирование только обновленной версии файла  установкой значения `PreserveNewest`.
  
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
>  В [!INCLUDE[TLA2#tla_visualstu](../../../../includes/tla2sharptla-visualstu-md.md)] файл содержимого создается путем добавления файла в проект и присвоения его свойства `Build Action` равным `Content` и установкой `Copy to Output Directory` в `Copy always` (то же, что `Always`) или `Copy if newer` (то же, что `PreserveNewest`).
  
 Когда проект будет собран, атрибут <xref:System.Windows.Resources.AssemblyAssociatedContentFileAttribute> скомпилируется в метаданные сборки для каждого файла содержимого.
  
 `[assembly: AssemblyAssociatedContentFile("ContentFile.xaml")]`  
  
 Значение <xref:System.Windows.Resources.AssemblyAssociatedContentFileAttribute> указывает путь к файлу содержимого относительно его положения в проекте. Например, если файл содержимого был расположен во вложенной папке проекта, дополнительные сведения о пути были бы включены в значение <xref:System.Windows.Resources.AssemblyAssociatedContentFileAttribute>.  

 `[assembly: AssemblyAssociatedContentFile("Resources/ContentFile.xaml")]`  
  
 Значение <xref:System.Windows.Resources.AssemblyAssociatedContentFileAttribute> также является путем к файлу содержимого в выходной папке сборки.
  
### <a name="using-content-files"></a>Использование файлов содержимого  
 Чтобы загрузить файл содержимого, можно вызвать метод <xref:System.Windows.Application.GetContentStream%2A> класса <xref:System.Windows.Application>, передавая им pack URI, определяющий нужный файл содержимого. <xref:System.Windows.Application.GetContentStream%2A> возвращает <xref:System.Windows.Resources.StreamResourceInfo>, который представляет файл содержимого в качестве <xref:System.IO.Stream> и описывает тип его содержимого.

 В приведенном ниже примере показано, как использовать <xref:System.Windows.Application.GetContentStream%2A> для загрузки <xref:System.Windows.Controls.Page> из файла и задать его в качестве содержимого <xref:System.Windows.Controls.Frame> (`pageFrame`).

 [!code-csharp[WPFAssemblyResourcesSnippets#LoadAPageContentFileManuallyCODE](~/samples/snippets/csharp/VS_Snippets_Wpf/WPFAssemblyResourcesSnippets/CSharp/ResourcesSample/ApplicationGetContentStreamSnippetWindow.xaml.cs#loadapagecontentfilemanuallycode)]
   

 Во время вызова методов <xref:System.Windows.Application.GetContentStream%2A> вы получаете доступ к <xref:System.IO.Stream>. Для преобразования его в тип свойства, которое нужно установить, могут потребоваться дополнительные действия. Вместо этого можно позволить WPF позаботиться об открытии и преобразовании <xref:System.IO.Stream>, загрузив файл ресурсов непосредственно в свойство типа.
  
 В следующем примере показано, как загрузить <xref:System.Windows.Controls.Page> непосредственно в <xref:System.Windows.Controls.Frame> (`pageFrame`) с помощью кода.  
  
 [!code-csharp[WPFAssemblyResourcesSnippets#LoadPageContentFileFromCODE](~/samples/snippets/csharp/VS_Snippets_Wpf/WPFAssemblyResourcesSnippets/CSharp/ResourcesSample/ApplicationGetContentStreamSnippetWindow.xaml.cs#loadpagecontentfilefromcode)]

  
 В следующем примере показан эквивалент предыдущего примера, реализованный с помощью разметки.
  
 [!code-xaml[WPFAssemblyResourcesSnippets#LoadPageContentFileFromXAML](~/samples/snippets/csharp/VS_Snippets_Wpf/WPFAssemblyResourcesSnippets/CSharp/ResourcesSample/ApplicationGetContentStreamSnippetWindow.xaml#loadpagecontentfilefromxaml)]  
  
<a name="Site_of_Origin_Files"></a>   
## <a name="site-of-origin-files"></a>Файлы исходного узла
 Файлы ресурсов имеют явную связь со сборками, которые они распространяются, в соответствии с определением <xref:System.Windows.Resources.AssemblyAssociatedContentFileAttribute>. Но иногда необходимо установить неявную либо несуществующую связь между сборкой и файлом данных приложения, например, в следующих случаях:  

-   Файл не существует во время компиляции.  
  
-   Неизвестно, какие файлы потребуются для сборки до времени выполнения.  
  
-   Нужна возможность обновлять файлы без повторной компиляции сборки, связанной с ними.  
  
-   Приложение использует большие файлы данных, такие как аудио и видео, и необходимо, чтобы пользователи могли их загружать только при необходимости.  
  
 Можно загрузить эти типы файлов с помощью традиционных схем URI, таких как file:/// и http://.
  
 [!code-xaml[WPFAssemblyResourcesSnippets#AbsolutePackUriFileHttpReferenceXAML](~/samples/snippets/csharp/VS_Snippets_Wpf/WPFAssemblyResourcesSnippets/CSharp/ResourcesSample/AbsolutePackUriPage.xaml#absolutepackurifilehttpreferencexaml)]  
  
 Однако схемы file:/// и http:// требуют полного доверия приложения. Если приложение является приложением обозревателя XAML (XBAP), запущенным из Интернета или интрасети, и запрашивает только обычный набор разрешений для этих местоположений, свободные файлы могут быть загружены только из узла приложения (исходного места запуска - Site of Origin). Такие файлы называются файлами *исходного узла*.

 Файлы исходного узла являются единственным вариантом для приложений с частичным доверием, хотя и не ограничиваются такими приложениями. Приложениям с полным доверием, возможно, все равно придется загружать файлы данных приложений, о которых они не знают во время построения. Хотя приложения с полным доверием могут использовать схему file:///, вероятнее всего, файлы данных приложения будут установлены в одну папку или вложенную папку со сборкой приложения. В этом случае использовать ссылки на исходный узел проще, чем использовать file:///, так как последнее требует указания полного пути к файлу.
  
> [!NOTE]
>  Файлы, исходного узла XBAP не кэшируются на клиентском компьютере, в отличие от файлов содержимого. Следовательно, они загружаются только по специальному запросу. Если приложение обозревателя содержит большие мультимедийные файлы, их настройка в качестве файлов исходного узла означает, что первоначальный запуск приложения выполняется гораздо быстрее, а файлы загружаются только по запросу.  
  
### <a name="configuring-site-of-origin-files"></a>Настройка файлов исходного узла  
 Если файлы исходного узла не существуют или неизвестны во время компиляции, необходимо использовать традиционные механизмы обеспечения их доступности во время выполнения, включая использование либо программы командной строки `XCopy` или [!INCLUDE[TLA#tla_wininstall](../../../../includes/tlasharptla-wininstall-md.md)].
  
 Если во время компиляции известны файлы, которые должны быть расположены на исходном узле, но все еще требуется избежать явных зависимостей, можно добавить эти файлы в проект MSBuild в качестве элемента `None`. Как и для файлов содержимого, необходимо задать атрибут `CopyToOutputDirectory`, чтобы указать, что файл исходного узла копируется в расположение относительно сборки построения, указывая значение `Always` или `PreserveNewest`.
  
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
>  В [!INCLUDE[TLA2#tla_visualstu](../../../../includes/tla2sharptla-visualstu-md.md)], файл исходного узла создается путем добавления файла в проект и присвоения его свойству `Build Action` значения `None`.
  
 Когда проект будет собран, MSBuild скопирует указанные файлы в выходную папку сборки.
  
### <a name="using-site-of-origin-files"></a>Использование файлов исходного узла  
 Чтобы загрузить файл исходного узла, можно вызвать метод <xref:System.Windows.Application.GetRemoteStream%2A> класса <xref:System.Windows.Application>, передавая ему pack URI, определяющий нужный файл исходного узла. <xref:System.Windows.Application.GetRemoteStream%2A> возвращает <xref:System.Windows.Resources.StreamResourceInfo>, который предоставляет файл исходного узла как <xref:System.IO.Stream> и описывает тип его содержимого.
  
 В приведенном ниже примере показано, как использовать <xref:System.Windows.Application.GetRemoteStream%2A> для загрузки файла исходного узла <xref:System.Windows.Controls.Page> и задать его в качестве содержимого <xref:System.Windows.Controls.Frame> (`pageFrame`).
  
 [!code-csharp[WPFAssemblyResourcesSnippets#LoadAPageSOOFileManuallyCODE](~/samples/snippets/csharp/VS_Snippets_Wpf/WPFAssemblyResourcesSnippets/CSharp/ResourcesSample/SOOPage.xaml.cs#loadapagesoofilemanuallycode)]
   
  
 При вызове метода <xref:System.Windows.Application.GetRemoteStream%2A> вы получаете объект <xref:System.IO.Stream>. Для преобразования его в тип свойства, которое нужно установить, могут потребоваться дополнительные действия. Вместо этого можно позволить WPF позаботиться об открытии и преобразовании <xref:System.IO.Stream>, загрузив файл ресурсов непосредственно в свойство типа.  
  
 В следующем примере показано, как загрузить <xref:System.Windows.Controls.Page> непосредственно в <xref:System.Windows.Controls.Frame> (`pageFrame`) с помощью кода.  
  
 [!code-csharp[WPFAssemblyResourcesSnippets#LoadPageSOOFileFromCODE](~/samples/snippets/csharp/VS_Snippets_Wpf/WPFAssemblyResourcesSnippets/CSharp/ResourcesSample/SOOPage.xaml.cs#loadpagesoofilefromcode)]
   
  
 В следующем примере показан эквивалент предыдущего примера, реализованный в разметке.  
  
 [!code-xaml[WPFAssemblyResourcesSnippets#LoadPageSOOFileFromXAML](~/samples/snippets/csharp/VS_Snippets_Wpf/WPFAssemblyResourcesSnippets/CSharp/ResourcesSample/SOOPage.xaml#loadpagesoofilefromxaml)]  
  
<a name="Rebuilding_after_Changing_Build_Type"></a>   
## <a name="rebuilding-after-changing-build-type"></a>Повторное построение после изменения типа построения  
 После изменения типа построения файла данных приложения необходимо перестроить все приложение, чтобы обеспечить применение этих изменений. Если просто выполнить построение приложения, изменения не применяются.
  
## <a name="see-also"></a>См. также

- [URI типа "pack" в WPF](pack-uris-in-wpf.md)
