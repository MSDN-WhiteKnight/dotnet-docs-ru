---
title: Настройка элементов управления DataGridView в Windows Forms
ms.date: 03/30/2017
helpviewer_keywords:
- data grids [Windows Forms], customization
- DataGridView control [Windows Forms], customization
ms.assetid: 01ea5d4c-a736-4596-b0e9-a67a1b86e15f
ms.openlocfilehash: ab8d1f07c608aca4f14f5e73860f8c3e263a4610
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59091386"
---
# <a name="customizing-the-windows-forms-datagridview-control"></a>Настройка элементов управления DataGridView в Windows Forms
`DataGridView` Управления предоставляет несколько свойств, которые можно использовать для настройки внешнего вида и базовое поведение (оформление) его ячеек, строк и столбцов. Если у вас есть особые потребности, которые выходят за рамки возможностей <xref:System.Windows.Forms.DataGridViewCellStyle> класса, однако можно также реализовать пользовательское рисование элемента управления или расширяют ее возможности, создав пользовательские ячейки, строки и столбцы.  
  
 Для закрашивания ячейки и строки самостоятельно, можно обработать различные `DataGridView` события рисования. Чтобы изменить существующие функциональные возможности или предоставить новые функциональные возможности, можно создать собственные типы, производные от существующих `DataGridViewCell`, `DataGridViewColumn`, и `DataGridViewRow` типы. Можно также предоставить новые возможности редактирования путем создания производных типов, отображение элемента управления по своему выбору, если ячейка находится в режиме правки.  
  
## <a name="in-this-section"></a>В этом разделе  
 [Практическое руководство. Настройка внешнего вида ячеек элемента управления DataGridView в Windows Forms](customize-the-appearance-of-cells-in-the-datagrid.md)  
 Описание способов обработки <xref:System.Windows.Forms.DataGridView.CellPainting> событий для рисования ячейки вручную.  
  
 [Практическое руководство. Настройка внешнего вида строк элемента управления DataGridView в Windows Forms](customize-the-appearance-of-rows-in-the-datagrid.md)  
 Описание способов обработки <xref:System.Windows.Forms.DataGridView.RowPrePaint> и <xref:System.Windows.Forms.DataGridView.RowPostPaint> события для закрашивания строк с помощью пользовательских, градиента фона и содержимого, которое охватывает несколько столбцов.  
  
 [Практическое руководство. Дополнительные возможности управления внешним видом и поведением ячеек и столбцов элемента управления DataGridView в Windows Forms](customize-cells-and-columns-in-the-datagrid-by-extending-behavior.md)  
 Описывает способы создания пользовательских типов, производных от `DataGridViewCell` и `DataGridViewColumn` для выделения ячеек на них указателя мыши.  
  
 [Практическое руководство. Отключение кнопок в кнопочном столбе элемента управления DataGridView в Windows Forms](disable-buttons-in-a-button-column-in-the-datagrid.md)  
 Описывает способы создания пользовательских типов, производных от <xref:System.Windows.Forms.DataGridViewButtonCell> и <xref:System.Windows.Forms.DataGridViewButtonColumn> для отображения кнопок в кнопочном столбе.  
  
 [Практическое руководство. Размещение элементов управления в ячейках элемента управления DataGridView в Windows Forms](how-to-host-controls-in-windows-forms-datagridview-cells.md)  
 Описывается реализация `IDataGridViewEditingControl` интерфейса и создания пользовательских типов, производных от `DataGridViewCell` и `DataGridViewColumn` для отображения <xref:System.Windows.Forms.DateTimePicker> управления, когда ячейка находится в режиме редактирования.  
  
## <a name="reference"></a>Ссылка  
 <xref:System.Windows.Forms.DataGridView>  
 Справочная документация по элементу управления <xref:System.Windows.Forms.DataGridView>.  
  
 <xref:System.Windows.Forms.DataGridViewCell>  
 Содержит справочную документацию по <xref:System.Windows.Forms.DataGridViewCell> класса.  
  
 <xref:System.Windows.Forms.DataGridViewRow>  
 Содержит справочную документацию по <xref:System.Windows.Forms.DataGridViewRow> класса.  
  
 <xref:System.Windows.Forms.DataGridViewColumn>  
 Содержит справочную документацию по <xref:System.Windows.Forms.DataGridViewColumn> класса.  
  
 <xref:System.Windows.Forms.IDataGridViewEditingControl>  
 Содержит справочную документацию по <xref:System.Windows.Forms.IDataGridViewEditingControl> интерфейс.  
  
## <a name="related-sections"></a>Связанные разделы  
 [Базовое форматирование и оформление элемента управления DataGridView в Windows Forms](basic-formatting-and-styling-in-the-windows-forms-datagridview-control.md)  
 Разделы, описывающие способы изменения базового внешнего вида элемента управления и форматирования отображаемых данных ячейки.  
  
## <a name="see-also"></a>См. также

- [Элемент управления DataGridView](datagridview-control-windows-forms.md)
- [Типы столбцов элемента управления DataGridView в Windows Forms](column-types-in-the-windows-forms-datagridview-control.md)
