---
title: URI типа "pack" в WPF
ms.date: 03/30/2017
helpviewer_keywords:
- pack URI scheme [WPF]
- loading embedded resources [WPF]
- URIs (Uniform Resource Identifiers)
- Uniform Resource Identifiers (URIs)
- loading non-resource files
- application management [WPF]
ms.assetid: 43adb517-21a7-4df3-98e8-09e9cdf764c4
ms.openlocfilehash: 4e005ea96df45da8326386f8b43aa5640ce810b1
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59344355"
---
# <a name="pack-uris-in-wpf"></a>URI типа "pack" в WPF
В Windows Presentation Foundation (WPF), [!INCLUDE[TLA#tla_uri#plural](../../../../includes/tlasharptla-urisharpplural-md.md)] используются для идентификации и загрузки файлов несколькими способами, включая следующие:  
  
-   Указание [!INCLUDE[TLA#tla_ui](../../../../includes/tlasharptla-ui-md.md)] для отображения при первом запуске приложения.  
  
-   Загрузка изображений.  
  
-   Переход по страницам.  
  
-   Загрузка неисполняемых файлов данных.  
  
 Кроме того [!INCLUDE[TLA2#tla_uri#plural](../../../../includes/tla2sharptla-urisharpplural-md.md)] может использоваться для идентификации и загрузки файлов из различных расположений, включая следующие:  
  
-   Текущая сборка.  
  
-   Указанная ссылками сборка.  
  
-   Расположение, связанное со сборкой.  
  
-   Исходный узел приложения.  
  
 Для обеспечения согласованного механизма идентификации и загрузки этих типов файлов из этих расположений, [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)] использует расширяемость *схема URI упаковки*. В этом разделе представлен обзор схемы, описывается формирование пакета [!INCLUDE[TLA2#tla_uri#plural](../../../../includes/tla2sharptla-urisharpplural-md.md)] для разнообразных сценариев, рассматриваются абсолютное и относительное [!INCLUDE[TLA2#tla_uri#plural](../../../../includes/tla2sharptla-urisharpplural-md.md)] и [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)] разрешение как использовать пакет [!INCLUDE[TLA2#tla_uri#plural](../../../../includes/tla2sharptla-urisharpplural-md.md)] из обоих разметки и код.  

<a name="The_Pack_URI_Scheme"></a>   
## <a name="the-pack-uri-scheme"></a>Схема URI типа "pack"  
 Пакет [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)] используется схема [спецификации Open Packaging Conventions](https://go.microsoft.com/fwlink/?LinkID=71255) спецификации (OPC), которая описывает модель для организации и идентификации содержимого. Основными элементами этой модели являются пакеты и элементы, где *пакета* — это логический контейнер для одного или более логическими *частей*. Эта структура показана на следующем рисунке.  
  
 ![Схема пакета и частей](./media/pack-uris-in-wpf/wpf-package-parts-diagram.png)  
  
 Для определения частей, спецификации OPC используется расширяемость RFC 2396 (универсальных кодов ресурса (URI): Общий синтаксис) для определения в пакете [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)] схемы.  
  
 Схемы, который задается параметром [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)] определяется его префиксом; http, ftp и file, известных примеров. Пакет [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)] схема использует «pack» в качестве схемы и содержит два компонента: центр и путь. Ниже приведен формат для пакета [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)].  
  
 пакет: / /*центра*/*путь*
  
 *Центра* указывает тип пакета, которое находится элемент, пока *путь* указывает расположение части внутри пакета.  
  
 Эта концепция показана на следующей схеме:  
  
 ![Отношение между пакетом, сертификацией и путем](./media/pack-uris-in-wpf/wpf-relationship-diagram.png)  
  
 Пакеты и элементы аналогичны приложениям и файлам. Приложение (пакет) может содержать один или несколько файлов (элементов), в том числе:  
  
-   Файлы ресурсов, скомпилированные в локальную сборку.  
  
-   Файлы ресурсов, скомпилированные в сборку, на которую указывает ссылка.  
  
-   Файлы ресурсов, скомпилированные в ссылающуюся сборку.  
  
-   Файлы содержимого.  
  
-   Файлы исходного узла.  
  
 Для доступа к этим типам файлов, [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)] поддерживает два центра: application: / / / и siteoforigin: / / /. Центр application:/// определяет файлы данных приложения, известные во время компиляции, включая файлы ресурсов и файлы содержимого. Центр siteoforigin:/// определяет файлы исходного узла. На следующем рисунке показана область каждого центра.  
  
 ![Схема URI типа “pack”](./media/pack-uris-in-wpf/wpf-pack-uri-scheme.png)  
  
> [!NOTE]
>  Компонент центра пакета [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)] является встроенным [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)] , указывающий на пакет и должен соответствовать стандарту RFC 2396. Кроме того, символ "/" необходимо заменить символом ",", и необходимо обособлять escape-символами такие зарезервированные символы, как "%" и "?". Подробные сведения см. в OPC.  
  
 В следующих разделах рассматривается построение пакета [!INCLUDE[TLA2#tla_uri#plural](../../../../includes/tla2sharptla-urisharpplural-md.md)] с использованием этих двух центров с соответствующими путями для идентификации ресурсов, содержимого и файлы исходного узла.  
  
<a name="Resource_File_Pack_URIs___Local_Assembly"></a>   
## <a name="resource-file-pack-uris"></a>URI типа "pack" для файла ресурсов  
 Файлы ресурсов настраиваются как [!INCLUDE[TLA2#tla_msbuild](../../../../includes/tla2sharptla-msbuild-md.md)]`Resource` элементы и компилируются в сборки. [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)] поддерживает формирование пакета [!INCLUDE[TLA2#tla_uri#plural](../../../../includes/tla2sharptla-urisharpplural-md.md)] может использоваться для идентификации файлов ресурсов, которые компилируются в локальную сборку или компилируется в сборку, на который ссылается локальная сборка.  
  
<a name="Local_Assembly_Resource_File"></a>   
### <a name="local-assembly-resource-file"></a>Файл ресурсов локальной сборки  
 Пакет [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)] для ресурса файла, который компилируется в локальную сборку использует следующие центр и путь:  
  
-   **Центр**: application:///.  
  
-   **Путь**: Имя файла ресурсов, включая его путь относительно корневой папки проекта локальной сборки.  
  
 В следующем примере показано пакете [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)] для [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] файл ресурсов, который находится в корневой папке проекта локальной сборки.  
  
 `pack://application:,,,/ResourceFile.xaml`  
  
 В следующем примере показано пакете [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)] для [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] файла ресурсов, который находится во вложенной папке проекта локальной сборки.  
  
 `pack://application:,,,/Subfolder/ResourceFile.xaml`  
  
<a name="Resource_File_Pack_URIs___Referenced_Assembly"></a>   
### <a name="referenced-assembly-resource-file"></a>Файл ресурсов указанной ссылками сборки  
 Пакет [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)] для ресурса файла, который компилируется в сборку использует следующие центр и путь:  
  
