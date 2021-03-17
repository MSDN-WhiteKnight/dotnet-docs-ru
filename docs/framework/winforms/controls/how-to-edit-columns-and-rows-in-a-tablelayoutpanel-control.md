---
title: Практическое руководство. Изменение столбцов и строк в элементе управления TableLayoutPanel
ms.date: 03/30/2017
f1_keywords:
- net.ComponentModel.StyleCollectionEditor
helpviewer_keywords:
- columns [Windows Forms], editing
- TableLayoutPanel control [Windows Forms], editing
- rows [Windows Forms], editing
ms.assetid: c367ed43-40dc-49eb-9e0f-ba70e83dfec0
ms.openlocfilehash: 2149cac7fb15052c2602ef20a6684696730aae1b
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59294475"
---
# <a name="how-to-edit-columns-and-rows-in-a-tablelayoutpanel-control"></a>Практическое руководство. Изменение столбцов и строк в элементе управления TableLayoutPanel
Можно использовать редактор коллекции для <xref:System.Windows.Forms.TableLayoutPanel> элементом управления, называемым **стили столбцов и строк** диалоговое окно для редактирования строк и столбцов элементов управления.  
  
> [!NOTE]
>  Элемент управления, чтобы охватывать несколько строк или столбцов, задайте `RowSpan` и `ColumnSpan` свойствам элемента управления. Дополнительные сведения см. в разделе [Пошаговое руководство: Упорядочение элементов управления в Windows Forms, с помощью элемента управления TableLayoutPanel](walkthrough-arranging-controls-on-windows-forms-using-a-tablelayoutpanel.md).  
>   
>  Если вы хотите выравнивание элементов управления внутри ячейки или элемент управления выполнить растяжение в ячейке, использование элемента управления <xref:System.Windows.Forms.Control.Anchor%2A> свойство. Дополнительные сведения см. в разделе [Пошаговое руководство: Упорядочение элементов управления в Windows Forms, с помощью элемента управления TableLayoutPanel](walkthrough-arranging-controls-on-windows-forms-using-a-tablelayoutpanel.md).  
>   
>  Отображаемые диалоговые окна и команды меню могут отличаться от описанных в справке в зависимости от текущих параметров или выпуска. Чтобы изменить параметры, выберите в меню **Сервис** пункт **Импорт и экспорт параметров** . Дополнительные сведения см. в разделе [Персонализация интегрированной среды разработки Visual Studio](/visualstudio/ide/personalizing-the-visual-studio-ide).  
  
### <a name="to-edit-rows-and-columns"></a>Чтобы изменить строки и столбцы  
  
1. Перетащите элемент управления <xref:System.Windows.Forms.TableLayoutPanel> из **панели элементов** в свою форму.  
  
2. Нажмите кнопку <xref:System.Windows.Forms.TableLayoutPanel> глиф смарт-тега элемента управления (![глиф смарт-тега](./media/vs-winformsmttagglyph.gif "VS_WinFormSmtTagGlyph")) и выберите **изменить строки и столбцы** открыть  **Стили столбцов и строк** диалоговое окно. Вы можете также щелкнуть правой кнопкой мыши <xref:System.Windows.Forms.TableLayoutPanel> управления и выберите **изменить строки и столбцы** в контекстном меню.  
  
3. Чтобы добавить или удалить столбцы, выберите **столбцы** из **тип члена** поле с раскрывающимся списком.  
  
4. Чтобы добавить или удалить строки, выберите **строк** из **тип члена** поле с раскрывающимся списком.  
  
5. Нажмите кнопку **добавить** , чтобы добавить в конец строки или столбца **член** списка.  
  
6. Нажмите кнопку **вставить** кнопку, чтобы добавить строки или столбца перед текущего выбранного элемента в списке.  
  
7. При добавлении строки или столбца, выберите **тип размера** для новой строки или столбца. Дополнительные сведения см. в разделе <xref:System.Windows.Forms.SizeType>.  
  
8. Чтобы удалить строки или столбца, щелкните **удалить** кнопку, чтобы удалить выбранный элемент в **член** списка.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.SizeType>
- [Элемент управления TableLayoutPanel](tablelayoutpanel-control-windows-forms.md)
