---
title: Практическое руководство. Объединение строк и столбцов в элементе управления TableLayoutPanel
ms.date: 03/30/2017
f1_keywords:
- net.ComponentModel.StyleCollectionEditor.TLP.SpanRowsColumns
helpviewer_keywords:
- columns [Windows Forms], spanning
- merging cells
- TableLayoutPanel control [Windows Forms], spanning rows and columns
- rows [Windows Forms], spanning
- cells [Windows Forms], merging
ms.assetid: a8a2fdd3-a848-48b0-a4cd-4e85ebded87e
ms.openlocfilehash: 02db78b07930676235e55e535fb24f6ff618d823
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59339025"
---
# <a name="how-to-span-rows-and-columns-in-a-tablelayoutpanel-control"></a>Практическое руководство. Объединение строк и столбцов в элементе управления TableLayoutPanel
Элементы управления в <xref:System.Windows.Forms.TableLayoutPanel> элемент управления может охватывать соседних строк и столбцов.  
  
> [!NOTE]
>  Отображаемые диалоговые окна и команды меню могут отличаться от описанных в справке в зависимости от текущих параметров или выпуска. Чтобы изменить параметры, выберите в меню **Сервис** пункт **Импорт и экспорт параметров** . Дополнительные сведения см. в разделе [Персонализация интегрированной среды разработки Visual Studio](/visualstudio/ide/personalizing-the-visual-studio-ide).  
  
### <a name="to-span-columns-and-rows"></a>Чтобы объединить столбцы и строки  
  
1. Перетащите элемент управления <xref:System.Windows.Forms.TableLayoutPanel> из **панели элементов** в свою форму.  
  
2. Перетащите <xref:System.Windows.Forms.Button> управления из **элементов** в левый верхний угол объекта <xref:System.Windows.Forms.TableLayoutPanel> элемента управления.  
  
3. Задайте <xref:System.Windows.Forms.Button> элемента управления **ColumnSpan** свойства **2**. Обратите внимание, что <xref:System.Windows.Forms.Button> управления охватывает первый и второй столбцы.  
  
4. Задайте <xref:System.Windows.Forms.Button> элемента управления **RowSpan** свойства **2**. Обратите внимание, что <xref:System.Windows.Forms.Button> управления охватывает первую и вторую строку.  
  
5. Задайте <xref:System.Windows.Forms.Button> элемента управления **ColumnSpan** свойства **1**. Обратите внимание, что <xref:System.Windows.Forms.Button> управления перемещается в первый столбец, но охватывает первую и вторую строку.  
  
## <a name="see-also"></a>См. также

- [Элемент управления TableLayoutPanel](tablelayoutpanel-control-windows-forms.md)
