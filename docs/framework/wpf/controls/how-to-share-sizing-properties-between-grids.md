---
title: Практическое руководство. Совместное использование свойств размера между сетками
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- Grid control [WPF], sharing sizing data of columns
- sizing data in Grid controls [WPF]
- Grid control [WPF], sharing sizing data of rows
ms.assetid: a0535a6f-ff04-4b25-9912-7dd856e11044
ms.openlocfilehash: d5ab2ac612d55c8cbc34ae6d7d9d63b9f8aa23e7
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59190344"
---
# <a name="how-to-share-sizing-properties-between-grids"></a>Практическое руководство. Совместное использование свойств размера между сетками
В этом примере показано совместное использование данных о размере столбцов и строк для <xref:System.Windows.Controls.Grid> элементов, чтобы сохранить согласование размеров.  
  
## <a name="example"></a>Пример  
 В следующем примере представлены два <xref:System.Windows.Controls.Grid> элементы как дочерние элементы родительского элемента <xref:System.Windows.Controls.DockPanel>. <xref:System.Windows.Controls.Grid.IsSharedSizeScope%2A> Присоединенное свойство <xref:System.Windows.Controls.Grid> определенные в родительском <xref:System.Windows.Controls.DockPanel>.  
  
 Пример манипулирует значением свойства с помощью двух <xref:System.Windows.Controls.Button> элементов; каждый элемент представляет одно из значений свойства типа Boolean. Когда <xref:System.Windows.Controls.Grid.IsSharedSizeScope%2A> имеет значение `true`, каждый член столбца или строки <xref:System.Windows.Controls.DefinitionBase.SharedSizeGroup%2A> совместно использует сведения о размере, независимо от того, содержимое строки или столбца.  
  
 [!code-xaml[gridIssharedsizescopeProp#1](~/samples/snippets/csharp/VS_Snippets_Wpf/gridIssharedsizescopeProp/CSharp/Window1.xaml#1)]  
  
 ...  
  
 [!code-xaml[gridIssharedsizescopeProp#2](~/samples/snippets/csharp/VS_Snippets_Wpf/gridIssharedsizescopeProp/CSharp/Window1.xaml#2)]  
  
 В следующем примере кода программной части обрабатывает методы, кнопки <xref:System.Windows.Controls.Primitives.ButtonBase.Click> вызывает событие. Пример записывает результаты вызовов этого метода для <xref:System.Windows.Controls.TextBlock> элементы, которые используют связанные методы получения для вывода новых значений свойств в виде строк.  
  
 [!code-csharp[gridIssharedsizescopeProp#3](~/samples/snippets/csharp/VS_Snippets_Wpf/gridIssharedsizescopeProp/CSharp/Window1.xaml.cs#3)]
 [!code-vb[gridIssharedsizescopeProp#3](~/samples/snippets/visualbasic/VS_Snippets_Wpf/gridIssharedsizescopeProp/VisualBasic/Window1.xaml.vb#3)]  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Controls.Grid>
- <xref:System.Windows.Controls.Grid.IsSharedSizeScope%2A>
- [Общие сведения о панелях](panels-overview.md)