-   **Центр**: application:///.  
  
-   **Путь**: Имя файла ресурсов, который компилируется в сборку. Путь должен соответствовать следующему формату:  
  
     *AssemblyShortName*{*; Версия*] {*; Открытый ключ*]; component /*путь*  
  
    -   **AssemblyShortName** — краткое имя для указанной ссылками сборки.  
  
    -   **;Version** [необязательно] — версия указанной ссылками сборки, которая содержит файл ресурсов. Используется при загрузке двух или более указанных ссылками сборок с одинаковым кратким именем.  
  
    -   **;PublicKey** [необязательно]: открытый ключ, который использовался для подписи указанной ссылками сборки. Используется при загрузке двух или более указанных ссылками сборок с одинаковым кратким именем.  
  
    -   **;component**: указывает, что на упоминаемую сборку ссылается локальная сборка.  
  
    -   **/Path**: имя файла ресурсов, включая его путь относительно корневой папки проекта указанной ссылками сборки.  
  
 В следующем примере показано пакете [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)] для [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] файл ресурсов, который находится в корневой папке проекта указанной ссылками сборки.  
  
 `pack://application:,,,/ReferencedAssembly;component/ResourceFile.xaml`  
  
 В следующем примере показано пакете [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)] для [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] файла ресурсов, который находится во вложенной папке проекта указанной ссылками сборки.  
  
 `pack://application:,,,/ReferencedAssembly;component/Subfolder/ResourceFile.xaml`  
  
 В следующем примере показано пакете [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)] для [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] файл ресурсов, который находится в папке корневой папки проекта ссылочной сборки конкретной версии.  
  
 `pack://application:,,,/ReferencedAssembly;v1.0.0.1;component/ResourceFile.xaml`  
  
 Обратите внимание, что пакет [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)] синтаксис для файлов ресурсов указанной ссылками сборки может использоваться только вместе с приложением: / / / центра. Например, следующее не поддерживается в [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)].  
  
 `pack://siteoforigin:,,,/SomeAssembly;component/ResourceFile.xaml`  
  
