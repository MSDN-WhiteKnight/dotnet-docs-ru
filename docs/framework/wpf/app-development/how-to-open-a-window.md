---
title: Практическое руководство. Откройте окно
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- windows [WPF], opening
- opening windows [WPF]
ms.assetid: 6b91b2bb-fda7-491d-a72e-139dd630a5b0
ms.openlocfilehash: 9ce7ffb3f46dd869fda7893745b531bd02d18ee1
ms.sourcegitcommit: 0c48191d6d641ce88d7510e319cf38c0e35697d0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/05/2019
ms.locfileid: "57373573"
---
# <a name="how-to-open-a-window"></a>Практическое руководство. Откройте окно
В этом примере показано, как открыть окно.  
  
## <a name="example"></a>Пример  
 Открывается окно путем создания экземпляра <xref:System.Windows.Window> и вызов <xref:System.Windows.Window.Show%2A> метод. <xref:System.Windows.Window.Show%2A> Открывает окно и возвращается немедленно без ожидания закрытия нового окна. Этот тип окна называется также *немодальное* окно и не ограничивает ввод данных пользователем.  
  
 [!code-csharp[HOWTOWindowManagementSnippets#OpenNewWindowCODE](~/samples/snippets/csharp/VS_Snippets_Wpf/HOWTOWindowManagementSnippets/CSharp/MainWindow.xaml.cs#opennewwindowcode)]
 [!code-vb[HOWTOWindowManagementSnippets#OpenNewWindowCODE](~/samples/snippets/visualbasic/VS_Snippets_Wpf/HOWTOWindowManagementSnippets/visualbasic/mainwindow.xaml.vb#opennewwindowcode)]  
  
## <a name="net-framework-security"></a>Безопасность платформы .NET Framework  
 Создание экземпляра <xref:System.Windows.Window> требуется разрешение на вызов небезопасных собственных методов (см. в разделе <xref:System.Windows.Window.%23ctor%2A>).
