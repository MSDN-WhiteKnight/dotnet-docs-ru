---
title: Практическое руководство. Группировать, сортировать и фильтровать данные в элементе управления DataGrid
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- DataGrid [WPF], sort
- DataGrid [WPF], group
- DataGrid [WPF], filter
ms.assetid: 03345e85-89e3-4aec-9ed0-3b80759df770
ms.openlocfilehash: 81fdb0a6d5602f612c55d7e790ca9a0fe56c144e
ms.sourcegitcommit: 0c48191d6d641ce88d7510e319cf38c0e35697d0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/05/2019
ms.locfileid: "57365052"
---
# <a name="how-to-group-sort-and-filter-data-in-the-datagrid-control"></a>Практическое руководство. Группирования, сортировки и фильтрации данных в элементе управления DataGrid

Часто бывает полезно для просмотра данных в <xref:System.Windows.Controls.DataGrid> по-разному, группирования, сортировки и фильтрации данных. Чтобы группировать, сортировать и фильтровать данные в <xref:System.Windows.Controls.DataGrid>, привяжите его к <xref:System.Windows.Data.CollectionView> , поддерживает эти функции. Затем можно работать с данными в <xref:System.Windows.Data.CollectionView> без влияния на базовый источник данных. Изменения в представлении коллекции отражаются в <xref:System.Windows.Controls.DataGrid> пользовательский интерфейс (UI).

<xref:System.Windows.Data.CollectionView> Класс предоставляет функции для источника данных, который реализует группировки и сортировки <xref:System.Collections.IEnumerable> интерфейс. <xref:System.Windows.Data.CollectionViewSource> Класса позволяет задавать свойства <xref:System.Windows.Data.CollectionView> из XAML.

В этом примере коллекция `Task` связанным объектам в <xref:System.Windows.Data.CollectionViewSource>. <xref:System.Windows.Data.CollectionViewSource> Используется в качестве <xref:System.Windows.Controls.ItemsControl.ItemsSource%2A> для <xref:System.Windows.Controls.DataGrid>. Группирование, сортировка и фильтрация выполняются на <xref:System.Windows.Data.CollectionViewSource> и отображаются в <xref:System.Windows.Controls.DataGrid> пользовательского интерфейса.

![Сгруппированные данные в DataGrid](././media/wpf-datagridgroups.png "WPF_DataGridGroups") сгруппированных данных в элементе управления DataGrid

## <a name="using-a-collectionviewsource-as-an-itemssource"></a>С помощью CollectionViewSource как ItemsSource

Для группирования, сортировки и фильтрации данных в <xref:System.Windows.Controls.DataGrid> привязать элемент управления, <xref:System.Windows.Controls.DataGrid> для <xref:System.Windows.Data.CollectionView> , поддерживает эти функции. В этом примере <xref:System.Windows.Controls.DataGrid> привязан к <xref:System.Windows.Data.CollectionViewSource> , предоставляет эти функции для <xref:System.Collections.Generic.List%601> из `Task` объектов.

### <a name="to-bind-a-datagrid-to-a-collectionviewsource"></a>Для привязки к CollectionViewSource, элемент управления DataGrid

