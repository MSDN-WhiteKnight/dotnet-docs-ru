---
title: Сериализация ограничений XamlWriter.Save
ms.date: 03/30/2017
helpviewer_keywords:
- XamlWriter.Save [WPF], serialization limitations of
- limitations of XamlWriter.Save
- serialization limitations of XamlWriter.Save
ms.assetid: f86acc91-2b67-4039-8555-505734491d36
ms.openlocfilehash: 89cb36dba63dccdf7e52b7fcafbe3d9fc2fea1e5
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59113286"
---
# <a name="serialization-limitations-of-xamlwritersave"></a>Сериализация ограничений XamlWriter.Save
[!INCLUDE[TLA#tla_api](../../../../includes/tlasharptla-api-md.md)] <xref:System.Windows.Markup.XamlWriter.Save%2A> Может использоваться для сериализации содержимого Windows Presentation Foundation (WPF) под XAML файл. Однако существуют некоторые заметные ограничения в том, что именно подлежит сериализации. В данном разделе описаны эти ограничения и некоторые общие рекомендации.  

<a name="Run_Time__Not_Design_Time_Representation"></a>   
## <a name="run-time-not-design-time-representation"></a>Представление во время выполнения, а не во время разработки  
 Основные принципы что подлежит сериализации при вызове <xref:System.Windows.Markup.XamlWriter.Save%2A> том, что результат будет представление сериализуемого во время выполнения объекта. Многие свойства времени разработки первоначального [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] файл уже может быть оптимизированы или потеряны к тому времени, [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] загружается как объекты в памяти и не сохраняются при вызове <xref:System.Windows.Markup.XamlWriter.Save%2A> для сериализации. Результат сериализации — эффективное представление построенного логического дерева приложения, но не обязательно исходного [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)], который его создал. Эти проблемы затрудняют использование <xref:System.Windows.Markup.XamlWriter.Save%2A> сериализации как части обширной [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] область конструктора.  
  
<a name="Serialization_is_Self_Contained"></a>   
## <a name="serialization-is-self-contained"></a>Сериализация самодостаточна  
 Сериализованные выходные данные <xref:System.Windows.Markup.XamlWriter.Save%2A> самодостаточны; все, что сериализовано, содержится внутри [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] одну страницу, с единственный корневой элемент и без внешних ссылок, отличных от [!INCLUDE[TLA2#tla_uri#plural](../../../../includes/tla2sharptla-urisharpplural-md.md)]. Например, если страницы ссылаются на ресурсы из ресурсов приложения, они будут отображаться, как если бы они были компонентом сериализуемой страницы.  
  
<a name="Extension_References_are_Dereferenced"></a>   
## <a name="extension-references-are-dereferenced"></a>Ссылки на расширения разыменовываются  
 Общие ссылки на объекты, сделанные различными форматами расширения разметки, такие как `StaticResource` или `Binding`, будут разыменованы в процессе сериализации. Они уже были разыменованы во время создания объектов в памяти при выполнении приложения и <xref:System.Windows.Markup.XamlWriter.Save%2A> логики не к повторному посещению исходного [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] для восстановления таких ссылок для сериализованных выходных данных. Это потенциально замораживает любое значение, полученное из привязки данных или ресурсов, которое в последний раз использовалось представлением во время выполнения, и остается только ограниченная или косвенная возможность отличать такое значение от любого другого значения, установленного локально. Образы сериализуются как ссылки объектов на изображения в том виде, в котором они существуют в проекте, а не как исходные ссылки на источники, теряя изначально указанные ссылками имя файла или [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)]. Ресурсы, объявленные на одной странице, воспринимаются как сериализованные в том месте, где они были указаны ссылками, а не сохраняются как ключ коллекции ресурсов.  
  
<a name="Event_Handling_is_Not_Preserved"></a>   
## <a name="event-handling-is-not-preserved"></a>Обработка событий не сохраняется  
 Если обработчики событий, которые добавляются с помощью [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)], будут сериализованы, то они не сохранятся. [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] без кода (и без механизма связанных x: Code) не имеет возможности сериализовать процедурную логику времени выполнения. Поскольку сериализация является самодостаточной и ограничивается логическим деревом, не существует средств для хранения обработчиков событий. В результате атрибуты обработчика событий (и атрибут, и строковое значение имени обработчика) удаляются из выходных данных [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)].  
  
<a name="Realistic_Scenarios_for_Use_of_XAMLWriter_Save"></a>   
## <a name="realistic-scenarios-for-use-of-xamlwritersave"></a>Реалистичные сценарии использования XAMLWriter.Save  
 Хотя ограничения, перечисленные здесь, являются достаточно значительными, существует еще несколько подходящих сценариев использования <xref:System.Windows.Markup.XamlWriter.Save%2A> для сериализации.  
  
-   Вектор или графического вывода: Выходные данные для просмотра области можно использовать для воспроизведения того же вектора или графики при перезагрузке.  
  
-   Форматированный текст и потоковые документы: Текст и все форматирование и элемент вложение элементов внутри него сохраняются в выходных данных. Это может быть полезно для механизмов, которые аппроксимируют функциональность буфера обмена.  
  
-   Сохранение данных бизнес-объекта: Если вы сохранили данные в пользовательских элементах, такие как [!INCLUDE[TLA2#tla_xml](../../../../includes/tla2sharptla-xml-md.md)] данных, условии, что бизнес-объекты соответствуют базовым [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] правил, таких как предоставление настраиваемых конструкторов и преобразование значений свойств по ссылке, эти бизнес-объектов может быть сохранены посредством сериализации.
