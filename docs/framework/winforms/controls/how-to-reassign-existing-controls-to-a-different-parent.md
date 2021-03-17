---
title: Практическое руководство. Переназначение существующих элементов управления другим родительским элементам
ms.date: 03/30/2017
helpviewer_keywords:
- container controls [Windows Forms], Windows Forms
- layout [Windows Forms], resizing
- layout [Windows Forms], child controls
ms.assetid: 5a5723ff-34e0-4b6f-a57b-be4ebe35cb34
ms.openlocfilehash: 2639322707c1c7e378f6d389a1dec80fd619841c
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59328222"
---
# <a name="how-to-reassign-existing-controls-to-a-different-parent"></a>Практическое руководство. Переназначение существующих элементов управления другим родительским элементам
Можно назначать существующие в форме элементы управления новому контейнерному элементу управления.  
  
> [!NOTE]
>  Отображаемые диалоговые окна и команды меню могут отличаться от описанных в справке в зависимости от текущих параметров или выпуска. Чтобы изменить параметры, выберите в меню **Сервис** пункт **Импорт и экспорт параметров** . Дополнительные сведения см. в разделе [Персонализация интегрированной среды разработки Visual Studio](/visualstudio/ide/personalizing-the-visual-studio-ide).  
  
### <a name="to-reassign-existing-controls-to-a-different-parent"></a>Переназначение существующих элементов управления другим родительским элементам  
  
1. Перетащите три элемента управления <xref:System.Windows.Forms.Button> с **панели элементов** в форму.  
  
     Расположите их рядом друг с другом, но не выравнивайте.  
  
2. В **панели элементов**щелкните значок элемента управления <xref:System.Windows.Forms.FlowLayoutPanel> .  
  
     Не перетаскивайте значок на форму.  
  
3. Переместите указатель мыши к трем элементам управления <xref:System.Windows.Forms.Button> .  
  
     Указатель превратится в перекрестие с прикрепленным значком элемента управления <xref:System.Windows.Forms.FlowLayoutPanel> .  
  
4. Нажмите и удерживайте кнопку мыши.  
  
5. Перемещайте указатель мыши, чтобы нарисовать контур элемента управления <xref:System.Windows.Forms.FlowLayoutPanel> .  
  
6. Обведите таким образом три элемента управления <xref:System.Windows.Forms.Button> .  
  
7. Отпустите кнопку мыши.  
  
     Теперь три элемента управления <xref:System.Windows.Forms.Button> вставлены в элемент управления <xref:System.Windows.Forms.FlowLayoutPanel> .  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.FlowLayoutPanel>
- <xref:System.Windows.Forms.TableLayoutPanel>
- [Расположение элементов управления в формах Windows Forms](arranging-controls-on-windows-forms.md)
- [Пошаговое руководство. Упорядочение элементов управления в формах Windows Forms с помощью элемента TableLayoutPanel](walkthrough-arranging-controls-on-windows-forms-using-a-tablelayoutpanel.md)
- [Пошаговое руководство. Упорядочение элементов управления в формах Windows Forms с помощью линий привязки](walkthrough-arranging-controls-on-windows-forms-using-snaplines.md)
