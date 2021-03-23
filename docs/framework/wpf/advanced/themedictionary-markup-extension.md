---
title: Расширение разметки ThemeDictionary
ms.date: 03/30/2017
f1_keywords:
- ThemeDictionaryExtension
- ThemeDictionary
helpviewer_keywords:
- ThemeDictionary markup extension [WPF]
- XAML [WPF], ThemeDictionary markup extension
ms.assetid: aa75e10b-13dd-4989-972d-51bab63a05e2
ms.openlocfilehash: ad2248c791fadc5363d90ff496d5e040f6036ab3
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59132097"
---
# <a name="themedictionary-markup-extension"></a>Расширение разметки ThemeDictionary
Предоставляет для разработчиков пользовательских элементов управления или приложений, которые объединяют элементы управления сторонних производителей, способ загрузки определенных темой словарей ресурсов для использования в стилизации элемента управления.  
  
## <a name="xaml-attribute-usage"></a>Использование атрибута XAML  
  
```xml  
<object property="{ThemeDictionary assemblyUri}" .../>  
```  
  
## <a name="xaml-object-element-usage"></a>Использование элемента объекта XAML  
  
```xml  
<object>  
  <object.property>  
    <ThemeDictionary AssemblyName="assemblyUri"/>  
  <object.property>  
<object>  
```  
  
## <a name="xaml-values"></a>Значения XAML  
  
|||  
|-|-|  
|`assemblyUri`|[!INCLUDE[TLA#tla_uri](../../../../includes/tlasharptla-uri-md.md)] сборки, содержащей сведения о теме. Как правило, это URI типа pack, который ссылается на сборку в большом пакете. Ресурсы сборки и URI типа pack упрощают развертывание. Дополнительные сведения см. в разделе [URI типа pack в WPF](../app-development/pack-uris-in-wpf.md).|  
  
## <a name="remarks"></a>Примечания  
 Это расширение предназначено для заполнения только одного значения конкретного свойства: значение для <xref:System.Windows.ResourceDictionary.Source%2A?displayProperty=nameWithType>.  
  
 Используя это расширение, можно указать единую сборку только для ресурсов, которая содержит некоторые стили для использования только в случае, если тема [!INCLUDE[TLA#tla_aero](../../../../includes/tlasharptla-aero-md.md)] применяется к системе пользователя, другие стили при активной теме Luna и т. д. Используя это расширение, содержимое словаря ресурсов элемента управления при необходимости можно автоматически считать недействительным и перезагрузить для другой темы.  
  
 `assemblyUri` Строки (<xref:System.Windows.ThemeDictionaryExtension.AssemblyName%2A> значение свойства) является основанием для именования, определяющий, какой словарь применяется к определенной теме. <xref:System.Windows.Markup.MarkupExtension.ProvideValue%2A> Логику для `ThemeDictionary` завершения соглашение путем создания [!INCLUDE[TLA#tla_uri](../../../../includes/tlasharptla-uri-md.md)] , указывающий тип словаря конкретной темы, содержащийся внутри предварительно скомпилированных ресурсов сборки. Описание этого соглашения или взаимодействия темы со стилизацией основных элементов управления и стилизацией уровня страницы или приложения, как концепции, полностью в данном разделе не рассматривается. Основные сценарии использования `ThemeDictionary` заключается в указании <xref:System.Windows.ResourceDictionary.Source%2A> свойство `ResourceDictionary` объявлен на уровне приложения. В случае предоставления [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)] для сборки посредством расширения `ThemeDictionary` вместо непосредственного [!INCLUDE[TLA2#tla_uri](../../../../includes/tla2sharptla-uri-md.md)] логика расширения обеспечит логику недействительности, которая применяется при каждом изменении системной темы.  
  
 Синтаксис атрибутов является наиболее распространенным синтаксисом, используемым с этим расширением разметки. Строковая лексема, указываемая после строки идентификатора `ThemeDictionary`, присваивается в качестве значения <xref:System.Windows.ThemeDictionaryExtension.AssemblyName%2A> соответствующего класса расширения <xref:System.Windows.ThemeDictionaryExtension>.  
  
 `ThemeDictionary` может также использоваться в синтаксисе элемента объекта. В этом случае укажите значение параметра <xref:System.Windows.ThemeDictionaryExtension.AssemblyName%2A> свойство является обязательным.  
  
 `ThemeDictionary` Можно также использовать в использовании атрибут verbose, который указывает <xref:System.Windows.Markup.StaticExtension.Member%2A> как свойство = значение пары:  
  
```xml  
<object property="{ThemeDictionary AssemblyName=assemblyUri}" .../>  
```  
  
 Подробное определение зачастую удобно использовать для расширений, которые имеют несколько устанавливаемых свойств, а также в том случае, если некоторые свойства являются необязательными. Так как `ThemeDictionary` имеет только одно устанавливаемое свойство, которое является обязательным, это использование не является типичным.  
  
 В WPF [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] реализации обработчика обработка данного расширения разметки определяется <xref:System.Windows.ThemeDictionaryExtension> класса.  
  
 `ThemeDictionary` является расширением разметки. Расширения разметки обычно реализуются, если требуется заменить значения атрибутов на нелитеральные значения или имена обработчиков и если требуется больше, чем простая настройка преобразователей типов на работу с определенными типами или свойствами. Все расширения разметки в [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] используют символы "{" и "}" в синтаксисе их атрибутов, который является соглашением, по которому обработчик [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] распознает, что расширение разметки должно обработать атрибут. Дополнительные сведения см. в разделе [Расширения разметки и XAML WPF](markup-extensions-and-wpf-xaml.md).  
  
## <a name="see-also"></a>См. также

- [Стилизация и использование шаблонов](../controls/styling-and-templating.md)
- [Обзор XAML (WPF)](xaml-overview-wpf.md)
- [Расширения разметки и XAML WPF](markup-extensions-and-wpf-xaml.md)
- [Ресурсы, Содержимое и Файлы данных WPF-приложения](../app-development/wpf-application-resource-content-and-data-files.md)
