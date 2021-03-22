---
title: Практическое руководство. Реализация интерфейса INotifyPropertyChanged
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- INotifyPropertyChanged interface [Windows Forms], implementing
ms.assetid: eac428af-b43b-46ac-80d9-1a5f88658725
ms.openlocfilehash: cfdfb22fd854a8f630243e0f612761c71cb778d8
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59225603"
---
# <a name="how-to-implement-the-inotifypropertychanged-interface"></a>Практическое руководство. Реализация интерфейса INotifyPropertyChanged
В следующем примере кода показано, как реализовать <xref:System.ComponentModel.INotifyPropertyChanged> интерфейс. Реализуйте этот интерфейс для бизнес-объектов, которые используются в привязке данных Windows Forms. При реализации, этот интерфейс сообщает связанному элементу управления об изменениях свойств бизнес-объекта.  
  
## <a name="example"></a>Пример  
 [!code-csharp[System.ComponentModel.IPropertyChangeExample#1](~/samples/snippets/csharp/VS_Snippets_Winforms/System.ComponentModel.IPropertyChangeExample/CS/Form1.cs#1)]
   
  
## <a name="see-also"></a>См. также

- [Практическое руководство. Применение шаблона PropertyNameChanged](how-to-apply-the-propertynamechanged-pattern.md)
- [Привязка данных Windows Forms](windows-forms-data-binding.md)
- [Практическое руководство. Получение уведомления об изменении данных с использованием компонента BindingSource и интерфейса INotifyPropertyChanged](./controls/raise-change-notifications--bindingsource.md)
- [Получение уведомления об изменении данных, связанных с элементом управления, в Windows Forms](change-notification-in-windows-forms-data-binding.md)
