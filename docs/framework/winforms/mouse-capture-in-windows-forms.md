---
title: Захват мыши в Windows Forms
ms.date: 03/30/2017
helpviewer_keywords:
- mouse [Windows Forms], capture
ms.assetid: 8911d4b0-a4f8-4f93-8246-371aebd27d0c
ms.openlocfilehash: 30432c6978f60cc9ad47d5df5dafc7aa45229f3b
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59151649"
---
# <a name="mouse-capture-in-windows-forms"></a>Захват мыши в Windows Forms
*Захват мыши* называется элемент управления вводом все мыши. Если мышь захвачена элементом управления, он получает ввод от мыши ли указатель мыши находится в границах.  
  
## <a name="setting-mouse-capture"></a>Установка захвата мыши  
 В Windows Forms имеет захват мыши элементом управления при нажатии кнопки мыши на элемент управления, и который мышь выпускается элементом управления, когда пользователь отпускает кнопку мыши.  
  
 <xref:System.Windows.Forms.Control.Capture%2A> Свойство <xref:System.Windows.Forms.Control> класса указывает ли мышь захвачена элементом. Чтобы определить, когда элемент управления теряет захват мыши, обработайте <xref:System.Windows.Forms.Control.MouseCaptureChanged> событий.  
  
 Только окна на передний план можно захватить мышь. Если фоновое окно пытается захватить мышь, получит сообщения о событиях мыши, возникающие, когда указатель мыши находится в видимой части окна. Кроме того даже если мышь захвачена окна на передний план, пользователь может по-прежнему щелкнуть другое окно выводило на передний план. При захвате мыши сочетаний клавиш не работают.  
  
## <a name="see-also"></a>См. также

- [Ввод данных мышью в приложении Windows Forms](mouse-input-in-a-windows-forms-application.md)
