---
title: Области видимости имен XAML в WPF
ms.date: 03/30/2017
helpviewer_keywords:
- namescopes [WPF]
- styles [WPF], namescopes in
- templates [WPF], namescopes in
- APIs [WPF], name-related
- name-related APIs
- XAML [WPF], namescopes
- classes [WPF], FrameworkContentElement
ms.assetid: 52bbf4f2-15fc-40d4-837b-bb4c21ead7d4
ms.openlocfilehash: a46942188fd417b46ba4feb44d436800e1362098
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59225798"
---
# <a name="wpf-xaml-namescopes"></a>Области видимости имен XAML в WPF
Области имен XAML — это понятие, которое идентифицирует объекты, определенные в XAML. Имена из области имен XAML можно использовать для установления связей между именами объектов, определенными в XAML, и эквивалентными им экземплярами из дерева объектов. Области имен XAML в управляемом коде WPF, как правило, создаются при загрузке отдельных корневых страниц XAML для приложения XAML. Области видимости имен XAML как программируемые объекты определяются <xref:System.Windows.Markup.INameScope> и реализуются также посредством практического класса <xref:System.Windows.NameScope>.  

<a name="Namescopes_in_Loaded_XAML_Applications"></a>   
## <a name="namescopes-in-loaded-xaml-applications"></a>Области имен в загруженных приложениях XAML  
 В более широком контексте программирования или информатики в концепции программирования включается принцип уникального идентификатора или имени, которое можно использовать для доступа к объекту. В системах, где используются идентификаторы или имена, область имен определяет границы, в пределах которых процесс или технология ищет объект с запрошенным именем, или границы, в пределах которых применяются уникальные имена. Эти общие принципы действительны и для областей имен XAML. В WPF области имен XAML создаются в корневом элементе страницы XAML при загрузке страницы. Каждое имя, указанное внутри страницы XAML, начиная с корневой страницы, добавляется в соответствующую область имен XAML.  
  
 В WPF XAML, элементы, являющиеся общими корневыми элементами (такие как <xref:System.Windows.Controls.Page>, и <xref:System.Windows.Window>) всегда управляют областью видимости имен XAML. Если такой элемент, как <xref:System.Windows.FrameworkElement> или <xref:System.Windows.FrameworkContentElement> является корневым элементом страницы в разметке, XAML процессор добавляет <xref:System.Windows.Controls.Page> неявно root, чтобы <xref:System.Windows.Controls.Page> можно указать область видимости имен XAML рабочего.  
  
> [!NOTE]
>  Область имен XAML создается для рабочего приложения XAML при выполнении действий сборки WPF, даже если атрибуты `Name` и `x:Name` не определены в элементах разметки XAML.  
  
 При попытке использования одного и того же имени дважды в любой области имен XAML будет вызвано исключение. Для кода XAML системы WPF, который содержит код программной части и является компонентом скомпилированного приложения, во время первоначальной компиляции разметки при создании сформированного класса для страницы вызывается исключение при выполнении действий сборки WPF. Для кода XAML, разметка которого не скомпилирована действием сборки, исключения, связанные с проблемами области имен XAML, могут вызываться при загрузке кода XAML. Разработчики XAML должны также учитывать возможность возникновения проблем с областью имен XAML во время разработки.  
  
### <a name="adding-objects-to-runtime-object-trees"></a>Добавление объектов в деревья объектов среды выполнения  
 Область имен XAML системы WPF создается и определяется в момент синтаксического анализа кода XAML. Если объект добавляется в дерево объектов уже после того, как выполнен синтаксический анализ кода XAML, сформировавшего это дерево, значение `Name` или `x:Name` нового объекта не приводит к автоматическому обновлению сведений из области имен XAML. Чтобы добавить имя для объекта в области видимости имен XAML WPF после загрузки XAML, необходимо вызвать соответствующую реализацию <xref:System.Windows.Markup.INameScope.RegisterName%2A> на объект, который определяет область видимости имен XAML, который обычно является корневой страницы XAML. Если имя не зарегистрирован, добавленный объект нельзя ссылаться по имени через методы например <xref:System.Windows.FrameworkElement.FindName%2A>, и вы не может использовать это имя для анимации.  
  
 Является наиболее распространенным сценарием для разработчиков приложений, который будет использоваться <xref:System.Windows.FrameworkElement.RegisterName%2A> для регистрации имен в области видимости имен XAML в текущем корне страницы. <xref:System.Windows.FrameworkElement.RegisterName%2A> является частью важных сценария для раскадровок, целевых объектов для анимации. Дополнительные сведения см. в разделе [Общие сведения о Storyboard](../graphics-multimedia/storyboards-overview.md).  
  
 При вызове метода <xref:System.Windows.FrameworkElement.RegisterName%2A> объект, отличный от объекта, который определяет область видимости имен XAML, имя по-прежнему регистрируется в области видимости имен XAML, вызывающего объекта, находящееся в, как если бы Вы вызвали <xref:System.Windows.FrameworkElement.RegisterName%2A> на область видимости имен XAML, определение объекта.  
  
