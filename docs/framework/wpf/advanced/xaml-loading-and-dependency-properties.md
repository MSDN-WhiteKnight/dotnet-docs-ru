---
title: Загрузка кода XAML и свойства зависимостей
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- custom dependency properties [WPF]
- dependency properties [WPF], XAML loading and
- loading XML data [WPF]
ms.assetid: 6eea9f4e-45ce-413b-a266-f08238737bf2
ms.openlocfilehash: 4db87c5f266a9eed136f0651f48d11720abede65
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59083840"
---
# <a name="xaml-loading-and-dependency-properties"></a>Загрузка кода XAML и свойства зависимостей
Текущая реализация процессора WPF в XAML, по сути, учитывает свойство зависимостей. При загрузке двоичных файлов XAML и обработке атрибутов, которые являются свойствами зависимостей, процессор XAML WPF использует методы системы свойств для свойств зависимостей. При этом выполняется обход оболочек свойств. При реализации пользовательских свойств зависимостей, вы должны учитывать такое поведение и избегать размещения любой другой код в оболочке свойства, отличные от методов системы свойств <xref:System.Windows.DependencyObject.GetValue%2A> и <xref:System.Windows.DependencyObject.SetValue%2A>.  

<a name="prerequisites"></a>   
## <a name="prerequisites"></a>Предварительные требования  
 В этом разделе предполагается, что вы, как пользователь и разработчик, понимаете свойства зависимостей и ознакомились с разделами [Общие сведения о свойствах зависимости](dependency-properties-overview.md) и [Пользовательские свойства зависимостей](custom-dependency-properties.md). Следует также прочитать разделы [Общие сведения о языке XAML (WPF)](xaml-overview-wpf.md) и [Подробное описание синтаксиса XAML](xaml-syntax-in-detail.md).  
  
<a name="implementation"></a>   
## <a name="the-wpf-xaml-loader-implementation-and-performance"></a>Реализация загрузчика XAML WPF и производительность  
 В целях реализации требуется значительно меньше затрат для определения свойства как свойства зависимости и доступа к системе свойств <xref:System.Windows.DependencyObject.SetValue%2A> метод, чтобы задать его, а не с помощью оболочки свойства и метода задания значения. Причина этого заключается в том, что процессору XAML требуется вывести всю объектную модель вспомогательного кода, основываясь только на сведениях о типе и связях между членами, которые определены структурой разметки и различными строками.  
  
 Поиск типа осуществляется посредством сочетания элементов xmlns и атрибутов сборки, однако для идентификации членов, определения членов которой можно установить в качестве атрибута, и разрешение типов, поддерживаемых значениями свойств обычно требуется расширенное отражение с помощью <xref:System.Reflection.PropertyInfo>. Так как свойства зависимостей данного типа доступны в виде таблицы хранилища с помощью системы свойств, WPF реализацию его XAML процессора использует эту таблицу и выводит, что любое данное свойство *ABC* может быть эффективнее задано путем вызова <xref:System.Windows.DependencyObject.SetValue%2A> в содержащем <xref:System.Windows.DependencyObject> производный тип, с помощью идентификатора свойства зависимости *ABCProperty*.  
  
<a name="implications"></a>   
## <a name="implications-for-custom-dependency-properties"></a>Последствия использования пользовательских свойств зависимостей  
 Так как текущая реализация процессора XAML в WPF при установке свойства полностью обходит оболочки, не следует помещать дополнительную логику в определения метода set оболочки для пользовательского свойства зависимости. Если поместить такую логику в определение метода set, она не будет выполняться, если свойство задается в XAML, а не в коде.  
  
 Аналогичным образом, другие аспекты XAML процессора, которые получают значения свойств из XAML обработки также используйте <xref:System.Windows.DependencyObject.GetValue%2A> вместо оболочки. Таким образом, следует также избегать любых дополнительных реализаций в `get` определение за пределы <xref:System.Windows.DependencyObject.GetValue%2A> вызова.  
  
 В приведенном ниже примере показано рекомендуемое определение свойства зависимости с оболочками, где идентификатор свойства хранится в виде поля с атрибутами `public` `static` `readonly`, а определения методов `get` и `set` не содержат никакого кода, кроме необходимых методов системы свойств, определяющих резервное свойство зависимости.  
  
 [!code-csharp[WPFAquariumSln#AGWithWrapper](~/samples/snippets/csharp/VS_Snippets_Wpf/WPFAquariumSln/CSharp/WPFAquariumObjects/Class1.cs#agwithwrapper)]
   
  
## <a name="see-also"></a>См. также

- [Общие сведения о свойствах зависимости](dependency-properties-overview.md)
- [Обзор XAML (WPF)](xaml-overview-wpf.md)
- [Метаданные свойства зависимости](dependency-property-metadata.md)
- [Свойства зависимостей типа коллекция](collection-type-dependency-properties.md)
- [Безопасность свойства зависимости](dependency-property-security.md)
- [Шаблоны безопасного конструктора для DependencyObjects](safe-constructor-patterns-for-dependencyobjects.md)
