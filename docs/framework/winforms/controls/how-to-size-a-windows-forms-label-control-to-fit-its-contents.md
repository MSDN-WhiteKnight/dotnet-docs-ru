---
title: Практическое руководство. Приведение размера элемента управления Label в соответствие с его содержимым в Windows Forms
ms.date: 03/30/2017
helpviewer_keywords:
- captions [Windows Forms], sizing
- sizing controls
- size [Windows Forms], controls
- labels [Windows Forms], sizing to fit contents
- Label control [Windows Forms], sizing to fit contents
ms.assetid: 99648964-63b2-438c-980e-d24103ad602b
ms.openlocfilehash: 110aab0c0826bb4b06e22158afd6af37b5406be4
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59312193"
---
# <a name="how-to-size-a-windows-forms-label-control-to-fit-its-contents"></a>Практическое руководство. Приведение размера элемента управления Label в соответствие с его содержимым в Windows Forms
Windows Forms <xref:System.Windows.Forms.Label> элемент управления может быть одной или несколькими строками, которая может быть либо фиксированного размера или может автоматически изменять свой размер надписи. <xref:System.Windows.Forms.Label.AutoSize%2A> Свойство помогает определить размер элементов управления в соответствии с размером надписи, который является особенно удобно в том случае, если заголовок будет изменяться во время выполнения.  
  
### <a name="to-make-a-label-control-resize-dynamically-to-fit-its-contents"></a>Чтобы сделать элемент управления label динамически изменить размер, чтобы вместить его содержимое  
  
1. Задайте его <xref:System.Windows.Forms.Label.AutoSize%2A> свойства `true`.  
  
 Если <xref:System.Windows.Forms.Label.AutoSize%2A> присваивается `false`, слова, указанные в <xref:System.Windows.Forms.Label.Text%2A> свойство будет переносится на следующую строку, если это возможно, но элемент управления не будет увеличиваться.  
  
## <a name="see-also"></a>См. также

- [Практическое руководство. Определение клавиш доступа с помощью элементов управления Label в Windows Forms](how-to-create-access-keys-with-windows-forms-label-controls.md)
- [Общие сведения об элементе управления Label](label-control-overview-windows-forms.md)
- [Элемент управления Label](label-control-windows-forms.md)
