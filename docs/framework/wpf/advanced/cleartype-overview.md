---
title: Общие сведения о технологии ClearType
ms.date: 03/30/2017
helpviewer_keywords:
- typography [WPF], ClearType technology
- ClearType [WPF], technology
ms.assetid: 7e2392e0-75dc-463d-a716-908772782431
ms.openlocfilehash: 0127ee4112c4b42a7a55b9233217ea1e02604042
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59085198"
---
# <a name="cleartype-overview"></a>Общие сведения о технологии ClearType
В этой статье дается обзор технологии [!INCLUDE[TLA#tla_ct](../../../../includes/tlasharptla-ct-md.md)], доступной в Windows Presentation Foundation (WPF).  

<a name="overview"></a>   
## <a name="technology-overview"></a>Общие сведения о технологии  
 [!INCLUDE[TLA2#tla_ct](../../../../includes/tla2sharptla-ct-md.md)] — это программная технология, разработанная компанией [!INCLUDE[TLA#tla_ms](../../../../includes/tlasharptla-ms-md.md)] для улучшения удобочитаемости текста на современных ЖК-мониторах (жидкокристаллических дисплеях), например экранах ноутбуков, карманных ПК и плоскопанельных мониторах.  [!INCLUDE[TLA2#tla_ct](../../../../includes/tla2sharptla-ct-md.md)] работает путем обращения к отдельным вертикальным элементам цветных полос в каждом пикселе ЖК-экрана. До представления технологии [!INCLUDE[TLA2#tla_ct](../../../../includes/tla2sharptla-ct-md.md)] минимальным уровнем детализации изображения на компьютере был один пиксель, однако благодаря [!INCLUDE[TLA2#tla_ct](../../../../includes/tla2sharptla-ct-md.md)] на ЖК-экране могут отображаться детали текста вплоть до доли ширины пикселя. Дополнительное разрешение повышает четкость мелких деталей отображаемого текста, значительно облегчая его длительное чтение.  
  
 Технология [!INCLUDE[TLA2#tla_ct](../../../../includes/tla2sharptla-ct-md.md)], доступная в Windows Presentation Foundation (WPF), — это новое поколение [!INCLUDE[TLA2#tla_ct](../../../../includes/tla2sharptla-ct-md.md)], которое включает несколько преимуществ по сравнению с версией [!INCLUDE[TLA#tla_gdi](../../../../includes/tlasharptla-gdi-md.md)].  
  
<a name="sub-pixel_positioning"></a>   
## <a name="sub-pixel-positioning"></a>Субпиксельная отрисовка  
 Значительным преимуществом по сравнению с предыдущей версией [!INCLUDE[TLA2#tla_ct](../../../../includes/tla2sharptla-ct-md.md)] является использование субпиксельной отрисовки. В отличие от реализации [!INCLUDE[TLA2#tla_ct](../../../../includes/tla2sharptla-ct-md.md)] в [!INCLUDE[TLA2#tla_gdi](../../../../includes/tla2sharptla-gdi-md.md)] технология [!INCLUDE[TLA2#tla_ct](../../../../includes/tla2sharptla-ct-md.md)] в Windows Presentation Foundation (WPF) позволяет глифам начинаться внутри пикселя, а не только на его начальной границе. Благодаря дополнительному разрешению при отрисовке глифов интервалы и пропорции глифов становятся более точными и согласованными.  
  
 В следующих двух примерах показано, как глифы могут начинаться на любой субпиксельной границе при использовании субпиксельной отрисовки. Отрисовка примера справа выполнена с использованием более ранней версии отрисовщика [!INCLUDE[TLA2#tla_ct](../../../../includes/tla2sharptla-ct-md.md)], в котором не использовалась субпиксельная отрисовка. Отрисовка примера справа выполнена с использованием новой версии отрисовщика [!INCLUDE[TLA2#tla_ct](../../../../includes/tla2sharptla-ct-md.md)] и функции субпиксельной отрисовки. Обратите внимание на то, что каждая буква **e** и **l** на рисунке справа отображается немного по-разному, так разные глифы начинаются в разных субпикселях. При просмотре текста в обычном размере на экране это различие незаметно из-за высокой контрастности изображения глифа. Это возможно только благодаря сложной цветовой фильтрации, которая включена в функцию [!INCLUDE[TLA2#tla_ct](../../../../includes/tla2sharptla-ct-md.md)].  
  
 ![Текст, отображаемый двумя версиями ClearType](./media/wcpsdk-mmgraphics-text-cleartype-overview-01.png "wcpsdk_mmgraphics_text_cleartype_overview_01")  
Текст, отображаемый более ранней и более поздней версией ClearType  
  
 Сравните вывод предыдущего отрисовщика [!INCLUDE[TLA2#tla_ct](../../../../includes/tla2sharptla-ct-md.md)] с новой версией отрисовщика [!INCLUDE[TLA2#tla_ct](../../../../includes/tla2sharptla-ct-md.md)] в следующих двух примерах. Субпиксельная отрисовка, показанная справа, значительно улучшает плотность знаков на экране, особенно при небольших размерах, когда разница между субпикселем и целым пикселем представляет значительную часть ширины глифа. Обратите внимание, что расстояние между буквами более однородно на втором изображении. Совокупное влияние субпиксельной отрисовки на общий вид текста на экране значительно увеличено и демонстрирует существенное развитие технологии [!INCLUDE[TLA2#tla_ct](../../../../includes/tla2sharptla-ct-md.md)].  
  
 ![Текст, отображаемый ранней версией ClearType](./media/wcpsdk-mmgraphics-text-cleartype-overview-02.png "wcpsdk_mmgraphics_text_cleartype_overview_02")  
Текст, отображаемый более ранней и более поздней версией ClearType  
  
<a name="y-direction_antialiasing"></a>   
## <a name="y-direction-antialiasing"></a>Сглаживание по оси Y  
 Другим преимуществом [!INCLUDE[TLA2#tla_ct](../../../../includes/tla2sharptla-ct-md.md)] в Windows Presentation Foundation (WPF) является сглаживание по оси Y. [!INCLUDE[TLA2#tla_ct](../../../../includes/tla2sharptla-ct-md.md)] в [!INCLUDE[TLA2#tla_gdi](../../../../includes/tla2sharptla-gdi-md.md)] без сглаживания по оси Y обеспечивает лучшее разрешение по оси X, но не Y. В верхних и нижних границах мелких изгибов неровные края влияют на их удобочитаемость.  
  
 В следующем примере к тексту не применено сглаживание по оси Y. В этом случае неровные края верхней и нижней частей буквы сильно заметны.  
  
 ![Текст с неровными краями у мелких изгибов](./media/wcpsdk-mmgraphics-text-cleartype-overview-03.png "wcpsdk_mmgraphics_text_cleartype_overview_03")  
Текст с неровными краями у мелких изгибов  
  
 [!INCLUDE[TLA2#tla_ct](../../../../includes/tla2sharptla-ct-md.md)] в Windows Presentation Foundation (WPF) обеспечивает сглаживание по оси y уровень сгладить неровные края. Это особенно важно для повышения удобочитаемости восточно-азиатских языков, в которых иероглифы имеют почти равное количество горизонтальных и вертикальных мелких изгибов.  
  
 В следующем примере к тексту применено сглаживание по оси Y. В этом случае заметны гладкие изгибы верхней и нижней частей буквы.  
  
 ![Текст с ClearType по оси y&#45;направление anti&#45;сглаживание](./media/wcpsdk-mmgraphics-text-cleartype-overview-04.png "wcpsdk_mmgraphics_text_cleartype_overview_04")  
Текст со сглаживанием ClearType по оси Y  
  
<a name="hardware_acceleration"></a>   
## <a name="hardware-acceleration"></a>Аппаратное ускорение  
 [!INCLUDE[TLA2#tla_ct](../../../../includes/tla2sharptla-ct-md.md)] в Windows Presentation Foundation (WPF) использовать преимущества аппаратного ускорения для повышения производительности и снижения нагрузки и системных требований к памяти ЦП. Используя построители текстуры и память видеокарты, [!INCLUDE[TLA2#tla_ct](../../../../includes/tla2sharptla-ct-md.md)] обеспечивает быструю визуализацию текста, особенно при использовании анимации.  
  
 [!INCLUDE[TLA2#tla_ct](../../../../includes/tla2sharptla-ct-md.md)] в Windows Presentation Foundation (WPF) не изменяет общесистемные [!INCLUDE[TLA2#tla_ct](../../../../includes/tla2sharptla-ct-md.md)] параметры. Отключение [!INCLUDE[TLA2#tla_ct](../../../../includes/tla2sharptla-ct-md.md)] в [!INCLUDE[TLA#tla_mswin](../../../../includes/tlasharptla-mswin-md.md)] задает Windows Presentation Foundation (WPF) для сглаживания режим "оттенки серого". Кроме того, [!INCLUDE[TLA2#tla_ct](../../../../includes/tla2sharptla-ct-md.md)] в Windows Presentation Foundation (WPF) не изменяет параметры [средства настройки ClearType, PowerToy](https://www.microsoft.com/typography/ClearTypePowerToy.mspx).  
  
 Одно из архитектурных решений Windows Presentation Foundation (WPF) предполагает наличие независимого от разрешения макета, который обеспечивает более эффективную поддержку мониторов с высоким разрешением, получающих все большее распространение. Вследствие этого Windows Presentation Foundation (WPF) не поддерживает отрисовку сглаженного текста или точечных рисунков в некоторых восточно-азиатских шрифтах, поскольку они являются зависимыми от разрешения.  
  
<a name="further_information"></a>   
## <a name="further-information"></a>Дополнительные сведения  
 [Сведения о технологии ClearType](https://www.microsoft.com/typography/ClearTypeInfo.mspx)  
  
 [Настройки ClearType PowerToy](https://www.microsoft.com/typography/ClearTypePowerToy.mspx)  
  
## <a name="see-also"></a>См. также

- [Параметры реестра ClearType](cleartype-registry-settings.md)