<a name="Content_File_Pack_URIs"></a>   
## <a name="content-file-pack-uris"></a>URI типа "pack" для файла содержимого  
 Пакет [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)] для файла содержимого использует следующие центр и путь:  
  
-   **Центр**: application:///.  
  
-   **Путь**: Имя файла содержимого, включая его путь относительно расположения файла системы основной исполняемой сборки приложения.  
  
 В следующем примере показано пакете [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)] для [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] содержимого файла, расположенного в той же папке, что и исполняемая сборка.  
  
 `pack://application:,,,/ContentFile.xaml`  
  
 В следующем примере показано пакете [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)] для [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] содержимого файла, расположенного во вложенной папке относительно исполняемой сборки приложения.  
  
 `pack://application:,,,/Subfolder/ContentFile.xaml`  
  
> [!NOTE]
>  [!INCLUDE[TLA2#tla_html](../../../../includes/tla2sharptla-html-md.md)] файлы содержимого не может перемещаться. [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)] Схема поддерживает переход только к [!INCLUDE[TLA2#tla_html](../../../../includes/tla2sharptla-html-md.md)] файлы, расположенные на исходном узле.  
  
<a name="The_siteoforigin_____Authority"></a>   
## <a name="site-of-origin-pack-uris"></a>URI типа "pack" исходного узла  
 Пакет [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)] для исходного узла файла использует следующие центр и путь:  
  
-   **Центр**: siteoforigin:///.  
  
-   **Путь**: Имя узла исходного файла, включая его путь относительно расположения, из которого была запущена исполняемая сборка.  
  
 В следующем примере показано пакете [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)] для [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] сайта из исходного файла, хранящегося в расположении, из которого запускается исполняемая сборка.  
  
 `pack://siteoforigin:,,,/SiteOfOriginFile.xaml`  
  
 В следующем примере показано пакете [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)] для [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] сайта из исходного файла, хранящегося во вложенной папке относительно расположения, из которого запускается исполняемая сборка приложения.  
  
 `pack://siteoforigin:,,,/Subfolder/SiteOfOriginFile.xaml`  
  
<a name="Page_Files"></a>   
## <a name="page-files"></a>Файлы подкачки  
 [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] файлы, которые настроены как [!INCLUDE[TLA2#tla_msbuild](../../../../includes/tla2sharptla-msbuild-md.md)]`Page` элементы компилируются в сборки таким же образом, как файлы ресурсов. Следовательно [!INCLUDE[TLA2#tla_msbuild](../../../../includes/tla2sharptla-msbuild-md.md)]`Page` элементов можно идентифицировать с помощью пакета [!INCLUDE[TLA2#tla_uri#plural](../../../../includes/tla2sharptla-urisharpplural-md.md)] для файлов ресурсов.  
  
 Типы [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] файлы, которые обычно настраиваются как [!INCLUDE[TLA2#tla_msbuild](../../../../includes/tla2sharptla-msbuild-md.md)]`Page` элементы имеют одно из следующих корневых элементов:  
  
-   <xref:System.Windows.Window?displayProperty=nameWithType>  
  
-   <xref:System.Windows.Controls.Page?displayProperty=nameWithType>  
  
-   <xref:System.Windows.Navigation.PageFunction%601?displayProperty=nameWithType>  
  
-   <xref:System.Windows.ResourceDictionary?displayProperty=nameWithType>  
  
-   <xref:System.Windows.Documents.FlowDocument?displayProperty=nameWithType>  
  
-   <xref:System.Windows.Controls.UserControl?displayProperty=nameWithType>  
  
<a name="Absolute_vs_Relative_Pack_URIs"></a>   
## <a name="absolute-vs-relative-pack-uris"></a>Абсолютные и относительные URI типа "pack"  
 Полный пакет [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)] включает в себя схему, центр и путь, и он считается абсолютным пакет [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)]. Для разработчиков, упрощения [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] элементы обычно допускают настройку соответствующих атрибутов в относительный пакет [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)], который включает только путь.  
  
 Например, рассмотрим следующий абсолютный пакет [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)] для файла ресурсов в локальной сборке.  
  
 `pack://application:,,,/ResourceFile.xaml`  
  
 Относительный пакет [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)] , ссылающийся на этот ресурс файла будет следующим.  
  
 `/ResourceFile.xaml`  
  
