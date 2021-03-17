---
title: Практическое руководство. Привязка к коллекции и вывод сведений в зависимости от выделенного элемента
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- data collections [WPF], selecting data for views
- data binding [WPF], creating views of data collections
- data binding [WPF], selecting data for views
- data binding [WPF], binding to collections
ms.assetid: 952a7d76-dd29-49e5-86f5-32c4530e70eb
ms.openlocfilehash: bb7d4c89e63982a3052857dcb50d04d36d9517dd
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59314399"
---
# <a name="how-to-bind-to-a-collection-and-display-information-based-on-selection"></a>Практическое руководство. Привязка к коллекции и вывод сведений в зависимости от выделенного элемента
В простом сценарии «основной-подробности», у вас есть привязкой к данным <xref:System.Windows.Controls.ItemsControl> например <xref:System.Windows.Controls.ListBox>. В зависимости от выбора пользователя можно отобразить дополнительные сведения о выбранном элементе. В этом примере показано, как реализовать этот сценарий.  
  
## <a name="example"></a>Пример  
 В этом примере `People` — <xref:System.Collections.ObjectModel.ObservableCollection%601> из `Person` классы. Это `Person` класс содержит три свойства: `FirstName`, `LastName`, и `HomeTown`, все типа `string`.  
  
 [!code-xaml[CollectionBinding#Source](~/samples/snippets/csharp/VS_Snippets_Wpf/CollectionBinding/CSharp/Window1.xaml#source)]  
[!code-xaml[CollectionBinding#UI](~/samples/snippets/csharp/VS_Snippets_Wpf/CollectionBinding/CSharp/Window1.xaml#ui)]  
  
 <xref:System.Windows.Controls.ContentControl> Использует следующие <xref:System.Windows.DataTemplate> определяет, как данные `Person` представлены:  
  
 [!code-xaml[CollectionBinding#DetailTemplate](~/samples/snippets/csharp/VS_Snippets_Wpf/CollectionBinding/CSharp/Window1.xaml#detailtemplate)]  
  
 Ниже приведен снимок экрана примера. <xref:System.Windows.Controls.ContentControl> Показаны другие свойства выбранного лица.  
  
 ![Привязка к коллекции](./media/databinding-collectionbindingsample.png "DataBinding_CollectionBindingSample")  
  
 В этом примере следует обратить внимание на два обстоятельства:  
  
1. <xref:System.Windows.Controls.ListBox> И <xref:System.Windows.Controls.ContentControl> привязать к одному источнику. <xref:System.Windows.Data.Binding.Path%2A> Свойства обе привязки не заданы, так как оба элемента управления привязаны к всему объекту коллекции.  
  
2. Необходимо задать <xref:System.Windows.Controls.Primitives.Selector.IsSynchronizedWithCurrentItem%2A> свойства `true` для правильной работы. Задание этого свойства гарантирует, что выбранный элемент всегда задается как <xref:System.Windows.Controls.ItemCollection.CurrentItem%2A>. Кроме того Если <xref:System.Windows.Controls.ListBox> получает данные от <xref:System.Windows.Data.CollectionViewSource>, он автоматически синхронизирует Выбор и денежные единицы.  
  
 Обратите внимание, что `Person` класса переопределения `ToString` метод следующим образом. По умолчанию <xref:System.Windows.Controls.ListBox> вызовы `ToString` и отображает строковое представление каждого объекта в привязанной коллекции. Вот почему каждый `Person` отображается как имя в <xref:System.Windows.Controls.ListBox>.  
  
 [!code-csharp[CollectionBinding#ToString](~/samples/snippets/csharp/VS_Snippets_Wpf/CollectionBinding/CSharp/Data.cs#tostring)]
 [!code-vb[CollectionBinding#ToString](~/samples/snippets/visualbasic/VS_Snippets_Wpf/CollectionBinding/VisualBasic/Person.vb#tostring)]  
  
## <a name="see-also"></a>См. также

- [Использование шаблона "Основной/подробности" с иерархическими данными](how-to-use-the-master-detail-pattern-with-hierarchical-data.md)
- [Использование шаблона "Основной/подробности" с иерархическими XML-данными](how-to-use-the-master-detail-pattern-with-hierarchical-xml-data.md)
- [Общие сведения о привязке данных](data-binding-overview.md)
- [Общие сведения о шаблонах данных](data-templating-overview.md)
- [Практические руководства](data-binding-how-to-topics.md)
