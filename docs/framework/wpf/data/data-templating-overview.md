---
title: Общие сведения о шаблонах данных
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- data binding [WPF], templates
- binding data [WPF], templates
- templates [WPF], data
- data templates [WPF]
ms.assetid: 0f4d9f8c-0230-4013-bd7b-e8e7fed01b4a
ms.openlocfilehash: 98fff9ba84f386e93549fa94fe84f7b2b0fff5fd
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59097555"
---
# <a name="data-templating-overview"></a>Общие сведения о шаблонах данных
Модель шаблонов данных WPF предоставляет большую гибкость при определении представления данных. Элементы управления WPF имеют встроенные функции для поддержки настройки представления данных. В этом разделе сначала демонстрируется определение <xref:System.Windows.DataTemplate> , а затем предоставляются другие возможности шаблонов данных, такие как выбор шаблона на основе пользовательской логики и поддержка отображения иерархических данных.  
  
<a name="Prerequisites"></a>   
## <a name="prerequisites"></a>Предварительные требования  
 В этом разделе рассматриваются функции шаблонов данных. Здесь отсутствуют общие сведения о понятиях привязки данных. Сведения о базовых концепциях привязки данных содержатся в разделе [Обзор привязки данных](data-binding-overview.md).  
  
 <xref:System.Windows.DataTemplate> является представлением данных и является одним из многих функций, предоставляемых моделью стилей и шаблонов WPF. Общие сведения о WPF Стилизация и использование шаблонов модели, например, как использовать <xref:System.Windows.Style> для задания свойств элементов управления, см. в разделе [Стилизация и использование шаблонов](../controls/styling-and-templating.md) раздела.  
  
 Кроме того, важно понимать `Resources`, которые по сути являются что включать объекты, такие как <xref:System.Windows.Style> и <xref:System.Windows.DataTemplate> для повторного использования. Дополнительные сведения о ресурсах см. в разделе [Ресурсы XAML](../advanced/xaml-resources.md).  
  
