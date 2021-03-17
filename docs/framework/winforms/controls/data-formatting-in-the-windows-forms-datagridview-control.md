---
title: Форматирование данных в элементе управления DataGridView в Windows Forms
ms.date: 03/30/2017
helpviewer_keywords:
- DataGridView control [Windows Forms], formatting data
- data [Windows Forms], formatting in grids
- data grids [Windows Forms], formatting data
ms.assetid: 07bf558d-3748-42ba-8ba0-37fdef924081
ms.openlocfilehash: b5c055bdd12a4bede6e77233726c697de424a055
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59158650"
---
# <a name="data-formatting-in-the-windows-forms-datagridview-control"></a>Форматирование данных в элементе управления DataGridView в Windows Forms
<xref:System.Windows.Forms.DataGridView> Управления обеспечивает автоматическое преобразование между значениями ячеек и типы данных, которые отображаются в родительских столбцах. Столбцах текстовых полей, например, отображения строковых представлений значений перечисления, число, даты и времени и введенный пользователем строковые значения преобразуются в типы, необходимые для хранилища данных.  
  
## <a name="formatting-with-the-datagridviewcellstyle-class"></a>Форматирование с помощью класса DataGridViewCellStyle  
 <xref:System.Windows.Forms.DataGridView> Элемент управления предоставляет основные данные форматирования значений ячеек, через <xref:System.Windows.Forms.DataGridViewCellStyle> класса. Можно использовать <xref:System.Windows.Forms.DataGridViewCellStyle.Format%2A> свойство для форматирования значений даты, времени, числа и перечисления для текущего языка и региональных параметров по умолчанию, с помощью описателей формата, описанные в [типы форматирования](../../../standard/base-types/formatting-types.md). Также можно отформатировать эти значения для конкретных языков и региональных параметров с помощью <xref:System.Windows.Forms.DataGridViewCellStyle.FormatProvider%2A> свойство. Указанный формат используется для отображения данных и для анализа данных, которые пользователь вводит в указанном формате.  
  
 <xref:System.Windows.Forms.DataGridViewCellStyle> Класс предоставляет дополнительные свойства форматирования для переноса слов, выравнивание текста и настройки отображения значений null базы данных. Дополнительные сведения см. в разделе [Как Форматирование данных в Windows Forms элемента управления DataGridView](how-to-format-data-in-the-windows-forms-datagridview-control.md).  
  
## <a name="formatting-with-the-cellformatting-event"></a>Форматирование с помощью событий CellFormatting  
 Если базовое форматирование не удовлетворяет вашим потребностям, можно указать пользовательское форматирование данных в обработчик <xref:System.Windows.Forms.DataGridView.CellFormatting?displayProperty=nameWithType> событий. <xref:System.Windows.Forms.DataGridViewCellFormattingEventArgs> Передается обработчику имеет <xref:System.Windows.Forms.ConvertEventArgs.Value%2A> свойство, которое изначально содержит значение ячейки. Как правило это значение автоматически преобразуется в тип отображения. Для преобразования значения самостоятельно, задайте <xref:System.Windows.Forms.ConvertEventArgs.Value%2A> значение части типа отображения.  
  
> [!NOTE]
>  Если строка формата действует для ячейки, она переопределяет изменения <xref:System.Windows.Forms.ConvertEventArgs.Value%2A> значение свойства, если не задать <xref:System.Windows.Forms.DataGridViewCellFormattingEventArgs.FormattingApplied%2A> свойства `true`.  
  
 <xref:System.Windows.Forms.DataGridView.CellFormatting> Событие также полезно, если вы хотите задать <xref:System.Windows.Forms.DataGridViewCellStyle> свойства для отдельных ячеек на основе их значений. Дополнительные сведения см. в разделе [Как Настройка форматирования данных в элементе управления DataGridView Windows Forms](how-to-customize-data-formatting-in-the-windows-forms-datagridview-control.md).  
  
 Если анализ указанные пользователем значения по умолчанию не удовлетворяет вашим потребностям, можно обрабатывать <xref:System.Windows.Forms.DataGridView.CellParsing> событие <xref:System.Windows.Forms.DataGridView> элемента управления для предоставления пользовательского анализа.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.DataGridView>
- <xref:System.Windows.Forms.DataGridViewCellStyle>
- [Отображение данных с помощью элемента управления DataGridView в Windows Forms](displaying-data-in-the-windows-forms-datagridview-control.md)
- [Стили ячеек элемента управления DataGridView в Windows Forms](cell-styles-in-the-windows-forms-datagridview-control.md)
- [Практическое руководство. Форматирование данных элемента управления DataGridView в Windows Forms](how-to-format-data-in-the-windows-forms-datagridview-control.md)
- [Практическое руководство. Настройка форматирования данных элемента управления DataGridView в Windows Forms](how-to-customize-data-formatting-in-the-windows-forms-datagridview-control.md)
