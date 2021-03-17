---
title: Интерфейсы, относящиеся к привязке данных
ms.date: 03/30/2017
helpviewer_keywords:
- data [Windows Forms], data-binding interfaces
- INotifyPropertyChanged interface
- IBindingListView interface
- IList interface [Windows Forms], Windows Forms data binding
- IBindingList interface [Windows Forms], Windows Forms data binding
- interfaces [Windows Forms], Windows Forms data binding
- IEditableObject interface [Windows Forms], Windows Forms data binding
- data binding [Windows Forms], interfaces
- IDataErrorInfo interface [Windows Forms], Windows Forms data binding
ms.assetid: 14e49a2e-3e46-47ca-b491-70d546333277
ms.openlocfilehash: ffda85b2704212ea5323117447e0cfe17ffb33db
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59226972"
---
# <a name="interfaces-related-to-data-binding"></a>Интерфейсы, относящиеся к привязке данных
С помощью [!INCLUDE[vstecado](../../../includes/vstecado-md.md)] можно создать различные структуры данных в соответствии с требованиями привязки приложения и данных, с которыми приходится работать. Можно создать собственные классы, которые предоставляют или используют данные в Windows Forms. Такие объекты могут предоставлять функциональные возможности и обеспечивать сложность различного уровня, такие как базовая привязка данных, поддержка на этапе разработки, проверка ошибок, уведомление об изменениях или даже поддержка структурированного отката изменений, внесенных в сами данные.  
  
## <a name="consumers-of-data-binding-interfaces"></a>Потребители интерфейсов привязки данных  
 Ниже описаны две группы объектов интерфейса. В первую группу входят интерфейсы, реализованные на основе источников данных авторами источников данных. Такие интерфейсы предназначены для использования потребителями источников данных, которыми в большинстве случаев являются элементы управления или компоненты Windows Forms. Ко второй группе относятся интерфейсы, используемые авторами компонентов. Авторы компонентов используют эти интерфейсы при создании компонента, поддерживающего привязку данных, которую должен применять модуль привязки данных Windows Forms. Данные интерфейсы можно реализовать внутри классов, связанных с вашей формой, чтобы обеспечить привязку данных. Каждый вариант представляет класс, реализующий интерфейс, позволяющий взаимодействовать с данными. Visual Studio быстрой разработки (RAD) в средствах уже воспользоваться преимуществами этой функции.  
  
### <a name="interfaces-for-implementation-by-data-source-authors"></a>Интерфейсы для реализации авторами источников данных  
 Следующие интерфейсы предназначены для использования элементами управления Windows Forms.  
  
-   <xref:System.Collections.IList> интерфейс  
  
     Класс, реализующий <xref:System.Collections.IList> интерфейс может быть <xref:System.Array>, <xref:System.Collections.ArrayList>, или <xref:System.Collections.CollectionBase>. Они представляют собой индексированные списки элементов типа <xref:System.Object>. Эти списки должны содержать однородные типы, так как первый элемент индекса определяет тип. <xref:System.Collections.IList> будут доступны для привязки только во время выполнения.  
  
    > [!NOTE]
    >  Если вы хотите создать список бизнес-объектов для привязки с Windows Forms, следует рассмотреть возможность использования <xref:System.ComponentModel.BindingList%601>. <xref:System.ComponentModel.BindingList%601> Представляет собой расширяемый класс, реализующий основные интерфейсы, необходимые для двусторонней привязки данных Windows Forms.  
  
-   <xref:System.ComponentModel.IBindingList> интерфейс  
  
     Класс, реализующий <xref:System.ComponentModel.IBindingList> интерфейс обеспечивает более высокого уровня возможностей привязки данных. Благодаря данной реализации у вас есть основные возможности сортировки и уведомлений об изменении как при изменении элементов списка (например, третий элемент в списке заказчиков имеет изменения в поле адреса), так и при изменении самого списка (например, увеличение или уменьшение числа элементов в списке). Уведомление об изменении важно, если вы планируете использовать несколько элементов управления, привязанных к одним и тем же данным, и необходимо, чтобы изменения данных, сделанные в одном из элементов управления, распространялись в другие привязанные элементы управления.  
  
    > [!NOTE]
    >  Уведомление об изменениях включается для <xref:System.ComponentModel.IBindingList> интерфейс, с помощью <xref:System.ComponentModel.IBindingList.SupportsChangeNotification%2A> свойство которой, когда `true`, вызывает <xref:System.ComponentModel.IBindingList.ListChanged> событие, указывающее, изменен список или элемент в списке изменен.  
  
     Тип изменения описывается <xref:System.ComponentModel.ListChangedType> свойство <xref:System.ComponentModel.ListChangedEventArgs> параметр. Следовательно, при любом обновлении модели данных все зависимые представления, например другие элементы управления, привязанные к тому же источнику данных, также будут обновлены. Тем не менее, будет уведомлять список о изменении, чтобы список объектов, содержащихся в списке <xref:System.ComponentModel.IBindingList.ListChanged> событий.  
  
    > [!NOTE]
    >  <xref:System.ComponentModel.BindingList%601> Предоставляет универсальную реализацию <xref:System.ComponentModel.IBindingList> интерфейс.  
  
