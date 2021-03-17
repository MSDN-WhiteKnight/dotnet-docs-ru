---
title: Общие сведения о GridView
ms.date: 03/30/2017
helpviewer_keywords:
- GridView view mode [WPF]
- ListView controls [WPF], GridView view mode
- controls [WPF], ListView
ms.assetid: b2d02267-32b3-40ce-8e9f-06972d8749d9
ms.openlocfilehash: d2f55db90fb130416ee4dcb15d440b6d367c0b06
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59201303"
---
# <a name="gridview-overview"></a>Общие сведения о GridView
<xref:System.Windows.Controls.GridView> режим — один из режимов представления для <xref:System.Windows.Controls.ListView> элемента управления. <xref:System.Windows.Controls.GridView> Класса и его вспомогательные классы позволяют вам и пользователям для просмотра коллекций элементов в таблице, в качестве интерактивных заголовков столбцов обычно используются кнопки. В данном разделе представлены <xref:System.Windows.Controls.GridView> класса и возможности его использования.  

<a name="DefiningaListViewthatusesGridViewView"></a>   
## <a name="what-is-a-gridview-view"></a>Что такое представление GridView?  
 <xref:System.Windows.Controls.GridView> Представления в режиме отображается список элементов данных посредством привязки полей данных к столбцам и отображения заголовка столбца для идентификации поля. Значение по умолчанию <xref:System.Windows.Controls.GridView> стиля реализует кнопок заголовков столбцов. С помощью кнопок для заголовков столбцов, можно реализовать возможности взаимодействия с пользователем важно; Например, пользователям можно щелкнуть заголовок столбца для сортировки <xref:System.Windows.Controls.GridView> данные в соответствии с содержимым конкретного столбца.  
  
