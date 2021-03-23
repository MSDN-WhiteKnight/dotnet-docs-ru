---
title: Атрибут PresentationOptions:Freeze
ms.date: 03/30/2017
helpviewer_keywords:
- Freeze attribute [WPF]
- Freezable elements [WPF]
- PresentationOptions prefix [WPF]
ms.assetid: 391032dd-2fba-4804-bb8a-3b071797a9f4
ms.openlocfilehash: e60c4a505db42936f188354f52edd7832fb9632b
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59074668"
---
# <a name="presentationoptionsfreeze-attribute"></a>Атрибут PresentationOptions:Freeze
Наборы <xref:System.Windows.Freezable.IsFrozen%2A> состояние `true` в содержащем <xref:System.Windows.Freezable> элемент. Поведение по умолчанию для <xref:System.Windows.Freezable> без `PresentationOptions:Freeze` указан атрибут является то, что <xref:System.Windows.Freezable.IsFrozen%2A> — `false` во время загрузки и в зависимости от Общие <xref:System.Windows.Freezable> поведению во время выполнения.  
  
## <a name="xaml-attribute-usage"></a>Использование атрибута XAML  
  
```  
<object  
  xmlns:PresentationOptions="http://schemas.microsoft.com/winfx/2006/xaml/presentation/options"  
  xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"  
  mc:Ignorable="PresentationOptions">  
    <freezableElement PresentationOptions:Freeze="true"/>  
</object>  
```  
  
## <a name="xaml-values"></a>Значения XAML  
  
|||  
|-|-|  
|`PresentationOptions`|Префикс пространства имен XML, который может быть любая строка допустимый префикс, в соответствии со спецификацией XML 1.0. Префикс `PresentationOptions` используется для идентификации в этой документации.|  
|`freezableElement`|Элемент, который создает экземпляр любой производный класс <xref:System.Windows.Freezable>.|  
  
## <a name="remarks"></a>Примечания  
 `Freeze` Атрибут является единственным атрибутом или другого элемента программирования, определенного в `http://schemas.microsoft.com/winfx/2006/xaml/presentation/options` пространство имен XML. `Freeze` Атрибут существует в этом специальном пространстве имен, поэтому он может быть назначен в качестве игнорируемого, используя [mc: Ignorable-атрибут](mc-ignorable-attribute.md) как часть объявлений корневого элемента. Причина, `Freeze` должен иметь возможность быть ignorable — так как не все [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] реализаций обработчиков может замораживать <xref:System.Windows.Freezable> во время загрузки; эта возможность не является частью [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] спецификации.  
  
 Возможность обработки `Freeze` атрибут специально встроен в [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] процессором, который обрабатывает [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] для скомпилированных приложений. Атрибут не поддерживается для любого класса, и синтаксис атрибута не является расширяемым или модифицируемым. Если вы реализуете собственный [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] процессора, вы можете параллельная замораживания поведение WPF [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] процессора при обработке `Freeze` атрибут <xref:System.Windows.Freezable> элементов во время загрузки.  
  
 Любое значение для `Freeze` отличное от атрибута `true` (без учета регистра) вызывает ошибку времени загрузки. (Указание `Freeze` атрибут как `false` не является ошибкой, но это уже по умолчанию, поэтому `false` не выполняет никаких действий).  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Freezable>
- [Общие сведения об объектах класса Freezable](freezable-objects-overview.md)
- [Атрибут mc: Ignorable](mc-ignorable-attribute.md)
