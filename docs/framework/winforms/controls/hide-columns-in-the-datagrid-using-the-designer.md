---
title: Практическое руководство. Скрытие столбцов элемента управления DataGridView в формах Windows Forms с помощью конструктора
ms.date: 03/30/2017
helpviewer_keywords:
- Windows Forms, columns
- columns [Windows Forms], hiding
- DataGridView control [Windows Forms], column hiding
- data [Windows Forms], displaying
ms.assetid: a81c38e6-2527-426a-bcb1-be691403be04
ms.openlocfilehash: aa81eb7470b818fa2b65200503e5ce65b467c0f2
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59324452"
---
# <a name="how-to-hide-columns-in-the-windows-forms-datagridview-control-using-the-designer"></a>Практическое руководство. Скрытие столбцов элемента управления DataGridView в формах Windows Forms с помощью конструктора
Иногда требуется показать только некоторые из столбцов, доступных в элементе управления <xref:System.Windows.Forms.DataGridView> Windows Forms. Например, может потребоваться Показать сотрудник столбец заработной платы для пользователей с учетными данными управления скрывая его от других пользователей. Кроме того можно привязать элемент управления к источнику данных, содержащей много столбцов, только некоторые из которых вы хотите отобразить. В этом случае обычно будет удалить столбцы, которые не представляют интереса в отображение, а не скрываются. Дополнительные сведения см. в разделе [Как Добавление и удаление столбцов в Windows Forms с помощью конструктора элемента управления DataGridView](add-and-remove-columns-in-the-datagrid-using-the-designer.md).  
  
 Следующая процедура требуется **приложения Windows** проекта с формой, содержащей <xref:System.Windows.Forms.DataGridView> элемента управления. Сведения о настройке такого проекта см. в разделе [как: Создайте проект приложения Windows Forms](/visualstudio/ide/step-1-create-a-windows-forms-application-project) и [как: Добавление элементов управления в Windows Forms](how-to-add-controls-to-windows-forms.md).  
  
> [!NOTE]
>  Отображаемые диалоговые окна и команды меню могут отличаться от описанных в справке в зависимости от текущих параметров или выпуска. Чтобы изменить параметры, выберите в меню **Сервис** пункт **Импорт и экспорт параметров** . Дополнительные сведения см. в разделе [Персонализация интегрированной среды разработки Visual Studio](/visualstudio/ide/personalizing-the-visual-studio-ide).  
  
### <a name="to-hide-a-column-using-the-designer"></a>Чтобы скрыть столбец с помощью конструктора  
  
1. Щелкните глиф смарт-тега (![глиф смарт-тега](./media/vs-winformsmttagglyph.gif "VS_WinFormSmtTagGlyph")) в правом верхнем углу <xref:System.Windows.Forms.DataGridView> управления, а затем выберите **Правка столбцов**.  
  
2. Выберите столбец из **выбранные столбцы** списка.  
  
3. В **свойства столбца** сетки, задайте <xref:System.Windows.Forms.DataGridViewColumn.Visible%2A> свойства `false`.  
  
    > [!NOTE]
    >  Можно также скрыть столбец при его добавлении, сняв **Visible** флажок в **добавить столбец** диалоговое окно.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.DataGridView>
- <xref:System.Windows.Forms.DataGridViewColumn.Visible%2A?displayProperty=nameWithType>
- [Практическое руководство. Добавление и удаление столбцов элемента управления DataGridView в формах Windows Forms с помощью конструктора](add-and-remove-columns-in-the-datagrid-using-the-designer.md)
- [Практическое руководство. Создайте проект приложения Windows Forms](/visualstudio/ide/step-1-create-a-windows-forms-application-project)
- [Практическое руководство. Добавление элементов управления в формы Windows Forms](how-to-add-controls-to-windows-forms.md)
