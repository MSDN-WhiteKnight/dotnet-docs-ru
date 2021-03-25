---
title: Практическое руководство. Определение таблицы с помощью XAML
ms.date: 03/30/2017
helpviewer_keywords:
- XAML [WPF], defining tables
- documents [WPF], defining tables with XAML
- tables [WPF], defining with XAML
ms.assetid: 83f2dc58-437e-4cdc-b5dd-0019810c7a85
ms.openlocfilehash: 7398af6fddae56238e1af3ee4e726420c01ab7ea
ms.sourcegitcommit: 0c48191d6d641ce88d7510e319cf38c0e35697d0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/05/2019
ms.locfileid: "57376940"
---
# <a name="how-to-define-a-table-with-xaml"></a>Практическое руководство. Определение таблицы с помощью XAML
В следующем примере демонстрируется определение <xref:System.Windows.Documents.Table> с помощью XAML.  Пример таблицы содержит четыре столбца (представленный <xref:System.Windows.Documents.TableColumn> элементов) и несколько строк (представленных <xref:System.Windows.Documents.TableRow> элементы) содержащий данные, а также как название, заголовок и нижний колонтитул сведения.  Строки, которые должны содержаться в <xref:System.Windows.Documents.TableRowGroup> элемент.  Каждая строка в таблице состоит из одной или нескольких ячеек (представленных <xref:System.Windows.Documents.TableCell> элементов).  Содержимое в ячейке таблицы должно содержаться в <xref:System.Windows.Documents.Block> элемент; в таком случае <xref:System.Windows.Documents.Paragraph> используются элементы.  Таблица также содержит гиперссылку (представленный <xref:System.Windows.Documents.Hyperlink> элемент) в строке нижнего колонтитула.  
  
## <a name="example"></a>Пример  
 [!code-xaml[TableSnippetsXAML#_TableXAML](~/samples/snippets/csharp/VS_Snippets_Wpf/TableSnippetsXAML/CS/Window1.xaml#_tablexaml)]  
  
 На следующем рисунке показано, как отображается таблица, определенная в этом примере.  
  
 ![Отображаемая таблица.](./media/tableeg.png "TableEG")
