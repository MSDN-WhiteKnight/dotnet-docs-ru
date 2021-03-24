---
title: Практическое руководство. Использование автоматической разметки для создания кнопки
ms.date: 03/30/2017
helpviewer_keywords:
- Button controls [WPF], creating with automatic layout
- automatic layout [WPF], creating buttons
ms.assetid: 96c206d0-9e77-4784-9d2d-5045aed2021c
ms.openlocfilehash: 8eb1e93dd87c210812c9b7758c744a616ef2d862
ms.sourcegitcommit: 3630c2515809e6f4b7dbb697a3354efec105a5cd
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/25/2019
ms.locfileid: "58409787"
---
# <a name="how-to-use-automatic-layout-to-create-a-button"></a>Практическое руководство. Использование автоматической разметки для создания кнопки
В этом примере описывается, как использовать автоматическую разметку для создания кнопки в локализуемом приложении.  
  
 Локализация [!INCLUDE[TLA#tla_ui](../../../../includes/tlasharptla-ui-md.md)] может занять много времени. Часто при локализации, помимо перевода текста, необходимо изменять размеры и положение элементов. В прошлом каждый язык, UI переводился требовал коррекции. Теперь с возможностями Windows Presentation Foundation (WPF) можно разрабатывать элементы, сокращающие потребность в коррекции. Подход к написанию приложений, в которых проще изменять размер и положение элементов, называется `automatic layout`.  
  
## <a name="example"></a>Пример  

Следующие два [!INCLUDE[TLA#tla_xaml](../../../../includes/tlasharptla-xaml-md.md)] примеры создания приложений, позволяющих создать экземпляр кнопки: один с англоязычным текстом и один с текстом на испанском языке. Обратите внимание на то, что код является одинаковым, за исключением текста. Размер кнопки изменяется в соответствии с размером текста.

[!code-xaml[LocalizationBtn_snip#1](~/samples/snippets/csharp/VS_Snippets_Wpf/LocalizationBtn_snip/CS/Pane1.xaml#1)]  
  
[!code-xaml[LocalizationBtn#1](~/samples/snippets/csharp/VS_Snippets_Wpf/LocalizationBtn/CS/Pane1.xaml#1)]  
  
 На следующем рисунке показан выходные данные примеры кода с изменяемыми размерами автоматически кнопками:
  
 ![Та же кнопка с текстовой подписью на различных языках](./media/use-automatic-layout-overview/auto-resizable-button.png)  
  
## <a name="see-also"></a>См. также

- [Обзор использования автоматической разметки](use-automatic-layout-overview.md)
- [Использование сетки для автоматической разметки](how-to-use-a-grid-for-automatic-layout.md)
