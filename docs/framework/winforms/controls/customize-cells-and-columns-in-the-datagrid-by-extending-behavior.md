---
title: Практическое руководство. Дополнительные возможности управления внешним видом и поведением ячеек и столбцов элемента управления DataGridView в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- DataGridView control [Windows Forms], cell customization
- columns [Windows Forms], customizing in DataGridView control
- cells [Windows Forms], customizing in DataGridView control
ms.assetid: 9b7dc7b6-5ce6-4566-9949-902f74f17a81
ms.openlocfilehash: 6b0773b4c41b77fe43a5b7fba994778ae18c16c1
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59325011"
---
# <a name="how-to-customize-cells-and-columns-in-the-windows-forms-datagridview-control-by-extending-their-behavior-and-appearance"></a>Практическое руководство. Дополнительные возможности управления внешним видом и поведением ячеек и столбцов элемента управления DataGridView в Windows Forms
Внешний вид и поведение элемента управления <xref:System.Windows.Forms.DataGridView> можно настроить несколькими способами с помощью свойств, событий и классов-компаньонов. В ряде случаев к ячейкам могут предъявляться требования, когда этих возможностей будет недостаточно. Вы можете создать пользовательский класс <xref:System.Windows.Forms.DataGridViewCell> для расширения функциональных возможностей.  
  
 Пользовательский класс <xref:System.Windows.Forms.DataGridViewCell> создается как производный от базового класса <xref:System.Windows.Forms.DataGridViewCell> или одного из его производных классов. Хотя любой тип ячейки можно отобразить в любом типе столбца, как правило, потребуется также создать пользовательский класс <xref:System.Windows.Forms.DataGridViewColumn>, специально предназначенный для отображения пользовательского типа ячейки. Классы столбцов являются производными от <xref:System.Windows.Forms.DataGridViewColumn> или от одного из его производных типов.  
  
 В примере кода ниже создается пользовательский класс ячейки с именем `DataGridViewRolloverCell`, который обнаруживает, когда указатель мыши пересекает границы ячейки. Когда указатель мыши находится внутри границ ячейки, рисуется внутренняя рамка. Этот новый тип является производным от <xref:System.Windows.Forms.DataGridViewTextBoxCell> и во всем остальном ведет себя так же, как и базовый класс. Класс-компаньон столбца имеет имя `DataGridViewRolloverColumn`.  
  
 Для использования этих классов необходимо создать форму, содержащую элемент управления <xref:System.Windows.Forms.DataGridView>, добавить один или несколько объектов `DataGridViewRolloverColumn` в коллекцию <xref:System.Windows.Forms.DataGridView.Columns%2A> и заполнить элемент управления строками со значениями.  
  
> [!NOTE]
>  Пример не будет работать правильно с пустыми строками. Пустые строки создаются, например, при добавлении строк в элемент управления путем задания свойства <xref:System.Windows.Forms.DataGridView.RowCount%2A>. Это происходит потому, что добавленные в этом случае строки автоматически становятся общими. Это означает, что экземпляры объектов `DataGridViewRolloverCell` не будут создаваться до тех пор, пока не будут нажаты отдельные ячейки, что отменяет блокирование связанных общих строк.  
  
 Так как подобная настройка ячеек требует, чтобы строки не были общими, она не подходит для использования с большими наборами данных. Дополнительные сведения о совместном использовании строк см. в разделе [масштабирование элемента управления DataGridView в Windows Forms](best-practices-for-scaling-the-windows-forms-datagridview-control.md).  
  
> [!NOTE]
>  При наследовании от класса <xref:System.Windows.Forms.DataGridViewCell> или <xref:System.Windows.Forms.DataGridViewColumn> и добавлении новых свойств к производному классу необходимо переопределить метод `Clone`, чтобы скопировать новые свойства во время операций копирования. Кроме того, необходимо вызвать метод `Clone` базового класса, чтобы свойства базового класса скопировались в новую ячейку или столбец.  
  
### <a name="to-customize-cells-and-columns-in-the-datagridview-control"></a>Настройка ячеек и столбцов в элементе управления DataGridView  
  
