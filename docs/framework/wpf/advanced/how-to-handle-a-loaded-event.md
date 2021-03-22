---
title: Практическое руководство. Обработка загруженного события
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- XAML [WPF], Loaded events
- events [WPF], Loaded
- Loaded events [WPF]
ms.assetid: 0cf8d003-8441-4df4-807a-6db09347e829
ms.openlocfilehash: b8cd2f5e9d848cebb712e7b4930ca39efe48ecc0
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59122555"
---
# <a name="how-to-handle-a-loaded-event"></a>Практическое руководство. Обработка загруженного события
В этом примере демонстрируется обработка <xref:System.Windows.FrameworkElement.Loaded?displayProperty=nameWithType> событий и соответствующий скрипт для обработки этого события. Создает обработчик <xref:System.Windows.Controls.Button> при загрузке страницы.  
  
## <a name="example"></a>Пример  
 В следующем примере используется [!INCLUDE[TLA#tla_xaml](../../../../includes/tlasharptla-xaml-md.md)] вместе с файлом кода.  
  
 [!code-xaml[FELoaded#XAML](~/samples/snippets/csharp/VS_Snippets_Wpf/FELoaded/CSharp/default.xaml#xaml)]  
  
 [!code-csharp[FELoaded#Handler](~/samples/snippets/csharp/VS_Snippets_Wpf/FELoaded/CSharp/default.xaml.cs#handler)]
   
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.FrameworkElement>
- [События времени жизни объекта](object-lifetime-events.md)
- [Общие сведения о перенаправленных событиях](routed-events-overview.md)
- [Практические руководства](base-elements-how-to-topics.md)
