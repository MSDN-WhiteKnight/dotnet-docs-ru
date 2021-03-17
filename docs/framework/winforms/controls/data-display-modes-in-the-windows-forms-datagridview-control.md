---
title: Режимы отображения данных в элементе управления DataGridView в Windows Forms
ms.date: 03/30/2017
helpviewer_keywords:
- data [Windows Forms], display modes
- data grids [Windows Forms], display modes
- DataGridView control [Windows Forms], display modes
ms.assetid: 9755a030-3f3f-4705-a661-ba5a48a81875
ms.openlocfilehash: 673780909f6d66168548893e99d79bbfec70a0e0
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59079699"
---
# <a name="data-display-modes-in-the-windows-forms-datagridview-control"></a>Режимы отображения данных в элементе управления DataGridView в Windows Forms
<xref:System.Windows.Forms.DataGridView> Элемент управления может отображать данные в трех различных режимах: привязанного, не связанного с данными и виртуальных. Выберите наиболее подходящий режим, в зависимости от ваших требований.  
  
## <a name="unbound"></a>Свободные  
 Несвязанный режим подходит для отображения относительно небольшим объемам данных, управляемых программным способом. Не присоединять <xref:System.Windows.Forms.DataGridView> управления непосредственно к источнику данных, как и в режиме привязки. Вместо этого вы должны самостоятельно заполнить элемент управления, обычно с помощью <xref:System.Windows.Forms.DataGridViewRowCollection.Add%2A?displayProperty=nameWithType> метод.  
  
 Несвязанный режим может быть особенно полезно для статических, только для чтения данных, или если вы хотите предоставить собственный код, который взаимодействует с во внешнем хранилище данных. Если требуется, чтобы пользователи могли взаимодействовать с внешним источником данных, тем не менее, обычно используется связанный режим.  
  
 Пример, в котором используется только для чтения несвязанных <xref:System.Windows.Forms.DataGridView>, см. в разделе [как: Создание элемента управления DataGridView в Windows свободной формы](how-to-create-an-unbound-windows-forms-datagridview-control.md).  
  
## <a name="bound"></a>привязан  
 Связанный режим подходит для управления данными, с помощью автоматического взаимодействия с хранилищем данных. Вы можете подключить <xref:System.Windows.Forms.DataGridView> управления непосредственно к источнику данных, задав <xref:System.Windows.Forms.DataGridView.DataSource%2A> свойство. Если элемент управления с привязкой к данным, строки данных отправкой и получением без необходимости явного управления со стороны пользователя. Когда <xref:System.Windows.Forms.DataGridView.AutoGenerateColumns%2A> свойство `true`, каждый столбец в источнике данных вызовет соответствующий столбец должен быть создан в элементе управления. Если вы хотите создать собственные столбцы, это свойство можно задать `false` и использовать <xref:System.Windows.Forms.DataGridViewColumn.DataPropertyName%2A> свойство для привязки каждого столбца при его настройке. Это полезно в том случае, если вы хотите использовать тип столбца, отличного от типов, которые создаются по умолчанию. Дополнительные сведения см. в разделе [типы столбцов элемента управления DataGridView в Windows Forms](column-types-in-the-windows-forms-datagridview-control.md).  
  
 Пример с использованием связанного <xref:System.Windows.Forms.DataGridView> управления, см. в разделе [Пошаговое руководство: Проверка данных в Windows Forms элемента управления DataGridView](walkthrough-validating-data-in-the-windows-forms-datagridview-control.md).  
  
 Можно также добавить несвязанные столбцы для <xref:System.Windows.Forms.DataGridView> элемента управления в режиме привязки. Это полезно в том случае, если вы хотите отобразить столбец кнопки или ссылки, позволяющие пользователям выполнять действия с определенными строками. Это также полезно для отображения столбцов со значениями, вычисленный на основе связанных столбцов. Можно заполнить значения ячейки для вычисляемых столбцов в обработчике <xref:System.Windows.Forms.DataGridView.CellFormatting> событий. Если вы используете <xref:System.Data.DataSet> или <xref:System.Data.DataTable> как источник данных, тем не менее, может потребоваться использовать <xref:System.Data.DataColumn.Expression%2A?displayProperty=nameWithType> свойство, чтобы вместо этого создать вычисляемый столбец. В этом случае <xref:System.Windows.Forms.DataGridView> управления будет рассматривать вычисляемый столбец так же, как и любой другой столбец в источнике данных.  
  
 Сортировка по несвязанных столбцов в связанном режиме не поддерживается. Если создание непривязанного столбца в режиме привязки, содержащий изменяемые пользователем значения, необходимо реализовать виртуального режима для сохранения этих значений, когда элемент управления отсортирован по связанному столбцу.  
  
## <a name="virtual"></a>виртуальный  
 Виртуальный режим можно реализовать собственные операции управления данными. Это необходимо для сохранения значений несвязанных столбцов в связанном режиме, когда элемент управления сортируется по привязанные столбцы. Основной виртуальный режим, тем не менее, используется для оптимизации производительности при взаимодействии с большими объемами данных.  
  
 Присоединении <xref:System.Windows.Forms.DataGridView> управления кэша, которыми вы управляете и код управляет отправкой и получением строк данных. Чтобы сохранить небольшой объем памяти, кэша должен быть размер аналогичен количество отображаемых строк. Когда пользователь прокручивает новых строк в представление, код запрашивает новые данные из кэша и при необходимости очищает старые данные из памяти.  
  
 При реализации виртуального режима, необходимо отслеживать, если строку необходимо в модели данных и при откате добавления новой строки. Конкретная реализация этих функциональных возможностей будет зависеть от реализации модели данных и семантика транзакций модели данных; является ли область фиксации на уровне ячейки или строки.  
  
 Дополнительные сведения о виртуальном режиме, см. в разделе [виртуальный режим в элементе управления DataGridView Windows Forms](virtual-mode-in-the-windows-forms-datagridview-control.md). Пример, показывающий, как использовать события в виртуальном режиме, см. в разделе [Пошаговое руководство: Реализация виртуального режима в Windows Forms элемента управления DataGridView](implementing-virtual-mode-wf-datagridview-control.md).  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.DataGridView>
- <xref:System.Windows.Forms.DataGridView.DataSource%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.DataGridView.VirtualMode%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.BindingSource>
- <xref:System.Windows.Forms.DataGridViewColumn.DataPropertyName%2A?displayProperty=nameWithType>
- [Отображение данных с помощью элемента управления DataGridView в Windows Forms](displaying-data-in-the-windows-forms-datagridview-control.md)
- [Типы столбцов элемента управления DataGridView в Windows Forms](column-types-in-the-windows-forms-datagridview-control.md)
- [Пошаговое руководство. Создание не связанного с данными элемента управления DataGridView в Windows Forms](walkthrough-creating-an-unbound-windows-forms-datagridview-control.md)
- [Практическое руководство. Привязка данных к элементу управления DataGridView в Windows Forms](how-to-bind-data-to-the-windows-forms-datagridview-control.md)
- [Виртуальный режим элемента управления DataGridView в Windows Forms](virtual-mode-in-the-windows-forms-datagridview-control.md)
- [Пошаговое руководство. Реализация виртуального режима для элемента управления DataGridView в Windows Forms](implementing-virtual-mode-wf-datagridview-control.md)
