---
title: Получение уведомления об изменении данных, связанных с элементом управления, в Windows Forms
ms.date: 03/30/2017
helpviewer_keywords:
- Windows Forms, data binding
- Windows Forms, adding change notification for data binding
ms.assetid: b5b10f90-0585-41d9-a377-409835262a92
ms.openlocfilehash: 559cdee1cce84df1c4b838e249d11ba235a0c636
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59097581"
---
# <a name="change-notification-in-windows-forms-data-binding"></a>Получение уведомления об изменении данных, связанных с элементом управления, в Windows Forms
Одним из наиболее важных понятий привязки данных Windows Forms является *уведомления об изменениях*. Чтобы обеспечить источник данных и связанные элементы управления всегда самые последние данные, необходимо добавить уведомление об изменении для привязки данных. В частности необходимо убедиться, что элементы управления с привязкой уведомляются об изменения, внесенные в источнике данных и источнике уведомляется об изменениях, внесенных в свойства привязанного элемента управления.  
  
 Существуют различные виды уведомлений об изменении зависимости от вида привязки данных:  
  
-   Простая привязка, в котором свойство одного элемента управления привязан к одному экземпляру объекта.  
  
-   Привязки на основе списка, который может включать одно свойство элемента управления привязано к свойству элемента в списке или свойство элемента управления привязаны к списку объектов.  
  
 Кроме того, при создании элементов управления Windows Forms, которые вы хотите использовать для привязки данных, необходимо применить *PropertyName*изменить шаблон к элементам управления, таким образом, для распространения изменений в свойство привязанного элемента управления источник данных.  
  
## <a name="change-notification-for-simple-binding"></a>Уведомление об изменении для простой привязки  
 Для простой привязки бизнес-объектов необходимо предоставить уведомление об изменении при изменении значения связанного свойства. Это можно сделать, предоставляя *PropertyName*событие Changed для каждого свойства бизнес-объекта и привязки к элементам управления с бизнес-объект <xref:System.Windows.Forms.BindingSource> или предпочтительный метод, который реализует бизнес-объекта <xref:System.ComponentModel.INotifyPropertyChanged> интерфейс и вызывает <xref:System.ComponentModel.INotifyPropertyChanged.PropertyChanged> событие при изменении значения свойства. Дополнительные сведения см. в разделе [Как Реализация интерфейса INotifyPropertyChanged](how-to-implement-the-inotifypropertychanged-interface.md). При использовании объектов, реализующих <xref:System.ComponentModel.INotifyPropertyChanged> интерфейс, не нужно использовать <xref:System.Windows.Forms.BindingSource> для привязки объекта к элементу управления, однако применение <xref:System.Windows.Forms.BindingSource> рекомендуется.  
  
## <a name="change-notification-for-list-based-binding"></a>Уведомление об изменении для привязки на основе списка  
 Windows Forms зависит от привязанного списка для предоставления изменение свойства (меняет значение свойства элемента списка) или списка (элемент удален или добавлен в список) сведения в привязанные элементы управления. Таким образом, списки, используемые для привязки данных должны реализовывать интерфейс <xref:System.ComponentModel.IBindingList>, который поддерживает оба типа уведомлений об изменении. <xref:System.ComponentModel.BindingList%601> Является универсальную реализацию <xref:System.ComponentModel.IBindingList> и предназначен для использования с помощью привязки данных Windows Forms. Можно создать <xref:System.ComponentModel.BindingList%601> , содержащий тип бизнес-объекта, который реализует <xref:System.ComponentModel.INotifyPropertyChanged> и список будет автоматически преобразована <xref:System.ComponentModel.INotifyPropertyChanged.PropertyChanged> событий <xref:System.ComponentModel.IBindingList.ListChanged> события. Если связанный список не является <xref:System.ComponentModel.IBindingList>, необходимо привязать список объектов к элементам управления Windows Forms с помощью <xref:System.Windows.Forms.BindingSource> компонента. <xref:System.Windows.Forms.BindingSource> Компонент предоставляет список свойств преобразования аналогичны <xref:System.ComponentModel.BindingList%601>. Дополнительные сведения см. в разделе [Как Получение уведомления об изменении с помощью компонента BindingSource и интерфейса INotifyPropertyChanged](./controls/raise-change-notifications--bindingsource.md).  
  
## <a name="change-notification-for-custom-controls"></a>Уведомление об изменении для пользовательских элементов управления  
 Наконец, на стороне элементов управления можно предоставить *PropertyName*событие Changed для каждого свойства, предназначенный для привязки к данным. Изменения свойств элемента управления, затем распространяются привязанного источника данных. Дополнительные сведения см. в разделе [Как Применение шаблона PropertyNameChanged](how-to-apply-the-propertynamechanged-pattern.md)  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.BindingSource>
- <xref:System.ComponentModel.INotifyPropertyChanged>
- <xref:System.ComponentModel.BindingList%601>
- [Привязка данных Windows Forms](windows-forms-data-binding.md)
- [Источники данных, поддерживаемые Windows Forms](data-sources-supported-by-windows-forms.md)
- [Связывание данных и Windows Forms](data-binding-and-windows-forms.md)
