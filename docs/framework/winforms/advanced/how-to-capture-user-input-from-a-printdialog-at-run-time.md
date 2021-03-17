---
title: Практическое руководство. Перенаправление данных, введенных пользователем в PrintDialog во время выполнения
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- print options [Windows Forms], changing at run time
- printing [Windows Forms], options
- print options
- run time [Windows Forms], changing print options
ms.assetid: 438501d8-9a70-4fb3-aae6-e46579aba0c6
ms.openlocfilehash: 2aaf988f362baf9cd80eb16e4a08f7f65a5077bb
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59311426"
---
# <a name="how-to-capture-user-input-from-a-printdialog-at-run-time"></a>Практическое руководство. Перенаправление данных, введенных пользователем в PrintDialog во время выполнения
Хотя можно задать параметры, относящиеся к печати во время разработки, иногда требуется изменить эти параметры во время выполнения, скорее всего, из-за выборов, сделанных пользователем. Ввод данных для печати документа с помощью <xref:System.Windows.Forms.PrintDialog> и <xref:System.Drawing.Printing.PrintDocument> компонентов.  
  
### <a name="to-change-print-options-programmatically"></a>Чтобы изменить параметры печати программными средствами  
  
1. Добавить <xref:System.Windows.Forms.PrintDialog> и <xref:System.Drawing.Printing.PrintDocument> форму компонента.  
  
2. Задайте <xref:System.Windows.Forms.PrintDialog.Document%2A> свойство <xref:System.Windows.Forms.PrintDialog> для <xref:System.Drawing.Printing.PrintDocument> добавления в форму.  
  
    ```vb  
    PrintDialog1.Document = PrintDocument1  
    ```  
  
    ```csharp  
    printDialog1.Document = PrintDocument1;  
    ```  
  
    ```cpp  
    printDialog1->Document = PrintDocument1;  
    ```  
  
3. Отображение <xref:System.Windows.Forms.PrintDialog> компонент с помощью <xref:System.Windows.Forms.CommonDialog.ShowDialog%2A> метод.  
  
    ```vb  
    PrintDialog1.ShowDialog()  
    ```  
  
    ```csharp  
    printDialog1.ShowDialog();  
    ```  
  
    ```cpp  
    printDialog1->ShowDialog();  
    ```  
  
4. Пользователя вариантами печати из диалогового окна будут скопированы в <xref:System.Drawing.Printing.PrinterSettings> свойство <xref:System.Drawing.Printing.PrintDocument> компонента.  
  
## <a name="see-also"></a>См. также

- [Практическое руководство. Печать многостраничных текстовых файлов в Windows Forms](how-to-print-a-multi-page-text-file-in-windows-forms.md)
- [Поддержка печати в Windows Forms](windows-forms-print-support.md)
