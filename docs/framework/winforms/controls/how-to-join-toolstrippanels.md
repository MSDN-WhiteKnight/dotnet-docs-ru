---
title: Практическое руководство. Соединение нескольких элементов управления ToolStripPanel
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- toolbars [Windows Forms], joining together
- ToolStripPanel control [Windows Forms], joining together
ms.assetid: 4eadda6d-e3b8-4151-aaf2-a8d564fbe6b3
ms.openlocfilehash: f73c13c4aac1abef70a2ceb0a30c3e46d8664748
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59161009"
---
# <a name="how-to-join-toolstrippanels"></a>Практическое руководство. Соединение нескольких элементов управления ToolStripPanel
Элементы управления <xref:System.Windows.Forms.ToolStrip> можно подключать к <xref:System.Windows.Forms.ToolStripPanel> во время выполнения, благодаря чему обеспечивается гибкость приложений с интерфейсом MDI.  
  
## <a name="example"></a>Пример  
 В примере кода ниже показано, как подключить элементы управления <xref:System.Windows.Forms.ToolStrip> к <xref:System.Windows.Forms.ToolStripPanel>.  
  
 [!code-csharp[System.Windows.Forms.ToolStrip.Misc#11](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.ToolStrip.Misc/CS/Program.cs#11)]
   
  
## <a name="compiling-the-code"></a>Компиляция кода  
 Для этого примера требуются:  
  
-   ссылки на сборки System.Design, System.Drawing и System.Windows.Forms.  
  
 Сведения о выполнении сборки этого примера из командной строки для Visual Basic или Visual C#, см. в разделе [построение из командной строки](../../../visual-basic/reference/command-line-compiler/building-from-the-command-line.md) или [командной строки создания с помощью csc.exe](../../../csharp/language-reference/compiler-options/command-line-building-with-csc-exe.md). Можно также сборке этого примера в Visual Studio путем вставки кода в новый проект.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.ToolStrip>
- <xref:System.Windows.Forms.ToolStripPanel>
- [Практическое руководство. Использование элементов управления ToolStripPanel при создании форм MDI](how-to-use-toolstrippanels-for-mdi.md)
