---
title: Практическое руководство. Поиск элемента TreeViewItem в TreeView
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- TreeView control [WPF], finding a TreeViewItem
- TreeViewItem [WPF], finding
ms.assetid: 72ecd40c-3939-4e01-b617-5e9daa6074d9
ms.openlocfilehash: 034ec2e57fb3b6a9b3a81f66f6888a68e2c113d7
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59219048"
---
# <a name="how-to-find-a-treeviewitem-in-a-treeview"></a>Практическое руководство. Поиск элемента TreeViewItem в TreeView
<xref:System.Windows.Controls.TreeView> Элемент управления предоставляет удобный способ отображения иерархических данных. Если ваш <xref:System.Windows.Controls.TreeView> привязан к источнику данных <xref:System.Windows.Controls.TreeView.SelectedItem%2A> свойство предоставляет удобный способ для быстрого извлечения выбранного объекта данных. Обычно лучше всего работать с основной объект данных, но иногда необходимо программно управлять данных, содержащий <xref:System.Windows.Controls.TreeViewItem>. Например, может потребоваться программным образом развернуть <xref:System.Windows.Controls.TreeViewItem>, или выберите другой элемент в <xref:System.Windows.Controls.TreeView>.  
  
 Чтобы найти <xref:System.Windows.Controls.TreeViewItem> , содержащий конкретный объект данных, необходимо пройти каждый уровень <xref:System.Windows.Controls.TreeView>. Элементы в <xref:System.Windows.Controls.TreeView> также могут быть виртуализированы для повышения производительности. В случае, когда виртуализации элементов, необходимо также реализовать <xref:System.Windows.Controls.TreeViewItem> для проверки, содержит ли объект данных.  
  
## <a name="example"></a>Пример  
  
## <a name="description"></a>Описание  
 В следующем примере производится поиск <xref:System.Windows.Controls.TreeView> для определенного объекта и возвращает, содержащий этот объект <xref:System.Windows.Controls.TreeViewItem>. В примере проверяется, чтобы каждый <xref:System.Windows.Controls.TreeViewItem> создается таким образом, чтобы поиска дочерних элементов. В этом примере также работает, если <xref:System.Windows.Controls.TreeView> используются виртуализированные элементы.  
  
> [!NOTE]
>  Следующий пример работает для любого <xref:System.Windows.Controls.TreeView>, вне зависимости от базовой модели данных и выполняет каждый <xref:System.Windows.Controls.TreeViewItem> пока не будет найден объект. Другой метод, имеющий более высокую производительность заключается поиск модели данных для указанного объекта, отслеживать его положение в иерархии данных и затем найти соответствующий <xref:System.Windows.Controls.TreeViewItem> в <xref:System.Windows.Controls.TreeView>. Тем не менее, метод, имеющий более высокую производительность требует знаний модели данных и не может быть обобщить для любого заданного <xref:System.Windows.Controls.TreeView>.  
  
## <a name="code"></a>Код  
 [!code-csharp[TreeViewFindTVI#1](~/samples/snippets/csharp/VS_Snippets_Wpf/TreeViewFindTVI/CSharp/MainWindow.xaml.cs#1)]
   
  
 Предыдущий код использует пользовательский <xref:System.Windows.Controls.VirtualizingStackPanel> , предоставляет метод с именем `BringIntoView`. Следующий код определяет пользовательский <xref:System.Windows.Controls.VirtualizingStackPanel>.  
  
 [!code-csharp[TreeViewFindTVI#2](~/samples/snippets/csharp/VS_Snippets_Wpf/TreeViewFindTVI/CSharp/MainWindow.xaml.cs#2)]
   
  
 Следующий XAML показан способ создания <xref:System.Windows.Controls.TreeView> , использующего пользовательский <xref:System.Windows.Controls.VirtualizingStackPanel>.  
  
 [!code-xaml[TreeViewFindTVI#3](~/samples/snippets/csharp/VS_Snippets_Wpf/TreeViewFindTVI/CSharp/MainWindow.xaml#3)]  
  
## <a name="see-also"></a>См. также

- [Повышение производительности элемента управления TreeView](how-to-improve-the-performance-of-a-treeview.md)
