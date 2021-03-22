---
title: Практическое руководство. Печать в Windows Forms с использованием предварительного просмотра
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- printing [Windows Forms], using print preview
- printing [Windows Forms], with print preview
- print preview
ms.assetid: 4a16f7e2-ae10-4485-b0ae-3d558334d0fe
ms.openlocfilehash: db9269978f3a77920778ab120a6ace11d6dd111c
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59325765"
---
# <a name="how-to-print-in-windows-forms-using-print-preview"></a>Практическое руководство. Печать в Windows Forms с использованием предварительного просмотра
При программировании с использованием Windows Forms в качестве дополнения к службам печати часто предлагается возможность предварительного просмотра. Легким способом добавления предварительного просмотра в приложение является использование элемента управления <xref:System.Windows.Forms.PrintPreviewDialog> в сочетании с логикой обработки событий <xref:System.Drawing.Printing.PrintDocument.PrintPage> для печати файла.  
  
### <a name="to-preview-a-text-document-with-a-printpreviewdialog-control"></a>Предварительный просмотр текстового документа с помощью элемента управления PrintPreviewDialog  
  
1. Добавьте в форму элемент управления <xref:System.Windows.Forms.PrintPreviewDialog>, <xref:System.Drawing.Printing.PrintDocument>и две строки.  
  
     [!code-csharp[System.Drawing.Printing.PrintPreviewExample#1](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Drawing.Printing.PrintPreviewExample/CS/Form1.cs#1)]
       
  
2. Укажите в качестве значения свойства <xref:System.Drawing.Printing.PrintDocument.DocumentName%2A> документ, который нужно напечатать, а затем откройте документ и прочтите его содержимое в строку, добавленную ранее.  
  
     [!code-csharp[System.Drawing.Printing.PrintPreviewExample#2](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Drawing.Printing.PrintPreviewExample/CS/Form1.cs#2)]
       
  
3. Как и при печати документа, для расчета числа строк на странице и отрисовки содержимого документа в обработчике событий <xref:System.Drawing.Printing.PrintDocument.PrintPage> используется свойство <xref:System.Drawing.Printing.PrintPageEventArgs.Graphics%2A> класса <xref:System.Drawing.Printing.PrintPageEventArgs> и содержимое файла. Нарисовав очередную страницу, проверьте, является ли она последней, и установите соответствующим образом свойство <xref:System.Drawing.Printing.PrintPageEventArgs.HasMorePages%2A> класса <xref:System.Drawing.Printing.PrintPageEventArgs> . Событие <xref:System.Drawing.Printing.PrintDocument.PrintPage> возникает до тех пор, пока значение свойства <xref:System.Drawing.Printing.PrintPageEventArgs.HasMorePages%2A> не станет равно `false`. После завершения отрисовки документа сбросьте строку, подлежащую отрисовке. Кроме того, убедитесь в том, что событие <xref:System.Drawing.Printing.PrintDocument.PrintPage> связано со своим методом обработки событий.  
  
    > [!NOTE]
    >  Если поддержка печати уже реализована в приложении, то, возможно, шаги 2 и 3 были выполнены ранее.  
  
     В примере кода ниже обработчик событий используется для печати файла testPage.txt тем шрифтом, который используется в форме.  
  
     [!code-csharp[System.Drawing.Printing.PrintPreviewExample#3](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Drawing.Printing.PrintPreviewExample/CS/Form1.cs#3)]
       
  
4. Присвойте свойству <xref:System.Windows.Forms.PrintPreviewDialog.Document%2A> элемента управления <xref:System.Windows.Forms.PrintPreviewDialog> значение компонента <xref:System.Drawing.Printing.PrintDocument> в форме.  
  
     [!code-csharp[System.Drawing.Printing.PrintPreviewExample#5](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Drawing.Printing.PrintPreviewExample/CS/Form1.cs#5)]
       
  
5. Вызовите метод <xref:System.Windows.Forms.CommonDialog.ShowDialog%2A> элемента управления <xref:System.Windows.Forms.PrintPreviewDialog> . Как правило, метод <xref:System.Windows.Forms.CommonDialog.ShowDialog%2A> вызывается из метода обработки событий <xref:System.Windows.Forms.Control.Click> кнопки. Вызов метода <xref:System.Windows.Forms.CommonDialog.ShowDialog%2A> приводит к возникновению события <xref:System.Drawing.Printing.PrintDocument.PrintPage> и отрисовке выходных данных в элементе управления <xref:System.Windows.Forms.PrintPreviewDialog> . Когда пользователь нажимает на значок печати в диалоговом окне, событие <xref:System.Drawing.Printing.PrintDocument.PrintPage> вызывается снова. При этом выходные данные отправляются на принтер, а не в диалоговое окно предварительного просмотра. Вот почему в шаге 3 в конце процесса отрисовки сбрасывалась строка.  
  
     В примере ниже показан метод обработки событий <xref:System.Windows.Forms.Control.Click> для кнопки в форме. Этот метод вызывает методы для чтения документа и вывода окна предварительного просмотра.  
  
     [!code-csharp[System.Drawing.Printing.PrintPreviewExample#4](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Drawing.Printing.PrintPreviewExample/CS/Form1.cs#4)]
       
  
## <a name="example"></a>Пример  
 [!code-csharp[System.Drawing.Printing.PrintPreviewExample#0](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Drawing.Printing.PrintPreviewExample/CS/Form1.cs#0)]
   
  
## <a name="compiling-the-code"></a>Компиляция кода  
 Для этого примера требуются:  
  
-   ссылки на сборки System, System.Windows.Forms и System.Drawing.  
  
-   Сведения о выполнении сборки этого примера из командной строки для Visual Basic или Visual C#, см. в разделе [построение из командной строки](../../../visual-basic/reference/command-line-compiler/building-from-the-command-line.md) или [командной строки создания с помощью csc.exe](../../../csharp/language-reference/compiler-options/command-line-building-with-csc-exe.md). Можно также сборке этого примера в Visual Studio путем вставки кода в новый проект.  
  
## <a name="see-also"></a>См. также

- [Практическое руководство. Печать многостраничных текстовых файлов в Windows Forms](how-to-print-a-multi-page-text-file-in-windows-forms.md)
- [Поддержка печати в Windows Forms](windows-forms-print-support.md)
- [Более безопасная печать в Windows Forms](../more-secure-printing-in-windows-forms.md)
