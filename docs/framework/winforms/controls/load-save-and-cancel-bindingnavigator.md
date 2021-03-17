---
title: Практическое руководство. Добавление кнопок загрузки, сохранения и отмены в элемент управления BindingNavigator в формах Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- controls [Windows Forms], manipulating
- BindingNavigator control [Windows Forms], adding buttons
ms.assetid: faa33042-186e-4bb2-8798-17ceb987ec62
ms.openlocfilehash: 4d5cc91ca8bf71b2d5893f591652d777041e1a4d
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59304783"
---
# <a name="how-to-add-load-save-and-cancel-buttons-to-the-windows-forms-bindingnavigator-control"></a>Практическое руководство. Добавление кнопок загрузки, сохранения и отмены в элемент управления BindingNavigator в формах Windows Forms
<xref:System.Windows.Forms.BindingNavigator> Элемент управления является специализированным <xref:System.Windows.Forms.ToolStrip> элемент управления, который предназначен для навигации и управление элементами управления в форме, привязанных к данным.  
  
 Так как это <xref:System.Windows.Forms.ToolStrip> управления <xref:System.Windows.Forms.BindingNavigator> компонента можно легко изменить для включения дополнительных или альтернативных команд для пользователя.  
  
 В следующей процедуре <xref:System.Windows.Forms.TextBox> управления привязкой к данным и <xref:System.Windows.Forms.ToolStrip> изменен элемент управления, который добавляется в форму, чтобы включают загрузку, сохранить и «Отмена».  
  
### <a name="to-add-load-save-and-cancel-buttons-to-the-bindingnavigator-component"></a>Чтобы добавить нагрузки, сохранить и Отмена кнопок к компоненту BindingNavigator  
  
1. Добавьте элемент управления <xref:System.Windows.Forms.TextBox> в форму.  
  
2. Привяжите его к <xref:System.Windows.Forms.BindingSource>, который привязан к источнику данных. В этом примере <xref:System.Windows.Forms.BindingSource> привязан к базе данных.  
  
3. После создания набора данных и адаптер таблицы, перетащите <xref:System.Windows.Forms.BindingNavigator> на форму элемент управления.  
  
4. Задайте <xref:System.Windows.Forms.BindingNavigator> элемента управления <xref:System.Windows.Forms.BindingNavigator.BindingSource%2A> свойства <xref:System.Windows.Forms.BindingSource> на форме, которая привязывается к элементам управления.  
  
5. Выберите элемент управления <xref:System.Windows.Forms.BindingNavigator>.  
  
6. Щелкните глиф смарт-тега (![глиф смарт-тега](./media/vs-winformsmttagglyph.gif "VS_WinFormSmtTagGlyph")) поэтому **задачи BindingNavigator** диалоговое окно и выберите пункт **изменение элементов**.  
  
     **Редактор коллекции элементов** отображается.  
  
7. В **редактор коллекции элементов**, воспользуйтесь одним из следующих:  
  
    1.  Добавить <xref:System.Windows.Forms.ToolStripSeparator> и три <xref:System.Windows.Forms.ToolStripButton> элементы, выбрав соответствующий тип <xref:System.Windows.Forms.ToolStripItem> и щелкнув **добавить** кнопки.  
  
    2.  Задайте <xref:System.Windows.Forms.ToolStripItem.Name%2A> свойство кнопки для **LoadButton**, **SaveButton**, и **CancelButton**, соответственно.  
  
    3.  Задайте <xref:System.Windows.Forms.ToolStripItem.Text%2A> свойство кнопки для **нагрузки**, **Сохранить**, и **отменить**.  
  
    4.  Задайте <xref:System.Windows.Forms.ToolStripItem.DisplayStyle%2A> для каждой из кнопок, чтобы **текст**. Кроме того, это свойство можно задать **изображение** или **ImageAndText**и задать изображение для отображения в <xref:System.Windows.Forms.ToolStripItem.Image%2A> свойство.  
  
    5.  Нажмите кнопку **ОК** чтобы закрыть диалоговое окно. Добавляются кнопки <xref:System.Windows.Forms.ToolStrip>.  
  
8. Щелкните форму правой кнопкой мыши и выберите **Просмотр кода**.  
  
9. В редакторе кода найдите строку кода, который загружает данные в адаптер таблицы. Этот код был создан при настройке привязки данных на шаге 2. Код должен быть следующего вида: `TableAdapterName.Fill(DataSetName.TableName)`. Он, скорее всего может быть в форме <xref:System.Windows.Forms.Form.Load> событий.  
  
10. Создайте обработчик событий для <xref:System.Windows.Forms.ToolStripItem.Click> событие **нагрузки** <xref:System.Windows.Forms.ToolStripButton> созданной ранее и переместить этот код для загрузки данных в него.  
  
     Код теперь должен выглядеть следующим образом:  
  
    ```vb  
    Private Sub LoadButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadButton.Click  
        TableAdapterName.Fill(DataSetName.TableName)  
    End Sub  
    ```  
  
    ```csharp  
    private void LoadButton_Click(System.Object sender,   
        System.EventArgs e)  
    {  
        TableAdapterName.Fill(DataSetName.TableName);  
    }  
    ```  
  
11. Создайте обработчик событий для <xref:System.Windows.Forms.ToolStripItem.Click> событие **Сохранить** <xref:System.Windows.Forms.ToolStripButton> созданную ранее, и напишите код для обновления данных в таблице элемент управления привязывается к.  
  
    ```vb  
    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click  
        TableAdapterName.Update(DataSetName.TableName)  
    End Sub  
    ```  
  
    ```csharp  
    private void SaveButton_Click(System.Object sender,   
        System.EventArgs e)  
    {  
        TableAdapterName.Update(DataSetName.TableName);  
    }  
    ```  
  
    > [!NOTE]
    > В некоторых случаях <xref:System.Windows.Forms.BindingNavigator> компоненты уже имеют **Сохранить** кнопки, но код не будет были созданы с помощью конструктора Windows Forms. В этом случае можно поместить приведенного выше кода в <xref:System.Windows.Forms.ToolStripItem.Click> обработчик событий для этой кнопки, а не создавать полностью новой кнопки на <xref:System.Windows.Forms.ToolStrip>. Тем не менее, кнопка отключена по умолчанию, поэтому вам нужно задать <xref:System.Windows.Forms.ToolBarButton.Enabled%2A> свойство кнопки `true` иметь кнопка работала правильно.
  
12. Создайте обработчик событий для <xref:System.Windows.Forms.ToolStripItem.Click> событие **отменить** <xref:System.Windows.Forms.ToolStripButton> созданной ранее и написать код, чтобы отменить все изменения отображаемой записи данных.  
  
    ```vb  
    Private Sub CancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelButton.Click  
        BindingSourceName.CancelEdit()  
    End Sub  
    ```  
  
    ```csharp  
    private void CancelButton_Click(System.Object sender, System.EventArgs e)  
    {  
        BindingSourceName.CancelEdit();  
    }  
    ```  
  
    > [!NOTE]
    >  <xref:System.Windows.Forms.BindingSource.CancelEdit%2A> Метод ограничивается строки данных. Сохраните все изменения, внесенные во время просмотра этой отдельной записи до перехода к следующей записи.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.BindingNavigator>
- <xref:System.Windows.Forms.BindingSource>
- <xref:System.Windows.Forms.ToolStrip>
- [BindingNavigator — элемент управления](bindingnavigator-control-windows-forms.md)
- [Общие сведения о компоненте BindingSource](bindingsource-component-overview.md)
