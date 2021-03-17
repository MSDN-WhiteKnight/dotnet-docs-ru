---
title: Общие сведения о компоненте PrintDialog (Windows Forms)
ms.date: 03/30/2017
f1_keywords:
- PrintDialog
helpviewer_keywords:
- Print dialog box [Windows Forms], displaying
- PrintDialog component [Windows Forms], about PrintDialog component
ms.assetid: 8327b8ac-1017-4b5e-a88b-fea9dd56999c
ms.openlocfilehash: 982c52dbe9243e69bbb0452513e78798f4d1fd0d
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59072445"
---
# <a name="printdialog-component-overview-windows-forms"></a>Общие сведения о компоненте PrintDialog (Windows Forms)
Windows Forms [PrintDialog](printdialog-component-windows-forms.md) компонент является стандартным диалоговым окном, используемый для выбора принтера, печатаемых страниц и определения других параметров печати в приложениях на базе Windows. Он используется в качестве простого решения для выбора принтера и параметров печати вместо самостоятельной настройки диалогового окна. Вы можете включить пользователям возможность распечатывать многие части своих документов: печать всех, указанного диапазона страниц или выделенного фрагмента текста. Использование стандартных диалоговых окон Windows помогает создавать приложения, основные функциональные возможности которых хорошо знакомы пользователям. <xref:System.Windows.Forms.PrintDialog> Компонент наследуется от <xref:System.Windows.Forms.CommonDialog> класса.  
  
## <a name="working-with-the-component"></a>Работа с компонентом  
 Используйте <xref:System.Windows.Forms.CommonDialog.ShowDialog%2A> метод, чтобы отобразить диалоговое окно во время выполнения. Этот компонент имеет свойства, которые относятся к либо одного задания печати (<xref:System.Drawing.Printing.PrintDocument> класс) или параметры отдельных принтера (<xref:System.Drawing.Printing.PrinterSettings> класса). Любой из них, в свою очередь, могут совместно использоваться несколько принтеров.  
  
 При добавлении в форму, <xref:System.Windows.Forms.PrintDialog> компонент появится в области в нижней части конструктора Windows Forms.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.PrintDialog>
- [Компонент PrintDialog](printdialog-component-windows-forms.md)
