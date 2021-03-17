---
title: Практическое руководство. Добавление элемента управления на панель, представленную компонентом ToolStripContentPanel
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- ToolStripContentPanel [Windows Forms], adding controls
ms.assetid: fa410960-bf1a-42fc-80e8-f2e27fb3dbb8
ms.openlocfilehash: d228300e00a5c2be9cf530cd921865a01accab05
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59177883"
---
# <a name="how-to-add-a-control-to-a-toolstripcontentpanel"></a>Практическое руководство. Добавление элемента управления на панель, представленную компонентом ToolStripContentPanel
Можно программно добавить один или несколько элементов для <xref:System.Windows.Forms.ToolStripContentPanel>.  
  
## <a name="example"></a>Пример  
 В примере кода ниже показано, как добавить <xref:System.Windows.Forms.RichTextBox> к <xref:System.Windows.Forms.ToolStripContentPanel>.  
  
 [!code-csharp[System.Windows.Forms.ToolStripContainer#1](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.ToolStripContainer/CS/Form1.cs#1)]
 [!code-vb[System.Windows.Forms.ToolStripContainer#1](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Windows.Forms.ToolStripContainer/VB/Form1.vb#1)]  
  
## <a name="compiling-the-code"></a>Компиляция кода  
 Для этого примера кода требуются:  
  
-   ссылки на сборки System, System.Drawing и System.Windows.Forms.  
  
 Сведения о выполнении сборки этого примера из командной строки для Visual Basic или Visual C#, см. в разделе [построение из командной строки](../../../visual-basic/reference/command-line-compiler/building-from-the-command-line.md) или [командной строки создания с помощью csc.exe](../../../csharp/language-reference/compiler-options/command-line-building-with-csc-exe.md). Можно также сборке этого примера в Visual Studio путем вставки кода в новый проект.
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.ToolStripContentPanel>
- <xref:System.Windows.Forms.ToolStripContainer>
- [Элемент управления ToolStripContainer](toolstripcontainer-control.md)
- [Элемент управления ToolStrip](toolstrip-control-windows-forms.md)