> [!NOTE]
>  Поскольку файлы исходного узла не связаны со сборками, они могут ссылаться только на абсолютный пакет [!INCLUDE[TLA2#tla_uri#plural](../../../../includes/tla2sharptla-urisharpplural-md.md)].  
  
 По умолчанию относительный пакет [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)] считается относительно расположения разметки или кода, содержащий ссылку. Если используется предварительная обратная косая черта, однако относительный пакет для [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)] рассматривается относительно корня приложения. Например, рассмотрим следующую структуру проекта.  
  
 `App.xaml`  
  
 `Page2.xaml`  
  
 `\SubFolder`  
  
 `+ Page1.xaml`  
  
 `+ Page2.xaml`  
  
 Если Page1.xaml содержит [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)] , ссылающийся на *корневой*\SubFolder\Page2.xaml, ссылка может использовать следующий относительный пакет [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)].  
  
 `Page2.xaml`  
  
 Если Page1.xaml содержит [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)] , ссылающийся на *корневой*\Page2.xaml, ссылка может использовать следующий относительный пакет [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)].  
  
 `/Page2.xaml`  
  
<a name="Pack_URI_Resolution"></a>   
## <a name="pack-uri-resolution"></a>Разрешение URI типа "pack"  
 Формат пакета [!INCLUDE[TLA2#tla_uri#plural](../../../../includes/tla2sharptla-urisharpplural-md.md)] делает возможным для пакета [!INCLUDE[TLA2#tla_uri#plural](../../../../includes/tla2sharptla-urisharpplural-md.md)] для различных типов файлов может выглядеть одинаково. Например, рассмотрим следующий абсолютный пакет [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)].  
  
 `pack://application:,,,/ResourceOrContentFile.xaml`  
  
 Этот абсолютный пакет [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)] может ссылаться на файлы ресурсов в локальной сборке или файл содержимого. То же самое верно для следующего относительного [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)].  
  
 `/ResourceOrContentFile.xaml`  
  
 Чтобы определить тип файла, типа pack [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)] ссылается на, [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)] разрешает [!INCLUDE[TLA2#tla_uri#plural](../../../../includes/tla2sharptla-urisharpplural-md.md)] для файлов ресурсов в локальных сборках и файлы содержимого с помощью следующих эвристических методов:  
  
1. Проверка метаданных сборки для <xref:System.Windows.Resources.AssemblyAssociatedContentFileAttribute> атрибут, соответствующий пакет [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)].  
  
2. Если <xref:System.Windows.Resources.AssemblyAssociatedContentFileAttribute> обнаружении атрибута путь пакета [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)] ссылается на файл содержимого.  
  
3. Если <xref:System.Windows.Resources.AssemblyAssociatedContentFileAttribute> атрибут не найден, проверки файлы ресурсов набора, которые компилируются в локальную сборку.  
  
4. Если файл ресурсов, которое соответствует пути пакета [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)] найден, путь пакета [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)] ссылается на файл ресурсов.  
  
