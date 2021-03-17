---
title: Практическое руководство. Создание простых или сложных элементов TreeView
ms.date: 03/30/2017
helpviewer_keywords:
- TreeView control [WPF], creating
- Control class [WPF], TreeView [WPF], creating
ms.assetid: 1defbb78-b8e7-4c0e-b650-576453ac828d
ms.openlocfilehash: 7edb4933ebcc0f0d2cb02754238c2342ee9dd4a2
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59205151"
---
# <a name="how-to-create-simple-or-complex-treeviews"></a>Практическое руководство. Создание простых или сложных элементов TreeView
В этом примере показано, как создавать простые и комплексные <xref:System.Windows.Controls.TreeView> элементов управления.  
  
 Объект <xref:System.Windows.Controls.TreeView> состоит из иерархии <xref:System.Windows.Controls.TreeViewItem> элементов управления, которые могут содержать простые текстовые строки, а также более сложное содержимое, такие как <xref:System.Windows.Controls.Button> элементов управления или <xref:System.Windows.Controls.StackPanel> с внедренным содержимым. Можно явно определить <xref:System.Windows.Controls.TreeView> содержимое или источник данных может предоставить содержимое. В этом разделе приведены примеры этих понятий.  
  
## <a name="example"></a>Пример  
 <xref:System.Windows.Controls.HeaderedItemsControl.Header%2A> Свойство <xref:System.Windows.Controls.TreeViewItem> с содержимым, <xref:System.Windows.Controls.TreeView> отображает для данного элемента. Объект <xref:System.Windows.Controls.TreeViewItem> может также иметь <xref:System.Windows.Controls.TreeViewItem> элементов управления, а его дочерние элементы можно определить эти дочерние элементы с помощью <xref:System.Windows.Controls.ItemsControl.Items%2A> свойство.  
  
 В следующем примере показано, как явно определить <xref:System.Windows.Controls.TreeViewItem> содержимого, задав <xref:System.Windows.Controls.HeaderedItemsControl.Header%2A> свойство в текстовую строку.  
  
 [!code-xaml[TreeViewSimple#1](~/samples/snippets/csharp/VS_Snippets_Wpf/TreeViewSimple/CS/Window1.xaml#1)]  
  
 В следующем примере показано, как определить дочерние элементы <xref:System.Windows.Controls.TreeViewItem> , определив <xref:System.Windows.Controls.ItemsControl.Items%2A> , которые <xref:System.Windows.Controls.Button> элементов управления.  
  
 [!code-xaml[TreeViewSimple#3](~/samples/snippets/csharp/VS_Snippets_Wpf/TreeViewSimple/CS/Window1.xaml#3)]  
  
 В следующем примере показано, как создать <xref:System.Windows.Controls.TreeView> где <xref:System.Windows.Data.XmlDataProvider> предоставляет <xref:System.Windows.Controls.TreeViewItem> содержимого и <xref:System.Windows.HierarchicalDataTemplate> определяет внешний вид содержимого.  
  
 [!code-xaml[TreeViewSimple#6](~/samples/snippets/csharp/VS_Snippets_Wpf/TreeViewSimple/CS/Window1.xaml#6)]  
  
 [!code-xaml[TreeViewSimple#7](~/samples/snippets/csharp/VS_Snippets_Wpf/TreeViewSimple/CS/Window1.xaml#7)]  
  
 [!code-xaml[TreeViewSimple#5](~/samples/snippets/csharp/VS_Snippets_Wpf/TreeViewSimple/CS/Window1.xaml#5)]  
  
 В следующем примере показано, как создать <xref:System.Windows.Controls.TreeView> где <xref:System.Windows.Controls.TreeViewItem> содержимое содержит <xref:System.Windows.Controls.DockPanel> элементов управления, которые содержат вложенное содержимое.  
  
 [!code-xaml[TreeViewSimple#9](~/samples/snippets/csharp/VS_Snippets_Wpf/TreeViewSimple/CS/Window1.xaml#9)]  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Controls.TreeView>
- <xref:System.Windows.Controls.TreeViewItem>
- [Обзор элемента управления "TreeView"](treeview-overview.md)
- [Практические руководства](treeview-how-to-topics.md)