### <a name="xaml-namescopes-in-code"></a>Области имен XAML в коде  
 Вы можете создавать и использовать области имен XAML в коде. Интерфейсы API и понятия, которые применяются при создании областей имен XAML, совпадают с применяемыми в чистом коде, так как обработчик XAML для WPF использует эти API и понятия при обработке самого кода XAML. Они существуют в основном для поиска объектов по имени в дереве объектов, которое, как правило, частично или полностью задано в XAML.  
  
 Для приложений, создаваемых программным путем, а не из загруженного XAML, необходимо реализовать объект, который определяет область видимости имен XAML <xref:System.Windows.Markup.INameScope>, или быть <xref:System.Windows.FrameworkElement> или <xref:System.Windows.FrameworkContentElement> производного класса, чтобы поддерживать создание области видимости имен XAML на его экземпляры.  
  
 Также для любого элемента, не загруженного и не обработанного обработчиком XAML, область имен XAML для объекта не создается и не инициализируется по умолчанию. Необходимо явным образом создать область имен XAML для любого объекта, в котором впоследствии требуется регистрировать имена. Чтобы создать область имен XAML, вызовите статический <xref:System.Windows.NameScope.SetNameScope%2A> метод. Укажите объект, которому будет принадлежать его как `dependencyObject` параметра, а новые <xref:System.Windows.NameScope.%23ctor%2A> вызов конструктора как `value` параметр.  
  
 Если объект, предоставленный как `dependencyObject` для <xref:System.Windows.NameScope.SetNameScope%2A> не <xref:System.Windows.Markup.INameScope> реализации <xref:System.Windows.FrameworkElement> или <xref:System.Windows.FrameworkContentElement>, вызов <xref:System.Windows.FrameworkElement.RegisterName%2A> для любых дочерних элементов не окажет никакого воздействия. Если вам не удается создать новую область видимости имен XAML явно, то вызывает для <xref:System.Windows.FrameworkElement.RegisterName%2A> приведет к появлению исключения.  
  
 Пример использования интерфейсов API для области имен XAML в коде см. в разделе [Определение пространства имен](../graphics-multimedia/how-to-define-a-name-scope.md).  
  