5. Если ресурс не найден, то созданный <xref:System.Uri> является недопустимым.  
  
 [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)] разрешения не применяется для [!INCLUDE[TLA2#tla_uri#plural](../../../../includes/tla2sharptla-urisharpplural-md.md)] , со следующими разделами:  
  
-   Файлы содержимого в связанные сборки: не поддерживаются следующие типы файлов [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)].  
  
-   Внедренные файлы в указанных ссылками сборках: [!INCLUDE[TLA2#tla_uri#plural](../../../../includes/tla2sharptla-urisharpplural-md.md)] , которые идентифицируют их являются уникальными, поскольку они включают в себя имя сборки, на которые имеются ссылки и `;component` суффикс.  
  
-   Файлы исходного узла: [!INCLUDE[TLA2#tla_uri#plural](../../../../includes/tla2sharptla-urisharpplural-md.md)] , которые идентифицируют их являются уникальными, поскольку они являются только такие файлы, которые могут быть идентифицированы пакетом [!INCLUDE[TLA2#tla_uri#plural](../../../../includes/tla2sharptla-urisharpplural-md.md)] , содержащего центр siteoforigin: / / / центра.  
  
 Единственное упрощение, которое пакет [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)] поддерживает разрешение для кода в некоторой степени зависеть от расположения файлов ресурсов и содержимого. Например, если у вас есть файл ресурсов в локальной сборке, который перенастроен в файл содержимого, пакет [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)] для ресурса останется таким же, как и код, который использует пакет [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)].  
  
<a name="Programming_with_Pack_URIs"></a>   
## <a name="programming-with-pack-uris"></a>Программирование с использованием URI типа "pack"  
 Многие [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)] классы реализуют свойства, которые могут быть заданы с помощью пакета [!INCLUDE[TLA2#tla_uri#plural](../../../../includes/tla2sharptla-urisharpplural-md.md)], в том числе:  
  
-   <xref:System.Windows.Application.StartupUri%2A?displayProperty=nameWithType>  
  
-   <xref:System.Windows.Controls.Frame.Source%2A?displayProperty=nameWithType>  
  
-   <xref:System.Windows.Navigation.NavigationWindow.Source%2A?displayProperty=nameWithType>  
  
-   <xref:System.Windows.Documents.Hyperlink.NavigateUri%2A?displayProperty=nameWithType>  
  
-   <xref:System.Windows.Window.Icon%2A?displayProperty=nameWithType>  
  
-   <xref:System.Windows.Controls.Image.Source%2A?displayProperty=nameWithType>  
  
 Эти свойства можно задать из разметки и кода. В этом разделе демонстрируются основные конструкции для разметки и кода, а также приводятся примеры наиболее распространенных сценариев.  
  
<a name="Using_Pack_URIs_in_Markup"></a>   
### <a name="using-pack-uris-in-markup"></a>Использование URI типа "pack" в разметке  
 Пакет [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)] задается в разметке путем настройки элемента атрибута с помощью пакета [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)]. Пример:  
  
 `<element attribute="pack://application:,,,/File.xaml" />`  
  
 Таблица 1 демонстрирует различные абсолютный пакет [!INCLUDE[TLA2#tla_uri#plural](../../../../includes/tla2sharptla-urisharpplural-md.md)] , можно указывать в разметке.  
  
 Таблица 1. Абсолютный пакет URI типа в разметке  
  
|Файл|Абсолютный пакет [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)]|  
|----------|-------------------------------------------------------------------------------------------------------------------------|  
|Файл ресурсов — локальная сборка|`"pack://application:,,,/ResourceFile.xaml"`|  
|Файл ресурсов в подпапке — локальная сборка|`"pack://application:,,,/Subfolder/ResourceFile.xaml"`|  
|Файл ресурсов — указанная ссылками сборка|`"pack://application:,,,/ReferencedAssembly;component/ResourceFile.xaml"`|  
|Файл ресурсов в подпапке указанной ссылками сборки|`"pack://application:,,,/ReferencedAssembly;component/Subfolder/ResourceFile.xaml"`|  
|Файл ресурсов в указанной ссылками сборке с несколькими версиями|`"pack://application:,,,/ReferencedAssembly;v1.0.0.0;component/ResourceFile.xaml"`|  
|Файл содержимого|`"pack://application:,,,/ContentFile.xaml"`|  
|Файл содержимого в подпапке|`"pack://application:,,,/Subfolder/ContentFile.xaml"`|  
|Файл исходного узла|`"pack://siteoforigin:,,,/SOOFile.xaml"`|  
|Файл исходного узла в подпапке|`"pack://siteoforigin:,,,/Subfolder/SOOFile.xaml"`|  
  
 Таблица 2 демонстрирует различные относительные pack [!INCLUDE[TLA2#tla_uri#plural](../../../../includes/tla2sharptla-urisharpplural-md.md)] , можно указывать в разметке.  
  
 Таблица 2. Относительный пакет URI типа в разметке  
  
|Файл|Относительный пакет [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)]|  
|----------|-------------------------------------------------------------------------------------------------------------------------|  
|Файл ресурсов в локальной сборке|`"/ResourceFile.xaml"`|  
|Файл ресурсов в подпапке — локальная сборка|`"/Subfolder/ResourceFile.xaml"`|  
|Файл ресурсов в указанной ссылками сборке|`"/ReferencedAssembly;component/ResourceFile.xaml"`|  
|Файл ресурсов в подпапке указанной ссылками сборки|`"/ReferencedAssembly;component/Subfolder/ResourceFile.xaml"`|  
|Файл содержимого|`"/ContentFile.xaml"`|  
|Файл содержимого в подпапке|`"/Subfolder/ContentFile.xaml"`|  
  
<a name="Using_Pack_URIs_in_Code"></a>   
### <a name="using-pack-uris-in-code"></a>Использование URI типа "pack" в коде  
 Укажите пакет [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)] в коде путем создания экземпляра <xref:System.Uri> класса и передачи [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)] в качестве параметра конструктора. Это показано в следующем примере.  
  
```csharp  
Uri uri = new Uri("pack://application:,,,/File.xaml");  
```  
  
 По умолчанию <xref:System.Uri> класс считает, что пакет [!INCLUDE[TLA2#tla_uri#plural](../../../../includes/tla2sharptla-urisharpplural-md.md)] абсолютным. Следовательно, возникает исключение при создании экземпляра класса <xref:System.Uri> класс создается с помощью относительных пакета [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)].  
  
```csharp  
Uri uri = new Uri("/File.xaml");  
```  
  
 К счастью <xref:System.Uri.%23ctor%28System.String%2CSystem.UriKind%29> перегрузки <xref:System.Uri> конструктор классов принимает параметр типа <xref:System.UriKind> чтобы можно было указать ли пакет [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)] является абсолютным или относительным.  
  
```csharp  
// Absolute URI (default)  
Uri absoluteUri = new Uri("pack://application:,,,/File.xaml", UriKind.Absolute);  
// Relative URI  
Uri relativeUri = new Uri("/File.xaml",   
                        UriKind.Relative);  
```  
  
 Следует указать только <xref:System.UriKind.Absolute> или <xref:System.UriKind.Relative> когда вы будете уверены, что указанный пакет [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)] — одно из них. Если вы не знаете тип пакета [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)] , например, если пользователь вводит пакет, используемый [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)] во время выполнения, используйте <xref:System.UriKind.RelativeOrAbsolute> вместо этого.  
  
