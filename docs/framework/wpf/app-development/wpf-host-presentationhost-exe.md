---
title: Ведущее приложение WPF (PresentationHost.exe)
ms.date: 03/30/2017
helpviewer_keywords:
- WPF Host application [WPF]
- PresentationHost.exe
ms.assetid: 3215bfa1-722c-4ac8-a7c5-bdd02d30afbd
ms.openlocfilehash: 586d306d0f375241c9382e1e24cf1af75b990ba9
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59122867"
---
# <a name="wpf-host-presentationhostexe"></a>Ведущее приложение WPF (PresentationHost.exe)
Ведущее приложение Windows Presentation Foundation (WPF) (PresentationHost.exe) — это приложение, которое позволяет WPF приложений, размещенных в совместимых браузерах (включая [!INCLUDE[TLA#tla_ie6](../../../../includes/tlasharptla-ie6-md.md)] и более поздних версий). По умолчанию узел Windows Presentation Foundation (WPF) регистрируется как оболочка и [!INCLUDE[TLA2#tla_mime](../../../../includes/tla2sharptla-mime-md.md)] обработчик для Браузерные WPF содержимое, которое включает в себя:  
  
-   Свободные (нескомпилированные) файлы XAML (.xaml).  
  
-   Приложение обозревателя XAML (XBAP) (.xbap).  
  
 Для файлов этих типов узлов Windows Presentation Foundation (WPF).  
  
-   Запускает зарегистрированный HTML обработчик для размещения содержимого Windows Presentation Foundation (WPF).  
  
-   Загружает правильные версии требуемых CLR и сборок Windows Presentation Foundation (WPF).  
  
-   Обеспечивает наличие соответствующих уровней разрешений для зоны развертывания.  
  
 В этом разделе описываются параметры командной строки, которые можно использовать с PresentationHost.exe.  
  
## <a name="usage"></a>Использование  
 `PresentationHost.exe [parameters] uri|filename`  
  
## <a name="parameters"></a>Параметры  
  
|Параметр|Описание|  
|---------------|-----------------|  
|filename|Путь к файлу, который нужно активировать. Также может быть URI.|  
|-debug|При активации приложения не фиксирует его в хранилище и не запускает из хранилища. Работает только при активации локального файла.|  
|-debugSecurityZoneURL \<url>|Используется со значением URL для указания необходимости отладки PresentationHost.exe, как при развертывании из указанного URL. Это определяет как зону развертывания, так и исходный узел.|  
|-embedding|Требуется для OLE. Если указан параметр `-event` или `-debug`, то не обязательно указывать параметр `-embedding`, поскольку он устанавливается внутренне.|  
|-event \<eventname>|Открывает событие с указанным именем и сигнализирует ему при инициализации PresentationHost.exe и готовности к размещению содержимого WPF. Работа PresentationHost.exe будет прервана в случае ошибки при открытии события, например, если оно еще не создано.|  
|-launchApplication \<url>|Запускает автономное приложение ClickOnce с указанного URL-адреса. Internet Explorer и применяются политики безопасности WinINet приложений .NET.|  
  
## <a name="scenarios"></a>Сценарии  
  
### <a name="shell-handler"></a>Обработчик оболочки  
 `PresentationHost.exe example.xbap`  
  
### <a name="mime-handler"></a>Обработчик MIME  
 `PresentationHost.exe -embedding example.xbap`  
  
### <a name="visual-studio-debugging"></a>Отладка в Visual Studio  
 `PresentationHost.exe -debug example.xbap`  
  
### <a name="visual-studio-debugging-in-zone"></a>Visual Studio, отладка в зоне  
 `PresentationHost.exe -debug -debugSecurityZoneURL http://www.example.com c:\folderpath\example.xbap`  
  
## <a name="see-also"></a>См. также

- [Безопасность](../security-wpf.md)