-   <xref:System.ComponentModel.IBindingListView> интерфейс  
  
     Класс, реализующий <xref:System.ComponentModel.IBindingListView> интерфейс предоставляет все функциональные возможности реализации <xref:System.ComponentModel.IBindingList>, а также как фильтрации и дополнительные возможности сортировки. Такая реализация обеспечивает фильтрацию на основе строк и сортировку по нескольким столбцам с помощью пары "дескриптор свойства-направление".  
  
-   <xref:System.ComponentModel.IEditableObject> интерфейс  
  
     Класс, реализующий <xref:System.ComponentModel.IEditableObject> интерфейс обеспечивает связь объекта с целью управления, когда изменения в данном объекте становятся постоянными. Данная реализация предоставляет <xref:System.ComponentModel.IEditableObject.BeginEdit%2A>, <xref:System.ComponentModel.IEditableObject.EndEdit%2A>, и <xref:System.ComponentModel.IEditableObject.CancelEdit%2A> методы, позволяющие выполнять откат изменений, внесенных в объект. Ниже приводится краткое объяснение работы методов <xref:System.ComponentModel.IEditableObject.BeginEdit%2A>, <xref:System.ComponentModel.IEditableObject.EndEdit%2A>, и <xref:System.ComponentModel.IEditableObject.CancelEdit%2A> методы и как они работают в сочетании друг с другом для обеспечения отката изменений, внесенных в данные:  
  
    -   <xref:System.ComponentModel.IEditableObject.BeginEdit%2A> Метод сигнализирует о начале изменения объекта. Объект, реализующий этот интерфейс нужно будет сохранять все обновления после <xref:System.ComponentModel.IEditableObject.BeginEdit%2A> вызов метода таким образом, что можно было отменить Если <xref:System.ComponentModel.IEditableObject.CancelEdit%2A> вызывается метод. В Windows Forms привязки данных, можно вызвать <xref:System.ComponentModel.IEditableObject.BeginEdit%2A> несколько раз в пределах одной транзакции изменения (например, <xref:System.ComponentModel.IEditableObject.BeginEdit%2A>, <xref:System.ComponentModel.IEditableObject.BeginEdit%2A>, <xref:System.ComponentModel.IEditableObject.EndEdit%2A>). Реализации <xref:System.ComponentModel.IEditableObject> следует следить, следует ли <xref:System.ComponentModel.IEditableObject.BeginEdit%2A> уже был вызван и игнорировать последующие вызовы <xref:System.ComponentModel.IEditableObject.BeginEdit%2A>. Поскольку этот метод может быть вызван несколько раз, очень важно, что последующие вызовы были неразрушающими; то есть последующие <xref:System.ComponentModel.IEditableObject.BeginEdit%2A> вызовы не удается уничтожить обновления были внесены или изменить данные, сохраненные на первом <xref:System.ComponentModel.IEditableObject.BeginEdit%2A> вызова.  
  
    -   <xref:System.ComponentModel.IEditableObject.EndEdit%2A> Метод помещает изменения с момента <xref:System.ComponentModel.IEditableObject.BeginEdit%2A> был вызван в базовый объект, если объект находится в режиме редактирования.  
  
    -   <xref:System.ComponentModel.IEditableObject.CancelEdit%2A> Метод отменяет все изменения, внесенные в объект.  
  
     Дополнительные сведения о том, как <xref:System.ComponentModel.IEditableObject.BeginEdit%2A>, <xref:System.ComponentModel.IEditableObject.EndEdit%2A>, и <xref:System.ComponentModel.IEditableObject.CancelEdit%2A> методы работы, см. в разделе [сохранить данные в базе данных](/visualstudio/data-tools/save-data-back-to-the-database).  
  
     Такой транзакционный характер функциональных возможностей данных используется <xref:System.Windows.Forms.DataGridView> элемента управления.  
  
-   <xref:System.ComponentModel.ICancelAddNew> интерфейс  
  
     Класс, реализующий <xref:System.ComponentModel.ICancelAddNew> обычно реализует интерфейс <xref:System.ComponentModel.IBindingList> интерфейса и позволяет выполнять откат добавлений, сделанных в источнике данных с помощью <xref:System.ComponentModel.IBindingList.AddNew%2A> метод. Если источник данных реализует <xref:System.ComponentModel.IBindingList> интерфейс, вы также должны реализовать <xref:System.ComponentModel.ICancelAddNew> интерфейс.  
  
