---
title: Практическое руководство. Установка часов в синхронном режиме
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- clocks [WPF], seeking synchronously
- seeking clocks synchronously [WPF]
ms.assetid: e5b7529b-b7d0-40d2-9e1d-fa4b5e736e96
ms.openlocfilehash: 9b6b1f5523effc56ccd9ddaa4f478e1d3a20ada8
ms.sourcegitcommit: 0c48191d6d641ce88d7510e319cf38c0e35697d0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/05/2019
ms.locfileid: "57356001"
---
# <a name="how-to-seek-a-clock-synchronously"></a>Практическое руководство. Установка часов в синхронном режиме
Используйте <xref:System.Windows.Media.Animation.ClockController.SeekAlignedToLastTick%2A> метод для часов до определенной точки в синхронном. В следующем примере показано, как <xref:System.Windows.Media.Animation.ClockController.Seek%2A> и <xref:System.Windows.Media.Animation.ClockController.SeekAlignedToLastTick%2A> методы <xref:System.Windows.Media.Animation.ClockController>.  
  
 В этом примере показано, как выполнить поиск <xref:System.Windows.Media.Animation.Clock>; пример, демонстрирующий поиск раскадровки, см. в разделе [поиск раскадровки синхронно](how-to-seek-a-storyboard-synchronously.md) .  
  
## <a name="example"></a>Пример  
 [!code-csharp[ClockController_procedural_snip#ClockControllerSeekExample](~/samples/snippets/csharp/VS_Snippets_Wpf/ClockController_procedural_snip/CSharp/SeekAlignedToLastTickExample.cs#clockcontrollerseekexample)]
 
