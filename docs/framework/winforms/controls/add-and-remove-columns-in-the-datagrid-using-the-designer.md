---
title: Практическое руководство. Добавление и удаление столбцов элемента управления DataGridView в формах Windows Forms с помощью конструктора
ms.date: 03/30/2017
f1_keywords:
- vs.DataGridViewAddColumnDialog
helpviewer_keywords:
- DataGridView control [Windows Forms], adding columns
- DataGridView control [Windows Forms], removing columns
ms.assetid: 9e709f35-0a8c-4e7e-b4c4-bacb7a834077
ms.openlocfilehash: 80ede9b7bc5bf667e03dc0a745fbc0b5f6c2663a
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59343289"
---
# <a name="how-to-add-and-remove-columns-in-the-windows-forms-datagridview-control-using-the-designer"></a>Практическое руководство. Добавление и удаление столбцов элемента управления DataGridView в формах Windows Forms с помощью конструктора
Windows Forms <xref:System.Windows.Forms.DataGridView> элемент управления должен содержать столбцы для отображения данных. Если вы планируете вручную заполнение элемента управления, необходимо добавить столбцы самостоятельно. Кроме того можно привязать элемент управления к источнику данных, который создает и заполняет столбцы автоматически. Если источник данных содержит больше столбцов, чем требуется отобразить, можно удалить ненужные столбцы.  
  
 Следующие процедуры требуют **приложения Windows** проекта с формой, содержащей <xref:System.Windows.Forms.DataGridView> элемента управления. Сведения о настройке такого проекта см. в разделе [как: Создайте проект приложения Windows Forms](/visualstudio/ide/step-1-create-a-windows-forms-application-project) и [как: Добавление элементов управления в Windows Forms](how-to-add-controls-to-windows-forms.md).  
  
> [!NOTE]
>  Отображаемые диалоговые окна и команды меню могут отличаться от описанных в справке в зависимости от текущих параметров или выпуска. Чтобы изменить параметры, выберите в меню **Сервис** пункт **Импорт и экспорт параметров** . Дополнительные сведения см. в разделе [Персонализация интегрированной среды разработки Visual Studio](/visualstudio/ide/personalizing-the-visual-studio-ide).  
  
### <a name="to-add-a-column-using-the-designer"></a>Чтобы добавить столбец с помощью конструктора  
  
1. Щелкните глиф смарт-тега (![глиф смарт-тега](./media/vs-winformsmttagglyph.gif "VS_WinFormSmtTagGlyph")) в правом верхнем углу <xref:System.Windows.Forms.DataGridView> управления, а затем выберите **добавить столбец**.  
  
2. В **добавить столбец** диалоговое окно, выберите **с привязкой к данным столбца** параметр и выберите столбец из источника данных или выберите **несвязанного столбца** параметр и для определения столбца с помощью соответствующих полях.  
  
3. Нажмите кнопку **добавить** кнопка для добавления столбца, который отображается в конструкторе, если существующие столбцы не заполняет область отображения элемента управления.  
  
    > [!NOTE]
    >  Можно изменить свойства столбца в **Правка столбцов** диалоговое окно, к которому можно получить из смарт-тега элемента управления.  
  
### <a name="to-remove-a-column-using-the-designer"></a>Чтобы удалить столбец, с помощью конструктора  
  
1. Выберите **Правка столбцов** смарт-теге элемента управления.  
  
2. Выберите столбец из **выбранные столбцы** списка.  
  
3. Нажмите кнопку **удалить** кнопку, чтобы удалить столбец, чего он исчезнет из конструктора.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.DataGridView>
- [Практическое руководство. Создайте проект приложения Windows Forms](/visualstudio/ide/step-1-create-a-windows-forms-application-project)
- [Практическое руководство. Добавление элементов управления в формы Windows Forms](how-to-add-controls-to-windows-forms.md)
