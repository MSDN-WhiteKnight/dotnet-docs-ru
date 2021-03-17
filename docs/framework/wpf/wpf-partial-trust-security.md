---
title: Безопасность частичного доверия в WPF
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- partial trust security [WPF]
- detecting permissions [WPF]
- security settings for Internet Explorer [WPF]
- partial trust applications [WPF], debugging
- permissions [WPF], managing
- debugging partial trust applications [WPF]
- permissions [WPF], detecting
- feature security requirements [WPF]
- managing permissions [WPF]
ms.assetid: ef2c0810-1dbf-4511-babd-1fab95b523b5
ms.openlocfilehash: 75ebf605e9abb844e7a713b448aefe2ec4cd1a27
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59218385"
---
# <a name="wpf-partial-trust-security"></a>Безопасность частичного доверия в WPF
<a name="introduction"></a> Как правило, интернет-приложениям следует ограничить прямой доступ к критическим системным ресурсам, чтобы избежать злонамеренного повреждения. По умолчанию [!INCLUDE[TLA#tla_html](../../../includes/tlasharptla-html-md.md)] и языки сценариев на стороне клиента не могут получить доступ к критическим системным ресурсам. Поскольку Браузерные приложения Windows Presentation Foundation (WPF) может быть запущено из браузера, они должны соответствовать аналогичному набору ограничений. Для принудительного применения этих ограничений [!INCLUDE[TLA2#tla_wpf](../../../includes/tla2sharptla-wpf-md.md)] полагается на [!INCLUDE[TLA#tla_cas](../../../includes/tlasharptla-cas-md.md)] и [!INCLUDE[TLA#tla_clickonce](../../../includes/tlasharptla-clickonce-md.md)] (см. в разделе [стратегия безопасности WPF — безопасность платформы](wpf-security-strategy-platform-security.md)). По умолчанию Браузерные приложения запрашивают зоны Интернета [!INCLUDE[TLA2#tla_cas](../../../includes/tla2sharptla-cas-md.md)] набор разрешений, независимо от того, запускаются ли они из Интернета, локальной интрасети или локального компьютера. Приложения, выполняющиеся с набором разрешений меньшим, чем полный набор, называют выполняющимися с частичным доверием.  
  
 [!INCLUDE[TLA2#tla_wpf](../../../includes/tla2sharptla-wpf-md.md)] предоставляет широкий спектр поддержки, чтобы убедиться, что число функциональных возможностей, как можно можно безопасно в режиме частичного доверия и вместе с [!INCLUDE[TLA2#tla_cas](../../../includes/tla2sharptla-cas-md.md)], обеспечивает дополнительную поддержку для программирования в режиме частичного доверия.  
  
 В этом разделе содержатся следующие подразделы.  
  
-   [Поддержка частичного доверия функциями WPF](#WPF_Feature_Partial_Trust_Support)  
  
-   [Программирование в режиме частичного доверия](#Partial_Trust_Programming)  
  
-   [Управление разрешениями](#Managing_Permissions)  
  
<a name="WPF_Feature_Partial_Trust_Support"></a>   
## <a name="wpf-feature-partial-trust-support"></a>Поддержка частичного доверия функциями WPF  
 В следующей таблице перечислены обобщенные функции Windows Presentation Foundation (WPF), которые являются безопасными для использования в пределах набора разрешений зоны Интернета.  
  
 Таблица 1. Функции WPF, являются безопасными в режиме частичного доверия  
  
|Область функции|Функция|  
|------------------|-------------|  
|Общие|Окно обозревателя<br /><br /> Доступ к исходному сайту<br /><br /> IsolatedStorage (ограничение 512 КБ)<br /><br /> Поставщики UIAutomation<br /><br /> Система команд<br /><br /> Редакторы метода ввода (IME)<br /><br /> Перо планшетного компьютера и рукописный ввод<br /><br /> Моделирование перетаскивания с помощью событий захвата и перемещения мыши<br /><br /> OpenFileDialog<br /><br /> Десериализация XAML (посредством XamlReader.Load)|  
|Веб-интеграция|Диалоговое окно загрузки браузера<br /><br /> Навигация верхнего уровня, инициированная пользователем<br /><br /> mailto:links<br /><br /> Параметры универсального идентификатора ресурса (URI)<br /><br /> HTTPWebRequest<br /><br /> Содержимое WPF, размещенное в IFRAME<br /><br /> Размещение HTML-страниц одного веб-сайта с помощью Frame<br /><br /> Размещение HTML-страниц одного веб-сайта с помощью WebBrowser<br /><br /> Веб-службы (ASMX-файлы)<br /><br /> Веб-службы (с помощью Windows Communication Foundation)<br /><br /> Скрипты<br /><br /> Модель DOM|  
|Визуальные элементы|2D- и 3D-графика<br /><br /> Анимация<br /><br /> Мультимедиа (исходный сайт и междоменные)<br /><br /> Обработка изображений/аудио/видео|  
|Чтение|FlowDocument<br /><br /> XPS-документы<br /><br /> Внедренные и системные шрифты<br /><br /> Шрифты CFF и TrueType|  
|Редактирование|Проверка орфографии<br /><br /> RichTextBox<br /><br /> Поддержка буфера обмена для обычного текста и рукописного ввода<br /><br /> Вставка, инициированная пользователем<br /><br /> Копирование выделенного содержимого|  
|Элементы управления|Общие элементы управления|  
  
 Эта таблица охватывает [!INCLUDE[TLA2#tla_wpf](../../../includes/tla2sharptla-wpf-md.md)] функции на высоком уровне. Более подробные сведения, [!INCLUDE[TLA#tla_lhsdk](../../../includes/tlasharptla-lhsdk-md.md)] задокументированы разрешения, необходимые каждому элементу в [!INCLUDE[TLA2#tla_wpf](../../../includes/tla2sharptla-wpf-md.md)]. Кроме того, следующие функции содержат более подробные сведения, касающиеся выполнения при частичном доверии, включая некоторые особые аспекты.  
  
-   [!INCLUDE[TLA2#tla_xaml](../../../includes/tla2sharptla-xaml-md.md)] (см. в разделе [Обзор XAML (WPF)](./advanced/xaml-overview-wpf.md)).  
  
-   Всплывающие окна (см. в разделе <xref:System.Windows.Controls.Primitives.Popup?displayProperty=nameWithType>).  
  
-   Перетаскивание (см. в разделе [Drag and Drop Обзор](./advanced/drag-and-drop-overview.md)).  
  
-   Буфер обмена (см. в разделе <xref:System.Windows.Clipboard?displayProperty=nameWithType>).  
  
-   Работы с образами (см. в разделе <xref:System.Windows.Controls.Image?displayProperty=nameWithType>).  
  
-   Сериализация (см. в разделе <xref:System.Windows.Markup.XamlReader.Load%2A?displayProperty=nameWithType>, <xref:System.Windows.Markup.XamlWriter.Save%2A?displayProperty=nameWithType>).  
  
-   Открыть файл-диалоговое окно (см. в разделе <xref:Microsoft.Win32.OpenFileDialog?displayProperty=nameWithType>).  
  
 В следующей таблице описываются [!INCLUDE[TLA2#tla_wpf](../../../includes/tla2sharptla-wpf-md.md)] набора разрешений зоны функции, которые не являются безопасными для выполнения в пределах Интернета.  
  
 Таблица 2. Функции WPF, не являются безопасными в режиме частичного доверия  
  
|Область функции|Функция|  
|------------------|-------------|  
|Общие|Окно (определенные приложением окна и диалоговые окна)<br /><br /> SaveFileDialog<br /><br /> Файловая система<br /><br /> Доступ к реестру<br /><br /> Перетаскивание<br /><br /> Сериализация XAML (через XamlWriter.Save)<br /><br /> Клиенты UIAutomation<br /><br /> Доступ к исходному окну (HwndHost)<br /><br /> Полная поддержка управления речью<br /><br /> Взаимодействие с Windows Forms|  
|Визуальные элементы|Эффекты для точечных рисунков<br /><br /> Кодирование изображений|  
|Редактирование|Буфер обмена формата RTF<br /><br /> Полная поддержка XAML|  
  
<a name="Partial_Trust_Programming"></a>   
## <a name="partial-trust-programming"></a>Программирование в режиме частичного доверия  
 Для [!INCLUDE[TLA2#tla_xbap](../../../includes/tla2sharptla-xbap-md.md)] приложения, код, превышающий набор разрешений по умолчанию, имеет другое поведение в зависимости от зоны безопасности. В некоторых случаях пользователь получит предупреждение при попытке установить приложение. Пользователь может выбрать продолжение или отмену установки. В следующей таблице описаны поведение приложения для каждой зоны безопасности и действия, необходимые для получения приложением полного доверия.  
  
|Зона безопасности|Поведение|Получение полного доверия|  
|-------------------|--------------|------------------------|  
|Локальный компьютер|Автоматическое получение полного доверия|Никаких действий не требуется.|  
|Интрасеть и надежные веб-сайты|Запрос полного доверия|Подпишите приложение XBAP с помощью сертификата, чтобы пользователь видел источник в запросе.|  
|Интернет|Сбой с сообщением "Доверие не оказано"|Подпишите приложение XBAP с помощью сертификата.|  
  
> [!NOTE]
>  Поведение, описанное в предыдущей таблице, относится к приложениям XBAP с полным доверием, не следующим модели доверенного развертывания ClickOnce.  
  
 В общем случае код, который может превышать допустимые разрешения, вероятнее всего, является общим кодом, который совместно используется автономными и браузерными приложениями. [!INCLUDE[TLA2#tla_cas](../../../includes/tla2sharptla-cas-md.md)] и [!INCLUDE[TLA2#tla_wpf](../../../includes/tla2sharptla-wpf-md.md)] обеспечивают несколько методик для таких случаев.  
  
<a name="Detecting_Permissions_using_CAS"></a>   
### <a name="detecting-permissions-using-cas"></a>Определение разрешений с помощью CAS  
 В некоторых случаях общий код в сборках библиотеки будет использоваться как автономными приложениями и [!INCLUDE[TLA2#tla_xbap#plural](../../../includes/tla2sharptla-xbapsharpplural-md.md)]. В этих случаях код может выполнять функции, которые могут потребовать больше разрешений, чем позволяет набор разрешений, присвоенный приложению. Приложение может определять, независимо от того, имеется ли он имеет определенное разрешение с помощью системы безопасности Microsoft .NET Framework. В частности, его можно проверить на наличие определенного разрешения, вызвав <xref:System.Security.CodeAccessPermission.Demand%2A> метод экземпляра нужного разрешения. Это показано в следующем примере, который содержит код, запрашивающий возможность сохранить файл на локальный диск.  
  
 [!code-csharp[PartialTrustSecurityOverviewSnippets#DetectPermsCODE1](~/samples/snippets/csharp/VS_Snippets_Wpf/PartialTrustSecurityOverviewSnippets/CSharp/FileHandling.cs#detectpermscode1)]
 [!code-vb[PartialTrustSecurityOverviewSnippets#DetectPermsCODE1](~/samples/snippets/visualbasic/VS_Snippets_Wpf/PartialTrustSecurityOverviewSnippets/VisualBasic/FileHandling.vb#detectpermscode1)]  
[!code-csharp[PartialTrustSecurityOverviewSnippets#DetectPermsCODE2](~/samples/snippets/csharp/VS_Snippets_Wpf/PartialTrustSecurityOverviewSnippets/CSharp/FileHandling.cs#detectpermscode2)]
[!code-vb[PartialTrustSecurityOverviewSnippets#DetectPermsCODE2](~/samples/snippets/visualbasic/VS_Snippets_Wpf/PartialTrustSecurityOverviewSnippets/VisualBasic/FileHandling.vb#detectpermscode2)]  
  
 Если приложение не имеет нужных разрешений, вызов <xref:System.Security.CodeAccessPermission.Demand%2A> создаст исключение безопасности. В противном случае разрешение будет предоставлено. `IsPermissionGranted` Инкапсулирует это поведение и возвращает `true` или `false` соответствующим образом.  
  
<a name="Graceful_Degradation_of_Functionality"></a>   
### <a name="graceful-degradation-of-functionality"></a>Постепенное снижение функциональности  
 Возможность обнаружения у кода разрешений на выполнение действия представляет интерес для кода, который может выполняться из разных зон. Обнаружение зоны — это один из аспектов, однако рекомендуется по возможности предоставить пользователю альтернативу. Например, приложение с полным доверием обычно позволяет пользователям создавать файлы в любом расположении, тогда как приложение с частичным доверием может создавать файлы только в изолированном хранилище. Если код для создания файла существует в сборке, которая совместно используется приложениями с полным доверием (автономными) и приложениями с частичным доверием (размещенными в браузере), и оба приложения должны обеспечивать функцию создания файлов пользователем, общий код должен определить, выполняется ли он в режиме частичного или полного доверия перед созданием файла в соответствующем расположении. Оба варианта демонстрируются в следующем коде.  
  
 [!code-csharp[PartialTrustSecurityOverviewSnippets#DetectPermsGracefulCODE1](~/samples/snippets/csharp/VS_Snippets_Wpf/PartialTrustSecurityOverviewSnippets/CSharp/FileHandlingGraceful.cs#detectpermsgracefulcode1)]
 [!code-vb[PartialTrustSecurityOverviewSnippets#DetectPermsGracefulCODE1](~/samples/snippets/visualbasic/VS_Snippets_Wpf/PartialTrustSecurityOverviewSnippets/VisualBasic/FileHandlingGraceful.vb#detectpermsgracefulcode1)]  
[!code-csharp[PartialTrustSecurityOverviewSnippets#DetectPermsGracefulCODE2](~/samples/snippets/csharp/VS_Snippets_Wpf/PartialTrustSecurityOverviewSnippets/CSharp/FileHandlingGraceful.cs#detectpermsgracefulcode2)]
[!code-vb[PartialTrustSecurityOverviewSnippets#DetectPermsGracefulCODE2](~/samples/snippets/visualbasic/VS_Snippets_Wpf/PartialTrustSecurityOverviewSnippets/VisualBasic/FileHandlingGraceful.vb#detectpermsgracefulcode2)]  
  
 Во многих случаях вы сможете найти альтернативу частичному доверию.  
  
 В управляемой среде, например интрасети, можно установить пользовательские управляемых инфраструктур для всех клиентов в глобальном [!INCLUDE[TLA#tla_gac](../../../includes/tlasharptla-gac-md.md)]. Эти библиотеки могут выполнять код, который требует полного доверия и можно ссылаться из приложений, которым разрешено только частичное доверие, используя <xref:System.Security.AllowPartiallyTrustedCallersAttribute> (Дополнительные сведения см. в разделе [безопасности](security-wpf.md) и [безопасность WPF Стратегия — безопасность платформы](wpf-security-strategy-platform-security.md)).  
  
<a name="Browser_Host_Detection"></a>   
### <a name="browser-host-detection"></a>Обнаружение узла браузера  
 С помощью [!INCLUDE[TLA2#tla_cas](../../../includes/tla2sharptla-cas-md.md)] для проверки разрешений является подходящим способом, когда необходимо проверить на основе отдельных разрешений. Тем не менее эта методика зависит от перехвата исключений в рамках нормальной обработки, что не рекомендуется в общем и может вызывать проблемы производительности. Вместо этого Если ваш [!INCLUDE[TLA#tla_xbap](../../../includes/tlasharptla-xbap-md.md)] выполняется только в песочнице зоны Интернета, можно использовать <xref:System.Windows.Interop.BrowserInteropHelper.IsBrowserHosted%2A?displayProperty=nameWithType> свойство, которое возвращает значение true для [!INCLUDE[TLA#tla_xbap#plural](../../../includes/tlasharptla-xbapsharpplural-md.md)].  
  
> [!NOTE]
>  <xref:System.Windows.Interop.BrowserInteropHelper.IsBrowserHosted%2A> только отличает ли приложение выполняется в браузере, не какой набор разрешений приложения, выполнив.  
  
<a name="Managing_Permissions"></a>   
## <a name="managing-permissions"></a>Управление разрешениями  
 По умолчанию [!INCLUDE[TLA2#tla_xbap#plural](../../../includes/tla2sharptla-xbapsharpplural-md.md)] с частичным доверием (набор разрешений зоны Интернета по умолчанию). Тем не менее в зависимости от требований приложения можно изменить набор разрешений по умолчанию. Например если [!INCLUDE[TLA2#tla_xbap#plural](../../../includes/tla2sharptla-xbapsharpplural-md.md)] запускается из локальной интрасети, он может воспользоваться преимуществом расширенного набора разрешений, как показано в следующей таблице.  
  
 Таблица 3. Разрешений LocalIntranet и Internet  
  
|Разрешение|Атрибут|LocalIntranet|Интернет|  
|----------------|---------------|-------------------|--------------|  
|DNS|Доступ к DNS-серверам|Да|Нет|  
|Переменные среды|Чтение|Да|Нет|  
|Диалоговые окна для работы с файлами|Открыть|Да|Да|  
|Диалоговые окна для работы с файлами|Без ограничений|Да|Нет|  
|Изолированное хранилище|Изоляция сборки по пользователю|Да|Нет|  
|Изолированное хранилище|Неизвестная изоляция|Да|Да|  
|Изолированное хранилище|Неограниченная квота для пользователя|Да|Нет|  
|Мультимедиа|Безопасные аудио-, видеоданные и изображения|Да|Да|  
|Печать|Печать по умолчанию|Да|Нет|  
|Печать|Безопасная печать|Да|Да|  
|Отражение|Вывод|Да|Нет|  
|Безопасность|Выполнение управляемого кода|Да|Да|  
|Безопасность|Утверждение предоставленных разрешений|Да|Нет|  
|Пользовательский интерфейс|Без ограничений|Да|Нет|  
|Пользовательский интерфейс|Безопасные окна верхнего уровня|Да|Да|  
|Пользовательский интерфейс|Собственный буфер обмена|Да|Да|  
|Веб-браузер|Безопасная навигация по фреймам в HTML|Да|Да|  
  
> [!NOTE]
>  Вырезание и вставка разрешены только в режиме частичного доверия при инициации пользователем.  
  
 Если вам требуется повысить уровень разрешений, необходимо изменить параметры проекта и манифест приложения ClickOnce. Дополнительные сведения см. в разделе [Общие сведения о приложениях браузера WPF XAML](./app-development/wpf-xaml-browser-applications-overview.md). Следующие документы также могут быть полезны.  
  
-   [Mage.exe (средство создания и редактирования манифеста)](../tools/mage-exe-manifest-generation-and-editing-tool.md)  
  
-   [MageUI.exe (средство создания и редактирования манифестов, графический клиент)](../tools/mageui-exe-manifest-generation-and-editing-tool-graphical-client.md)  
  
-   [Защита приложений ClickOnce](/visualstudio/deployment/securing-clickonce-applications)  
  
 Если ваш [!INCLUDE[TLA2#tla_xbap](../../../includes/tla2sharptla-xbap-md.md)] требует полного доверия, можно использовать те же средства для предоставления запрошенных разрешений. Несмотря на то что [!INCLUDE[TLA2#tla_xbap](../../../includes/tla2sharptla-xbap-md.md)] только получит полное доверие, если он установлен на локальном компьютере и запущено с локального компьютера, интрасети или с URL-адрес, который указан в браузере доверенных или разрешенных сайтов. Если приложение установлено из интрасети или с доверенного сайта, пользователь получит стандартный запрос ClickOnce, уведомляющий о повышенных разрешениях. Пользователь может выбрать продолжение или отмену установки.  
  
 Кроме того, модель доверенного развертывания ClickOnce можно использовать для полностью доверенного развертывания из любой зоны безопасности. Дополнительные сведения см. в разделе [Trusted Application Deployment Overview](/visualstudio/deployment/trusted-application-deployment-overview) и [безопасности](security-wpf.md).  
  
## <a name="see-also"></a>См. также

- [Безопасность](security-wpf.md)
- [Стратегия безопасности WPF — безопасность платформы](wpf-security-strategy-platform-security.md)
- [Стратегия безопасности WPF — проектирование безопасности](wpf-security-strategy-security-engineering.md)
