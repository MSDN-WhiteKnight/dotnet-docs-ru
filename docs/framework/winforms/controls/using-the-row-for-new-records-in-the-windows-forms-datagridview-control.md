---
title: Использование строки элемента управления DataGridView, предназначенной для ввода новых данных, в Windows Forms
ms.date: 03/30/2017
helpviewer_keywords:
- DataGridView control [Windows Forms], adding rows for new records
- rows [Windows Forms], new records
- DataGridView control [Windows Forms], data entry
ms.assetid: 6110f1ea-9794-442c-a98a-f104a1feeaf4
ms.openlocfilehash: 67c87b28f04b028f329663d6cf8215370a00ef2f
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59184825"
---
# <a name="using-the-row-for-new-records-in-the-windows-forms-datagridview-control"></a>Использование строки элемента управления DataGridView, предназначенной для ввода новых данных, в Windows Forms
При использовании <xref:System.Windows.Forms.DataGridView> для редактирования данных в приложении, часто требуется предоставить пользователям возможность добавлять новые строки данных в хранилище данных. <xref:System.Windows.Forms.DataGridView> Элемент управления поддерживает данную функцию, предоставляя строку для новых записей, которая всегда находится в последней строке. Оно помечено символ звездочки (*) в заголовке строки. В следующих разделах рассматриваются некоторые аспекты, следует учитывать при включении программы со строкой для новых записей.  
  
## <a name="displaying-the-row-for-new-records"></a>Отображение строки для новых записей  
 Используйте <xref:System.Windows.Forms.DataGridView.AllowUserToAddRows%2A> свойство, указывающее, отображается ли строка для новых записей. По умолчанию этому свойству присваивается значение `true`.  
  
 Отображается вариант связывания данных, строки для новых записей Если <xref:System.Windows.Forms.DataGridView.AllowUserToAddRows%2A> свойство элемента управления и <xref:System.ComponentModel.IBindingList.AllowNew%2A?displayProperty=nameWithType> свойство источника данных являются `true`. Если выполняется любое `false` то строки не будут показаны.  
  
## <a name="populating-the-row-for-new-records-with-default-data"></a>Заполнение строки для новых записей с данными по умолчанию  
 Когда пользователь выбирает строку для новых записей как текущую строку, <xref:System.Windows.Forms.DataGridView> управления вызывает <xref:System.Windows.Forms.DataGridView.DefaultValuesNeeded> событий.  
  
 Это событие предоставляет доступ к новому <xref:System.Windows.Forms.DataGridViewRow> и позволяет заполнить новую строку с данными по умолчанию. Дополнительные сведения см. в разделе [Как Определение значения по умолчанию для новых строк в элементе управления DataGridView Windows Forms](specify-default-values-for-new-rows-in-the-datagrid.md)  
  
## <a name="the-rows-collection"></a>Набор строк  
 Содержится в строке для новых записей <xref:System.Windows.Forms.DataGridView> элемента управления <xref:System.Windows.Forms.DataGridView.Rows%2A> коллекции но ведет себя по-разному в двух аспектах:  
  
-   Невозможно удалить строки для новых записей из <xref:System.Windows.Forms.DataGridView.Rows%2A> коллекции программным способом. <xref:System.InvalidOperationException> Возникает исключение при попытке такой. Пользователь не может удалять строки для новых записей. <xref:System.Windows.Forms.DataGridViewRowCollection.Clear%2A?displayProperty=nameWithType> Метод не удаляет эту строку из <xref:System.Windows.Forms.DataGridView.Rows%2A> коллекции.  
  
-   Строка не могут добавляться после строки для новых записей. <xref:System.InvalidOperationException> Возникает при попытке такой. Таким образом, строка для новых записей всегда является последней строкой в <xref:System.Windows.Forms.DataGridView> элемента управления. Методы в <xref:System.Windows.Forms.DataGridViewRowCollection> , которые добавляют строки —<xref:System.Windows.Forms.DataGridViewRowCollection.Add%2A>, <xref:System.Windows.Forms.DataGridViewRowCollection.AddCopy%2A>, и <xref:System.Windows.Forms.DataGridViewRowCollection.AddCopies%2A>— все вызывать методы вставки внутренне при наличии строки для новых записей.  
  
