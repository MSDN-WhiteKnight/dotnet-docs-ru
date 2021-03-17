---
title: Практическое руководство. Отображение окна сообщения
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- message boxes [WPF], opening
- opening message boxes [WPF]
ms.assetid: acaad17f-af43-4eca-a004-f1c9e7c6f292
ms.openlocfilehash: cf7534cdee5e17d53e95294573023d660135e395
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59101111"
---
# <a name="how-to-open-a-message-box"></a>Практическое руководство. Отображение окна сообщения
В этом примере показано, как открыть окно сообщения.  
  
## <a name="example"></a>Пример  
 Окно сообщения — это готовое модальное диалоговое окно для отображения сведений для пользователей. Открывается окно сообщения путем вызова статического <xref:System.Windows.MessageBox.Show%2A> метод <xref:System.Windows.MessageBox> класса. Когда <xref:System.Windows.MessageBox.Show%2A> является именем, сообщение, передается с помощью параметра строки. Несколько перегрузок <xref:System.Windows.MessageBox.Show%2A> дают возможность настраивать, как будет выглядеть окно сообщения (см. в разделе <xref:System.Windows.MessageBox>).  
  
 [!code-csharp[MessageBoxSnippets#MessageBoxShow1CODE](~/samples/snippets/csharp/VS_Snippets_Wpf/MessageBoxSnippets/CSharp/Show1Window.xaml.cs#messageboxshow1code)]
 [!code-vb[MessageBoxSnippets#MessageBoxShow1CODE](~/samples/snippets/visualbasic/VS_Snippets_Wpf/MessageBoxSnippets/visualbasic/show1window.xaml.vb#messageboxshow1code)]  
  
## <a name="see-also"></a>См. также

- [Пример MessageBox](https://go.microsoft.com/fwlink/?LinkID=160023)