-   <xref:System.ComponentModel.IDataErrorInfo> интерфейс  
  
     Класс, реализующий <xref:System.ComponentModel.IDataErrorInfo> интерфейс позволяет объектам предоставлять пользовательские сведения об ошибках в привязанные элементы управления:  
  
    -   <xref:System.ComponentModel.IDataErrorInfo.Error%2A> Свойство возвращает общее сообщение об ошибке (например, «ошибка»).  
  
    -   <xref:System.ComponentModel.IDataErrorInfo.Item%2A> Свойство возвращает строку с сообщение об ошибке из столбца (например, «значение в `State` столбец является недопустимым»).  
  
-   <xref:System.Collections.IEnumerable> интерфейс  
  
     Класс, реализующий <xref:System.Collections.IEnumerable> интерфейс, обычно используется в [!INCLUDE[vstecasp](../../../includes/vstecasp-md.md)]. Поддержка Windows Forms для этого интерфейса можно получить только через <xref:System.Windows.Forms.BindingSource> компонента.  
  
    > [!NOTE]
    >  <xref:System.Windows.Forms.BindingSource> Компонент копирует все <xref:System.Collections.IEnumerable> элементы в отдельном списке исключительно для привязки.  
  
-   <xref:System.ComponentModel.ITypedList> интерфейс  
  
     Класс коллекции, реализующий <xref:System.ComponentModel.ITypedList> интерфейс предоставляет возможность управлять порядком и набор свойств, доступных привязанного элемента управления.  
  
    > [!NOTE]
    >  При реализации <xref:System.ComponentModel.ITypedList.GetItemProperties%2A> метод и <xref:System.ComponentModel.PropertyDescriptor> массива не равно null, последней записи в массиве будет дескриптором свойства, описывающим свойство списка, который является другим списком элементов.  
  
-   <xref:System.ComponentModel.ICustomTypeDescriptor> интерфейс  
  
     Класс, реализующий <xref:System.ComponentModel.ICustomTypeDescriptor> интерфейс предоставляет динамические сведения о себе. Этот интерфейс аналогичен <xref:System.ComponentModel.ITypedList> , но используется для объектов, а не списки. Этот интерфейс используется <xref:System.Data.DataRowView> для проецирования схемы основных строк. Простая реализация <xref:System.ComponentModel.ICustomTypeDescriptor> обеспечивается <xref:System.ComponentModel.CustomTypeDescriptor> класса.  
  
    > [!NOTE]
    >  Для поддержки привязки во время разработки, чтобы типы, реализующие <xref:System.ComponentModel.ICustomTypeDescriptor>, тип должен также реализовывать <xref:System.ComponentModel.IComponent> и существовать в качестве экземпляра формы.  
  
-   <xref:System.ComponentModel.IListSource> интерфейс  
  
     Класс, реализующий <xref:System.ComponentModel.IListSource> интерфейс позволяет привязку на основе списка не из списка объектов. <xref:System.ComponentModel.IListSource.GetList%2A> Метод <xref:System.ComponentModel.IListSource> используется для возврата привязываемого списка из объекта, который не является производным от <xref:System.Collections.IList>. <xref:System.ComponentModel.IListSource> используется <xref:System.Data.DataSet> класса.  
  
-   <xref:System.ComponentModel.IRaiseItemChangedEvents> интерфейс  
  
     Класс, реализующий <xref:System.ComponentModel.IRaiseItemChangedEvents> интерфейс представляет собой привязываемый список, который также реализует <xref:System.ComponentModel.IBindingList> интерфейс. Этот интерфейс используется для указания того, если ваш тип вызывает <xref:System.ComponentModel.IBindingList.ListChanged> события типа <xref:System.ComponentModel.ListChangedType.ItemChanged> через его <xref:System.ComponentModel.IRaiseItemChangedEvents.RaisesItemChangedEvents%2A> свойство.  
  
    > [!NOTE]
    >  Следует реализовать <xref:System.ComponentModel.IRaiseItemChangedEvents> Если источник данных предоставляет свойство описанное ранее преобразование списка и взаимодействует с <xref:System.Windows.Forms.BindingSource> компонента. В противном случае <xref:System.Windows.Forms.BindingSource> также будет выполнять преобразование свойства в список событий приводит к снижению производительности.  
  
