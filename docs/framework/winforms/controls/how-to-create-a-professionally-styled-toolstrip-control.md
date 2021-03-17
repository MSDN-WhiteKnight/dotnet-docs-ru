---
title: Практическое руководство. Создание профессионально оформленного элемента управления ToolStrip
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- toolbars [Windows Forms]
- ToolStripProfessionalRenderer class [Windows Forms]
- ToolStripRenderer class [Windows Forms]
- ToolStrip control [Windows Forms]
ms.assetid: c208b2f6-8105-474b-9075-d582e1792870
ms.openlocfilehash: 6da6e113867efed79dfcd02f3b89ee1f9ae13c4e
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59104596"
---
# <a name="how-to-create-a-professionally-styled-toolstrip-control"></a>Практическое руководство. Создание профессионально оформленного элемента управления ToolStrip
Вы можете придать элементам управления <xref:System.Windows.Forms.ToolStrip> своего приложения профессиональный внешний вид и поведение, создав собственный класс, производный от типа <xref:System.Windows.Forms.ToolStripProfessionalRenderer>.  
  
 Имеется широкая поддержка этой возможности в Visual Studio.  
  
 См. [Пошаговое руководство: Создание профессионально оформленного элемента управления ToolStrip](walkthrough-creating-a-professionally-styled-toolstrip-control.md).  
  
## <a name="example"></a>Пример  
 В следующем примере кода демонстрируется использование <xref:System.Windows.Forms.ToolStrip> элементы управления для создания составного элемента управления, напоминающего **редактируемую** в Microsoft® Outlook®.  
  
 [!code-csharp[System.Windows.Forms.ToolStrip.StackView#1](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.ToolStrip.StackView/CS/StackView.cs#1)]
 [!code-vb[System.Windows.Forms.ToolStrip.StackView#1](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Windows.Forms.ToolStrip.StackView/VB/StackView.vb#1)]  
  
## <a name="compiling-the-code"></a>Компиляция кода  
 Для этого примера требуются:  
  
-   ссылки на сборки System.Drawing и System.Windows.Forms.  
  
 Сведения о выполнении сборки этого примера из командной строки для Visual Basic или Visual C#, см. в разделе [построение из командной строки](~/docs/visual-basic/reference/command-line-compiler/building-from-the-command-line.md) или [командной строки создания с помощью csc.exe](~/docs/csharp/language-reference/compiler-options/command-line-building-with-csc-exe.md). Можно также сборке этого примера в Visual Studio путем вставки кода в новый проект.  Также см. в разделе [Пошаговое руководство: Создание профессионально оформленного элемента управления ToolStrip](walkthrough-creating-a-professionally-styled-toolstrip-control.md).  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.MenuStrip>
- <xref:System.Windows.Forms.ToolStrip>
- <xref:System.Windows.Forms.StatusStrip>
- [Элемент управления ToolStrip](toolstrip-control-windows-forms.md)
- [Практическое руководство. Связывание с формой стандартных элементов меню](how-to-provide-standard-menu-items-to-a-form.md)
