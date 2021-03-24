---
title: Безопасность (WPF)
ms.date: 03/30/2017
helpviewer_keywords:
- XAML files [WPF], sandbox behavior
- browser-hosted application security [WPF]
- application security [WPF]
- navigation security [WPF]
- loose XAML files [WPF], sandbox behavior
- WPF security [WPF]
- WebBrowser control [WPF], security
- feature controls [WPF], security
- XBAP security [WPF]
- Internet Explorer security settings [WPF]
ms.assetid: ee1baea0-3611-4e36-9ad6-fcd5205376fb
ms.openlocfilehash: 968913a52a1d86746498aed7c97b63594d346a31
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59313571"
---
# <a name="security-wpf"></a>Безопасность (WPF)
<a name="introduction"></a> При разработке Windows Presentation Foundation (WPF) автономных приложений и приложений, размещенных в веб-браузере, необходимо учитывать модель безопасности. WPF Автономные приложения выполняются с неограниченными разрешениями ( [!INCLUDE[TLA2#tla_cas](../../../includes/tla2sharptla-cas-md.md)] **FullTrust** набор разрешений), если развертываются с помощью установщика Windows (MSI), XCopy или [!INCLUDE[TLA2#tla_clickonce](../../../includes/tla2sharptla-clickonce-md.md)]. Развертывание автономных приложений WPF с частичным доверием с помощью ClickOnce не поддерживается. Тем не менее, полным доверием ведущего приложения можно создать с частичным доверием <xref:System.AppDomain> с помощью модели надстроек платформы .NET Framework. Дополнительные сведения см. в разделе [Общие сведения о надстройках WPF](./app-development/wpf-add-ins-overview.md).  
  
 WPF Браузерные приложения [!INCLUDE[TLA#tla_iegeneric](../../../includes/tlasharptla-iegeneric-md.md)] или Firefox, и может быть либо XAML-приложения браузера (XBAP) или свободными [!INCLUDE[TLA#tla_xaml](../../../includes/tlasharptla-xaml-md.md)] документов, Дополнительные сведения см. в разделе [Обзор приложений браузера XAML WPF](./app-development/wpf-xaml-browser-applications-overview.md).  
  
 WPF Браузерные приложения выполняются в песочнице с частичным доверием, по умолчанию, который ограничен по умолчанию [!INCLUDE[TLA2#tla_cas](../../../includes/tla2sharptla-cas-md.md)] **Internet** набора разрешений зоны. Это позволяет эффективно изолировать WPF Браузерные приложения от клиентского компьютера так же, что можно ожидать изолируются обычные веб-приложения. Приложение XBAP может повысить привилегии вплоть до полного доверия в зависимости от зоны безопасности URL-адреса развертывания и конфигурации безопасности клиента. Дополнительные сведения см. в разделе [Безопасность частичного доверия в WPF](wpf-partial-trust-security.md).  
  
 В этом разделе рассматривается модель безопасности для Windows Presentation Foundation (WPF) автономных приложений и приложений, размещенных в веб-браузере.  
  
 В этом разделе содержатся следующие подразделы.  
  
-   [Безопасная навигация](#SafeTopLevelNavigation)  
  
-   [Параметры безопасности программного обеспечения для просмотра веб-страниц](#InternetExplorerSecuritySettings)  
  
-   [Элемент управления WebBrowser и элементы управления функциями](#webbrowser_control_and_feature_controls)  
  
-   [Отключение сборок APTCA для клиентских приложений с частичным доверием](#APTCA)  
  
-   [Режим песочницы для свободных файлов XAML](#LooseContentSandboxing)  
  
-   [Ресурсы для разработки приложений WPF, обеспечивающих безопасность](#BestPractices)  
  
<a name="SafeTopLevelNavigation"></a>   
## <a name="safe-navigation"></a>Безопасная навигация  
 Для [!INCLUDE[TLA2#tla_xbap#plural](../../../includes/tla2sharptla-xbapsharpplural-md.md)], WPF различает два типа навигации: приложения и браузера.  
  
 *Навигация в приложении* — это навигация между элементами содержимого в пределах приложения, размещенного в браузере. *Навигация в браузере* — это навигация, изменяющая содержимое и URL-адрес расположения самого браузера. Связь между Навигация в приложении (как правило, XAML) и навигацией в браузере (как правило, HTML) показана на следующем рисунке:
  
 ![Отношение между навигации приложений и навигацией в браузере.](./media/security-wpf/application-browser-navigation-relationship.png)  
  
 Тип содержимого, которое считается безопасным для [!INCLUDE[TLA2#tla_xbap](../../../includes/tla2sharptla-xbap-md.md)] для перехода к главным образом определяется использование Навигация в приложении или в браузере.  
  
<a name="Application_Navigation_Security"></a>   
### <a name="application-navigation-security"></a>Безопасность навигации в приложениях  
 Навигация в приложении считается безопасным, если его можно с помощью пакета [!INCLUDE[TLA2#tla_uri](../../../includes/tla2sharptla-uri-md.md)], который поддерживает четыре типа содержимого:  
  
|Тип содержимого|Описание|Пример URI|  
|------------------|-----------------|-----------------|  
|Ресурс|Файлы, добавленные в проект с типом сборки **ресурсов**.|`pack://application:,,,/MyResourceFile.xaml`|  
|Content|Файлы, добавленные в проект с типом сборки **содержимого**.|`pack://application:,,,/MyContentFile.xaml`|  
|Исходный веб-сайт|Файлы, добавленные в проект с типом сборки **None**.|`pack://siteoforigin:,,,/MySiteOfOriginFile.xaml`|  
|Код приложения|Ресурсы XAML, имеющие скомпилированный код программной части.<br /><br /> -или-<br /><br /> Файлы XAML, которые добавляются в проект с типом сборки **страницы**.|`pack://application:,,,/MyResourceFile` `.xaml`|  
  
> [!NOTE]
>  Дополнительные сведения о файлах данных приложения и пакет [!INCLUDE[TLA2#tla_uri#plural](../../../includes/tla2sharptla-urisharpplural-md.md)], см. в разделе [ресурса приложения WPF, содержимое и файлы данных](./app-development/wpf-application-resource-content-and-data-files.md).  
  
 Файлы этих типов содержимого поддерживают навигацию, выполняемую пользователем или программно.  
  
-   **Навигация, выполняемая пользователем**. Пользователь выполняет переходы, щелкая <xref:System.Windows.Documents.Hyperlink> элемент.  
  
-   **Программная навигация**. Приложение выполняет переходы без участия пользователя, например, установив <xref:System.Windows.Navigation.NavigationWindow.Source%2A?displayProperty=nameWithType> свойство.  
  
<a name="Browser_Navigation_Security"></a>   
### <a name="browser-navigation-security"></a>Безопасность навигации в браузере  
 Навигация в браузере считается безопасной только при выполнении следующих условий.  
  
-   **Навигация, выполняемая пользователем**. Пользователь выполняет переходы, щелкая <xref:System.Windows.Documents.Hyperlink> элемент, расположенный в главном <xref:System.Windows.Navigation.NavigationWindow>, но не во вложенный <xref:System.Windows.Controls.Frame>.  
  
-   **Зона**. Содержимое, к которому выполняется переход, находится в Интернете или в локальной интрасети.  
  
-   **Протокол**. Используемый протокол является либо **http**, **https**, **файл**, или **mailto**.  
  
 Если [!INCLUDE[TLA2#tla_xbap](../../../includes/tla2sharptla-xbap-md.md)] пытается перейти к содержимому таким способом, который не соответствует этим условиям, <xref:System.Security.SecurityException> возникает исключение.  
  
<a name="InternetExplorerSecuritySettings"></a>   
## <a name="web-browsing-software-security-settings"></a>Параметры безопасности программного обеспечения для просмотра веб-страниц  
 Параметры безопасности компьютера определяют уровень доступа, который предоставляется программному обеспечению для просмотра веб-страниц. Веб-обозревателя включает любое приложение или компонент, который использует [WinINet](https://go.microsoft.com/fwlink/?LinkId=179379) или [UrlMon](https://go.microsoft.com/fwlink/?LinkId=179383) API, включая Internet Explorer и PresentationHost.exe.  
  
 [!INCLUDE[TLA2#tla_iegeneric](../../../includes/tla2sharptla-iegeneric-md.md)] предоставляет механизм, по которому можно настроить функции, которые разрешены для выполнения в [!INCLUDE[TLA2#tla_iegeneric](../../../includes/tla2sharptla-iegeneric-md.md)], включая следующие:  
  
-   Всему компоненты .NET  
  
-   элементы управления ActiveX и подключаемые модули;  
  
-   Загрузки  
  
-   Скрипты  
  
-   проверка подлинности пользователя.  
  
 Набор функциональных возможностей, которая может быть защищена таким образом настраивается для каждой зоны для **Internet**, **интрасети**, **Надежные узлы**, и  **Ограниченные узлы** зоны. Ниже приведена процедура для настройки параметров безопасности.  
  
1. Откройте **панель управления**.  
  
2. Нажмите кнопку **сеть и Интернет** и нажмите кнопку **обозревателя**.  
  
     Откроется диалоговое окно «Свойства веб-обозревателя».  
  
3. На **безопасности** выберите зону для настройки параметров безопасности.  
  
4. Нажмите кнопку **другой** кнопки.  
  
     **Параметры безопасности** откроется диалоговое окно, и можно настроить параметры безопасности для выбранной зоны.  
  
     ![Снимок экрана: диалоговое окно параметров безопасности.](./media/security-wpf/windows-presentation-foundation-security-settings.png)  
  
> [!NOTE]
>  К диалоговому окну "Свойства обозревателя" можно также перейти из Internet Explorer. Нажмите кнопку **средства** и нажмите кнопку **обозревателя**.  
  
 Начиная с [!INCLUDE[TLA#tla_ie7](../../../includes/tlasharptla-ie7-md.md)], включены следующие параметры безопасности специально для .NET Framework:  
  
-   **Свободный XAML**. Элементы управления ли [!INCLUDE[TLA2#tla_iegeneric](../../../includes/tla2sharptla-iegeneric-md.md)] можно переходить к и свободный [!INCLUDE[TLA2#tla_xaml](../../../includes/tla2sharptla-xaml-md.md)] файлов. (Варианты: "Включить", "Отключить" и "Запрашивать".)  
  
-   **XAML-приложения браузера**. Элементы управления ли [!INCLUDE[TLA2#tla_iegeneric](../../../includes/tla2sharptla-iegeneric-md.md)] можно перейти и запустить [!INCLUDE[TLA2#tla_xbap#plural](../../../includes/tla2sharptla-xbapsharpplural-md.md)]. (Варианты: "Включить", "Отключить" и "Запрашивать".)  
  
 По умолчанию эти параметры включены для **Internet**, **Местная интрасеть**, и **надежные сайты** зоны и отключен для **Ограниченные узлы**  зоны.  
  
<a name="Security_Settings_for_IE6_and_Below"></a>   
### <a name="security-related-wpf-registry-settings"></a>Параметры реестра WPF, связанные с безопасностью  
 Помимо параметров безопасности, доступных в окне "Свойства обозревателя", для избирательного отключения некоторых функций WPF, влияющих на безопасность, предусмотрены перечисленные далее значения реестра. Значения определяются в следующем разделе.  
  
 `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\.NETFramework\Windows Presentation Foundation\Features`  
  
 В таблице ниже перечислены возможные задаваемые значения.  
  
|Имя значения|Тип значения|Данные значения|  
|----------------|----------------|----------------|  
|XBAPDisallow|REG_DWORD|1, чтобы запретить; 0, чтобы разрешить.|  
|LooseXamlDisallow|REG_DWORD|1, чтобы запретить; 0, чтобы разрешить.|  
|WebBrowserDisallow|REG_DWORD|1, чтобы запретить; 0, чтобы разрешить.|  
|MediaAudioDisallow|REG_DWORD|1, чтобы запретить; 0, чтобы разрешить.|  
|MediaImageDisallow|REG_DWORD|1, чтобы запретить; 0, чтобы разрешить.|  
|MediaVideoDisallow|REG_DWORD|1, чтобы запретить; 0, чтобы разрешить.|  
|ScriptInteropDisallow|REG_DWORD|1, чтобы запретить; 0, чтобы разрешить.|  
  
<a name="webbrowser_control_and_feature_controls"></a>   
## <a name="webbrowser-control-and-feature-controls"></a>Элемент управления WebBrowser и элементы управления функциями  
 WPF <xref:System.Windows.Controls.WebBrowser> элемент управления может использоваться для размещения веб-содержимого. WPF <xref:System.Windows.Controls.WebBrowser> базового элемента управления WebBrowser ActiveX создает оболочку для элемента управления. WPF обеспечивает некоторую поддержку для защиты приложения при использовании WPF <xref:System.Windows.Controls.WebBrowser> управления для размещения ненадежного веб-содержимого. Тем не менее, некоторые функции безопасности должны применяться непосредственно приложениями с помощью <xref:System.Windows.Controls.WebBrowser> элемента управления. Дополнительные сведения об элементе управления WebBrowser ActiveX см. в разделе [элемента управления WebBrowser и учебники](https://go.microsoft.com/fwlink/?LinkId=179388).  
  
> [!NOTE]
>  Этот раздел также относится к <xref:System.Windows.Controls.Frame> управления, поскольку он использует <xref:System.Windows.Controls.WebBrowser> для перехода к HTML-содержимое.  
  
 Если WPF <xref:System.Windows.Controls.WebBrowser> управления используется для размещения ненадежного веб-содержимого, в приложении следует использовать с частичным доверием <xref:System.AppDomain> для изоляции кода приложения от потенциально вредоносного кода сценариев HTML. Это особенно верно в случае, если приложение взаимодействует с размещенным сценарием с помощью <xref:System.Windows.Controls.WebBrowser.InvokeScript%2A> метод и <xref:System.Windows.Controls.WebBrowser.ObjectForScripting%2A> свойство. Дополнительные сведения см. в разделе [Общие сведения о надстройках WPF](./app-development/wpf-add-ins-overview.md).  
  
 Если приложение использует WPF <xref:System.Windows.Controls.WebBrowser> элемента управления, другой способ повышения безопасности и снижения угроз, — чтобы включить элементы управления функциями Internet Explorer. Элементы управления функциями — дополнения к Internet Explorer, позволяющие администраторам и разработчикам настраивать функции Internet Explorer и приложений, на которых размещается элемент управления WebBrowser ActiveX, который WPF <xref:System.Windows.Controls.WebBrowser> оболочку управления. Элементы управления функциями можно настроить с помощью [CoInternetSetFeatureEnabled](https://go.microsoft.com/fwlink/?LinkId=179394) функции или путем изменения значений в реестре. Дополнительные сведения об элементах управления функциями см. в разделе [введение в элементы управления функциями](https://go.microsoft.com/fwlink/?LinkId=179390) и [элементы управления функциями Интернета](https://go.microsoft.com/fwlink/?LinkId=179392).  
  
 Если вы разрабатываете автономное приложение WPF, использующего WPF <xref:System.Windows.Controls.WebBrowser> элемент управления, WPF автоматически включает следующие элементы управления функциями для вашего приложения.  
  
|Элемент управления функцией|  
|---------------------|  
|FEATURE_MIME_HANDLING|  
|FEATURE_MIME_SNIFFING|  
|FEATURE_OBJECT_CACHING|  
|FEATURE_SAFE_BINDTOOBJECT|  
|FEATURE_WINDOW_RESTRICTIONS|  
|FEATURE_ZONE_ELEVATION|  
|FEATURE_RESTRICT_FILEDOWNLOAD|  
|FEATURE_RESTRICT_ACTIVEXINSTALL|  
|FEATURE_ADDON_MANAGEMENT|  
|FEATURE_HTTP_USERNAME_PASSWORD_DISABLE|  
|FEATURE_SECURITYBAND|  
|FEATURE_UNC_SAVEDFILECHECK|  
|FEATURE_VALIDATE_NAVIGATE_URL|  
|FEATURE_DISABLE_TELNET_PROTOCOL|  
|FEATURE_WEBOC_POPUPMANAGEMENT|  
|FEATURE_DISABLE_LEGACY_COMPRESSION|  
|FEATURE_SSLUX|  
  
 Поскольку эти элементы управления функциями включаются безусловно, они могут нарушать работу приложения с полным доверием. В этом случае, если нет риска безопасности для конкретного приложения и содержимого, размещенного в нем, можно отключить соответствующий элемент управления функцией.  
  
 Элементы управления функциями применяются процессом, создающим экземпляры объекта WebBrowser ActiveX. Таким образом, при создании автономного приложения, которое может переходить к ненадежному содержимому, следует рассмотреть возможность включения дополнительных элементов управления функциями.  
  
> [!NOTE]
>  Эта рекомендация основана на общих рекомендациях по безопасности узлов MSHTML и SHDOCVW. Дополнительные сведения см. в разделе [The MSHTML Host Security FAQ: Часть I из II](https://go.microsoft.com/fwlink/?LinkId=179396) и [безопасности узлов MSHTML часто задаваемые вопросы: Часть II части II](https://go.microsoft.com/fwlink/?LinkId=179415).  
  
 Для исполняемого файла можно включить следующие элементы управления функциями путем установки значения реестра равным 1.  
  
|Элемент управления функцией|  
|---------------------|  
|FEATURE_ACTIVEX_REPURPOSEDETECTION|  
|FEATURE_BLOCK_LMZ_IMG|  
|FEATURE_BLOCK_LMZ_OBJECT|  
|FEATURE_BLOCK_LMZ_SCRIPT|  
|FEATURE_RESTRICT_RES_TO_LMZ|  
|FEATURE_RESTRICT_ABOUT_PROTOCOL_IE7|  
|FEATURE_SHOW_APP_PROTOCOL_WARN_DIALOG|  
|FEATURE_LOCALMACHINE_LOCKDOWN|  
|FEATURE_FORCE_ADDR_AND_STATUS|  
|FEATURE_RESTRICTED_ZONE_WHEN_FILE_NOT_FOUND|  
  
 Для исполняемого файла можно отключить следующие элементы управления функциями путем установки значения реестра равным 0.  
  
|Элемент управления функцией|  
|---------------------|  
|FEATURE_ENABLE_SCRIPT_PASTE_URLACTION_IF_PROMPT|  
  
 При выполнении с частичным доверием [!INCLUDE[TLA#tla_xbap](../../../includes/tlasharptla-xbap-md.md)] , включает в себя WPF <xref:System.Windows.Controls.WebBrowser> контролировать [!INCLUDE[TLA#tla_iegeneric](../../../includes/tlasharptla-iegeneric-md.md)], WPF размещает элемент управления WebBrowser ActiveX в адресном пространстве процесса Internet Explorer. Поскольку элемент управления WebBrowser ActiveX размещается в [!INCLUDE[TLA2#tla_iegeneric](../../../includes/tla2sharptla-iegeneric-md.md)] процесса, все элементы управления функциями для Internet Explorer также включены для элемента управления WebBrowser ActiveX.  
  
 XBAP-приложения, выполняющиеся в Internet Explorer, также получают более высокий уровень безопасности по сравнению с обычными автономными приложениями. — Этот повышенный уровень безопасности, так как Internet Explorer и, следовательно, элемент управления WebBrowser ActiveX выполняются в защищенном режиме по умолчанию в [!INCLUDE[TLA#tla_winvista](../../../includes/tlasharptla-winvista-md.md)] и [!INCLUDE[win7](../../../includes/win7-md.md)]. Дополнительные сведения о защищенном режиме, см. в разделе [Знакомство и работа в защищенный режим Internet Explorer](https://go.microsoft.com/fwlink/?LinkId=179393).  
  
> [!NOTE]
>  При попытке запуска приложения XBAP, включающую WPF <xref:System.Windows.Controls.WebBrowser> элемента управления в Firefox в зоне Интернета <xref:System.Security.SecurityException> будет создано. Это связано с политикой безопасности WPF.  
  
<a name="APTCA"></a>   
## <a name="disabling-aptca-assemblies-for-partially-trusted-client-applications"></a>Отключение сборок APTCA для клиентских приложений с частичным доверием  
 Когда управляемые сборки устанавливаются в [!INCLUDE[TLA#tla_gac](../../../includes/tlasharptla-gac-md.md)], они становятся полностью надежными, так как пользователь должен предоставить явное разрешение на их установку. Поскольку они пользуются полным доверием, их могут использовать только полностью доверенные управляемые клиентские приложения. Чтобы разрешить частично доверенных приложений использовать их, они должны быть отмечены <xref:System.Security.AllowPartiallyTrustedCallersAttribute> (APTCA). Этим атрибутом могут быть помечены только сборки, которые были протестированы для подтверждения безопасности при выполнении в режиме частичного доверия.  
  
 Тем не менее, существует возможность сборка APTCA может представлять угрозу безопасности после установки в [!INCLUDE[TLA2#tla_gac](../../../includes/tla2sharptla-gac-md.md)]. После обнаружения уязвимости безопасности издатели сборок могут создавать обновления безопасности для решения проблем существующих установок и защиты установок, которые могут выполняться после выявления проблемы. Одним из вариантов обновления является удаление сборки, хотя это может нарушить работу других полностью доверенных клиентских приложений, использующих сборку.  
  
 WPF предоставляет механизм, по которому можно отключить сборку APTCA, для частично доверенных [!INCLUDE[TLA2#tla_xbap#plural](../../../includes/tla2sharptla-xbapsharpplural-md.md)] без удаления ЭТОЙ сборки.  
  
 Чтобы отключить сборку APTCA, необходимо создать специальный раздел реестра.  
  
 `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\.NETFramework\policy\APTCA\<AssemblyFullName>, FileVersion=<AssemblyFileVersion>`  
  
 Пример приведен ниже.  
  
 `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\.NETFramework\policy\APTCA\aptcagac, Version=1.0.0.0, Culture=neutral, PublicKeyToken=215e3ac809a0fea7, FileVersion=1.0.0.0`  
  
 Этот раздел содержит запись для сборки APTCA. Вам также потребуется создать значение в этом разделе, включающее или отключающее сборку. Ниже приведены сведения об этом значении.  
  
-   Имя значения: **APTCA_FLAG**.  
  
-   Тип значения: **REG_DWORD**.  
  
-   Данные значения: **1** для отключения; **0** для включения.  
  
 Если сборку необходимо отключить для клиентских приложений с частичным доверием, можно написать обновление, создающее раздел реестра и значение.  
  
> [!NOTE]
>  Базовые сборки .NET Framework не затрагиваются, отключив их таким образом, так как они необходимы для запуска управляемых приложений. Поддержка отключения сборок APTCA в основном ориентирована на сторонние приложения.  
  
<a name="LooseContentSandboxing"></a>   
## <a name="sandbox-behavior-for-loose-xaml-files"></a>Режим песочницы для свободных файлов XAML  
 Свободные [!INCLUDE[TLA2#tla_xaml](../../../includes/tla2sharptla-xaml-md.md)] файлы имеют только разметку XAML, не зависят от любого кода, обработчик событий или сборки приложения. Когда переход к свободным [!INCLUDE[TLA2#tla_xaml](../../../includes/tla2sharptla-xaml-md.md)] файлов осуществляется непосредственно из браузера, они загружаются в изолированной среде безопасности, в соответствии с набором разрешений зоны Интернета по умолчанию.  
  
 Тем не менее поведение безопасности отличается при свободные [!INCLUDE[TLA2#tla_xaml](../../../includes/tla2sharptla-xaml-md.md)] файлов осуществляется либо из <xref:System.Windows.Navigation.NavigationWindow> или <xref:System.Windows.Controls.Frame> в автономном приложении.  
  
 В обоих случаях свободный [!INCLUDE[TLA2#tla_xaml](../../../includes/tla2sharptla-xaml-md.md)] файла, к которому осуществляется переход, наследует разрешения от ведущего приложения. Тем не менее, это поведение может быть нежелательным с точки зрения безопасности, особенно в том случае, если свободный [!INCLUDE[TLA2#tla_xaml](../../../includes/tla2sharptla-xaml-md.md)] файл был создан небезопасной или неизвестной сущностью. Этот тип содержимого известен как *внешнее содержимое*и оба <xref:System.Windows.Controls.Frame> и <xref:System.Windows.Navigation.NavigationWindow> можно настроить, чтобы изолировать его при переходе. Изоляция достигается путем установки **SandboxExternalContent** значение true, как показано в следующих примерах для <xref:System.Windows.Controls.Frame> и <xref:System.Windows.Navigation.NavigationWindow>:  
  
 [!code-xaml[SecurityOverviewSnippets#FrameMARKUP](~/samples/snippets/csharp/VS_Snippets_Wpf/SecurityOverviewSnippets/CS/Window2.xaml#framemarkup)]  
  
 [!code-xaml[SecurityOverviewSnippets#NavigationWindowMARKUP](~/samples/snippets/csharp/VS_Snippets_Wpf/SecurityOverviewSnippets/CS/Window1.xaml#navigationwindowmarkup)]  
  
 Этот параметр позволяет загружать внешнее содержимое в процесс, который отделен от процесса, содержащего приложение. Этот процесс ограничен набором разрешений зоны Интернета по умолчанию, что эффективно изолирует его от ведущего приложения и клиентского компьютера.  
  
> [!NOTE]
>  Несмотря на то что переход к свободным [!INCLUDE[TLA2#tla_xaml](../../../includes/tla2sharptla-xaml-md.md)] файлов из любого <xref:System.Windows.Navigation.NavigationWindow> или <xref:System.Windows.Controls.Frame> в автономном приложении реализован на основе браузера WPF размещения инфраструктуры, включающей процесс PresentationHost, уровень безопасности, немного меньше, чем при загрузке содержимого непосредственно в Internet Explorer на [!INCLUDE[wiprlhext](../../../includes/wiprlhext-md.md)] и [!INCLUDE[win7](../../../includes/win7-md.md)] (которая все равно выполняется через процесс PresentationHost). Это обусловлено тем, что автономное приложение WPF, использующее веб-браузер, не предоставляет дополнительную функцию безопасности "Защищенный режим" Internet Explorer.  
  
<a name="BestPractices"></a>   
## <a name="resources-for-developing-wpf-applications-that-promote-security"></a>Ресурсы для разработки приложений WPF, обеспечивающих безопасность  
 Ниже приведены некоторые дополнительные ресурсы, помогающие при разработке WPF приложений, обеспечивающих безопасность:  
  
|Область|Ресурс|  
|----------|--------------|  
|Управляемый код|[Шаблоны и рекомендации по обеспечению безопасности приложений](https://go.microsoft.com/fwlink/?LinkId=117426)|  
|[!INCLUDE[TLA2#tla_cas](../../../includes/tla2sharptla-cas-md.md)]|[Управление доступом для кода](../misc/code-access-security.md)|  
|[!INCLUDE[TLA2#tla_clickonce](../../../includes/tla2sharptla-clickonce-md.md)]|[Развертывание и безопасность технологии ClickOnce](/visualstudio/deployment/clickonce-security-and-deployment)|  
|WPF|[Безопасность частичного доверия в WPF](wpf-partial-trust-security.md)|  
  
## <a name="see-also"></a>См. также

- [Безопасность частичного доверия в WPF](wpf-partial-trust-security.md)
- [Стратегия безопасности WPF — безопасность платформы](wpf-security-strategy-platform-security.md)
- [Стратегия безопасности WPF — проектирование безопасности](wpf-security-strategy-security-engineering.md)
- [Шаблоны и рекомендации по обеспечению безопасности приложений](https://go.microsoft.com/fwlink/?LinkId=117426)
- [Управление доступом для кода](../misc/code-access-security.md)
- [Развертывание и безопасность технологии ClickOnce](/visualstudio/deployment/clickonce-security-and-deployment)
- [Обзор XAML (WPF)](./advanced/xaml-overview-wpf.md)
