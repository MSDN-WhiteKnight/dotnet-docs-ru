---
title: Практическое руководство. Включение режима "только для чтения" для столбцов элемента управления DataGridView в формах Windows Forms с помощью конструктора
ms.date: 03/30/2017
helpviewer_keywords:
- Windows Forms, columns
- DataGridView control [Windows Forms], read-only columns
- data [Windows Forms], displaying
- columns [Windows Forms], read-only
ms.assetid: b4ef7a75-ab33-4ee3-b2cf-201530e454e9
ms.openlocfilehash: a735b9bef9f9e3488941e05b2aa9444e6ecdc4b8
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59320084"
---
# <a name="how-to-make-columns-read-only-in-the-windows-forms-datagridview-control-using-the-designer"></a>Практическое руководство. Включение режима "только для чтения" для столбцов элемента управления DataGridView в формах Windows Forms с помощью конструктора
По умолчанию, пользователи могут изменять текст и числовые данные, отображаемые в формах Windows <xref:System.Windows.Forms.DataGridView> элемента управления. Если вы хотите отображать данные, не предназначенные для редактирования, убедитесь в столбцы, содержащие данные только для чтения. Сведения о том, как сделать элемент управления доступным только для чтения, см. в разделе [как: Запретить добавление строк и удаления в Windows Forms с помощью конструктора элемента управления DataGridView](prevent-row-addition-and-deletion-in-the-datagrid-using-the-designer.md).  
  
 Следующая процедура требуется **приложения Windows** проекта с формой, содержащей <xref:System.Windows.Forms.DataGridView> элемента управления. Сведения о настройке такого проекта см. в разделе [как: Создайте проект приложения Windows Forms](/visualstudio/ide/step-1-create-a-windows-forms-application-project) и [как: Добавление элементов управления в Windows Forms](how-to-add-controls-to-windows-forms.md).  
  
> [!NOTE]
>  Отображаемые диалоговые окна и команды меню могут отличаться от описанных в справке в зависимости от текущих параметров или выпуска. Чтобы изменить параметры, выберите в меню **Сервис** пункт **Импорт и экспорт параметров** . Дополнительные сведения см. в разделе [Персонализация интегрированной среды разработки Visual Studio](/visualstudio/ide/personalizing-the-visual-studio-ide).  
  
### <a name="to-make-a-column-read-only-by-using-the-designer"></a>Чтобы сделать столбец только для чтения с помощью конструктора  
  
1. Щелкните глиф смарт-тега (![глиф смарт-тега](./media/vs-winformsmttagglyph.gif "VS_WinFormSmtTagGlyph")) в правом верхнем углу <xref:System.Windows.Forms.DataGridView> управления, а затем выберите **Правка столбцов**.  
  
2. Выберите столбец из **выбранные столбцы** списка.  
  
3. В **свойства столбца** сетки, задайте <xref:System.Windows.Forms.DataGridViewColumn.ReadOnly%2A> свойства `true`.  
  
    > [!NOTE]
    >  Вы также можете столбец только для чтения при добавлении, выбрав **только для чтения** флажок в **добавить столбец** диалоговое окно.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.DataGridView>
- <xref:System.Windows.Forms.DataGridViewColumn.ReadOnly%2A?displayProperty=nameWithType>
- [Практическое руководство. Добавление и удаление столбцов элемента управления DataGridView в формах Windows Forms с помощью конструктора](add-and-remove-columns-in-the-datagrid-using-the-designer.md)
- [Практическое руководство. Запрет добавления и удаления строк элемента управления DataGridView в Windows Forms с помощью конструктора](prevent-row-addition-and-deletion-in-the-datagrid-using-the-designer.md)
- [Практическое руководство. Создайте проект приложения Windows Forms](/visualstudio/ide/step-1-create-a-windows-forms-application-project)
- [Практическое руководство. Добавление элементов управления в формы Windows Forms](how-to-add-controls-to-windows-forms.md)
