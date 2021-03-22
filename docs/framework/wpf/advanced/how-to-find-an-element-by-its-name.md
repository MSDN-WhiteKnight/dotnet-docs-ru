---
title: Практическое руководство. Поиск элемента по его имени
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- elements [WPF], finding by name
ms.assetid: cfa7cf35-8aa2-4060-9454-872ed4af3f0e
ms.openlocfilehash: 7405f9ba8db5d4db0ce35ca250f13e456685f39b
ms.sourcegitcommit: 0c48191d6d641ce88d7510e319cf38c0e35697d0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/05/2019
ms.locfileid: "57351060"
---
# <a name="how-to-find-an-element-by-its-name"></a>Практическое руководство. Поиск элемента по его имени
В этом примере описывается использование <xref:System.Windows.FrameworkElement.FindName%2A> способ поиска элемента по его <xref:System.Windows.FrameworkElement.Name%2A> значение.  
  
## <a name="example"></a>Пример  
 В этом примере метод для поиска определенного элемента по его имени записывается как обработчик событий кнопки. `stackPanel` — <xref:System.Windows.FrameworkElement.Name%2A> корневого <xref:System.Windows.FrameworkElement> искомых, и в примере метод затем визуально указывает найденный элемент, приводя его <xref:System.Windows.Controls.TextBlock> и изменение одного из <xref:System.Windows.Controls.TextBlock> видимым [!INCLUDE[TLA2#tla_ui](../../../../includes/tla2sharptla-ui-md.md)] свойства.  
  
 [!code-csharp[FEFindName#Find](~/samples/snippets/csharp/VS_Snippets_Wpf/FEFindName/CSharp/default.xaml.cs#find)]
 
