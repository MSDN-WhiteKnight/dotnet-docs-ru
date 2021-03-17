---
title: Практическое руководство. Переопределение метода панели OnRender
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
f1_keywords:
- overriding OnRender method
- Panel control, overriding OnRender method
- OnRender method
- controls, Panel, overriding OnRender method
helpviewer_keywords:
- overriding OnRender method of Panel control [WPF]
- OnRender method [WPF], overriding
- Panel control [WPF], overriding OnRender method
ms.assetid: 57397834-a085-4e36-90ab-416fad98f341
ms.openlocfilehash: c4539847368c1a5789e99ec92106d17077ed5943
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59102535"
---
# <a name="how-to-override-the-panel-onrender-method"></a>Практическое руководство. Переопределение метода панели OnRender
В этом примере показано, как переопределить <xref:System.Windows.Controls.Panel.OnRender%2A> метод <xref:System.Windows.Controls.Panel> для добавления пользовательских графических эффектов в элемент макета.  
  
## <a name="example"></a>Пример  
 Используйте <xref:System.Windows.Controls.Panel.OnRender%2A> метод для добавления графических эффектов к элементу отображаемой панели. Например этот метод можно использовать для добавления пользовательских границу или фон эффекты. Объект <xref:System.Windows.Media.DrawingContext> объект передается как аргумент, который предоставляет методы для рисования фигур, текста, изображений и видео. Таким образом этот метод полезен для настройки объекта панели.  
  
 [!code-csharp[LightWeightCustomPanel#1](~/samples/snippets/csharp/VS_Snippets_Wpf/LightWeightCustomPanel/CSharp/OffsetPanel.cs#1)]
 [!code-vb[LightWeightCustomPanel#1](~/samples/snippets/visualbasic/VS_Snippets_Wpf/LightWeightCustomPanel/visualbasic/offsetpanel.vb#1)]  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Controls.Panel>
- [Общие сведения о панелях](panels-overview.md)
- [Пример пользовательской радиальной панели](https://go.microsoft.com/fwlink/?LinkID=159982)
- [Практические руководства](panel-how-to-topics.md)
