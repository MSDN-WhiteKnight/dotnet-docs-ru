---
title: Практическое руководство. Использование элемента изображения
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- controls [WPF], Image
- Image control [WPF]
- rendering images [WPF]
ms.assetid: 5b92e74b-1b56-4756-ac64-d5e9e08d9854
ms.openlocfilehash: 967159894e25721bdf380f851712e91d76088f87
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59205307"
---
# <a name="how-to-use-the-image-element"></a>Практическое руководство. Использование элемента изображения
В этом примере показано, как добавлять изображения в приложении с помощью <xref:System.Windows.Controls.Image> элемент.  
  
## <a name="example"></a>Пример  
 В следующем примере показано, как построить изображение шириной 200 пикселей. В этом примере XAML для определения изображения используются как синтаксис атрибута, так и синтаксис тега свойства. Дополнительные сведения о синтаксисе атрибутов и синтаксисе свойств см. в разделе [Общие сведения о свойствах зависимостей](../advanced/dependency-properties-overview.md). Объект <xref:System.Windows.Media.Imaging.BitmapImage> используется для определения источника данных изображения и явно определен в примере синтаксиса тега свойства. Кроме того <xref:System.Windows.Media.Imaging.BitmapImage.DecodePixelWidth%2A> из <xref:System.Windows.Media.Imaging.BitmapImage> присваивается такой же ширины, что <xref:System.Windows.FrameworkElement.Width%2A> из <xref:System.Windows.Controls.Image>. Это позволяет использовать минимальный объем памяти при построении изображения.  
  
> [!NOTE]
>  Как правило, если вы хотите указать размер сформированного изображения, укажите только <xref:System.Windows.FrameworkElement.Width%2A> или <xref:System.Windows.FrameworkElement.Height%2A> , но не оба. Если задано одно значение, пропорции изображения сохраняются. В противном случае изображение может внезапно оказаться растянутым или искривленным. Для управления изображение растяжением, используйте <xref:System.Windows.Controls.Image.Stretch%2A> и <xref:System.Windows.Controls.Image.StretchDirection%2A> свойства.  
  
> [!NOTE]
>  При указании размера изображения с помощью <xref:System.Windows.FrameworkElement.Width%2A> или <xref:System.Windows.FrameworkElement.Height%2A>, также необходимо задать либо <xref:System.Windows.Media.Imaging.BitmapImage.DecodePixelWidth%2A> или <xref:System.Windows.Media.Imaging.BitmapImage.DecodePixelHeight%2A> на тот же соответствующий размер.  
  
 <xref:System.Windows.Controls.Image.Stretch%2A> Свойство определяет, как источник изображения растягивается для заполнения элемента изображения. Дополнительные сведения см. в описании перечисления <xref:System.Windows.Media.Stretch>.  
  
 [!code-xaml[ImageElementExample_snip#ImageSimpleExampleInlineMarkup](~/samples/snippets/csharp/VS_Snippets_Wpf/ImageElementExample_snip/CSharp/ImageSimpleExample.xaml#imagesimpleexampleinlinemarkup)]  
  
## <a name="example"></a>Пример  
 В следующем примере показано, как построить изображение шириной 200 пикселей с использованием кода.  
  
> [!NOTE]
>  Установка <xref:System.Windows.Media.Imaging.BitmapImage> свойства должна быть выполнена внутри <xref:System.Windows.Media.Imaging.BitmapImage.BeginInit%2A> и <xref:System.Windows.Media.Imaging.BitmapImage.EndInit%2A> блока.  
  
 [!code-csharp[ImageElementExample_snip#ImageSimpleExampleInlineCode1](~/samples/snippets/csharp/VS_Snippets_Wpf/ImageElementExample_snip/CSharp/ImageSimpleExample.xaml.cs#imagesimpleexampleinlinecode1)]
   
  
## <a name="see-also"></a>См. также

- [Общие сведения об обработке изображений](../graphics-multimedia/imaging-overview.md)
