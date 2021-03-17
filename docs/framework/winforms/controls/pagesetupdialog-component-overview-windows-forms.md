---
title: Общие сведения о компоненте PageSetupDialog (Windows Forms)
ms.date: 03/30/2017
f1_keywords:
- PageSetupDialog
helpviewer_keywords:
- Page Setup dialog box [Windows Forms], displaying
- PageSetupDialog component
ms.assetid: 791caacb-a5ca-4fca-bad9-1a5721ad697c
ms.openlocfilehash: 30ac782cae830ac996132046cbbc57392067c0ae
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59228319"
---
# <a name="pagesetupdialog-component-overview-windows-forms"></a>Общие сведения о компоненте PageSetupDialog (Windows Forms)
Windows Forms <xref:System.Windows.Forms.PageSetupDialog> компонент является стандартным диалоговым окном, используемый для задания сведений о странице для печати в приложениях на базе Windows. Используйте его в приложении Windows в качестве простого решения для задания параметров настройки страницы вместо настройки собственного диалогового. Можно разрешить пользователям задать границ и полей, верхние и нижние колонтитулы и книжная или альбомная ориентация. Использование стандартных диалоговых окон Windows помогает создавать приложения, основные функциональные возможности которых хорошо знакомы пользователям.  
  
## <a name="key-properties-and-methods"></a>Ключевые свойства и методы  
 Используйте <xref:System.Windows.Forms.CommonDialog.ShowDialog%2A> метод для отображения диалогового окна во время выполнения. Этот компонент имеет свойства, можно задать, связанные с либо одной страницы (<xref:System.Drawing.Printing.PrintDocument> класс) или любой документ (<xref:System.Drawing.Printing.PageSettings> класса). Кроме того <xref:System.Windows.Forms.PageSetupDialog> компонент может использоваться для определения параметров определенного принтера, которые хранятся в <xref:System.Drawing.Printing.PrinterSettings> класса.  
  
 При добавлении в форму, <xref:System.Windows.Forms.PageSetupDialog> компонент появится в области в нижней части конструктора Windows Forms.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.PageSetupDialog>
- [Компонент PageSetupDialog](pagesetupdialog-component-windows-forms.md)
