---
title: Учебник. Размещение визуальных объектов в приложении Win32
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- visual objects in Win32 code [WPF]
- Win32 code [WPF], visual objects in
- hosting [WPF], visual objects in Win32 code
ms.assetid: f0e1600c-3217-43d5-875d-1864fa7fe628
ms.openlocfilehash: b260f96246f0d9e5447b74a05e1396bfef176197
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59111466"
---
# <a name="tutorial-hosting-visual-objects-in-a-win32-application"></a>Учебник. Размещение визуальных объектов в приложении Win32
Windows Presentation Foundation (WPF) предоставляет среду с широкими возможностями для создания приложений. Тем не менее, если имеются существенные преимущества в [!INCLUDE[TLA#tla_win32](../../../../includes/tlasharptla-win32-md.md)] код, он может быть более эффективно добавить WPF функциональные возможности приложения, а не переписывать код. Чтобы обеспечить поддержку [!INCLUDE[TLA#tla_win32](../../../../includes/tlasharptla-win32-md.md)] и WPF графических подсистем, одновременно используемых в приложении, WPF предоставляет механизм для размещения объектов в Win32 окна.  
  
 Этом руководстве описывается создание примера приложения, [проверка нажатия с помощью примера взаимодействия Win32](https://go.microsoft.com/fwlink/?LinkID=159995), в котором узлы WPF визуальные объекты в Win32 окна.  

<a name="requirements"></a>   
## <a name="requirements"></a>Требования  
 В этом учебнике предполагается, что вы знакомы с основами программирования в WPF и Win32. Основные сведения о WPF программирования, см. в разделе [Пошаговое руководство: Создание первого классического приложения WPF](../getting-started/walkthrough-my-first-wpf-desktop-application.md). Общие сведения о Win32 программирования, см. в разделе любой из многочисленных книг по этой теме, в частности *программирования Windows* Чарльза Петцольда.  
  
> [!NOTE]
>  Этот учебник включает ряд примеров кода из связанного образца приложения. Однако для удобства чтения он не содержит полный пример кода. Полный образец кода, см. в разделе [проверка нажатия с помощью примера взаимодействия Win32](https://go.microsoft.com/fwlink/?LinkID=159995).  
  
<a name="creating_the_host_win32_window"></a>   
## <a name="creating-the-host-win32-window"></a>Создание окна размещения Win32  
 Ключом к размещению WPF объекты в Win32 окно <xref:System.Windows.Interop.HwndSource> класса. Этот класс заключает WPF объекты в Win32 окна, позволяя им должна быть включена в ваш UI  как дочернего окна.  
  
 В примере показан код для создания <xref:System.Windows.Interop.HwndSource> объекта в виде Win32 окна контейнера для визуальных объектов. Чтобы задать стиль окна, положение и другие параметры для Win32 окно, используйте <xref:System.Windows.Interop.HwndSourceParameters> объекта.  
  
 [!code-csharp[VisualsHitTesting#101](~/samples/snippets/csharp/VS_Snippets_Wpf/VisualsHitTesting/CSharp/MyWindow.cs#101)]
   
  
> [!NOTE]
>  Значение <xref:System.Windows.Interop.HwndSourceParameters.ExtendedWindowStyle%2A> свойство нельзя установить значение WS_EX_TRANSPARENT. Это означает, что узел Win32 окно не может быть прозрачным. По этой причине цвет фона узла Win32 окно присваивается один и тот же цвет фона родительского окна.  
  
<a name="adding_visual_objects_to_the_host_win32_window"></a>   
## <a name="adding-visual-objects-to-the-host-win32-window"></a>Добавление визуальных объектов в окно размещения Win32  
 После создания узла Win32 окна контейнера для визуальных объектов, к нему можно добавить визуальные объекты. Необходимо убедиться, что любые преобразования визуальных объектов, такие как анимация, не выходят за пределы узла Win32 ограничивающего прямоугольника окна.  
  
 В примере показан код для создания <xref:System.Windows.Interop.HwndSource> объекта и добавления в него визуальных объектов.  
  
> [!NOTE]
>  <xref:System.Windows.Interop.HwndSource.RootVisual%2A> Свойство <xref:System.Windows.Interop.HwndSource> присваивается первый визуальный объект, добавленный к узлу Win32 окна. Корневой визуальный объект определяет верхний узел дерева визуальных объектов. Все последующие визуальные объекты, добавленные в главное Win32 окна добавляются как дочерние объекты.  
  
 [!code-csharp[VisualsHitTesting#100](~/samples/snippets/csharp/VS_Snippets_Wpf/VisualsHitTesting/CSharp/MyWindow.cs#100)]
   
  
<a name="implementing_the_win32_message_filter"></a>   
## <a name="implementing-the-win32-message-filter"></a>Реализация фильтра сообщений Win32  
 Узел Win32 окно для визуальных объектов требуется процедура фильтра сообщений окна для обработки сообщений, отправленных в окно из очереди приложения. Процедура окна получает сообщения от Win32 системы. Это могут быть входные сообщения или сообщения управления окнами. Сообщение можно обработать в процедуре окна или передать системе для обработки по умолчанию.  
  
 <xref:System.Windows.Interop.HwndSource> Объект, который вы определили в качестве родительского для визуальных объектов необходимо обращаться вами процедуру фильтра сообщений окна. При создании <xref:System.Windows.Interop.HwndSource> установите <xref:System.Windows.Interop.HwndSourceParameters.HwndSourceHook%2A> свойство для ссылки на процедуру окна.  
  
 [!code-csharp[VisualsHitTesting#102](~/samples/snippets/csharp/VS_Snippets_Wpf/VisualsHitTesting/CSharp/MyWindow.cs#102)]
   
  
 В следующем примере показан код для обработки сообщений при отпускании левой и правой кнопок мыши. Значение координаты мыши была нажата содержится в значении параметра `lParam` параметр.  
  
 [!code-csharp[VisualsHitTesting#103](~/samples/snippets/csharp/VS_Snippets_Wpf/VisualsHitTesting/CSharp/MyWindow.cs#103)]
   
  
<a name="processing_the_win32_messages"></a>   
## <a name="processing-the-win32-messages"></a>Обработка сообщений Win32  
 Код в следующем примере показано, как выполняется нажатия иерархии визуальных объектов, содержащихся в окне размещения Win32 окна. Можно определить, находится ли точка в пределах визуального объекта, с помощью <xref:System.Windows.Media.VisualTreeHelper.HitTest%2A> метод, чтобы задать корневой визуальный объект и значение координаты для проверки нажатия. В этом случае корневой визуальный объект является значение <xref:System.Windows.Interop.HwndSource.RootVisual%2A> свойство <xref:System.Windows.Interop.HwndSource> объекта.  
  
 [!code-csharp[VisualsHitTesting#104](~/samples/snippets/csharp/VS_Snippets_Wpf/VisualsHitTesting/CSharp/MyCircle.cs#104)]
   
  
 Дополнительные сведения о проверке нажатия для визуальных объектов, см. в разделе [проверка нажатия на визуальном уровне](hit-testing-in-the-visual-layer.md).  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Interop.HwndSource>
- [Попадания с помощью примера взаимодействия Win32](https://go.microsoft.com/fwlink/?LinkID=159995)
- [Проверка попадания на визуальном уровне](hit-testing-in-the-visual-layer.md)
