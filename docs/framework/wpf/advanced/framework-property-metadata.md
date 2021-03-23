---
title: Метаданные свойств среды
ms.date: 03/30/2017
helpviewer_keywords:
- metadata [WPF], framework properties
- framework property metadata [WPF]
ms.assetid: 9962f380-b885-4b61-a62e-457397083fea
ms.openlocfilehash: 2a20e5a2bdbcbb36f6f06bbbadb2a46743ca5eba
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59314702"
---
# <a name="framework-property-metadata"></a>Метаданные свойств среды
Параметры метаданных свойств среды сообщаются для свойств элементов объектов, которые, как считается, в архитектуре [!INCLUDE[TLA#tla_winclient](../../../../includes/tlasharptla-winclient-md.md)] находятся на уровне среды WPF. В целом привязка к уровню среды WPF подразумевает, что такие функции, как отрисовка, привязка данных и уточнение системных свойств, обрабатываются в презентации WPF [!INCLUDE[TLA2#tla_api#plural](../../../../includes/tla2sharptla-apisharpplural-md.md)] и исполняемых файлах. Метаданные свойств среды запрашиваются этими системами для определения функциональных характеристик конкретных свойств элемента.  

<a name="prerequisites"></a>   
## <a name="prerequisites"></a>Предварительные требования  
 Предполагается, что вы имеете представление о свойствах зависимостей с точки зрения потребителя существующих свойств зависимостей в классах [!INCLUDE[TLA#tla_winclient](../../../../includes/tlasharptla-winclient-md.md)] и ознакомились с разделом [Общие сведения о свойствах зависимостей](dependency-properties-overview.md). Вам следует также ознакомиться с разделом [Метаданные свойства зависимости](dependency-property-metadata.md).  
  
<a name="What_Is_Communicated_by_Framework_Property"></a>   
## <a name="what-is-communicated-by-framework-property-metadata"></a>Передаваемые сведения в метаданных свойств среды  
 Метаданные свойств среды можно разделить на следующие категории.  
  
-   Передающие свойства макета, влияющие на элемент (<xref:System.Windows.FrameworkPropertyMetadata.AffectsArrange%2A>, <xref:System.Windows.FrameworkPropertyMetadata.AffectsMeasure%2A>, <xref:System.Windows.FrameworkPropertyMetadata.AffectsRender%2A>). Может задать эти флаги в метаданных, если свойство влияет на соответствующие аспекты, а также реализации <xref:System.Windows.FrameworkElement.MeasureOverride%2A>  /  <xref:System.Windows.FrameworkElement.ArrangeOverride%2A> методы в классе для предоставления поведение визуализации и сведения в макет система. Как правило, такая реализация проверяет аннулирование свойств в свойствах зависимости, где любое из этих свойств макета имело в метаданных свойств значение true, и только для таких аннулирований необходимо запросить новый проход макета.  
  
-   Передающие свойства макета, влияющие на родительский элемент элемента (<xref:System.Windows.FrameworkPropertyMetadata.AffectsParentArrange%2A>, <xref:System.Windows.FrameworkPropertyMetadata.AffectsParentMeasure%2A>). Некоторые примеры, где эти флаги установлены по умолчанию: <xref:System.Windows.Documents.FixedPage.Left%2A?displayProperty=nameWithType> и <xref:System.Windows.Documents.Paragraph.KeepWithNext%2A?displayProperty=nameWithType>.  
  
-   <xref:System.Windows.FrameworkPropertyMetadata.Inherits%2A>. По умолчанию свойства зависимости не наследуют значения. <xref:System.Windows.FrameworkPropertyMetadata.OverridesInheritanceBehavior%2A> позволяет перемещать путь наследования в визуальное дерево, которое необходимо для некоторых сценариев управления.  
  
    > [!NOTE]
    >  Термин "наследует" в контексте значений свойств имеет особое значение для свойств зависимостей; это означает, что дочерние элементы могут наследовать фактическое значение свойства зависимости от родительских элементов (это обусловлено возможностью системы свойств WPF на уровне среды WPF). Это не имеет ничего общего непосредственно с типом управляемого кода и наследованием элементов через производные типы. Подробнее см. в разделе [Наследование значения свойства](property-value-inheritance.md).  
  
-   Передающие характеристики привязки данных (<xref:System.Windows.FrameworkPropertyMetadata.IsNotDataBindable%2A>, <xref:System.Windows.FrameworkPropertyMetadata.BindsTwoWayByDefault%2A>). По умолчанию свойства зависимости в среде поддерживают привязку данных с односторонним поведением привязки. Привязку данных можно было бы отключить, если бы сценарий для нее отсутствовал в принципе (поскольку они должны быть гибкими и расширяемыми, однако примеров таких свойств в WPF [!INCLUDE[TLA2#tla_api#plural](../../../../includes/tla2sharptla-apisharpplural-md.md)] по умолчанию не много). Можно задать привязку для получения двусторонней привязки по умолчанию для свойств, объединяющих поведения элемента управления среди их составляющих (<xref:System.Windows.Controls.MenuItem.IsSubmenuOpen%2A> приведен пример) или если двусторонняя привязка является распространенным и ожидаемым сценарием для пользователей (<xref:System.Windows.Controls.TextBox.Text%2A> является примером). Изменение метаданных, связанных с привязкой данных, влияет только на значение по умолчанию; на уровне отдельных привязок это значение по умолчанию всегда можно изменить. Сведения о режимах связывания и связывании в целом см. в разделе [Общие сведения о связывании данных](../data/data-binding-overview.md).  
  
-   Отчеты, должны ли свойства приложения или службы, поддерживающие ведение журнала (<xref:System.Windows.FrameworkPropertyMetadata.Journal%2A>). Для общих элементов ведение журнала не включено по умолчанию, но оно выборочно включается для некоторых пользовательских элементов управления вводом. Это свойство предназначено для прочтения службами ведения журнала, включая реализацию WPF ведения журнала, и обычно устанавливается для пользовательских элементов управления, таких как пользовательский выбор в списках, который необходимо сохранять на протяжении нескольких шагов навигации. Сведения о журнале см. в разделе [Общие сведения о навигации](../app-development/navigation-overview.md).  
  
<a name="Reading_FrameworkPropertyMetadata"></a>   
## <a name="reading-frameworkpropertymetadata"></a>Чтение FrameworkPropertyMetadata  
 Каждое из свойств ссылки выше являются специальными свойствами, <xref:System.Windows.FrameworkPropertyMetadata> добавляет в свой непосредственный базовый класс <xref:System.Windows.UIPropertyMetadata>. Каждое из этих свойств будет иметь значение `false` по умолчанию. Запрос метаданных для свойства, где важно знать значение этих свойств следует попытаться привести возвращаемые метаданные к <xref:System.Windows.FrameworkPropertyMetadata>, а затем при необходимости проверить значения отдельных свойств.  
  
<a name="Specifying_Metadata"></a>   
## <a name="specifying-metadata"></a>Задание метаданных  
 Создавая новый экземпляр метаданных в целях применения метаданных к новой регистрации свойства зависимостей, вы можете выбрать класс метаданных для использования: базовый <xref:System.Windows.PropertyMetadata> или некоторые производного класса, такие как <xref:System.Windows.FrameworkPropertyMetadata>. В общем случае следует использовать <xref:System.Windows.FrameworkPropertyMetadata>, особенно в том случае, если свойство имеет любое взаимодействие с системой свойств и WPF функции, такие как макет и привязка данных. Другой вариант в более сложных сценариях является наследование от <xref:System.Windows.FrameworkPropertyMetadata> для создания собственных метаданных класс, с дополнительными сведениями отчетов они передаются в его члены. Или можно использовать <xref:System.Windows.PropertyMetadata> или <xref:System.Windows.UIPropertyMetadata> для передачи степени поддержки функций вашей реализации.  
  
 Для существующих свойств (<xref:System.Windows.DependencyProperty.AddOwner%2A> или <xref:System.Windows.DependencyProperty.OverrideMetadata%2A> вызова), необходимо всегда выполнять переопределение с типом метаданных, использованным исходной регистрацией.  
  
 Если вы создаете <xref:System.Windows.FrameworkPropertyMetadata> экземпляра, существует два способа заполнения метаданных значениями для определенных свойств, передающих характеристики свойств среды:  
  
1. Используйте <xref:System.Windows.FrameworkPropertyMetadata> сигнатура конструктора, который позволяет `flags` параметра. Этот параметр должен быть заполнен всеми нужными комбинированных значений из <xref:System.Windows.FrameworkPropertyMetadataOptions> флаги перечисления.  
  
2. Используйте одну из подписей без `flags` параметра, а затем настройте каждое логическое свойство отчетности на <xref:System.Windows.FrameworkPropertyMetadata> для `true` для каждого требуемого изменения характеристики. Если сделать это, необходимо настроить эти свойства до создания каких-либо элементов с этим свойством зависимости. Логические свойства доступны для чтения и записи, чтобы разрешить поведение, которое избегает параметра `flags` и все равно заполняет метаданные, однако метаданные необходимо эффективно паковать, прежде чем использовать свойство. Таким образом, попытка задать свойства после запроса метаданных будет недопустимой операцией.  
  
<a name="Framework_Property_Metadata_Merge_Behavior"></a>   
## <a name="framework-property-metadata-merge-behavior"></a>Поведение слияния метаданных свойств среды  
 При переопределении метаданных свойств среды различные характеристики метаданных объединяются или заменяют друг друга.  
  
-   <xref:System.Windows.PropertyMetadata.PropertyChangedCallback%2A> объединяются. При добавлении нового <xref:System.Windows.PropertyMetadata.PropertyChangedCallback%2A>, соответствующий обратный вызов хранится в метаданных. Если вы не укажете <xref:System.Windows.PropertyMetadata.PropertyChangedCallback%2A> в переопределении, значение <xref:System.Windows.PropertyMetadata.PropertyChangedCallback%2A> переходит в качестве ссылки из ближайшего родительского объекта, указанного в метаданных.  
  
-   Фактическое поведение системы свойств для <xref:System.Windows.PropertyMetadata.PropertyChangedCallback%2A> является то, что реализации для всех владельцев метаданных в иерархии сохраняются и добавляются в таблицу, в порядке выполнения системой свойств, что обратные вызовы наиболее глубоких производных классов Сначала вызывается. Наследуемые обратные вызовы выполняются только один раз и считается, что они принадлежат классу, разместившему их в метаданных.  
  
-   <xref:System.Windows.PropertyMetadata.DefaultValue%2A> заменяется. Если вы не укажете <xref:System.Windows.PropertyMetadata.PropertyChangedCallback%2A> в переопределении, значение <xref:System.Windows.PropertyMetadata.DefaultValue%2A> поступают из ближайшего родительского объекта, указанного в метаданных.  
  
-   <xref:System.Windows.PropertyMetadata.CoerceValueCallback%2A> реализации заменяются. При добавлении нового <xref:System.Windows.PropertyMetadata.CoerceValueCallback%2A>, соответствующий обратный вызов хранится в метаданных. Если вы не укажете <xref:System.Windows.PropertyMetadata.CoerceValueCallback%2A> в переопределении, значение <xref:System.Windows.PropertyMetadata.CoerceValueCallback%2A> переходит в качестве ссылки из ближайшего родительского объекта, указанного в метаданных.  
  
-   Поведение системы свойств является только <xref:System.Windows.PropertyMetadata.CoerceValueCallback%2A> вызывается в непосредственных метаданных. Ссылки на другие <xref:System.Windows.PropertyMetadata.CoerceValueCallback%2A> реализаций в иерархии сохраняются.  
  
-   Флаги <xref:System.Windows.FrameworkPropertyMetadataOptions> перечисления, объединяются в виде битовой операции OR.  Если указать <xref:System.Windows.FrameworkPropertyMetadataOptions>, исходные параметры не перезаписываются.  Чтобы изменить параметр, задайте соответствующее свойство на <xref:System.Windows.FrameworkPropertyMetadata>. Например если исходный <xref:System.Windows.FrameworkPropertyMetadata> набора объектов <xref:System.Windows.FrameworkPropertyMetadataOptions.NotDataBindable?displayProperty=nameWithType> флаг, можно изменить, установив <xref:System.Windows.FrameworkPropertyMetadata.IsNotDataBindable%2A?displayProperty=nameWithType> для `false`.  
  
 Это поведение реализуется <xref:System.Windows.FrameworkPropertyMetadata.Merge%2A>и могут переопределяться в производных классах метаданных.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.DependencyProperty.GetMetadata%2A>
- [Метаданные свойства зависимости](dependency-property-metadata.md)
- [Общие сведения о свойствах зависимости](dependency-properties-overview.md)
- [Пользовательские свойства зависимостей](custom-dependency-properties.md)
