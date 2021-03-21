---
title: Практическое руководство. Перечисление системных шрифтов
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- typography [WPF], enumerating system fonts
- fonts [WPF], enumerating
- system fonts [WPF], enumerating
- enumerating [WPF], system fonts
ms.assetid: 36e37791-55b9-4f01-a496-5cc10335e6a6
ms.openlocfilehash: c7e81b5d1b70ba911a0b505219f7977e019038cf
ms.sourcegitcommit: 0c48191d6d641ce88d7510e319cf38c0e35697d0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/05/2019
ms.locfileid: "57352442"
---
# <a name="how-to-enumerate-system-fonts"></a>Практическое руководство. Перечисление системных шрифтов
## <a name="example"></a>Пример  
 В следующем примере показано, как перечисление шрифтов в коллекции системных шрифтов. Имя семейства шрифтов каждого <xref:System.Windows.Media.FontFamily> в <xref:System.Windows.Media.Fonts.SystemFontFamilies%2A> добавляется как элемент в поле со списком.  
  
 [!code-csharp[TextOverview#100](~/samples/snippets/csharp/VS_Snippets_Wpf/TextOverview/CSharp/Window1.xaml.cs#100)]
   
  
 Если несколько версий одного семейства шрифтов, находятся в том же каталоге, [!INCLUDE[TLA#tla_winclient](../../../../includes/tlasharptla-winclient-md.md)] перечисление шрифтов возвращает самую последнюю версию шрифта. Если сведения о версии не предоставляют разрешения, возвращается шрифта с последней отметкой. Если метки времени эквивалентно, возвращается файл шрифта, который является первым в алфавитном порядке.
