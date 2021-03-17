---
title: Архитектура компонента BindingSource
ms.date: 03/30/2017
helpviewer_keywords:
- BindingSource component [Windows Forms], architecture
- Windows Forms, data binding
- BindingSource component [Windows Forms], about BindingSource component
- data binding [Windows Forms], BindingSource component
ms.assetid: 7bc69c90-8a11-48b1-9336-3adab5b41591
ms.openlocfilehash: 81559444b6e3da2861e48bdc637ae01d246c0758
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59165351"
---
# <a name="bindingsource-component-architecture"></a>Архитектура компонента BindingSource
С помощью <xref:System.Windows.Forms.BindingSource> компонент, глобально, все элементы управления Windows Forms можно привязать к источникам данных.  
  
 <xref:System.Windows.Forms.BindingSource> Компонента упрощает процесс привязки элементов управления к источнику данных и предоставляет следующие преимущества по сравнению с традиционной привязке данных:  
  
-   Обеспечивает связывание во время разработки к бизнес-объектам.  
  
-   Инкапсулирует <xref:System.Windows.Forms.CurrencyManager> функциональные возможности и предоставляет <xref:System.Windows.Forms.CurrencyManager> события во время разработки.  
  
-   Упрощает создание списка, поддерживающего <xref:System.ComponentModel.IBindingList> интерфейса, предоставляя уведомления об изменении списка источников данных, которые изначально не поддерживают список уведомлений об изменениях.  
  
-   Предоставляет точку расширения для <xref:System.ComponentModel.IBindingList.AddNew%2A?displayProperty=nameWithType> метод.  
  
-   Обеспечивает уровень косвенного обращения между источником данных и элементом управления. Такое обращение очень важно, когда источник данных может изменяться во время выполнения.  
  
-   Взаимодействует с другие данных Windows Forms элементы управления, в частности <xref:System.Windows.Forms.BindingNavigator> и <xref:System.Windows.Forms.DataGridView> элементов управления.  
  
 По этим причинам <xref:System.Windows.Forms.BindingSource> компонент является предпочтительным способом привязки элементов управления Windows Forms к источникам данных.  
  
## <a name="bindingsource-features"></a>Функции BindingSource  
 <xref:System.Windows.Forms.BindingSource> Компонент предоставляет несколько возможностей для привязки элементов управления к данным. Эти функции можно реализовать большинства сценариев привязки данных практически без написания кода со стороны пользователя.  
  
 <xref:System.Windows.Forms.BindingSource> Компонента это достигается путем предоставления согласованного интерфейса для доступа к много различных типов источников данных. Это означает, что использовать ту же процедуру для привязки к любому типу. Например, можно присоединить <xref:System.Windows.Forms.BindingSource.DataSource%2A> свойства <xref:System.Data.DataSet> или бизнес-объекта и в обоих случаях вы используют один набор свойств, методов и событий для управления источника данных.  
  
 Согласованный интерфейс, предоставляемый <xref:System.Windows.Forms.BindingSource> компонент значительно упрощает процесс привязки данных к элементам управления. Для типов источников данных, которые предоставляют уведомления об изменениях, <xref:System.Windows.Forms.BindingSource> компонент автоматически передает изменения между элементом управления и источника данных. Для типов источников данных, не предоставляет уведомления об изменениях предусмотрены события, которые позволяют получение уведомления об изменении. В следующем списке приведены возможности, поддерживаемые <xref:System.Windows.Forms.BindingSource> компонента:  
  
-   Косвенное обращение.  
  
-   Оперативное управление.  
  
-   Источник данных в виде списка.  
  
-   <xref:System.Windows.Forms.BindingSource> как <xref:System.ComponentModel.IBindingList>.  
  
-   Создание пользовательских элементов.  
  
-   Создание транзакционных элементов.  
  
-   <xref:System.Collections.IEnumerable> Поддержка.  
  
-   Поддержка времени разработки.  
  
-   Статические <xref:System.Windows.Forms.ListBindingHelper> методы.  
  
-   Сортировка и фильтрация с использованием <xref:System.ComponentModel.IBindingListView> интерфейс.  
  
-   Интеграция с <xref:System.Windows.Forms.BindingNavigator>.  
  
### <a name="indirection"></a>Косвенное обращение  
 <xref:System.Windows.Forms.BindingSource> Компонент обеспечивает уровень косвенного обращения между элементом управления и источником данных. Вместо привязки элемента управления к источнику данных, привязать элемент управления <xref:System.Windows.Forms.BindingSource>, и подключить источник данных для <xref:System.Windows.Forms.BindingSource> компонента <xref:System.Windows.Forms.BindingSource.DataSource%2A> свойство.  
  
 С этим уровнем косвенного обращения можно изменить без сброса привязки элемента управления источника данных. Это дает следующие возможности:  
  