<a name="Namescopes_in_Styles_and_Templates"></a>   
## <a name="xaml-namescopes-in-styles-and-templates"></a>Области имен XAML в стилях и шаблонах  
 Стили и шаблоны WPF позволяют повторно использовать и применять содержимое простым и понятным способом. Однако стили и шаблоны могут также включать элементы с именами XAML, определенными на уровне шаблона. Затем один и тот же шаблон может использоваться несколько раз на странице. По этой причине стили и шаблоны определяют свои собственные области имен XAML независимо от расположения в дереве объектов, где применяется стиль или шаблон.  
  
 Рассмотрим следующий пример.  
  
 [!code-xaml[XamlOvwSupport#NameScopeTemplates](~/samples/snippets/csharp/VS_Snippets_Wpf/XAMLOvwSupport/CSharp/page6.xaml#namescopetemplates)]  
  
 Здесь один тот же шаблон применяется к двум разным кнопкам. Если у шаблонов не было дискретных областей имен XAML, имя `TheBorder`, используемое в шаблоне, вызовет конфликт имен в области имен XAML. Каждый экземпляр шаблона имеет свою собственную область имен XAML, поэтому в данном примере каждая область имен XAML экземпляра шаблона будет содержать ровно одно имя.  
  
 Стили также определяют собственные области имен XAML, в основном поэтому части раскадровок могут иметь присвоенные индивидуальные имена. Эти имена включают конкретные расширения функциональности элемента управления, которые предназначены для элементов с таким именем, даже если шаблон был переопределен при настройке элемента управления.  
  
 Из-за независимых областей имен XAML поиск именованных элементов в шаблоне является более затратной задачей, чем поиск нешаблонного именованного элемента на странице. Сначала необходимо определить применяемый шаблон путем получения <xref:System.Windows.Controls.Control.Template%2A> значения свойства элемента управления, где применяется шаблон. Затем вызывается версия шаблона <xref:System.Windows.FrameworkTemplate.FindName%2A>, передающая элемент управления, в котором шаблон применяется в качестве второго параметра.  
  
 Если вы являетесь автором элемента управления, и вы создаете соглашение, в котором конкретный именованный элемент в примененном шаблоне является целью для поведения, определенные самим элементом управления, можно использовать <xref:System.Windows.FrameworkElement.GetTemplateChild%2A> метода из кода реализации элемента управления. <xref:System.Windows.FrameworkElement.GetTemplateChild%2A> Метод защищен, поэтому только автор элемента управления имеет доступ к нему.  
  
 При работе с в шаблоне и требуется получить область имен XAML, где применяется шаблон, получите значение <xref:System.Windows.FrameworkElement.TemplatedParent%2A>, а затем вызвать <xref:System.Windows.FrameworkElement.FindName%2A> существует. В качестве примера работы в шаблоне можно привести ситуацию, когда пишется реализация обработчика событий, в котором событие будет вызвано из элемента в примененном шаблоне.  
  
<a name="Namescopes_and_Name_related_APIs"></a>   
## <a name="xaml-namescopes-and-name-related-apis"></a>Области имен XAML и интерфейсы API, связанные с именами  
 <xref:System.Windows.FrameworkElement> имеет <xref:System.Windows.FrameworkElement.FindName%2A>, <xref:System.Windows.FrameworkElement.RegisterName%2A> и <xref:System.Windows.FrameworkElement.UnregisterName%2A> методы. Если объект, для которого вызываются эти методы, имеет собственную область имен XAML, то методы вызывают методы соответствующей области имен XAML. В противном случае выполняется проверка того, владеет ли родительский элемент областью имен XAML и этот процесс продолжается рекурсивно до тех пор, пока область имен XAML не будет найдена (из-за того что поведение обработчика XAML гарантирует наличие области имен XAML в корне). <xref:System.Windows.FrameworkContentElement> имеет аналогичное поведение, за исключением, не <xref:System.Windows.FrameworkContentElement> может содержать область видимости имен XAML. Методы существуют в <xref:System.Windows.FrameworkContentElement> , чтобы вызовы могут перенаправляться в конечном счете <xref:System.Windows.FrameworkElement> родительского элемента.  
  
 <xref:System.Windows.NameScope.SetNameScope%2A> используется для сопоставления новой области видимости имен XAML с существующим объектом. Вы можете вызвать <xref:System.Windows.NameScope.SetNameScope%2A> более одного раза Чтобы сбросить или очистить XAML области видимости имен, но это не является распространенным вариантом применения. Кроме того <xref:System.Windows.NameScope.GetNameScope%2A> обычно не используется из кода.  
  
### <a name="xaml-namescope-implementations"></a>Реализации области имен XAML  
 Следующие классы реализуют <xref:System.Windows.Markup.INameScope> напрямую:  
  
-   <xref:System.Windows.NameScope>  
  
-   <xref:System.Windows.Style>  
  
-   <xref:System.Windows.ResourceDictionary>  
  
-   <xref:System.Windows.FrameworkTemplate>  
  
 <xref:System.Windows.ResourceDictionary> не используйте имена XAML или области видимости имен; он использует ключи вместо этого, так как он является реализацией словаря. Единственная причина, по которой <xref:System.Windows.ResourceDictionary> реализует <xref:System.Windows.Markup.INameScope> — что он может вызывать исключения в пользовательском коде, которые помогают уточнить различие между true области видимости имен XAML и как <xref:System.Windows.ResourceDictionary> обрабатывает клавиши, а также чтобы убедиться, что области видимости имен XAML не применяются к <xref:System.Windows.ResourceDictionary> родительскими элементами.  
  
 <xref:System.Windows.FrameworkTemplate> и <xref:System.Windows.Style> реализовать <xref:System.Windows.Markup.INameScope> через явные определения интерфейса. Явные реализации позволяют этим областям видимости имен XAML функционировать традиционно, когда они доступны через <xref:System.Windows.Markup.INameScope> интерфейса, как области видимости имен XAML передаются по WPF внутренние процессы. Но явные определения интерфейсов не являются частью обычной области API <xref:System.Windows.FrameworkTemplate> и <xref:System.Windows.Style>, так как редко бывает нужно вызывать <xref:System.Windows.Markup.INameScope> методы <xref:System.Windows.FrameworkTemplate> и <xref:System.Windows.Style> напрямую, а вместо этого используется другой интерфейс API Например, <xref:System.Windows.FrameworkElement.GetTemplateChild%2A>.  
  
 Следующие классы определяют свои собственные области видимости имен XAML, с помощью <xref:System.Windows.NameScope?displayProperty=nameWithType> вспомогательный класс и подключении к его реализации области имен XAML через <xref:System.Windows.NameScope.NameScope%2A?displayProperty=nameWithType> вложенного свойства зависимостей:  
  
-   <xref:System.Windows.FrameworkElement>  
  
-   <xref:System.Windows.FrameworkContentElement>  
  
## <a name="see-also"></a>См. также

- [Пространства имен XAML и сопоставление пространств имен для WPF XAML](xaml-namespaces-and-namespace-mapping-for-wpf-xaml.md)
- [Директива x:Name](../../xaml-services/x-name-directive.md)
