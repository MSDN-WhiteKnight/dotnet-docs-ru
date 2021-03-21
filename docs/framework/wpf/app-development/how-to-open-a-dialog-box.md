---
title: Практическое руководство. Отображение диалогового окна
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- opening dialog boxes [WPF]
- dialog boxes [WPF], opening
ms.assetid: 6b1557d2-da98-4ef4-9f68-4089f04ab9ea
ms.openlocfilehash: 70ac31285dd22244b4bd6ad0d188d182eb6e6264
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59084991"
---
# <a name="how-to-open-a-dialog-box"></a>Практическое руководство. Отображение диалогового окна
В этом примере показано, как открыть диалоговое окно.  
  
## <a name="example"></a>Пример  
 Диалоговое окно является окном, которое открывается путем создания экземпляра <xref:System.Windows.Window> и вызов <xref:System.Windows.Window.ShowDialog%2A> метод. <xref:System.Windows.Window.ShowDialog%2A> Открывает окно и не отвечала до новое диалоговое окно было закрыто. Этот тип окна называется также *модального* окно и ограничивает ввод данных пользователем.  
  
 [!code-csharp[HOWTOWindowManagementSnippets#OpenNewDialogBoxCODE](~/samples/snippets/csharp/VS_Snippets_Wpf/HOWTOWindowManagementSnippets/CSharp/MainWindow.xaml.cs#opennewdialogboxcode)]
   
  
## <a name="net-framework-security"></a>Безопасность платформы .NET Framework  
 Вызов <xref:System.Windows.Window.ShowDialog%2A> требуется разрешение на использование все окна и события пользовательского ввода без ограничений.  
  
## <a name="see-also"></a>См. также

- [Возвращение результата диалогового окна](how-to-return-a-dialog-box-result.md)
