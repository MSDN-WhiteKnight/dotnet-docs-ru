---
title: Практическое руководство. Использование шаблона "Основной/подробности" с иерархическими XML-данными
ms.date: 03/30/2017
helpviewer_keywords:
- data binding [WPF], Master-Detail data paradigm
- Master-Detail data paradigm
ms.assetid: eb8dbdd8-5871-42bb-a16b-04e655fea677
ms.openlocfilehash: ba6c932f519ffa5c3c70ecb21eb9b5d08c40fb28
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59086264"
---
# <a name="how-to-use-the-master-detail-pattern-with-hierarchical-xml-data"></a>Практическое руководство. Использование шаблона "Основной/подробности" с иерархическими XML-данными
В этом примере показано, как реализовать сценарий "основной / подробности" с [!INCLUDE[TLA2#tla_xml](../../../../includes/tla2sharptla-xml-md.md)] данных.  
  
## <a name="example"></a>Пример  
 Данный пример является [!INCLUDE[TLA2#tla_xml](../../../../includes/tla2sharptla-xml-md.md)] версию данных в примере, рассмотренном в [использование шаблона «основной-подробности» с иерархическими данными](how-to-use-the-master-detail-pattern-with-hierarchical-data.md). В этом примере данные берутся из файла `League.xml`. Обратите внимание как третий <xref:System.Windows.Controls.ListBox> управления отслеживает изменения выделения во втором <xref:System.Windows.Controls.ListBox> путем привязки к его <xref:System.Windows.Controls.Primitives.Selector.SelectedValue%2A> свойство.  
  
 [!code-xaml[MasterDetailXml#HowTo1](~/samples/snippets/csharp/VS_Snippets_Wpf/MasterDetailXml/CS/Window1.xaml#howto1)]  
[!code-xaml[MasterDetailXml#HowTo2](~/samples/snippets/csharp/VS_Snippets_Wpf/MasterDetailXml/CS/Window1.xaml#howto2)]  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.HierarchicalDataTemplate>
- [Практические руководства](data-binding-how-to-topics.md)
