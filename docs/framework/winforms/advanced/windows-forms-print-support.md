---
title: Поддержка печати в Windows Forms
ms.date: 03/30/2017
helpviewer_keywords:
- Windows Forms, printing
- printing [Windows Forms]
- forms [Windows Forms], printing (using designer)
- printing [Windows Forms], Windows Forms, support
- printing [Windows Forms], print support
ms.assetid: a4a2960c-eb70-48e2-b641-cfb222704e46
ms.openlocfilehash: 8e008f2cb4b2f32cdba676e68d9fd790530e2b06
ms.sourcegitcommit: 160a88c8087b0e63606e6e35f9bd57fa5f69c168
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/09/2019
ms.locfileid: "57708136"
---
# <a name="windows-forms-print-support"></a>Поддержка печати в Windows Forms
Печать в Windows Forms состоит главным образом с помощью [компонент PrintDocument](../controls/printdocument-component-windows-forms.md) компонента, чтобы пользователь мог напечатать и [управления PrintPreviewDialog](../controls/printpreviewdialog-control-windows-forms.md) элемента управления, [PrintDialog Компонент](../controls/printdialog-component-windows-forms.md) и [компонент PageSetupDialog](../controls/pagesetupdialog-component-windows-forms.md) компонентов для предоставления знакомый графический интерфейс для пользователей, привыкших к операционной системе Windows.  
  
 Обычно создается новый экземпляр класса <xref:System.Drawing.Printing.PrintDocument> компонента, значение свойства, описывающие содержимое для печати с помощью <xref:System.Drawing.Printing.PrinterSettings> и <xref:System.Drawing.Printing.PageSettings> классы и вызовите метод <xref:System.Drawing.Printing.PrintDocument.Print%2A> способ печати документа.  
  
 В ходе печати из приложения на базе Windows <xref:System.Drawing.Printing.PrintDocument> компонента будет отображаться диалоговое окно прерывания печати для предупреждения пользователей к тому факту, печати и чтобы разрешить задание печати отменяется.  
  
## <a name="in-this-section"></a>В этом разделе  
 [Практическое руководство. Создание заданий печати стандартный Windows Forms](how-to-create-standard-windows-forms-print-jobs.md)  
 Содержит сведения об использовании <xref:System.Drawing.Printing.PrintDocument> компонента для печати в Windows Forms.  
  
 [Практическое руководство. Захват данных пользователем в PrintDialog во время выполнения](how-to-capture-user-input-from-a-printdialog-at-run-time.md)  
 Объясняется, как изменить выбранные параметры печати программно с помощью <xref:System.Windows.Forms.PrintDialog> компонента.  
  
 [Практическое руководство. Выбор принтера, подключенного к компьютеру пользователя в Windows Forms](how-to-choose-the-printers-attached-to-user-computer-in-windows-forms.md)  
 Описывает изменение принтер с помощью <xref:System.Windows.Forms.PrintDialog> компонента во время выполнения.  
  
 [Практическое руководство. Печать графических изображений в Windows Forms](how-to-print-graphics-in-windows-forms.md)  
 Описание вывода графики на принтер.  
  
 [Практическое руководство. Печать многостраничных текстовых файлов в Windows Forms](how-to-print-a-multi-page-text-file-in-windows-forms.md)  
 Описывается вывод текста на принтер.  
  
 [Практическое руководство. Полный Windows Forms заданий печати](how-to-complete-windows-forms-print-jobs.md)  
 Описание для оповещения пользователей о завершении задания печати.  
  
 [Практическое руководство. Печать формы Windows Forms](how-to-print-a-windows-form.md)  
 Показано, как распечатать копию текущей формы.  
  
 [Практическое руководство. Печать в Windows Forms с использованием предварительного просмотра](how-to-print-in-windows-forms-using-print-preview.md)  
 Показано, как использовать <xref:System.Windows.Forms.PrintPreviewDialog> для печати документа.  
  
## <a name="related-sections"></a>Связанные разделы  
 [Компонент PrintDocument](../controls/printdocument-component-windows-forms.md)  
 Описываются сценарии использования <xref:System.Drawing.Printing.PrintDocument> компонента.  
  
 [Компонент PrintDialog](../controls/printdialog-component-windows-forms.md)  
 Описываются сценарии использования <xref:System.Windows.Forms.PrintDialog> компонента.  
  
 [Элемент управления PrintPreviewDialog](../controls/printpreviewdialog-control-windows-forms.md)  
 Описываются сценарии использования <xref:System.Windows.Forms.PrintPreviewDialog> элемента управления.  
  
 [Компонент PageSetupDialog](../controls/pagesetupdialog-component-windows-forms.md)  
 Описываются сценарии использования <xref:System.Windows.Forms.PageSetupDialog> компонента.  
  
 <xref:System.Drawing.Printing>  
 Содержит описание классов <xref:System.Drawing.Printing> пространства имен.
