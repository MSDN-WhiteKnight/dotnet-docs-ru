---
title: Функциональная возможность перетаскивания в Windows Forms
ms.date: 03/30/2017
helpviewer_keywords:
- drag and drop [Windows Forms], Windows Forms
- Windows Forms, drag and drop
ms.assetid: 65cd2c03-8782-474e-b958-cbe43eeb902c
ms.openlocfilehash: 437b632706b27cd487d60c2ad23db3f9a3c96c09
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59108021"
---
# <a name="drag-and-drop-functionality-in-windows-forms"></a>Функциональная возможность перетаскивания в Windows Forms
Windows Forms включает набор методов, событий и классов, реализующих режим перетаскивания. В этом разделе приводится обзор поддержки перетаскивания в Windows Forms.  Также см. в разделе [и-операции перетаскивания и поддержка буфера обмена](./advanced/drag-and-drop-operations-and-clipboard-support.md).  
  
## <a name="performing-drag-and-drop-operations"></a>Выполнение операций перетаскивания  
 Для выполнения операций перетаскивания используйте метод <xref:System.Windows.Forms.Control.DoDragDrop%2A> класса <xref:System.Windows.Forms.Control>. Подробнее о том, как выполняется операция перетаскивания, см. в описании метода <xref:System.Windows.Forms.Control.DoDragDrop%2A>. Для получения прямоугольника, над которым должен быть перемещен указатель мыши, чтобы началась операция перетаскивания, используется свойство <xref:System.Windows.Forms.SystemInformation.DragSize%2A> класса <xref:System.Windows.Forms.SystemInformation>.  
  
## <a name="events-related-to-drag-and-drop-operations"></a>События, относящиеся к операциям перетаскивания  
 С операцией перетаскивания связаны две категории событий: события, возникающие в текущем целевом объекте операции перетаскивания, и события, возникающие в ее исходном объекте.  
  
### <a name="events-on-the-current-target"></a>События в текущем целевом объекте  
 В приведенной ниже таблице перечислены события, возникающие в текущем целевом объекте операции перетаскивания.  
  
|Событие мыши|Описание|  
|-----------------|-----------------|  
|<xref:System.Windows.Forms.Control.DragEnter>|Это событие происходит при перетаскивании объекта внутрь границ элемента управления. Обработчик этого события принимает аргумент типа <xref:System.Windows.Forms.DragEventArgs>.|  
|<xref:System.Windows.Forms.Control.DragOver>|Это событие происходит при перетаскивании объекта, пока указатель мыши находится в пределах границ элемента управления. Обработчик этого события принимает аргумент типа <xref:System.Windows.Forms.DragEventArgs>.|  
|<xref:System.Windows.Forms.Control.DragDrop>|Это событие происходит при завершении операции перетаскивания. Обработчик этого события принимает аргумент типа <xref:System.Windows.Forms.DragEventArgs>.|  
|<xref:System.Windows.Forms.Control.DragLeave>|Это событие возникает при перемещении объекта за границы элемента управления. Обработчик этого события принимает аргумент типа <xref:System.EventArgs>.|  
  
 В классе <xref:System.Windows.Forms.DragEventArgs> содержится расположение указателя мыши, текущее состояние кнопок мыши и клавиш-модификаторов, перетаскиваемые данные и значения <xref:System.Windows.Forms.DragDropEffects>, указывающие, какие операции допускаются источником события перетаскивания, и результат операции перетаскивания в целевой объект.  
  
### <a name="events-on-the-source"></a>События в исходном объекте  
 В таблице ниже приведены события, возникающие в исходном объекте операции перетаскивания.  
  
|Событие мыши|Описание|  
|-----------------|-----------------|  
|<xref:System.Windows.Forms.Control.GiveFeedback>|Это событие возникает во время операции перетаскивания. Оно позволяет дать пользователю визуальную подсказку о том, что происходит операция перетаскивания, в виде, например, изменения указателя мыши. Обработчик этого события принимает аргумент типа <xref:System.Windows.Forms.GiveFeedbackEventArgs>.|  
|<xref:System.Windows.Forms.Control.QueryContinueDrag>|Это событие возникает во время операции перетаскивания и позволяет исходному объекту определить, следует ли отменить эту операцию. Обработчик этого события принимает аргумент типа <xref:System.Windows.Forms.QueryContinueDragEventArgs>.|  
  
 В классе <xref:System.Windows.Forms.QueryContinueDragEventArgs> содержится текущее состояние кнопок мыши и клавиш-модификаторов, значение, указывающее, была ли нажата клавиша ESC, и значение <xref:System.Windows.Forms.DragAction>, с помощью которого можно указать, следует ли продолжать операцию перетаскивания.  
  
## <a name="see-also"></a>См. также

- [Ввод данных мышью в приложении Windows Forms](mouse-input-in-a-windows-forms-application.md)