1. Создать конфигурацию сбора данных, который реализует <xref:System.Collections.IEnumerable> интерфейс.

    Если вы используете <xref:System.Collections.Generic.List%601> для создания коллекции, следует создать новый класс, наследуемый от <xref:System.Collections.Generic.List%601> вместо создания его экземпляра из <xref:System.Collections.Generic.List%601>. Это позволяет для привязки данных к коллекции в XAML.

    > [!NOTE]
    > Объекты в коллекции должны реализовывать <xref:System.ComponentModel.INotifyPropertyChanged> измененный интерфейс и <xref:System.ComponentModel.IEditableObject> интерфейс выполнился <xref:System.Windows.Controls.DataGrid> правильно реагировать на изменения свойства. Дополнительные сведения см. в разделе [Реализация уведомления об изменении свойств](../data/how-to-implement-property-change-notification.md).

    [!code-csharp[DataGrid_GroupSortFilter#101](~/samples/snippets/csharp/VS_Snippets_Wpf/DataGrid_GroupSortFilter/CS/MainWindow.xaml.cs#101)]
    

2. В XAML, создайте экземпляр класса коллекции и задайте [директивы x: Key](../../xaml-services/x-key-directive.md).

3. В XAML, создайте экземпляр <xref:System.Windows.Data.CollectionViewSource> класса, задайте [директивы x: Key](../../xaml-services/x-key-directive.md)и установите экземпляр класса коллекции как <xref:System.Windows.Data.CollectionViewSource.Source%2A>.

    [!code-xaml[DataGrid_GroupSortFilter#201](~/samples/snippets/csharp/VS_Snippets_Wpf/DataGrid_GroupSortFilter/CS/WindowSnips1.xaml#201)]

4. Создайте экземпляр <xref:System.Windows.Controls.DataGrid> и укажите <xref:System.Windows.Controls.ItemsControl.ItemsSource%2A> свойства <xref:System.Windows.Data.CollectionViewSource>.

    [!code-xaml[DataGrid_GroupSortFilter#002](~/samples/snippets/csharp/VS_Snippets_Wpf/DataGrid_GroupSortFilter/CS/MainWindow.xaml#002)]

5. Чтобы получить доступ к <xref:System.Windows.Data.CollectionViewSource> из кода, используйте <xref:System.Windows.Data.CollectionViewSource.GetDefaultView%2A> метод, чтобы получить ссылку на <xref:System.Windows.Data.CollectionViewSource>.

    [!code-csharp[DataGrid_GroupSortFilter#102](~/samples/snippets/csharp/VS_Snippets_Wpf/DataGrid_GroupSortFilter/CS/MainWindow.xaml.cs#102)]
    

## <a name="grouping-items-in-a-datagrid"></a>Группировка элементов в элемент управления DataGrid

Чтобы указать, как элементы группируются в <xref:System.Windows.Controls.DataGrid>, использовании <xref:System.Windows.Data.PropertyGroupDescription> типа, чтобы сгруппировать элементы в представлении источника.

### <a name="to-group-items-in-a-datagrid-using-xaml"></a>Для группирования элементов в элементе управления DataGrid с помощью XAML

1. Создание <xref:System.Windows.Data.PropertyGroupDescription> , задающий свойство для группировки. Можно указать свойство в XAML или в коде.

   1. В XAML, задайте <xref:System.Windows.Data.PropertyGroupDescription.PropertyName%2A> имя свойство для группировки.

   2. В коде передайте имя свойства для группирования по конструктору.

2. Добавить <xref:System.Windows.Data.PropertyGroupDescription> для <xref:System.Windows.Data.CollectionViewSource.GroupDescriptions%2A?displayProperty=nameWithType> коллекции.

3. Добавьте дополнительные экземпляры <xref:System.Windows.Data.PropertyGroupDescription> для <xref:System.Windows.Data.CollectionViewSource.GroupDescriptions%2A> коллекции, чтобы добавить дополнительные уровни группирования.

    [!code-xaml[DataGrid_GroupSortFilter#012](~/samples/snippets/csharp/VS_Snippets_Wpf/DataGrid_GroupSortFilter/CS/MainWindow.xaml#012)]
    [!code-csharp[DataGrid_GroupSortFilter#112](~/samples/snippets/csharp/VS_Snippets_Wpf/DataGrid_GroupSortFilter/CS/MainWindow.xaml.cs#112)]
    

4. Чтобы удалить группу, удалите <xref:System.Windows.Data.PropertyGroupDescription> из <xref:System.Windows.Data.CollectionViewSource.GroupDescriptions%2A> коллекции.

5. Чтобы удалить все группы, вызовите <xref:System.Collections.ObjectModel.Collection%601.Clear%2A> метод <xref:System.Windows.Data.CollectionViewSource.GroupDescriptions%2A> коллекции.

    [!code-csharp[DataGrid_GroupSortFilter#114](~/samples/snippets/csharp/VS_Snippets_Wpf/DataGrid_GroupSortFilter/CS/MainWindow.xaml.cs#114)]
    

Если элементы группируются в <xref:System.Windows.Controls.DataGrid>, можно определить <xref:System.Windows.Controls.GroupStyle> , указывающий внешний вид каждой группы. Можно применить <xref:System.Windows.Controls.GroupStyle> путем добавления его в <xref:System.Windows.Controls.ItemsControl.GroupStyle%2A> коллекцию DataGrid. При наличии нескольких уровней группировки, можно применить различные стили для каждого уровня. Стили применяются в порядке, в котором они определены. Например если определить два стиля, первый будет применять к группам строк верхнего уровня. Второй стиль будет применен ко всем группам строк на втором уровне и ниже. <xref:System.Windows.FrameworkElement.DataContext%2A> Из <xref:System.Windows.Controls.GroupStyle> является <xref:System.Windows.Data.CollectionViewGroup> , представляющий группу.

### <a name="to-change-the-appearance-of-row-group-headers"></a>Чтобы изменить внешний вид заголовков групп строк

1. Создание <xref:System.Windows.Controls.GroupStyle> , определяющий внешний вид группы строк.

2. Поместите <xref:System.Windows.Controls.GroupStyle> внутри `<DataGrid.GroupStyle>` теги.

    [!code-xaml[DataGrid_GroupSortFilter#003](~/samples/snippets/csharp/VS_Snippets_Wpf/DataGrid_GroupSortFilter/CS/MainWindow.xaml#003)]

## <a name="sorting-items-in-a-datagrid"></a>Сортировка элементов в элемент управления DataGrid

Чтобы указать способ сортировки элементов в <xref:System.Windows.Controls.DataGrid>, использовании <xref:System.ComponentModel.SortDescription> тип сортировки элементов в представлении источника.

### <a name="to-sort-items-in-a-datagrid"></a>Для сортировки элементов в элементе управления DataGrid

1. Создание <xref:System.ComponentModel.SortDescription> , задающий свойство для сортировки. Можно указать свойство в XAML или в коде.

    1. В XAML, задайте <xref:System.ComponentModel.SortDescription.PropertyName%2A> имя свойства для сортировки.

    2. В коде, передайте имя свойства для сортировки и <xref:System.ComponentModel.ListSortDirection> в конструктор.

2. Добавить <xref:System.ComponentModel.SortDescription> для <xref:System.Windows.Data.CollectionViewSource.SortDescriptions%2A?displayProperty=nameWithType> коллекции.

3. Добавьте дополнительные экземпляры <xref:System.ComponentModel.SortDescription> для <xref:System.Windows.Data.CollectionViewSource.SortDescriptions%2A> коллекции, чтобы выполнить сортировку по дополнительные свойства.

    [!code-xaml[DataGrid_GroupSortFilter#011](~/samples/snippets/csharp/VS_Snippets_Wpf/DataGrid_GroupSortFilter/CS/MainWindow.xaml#011)]
    [!code-csharp[DataGrid_GroupSortFilter#211](~/samples/snippets/csharp/VS_Snippets_Wpf/DataGrid_GroupSortFilter/CS/WindowSnips1.xaml.cs#211)]
    

## <a name="filtering-items-in-a-datagrid"></a>Фильтрация элементов в элементе управления DataGrid

Для фильтрации элементов в <xref:System.Windows.Controls.DataGrid> с помощью <xref:System.Windows.Data.CollectionViewSource>, предоставляют логику фильтрации в обработчике <xref:System.Windows.Data.CollectionViewSource.Filter?displayProperty=nameWithType> событий.

### <a name="to-filter-items-in-a-datagrid"></a>Для фильтрации элементов в элементе управления DataGrid

1. Добавить обработчик для <xref:System.Windows.Data.CollectionViewSource.Filter?displayProperty=nameWithType> событий.

2. В <xref:System.Windows.Data.CollectionViewSource.Filter> обработчик событий, определите логику фильтрации.

    Фильтр применяется каждый раз будет обновлено представление.

    [!code-xaml[DataGrid_GroupSortFilter#013](~/samples/snippets/csharp/VS_Snippets_Wpf/DataGrid_GroupSortFilter/CS/MainWindow.xaml#013)]
    [!code-csharp[DataGrid_GroupSortFilter#113](~/samples/snippets/csharp/VS_Snippets_Wpf/DataGrid_GroupSortFilter/CS/MainWindow.xaml.cs#113)]
    

Кроме того, можно отфильтровать элементы в <xref:System.Windows.Controls.DataGrid> , создав метод, который предоставляет логику фильтрации и параметр <xref:System.Windows.Data.CollectionView.Filter%2A?displayProperty=nameWithType> свойство, чтобы применить фильтр. Пример этого метода см. в разделе [данные фильтра в представлении](../data/how-to-filter-data-in-a-view.md).

## <a name="example"></a>Пример

В следующем примере показано группирование, сортировка и фильтрация `Task` данные в <xref:System.Windows.Data.CollectionViewSource> и отображение сгруппированных, упорядочивать и фильтровать `Task` данные в <xref:System.Windows.Controls.DataGrid>. <xref:System.Windows.Data.CollectionViewSource> Используется в качестве <xref:System.Windows.Controls.ItemsControl.ItemsSource%2A> для <xref:System.Windows.Controls.DataGrid>. Группирование, сортировка и фильтрация выполняются на <xref:System.Windows.Data.CollectionViewSource> и отображаются в <xref:System.Windows.Controls.DataGrid> пользовательского интерфейса.

Чтобы протестировать этот пример, необходимо изменить имя DGGroupSortFilterExample в соответствии с именем проекта. Если вы используете Visual Basic, необходимо изменить имя класса для <xref:System.Windows.Window> следующим.

`<Window x:Class="MainWindow"`

[!code-xaml[DataGrid_GroupSortFilter#000](~/samples/snippets/csharp/VS_Snippets_Wpf/DataGrid_GroupSortFilter/CS/MainWindow.xaml#000)]
[!code-csharp[DataGrid_GroupSortFilter#100](~/samples/snippets/csharp/VS_Snippets_Wpf/DataGrid_GroupSortFilter/CS/MainWindow.xaml.cs#100)]


## <a name="see-also"></a>См. также

- [Общие сведения о привязке данных](../data/data-binding-overview.md)
- [Создание и привязка ObservableCollection](../data/how-to-create-and-bind-to-an-observablecollection.md)
- [Фильтрация данных в представлении](../data/how-to-filter-data-in-a-view.md)
- [Сортировка данных в представлении](../data/how-to-sort-data-in-a-view.md)
- [Сортировка и группировка данных с помощью представления в XAML](../data/how-to-sort-and-group-data-using-a-view-in-xaml.md)
