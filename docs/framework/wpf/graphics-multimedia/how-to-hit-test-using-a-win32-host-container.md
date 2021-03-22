---
title: Практическое руководство. Проверка попадания с использованием контейнера узла Win32
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- hit tests [WPF], using Win32 host containers
- visual objects [WPF], hit tests on
- Win32 host containers [WPF], hit tests using
ms.assetid: 9491f7f3-d8ba-4573-a888-2f064d1349dc
ms.openlocfilehash: ac5cae5bcd94dc8bf80ff95b8971914e1fa5ba2c
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59081467"
---
# <a name="how-to-hit-test-using-a-win32-host-container"></a>Практическое руководство. Проверка попадания с использованием контейнера узла Win32
Можно создать визуальные объекты в пределах [!INCLUDE[TLA#tla_win32](../../../../includes/tlasharptla-win32-md.md)] окно путем предоставления контейнера окна для визуальных объектов. Чтобы обрабатывать события для содержащихся визуальных объектов, выполняется обработка сообщений, переданных в цикл фильтрации сообщений контейнера окна. Ссылаться на [руководства: По размещению визуальных объектов в приложении Win32](tutorial-hosting-visual-objects-in-a-win32-application.md) Дополнительные сведения о способах размещения визуальных объектов в [!INCLUDE[TLA2#tla_win32](../../../../includes/tla2sharptla-win32-md.md)] окна.  
  
## <a name="example"></a>Пример  
 Ниже показано, как настроить обработчики событий мыши для [!INCLUDE[TLA2#tla_win32](../../../../includes/tla2sharptla-win32-md.md)] окно, которое используется как контейнер для визуальных объектов.  
  
 [!code-csharp[VisualsHitTesting#103](~/samples/snippets/csharp/VS_Snippets_Wpf/VisualsHitTesting/CSharp/MyWindow.cs#103)]
   
  
 Приведенный ниже показано, как настроить проверку нажатия в ответ на перехват определенных событий мыши.  
  
 [!code-csharp[VisualsHitTesting#104](~/samples/snippets/csharp/VS_Snippets_Wpf/VisualsHitTesting/CSharp/MyCircle.cs#104)]
   
  
 <xref:System.Windows.Interop.HwndSource> Объект представляет [!INCLUDE[TLA#tla_winclient](../../../../includes/tlasharptla-winclient-md.md)] содержимого в пределах [!INCLUDE[TLA#tla_win32](../../../../includes/tlasharptla-win32-md.md)] окна. Значение <xref:System.Windows.Interop.HwndSource.RootVisual%2A> свойство <xref:System.Windows.Interop.HwndSource> представляет верхний узел в иерархии визуального дерева.  
  
 Полный пример проверки попадания объектов с помощью контейнера Win32 см. в разделе [проверка нажатия с помощью примера взаимодействия Win32](https://go.microsoft.com/fwlink/?LinkID=159995).  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Interop.HwndSource>
- [Проверка попадания на визуальном уровне](hit-testing-in-the-visual-layer.md)
- [Учебник. Размещение визуальных объектов в приложении Win32](tutorial-hosting-visual-objects-in-a-win32-application.md)
