---
title: Практическое руководство. Выравнивание элементов управления по границам формы во время выполнения
ms.date: 03/30/2017
helpviewer_keywords:
- custom controls [Windows Forms], docking using designer
- Dock property [Windows Forms], aligning controls (using designer)
ms.assetid: 51f08998-5e3b-4330-be58-a4edd0eb60f4
ms.openlocfilehash: 8ca6fd64edbd73301fd298f42c3d4d97d021888a
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59331868"
---
# <a name="how-to-align-a-control-to-the-edges-of-forms-at-design-time"></a>Практическое руководство. Выравнивание элементов управления по границам формы во время выполнения
Чтобы выровнять по границе формы, задав элемент управления <xref:System.Windows.Forms.Control.Dock%2A>. Это свойство определяет, в каком месте формы будет размещаться элемент управления. Свойство <xref:System.Windows.Forms.Control.Dock%2A> может принимать указанные ниже значения.  
  
|Параметр|Влияние на элемент управления|  
|-------------|----------------------------|  
|<xref:System.Windows.Forms.DockStyle.Bottom>|Фиксирует элемент управления у нижнего края формы.|  
|<xref:System.Windows.Forms.DockStyle.Fill>|Заполняет все свободное пространство формы.|  
|<xref:System.Windows.Forms.DockStyle.Left>|Фиксирует элемент управления у левого края формы.|  
|<xref:System.Windows.Forms.DockStyle.None>|Не фиксирует элемент нигде; он отображается в расположении, указанном путем его <xref:System.Windows.Forms.Control.Location%2A>.|  
|<xref:System.Windows.Forms.DockStyle.Right>|Фиксирует элемент управления у правого края формы.|  
|<xref:System.Windows.Forms.DockStyle.Top>|Фиксирует элемент управления у верхнего края формы.|  
  
 Эти значения можно также задать в коде. Дополнительные сведения см. в разделе [Как Выравнивание элементов управления по границам формы](how-to-align-a-control-to-the-edges-of-forms.md).  
  
> [!NOTE]
>  Отображаемые диалоговые окна и команды меню могут отличаться от описанных в справке в зависимости от текущих параметров или выпуска. Чтобы изменить параметры, выберите в меню **Сервис** пункт **Импорт и экспорт параметров** . Дополнительные сведения см. в разделе [Персонализация интегрированной среды разработки Visual Studio](/visualstudio/ide/personalizing-the-visual-studio-ide).  
  
### <a name="to-set-the-dock-property-for-your-control-at-design-time"></a>Чтобы задать свойства Dock для элемента управления во время разработки  
  
1. В конструкторе Windows Forms выберите элемент управления.  
  
2. В **свойства** окно, щелкните в раскрывающемся поле рядом с <xref:System.Windows.Forms.Control.Dock%2A> свойство.  
  
     Графический интерфейс с шестью возможными <xref:System.Windows.Forms.Control.Dock%2A> параметров отображается.  
  
3. Выберите соответствующий параметр.  
  
4. Элемент управления будет зафиксировано в отношении, определенном с помощью параметра.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.Control.Dock%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.Control.Anchor%2A?displayProperty=nameWithType>
- [Практическое руководство. Выравнивание элементов управления по границам формы](how-to-align-a-control-to-the-edges-of-forms.md)
- [Пошаговое руководство. Упорядочение элементов управления в формах Windows Forms с помощью линий привязки](walkthrough-arranging-controls-on-windows-forms-using-snaplines.md)
- [Практическое руководство. Привязка элементов управления в формах Windows Forms](how-to-anchor-controls-on-windows-forms.md)
- [Практическое руководство. Привязка и закрепление дочерних элементов управления в элементе управления TableLayoutPanel](how-to-anchor-and-dock-child-controls-in-a-tablelayoutpanel-control.md)
- [Практическое руководство. Привязка и закрепление дочерних элементов управления в элементе управления FlowLayoutPanel](how-to-anchor-and-dock-child-controls-in-a-flowlayoutpanel-control.md)
- [Пошаговое руководство. Упорядочение элементов управления в формах Windows Forms с помощью элемента TableLayoutPanel](walkthrough-arranging-controls-on-windows-forms-using-a-tablelayoutpanel.md)
- [Пошаговое руководство. Упорядочение элементов управления в формах Windows Forms с помощью элемента FlowLayoutPanel](walkthrough-arranging-controls-on-windows-forms-using-a-flowlayoutpanel.md)
- [Создание элементов управления Windows Forms во время разработки](developing-windows-forms-controls-at-design-time.md)
