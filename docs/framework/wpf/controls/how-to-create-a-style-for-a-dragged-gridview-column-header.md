---
title: Практическое руководство. Создание стиля для перетаскиваемого заголовка столбца GridView
ms.date: 03/30/2017
helpviewer_keywords:
- ListView controls [WPF], styling
ms.assetid: 0b999645-0313-4b33-80b9-19ece08b5459
ms.openlocfilehash: dbcdd38e0397b8e637aff962420a2959f33203df
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59090099"
---
# <a name="how-to-create-a-style-for-a-dragged-gridview-column-header"></a>Практическое руководство. Создание стиля для перетаскиваемого заголовка столбца GridView
В этом примере показано, как изменить внешний вид перетаскиваемого <xref:System.Windows.Controls.GridViewColumnHeader> когда пользователь изменяет положение столбца.  
  
## <a name="example"></a>Пример  
 При перетаскивании заголовка столбца в другое расположение в <xref:System.Windows.Controls.ListView> , использующий <xref:System.Windows.Controls.GridView> для режима просмотра, столбец перемещается в новое положение. При перетаскивании заголовка столбца, а также исходный заголовок появится с плавающей запятой копия заголовок. Заголовок столбца в <xref:System.Windows.Controls.GridView> представленного <xref:System.Windows.Controls.GridViewColumnHeader> объекта.  
  
 Чтобы настроить внешний вид заголовков с плавающей запятой и исходное, можно задать <xref:System.Windows.Controls.ControlTemplate.Triggers%2A> изменение <xref:System.Windows.Controls.GridViewColumnHeader> <xref:System.Windows.Style>. Эти <xref:System.Windows.Controls.ControlTemplate.Triggers%2A> применяются при <xref:System.Windows.Controls.Primitives.ButtonBase.IsPressed%2A> свойство имеет значение `true` и <xref:System.Windows.Controls.GridViewColumnHeader.Role%2A> свойство имеет значение <xref:System.Windows.Controls.GridViewColumnHeaderRole.Floating>.  
  
 Когда пользователь нажимает кнопку мыши и удерживании его, когда указатель мыши задерживается на <xref:System.Windows.Controls.GridViewColumnHeader>, <xref:System.Windows.Controls.Primitives.ButtonBase.IsPressed%2A> для изменения значения свойства `true`. Аналогичным образом, в том случае, когда пользователь начинает операцию перетаскивания, <xref:System.Windows.Controls.GridViewColumnHeader.Role%2A> изменения свойств <xref:System.Windows.Controls.GridViewColumnHeaderRole.Floating>.  
  
 В следующем примере показано, как задать <xref:System.Windows.Controls.ControlTemplate.Triggers%2A> изменение <xref:System.Windows.Controls.Control.Foreground%2A> и <xref:System.Windows.Controls.Control.Background%2A> цвета заголовков исходного и с плавающей запятой, когда пользователь перетаскивает столбца в новую позицию.  
  
 [!code-xaml[ListViewHeaderRoleStyle#GVCHControlTemplateStart](~/samples/snippets/csharp/VS_Snippets_Wpf/ListViewHeaderRoleStyle/CS/Window1.xaml#gvchcontroltemplatestart)]  
[!code-xaml[ListViewHeaderRoleStyle#ControlTemplateTriggersStart](~/samples/snippets/csharp/VS_Snippets_Wpf/ListViewHeaderRoleStyle/CS/Window1.xaml#controltemplatetriggersstart)]  
[!code-xaml[ListViewHeaderRoleStyle#IsPressed](~/samples/snippets/csharp/VS_Snippets_Wpf/ListViewHeaderRoleStyle/CS/Window1.xaml#ispressed)]  
[!code-xaml[ListViewHeaderRoleStyle#Floating](~/samples/snippets/csharp/VS_Snippets_Wpf/ListViewHeaderRoleStyle/CS/Window1.xaml#floating)]  
[!code-xaml[ListViewHeaderRoleStyle#ControlTemplateTriggersEnd](~/samples/snippets/csharp/VS_Snippets_Wpf/ListViewHeaderRoleStyle/CS/Window1.xaml#controltemplatetriggersend)]  
[!code-xaml[ListViewHeaderRoleStyle#GVCHControlTemplateEnd](~/samples/snippets/csharp/VS_Snippets_Wpf/ListViewHeaderRoleStyle/CS/Window1.xaml#gvchcontroltemplateend)]  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Controls.GridViewColumnHeader>
- <xref:System.Windows.Controls.GridViewColumnHeaderRole>
- <xref:System.Windows.Controls.ListView>
- <xref:System.Windows.Controls.GridView>
- [Практические руководства](listview-how-to-topics.md)
- [Общие сведения об элементе управления ListView](listview-overview.md)
- [Общие сведения о GridView](gridview-overview.md)
