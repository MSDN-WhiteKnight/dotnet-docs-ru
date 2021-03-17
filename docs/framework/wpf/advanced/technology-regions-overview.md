---
title: Общие сведения об областях применения технологий
ms.date: 03/30/2017
helpviewer_keywords:
- window regions [WPF]
- Win32 code [WPF], WPF interoperation
- Win32 code [WPF], airspace
- airspace [WPF]
- interoperability [WPF], airspace
- Win32 code [WPF], window regions
ms.assetid: b7cc350f-b9e2-48b1-be14-60f3d853222e
ms.openlocfilehash: 911ba1474677f26a773ff63e958ba0ceedbefd0d
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59100981"
---
# <a name="technology-regions-overview"></a>Общие сведения об областях применения технологий
Если в приложении используются несколько технологий представления, такие как WPF, Win32 или DirectX, то они должны совместно использовать области отрисовки в общем окне верхнего уровня. В этом разделе описываются проблемы, которые могут повлиять на представление и выходные данные приложения взаимодействия с WPF.  
  
## <a name="regions"></a>Области  
 В окне верхнего уровня можно представить, что каждый HWND, который представляет собой одну из технологий приложения взаимодействия, имеет собственную область (также называемую "свободное пространство"). Каждый пиксель в окне принадлежит только одному дескриптору HWND, который определяет область этого HWND. (Строго говоря, существует более одной области [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)], если имеется более одного HWND [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)], но для целей этого обсуждения можно предположить, что есть только один). Область подразумевает, что все слои или другие окна, которые пытаются отобразиться поверх этого пикселя во время существования приложения, должны быть частью одной и той же технологии уровня отрисовки. Попытка отобразить пиксели [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] поверх [!INCLUDE[TLA2#tla_win32](../../../../includes/tla2sharptla-win32-md.md)] приводит к нежелательным результатам и в максимально возможной степени запрещается через взаимодействие [!INCLUDE[TLA2#tla_api#plural](../../../../includes/tla2sharptla-apisharpplural-md.md)].  
  
### <a name="region-examples"></a>Примеры областей  
 На следующем рисунке показано приложение, в котором одновременно используются [!INCLUDE[TLA2#tla_win32](../../../../includes/tla2sharptla-win32-md.md)], [!INCLUDE[TLA2#tla_dx](../../../../includes/tla2sharptla-dx-md.md)] и [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)]. Каждая технология использует отдельный, неперекрывающийся набор пикселей, и проблемы с областями отсутствуют.  
  
 ![Окно, которое не имеет проблем со свободным пространством](./media/migrationinteroparchitectarticle01.png "MigrationInteropArchitectArticle01")  
  
 Предположим, что это приложение использует положение указателя мыши для создания анимации, которая пытается выполнить отрисовку поверх любой из этих трех областей. Независимо от того, какая технология отвечает за анимацию, эта технология нарушила бы область двух других. На рисунке показана попытка отрисовать круг WPF поверх области Win32.  
  
 ![Схема взаимодействия](./media/migrationinteroparchitectarticle02.png "MigrationInteropArchitectArticle02")  
  
 Другое нарушение — это попытка использовать прозрачность/альфа-смешение между различными технологиями.  На следующей иллюстрации окно [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] нарушает области [!INCLUDE[TLA2#tla_win32](../../../../includes/tla2sharptla-win32-md.md)] и [!INCLUDE[TLA2#tla_dx](../../../../includes/tla2sharptla-dx-md.md)]. Так как пиксели в этом окне [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] являются полупрозрачными, они должны принадлежать и [!INCLUDE[TLA2#tla_dx](../../../../includes/tla2sharptla-dx-md.md)], и [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)], что невозможно.  Так что это еще одно нарушение, и его нельзя построить.  
  
 ![Схема взаимодействия](./media/migrationinteroparchitectarticle03.png "MigrationInteropArchitectArticle03")  
  
 В предыдущих трех примерах использовались прямоугольные области, но возможны разные формы.  Например, в области может быть отверстие. На следующем рисунке показана область [!INCLUDE[TLA2#tla_win32](../../../../includes/tla2sharptla-win32-md.md)] с прямоугольным отверстием. Это размер областей [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] и [!INCLUDE[TLA2#tla_dx](../../../../includes/tla2sharptla-dx-md.md)] вместе.  
  
 ![Схема взаимодействия](./media/migrationinteroparchitectarticle04.png "MigrationInteropArchitectArticle04")  
  
 Области также могут быть полностью непрямоугольными или иметь любую форму, описываемую [!INCLUDE[TLA2#tla_win32](../../../../includes/tla2sharptla-win32-md.md)] HRGN (область).  
  
 ![Схема взаимодействия](./media/migrationinteroparchitectarticle05.png "MigrationInteropArchitectArticle05")  
  
## <a name="transparency-and-top-level-windows"></a>Прозрачность и окна верхнего уровня  
 Диспетчер окон Windows в действительности обрабатывает только HWND [!INCLUDE[TLA2#tla_win32](../../../../includes/tla2sharptla-win32-md.md)]. Таким образом каждый [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] <xref:System.Windows.Window> является HWND. <xref:System.Windows.Window> HWND должны соблюдаться общие правила для любого HWND. Внутри этого HWND код [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] может выполнять любую поддержку [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] [!INCLUDE[TLA2#tla_api#plural](../../../../includes/tla2sharptla-apisharpplural-md.md)]. Но для взаимодействия с другими HWND на рабочем столе [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] должен соответствовать правилам обработки и отрисовки [!INCLUDE[TLA2#tla_win32](../../../../includes/tla2sharptla-win32-md.md)].  [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] поддерживает непрямоугольные окна с помощью [!INCLUDE[TLA2#tla_win32](../../../../includes/tla2sharptla-win32-md.md)] [!INCLUDE[TLA2#tla_api#plural](../../../../includes/tla2sharptla-apisharpplural-md.md)]— HRGN для непрямоугольных окон и многослойные окна для альфа на пиксель.  
  
 Постоянные альфа- и цветовые ключи не поддерживаются.  [!INCLUDE[TLA2#tla_win32](../../../../includes/tla2sharptla-win32-md.md)] возможности многослойных окон зависят от платформы.  
  
 Многослойные окна позволяют сделать все окно прозрачным (полупрозрачным), указав альфа-значение, которое применяется к каждому пикселю в окне.  ([!INCLUDE[TLA2#tla_win32](../../../../includes/tla2sharptla-win32-md.md)] фактически поддерживает альфа-смешение на уровне отдельных пикселей, но это очень сложно использовать в практических программах, потому что в этом режиме нужно рисовать все дочерние HWND самостоятельно, включая диалоговые окна и выпадающие списки).  
  
 [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] поддерживает HRGN. Тем не менее, есть нет управляемых [!INCLUDE[TLA2#tla_api#plural](../../../../includes/tla2sharptla-apisharpplural-md.md)] для использования этой функции. Можно использовать платформу вызова и <xref:System.Windows.Interop.HwndSource> для вызова соответствующего [!INCLUDE[TLA2#tla_win32](../../../../includes/tla2sharptla-win32-md.md)] [!INCLUDE[TLA2#tla_api#plural](../../../../includes/tla2sharptla-apisharpplural-md.md)]. Дополнительную информацию см. в разделе [Вызов встроенных функций из управляемого кода](/cpp/dotnet/calling-native-functions-from-managed-code).  
  
 [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] Многослойные окна имеют разные функциональные возможности в различных операционных системах. Это связано с тем, что [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] использует [!INCLUDE[TLA2#tla_dx](../../../../includes/tla2sharptla-dx-md.md)] для отрисовки, а многослойные окна были в первую очередь предназначены для отрисовки [!INCLUDE[TLA2#tla_gdi](../../../../includes/tla2sharptla-gdi-md.md)], а не [!INCLUDE[TLA2#tla_dx](../../../../includes/tla2sharptla-dx-md.md)].  
  
-   [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] поддерживает аппаратное ускорение многослойных окон в [!INCLUDE[TLA#tla_longhorn](../../../../includes/tlasharptla-longhorn-md.md)] и более поздних версий. Для многослойных окон с аппаратным ускорением в [!INCLUDE[TLA2#tla_winxp](../../../../includes/tla2sharptla-winxp-md.md)] требуется поддержка [!INCLUDE[TLA#tla_dx](../../../../includes/tlasharptla-dx-md.md)], поэтому их возможности будут зависеть от версии [!INCLUDE[TLA#tla_dx](../../../../includes/tlasharptla-dx-md.md)] на данном компьютере.  
  
-   [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] не поддерживает цветовые ключи прозрачности, так как [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] не может гарантировать отрисовку необходимого цвета, особенно при использовании аппаратного ускорения.  
  
-   Если приложение работает в [!INCLUDE[TLA2#tla_winxp](../../../../includes/tla2sharptla-winxp-md.md)], многослойные окна поверх поверхностей [!INCLUDE[TLA2#tla_dx](../../../../includes/tla2sharptla-dx-md.md)] мерцают при отрисовке приложения [!INCLUDE[TLA2#tla_dx](../../../../includes/tla2sharptla-dx-md.md)].  (Фактическая последовательность отрисовки заключается в том, что [!INCLUDE[TLA#tla_gdi](../../../../includes/tlasharptla-gdi-md.md)] скрывает многослойное окно, выполняется рисование [!INCLUDE[TLA2#tla_dx](../../../../includes/tla2sharptla-dx-md.md)], а затем возвращает [!INCLUDE[TLA#tla_gdi](../../../../includes/tlasharptla-gdi-md.md)] многослойное окно).  Это ограничение накладывается и на многослойные окна вне [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)].  
  
## <a name="see-also"></a>См. также

- [Взаимодействие WPF и Win32](wpf-and-win32-interoperation.md)
- [Пошаговое руководство. Размещение часов WPF в Win32](walkthrough-hosting-a-wpf-clock-in-win32.md)
- [Размещение содержимого Win32 в WPF](hosting-win32-content-in-wpf.md)
