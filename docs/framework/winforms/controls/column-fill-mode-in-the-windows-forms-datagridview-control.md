---
title: Установка режимов заполнения для столбцов элемента управления DataGridView в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- data grids [Windows Forms], automatically resizing columns
- DataGridView control [Windows Forms], column fill mode
- data grids [Windows Forms], column fill mode
ms.assetid: b4ef7411-ebf4-4e26-bb33-aecec90de80c
ms.openlocfilehash: a85745d39903719ec1e44ccf70df72d472720b7c
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59214732"
---
# <a name="column-fill-mode-in-the-windows-forms-datagridview-control"></a>Установка режимов заполнения для столбцов элемента управления DataGridView в Windows Forms
В режиме заполнения столбцов элемент управления <xref:System.Windows.Forms.DataGridView> автоматически изменяет размер своих столбцов, чтобы они полностью заполняли доступную область отображения по ширине. Элемент управления не отображает горизонтальную полосу прокрутки, за исключением случаев, когда необходимо сохранить ширину каждого столбца равной или большей, чем значение его свойства <xref:System.Windows.Forms.DataGridViewColumn.MinimumWidth%2A>.  
  
 Поведение каждого столбца при изменении размера зависит от его свойства <xref:System.Windows.Forms.DataGridViewColumn.InheritedAutoSizeMode%2A>. Значение этого свойства наследуется от свойства <xref:System.Windows.Forms.DataGridViewColumn.AutoSizeMode%2A> или свойства элемента управления <xref:System.Windows.Forms.DataGridView.AutoSizeColumnsMode%2A>, если значение столбца равно <xref:System.Windows.Forms.DataGridViewAutoSizeColumnMode.NotSet> (значение по умолчанию).  
  
 Каждый столбец может иметь свой режим определения размера, но все столбцы с режимом определения размера <xref:System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill> будут совместно использовать ту ширину области отображения, которая не занята другими столбцами. Эта ширина распределяется между столбцами с заполнением пропорционально значениям их свойств <xref:System.Windows.Forms.DataGridViewColumn.FillWeight%2A>. Например, если два столбца имеют значения <xref:System.Windows.Forms.DataGridViewColumn.FillWeight%2A>, равные 100 и 200, то первый столбец будет иметь половину от ширины второго столбца.  
  
## <a name="user-resizing-in-fill-mode"></a>Изменение размера пользователем в режиме заполнения  
 В отличие от режимов определения размера на основе содержимого ячейки, режим заполнения запрещает пользователям изменение размеров столбцов, имеющих значения свойства<xref:System.Windows.Forms.DataGridViewColumn.Resizable%2A>, равные `true`. При изменении пользователем размера столбца в режиме заполнения все столбцы с заполнением после столбца с измененным размером (справа от него, если <xref:System.Windows.Forms.Control.RightToLeft%2A> равно `false`, в противном случае — слева) также меняются, чтобы компенсировать изменение на доступную ширину. Если после столбца с измененным размером нет столбцов с заполнением, то размеры всех остальных столбцов с заполнением в элементе управления изменяются для компенсации. Если в элементе управления нет других столбцов с заполнением, то изменение размера игнорируется. Если изменяется размер столбца, который не находится в режиме заполнения, то размеры всех столбцов с заполнением в элементе управления изменяются для компенсации.  
  
 После изменения размера столбца с заполнением значения <xref:System.Windows.Forms.DataGridViewColumn.FillWeight%2A> для всех измененных столбцов будут пропорционально скорректированы. Например, если четыре столбца с заполнением имеют значения <xref:System.Windows.Forms.DataGridViewColumn.FillWeight%2A>, равные 100, то уменьшение ширины второго столбца в два раза приведет к изменению значений <xref:System.Windows.Forms.DataGridViewColumn.FillWeight%2A> в 100, 50, 125 и 125. Изменение размера столбца без заполнения не приведет к изменению значения <xref:System.Windows.Forms.DataGridViewColumn.FillWeight%2A>, поскольку столбцы с заполнением просто компенсируют изменения, чтобы сохранить соотношения.  
  
## <a name="content-based-fillweight-adjustment"></a>Коррекция на основе содержимого FillWeight  
 Для столбцов с заполнением можно инициализировать значения <xref:System.Windows.Forms.DataGridViewColumn.FillWeight%2A>, используя методы автоматического изменения размера <xref:System.Windows.Forms.DataGridView>, такие как метод <xref:System.Windows.Forms.DataGridView.AutoResizeColumns%2A>. Этот метод сначала вычисляет ширину столбцов, необходимую для отображения их содержимого. Затем элемент управления корректирует значения <xref:System.Windows.Forms.DataGridViewColumn.FillWeight%2A> для всех столбцов с заполнением, чтобы их соотношение соответствовало соотношению рассчитанных значений ширины. И наконец, элемент управления изменяет размеры столбцов с заполнением с использованием нового соотношения <xref:System.Windows.Forms.DataGridViewColumn.FillWeight%2A>, таким образом, чтобы все столбцы в элементе управления заполняли доступное пространство по горизонтали.  
  
