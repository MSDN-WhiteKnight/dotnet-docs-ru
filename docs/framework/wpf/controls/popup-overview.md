---
title: Общие сведения о контекстном меню
ms.date: 03/30/2017
helpviewer_keywords:
- controls [WPF], Popup
- Popup control [WPF], about Popup control
ms.assetid: 774f53ca-bff8-470e-9ce9-3928b4cf3d4c
ms.openlocfilehash: 370970c80221e371db5a97303ef2650d14300b14
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59102782"
---
# <a name="popup-overview"></a>Общие сведения о контекстном меню
<xref:System.Windows.Controls.Primitives.Popup> Управления предоставляет способ отображения содержимого в отдельном окне, расположенном поверх текущего окна приложения относительно обозначенного элемента или экранных координат. В данном разделе представлены <xref:System.Windows.Controls.Primitives.Popup> управления и предоставляет сведения о его использовании.  

<a name="What_Is_a_Popup_"></a>   
## <a name="what-is-a-popup"></a>Что такое контекстное меню?  
 Объект <xref:System.Windows.Controls.Primitives.Popup> управления отображает содержимое в отдельном окне относительно элемента или точки на экране. Когда <xref:System.Windows.Controls.Primitives.Popup> является видимым, <xref:System.Windows.Controls.Primitives.Popup.IsOpen%2A> свойству `true`.  
  
> [!NOTE]
>  Объект <xref:System.Windows.Controls.Primitives.Popup> не открывается автоматически при перемещении указателя мыши на родительский объект. Если вы хотите, чтобы <xref:System.Windows.Controls.Primitives.Popup> чтобы автоматически открыть, используйте <xref:System.Windows.Controls.ToolTip> или <xref:System.Windows.Controls.ToolTipService> класса. Дополнительные сведения см. в разделе [Общие сведения о всплывающих подсказках](tooltip-overview.md).  
  
