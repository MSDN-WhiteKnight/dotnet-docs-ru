---
title: Практическое руководство. Определение режима редактирования для элемента управления DataGridView в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- DataGridView control [Windows Forms], edit mode
- data grids [Windows Forms], edit mode
ms.assetid: 93e117e8-94c4-411b-ba31-645e475ed85c
ms.openlocfilehash: 7cb9278cd311d211ef95df238b930970ae472d05
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59080401"
---
# <a name="how-to-specify-the-edit-mode-for-the-windows-forms-datagridview-control"></a>Практическое руководство. Определение режима редактирования для элемента управления DataGridView в Windows Forms
По умолчанию, пользователи могут изменять содержимое текущего <xref:System.Windows.Forms.DataGridView> ячейке текстового поля, введя его или нажав клавишу F2. Таким образом ячейки в режиме редактирования, если выполняются все из следующих условий:  
  
-   Базовый источник данных поддерживает редактирование.  
  
-   <xref:System.Windows.Forms.DataGridView> Включен элемент управления.  
  
-   <xref:System.Windows.Forms.DataGridView.EditMode%2A> Значение свойства не является <xref:System.Windows.Forms.DataGridViewEditMode.EditProgrammatically>.  
  
-   `ReadOnly` Свойства ячейки, строки, столбца и управления имеют значение `false`.  
  
 В режиме редактирования пользователя можно изменить значение ячейки и нажмите клавишу ВВОД для подтверждения изменений или ESC, чтобы отменить изменение для ячейки в исходное значение.  
  
 Можно настроить <xref:System.Windows.Forms.DataGridView> управления позволит ячейка переходит в режим редактирования, как только она становится текущей ячейкой. В этом случае поведение клавиш ввод и ESC не изменяется, но ячейка остается в режиме редактирования после фиксации или вернуть значение. Элемент управления также можно настроить таким образом, чтобы ячейки режим редактирования только в том случае, когда пользователь вводит в ячейку или только в том случае, при нажатии клавиши F2. Наконец, можно предотвратить ячейки в режим редактирования, за исключением случаев, когда вы вызываете <xref:System.Windows.Forms.DataGridView.BeginEdit%2A> метод.  
  
### <a name="to-change-the-edit-mode-of-a-datagridview-control"></a>Чтобы изменить режим правки элемента управления DataGridView  
  
-   Задайте <xref:System.Windows.Forms.DataGridView.EditMode%2A?displayProperty=nameWithType> свойство в соответствующий <xref:System.Windows.Forms.DataGridViewEditMode> перечисления.  
  
     [!code-csharp[System.Windows.Forms.DataGridViewMisc#067](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataGridViewMisc/CS/datagridviewmisc.cs#067)]
     [!code-vb[System.Windows.Forms.DataGridViewMisc#067](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Windows.Forms.DataGridViewMisc/VB/datagridviewmisc.vb#067)]  
  
## <a name="compiling-the-code"></a>Компиляция кода  
 Для этого примера требуются:  
  
-   элемент управления <xref:System.Windows.Forms.DataGridView> с именем `dataGridView1`;  
  
-   ссылки на сборки <xref:System> и <xref:System.Windows.Forms>.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.DataGridView>
- <xref:System.Windows.Forms.DataGridView.EditMode%2A?displayProperty=nameWithType>
- [Ввод данных с помощью элемента управления DataGridView в Windows Forms](data-entry-in-the-windows-forms-datagridview-control.md)