-   Вы можете подключить <xref:System.Windows.Forms.BindingSource> к различным источникам данных, сохраняя текущие привязки элемента управления.  
  
-   Можно изменить элементы в источнике данных и уведомлять связанные элементы управления. Дополнительные сведения см. в разделе [Как Отражение обновились в источнике данных в элементе управления Windows Forms с использованием компонента BindingSource](reflect-data-source-updates-in-a-wf-control-with-the-bindingsource.md).  
  
-   Можно привязать к <xref:System.Type> вместо объекта в памяти. Дополнительные сведения см. в разделе [Как Привязка элемента управления Windows Forms к типу](how-to-bind-a-windows-forms-control-to-a-type.md). Затем, можно привязать к объекту во время выполнения.  
  
### <a name="currency-management"></a>Управление валюты  
 <xref:System.Windows.Forms.BindingSource> Компонент реализует <xref:System.Windows.Forms.ICurrencyManagerProvider> интерфейса для обработки управления валюты для вас. С помощью <xref:System.Windows.Forms.ICurrencyManagerProvider> интерфейс, можно также обращаться для диспетчер денежных единиц для <xref:System.Windows.Forms.BindingSource>, помимо диспетчер денежных единиц для другого <xref:System.Windows.Forms.BindingSource> привязан к той же <xref:System.Windows.Forms.BindingSource.DataMember%2A>.  
  
 <xref:System.Windows.Forms.BindingSource> Инкапсулирует компонент <xref:System.Windows.Forms.CurrencyManager> функциональные возможности и предоставляет стандартные <xref:System.Windows.Forms.CurrencyManager> свойства и события. Ниже перечислены некоторые из элементов, связанных с управлением валюты.  
  
 <xref:System.Windows.Forms.ICurrencyManagerProvider.CurrencyManager%2A> свойство;  
 Получает диспетчер денежных единиц, сопоставленный <xref:System.Windows.Forms.BindingSource>.  
  
 <xref:System.Windows.Forms.ICurrencyManagerProvider.GetRelatedCurrencyManager%2A> метод  
 Если существует другой <xref:System.Windows.Forms.BindingSource> привязан к указанному элементу данных, Получает диспетчер денежных единиц.  
  
 <xref:System.Windows.Forms.BindingSource.Current%2A> свойство;  
 Возвращает текущий элемент источника данных.  
  
 <xref:System.Windows.Forms.BindingSource.Position%2A> свойство;  
 Возвращает или задает текущую позицию в базовом списке.  
  
 <xref:System.Windows.Forms.BindingSource.EndEdit%2A> метод  
 Применяет ожидающие изменения к базовому источнику данных.  
  
 <xref:System.Windows.Forms.BindingSource.CancelEdit%2A> метод  
 Отменяет текущую операцию редактирования.  
  
### <a name="data-source-as-a-list"></a>Источник данных в виде списка  
 <xref:System.Windows.Forms.BindingSource> Компонент реализует <xref:System.ComponentModel.IBindingListView> и <xref:System.ComponentModel.ITypedList> интерфейсов. В этой реализации можно использовать <xref:System.Windows.Forms.BindingSource> сам компонент как источник данных без любого внешнего хранилища.  
  
 Когда <xref:System.Windows.Forms.BindingSource> компонент подключен к источнику данных, он представляет источник данных в виде списка.  
  
 <xref:System.Windows.Forms.BindingSource.DataSource%2A> Может быть установлено для нескольких источников данных. К ним относятся типы, объекты и списки типов. Итоговый источник данных будет представлен в виде списка. В следующей таблице показаны некоторые общие источники данных и оценка полученного списка.  
  
|Свойство DataSource|Список результатов|  
|-------------------------|------------------|  
|Пустая ссылка (`Nothing` в Visual Basic)|Пустой <xref:System.ComponentModel.IBindingList> объектов. Добавление элемента списка присваивается тип добавляемого элемента.|  
|Пустая ссылка (`Nothing` в Visual Basic) с <xref:System.Windows.Forms.BindingSource.DataMember%2A> значение|Не поддерживается; вызывает <xref:System.ArgumentException>.|  
|Тип списка не или объект типа «T»|Пустой <xref:System.ComponentModel.IBindingList> типа «T».|  
|Экземпляр массива|<xref:System.ComponentModel.IBindingList> Содержащий элементы массива.|  
|<xref:System.Collections.IEnumerable> экземпляр|<xref:System.ComponentModel.IBindingList> Содержащий <xref:System.Collections.IEnumerable> элементов|  
|Экземпляр списка, содержащий тип «T»|<xref:System.ComponentModel.IBindingList> Экземпляр, содержащий тип «T».|  
  
 Кроме того <xref:System.Windows.Forms.BindingSource.DataSource%2A> можно задать для других типов списков, такие как <xref:System.ComponentModel.IListSource> и <xref:System.ComponentModel.ITypedList>и <xref:System.Windows.Forms.BindingSource> будет обрабатывать их соответствующим образом. В этом случае тип, содержащийся в списке должен иметь конструктор по умолчанию.  
  
