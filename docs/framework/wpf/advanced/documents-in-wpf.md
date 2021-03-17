---
title: Документы в WPF
ms.date: 03/30/2017
helpviewer_keywords:
- documents [WPF], packaging
- documents [WPF], text layout
- documents [WPF], XPS
- 'XPS documents [WPF], , '
- documents [WPF], controls
- documents [WPF], types of
- documents [WPF], browser-viewable
ms.assetid: 6e8db7bc-050a-4070-aa72-bb8c46e87ff8
ms.openlocfilehash: b4057f54934fb5c7c9bb3d4fb97fe8e197e324ad
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59313961"
---
# <a name="documents-in-wpf"></a>Документы в WPF
[!INCLUDE[TLA#tla_winclient](../../../../includes/tlasharptla-winclient-md.md)] предлагает широкий диапазон свойств документа, которые позволяют создавать содержимое высокого качества, который позволяет проще доступа и чтения, чем в предыдущих поколениях [!INCLUDE[TLA#tla_mswin](../../../../includes/tlasharptla-mswin-md.md)]. В дополнение к расширенным возможностям и повышенному качеству [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] предоставляет интегрированные службы для отображения, упаковки и обеспечения безопасности документов. В этом разделе содержатся вводные сведения о типах и упаковке документов [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)].  

<a name="types_of_documents"></a>   
## <a name="types-of-documents"></a>Типы документов  
 [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] разделяет документы на две основные категории на основе их предполагаемого использования; Эти категории документов называются «документы фиксированного формата» и «документы нефиксированного формата.»  
  
 Документы фиксированного формата предназначены для сфер применения, требующих точного представления [!INCLUDE[TLA#tla_wys](../../../../includes/tlasharptla-wys-md.md)] независимо от используемого дисплея или принтера. Документы фиксированного формата используются в компьютерной верстке, текстовой обработке и макетах форм, где строгое соответствие дизайну исходной страницы имеет критическое значение. При использовании такого макета документ фиксированного формата сохраняет точное расположение элементов содержимого независимо от используемого устройства изображения или печати. Так, страница документа фиксированного формата, отображаемая на дисплее 96 точек на дюйм, будет совершенно одинаково отображаться на лазерном принтере 600 точек на дюйм и фотонаборной машине 4800 точек на дюйм. Макет страницы остается неизменным во всех случаях, хотя качество документа повышается с учетом возможностей устройства.  
  
 Для сравнения: документы нефиксированного формата предназначены для повышения удобства просмотра и чтения; их лучше всего использовать, когда в работе с документом важнее всего удобство чтения. Вместо того чтобы использовать какой-либо определенный макет, документы нефиксированного формата динамически корректируют и перемещают содержимое с учетом переменных времени выполнения, таких как размер окна, разрешение устройства и дополнительные пользовательские настройки. Веб-страница — это простой пример документа нефиксированного формата, содержимое на которой динамически форматируется, чтобы уместиться в окне. Документы нефиксированного формата оптимизируют просмотр и чтение для пользователя в зависимости от среды выполнения. Например, один и тот же документ нефиксированного формата будет динамически переформатирован, чтобы обеспечить оптимальную читаемость на дисплее высокого разрешения 19 дюймов или небольшом экране PDA размером 2 x 3 дюйма. Кроме того, документы нефиксированного формата имеют несколько встроенных возможностей, включая поиск, режимы просмотра, оптимизирующие читаемость, и возможность менять размер и внешний вид шрифта.  См. иллюстрации, примеры и подробное описание документов нефиксированного формата в разделе [Общие сведения о документах нефиксированного формата](flow-document-overview.md).  
  
<a name="document_viewer"></a>   
## <a name="document-controls-and-text-layout"></a>Элементы управления документами и макеты текста  
 .NET Framework предоставляет набор встроенных элементов управления, которые упрощают использование документы фиксированного формата, документы нефиксированного формата и основного текста в приложении.  Отображение содержимого документа фиксированного поддерживается при использовании <xref:System.Windows.Controls.DocumentViewer> элемента управления.  Отображение содержимого документа нефиксированного поддерживается трех различных элементов управления: <xref:System.Windows.Controls.FlowDocumentReader>, <xref:System.Windows.Controls.FlowDocumentPageViewer>, и <xref:System.Windows.Controls.FlowDocumentScrollViewer> которые соответствуют разным пользовательским сценариям (см. разделы ниже).  Другие элементы управления [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] предоставляют упрощенную разметку для стандартных способов использования текста (см. раздел [Текст в пользовательском интерфейсе](#text_in_the_user_interface) ниже).  
  
### <a name="fixed-document-control---documentviewer"></a>Элемент управления документом фиксированного формата DocumentViewer  
 <xref:System.Windows.Controls.DocumentViewer> Элемент управления предназначен для отображения <xref:System.Windows.Documents.FixedDocument> содержимого. <xref:System.Windows.Controls.DocumentViewer> Управления предоставляет интуитивно понятный пользовательский интерфейс, который предоставляет встроенную поддержку для общих операций, включая вывод на печать, копирование в буфер обмена, масштабирование и возможности поиска текста. Элемент управления предоставляет доступ к страницам содержимого через знакомый механизм прокрутки. Как и все [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] элементов управления, <xref:System.Windows.Controls.DocumentViewer> поддерживает полное или частичное изменение стиля, который включает элемент управления можно интегрировать в практически любое приложение или среду.  
  
 <xref:System.Windows.Controls.DocumentViewer> предназначен для отображения содержимого в режиме только для чтения; редактирование и изменение содержимого не поддерживается и не поддерживается.  
  
<a name="flow_document"></a>   
### <a name="flow-document-controls"></a>Элементы управления документа нефиксированного формата  
 **Примечание.** Дополнительные сведения о функциях документов нефиксированного формата и способах их создания см. в разделе [Общие](flow-document-overview.md).  
  
 Отображение содержимого документа нефиксированного поддерживается три элемента управления: <xref:System.Windows.Controls.FlowDocumentReader>, <xref:System.Windows.Controls.FlowDocumentPageViewer>, и <xref:System.Windows.Controls.FlowDocumentScrollViewer>.  
  
#### <a name="flowdocumentreader"></a>FlowDocumentReader  
 <xref:System.Windows.Controls.FlowDocumentReader> включает функции, которые позволяют пользователю динамически переключаться между разными режимами просмотра, включая постраничный (страницы в a-time), две страницы в раз (книжный формат) режиме непрерывной прокрутки (без дна) и режим просмотра.  Дополнительные сведения об этих режимах просмотра см. в разделе <xref:System.Windows.Controls.FlowDocumentReaderViewingMode>.  Если возможность динамически переключаться между режимами просмотра не требуется <xref:System.Windows.Controls.FlowDocumentPageViewer> и <xref:System.Windows.Controls.FlowDocumentScrollViewer> предоставляют облегченные средства просмотра содержимого, исправленных в определенном режиме просмотра.  
  
#### <a name="flowdocumentpageviewer-and-flowdocumentscrollviewer"></a>FlowDocumentPageViewer и FlowDocumentScrollViewer  
 <xref:System.Windows.Controls.FlowDocumentPageViewer> Отображает содержимое в страницы во время режима просмотра, а <xref:System.Windows.Controls.FlowDocumentScrollViewer> отображает содержимое в режиме непрерывной прокрутки.  Оба <xref:System.Windows.Controls.FlowDocumentPageViewer> и <xref:System.Windows.Controls.FlowDocumentScrollViewer> зафиксированы в определенном режиме просмотра. Сравнить с <xref:System.Windows.Controls.FlowDocumentReader>, которое включает функции, которые позволяют пользователю динамически переключаться между разными режимами просмотра (предоставленный <xref:System.Windows.Controls.FlowDocumentReaderViewingMode> перечисления), однако является более ресурсоемким, чем <xref:System.Windows.Controls.FlowDocumentPageViewer> или <xref:System.Windows.Controls.FlowDocumentScrollViewer>.  
  
 По умолчанию вертикальная полоса прокрутки отображается всегда, а горизонтальная полоса прокрутки становится видимой при необходимости. Значение по умолчанию [!INCLUDE[TLA2#tla_ui](../../../../includes/tla2sharptla-ui-md.md)] для <xref:System.Windows.Controls.FlowDocumentScrollViewer> не включает панель инструментов; Однако <xref:System.Windows.Controls.FlowDocumentScrollViewer.IsToolBarVisible%2A> свойство может использоваться для включения встроенной панели инструментов.  
  
<a name="text_in_the_user_interface"></a>   
### <a name="text-in-the-user-interface"></a>Текст в пользовательском интерфейсе  
 Текст можно добавлять не только в документы, но и использовать в интерфейсе приложений, например в формах. [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] содержит несколько элементов управления для рисования текста на экране. Каждый элемент управления предназначен для своего сценария и имеет собственный список функций и ограничений. В общем случае <xref:System.Windows.Controls.TextBlock> элемент должен использоваться при необходимости, например короткого предложения в ограниченная поддержка текста [!INCLUDE[TLA#tla_ui](../../../../includes/tlasharptla-ui-md.md)]. <xref:System.Windows.Controls.Label> может использоваться, если требуется Минимальная текстовая поддержка. Дополнительные сведения см. в разделе [Общие сведения о классе TextBlock](../controls/textblock-overview.md).  
  
<a name="packaging"></a>   
## <a name="document-packaging"></a>Упаковка документов  
 <xref:System.IO.Packaging> [!INCLUDE[TLA2#tla_api#plural](../../../../includes/tla2sharptla-apisharpplural-md.md)] Предоставляет эффективные средства для организации данных приложения, содержимого документов и связанных ресурсов в одном контейнере, который обеспечивает простой доступ, переносимость и легко распространять. ZIP-файл является примером <xref:System.IO.Packaging.Package> может хранить несколько объектов как единое целое. Упаковка [!INCLUDE[TLA2#tla_api#plural](../../../../includes/tla2sharptla-apisharpplural-md.md)] предоставления по умолчанию <xref:System.IO.Packaging.ZipPackage> реализации, разработанные с применением стандартом Open Packaging Conventions с архитектурой файлов XML и ZIP. [!INCLUDE[TLA2#tla_api#plural](../../../../includes/tla2sharptla-apisharpplural-md.md)] упаковки [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] упрощает создание пакетов, хранение в них объектов и осуществление доступа к таким объектам. Объект, хранящийся в <xref:System.IO.Packaging.Package> называется <xref:System.IO.Packaging.PackagePart> («часть»). Пакеты также могут включать подписанные цифровые сертификаты, с помощью которых можно идентифицировать создателя части и убедиться, что содержимое пакета не было изменено.  Пакеты также включают <xref:System.IO.Packaging.PackageRelationship> функция, которая позволяет добавил в пакет и связанный с определенными частями, не меняя содержимое существующих частей дополнительные данные.  Службы пакета также поддерживают [!INCLUDE[TLA#tla_rm](../../../../includes/tlasharptla-rm-md.md)].  
  
 Архитектура пакета [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] лежит в основе ряда ключевых технологий:  
  
-   [!INCLUDE[TLA2#tla_xps](../../../../includes/tla2sharptla-xps-md.md)] документы, удовлетворяющие [!INCLUDE[TLA#tla_xps](../../../../includes/tlasharptla-xps-md.md)].  
  
-   Документы открытого XML-формата Microsoft Office "12" (.docx).  
  
-   Пользовательские форматы хранения для собственного приложения.  
  
 В зависимости от API упаковки, <xref:System.Windows.Xps.Packaging.XpsDocument> разработан специально для хранения [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] документов с фиксированным содержимым. <xref:System.Windows.Xps.Packaging.XpsDocument> Является полностью автономным документом, который можно открыть в средстве просмотра, отображаются в <xref:System.Windows.Controls.DocumentViewer> элемента управления, направляться в очередь печати или вывести непосредственно на [!INCLUDE[TLA2#tla_xps](../../../../includes/tla2sharptla-xps-md.md)]-совместимого принтера.  
  
 Следующие разделы содержат дополнительные сведения о <xref:System.IO.Packaging.Package> и <xref:System.Windows.Xps.Packaging.XpsDocument> [!INCLUDE[TLA2#tla_api#plural](../../../../includes/tla2sharptla-apisharpplural-md.md)] в состав [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)].  
  
<a name="packages"></a>   
### <a name="package-components"></a>Компоненты пакета  
 Интерфейсы API упаковки [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] позволяют упорядочить данные и документы приложения в единый портативный блок. ZIP-файл является одним из наиболее распространенных типов пакетов и типом пакета по умолчанию, предоставляемым [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)].  <xref:System.IO.Packaging.Package> сам является абстрактным классом, из которого <xref:System.IO.Packaging.ZipPackage> реализуется с помощью открытых стандартных архитектуру файл XML и ZIP.  <xref:System.IO.Packaging.Package.Open%2A> Использует метод <xref:System.IO.Packaging.ZipPackage> для создания и использования ZIP-файлов по умолчанию. Пакет может содержать три основных типа элементов:  
  
|||  
|-|-|  
|<xref:System.IO.Packaging.PackagePart>|Содержимое приложения, данные, документы и файлы ресурсов.|  
|<xref:System.IO.Packaging.PackageDigitalSignature>|[Сертификат X.509] для идентификации, аутентификации и проверки.|  
|<xref:System.IO.Packaging.PackageRelationship>|Добавленные сведения о пакете или определенной части.|  
  
<a name="PackageParts"></a>   
#### <a name="packageparts"></a>PackageParts  
 Объект <xref:System.IO.Packaging.PackagePart> («часть») — это абстрактный класс, который ссылается на объект, хранящийся в <xref:System.IO.Packaging.Package>. В ZIP-файле части пакета соответствуют отдельным файлам, хранящимся в ZIP-файле.  <xref:System.IO.Packaging.ZipPackagePart> предоставляет реализацию по умолчанию для сериализуемых объектов, хранящихся в <xref:System.IO.Packaging.ZipPackage>.  Как и в файловой системе, части, которые содержатся в пакете, хранятся в иерархическом каталоге или организованы по папкам.  С помощью [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] API упаковки приложений можно записать, хранить и считывать несколько <xref:System.IO.Packaging.PackagePart> объекты, используя один контейнер ZIP-файла.  
  
<a name="PackageDigitalSignatures"></a>   
#### <a name="packagedigitalsignatures"></a>PackageDigitalSignatures  
 В целях безопасности <xref:System.IO.Packaging.PackageDigitalSignature> («цифровая подпись») можно связать с частями в составе пакета. Объект <xref:System.IO.Packaging.PackageDigitalSignature> включает сертификат [509], предоставляет две функции:  
  
1. Идентификация и проверка подлинности создателя части.  
  
2. Проверка, не была ли часть изменена.  
  
 Цифровая подпись не защищает часть от изменения, но проверка цифровой подписи завершится ошибкой, если часть изменяется каким-либо образом. В таком случае приложение может предпринять соответствующие действия, например не допустить открытия части или уведомить пользователя об изменении (и, следовательно, ненадежности) части.  
  
<a name="PackageRelationships"></a>   
#### <a name="packagerelationships"></a>PackageRelationships  
 Объект <xref:System.IO.Packaging.PackageRelationship> («отношение») предоставляет механизм для связи дополнительной информации с фрагментом внутри пакета или пакета. Отношение — это возможность на уровне пакета, позволяющая связывать дополнительную информацию с частью, не меняя фактического содержимого части. Вставлять новые данные непосредственно в содержимое части, как правило, нецелесообразно:  
  
-   Фактический тип части и схема содержимого неизвестны.  
  
-   Даже если эти параметры известны, схема содержимого может не обеспечивать средства для добавления новых данных.  
  
-   Часть может быть защищена от изменений цифровой подписью или шифрованием.  
  
 Отношения пакета предоставляют видимые средства добавления дополнительной информации в отдельные части или весь пакет и создания соответствующих связей между этой информацией и объектами. Отношения пакетов используются для решения двух основных задач:  
  
1. Определение отношений зависимости между частями.  
  
2. Определение информационных отношений, добавляющих примечания или другие данные, связанные с частью.  
  
 Объект <xref:System.IO.Packaging.PackageRelationship> предоставляет средства быстрого и удобного определения зависимостей и добавления других сведений, связанных с частью пакета или пакет в целом.  
  
<a name="Dependency_Relationships"></a>   
##### <a name="dependency-relationships"></a>Отношения зависимости  
 Отношения зависимости используются для описания зависимостей между частями. Например, пакет может содержать HTML-часть, которая включает один или несколько тегов изображений \<img>. Теги изображений относятся к изображениям, которые хранятся как части внутри пакета или вне его (например, части, доступные через Интернет). Создание <xref:System.IO.Packaging.PackageRelationship> связанный с файлом HTML, делает обнаружение и доступ к зависимые ресурсы быстро и легко. Браузер или приложение средства просмотра может осуществлять прямой доступ к отношениям частей и сразу приступать к сборке зависимых ресурсов, даже не зная схемы и не выполняя синтаксического анализа документа.  
  
<a name="Information_Relationships"></a>   
##### <a name="information-relationships"></a>Информационные отношения  
 Аналогичную примечанию или заметке, <xref:System.IO.Packaging.PackageRelationship> также может использоваться для хранения других типов данных, которые будут связаны с частью без необходимости фактического изменения содержимого части.  
  
<a name="XPS_Documents"></a>   
## <a name="xps-documents"></a>XPS-документы  
 [!INCLUDE[TLA#tla_xps](../../../../includes/tlasharptla-xps-md.md)] документ является пакет, содержащий один или несколько фиксированных документов и все ресурсы и сведения, необходимые для подготовки к просмотру.  [!INCLUDE[TLA2#tla_xps](../../../../includes/tla2sharptla-xps-md.md)] также является собственным [!INCLUDE[TLA#tla_winvista](../../../../includes/tlasharptla-winvista-md.md)] формат файла очереди печати.  <xref:System.Windows.Xps.Packaging.XpsDocument> Хранится в стандартном наборе данных ZIP и может включать комбинацию XML и двоичных компонентов, таких как файлы изображений и шрифтов. [PackageRelationships](#PackageRelationships) используются для определения зависимостей между содержимым и ресурсами, необходимыми для полного отображения документа.  <xref:System.Windows.Xps.Packaging.XpsDocument> Подход обеспечивает единый, высококачественный документ решение, которое поддерживает многократного использования:  
  
-   Чтение, запись и хранение содержимого и ресурсов документов фиксированного формата в одном портативном документе с возможностью удобного распространения.  
  
-   Отображение документов в приложении средства просмотра [!INCLUDE[TLA2#tla_xps](../../../../includes/tla2sharptla-xps-md.md)].  
  
-   Вывод документов в собственном формате вывода в очередь на печать [!INCLUDE[TLA#tla_winvista](../../../../includes/tlasharptla-winvista-md.md)].  
  
-   Перенаправление документов непосредственно на совместимый с [!INCLUDE[TLA2#tla_xps](../../../../includes/tla2sharptla-xps-md.md)] принтер.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Documents.FixedDocument>
- <xref:System.Windows.Documents.FlowDocument>
- <xref:System.Windows.Xps.Packaging.XpsDocument>
- <xref:System.IO.Packaging.ZipPackage>
- <xref:System.IO.Packaging.ZipPackagePart>
- <xref:System.IO.Packaging.PackageRelationship>
- <xref:System.Windows.Controls.DocumentViewer>
- [Текста](optimizing-performance-text.md)
- [Общие сведения о документах нефиксированного формата](flow-document-overview.md)
- [Общие сведения о печати](printing-overview.md)
- [Сериализация и хранение документов](document-serialization-and-storage.md)
