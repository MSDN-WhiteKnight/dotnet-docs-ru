---
title: Архитектура элементов управления DataGridView (Windows Forms)
ms.date: 03/30/2017
helpviewer_keywords:
- DataGridView control [Windows Forms], architecture
ms.assetid: 1c6cabf0-02ee-4bbc-9574-b54bb7f5b19e
ms.openlocfilehash: 892168ec282fbf168c43515e0718fe5486a345a8
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59130264"
---
# <a name="datagridview-control-architecture-windows-forms"></a>Архитектура элементов управления DataGridView (Windows Forms)
<xref:System.Windows.Forms.DataGridView> Управления и связанные с ним классы предназначены для гибкую, расширяемую систему для отображения и редактирования табличных данных. Все эти классы содержатся в <xref:System.Windows.Forms?displayProperty=nameWithType> пространства имен и они именуются с префиксом «DataGridView».  
  
## <a name="architecture-elements"></a>Элементы архитектуры  
 Основной <xref:System.Windows.Forms.DataGridView> сопутствующих классов являются производными от <xref:System.Windows.Forms.DataGridViewElement>. Приведенные ниже объектные модели иллюстрирует <xref:System.Windows.Forms.DataGridViewElement> иерархии наследования.  
  
 ![Схема, показывающая объектная модель DataGridViewElement иерархии.](./media/datagridview-control-architecture-windows-forms/datagridviewelement-object-model.gif)  
  
 <xref:System.Windows.Forms.DataGridViewElement> Класс предоставляет ссылку на родительский <xref:System.Windows.Forms.DataGridView> а <xref:System.Windows.Forms.DataGridViewElement.State%2A> свойство, которое содержит значение, которое представляет собой сочетание значений из <xref:System.Windows.Forms.DataGridViewElementStates> перечисления.  
  
 В следующих разделах описываются <xref:System.Windows.Forms.DataGridView> сопутствующих классов более подробно.  
  
### <a name="datagridviewelementstates"></a>DataGridViewElementStates  
 <xref:System.Windows.Forms.DataGridViewElementStates> Перечисление содержит следующие значения:  
  
-   <xref:System.Windows.Forms.DataGridViewElementStates.None>  
  
-   <xref:System.Windows.Forms.DataGridViewElementStates.Frozen>  
  
-   <xref:System.Windows.Forms.DataGridViewElementStates.ReadOnly>  
  
-   <xref:System.Windows.Forms.DataGridViewElementStates.Resizable>  
  
-   <xref:System.Windows.Forms.DataGridViewElementStates.ResizableSet>  
  
-   <xref:System.Windows.Forms.DataGridViewElementStates.Selected>  
  
-   <xref:System.Windows.Forms.DataGridViewElementStates.Visible>  
  
 Значения этого перечисления могут сочетаться с побитовые логические операторы, поэтому <xref:System.Windows.Forms.DataGridViewElement.State%2A> свойство можно выразить несколько состояний одновременно. Например <xref:System.Windows.Forms.DataGridViewElement> может быть одновременно <xref:System.Windows.Forms.DataGridViewElementStates.Frozen>, <xref:System.Windows.Forms.DataGridViewElementStates.Selected>, и <xref:System.Windows.Forms.DataGridViewElementStates.Visible>.  
  
### <a name="cells-and-bands"></a>Ячейки и зоны  
 <xref:System.Windows.Forms.DataGridView> Элемент управления состоит из двух основных типов объектов: ячейки и зоны. Все ячейки, являются производными от <xref:System.Windows.Forms.DataGridViewCell> базового класса. Два вида делений, <xref:System.Windows.Forms.DataGridViewColumn> и <xref:System.Windows.Forms.DataGridViewRow>, оба являются производными от <xref:System.Windows.Forms.DataGridViewBand> базового класса.  
  
 <xref:System.Windows.Forms.DataGridView> Управления взаимодействует с несколькими классами, но чаще всего встречаются <xref:System.Windows.Forms.DataGridViewCell>, <xref:System.Windows.Forms.DataGridViewColumn>, и <xref:System.Windows.Forms.DataGridViewRow>.  
  
