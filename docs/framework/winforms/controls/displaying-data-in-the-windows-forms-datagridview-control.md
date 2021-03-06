---
title: Отображение данных с помощью элемента управления DataGridView в Windows Forms
ms.date: 03/30/2017
helpviewer_keywords:
- data [Windows Forms], displaying in tabular format
- data grids [Windows Forms], displaying data
- displaying data [Windows Forms], data grids
- DataGridView control [Windows Forms], displaying data
ms.assetid: b170b52a-2ebd-4948-ac2f-e52d494cebb2
ms.openlocfilehash: c153d422470ff20491567aed70557e461dc2b4e6
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59168640"
---
# <a name="displaying-data-in-the-windows-forms-datagridview-control"></a>Отображение данных с помощью элемента управления DataGridView в Windows Forms
`DataGridView` Управления используется для отображения данных из различных внешних источников данных. Кроме того можно добавить строки и столбцы для элемента управления и вручную заполнить его данными.  
  
 При привязке элемента управления к источнику данных, можно создать столбцы, автоматически на основе схемы источника данных. Если эти столбцы не отображаются так же, как надо, можно скрыть, удалить или изменить их порядок. Можно также добавить несвязанные столбцы для отображения дополнительных данных, поступающих не из источника данных.  
  
 Кроме того можно отображать данные с помощью стандартных форматах (например, формат денежной единицы), или настроить форматирование представления данных, однако необходимо (например, изменение цвета фона для отрицательных чисел или заменить строковые значения отображения с помощью соответствующие образы).  
  
## <a name="in-this-section"></a>В этом разделе  
 [Режимы отображения данных в элементе управления DataGridView в Windows Forms](data-display-modes-in-the-windows-forms-datagridview-control.md)  
 Описание параметров заполнения элемента управления данными.  
  
 [Форматирование данных в элементе управления DataGridView в Windows Forms](data-formatting-in-the-windows-forms-datagridview-control.md)  
 Описывает параметры для форматирования отображения значений ячеек.  
  
 [Пошаговое руководство. Создание не связанного с данными элемента управления DataGridView в Windows Forms](walkthrough-creating-an-unbound-windows-forms-datagridview-control.md)  
 Описывает, как вручную заполнение элемента управления с данными.  
  
 [Практическое руководство. Привязка данных к элементу управления DataGridView в Windows Forms](how-to-bind-data-to-the-windows-forms-datagridview-control.md)  
 Описывает заполнение элемента управления данными, привязав его к `BindingSource` , содержащий сведения, извлеченные из базы данных.  
  
 [Практическое руководство. Автоматическое создание столбцов связанного с данными элемента управления DataGridView в Windows Forms](autogenerate-columns-in-a-data-bound-wf-datagridview-control.md)  
 В этой статье описывается автоматическое создание столбцов, в зависимости от связанного источника данных.  
  
 [Практическое руководство. Удаление автоматически сгенерированных столбцов элемента управления DataGridView в Windows Forms](remove-autogenerated-columns-from-a-wf-datagridview-control.md)  
 Описывает, как скрыть или удалить столбцы, создается автоматически из привязанного источника данных.  
  
 [Практическое руководство. Изменение порядка столбцов элемента управления DataGridView в Windows Forms](how-to-change-the-order-of-columns-in-the-windows-forms-datagridview-control.md)  
 В этой статье описывается изменение порядка столбцов, автоматически создается из связанного источника данных.  
  
 [Практическое руководство. Добавление столбца, не связанного с данными, в связанный с данными элемент управления DataGridView в Windows Forms](unbound-column-to-a-data-bound-datagridview.md)  
 Описывает способ дополнить данные из привязанного источника данных путем отображения дополнительных несвязанных столбцов.  
  
 [Практическое руководство. Связывание объектов с элементами управления DataGridView в Windows Forms](how-to-bind-objects-to-windows-forms-datagridview-controls.md)  
 В этой статье описывается привязка элемента управления в коллекцию произвольных объектов, так что каждый объект отображается в отдельной строке.  
  
 [Практическое руководство. Доступ к связанным объектам в строках DataGridView в Windows Forms](how-to-access-objects-bound-to-windows-forms-datagridview-rows.md)  
 В этой статье описывается извлечение объекта, связанного с определенной строкой элемента управления.  
  
 [Пошаговое руководство. Создание главного и подчиненного представлений данных с использованием двух элементов управления DataGridView в Windows Forms](creating-a-master-detail-form-using-two-datagridviews.md)  
 Описание способа отображения данных из двух связанных таблиц базы данных, чтобы значения, показанные в одном `DataGridView` управления зависят от выбранной строки в другой элемент управления.  
  
 [Практическое руководство. Настройка форматирования данных элемента управления DataGridView в Windows Forms](how-to-customize-data-formatting-in-the-windows-forms-datagridview-control.md)  
 Описание способов обработки <xref:System.Windows.Forms.DataGridView.CellFormatting?displayProperty=nameWithType> событий, чтобы изменить внешний вид ячеек в зависимости от их значения.  
  
## <a name="reference"></a>Ссылка  
 <xref:System.Windows.Forms.DataGridView>  
 Справочная документация по элементу управления <xref:System.Windows.Forms.DataGridView>.  
  
 <xref:System.Windows.Forms.DataGridView.DataSource%2A?displayProperty=nameWithType>  
 Содержит справочную документацию по <xref:System.Windows.Forms.DataGridView.DataSource%2A> свойство.  
  
 <xref:System.Windows.Forms.BindingSource>  
 Содержит справочную документацию по компоненту <xref:System.Windows.Forms.BindingSource>.  
  
## <a name="related-sections"></a>Связанные разделы  
 [Ввод данных с помощью элемента управления DataGridView в Windows Forms](data-entry-in-the-windows-forms-datagridview-control.md)  
 Разделы, в которых описывается изменение способов добавления и изменения данных в элементе управления.  
  
## <a name="see-also"></a>См. также

- [Элемент управления DataGridView](datagridview-control-windows-forms.md)
- [Типы столбцов элемента управления DataGridView в Windows Forms](column-types-in-the-windows-forms-datagridview-control.md)