<a name="APopupExample"></a>   
## <a name="creating-a-popup"></a>Создание всплывающего окна  
 В следующем примере показано определение <xref:System.Windows.Controls.Primitives.Popup> управления, являющийся дочерним элементом элемента <xref:System.Windows.Controls.Button> элемента управления. Так как <xref:System.Windows.Controls.Button> может иметь только один дочерний элемент, в этом примере помещает текст для <xref:System.Windows.Controls.Button> и <xref:System.Windows.Controls.Primitives.Popup> элементов управления в <xref:System.Windows.Controls.StackPanel>. Содержание <xref:System.Windows.Controls.Primitives.Popup> отображается в <xref:System.Windows.Controls.TextBlock> элемент управления, который отображает текст в отдельном окне, расположенном поверх окна приложения рядом с соответствующим <xref:System.Windows.Controls.Button> элемента управления.  
  
 [!code-xaml[PopupSimple#1](~/samples/snippets/csharp/VS_Snippets_Wpf/PopupSimple/CSharp/Window1.xaml#1)]  
  
 [!code-xaml[PopupSimple#CreatePopupCodeXAML](~/samples/snippets/csharp/VS_Snippets_Wpf/PopupSimple/CSharp/Window1.xaml#createpopupcodexaml)]  
  
<a name="PopupUses"></a>   
## <a name="controls-that-implement-a-popup"></a>Элементы управления, реализующие контекстное меню  
 Вы можете создавать <xref:System.Windows.Controls.Primitives.Popup> элементы управления в другие элементы управления. Следующие элементы управления реализуют <xref:System.Windows.Controls.Primitives.Popup> управления для конкретных целей:  
  
-   <xref:System.Windows.Controls.ToolTip>. Если вы хотите создать подсказку для элемента, используйте <xref:System.Windows.Controls.ToolTip> и <xref:System.Windows.Controls.ToolTipService> классы. Дополнительные сведения см. в разделе [Общие сведения о всплывающих подсказках](tooltip-overview.md).  
  
-   <xref:System.Windows.Controls.ContextMenu>. Если вы хотите создать контекстное меню для элемента, используйте <xref:System.Windows.Controls.ContextMenu> элемента управления. Дополнительные сведения см. в разделе [Общие сведения об элементе управления ContextMenu](contextmenu-overview.md).  
  
-   <xref:System.Windows.Controls.ComboBox>. Если вы хотите создать элемент управления выбора, который содержит поле с раскрывающимся списком, может быть использовано отображаемое или скрытое, <xref:System.Windows.Controls.ComboBox> элемента управления.  
  
-   <xref:System.Windows.Controls.Expander>. Если вы хотите создать элемент управления, отображающий заголовок со свертываемой областью отображения содержимого, используйте <xref:System.Windows.Controls.Expander> элемента управления. Дополнительные сведения см. в разделе [Общие сведения об элементе управления Expander](expander-overview.md).  
  
<a name="PopupBehaviorandAppearance"></a>   
## <a name="popup-behavior-and-appearance"></a>Внешний вид и поведение контекстного меню  
 <xref:System.Windows.Controls.Primitives.Popup> Управления предоставляет функциональность, позволяющую настраивать свое поведение и внешний вид. Например, можно задать поведение открытия и закрытия, анимацию, эффекты прозрачности и точечного рисунка, и <xref:System.Windows.Controls.Primitives.Popup> размер и положение.  
  
<a name="OpenandCloseBehavior"></a>   
### <a name="open-and-close-behavior"></a>Поведение открытия и закрытия  
 Объект <xref:System.Windows.Controls.Primitives.Popup> отображает содержимое элемента управления, когда <xref:System.Windows.Controls.Primitives.Popup.IsOpen%2A> свойству `true`. По умолчанию <xref:System.Windows.Controls.Primitives.Popup> остается открытым до <xref:System.Windows.Controls.Primitives.Popup.IsOpen%2A> свойству `false`. Тем не менее, можно изменить поведение по умолчанию, задав <xref:System.Windows.Controls.Primitives.Popup.StaysOpen%2A> свойства `false`. Если задано это свойство `false`, <xref:System.Windows.Controls.Primitives.Popup> окно содержимого имеет захват мыши. <xref:System.Windows.Controls.Primitives.Popup> Теряет мыши захвата и окно закрывается при возникновении события мыши за пределами <xref:System.Windows.Controls.Primitives.Popup> окна.  
  
 <xref:System.Windows.Controls.Primitives.Popup.Opened> И <xref:System.Windows.Controls.Primitives.Popup.Closed> событий при <xref:System.Windows.Controls.Primitives.Popup> окно содержимого открытым или закрытым.  
  
<a name="Animation"></a>   
### <a name="animation"></a>Анимация  
 <xref:System.Windows.Controls.Primitives.Popup> Элемент управления имеет встроенную поддержку анимаций, которые обычно связаны с таким поведением, как постепенное появление и. Эти анимации можно включить, задав <xref:System.Windows.Controls.Primitives.Popup.PopupAnimation%2A> свойства <xref:System.Windows.Controls.Primitives.PopupAnimation> значение перечисления. Для <xref:System.Windows.Controls.Primitives.Popup> анимации работал правильно, необходимо задать <xref:System.Windows.Controls.Primitives.Popup.AllowsTransparency%2A> свойства `true`.  
  
 Можно также применить анимацию, например <xref:System.Windows.Media.Animation.Storyboard> для <xref:System.Windows.Controls.Primitives.Popup> элемента управления.  
  
<a name="OpacityandBitmapEffects"></a>   
### <a name="opacity-and-bitmap-effects"></a>Прозрачность и эффекты для точечных рисунков  
 <xref:System.Windows.UIElement.Opacity%2A> Свойство для <xref:System.Windows.Controls.Primitives.Popup> управления не влияет на его содержимое. По умолчанию <xref:System.Windows.Controls.Primitives.Popup> окно содержимого непрозрачно. Для создания прозрачного <xref:System.Windows.Controls.Primitives.Popup>, задайте <xref:System.Windows.Controls.Primitives.Popup.AllowsTransparency%2A> свойства `true`.  
  
 Содержание <xref:System.Windows.Controls.Primitives.Popup> не наследует эффекты для точечных рисунков, таких как <xref:System.Windows.Media.Effects.DropShadowBitmapEffect>, непосредственно указать на <xref:System.Windows.Controls.Primitives.Popup> управления или любого другого элемента родительского окна. Для отображения содержимого из эффектов точечного рисунка <xref:System.Windows.Controls.Primitives.Popup>, необходимо задать эффект точечного рисунка непосредственно для его содержимого. Например если дочернего элемента для <xref:System.Windows.Controls.Primitives.Popup> — <xref:System.Windows.Controls.StackPanel>, задайте эффект точечного рисунка на <xref:System.Windows.Controls.StackPanel>.  
  
<a name="PopupSize"></a>   
### <a name="popup-size"></a>Размер контекстного меню  
 По умолчанию <xref:System.Windows.Controls.Primitives.Popup> автоматически изменяется в соответствии с его содержимым. В случае автоматического изменения размера некоторые эффекты точечного рисунка могут быть скрыты, поскольку размер по умолчанию области экрана, который определен для <xref:System.Windows.Controls.Primitives.Popup> содержимого не предоставляет достаточно места для отображения эффектов точечного рисунка.  
  
 <xref:System.Windows.Controls.Primitives.Popup> содержимое может быть скрыто при установке <xref:System.Windows.UIElement.RenderTransform%2A> содержимого. В этом случае часть содержимого может быть скрыт, если содержимое преобразованного <xref:System.Windows.Controls.Primitives.Popup> выходит за пределы области исходного <xref:System.Windows.Controls.Primitives.Popup>. Если эффект точечного рисунка или преобразования требуется больше места, можно определить поля вокруг <xref:System.Windows.Controls.Primitives.Popup> содержимого, чтобы освободить больше пространства для элемента управления.  
  
<a name="DefiningPopupPosition"></a>   
## <a name="defining-the-popup-position"></a>Определение положения контекстного меню  
 Можно разместить всплывающее окно, задав <xref:System.Windows.Controls.Primitives.Popup.PlacementTarget%2A>, <xref:System.Windows.Controls.Primitives.Popup.PlacementRectangle%2A>, <xref:System.Windows.Controls.Primitives.Popup.Placement%2A>, <xref:System.Windows.Controls.Primitives.Popup.HorizontalOffset%2A>, и <xref:System.Windows.Controls.Primitives.Popup.VerticalOffsetProperty> свойства. Дополнительные сведения см. в разделе [Поведение при размещении контекстного меню](popup-placement-behavior.md). Когда <xref:System.Windows.Controls.Primitives.Popup> отображается на экране, его положение не перемещен родительского.  
  
<a name="CustomizingPopupPlacement"></a>   
### <a name="customizing-popup-placement"></a>Настройка размещения контекстного меню  
 Вы можете настроить размещение <xref:System.Windows.Controls.Primitives.Popup> управления, указав набор координат, относящихся к <xref:System.Windows.Controls.Primitives.Popup.PlacementTarget%2A> место <xref:System.Windows.Controls.Primitives.Popup> для отображения.  
  
 Чтобы настроить размещение, задайте <xref:System.Windows.Controls.Primitives.Popup.Placement%2A> свойства <xref:System.Windows.Controls.Primitives.PlacementMode.Custom>. Затем определите <xref:System.Windows.Controls.Primitives.CustomPopupPlacementCallback> делегат, который возвращает набор возможных точек размещения и основные оси (в порядке предпочтения) для <xref:System.Windows.Controls.Primitives.Popup>. Точка, в которой отображается наибольшая часть <xref:System.Windows.Controls.Primitives.Popup> выбирается автоматически. См. пример в разделе [Указание пользовательского расположения контекстного меню](how-to-specify-a-custom-popup-position.md).  
  
<a name="PopupandtheVisualTree"></a>   
## <a name="popup-and-the-visual-tree"></a>Контекстное меню и визуальное дерево  
 Объект <xref:System.Windows.Controls.Primitives.Popup> управления не имеет собственного визуального дерева; вместо этого он возвращает размер 0 (нулю) при <xref:System.Windows.Controls.Primitives.Popup.MeasureOverride%2A> метод <xref:System.Windows.Controls.Primitives.Popup> вызывается. Тем не менее, если выбрано <xref:System.Windows.Controls.Primitives.Popup.IsOpen%2A> свойство <xref:System.Windows.Controls.Primitives.Popup> для `true`, создается новое окно со своим собственным визуальным деревом. Новое окно включает <xref:System.Windows.Controls.Primitives.Popup.Child%2A> содержимое <xref:System.Windows.Controls.Primitives.Popup>. Ширина и высота нового окна не могут превышать 75 процентов от ширины или высоты экрана.  
  
 <xref:System.Windows.Controls.Primitives.Popup> Элемент управления сохраняет ссылку на его <xref:System.Windows.Controls.Primitives.Popup.Child%2A> содержимое в виде логических дочерних. При создании нового окна содержимое <xref:System.Windows.Controls.Primitives.Popup> становится визуальным дочерним элементом окна и остается логическим дочерним элементом <xref:System.Windows.Controls.Primitives.Popup>. И наоборот <xref:System.Windows.Controls.Primitives.Popup> остается логическим родительским из его <xref:System.Windows.Controls.Primitives.Popup.Child%2A> содержимого.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Controls.Primitives.Popup>
- <xref:System.Windows.Controls.Primitives.PopupPrimaryAxis>
- <xref:System.Windows.Controls.Primitives.PlacementMode>
- <xref:System.Windows.Controls.Primitives.CustomPopupPlacement>
- <xref:System.Windows.Controls.Primitives.CustomPopupPlacementCallback>
- <xref:System.Windows.Controls.ToolTip>
- <xref:System.Windows.Controls.ToolTipService>
- [Практические руководства](popup-how-to-topics.md)
- [Практические руководства](tooltip-how-to-topics.md)
