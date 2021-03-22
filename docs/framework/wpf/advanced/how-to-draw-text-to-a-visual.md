---
title: Практическое руководство. Рисование текста в визуальном элементе
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- typography [WPF], drawing text to visuals
- visuals [WPF], drawing text to
- text [WPF], drawing to visuals
- drawing [WPF], text to visuals
ms.assetid: fee4003c-e8a6-46ec-babd-2c7f4231a101
ms.openlocfilehash: 1ea31540ad59ab419e209e4133bcb88640cc01fe
ms.sourcegitcommit: 0c48191d6d641ce88d7510e319cf38c0e35697d0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/05/2019
ms.locfileid: "57368921"
---
# <a name="how-to-draw-text-to-a-visual"></a>Практическое руководство. Рисование текста в визуальном элементе
В следующем примере показано, как для рисования текста для <xref:System.Windows.Media.DrawingVisual> с помощью <xref:System.Windows.Media.DrawingContext> объекта. Контекст рисования возвращается путем вызова <xref:System.Windows.Media.DrawingVisual.RenderOpen%2A> метод <xref:System.Windows.Media.DrawingVisual> объекта. Можно рисовать изображения и текст в контекст рисования.  
  
 Чтобы нарисовать текст в контекст рисования, используйте <xref:System.Windows.Media.DrawingContext.DrawText%2A> метод <xref:System.Windows.Media.DrawingContext> объекта. Когда вы закончите, рисование содержимого в контекст рисования, вызовите <xref:System.Windows.Media.DrawingContext.Close%2A> метод, чтобы закрыть контекст рисования и сохранить содержимое.  
  
## <a name="example"></a>Пример  
 [!code-csharp[DrawingVisualSample#110](~/samples/snippets/csharp/VS_Snippets_Wpf/DrawingVisualSample/CSharp/Window1.xaml.cs#110)]
   
  
> [!NOTE]
>  Полный код примера, из которого был взят предыдущий пример кода, см. в разделе [Проверка нажатия с помощью примера DrawingVisuals](https://go.microsoft.com/fwlink/?LinkID=159994).