### <a name="bindingsource-as-an-ibindinglist"></a>BindingSource следующим IBindingList  
 <xref:System.Windows.Forms.BindingSource> Компонент предоставляет члены для доступа и обработки базовых данных как <xref:System.ComponentModel.IBindingList>. Ниже перечислены некоторые из этих членов.  
  
|Член|Описание|  
|------------|-----------------|  
|<xref:System.Windows.Forms.BindingSource.List%2A> свойство;|Получает список, полученный в результате вычисления <xref:System.Windows.Forms.BindingSource.DataSource%2A> или <xref:System.Windows.Forms.BindingSource.DataMember%2A> свойства.|  
|<xref:System.Windows.Forms.BindingSource.AddNew%2A> метод|Добавляет новый элемент в базовый список. Применяется к источникам данных, которые реализуют <xref:System.ComponentModel.IBindingList> интерфейс и позволяют добавлять элементы (т. е <xref:System.Windows.Forms.BindingSource.AllowNew%2A> свойству `true`).|  
  
### <a name="custom-item-creation"></a>Создание пользовательских элементов  
 Можно обрабатывать <xref:System.Windows.Forms.BindingSource.AddingNew> событие, чтобы предоставить свою собственную логику создания элементов. <xref:System.Windows.Forms.BindingSource.AddingNew> Событие возникает перед добавлением нового объекта <xref:System.Windows.Forms.BindingSource>. Это событие возникает после <xref:System.Windows.Forms.BindingSource.AddNew%2A> вызывается метод, но перед добавлением нового элемента в базовый список. Обрабатывая это событие, можно указать поведение создания пользовательского элемента не на основе <xref:System.Windows.Forms.BindingSource> класса. Дополнительные сведения см. в разделе [Как Настройка добавления элемента с помощью компонента BindingSource в Windows Forms](how-to-customize-item-addition-with-the-windows-forms-bindingsource.md).  
  
### <a name="transactional-item-creation"></a>Создание транзакционных элементов  
 <xref:System.Windows.Forms.BindingSource> Компонент реализует <xref:System.ComponentModel.ICancelAddNew> интерфейс, который позволяет создавать транзакционные элементы. После элемента условно создается с помощью вызова <xref:System.Windows.Forms.BindingSource.AddNew%2A>, добавление может зафиксировать или откатить назад, одним из следующих способов:  
  
-   <xref:System.ComponentModel.ICancelAddNew.EndNew%2A> Метод явным образом подтверждает отложенное добавление.  
  
-   Выполнение другой операции коллекции, такие как вставки, удаления или перемещения, неявно фиксируется ожидающего добавления.  
  
-   <xref:System.ComponentModel.ICancelAddNew.CancelNew%2A> Метод приведет к откату ожидающего добавления Если метод не уже была зафиксирована.  
  
### <a name="ienumerable-support"></a>Поддержка интерфейса IEnumerable  
 <xref:System.Windows.Forms.BindingSource> Компонент позволяет привязывать элементы управления к <xref:System.Collections.IEnumerable> источников данных. С этим компонентом можно привязать к источнику данных такие как <xref:System.Data.SqlClient.SqlDataReader?displayProperty=nameWithType>.  
  
 Когда <xref:System.Collections.IEnumerable> источник данных будет назначен <xref:System.Windows.Forms.BindingSource> компонента, <xref:System.Windows.Forms.BindingSource> создает <xref:System.ComponentModel.IBindingList> и добавляет содержимое <xref:System.Collections.IEnumerable> источника данных в списке.  
  
### <a name="design-time-support"></a>Поддержка времени разработки  
 Некоторые типы объектов не может создаваться во время разработки, например объекты, созданные на основе класса фабрики или объектов, возвращаемых веб-службой. Иногда необходимо привязать к элементам управления для этих типов во время разработки, несмотря на то, что отсутствует объект в памяти, к которому можно привязать к элементам управления. Например, может потребоваться пометить заголовки столбцов из <xref:System.Windows.Forms.DataGridView> управления имена открытых свойств пользовательского типа.  
  
 Для поддержки этого сценария <xref:System.Windows.Forms.BindingSource> компонент поддерживает привязку к <xref:System.Type>. При назначении <xref:System.Type> для <xref:System.Windows.Forms.BindingSource.DataSource%2A> свойство, <xref:System.Windows.Forms.BindingSource> компонент создает пустой <xref:System.ComponentModel.BindingList%601> из <xref:System.Type> элементов. Все элементы управления, можно впоследствии привязку к <xref:System.Windows.Forms.BindingSource> компонент будут отображаться оповещения о наличии свойств или схемы данного типа, во время разработки или во время выполнения. Дополнительные сведения см. в разделе [Как Привязка элемента управления Windows Forms к типу](how-to-bind-a-windows-forms-control-to-a-type.md).  
  
