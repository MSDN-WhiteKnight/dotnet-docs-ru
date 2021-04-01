---
title: Практическое руководство. Использование SystemParameters
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- classes [WPF], SystemParameters
ms.assetid: 02e7a5de-94eb-4953-b91c-52e6c872ad5b
ms.openlocfilehash: 344fb54b48bcbf188b36a29d8205c21deff713c4
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59199860"
---
# <a name="how-to-use-systemparameters"></a>Практическое руководство. Использование SystemParameters
В этом примере показано, как получить доступ и использовать свойства <xref:System.Windows.SystemParameters> для изменения стиля или настроек кнопки.  
  
## <a name="example"></a>Пример  
 Системные ресурсы предоставляют несколько параметров системы в виде ресурсов, помогающих создавать визуальные элементы с учетом параметров системы. <xref:System.Windows.SystemParameters> — Это класс, содержащий как свойства значений параметров системы, так и ключи ресурсов, которые привязаны к значениям. Например <xref:System.Windows.SystemParameters.FullPrimaryScreenHeight%2A> — <xref:System.Windows.SystemParameters> значение свойства и <xref:System.Windows.SystemParameters.FullPrimaryScreenHeightKey%2A> является соответствующим ключом ресурса.  
  
 В XAML, можно использовать члены <xref:System.Windows.SystemParameters> как статическое свойство или ссылки на динамические ресурсы (со статическим значением свойства в качестве ключа). Используйте ссылку на динамический ресурс, если требуется системное значение для автоматического обновления во время выполнения приложения. В противном случае используйте статическую ссылку. Ключи ресурсов имеют суффикс `Key` добавляется к имени свойства.  
  
 В следующем примере показано, как получить доступ и использовать статические значения объекта <xref:System.Windows.SystemParameters> для создания стиля или настроек кнопки. Этот пример разметки изменяет размер кнопки, применяя <xref:System.Windows.SystemParameters> значения к кнопке.  
  
 [!code-xaml[SystemRes_snip#ParameterStaticResources](~/samples/snippets/csharp/VS_Snippets_Wpf/SystemRes_snip/CSharp/Pane1.xaml#parameterstaticresources)]  
  
 Чтобы использовать значения из <xref:System.Windows.SystemParameters> в коде, не нужно использовать статические или динамические ссылки на ресурсы. Вместо этого используйте значения <xref:System.Windows.SystemParameters> класса. Хотя неключевые свойства очевидно определены как статические, поведение среды выполнения WPF , размещенного системой будут пересчитываться свойства в режиме реального времени, и правильно учитываться вносимые пользователем изменения значений системы. В следующем примере показано, как задать ширину и высоту кнопки с помощью <xref:System.Windows.SystemParameters> значения.  
  
 [!code-csharp[SystemRes_snip#ParameterResourcesCode](~/samples/snippets/csharp/VS_Snippets_Wpf/SystemRes_snip/CSharp/Pane1.xaml.cs#parameterresourcescode)]
   
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.SystemParameters>
- [Заливка области с помощью системной кисти](../graphics-multimedia/how-to-paint-an-area-with-a-system-brush.md)
- [Использование SystemFonts](how-to-use-systemfonts.md)
- [Использование разделов системных параметров](how-to-use-system-parameters-keys.md)
- [Практические руководства](resources-how-to-topics.md)
