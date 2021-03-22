---
title: Практическое руководство. Использование элементов управления ToolStripPanel при создании форм MDI
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- MDI [Windows Forms], using ToolStripPanels [Windows Forms]
- ToolStripPanel control [Windows Forms], using for MDI
- toolbars [Windows Forms], using for MDI
ms.assetid: d6b884fc-0846-465f-83c3-5dc0fe93b00f
ms.openlocfilehash: 42d4ed23f477f545c4ff2be53c36d8ea86d3b4f9
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59219880"
---
# <a name="how-to-use-toolstrippanels-for-mdi"></a>Практическое руководство. Использование элементов управления ToolStripPanel при создании форм MDI
<xref:System.Windows.Forms.ToolStripPanel> обеспечивает гибкость для приложений многодокументного интерфейса (MDI) с помощью метода <xref:System.Windows.Forms.ToolStripPanel.Join%2A>.  
  
## <a name="example"></a>Пример  
 В примере кода ниже показано использование элементов управления <xref:System.Windows.Forms.ToolStripPanel> с формой MDI.  
  
 [!code-csharp[System.Windows.Forms.ToolStrip.Misc#10](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.ToolStrip.Misc/CS/Program.cs#10)]
   
  
## <a name="compiling-the-code"></a>Компиляция кода  
 Для этого примера требуются:  
  
-   ссылки на сборки System.Design, System.Drawing и System.Windows.Forms.  
  
 Сведения о выполнении сборки этого примера из командной строки для Visual Basic или Visual C#, см. в разделе [построение из командной строки](../../../visual-basic/reference/command-line-compiler/building-from-the-command-line.md) или [командной строки создания с помощью csc.exe](../../../csharp/language-reference/compiler-options/command-line-building-with-csc-exe.md). Можно также сборке этого примера в Visual Studio путем вставки кода в новый проект.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.ToolStripPanel>
- [Практическое руководство. Соединение нескольких элементов управления ToolStripPanel](how-to-join-toolstrippanels.md)
