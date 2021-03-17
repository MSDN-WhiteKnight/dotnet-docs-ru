---
title: Общие сведения об эффектах для точечных рисунков
ms.date: 03/30/2017
helpviewer_keywords:
- bitmap effects [WPF]
ms.assetid: 23cb338e-4b59-4b52-b294-96431f9c9568
ms.openlocfilehash: 1866ba7a5419ea435a56daa63f94122d3b83473e
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59166898"
---
# <a name="bitmap-effects-overview"></a>Общие сведения об эффектах для точечных рисунков
Растровые эффекты позволяют конструкторам и разработчикам применять визуальные эффекты к просмотру содержимого Windows Presentation Foundation (WPF). Например, растровые эффекты позволяют легко применить <xref:System.Windows.Media.Effects.DropShadowBitmapEffect> эффект или эффект размытия для изображения или кнопки.  
  
> [!IMPORTANT]
>  В [!INCLUDE[net_v40_short](../../../../includes/net-v40-short-md.md)] или более поздней версии, <xref:System.Windows.Media.Effects.BitmapEffect> класс является устаревшим. Если вы попытаетесь использовать <xref:System.Windows.Media.Effects.BitmapEffect> класса, будет вызвано исключение устаревшего. Неустаревшая альтернатива для <xref:System.Windows.Media.Effects.BitmapEffect> класс является <xref:System.Windows.Media.Effects.Effect> класса. В большинстве случаев <xref:System.Windows.Media.Effects.Effect> класс значительно быстрее.  

<a name="wpf_effects"></a>   
## <a name="wpf-bitmap-effects"></a>Растровые эффекты WPF  
 Эффекты для точечных рисунков (<xref:System.Windows.Media.Effects.BitmapEffect> объекта) — это простой пикселей операции обработки. Растровый эффект принимает <xref:System.Windows.Media.Imaging.BitmapSource> как входных данных и выдает новый <xref:System.Windows.Media.Imaging.BitmapSource> после применения эффекта, например размытия или тени. Каждый растровый эффект обеспечивает свойства, которые могут управлять свойствами фильтра, такими как <xref:System.Windows.Media.Effects.BlurBitmapEffect.Radius%2A> из <xref:System.Windows.Media.Effects.BlurBitmapEffect>.  
  
 Как особый случай в [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)], эффекты могут задаваться как свойства в реальном времени <xref:System.Windows.Media.Visual> объекты, такие как <xref:System.Windows.Controls.Button> или <xref:System.Windows.Controls.TextBox>. Обработка пикселей применяется и отображается во время выполнения. В этом случае во время подготовки к просмотру <xref:System.Windows.Media.Visual> автоматически преобразуется в его <xref:System.Windows.Media.Imaging.BitmapSource> эквивалентное и передается в качестве входных данных для <xref:System.Windows.Media.Effects.BitmapEffect>. Выходные данные заменяют <xref:System.Windows.Media.Visual> поведение отрисовки по умолчанию для объекта. Вот почему <xref:System.Windows.Media.Effects.BitmapEffect> объектов заставляют визуальные для подготовки к просмотру в программном обеспечении только т. е. без аппаратного ускорения на визуальных элементах при применении эффектов.  
  
-   <xref:System.Windows.Media.Effects.BlurBitmapEffect> имитирует объект, который отображается вне в фокусе.  
  
-   <xref:System.Windows.Media.Effects.OuterGlowBitmapEffect> Создает цветное свечение по периметру объекта.  
  
-   <xref:System.Windows.Media.Effects.DropShadowBitmapEffect> создает тень позади объекта.  
  
-   <xref:System.Windows.Media.Effects.BevelBitmapEffect> Создает Рельеф, поднимающий поверхность изображения в соответствии с указанной кривой.  
  
-   <xref:System.Windows.Media.Effects.EmbossBitmapEffect> Создает рельефа <xref:System.Windows.Media.Visual> впечатление глубины и текстуры от искусственного источника света.  
  
