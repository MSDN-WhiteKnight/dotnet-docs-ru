---
title: Практическое руководство. Установка степени прозрачности фона элемента управления
ms.date: 03/30/2017
helpviewer_keywords:
- transparent backgrounds [Windows Forms], custom controls
- custom controls [Windows Forms], transparent background
- transparency [Windows Forms], Windows Forms custom controls
ms.assetid: 32433e63-f4e9-4305-9857-6de3edeb944a
ms.openlocfilehash: 671075973793d7fbf0b70ce77428a0a632305b9c
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59206100"
---
# <a name="how-to-give-your-control-a-transparent-background"></a>Практическое руководство. Установка степени прозрачности фона элемента управления
В предыдущих версиях платформы .NET Framework элементы управления не поддерживали задание прозрачных цветов фона, если предварительно не был установлен метод <xref:System.Windows.Forms.Control.SetStyle%2A> в конструкторе форм. В текущей версии платформы для большинства элементов управления можно задать цвет фона <xref:System.Drawing.Color.Transparent%2A> в окне **Свойства** во время разработки или в коде в конструкторе форм.  
  
> [!NOTE]
>  Элементы управления Windows Forms не поддерживают настоящую прозрачность. Фон прозрачного элемента управления Windows Forms закрашивается его родительским элементом.  
  
> [!NOTE]
>  Элемент управления <xref:System.Windows.Controls.Button> не поддерживает прозрачный цвет фона, даже если свойство <xref:System.Windows.Forms.ButtonBase.BackColor%2A> имеет значение <xref:System.Drawing.Color.Transparent%2A>.  
  
### <a name="to-give-your-control-a-transparent-backcolor"></a>Установка прозрачного фона для элемента управления  
  
-   В окне «Свойства» выберите <xref:System.Windows.Forms.ButtonBase.BackColor%2A> свойство и присвойте ему значение <xref:System.Drawing.Color.Transparent%2A>  
  
## <a name="see-also"></a>См. также

- <xref:System.Drawing.Color.FromArgb%2A>
- [Разработка пользовательских элементов управления Windows Forms в .NET Framework](developing-custom-windows-forms-controls.md)
- [Использование управляемых графических классов](../advanced/using-managed-graphics-classes.md)
- [Практическое руководство. Рисование непрозрачных и полупрозрачных линий](../advanced/how-to-draw-opaque-and-semitransparent-lines.md)
