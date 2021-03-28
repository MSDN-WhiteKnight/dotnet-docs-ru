---
title: Практическое руководство. Переход вперед или назад по журналу навигации
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- history [WPF], navigating forward
- navigation [WPF], through navigation history (forward)
ms.assetid: 5939d574-5f53-469e-85f5-1f2b13607caa
ms.openlocfilehash: 4c20ebfab45a24cf34b1476fb94dae6913fb4d99
ms.sourcegitcommit: 0c48191d6d641ce88d7510e319cf38c0e35697d0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/05/2019
ms.locfileid: "57366664"
---
# <a name="how-to-navigate-forward-or-back-through-navigation-history"></a>Практическое руководство. Переход вперед или назад по журналу навигации
В этом примере показано, как для перехода к записи в журнале переходов вперед или назад.  
  
## <a name="example"></a>Пример  
 Код, выполняемый из содержимого в следующими узлами можно перейти вперед или назад по журналу переходов, одной записи за раз.  
  
-   <xref:System.Windows.Navigation.NavigationWindow> С помощью <xref:System.Windows.Navigation.NavigationService>  
  
-   <xref:System.Windows.Controls.Frame> С помощью <xref:System.Windows.Navigation.NavigationService>  
  
-   Windows Internet Explorer  
  
 Прежде чем можно будет перейти вперед на одну запись, сначала следует проверить, записи в журнале переходов вперед, проверяя **CanGoForward** свойство. Чтобы перейти вперед на одну запись, необходимо вызвать **GoForward** метод. Это показано в следующем примере:  
  
 [!code-csharp[HOWTONavigationSnippets#NavigateForwardCODE](~/samples/snippets/csharp/VS_Snippets_Wpf/HOWTONavigationSnippets/CSharp/HomePage.xaml.cs#navigateforwardcode)]
   
  
 Прежде чем вы можете перейти назад на одну запись, необходимо сначала проверить, записи в журнале переходов назад, проверяя **CanGoBack** свойство. Чтобы перейти назад на одну запись, необходимо вызвать **GoBack** метод. Это показано в следующем примере:  
  
 [!code-csharp[HOWTONavigationSnippets#NavigateBackCODE](~/samples/snippets/csharp/VS_Snippets_Wpf/HOWTONavigationSnippets/CSharp/HomePage.xaml.cs#navigatebackcode)]
   
  
 **Значение свойства CanGoForward**, **GoForward**, **CanGoBack**, и **GoBack** реализуются <xref:System.Windows.Navigation.NavigationWindow>, <xref:System.Windows.Controls.Frame>, и <xref:System.Windows.Navigation.NavigationService>.  
  
> [!NOTE]
>  При вызове метода **GoForward**, и нет записей в журнале переходов вперед, или при вызове **GoBack**, и нет записей в журнале переходов назад, <xref:System.InvalidOperationException> возникает исключение.
