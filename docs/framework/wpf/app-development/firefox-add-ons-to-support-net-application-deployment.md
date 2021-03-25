---
title: Надстройки Firefox для поддержки развертывания приложений .NET
ms.date: 03/30/2017
helpviewer_keywords:
- Firefox add-ons for .NET application deployment
- WPF plug-in for Firefox
- .NET application deployment [WPF], deploying with Firefox add-ons
- .NET Framework Assistant for Firefox
ms.assetid: 2403403b-9b14-48e9-b70d-fa288a3c9081
ms.openlocfilehash: 4b0552ab9f565d9118415bc2da2823762f34fe2c
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59111739"
---
# <a name="firefox-add-ons-to-support-net-application-deployment"></a>Надстройки Firefox для поддержки развертывания приложений .NET
Включить Windows Presentation Foundation (WPF) подключаемого модуля для Firefox и .NET Framework Assistant для Firefox [!INCLUDE[TLA#tla_winfxwebapp#plural](../../../../includes/tlasharptla-winfxwebappsharpplural-md.md)], свободные [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)]и приложений ClickOnce для работы с браузером Mozilla Firefox.  
  
## <a name="wpf-plug-in-for-firefox"></a>Подключаемого модуля WPF для Firefox  
 Включение подключаемого модуля WPF для Firefox XBAP и свободные [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] файлы, чтобы перейти и запустить на верхнем уровне или в IFRAME HTML в браузере Firefox. XBAP Является WPF приложения, опубликованные на веб-сервере и запустить в поддерживаемых браузеров. Свободные [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] является файлом только для XAML, который можно перейти и в поддерживаемых браузерах, как XML-файл.  
  
 WPF Подключаемый модуль для Firefox устанавливается вместе с [!INCLUDE[net_v35_short](../../../../includes/net-v35-short-md.md)]. Windows 7 включает [!INCLUDE[net_v35_short](../../../../includes/net-v35-short-md.md)], но не включает WPF подключаемого модуля для Firefox. Не удается установить WPF подключаемого модуля для Firefox в Windows 7.  
  
 [!INCLUDE[net_v40_short](../../../../includes/net-v40-short-md.md)] Не включает WPF подключаемого модуля для Firefox. Тем не менее если оба [!INCLUDE[net_v35_short](../../../../includes/net-v35-short-md.md)] и [!INCLUDE[net_v40_short](../../../../includes/net-v40-short-md.md)] являются установки подключаемого модуля WPF для Firefox устанавливается вместе с [!INCLUDE[net_v35_short](../../../../includes/net-v35-short-md.md)]. Таким образом [!INCLUDE[net_v40_short](../../../../includes/net-v40-short-md.md)] приложений будет работать, поскольку ведущее приложение WPF загрузит правильную версию платформы. Дополнительные сведения см. в разделе [ведущее приложение WPF (PresentationHost.exe)](wpf-host-presentationhost-exe.md).  
  
## <a name="net-framework-assistant-for-firefox"></a>.NET Framework Assistant для Firefox  
 .NET Framework Assistant для Firefox позволяет выполнять из браузера Firefox автономного приложения ClickOnce. .NET Framework Assistant для Firefox функций идентично в том случае, если он установлен до и после браузер Firefox. При запуске браузера Firefox и [!INCLUDE[net_v35SP1_short](../../../../includes/net-v35sp1-short-md.md)] будет установлено, Firefox находит и устанавливает .NET Framework Assistant для Firefox. Пользователи могут настраивать .NET Framework Assistant для Firefox, выполнив следующие действия:  
  
-   Запрашивать перед запуском приложения ClickOnce.  
  
-   Сообщать о всех установленных версий .NET Framework или только о последней версии.  
  
 .NET Framework Assistant для Firefox входит в состав [!INCLUDE[net_v35SP1_short](../../../../includes/net-v35sp1-short-md.md)]. Сведения об удалении .NET Framework Assistant для Firefox, см. в разделе [удаление .NET Framework Assistant для Firefox](https://go.microsoft.com/fwlink/?LinkId=177944).  
  
## <a name="see-also"></a>См. также

- [Развертывание приложения WPF](deploying-a-wpf-application-wpf.md)
- [Общие сведения о приложениях браузера WPF XAML](wpf-xaml-browser-applications-overview.md)
- [Проверка наличия установленного подключаемого модуля WPF для Firefox](how-to-detect-whether-the-wpf-plug-in-for-firefox-is-installed.md)
