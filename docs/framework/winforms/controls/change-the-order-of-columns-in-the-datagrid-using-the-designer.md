---
title: Практическое руководство. Изменение порядка столбцов элемента управления DataGridView в формах Windows Forms с помощью конструктора
ms.date: 03/30/2017
helpviewer_keywords:
- columns [Windows Forms], order of
- DataGridView control [Windows Forms], column order
- Windows Forms, columns
- data [Windows Forms], displaying
ms.assetid: 7fe52a98-75d6-448c-97a5-65ca2c568c1a
ms.openlocfilehash: cb8aeb30e12f7af18b475fd7707fa9d2ede6a299
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59311517"
---
# <a name="how-to-change-the-order-of-columns-in-the-windows-forms-datagridview-control-using-the-designer"></a>Практическое руководство. Изменение порядка столбцов элемента управления DataGridView в формах Windows Forms с помощью конструктора
При привязке форм Windows <xref:System.Windows.Forms.DataGridView> элемента управления к источнику данных, порядок отображения автоматически создаваемые столбцы, зависит от источника данных. Если вас не устраивает, можно изменить порядок столбцов, с помощью конструктора. Можно также добавить несвязанных столбцов в элемент управления и изменить порядок их отображения. Сведения о том, как изменение порядка столбцов программным образом см. в разделе [как: Изменение порядка столбцов элемента управления DataGridView в Windows Forms](how-to-change-the-order-of-columns-in-the-windows-forms-datagridview-control.md).  
  
 Следующая процедура требуется **приложения Windows** проекта с формой, содержащей <xref:System.Windows.Forms.DataGridView> элемента управления. Сведения о настройке такого проекта см. в разделе [как: Создайте проект приложения Windows Forms](/visualstudio/ide/step-1-create-a-windows-forms-application-project) и [как: Добавление элементов управления в Windows Forms](how-to-add-controls-to-windows-forms.md).  
  
> [!NOTE]
>  Отображаемые диалоговые окна и команды меню могут отличаться от описанных в справке в зависимости от текущих параметров или выпуска. Чтобы изменить параметры, выберите в меню **Сервис** пункт **Импорт и экспорт параметров** . Дополнительные сведения см. в разделе [Персонализация Интегрированной среды разработки Visual Studio](/visualstudio/ide/personalizing-the-visual-studio-ide)  
  
### <a name="to-change-the-column-order-using-the-designer"></a>Чтобы изменить порядок столбцов, с помощью конструктора  
  
1. Щелкните глиф смарт-тега (![глиф смарт-тега](./media/vs-winformsmttagglyph.gif "VS_WinFormSmtTagGlyph")) в правом верхнем углу <xref:System.Windows.Forms.DataGridView> управления, а затем выберите **Правка столбцов**.  
  
2. Выберите столбец из **выбранные столбцы** списка.  
  
3. Щелкните стрелку вверх или стрелку справа от раскрывающегося списка **выбранных столбцов** списка до выбранного столбца в нужное место.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.DataGridView>
- [Практическое руководство. Добавление и удаление столбцов элемента управления DataGridView в формах Windows Forms с помощью конструктора](add-and-remove-columns-in-the-datagrid-using-the-designer.md)
- [Практическое руководство. Создайте проект приложения Windows Forms](/visualstudio/ide/step-1-create-a-windows-forms-application-project)
- [Практическое руководство. Добавление элементов управления в формы Windows Forms](how-to-add-controls-to-windows-forms.md)
