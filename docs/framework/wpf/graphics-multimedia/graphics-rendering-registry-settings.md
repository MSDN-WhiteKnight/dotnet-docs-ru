---
title: Настройки реестра графической отрисовки
ms.date: 03/30/2017
helpviewer_keywords:
- rendering graphics [WPF], registry settings
- rendering graphics [WPF]
- rendering graphics [WPF], troubleshooting
- troubleshooting graphics rendering [WPF]
- graphics [WPF], rendering
ms.assetid: f4b41b42-327d-407c-b398-3ed5f505df8b
ms.openlocfilehash: 616c74ccd787d9acdcb2a3bbe281c2f43bb49c2e
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59135542"
---
# <a name="graphics-rendering-registry-settings"></a>Настройки реестра графической отрисовки
В этом разделе содержится обзор параметров графической отрисовки [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] в реестре, которые влияют на приложения [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)].  

<a name="overview"></a>   
## <a name="when-to-use-graphics-rendering-registry-settings"></a>Когда следует использовать настройки реестра для графической отрисовки  
 Эти параметры реестра предоставляются для устранения неполадок, отладки и поддержки продукта. Поскольку изменения в реестре влияют на все приложения [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)], ваше приложение никогда не должно изменять эти разделы реестра автоматически или во время установки.  
  
