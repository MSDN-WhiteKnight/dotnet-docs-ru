---
title: Практическое руководство. Создание формы MDI путем слияния меню и с применением и элементов управления ToolStrip
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- toolbars [Windows Forms]
- ToolStripPanel control [Windows Forms]
- ToolStrip control [Windows Forms]
- MenuStrip control [Windows Forms]
ms.assetid: 64992ed9-44af-4baf-b45f-863e6ab35711
ms.openlocfilehash: a67298614b1985152c42577de14d2c5d295f672f
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59157533"
---
# <a name="how-to-create-an-mdi-form-with-menu-merging-and-toolstrip-controls"></a>Практическое руководство. Создание формы MDI путем слияния меню и с применением и элементов управления ToolStrip
Пространство имен <xref:System.Windows.Forms?displayProperty=nameWithType> поддерживает приложения с интерфейсом MDI, а элемент управления <xref:System.Windows.Forms.MenuStrip> поддерживает слияние меню. Формы MDI также могут содержать элементы управления <xref:System.Windows.Forms.ToolStrip>.  
  
 Имеется широкая поддержка этой возможности в Visual Studio.  
  
 Также см. в разделе [Пошаговое руководство: Создание формы MDI путем слияния меню и элементов управления ToolStrip](walkthrough-creating-an-mdi-form-with-menu-merging-and-toolstrip-controls.md).  
  
## <a name="example"></a>Пример  
 В примере кода ниже показано использование элементов управления <xref:System.Windows.Forms.ToolStripPanel> с формой MDI. Форма также поддерживает слияние меню с вложенными меню.  
  
 [!code-csharp[System.Windows.Forms.ToolStrip.MdiForm#1](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.ToolStrip.MdiForm/CS/Form1.cs#1)]
 [!code-vb[System.Windows.Forms.ToolStrip.MdiForm#1](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Windows.Forms.ToolStrip.MdiForm/VB/Form1.vb#1)]  
  
## <a name="compiling-the-code"></a>Компиляция кода  
 Для этого примера кода требуются:  
  
-   ссылки на сборки System.Drawing и System.Windows.Forms.  
  
 Сведения о выполнении сборки этого примера из командной строки для Visual Basic или Visual C#, см. в разделе [построение из командной строки](../../../visual-basic/reference/command-line-compiler/building-from-the-command-line.md) или [командной строки создания с помощью csc.exe](../../../csharp/language-reference/compiler-options/command-line-building-with-csc-exe.md). Можно также сборке этого примера в Visual Studio путем вставки кода в новый проект.  
  
## <a name="see-also"></a>См. также

- [Элемент управления ToolStrip](toolstrip-control-windows-forms.md)
