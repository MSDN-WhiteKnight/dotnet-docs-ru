---
title: Практическое руководство. Использование разделов системных шрифтов
ms.date: 03/30/2017
helpviewer_keywords:
- resource keys [WPF], SystemFonts class
ms.assetid: 036ebea7-5677-4f60-8ba4-56c9f9d9b8bd
ms.openlocfilehash: e924f4c14d98380d9f4c0defe27d9f98c3293114
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59148932"
---
# <a name="how-to-use-system-fonts-keys"></a>Практическое руководство. Использование разделов системных шрифтов
Системные ресурсы предоставляют ряд метрик системы в качестве ресурсов, что помогает разработчикам создавать визуальные элементы, совместимые с параметрами системы. <xref:System.Windows.SystemFonts> — Это класс, который содержит значения системных шрифтов и ресурсы системных шрифтов, которые привязаны к значениям — например, <xref:System.Windows.SystemFonts.CaptionFontFamily%2A> и <xref:System.Windows.SystemFonts.CaptionFontFamilyKey%2A>.  
  
 Метрики системных шрифтов могут использоваться в качестве статического или динамического ресурса. Используйте динамический ресурс, если требуется метрика шрифта для автоматического обновления во время выполнения приложения. В противном случае используйте статический ресурс.  
  
> [!NOTE]
>  Динамические ресурсы имеют ключевое слово *ключ* добавляется к имени свойства.  
  
 В приведенном ниже примере показано, как получить доступ к ресурсам динамических системных шрифтов и использовать их для создания стиля или настройки кнопки. Это XAML примере создается стиль кнопки, который назначает <xref:System.Windows.SystemFonts> значения к кнопке.  
  
## <a name="example"></a>Пример  
 [!code-xaml[SystemRes_snip#FontDynamicResources](~/samples/snippets/csharp/VS_Snippets_Wpf/SystemRes_snip/CSharp/MyApp.xaml#fontdynamicresources)]  
  
## <a name="see-also"></a>См. также

- [Заливка области с помощью системной кисти](../graphics-multimedia/how-to-paint-an-area-with-a-system-brush.md)
- [Использование SystemParameters](how-to-use-systemparameters.md)
- [Использование SystemFonts](how-to-use-systemfonts.md)
