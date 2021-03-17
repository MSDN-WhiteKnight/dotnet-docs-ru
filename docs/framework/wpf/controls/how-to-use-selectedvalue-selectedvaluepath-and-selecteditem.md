---
title: Практическое руководство. Использование элементов SelectedValue, SelectedValuePath и SelectedItem
ms.date: 03/30/2017
helpviewer_keywords:
- TreeView control [WPF], SelectedValue properties
- Control class [WPF], SelectedItem properties
- Control class [WPF], TreeView properties
- Control class [WPF], SelectedValue properties
- TreeView control [WPF], SelectedItem properties
- SelectedValue [WPF], SelectedValuePath properties
- TreeView control [WPF], SelectedValuePath properties
- Control class [WPF], SelectedValuePath properties
- SelectedValue [WPF], SelectedItem properties
ms.assetid: 2fc92ad4-f02c-4f89-bbe9-d4978a7af0db
ms.openlocfilehash: d9f7a8f04f53b7d38a49dfef2c947dfa1c2d263d
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59169711"
---
# <a name="how-to-use-selectedvalue-selectedvaluepath-and-selecteditem"></a>Практическое руководство. Использование элементов SelectedValue, SelectedValuePath и SelectedItem
В этом примере показано, как использовать <xref:System.Windows.Controls.TreeView.SelectedValue%2A> и <xref:System.Windows.Controls.TreeView.SelectedValuePath%2A> свойства, чтобы указать значение для <xref:System.Windows.Controls.TreeView.SelectedItem%2A> из <xref:System.Windows.Controls.TreeView>.  
  
## <a name="example"></a>Пример  
 <xref:System.Windows.Controls.TreeView.SelectedValuePath%2A> Свойство позволяет указать <xref:System.Windows.Controls.TreeView.SelectedValue%2A> для <xref:System.Windows.Controls.TreeView.SelectedItem%2A> в <xref:System.Windows.Controls.TreeView>. <xref:System.Windows.Controls.TreeView.SelectedItem%2A> Представляет объект в <xref:System.Windows.Controls.ItemsControl.Items%2A> коллекции и <xref:System.Windows.Controls.TreeView> отображает значение одного свойства выбранного элемента. <xref:System.Windows.Controls.TreeView.SelectedValuePath%2A> Задает путь к свойству, которое используется для определения значения <xref:System.Windows.Controls.TreeView.SelectedValue%2A> свойство. В примерах этого раздела показана эта концепция.  
  
 В следующем примере показан <xref:System.Windows.Data.XmlDataProvider> , содержащий сведения о сотрудниках.  
  
 [!code-xaml[TreeViewSelectedValue#XMLDataProvider](~/samples/snippets/csharp/VS_Snippets_Wpf/TreeViewSelectedValue/CS/Window1.xaml#xmldataprovider)]  
  
 В следующем примере определяется <xref:System.Windows.HierarchicalDataTemplate> , отображающий `EmployeeName` и `EmployeeWorkDay` из `Employee`. Обратите внимание, что <xref:System.Windows.HierarchicalDataTemplate> не указывает `EmployeeNumber` как часть шаблона.  
  
 [!code-xaml[TreeViewSelectedValue#HierarchicalDataTemplate](~/samples/snippets/csharp/VS_Snippets_Wpf/TreeViewSelectedValue/CS/Window1.xaml#hierarchicaldatatemplate)]  
  
 В следующем примере показан <xref:System.Windows.Controls.TreeView> , использующий ранее определенный <xref:System.Windows.HierarchicalDataTemplate> и устанавливает <xref:System.Windows.Controls.TreeView.SelectedValue%2A> свойства `EmployeeNumber`. При выборе `EmployeeName` в <xref:System.Windows.Controls.TreeView>, <xref:System.Windows.Controls.TreeView.SelectedItem%2A> возвращает `EmployeeInfo` элемент данных, соответствующий выбранной `EmployeeName`. Тем не менее так как <xref:System.Windows.Controls.TreeView.SelectedValuePath%2A> этого <xref:System.Windows.Controls.TreeView> присваивается `EmployeeNumber`, <xref:System.Windows.Controls.TreeView.SelectedValue%2A> присваивается `EmployeeNumber`.  
  
 [!code-xaml[TreeViewSelectedValue#SelectedValuePath](~/samples/snippets/csharp/VS_Snippets_Wpf/TreeViewSelectedValue/CS/Window1.xaml#selectedvaluepath)]  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Controls.TreeView>
- <xref:System.Windows.Controls.TreeViewItem>
- [Обзор элемента управления "TreeView"](treeview-overview.md)
- [Практические руководства](treeview-how-to-topics.md)
