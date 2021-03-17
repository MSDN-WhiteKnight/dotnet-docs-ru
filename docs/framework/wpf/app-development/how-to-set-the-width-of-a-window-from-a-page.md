---
title: Практическое руководство. Задание ширины окна из страницы
ms.date: 03/30/2017
helpviewer_keywords:
- width of windows [WPF], setting from a page
- windows [WPF], setting width from a page
- pages [WPF], setting window width from
ms.assetid: 31601c92-7889-472a-b07e-bf675ad21c92
ms.openlocfilehash: fee6d4c9ae9dae03e81cc4be56576763cb59958b
ms.sourcegitcommit: 0c48191d6d641ce88d7510e319cf38c0e35697d0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/05/2019
ms.locfileid: "57379358"
---
# <a name="how-to-set-the-width-of-a-window-from-a-page"></a>Практическое руководство. Задание ширины окна из страницы
В этом примере показано задание ширины окна из <xref:System.Windows.Controls.Page>.  
  
## <a name="example"></a>Пример  
 Объект <xref:System.Windows.Controls.Page> можно задать ширину окна ее размещения, задав <xref:System.Windows.Controls.Page.WindowWidth%2A>. Это свойство позволяет <xref:System.Windows.Controls.Page> не были точно знать тип окна, на котором она размещена.  
  
> [!NOTE]
>  Чтобы задать ширину окна с помощью <xref:System.Windows.Controls.Page.WindowWidth%2A>, <xref:System.Windows.Controls.Page> должен быть дочерним элементом окна.  
  
 [!code-xaml[HOWTONavigationSnippets#SetPageWindowWidthXAML](~/samples/snippets/csharp/VS_Snippets_Wpf/HOWTONavigationSnippets/CSharp/SetWindowWidthPage.xaml#setpagewindowwidthxaml)]
