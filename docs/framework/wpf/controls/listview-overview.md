---
title: Общие сведения об элементе управления ListView
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- controls [WPF], ListView
- ListView controls [WPF], about ListView control
ms.assetid: 989e12b0-260e-4570-95c6-489284003ce2
ms.openlocfilehash: 6d4a6c19dc0af8a2950754f32890ae9c3bcbad21
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59186502"
---
# <a name="listview-overview"></a>Общие сведения об элементе управления ListView
<xref:System.Windows.Controls.ListView> Управления предоставляет инфраструктуру для отображения набора элементов данных в различных макетах или представлениях. Например, у пользователя может возникнуть необходимость в отображении элементов данных в таблице, а также в сортировке ее столбцов.  

<a name="WhatisaListView"></a>   
## <a name="what-is-a-listview"></a>Понятие об элементе управления ListView  
 <xref:System.Windows.Controls.ListView> Элемент управления является <xref:System.Windows.Controls.ItemsControl> , производный от <xref:System.Windows.Controls.ListBox>. Как правило, его элементы являются элементами коллекции данных и представляются в виде <xref:System.Windows.Controls.ListViewItem> объектов. Объект <xref:System.Windows.Controls.ListViewItem> является <xref:System.Windows.Controls.ContentControl> и может содержать только один дочерний элемент. Но дочерним может быть любой визуальный элемент.  
  