## <a name="example"></a>Пример  
  
### <a name="description"></a>Описание  
 Поведение размеров столбцов для различных сценариев можно настроить, используя соответствующие значения для свойств <xref:System.Windows.Forms.DataGridViewColumn.AutoSizeMode%2A>, <xref:System.Windows.Forms.DataGridViewColumn.MinimumWidth%2A>, <xref:System.Windows.Forms.DataGridViewColumn.FillWeight%2A> и <xref:System.Windows.Forms.DataGridViewColumn.Resizable%2A>.  
  
 В следующем примере кода можно поэкспериментировать с различными значениями для свойств <xref:System.Windows.Forms.DataGridViewColumn.AutoSizeMode%2A>, <xref:System.Windows.Forms.DataGridViewColumn.FillWeight%2A> и <xref:System.Windows.Forms.DataGridViewColumn.MinimumWidth%2A> различных столбцов. В этом примере элемент управления <xref:System.Windows.Forms.DataGridView> привязан к собственной коллекции <xref:System.Windows.Forms.DataGridView.Columns%2A>, а один столбец связан с каждым из свойств <xref:System.Windows.Forms.DataGridViewColumn.HeaderText%2A>, <xref:System.Windows.Forms.DataGridViewColumn.AutoSizeMode%2A>, <xref:System.Windows.Forms.DataGridViewColumn.FillWeight%2A>, <xref:System.Windows.Forms.DataGridViewColumn.MinimumWidth%2A> и <xref:System.Windows.Forms.DataGridViewColumn.Width%2A>. Каждый из столбцов также представлен строкой в элементе управления, и изменение значений в строке приведет к обновлению свойства соответствующего столбца, чтобы можно было увидеть взаимодействие значений.  
  
### <a name="code"></a>Код  
 [!code-csharp[System.Windows.Forms.DataGridViewFillColumnsDemo#00](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataGridViewFillColumnsDemo/CS/fillcolumns.cs#00)]
 [!code-vb[System.Windows.Forms.DataGridViewFillColumnsDemo#00](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Windows.Forms.DataGridViewFillColumnsDemo/vb/fillcolumns.vb#00)]  
  
### <a name="comments"></a>Комментарии  
 Использование этого демонстрационного приложения.  
  
-   Измените размер формы. Обратите внимание, как изменяется ширина столбцов и одновременно сохраняются пропорции, указанные значениями свойства <xref:System.Windows.Forms.DataGridViewColumn.FillWeight%2A>.  
  
-   Измените размеры столбцов, перетаскивая их разделители с помощью мыши. Обратите внимание, как изменяются значения <xref:System.Windows.Forms.DataGridViewColumn.FillWeight%2A>.  
  
-   Измените значение <xref:System.Windows.Forms.DataGridViewColumn.MinimumWidth%2A> для одного столбца, а затем перетащите для изменения размеров формы. Обратите внимание, что при достаточном уменьшении размера формы, значения <xref:System.Windows.Forms.DataGridViewColumn.Width%2A> не становятся меньше значений <xref:System.Windows.Forms.DataGridViewColumn.MinimumWidth%2A>.  
  
-   Измените значения <xref:System.Windows.Forms.DataGridViewColumn.MinimumWidth%2A> для всех столбцов на большие числа, чтобы суммарное значение было больше ширины элемента управления. Обратите внимание, как появляется горизонтальная полоса прокрутки.  
  
-   Измените значения <xref:System.Windows.Forms.DataGridViewColumn.AutoSizeMode%2A> для некоторых столбцов. Наблюдайте результат при изменении размера столбцов или формы.  
  
## <a name="compiling-the-code"></a>Компиляция кода  
 Для этого примера требуются:  
  
-   ссылки на сборки System, System.Drawing и System.Windows.Forms.  
  
-   Сведения о выполнении сборки этого примера из командной строки для Visual Basic или Visual C#, см. в разделе [построение из командной строки](../../../visual-basic/reference/command-line-compiler/building-from-the-command-line.md) или [командной строки создания с помощью csc.exe](../../../csharp/language-reference/compiler-options/command-line-building-with-csc-exe.md). Можно также сборке этого примера в Visual Studio путем вставки кода в новый проект.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.DataGridView>
- <xref:System.Windows.Forms.DataGridView.AutoResizeColumns%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.DataGridView.AutoSizeColumnsMode%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.DataGridViewAutoSizeColumnsMode>
- <xref:System.Windows.Forms.DataGridViewColumn>
- <xref:System.Windows.Forms.DataGridViewColumn.InheritedAutoSizeMode%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.DataGridViewColumn.AutoSizeMode%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.DataGridViewAutoSizeColumnMode>
- <xref:System.Windows.Forms.DataGridViewColumn.FillWeight%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.DataGridViewColumn.MinimumWidth%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.DataGridViewColumn.Width%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.DataGridViewColumn.Resizable%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.Control.RightToLeft%2A?displayProperty=nameWithType>
- [Изменение размера столбцов и строк элемента управления DataGridView в Windows Forms](resizing-columns-and-rows-in-the-windows-forms-datagridview-control.md)
