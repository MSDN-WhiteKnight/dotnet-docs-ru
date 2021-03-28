---
title: Практическое руководство. Создание таблицы программным способом
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- tables [WPF], creating programmatically
ms.assetid: e3ca88f3-6e94-4b61-82fc-42104c10b761
ms.openlocfilehash: 315154b37218c0a6845f0a46149fc056780ee650
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59172631"
---
# <a name="how-to-build-a-table-programmatically"></a>Практическое руководство. Создание таблицы программным способом
Следующие примеры показывают, как программным способом создать <xref:System.Windows.Documents.Table> и заполнение ее содержимым. Содержимое таблицы распределено по пяти строкам (представленный <xref:System.Windows.Documents.TableRow> объектов, содержащихся в <xref:System.Windows.Documents.Table.RowGroups%2A> объекта) и шести столбцам (представленный <xref:System.Windows.Documents.TableColumn> объектов). Строки используются для различных целей представления, включая строку названия, предназначенную для заголовка всей таблицы, строку заголовка для описания столбцов данных в таблице и строку нижнего колонтитула для сводной информации.  Обратите внимание, что строки "title", "header" и "footer" не встроены в таблицу. Это просто строки с разными характеристиками. Ячейки таблицы содержат фактическое содержимое, которое может состоять из текста, изображений или практически любых других UI  элемент.  
  
## <a name="example"></a>Пример  
 Во-первых, <xref:System.Windows.Documents.FlowDocument> создается узел <xref:System.Windows.Documents.Table>и новый <xref:System.Windows.Documents.Table> создается и добавляется к содержимому <xref:System.Windows.Documents.FlowDocument>.  
  
 [!code-csharp[TableSnippets#_TableCreate](~/samples/snippets/csharp/VS_Snippets_Wpf/TableSnippets/CSharp/Table.cs#_tablecreate)]
   
  
## <a name="example"></a>Пример  
 Далее шесть <xref:System.Windows.Documents.TableColumn> объекты создаются и добавляются в таблицу <xref:System.Windows.Documents.Table.Columns%2A> коллекции с определенным форматированием.  
  
> [!NOTE]
>  Обратите внимание, что таблицы <xref:System.Windows.Documents.Table.Columns%2A> коллекция использует стандартную индексацию с нуля.  
  
 [!code-csharp[TableSnippets#_TableCreateColumns](~/samples/snippets/csharp/VS_Snippets_Wpf/TableSnippets/CSharp/Table.cs#_tablecreatecolumns)]
   
  
## <a name="example"></a>Пример  
 Затем создается строка заголовка и добавляется в таблицу с определенным форматированием.  Строка названия содержит одну ячейку, охватывающую все шесть столбцов таблицы.  
  
 [!code-csharp[TableSnippets#_TableAddTitleRow](~/samples/snippets/csharp/VS_Snippets_Wpf/TableSnippets/CSharp/Table.cs#_tableaddtitlerow)]
   
  
## <a name="example"></a>Пример  
 Далее создается и добавляется в таблицу строка заголовка, а ячейки в строке заголовка создаются и заполняются содержимым.  
  
 [!code-csharp[TableSnippets#_TableAddHeaderRow](~/samples/snippets/csharp/VS_Snippets_Wpf/TableSnippets/CSharp/Table.cs#_tableaddheaderrow)]
   
  
## <a name="example"></a>Пример  
 Затем создается и добавляется в таблицу ряд данных, а ячейки в этой строке создаются и заполняются содержимым.  Построение этой строки аналогично построению строки заголовка с применением немного другого форматирования.  
  
 [!code-csharp[TableSnippets#_TableAddDataRow](~/samples/snippets/csharp/VS_Snippets_Wpf/TableSnippets/CSharp/Table.cs#_tableadddatarow)]
   
  
## <a name="example"></a>Пример  
 Наконец, создается, добавляется и форматируется строка нижнего колонтитула.  Как и строка названия, нижний колонтитул содержит одну ячейку, которая включает все шесть столбцов в таблице.  
  
 [!code-csharp[TableSnippets#_TableAddFooterRow](~/samples/snippets/csharp/VS_Snippets_Wpf/TableSnippets/CSharp/Table.cs#_tableaddfooterrow)]
   
  
## <a name="see-also"></a>См. также

- [Общие сведения о таблицах](table-overview.md)
