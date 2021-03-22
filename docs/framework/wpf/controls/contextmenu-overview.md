---
title: Общие сведения о ContextMenu
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- controls [WPF], ContextMenu
- ContextMenu controls [WPF], about ContextMenu controls
ms.assetid: 16909c42-799a-4561-91e0-7d69dcfeea91
ms.openlocfilehash: 1818718d3ca9e8f56da99d6e504b41b217bfd980
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59203552"
---
# <a name="contextmenu-overview"></a>Общие сведения о ContextMenu
<xref:System.Windows.Controls.ContextMenu> Класс представляет элемент, который предоставляет функциональные возможности с помощью контекстно зависимое <xref:System.Windows.Controls.Menu>. Как правило, предоставляется пользователю <xref:System.Windows.Controls.ContextMenu> в [!INCLUDE[TLA#tla_ui](../../../../includes/tlasharptla-ui-md.md)] щелкнув правой кнопкой мыши. В данном разделе представлены <xref:System.Windows.Controls.ContextMenu> элемент и приводятся примеры того, как использовать его в [!INCLUDE[TLA#tla_xaml](../../../../includes/tlasharptla-xaml-md.md)] и кода.  

<a name="contextmenu_control"></a>   
## <a name="contextmenu-control"></a>Элемент управления ContextMenu  
 Объект <xref:System.Windows.Controls.ContextMenu> подключен с конкретным элементом управления. <xref:System.Windows.Controls.ContextMenu> Элемент позволяет представлять пользователям список элементов, определяющих команды или параметры, связанные с определенным элементом управления, например, <xref:System.Windows.Controls.Button>. Пользователи нажимают правой кнопкой мыши элемент управления, чтобы появилось меню. Как правило, щелкнув <xref:System.Windows.Controls.MenuItem> открывается подменю или вызывает приложение для выполнения команды.  
  
<a name="creating_contextmenus"></a>   
## <a name="creating-contextmenus"></a>Создание элементов ContextMenu  
 Следующие примеры демонстрируют создание <xref:System.Windows.Controls.ContextMenu> с вложенными меню. <xref:System.Windows.Controls.ContextMenu> Вложенные элементы управления для элемента управления button.  
  
 [!code-xaml[ContextMenu#1](~/samples/snippets/csharp/VS_Snippets_Wpf/ContextMenu/CSharp/Pane1.xaml#1)]  
  
 [!code-csharp[ContextMenu#2](~/samples/snippets/csharp/VS_Snippets_Wpf/ContextMenu/CSharp/Pane1.xaml.cs#2)]
   
  
<a name="applying_styles_to_contextmenu"></a>   
## <a name="applying-styles-to-a-contextmenu"></a>Применение стилей к ContextMenu  
 С помощью элемента управления <xref:System.Windows.Style>, можно значительно изменить внешний вид и поведение <xref:System.Windows.Controls.ContextMenu> без написания пользовательского элемента управления. В дополнение к установке визуальных свойств также можно применить стили к частям элемента управления. Например, можно изменить поведение частей элемента управления с помощью свойств, или можно добавлять части или изменить макет, <xref:System.Windows.Controls.ContextMenu>. В следующих примерах показано несколько способов добавления стилей к <xref:System.Windows.Controls.ContextMenu> элементов управления.  
  
 В первом примере определяется стиль с именем `SimpleSysResources`, который показывает, как использовать текущие параметры системы в стиле. Этот пример назначает <xref:System.Windows.SystemColors.MenuHighlightBrushKey%2A> как <xref:System.Windows.Controls.Control.Background%2A> цвет и <xref:System.Windows.SystemColors.MenuTextBrushKey%2A> как <xref:System.Windows.Controls.Control.Foreground%2A> цвет <xref:System.Windows.Controls.ContextMenu>.  
  
```xaml  
<Style x:Key="SimpleSysResources" TargetType="{x:Type MenuItem}">  
  <Setter Property = "Background" Value=   
    "{DynamicResource {x:Static SystemColors.MenuHighlightBrushKey}}"/>  
  <Setter Property = "Foreground" Value=   
    "{DynamicResource {x:Static SystemColors.MenuTextBrushKey}}"/>  
</Style>  
```  
  
 В следующем примере используется <xref:System.Windows.Trigger> элемент для изменения внешнего вида <xref:System.Windows.Controls.Menu> в ответ на события, возникающие на <xref:System.Windows.Controls.ContextMenu>. Когда пользователь перемещает мышь поверх меню, внешний вид <xref:System.Windows.Controls.ContextMenu> элементы изменения.  
  
```xaml  
<Style x:Key="Triggers" TargetType="{x:Type MenuItem}">  
  <Style.Triggers>  
    <Trigger Property="MenuItem.IsMouseOver" Value="true">  
      <Setter Property = "FontSize" Value="16"/>  
      <Setter Property = "FontStyle" Value="Italic"/>  
      <Setter Property = "Foreground" Value="Red"/>  
    </Trigger>  
  </Style.Triggers>  
</Style>  
```  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Controls.ContextMenu>
- <xref:System.Windows.Style>
- <xref:System.Windows.Controls.Menu>
- <xref:System.Windows.Controls.MenuItem>
- [ContextMenu](contextmenu.md)
- [Стили и шаблоны элемента ContextMenu](contextmenu-styles-and-templates.md)
- [Пример коллекции элементов управления WPF](https://go.microsoft.com/fwlink/?LinkID=160053)
