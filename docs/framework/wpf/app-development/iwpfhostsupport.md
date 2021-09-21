---
title: Интерфейс IWpfHostSupport
ms.date: 03/30/2017
helpviewer_keywords:
- IWpfHostSupport interface [WPF]
ms.assetid: cc5a0281-de81-4cc1-87e4-0e46b1a811e9
ms.openlocfilehash: 074167111b78edc517dda019465260d0acd54737
ms.sourcegitcommit: 0c48191d6d641ce88d7510e319cf38c0e35697d0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/05/2019
ms.locfileid: "57376017"
---
# <a name="iwpfhostsupport"></a>Интерфейс IWpfHostSupport
Приложения, размещающие Windows Presentation Foundation (WPF) содержимым при помощи PresentationHost.exe Реализуйте этот интерфейс для предоставления точки интеграции между узлом и PresentationHost.exe.  
  
## <a name="remarks"></a>Примечания  
 Win32 можно размещать приложения, такие как веб-браузеры WPF содержимого, включая XAML-приложения браузера (XBAP) и Свободный XAML. Узел WPF содержимое, Win32 приложения создают экземпляр [элемент управления WebBrowser](https://go.microsoft.com/fwlink/?LinkId=97911). Для размещения WPF создает экземпляр класса PresentationHost.exe, который предоставляет размещаемый WPF содержимого на узле для отображения в [элемент управления WebBrowser](https://go.microsoft.com/fwlink/?LinkId=97911).  
  
 Интеграция включаемые `IWpfHostSupport` позволяет PresentationHost.exe для:  
  
-   Определить и зарегистрировать устройства необработанного ввода (HID-устройств), которые интересуют ведущее приложение.  
  
-   Получите входящие сообщения от зарегистрированного устройства необработанного ввода и переслать соответствующие сообщения ведущему приложению.  
  
-   Запрос ведущим приложением для настраиваемых пользовательских интерфейсов хода выполнения и ошибки.  
  
> [!NOTE]
>  Этот API предназначен и поддерживается только для использования на локальном клиентском компьютере  
  
## <a name="members"></a>Члены  
  
|Член|Описание:|  
|------------|-----------------|  
|[GetRawInputDevices](getrawinputdevices.md)|Позволяет программе PresentationHost.exe обнаруживать устройства необработанного ввода (устройства HID), которые интересуют ведущее приложение.|  
|[FilterInputMessage](filterinputmessage.md)|Вызывается программой PresentationHost.exe всякий раз при получении сообщения, пока не будет возвращено E_NOTIMPL.|  
|[GetCustomUI](getcustomui.md)|По умолчанию PresentationHost.exe время от времени предоставляет свой собственный ход выполнения развертывания и ошибка развертывания при пользовательские интерфейсы, которые отображаются при развертывании содержимого WPF.|
