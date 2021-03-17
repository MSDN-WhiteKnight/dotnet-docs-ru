---
title: Ресурсы и код
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- keys [WPF], using objects as
- resources [WPF], accessing from procedural code
- procedural code [WPF], creating resources with
- procedural code [WPF], accessing resources from
- resources [WPF], creating with procedural code
ms.assetid: c1cfcddb-e39c-41c8-a7f3-60984914dfae
ms.openlocfilehash: d36d30dd336bbe50b192b10a6a60d2c7e382adb8
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59137713"
---
# <a name="resources-and-code"></a>Ресурсы и код
Этот обзор посвящен преимущественно доступу к ресурсам [!INCLUDE[TLA#tla_winclient](../../../../includes/tlasharptla-winclient-md.md)] и их созданию с использованием кода, а не синтаксиса [!INCLUDE[TLA#tla_xaml](../../../../includes/tlasharptla-xaml-md.md)]. Дополнительные сведения об общем использовании ресурсов и ресурсах с точки зрения синтаксиса [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] см. в разделе [Ресурсы XAML](xaml-resources.md).  

<a name="accessing"></a>   
## <a name="accessing-resources-from-code"></a>Доступ к ресурсам из кода  
 Ключи, идентифицирующие ресурсы, если они определены через [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)], также используются для извлечения определенных ресурсов при запросе ресурса из кода. Самый простой способ извлечения ресурса из кода является вызов либо <xref:System.Windows.FrameworkElement.FindResource%2A> или <xref:System.Windows.FrameworkElement.TryFindResource%2A> метода из объектов уровня среды приложения. Различие между этими методами проявляется, если запрошенный ключ не найден. <xref:System.Windows.FrameworkElement.FindResource%2A> приводит к появлению исключения; <xref:System.Windows.FrameworkElement.TryFindResource%2A> не вызовут исключения, но возвращает `null`. Каждый из этих методов принимает ключ ресурса в качестве входного параметра и возвращает объект со слабой типизацией. Как правило, ключ ресурса является строкой, но иногда используются и нестроковые ключи. Подробнее см. в разделе [Использование объектов в качестве ключей](#objectaskey). Как правило, возвращаемый объект приводится к типу, необходимому для свойства, которое устанавливается при запросе ресурса. Логика поиска разрешения ресурса кода такая же, как и в случае динамической ссылки на ресурс [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)]. Поиск ресурсов начинается с вызывающего элемента, затем продолжается в последовательных родительских элементах в логическом дереве. При необходимости поиск продолжается в ресурсах приложений, темах и системных ресурсах. Запрос кода для ресурса будет правильно учитывать изменения во время выполнения в словарях ресурсов, которые могли быть сделаны после загрузки данного словаря из [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)], а также изменения системных ресурсов в реальном времени.  
  
 Ниже приведен пример кода, который находит ресурс по ключу и использует возвращаемое значение, чтобы задать свойство, реализованы в виде <xref:System.Windows.Controls.Primitives.ButtonBase.Click> обработчик событий.  
  
 [!code-csharp[PropertiesOvwSupport#ResourceProceduralGet](~/samples/snippets/csharp/VS_Snippets_Wpf/PropertiesOvwSupport/CSharp/page3.xaml.cs#resourceproceduralget)]
 [!code-vb[PropertiesOvwSupport#ResourceProceduralGet](~/samples/snippets/visualbasic/VS_Snippets_Wpf/PropertiesOvwSupport/visualbasic/page3.xaml.vb#resourceproceduralget)]  
  
 Альтернативный метод для назначения является ссылкой на ресурс является <xref:System.Windows.FrameworkElement.SetResourceReference%2A>. Этот метод принимает два параметра — ключ ресурса и идентификатор конкретного свойства зависимостей из экземпляра элемента, которому должно быть присвоено значение ресурса. Функционально этот метод аналогичен, но имеет преимущество в том плане, что не требует приведения возвращаемых значений.  
  
 Еще одним способом программного доступа к ресурсам является доступ к содержимому <xref:System.Windows.FrameworkElement.Resources%2A> свойство как словарь. Доступ к словарю, содержащемуся в этом свойстве, включает добавление новых ресурсов в существующие коллекции, проверку оригинальности имени ключа в коллекции, а также другие операции со словарем/коллекцией. Если вы создаете [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] приложения полностью в коде, можно также создать всю коллекцию в коде, присвоить ей ключи и затем присвоить законченную коллекцию для <xref:System.Windows.FrameworkElement.Resources%2A> свойство установленного элемента. Это будет описано в следующем разделе.  
  
 Можно индексировать любую заданную <xref:System.Windows.FrameworkElement.Resources%2A> коллекцию, используя указанный ключ индекса, но следует иметь в виду, что доступ к ресурсу таким образом не соответствует обычным правилам времени выполнения для разрешения ресурса. У вас будет только доступ к этой конкретной коллекции. Поиск ресурсов не будет пересекать область действия корня или приложения, если в запрашиваемом ключе не найден действительный объект. Тем не менее в некоторых случаях этот подход может иметь преимущество в производительности, поскольку область поиска ключа более ограничена. См. в разделе <xref:System.Windows.ResourceDictionary> Дополнительные сведения о том, как работать со словарями ресурсов напрямую.  
  
<a name="creating"></a>   
## <a name="creating-resources-with-code"></a>Создание ресурсов с помощью кода  
 Пи создании приложения [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] полностью в коде может также понадобиться создать в коде все ресурсы в этом приложении. Чтобы добиться этого, создайте новый <xref:System.Windows.ResourceDictionary> экземпляра, а затем добавьте все ресурсы в словарь, с помощью последовательных вызовов <xref:System.Windows.ResourceDictionary.Add%2A?displayProperty=nameWithType>. Затем с помощью <xref:System.Windows.ResourceDictionary> созданный таким образом, чтобы задать <xref:System.Windows.FrameworkElement.Resources%2A> свойство на элементе, который присутствует в области страницы, или <xref:System.Windows.Application.Resources%2A?displayProperty=nameWithType>. Можно также хранить <xref:System.Windows.ResourceDictionary> как с автономным объектом, не добавляя ее к элементу. Однако в этом случае для доступа к ресурсам внутри него потребуется ключ элемента, как для общего словаря. Объект <xref:System.Windows.ResourceDictionary> , не присоединенные к элементу `Resources` свойство не будет существовать как часть дерева элементов и не имел бы области в последовательности поиска, которая может использоваться <xref:System.Windows.FrameworkElement.FindResource%2A> и связанными методами.  
  
<a name="objectaskey"></a>   
## <a name="using-objects-as-keys"></a>Использование объектов в качестве ключей  
 В большинстве случаев использования ресурса ключ ресурса устанавливается в виде строки. Однако различные функции [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] намеренно не используют строковый тип для указания ключей, вместо этого параметр является объектом. Возможность доступа объекта к ресурсу по ключу используется в поддержке стилей и тем [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)]. Стили в темах, которые становятся стилем по умолчанию для элемента управления без стиля по ключу с <xref:System.Type> элемента управления, они должны применяться. Ввод с помощью ключа по типу обеспечивает надежный механизм поиска, который работает со стандартными экземплярами каждого типа элемента управления, а тип может быть обнаружен отражением и использоваться для создания стилей производных классов, даже если у производного типа нет стиля по умолчанию. Можно указать <xref:System.Type> ключей для ресурса, определенного в [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] с помощью [расширение разметки x: Type](../../xaml-services/x-type-markup-extension.md). Аналогичные расширения существуют для других случаев использования нестрокового ключа, поддерживающих функции [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)], такие как [Расширение разметки ComponentResourceKey](componentresourcekey-markup-extension.md).  
  
## <a name="see-also"></a>См. также

- [Ресурсы XAML](xaml-resources.md)
- [Стилизация и использование шаблонов](../controls/styling-and-templating.md)
