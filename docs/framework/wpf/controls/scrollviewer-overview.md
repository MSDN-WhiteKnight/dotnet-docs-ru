---
title: Общие сведения об элементе управления ScrollViewer
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- controls [WPF], ScrollViewer
- ScrollViewer control [WPF], about ScrollViewer control
ms.assetid: 94a13b94-cfdf-4b12-a1aa-90cb50c6e9b9
ms.openlocfilehash: a3302d9c360b0918a1fce956af3e3aa14f29361b
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59212431"
---
# <a name="scrollviewer-overview"></a>Общие сведения об элементе управления ScrollViewer
Часто содержимое в пользовательском интерфейсе занимает больше места, чем вмещает область отображения на экране компьютера. <xref:System.Windows.Controls.ScrollViewer> Элемент управления предоставляет удобный способ включить прокрутку содержимого в [!INCLUDE[TLA#tla_winclient](../../../../includes/tlasharptla-winclient-md.md)] приложений. В данном разделе представлены <xref:System.Windows.Controls.ScrollViewer> элемент и приводится несколько примеров использования.  
  
<a name="what_is_a_scrollviewer_element"></a>   
## <a name="the-scrollviewer-control"></a>Элемент управления ScrollViewer  
 Существуют два предварительно определенных элемента, обеспечивающих прокрутку в WPF приложений: <xref:System.Windows.Controls.Primitives.ScrollBar> и <xref:System.Windows.Controls.ScrollViewer>. <xref:System.Windows.Controls.ScrollViewer> Управления инкапсулирует горизонтальном и вертикальном <xref:System.Windows.Controls.Primitives.ScrollBar> элементов и контейнер содержимого (например, <xref:System.Windows.Controls.Panel> элемент) для отображения других видимых элементов в прокручиваемой области. Необходимо выполнить сборку пользовательского объекта для использования <xref:System.Windows.Controls.Primitives.ScrollBar> элемента для прокрутки содержимого. Тем не менее, можно использовать <xref:System.Windows.Controls.ScrollViewer> элемент сам по себе, так как это составной элемент управления, который инкапсулирует <xref:System.Windows.Controls.Primitives.ScrollBar> функциональные возможности.  
  
 <xref:System.Windows.Controls.ScrollViewer> Элемент управления реагирует на команды мыши и клавиатуры и определяет множество методов для прокрутки содержимого на предопределенные значения приращения. Можно использовать <xref:System.Windows.Controls.ScrollViewer.ScrollChanged> событий для обнаружения изменений в <xref:System.Windows.Controls.ScrollViewer> состояние.  
  
 Объект <xref:System.Windows.Controls.ScrollViewer> может иметь только один дочерний элемент, обычно <xref:System.Windows.Controls.Panel> элемент, который может содержать <xref:System.Windows.Controls.Panel.Children%2A> коллекции элементов. <xref:System.Windows.Controls.ContentPresenter.Content%2A> Свойство определяет единственного потомка <xref:System.Windows.Controls.ScrollViewer>.  
  
<a name="scrollviewer_physical_vs_logical"></a>   
## <a name="physical-vs-logical-scrolling"></a>Физическая и логическая прокрутка  
 Физическая прокрутка используется для прокрутки на предопределенное приращение, которое обычно является значением, объявленным в пикселях. Логическая прокрутка используется для прокрутки к следующему элементу в логическом дереве. Физическая прокрутка является поведением прокрутки по умолчанию для большинства <xref:System.Windows.Controls.Panel> элементов. WPF поддерживает оба типа прокрутки.  
  
#### <a name="the-iscrollinfo-interface"></a>Интерфейс IScrollInfo  
 <xref:System.Windows.Controls.Primitives.IScrollInfo> Интерфейс представляет основную область прокрутки в <xref:System.Windows.Controls.ScrollViewer> или производном элементе управления. Интерфейс определяет свойства и методы, которые могут быть реализованы прокрутки <xref:System.Windows.Controls.Panel> элементов, требующими прокрутки на логическую единицу, а не на физическое приращение. Приведение экземпляра класса <xref:System.Windows.Controls.Primitives.IScrollInfo> к производному <xref:System.Windows.Controls.Panel> и затем использование его методов прокрутки обеспечивают удобный способ выполнить прокрутку до следующей логической единице в дочерней коллекции, а не приращение в пикселях. По умолчанию <xref:System.Windows.Controls.ScrollViewer> элемент управления поддерживает прокрутку на физические единицы.  
  
 <xref:System.Windows.Controls.StackPanel> и <xref:System.Windows.Controls.VirtualizingStackPanel> реализуют <xref:System.Windows.Controls.Primitives.IScrollInfo> и имеют встроенную поддержку логической прокрутки. Для элементов управления разметкой, встроенную поддержку логической прокрутки, можно реализовать физическую прокрутку путем переноса узла <xref:System.Windows.Controls.Panel> элемент в <xref:System.Windows.Controls.ScrollViewer> и параметр <xref:System.Windows.Controls.ScrollViewer.CanContentScroll%2A> свойства `false`.  
  
 В следующем примере кода показано, как привести экземпляр <xref:System.Windows.Controls.Primitives.IScrollInfo> для <xref:System.Windows.Controls.StackPanel> и использование методов прокрутки содержимого (<xref:System.Windows.Controls.Primitives.IScrollInfo.LineUp%2A> и <xref:System.Windows.Controls.Primitives.IScrollInfo.LineDown%2A>) определенные в интерфейсе.  
  
 [!code-csharp[IScrollInfoMethods#3](~/samples/snippets/csharp/VS_Snippets_Wpf/IScrollInfoMethods/CSharp/Window1.xaml.cs#3)]
   
  
<a name="scrollviewer_markup_syntax_and_sample"></a>   
## <a name="defining-and-using-a-scrollviewer-element"></a>Определение и использование элемента ScrollViewer  
 В следующем примере создается <xref:System.Windows.Controls.ScrollViewer> в окно, содержащее текст и прямоугольник. <xref:System.Windows.Controls.Primitives.ScrollBar> элементы отображаются, только когда они необходимы. При изменении размера окна, <xref:System.Windows.Controls.Primitives.ScrollBar> элементы появляются и исчезают в результате изменения значений из <xref:System.Windows.Controls.ScrollViewer.ComputedHorizontalScrollBarVisibility%2A> и <xref:System.Windows.Controls.ScrollViewer.ComputedVerticalScrollBarVisibility%2A> свойства.  
  
 
 [!code-csharp[ScrollViewer#1](~/samples/snippets/csharp/VS_Snippets_Wpf/ScrollViewer/CSharp/ScrollViewer_wcp.cs#1)]
 
 [!code-xaml[ScrollViewer#1](~/samples/snippets/xaml/VS_Snippets_Wpf/ScrollViewer/XAML/Pane1.xaml#1)]  
  
<a name="scrollviewer_styling_scrollviewer"></a>   
## <a name="styling-a-scrollviewer"></a>Стили элемента управления ScrollViewer  
 Как и все элементы в Windows Presentation Foundation, <xref:System.Windows.Controls.ScrollViewer> можно применить различные стили для изменения поведения отрисовки по умолчанию элемента управления. Дополнительные сведения о стилях элементов управления см. в разделе [Стилизация и использование шаблонов](styling-and-templating.md).  
  
<a name="scrollviewer_scroll_vs_paginate"></a>   
## <a name="paginating-documents"></a>Разбивка документов на страницы  
 Альтернативой прокрутке содержимого документа является контейнер документа, поддерживающий разбиение на страницы. <xref:System.Windows.Documents.FlowDocument> предназначен для документов, которые предназначены для размещения в элементе управления просмотра, такие как <xref:System.Windows.Controls.FlowDocumentPageViewer>, который поддерживает разбивку содержимого на несколько страниц, устраняет необходимость в прокрутке. <xref:System.Windows.Controls.DocumentViewer> предоставляет решение для просмотра <xref:System.Windows.Documents.FixedDocument> содержимое, которое используется традиционная прокрутка для отображения содержимого за пределы области отображения.  
  
 Дополнительные сведения о форматах документа и параметрах представления см. в разделе [Документы в WPF](../advanced/documents-in-wpf.md).  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Controls.ScrollViewer>
- <xref:System.Windows.Controls.Primitives.ScrollBar>
- <xref:System.Windows.Controls.Primitives.IScrollInfo>
- [Практическое руководство. Создание средства прокрутки](https://docs.microsoft.com/previous-versions/dotnet/netframework-3.5/ms752352(v=vs.90))
- [Документы в WPF](../advanced/documents-in-wpf.md)
- [Стили и шаблоны элемента ScrollBar](scrollbar-styles-and-templates.md)
- [Элементы управления](../advanced/optimizing-performance-controls.md)
