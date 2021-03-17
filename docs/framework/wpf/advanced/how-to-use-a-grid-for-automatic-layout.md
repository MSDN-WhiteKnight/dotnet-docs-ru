---
title: Практическое руководство. Использование сетки для автоматического макета
ms.date: 03/30/2017
helpviewer_keywords:
- grids [WPF], automatic layout
- automatic layout [WPF], grid use
ms.assetid: ab9de407-e0c1-4047-bdf0-24951bf73879
ms.openlocfilehash: 590ad7292fea572b20ccaa09ce2886724e004a6a
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59227136"
---
# <a name="how-to-use-a-grid-for-automatic-layout"></a>Практическое руководство. Использование сетки для автоматического макета
В этот примере описаны способы использования сетки для автоматической разметки с целью создания локализуемого приложения.  
  
 Локализация [!INCLUDE[TLA#tla_ui](../../../../includes/tlasharptla-ui-md.md)] может занять много времени. Часто при локализации, помимо перевода текста, необходимо изменять размеры и положение элементов. В прошлом каждый язык, [!INCLUDE[TLA2#tla_ui](../../../../includes/tla2sharptla-ui-md.md)] переводился требовал коррекции. Теперь с возможностями [!INCLUDE[TLA#tla_winclient](../../../../includes/tlasharptla-winclient-md.md)] можно разрабатывать элементы, сокращающие потребность в коррекции. Подход к написанию приложений, в которых проще изменять размер и положение элементов, называется `auto layout`.  
  
 Следующие [!INCLUDE[TLA#tla_xaml](../../../../includes/tlasharptla-xaml-md.md)] примере демонстрируется использование сетки для размещения нескольких кнопок и текста. Обратите внимание на то, что высоты и ширины ячейки установлено значение `Auto`; поэтому ячейку, которая содержит кнопку с изображением, изменяется в соответствии изображение. Так как <xref:System.Windows.Controls.Grid> элемента можно настроить на его содержимое, бывает полезно при использовании автоматической разметки для разработки приложений, которые могут быть локализованы.  
  
## <a name="example"></a>Пример  
 В приведенном ниже примере показано использование сетки.  
  
 [!code-xaml[LocalizationGrid#1](~/samples/snippets/csharp/VS_Snippets_Wpf/LocalizationGrid/CS/Pane1.xaml#1)]  
  
 На приведенном ниже рисунке показан результат выполнения примера кода.  
  
 ![Пример сетки](./media/glob-grid.png "glob_grid")  
Grid  
  
## <a name="see-also"></a>См. также

- [Обзор использования автоматической разметки](use-automatic-layout-overview.md)
- [Использование автоматического макета для создания кнопки](how-to-use-automatic-layout-to-create-a-button.md)
