---
title: Хранение рукописных данных
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- ISF (Ink Serialized Format)
- storing ink [WPF]
- ink [WPF], storing
- retrieving ink [WPF]
- Ink Serialized Format (ISF)
ms.assetid: a3f6d16b-d682-4680-9965-907332b4d2b8
ms.openlocfilehash: 4089aa7942105c14eb628c75edb7f53ffacfaeb0
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59182342"
---
# <a name="storing-ink"></a>Хранение рукописных данных
<xref:System.Windows.Ink.StrokeCollection.Save%2A> Методы поддерживают хранение рукописных данных в качестве формата сериализации рукописного ввода (ISF). Конструкторы для <xref:System.Windows.Ink.StrokeCollection> класс обеспечивают поддержку чтения данных рукописного ввода.  
  
## <a name="ink-storage-and-retrieval"></a>Рукописный ввод хранения и извлечения  
 В этом разделе рассматриваются способы хранения и получения рукописных данных в WPF платформы.  
  
 В следующем примере реализуется обработчик событий нажатия кнопки, который отображает диалоговое окно сохранения файла и сохраняет рукописные данные из <xref:System.Windows.Controls.InkCanvas> в файл.  
  
 [!code-csharp[DigitalInkTopics#12](~/samples/snippets/csharp/VS_Snippets_Wpf/DigitalInkTopics/CSharp/Window1.xaml.cs#12)]
   
  
 В следующем примере реализуется обработчик событий нажатия кнопки, который отображает диалоговое окно открытия файла и считывает рукописные данные из файла в <xref:System.Windows.Controls.InkCanvas> элемент.  
  
 [!code-csharp[DigitalInkTopics#13](~/samples/snippets/csharp/VS_Snippets_Wpf/DigitalInkTopics/CSharp/Window1.xaml.cs#13)]
   
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Controls.InkCanvas>
- [Windows Presentation Foundation](../index.md)
