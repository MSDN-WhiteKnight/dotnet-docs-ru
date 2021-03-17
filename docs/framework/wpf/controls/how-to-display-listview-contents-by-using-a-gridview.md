---
title: Практическое руководство. Отображение содержимого ListView с помощью GridView
ms.date: 03/30/2017
helpviewer_keywords:
- ListView controls [WPF], displaying contents with GridView
- GridView [WPF], displaying ListView contents
ms.assetid: 5bc1e767-ab46-4f14-bd41-3d5d39e1d000
ms.openlocfilehash: 9b467c95d541c326a41d1ed4bd9eb5c87e25bd5c
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59112792"
---
# <a name="how-to-display-listview-contents-by-using-a-gridview"></a>Практическое руководство. Отображение содержимого ListView с помощью GridView
В этом примере показан способ определения <xref:System.Windows.Controls.GridView> режим просмотра для <xref:System.Windows.Controls.ListView> элемента управления.  
  
## <a name="example"></a>Пример  
 Можно определить режим представления <xref:System.Windows.Controls.GridView> , указав <xref:System.Windows.Controls.GridViewColumn> объектов. В следующем примере показано определение <xref:System.Windows.Controls.GridViewColumn> объектов, которые привязаны к содержимому данных, который указан для <xref:System.Windows.Controls.ListView> элемента управления. Это <xref:System.Windows.Controls.GridView> пример указывает три <xref:System.Windows.Controls.GridViewColumn> объектов, сопоставляемых с `FirstName`, `LastName`, и `EmployeeNumber` поля `EmployeeInfoDataSource` , для которой включено как <xref:System.Windows.Controls.ItemsControl.ItemsSource%2A> из <xref:System.Windows.Controls.ListView> элемента управления.  
  
 [!code-xaml[ListViewCode#ListViewEmployee](~/samples/snippets/csharp/VS_Snippets_Wpf/ListViewCode/CSharp/Window1.xaml#listviewemployee)]  
  
 Ниже показано, как будет выглядеть этот пример.  
  
 ![Снимок экрана с ListView с выводом GridView.](./media/gridview-overview/listview-gridview-output.jpg)  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Controls.ListView>
- <xref:System.Windows.Controls.GridView>
- [Общие сведения об элементе управления ListView](listview-overview.md)
- [Общие сведения о GridView](gridview-overview.md)
- [Практические руководства](listview-how-to-topics.md)
