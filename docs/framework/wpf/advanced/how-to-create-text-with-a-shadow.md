---
title: Практическое руководство. Создание текста с тенью
ms.date: 03/30/2017
helpviewer_keywords:
- typography [WPF], shadow effects
- shadow effects in text [WPF]
- text [WPF], shadowed
ms.assetid: 6ab9c754-6001-4708-b479-5367f2fd1a35
ms.openlocfilehash: a2225e297dbc0b5f9d49799cb34eb5539746e62e
ms.sourcegitcommit: 16aefeb2d265e69c0d80967580365fabf0c5d39a
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/16/2019
ms.locfileid: "58125789"
---
# <a name="how-to-create-text-with-a-shadow"></a>Практическое руководство. Создание текста с тенью
Примеры в этом разделе демонстрируют создание эффекта тени для отображаемого текста.  
  
## <a name="example"></a>Пример  
 <xref:System.Windows.Media.Effects.DropShadowEffect> Объекта позволяет создавать разнообразные эффекты тени для Windows Presentation Foundation (WPF) объектов. В следующем примере показано применение эффекта тени к тексту. В этом случае используется мягкая тень, то есть цвет тени размывается.  
  
 ![Тень текста с мягкостью &#61; 0,25](./media/how-to-create-text-with-a-shadow/drop-shadow-text-effect.jpg) 
  
 Ширину тени можно управлять, задав <xref:System.Windows.Media.Effects.DropShadowEffect.ShadowDepth%2A> свойство. Значение `4.0` обозначает ширину тени, равную 4 точкам. Можно управлять мягкости или размытия тени, изменив <xref:System.Windows.Media.Effects.DropShadowEffect.BlurRadius%2A> свойство. Значение `0.0` указывает на отсутствие размытия. В следующем примере кода показано создание мягкой тени.  
  
 [!code-xaml[TextShadowSnippets#TextShadowSnippet1](~/samples/snippets/csharp/VS_Snippets_Wpf/TextShadowSnippets/CS/SingleShadows.xaml#textshadowsnippet1)]  
  
> [!NOTE]
>  Эти эффекты тени не проходят через Windows Presentation Foundation (WPF) конвейера отрисовки текста. Следовательно, тип ClearType при использовании этих эффектов отключен.  
  
 В следующем примере показано применение эффекта жесткой тени к тексту. В этом случае тень не размыта.  
  
 ![Тень текста с мягкостью &#61; 0](./media/how-to-create-text-with-a-shadow/text-shadow-softness.jpg) 
  
 Можно создать жесткую тень, задав <xref:System.Windows.Media.Effects.DropShadowEffect.BlurRadius%2A> свойства `0.0`, который указывает, что отсутствие размытия. Можно контролировать направление тени, изменив <xref:System.Windows.Media.Effects.DropShadowEffect.Direction%2A> свойство. Значение этого свойства градус от `0` и `360`. На следующем рисунке показан значения направления <xref:System.Windows.Media.Effects.DropShadowEffect.Direction%2A> значение свойства.  
  
 ![Параметр степени тени DropShadow](./media/how-to-create-text-with-a-shadow/drop-shadow-degree-setting.png)
  
 В следующем примере кода показано создание жесткой тени.  
  
 [!code-xaml[TextShadowSnippets#TextShadowSnippet2](~/samples/snippets/csharp/VS_Snippets_Wpf/TextShadowSnippets/CS/SingleShadows.xaml#textshadowsnippet2)]  
  
## <a name="using-a-blur-effect"></a>Использование эффекта размытия  
 Объект <xref:System.Windows.Media.Effects.BlurBitmapEffect> может быть использован для создания аналогичного эффекта тени, который можно разместить позади текстового объекта. Если к тексту применяется эффект размытия для точечных рисунков, текст равномерно размывается во всех направлениях.  
  
 В следующем примере показан эффект размытия, примененный к тексту.  
  
 ![Тень текста с использованием BlurBitmapEffect](./media/how-to-create-text-with-a-shadow/text-shadow-blur-effect.jpg)  
  
 В следующем примере кода показано создание эффекта размытия.  
  
 [!code-xaml[TextShadowSnippets#TextShadowSnippet6](~/samples/snippets/csharp/VS_Snippets_Wpf/TextShadowSnippets/CS/BlurShadows.xaml#textshadowsnippet6)]  
  
## <a name="using-a-translate-transform"></a>Использование преобразования переноса  
 Объект <xref:System.Windows.Media.TranslateTransform> может быть использован для создания аналогичного эффекта тени, который можно разместить позади текстового объекта.  
  
 В следующем примере кода используется <xref:System.Windows.Media.TranslateTransform> для смещения текста. В этом примере слегка смещенная копия текста под основным текстом создает эффект тени.  
  
 ![Тень текста с использованием TranslateTransform](./media/how-to-create-text-with-a-shadow/text-transform-shadow-effect.jpg)    
  
 В следующем примере кода показано создание эффекта тени с помощью преобразования.  
  
 [!code-xaml[TextShadowSnippets#TextShadowSnippet7](~/samples/snippets/csharp/VS_Snippets_Wpf/TextShadowSnippets/CS/TransformShadows.xaml#textshadowsnippet7)]