```csharp  
// Relative or Absolute URI provided by user via a text box  
TextBox userProvidedUriTextBox = new TextBox();  
Uri uri = new Uri(userProvidedUriTextBox.Text, UriKind.RelativeOrAbsolute);  
```  
  
 Таблице 3 показаны различные относительные pack [!INCLUDE[TLA2#tla_uri#plural](../../../../includes/tla2sharptla-urisharpplural-md.md)] , можно указать в коде с помощью <xref:System.Uri?displayProperty=nameWithType>.  
  
 Таблица 3. Абсолютный пакет URI типа в коде  
  
|Файл|Абсолютный пакет [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)]|  
|----------|-------------------------------------------------------------------------------------------------------------------------|  
|Файл ресурсов — локальная сборка|`Uri uri = new Uri("pack://application:,,,/ResourceFile.xaml", UriKind.Absolute);`|  
|Файл ресурсов в подпапке — локальная сборка|`Uri uri = new Uri("pack://application:,,,/Subfolder/ResourceFile.xaml", UriKind.Absolute);`|  
|Файл ресурсов — указанная ссылками сборка|`Uri uri = new Uri("pack://application:,,,/ReferencedAssembly;component/ResourceFile.xaml", UriKind.Absolute);`|  
|Файл ресурсов в подпапке указанной ссылками сборки|`Uri uri = new Uri("pack://application:,,,/ReferencedAssembly;component/Subfolder/ResourceFile.xaml", UriKind.Absolute);`|  
|Файл ресурсов в указанной ссылками сборке с несколькими версиями|`Uri uri = new Uri("pack://application:,,,/ReferencedAssembly;v1.0.0.0;component/ResourceFile.xaml", UriKind.Absolute);`|  
|Файл содержимого|`Uri uri = new Uri("pack://application:,,,/ContentFile.xaml", UriKind.Absolute);`|  
|Файл содержимого в подпапке|`Uri uri = new Uri("pack://application:,,,/Subfolder/ContentFile.xaml", UriKind.Absolute);`|  
|Файл исходного узла|`Uri uri = new Uri("pack://siteoforigin:,,,/SOOFile.xaml", UriKind.Absolute);`|  
|Файл исходного узла в подпапке|`Uri uri = new Uri("pack://siteoforigin:,,,/Subfolder/SOOFile.xaml", UriKind.Absolute);`|  
  
 Таблица 4 демонстрирует различные относительные pack [!INCLUDE[TLA2#tla_uri#plural](../../../../includes/tla2sharptla-urisharpplural-md.md)] , можно указать в коде с помощью <xref:System.Uri?displayProperty=nameWithType>.  
  
 Таблица 4. Относительный пакет URI типа в коде  
  
|Файл|Относительный пакет [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)]|  
|----------|-------------------------------------------------------------------------------------------------------------------------|  
|Файл ресурсов — локальная сборка|`Uri uri = new Uri("/ResourceFile.xaml", UriKind.Relative);`|  
|Файл ресурсов в подпапке — локальная сборка|`Uri uri = new Uri("/Subfolder/ResourceFile.xaml", UriKind.Relative);`|  
|Файл ресурсов — указанная ссылками сборка|`Uri uri = new Uri("/ReferencedAssembly;component/ResourceFile.xaml", UriKind.Relative);`|  
|Файл ресурсов в подпапке — указанная ссылками сборка|`Uri uri = new Uri("/ReferencedAssembly;component/Subfolder/ResourceFile.xaml", UriKind.Relative);`|  
|Файл содержимого|`Uri uri = new Uri("/ContentFile.xaml", UriKind.Relative);`|  
|Файл содержимого в подпапке|`Uri uri = new Uri("/Subfolder/ContentFile.xaml", UriKind.Relative);`|  
  
<a name="Common_Pack_URI_Scenarios"></a>   
### <a name="common-pack-uri-scenarios"></a>Типичные сценарии URI типа "pack"  
 Предыдущих разделах обсуждались способы создания пакета [!INCLUDE[TLA2#tla_uri#plural](../../../../includes/tla2sharptla-urisharpplural-md.md)] для идентификации ресурсов, содержимого и файлы исходного узла. В [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)], эти конструкции используются различными способами, и в следующих разделах описаны некоторые общие способы использования.  
  
<a name="Specifying_the_UI_to_Show_when_an_Application_Starts"></a>   
#### <a name="specifying-the-ui-to-show-when-an-application-starts"></a>Указание пользовательского интерфейса для отображения при запуске приложения  
 <xref:System.Windows.Application.StartupUri%2A> Указывает первый [!INCLUDE[TLA2#tla_ui](../../../../includes/tla2sharptla-ui-md.md)] должна отображаться при [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)] приложение запускается. Для автономных приложений [!INCLUDE[TLA2#tla_ui](../../../../includes/tla2sharptla-ui-md.md)] может быть окном, как показано в следующем примере.  
  
 [!code-xaml[PackURIOverviewSnippets#StartupUriWindow](~/samples/snippets/csharp/VS_Snippets_Wpf/PackURIOverviewSnippets/CS/Copy of App.xaml#startupuriwindow)]  
  
 Автономные приложения и [!INCLUDE[TLA#tla_xbap#plural](../../../../includes/tlasharptla-xbapsharpplural-md.md)] можно также указать страницу в качестве начального пользовательского интерфейса, как показано в следующем примере.  
  
 [!code-xaml[PackURIOverviewSnippets#StartupUriPage](~/samples/snippets/csharp/VS_Snippets_Wpf/PackURIOverviewSnippets/CS/App.xaml#startupuripage)]  
  
 Если приложение — это автономное приложение, и страница указана с <xref:System.Windows.Application.StartupUri%2A>, [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)] открывает <xref:System.Windows.Navigation.NavigationWindow> для размещения страницы. Для [!INCLUDE[TLA2#tla_xbap#plural](../../../../includes/tla2sharptla-xbapsharpplural-md.md)], страница будет отображена в браузере основного приложения.  
  
<a name="Navigating_to_a_Page"></a>   
#### <a name="navigating-to-a-page"></a>Переход на страницу  
 В следующем примере показано, как перейти на какую-либо страницу.  
  
 [!code-xaml[NavigationOverviewSnippets#HyperlinkXAML1](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/PageWithHyperlink.xaml#hyperlinkxaml1)]  
[!code-xaml[NavigationOverviewSnippets#HyperlinkXAML2](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/PageWithHyperlink.xaml#hyperlinkxaml2)]  
[!code-xaml[NavigationOverviewSnippets#HyperlinkXAML3](~/samples/snippets/csharp/VS_Snippets_Wpf/NavigationOverviewSnippets/CSharp/PageWithHyperlink.xaml#hyperlinkxaml3)]  
  
 Дополнительные сведения о различных способах перехода в [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)], см. в разделе [Общие сведения о переходах](navigation-overview.md).  
  
<a name="Specifying_a_Window_Icon"></a>   
#### <a name="specifying-a-window-icon"></a>Указание значка окна  
 В следующем примере показано использование URI для указания значка окна.  
  
 [!code-xaml[WindowIconSnippets#WindowIconSetXAML](~/samples/snippets/xaml/VS_Snippets_Wpf/WindowIconSnippets/XAML/MainWindow.xaml#windowiconsetxaml)]  
  
 Дополнительные сведения см. в разделе <xref:System.Windows.Window.Icon%2A>.  
  
<a name="Loading_Image__Audio__and_Video_Files"></a>   
#### <a name="loading-image-audio-and-video-files"></a>Загрузка файлов изображения, аудио и видео файлов  
 [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)] позволяет приложениям использовать разнообразные типы носителей, все из которых можно определить и загрузить с помощью пакета [!INCLUDE[TLA2#tla_uri#plural](../../../../includes/tla2sharptla-urisharpplural-md.md)], как показано в следующих примерах.  
  
 [!code-xaml[MediaPlayerVideoSample#VideoPackURIAtSOO](~/samples/snippets/csharp/VS_Snippets_Wpf/MediaPlayerVideoSample/CS/HomePage.xaml#videopackuriatsoo)]  
  
 [!code-xaml[MediaPlayerAudioSample#AudioPackURIAtSOO](~/samples/snippets/csharp/VS_Snippets_Wpf/MediaPlayerAudioSample/CS/HomePage.xaml#audiopackuriatsoo)]  
  
 [!code-xaml[ImageSample#ImagePackURIContent](~/samples/snippets/csharp/VS_Snippets_Wpf/ImageSample/CS/HomePage.xaml#imagepackuricontent)]  
  
 Дополнительные сведения о работе с мультимедийным содержимым см. в разделе [графика и мультимедиа](../graphics-multimedia/index.md).  
  
<a name="Loading_a_Resource_Dictionary_from_the_Site_of_Origin"></a>   
#### <a name="loading-a-resource-dictionary-from-the-site-of-origin"></a>Загрузка словаря ресурсов с исходного узла  
 Словари ресурсов (<xref:System.Windows.ResourceDictionary>) можно использовать для поддержки тем приложения. Одним из способов создания тем и управления ими является создание нескольких тем в качестве словарей ресурсов, расположенных в исходном узле приложения. Это позволяет добавлять и обновлять темы без повторной компиляции и развертывания приложения. Словари ресурсов можно определить и загрузить с помощью пакета [!INCLUDE[TLA2#tla_uri#plural](../../../../includes/tla2sharptla-urisharpplural-md.md)], как показано в следующем примере.  
  
 [!code-xaml[ResourceDictionarySnippets#ResourceDictionaryPackURI](~/samples/snippets/csharp/VS_Snippets_Wpf/ResourceDictionarySnippets/CS/App.xaml#resourcedictionarypackuri)]  
  
 Обзор тем в [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)], см. в разделе [Стилизация и использование шаблонов](../controls/styling-and-templating.md).  
  
## <a name="see-also"></a>См. также

- [Ресурсы, Содержимое и Файлы данных WPF-приложения](wpf-application-resource-content-and-data-files.md)