<a name="DataTemplating_Basic"></a>   
## <a name="data-templating-basics"></a>Основные сведения о шаблонах данных  
  
 Чтобы продемонстрировать важность <xref:System.Windows.DataTemplate> важно, давайте разберем пример привязки данных. В этом примере у нас есть <xref:System.Windows.Controls.ListBox> , привязанный к списку `Task` объектов. Каждому `Task` объекту соответствует `TaskName` (строка), `Description` (строка), `Priority` (int) и свойство типа `TaskType`, которое является `Enum` со значениями `Home` и `Work`.  
  
 [!code-xaml[DataTemplatingIntro_snip#Resources](~/samples/snippets/csharp/VS_Snippets_Wpf/DataTemplatingIntro_snip/CSharp/Window1.xaml#resources)]  
[!code-xaml[DataTemplatingIntro_snip#UI1](~/samples/snippets/csharp/VS_Snippets_Wpf/DataTemplatingIntro_snip/CSharp/Window1.xaml#ui1)]  
[!code-xaml[DataTemplatingIntro_snip#UI2](~/samples/snippets/csharp/VS_Snippets_Wpf/DataTemplatingIntro_snip/CSharp/Window1.xaml#ui2)]  
  
<a name="without_a_datatemplate"></a>   
### <a name="without-a-datatemplate"></a>Без шаблона данных DataTemplate  
 Без <xref:System.Windows.DataTemplate>наш <xref:System.Windows.Controls.ListBox> в данный момент выглядит следующим образом:  
  
 ![Снимок экрана шаблонов данных](./media/datatemplatingintro-fig1.png "DataTemplatingIntro_fig1")  
  
 Что происходит: без конкретных инструкций <xref:System.Windows.Controls.ListBox> по умолчанию вызывает `ToString` при попытке отображения объектов в коллекции. Таким образом Если `Task` переопределяет метод `ToString` метод, то <xref:System.Windows.Controls.ListBox> отображает строковое представление каждого исходного объекта в базовой коллекции.  
  
 Например, если класс `Task` переопределяет метод `ToString` таким образом, что `name` — поле для `TaskName` свойства:  
  
 [!code-csharp[DataTemplatingIntro_snip#ToString](~/samples/snippets/csharp/VS_Snippets_Wpf/DataTemplatingIntro_snip/CSharp/Data.cs#tostring)]
   
  
 Затем <xref:System.Windows.Controls.ListBox> выглядит следующим образом:  
  
 ![Снимок экрана шаблонов данных](./media/datatemplatingintro-fig2.png "DataTemplatingIntro_fig2")  
  
 Тем не менее это характеризуется ограниченностью и негибкостью. Кроме того, если выполняется привязка к даннымXML, невозможно переопределить `ToString`.  
  
<a name="defining_simple_datatemplate"></a>   
### <a name="defining-a-simple-datatemplate"></a>Определение простого шаблона DataTemplate  
 Решением является определение <xref:System.Windows.DataTemplate>. Один из способов это сделать, — присвоить <xref:System.Windows.Controls.ItemsControl.ItemTemplate%2A> свойство <xref:System.Windows.Controls.ListBox> для <xref:System.Windows.DataTemplate>. Укажите в вашей <xref:System.Windows.DataTemplate> , становится визуальной структурой вашего объекта данных. Следующие <xref:System.Windows.DataTemplate> достаточно прост. Мы зададим инструкции, которые каждый элемент отображается как три <xref:System.Windows.Controls.TextBlock> элементы внутри <xref:System.Windows.Controls.StackPanel>. Каждый <xref:System.Windows.Controls.TextBlock> элемент привязывается к свойству `Task` класса.  
  
 [!code-xaml[DataTemplatingIntro_snip#Inline](~/samples/snippets/csharp/VS_Snippets_Wpf/DataTemplatingIntro_snip/CSharp/Window1.xaml#inline)]  
  
 Базовые данные в примерах этого раздела — это совокупность объектов CLR. Если выполнить привязку к данным XML, основные понятия схожи, но есть незначительные синтаксические различия. Например, вместо того, `Path=TaskName`, необходимо установить <xref:System.Windows.Data.Binding.XPath%2A> для `@TaskName` (если `TaskName` является атрибутом вашего XML узла).  
  
 Теперь наши <xref:System.Windows.Controls.ListBox> выглядит следующим образом:  
  
 ![Снимок экрана шаблонов данных](./media/datatemplatingintro-fig3.png "DataTemplatingIntro_fig3")  
  
<a name="defining_datatemplate_as_a_resource"></a>   
### <a name="creating-the-datatemplate-as-a-resource"></a>Создание шаблона DataTemplate как ресурса  
 В приведенном выше примере мы определили <xref:System.Windows.DataTemplate> встроенный. Обычно его определяют в разделе ресурсов, чтобы его можно было повторно использовать, как в следующем примере:  
  
 [!code-xaml[DataTemplatingIntro_snip#R1](~/samples/snippets/csharp/VS_Snippets_Wpf/DataTemplatingIntro_snip/CSharp/Window1.xaml#r1)]  
[!code-xaml[DataTemplatingIntro_snip#AsResource](~/samples/snippets/csharp/VS_Snippets_Wpf/DataTemplatingIntro_snip/CSharp/Window1.xaml#asresource)]  
[!code-xaml[DataTemplatingIntro_snip#R2](~/samples/snippets/csharp/VS_Snippets_Wpf/DataTemplatingIntro_snip/CSharp/Window1.xaml#r2)]  
  
 Теперь вы можете использовать `myTaskTemplate` в качестве ресурса, как показано в следующем примере:  
  
 [!code-xaml[DataTemplatingIntro_snip#MyTaskTemplate](~/samples/snippets/csharp/VS_Snippets_Wpf/DataTemplatingIntro_snip/CSharp/Window1.xaml#mytasktemplate)]  
  
 Так как `myTaskTemplate` является ресурсом, теперь можно использовать его для других элементов управления, которые имеют свойства, которое принимает <xref:System.Windows.DataTemplate> типа. Как показано выше, для <xref:System.Windows.Controls.ItemsControl> объекты, такие как <xref:System.Windows.Controls.ListBox>, это <xref:System.Windows.Controls.ItemsControl.ItemTemplate%2A> свойство. Для <xref:System.Windows.Controls.ContentControl> объектов, это <xref:System.Windows.Controls.ContentControl.ContentTemplate%2A> свойство.  
  
<a name="Styling_DataType"></a>   
### <a name="the-datatype-property"></a>Свойство DataType  
 <xref:System.Windows.DataTemplate> Класс имеет <xref:System.Windows.DataTemplate.DataType%2A> свойство, которое очень похоже на <xref:System.Windows.Style.TargetType%2A> свойство <xref:System.Windows.Style> класса. Таким образом, вместо указания `x:Key` для <xref:System.Windows.DataTemplate> в приведенном выше примере можно сделать следующее:  
  
 [!code-xaml[DataTemplatingIntro_snip#DataType](~/samples/snippets/csharp/VS_Snippets_Wpf/DataTemplatingIntro_snip/CSharp/Window1.xaml#datatype)]  
  
 Это <xref:System.Windows.DataTemplate> автоматически применяется ко всем `Task` объектов. Обратите внимание, что в этом случае `x:Key` устанавливается неявно. Таким образом при назначении этого <xref:System.Windows.DataTemplate> `x:Key` значение, вы переопределяете явное `x:Key` и <xref:System.Windows.DataTemplate> не будет применяться автоматически.  
  
 При связывании <xref:System.Windows.Controls.ContentControl> на коллекцию `Task` объектов, <xref:System.Windows.Controls.ContentControl> не используйте указанные выше <xref:System.Windows.DataTemplate> автоматически. Это обусловлено привязки на <xref:System.Windows.Controls.ContentControl> требуется больше информации для различения ли вы хотите выполнить привязку ко всей коллекции или отдельные объекты. Если ваш <xref:System.Windows.Controls.ContentControl> отслеживает выбор <xref:System.Windows.Controls.ItemsControl> типа, можно задать <xref:System.Windows.Data.Binding.Path%2A> свойство <xref:System.Windows.Controls.ContentControl> привязка к "`/`" для указания, что вы заинтересованы в текущем элементе. Для примера см. [Выполнение привязки к коллекции и вывод сведений в зависимости от выделенного элемента](how-to-bind-to-a-collection-and-display-information-based-on-selection.md). В противном случае необходимо указать <xref:System.Windows.DataTemplate> явным образом задав <xref:System.Windows.Controls.ContentControl.ContentTemplate%2A> свойство.  
  
 <xref:System.Windows.DataTemplate.DataType%2A> Свойство особенно полезно при наличии <xref:System.Windows.Data.CompositeCollection> различных типов объектов данных. Пример см. в разделе [Реализация CompositeCollection](how-to-implement-a-compositecollection.md).  
  
<a name="adding_more_to_datatemplate"></a>   
## <a name="adding-more-to-the-datatemplate"></a>Добавление дополнительных данных в DataTemplate  
 В настоящее время данные содержат необходимую информацию, но определенно это можно улучшить. Давайте улучшим представление, добавив <xref:System.Windows.Controls.Border>, <xref:System.Windows.Controls.Grid>и некоторые <xref:System.Windows.Controls.TextBlock> элементы, описывающие данные, отображается.  
  
 [!code-xaml[DataTemplatingIntro#AddingMore](~/samples/snippets/xaml/VS_Snippets_Wpf/DataTemplatingIntro/xaml/window1.xaml#addingmore)]  
[!code-xaml[DataTemplatingIntro#AddingMore2](~/samples/snippets/xaml/VS_Snippets_Wpf/DataTemplatingIntro/xaml/window1.xaml#addingmore2)]  
  
 На следующем снимке экрана показан <xref:System.Windows.Controls.ListBox> с этим измененным <xref:System.Windows.DataTemplate>:  
  
 ![Снимок экрана шаблонов данных](./media/datatemplatingintro-fig4.png "DataTemplatingIntro_fig4")  
  
 Можно установить <xref:System.Windows.Controls.Control.HorizontalContentAlignment%2A> для <xref:System.Windows.HorizontalAlignment.Stretch> на <xref:System.Windows.Controls.ListBox> чтобы убедиться, что ширина элементов занимает все пространство:  
  
 [!code-xaml[DataTemplatingIntro_snip#Stretch](~/samples/snippets/csharp/VS_Snippets_Wpf/DataTemplatingIntro_snip/CSharp/Window1.xaml#stretch)]  
  
 С помощью <xref:System.Windows.Controls.Control.HorizontalContentAlignment%2A> свойство значение <xref:System.Windows.HorizontalAlignment.Stretch>, <xref:System.Windows.Controls.ListBox> теперь выглядит следующим образом:  
  
 ![Снимок экрана шаблонов данных](./media/datatemplatingintro-fig5.png "DataTemplatingIntro_fig5")  
  
<a name="DataTrigger_to_Apply_Property_Values"></a>   
### <a name="use-datatriggers-to-apply-property-values"></a>Использование триггеров данных для применения значений свойств  
 В настоящей презентации не говорится о том, является ли `Task` домашней задачей или офисной. Помните, что объект `Task` имеет свойство `TaskType` типа `TaskType`, который является перечислением со значениями `Home` и `Work`.  
  
 В следующем примере <xref:System.Windows.DataTrigger> задает <xref:System.Windows.Controls.Border.BorderBrush%2A> элемента с именем `border` для `Yellow` Если `TaskType` свойство `TaskType.Home`.  
  
 [!code-xaml[DataTemplatingIntro#DT](~/samples/snippets/xaml/VS_Snippets_Wpf/DataTemplatingIntro/xaml/window1.xaml#dt)]  
[!code-xaml[DataTemplatingIntro#DataTrigger](~/samples/snippets/xaml/VS_Snippets_Wpf/DataTemplatingIntro/xaml/window1.xaml#datatrigger)]  
[!code-xaml[DataTemplatingIntro#AddingMore2](~/samples/snippets/xaml/VS_Snippets_Wpf/DataTemplatingIntro/xaml/window1.xaml#addingmore2)]  
  
 Наше приложение теперь выглядит следующим образом. Домашние задачи отображаются с желтой границей, а офисные — с синей границей:  
  
 ![Снимок экрана шаблонов данных](./media/datatemplatingintro-fig6.png "DataTemplatingIntro_fig6")  
  
 В этом примере <xref:System.Windows.DataTrigger> использует <xref:System.Windows.Setter> для задания значения свойства. Классы триггера также имеют <xref:System.Windows.TriggerBase.EnterActions%2A> и <xref:System.Windows.TriggerBase.ExitActions%2A> свойства, позволяющие запускать ряд действий, например анимацию. Кроме того, имеется также <xref:System.Windows.MultiDataTrigger> , позволяющий применять изменения на основе значений нескольких свойств с привязкой к данным.  
  
 Альтернативным способом достижения такого же эффекта является привязка <xref:System.Windows.Controls.Border.BorderBrush%2A> свойства `TaskType` и использование преобразователя значения для возврата цвета на основе `TaskType` значение. Создание вышеупомянутого эффекта с помощью преобразователя является немного более эффективным с точки зрения производительности. Кроме того, создание собственных преобразователей обеспечивает большую гибкость, так как вы предоставляете свою собственную логику. В конечном счете выбор техники зависит от сценария и предпочтений. Сведения о том, как написать преобразователь см. в разделе <xref:System.Windows.Data.IValueConverter>.  
  
<a name="what_belongs_in_datatemplate"></a>   
### <a name="what-belongs-in-a-datatemplate"></a>Что входит в DataTemplate?  

В предыдущем примере мы разместили триггер в <xref:System.Windows.DataTemplate> с помощью <xref:System.Windows.DataTemplate>.<xref:System.Windows.DataTemplate.Triggers%2A> . <xref:System.Windows.Setter> Триггера задает значение свойства элемента ( <xref:System.Windows.Controls.Border> элемент), находится в пределах <xref:System.Windows.DataTemplate>. Тем не менее если свойства, ваш `Setters` интересует не являются свойствами элементов, которые находятся в текущем <xref:System.Windows.DataTemplate>, возможно, больше подойдет задание свойств с помощью <xref:System.Windows.Style> , предназначенная для <xref:System.Windows.Controls.ListBoxItem> класса (если элемент управления, связывании <xref:System.Windows.Controls.ListBox>). Например, если вы хотите, чтобы ваши <xref:System.Windows.Trigger> для анимации <xref:System.Windows.UIElement.Opacity%2A> значение элемента при наведении указателя мыши на элемент, определите триггеры <xref:System.Windows.Controls.ListBoxItem> стиля. Пример см. в разделе [Вводная часть примера стилизации и использования шаблонов](https://github.com/Microsoft/WPF-Samples/tree/master/Styles%20&%20Templates/IntroToStylingAndTemplating).
  
 Как правило, имейте в виду, что <xref:System.Windows.DataTemplate> , применяется к каждому созданного <xref:System.Windows.Controls.ListBoxItem> (Дополнительные сведения о том, как и где он фактически применяется см. в разделе <xref:System.Windows.Controls.ItemsControl.ItemTemplate%2A> страницы.). Ваш <xref:System.Windows.DataTemplate> отвечает только за презентацию и внешний вид объектов данных. В большинстве случаев все другие аспекты представления, например как элемент выглядит при его выборе или как <xref:System.Windows.Controls.ListBox> размещает элементы, не входящие в определение <xref:System.Windows.DataTemplate>. Пример см. в разделе [Стилизация и использование шаблонов для ItemsControl](#DataTemplating_ItemsControl).  
  
<a name="Styling_StyleSelection"></a>   
## <a name="choosing-a-datatemplate-based-on-properties-of-the-data-object"></a>Выбор DataTemplate на основе свойств объекта данных  
 В разделе [Свойство DataType](#Styling_DataType) мы говорили о том, что можно определить различные шаблоны данных для различных объектов данных. Это особенно полезно при наличии <xref:System.Windows.Data.CompositeCollection> различных типов или коллекций с элементами различных типов. В [использование триггеров данных для применения значений свойств](#DataTrigger_to_Apply_Property_Values) разделе было показано, что если у вас есть коллекция объектов данных одного типа можно создать <xref:System.Windows.DataTemplate> и затем использовать триггеры для применения изменений на основании значений свойств Каждый объект данных. Тем не менее, хотя триггеры позволяют применить значения свойств или запустить анимацию, они не предоставляют гибкость, достаточную для реконструкции структуры объектов данных. Некоторые сценарии могут потребовать создания различных <xref:System.Windows.DataTemplate> для данных объектов, которые имеют тот же тип, но разные свойства.  
  
 Например, если объект `Task` имеет значение `Priority` свойства `1`, вы можете задать совершенно другой вид для него, чтобы сделать его сигналом оповещения. В этом случае создается <xref:System.Windows.DataTemplate> для отображения с высоким приоритетом `Task` объектов. Давайте добавим следующий <xref:System.Windows.DataTemplate> в раздел ресурсов:  
  
 [!code-xaml[DataTemplatingIntro_snip#ImportantTemplate](~/samples/snippets/csharp/VS_Snippets_Wpf/DataTemplatingIntro_snip/CSharp/Window1.xaml#importanttemplate)]  
  
 Обратите внимание, что в этом примере используется <xref:System.Windows.DataTemplate>.<xref:System.Windows.FrameworkTemplate.Resources%2A> . Ресурсы, определенные в этом разделе, являются общими для элементов внутри <xref:System.Windows.DataTemplate>.  
  
 Чтобы задать логику выбирать, какие <xref:System.Windows.DataTemplate> для использования на основе `Priority` значение объекта данных, создать подкласс <xref:System.Windows.Controls.DataTemplateSelector> и переопределить <xref:System.Windows.Controls.DataTemplateSelector.SelectTemplate%2A> метод. В следующем примере <xref:System.Windows.Controls.DataTemplateSelector.SelectTemplate%2A> метод предоставляет логику для возвращения соответствующего шаблона на основе значения из `Priority` свойство. Возвращаемый шаблон находится в ресурсах <xref:System.Windows.Window> элемент.  
  
 [!code-csharp[DataTemplatingIntro_snip#DTSClass](~/samples/snippets/csharp/VS_Snippets_Wpf/DataTemplatingIntro_snip/CSharp/TaskListDataTemplateSelector.cs#dtsclass)]
   
  
 Затем можно объявить `TaskListDataTemplateSelector` как ресурс:  
  
 [!code-xaml[DataTemplatingIntro_snip#R1](~/samples/snippets/csharp/VS_Snippets_Wpf/DataTemplatingIntro_snip/CSharp/Window1.xaml#r1)]  
[!code-xaml[DataTemplatingIntro_snip#DTS](~/samples/snippets/csharp/VS_Snippets_Wpf/DataTemplatingIntro_snip/CSharp/Window1.xaml#dts)]  
[!code-xaml[DataTemplatingIntro_snip#R2](~/samples/snippets/csharp/VS_Snippets_Wpf/DataTemplatingIntro_snip/CSharp/Window1.xaml#r2)]  
  
 Для использования ресурса выбора шаблона, назначьте его <xref:System.Windows.Controls.ItemsControl.ItemTemplateSelector%2A> свойство <xref:System.Windows.Controls.ListBox>. <xref:System.Windows.Controls.ListBox> Вызовы <xref:System.Windows.Controls.DataTemplateSelector.SelectTemplate%2A> метод `TaskListDataTemplateSelector` для каждого элемента в базовой коллекции. Вызов передает объект данных в качестве параметра элемента. <xref:System.Windows.DataTemplate> , Возвращаемый метод применяется к объекту данных.  
  
 [!code-xaml[DataTemplatingIntro_snip#ItemTemplateSelector](~/samples/snippets/csharp/VS_Snippets_Wpf/DataTemplatingIntro_snip/CSharp/Window1.xaml#itemtemplateselector)]  
  
 С помощью выбора шаблона на месте <xref:System.Windows.Controls.ListBox> теперь выглядит следующим образом:  
  
 ![Снимок экрана шаблонов данных](./media/datatemplatingintro-fig7.png "DataTemplatingIntro_fig7")  

Это заключительный шаг нашего обсуждения данного примера. Полный пример см. в разделе [Вводная часть примера стилизации и использования шаблонов](https://github.com/Microsoft/WPF-Samples/tree/master/Data%20Binding/DataTemplatingIntro).

<a name="DataTemplating_ItemsControl"></a>   
## <a name="styling-and-templating-an-itemscontrol"></a>Стилизация и использование шаблонов для ItemsControl  
 Несмотря на то что <xref:System.Windows.Controls.ItemsControl> не является единственным типом элемента управления, который можно использовать <xref:System.Windows.DataTemplate> , это очень распространенный сценарий для привязки <xref:System.Windows.Controls.ItemsControl> в коллекцию. В [что входит в DataTemplate](#what_belongs_in_datatemplate) разделе мы рассмотрели, что определение вашего <xref:System.Windows.DataTemplate> должен быть только за презентационный уровень данных. Чтобы узнать, когда это не подходит для использования <xref:System.Windows.DataTemplate> важно понимать различные свойства стиля и шаблона, предоставляемые <xref:System.Windows.Controls.ItemsControl>. Следующий пример предназначен для демонстрации функции каждого из этих свойств. <xref:System.Windows.Controls.ItemsControl> В этом примере, привязан к той же `Tasks` коллекции, как показано в предыдущем примере. Для демонстрационных целей все стили и шаблоны в этом примере объявлены встроенными.  
  
 [!code-xaml[DataTemplatingIntro_snip#ItemsControlProperties](~/samples/snippets/csharp/VS_Snippets_Wpf/DataTemplatingIntro_snip/CSharp/Window1.xaml#itemscontrolproperties)]  
  
 Ниже приведен снимок экрана примера при его просмотре:  
  
 ![Снимок экрана примера ItemsControl](./media/databinding-itemscontrolproperties.png "DataBinding_ItemsControlProperties")  
  
 Обратите внимание, что вместо использования <xref:System.Windows.Controls.ItemsControl.ItemTemplate%2A>, можно использовать <xref:System.Windows.Controls.ItemsControl.ItemTemplateSelector%2A>. Пример см. в предыдущем разделе. Аналогичным образом, вместо использования <xref:System.Windows.Controls.ItemsControl.ItemContainerStyle%2A>, у вас есть возможность использовать <xref:System.Windows.Controls.ItemsControl.ItemContainerStyleSelector%2A>.  
  
 Два других относящихся к стилю свойства <xref:System.Windows.Controls.ItemsControl> , не отображаются, вот <xref:System.Windows.Controls.ItemsControl.GroupStyle%2A> и <xref:System.Windows.Controls.ItemsControl.GroupStyleSelector%2A>.  
  
<a name="DataTemplating_HeirarchicalDataTemplate"></a>   
## <a name="support-for-hierarchical-data"></a>Поддержка иерархических данных  
 Пока мы только рассматривали как привязывать и отображать одну коллекцию. Иногда встречается коллекция, содержащая другие коллекции. <xref:System.Windows.HierarchicalDataTemplate> Класс предназначен для использования с <xref:System.Windows.Controls.HeaderedItemsControl> типы для отображения таких данных. В следующем примере `ListLeagueList` является списком объектов `League`. Каждый объект `League` содержит `Name` и коллекцию объектов `Division`. Каждый `Division` содержит `Name` и коллекцию объектов `Team`, и каждый объект `Team` содержит `Name`.  
  
 [!code-xaml[HierarchicalDataTemplateSnippet#HDT](~/samples/snippets/csharp/VS_Snippets_Wpf/HierarchicalDataTemplateSnippet/CS/window1.xaml#hdt)]  
  
 Пример показывает, что с помощью <xref:System.Windows.HierarchicalDataTemplate>, можно отобразить данные списка, содержащего другие списки. Ниже приведен снимок экрана примера.  
  
 ![Снимок экрана примера HierarchicalDataTemplate](./media/databinding-hierarchicaldatatemplate.png "DataBinding_HierarchicalDataTemplate")  
  
## <a name="see-also"></a>См. также

- [Привязка данных](../advanced/optimizing-performance-data-binding.md)
- [Поиск элементов, созданных с использованием шаблона DataTemplate](how-to-find-datatemplate-generated-elements.md)
- [Стилизация и использование шаблонов](../controls/styling-and-templating.md)
- [Общие сведения о привязке данных](data-binding-overview.md)
- [Общие сведения о стилях заголовков столбцов GridView и шаблонах](../controls/gridview-column-header-styles-and-templates-overview.md)
