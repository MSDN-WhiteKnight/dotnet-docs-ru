---
title: Практическое руководство. Создание объекта, следующего за указателем мыши
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- following the mouse pointer (cursor)
- mouse pointer (cursor), making objects follow
- cursor (mouse pointer), making objects follow
ms.assetid: 50b20415-14bc-405c-baf3-2fb254fffde3
ms.openlocfilehash: b9b13b4eec3e42744ba2be6031ec841fb5f215e3
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59107319"
---
# <a name="how-to-make-an-object-follow-the-mouse-pointer"></a>Практическое руководство. Создание объекта, следующего за указателем мыши
В этом примере показано, как изменить размеры объекта, при перемещении указателя мыши на экране.  
  
 В примере [!INCLUDE[TLA#tla_xaml](../../../../includes/tlasharptla-xaml-md.md)] файл, который создает [!INCLUDE[TLA#tla_ui](../../../../includes/tlasharptla-ui-md.md)] и файл кода, который создает обработчик событий.  
  
## <a name="example"></a>Пример  
 Следующие [!INCLUDE[TLA2#tla_titlexaml](../../../../includes/tla2sharptla-titlexaml-md.md)] создает [!INCLUDE[TLA2#tla_ui](../../../../includes/tla2sharptla-ui-md.md)], который состоит из <xref:System.Windows.Shapes.Ellipse> внутри <xref:System.Windows.Controls.StackPanel>и присоединяет обработчик событий для <xref:System.Windows.UIElement.MouseMove> событий.  
  
 [!code-xaml[mouseMoveWithPointer#MouseMoveWithPointerXAML](~/samples/snippets/csharp/VS_Snippets_Wpf/mouseMoveWithPointer/CSharp/Window1.xaml#mousemovewithpointerxaml)]  
  
 Следующий код создает <xref:System.Windows.UIElement.MouseMove> обработчик событий.  При перемещении указателя мыши, высоту и ширину <xref:System.Windows.Shapes.Ellipse> увеличиваются и уменьшаются.  
  
 [!code-csharp[mouseMoveWithPointer#MouseMovePointerGetPosition](~/samples/snippets/csharp/VS_Snippets_Wpf/mouseMoveWithPointer/CSharp/Window1.xaml.cs#mousemovepointergetposition)]
   
  
## <a name="see-also"></a>См. также

- [Общие сведения о входных данных](input-overview.md)
