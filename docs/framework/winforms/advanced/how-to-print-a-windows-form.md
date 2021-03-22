---
title: Практическое руководство. Печать формы Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- Windows Forms, printing
- printing [Windows Forms]
- printing a form
- printing [Windows Forms], printing a form
ms.assetid: c8dff5f8-f56a-4c07-ae31-64643b31f8fc
ms.openlocfilehash: 85fb12028687578b76e0f16061deb9b9a4de70e3
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59121970"
---
# <a name="how-to-print-a-windows-form"></a>Практическое руководство. Печать формы Windows Forms
Как часть процесса разработки обычно требуется распечатать копию в форму Windows. В следующем примере кода показано, как распечатать копию текущей формы с помощью <xref:System.Drawing.Graphics.CopyFromScreen%2A> метод.  
  
## <a name="example"></a>Пример  
 [!code-csharp[System.Drawing.Graphics.CopyFromScreen#1](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Drawing.Graphics.CopyFromScreen/CS/Form1.cs#1)]
   
  
## <a name="compiling-the-code"></a>Компиляция кода  
 Это полный пример кода, содержащий `Main` метод.  
  
## <a name="robust-programming"></a>Отказоустойчивость  
 При следующих условиях возможно возникновение исключения:  
  
-   У вас нет разрешения на доступ к принтеру.  
  
-   Нет нет установленных принтеров.  
  
## <a name="net-framework-security"></a>Безопасность платформы .NET Framework  
 Чтобы запустить этот пример кода, необходимо разрешение на доступ к принтеру, используемые с компьютера.  
  
## <a name="see-also"></a>См. также

- <xref:System.Drawing.Printing.PrintDocument>
- [Практическое руководство. Отрисовка изображений с использованием GDI+](how-to-render-images-with-gdi.md)
- [Практическое руководство. Печать графических изображений в Windows Forms](how-to-print-graphics-in-windows-forms.md)
