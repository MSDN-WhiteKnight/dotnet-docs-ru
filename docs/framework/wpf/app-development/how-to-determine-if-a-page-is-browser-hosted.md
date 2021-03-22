---
title: Практическое руководство. Определение, размещена ли страница в браузере
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- hosted pages in browser [WPF]
- pages [WPF], hosted in browser
ms.assetid: 737e0f26-8371-49b4-9579-70879e51e1aa
ms.openlocfilehash: d154de2f885101d1bd0c4613dfb1604be8acbe6a
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59107150"
---
# <a name="how-to-determine-if-a-page-is-browser-hosted"></a>Практическое руководство. Определение, размещена ли страница в браузере
В этом примере показано, как определить, если <xref:System.Windows.Controls.Page> размещается в браузере.  
  
## <a name="example"></a>Пример  
 Объект <xref:System.Windows.Controls.Page> может размещаться независимо и, следовательно, может быть загружена в несколько различных типов узлов, включая <xref:System.Windows.Controls.Frame>, <xref:System.Windows.Navigation.NavigationWindow>, или другой браузер. Это может произойти, если у вас есть библиотечная сборка, содержащий одну или несколько страниц, на который ссылаются несколько автономных и отображаемых в обозревателе ([!INCLUDE[TLA#tla_xbap](../../../../includes/tlasharptla-xbap-md.md)]) размещения приложений.  
  
 Следующий пример демонстрирует, как использовать <xref:System.Windows.Interop.BrowserInteropHelper.IsBrowserHosted%2A?displayProperty=nameWithType> на предмет <xref:System.Windows.Controls.Page> размещается в браузере.  
  
 [!code-csharp[HOWTOBrowserInteropHelperSnippets#IsBrowserHostedCODE](~/samples/snippets/csharp/VS_Snippets_Wpf/HOWTOBrowserInteropHelperSnippets/CSharp/Page1.xaml.cs#isbrowserhostedcode)]
   
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Controls.Frame>
- <xref:System.Windows.Controls.Page>
