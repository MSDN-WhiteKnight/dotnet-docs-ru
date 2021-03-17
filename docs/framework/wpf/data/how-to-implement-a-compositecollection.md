---
title: Практическое руководство. Реализация CompositeCollection
ms.date: 03/30/2017
helpviewer_keywords:
- data binding [WPF], CompositeCollection class
ms.assetid: 0d8fc84c-7920-427f-8ad7-d55ca656c170
ms.openlocfilehash: 8361c2bfa9c125aeadf0a62ca86af1855e5c3dbc
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59091169"
---
# <a name="how-to-implement-a-compositecollection"></a>Практическое руководство. Реализация CompositeCollection
## <a name="example"></a>Пример  
 В следующем примере показано, как отображать несколько коллекций и элементов как один список с помощью <xref:System.Windows.Data.CompositeCollection> класса. В этом примере `GreekGods` — <xref:System.Collections.ObjectModel.ObservableCollection%601> из `GreekGod` пользовательских объектов. Шаблоны данных определены таким образом, чтобы `GreekGod` объектов и `GreekHero` объекты отображаются с желтым и голубой цвет, соответственно.  
  
 [!code-xaml[CompositeCollections#1](~/samples/snippets/csharp/VS_Snippets_Wpf/CompositeCollections/CS/Window1.xaml#1)]  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Data.CollectionContainer>
- <xref:System.Windows.Controls.ItemsControl.ItemsSource%2A>
- <xref:System.Windows.Data.XmlDataProvider>
- <xref:System.Windows.DataTemplate>
- [Общие сведения о привязке данных](data-binding-overview.md)
- [Практические руководства](data-binding-how-to-topics.md)