> [!NOTE]
>  [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)] эффекты для точечных рисунков подготавливаются к просмотру в режиме программного обеспечения. Любой объект, который применяет эффект, будет также отрисован в программном режиме. Производительность наиболее снижается при использовании растровых эффектов на больших визуальных объектах или при анимации свойств растрового эффекта. Это не означает, что не следует вовсе использовать растровые эффекты, но следует соблюдать осторожность и выполнять тщательное тестирование, чтобы убедиться, что пользователи получат то, что вы ожидаете.  
  
> [!NOTE]
>  [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)] Эффекты для точечных рисунков не поддерживают выполнение при частичном доверии. Для использования растровых эффектов приложение должно иметь разрешения полного доверия.  
  
<a name="applyeffects"></a>   
## <a name="how-to-apply-an-effect"></a>Применение эффекта  
 <xref:System.Windows.Media.Effects.BitmapEffect> является свойством <xref:System.Windows.Media.Visual>. Поэтому применение эффектов к визуальным элементам, такие как <xref:System.Windows.Controls.Button>, <xref:System.Windows.Controls.Image>, <xref:System.Windows.Media.DrawingVisual>, или <xref:System.Windows.UIElement>, так же просто, как задание свойства. <xref:System.Windows.UIElement.BitmapEffect%2A> можно задать единое <xref:System.Windows.Media.Effects.BitmapEffect> объект или несколько эффектов можно объединить в цепочку с помощью <xref:System.Windows.Media.Effects.BitmapEffectGroup> объекта.  
  
 Следующий пример демонстрирует применение <xref:System.Windows.Media.Effects.BitmapEffect> в [!INCLUDE[TLA#tla_xaml](../../../../includes/tlasharptla-xaml-md.md)].  
  
 [!code-xaml[EffectsGallery_snip#BlurSimpleExampleInline](~/samples/snippets/csharp/VS_Snippets_Wpf/EffectsGallery_snip/CSharp/blursimpleexample.xaml#blursimpleexampleinline)]  
  
 Следующий пример демонстрирует применение <xref:System.Windows.Media.Effects.BitmapEffect> в коде.  
  
 [!code-csharp[EffectsGallery_snip#CodeBehindBlurCodeBehindExampleInline](~/samples/snippets/csharp/VS_Snippets_Wpf/EffectsGallery_snip/CSharp/blurcodebehindexample.xaml.cs#codebehindblurcodebehindexampleinline)]  
  
> [!NOTE]
>  Когда <xref:System.Windows.Media.Effects.BitmapEffect> применяется к контейнеру макета, такие как <xref:System.Windows.Controls.DockPanel> или <xref:System.Windows.Controls.Canvas>, эффект применяется к визуальному дереву элемента или визуального элемента, включая все его дочерние элементы.  
  
<a name="customeffects"></a>   
## <a name="creating-custom-effects"></a>Создание пользовательских эффектов  
 [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)] также предоставляет неуправляемые интерфейсы для создания пользовательских эффектов, которые могут быть использованы в управляемом [!INCLUDE[TLA2#tla_wpf](../../../../includes/tla2sharptla-wpf-md.md)] приложений. Дополнительные справочные материалы для создания пользовательских растровых эффектов см. в разделе [Неуправляемые растровые эффекты WPF](https://docs.microsoft.com/previous-versions/windows/desktop/wibe/-wibe-lh).  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Media.Effects.BitmapEffectGroup>
- <xref:System.Windows.Media.Effects.BitmapEffectInput>
- <xref:System.Windows.Media.Effects.BitmapEffectCollection>
- [Неуправляемые растровые эффекты WPF](https://docs.microsoft.com/previous-versions/windows/desktop/wibe/-wibe-lh)
- [Общие сведения об обработке изображений](imaging-overview.md)
- [Безопасность](../security-wpf.md)
- [Общие сведения об отрисовке графики в WPF](wpf-graphics-rendering-overview.md)
- [Двумерная графика и изображения](../advanced/optimizing-performance-2d-graphics-and-imaging.md)
