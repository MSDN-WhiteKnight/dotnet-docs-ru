---
title: Общие сведения о TextBlock
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- controls [WPF], TextBlock
- TextBlock control [WPF]
ms.assetid: 24720bca-341a-4b03-8a6b-7a678023b10a
ms.openlocfilehash: ce7da2b9c9c8e2a3a24d3acf18396ca447ac3f27
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59203474"
---
# <a name="textblock-overview"></a>Общие сведения о TextBlock
<xref:System.Windows.Controls.TextBlock> Управления обеспечивает гибкую поддержку текста для WPF приложений. Элемент в основном предназначен для базовых сценариев UI, которые не требуют более одного абзаца текста. Он поддерживает ряд свойств, которые обеспечивают точный контроль представления, такие как <xref:System.Windows.Controls.TextBlock.FontFamily%2A>, <xref:System.Windows.Controls.TextBlock.FontSize%2A>, <xref:System.Windows.Controls.TextBlock.FontWeight%2A>, <xref:System.Windows.Controls.TextBlock.TextEffects%2A>, и <xref:System.Windows.Controls.TextBlock.TextWrapping%2A>. Текстовое содержимое можно добавить с помощью <xref:System.Windows.Controls.TextBlock.Text%2A> свойство. При использовании в XAML содержимое между открывающим и закрывающим тегами неявно добавляется в качестве текста элемента.  
  
 Объект <xref:System.Windows.Controls.TextBlock> элемент могут создаваться очень просто с помощью XAML.  
  
 [!code-xaml[TextBlockSnip_XAML#2](~/samples/snippets/csharp/VS_Snippets_Wpf/TextBlockSnip_XAML/CS/default.xaml#2)]  
  
 Аналогично, использование <xref:System.Windows.Controls.TextBlock> элемента в коде приложения относительно прост.  
  
 [!code-csharp[TextBlockSnip#1](~/samples/snippets/csharp/VS_Snippets_Wpf/TextBlockSnip/CSharp/TextBlockSnips.cs#1)]
   
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Controls.Label>
