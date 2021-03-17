---
title: Визуальное наследование в Windows Forms
ms.date: 03/30/2017
helpviewer_keywords:
- base forms
- inheritance [Windows Forms], forms
- inherited forms [Windows Forms], Windows Forms
- inheritance
- inherited forms
- form inheritance
- Windows Forms, inheritance
ms.assetid: 857eb737-3602-4d49-bd8b-f70d33ace345
ms.openlocfilehash: e94cdc38b97f95cfe8a8504733298525c25667df
ms.sourcegitcommit: 160a88c8087b0e63606e6e35f9bd57fa5f69c168
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/09/2019
ms.locfileid: "57705302"
---
# <a name="windows-forms-visual-inheritance"></a>Визуальное наследование в Windows Forms
В некоторых случаях вы можете решить, что проект вызывает форму, похожую на форму, созданную в предыдущем проекте. Или можете захотеть создать базовую форму с параметрами, например водяным знаком или определенной структурой элементов управления, которые будут затем повторно использоваться в проекте, с каждой итерацией, содержащей изменения в исходном шаблоне формы. Наследование форм позволяет создать базовую форму, затем наследовать от нее и вносить изменения, сохраняя при этом все необходимые исходные параметры.  
  
 Формы производного класса можно создавать программно или с помощью выбора компонентов для визуального наследования.  
  
## <a name="in-this-section"></a>В этом разделе  
 [Практическое руководство. Наследование форм Windows Forms](how-to-inherit-windows-forms.md)  
 Указания по созданию наследуемых форм в коде.  
  
 [Практическое руководство. Наследование форм с помощью диалогового окна выбора наследования](how-to-inherit-forms-using-the-inheritance-picker-dialog-box.md)  
 Указания по созданию наследуемых форм с помощью окна выбора компонентов для наследования.  
  
 [Влияние изменения внешнего вида базовой формы](effects-of-modifying-base-form-appearance.md)  
 Указания по изменению элементов управления базовой формы и их свойств.  
  
 [Пошаговое руководство: Демонстрация визуального наследования](walkthrough-demonstrating-visual-inheritance.md)  
 Создание базовой формы Windows Forms и ее компиляция в библиотеку классов. После этого данная библиотека классов импортируется в другой проект и создается новая форма, которая наследуется от базовой формы.  
  
 [Практическое руководство. Использование свойств Modifiers и GenerateMember](how-to-use-the-modifiers-and-generatemember-properties.md)  
 Указания по использованию свойств `GenerateMember` и `Modifiers`, актуальных в случае, когда конструктор Windows Forms создает переменную-член для компонента.  
  
## <a name="related-sections"></a>Связанные разделы  
 [Основы наследования (Visual Basic)](~/docs/visual-basic/programming-guide/language-features/objects-and-classes/inheritance-basics.md)  
 Описание способов определения классов Visual Basic, которые служат основой для других классов.  
  
 [class](~/docs/csharp/language-reference/keywords/class.md)  
 Описание принципов особенностей классов в C#, в которых разрешено единичное наследование.  
  
 [Устранение неполадок, связанных с унаследованными обработчиками событий, в Visual Basic](~/docs/visual-basic/programming-guide/language-features/events/troubleshooting-inherited-event-handlers.md)  
 Перечисление распространенных проблем, возникающих в обработчиках событий в наследуемых компонентах.
