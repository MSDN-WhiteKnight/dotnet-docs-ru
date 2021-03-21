---
title: Практическое руководство. Управление столбцами таблицы с помощью свойства Columns
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- documents [WPF], manipulating table columns
- properties [WPF], Columns [WPF], manipulating table columns
- tables [WPF], manipulating columns
- Columns property [WPF]
ms.assetid: 3f8884f4-7e1f-456b-be06-fbd3cf469bf3
ms.openlocfilehash: d379d1a98bff614ff9e16cdd340bb69644988743
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59078425"
---
# <a name="how-to-manipulate-a-tables-columns-through-the-columns-property"></a>Практическое руководство. Управление столбцами таблицы с помощью свойства Columns
В этом примере показаны некоторые из наиболее распространенных операций, которые могут выполняться над столбцами таблицы с помощью <xref:System.Windows.Documents.Table.Columns%2A> свойство.  
  
## <a name="example"></a>Пример  
 В следующем примере создается новая таблица и затем использует <xref:System.Windows.Documents.TableColumnCollection.Add%2A> метод для добавления столбцов в таблицу <xref:System.Windows.Documents.Table.Columns%2A> коллекции.  
  
 [!code-csharp[TableSnippets2#_Table_Columns_Add](~/samples/snippets/csharp/VS_Snippets_Wpf/TableSnippets2/CSharp/Window1.xaml.cs#_table_columns_add)]
   
  
## <a name="example"></a>Пример  
 В следующем примере вставляется новый <xref:System.Windows.Documents.TableColumn>.  Новый столбец вставляется в позиции индекса 0, делая его первым столбцом в таблице.  
  
> [!NOTE]
>  <xref:System.Windows.Documents.TableColumnCollection> Коллекция использует стандартную индексацию с нуля.  
  
 [!code-csharp[TableSnippets2#_Table_Columns_Insert](~/samples/snippets/csharp/VS_Snippets_Wpf/TableSnippets2/CSharp/Window1.xaml.cs#_table_columns_insert)]
   
  
## <a name="example"></a>Пример  
 Следующий пример обращается к некоторые произвольные свойства для столбцов в <xref:System.Windows.Documents.TableColumnCollection> коллекции, ссылающийся на определенных столбцов по индексу.  
  
 [!code-csharp[TableSnippets2#_Table_Columns_Manip](~/samples/snippets/csharp/VS_Snippets_Wpf/TableSnippets2/CSharp/Window1.xaml.cs#_table_columns_manip)]
   
  
## <a name="example"></a>Пример  
 Следующий пример возвращает количество столбцов, в настоящий момент размещенные в таблице.  
  
 [!code-csharp[TableSnippets2#_Table_Columns_Count](~/samples/snippets/csharp/VS_Snippets_Wpf/TableSnippets2/CSharp/Window1.xaml.cs#_table_columns_count)]
   
  
## <a name="example"></a>Пример  
 Следующий пример удаляет определенный столбец по ссылке.  
  
 [!code-csharp[TableSnippets2#_Table_Columns_DelRef](~/samples/snippets/csharp/VS_Snippets_Wpf/TableSnippets2/CSharp/Window1.xaml.cs#_table_columns_delref)]
   
  
## <a name="example"></a>Пример  
 Следующий пример удаляет определенный столбец по индексу.  
  
 [!code-csharp[TableSnippets2#_Table_Columns_DelIndex](~/samples/snippets/csharp/VS_Snippets_Wpf/TableSnippets2/CSharp/Window1.xaml.cs#_table_columns_delindex)]
   
  
## <a name="example"></a>Пример  
 Следующий пример удаляет все столбцы из коллекции столбцов таблицы.  
  
 [!code-csharp[TableSnippets2#_Table_Columns_Clear](~/samples/snippets/csharp/VS_Snippets_Wpf/TableSnippets2/CSharp/Window1.xaml.cs#_table_columns_clear)]
   
  
## <a name="see-also"></a>См. также

- [Общие сведения о таблицах](table-overview.md)
- [Определение таблицы с помощью XAML](how-to-define-a-table-with-xaml.md)
- [Создание таблицы программным способом](how-to-build-a-table-programmatically.md)
- [Управление группами строк таблицы пользователя с помощью свойства RowGroups](how-to-manipulate-table-row-groups-through-the-rowgroups-property.md)
- [Управление FlowDocument с помощью свойства Blocks](how-to-manipulate-a-flowdocument-through-the-blocks-property.md)
- [Управление группами строк таблицы пользователя с помощью свойства RowGroups](how-to-manipulate-table-row-groups-through-the-rowgroups-property.md)
