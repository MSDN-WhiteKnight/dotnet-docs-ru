---
title: Практическое руководство. Привязка данных к элементу управления DataGridView в форме Windows Forms с помощью конструктора
ms.date: 03/30/2017
helpviewer_keywords:
- Windows Forms controls, binding to a data source
- data sources [Windows Forms], binding to Windows Forms controls
- DataGridView control [Windows Forms], data binding
ms.assetid: f4f46009-cec2-441b-8668-6b5af057558b
ms.openlocfilehash: 59a025535e850cf3c773a2a078511d41058bb24c
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59321852"
---
# <a name="how-to-bind-data-to-the-windows-forms-datagridview-control-using-the-designer"></a>Практическое руководство. Привязка данных к элементу управления DataGridView в форме Windows Forms с помощью конструктора
Конструктор можно использовать для подключения <xref:System.Windows.Forms.DataGridView> элемента управления к источникам данных разных видов, включая базы данных, бизнес-объектов или веб-служб. При привязке элемента управления к источнику данных с помощью конструктора, элемент управления автоматически привязывается к <xref:System.Windows.Forms.BindingSource> компонент, который представляет источник данных. Кроме того, в элементе управления автоматически создаются столбцы для сопоставления данных о схеме, предоставляемых источником данных.  
  
 После этого созданные столбцы можно будет изменить с учетом ваших потребностей. Например, можно удалить или скрыть столбцы, которые вас не интересуют, изменить порядок или типы столбцов. Дополнительные сведения об изменении столбцов см. в разделах, перечисленных в разделе "См. также".  
  
 Можно также привязать несколько <xref:System.Windows.Forms.DataGridView> элементы управления для связанных таблиц для создания отношений "основной/подробности". В данной конфигурации один элемент управления отображает родительскую таблицу, а другой — только те строки из дочерней таблицы, которые связаны с текущей строкой в родительской таблице. Дополнительные сведения см. в разделе [Как Отображение связанных данных в Windows Forms Application](https://docs.microsoft.com/previous-versions/visualstudio/visual-studio-2013/57tx3hhe(v=vs.120)).  
  
 Для следующей процедуры требуется **приложения Windows** проект с формой, содержащей <xref:System.Windows.Forms.DataGridView> элемента управления или двух элементов управления для отношения "основной/подробности". Сведения о создании такого проекта, см. в разделе [как: Создайте проект приложения Windows Forms](/visualstudio/ide/step-1-create-a-windows-forms-application-project) и [как: Добавление элементов управления в Windows Forms](how-to-add-controls-to-windows-forms.md).  
  
> [!NOTE]
>  Отображаемые диалоговые окна и команды меню могут отличаться от описанных в справке в зависимости от текущих параметров или выпуска. Чтобы изменить параметры, выберите в меню **Сервис** пункт **Импорт и экспорт параметров** . Дополнительные сведения см. в разделе [Персонализация интегрированной среды разработки Visual Studio](/visualstudio/ide/personalizing-the-visual-studio-ide).  
  
### <a name="to-bind-the-control-to-a-data-source"></a>Привязка элемента управления к источнику данных  
  
1. Щелкните глиф смарт-тега (![глиф смарт-тега](./media/vs-winformsmttagglyph.gif "VS_WinFormSmtTagGlyph")) в правом верхнем углу <xref:System.Windows.Forms.DataGridView> элемента управления.  
  
2. Щелкните стрелку раскрывающегося списка рядом с параметром **Выбор источника данных**.  
  
3. Если у проекта еще нет источника данных, нажмите **Добавить источник данных проекта** и следуйте указаниям мастера.  
  
     Дополнительные сведения см. в разделе [Мастер настройки источника данных](https://docs.microsoft.com/previous-versions/visualstudio/visual-studio-2013/w4dd7z6t(v=vs.120)). Новый источник данных появится в раскрывающемся окне **Выбор источника данных**. Если источник данных содержит только один элемент, например только одну таблицу баз данных, элемент управления будет автоматически привязан к этому элементу. В противном случае перейдите к следующему этапу.  
  
4. Разверните узлы **Другие источники данных** и **Источники данных проекта**, если они еще не развернуты, и выберите источник данных, к которому нужно привязать элемент управления.  
  
5. Если источник данных содержит несколько членов, например, если вы создали <xref:System.Data.DataSet?displayProperty=nameWithType> , содержащего несколько таблиц, разверните источник данных, затем выберите конкретный элемент для привязки.  
  
6. Чтобы создать отношение "основной/подробности" в **Выбор источника данных** раскрывающееся окно на секунду <xref:System.Windows.Forms.DataGridView> управления, разверните <xref:System.Windows.Forms.BindingSource> создан для родительской таблицы, а затем выберите соответствующую дочернюю таблицу из списка показано.  
  
    > [!NOTE]
    >  Если в вашем проекте уже есть источник данных, форму данных можно также создать в окне **Источники данных**. Дополнительные сведения см. в разделе [Окно источников данных](https://docs.microsoft.com/previous-versions/visualstudio/visual-studio-2013/6ckyxa83(v=vs.120)).  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.DataGridView>
- <xref:System.Windows.Forms.BindingSource>
- <xref:System.Windows.Forms.DataGridView.DataMember%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.DataGridView.DataSource%2A?displayProperty=nameWithType>
- [Практическое руководство. Подключение к данным в базе данных](https://docs.microsoft.com/previous-versions/visualstudio/visual-studio-2013/fxk9yw1t(v=vs.120))
- [Практическое руководство. Добавление и удаление столбцов элемента управления DataGridView в формах Windows Forms с помощью конструктора](add-and-remove-columns-in-the-datagrid-using-the-designer.md)
- [Практическое руководство. Изменение порядка столбцов элемента управления DataGridView в формах Windows Forms с помощью конструктора](change-the-order-of-columns-in-the-datagrid-using-the-designer.md)
- [Практическое руководство. Изменение типа столбца DataGridView в формах Windows Forms с помощью конструктора](change-the-type-of-a-wf-datagridview-column-using-the-designer.md)
- [Практическое руководство. Замораживание столбцов элемента управления DataGridView в формах Windows Forms с помощью конструктора](freeze-columns-in-the-datagrid-using-the-designer.md)
- [Практическое руководство. Скрытие столбцов элемента управления DataGridView в формах Windows Forms с помощью конструктора](hide-columns-in-the-datagrid-using-the-designer.md)
- [Практическое руководство. Включение режима "только для чтения" для столбцов элемента управления DataGridView в формах Windows Forms с помощью конструктора](make-columns-read-only-in-the-datagrid-using-the-designer.md)
- [Практическое руководство. Создайте проект приложения Windows Forms](/visualstudio/ide/step-1-create-a-windows-forms-application-project)
- [Практическое руководство. Добавление элементов управления в формы Windows Forms](how-to-add-controls-to-windows-forms.md)
- [Окно "Источники данных"](https://docs.microsoft.com/previous-versions/visualstudio/visual-studio-2013/6ckyxa83(v=vs.120))
- [Практическое руководство. Отображение связанных данных в приложении Windows Forms](https://docs.microsoft.com/previous-versions/visualstudio/visual-studio-2013/57tx3hhe(v=vs.120))