-   <xref:System.ComponentModel.ISupportInitialize> интерфейс  
  
     Компонент, реализующий <xref:System.ComponentModel.ISupportInitialize> интерфейс, использует возможности пакетной оптимизации для задания свойств и инициализации взаимозависимых свойств. <xref:System.ComponentModel.ISupportInitialize> Содержит два метода:  
  
    -   <xref:System.ComponentModel.ISupportInitialize.BeginInit%2A> подает сигнал о начале инициализации объекта.  
  
    -   <xref:System.ComponentModel.ISupportInitialize.EndInit%2A> подает сигнал о завершении инициализации этого объекта.  
  
-   <xref:System.ComponentModel.ISupportInitializeNotification> интерфейс  
  
     Компонент, реализующий <xref:System.ComponentModel.ISupportInitializeNotification> также интерфейс реализует <xref:System.ComponentModel.ISupportInitialize> интерфейс. Этот интерфейс позволяет уведомлять другие <xref:System.ComponentModel.ISupportInitialize> компоненты завершении инициализации. <xref:System.ComponentModel.ISupportInitializeNotification> Интерфейс содержит два члена:  
  
    -   <xref:System.ComponentModel.ISupportInitializeNotification.IsInitialized%2A> Возвращает `boolean` значение, указывающее, инициализирован ли компонент.  
  
    -   <xref:System.ComponentModel.ISupportInitializeNotification.Initialized> Происходит при <xref:System.ComponentModel.ISupportInitialize.EndInit%2A> вызывается.  
  
-   <xref:System.ComponentModel.INotifyPropertyChanged> интерфейс  
  
     Класс, реализующий этот интерфейс, представляет собой тип, который вызывает событие при изменении любого значения его свойств. Этот интерфейс предназначен для замены шаблона, в рамках которого имеется отдельное событие изменения для каждого свойства элемента управления. При использовании в <xref:System.ComponentModel.BindingList%601>, следует реализовать бизнес-объект <xref:System.ComponentModel.INotifyPropertyChanged> интерфейс, а BindingList\`1 будет преобразовывать <xref:System.ComponentModel.INotifyPropertyChanged.PropertyChanged> событий <xref:System.ComponentModel.BindingList%601.ListChanged> события типа <xref:System.ComponentModel.ListChangedType.ItemChanged>.  
  
    > [!NOTE]
    >  Для изменения уведомление создавалось в привязке между связанным клиентом и данных вашего привязанного источника данных типа источника должен либо реализовывать <xref:System.ComponentModel.INotifyPropertyChanged> интерфейс (предпочтительно), или можно задать *propertyName* `Changed` события для привязанного типа, но не следует использовать оба.  
  
### <a name="interfaces-for-implementation-by-component-authors"></a>Интерфейсы для реализации авторами компонентов  
 Перечисленные ниже интерфейсы предназначены для использования модулем привязки данных в Windows Forms.  
  
-   <xref:System.Windows.Forms.IBindableComponent> интерфейс  
  
     Класс, реализующий этот интерфейс, является компонентом без элемента управления, который поддерживает привязку данных. Этот класс возвращает привязки данных и контекст привязки компонента через <xref:System.Windows.Forms.IBindableComponent.DataBindings%2A> и <xref:System.Windows.Forms.IBindableComponent.BindingContext%2A> свойства этого интерфейса.  
  
    > [!NOTE]
    >  Если компонент наследуется от <xref:System.Windows.Forms.Control>, необходимо реализовать <xref:System.Windows.Forms.IBindableComponent> интерфейс.  
  
-   <xref:System.Windows.Forms.ICurrencyManagerProvider> интерфейс  
  
     Класс, реализующий <xref:System.Windows.Forms.ICurrencyManagerProvider> интерфейс — это компонент, который предоставляет собственный <xref:System.Windows.Forms.CurrencyManager> для управления привязками, связанными с данным конкретным компонентом. Доступ к пользовательскому <xref:System.Windows.Forms.CurrencyManager> обеспечивается <xref:System.Windows.Forms.ICurrencyManagerProvider.CurrencyManager%2A> свойство.  
  
    > [!NOTE]
    >  Класс, наследуемый от <xref:System.Windows.Forms.Control> управляет привязками автоматически посредством его <xref:System.Windows.Forms.Control.BindingContext%2A> свойство, поэтому случаев, в которых необходимо реализовать <xref:System.Windows.Forms.ICurrencyManagerProvider> довольно редки.  
  
## <a name="see-also"></a>См. также

- [Связывание данных и Windows Forms](data-binding-and-windows-forms.md)
- [Практическое руководство. Создание элемента управления с простой привязкой в форме Windows Forms](how-to-create-a-simple-bound-control-on-a-windows-form.md)
- [Привязка данных Windows Forms](windows-forms-data-binding.md)
