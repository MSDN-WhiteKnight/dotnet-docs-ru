---
title: Код программной части и XAML в WPF
ms.date: 03/30/2017
helpviewer_keywords:
- XAML [WPF], code-behind
- code-behind files [WPF], XAML
ms.assetid: 9df6d3c9-aed3-471c-af36-6859b19d999f
ms.openlocfilehash: 4a77060661cb0d71b0209cbcdeba23ffc2c6e5c7
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59088579"
---
# <a name="code-behind-and-xaml-in-wpf"></a>Код программной части и XAML в WPF
<a name="introduction"></a> Выделенный код — это термин, используемый для описания код, соединяемый с созданными в разметке объектами, когда [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] страницы, скомпилированного с разметкой. В этом разделе описываются требования для кода, а также альтернативный механизм встроенного кода для кода в [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)].  
  
 В этом разделе содержатся следующие подразделы.  
  
-   [Предварительные требования](#Prerequisites)  
  
-   [Код программной части и язык XAML](#codebehind_and_the_xaml_language)  
  
-   [Кода, обработчик событий и требования частичного класса в WPF](#Code_behind__Event_Handler__and_Partial_Class)  
  
-   [x: Code](#x_Code)  
  
-   [Ограничения встроенного кода](#Inline_Code_Limitations)  
  
<a name="Prerequisites"></a>   
## <a name="prerequisites"></a>Предварительные требования  
 В этом разделе предполагается, что вы прочитали [Обзор XAML (WPF)](xaml-overview-wpf.md) и иметь базовые знания о [!INCLUDE[TLA2#tla_clr](../../../../includes/tla2sharptla-clr-md.md)] и объектно ориентированного программирования.  
  
<a name="codebehind_and_the_xaml_language"></a>   
## <a name="code-behind-and-the-xaml-language"></a>Код программной части и язык XAML  
 Язык XAML включает в себя возможности языка, которые позволяют связать файлы кода в файлах разметки, со стороны файла разметки. В частности, язык XAML определяет возможности языка [директива x: Class](../../xaml-services/x-class-directive.md), [директива x: Subclass](../../xaml-services/x-subclass-directive.md), и [директива x: ClassModifier](../../xaml-services/x-classmodifier-directive.md). Точно как код должен создаваться и как интегрировать разметки и кода, не является частью указывает на языке XAML. Он остается до платформ, таких как WPF, чтобы определить, как интегрировать код, как использовать XAML в приложение и модели программирования и построение действия или другие поддерживает, что все это требует.  
  
<a name="Code_behind__Event_Handler__and_Partial_Class"></a>   
## <a name="code-behind-event-handler-and-partial-class-requirements-in-wpf"></a>Кода, обработчик событий и требования частичного класса в WPF  
  
-   Разделяемый класс должен быть производным от типа, который возвращает корневой элемент.  
  
-   Обратите внимание на то, что в группе по умолчанию поведение действий сборки для компиляции разметки, можно оставить наследование пустым в определении разделяемого класса со стороны кода. Скомпилированный результат предполагает резервный тип корневой страницы, чтобы служить основой для разделяемого класса, даже если он не указан. Тем не менее полагаться на это поведение не рекомендуется.  
  
-   Обработчики событий, который включается в код программной части должны быть методами экземпляра и не может быть статическими методами. Эти методы должны быть определены разделяемым классом в пространстве имен CLR, определяемый `x:Class`. Нельзя уточнить имя обработчика событий, чтобы указать [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] процессора для поиска для обработчика событий для события, написанного в другой области класса.  
  
-   Обработчик должен соответствовать делегат для соответствующего события в системе резервных типов.  
  
-   Для языка Microsoft Visual Basic в частности, можно использовать конкретного языка `Handles` ключевое слово, чтобы связать обработчики с экземплярами и событиями в объявлении обработчика, вместо присоединения обработчиков с атрибутами в [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)]. Тем не менее, этот метод имеет некоторые ограничения, так как `Handles` ключевое слово не поддерживает все функции [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] системы событий, такие как определенные сценарии перенаправленных событий или вложенные события. Дополнительные сведения см. в разделе [Visual Basic и обработка событий WPF](visual-basic-and-wpf-event-handling.md).  
  
<a name="x_Code"></a>   
## <a name="xcode"></a>x: Code  
 [x: Code](../../xaml-services/x-code-intrinsic-xaml-type.md) определен элемент директивы в [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)]. `x:Code` Директива может содержать встроенный программный код. Код, определенный встроенным можно взаимодействовать с [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] на одной странице. В следующем примере показано встроенного кода C#. Обратите внимание, что код находится внутри `x:Code` элемента и что код должен быть заключен в `<CDATA[`... `]]>` для экранирования содержимое для [!INCLUDE[TLA2#tla_xml](../../../../includes/tla2sharptla-xml-md.md)], так что [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] процессора (Интерпретация либо [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] схемы или [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] схемы) не будет пытаться интерпретировать содержимое буквально как [!INCLUDE[TLA2#tla_xml](../../../../includes/tla2sharptla-xml-md.md)].  
  
 [!code-xaml[XAMLOvwSupport#ButtonWithInlineCode](~/samples/snippets/csharp/VS_Snippets_Wpf/XAMLOvwSupport/CSharp/page4.xaml#buttonwithinlinecode)]  
  
<a name="Inline_Code_Limitations"></a>   
## <a name="inline-code-limitations"></a>Ограничения встроенного кода  
 Следует избегать или ограничивать использование встроенного кода. С точки зрения архитектуры и философии кодирования обеспечение разделения разметки и кода сохраняет ролей дизайнеры и разработчики гораздо больше отдельных. На более техническом уровне, код, написанный для встроенного кода может быть неудобно записи, так как вы записываете всегда в [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)] создается разделяемый класс и можно использовать только сопоставления пространства имен XML по умолчанию. Поскольку невозможно добавить `using` инструкций, необходимо полностью указать многие [!INCLUDE[TLA2#tla_api](../../../../includes/tla2sharptla-api-md.md)] вызовов. Значение по умолчанию [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] сопоставления включают большинство, но не все [!INCLUDE[TLA2#tla_clr](../../../../includes/tla2sharptla-clr-md.md)] пространства имен, которые присутствуют в [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] сборок; необходимо будет полностью определить вызовы к типам и членам, содержащихся в других пространствах имен среды CLR. Также любых других разделяемый класс не может определить во встроенном коде, и все сущности пользовательского кода, ссылки на которые должны существовать в качестве членов или переменных внутри созданного разделяемого класса. Другие программирования функции для конкретных языков, таких как макросы или `#ifdef` глобальные переменные или переменные сборки, также не доступны. Дополнительные сведения см. в разделе [встроенный тип XAML x: Code](../../xaml-services/x-code-intrinsic-xaml-type.md).  
  
## <a name="see-also"></a>См. также

- [Обзор XAML (WPF)](xaml-overview-wpf.md)
- [Встроенный тип XAML x:Code](../../xaml-services/x-code-intrinsic-xaml-type.md)
- [Построение приложения WPF](../app-development/building-a-wpf-application-wpf.md)
- [Подробное описание синтаксиса XAML](xaml-syntax-in-detail.md)
