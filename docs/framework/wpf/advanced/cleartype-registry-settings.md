---
title: Параметры реестра ClearType
ms.date: 03/30/2017
helpviewer_keywords:
- ClearType [WPF], registry settings
- typography [WPF], ClearType registry settings
ms.assetid: 56f314bb-b30b-4f67-8492-8b8a9fa432ae
ms.openlocfilehash: a776c3d4060b9ca291e4e919ab6ca33fb713434c
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59079998"
---
# <a name="cleartype-registry-settings"></a>Параметры реестра ClearType
В этом разделе содержится обзор [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)][!INCLUDE[TLA#tla_ct](../../../../includes/tlasharptla-ct-md.md)] параметры реестра, используемые [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] приложений.  

<a name="overview"></a>   
## <a name="technology-overview"></a>Общие сведения о технологии  
 [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] приложения, которые отображают текст на устройство отображения, используют [!INCLUDE[TLA2#tla_ct](../../../../includes/tla2sharptla-ct-md.md)] признаки должны предоставлять чтение. [!INCLUDE[TLA2#tla_ct](../../../../includes/tla2sharptla-ct-md.md)] — это программная технология, разработанная компанией [!INCLUDE[TLA#tla_ms](../../../../includes/tlasharptla-ms-md.md)] для улучшения удобочитаемости текста на современных ЖК-мониторах (жидкокристаллических дисплеях), например экранах ноутбуков, карманных ПК и плоскопанельных мониторах. [!INCLUDE[TLA2#tla_ct](../../../../includes/tla2sharptla-ct-md.md)] работает путем обращения к отдельным вертикальным элементам цветных полос в каждом пикселе ЖК-экрана. Дополнительные сведения о [!INCLUDE[TLA2#tla_ct](../../../../includes/tla2sharptla-ct-md.md)], см. в разделе [Общие сведения о технологии ClearType](cleartype-overview.md).  
  
 Текст, отображаемый с [!INCLUDE[TLA2#tla_ct](../../../../includes/tla2sharptla-ct-md.md)] может существенно отличаться при просмотре на различных устройствах отображения. Например, небольшое число мониторов реализуют элементы полос цвета расположены в порядке синий, зеленый, красный, а не чаще, красный, зеленый, синий ( [!INCLUDE[TLA#tla_rgb](../../../../includes/tlasharptla-rgb-md.md)]) порядке.  
  
 Текст, отображаемый с [!INCLUDE[TLA2#tla_ct](../../../../includes/tla2sharptla-ct-md.md)] может также существенно отличаться при просмотре лиц с разным уровнем светочувствительности. Некоторые замечают незначительные различия в цвете лучше, чем другие.  
  
 В каждом из этих случаев [!INCLUDE[TLA2#tla_ct](../../../../includes/tla2sharptla-ct-md.md)] функции должны быть изменены, чтобы обеспечить лучшие возможности для чтения для каждого пользователя.  
  
<a name="registry_settings"></a>   
## <a name="registry-settings"></a>Параметры реестра  
 [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] Задает четыре параметра реестра для управления [!INCLUDE[TLA2#tla_ct](../../../../includes/tla2sharptla-ct-md.md)] функции:  
  
|Параметр|Описание|  
|-------------|-----------------|  
|[!INCLUDE[TLA2#tla_ct](../../../../includes/tla2sharptla-ct-md.md)] level|Описывает уровень [!INCLUDE[TLA2#tla_ct](../../../../includes/tla2sharptla-ct-md.md)] прозрачности цвета.|  
|Гамма-уровень|Описывает уровень компонента цвета пикселя для устройства отображения.|  
|Структура пикселей|Описывает расположение пикселей для устройства отображения.|  
|Уровень контрастности текста|Описывает уровень контрастности отображаемого текста.|  
  
 Эти параметры доступны внешней конфигурации программы, которая знает, как ссылаться на [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)][!INCLUDE[TLA2#tla_ct](../../../../includes/tla2sharptla-ct-md.md)] параметры реестра. Эти параметры также можно создать или изменить через прямой доступ к значениям с использованием редактора реестра [!INCLUDE[TLA#tla_mswin](../../../../includes/tlasharptla-mswin-md.md)].  
  
 Если [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)][!INCLUDE[TLA2#tla_ct](../../../../includes/tla2sharptla-ct-md.md)] (это состояние по умолчанию), не заданы параметры реестра [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] запросов приложения [!INCLUDE[TLA#tla_mswin](../../../../includes/tlasharptla-mswin-md.md)] сведения о системных параметрах для настроек сглаживания шрифтов.  
  
> [!NOTE]
>  Сведения о перечислении имен устройств отображения см. в разделе `SystemParametersInfo`[!INCLUDE[TLA2#tla_win32](../../../../includes/tla2sharptla-win32-md.md)] функции.  
  
<a name="ClearType_level"></a>   
## <a name="cleartype-level"></a>Уровень ClearType  
 [!INCLUDE[TLA2#tla_ct](../../../../includes/tla2sharptla-ct-md.md)] Уровень позволяет настроить отрисовку текста, в зависимости от чувствительности к свету и восприятия индивида. Для некоторых пользователей отрисовка текста, которая использует [!INCLUDE[TLA2#tla_ct](../../../../includes/tla2sharptla-ct-md.md)] на самом высоком уровне не создает лучшие возможности для чтения.  
  
 [!INCLUDE[TLA2#tla_ct](../../../../includes/tla2sharptla-ct-md.md)] Уровень — целочисленное значение, в диапазоне от 0 до 100. По умолчанию — 100, что означает [!INCLUDE[TLA2#tla_ct](../../../../includes/tla2sharptla-ct-md.md)] используются возможности максимальный ресурс элементов полос цвета дисплея. Тем не менее [!INCLUDE[TLA2#tla_ct](../../../../includes/tla2sharptla-ct-md.md)] уровень 0 визуализирует текст оттенках серого. Установив [!INCLUDE[TLA2#tla_ct](../../../../includes/tla2sharptla-ct-md.md)] уровня где-нибудь в диапазоне от 0 до 100, можно создать промежуточный уровень, подходящий для отдельного светочувствительности.  
  
### <a name="registry-setting"></a>Параметр реестра  
 Параметр реестра для [!INCLUDE[TLA2#tla_ct](../../../../includes/tla2sharptla-ct-md.md)] уровень — в параметре отдельного пользователя, соответствующий имени определенного устройства отображения:  
  
 `HKEY_CURRENT_USER\SOFTWARE\Microsoft\Avalon.Graphics\<displayName>`  
  
 Для каждого имени устройства отображения для пользователя `ClearTypeLevel` определено значение DWORD. На следующем рисунке показан параметр редактора реестра для [!INCLUDE[TLA2#tla_ct](../../../../includes/tla2sharptla-ct-md.md)] уровень.  
  
 ![Параметры ClearType в редакторе реестра.](./media/cleartype-registry-settings/cleartype-settings-registry-editor.png)  
  
> [!NOTE]
>  [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] приложения для вывода текста в одном из двух режимов, с и без [!INCLUDE[TLA2#tla_ct](../../../../includes/tla2sharptla-ct-md.md)]. Если текст отрисовывается без [!INCLUDE[TLA2#tla_ct](../../../../includes/tla2sharptla-ct-md.md)], он называется отрисовке в оттенках серого.  
  
<a name="gamma_level"></a>   
## <a name="gamma-level"></a>Гамма-уровень  
 Гамма-уровень относится к нелинейной связи между значением пикселя и яркостью. Параметр гамма-уровня должен соответствовать физическим характеристикам устройства отображения; в противном случае возможны нарушения в отрисовываемых выходных данных. Например, текст может отображаться слишком широко или узко, либо по краям вертикальных полос глифов могут отображаться цветные полосы.  
  
 Гамма-уровень — это целочисленное значение в диапазоне от 1000 до 2200. Значение по умолчанию — 1900.  
  
### <a name="registry-setting"></a>Параметр реестра  
 Расположение параметра реестра для гамма-уровня — параметр локальной машины, соответствующий имени определенного устройства отображения.  
  
 `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Avalon.Graphics\<displayName>`  
  
 Для каждого имени устройства отображения для пользователя `GammaLevel` определено значение DWORD. На следующем снимке экрана показан параметр редактора реестра для гамма-уровня.  
  
 ![Параметры уровня гамма ClearType в редакторе реестра](./media/cleartype-registry-settings/cleartype-gamma-level-settings-registry-editor.png)  
  
<a name="pixel_structure"></a>   
## <a name="pixel-structure"></a>Структура пикселей  
 Структура пикселей описывает тип пикселей, составляющих устройство отображения. Структура пикселей определяется как один из трех типов.  
  
|Тип|Значение|Описание|  
|----------|-----------|-----------------|  
|плоский|0|Устройство отображения не имеет структуры пикселей. Это означает, что источники света для каждого цвета распределены равномерно в области пикселя: это называется отрисовкой в оттенках серого. Так работает стандартное устройство отображения. [!INCLUDE[TLA2#tla_ct](../../../../includes/tla2sharptla-ct-md.md)] никогда не применяется к отрисованному тексту.|  
|RGB|1|Пиксели на устройстве отображения состоят из трех полос, расположенных в следующем порядке: красный, зеленый и синий. [!INCLUDE[TLA2#tla_ct](../../../../includes/tla2sharptla-ct-md.md)] применяется к отрисованному тексту.|  
|BGR|2|Пиксели на устройстве отображения состоят из трех полос, расположенных в следующем порядке: синий, зеленый и красный. [!INCLUDE[TLA2#tla_ct](../../../../includes/tla2sharptla-ct-md.md)] применяется к отрисованному тексту. Обратите внимание на обратный порядок цветов по сравнению с RGB.|  
  
 Структура пикселей соответствует целочисленному значению в диапазоне от 0 до 2. Значение по умолчанию — 0, представляющее плоскую структуру пикселей.  
  
> [!NOTE]
>  Сведения о перечислении имен устройств отображения см. в разделе `EnumDisplayDevices`[!INCLUDE[TLA2#tla_win32](../../../../includes/tla2sharptla-win32-md.md)] функции.  
  
### <a name="registry-setting"></a>Параметр реестра  
 Расположение параметра реестра для структуры пикселей — параметр локальной машины, соответствующий имени определенного устройства отображения.  
  
 `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Avalon.Graphics\<displayName>`  
  
 Для каждого имени устройства отображения для пользователя `PixelStructure` определено значение DWORD. На следующем снимке экрана показан параметр редактора реестра для структуры пикселей.  
  
 ![Параметры уровня гамма ClearType в редакторе реестра](./media/cleartype-registry-settings/cleartype-gamma-level-settings-registry-editor.png)  
  
<a name="text_contrast_level"></a>   
## <a name="text-contrast-level"></a>Уровень контрастности текста  
 Уровень контрастности текста позволяет настроить отрисовку текста в зависимости от ширины полос глифов. Уровень контрастности текста — это целочисленное значение в диапазоне от 0 до 6: чем больше это значение, тем шире полоса. Значение по умолчанию — 1.  
  
### <a name="registry-setting"></a>Параметр реестра  
 Параметр реестра для уровня контрастности текста расположен в параметре отдельного пользователя, соответствующем имени определенного устройства отображения.  
  
 `HKEY_CURRENT_USER\Software\Microsoft\Avalon.Graphics\<displayName>`  
  
 Для каждого имени устройства отображения для пользователя `TextContrastLevel` определено значение DWORD. На следующем снимке экрана показан параметр редактора реестра для уровня контрастности текста.  
  
 ![Параметры ClearType в редакторе реестра.](./media/cleartype-registry-settings/cleartype-settings-registry-editor.png)  
  
## <a name="see-also"></a>См. также

- [Общие сведения о технологии ClearType](cleartype-overview.md)
- [Сглаживание ClearType](/windows/desktop/gdi/cleartype-antialiasing)
