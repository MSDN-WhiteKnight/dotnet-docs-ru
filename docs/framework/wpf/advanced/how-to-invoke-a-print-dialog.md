---
title: Практическое руководство. Вызов диалогового окна печати
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- invoking print dialogs [WPF]
- print dialogs [WPF], invoking
ms.assetid: e3a2c84c-74fe-45a4-8501-5813f9dbfed2
ms.openlocfilehash: 2ced508eb83e2955fdcd1ad87fb6415e2052446f
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59206048"
---
# <a name="how-to-invoke-a-print-dialog"></a>Практическое руководство. Вызов диалогового окна печати
Чтобы обеспечить возможность печати из приложения, вы можете создать и открыть <xref:System.Windows.Controls.PrintDialog> объекта.  
  
## <a name="example"></a>Пример  
 Элемент управления <xref:System.Windows.Controls.PrintDialog> предоставляет единую точку входа для UI, конфигурации и отправки задания [!INCLUDE[TLA2#tla_metro](../../../../includes/tla2sharptla-metro-md.md)]. Элемент управления является простой в использовании и может быть создан с помощью XAML разметки или кода. Ниже приведен пример, как создать и открыть элемент управления в коде и способ печати из него. Также показано, как убедиться, что диалоговое окно предоставит пользователям возможность установки конкретного диапазона страниц. В примере кода предполагается, что имеется файл FixedDocumentSequence.xps в корне диска C:.  
  
 [!code-csharp[printdialog#1](~/samples/snippets/csharp/VS_Snippets_Wpf/PrintDialog/CSharp/Window1.xaml.cs#1)]
   
  
 Когда откроется диалоговое окно, пользователи будут доступны для выбора принтеров, установленных на компьютере. Они также получат возможность выбрать [средство записи документов XPS Microsoft](https://go.microsoft.com/fwlink/?LinkId=147319) для создания [!INCLUDE[TLA#tla_xps](../../../../includes/tlasharptla-xps-md.md)] файла вместо печати.  
  
> [!NOTE]
>  <xref:System.Windows.Controls.PrintDialog?displayProperty=nameWithType> Управления WPF, как описано в этом разделе, не следует путать с <xref:System.Windows.Forms.PrintDialog?displayProperty=nameWithType> компонент Windows Forms.  
  
 Строго говоря, можно использовать <xref:System.Windows.Controls.PrintDialog.PrintDocument%2A> метода, не открывая диалоговое окно. В этом смысле элемент управления может использоваться как невидимого компонента печати. Но из соображений производительности было бы лучше использовать <xref:System.Printing.PrintQueue.AddJob%2A> метода или один из многих <xref:System.Windows.Xps.XpsDocumentWriter.Write%2A> и <xref:System.Windows.Xps.XpsDocumentWriter.WriteAsync%2A> методы <xref:System.Windows.Xps.XpsDocumentWriter>. Дополнительные сведения об этом см. в разделе [печатать файлы XPS программным способом](how-to-programmatically-print-xps-files.md) и.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Controls.PrintDialog>
- [Документы в WPF](documents-in-wpf.md)
- [Общие сведения о печати](printing-overview.md)
- [Средство записи XPS-документов (Майкрософт)](https://go.microsoft.com/fwlink/?LinkId=147319)
