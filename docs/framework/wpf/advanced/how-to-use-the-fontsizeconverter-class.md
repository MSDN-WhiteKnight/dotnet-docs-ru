---
title: Практическое руководство. Использование класса FontSizeConverter
ms.date: 03/30/2017
helpviewer_keywords:
- FontSizeConverter objects [WPF]
- typography [WPF], FontSizeConverter objects
ms.assetid: 3b0592bd-7223-4860-a108-a5d72f3a9178
ms.openlocfilehash: f33a297ae07d5509d2b4d9a98636086ac433a57f
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59088188"
---
# <a name="how-to-use-the-fontsizeconverter-class"></a>Практическое руководство. Использование класса FontSizeConverter
## <a name="example"></a>Пример  
 В этом примере показано, как создать экземпляр <xref:System.Windows.FontSizeConverter> и использовать его для изменения размера шрифта.  
  
 В примере определяется пользовательский метод с именем `changeSize` , преобразующий содержимое <xref:System.Windows.Controls.ListBoxItem>, как определено в отдельном [!INCLUDE[TLA#tla_xaml](../../../../includes/tlasharptla-xaml-md.md)] файл, чтобы экземпляр <xref:System.Double>и более поздних версий в <xref:System.String>. Этот метод передает <xref:System.Windows.Controls.ListBoxItem> для <xref:System.Windows.FontSizeConverter> объект, который преобразует <xref:System.Windows.Controls.ContentControl.Content%2A> из <xref:System.Windows.Controls.ListBoxItem> к экземпляру <xref:System.Double>. Это значение затем передается обратно в качестве значения <xref:System.Windows.Controls.TextBlock.FontSize%2A> свойство <xref:System.Windows.Controls.TextBlock> элемент.  
  
 В этом примере также определяется второй пользовательский метод, вызываемый `changeFamily`. Этот метод преобразует <xref:System.Windows.Controls.ContentControl.Content%2A> из <xref:System.Windows.Controls.ListBoxItem> для <xref:System.String>, а затем передает это значение <xref:System.Windows.Controls.TextBlock.FontFamily%2A> свойство <xref:System.Windows.Controls.TextBlock> элемент.  
  
 Этот пример не запускается.  
  
 [!code-csharp[FontSizeConverter#1](~/samples/snippets/csharp/VS_Snippets_Wpf/FontSizeConverter/CSharp/Window1.xaml.cs#1)]  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.FontSizeConverter>