### <a name="datagridviewcell"></a>DataGridViewCell  
 Ячейка является основной единицей взаимодействия для <xref:System.Windows.Forms.DataGridView>. Отображение выравнивается по центру ячейки и ввода данных часто выполняется по ячейкам. Доступ к ячейкам с помощью <xref:System.Windows.Forms.DataGridViewRow.Cells%2A> коллекцию <xref:System.Windows.Forms.DataGridViewRow> , поэтому для доступа к выбранным ячейкам используется <xref:System.Windows.Forms.DataGridView.SelectedCells%2A> коллекцию <xref:System.Windows.Forms.DataGridView> элемента управления. Приведенные ниже объектные модели показан пример использования и показывает <xref:System.Windows.Forms.DataGridViewCell> иерархии наследования.  
  
 ![Схема, показывающая иерархии объектная модель DataGridViewCell.](./media/datagridview-control-architecture-windows-forms/datagridviewcell-object-model.gif)  
  
 <xref:System.Windows.Forms.DataGridViewCell> Тип является абстрактным базовым классом, от которого наследуют все типы ячеек. <xref:System.Windows.Forms.DataGridViewCell> и его производные типы не являются элементы управления Windows Forms, но некоторые элементы управления ведущего приложения Windows Forms. Любые изменения функциональных возможностей, поддерживаемых ячейки обычно обрабатывается размещаемого элемента управления.  
  
 <xref:System.Windows.Forms.DataGridViewCell> объекты контролирует собственные внешним видом и оформлением так же как элементы управления Windows Forms. Вместо этого <xref:System.Windows.Forms.DataGridView> несет ответственность за внешний вид его <xref:System.Windows.Forms.DataGridViewCell> объектов. Вы может существенно повлиять на внешний вид и поведение ячеек, взаимодействуя с <xref:System.Windows.Forms.DataGridView> свойства и события элемента управления. При наличии особых требований к настройкам, выходящих за рамки возможностей <xref:System.Windows.Forms.DataGridView> элемента управления, можно реализовать собственный класс, производный от <xref:System.Windows.Forms.DataGridViewCell> или одного из его дочерних классов.  
  
 В следующем списке приведены классы, производные от <xref:System.Windows.Forms.DataGridViewCell>:  
  
-   <xref:System.Windows.Forms.DataGridViewTextBoxCell>  
  
-   <xref:System.Windows.Forms.DataGridViewButtonCell>  
  
-   <xref:System.Windows.Forms.DataGridViewLinkCell>  
  
-   <xref:System.Windows.Forms.DataGridViewCheckBoxCell>  
  
-   <xref:System.Windows.Forms.DataGridViewComboBoxCell>  
  
-   <xref:System.Windows.Forms.DataGridViewImageCell>  
  
-   <xref:System.Windows.Forms.DataGridViewHeaderCell>  
  
-   <xref:System.Windows.Forms.DataGridViewRowHeaderCell>  
  
-   <xref:System.Windows.Forms.DataGridViewColumnHeaderCell>  
  
-   <xref:System.Windows.Forms.DataGridViewTopLeftHeaderCell>  
  
-   Пользовательские типы ячеек  
  
### <a name="datagridviewcolumn"></a>DataGridViewColumn  
 Схема <xref:System.Windows.Forms.DataGridView> элемента управления хранилища данных выражается в <xref:System.Windows.Forms.DataGridView> столбцов элемента управления. Вы можете получить доступ к <xref:System.Windows.Forms.DataGridView> столбцов элемента управления с помощью <xref:System.Windows.Forms.DataGridView.Columns%2A> коллекции. Доступ к выбранным столбцам с помощью <xref:System.Windows.Forms.DataGridView.SelectedColumns%2A> коллекции. Приведенные ниже объектные модели показан пример использования и показывает <xref:System.Windows.Forms.DataGridViewColumn> иерархии наследования.  
  
 ![Схема, показывающая объектная модель DataGridViewColumn иерархии.](./media/datagridview-control-architecture-windows-forms/datagridviewcolumn-object-model.gif)  
  
 Некоторые типы ключей ячейки имеют соответствующие типы столбцов. Они являются производными от <xref:System.Windows.Forms.DataGridViewColumn> базового класса.  
  
 В следующем списке приведены классы, производные от <xref:System.Windows.Forms.DataGridViewColumn>:  
  
-   <xref:System.Windows.Forms.DataGridViewButtonColumn>  
  
-   <xref:System.Windows.Forms.DataGridViewCheckBoxColumn>  
  
-   <xref:System.Windows.Forms.DataGridViewComboBoxColumn>  
  
-   <xref:System.Windows.Forms.DataGridViewImageColumn>  
  
-   <xref:System.Windows.Forms.DataGridViewTextBoxColumn>  
  
-   <xref:System.Windows.Forms.DataGridViewLinkColumn>  
  
-   Пользовательские типы столбцов  
  
