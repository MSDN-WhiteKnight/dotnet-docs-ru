---
title: Практическое руководство. Форматирование элемента управления DataGrid в формах Windows Forms с помощью конструктора
ms.date: 03/30/2017
helpviewer_keywords:
- columns [Windows Forms], DataGrid controls
- colors [Windows Forms], applying to DataGrid controls
- DataGrid control [Windows Forms], formatting
- DataGrid control [Windows Forms], default styles
- tables [Windows Forms], formatting in DataGrid control
- formatting [Windows Forms]
ms.assetid: 533b9814-6124-49dc-9fda-085f1502609f
ms.openlocfilehash: fbe2aa724274022446498a89618f37787f0fa8bd
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59333578"
---
# <a name="how-to-format-the-windows-forms-datagrid-control-using-the-designer"></a>Практическое руководство. Форматирование элемента управления DataGrid в формах Windows Forms с помощью конструктора

> [!NOTE]
>  Элемент управления <xref:System.Windows.Forms.DataGridView> заменяет элемент управления <xref:System.Windows.Forms.DataGrid> и расширяет его функциональные возможности; однако при необходимости элемент управления <xref:System.Windows.Forms.DataGrid> можно сохранить для обратной совместимости и использования в будущем. Дополнительные сведения см. в разделе [Различия элементов управления DataGridView и DataGrid в Windows Forms](differences-between-the-windows-forms-datagridview-and-datagrid-controls.md).  
  
 Разными цветами на различные части <xref:System.Windows.Forms.DataGrid> управления позволяет облегчить чтение и понимание сведений. Цвет могут применяться в строки и столбцы. Строки и столбцы можно также скрывать или отображать по необходимости.  
  
 Существует три основных аспектов форматирования <xref:System.Windows.Forms.DataGrid> управления:  
  
-   Можно задать свойства, чтобы создать стиль по умолчанию, в котором отображаются данные.  
  
-   На этой основе можно настроить способ отображения определенных таблиц во время выполнения.  
  
