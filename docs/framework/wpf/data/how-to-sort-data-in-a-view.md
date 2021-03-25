---
title: Практическое руководство. Сортировка данных в представлении
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- data binding [WPF], sorting data in views
- data binding [WPF], grouping data in views
- grouping data in views [WPF]
- views [WPF], sorting data
- views [WPF], grouping data
- sorting data in views [WPF]
ms.assetid: f4c43578-01b7-4774-a953-acb95a13b94a
ms.openlocfilehash: 32f73d3c3ba213778654f0d1ee7bbae16b9d845b
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59211261"
---
# <a name="how-to-sort-data-in-a-view"></a>Практическое руководство. Сортировка данных в представлении
В этом примере описывается порядок сортировки данных в представлении.  
  
## <a name="example"></a>Пример  
 В следующем примере создается простой <xref:System.Windows.Controls.ListBox> и <xref:System.Windows.Controls.Button>:  
  
 [!code-xaml[ListBoxSort_snip#HowTo](~/samples/snippets/csharp/VS_Snippets_Wpf/ListBoxSort_snip/CSharp/Window1.xaml#howto)]  
  
 <xref:System.Windows.Controls.Primitives.ButtonBase.Click> Обработчик событий кнопки содержит логику для сортировки элементов в <xref:System.Windows.Controls.ListBox> в порядке убывания. Это можно сделать, так как добавление элементов в <xref:System.Windows.Controls.ListBox> таким образом они добавляются в <xref:System.Windows.Controls.ItemCollection> из <xref:System.Windows.Controls.ListBox>, и <xref:System.Windows.Controls.ItemCollection> является производным от <xref:System.Windows.Data.CollectionView> класса. При связывании вашей <xref:System.Windows.Controls.ListBox> в коллекции с помощью <xref:System.Windows.Controls.ItemsControl.ItemsSource%2A> свойство, можно использовать ту же методику для сортировки.  
  
 [!code-csharp[ListBoxSort_snip#HowToCode](~/samples/snippets/csharp/VS_Snippets_Wpf/ListBoxSort_snip/CSharp/Window1.xaml.cs#howtocode)]
   
  
 До тех пор, пока у вас есть ссылку на объект представления, можно использовать ту же методику для сортировки содержимого других представлений коллекции. Пример получения представления, см. в разделе [получение представления по умолчанию для коллекции данных](how-to-get-the-default-view-of-a-data-collection.md). Еще один пример см. в разделе [сортировки GridView столбца при нажатии на заголовок](../controls/how-to-sort-a-gridview-column-when-a-header-is-clicked.md). Дополнительные сведения о представлениях см [Общие сведения о привязке данных](data-binding-overview.md).  
  
 Например, как применить логику сортировки в XAML, см. в разделе [сортировки и группы данных с помощью представления в XAML](how-to-sort-and-group-data-using-a-view-in-xaml.md).  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Data.ListCollectionView.CustomSort%2A>
- [Сортировка столбцов GridView при нажатии на заголовок](../controls/how-to-sort-a-gridview-column-when-a-header-is-clicked.md)
- [Общие сведения о привязке данных](data-binding-overview.md)
- [Фильтрация данных в представлении](how-to-filter-data-in-a-view.md)
- [Практические руководства](data-binding-how-to-topics.md)
