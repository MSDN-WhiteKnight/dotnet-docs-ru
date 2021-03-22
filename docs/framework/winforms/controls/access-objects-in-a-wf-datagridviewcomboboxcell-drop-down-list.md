---
title: Практическое руководство. Доступ к объектам в раскрывающемся списке элемента управления DataGridViewComboBoxCell в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- DataGridView control [Windows Forms], accessing objects in combo box cells
- combo boxes [Windows Forms], in DataGridView control
- combo boxes [Windows Forms], accessing objects in DataGridViewComboBoxCell drop-down lists
ms.assetid: bcbe794a-d1fa-47f8-b5a3-5f085b32097d
ms.openlocfilehash: 17b7c93effe9338a9e2d6cb207a948a956d9b666
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59334280"
---
# <a name="how-to-access-objects-in-a-windows-forms-datagridviewcomboboxcell-drop-down-list"></a>Практическое руководство. Доступ к объектам в раскрывающемся списке элемента управления DataGridViewComboBoxCell в Windows Forms
Как и <xref:System.Windows.Forms.ComboBox> управления <xref:System.Windows.Forms.DataGridViewComboBoxColumn> и <xref:System.Windows.Forms.DataGridViewComboBoxCell> типов позволяют добавлять произвольные объекты в свой список раскрывающегося списка. С помощью этой функции может представлять сложных состояний в раскрывающемся списке без необходимости хранения соответствующих объектов в отдельной коллекции.  
  
 В отличие от <xref:System.Windows.Forms.ComboBox> управления <xref:System.Windows.Forms.DataGridView> типы не имеют <xref:System.Windows.Forms.ComboBox.SelectedItem%2A> свойство для извлечения текущего выбранного объекта. Вместо этого необходимо задать <xref:System.Windows.Forms.DataGridViewComboBoxColumn.ValueMember%2A?displayProperty=nameWithType> или <xref:System.Windows.Forms.DataGridViewComboBoxCell.ValueMember%2A?displayProperty=nameWithType> присваивается имя свойства бизнес-объекта. Когда пользователь делает выбор, указанное свойство бизнес-объект задает ячейку <xref:System.Windows.Forms.DataGridViewCell.Value%2A> свойство.  
  
 Для получения бизнес-объекта до значения ячейки, `ValueMember` свойство необходимо указать свойство, возвращающее ссылку на сам бизнес-объект. Таким образом Если тип бизнес-объекта не под вашим управлением, необходимо добавить такое свойство, расширив тип путем наследования.  
  
 Следующие процедуры демонстрируют, как для заполнения раскрывающегося списка с бизнес-объектов и извлечение объектов с помощью ячейки <xref:System.Windows.Forms.DataGridViewCell.Value%2A> свойство.  
  
### <a name="to-add-business-objects-to-the-drop-down-list"></a>Чтобы добавить бизнес-объектов в раскрывающемся списке  
  
1. Создайте новый <xref:System.Windows.Forms.DataGridViewComboBoxColumn> и заполнить его <xref:System.Windows.Forms.DataGridViewComboBoxColumn.Items%2A> коллекции. Кроме того, можно задать столбец <xref:System.Windows.Forms.DataGridViewComboBoxColumn.DataSource%2A> свойство в коллекцию бизнес-объектов. В этом случае Однако нельзя добавляемый «неназначенные» стрелку раскрывающегося списка без создания соответствующего бизнес-объект в коллекции.  
  
     [!code-csharp[System.Windows.Forms.DataGridViewComboBoxObjectBinding#110](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataGridViewComboBoxObjectBinding/CS/form1.cs#110)]
       
  
2. Задайте свойства <xref:System.Windows.Forms.DataGridViewComboBoxColumn.DisplayMember%2A> и <xref:System.Windows.Forms.DataGridViewComboBoxColumn.ValueMember%2A>. <xref:System.Windows.Forms.DataGridViewComboBoxColumn.DisplayMember%2A> Указывает свойство бизнес-объекта для отображения в раскрывающемся списке. <xref:System.Windows.Forms.DataGridViewComboBoxColumn.ValueMember%2A> Указывает свойство, которое возвращает ссылку на бизнес-объект.  
  
     [!code-csharp[System.Windows.Forms.DataGridViewComboBoxObjectBinding#115](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataGridViewComboBoxObjectBinding/CS/form1.cs#115)]
       
  
3. Убедитесь, что ваши бизнес-тип объекта содержит свойство, возвращающее ссылку на текущий экземпляр. Это свойство должно присваиваться с помощью значение, присваиваемое <xref:System.Windows.Forms.DataGridViewComboBoxColumn.ValueMember%2A> на предыдущем шаге.  
  
     [!code-csharp[System.Windows.Forms.DataGridViewComboBoxObjectBinding#310](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataGridViewComboBoxObjectBinding/CS/form1.cs#310)]
       
  
### <a name="to-retrieve-the-currently-selected-business-object"></a>Для извлечения выбранной бизнес-объекта  
  
-   Получить ячейку <xref:System.Windows.Forms.DataGridViewCell.Value%2A> свойство и приведите его к типу объекта бизнеса.  
  
     [!code-csharp[System.Windows.Forms.DataGridViewComboBoxObjectBinding#120](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataGridViewComboBoxObjectBinding/CS/form1.cs#120)]
       
  
## <a name="example"></a>Пример  
 Полный пример демонстрирует использование бизнес-объектов в раскрывающемся списке. В примере <xref:System.Windows.Forms.DataGridView> управления привязан к коллекции `Task` объектов. Каждый `Task` объект имеет `AssignedTo` свойство, указывающее `Employee` объект, назначенных этой задачи. `Assigned To` Столбце отображаются `Name` назначить значение свойства для каждого сотрудника или «неназначенные», если `Task.AssignedTo` свойство имеет значение `null`.  
  
 Чтобы просмотреть поведение в этом примере, выполните следующие действия:  
  
1. Изменение назначений в `Assigned To` столбец, выбрав разные значения из раскрывающихся списков или нажав сочетание клавиш CTRL + 0 в ячейке с раскрывающимся списком.  
  
2. Щелкните `Generate Report` для отображения текущих назначений. Это показывает, что изменение в `Assigned To` столбца автоматически обновляет `tasks` коллекции.  
  
3. Нажмите кнопку `Request Status` кнопку, чтобы вызвать `RequestStatus` метод текущего класса `Employee` объекта для этой строки. Это показывает, что выбранный объект был успешно получен.  
  
 [!code-csharp[System.Windows.Forms.DataGridViewComboBoxObjectBinding#000](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataGridViewComboBoxObjectBinding/CS/form1.cs#000)]
   
  
## <a name="compiling-the-code"></a>Компиляция кода  
 Для этого примера требуются:  
  
-   ссылки на сборки System и System.Windows.Forms;  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.DataGridView>
- <xref:System.Windows.Forms.DataGridViewComboBoxColumn>
- <xref:System.Windows.Forms.DataGridViewComboBoxColumn.Items%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.DataGridViewComboBoxColumn.DataSource%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.DataGridViewComboBoxColumn.ValueMember%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.DataGridViewComboBoxCell>
- <xref:System.Windows.Forms.DataGridViewComboBoxCell.Items%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.DataGridViewComboBoxCell.DataSource%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.DataGridViewComboBoxCell.ValueMember%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.DataGridViewCell.Value%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.ComboBox>
- [Отображение данных с помощью элемента управления DataGridView в Windows Forms](displaying-data-in-the-windows-forms-datagridview-control.md)
