---
title: 'Атрибут mc: Ignorable'
ms.date: 03/30/2017
helpviewer_keywords:
- mc XML namespace prefix [WPF]
- mc:Ignorable attribute
- XML [WPF], mc namespace prefix
- XAML [WPF], mc:Ignorable attribute
- mc:ProcessContent attribute
- XAML [WPF], mc:ProcessContent attribute
ms.assetid: acd9a6ef-b7ca-4146-abb6-60f3b366e9ec
ms.openlocfilehash: 03439a2c4a1a4de375e90d0e5121e690541e2f0f
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59219334"
---
# <a name="mcignorable-attribute"></a>Атрибут mc: Ignorable
Указывает, какие [!INCLUDE[TLA2#tla_xml](../../../../includes/tla2sharptla-xml-md.md)] префиксы пространства имен в файле разметки могут игнорироваться XAML процессора. `mc:Ignorable` Атрибут поддерживает совместимость разметки для пользовательского сопоставления пространства имен и XAML управления версиями.  
  
## <a name="xaml-attribute-usage-single-prefix"></a>Использование атрибута XAML (один префикс)  
  
```  
<object  
  xmlns:ignorablePrefix="ignorableUri"  
  xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"  
  mc:Ignorable="ignorablePrefix"...>  
    <ignorablePrefix1:ThisElementCanBeIgnored/>  
</object>  
```  
  
## <a name="xaml-attribute-usage-two-prefixes"></a>Использование атрибута XAML (два префикса)  
  
```  
<object  
  xmlns:ignorablePrefix1="ignorableUri"  
  xmlns:ignorablePrefix2="ignorableUri2"  
  xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"  
  mc:Ignorable="ignorablePrefix1 ignorablePrefix2"...>  
    <ignorablePrefix1:ThisElementCanBeIgnored/>  
</object>  
```  
  
## <a name="xaml-values"></a>Значения XAML  
  
|||  
|-|-|  
|*ignorablePrefix, ignorablePrefix1 и т. д.*|Любая строка допустимый префикс, согласно спецификации XML 1.0.|  
|*ignorableUri*|Любой допустимый URI для назначения пространства имен, согласно спецификации XML 1.0.|  
|*ThisElementCanBeIgnored*|Элемент, который может обрабатываться средством XAML реализаций обработчиков, если базовый тип не может быть разрешена.|  
  
## <a name="remarks"></a>Примечания  
 `mc` [!INCLUDE[TLA2#tla_xml](../../../../includes/tla2sharptla-xml-md.md)] Префикс пространства имен является соглашением, рекомендуемый префикс для использования при сопоставлении XAML имен совместимости [!INCLUDE[TLA#tla_mcxmlnsv1](../../../../includes/tlasharptla-mcxmlnsv1-md.md)].  
  
 Элементы или атрибуты, где префикс часть имени элемента определяется как `mc:Ignorable` не создают ошибок при обработке XAML процессора. Если этот атрибут не может быть разрешена для базового типа или конструкции программирования, то этот элемент игнорируется. Тем не менее, обратите внимание, что пропускаемые элементы по-прежнему могут создавать дополнительные синтаксические ошибки для дополнительных требований к элементу, побочных эффектов этого элемента не обрабатывается. К примеру, определенный элемент содержимого модели может потребоваться только один дочерний элемент, но если указанный дочерний элемент был в `mc:Ignorable` префикс и указанный дочерний элемент не удалось разрешить в тип, то XAML процессора может создается ошибка.  
  
 `mc:Ignorable` применяется только для сопоставления пространства имен с идентификатором строки. `mc:Ignorable` не применяется для сопоставления пространства имен в сборках, указывающих [!INCLUDE[TLA2#tla_clr](../../../../includes/tla2sharptla-clr-md.md)] пространства имен и сборки (или по умолчанию для текущего исполняемый файл как сборку).  
  
 Если вы реализуете XAML процессора, не должны вызывать реализация обработчика, синтаксического анализа или обработки ошибок для разрешения типов для любого элемента или атрибута, который определяется префикс, который определяется как `mc:Ignorable`. Но реализация обработчика по-прежнему может вызывать исключения, которые являются побочным результатом сбоя загрузки или обработки, таких как в приведенном выше примере одного дочернего элемента элемента.  
  
 По умолчанию XAML процессора будет игнорировать содержимое внутри игнорируемого элемента. Тем не менее, можно указать дополнительный атрибут, [атрибут mc: ProcessContent](mc-processcontent-attribute.md), для продолжения обработки содержимого в пределах игнорируемого элемента следующим доступным родительским элементом.  
  
 Можно указать несколько префиксов в атрибуте, используя один или несколько символов пробела в качестве разделителя, например: `mc:Ignorable="ignore1 ignore2"`.  

 [!INCLUDE[TLA#tla_mcxmlnsv1](../../../../includes/tlasharptla-mcxmlnsv1-md.md)] Пространство имен определяет другие элементы и атрибуты, которые не документированы в этой области [!INCLUDE[TLA#tla_sdk](../../../../includes/tlasharptla-sdk-md.md)]. Дополнительные сведения см. в разделе [спецификации совместимости разметки XML](/office/open-xml/introduction-to-markup-compatibility#markup-compatibility-in-the-open-xml-file-formats-specification).  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Markup.XamlReader>
- [Атрибут PresentationOptions:Freeze](presentationoptions-freeze-attribute.md)
- [Обзор XAML (WPF)](xaml-overview-wpf.md)
- [Документы в WPF](documents-in-wpf.md)
