---
title: Общие сведения о таблицах
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- flow content elements [WPF], Table
- documents [WPF], tables
- tables [WPF]
ms.assetid: 5e1105f4-8fc4-473a-ba55-88c8e71386e6
ms.openlocfilehash: 6485aa9f2094b734f796ff38a33f4e0d3434e004
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59317666"
---
# <a name="table-overview"></a>Общие сведения о таблицах
<xref:System.Windows.Documents.Table> представляет собой элемент уровня блока, который поддерживает представление на основе сетки содержимого документа. Гибкость этого элемента делает его очень полезным, но также и более сложным для понимания и правильного использования.  
  
 В этом разделе содержатся следующие подразделы.  
  
-   [Основные сведения о таблицах](#table_basics)  
  
-   [Отличие таблицы от сетки](#table_vs_Grid)  
  
-   [Основная структура таблицы](#basic_table_structure)  
  
-   [Вложения таблицы](#table_containment)  
  
-   [Группирование строк](#row_groupings)  
  
-   [Приоритет отрисовки фона](#rendering_precedence)  
  
-   [Объединение строк или столбцов](#spanning_rows_or_columns)  
  
-   [Построение таблицы с помощью кода](#building_a_table_with_code)  
  
-   [Связанные разделы] 
  
<a name="table_basics"></a>   
## <a name="table-basics"></a>Основные сведения о таблицах  
  
<a name="table_vs_Grid"></a>   
### <a name="how-is-table-different-then-grid"></a>Отличие таблицы от сетки  
 <xref:System.Windows.Documents.Table> и <xref:System.Windows.Controls.Grid> совместно использовать некоторые общие функциональные возможности, но каждый из них лучше всего подходит для различных сценариев. Объект <xref:System.Windows.Documents.Table> предназначен для использования в потоковом содержимом (см. в разделе [Общие](flow-document-overview.md) Дополнительные сведения о потоковом содержимом). Сетки лучше всего использовать внутри форм (по сути в любом месте вне потокового содержимого). В рамках <xref:System.Windows.Documents.FlowDocument>, <xref:System.Windows.Documents.Table> поддерживает поток такие возможности, как разбиение на страницы, Перекомпоновка столбцов и Выбор содержимого при <xref:System.Windows.Controls.Grid> — нет. Объект <xref:System.Windows.Controls.Grid> с другой стороны лучше всего использовать за пределами <xref:System.Windows.Documents.FlowDocument> по многим причинам, в том числе <xref:System.Windows.Controls.Grid> добавляет элементы на основе индекса строк и столбцов, <xref:System.Windows.Documents.Table> — нет. <xref:System.Windows.Controls.Grid> Элемент позволяет создавать слои дочернего содержимого, позволяя более чем одного элемента существовать внутри одной «ячейки». <xref:System.Windows.Documents.Table> не поддерживает слои. Дочерние элементы <xref:System.Windows.Controls.Grid> можно абсолютно позиционировать относительно области границ их «ячейки». <xref:System.Windows.Documents.Table> не поддерживает эту функцию. Наконец <xref:System.Windows.Controls.Grid> требует меньше ресурсов, а затем <xref:System.Windows.Documents.Table> поэтому рассмотрите возможность использования <xref:System.Windows.Controls.Grid> для повышения производительности.  
  
<a name="basic_table_structure"></a>   
### <a name="basic-table-structure"></a>Основная структура таблицы  
 <xref:System.Windows.Documents.Table> предоставляет презентацию основе сетки, состоящий из столбцов (представленный <xref:System.Windows.Documents.TableColumn> элементов) и строк (представленных <xref:System.Windows.Documents.TableRow> элементов). <xref:System.Windows.Documents.TableColumn> элементы не размещайте содержимого; они просто определяют столбцы и их характеристики. <xref:System.Windows.Documents.TableRow> элементы должны размещаться в <xref:System.Windows.Documents.TableRowGroup> элемент, который определяет группирование строк в таблице. <xref:System.Windows.Documents.TableCell> элементы, которые содержат фактическое содержимое, которое должно быть представлено в таблице, должны размещаться в <xref:System.Windows.Documents.TableRow> элемент. <xref:System.Windows.Documents.TableCell> может содержать только элементы, которые являются производными от <xref:System.Windows.Documents.Block>.  Допустимые дочерние элементы для <xref:System.Windows.Documents.TableCell> включают.  
  
-   <xref:System.Windows.Documents.BlockUIContainer>  
  
-   <xref:System.Windows.Documents.List>  
  
-   <xref:System.Windows.Documents.Paragraph>  
  
-   <xref:System.Windows.Documents.Section>  
  
-   <xref:System.Windows.Documents.Table>  
  
> [!NOTE]
>  <xref:System.Windows.Documents.TableCell> элементы могут не содержать текстовое содержимое. Дополнительные сведения о правилах включения для потока содержимого элементы, такие как <xref:System.Windows.Documents.TableCell>, см. в разделе [Общие](flow-document-overview.md).  
  
> [!NOTE]
>  <xref:System.Windows.Documents.Table> аналогичен <xref:System.Windows.Controls.Grid> элемент но имеет больше возможностей и, следовательно, требует больше ресурсов.  
  
 В следующем примере определяется Простая таблица 2 x 3 с помощью XAML.  
  
 [!code-xaml[TableSnippets2#_Table_BasicLayout](~/samples/snippets/csharp/VS_Snippets_Wpf/TableSnippets2/CSharp/Window1.xaml#_table_basiclayout)]  
  
 На следующем рисунке показана отрисовка этого примера.  
  
 ![Снимок экрана: отрисовка базовой таблицы.](./media/table-overview/basic-table-render-example.png)  
  
<a name="table_containment"></a>   
### <a name="table-containment"></a>Вложения таблицы  
 <xref:System.Windows.Documents.Table> является производным от <xref:System.Windows.Documents.Block> элемент и следует общим правилам для <xref:System.Windows.Documents.Block> элементов уровня.  Объект <xref:System.Windows.Documents.Table> элемент может содержаться в любом из следующих элементов:  
  
-   <xref:System.Windows.Documents.FlowDocument>  
  
-   <xref:System.Windows.Documents.TableCell>  
  
-   <xref:System.Windows.Controls.ListBoxItem>  
  
-   <xref:System.Windows.Controls.ListViewItem>  
  
-   <xref:System.Windows.Documents.Section>  
  
-   <xref:System.Windows.Documents.Floater>  
  
-   <xref:System.Windows.Documents.Figure>  
  
<a name="row_groupings"></a>   
### <a name="row-groupings"></a>Группирование строк  
 <xref:System.Windows.Documents.TableRowGroup> Элемент предоставляет способ произвольного группирования строк в таблице; каждая строка таблицы должна принадлежать группе строк.  Строки в группе часто имеют общее назначение и могут быть стилизованы в виде группы.  Обычно группирование строк используется для отделения строк специального назначения, например строк названия, заголовка и нижнего колонтитула, от основного содержимого, находящегося в таблице.  
  
 В следующем примере используется XAML для определения таблицы с примененным стилем заголовка и нижнего колонтитула.  
  
 [!code-xaml[TableSnippets2#_Table_RowGroups](~/samples/snippets/csharp/VS_Snippets_Wpf/TableSnippets2/CSharp/Window1.xaml#_table_rowgroups)]  
  
 На следующем рисунке показана отрисовка этого примера.  
  
 ![Снимок экрана: Группы строк таблицы](./media/table-rowgroups.png "Table_RowGroups")  
  
<a name="rendering_precedence"></a>   
### <a name="background-rendering-precedence"></a>Приоритет отрисовки фона  
 Элементы таблицы отрисовываются в следующем порядке (z-порядок от нижнего к верхнему). Этот порядок нельзя изменить. Например, для этих элементов не существует свойства "Z-порядок", которое можно использовать для переопределения этого установленного порядка.  
  
1. <xref:System.Windows.Documents.Table>  
  
2. <xref:System.Windows.Documents.TableColumn>  
  
3. <xref:System.Windows.Documents.TableRowGroup>  
  
4. <xref:System.Windows.Documents.TableRow>  
  
5. <xref:System.Windows.Documents.TableCell>  
  
 Рассмотрим следующий пример, в котором задается цвет фона для каждого из этих элементов в таблице.  
  
 [!code-xaml[TableSnippets2#_Table_ZOrder](~/samples/snippets/csharp/VS_Snippets_Wpf/TableSnippets2/CSharp/Window1.xaml#_table_zorder)]  
  
 На следующем рисунке показана отрисовка этого примера (показаны только фоновые цвета).  
  
 ![Снимок экрана: Таблица z&#45;порядок](./media/table-zorder.png "Table_ZOrder")  
  
<a name="spanning_rows_or_columns"></a>   
### <a name="spanning-rows-or-columns"></a>Объединение строк или столбцов  
 Ячейки таблицы могут быть настроены для охватывать несколько строк или столбцов с помощью <xref:System.Windows.Documents.TableCell.RowSpan%2A> или <xref:System.Windows.Documents.TableCell.ColumnSpan%2A> соответственно.  
  
 Рассмотрим следующий пример, в котором ячейка включает три столбца.  
  
 [!code-xaml[TableSnippets2#_Table_ColumnSpan](~/samples/snippets/csharp/VS_Snippets_Wpf/TableSnippets2/CSharp/Window1.xaml#_table_columnspan)]  
  
 На следующем рисунке показана отрисовка этого примера.  
  
 ![Снимок экрана: Ячейка, охватывающая все три столбца](./media/table-columnspan.png "Table_ColumnSpan")  
  
<a name="building_a_table_with_code"></a>   
## <a name="building-a-table-with-code"></a>Построение таблицы с помощью кода  
 Следующие примеры показывают, как программным способом создать <xref:System.Windows.Documents.Table> и заполнение ее содержимым. Содержимое таблицы распределено по пяти строкам (представленный <xref:System.Windows.Documents.TableRow> объектов, содержащихся в <xref:System.Windows.Documents.Table.RowGroups%2A> объекта) и шести столбцам (представленный <xref:System.Windows.Documents.TableColumn> объектов). Строки используются для различных целей представления, включая строку названия, предназначенную для заголовка всей таблицы, строку заголовка для описания столбцов данных в таблице и строку нижнего колонтитула для сводной информации.  Обратите внимание, что строки "title", "header" и "footer" не встроены в таблицу. Это просто строки с разными характеристиками. Ячейки таблицы содержат фактическое содержимое, которое может состоять из текста, изображений или практически любых других UI  элемент.  
  
 Во-первых, <xref:System.Windows.Documents.FlowDocument> создается узел <xref:System.Windows.Documents.Table>и новый <xref:System.Windows.Documents.Table> создается и добавляется к содержимому <xref:System.Windows.Documents.FlowDocument>.  
  
 [!code-csharp[TableSnippets#_TableCreate](~/samples/snippets/csharp/VS_Snippets_Wpf/TableSnippets/CSharp/Table.cs#_tablecreate)]
   
  
 Далее шесть <xref:System.Windows.Documents.TableColumn> объекты создаются и добавляются в таблицу <xref:System.Windows.Documents.Table.Columns%2A> коллекции с определенным форматированием.  
  
> [!NOTE]
>  Обратите внимание, что таблицы <xref:System.Windows.Documents.Table.Columns%2A> коллекция использует стандартную индексацию с нуля.  
  
 [!code-csharp[TableSnippets#_TableCreateColumns](~/samples/snippets/csharp/VS_Snippets_Wpf/TableSnippets/CSharp/Table.cs#_tablecreatecolumns)]
   
  
 Затем создается строка заголовка и добавляется в таблицу с определенным форматированием.  Строка названия содержит одну ячейку, охватывающую все шесть столбцов таблицы.  
  
 [!code-csharp[TableSnippets#_TableAddTitleRow](~/samples/snippets/csharp/VS_Snippets_Wpf/TableSnippets/CSharp/Table.cs#_tableaddtitlerow)]
   
  
 Далее создается и добавляется в таблицу строка заголовка, а ячейки в строке заголовка создаются и заполняются содержимым.  
  
 [!code-csharp[TableSnippets#_TableAddHeaderRow](~/samples/snippets/csharp/VS_Snippets_Wpf/TableSnippets/CSharp/Table.cs#_tableaddheaderrow)]
   
  
 Затем создается и добавляется в таблицу строка для данных, создаются ячейки в этой строке и заполняются содержимым.  Построение этой строки аналогично построению строки заголовка с применением немного другого форматирования.  
  
 [!code-csharp[TableSnippets#_TableAddDataRow](~/samples/snippets/csharp/VS_Snippets_Wpf/TableSnippets/CSharp/Table.cs#_tableadddatarow)]
   
  
 Наконец, создается, добавляется и форматируется строка нижнего колонтитула.  Как и строка названия, нижний колонтитул содержит одну ячейку, которая включает все шесть столбцов в таблице.  
  
 [!code-csharp[TableSnippets#_TableAddFooterRow](~/samples/snippets/csharp/VS_Snippets_Wpf/TableSnippets/CSharp/Table.cs#_tableaddfooterrow)]
   
  
## <a name="see-also"></a>См. также

- [Общие сведения о документах нефиксированного формата](flow-document-overview.md)
- [Определение таблицы с помощью XAML](how-to-define-a-table-with-xaml.md)
- [Документы в WPF](documents-in-wpf.md)
- [Использование элементов потокового содержимого](how-to-use-flow-content-elements.md)
