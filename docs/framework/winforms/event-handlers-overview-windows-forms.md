---
title: Обзор обработчиков событий (Windows Forms)
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- Windows Forms, event handling
- event handling [Windows Forms], Windows Forms
- event handlers [Windows Forms], about event handlers
ms.assetid: 228112e1-1711-42ee-8ffa-ff3555bffe66
ms.openlocfilehash: 05acbfaf427060d015c2445360a7d73ebe97d070
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59186086"
---
# <a name="event-handlers-overview-windows-forms"></a>Обзор обработчиков событий (Windows Forms)
Обработчик событий — метод, связанный с событием. При возникновении события выполняется код в обработчик событий. Каждый обработчик событий предоставляет два параметра, которые дают возможность обрабатывать событие должным образом. В примере показан обработчик событий для <xref:System.Windows.Forms.Button> элемента управления <xref:System.Windows.Forms.Control.Click> событий.  
  
```vb  
Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click  
  
End Sub  
```  
  
```csharp  
private void button1_Click(object sender, System.EventArgs e)   
{  
  
}  
```  
  
```cpp  
private:  
  void button1_Click(System::Object ^ sender,  
    System::EventArgs ^ e)  
  {  
  
  }  
```  
  
 Первый параметр,`sender`, предоставляющий ссылку на объект, который вызвал событие. Второй параметр, `e`, в приведенном выше примере передает объект события, которое обрабатывается. Ссылаясь на свойства объекта (и в некоторых случаях его методы), можно получить сведения, такие как расположение для события мыши или данных, передаваемых в событиях и перетащите указатель мыши.  
  
 Обычно каждое событие создает обработчик событий с типом другой объект события для второго параметра. Некоторые обработчики событий, например, для <xref:System.Windows.Forms.Control.MouseDown> и <xref:System.Windows.Forms.Control.MouseUp> события, имеют один и тот же тип объекта для второго параметра. Для этих типов событий можно использовать один и тот же обработчик событий для обработки обоих событий.  
  
 Можно также использовать тот же обработчик событий для обработки того же события для различных элементов управления. Например, если у вас есть группы <xref:System.Windows.Forms.RadioButton> элементы управления формы, можно создать один обработчик событий для <xref:System.Windows.Forms.Control.Click> событий и каждого элемента управления <xref:System.Windows.Forms.Control.Click> привязки событий к одному обработчику событий. Дополнительные сведения см. в разделе [Как Подключение нескольких событий к одному обработчику в Windows Forms](how-to-connect-multiple-events-to-a-single-event-handler-in-windows-forms.md).  
  
## <a name="see-also"></a>См. также

- [Создание обработчиков событий в Windows Forms](creating-event-handlers-in-windows-forms.md)
- [Общие сведения о событиях](events-overview-windows-forms.md)
