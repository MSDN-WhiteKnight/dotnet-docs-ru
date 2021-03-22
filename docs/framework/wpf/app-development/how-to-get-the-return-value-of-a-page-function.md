---
title: Практическое руководство. Получение возвращаемого значения функции страницы
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- functions [WPF], getting return values of
- page functions [WPF], getting return values of
- return values of page functions [WPF]
- getting [WPF], return values of page functions
ms.assetid: 75470af6-256c-4c46-87e7-705080723a1c
ms.openlocfilehash: 054ffe16690425e118fcac481b2a5ff63f9450f2
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59125072"
---
# <a name="how-to-get-the-return-value-of-a-page-function"></a>Практическое руководство. Получение возвращаемого значения функции страницы
В этом примере показано, как получить результат, возвращаемый функцией страницы.  
  
## <a name="example"></a>Пример  
 Чтобы получить результат, который возвращается из функции страницы, необходимо обрабатывать <xref:System.Windows.Navigation.PageFunction%601.Return> при вызове функции страницы.  
  
 [!code-xaml[HOWTOPageFunctionSnippets#CallAPageFunctionXAML](~/samples/snippets/csharp/VS_Snippets_Wpf/HOWTOPageFunctionSnippets/CSharp/CallingPage.xaml#callapagefunctionxaml)]  
  
 [!code-csharp[HOWTOPageFunctionSnippets#GetPageFunctionResultCODEBEHIND](~/samples/snippets/csharp/VS_Snippets_Wpf/HOWTOPageFunctionSnippets/CSharp/CallingPage.xaml.cs#getpagefunctionresultcodebehind)]
   
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Navigation.PageFunction%601>
