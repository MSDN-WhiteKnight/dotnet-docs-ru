---
title: Типы столбцов элемента управления DataGridView в Windows Forms
ms.date: 03/30/2017
helpviewer_keywords:
- columns [Windows Forms], types
- DataGridView control [Windows Forms], column types
- data grids [Windows Forms], columns
ms.assetid: f0a0a9f1-8757-4bfd-891f-d7d12870dbed
ms.openlocfilehash: a33cf4cd865921c04ef10c7fccf3a67c3d22de73
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59115678"
---
# <a name="column-types-in-the-windows-forms-datagridview-control"></a>Типы столбцов элемента управления DataGridView в Windows Forms
<xref:System.Windows.Forms.DataGridView> Элемент управления использует несколько типов столбцов для отображения данных и позволяют пользователям изменять или добавлять данные.  
  
 При привязке <xref:System.Windows.Forms.DataGridView> и задание <xref:System.Windows.Forms.DataGridView.AutoGenerateColumns%2A> свойства `true`, столбцы создаются автоматически с помощью типов столбцов по умолчанию для типов данных, содержащихся в привязанного источника данных.  
  
 Можно также создать экземпляры любых классов столбцов самостоятельно и добавить их в коллекцию, возвращаемую <xref:System.Windows.Forms.DataGridView.Columns%2A> свойство. Можно создать эти экземпляры для использования в качестве непривязанные столбцы, или вручную привязывать их. Вручную привязанные столбцы полезны, например, если вы хотите заменить автоматически созданного столбца одного типа со столбцом типа.  
  
 В следующей таблице описаны различные классы столбцов, доступных для использования в <xref:System.Windows.Forms.DataGridView> элемента управления.  
  
|Класс|Описание|  
|-----------|-----------------|  
|<xref:System.Windows.Forms.DataGridViewTextBoxColumn>|Используется с текстовыми значениями. Создается автоматически при привязке к чисел и строк.|  
|<xref:System.Windows.Forms.DataGridViewCheckBoxColumn>|Используется с <xref:System.Boolean> и <xref:System.Windows.Forms.CheckState> значения. Создается автоматически, при привязке к значениям из этих типов.|  
|<xref:System.Windows.Forms.DataGridViewImageColumn>|Используется для отображения изображения. Создается автоматически при привязке в массив байтов, <xref:System.Drawing.Image> объектов, или <xref:System.Drawing.Icon> объектов.|  
|<xref:System.Windows.Forms.DataGridViewButtonColumn>|Используется для отображения кнопок в ячейках. Создается автоматически при привязке. Обычно используется в качестве несвязанных столбцов.|  
|<xref:System.Windows.Forms.DataGridViewComboBoxColumn>|Используется для отображения раскрывающихся списков в ячейках. Создается автоматически при привязке. Обычно связан с данными вручную.|  
|<xref:System.Windows.Forms.DataGridViewLinkColumn>|Используется для отображения ссылки в ячейках. Создается автоматически при привязке. Обычно связан с данными вручную.|  
|Пользовательский тип столбцов|Можно создать свой собственный класс столбца путем наследования <xref:System.Windows.Forms.DataGridViewColumn> класса или любого из его производных классов, чтобы предоставить пользовательское оформление, поведение или размещенные элементы управления. Дополнительные сведения см. в разделе [Как Настройка ячеек и столбцов в элементе управления DataGridView Windows Forms, расширяя их поведение и внешний вид](customize-cells-and-columns-in-the-datagrid-by-extending-behavior.md)|  
  
 Типы столбцов описаны более подробно в следующих разделах.  
  
## <a name="datagridviewtextboxcolumn"></a>DataGridViewTextBoxColumn  
 <xref:System.Windows.Forms.DataGridViewTextBoxColumn> Является типом столбца общего назначения для использования с текстовыми значениями, например чисел и строк. В режиме редактирования <xref:System.Windows.Forms.TextBox> отображается элемент управления в ячейки, дающий пользователю возможность изменять значение ячейки.  
  
 Значения ячеек, автоматически преобразуются в строки для отображения. Для создания ячейки значение соответствующего типа данных автоматически синтаксический анализ значения вводятся или изменены пользователем. Эти преобразования можно настроить путем обработки <xref:System.Windows.Forms.DataGridView.CellFormatting> и <xref:System.Windows.Forms.DataGridView.CellParsing> события <xref:System.Windows.Forms.DataGridView> элемента управления.  
  
 Тип данных значения ячейки столбца задается в <xref:System.Windows.Forms.DataGridViewColumn.ValueType%2A> свойства столбца.  
  