### <a name="datagridview-editing-controls"></a>Элементы управления редактирования DataGridView  
 Ячейки, которые обычно поддерживают расширенные функции редактирования используйте размещаемого элемента управления, который является производным от элемента управления Windows Forms. Эти элементы управления также реализовать <xref:System.Windows.Forms.IDataGridViewEditingControl> интерфейс. Приведенные ниже объектные модели иллюстрирует использование этих элементов управления.  
  
 ![Схема, показывающая иерархии DataGridView редактирования объектная модель элемента управления.](./media/datagridview-control-architecture-windows-forms/datagridviewediting-object-model.gif)  
  
 Следующие элементы управления редактирования входящие в состав <xref:System.Windows.Forms.DataGridView> управления:  
  
-   <xref:System.Windows.Forms.DataGridViewComboBoxEditingControl>  
  
-   <xref:System.Windows.Forms.DataGridViewTextBoxEditingControl>  
  
 Сведения о создании собственных редактирования элементов управления, см. в разделе [как: Ведущие элементы управления в формах Windows Forms ячеек элемента управления DataGridView](how-to-host-controls-in-windows-forms-datagridview-cells.md).  
  
 В следующей таблице показано отношение между типов ячеек, типы столбцов и элементами управления.  
  
|Тип ячейки|Размещаемый элемент управления|Тип столбца|  
|---------------|--------------------|-----------------|  
|<xref:System.Windows.Forms.DataGridViewButtonCell>|Н/Д|<xref:System.Windows.Forms.DataGridViewButtonColumn>|  
|<xref:System.Windows.Forms.DataGridViewCheckBoxCell>|Н/Д|<xref:System.Windows.Forms.DataGridViewCheckBoxColumn>|  
|<xref:System.Windows.Forms.DataGridViewComboBoxCell>|<xref:System.Windows.Forms.DataGridViewComboBoxEditingControl>|<xref:System.Windows.Forms.DataGridViewComboBoxColumn>|  
|<xref:System.Windows.Forms.DataGridViewImageCell>|Н/Д|<xref:System.Windows.Forms.DataGridViewImageColumn>|  
|<xref:System.Windows.Forms.DataGridViewLinkCell>|Н/Д|<xref:System.Windows.Forms.DataGridViewLinkColumn>|  
|<xref:System.Windows.Forms.DataGridViewTextBoxCell>|<xref:System.Windows.Forms.DataGridViewTextBoxEditingControl>|<xref:System.Windows.Forms.DataGridViewTextBoxColumn>|  
  
### <a name="datagridviewrow"></a>DataGridViewRow  
 <xref:System.Windows.Forms.DataGridViewRow> Хранения класс отображает поля данных записи из данных, к которому <xref:System.Windows.Forms.DataGridView> присоединяется элемент управления. Вы можете получить доступ к <xref:System.Windows.Forms.DataGridView> строк элемента управления с помощью <xref:System.Windows.Forms.DataGridView.Rows%2A> коллекции. Выбранные строки доступны посредством <xref:System.Windows.Forms.DataGridView.SelectedRows%2A> коллекции. Приведенные ниже объектные модели показан пример использования и показывает <xref:System.Windows.Forms.DataGridViewRow> иерархии наследования.  
  
 ![Схема, показывающая объектная модель DataGridViewRow иерархии.](./media/datagridview-control-architecture-windows-forms/datagridviewrow-object-model.gif)
  
 Можно создавать производные пользовательские типы из <xref:System.Windows.Forms.DataGridViewRow> класса, несмотря на то, что это обычно не нужно выполнять. <xref:System.Windows.Forms.DataGridView> Элемент управления имеет несколько событий, связанных со строками и свойств для настройки поведения его <xref:System.Windows.Forms.DataGridViewRow> объектов.  
  
 Если вы включаете <xref:System.Windows.Forms.DataGridView> элемента управления <xref:System.Windows.Forms.DataGridView.AllowUserToAddRows%2A> , отдельную строку для добавления новых строк отображается как последняя строка. Эта строка является частью <xref:System.Windows.Forms.DataGridView.Rows%2A> коллекции, но он имеет специальные функции, которые могут потребовать вашего внимания. Дополнительные сведения см. в разделе [с помощью строки для новых записей в элементе управления DataGridView Windows Forms](using-the-row-for-new-records-in-the-windows-forms-datagridview-control.md).  
  
## <a name="see-also"></a>См. также

- [Общие сведения об элементе управления DataGridView](datagridview-control-overview-windows-forms.md)
- [Настройка элементов управления DataGridView в Windows Forms](customizing-the-windows-forms-datagridview-control.md)
- [Использование строки элемента управления DataGridView, предназначенной для ввода новых данных, в Windows Forms](using-the-row-for-new-records-in-the-windows-forms-datagridview-control.md)