> [!NOTE]
>  Кнопочные элементы управления, <xref:System.Windows.Controls.GridView> использует для заголовков столбцов являются производными от <xref:System.Windows.Controls.Primitives.ButtonBase>.  
  
 На следующем рисунке показано <xref:System.Windows.Controls.GridView> представление <xref:System.Windows.Controls.ListView> содержимого.  
    
 ![Снимок экрана: представление GridView содержимого ListView.](./media/gridview-overview/styled-listview-content.png)  
  
 <xref:System.Windows.Controls.GridView> столбцы представляются <xref:System.Windows.Controls.GridViewColumn> объекты, размер которых может автоматически в соответствии с содержимым. При необходимости можно явно задать <xref:System.Windows.Controls.GridViewColumn> ширину. Можно изменить размеры столбцов, перетащив границу между заголовками столбцов. Также динамически можно добавлять, удалять, заменять и изменять порядок столбцов, так как эта функция встроена в <xref:System.Windows.Controls.GridView>. Тем не менее <xref:System.Windows.Controls.GridView> нельзя напрямую обновлять данные, он отображает.  
  
 В следующем примере показано определение <xref:System.Windows.Controls.GridView> , отображаются данные о сотрудниках. В этом примере <xref:System.Windows.Controls.ListView> определяет `EmployeeInfoDataSource` как <xref:System.Windows.Controls.ItemsControl.ItemsSource%2A>. Определения свойств для <xref:System.Windows.Controls.GridViewColumn.DisplayMemberBinding%2A> привязать <xref:System.Windows.Controls.GridViewColumn> содержимого `EmployeeInfoDataSource` категории данных.  
  
 [!code-xaml[ListViewCode#ListViewEmployee](~/samples/snippets/csharp/VS_Snippets_Wpf/ListViewCode/CSharp/Window1.xaml#listviewemployee)]  
  
 На следующем рисунке показана таблица, которая создается в предыдущем примере. Элемент GridView отображает данные из ItemsSource объекта:
    
 ![Снимок экрана с ListView с выводом GridView.](./media/gridview-overview/listview-gridview-output.jpg)  
  
<a name="GridViewLayoutandStyle"></a>   
## <a name="gridview-layout-and-style"></a>Макет и стиль GridView  
 Ячейки и заголовок <xref:System.Windows.Controls.GridViewColumn> имеют одинаковую ширину. По умолчанию ширина каждого столбца изменяется в соответствии с шириной содержимого. При необходимости можно установить фиксированную ширину столбца.  
  
 Связанные данные отображаются в горизонтальных строках. Например, на предыдущем рисунке фамилия, имя и идентификационный номер каждого сотрудника отображаются в виде набора, поскольку они отображаются в горизонтальной строке.  
  
<a name="DefiningandStylingColumnsinaGridView"></a>   
### <a name="defining-and-styling-columns-in-a-gridview"></a>Определение и применение стилей к столбцам в GridView  
 При определении поля данных для отображения в <xref:System.Windows.Controls.GridViewColumn>, использовать <xref:System.Windows.Controls.GridViewColumn.DisplayMemberBinding%2A>, <xref:System.Windows.Controls.GridViewColumn.CellTemplate%2A>, или <xref:System.Windows.Controls.GridViewColumn.CellTemplateSelector%2A> свойства. <xref:System.Windows.Controls.GridViewColumn.DisplayMemberBinding%2A> Свойство имеет приоритет над любым из свойств шаблона.  
  
 Чтобы указать выравнивание содержимого в столбце <xref:System.Windows.Controls.GridView>, определить <xref:System.Windows.Controls.GridViewColumn.CellTemplate%2A>. Не используйте <xref:System.Windows.Controls.Control.HorizontalContentAlignment%2A> и <xref:System.Windows.Controls.Control.VerticalContentAlignment%2A> свойства <xref:System.Windows.Controls.ListView> содержимое, которое отображается с помощью <xref:System.Windows.Controls.GridView>.  
  
 Чтобы указать свойства шаблонов и стилей для заголовков столбцов, используйте <xref:System.Windows.Controls.GridView>, <xref:System.Windows.Controls.GridViewColumn>, и <xref:System.Windows.Controls.GridViewColumnHeader> классы. Дополнительные сведения см. в разделе [Общие сведения о стилях заголовков столбцов GridView и шаблонах](gridview-column-header-styles-and-templates-overview.md).  
  
<a name="AddingVisualElementstoaGridViewView"></a>   
### <a name="adding-visual-elements-to-a-gridview"></a>Добавление визуальных элементов в GridView  
 Чтобы добавить визуальные элементы, такие как <xref:System.Windows.Controls.CheckBox> и <xref:System.Windows.Controls.Button> управляет, <xref:System.Windows.Controls.GridView> режим просмотра, используйте шаблоны или стили.  
  
 Если явно определить визуальный элемент в качестве элемента данных, он может присутствовать только один раз в <xref:System.Windows.Controls.GridView>. Это ограничение существует, так как элемент может иметь только один родительский элемент и, таким образом, может появляться, только один раз в визуальном дереве.  
  
<a name="StylingRowsinaGridViewView"></a>   
### <a name="styling-rows-in-a-gridview"></a>Применение стилей к строкам в GridView  
 Используйте <xref:System.Windows.Controls.GridViewRowPresenter> и <xref:System.Windows.Controls.GridViewHeaderRowPresenter> классы для форматирования и отображения строк <xref:System.Windows.Controls.GridView>. Пример того, как стилей к строкам в <xref:System.Windows.Controls.GridView> режим просмотра, см. в разделе [стиля строки в ListView, реализующем GridView](how-to-style-a-row-in-a-listview-that-implements-a-gridview.md).  
  
<a name="AlignmentIssuesWhenUsingItemContainerStyle"></a>   
### <a name="alignment-issues-when-you-use-itemcontainerstyle"></a>Проблемы выравнивания при использовании ItemContainerStyle  
 Чтобы предотвратить проблемы выравнивания между заголовками столбцов и ячейками, не задания свойства или указать шаблон, который влияет на ширину элемента в <xref:System.Windows.Controls.ItemsControl.ItemContainerStyle%2A>. Например, не устанавливайте <xref:System.Windows.FrameworkElement.Margin%2A> свойства или указать <xref:System.Windows.Controls.ControlTemplate> , добавляющий <xref:System.Windows.Controls.CheckBox> для <xref:System.Windows.Controls.ItemsControl.ItemContainerStyle%2A> , определенному в <xref:System.Windows.Controls.ListView> элемента управления. Вместо этого укажите свойства и шаблоны, которые влияют на ширину столбца, непосредственно в классах, определяющих <xref:System.Windows.Controls.GridView> режим просмотра.  
  
 Например, чтобы добавить <xref:System.Windows.Controls.CheckBox> к строкам в <xref:System.Windows.Controls.GridView> режим просмотра, добавления <xref:System.Windows.Controls.CheckBox> для <xref:System.Windows.DataTemplate>и задайте <xref:System.Windows.Controls.GridViewColumn.CellTemplate%2A> свойства <xref:System.Windows.DataTemplate>.  
  
<a name="InteractingwithaGridViewControl"></a>   
## <a name="user-interactions-with-a-gridview"></a>Взаимодействие пользователя с GridView  
 При использовании <xref:System.Windows.Controls.GridView> в приложении, пользователи могут взаимодействовать с и изменить форматирование <xref:System.Windows.Controls.GridView>. Например, пользователи могут изменить порядок столбцов, изменить размер столбца, выделить элементы в таблице и прокрутить содержимое. Можно также определить обработчик событий, реагирующий на нажатие пользователем кнопки заголовка столбца. Обработчик событий может выполнять такие операции, как сортировка данных, который отображается в <xref:System.Windows.Controls.GridView> в соответствии с содержимым столбца.  
  
 Ниже более подробно рассматриваются возможности использования <xref:System.Windows.Controls.GridView> для взаимодействия с пользователем:  
  
-   **Изменение порядка столбцов с помощью метода перетаскивания и вставки.**  
  
     Пользователи могут изменить порядок столбцов в <xref:System.Windows.Controls.GridView> путем нажатия левой кнопки мыши над заголовком столбца и перетаскивания этого столбца в новую позицию. Пока пользователь перетаскивает заголовок столбца, отображается плавающей версии заголовка, а также сплошная черная линия, показывающая место вставки столбца.  
  
     Если вы хотите изменить стиль по умолчанию для плавающей версии заголовка, укажите <xref:System.Windows.Controls.ControlTemplate> для <xref:System.Windows.Controls.GridViewColumnHeader> типа, который является инициируется при <xref:System.Windows.Controls.GridViewColumnHeader.Role%2A> свойству <xref:System.Windows.Controls.GridViewColumnHeaderRole.Floating>. Дополнительные сведения см. в разделе [Как создать стиль для перетаскиваемого заголовка столбца GridView](how-to-create-a-style-for-a-dragged-gridview-column-header.md).  
  
-   **Изменение размера столбца по его содержимому.**  
  
     Пользователям можно дважды щелкнуть границу справа от заголовка столбца, чтобы изменить размер столбца в соответствии с содержимым.  
  
    > [!NOTE]
    >  Можно задать <xref:System.Windows.Controls.GridViewColumn.Width%2A> свойства `Double.NaN` для создания такой же эффект.  
  
-   **Выбор элементов строк.**  
  
     Пользователи могут выбрать один или несколько элементов в <xref:System.Windows.Controls.GridView>.  
  
     Если вы хотите изменить <xref:System.Windows.Style> выбранного элемента, см. в разделе [Применение триггеров для определения стиля выбранных элементов в ListView](how-to-use-triggers-to-style-selected-items-in-a-listview.md).  
  
-   **Прокрутка для просмотра содержимого, не отображается на экране изначально.**  
  
     Если размер <xref:System.Windows.Controls.GridView> является недостаточен для отображения всех элементов, пользователи смогут прокручивать горизонтально или вертикально с помощью полосы прокрутки, которые предоставляются элементом <xref:System.Windows.Controls.ScrollViewer> элемента управления. Объект <xref:System.Windows.Controls.Primitives.ScrollBar> скрыт, если все содержимое является видимым в определенном направлении. При использовании полос прокрутки заголовки столбцов не прокручиваются по вертикали, но могут прокручиваться по горизонтали.  
  
-   **Взаимодействие со столбцами путем нажатия кнопок заголовков столбцов.**  
  
     При нажатии кнопки заголовка столбца можно отсортировать данные, которые отображаются в столбце, если указан алгоритм сортировки.  
  
     Можно обрабатывать <xref:System.Windows.Controls.Primitives.ButtonBase.Click> событий для кнопок заголовков столбцов, чтобы обеспечить функциональные возможности алгоритма сортировки. Для обработки <xref:System.Windows.Controls.Primitives.ButtonBase.Click> событий для одного заголовка столбца, задайте обработчик событий на <xref:System.Windows.Controls.GridViewColumnHeader>. Чтобы задать обработчик событий, который обрабатывает <xref:System.Windows.Controls.Primitives.ButtonBase.Click> событий для всех заголовков столбцов, задайте обработчик для <xref:System.Windows.Controls.ListView> элемента управления.  
  
<a name="Obtaining_Other_Custom_Views"></a>   
## <a name="obtaining-other-custom-views"></a>Получение других настраиваемых представлений  
 <xref:System.Windows.Controls.GridView> Класс, который является производным от <xref:System.Windows.Controls.ViewBase> абстрактного класса, является только одним из возможных режимов представления для <xref:System.Windows.Controls.ListView> класса. Можно создать другие настраиваемые представления для <xref:System.Windows.Controls.ListView> путем наследования от <xref:System.Windows.Controls.ViewBase> класса. Пример настраиваемого режима представления см. в разделе [Создание пользовательского режима представления для ListView](how-to-create-a-custom-view-mode-for-a-listview.md).  
  
<a name="GridViewSupportingClasses"></a>   
## <a name="gridview-supporting-classes"></a>Вспомогательные классы GridView  
 Следующие классы поддерживают <xref:System.Windows.Controls.GridView> режим просмотра.  
  
-   <xref:System.Windows.Controls.GridViewColumn>  
  
-   <xref:System.Windows.Controls.GridViewColumnHeader>  
  
-   <xref:System.Windows.Controls.GridViewRowPresenter>  
  
-   <xref:System.Windows.Controls.GridViewHeaderRowPresenter>  
  
-   <xref:System.Windows.Controls.GridViewColumnCollection>  
  
-   <xref:System.Windows.Controls.GridViewColumnHeaderRole>  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Controls.ListView>
- <xref:System.Windows.Controls.ListViewItem>
- <xref:System.Windows.Controls.GridViewColumn>
- <xref:System.Windows.Controls.GridViewColumnHeader>
- <xref:System.Windows.Controls.GridViewRowPresenter>
- <xref:System.Windows.Controls.GridViewHeaderRowPresenter>
- <xref:System.Windows.Controls.ViewBase>
- [Общие сведения об элементе управления ListView](listview-overview.md)
- [Сортировка столбцов GridView при нажатии на заголовок](how-to-sort-a-gridview-column-when-a-header-is-clicked.md)
- [Практические руководства](listview-how-to-topics.md)
