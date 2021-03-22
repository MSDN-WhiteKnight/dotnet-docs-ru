---
title: Практическое руководство. Получение представления по умолчанию для коллекции данных
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- data collections [WPF], creating views of
- data binding [WPF], creating views of data collections
ms.assetid: b641e96c-c2f6-42ea-9c5d-bac81176ad65
ms.openlocfilehash: 746331e69ee1e5eee795a0e35202f4889b72c53f
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59222111"
---
# <a name="how-to-get-the-default-view-of-a-data-collection"></a>Практическое руководство. Получение представления по умолчанию для коллекции данных
Представления позволяют просматривать по-разному в зависимости от сортировки, фильтрации и группировки условий же коллекцию данных. Каждая коллекция имеет одно общее представление по умолчанию, который используется в качестве фактического источника привязки, если привязка задает коллекцию в качестве источника. В этом примере показано, как получение представления по умолчанию для коллекции.  
  
## <a name="example"></a>Пример  
 Чтобы создать представление, требуется ссылка на объект в коллекцию. Этот объект данных можно получить, ссылаясь на собственный объект кода, получив контекст данных свойства источника данных или путем получения свойства привязки. В этом примере показано, как получить <xref:System.Windows.FrameworkElement.DataContext%2A> объект данных и используйте его для непосредственного получения коллекции по умолчанию просмотра для данной коллекции.  
  
 [!code-csharp[CollectionView#2](~/samples/snippets/csharp/VS_Snippets_Wpf/CollectionView/CSharp/Page1.xaml.cs#2)]
   
  
 В этом примере корневым элементом является <xref:System.Windows.Controls.StackPanel>. <xref:System.Windows.FrameworkElement.DataContext%2A> Присваивается *myDataSource*, который ссылается на поставщик данных, который является <xref:System.Collections.ObjectModel.ObservableCollection%601> из *порядок* объектов.  
  
 [!code-xaml[CollectionView#CollectionViewDataContext](~/samples/snippets/csharp/VS_Snippets_Wpf/CollectionView/CSharp/Page1.xaml#collectionviewdatacontext)]  
  
 Кроме того, можно создать экземпляр и привязка к собственные представления коллекции с помощью <xref:System.Windows.Data.CollectionViewSource> класса. Данное представление коллекции совместно используется только элементами управления, которые привязаны к нему напрямую. Пример, см. в разделе для создания представления статьи [Общие сведения о привязке данных](data-binding-overview.md).  
  
 Примеры функциональных возможностях, предоставляемых представлением коллекции, см. в разделе [сортировка данных в представлении](how-to-sort-data-in-a-view.md), [данные фильтра в представлении](how-to-filter-data-in-a-view.md), и [перемещение по объектам в Data CollectionView](how-to-navigate-through-the-objects-in-a-data-collectionview.md).  
  
## <a name="see-also"></a>См. также

- [Сортировка и группировка данных с помощью представления в XAML](how-to-sort-and-group-data-using-a-view-in-xaml.md)
- [Практические руководства](data-binding-how-to-topics.md)
