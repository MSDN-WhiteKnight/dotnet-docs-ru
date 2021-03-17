---
title: Отображение компонента PrintDialog
ms.date: 03/30/2017
helpviewer_keywords:
- Print dialog box [Windows Forms], displaying
- PrintDialog component [Windows Forms], displaying
- printing [Windows Forms], displaying print dialog box
ms.assetid: 745a8db7-0526-4b21-b09d-18e13ed32014
ms.openlocfilehash: 198ae75d407bd1837033a1cc186d84ff972fdc2f
ms.sourcegitcommit: 14355b4b2fe5bcf874cac96d0a9e6376b567e4c7
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 01/30/2019
ms.locfileid: "55285159"
---
# <a name="how-to-display-the-printdialog-component"></a>Отображение компонента PrintDialog

<xref:System.Windows.Forms.PrintDialog> Компонент является стандартным, многие ваши пользователи будут знакомы с окном диалогового окна печати Windows. Так как пользователям будет удобно работать с ним, полезно было бы использовать <xref:System.Windows.Forms.PrintDialog> компонента.

## <a name="to-display-the-printdialog-component"></a>Отображение компонента PrintDialog

- Вызовите <xref:System.Windows.Forms.Form.ShowDialog%2A> метода в код приложения.

     После отображения этого компонента пользователи смогут взаимодействовать с ним, задавая свойства задания печати. Они сохраняются в <xref:System.Drawing.Printing.PrinterSettings> класс (и <xref:System.Drawing.Printing.PageSettings> класса, если пользователь обращается к [компонент PageSetupDialog](pagesetupdialog-component-windows-forms.md) через <xref:System.Windows.Forms.PrintDialog> компонент) связанные с этим заданием печати. Затем можно вызывать заданные пользователями свойства для определения специфики задания печати.

## <a name="see-also"></a>См. также

- [Практическое руководство. Создание заданий печати стандартный Windows Forms](../advanced/how-to-create-standard-windows-forms-print-jobs.md)
- [Практическое руководство. Захват данных пользователем в PrintDialog во время выполнения](../advanced/how-to-capture-user-input-from-a-printdialog-at-run-time.md)
- [Элемент управления PrintPreviewDialog](printpreviewdialog-control-windows-forms.md)
- [Компонент PrintDialog](printdialog-component-windows-forms.md)
- [Поддержка печати в Windows Forms](../advanced/windows-forms-print-support.md)
- [Элементы управления Windows Forms](index.md)