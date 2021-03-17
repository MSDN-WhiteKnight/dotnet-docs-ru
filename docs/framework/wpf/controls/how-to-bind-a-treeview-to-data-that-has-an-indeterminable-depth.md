---
title: Практическое руководство. Привязка элемента управления TreeView к данным неопределенной глубины
ms.date: 03/30/2017
helpviewer_keywords:
- TreeView control [WPF], binding to data of indeterminate depth
ms.assetid: daddcd74-1b0f-4ffd-baeb-ec934c5e0f53
ms.openlocfilehash: 7da0a121cdb854c787c105c92cec70b7c4b3244e
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59214862"
---
# <a name="how-to-bind-a-treeview-to-data-that-has-an-indeterminable-depth"></a>Практическое руководство. Привязка элемента управления TreeView к данным неопределенной глубины
Возможны ситуации, когда необходимо выполнить привязку <xref:System.Windows.Controls.TreeView> к источнику данных, глубина которого неизвестно.  Это может произойти, когда данные рекурсивных по своей природе, например в файловой системе, где папок может содержать папки, или организационной структуры компании, где у сотрудников были другими сотрудниками в качестве непосредственных подчиненных.  
  
 Источник данных должен иметь иерархическую объектную модель. Например `Employee` класс может содержать коллекцию объектов Employee, подчиненных этого сотрудника. Если данные представлены в виде, не является иерархической, необходимо построить иерархическое представление данных.  
  
 При задании <xref:System.Windows.Controls.ItemsControl.ItemTemplate%2A?displayProperty=nameWithType> свойства и, если <xref:System.Windows.Controls.ItemsControl> приводит к возникновению ошибки <xref:System.Windows.Controls.ItemsControl> для каждого дочернего элемента, а затем дочерние <xref:System.Windows.Controls.ItemsControl> использует тот же <xref:System.Windows.Controls.ItemsControl.ItemTemplate%2A> как родительский. Например, если задать <xref:System.Windows.Controls.ItemsControl.ItemTemplate%2A> свойство привязкой к данным <xref:System.Windows.Controls.TreeView>, каждая <xref:System.Windows.Controls.TreeViewItem> то есть созданный использует <xref:System.Windows.DataTemplate> , присвоенный <xref:System.Windows.Controls.ItemsControl.ItemTemplate%2A> свойство <xref:System.Windows.Controls.TreeView>.  
  
 <xref:System.Windows.HierarchicalDataTemplate> Позволяет указать <xref:System.Windows.Controls.ItemsControl.ItemsSource%2A> для <xref:System.Windows.Controls.TreeViewItem>, или любой <xref:System.Windows.Controls.HeaderedItemsControl>, в шаблоне данных. При задании <xref:System.Windows.HierarchicalDataTemplate.ItemsSource%2A?displayProperty=nameWithType> свойство, значение используется, когда <xref:System.Windows.HierarchicalDataTemplate> применяется. С помощью <xref:System.Windows.HierarchicalDataTemplate>, можно рекурсивно задать <xref:System.Windows.Controls.ItemsControl.ItemsSource%2A> для каждого <xref:System.Windows.Controls.TreeViewItem> в <xref:System.Windows.Controls.TreeView>.  
  
## <a name="example"></a>Пример  
 Следующий пример демонстрирует способ привязки <xref:System.Windows.Controls.TreeView> иерархических данных и используйте <xref:System.Windows.HierarchicalDataTemplate> для указания <xref:System.Windows.Controls.ItemsControl.ItemsSource%2A> для каждого <xref:System.Windows.Controls.TreeViewItem>.  <xref:System.Windows.Controls.TreeView> Привязывается к XML-данные о сотрудниках компании.  Каждый `Employee` элемент может содержать другие `Employee` элементы, чтобы указать, кому подчиняется. Так как данные является рекурсивной, <xref:System.Windows.HierarchicalDataTemplate> могут применяться для каждого уровня.  
  
 [!code-xaml[TreeViewWithUnknownDepth#1](~/samples/snippets/csharp/VS_Snippets_Wpf/TreeViewWithUnknownDepth/CS/Window1.xaml#1)]  
  
## <a name="see-also"></a>См. также

- [Общие сведения о привязке данных](../data/data-binding-overview.md)
- [Общие сведения о шаблонах данных](../data/data-templating-overview.md)