### <a name="static-listbindinghelper-methods"></a>ListBindingHelper статические методы  
 <xref:System.Windows.Forms.BindingContext?displayProperty=nameWithType>, <xref:System.Windows.Forms.CurrencyManager?displayProperty=nameWithType>, И <xref:System.Windows.Forms.BindingSource> типы всех общую логику общую папку для создания списка из `DataSource` / `DataMember` пары. Кроме того, эта общая логика открыта для использования авторами элемента управления и другими третьими лицами, в следующем `static` методы:  
  
-   <xref:System.Windows.Forms.ListBindingHelper.GetListItemProperties%2A>  
  
-   <xref:System.Windows.Forms.ListBindingHelper.GetList%2A>.  
  
-   <xref:System.Windows.Forms.ListBindingHelper.GetListName%2A>  
  
-   <xref:System.Windows.Forms.ListBindingHelper.GetListItemType%2A>  
  
### <a name="sorting-and-filtering-with-the-ibindinglistview-interface"></a>Сортировка и фильтрация с использованием IBindingListView-интерфейс  
 <xref:System.Windows.Forms.BindingSource> Компонент реализует <xref:System.ComponentModel.IBindingListView> интерфейс, который расширяет <xref:System.ComponentModel.IBindingList> интерфейс. <xref:System.ComponentModel.IBindingList> Предлагает сортировке одного столбца и <xref:System.ComponentModel.IBindingListView> предлагает расширенную сортировки и фильтрации. С помощью <xref:System.ComponentModel.IBindingListView>, можно сортировать и фильтровать элементы в источнике данных, если источник данных, также реализует один из этих интерфейсов. <xref:System.Windows.Forms.BindingSource> Компонент не предоставляет справочную реализацию этих членов. Вместо этого звонки передаются в базовый список.  
  
 В следующей таблице описаны свойства, которые можно использовать для сортировки и фильтрации.  
  
|Член|Описание|  
|------------|-----------------|  
|<xref:System.Windows.Forms.BindingSource.Filter%2A> свойство;|Если источником данных является <xref:System.ComponentModel.IBindingListView>, то возвращает или задает выражение, используемое для фильтрации просматриваемых строк.|  
|<xref:System.Windows.Forms.BindingSource.Sort%2A> свойство;|Если источником данных является <xref:System.ComponentModel.IBindingList>, то возвращает или задает имя столбца, используемого для сортировки, и порядок сортировки.<br /><br /> -или-<br /><br /> Если источником данных является <xref:System.ComponentModel.IBindingListView> и поддерживается Расширенная сортировка, получает имя столбца, используемого для сортировки и порядок сортировки|  
  
### <a name="integration-with-bindingnavigator"></a>Интеграция с BindingNavigator  
 Можно использовать <xref:System.Windows.Forms.BindingSource> компонента для привязки любого элемента управления Windows Forms к источнику данных, но <xref:System.Windows.Forms.BindingNavigator> элемент управления предназначен специально для работы с <xref:System.Windows.Forms.BindingSource> компонента. <xref:System.Windows.Forms.BindingNavigator> Управления предоставляет пользовательский интерфейс для управления <xref:System.Windows.Forms.BindingSource> компонента текущего элемента. По умолчанию <xref:System.Windows.Forms.BindingNavigator> управления содержит кнопки, которые соответствуют методам навигации на <xref:System.Windows.Forms.BindingSource> компонента. Дополнительные сведения см. в разделе [Как Навигация по набору данных с помощью элемента управления BindingNavigator в Windows Forms](how-to-navigate-data-with-the-windows-forms-bindingnavigator-control.md).  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.BindingSource>
- <xref:System.Windows.Forms.BindingNavigator>
- [Общие сведения о компоненте BindingSource](bindingsource-component-overview.md)
- [BindingNavigator — элемент управления](bindingnavigator-control-windows-forms.md)
- [Привязка данных Windows Forms](../windows-forms-data-binding.md)
- [Элементы управления для использования в формах Windows Forms](controls-to-use-on-windows-forms.md)
- [Практическое руководство. Связывание элемента управления с типом в Windows Forms](how-to-bind-a-windows-forms-control-to-a-type.md)
- [Практическое руководство. Отражения в элементе управления данных, которые обновились в источнике, с использованием компонента BindingSource в Windows Forms](reflect-data-source-updates-in-a-wf-control-with-the-bindingsource.md)
