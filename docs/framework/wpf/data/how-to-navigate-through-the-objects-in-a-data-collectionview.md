---
title: Практическое руководство. Перемещение по объектам в Data CollectionView
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- CollectionView [WPF], navigating through objects
- data binding [WPF], navigating through objects in data CollectionView
- navigating through objects in data CollectionView [WPF]
ms.assetid: fcd37590-bce1-4ac9-8b74-3b96c7458b8a
ms.openlocfilehash: 1507ab4db0c91b670d8bca754f6fd67d887c7041
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59138182"
---
# <a name="how-to-navigate-through-the-objects-in-a-data-collectionview"></a>Практическое руководство. Перемещение по объектам в Data CollectionView
Представления позволяют просматривать по-разному в зависимости от сортировки, фильтрации и группировки же коллекцию данных. Представления также предоставляют понятием текущего указателя записи и включить перемещение указателя. В этом примере показано, как получить текущий объект, а также перемещение по объектам в коллекции данных с помощью функциональных возможностей, предоставляемых в <xref:System.Windows.Data.CollectionView> класса.  
  
## <a name="example"></a>Пример  
 В этом примере `myCollectionView` является <xref:System.Windows.Data.CollectionView> объект, который является представлением присоединенной коллекции.  
  
 В следующем примере `OnButton` является обработчиком событий для `Previous` и `Next` кнопки в приложении, которые находятся кнопки, которые позволяют пользователю переходить коллекции данных. Обратите внимание, что <xref:System.Windows.Data.CollectionView.IsCurrentBeforeFirst%2A> и <xref:System.Windows.Data.CollectionView.IsCurrentAfterLast%2A> свойства отчетов ли указатель текущей записи начал в начало и конец списка соответственно таким образом, <xref:System.Windows.Data.CollectionView.MoveCurrentToFirst%2A> и <xref:System.Windows.Data.CollectionView.MoveCurrentToLast%2A> могут быть вызваны соответствующим образом.  
  
 <xref:System.Windows.Data.CollectionView.CurrentItem%2A> Приведенное свойства представления `Order` для возврата текущего элемента в коллекции.  
  
 [!code-csharp[CollectionView#OnButton](~/samples/snippets/csharp/VS_Snippets_Wpf/CollectionView/CSharp/Page1.xaml.cs#onbutton)]
   
  
## <a name="see-also"></a>См. также

- [Общие сведения о привязке данных](data-binding-overview.md)
- [Сортировка данных в представлении](how-to-sort-data-in-a-view.md)
- [Фильтрация данных в представлении](how-to-filter-data-in-a-view.md)
- [Сортировка и группировка данных с помощью представления в XAML](how-to-sort-and-group-data-using-a-view-in-xaml.md)
- [Практические руководства](data-binding-how-to-topics.md)