## <a name="datagridviewcheckboxcolumn"></a>DataGridViewCheckBoxColumn  
 <xref:System.Windows.Forms.DataGridViewCheckBoxColumn> Используется с <xref:System.Boolean> и <xref:System.Windows.Forms.CheckState> значения. <xref:System.Boolean> значения отображаются в виде двумя или тремя состояниями флажков, в зависимости от значения <xref:System.Windows.Forms.DataGridViewCheckBoxColumn.ThreeState%2A> свойство. Когда столбец связан с <xref:System.Windows.Forms.CheckState> значения, <xref:System.Windows.Forms.DataGridViewCheckBoxColumn.ThreeState%2A> свойство имеет значение `true` по умолчанию.  
  
 Как правило значения ячеек "флажок" предназначены для хранения данных, как любые другие данные, либо для выполнения массовых операций. Если вы хотите немедленно при щелчке ячейки с флажком, можно обрабатывать реагировать на <xref:System.Windows.Forms.DataGridView.CellClick> событие, но это событие происходит до обновления значения ячейки. Если необходимо новое значение во время щелчка, один из вариантов — можно вычислить ожидаемое значение, на основе текущего значения. Другой подход заключается в том, чтобы немедленно зафиксируйте изменения и обработки информации о <xref:System.Windows.Forms.DataGridView.CellValueChanged> событий отвечать на него. Чтобы применить изменения при щелчке ячейки, должно обрабатывать <xref:System.Windows.Forms.DataGridView.CurrentCellDirtyStateChanged> событий. В обработчике, если текущая ячейка является ячейкой флажок, вызовите <xref:System.Windows.Forms.DataGridView.CommitEdit%2A> метод и передать <xref:System.Windows.Forms.DataGridViewDataErrorContexts.Commit> значение.  
  
## <a name="datagridviewimagecolumn"></a>DataGridViewImageColumn  
 <xref:System.Windows.Forms.DataGridViewImageColumn> Используется для отображения изображения. Столбцы изображений можно автоматически заполняется из источника данных, заполняется вручную для несвязанных столбцов или динамически заполнить в обработчике для <xref:System.Windows.Forms.DataGridView.CellFormatting> событий.  
  
 Автоматическое заполнение столбцов изображений из источника данных работает с массивами байтов в различных форматов изображений, включая любые форматы, поддерживаемые <xref:System.Drawing.Image> класс и OLE графический формат, используемый в Microsoft® Access и образец базы данных "Борей".  
  
 Заполнение столбцов изображений вручную полезно, если вы хотите предоставить функциональность <xref:System.Windows.Forms.DataGridViewButtonColumn>, но с настроенными внешним видом. Можно обрабатывать <xref:System.Windows.Forms.DataGridView.CellClick?displayProperty=nameWithType> событий для реагирования на нажатия в пределах ячейки с изображением.  
  
 Заполнение ячеек столбца изображений с помощью обработчика <xref:System.Windows.Forms.DataGridView.CellFormatting> событие полезно, если вы хотите предоставлять образы для вычисляемых значений или значений в не являющихся изображениями. Например, имеется столбец «Риск» со строковыми значениями например `"high"`, `"middle"`, и `"low"` , будет отображаться в виде значков. Кроме того имеется столбец «Образ», содержащий расположения образов, которые должны загружаться вместо того чтобы двоичного содержимого изображений.  
  
## <a name="datagridviewbuttoncolumn"></a>DataGridViewButtonColumn  
 С помощью <xref:System.Windows.Forms.DataGridViewButtonColumn>, можно отобразить столбец ячеек, содержащих кнопки. Это полезно в том случае, если вы хотите предоставить простой способ для пользователей для выполнения действий над записями, таких как размещение заказа и отображение дочерних записей в отдельном окне.  
  
 Кнопка столбцы не создаются автоматически при связывании <xref:System.Windows.Forms.DataGridView> элемента управления. Использование столбцов, необходимо создать их вручную и добавить их в коллекцию, возвращаемую <xref:System.Windows.Forms.DataGridView.Columns%2A?displayProperty=nameWithType> свойство.  
  
 Может отвечать на щелчок пользователя в ячейках кнопки путем обработки <xref:System.Windows.Forms.DataGridView.CellClick?displayProperty=nameWithType> событий.  
  
