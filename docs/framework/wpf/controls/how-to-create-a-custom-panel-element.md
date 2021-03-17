---
title: Практическое руководство. Создание пользовательского элемента панели
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- Panel control [WPF]
- custom Panel elements [WPF]
ms.assetid: e0df4f1e-8c07-4e86-89a3-e22acfffdc2a
ms.openlocfilehash: d4fc9d76ada9f27bd52619280b323691af9382c2
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59139572"
---
# <a name="how-to-create-a-custom-panel-element"></a>Практическое руководство. Создание пользовательского элемента панели
## <a name="example"></a>Пример  
 В этом примере показано, как переопределить поведение по умолчанию макет <xref:System.Windows.Controls.Panel> элемент и создать пользовательский макет элементов, которые являются производными от <xref:System.Windows.Controls.Panel>.  
  
 В примере определяется простой пользовательский <xref:System.Windows.Controls.Panel> элемент с именем `PlotPanel`, который размещает дочерние элементы в соответствии с двумя жестко координаты x и y-. В этом примере `x` и `y` устанавливается `50`; таким образом, все дочерние элементы располагаются в этом расположении на x и y осей.  
  
 Чтобы реализовать пользовательскую <xref:System.Windows.Controls.Panel> поведения, в примере используется <xref:System.Windows.FrameworkElement.MeasureOverride%2A> и <xref:System.Windows.FrameworkElement.ArrangeOverride%2A> методы. Каждый метод возвращает <xref:System.Windows.Size> данные, необходимые для размещения и отображения дочерних элементов.  
  
 [!code-cpp[PlotPanel#1](~/samples/snippets/cpp/VS_Snippets_Wpf/PlotPanel/CPP/PlotPanel.cpp#1)]
 [!code-csharp[PlotPanel#1](~/samples/snippets/csharp/VS_Snippets_Wpf/PlotPanel/CSharp/PlotPanel.cs#1)]
 [!code-vb[PlotPanel#1](~/samples/snippets/visualbasic/VS_Snippets_Wpf/PlotPanel/VisualBasic/PlotPanel.vb#1)]  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Controls.Panel>
- [Общие сведения о панелях](panels-overview.md)
- [Создание пользовательского содержимого пример](https://go.microsoft.com/fwlink/?LinkID=159979)