1. Создайте класс ячейки с именем `DataGridViewRolloverCell`, производный от типа <xref:System.Windows.Forms.DataGridViewTextBoxCell>.  
  
     [!code-csharp[System.Windows.Forms.DataGridViewRolloverCell#201](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataGridViewRolloverCell/CS/rollovercell.cs#201)]
     [!code-vb[System.Windows.Forms.DataGridViewRolloverCell#201](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Windows.Forms.DataGridViewRolloverCell/VB/rollovercell.vb#201)]  
    [!code-csharp[System.Windows.Forms.DataGridViewRolloverCell#202](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataGridViewRolloverCell/CS/rollovercell.cs#202)]
    [!code-vb[System.Windows.Forms.DataGridViewRolloverCell#202](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Windows.Forms.DataGridViewRolloverCell/VB/rollovercell.vb#202)]  
  
2. Переопределите метод <xref:System.Windows.Forms.DataGridViewTextBoxCell.Paint%2A> в классе `DataGridViewRolloverCell` . При переопределении сначала вызовите реализацию базового класса, которая отвечает за функциональные возможности размещенного текстового поля. Затем с помощью метода <xref:System.Windows.Forms.Control.PointToClient%2A> элемента управления преобразуйте положение курсора (в экранных координатах) в координаты клиентской области <xref:System.Windows.Forms.DataGridView>. Если координаты курсора попадают в границы ячейки, то рисуется внутренняя рамка.  
  
     [!code-csharp[System.Windows.Forms.DataGridViewRolloverCell#210](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataGridViewRolloverCell/CS/rollovercell.cs#210)]
     [!code-vb[System.Windows.Forms.DataGridViewRolloverCell#210](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Windows.Forms.DataGridViewRolloverCell/VB/rollovercell.vb#210)]  
  
3. Переопределите методы <xref:System.Windows.Forms.DataGridViewCell.OnMouseEnter%2A> и <xref:System.Windows.Forms.DataGridViewCell.OnMouseLeave%2A> класса `DataGridViewRolloverCell`, чтобы ячейки отрисовывались повторно, когда указатель мыши пересекает их границы.  
  
     [!code-csharp[System.Windows.Forms.DataGridViewRolloverCell#220](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataGridViewRolloverCell/CS/rollovercell.cs#220)]
     [!code-vb[System.Windows.Forms.DataGridViewRolloverCell#220](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Windows.Forms.DataGridViewRolloverCell/VB/rollovercell.vb#220)]  
  
4. Создайте класс с именем `DataGridViewRolloverCellColumn`, производный от типа <xref:System.Windows.Forms.DataGridViewColumn>. В конструкторе назначьте новый объект `DataGridViewRolloverCell` его свойству <xref:System.Windows.Forms.DataGridViewColumn.CellTemplate%2A>.  
  
     [!code-csharp[System.Windows.Forms.DataGridViewRolloverCell#300](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataGridViewRolloverCell/CS/rollovercell.cs#300)]
     [!code-vb[System.Windows.Forms.DataGridViewRolloverCell#300](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Windows.Forms.DataGridViewRolloverCell/VB/rollovercell.vb#300)]  
  
## <a name="example"></a>Пример  
 Полный пример кода включает небольшую тестовую форму, демонстрирующую поведение ячейки пользовательского типа.  
  
 [!code-csharp[System.Windows.Forms.DataGridViewRolloverCell#000](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataGridViewRolloverCell/CS/rollovercell.cs#000)]
 [!code-vb[System.Windows.Forms.DataGridViewRolloverCell#000](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Windows.Forms.DataGridViewRolloverCell/VB/rollovercell.vb#000)]  
  
## <a name="compiling-the-code"></a>Компиляция кода  
 Для этого примера требуются:  
  
-   ссылки на сборки System, System.Windows.Forms и System.Drawing.  
  
 Сведения о выполнении сборки этого примера из командной строки для Visual Basic или Visual C#, см. в разделе [построение из командной строки](../../../visual-basic/reference/command-line-compiler/building-from-the-command-line.md) или [командной строки создания с помощью csc.exe](../../../csharp/language-reference/compiler-options/command-line-building-with-csc-exe.md). Можно также сборке этого примера в Visual Studio путем вставки кода в новый проект.
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.DataGridView>
- <xref:System.Windows.Forms.DataGridViewCell>
- <xref:System.Windows.Forms.DataGridViewColumn>
- [Настройка элементов управления DataGridView в Windows Forms](customizing-the-windows-forms-datagridview-control.md)
- [Архитектура элементов управления DataGridView](datagridview-control-architecture-windows-forms.md)
- [Типы столбцов элемента управления DataGridView в Windows Forms](column-types-in-the-windows-forms-datagridview-control.md)
- [Масштабирование элемента управления DataGridView в Windows Forms](best-practices-for-scaling-the-windows-forms-datagridview-control.md)