-   Наконец можно изменить столбцы, которые отображаются в сетке данных, а также цвета и другие элементы, которые отображается.  
  
 На первом этапе форматирования сетки данных, можно задать свойства <xref:System.Windows.Forms.DataGrid> сам. Эти параметры цветов и форматирования составляют основу, из которого затем можно внести изменения в зависимости от данных таблиц и столбцов, отображаемых.  
  
 Следующая процедура требуется **приложения Windows** проекта с формой, содержащей <xref:System.Windows.Forms.DataGrid> элемента управления. Сведения о настройке такого проекта см. в разделе [как: Создайте проект приложения Windows Forms](/visualstudio/ide/step-1-create-a-windows-forms-application-project) и [как: Добавление элементов управления в Windows Forms](how-to-add-controls-to-windows-forms.md). В Visual Studio 2005 <xref:System.Windows.Forms.DataGrid> элемент управления отсутствует в **элементов** по умолчанию. Дополнительные сведения см. в разделе [Как Добавление элементов на панель инструментов](https://docs.microsoft.com/previous-versions/visualstudio/visual-studio-2010/ms165355(v=vs.100)).  
  
> [!NOTE]
>  Отображаемые диалоговые окна и команды меню могут отличаться от описанных в справке в зависимости от текущих параметров или выпуска. Чтобы изменить параметры, выберите в меню **Сервис** пункт **Импорт и экспорт параметров** . Дополнительные сведения см. в разделе [Персонализация интегрированной среды разработки Visual Studio](/visualstudio/ide/personalizing-the-visual-studio-ide).  
  
### <a name="to-establish-a-default-style-for-the-datagrid-control"></a>Чтобы создать стиль по умолчанию для элемента управления DataGrid  
  
1. Выберите элемент управления <xref:System.Windows.Forms.DataGrid>.  
  
2. В **свойства** окна, задайте следующие свойства, соответствующим образом.  
  
    |Свойство|Описание|  
    |--------------|-----------------|  
    |<xref:System.Windows.Forms.DataGrid.AlternatingBackColor%2A>|`BackColor` Свойство определяет цвет четных строк сетки. При задании <xref:System.Windows.Forms.DataGrid.AlternatingBackColor%2A> цвет, все остальные строки свойству цветом (строки 1, 3, 5 и т. д.).|  
    |<xref:System.Windows.Forms.DataGrid.BackColor%2A>|Цвет фона четных строк сетки (строки 0, 2, 4, 6 и т. д.).|  
    |<xref:System.Windows.Forms.DataGrid.BackgroundColor%2A>|Тогда как <xref:System.Windows.Forms.DataGrid.BackColor%2A> и <xref:System.Windows.Forms.DataGrid.AlternatingBackColor%2A> свойства определяет цвет строк в сетке <xref:System.Windows.Forms.DataGrid.BackgroundColor%2A> свойство определяет цвет области за пределами области строк, который отображается, только когда сетка прокручена вниз, а также если только несколько строк, содержится в сетке.|  
    |<xref:System.Windows.Forms.DataGrid.BorderStyle%2A>|Стиль границы сетки, один из <xref:System.Windows.Forms.BorderStyle> значений перечисления.|  
    |<xref:System.Windows.Forms.DataGrid.CaptionBackColor%2A>|Цвет фона заголовка сетки окна, расположенного непосредственно над сеткой.|  
    |<xref:System.Windows.Forms.DataGrid.CaptionFont%2A>|Шрифт заголовка в верхней части сетки.|  
    |<xref:System.Windows.Forms.DataGrid.CaptionForeColor%2A>|Цвет фона названия окна сетки.|  
    |<xref:System.Windows.Forms.Control.Font%2A>|Шрифт, используемый для отображения текста в сетке.|  
    |<xref:System.Windows.Forms.DataGrid.ForeColor%2A>|Цвет шрифта, которым данные в строках таблицы данных.|  
    |<xref:System.Windows.Forms.DataGrid.GridLineColor%2A>|Цвет линий сетки сетки данных.|  
    |<xref:System.Windows.Forms.DataGrid.GridLineStyle%2A>|Стиль линий, разделяющих ячейки сетки, один из <xref:System.Windows.Forms.DataGridLineStyle> значений перечисления.|  
    |<xref:System.Windows.Forms.DataGrid.HeaderBackColor%2A>|Цвет фона заголовков строк и столбцов.|  
    |<xref:System.Windows.Forms.DataGrid.HeaderFont%2A>|Шрифт, используемый для заголовков столбцов.|  
    |<xref:System.Windows.Forms.DataGrid.HeaderForeColor%2A>|Основной цвет заголовков столбцов сетки, включая текст заголовка столбца и знак плюс (+) и минус (-) глифы, разворачивать и сворачивать строки, при нескольких связанных таблиц отображаются.|  
    |<xref:System.Windows.Forms.DataGrid.LinkColor%2A>|Цвет текста всех ссылок в сетке данных, включая ссылки на дочерние таблицы, имя отношения и т. д.|  
    |<xref:System.Windows.Forms.DataGrid.ParentRowsBackColor%2A>|В дочерней таблице это цвет фона родительских строк.|  
    |<xref:System.Windows.Forms.DataGrid.ParentRowsForeColor%2A>|В дочерней таблице это основной цвет родительских строк.|  
    |<xref:System.Windows.Forms.DataGrid.ParentRowsLabelStyle%2A>|Определяет, отображаются ли имена таблиц и столбцов в родительской строке, с помощью параметра <xref:System.Windows.Forms.DataGridParentRowsLabelStyle> перечисления.|  
    |<xref:System.Windows.Forms.DataGrid.PreferredColumnWidth%2A>|Стандартная ширина (в пикселях) столбцов сетки. Задать это свойство перед сбросом <xref:System.Windows.Forms.DataGrid.DataSource%2A> и <xref:System.Windows.Forms.DataGrid.DataMember%2A> свойства (либо отдельно, либо с помощью <xref:System.Windows.Forms.DataGrid.SetDataBinding%2A> метод), или свойство не окажет никакого воздействия.<br /><br /> Свойство не может быть присвоено значение меньше 0.|  
    |<xref:System.Windows.Forms.DataGrid.PreferredRowHeight%2A>|Высота строки (в пикселях) строки в сетке. Задать это свойство перед сбросом <xref:System.Windows.Forms.DataGrid.DataSource%2A> и <xref:System.Windows.Forms.DataGrid.DataMember%2A> свойства (либо отдельно, либо с помощью <xref:System.Windows.Forms.DataGrid.SetDataBinding%2A> метод), или свойство не окажет никакого воздействия.<br /><br /> Свойство не может быть присвоено значение меньше 0.|  
    |<xref:System.Windows.Forms.DataGrid.RowHeaderWidth%2A>|Ширина заголовков строк сетки.|  
    |<xref:System.Windows.Forms.DataGrid.SelectionBackColor%2A>|При выборе ячейки или строки, это цвет фона.|  
    |<xref:System.Windows.Forms.DataGrid.SelectionForeColor%2A>|При выборе ячейки или строки, это цвет переднего плана.|  
  
    > [!NOTE]
    >  При настройке цветов элементов управления, это можно сделать элемент управления недоступен из-за выбор неудачных цветов (например, красный и зеленый). Использование цветов, доступных на **системных цветов** палитры модулей, чтобы избежать этой проблемы.

     Следующая процедура требуется <xref:System.Windows.Forms.DataGrid> элемент управления привязан к таблице данных. Дополнительные сведения см. в разделе [Как Привязка элемента управления DataGrid в Windows Forms к источнику данных](how-to-bind-the-windows-forms-datagrid-control-to-a-data-source.md).

### <a name="to-set-the-table-and-column-style-of-a-data-table-at-design-time"></a>Если требуется задать стиль таблицы и столбца таблицы данных во время разработки

1. Выберите <xref:System.Windows.Forms.DataGrid> элемент управления в форме.

2. В **свойства** выберите <xref:System.Windows.Forms.DataGrid.TableStyles%2A> свойство и нажмите кнопку **кнопку с многоточием** (![экрана VisualStudioEllipsesButton](../media/vbellipsesbutton.png " vbEllipsesButton")) кнопку.

3. В **редактор коллекции DataGridTableStyle** диалоговом окне щелкните **добавить** , добавляемый в коллекцию стиль таблицы.

     С помощью **редактор коллекции DataGridTableStyle**, можно добавить и удалить таблицы стилей, отображения набора и свойства макета и набор сопоставление имен для стилей таблиц.

4. Задайте <xref:System.Windows.Forms.DataGridTableStyle.MappingName%2A> свойство имя сопоставления для каждого стиля таблицы.

     Сопоставление имен используется для указания, следует использовать стиль таблицы.

5. В **редактор коллекции DataGridTableStyle**выберите <xref:System.Windows.Forms.DataGridTableStyle.GridColumnStyles%2A> свойство и нажмите кнопку с многоточием (![экрана VisualStudioEllipsesButton](../media/vbellipsesbutton.png "vbEllipsesButton ")).

6. В **редактор коллекции DataGridColumnStyle** диалоговое окно, добавьте созданный стиль таблицы стилей столбцов.

     С помощью **редактор коллекции DataGridColumnStyle**, можно добавить и удалить стили столбцов, задавать свойства отображения и макета и установить имя сопоставления, и строки форматирования для данных столбцов.

    > [!NOTE]
    >  Дополнительные сведения о форматировании строк см. в разделе [типы форматирования](../../../standard/base-types/formatting-types.md).

## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.GridTableStylesCollection>
- <xref:System.Windows.Forms.GridColumnStylesCollection>
- <xref:System.Windows.Forms.DataGrid>
- [Практическое руководство. Удаление или скрытие столбцов элемента управления DataGrid в Windows Forms](how-to-delete-or-hide-columns-in-the-windows-forms-datagrid-control.md)
- [Элемент управления DataGrid](datagrid-control-windows-forms.md)