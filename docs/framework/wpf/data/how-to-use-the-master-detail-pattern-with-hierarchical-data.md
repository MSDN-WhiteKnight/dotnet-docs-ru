---
title: Практическое руководство. Использование шаблона "Основной/подробности" с иерархическими данными
ms.date: 03/30/2017
helpviewer_keywords:
- data binding [WPF], Master-Detail data paradigm
- Master-Detail data paradigm
ms.assetid: 11429b9e-058d-4084-bfb6-2cf209c8ddf7
ms.openlocfilehash: e0bbb24b07fdc1c362e2be43d69d189defbc27a4
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59346188"
---
# <a name="how-to-use-the-master-detail-pattern-with-hierarchical-data"></a>Практическое руководство. Использование шаблона "Основной/подробности" с иерархическими данными
В этом примере показано, как для реализации сценария «основной-подробности».  
  
## <a name="example"></a>Пример  
 В этом примере `LeagueList` — это коллекция `Leagues`. Каждый `League` имеет `Name` и коллекцию `Divisions`и каждый `Division` имеет имя и коллекция `Teams`. Каждый `Team` содержит имя команды.  
  
 [!code-xaml[MasterDetail#HowTo1](~/samples/snippets/visualbasic/VS_Snippets_Wpf/MasterDetail/VisualBasic/Page1.xaml#howto1)]  
[!code-xaml[MasterDetail#HowTo2](~/samples/snippets/visualbasic/VS_Snippets_Wpf/MasterDetail/VisualBasic/Page1.xaml#howto2)]  
  
 Ниже приведен снимок экрана примера. `Divisions` <xref:System.Windows.Controls.ListBox> Автоматически отслеживает выделение в `Leagues` <xref:System.Windows.Controls.ListBox> и отображают соответствующие данные. `Teams` <xref:System.Windows.Controls.ListBox> Отслеживает выбранные параметры в двух других <xref:System.Windows.Controls.ListBox> элементов управления.  
  
 ![Снимок экрана, показывающий шаблона&#45;пример сценария детализации.](./media/how-to-use-the-master-detail-pattern-with-hierarchical-data/databinding-master-detail-scenario.png)  
  
 В этом примере следует обратить внимание на два обстоятельства:  
  
1. Три <xref:System.Windows.Controls.ListBox> привязать элементы управления с одним источником. Можно задать <xref:System.Windows.Data.Binding.Path%2A> свойство привязки, чтобы указать, какой уровень данных <xref:System.Windows.Controls.ListBox> для отображения.  
  
2. Необходимо задать <xref:System.Windows.Controls.Primitives.Selector.IsSynchronizedWithCurrentItem%2A> свойства `true` на <xref:System.Windows.Controls.ListBox> элементов управления, из которых осуществляется отслеживание выбора. Задание этого свойства гарантирует, что выбранный элемент всегда задается как <xref:System.Windows.Controls.ItemCollection.CurrentItem%2A>. Кроме того Если <xref:System.Windows.Controls.ListBox> получает данные от <xref:System.Windows.Data.CollectionViewSource>, он автоматически синхронизирует Выбор и денежные единицы.  
  
 Метод немного отличается при использовании XML данных. Например, см. в разделе [использование шаблона «основной-подробности» с иерархическими данными XML](how-to-use-the-master-detail-pattern-with-hierarchical-xml-data.md).  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.HierarchicalDataTemplate>
- [Привязка к коллекции и вывод сведений в зависимости от выделенного элемента](how-to-bind-to-a-collection-and-display-information-based-on-selection.md)
- [Общие сведения о привязке данных](data-binding-overview.md)
- [Общие сведения о шаблонах данных](data-templating-overview.md)
- [Практические руководства](data-binding-how-to-topics.md)
