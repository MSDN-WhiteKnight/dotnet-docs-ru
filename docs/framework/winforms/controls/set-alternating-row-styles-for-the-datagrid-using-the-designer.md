---
title: Практическое руководство. Установка стилей для чередующихся строк в элементе управления DataGridView формы Windows Forms с помощью конструктора
ms.date: 03/30/2017
helpviewer_keywords:
- ledger-like formats
- DataGridView control [Windows Forms], row style alternation
- Windows Forms, rows
- rows [Windows Forms], alternating
- data [Windows Forms], displaying
ms.assetid: 02373442-bf94-4470-9f8a-e44c4a9d5b88
ms.openlocfilehash: fb338a3616bc20542ec940db5977c4ffdab9654c
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59335632"
---
# <a name="how-to-set-alternating-row-styles-for-the-windows-forms-datagridview-control-using-the-designer"></a>Практическое руководство. Установка стилей для чередующихся строк в элементе управления DataGridView формы Windows Forms с помощью конструктора
Данные в таблицах часто представлены в виде подобном бухгалтерским книгам: в чередующихся строках используется разный цвет фона. Такой формат позволяет проще определять, какие ячейки находятся в какой строке, что особенно удобно в широких таблицах со множеством столбцов.  
  
 С помощью элемента управления <xref:System.Windows.Forms.DataGridView> можно указать полные сведения о стиле для чередующихся строк. Характеристики стиля, как цвет и шрифт, а также цвет фона, можно использовать для различения чередующихся строк. Дополнительные сведения см. в разделе [стили ячеек элемента управления DataGridView Windows Forms в](cell-styles-in-the-windows-forms-datagridview-control.md).  
  
 Следующая процедура требуется **приложения Windows** проекта с формой, содержащей <xref:System.Windows.Forms.DataGridView> элемента управления. Сведения о настройке такого проекта см. в разделе [как: Создайте проект приложения Windows Forms](/visualstudio/ide/step-1-create-a-windows-forms-application-project) и [как: Добавление элементов управления в Windows Forms](how-to-add-controls-to-windows-forms.md).  
  
> [!NOTE]
>  Отображаемые диалоговые окна и команды меню могут отличаться от описанных в справке в зависимости от текущих параметров или выпуска. Чтобы изменить параметры, выберите в меню **Сервис** пункт **Импорт и экспорт параметров** . Дополнительные сведения см. в разделе [Персонализация интегрированной среды разработки Visual Studio](/visualstudio/ide/personalizing-the-visual-studio-ide).  
  
### <a name="define-styles-for-alternating-rows"></a>Определение стилей для чередующихся строк  
  
1. Выберите <xref:System.Windows.Forms.DataGridView> управления в конструкторе.  
  
2. В **свойства** окно, нажмите кнопку с многоточием (![экрана VisualStudioEllipsesButton](../media/vbellipsesbutton.png "vbEllipsesButton")) рядом с полем <xref:System.Windows.Forms.DataGridView.AlternatingRowsDefaultCellStyle%2A> свойство.  
  
3. В **построителя CellStyle** диалоговом окне определения стиля, устанавливая свойства и использовать **предварительной версии** панели, чтобы подтвердить выбранные параметры. Для каждой строки, отображаемый в элементе управления, начиная со второй используются стили вами.  
  
4. Чтобы определить стили для оставшихся строк, повторите шаги 2 и 3. Использование <xref:System.Windows.Forms.DataGridView.RowsDefaultCellStyle%2A> свойство.  
  
    > [!NOTE]
    >  Для отображения ячеек с помощью стилей, унаследованные от различных свойств. Дополнительные сведения о наследовании стилей см. в разделе [стили ячеек элемента управления DataGridView Windows Forms в](cell-styles-in-the-windows-forms-datagridview-control.md).  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.DataGridView>
- [Стили ячеек элемента управления DataGridView в Windows Forms](cell-styles-in-the-windows-forms-datagridview-control.md)
- [Базовое форматирование и оформление элемента управления DataGridView в Windows Forms](basic-formatting-and-styling-in-the-windows-forms-datagridview-control.md)
- [Использование конструктора с элементом управления DataGridView Windows Forms](using-the-designer-with-the-windows-forms-datagridview-control.md)
- [Практическое руководство. Создайте проект приложения Windows Forms](/visualstudio/ide/step-1-create-a-windows-forms-application-project)
- [Практическое руководство. Добавление элементов управления в формы Windows Forms](how-to-add-controls-to-windows-forms.md)
