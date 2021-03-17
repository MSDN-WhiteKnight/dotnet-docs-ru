---
title: Практическое руководство. Привязка и закрепление дочерних элементов управления в элементе управления FlowLayoutPanel
ms.date: 03/30/2017
helpviewer_keywords:
- layout [Windows Forms], child controls
- FlowLayoutPanel control [Windows Forms], child controls
- controls [Windows Forms], child
- child controls [Windows Forms], anchoring and docking
ms.assetid: a2bcdfca-9b63-45e6-9c0e-3411015cba98
ms.openlocfilehash: 255ac50ae79d6931c9b82b50677c450c0834fdea
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59329041"
---
# <a name="how-to-anchor-and-dock-child-controls-in-a-flowlayoutpanel-control"></a>Практическое руководство. Привязка и закрепление дочерних элементов управления в элементе управления FlowLayoutPanel
Элемент управления <xref:System.Windows.Forms.FlowLayoutPanel> поддерживает свойства <xref:System.Windows.Forms.Control.Anchor%2A> и <xref:System.Windows.Forms.Control.Dock%2A> в своих дочерних элементах управления.  
  
### <a name="to-anchor-and-dock-child-controls-in-a-flowlayoutpanel-control"></a>Привязка и закрепление дочерних элементов управления в элементе управления FlowLayoutPanel  
  
1. Создание элемента управления <xref:System.Windows.Forms.FlowLayoutPanel> в форме.  
  
2. Задайте <xref:System.Windows.Forms.Control.Width%2A> из <xref:System.Windows.Forms.FlowLayoutPanel> управления **300**и задайте его <xref:System.Windows.Forms.FlowLayoutPanel.FlowDirection%2A> для <xref:System.Windows.Forms.FlowDirection.TopDown>.  
  
3. Создайте два элемента управления <xref:System.Windows.Forms.Button> и поместите их в элемент управления <xref:System.Windows.Forms.FlowLayoutPanel>.  
  
4. Задайте <xref:System.Windows.Forms.Control.Width%2A> первой кнопки значение **200**.  
  
5. Присвойте свойству <xref:System.Windows.Forms.Control.Dock%2A> первой кнопки значение <xref:System.Windows.Forms.DockStyle.Fill>.  
  
    > [!NOTE]
    >  Вторая кнопка принимает ту же ширину, что и первая кнопка. Она не растягивается по ширине элемента управления <xref:System.Windows.Forms.FlowLayoutPanel>.  
  
6. Присвойте свойству <xref:System.Windows.Forms.Control.Dock%2A> первой кнопки значение `None`. При этом кнопка примет исходную ширину.  
  
7. Присвойте свойству <xref:System.Windows.Forms.Control.Anchor%2A> первой кнопки значение `Left, Right`.  
  
    > [!IMPORTANT]
    >  Вторая кнопка принимает ту же ширину, что и первая кнопка. Она не растягивается по ширине элемента управления <xref:System.Windows.Forms.FlowLayoutPanel>. Общее правило для привязки и закрепления в элементе управления <xref:System.Windows.Forms.FlowLayoutPanel>: в вертикальном направлении элемент управления <xref:System.Windows.Forms.FlowLayoutPanel> вычисляет ширину предполагаемого столбца исходя из ширины самого широкого элемента управления в столбце. Другие элементы управления в этом столбце со свойствами <xref:System.Windows.Forms.Control.Anchor%2A> или <xref:System.Windows.Forms.Control.Dock%2A> выравниваются или растягиваются до этого предполагаемого столбца. Аналогичное поведение работает и в горизонтальном направлении. Элемент управления <xref:System.Windows.Forms.FlowLayoutPanel> вычисляет высоту предполагаемой строки на основе самого высокого дочернего элемента управления в строке, и все закрепленные или привязанные дочерние элементы управления в этой строке выравниваются или их размеры устанавливаются в соответствии с предполагаемой строкой.  
  
## <a name="example"></a>Пример  
 На следующем рисунке показаны четыре кнопки, привязанный и закрепленные по отношению к синей кнопке в <xref:System.Windows.Forms.FlowLayoutPanel>. Значение параметра <xref:System.Windows.Forms.FlowLayoutPanel.FlowDirection%2A> — <xref:System.Windows.Forms.FlowDirection.LeftToRight>.  
  
 ![Закрепление FlowLayoutPanel](./media/net-flpanchorexp.gif "NET_FLPanchorExp")  
  
 На следующем рисунке показаны четыре кнопки, привязанный и закрепленные по отношению к синей кнопке в <xref:System.Windows.Forms.FlowLayoutPanel>. Значение параметра <xref:System.Windows.Forms.FlowLayoutPanel.FlowDirection%2A> — <xref:System.Windows.Forms.FlowDirection.TopDown>.  
  
 ![Закрепление FlowLayoutPanel](./media/vs-flpanchor2.gif "VS_FLPanchor2")  
  
 В следующем примере кода демонстрируются все варианты свойства <xref:System.Windows.Forms.Control.Anchor%2A> для размещения элемента управления <xref:System.Windows.Forms.Button> в элементе управления <xref:System.Windows.Forms.FlowLayoutPanel>.  
  
 [!code-csharp[System.Windows.Forms.FlowLayoutPanel.AnchorExampleForm#1](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.FlowLayoutPanel.AnchorExampleForm/CS/FlpAnchorExampleForm.cs#1)]
 [!code-vb[System.Windows.Forms.FlowLayoutPanel.AnchorExampleForm#1](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Windows.Forms.FlowLayoutPanel.AnchorExampleForm/VB/FlpAnchorExampleForm.vb#1)]  
  
## <a name="compiling-the-code"></a>Компиляция кода  
 Для этого примера требуются:  
  
-   ссылки на сборки System, System.Data, System.Drawing и System.Windows.Forms.  
  
 Сведения о выполнении сборки этого примера из командной строки для Visual Basic или Visual C#, см. в разделе [построение из командной строки](../../../visual-basic/reference/command-line-compiler/building-from-the-command-line.md) или [командной строки создания с помощью csc.exe](../../../csharp/language-reference/compiler-options/command-line-building-with-csc-exe.md). Можно также сборке этого примера в Visual Studio путем вставки кода в новый проект.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.FlowLayoutPanel>
- [Общие сведения об элементе управления FlowLayoutPanel](flowlayoutpanel-control-overview.md)
