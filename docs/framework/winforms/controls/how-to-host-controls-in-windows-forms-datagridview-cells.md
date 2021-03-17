---
title: Практическое руководство. Размещение элементов управления в ячейках элемента управления DataGridView в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- controls [Windows Forms], hosting in cells
- DataGridView control [Windows Forms], hosting controls in cells
- cells [Windows Forms], hosting controls
ms.assetid: e79a9d4e-64ec-41f5-93ec-f5492633cbb2
ms.openlocfilehash: 008b6da56c3428d0edcc44778b4d3bef1a52c443
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59194205"
---
# <a name="how-to-host-controls-in-windows-forms-datagridview-cells"></a>Практическое руководство. Размещение элементов управления в ячейках элемента управления DataGridView в Windows Forms
Элемент управления <xref:System.Windows.Forms.DataGridView> предоставляет несколько типов столбцов, что позволяет пользователям вводить и редактировать значения различными способами. Если эти типы столбцов не удовлетворяют вашим потребностям ввода данных, вы можете создать собственные типы столбцов с ячейками, содержащими элементы управления по своему выбору. Для этого необходимо определить классы, производные от <xref:System.Windows.Forms.DataGridViewColumn> и <xref:System.Windows.Forms.DataGridViewCell>. Необходимо также определить класс, производный от <xref:System.Windows.Forms.Control> и реализующий интерфейс <xref:System.Windows.Forms.IDataGridViewEditingControl>.  
  
 В следующем примере кода показано, как создать столбец календаря. В ячейках этого столбца отображаются даты с помощью обычных текстовых полей, однако при редактировании ячейки появляется элемент управления <xref:System.Windows.Forms.DateTimePicker>. Чтобы избежать необходимости повторно реализовать функции отображения текстового поля, класс `CalendarCell` является производным от класса <xref:System.Windows.Forms.DataGridViewTextBoxCell>, а не наследует класс <xref:System.Windows.Forms.DataGridViewCell> напрямую.  
  
> [!NOTE]
>  При наследовании от класса <xref:System.Windows.Forms.DataGridViewCell> или <xref:System.Windows.Forms.DataGridViewColumn> и добавлении новых свойств к производному классу необходимо переопределить метод `Clone`, чтобы скопировать новые свойства во время операций копирования. Кроме того, необходимо вызвать метод `Clone` базового класса, чтобы свойства базового класса скопировались в новую ячейку или столбец.  
  
## <a name="example"></a>Пример  
 [!code-csharp[System.Windows.Forms.DataGridViewCalendarColumn#000](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataGridViewCalendarColumn/CS/datagridviewcalendarcolumn.cs#000)]
 [!code-vb[System.Windows.Forms.DataGridViewCalendarColumn#000](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Windows.Forms.DataGridViewCalendarColumn/VB/datagridviewcalendarcolumn.vb#000)]  
  
## <a name="compiling-the-code"></a>Компиляция кода  
 В следующем примере требуется:  
  
-   ссылки на сборки System и System.Windows.Forms;  
  
 Сведения о выполнении сборки этого примера из командной строки для Visual Basic или Visual C#, см. в разделе [построение из командной строки](../../../visual-basic/reference/command-line-compiler/building-from-the-command-line.md) или [командной строки создания с помощью csc.exe](../../../csharp/language-reference/compiler-options/command-line-building-with-csc-exe.md). Можно также сборке этого примера в Visual Studio путем вставки кода в новый проект.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.DataGridView>
- <xref:System.Windows.Forms.DataGridViewColumn>
- <xref:System.Windows.Forms.DataGridViewCell>
- <xref:System.Windows.Forms.DataGridViewTextBoxCell>
- <xref:System.Windows.Forms.IDataGridViewEditingControl>
- <xref:System.Windows.Forms.DateTimePicker>
- [Настройка элементов управления DataGridView в Windows Forms](customizing-the-windows-forms-datagridview-control.md)
- [Архитектура элементов управления DataGridView](datagridview-control-architecture-windows-forms.md)
- [Типы столбцов элемента управления DataGridView в Windows Forms](column-types-in-the-windows-forms-datagridview-control.md)
