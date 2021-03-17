---
title: Общие сведения о компоненте BindingSource
ms.date: 03/30/2017
helpviewer_keywords:
- Windows Forms, data binding
- controls [Windows Forms], binding to data
- BindingSource component [Windows Forms], about BindingSource component
- data binding [Windows Forms], BindingSource component
ms.assetid: be838caf-fcb0-4b68-827f-58b2c04b747f
ms.openlocfilehash: 2237ba71487afc132f9164243a664b277397ccfa
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59098641"
---
# <a name="bindingsource-component-overview"></a>Общие сведения о компоненте BindingSource
Компонент <xref:System.Windows.Forms.BindingSource> предназначен для упрощения процесса привязки элементов управления к источнику данных. Компонент <xref:System.Windows.Forms.BindingSource> выступает в качестве источника и канала передачи данных для привязки других элементов управления. Он реализует абстракцию подключения данных формы, перенаправляя команды к базовому списку данных. Кроме того, можно добавлять данные непосредственно в него, поэтому сам компонент выступает и в качестве источника данных.  
  
## <a name="bindingsource-component-as-an-intermediary"></a>Компонент BindingSource в качестве посредника  
 Компонент <xref:System.Windows.Forms.BindingSource> выступает в качестве источника данных для некоторых или всех элементов управления формы. В Visual Studio <xref:System.Windows.Forms.BindingSource> можно привязать к элементу управления с помощью параметра `DataBindings` свойство, доступное из **свойства** окна. Также см. раздел [Как Привязка элементов управления Windows Forms с компонентом BindingSource с помощью конструктора](bind-wf-controls-with-the-bindingsource.md).  
  
 Компонент <xref:System.Windows.Forms.BindingSource> можно привязать как к источникам простых данных, например одиночному свойству объекта или базовой коллекции, такому как <xref:System.Collections.ArrayList>, так и к источникам сложных данных, таким как таблица базы данных. Компонент <xref:System.Windows.Forms.BindingSource> является посредником, обеспечивающим привязку и управление валютой. Во время разработки или во время выполнения компонент <xref:System.Windows.Forms.BindingSource> можно привязать к источнику сложных данных, указав в качестве значений его свойств <xref:System.Windows.Forms.BindingSource.DataSource%2A> и <xref:System.Windows.Forms.BindingSource.DataMember%2A> базу данных и таблицу. На следующем рисунке показано, как компонент <xref:System.Windows.Forms.BindingSource> встраивается в существующую архитектуру привязки данных.  
  
 ![Источник привязки и архитектура привязки данных](./media/net-bindsrcdatabindarch.gif "NET_BindSrcDataBindArch")  
  
> [!NOTE]
>  Во время разработки некоторые действия, например перетаскивание таблицы базы данных из окна данных в пустую форму, приведут к созданию компонента <xref:System.Windows.Forms.BindingSource>, его привязке к базовому источнику данных и добавлению элементов управления данными в одной операции. См. также [Привязка элементов управления Windows Forms к данным в Visual Studio](/visualstudio/data-tools/bind-windows-forms-controls-to-data-in-visual-studio).  
  
## <a name="bindingsource-component-as-a-data-source"></a>Компонент BindingSource в качестве источника данных  
 Если начать добавлять элементы в компонент <xref:System.Windows.Forms.BindingSource> компонента без указания списка для привязки, то компонент будет действовать как источник данных в виде списка и примет эти элементы.  
  
 Кроме того, можно написать код, чтобы добавить пользовательскую функциональность "AddNew" с помощью события <xref:System.Windows.Forms.BindingSource.AddingNew>, которое возникает при вызове метода <xref:System.Windows.Forms.BindingSource.AddNew%2A> перед добавлением элемента в список. Дополнительные сведения см. в разделе [Архитектура компонента BindingSource](bindingsource-component-architecture.md).  
  
## <a name="navigation"></a>Навигация  
 Для пользователей, которым необходимо перемещение данных в форме, компонент  <xref:System.Windows.Forms.BindingNavigator> предоставляет возможность перемещения данных и управления ими совместно с компонентом <xref:System.Windows.Forms.BindingSource>. Дополнительные сведения см. в разделе [Элемент управления BindingNavigator](bindingnavigator-control-windows-forms.md).  
  