<a name="xpdmandwddm"></a>   
## <a name="what-are-xpdm-and-wddm"></a>Что такое XPDM и WDDM?  
 Некоторые из параметров реестра для графической отрисовки имеют разные значения по умолчанию, в зависимости от того, использует ли видеокарта драйвер XPDM или WDDM. XPDM — модель видеодрайвера [!INCLUDE[TLA#tla_winxp](../../../../includes/tlasharptla-winxp-md.md)], а WDDM — модель видеодрайвера Windows. Модель WDDM доступна на компьютерах под управлением [!INCLUDE[TLA2#tla_winvista](../../../../includes/tla2sharptla-winvista-md.md)] и [!INCLUDE[win7](../../../../includes/win7-md.md)]. Модель XPDM доступна на компьютерах под управлением [!INCLUDE[TLA2#tla_winvista](../../../../includes/tla2sharptla-winvista-md.md)], [!INCLUDE[TLA#tla_winxp](../../../../includes/tlasharptla-winxp-md.md)] и [!INCLUDE[TLA#tla_winnetsvrfam](../../../../includes/tlasharptla-winnetsvrfam-md.md)]. Дополнительную информацию о WDDM см. в разделе [Руководство по проектированию для модели видеодрайвера Windows Vista](https://go.microsoft.com/fwlink/?LinkId=178394).  
  
<a name="registry_settings"></a>   
## <a name="registry-settings"></a>Параметры реестра  
 [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] предоставляет четыре параметра реестра для управления [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] отрисовки:  
  
|Параметр|Описание|  
|-------------|-----------------|  
|**Отключить аппаратное ускорение**|Указывает, следует ли включить аппаратное ускорение.|  
|**Максимальное значение мультисэмплинга**|Определяет степень мультисэмплинга для сглаживания содержимого [!INCLUDE[TLA2#tla_3d](../../../../includes/tla2sharptla-3d-md.md)].|  
|**Требуемая дата видеодрайвера**|Указывает, отключает ли система аппаратное ускорение для драйверов, выпущенных до ноября 2004 г.|  
|**Использовать средство программной прорисовки**|Указывает, следует ли [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] использовать средство программной прорисовки.|  
  
 Эти параметры доступны любой внешней служебной программе настройки, которая знает, как ссылаться на параметры реестра [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)]. Эти параметры также можно создать или изменить через прямой доступ к значениям с использованием редактора реестра [!INCLUDE[TLA#tla_mswin](../../../../includes/tlasharptla-mswin-md.md)].  
  
<a name="disablehardwareacceleration"></a>   
## <a name="disable-hardware-acceleration-option"></a>Отключить аппаратное ускорение  
  
|Раздел реестра|Тип значения|  
|------------------|----------------|  
|`HKEY_CURRENT_USER\SOFTWARE\Microsoft\Avalon.Graphics\DisableHWAcceleration`|DWORD|  
  
 Параметр **отключения аппаратного ускорения** позволяет отключить аппаратное ускорение для тестирования и отладки. При появлении артефактов отрисовки в приложении попробуйте отключить аппаратное ускорение. Если артефакт исчезает, проблема может быть связана с видеодрайвером.  
  
 Параметр **отключить аппаратное ускорение** имеет тип DWORD и может принимать значение 0 или 1. Значение 1 отключает аппаратное ускорение. Значение 0 включает аппаратное ускорение, если система соответствует требованиям для аппаратного ускорения; дополнительные сведения см. в разделе [Уровни отрисовки графики](../advanced/graphics-rendering-tiers.md).  
  
<a name="maxmultisample"></a>   
## <a name="maximum-multisample-value"></a>Максимальное значение мультисэмплинга  
  
|Раздел реестра|Тип значения|  
|------------------|----------------|  
|`HKEY_CURRENT_USER\SOFTWARE\Microsoft\Avalon.Graphics\MaxMultisampleType`|DWORD|  
  
 Параметр **максимальное значение мультисэмплинга** дает возможность настроить максимальное сглаживание содержимого [!INCLUDE[TLA2#tla_3d](../../../../includes/tla2sharptla-3d-md.md)]. Используйте этот уровень для отключения сглаживания [!INCLUDE[TLA2#tla_3d](../../../../includes/tla2sharptla-3d-md.md)] в [!INCLUDE[TLA2#tla_winvista](../../../../includes/tla2sharptla-winvista-md.md)] или включения его в [!INCLUDE[TLA#tla_winxp](../../../../includes/tlasharptla-winxp-md.md)].  
  
 Параметр **максимальное значение мультисэмплинга** является значением типа DWORD в диапазоне от 0 до 16. Значение 0 указывает, что мультисэмплинговое сглаживание трехмерного содержимого должно быть отключено, а при значении 16 будет выполняться попытка использования 16-кратного мультисэмплингового сглаживания, если это поддерживается видеоадаптером. Имейте в виду, что установка этого значения раздела реестра на компьютерах, использующих драйверы XPDM, приведет к потреблению приложениями большого объема дополнительной видеопамяти, уменьшению производительности отрисовки [!INCLUDE[TLA2#tla_3d](../../../../includes/tla2sharptla-3d-md.md)] и потенциально может привести к появлению ошибок отрисовки и проблем стабильности.  
  
 Если этот раздел реестра не задан, [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] по умолчанию равно 0 для драйверов XPDM и 4 — для драйверов WDDM.  
  
<a name="requiredvideodriverdatesetting"></a>   
## <a name="required-video-driver-date-setting"></a>Требуемая дата видеодрайвера  
  
|Раздел реестра|Тип значения|  
|------------------|----------------|  
|`HKEY_CURRENT_USER\SOFTWARE\Microsoft\Avalon.Graphics\RequiredVideoDriverDate`|String|  
  
 В ноябре 2004 года [!INCLUDE[TLA#tla_ms](../../../../includes/tlasharptla-ms-md.md)] выпустила новую версию рекомендаций по тестированию драйверов; драйверы, написанные после этой даты, более стабильны. По умолчанию [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] будет использовать для таких драйверов конвейер аппаратного ускорения и вернется к программной отрисовке для драйверов XPDM, опубликованных до этой даты.  
  
 Параметр **требуемая дата видеодрайвера** позволяет указать альтернативную минимальную дату для драйверов XPDM. Дату ранее ноября 2004 г. следует указывать только в случае, если вы не уверены, что видеодрайвер достаточно стабилен для поддержки [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)].  
  
 Параметр требуемой даты видеодрайвера принимает строку в следующем формате:  
  
| |  
|-|  
|*ГГГГ* `/` *ММ* `/` *ДД*|  
  
 Где *ГГГГ* — четырехзначный год, *MM* — месяц из двух цифр и *ДД* — день из двух цифр. Если это значение не задано, [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] использует ноябрь 2004 года в качестве требуемой даты видеодрайвера.  
  
<a name="usereferencerasterizeroption"></a>   
## <a name="use-reference-rasterizer-option"></a>Использовать средство программной прорисовки  
  
|Раздел реестра|Тип значения|  
|------------------|----------------|  
|`HKEY_CURRENT_USER\SOFTWARE\Microsoft\Avalon.Graphics\UseReferenceRasterizer`|DWORD|  
  
 Параметр **использовать средство программной прорисовки** позволяет принудительно перевести [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] в режим эмуляции аппаратной отрисовки для отладки: [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] переходит в аппаратный режим, но вместо физического устройства использует средство программной прорисовки [!INCLUDE[TLA#tla_d3d](../../../../includes/tlasharptla-d3d-md.md)], d3dref9.dll.  
  
 Средство программной прорисовки является очень медленным, но обходит видеодрайвер во избежание проблем отрисовки, вызванных неполадками драйвера. По этой причине средство программной прорисовки можно использовать для определения, связаны ли проблемы отрисовки с видеодрайвером. Файл d3dref9.dll должен располагаться там, где приложение может получить к нему доступ, например в любом месте системного пути или в локальном каталоге приложения.  
  
 Параметр **использовать средство программной прорисовки** принимает значение типа DWORD. Значение 0 указывает, что средство программной прорисовки не используется. Любое другое ненулевое значение приводит к тому, что [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] будет использовать средство программной прорисовки.  
  
## <a name="see-also"></a>См. также

- [Уровни графической отрисовки](../advanced/graphics-rendering-tiers.md)
- [Общие сведения об отрисовке графики в WPF](wpf-graphics-rendering-overview.md)
