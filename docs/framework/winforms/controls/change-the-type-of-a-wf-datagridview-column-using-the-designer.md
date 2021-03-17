---
title: Практическое руководство. Изменение типа столбца DataGridView в формах Windows Forms с помощью конструктора
ms.date: 03/30/2017
helpviewer_keywords:
- Windows Forms, columns
- columns [Windows Forms], types
- DataGridView control [Windows Forms], changing column type
- data [Windows Forms], displaying
ms.assetid: 7f994d45-600d-4190-a187-35803214b40c
ms.openlocfilehash: e87017f3698bc88a123d8a0ba0df5dbe2b7bbfd9
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59314871"
---
# <a name="how-to-change-the-type-of-a-windows-forms-datagridview-column-using-the-designer"></a>Практическое руководство. Изменение типа столбца DataGridView в формах Windows Forms с помощью конструктора
Иногда требуется изменить тип столбца, который уже был добавлен к формам Windows <xref:System.Windows.Forms.DataGridView> элемента управления. Например может потребоваться изменить типы некоторых столбцов, которые создаются автоматически при привязке элемента управления к источнику данных. Это полезно в тех случаях, когда в таблице, которые отображены есть столбцы, содержащие внешние ключи для строк в связанной таблице. В этом случае необходимо заменить столбцы с текстовыми полями, которые отображают эти внешние ключи, со столбцами поле со списком, отобразить более понятные значения из связанной таблицы.  
  
 Следующая процедура требуется **приложения Windows** проекта с формой, содержащей <xref:System.Windows.Forms.DataGridView> элемента управления. Сведения о настройке такого проекта см. в разделе [как: Создайте проект приложения Windows Forms](/visualstudio/ide/step-1-create-a-windows-forms-application-project) и [как: Добавление элементов управления в Windows Forms](how-to-add-controls-to-windows-forms.md).  
  
> [!NOTE]
>  Отображаемые диалоговые окна и команды меню могут отличаться от описанных в справке в зависимости от текущих параметров или выпуска. Чтобы изменить параметры, выберите в меню **Сервис** пункт **Импорт и экспорт параметров** . Дополнительные сведения см. в разделе [Персонализация интегрированной среды разработки Visual Studio](/visualstudio/ide/personalizing-the-visual-studio-ide).  
  
### <a name="to-change-the-type-of-a-column-using-the-designer"></a>Чтобы изменить тип столбца с помощью конструктора  
  
1. Щелкните глиф смарт-тега (![глиф смарт-тега](./media/vs-winformsmttagglyph.gif "VS_WinFormSmtTagGlyph")) в правом верхнем углу <xref:System.Windows.Forms.DataGridView> управления, а затем выберите **Правка столбцов**.  
  
2. Выберите столбец из **выбранные столбцы** списка.  
  
3. В **свойства столбца** сетки, задайте `ColumnType` свойство в новый тип столбца.  
  
    > [!NOTE]
    >  `ColumnType` Свойство является свойством только во время разработки, который указывает класс, представляющий тип столбца. Это не фактическое свойство, определенное в классе столбца.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.DataGridView>
- <xref:System.Windows.Forms.DataGridViewColumn>
- [Практическое руководство. Создайте проект приложения Windows Forms](/visualstudio/ide/step-1-create-a-windows-forms-application-project)
- [Практическое руководство. Добавление элементов управления в формы Windows Forms](how-to-add-controls-to-windows-forms.md)