## <a name="data-manipulation"></a>Обработка данных  
 <xref:System.Windows.Forms.BindingSource> выступает в качестве <xref:System.Windows.Forms.CurrencyManager> для всех привязок и, таким образом, может предоставлять доступ к сведениям о валюте и положении в зависимости от источника данных. В следующей таблице показаны члены, предоставляемые компонентом <xref:System.Windows.Forms.BindingSource> для доступа и обработки базовых данных.  
  
|Член|Описание|  
|------------|-----------------|  
|<xref:System.Windows.Forms.BindingSource.Current%2A> свойство;|Возвращает текущий элемент источника данных.|  
|<xref:System.Windows.Forms.BindingSource.Position%2A> свойство;|Возвращает или задает текущую позицию в базовом списке.|  
|<xref:System.Windows.Forms.BindingSource.List%2A> свойство;|Возвращает список, который является результатом вычисления <xref:System.Windows.Forms.BindingSource.DataSource%2A> и <xref:System.Windows.Forms.BindingSource.DataMember%2A>. Если свойство <xref:System.Windows.Forms.BindingSource.DataMember%2A> не задано, то возвращается список, указанный в <xref:System.Windows.Forms.BindingSource.DataSource%2A>.|  
|<xref:System.Windows.Forms.BindingSource.Insert%2A> метод|Вставляет элемент в список по указанному индексу.|  
|<xref:System.Windows.Forms.BindingSource.RemoveCurrent%2A> метод|Удаляет текущий элемент из списка.|  
|<xref:System.Windows.Forms.BindingSource.EndEdit%2A> метод|Применяет ожидающие изменения к базовому источнику данных.|  
|<xref:System.Windows.Forms.BindingSource.CancelEdit%2A> метод|Отменяет текущую операцию редактирования.|  
|<xref:System.Windows.Forms.BindingSource.AddNew%2A> метод|Добавляет новый элемент в базовый список. Если источник данных реализует <xref:System.ComponentModel.IBindingList> и возвращает элемент из события <xref:System.Windows.Forms.BindingSource.AddingNew>, то  добавляется этот элемент. В противном случае запрос передается в метод <xref:System.ComponentModel.IBindingList.AddNew%2A> списка. Если базовый список не является <xref:System.ComponentModel.IBindingList>, элемент автоматически создается с помощью его общего конструктора по умолчанию.|  
  
## <a name="sorting-and-filtering"></a>Сортировка и фильтрация  
 Как правило, работа осуществляется с упорядоченным или отфильтрованным представлением источника данных. В следующей таблице показаны члены, предоставляемые компонентом <xref:System.Windows.Forms.BindingSource> источника данных.  
  
|Член|Описание|  
|------------|-----------------|  
|<xref:System.Windows.Forms.BindingSource.Sort%2A> свойство;|Если источником данных является <xref:System.ComponentModel.IBindingList>, то возвращает или задает имя столбца, используемого для сортировки, и порядок сортировки. Если источником данных является <xref:System.ComponentModel.IBindingListView> и поддерживается расширенная сортировка, то возвращает имена нескольких столбцов, используемых для сортировки, и порядок сортировки|  
|<xref:System.Windows.Forms.BindingSource.Filter%2A> свойство;|Если источником данных является <xref:System.ComponentModel.IBindingListView>, то возвращает или задает выражение, используемое для фильтрации просматриваемых строк.|  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.BindingSource>
- <xref:System.Windows.Forms.BindingNavigator>
- [Архитектура компонента BindingSource](bindingsource-component-architecture.md)
- [Компонент BindingSource](bindingsource-component.md)
- [BindingNavigator — элемент управления](bindingnavigator-control-windows-forms.md)
- [Привязка данных Windows Forms](../windows-forms-data-binding.md)
- [Элементы управления для использования в формах Windows Forms](controls-to-use-on-windows-forms.md)
