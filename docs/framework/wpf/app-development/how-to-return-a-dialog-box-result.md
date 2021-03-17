---
title: Практическое руководство. Возвращает результат диалогового окна
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- dialog boxes [WPF], returning results
ms.assetid: 4c5cf286-746b-4052-934d-d80cbf8acba3
ms.openlocfilehash: b574a5bbc08d947371837116915c2fc8c13ec81d
ms.sourcegitcommit: 0c48191d6d641ce88d7510e319cf38c0e35697d0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/05/2019
ms.locfileid: "57357772"
---
# <a name="how-to-return-a-dialog-box-result"></a>Практическое руководство. Возвращает результат диалогового окна
В этом примере показано, как получить результат диалогового окна для окна, которое открывается путем вызова <xref:System.Windows.Window.ShowDialog%2A>.  
  
## <a name="example"></a>Пример  
 Прежде чем диалоговое окно закрывается, его <xref:System.Windows.Window.DialogResult%2A> свойство должно быть установлено с <xref:System.Nullable%601> <xref:System.Boolean> , указывающее, каким образом пользователь закрыл диалоговое окно. Это значение возвращается по <xref:System.Windows.Window.ShowDialog%2A> коду клиента для определения способа закрытия диалогового окна и, следовательно, как обрабатывать результат.  
  
> [!NOTE]
>  <xref:System.Windows.Window.DialogResult%2A> можно устанавливать, только если окно было открыто, вызвав <xref:System.Windows.Window.ShowDialog%2A>.  
  
 [!code-csharp[HOWTOWindowManagementSnippets#GetDialogResultCODE](~/samples/snippets/csharp/VS_Snippets_Wpf/HOWTOWindowManagementSnippets/CSharp/MainWindow.xaml.cs#getdialogresultcode)]
 [!code-vb[HOWTOWindowManagementSnippets#GetDialogResultCODE](~/samples/snippets/visualbasic/VS_Snippets_Wpf/HOWTOWindowManagementSnippets/visualbasic/mainwindow.xaml.vb#getdialogresultcode)]  
  
## <a name="net-framework-security"></a>Безопасность платформы .NET Framework  
 Вызов <xref:System.Windows.Window.ShowDialog%2A> требуется разрешение на использование все окна и события пользовательского ввода без ограничений.
