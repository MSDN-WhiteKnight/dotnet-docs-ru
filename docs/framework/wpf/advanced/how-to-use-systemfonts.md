---
title: Практическое руководство. Использование SystemFonts
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- system fonts [WPF]
- fonts [WPF], system fonts
- classes [WPF], SystemFonts
ms.assetid: 3f46a4ec-2225-408a-8123-8838a8f7057a
ms.openlocfilehash: 5976bc0cb8b34e68d5e89dd70a608d7e52ded332
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59216786"
---
# <a name="how-to-use-systemfonts"></a>Практическое руководство. Использование SystemFonts
В этом примере показано, как использовать статические ресурсы <xref:System.Windows.SystemFonts> класс для изменения стиля или настроек кнопки.  
  
## <a name="example"></a>Пример  
 Системные ресурсы предоставляют несколько значений, определяемых системой, в качестве ресурсов и свойств, помогающих создавать визуальные элементы, согласованные с параметрами системы. <xref:System.Windows.SystemFonts> — Это класс, содержащий значения системного шрифта в виде статических свойств и свойства со ссылками на ключи ресурсов, которые могут использоваться для доступа к этим значениям динамически во время выполнения. Например <xref:System.Windows.SystemFonts.CaptionFontFamily%2A> — <xref:System.Windows.SystemFonts> значение, и <xref:System.Windows.SystemFonts.CaptionFontFamilyKey%2A> является ключом соответствующего ресурса.  
  
 В XAML, можно использовать члены <xref:System.Windows.SystemFonts> как статические свойства или ссылки на динамические ресурсы (со статическим значением свойства в качестве ключа). Используйте ссылку на динамический ресурс, если метрика шрифта должна автоматически обновляться во время выполнения приложения. В противном случае используйте ссылку на статическое значение.  
  
> [!NOTE]
>  К именам свойств, используемых в качестве ключей ресурсов, добавляется суффикс Key.  
  
 Приведенный ниже показано, как получить доступ и использовать свойства <xref:System.Windows.SystemFonts> как статических значений для изменения стиля или настроек кнопки. Этот пример разметки присваивает <xref:System.Windows.SystemFonts> значения к кнопке.  
  
 [!code-xaml[SystemRes_snip#FontStaticResources](~/samples/snippets/csharp/VS_Snippets_Wpf/SystemRes_snip/CSharp/Pane1.xaml#fontstaticresources)]  
  
 Чтобы использовать значения из <xref:System.Windows.SystemFonts> в коде, не нужно использовать статическое значение или ссылку на динамический ресурс. Вместо этого использовать неключевые свойства <xref:System.Windows.SystemFonts> класса. Хотя неключевые свойства очевидно определены как статические, поведение времени выполнения WPF , размещенного по системе будут пересчитываться свойства в режиме реального времени и правильно учитываться вносимые пользователем изменения значений системы. В приведенном ниже примере показано, как задать параметры шрифта кнопки.  
  
 [!code-csharp[SystemRes_snip#FontResourcesCode](~/samples/snippets/csharp/VS_Snippets_Wpf/SystemRes_snip/CSharp/Pane1.xaml.cs#fontresourcescode)]
   
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.SystemFonts>
- [Заливка области с помощью системной кисти](../graphics-multimedia/how-to-paint-an-area-with-a-system-brush.md)
- [Использование SystemParameters](how-to-use-systemparameters.md)
- [Использование разделов системных шрифтов](how-to-use-system-fonts-keys.md)
- [Практические руководства](resources-how-to-topics.md)
- [Расширение разметки x:Static](../../xaml-services/x-static-markup-extension.md)
- [Ресурсы XAML](xaml-resources.md)
- [Расширение разметки DynamicResource](dynamicresource-markup-extension.md)
