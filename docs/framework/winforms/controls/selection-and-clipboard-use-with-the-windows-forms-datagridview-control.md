---
title: Выделение данных и операции с буфером обмена в элементе управления DataGridView в Windows Forms
ms.date: 03/30/2017
helpviewer_keywords:
- DataGridView control [Windows Forms], Clipboard use
- cells [Windows Forms], selecting in grids
- Clipboard [Windows Forms], in DataGridView control
- selection [Windows Forms], in DataGridView control
- data grids [Windows Forms], selecting cells
- DataGridView control [Windows Forms], selecting cells
ms.assetid: 82cffcad-8b30-4897-bddb-c3a79d751b83
ms.openlocfilehash: 1836fbc1887082ca685c49bef2bc42bdb167578f
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59105862"
---
# <a name="selection-and-clipboard-use-with-the-windows-forms-datagridview-control"></a>Выделение данных и операции с буфером обмена в элементе управления DataGridView в Windows Forms
`DataGridView` Элемент управления предоставляет множество параметров для настройки, как пользователи могут выбрать ячеек, строк и столбцов. Например вы можете включить выделение одного или нескольких элементов, выбор целых строк или столбцов при щелчке ячейки или выбор целых строк или столбцов только в том случае, когда пользователь щелкает их заголовки, что позволяет также выделение ячеек. Если вы хотите предоставить собственный пользовательский интерфейс для выбора, можно отключить стандартные функции выбора и обрабатывать все команды выбора программным способом. Кроме того можно разрешить пользователям копировать выбранные значения в буфер обмена.  
  
## <a name="in-this-section"></a>В этом разделе  
 [Режимы выделения содержимого элемента управления DataGridView в Windows Forms](selection-modes-in-the-windows-forms-datagridview-control.md)  
 Описывает параметры для пользователей и программный выбор в элементе управления.  
  
 [Практическое руководство. Определение режима выделения для элемента управления DataGridView в Windows Forms](how-to-set-the-selection-mode-of-the-windows-forms-datagridview-control.md)  
 В этой статье описывается настройка элемента управления для выбора одной строки, когда пользователь щелкает ячейку.  
  
 [Практическое руководство. Получение информации о выделенных пользователем ячейках, строках и столбцах элемента управления DataGridView в Windows Forms](selected-cells-rows-and-columns-datagridview.md)  
 В этой статье описывается работа с выбранными коллекциями ячеек, строк и столбцов.  
  
 [Практическое руководство. Разрешение копирования в буфер обмена нескольких ячеек элемента управления DataGridView в Windows Forms](enable-users-to-copy-multiple-cells-to-the-clipboard-datagridview.md)  
 В этой статье описывается включение поддержка буфера обмена в элементе управления.  
  
## <a name="reference"></a>Ссылка  
 <xref:System.Windows.Forms.DataGridView>  
 Справочная документация по элементу управления <xref:System.Windows.Forms.DataGridView>.  
  
 <xref:System.Windows.Forms.DataGridView.SelectionMode%2A?displayProperty=nameWithType>  
 Содержит справочную документацию по <xref:System.Windows.Forms.DataGridView.SelectionMode%2A> свойство.  
  
 <xref:System.Windows.Forms.DataGridView.ClipboardCopyMode%2A>  
 Содержит справочную документацию по <xref:System.Windows.Forms.DataGridView.ClipboardCopyMode%2A> свойство.  
  
 <xref:System.Windows.Forms.DataGridViewSelectedCellCollection>  
 Содержит справочную документацию по <xref:System.Windows.Forms.DataGridViewSelectedCellCollection> класса.  
  
 <xref:System.Windows.Forms.DataGridViewSelectedRowCollection>  
 Содержит справочную документацию по <xref:System.Windows.Forms.DataGridViewSelectedRowCollection> класса.  
  
 <xref:System.Windows.Forms.DataGridViewSelectedColumnCollection>  
 Содержит справочную документацию по <xref:System.Windows.Forms.DataGridViewSelectedColumnCollection> класса.  
  
## <a name="see-also"></a>См. также

- [Элемент управления DataGridView](datagridview-control-windows-forms.md)
- [Выполняемая по умолчанию обработка событий мыши и клавиатуры элементом управления DataGridView в Windows Forms](default-keyboard-and-mouse-handling-in-the-windows-forms-datagridview-control.md)