## <a name="visual-customization-of-the-row-for-new-records"></a>Настройка внешнего вида строки для новых записей  
 При создании строки для новых записей, он основан на строки, указанной в <xref:System.Windows.Forms.DataGridView.RowTemplate%2A> свойство. Стили ячеек, которые не указаны для этой строки, наследуются от других свойств. Дополнительные сведения о наследовании стилей ячеек, см. в разделе [стили ячеек элемента управления DataGridView Windows Forms в](cell-styles-in-the-windows-forms-datagridview-control.md).  
  
 Начальные значения для загрузки новых записей из каждой ячейки, ячейки в строке отображается <xref:System.Windows.Forms.DataGridViewCell.DefaultNewRowValue%2A> свойство. Для типа <xref:System.Windows.Forms.DataGridViewImageCell>, это свойство возвращает изображение-заполнитель. В противном случае это свойство возвращает `null`. Можно переопределить это свойство для возврата пользовательское значение. Тем не менее, можно заменить исходные значения <xref:System.Windows.Forms.DataGridView.DefaultValuesNeeded> обработчик событий, когда фокус вводит строку для новых записей.  
  
 Стандартные значки для этой строки заголовка, которые являются стрелки, или звездочку, не общедоступным. Если вы хотите настроить значки, необходимо создать пользовательский <xref:System.Windows.Forms.DataGridViewRowHeaderCell> класса.  
  
 Используйте стандартные значки <xref:System.Windows.Forms.DataGridViewCellStyle.ForeColor%2A> свойство <xref:System.Windows.Forms.DataGridViewCellStyle> используется ячейку заголовка строки. Стандартные значки не отображаются, если не хватает места, чтобы отобразить их полностью.  
  
 Ячейки заголовка строки задано строковое значение, если не хватает места, значок и текст, значок сначала удаляется.  
  
## <a name="sorting"></a>Сортировка  
 В несвязанном режиме новые записи всегда добавляются в конец <xref:System.Windows.Forms.DataGridView> даже если пользователь отсортировал содержание <xref:System.Windows.Forms.DataGridView>. Пользователю будет необходимо повторно применить сортировку для сортировки строк в нужное положение; Это поведение похоже, <xref:System.Windows.Forms.ListView> элемента управления.  
  
 В данных связанном и виртуальном режимах результат вставки при применении сортировки будет зависеть от реализации модели данных. Для [!INCLUDE[vstecado](../../../../includes/vstecado-md.md)], строки немедленно упорядочить в правильном положении.  
  
## <a name="other-notes-on-the-row-for-new-records"></a>Другие примечания к строке для новых записей  
 Невозможно задать <xref:System.Windows.Forms.DataGridViewRow.Visible%2A> свойства этой строки для `false`. <xref:System.InvalidOperationException> Возникает при попытке такой.  
  
 Строки для новых записей всегда создается в невыбранном состоянии.  
  
## <a name="virtual-mode"></a>Виртуальный режим  
 Если вы реализуете виртуальный режим, необходимо отслеживать, когда требуется строку для новых записей в модели данных, а также когда откатывать добавления строки. Конкретная реализация этих функций зависит от реализации модели данных и соответствующей семантики транзакций, например, является ли область фиксации на уровне ячейки или строки. Дополнительные сведения см. в разделе [виртуальный режим в элементе управления DataGridView Windows Forms](virtual-mode-in-the-windows-forms-datagridview-control.md).  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.DataGridView>
- <xref:System.Windows.Forms.DataGridView.DefaultValuesNeeded?displayProperty=nameWithType>
- [Ввод данных с помощью элемента управления DataGridView в Windows Forms](data-entry-in-the-windows-forms-datagridview-control.md)
- [Практическое руководство. Определение значений по умолчанию для новых строк элемента управления DataGridView в Windows Forms](specify-default-values-for-new-rows-in-the-datagrid.md)
