---
title: Развертывание приложений WPF
ms.date: 03/30/2017
helpviewer_keywords:
- WPF applications [WPF], deployment
- deployment [WPF], applications
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
---

# <a name="deploying-a-wpf-application-wpf"></a>Развертывание приложений WPF
После построения приложения Windows Presentation Foundation (WPF) должны быть развернуты. Windows и .NET Framework поддерживают несколько технологий развертывания. Технология развертывания, используемая для приложения WPF, зависит от типа приложения. Этот раздел содержит краткое описание каждой из технологий развертывания и их использования в сочетании с требованиями к развертыванию для каждого типа приложения WPF.  

<a name="Deployment_Technologies"></a>   
## <a name="deployment-technologies"></a>Технологии развертывания  
 Windows и .NET Framework включают несколько технологий развертывания:  
  
-   развертывание с помощью XCopy;  
  
-   [!INCLUDE[TLA2#tla_wininstall](../../../../includes/tla2sharptla-wininstall-md.md)] развертывание.  
  
-   ClickOnce развертывание.  
  
<a name="XCopy_Deployment"></a>   
### <a name="xcopy-deployment"></a>Развертывание с помощью XCopy  
 Развертывание с помощью XCopy означает использование программы командной строки XCopy для копирования файлов из одного расположения в другое. Развертывание с помощью XСopy подходит для указанных ниже случаев.  
  
-   Приложение является самодостаточным. Для его запуска не требуется обновлять клиент.  
  
-   Файлы приложения должны быть перемещены из одного расположения в другое, например из места сборки (локальный диск, общая папка [!INCLUDE[TLA2#tla_unc](../../../../includes/tla2sharptla-unc-md.md)] и т. д.) в место публикации (веб-сайт, общая папка [!INCLUDE[TLA2#tla_unc](../../../../includes/tla2sharptla-unc-md.md)] и т. д.).  
  
-   Для приложения не требуется интеграция в оболочку (добавление значка в меню "Пуск", на рабочий стол и т. д.).  
  
 Хотя технология XCopy подходит для простых сценариев развертывания, ее недостаточно, когда требуется выполнить более сложное развертывание. В частности, при использовании XCopy могут возникать дополнительные затраты на создание, выполнение и поддержку скриптов для надежного управления развертыванием. Кроме того, XCopy не поддерживает управление версиями, удаление или откат.  
  
<a name="Windows_Installer"></a>   
### <a name="windows-installer"></a>Установщик Windows  
 [!INCLUDE[TLA2#tla_wininstall](../../../../includes/tla2sharptla-wininstall-md.md)] позволяет упаковывать приложения как самодостаточные исполняемые файлы, которые легко развертывать и запускать на клиентах. Кроме того, [!INCLUDE[TLA2#tla_wininstall](../../../../includes/tla2sharptla-wininstall-md.md)] устанавливается вместе с Windows и поддерживает интеграцию с рабочим столом, меню "Пуск" и компонентом панели управления "Программы".  
  
 [!INCLUDE[TLA2#tla_wininstall](../../../../includes/tla2sharptla-wininstall-md.md)] упрощает установку и удаление приложений, но он не предоставляет средства, обеспечивающие обновление приложений до последней версии.  
  
 Дополнительные сведения об установщике Windows см. в разделе [развертывание с помощью установщика Windows](https://docs.microsoft.com/visualstudio/deployment/deploying-applications-services-and-components#create-an-installer-package-windows-desktop).
  
<a name="ClickOnce_Deployment"></a>   
### <a name="clickonce-deployment"></a>Развертывание ClickOnce
 ClickOnce позволяет использовать веб-развертывание для настольных приложений. Приложения публикуются на веб-серверах или файловых серверах и развертываются с них. Развертывание ClickOnce поддерживает не весь набор клиентских возможностей приложений, установленных с помощью [!INCLUDE[TLA2#tla_wininstall](../../../../includes/tla2sharptla-wininstall-md.md)]. Поддерживаются следующие возможности:  
  
-   интеграция в меню "Пуск" и элемент панели управления "Программы";  
  
-   управление версиями, откат и удаление;  
  
-   режим интернет-установки, в котором приложение всегда запускается из места развертывания;  
  
-   автоматическое обновление при выходе новых версий;  
  
-   регистрация расширений файлов.  
  
 Дополнительные сведения о ClickOnce см. в разделе [Развертывание и безопасность технологии ClickOnce](https://docs.microsoft.com/visualstudio/deployment/clickonce-security-and-deployment).  
  
<a name="Deploying_WPF_Applications"></a>   
## <a name="deploying-wpf-applications"></a>Развертывание приложений WPF  
 Параметры развертывания для приложения WPF зависят от типа приложения. В плане развертывания технология WPF поддерживает три основных типа приложений:  
  
-   автономные приложения;  
  
-   приложения, полностью состоящие из кода XAML разметки;  
  
-   XAML-приложения браузера (XBAP).  
  
<a name="Deploying_Standalone_Applications"></a>   
### <a name="deploying-standalone-applications"></a>Развертывание автономных приложений  
 Автономные приложения развертываются с помощью ClickOnce или [!INCLUDE[TLA2#tla_wininstall](../../../../includes/tla2sharptla-wininstall-md.md)]. В любом случае для запуска автономных приложений требуется полное доверие. Полное доверие автоматически предоставляется автономным приложениям, которые развертываются с помощью [!INCLUDE[TLA2#tla_wininstall](../../../../includes/tla2sharptla-wininstall-md.md)]. Автономные приложения, которые развертываются с помощью ClickOnce, не получают полного доверия автоматически. Вместо этого ClickOnce выводит диалоговое окно с предупреждением системы безопасности, которое пользователь должен подтвердить перед установкой автономного приложения. Если предупреждение принято, автономное приложение устанавливается и ему предоставляется полное доверие. В противном случае автономное приложение не устанавливается.  
  
<a name="Deploying_Markup_Only_XAML_Applications"></a>   
### <a name="deploying-markup-only-xaml-applications"></a>Развертывание приложений XAML, содержащих только разметку  
 Страницы XAML, содержащие только разметку, обычно публикуются на веб-серверах, как и страницы [!INCLUDE[TLA2#tla_html](../../../../includes/tla2sharptla-html-md.md)], и их можно просматривать с помощью [!INCLUDE[TLA2#tla_iegeneric](../../../../includes/tla2sharptla-iegeneric-md.md)]. Страницы XAML, содержащие только разметку, запускаются в изолированной среде (в режиме безопасности с частичным доверием) с ограничениями, которые определяются набором разрешений зоны Интернета. Это обеспечивает эквивалентный уровень безопасности для веб-приложений [!INCLUDE[TLA2#tla_html](../../../../includes/tla2sharptla-html-md.md)].
  
 Дополнительные сведения о безопасности приложений WPF см. в разделе [Безопасность](../security-wpf.md).  
  
 Страницы XAML, содержащие только разметку, можно устанавливать в локальной файловой системе с помощью XCopy или [!INCLUDE[TLA2#tla_wininstall](../../../../includes/tla2sharptla-wininstall-md.md)]. Эти страницы можно просматривать при помощи [!INCLUDE[TLA2#tla_iegeneric](../../../../includes/tla2sharptla-iegeneric-md.md)] или проводника Windows.  
  
 Дополнительные сведения о XAML см. в разделе [Общие сведения о языке XAML](../advanced/xaml-overview-wpf.md).  
  
<a name="Deploying_XAML_Browser_Applications"></a>   
### <a name="deploying-xaml-browser-applications"></a>Развертывание приложений браузера XAML  
 XBAP — это скомпилированные приложения, требующие развертывания следующих трех файлов:  
  
-   *ApplicationName*.exe: Исполняемый файл приложения сборки.  
  
-   *ApplicationName*.xbap: Манифест развертывания.  
  
-   *ApplicationName*. exe.manifest: Манифест приложения.  
  
> [!NOTE]
>  Дополнительные сведения о манифестах развертывания и приложений см. в разделе [Построение приложения WPF](building-a-wpf-application-wpf.md).  
  
 Эти файлы создаются при сборке XBAP. Дополнительные сведения см. в разделе [Создание нового проекта приложения браузера WPF](https://docs.microsoft.com/previous-versions/visualstudio/visual-studio-2010/bb628663(v=vs.100)). Подобно страницам XAML, содержащим только разметку, XBAP обычно публикуются на веб-сервере и просматриваются с помощью браузера [!INCLUDE[TLA2#tla_iegeneric](../../../../includes/tla2sharptla-iegeneric-md.md)].  
  
 XBAP можно развернуть для клиентов с помощью любого из методов развертывания. Однако рекомендуется использовать технологию ClickOnce, так как она имеет следующие возможности:  
  
1. автоматическое обновление при публикации новой версии;  
  
2. повышенные привилегии при выполнении XBAP в режиме полного доверия.  
  
 По умолчанию средство ClickOnce публикует файлы приложений с расширением DEPLOY. Это поведение может привести к затруднениям, но его можно отключить. Дополнительные сведения см. в разделе [Вопросы настройки сервера и клиента в развертываниях ClickOnce](https://docs.microsoft.com/visualstudio/deployment/server-and-client-configuration-issues-in-clickonce-deployments).  
  
 Дополнительные сведения о развертывании XAML-приложения браузера (XBAP) см. в разделе [Общие сведения о приложениях браузера WPF XAML](wpf-xaml-browser-applications-overview.md).  
  
<a name="Installing__NET_Framework_3_0"></a>   
## <a name="installing-the-net-framework"></a>Установка .NET Framework  
 Для запуска WPF приложения на клиентском компьютере необходимо установить Microsoft .NET Framework. Internet Explorer автоматически определяет, установлена ли .NET Framework на клиенте при просмотре браузерных приложений WPF. Если платформа .NET Framework не установлена, Internet Explorer предлагает пользователю установить ее.
  
 Для проверки наличия установленной платформы .NET Framework, Internet Explorer включает в себя приложение начальной загрузки, который зарегистрирован в качестве резервного обработчика содержимого файлов [!INCLUDE[TLA#tla_mime](../../../../includes/tlasharptla-mime-md.md)] со следующими расширениями: .xaml, .xps, .xbap и .application. При переходе на эти типы файлов, если .NET Framework не установлена на клиенте, приложение начальной загрузки запрашивает разрешение на его установку. Если разрешение не предоставляется, ни .NET Framework, ни приложение не будут установлены.  
  
 Если разрешение предоставлено, Internet Explorer загрузит и установит .NET Framework с помощью [!INCLUDE[TLA#tla_bits](../../../../includes/tlasharptla-bits-md.md)]. После успешной установки платформы .NET Framework изначально запрошенный файл открывается в новом окне браузера.  
  
 Автоматическое обнаружение .NET Framework поддерживается в [!INCLUDE[TLA#tla_longhorn](../../../../includes/tlasharptla-longhorn-md.md)], [!INCLUDE[TLA#tla_winxpsp2](../../../../includes/tlasharptla-winxpsp2-md.md)], и [!INCLUDE[TLA#tla_winnetsvrfamsp1](../../../../includes/tlasharptla-winnetsvrfamsp1-md.md)], при наличии [!INCLUDE[TLA2#tla_ie7](../../../../includes/tla2sharptla-ie7-md.md)] или более поздней версии.
  
 Дополнительные сведения см. в разделе [Развертывание .NET Framework и приложений](../../deployment/index.md).  
  
## <a name="see-also"></a>См. также

- [Построение приложения WPF](building-a-wpf-application-wpf.md)
- [Безопасность](../security-wpf.md)