## <a name="datagridviewcomboboxcolumn"></a>DataGridViewComboBoxColumn  
 С помощью <xref:System.Windows.Forms.DataGridViewComboBoxColumn>, можно отобразить столбец ячеек, содержащих поля с раскрывающимся списком. Это полезно для ввода данных в полях, которые может содержать только определенные значения, такие как столбец категории таблицы продуктов в базе данных Northwind.  
  
 Можно заполнить стрелку раскрывающегося списка, используемого для всех ячеек так же, заполнению <xref:System.Windows.Forms.ComboBox> стрелку раскрывающегося списка, либо вручную с помощью коллекции, возвращаемой <xref:System.Windows.Forms.DataGridViewComboBoxColumn.Items%2A> свойство, или через привязку к источнику данных с помощью <xref:System.Windows.Forms.DataGridViewComboBoxColumn.DataSource%2A>, <xref:System.Windows.Forms.DataGridViewComboBoxColumn.DisplayMember%2A>, и <xref:System.Windows.Forms.DataGridViewComboBoxColumn.ValueMember%2A> свойства. Дополнительные сведения см. в разделе [элемент управления ComboBox](combobox-control-windows-forms.md).  
  
 Фактические значения ячеек можно привязать к источнику данных, который используется командой <xref:System.Windows.Forms.DataGridView> управления <xref:System.Windows.Forms.DataGridViewColumn.DataPropertyName%2A> свойство <xref:System.Windows.Forms.DataGridViewComboBoxColumn?displayProperty=nameWithType>.  
  
 Столбцы поле со списком не создаются автоматически при связывании <xref:System.Windows.Forms.DataGridView> элемента управления. Использование столбцов поле со списком, необходимо создать их вручную и добавить их в коллекцию, возвращаемую <xref:System.Windows.Forms.DataGridView.Columns%2A> свойство.  
  
## <a name="datagridviewlinkcolumn"></a>DataGridViewLinkColumn  
 С помощью <xref:System.Windows.Forms.DataGridViewLinkColumn>, можно отобразить столбец ячеек, содержащих гиперссылки. Это полезно для значений URL-адрес в источнике данных или в качестве альтернативы, чтобы столбец кнопок для особого поведения, например открытия окна с дочерними записями.  
  
 Столбцы ссылок не создаются автоматически при связывании <xref:System.Windows.Forms.DataGridView> элемента управления. Использование столбцов ссылок, необходимо создать их вручную и добавить их в коллекцию, возвращаемую <xref:System.Windows.Forms.DataGridView.Columns%2A> свойство.  
  
 Может отвечать на щелчок мышью по ссылке путем обработки <xref:System.Windows.Forms.DataGridView.CellContentClick> событий. Это событие отличается от <xref:System.Windows.Forms.DataGridView.CellClick> и <xref:System.Windows.Forms.DataGridView.CellMouseClick> события, которые происходят, когда пользователь щелкает в любом месте ячейки.  
  
 <xref:System.Windows.Forms.DataGridViewLinkColumn> Класс предоставляет несколько свойств для изменения внешнего вида ссылок до, во время и после их щелкнули.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.DataGridView>
- <xref:System.Windows.Forms.DataGridViewColumn>
- <xref:System.Windows.Forms.DataGridViewButtonColumn>
- <xref:System.Windows.Forms.DataGridViewCheckBoxColumn>
- <xref:System.Windows.Forms.DataGridViewComboBoxColumn>
- <xref:System.Windows.Forms.DataGridViewImageColumn>
- <xref:System.Windows.Forms.DataGridViewTextBoxColumn>
- <xref:System.Windows.Forms.DataGridViewLinkColumn>
- [Элемент управления DataGridView](datagridview-control-windows-forms.md)
- [Практическое руководство. Вывод изображений в ячейках элемента управления DataGridView в Windows Forms](how-to-display-images-in-cells-of-the-windows-forms-datagridview-control.md)
- [Практическое руководство. Работа со столбцами изображений в элементе управления DataGridView в Windows Forms](how-to-work-with-image-columns-in-the-windows-forms-datagridview-control.md)
- [Настройка элементов управления DataGridView в Windows Forms](customizing-the-windows-forms-datagridview-control.md)
