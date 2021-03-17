---
title: Практическое руководство. Привязка элемента ListBox к данным
ms.date: 03/30/2017
helpviewer_keywords:
- ListBox controls [WPF], binding data to
- data binding [WPF], ListBox control
- binding data [WPF], to ListBox control
ms.assetid: de93a907-709a-44a7-84bf-578b846a3d8b
ms.openlocfilehash: 4dea53a524247d18628b3e7e7b2c06906dced53d
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59106446"
---
# <a name="how-to-bind-a-listbox-to-data"></a>Практическое руководство. Привязка элемента ListBox к данным
Разработчик приложения можно создать <xref:System.Windows.Controls.ListBox> элементы управления без указания содержимого каждого <xref:System.Windows.Controls.ListBoxItem> отдельно. Можно использовать привязку данных для привязки данных для отдельных элементов.  
  
 В следующем примере показано, как создать <xref:System.Windows.Controls.ListBox> , заполняющий <xref:System.Windows.Controls.ListBoxItem> элементов путем привязки данных к источнику данных с именем *цвета*. В этом случае необязательно использовать <xref:System.Windows.Controls.ListBoxItem> теги для указания содержимого каждого элемента.  
  
## <a name="example"></a>Пример  
 [!code-xaml[ListBoxEvent#7](~/samples/snippets/csharp/VS_Snippets_Wpf/ListBoxEvent/CSharp/Pane1.xaml#7)]  
[!code-xaml[ListBoxEvent#3](~/samples/snippets/csharp/VS_Snippets_Wpf/ListBoxEvent/CSharp/Pane1.xaml#3)]  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Controls.ListBox>
- <xref:System.Windows.Controls.ListBoxItem>
- [Элементы управления](../advanced/optimizing-performance-controls.md)
