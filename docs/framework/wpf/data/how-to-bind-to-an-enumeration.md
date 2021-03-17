---
title: Практическое руководство. Привязка к перечислению
ms.date: 03/30/2017
helpviewer_keywords:
- binding data [WPF], enumeration
- data binding [WPF], enumeration
- enumeration [WPF]
ms.assetid: b9091eba-1119-424e-868b-d1a4168b3732
ms.openlocfilehash: 5026261366d6abde82790f05780d8ba2c29c4a49
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59210026"
---
# <a name="how-to-bind-to-an-enumeration"></a>Практическое руководство. Привязка к перечислению
В этом примере показано, как привязка к перечислению путем привязки к методу GetValues перечисления.  
  
## <a name="example"></a>Пример  
 В следующем примере <xref:System.Windows.Controls.ListBox> отображает список <xref:System.Windows.HorizontalAlignment> значения перечисления с помощью привязки данных. <xref:System.Windows.Controls.ListBox> И <xref:System.Windows.Controls.Button> связаны таким образом, вы можете изменить <xref:System.Windows.FrameworkElement.HorizontalAlignment%2A> значение свойства <xref:System.Windows.Controls.Button> , выбрав значение в <xref:System.Windows.Controls.ListBox>.  
  
 [!code-xaml[BindToEnum#BindToEnum](~/samples/snippets/csharp/VS_Snippets_Wpf/BindToEnum/CS/Window1.xaml#bindtoenum)]  
  
## <a name="see-also"></a>См. также

- [Создание привязки к методу](how-to-bind-to-a-method.md)
- [Общие сведения о привязке данных](data-binding-overview.md)
- [Практические руководства](data-binding-how-to-topics.md)
