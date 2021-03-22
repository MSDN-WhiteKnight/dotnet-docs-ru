---
title: Практическое руководство. Создание пользовательского режима представления для ListView
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- ListView controls [WPF], creating custom View mode
ms.assetid: 71077349-eeb9-4344-ab29-b5df96df3314
ms.openlocfilehash: de11250a2e7529fba3b262e42b6714262738fa90
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59092894"
---
# <a name="how-to-create-a-custom-view-mode-for-a-listview"></a>Практическое руководство. Создание пользовательского режима представления для ListView
В этом примере показано, как можно создавать пользовательские <xref:System.Windows.Controls.ListView.View%2A> режим для <xref:System.Windows.Controls.ListView> элемента управления.  
  
## <a name="example"></a>Пример  
 Необходимо использовать <xref:System.Windows.Controls.ViewBase> класса при создании настраиваемого представления для <xref:System.Windows.Controls.ListView> элемента управления. В следующем примере показан режим представления, который называется `PlainView`, который является производным от <xref:System.Windows.Controls.ViewBase> класса.  
  
 [!code-csharp[ListViewCustomView#PlainView](~/samples/snippets/csharp/VS_Snippets_Wpf/ListViewCustomView/CSharp/PlainView.cs#plainview)]
   
  
 Чтобы применить стиль к пользовательскому представлению, используйте <xref:System.Windows.Style> класса. В следующем примере определяется <xref:System.Windows.Style> для `PlainView` режим просмотра. В предыдущем примере, этот стиль имеет значение для параметра <xref:System.Windows.Controls.ViewBase.DefaultStyleKey%2A> свойство, которое определено для `PlainView`.  
  
 [!code-xaml[ListViewCustomView#PlainViewStyle](~/samples/snippets/csharp/VS_Snippets_Wpf/ListViewCustomView/CSharp/Themes/Generic.xaml#plainviewstyle)]  
  
 Чтобы определить структуру данных в режиме представления, определите <xref:System.Windows.DataTemplate> объекта. В следующем примере определяется <xref:System.Windows.DataTemplate> , можно использовать для отображения данных в `PlainView` режим просмотра.  
  
 [!code-xaml[ListViewCustomView#PlainViewDataTemplate](~/samples/snippets/csharp/VS_Snippets_Wpf/ListViewCustomView/CSharp/Window1.xaml#plainviewdatatemplate)]  
  
 В следующем примере показано определение <xref:System.Windows.ResourceKey> для `PlainView` режим просмотра, который использует <xref:System.Windows.DataTemplate> , определенный в предыдущем примере.  
  
 [!code-xaml[ListViewCustomView#PlainViewtileView](~/samples/snippets/csharp/VS_Snippets_Wpf/ListViewCustomView/CSharp/Window1.xaml#plainviewtileview)]  
  
 Объект <xref:System.Windows.Controls.ListView> управления можно использовать представления, если задать <xref:System.Windows.Controls.ListView.View%2A> значение ключа ресурса. В следующем примере показано, как указать `PlainView` в качестве режима представления для <xref:System.Windows.Controls.ListView>.  
  
 [!code-csharp[ListViewCustomView#ListViewtileViewmode](~/samples/snippets/csharp/VS_Snippets_Wpf/ListViewCustomView/CSharp/Window1.xaml.cs#listviewtileviewmode)]
   
  
 Полный пример см. в разделе [ListView с несколькими представлениями (C#)](https://github.com/dotnet/samples/tree/master/snippets/csharp/VS_Snippets_Wpf/ListViewCustomView/CSharp) или [ListView с помощью нескольких Views(Visual Basic)](https://github.com/dotnet/samples/tree/master/snippets/visualbasic/VS_Snippets_Wpf/ListViewCustomView/visualbasic).  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Controls.ListView>
- <xref:System.Windows.Controls.GridView>
- [Практические руководства](listview-how-to-topics.md)
- [Общие сведения об элементе управления ListView](listview-overview.md)
- [Общие сведения о GridView](gridview-overview.md)
