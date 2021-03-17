---
title: Объединенные словари ресурсов
ms.date: 03/30/2017
helpviewer_keywords:
- merged resource dictionaries [WPF]
- dictionaries [WPF], merged resources
ms.assetid: d159531f-05d4-49fd-b951-c332de51e5bc
ms.openlocfilehash: 17dd8e0c02d71fc7e72800fc578866188d03060e
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59097243"
---
# <a name="merged-resource-dictionaries"></a>Объединенные словари ресурсов
[!INCLUDE[TLA#tla_winclient](../../../../includes/tlasharptla-winclient-md.md)] ресурсы поддерживают функцию объединенных словарей ресурсов. Эта функция обеспечивает способ определения части ресурсов приложения [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] за пределами скомпилированного приложения [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)]. Затем ресурсы можно совместно использовать в приложениях; они также более удобно изолируются для локализации.  
  
## <a name="introducing-a-merged-resource-dictionary"></a>Общие сведения об объединенном словаре ресурсов  
 Для представления на странице объединенного словаря ресурсов используйте в разметке следующий синтаксис.  
  
 [!code-xaml[ResourceMergeDictionary#MergedXAML](~/samples/snippets/csharp/VS_Snippets_Wpf/ResourceMergeDictionary/CS/default.xaml#mergedxaml)]  
  
 Обратите внимание, что <xref:System.Windows.ResourceDictionary> элемент не имеет [директивы x: Key](../../xaml-services/x-key-directive.md), которая обычно используется для всех элементов в коллекции ресурсов. Но другой <xref:System.Windows.ResourceDictionary> будет сослаться <xref:System.Windows.ResourceDictionary.MergedDictionaries%2A> коллекции является особым случаем, зарезервированные для этого сценария объединенного словаря ресурсов. <xref:System.Windows.ResourceDictionary> Представляющий объединенный словарь ресурсов не может иметь [директивы x: Key](../../xaml-services/x-key-directive.md). Как правило, каждый <xref:System.Windows.ResourceDictionary> в <xref:System.Windows.ResourceDictionary.MergedDictionaries%2A> указывает коллекцию <xref:System.Windows.ResourceDictionary.Source%2A> атрибута. Значение <xref:System.Windows.ResourceDictionary.Source%2A> должно быть [!INCLUDE[TLA#tla_uri](../../../../includes/tlasharptla-uri-md.md)] , разрешает путь к файлу ресурсов для объединения. Назначением [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)] должен быть другой [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] файла, с помощью <xref:System.Windows.ResourceDictionary> качестве корневого элемента.  
  
> [!NOTE]
>  Можно определять ресурсы в <xref:System.Windows.ResourceDictionary> , который указан как объединенный словарь, либо в качестве альтернативы указанию <xref:System.Windows.ResourceDictionary.Source%2A>, или в дополнение к любым ресурсам включаются из указанного источника. Однако это не очень распространенный сценарий; основным сценарием для объединенных словарей является объединение ресурсов из внешних файлов. Если вы хотите указать ресурсы в разметке страницы, обычно следует определить их в главном <xref:System.Windows.ResourceDictionary> , а не в объединенных словарях.  
  
## <a name="merged-dictionary-behavior"></a>Поведение объединенного словаря  
 Ресурсы в объединенном словаре занимают место в области поиска ресурсов сразу после области главного словаря ресурсов, в который они будут включены. Хотя ключ ресурса должен быть уникальным в пределах каждого отдельного словаря, один и тот же ключ может встречаться несколько раз в наборе объединенных словарей. В этом случае возвращаемый ресурс поступит из последнего словаря, последовательно найденного в <xref:System.Windows.ResourceDictionary.MergedDictionaries%2A> коллекции. Если <xref:System.Windows.ResourceDictionary.MergedDictionaries%2A> коллекция была определена в [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)], то порядок объединенных словарей в коллекции соответствует порядку элементов в разметке. Если ключ определен в главном словаре, а также в словаре, который был объединен, возвращаемый ресурс поступит из основного словаря. Эти правила поиска применяются одинаково для ссылок как на статические, так и на динамические ресурсы.  
  
### <a name="merged-dictionaries-and-code"></a>Объединенные словари и код  
 Объединенные словари могут быть добавлены в словарь `Resources` с помощью кода. По умолчанию, изначально пуста <xref:System.Windows.ResourceDictionary> , существует для каждого `Resources` свойство также имеет значение по умолчанию, изначально пуста <xref:System.Windows.ResourceDictionary.MergedDictionaries%2A> свойство коллекции. Чтобы добавить объединенный словарь посредством кода, можно получить ссылку на нужный основной <xref:System.Windows.ResourceDictionary>, получите его <xref:System.Windows.ResourceDictionary.MergedDictionaries%2A> значение свойства и вызов `Add` универсального `Collection` , содержащимся в <xref:System.Windows.ResourceDictionary.MergedDictionaries%2A>. Добавляемый объект должен быть новый <xref:System.Windows.ResourceDictionary>. В коде, вы не установите <xref:System.Windows.ResourceDictionary.Source%2A> свойство. Вместо этого необходимо получить <xref:System.Windows.ResourceDictionary> путем создания или загрузки. Один из способов загрузки существующего <xref:System.Windows.ResourceDictionary> для вызова <xref:System.Windows.Markup.XamlReader.Load%2A?displayProperty=nameWithType> на существующем [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] файловый поток, который имеет <xref:System.Windows.ResourceDictionary> корня, затем приведение <xref:System.Windows.Markup.XamlReader.Load%2A?displayProperty=nameWithType> возвращаемое значение для <xref:System.Windows.ResourceDictionary>.  
  
### <a name="merged-resource-dictionary-uris"></a>URI объединенных словарей ресурсов  
 Существует несколько методов включения объединенного словаря ресурсов, указываемого форматом [!INCLUDE[TLA#tla_uri](../../../../includes/tlasharptla-uri-md.md)], который будет использоваться. Вообще говоря, эти методы можно разделить на две категории: ресурсы, которые компилируются как часть проекта, и ресурсы, которые не компилируются как часть проекта.  
  
 Для ресурсов, которые компилируются как часть проекта, можно использовать относительный путь, ссылающийся на расположение ресурса. Относительный путь вычисляется во время компиляции. Ресурс должен быть определен как часть проекта в качестве действия сборки ресурса. Если XAML-файл ресурса включен в проект в качестве ресурса, то не нужно копировать этот файл ресурса в выходной каталог, так как ресурс уже включен в скомпилированное приложение. Можно также использовать действие сборки содержимого, но затем будет необходимо скопировать файлы в выходной каталог и развернуть эти файлы ресурсов по тому же пути, связанному с исполняемым файлом.  
  
> [!NOTE]
>  Не используйте действие сборки внедренного ресурса. Само действие сборки поддерживается для [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] приложения, но разрешение <xref:System.Windows.ResourceDictionary.Source%2A> не может включать <xref:System.Resources.ResourceManager>и поэтому невозможно отдельного ресурса из потока. Внедренный ресурс по-прежнему можно использовать для других целей до тех пор, пока вы также использовали <xref:System.Resources.ResourceManager> доступ к ресурсам.  
  
 Близким методом являются использование URI типа pack в файле [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] и ссылка на него в качестве источника. URI типа pack позволяет ссылки на компоненты связанных сборок и другие методы. Дополнительные сведения об URI типа pack см. в разделе [Ресурсы, контент и файлы данных приложения WPF](../app-development/wpf-application-resource-content-and-data-files.md).  
  
 Для ресурсов, которые не компилируются как часть проекта, URI вычисляется во время выполнения. Для ссылки на файл ресурсов можно использовать общий транспорт URI, такой как file: или http:. Недостаток подхода с использованием некомпилированного ресурса заключается в том, что для доступа file: требуются дополнительные действия по развертыванию, а доступ http: подразумевает зону безопасности Интернета.  
  
### <a name="reusing-merged-dictionaries"></a>Многократное использование объединенных словарей  
 Вы можете многократно или совместно использовать объединенные словари ресурсов в приложениях, поскольку на словарь ресурсов, предназначенный для слияния, можно ссылаться через любые допустимые [!INCLUDE[TLA#tla_uri](../../../../includes/tlasharptla-uri-md.md)]. Точный способ сделать это будет зависеть от стратегии развертывания приложения и используемой модели приложения. Вышеупомянутая стратегия URI типа pack обеспечивает способ совместного создания объединенного ресурса между несколькими проектами в процессе разработки путем совместного использования ссылки на сборку. В этом сценарии ресурсы по-прежнему распространяются клиентом и по крайней мере одно из приложений должно разворачивать связанную сборку. Можно также ссылаться на объединенные ресурсы с помощью распределенного URI, который использует протокол http.  
  
 Запись объединенных словарей как локальных файлов приложения или в локальное общее хранилище является другим возможным сценарием объединенного словаря или развертывания приложения.  
  
### <a name="localization"></a>Локализация  
 Если ресурсы, которые необходимо локализовать, изолированы от словарей, объединенных в основные словари, и хранятся как свободные [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)], эти файлы можно локализовать отдельно. Этот способ является упрощенной альтернативой для локализации вспомогательных сборок ресурсов. Дополнительные сведения см. в статье [Общие сведения о глобализации и локализации WPF](wpf-globalization-and-localization-overview.md).  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.ResourceDictionary>
- [Ресурсы XAML](xaml-resources.md)
- [Ресурсы и код](resources-and-code.md)
- [Ресурсы, Содержимое и Файлы данных WPF-приложения](../app-development/wpf-application-resource-content-and-data-files.md)
