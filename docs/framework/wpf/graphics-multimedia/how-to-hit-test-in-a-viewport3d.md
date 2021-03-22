---
title: Практическое руководство. Проверка нажатия в Viewport3D
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- 3-D visuals [WPF], hit-testing for
- hit tests [WPF], for 3-D visuals
- Viewport3D [WPF]
ms.assetid: 42bfbd99-c7c6-43f1-940b-90448faa412e
ms.openlocfilehash: c3238161a01df67b05be6284b8eed61981ff3974
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59098069"
---
# <a name="how-to-hit-test-in-a-viewport3d"></a>Практическое руководство. Проверка нажатия в Viewport3D
В этом примере показано, как выполнить проверку попадания для трехмерных визуальных элементов в <xref:System.Windows.Controls.Viewport3D>.  
  
 Так как <xref:System.Windows.Media.VisualTreeHelper.HitTest%2A> возвращает сведения о двух- и трехмерные, возможно, для прохода по результатам теста для чтения только 3D результатов.  
  
 [!code-csharp[HitTest3D#HitTest3D3DN4](~/samples/snippets/csharp/VS_Snippets_Wpf/HitTest3D/CSharp/Window1.xaml.cs#hittest3d3dn4)]
   
  
 <xref:System.Windows.Media.HitTestResultBehavior> В следующий код определяет способ обработки результатов проверки попадания.  `UpdateResultInfo` и `UpdateMaterial` локально определенные методы.  
  
 [!code-csharp[HitTest3D#HitTest3D3DN5](~/samples/snippets/csharp/VS_Snippets_Wpf/HitTest3D/CSharp/Window1.xaml.cs#hittest3d3dn5)]
   
  
## <a name="see-also"></a>См. также

- [Пример проверки нажатия в трехмерном пространстве](https://go.microsoft.com/fwlink/?LinkID=159959)
