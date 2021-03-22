---
title: 'Как выполнить: Распознавание жестов приложений'
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- application gestures [WPF], recognizing
- gestures [WPF], recognizing
ms.assetid: d58b740f-5192-4a3e-af59-7aa162e6ca15
ms.openlocfilehash: 647e7c9c1d785cebfdc362dc48511d865f3945dc
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59191514"
---
# <a name="how-to-recognize-application-gestures"></a>Как выполнить: Распознавание жестов приложений
Следующий пример демонстрирует удаление данных рукописного ввода, когда пользователь делает <xref:System.Windows.Ink.ApplicationGesture.ScratchOut> жестов на <xref:System.Windows.Controls.InkCanvas>. В этом примере предполагается <xref:System.Windows.Controls.InkCanvas>, который называется `inkCanvas1`, объявляется в файле XAML.  
  
## <a name="example"></a>Пример  
 [!code-csharp[HowToRecognizeGestures#1](~/samples/snippets/csharp/VS_Snippets_Wpf/HowToRecognizeGestures/CSharp/Window1.xaml.cs#1)]
   
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Ink.ApplicationGesture>
- <xref:System.Windows.Controls.InkCanvas>
- <xref:System.Windows.Controls.InkCanvas.Gesture>
