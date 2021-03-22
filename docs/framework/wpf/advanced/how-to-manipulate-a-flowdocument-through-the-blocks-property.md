---
title: Практическое руководство. Управление FlowDocument с помощью свойства Blocks
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- 'documents [WPF], manipulating FlowDocuments through Blocks property [WPF], , '
- ', '
ms.assetid: cbb7291e-3f1b-433e-9e16-f4d93ced14e8
ms.openlocfilehash: c307d85bf24e2d8a20226856181e0758758d40c0
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59130888"
---
# <a name="how-to-manipulate-a-flowdocument-through-the-blocks-property"></a>Практическое руководство. Управление FlowDocument с помощью свойства Blocks
Эти примеры демонстрируют некоторые из наиболее распространенных операций, которые могут быть выполнены на <xref:System.Windows.Documents.FlowDocument> через <xref:System.Windows.Documents.FlowDocument.Blocks%2A> свойство.  
  
## <a name="example"></a>Пример  
 В следующем примере создается новый <xref:System.Windows.Documents.FlowDocument> , а затем добавляется новый <xref:System.Windows.Documents.Paragraph> элемент <xref:System.Windows.Documents.FlowDocument>.  
  
 [!code-csharp[FlowDocumentSnippets#_FlowDocumentBlocksAdd](~/samples/snippets/csharp/VS_Snippets_Wpf/FlowDocumentSnippets/CSharp/Window1.xaml.cs#_flowdocumentblocksadd)]
   
  
## <a name="example"></a>Пример  
 В следующем примере создается новый <xref:System.Windows.Documents.Paragraph> элемент и вставляет его в начале <xref:System.Windows.Documents.FlowDocument>.  
  
 [!code-csharp[FlowDocumentSnippets#_FlowDocumentBlocksInsert](~/samples/snippets/csharp/VS_Snippets_Wpf/FlowDocumentSnippets/CSharp/Window1.xaml.cs#_flowdocumentblocksinsert)]
   
  
## <a name="example"></a>Пример  
 В следующем примере возвращается количество верхнего уровня <xref:System.Windows.Documents.Block> элементов, содержащихся в <xref:System.Windows.Documents.FlowDocument>.  
  
 [!code-csharp[FlowDocumentSnippets#_FlowDocumentBlocksCount](~/samples/snippets/csharp/VS_Snippets_Wpf/FlowDocumentSnippets/CSharp/Window1.xaml.cs#_flowdocumentblockscount)]
   
  
## <a name="example"></a>Пример  
 В следующем примере удаляется последний <xref:System.Windows.Documents.Block> элемент <xref:System.Windows.Documents.FlowDocument>.  
  
 [!code-csharp[FlowDocumentSnippets#_FlowDocumentBlocksRemoveLast](~/samples/snippets/csharp/VS_Snippets_Wpf/FlowDocumentSnippets/CSharp/Window1.xaml.cs#_flowdocumentblocksremovelast)]
   
  
## <a name="example"></a>Пример  
 В следующем примере удаляется все содержимое (<xref:System.Windows.Documents.Block> элементы) из <xref:System.Windows.Documents.FlowDocument>.  
  
 [!code-csharp[FlowDocumentSnippets#_FlowDocumentBlocksClear](~/samples/snippets/csharp/VS_Snippets_Wpf/FlowDocumentSnippets/CSharp/Window1.xaml.cs#_flowdocumentblocksclear)]
   
  
## <a name="see-also"></a>См. также

- [Управление группами строк таблицы пользователя с помощью свойства RowGroups](how-to-manipulate-table-row-groups-through-the-rowgroups-property.md)
- [Управление столбцами таблицы с помощью свойства Columns](how-to-manipulate-table-columns-through-the-columns-property.md)
- [Управление группами строк таблицы пользователя с помощью свойства RowGroups](how-to-manipulate-table-row-groups-through-the-rowgroups-property.md)
