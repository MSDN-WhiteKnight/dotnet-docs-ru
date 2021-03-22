---
title: Практическое руководство. Создание рамки вокруг элемента управления в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- margins
- controls [Windows Forms], Margin property
- padding [Windows Forms], Windows Forms
- controls [Windows Forms], Padding property
- controls [Windows Forms], outlining
- Padding property [Windows Forms]
- margins [Windows Forms], Windows Forms
- Margin property [Windows Forms]
ms.assetid: bac7ed4d-a163-4259-98bd-155a36345890
ms.openlocfilehash: e3bbf43dbe45e675df172a6c3e1db16a3ba9caa8
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59124032"
---
# <a name="how-to-create-a-border-around-a-windows-forms-control-using-padding"></a>Практическое руководство. Создание рамки вокруг элемента управления в Windows Forms
В следующем примере кода демонстрируется создание рамки или контур вокруг <xref:System.Windows.Forms.RichTextBox> элемента управления. В примере задается значение <xref:System.Windows.Forms.Panel> элемента управления <xref:System.Windows.Forms.Padding> свойство до 5 и наборы <xref:System.Windows.Forms.Control.Dock%2A> дочернего <xref:System.Windows.Forms.RichTextBox> управления <xref:System.Windows.Forms.DockStyle.Fill>. <xref:System.Windows.Forms.Control.BackColor%2A> Из <xref:System.Windows.Forms.Panel> управления <xref:System.Drawing.Color.Blue%2A>, который создает синяя рамка вокруг <xref:System.Windows.Forms.RichTextBox> элемента управления.  
  
## <a name="example"></a>Пример  
 [!code-csharp[System.Windows.Forms.Padding#1](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.Padding/CS/Form1.cs#1)]
   
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.Padding>
- [Поля и заполнение в элементах управления Windows Forms](margin-and-padding-in-windows-forms-controls.md)
