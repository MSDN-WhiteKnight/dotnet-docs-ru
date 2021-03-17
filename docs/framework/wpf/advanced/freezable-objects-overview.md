---
title: Общие сведения об объектах класса Freezable
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- Freezable objects [WPF], description
- unfreezing Freezable objects [WPF]
- classes [WPF], Freezable
ms.assetid: 89c71692-4f43-4057-b611-67c6a8a863a2
ms.openlocfilehash: 8df19e69ff3be06704878ea290a3f4a2997127eb
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59224269"
---
# <a name="freezable-objects-overview"></a>Общие сведения об объектах класса Freezable
В этом разделе описывается, как эффективно использовать и создавать <xref:System.Windows.Freezable> объекты, которые предоставляют специальные функции, которые могут помочь повысить производительность приложения. Объекты freezable примеры кисти, перья, преобразования, геометрии и анимации.  
  
<a name="whatisafreezable"></a>   
## <a name="what-is-a-freezable"></a>Что такое Freezable?  
 Объект <xref:System.Windows.Freezable> — это специальный тип объекта, имеющий два состояния: фиксированное и нефиксированное. Незафиксированный <xref:System.Windows.Freezable> ведет себя как любой другой объект. Зафиксированный <xref:System.Windows.Freezable> не может быть изменен.  
  
 Объект <xref:System.Windows.Freezable> предоставляет <xref:System.Windows.Freezable.Changed> событие, чтобы уведомлять наблюдателей об каких-либо изменений объекта. Замораживание <xref:System.Windows.Freezable> позволяет повысить его производительность, поскольку он больше не требуется тратить ресурсы на уведомления об изменениях. Зафиксированный <xref:System.Windows.Freezable> также может использоваться несколькими потоками, в отличие от незафиксированных <xref:System.Windows.Freezable> невозможно.  
  
 Несмотря на то что <xref:System.Windows.Freezable> класс имеет много приложений, наиболее <xref:System.Windows.Freezable> объекты в [!INCLUDE[TLA#tla_winclient](../../../../includes/tlasharptla-winclient-md.md)] связаны с графическая подсистема.  
  
 <xref:System.Windows.Freezable> Класс упрощает использование определенных объектов графических систем и может повысить производительность приложения. Примеры типов, которые наследуют от <xref:System.Windows.Freezable> включают <xref:System.Windows.Media.Brush>, <xref:System.Windows.Media.Transform>, и <xref:System.Windows.Media.Geometry> классы. Так как они содержат неуправляемые ресурсы, система должна отслеживать изменения этих объектов и затем обновить соответствующие им неуправляемые ресурсы, при наличии изменений в исходный объект. Даже если вы не меняете фактически объект графической системы, системы необходимо по-прежнему тратить часть его ресурсов, наблюдение за объектом, в случае, если изменить его.  
  
 Предположим, например, можно создать <xref:System.Windows.Media.SolidColorBrush> кисти и использовать его для рисования фона кнопки.  
  
 [!code-csharp[freezablesample_procedural#FrozenExamplePart1](~/samples/snippets/csharp/VS_Snippets_Wpf/freezablesample_procedural/CSharp/freezablesample.cs#frozenexamplepart1)]
 [!code-vb[freezablesample_procedural#FrozenExamplePart1](~/samples/snippets/visualbasic/VS_Snippets_Wpf/freezablesample_procedural/visualbasic/freezablesample.vb#frozenexamplepart1)]  
  
 При отображении кнопки [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] графическая подсистема использует сведения, предоставленные для закраски группы пикселей, которое необходимо создать внешний вид кнопки. Несмотря на то, что вы использовали Одноцветная кисть для описания того, как должен быть окрашен кнопки, сплошной цвет кисти фактически не выполняет заливку. Графическая система создает быстрые низкоуровневые объекты для кнопки и кисти, а это те объекты, которые отображаются на экране.  
  
 При изменении кисти, эти низкоуровневые объекты бы быть создан повторно. Класс freezable представляет, что дает возможность найти соответствующие объекты низкоуровневые и обновлять их при его изменении кисти. Если эта возможность включена, кисть, которая называется «незафиксированной».  
  
 Freezable <xref:System.Windows.Freezable.Freeze%2A> метод позволяет отключить данную возможность самостоятельного обновления. Этот метод можно использовать, чтобы сделать кисть «зафиксированной» или неизменяемым.  
  
> [!NOTE]
>  Не каждый объект Freezable может быть зафиксирован. Чтобы избежать возникновения <xref:System.InvalidOperationException>, проверьте значение свойства объекта Freezable <xref:System.Windows.Freezable.CanFreeze%2A> свойства, чтобы определить, является ли он быть зафиксирован перед фиксированием.  
  
 [!code-csharp[freezablesample_procedural#FrozenExamplePart2](~/samples/snippets/csharp/VS_Snippets_Wpf/freezablesample_procedural/CSharp/freezablesample.cs#frozenexamplepart2)]
 [!code-vb[freezablesample_procedural#FrozenExamplePart2](~/samples/snippets/visualbasic/VS_Snippets_Wpf/freezablesample_procedural/visualbasic/freezablesample.vb#frozenexamplepart2)]  
  
 Если вам больше не нужно изменять freezable, зафиксировать этот дает выигрыш в производительности. Если закрепить кисть, которая в этом примере, графическая система больше не потребуется отслеживать его изменения. Графическая система также может отправлять другие виды оптимизации, поскольку известно, что кисть, которая не изменится.  
  
> [!NOTE]
>  Для удобства объекты freezable остаются незафиксированными, пока вы явным образом замораживайте.  
  
<a name="frozenfreezables"></a>   
## <a name="using-freezables"></a>С помощью объектов Freezable  
 Использование незафиксированного freezable аналогично использованию любого другого типа объекта. В следующем примере цвет <xref:System.Windows.Media.SolidColorBrush> изменяется с желтого на красный после он используется для рисования фона кнопки. Графическая система работает незаметно для автоматического изменения кнопки с желтого на красный при очередном обновлении экрана.  
  
 [!code-csharp[freezablesample_procedural#UnFrozenExampleShort](~/samples/snippets/csharp/VS_Snippets_Wpf/freezablesample_procedural/CSharp/freezablesample.cs#unfrozenexampleshort)]
 [!code-vb[freezablesample_procedural#UnFrozenExampleShort](~/samples/snippets/visualbasic/VS_Snippets_Wpf/freezablesample_procedural/visualbasic/freezablesample.vb#unfrozenexampleshort)]  
  
### <a name="freezing-a-freezable"></a>Замораживание Freezable  
 Чтобы сделать <xref:System.Windows.Freezable> неизменяемым, необходимо вызвать его <xref:System.Windows.Freezable.Freeze%2A> метод. Когда вы закрепить объект, содержащий объекты freezable, эти объекты также закрепляются. Например, если зафиксировать <xref:System.Windows.Media.PathGeometry>, рисунки и сегменты будут зафиксированы.  
  
 Freezable **нельзя** зафиксировать, если одно из следующих условий:  
  
-   Объект имеет анимированные или свойства с привязкой к данным.  
  
-   Он имеет свойства, заданные на динамический ресурс. (См. в разделе [ресурсы XAML](xaml-resources.md) Дополнительные сведения о динамических ресурсов.)  
  
-   Он содержит <xref:System.Windows.Freezable> вложенные объекты, которые нельзя зафиксировать.  
  
 Если эти условия имеют значение false, и вы не собираетесь изменять <xref:System.Windows.Freezable>, то стоит зафиксировать, чтобы получить выигрыш в производительности, описанные ранее.  
  
 При вызове метода freezable <xref:System.Windows.Freezable.Freeze%2A> метод, он не может быть изменен. Попытка изменить зафиксированного объекта возникает <xref:System.InvalidOperationException> исключение. Следующий код создает исключение, так как выполняется попытка изменить кисть после она была зафиксирована.  
  
 [!code-csharp[freezablesample_procedural#ExceptionExample](~/samples/snippets/csharp/VS_Snippets_Wpf/freezablesample_procedural/CSharp/freezablesample.cs#exceptionexample)]
 [!code-vb[freezablesample_procedural#ExceptionExample](~/samples/snippets/visualbasic/VS_Snippets_Wpf/freezablesample_procedural/visualbasic/freezablesample.vb#exceptionexample)]  
  
 Чтобы избежать возникновения этого исключения, можно использовать <xref:System.Windows.Freezable.IsFrozen%2A> метод, чтобы определить, является ли <xref:System.Windows.Freezable> заморожен.  
  
 [!code-csharp[freezablesample_procedural#CheckIsFrozenExample](~/samples/snippets/csharp/VS_Snippets_Wpf/freezablesample_procedural/CSharp/freezablesample.cs#checkisfrozenexample)]
 [!code-vb[freezablesample_procedural#CheckIsFrozenExample](~/samples/snippets/visualbasic/VS_Snippets_Wpf/freezablesample_procedural/visualbasic/freezablesample.vb#checkisfrozenexample)]  
  
 В предыдущем примере кода, изменяемая копия была сделана зафиксированного объекта с помощью <xref:System.Windows.Freezable.Clone%2A> метод. В следующем разделе рассматривается более подробно клонирования.  
  
 **Примечание** поскольку зафиксированного freezable невозожно анимировать, системы анимации автоматически создаст изменяемые клоны замороженный <xref:System.Windows.Freezable> объектов при попытке их с помощью анимации <xref:System.Windows.Media.Animation.Storyboard>. Чтобы снизить издержки из-за клонирования, оставьте объект незафиксированным, если вы собираетесь анимировать его. Дополнительные сведения об анимации с помощью раскадровки см. в разделе [Общие сведения о раскадровках](../graphics-multimedia/storyboards-overview.md).  
  
### <a name="freezing-from-markup"></a>Замораживание из разметки  
 Чтобы закрепить <xref:System.Windows.Freezable> объявленный в разметке, можно использовать `PresentationOptions:Freeze` атрибута. В следующем примере <xref:System.Windows.Media.SolidColorBrush> объявляется как ресурс страницы и зафиксирован. Затем используется для установки фона кнопки.  
  
 [!code-xaml[FreezableSample#FreezeFromMarkupWholePage](~/samples/snippets/csharp/VS_Snippets_Wpf/FreezableSample/CS/FreezeFromMarkupExample.xaml#freezefrommarkupwholepage)]  
  
 Чтобы использовать `Freeze` атрибут, необходимо сопоставить с параметрами представления пространство имен: `http://schemas.microsoft.com/winfx/2006/xaml/presentation/options`. `PresentationOptions` — Это рекомендуемый префикс для сопоставления данного пространства имен:  
  
```  
xmlns:PresentationOptions="http://schemas.microsoft.com/winfx/2006/xaml/presentation/options"   
```  
  
 Так как не все средства чтения XAML распознают этот атрибут, рекомендуется использовать [mc: Ignorable-атрибут](mc-ignorable-attribute.md) для пометки `Presentation:Freeze` атрибут ignorable как:  
  
```  
xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"  
mc:Ignorable="PresentationOptions"  
```  
  
 Дополнительные сведения см. в разделе [mc: Ignorable-атрибут](mc-ignorable-attribute.md) страницы.  
  
### <a name="unfreezing-a-freezable"></a>«Размораживание» Freezable  
 После фиксации <xref:System.Windows.Freezable> никогда не может быть изменен или разморозить; тем не менее, можно создать с помощью незафиксированную копию <xref:System.Windows.Freezable.Clone%2A> или <xref:System.Windows.Freezable.CloneCurrentValue%2A> метод.  
  
 В следующем примере фона кнопки задается с помощью кисти и кисти, затем заморожен. Незафиксированная копия состоит из кисти с использованием <xref:System.Windows.Freezable.Clone%2A> метод. Клон изменяется и используется для изменения фона кнопки с желтого на красный.  
  
 [!code-csharp[freezablesample_procedural#CloneExample](~/samples/snippets/csharp/VS_Snippets_Wpf/freezablesample_procedural/CSharp/freezablesample.cs#cloneexample)]
 [!code-vb[freezablesample_procedural#CloneExample](~/samples/snippets/visualbasic/VS_Snippets_Wpf/freezablesample_procedural/visualbasic/freezablesample.vb#cloneexample)]  
  
> [!NOTE]
>  Независимо от используемого метода клонирования, анимация никогда не копируется в новый <xref:System.Windows.Freezable>.  
  
 <xref:System.Windows.Freezable.Clone%2A> И <xref:System.Windows.Freezable.CloneCurrentValue%2A> методы создают детальные копии объекта freezable. Если объект freezable содержит другие зафиксированные объекты freezable, они также клонируются и становятся изменяемыми. Например, если копировать зафиксированный <xref:System.Windows.Media.PathGeometry> чтобы сделать его изменяемым, рисунки и сегменты также копируются и становятся изменяемыми.  
  
<a name="createyourownfreezableclass"></a>   
## <a name="creating-your-own-freezable-class"></a>Создание собственного класса Freezable  
 Класс, производный от <xref:System.Windows.Freezable> поддерживает следующие функции.  
  
-   Особые состояния: только для чтения (замороженным) и состояние для записи.  
  
-   Потокобезопасность: зафиксированный <xref:System.Windows.Freezable> может использоваться несколькими потоками.  
  
-   Подробные уведомления об изменениях: В отличие от других <xref:System.Windows.DependencyObject>s, объектах класса Freezable предоставить уведомление об изменениях, при изменении значений вложенных свойств.  
  
-   Удобное клонирование: Freezable класс уже реализовал несколько методов, которые обеспечивают большую глубину клонирования.  
  
 Объект <xref:System.Windows.Freezable> — это разновидность <xref:System.Windows.DependencyObject>и поэтому использует в системе свойств зависимостей. Свойства класса не обязательно должны быть свойствами зависимости, но использование свойств зависимостей уменьшит объем кода, необходимо написать, так как <xref:System.Windows.Freezable> класс был разработан с учетом свойств зависимости. Дополнительные сведения о системе свойств зависимостей, см. в разделе [Общие сведения о свойствах зависимостей](dependency-properties-overview.md).  
  
 Каждый <xref:System.Windows.Freezable> подкласс должен переопределять <xref:System.Windows.Freezable.CreateInstanceCore%2A> метод. Если ваш класс использует свойства зависимости для всех своих данных, вы закончили.  
  
 Если класс содержит члены данных не свойство зависимости, необходимо также переопределить следующие методы:  
  
-   <xref:System.Windows.Freezable.CloneCore%2A>  
  
-   <xref:System.Windows.Freezable.CloneCurrentValueCore%2A>  
  
-   <xref:System.Windows.Freezable.GetAsFrozenCore%2A>  
  
-   <xref:System.Windows.Freezable.GetCurrentValueAsFrozenCore%2A>  
  
-   <xref:System.Windows.Freezable.FreezeCore%2A>  
  
 Также необходимо соблюдать следующие правила для доступа и записи на данные-члены, которые не являются свойствами зависимостей:  
  
-   В начале любого [!INCLUDE[TLA#tla_api](../../../../includes/tlasharptla-api-md.md)] , считывает элементы данных не свойство зависимости, вызовите <xref:System.Windows.Freezable.ReadPreamble%2A> метод.  
  
-   В начале любого API, который записывает элементы данных не свойство зависимости, вызовите <xref:System.Windows.Freezable.WritePreamble%2A> метод. (После вызова <xref:System.Windows.Freezable.WritePreamble%2A> в [!INCLUDE[TLA2#tla_api](../../../../includes/tla2sharptla-api-md.md)], не требуется дополнительный вызов к <xref:System.Windows.Freezable.ReadPreamble%2A> также считывать элементы данных не свойство зависимости.)  
  
-   Вызовите <xref:System.Windows.Freezable.WritePostscript%2A> метод перед выходом из методов, которые записывают на данные-члены не свойство зависимости.  
  
 Если класс содержит члены данных зависимостей свойства, которые являются <xref:System.Windows.DependencyObject> объектов, необходимо также вызвать <xref:System.Windows.Freezable.OnFreezablePropertyChanged%2A> метод каждый раз при изменении одного из их значения, даже если вы изменяете член `null`.  
  
> [!NOTE]
>  Очень важно, что началом реализации каждого <xref:System.Windows.Freezable> метод можно переопределить с помощью вызова к базовой реализации.  
  
 Пример настраиваемого <xref:System.Windows.Freezable> , представлена в разделе [пример пользовательского](https://go.microsoft.com/fwlink/?LinkID=159981).  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Freezable>
- [Пример пользовательской анимации](https://go.microsoft.com/fwlink/?LinkID=159981)
- [Общие сведения о свойствах зависимости](dependency-properties-overview.md)
- [Пользовательские свойства зависимостей](custom-dependency-properties.md)