<a name="DefiningaListViewView"></a>   
## <a name="defining-a-view-mode-for-a-listview"></a>Определение режима представления для элемента управления ListView  
 Чтобы указать режим просмотра содержимого <xref:System.Windows.Controls.ListView> элемента управления, задайте <xref:System.Windows.Controls.ListView.View%2A> свойство. Одним из режимов, Windows Presentation Foundation (WPF) предоставляет является <xref:System.Windows.Controls.GridView>, отображающий коллекцию элементов данных в таблице с настраиваемыми столбцами.  
  
 В следующем примере показано определение <xref:System.Windows.Controls.GridView> для <xref:System.Windows.Controls.ListView> элемент управления, который отображает данные о сотрудниках.  
  
 [!code-xaml[ListViewCode#ListViewEmployee](~/samples/snippets/csharp/VS_Snippets_Wpf/ListViewCode/CSharp/Window1.xaml#listviewemployee)]  
  
 На следующем рисунке показано, как будут отображаться данные для предыдущего примера.  
  
 ![Снимок экрана с ListView с выводом GridView.](./media/gridview-overview/listview-gridview-output.jpg)  
  
 Пользовательского режима представления можно создать, определив класс, наследуемый от <xref:System.Windows.Controls.ViewBase> класса. <xref:System.Windows.Controls.ViewBase> Класс предоставляет инфраструктуру, вам нужно создать пользовательское представление. Дополнительные сведения о создании пользовательского представления см. в разделе [Создание пользовательского режима представления для ListView](how-to-create-a-custom-view-mode-for-a-listview.md).  
  
<a name="BindingDatatoaListView"></a>   
## <a name="binding-data-to-a-listview"></a>Привязка данных к элементу управления ListView  
 Используйте <xref:System.Windows.Controls.ItemsControl.Items%2A> и <xref:System.Windows.Controls.ItemsControl.ItemsSource%2A> свойства, чтобы указать элементы для <xref:System.Windows.Controls.ListView> элемента управления. В следующем примере задается <xref:System.Windows.Controls.ItemsControl.ItemsSource%2A> свойство коллекции данных, которая называется `EmployeeInfoDataSource`.  
  
 [!code-xaml[ListViewCode#ItemsSource](~/samples/snippets/csharp/VS_Snippets_Wpf/ListViewCode/CSharp/Window1.xaml#itemssource)]  
  
 В <xref:System.Windows.Controls.GridView>, <xref:System.Windows.Controls.GridViewColumn> привязать объекты к указанным полям данных. Следующий пример связывает <xref:System.Windows.Controls.GridViewColumn> объекта к полю данных путем указания <xref:System.Windows.Data.Binding> для <xref:System.Windows.Controls.GridViewColumn.DisplayMemberBinding%2A> свойство.  
  
 [!code-csharp[ListViewCode#GridViewColumnProperties](~/samples/snippets/csharp/VS_Snippets_Wpf/ListViewCode/CSharp/Window1.xaml.cs#gridviewcolumnproperties)]
 
 [!code-xaml[ListViewCode#GridViewColumnProperties](~/samples/snippets/csharp/VS_Snippets_Wpf/ListViewCode/CSharp/Window1.xaml#gridviewcolumnproperties)]  
  
 Можно также указать <xref:System.Windows.Data.Binding> как часть <xref:System.Windows.DataTemplate> определение, которое используется для применения стиля к ячейкам столбца. В следующем примере <xref:System.Windows.DataTemplate> , определяемому с <xref:System.Windows.ResourceKey> задает <xref:System.Windows.Data.Binding> для <xref:System.Windows.Controls.GridViewColumn>. Обратите внимание, что в этом примере не определяет <xref:System.Windows.Controls.GridViewColumn.DisplayMemberBinding%2A> так, как это переопределяет привязку, которая определяется <xref:System.Windows.DataTemplate>.  
  
 [!code-xaml[ListViewTemplate#GridViewCellTemplate](~/samples/snippets/csharp/VS_Snippets_Wpf/ListViewTemplate/CS/window1.xaml#gridviewcelltemplate)]  
  
 [!code-xaml[ListViewTemplate#CellTemplateProperty](~/samples/snippets/csharp/VS_Snippets_Wpf/ListViewTemplate/CS/window1.xaml#celltemplateproperty)]  
  
<a name="StylingaListView"></a>   
## <a name="styling-a-listview-that-implements-a-gridview"></a>Задание стиля ListView, который реализует GridView  
 <xref:System.Windows.Controls.ListView> Элемент управления содержит <xref:System.Windows.Controls.ListViewItem> объектов, представляющих элементы данных, которые отображаются. Можно использовать следующие свойства для определения содержимого и стиля элементов данных:  
  
-   На <xref:System.Windows.Controls.ListView> управления, используйте <xref:System.Windows.Controls.ItemsControl.ItemTemplate%2A>, <xref:System.Windows.Controls.ItemsControl.ItemTemplateSelector%2A>, и <xref:System.Windows.Controls.ItemsControl.ItemContainerStyle%2A> свойства.  
  
-   На <xref:System.Windows.Controls.ListViewItem> управления, используйте <xref:System.Windows.Controls.ContentControl.ContentTemplate%2A> и <xref:System.Windows.Controls.ContentControl.ContentTemplateSelector%2A> свойства.  
  
 Чтобы избежать проблем выравнивания между ячейками в <xref:System.Windows.Controls.GridView>, не используйте <xref:System.Windows.Controls.ItemsControl.ItemContainerStyle%2A> для задания свойств или добавления содержимого, которое влияет на ширину элемента в <xref:System.Windows.Controls.ListView>. Например, проблема выравнивания может возникнуть при установке <xref:System.Windows.FrameworkElement.Margin%2A> свойство в <xref:System.Windows.Controls.ItemsControl.ItemContainerStyle%2A>. Чтобы задать свойства или определить содержимое, влияющее на ширину элементов в <xref:System.Windows.Controls.GridView>, используйте свойства класса <xref:System.Windows.Controls.GridView> класс и связанные с ним классы, такие как <xref:System.Windows.Controls.GridViewColumn>.  
  
 Дополнительные сведения об использовании <xref:System.Windows.Controls.GridView> и его вспомогательных классов см. в разделе [Общие сведения о GridView](gridview-overview.md).  
  
 При определении <xref:System.Windows.Controls.ItemsControl.ItemContainerStyle%2A> для <xref:System.Windows.Controls.ListView> также определять и управлять ими <xref:System.Windows.Controls.ItemsControl.ItemTemplate%2A>, необходимо включить <xref:System.Windows.Controls.ContentPresenter> в стиле выполнился <xref:System.Windows.Controls.ItemsControl.ItemTemplate%2A> для правильной работы.  
  
 Не используйте <xref:System.Windows.Controls.Control.HorizontalContentAlignment%2A> и <xref:System.Windows.Controls.Control.VerticalContentAlignment%2A> свойства <xref:System.Windows.Controls.ListView> содержимое, которое отображается с помощью <xref:System.Windows.Controls.GridView>. Чтобы указать выравнивание содержимого в столбце <xref:System.Windows.Controls.GridView>, определить <xref:System.Windows.Controls.GridViewColumn.CellTemplate%2A>.  
  
<a name="UsingtheSameViewMoreThanOnce"></a>   
## <a name="sharing-the-same-view-mode"></a>Совместное использование одного режима представления  
 Два <xref:System.Windows.Controls.ListView> элементы управления не могут совместно использовать один и тот же режим представления, в то же время. Если вы попытаетесь использовать тот же режим представления с более чем одним <xref:System.Windows.Controls.ListView> управления, возникает исключение.  
  
 Чтобы указать режим представления, который может одновременно использоваться более чем одной <xref:System.Windows.Controls.ListView>, используйте шаблоны или стили.
  
<a name="CreatingaCustomView"></a>   
## <a name="creating-a-custom-view-mode"></a>Создание пользовательского режима представления  
 Настраиваемые представления, такие как <xref:System.Windows.Controls.GridView> являются производными от <xref:System.Windows.Controls.ViewBase> абстрактный класс, который предоставляет средства для отображения элементов данных, которые отображаются в виде <xref:System.Windows.Controls.ListViewItem> объектов.    
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Controls.GridView>
- <xref:System.Windows.Controls.ListView>
- <xref:System.Windows.Controls.ListViewItem>
- <xref:System.Windows.Data.Binding>
- [Общие сведения о GridView](gridview-overview.md)
- [Практические руководства](listview-how-to-topics.md)
- [Элементы управления](../advanced/optimizing-performance-controls.md)
