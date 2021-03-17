---
title: Пошаговое руководство. Выполнение операции перетаскивания в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- Windows Forms, drag and drop operations
- drag and drop [Windows Forms], Windows Forms
ms.assetid: eb66f6bf-4a7d-4c2d-b276-40fefb2d3b6c
ms.openlocfilehash: f7551f28d07c9517865f60af99954eb40e57daa2
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59340728"
---
# <a name="walkthrough-performing-a-drag-and-drop-operation-in-windows-forms"></a>Пошаговое руководство. Выполнение операции перетаскивания в Windows Forms
Для выполнения операций перетаскивания и вставки в приложениях Windows необходимо обрабатывать последовательность событий, особенно <xref:System.Windows.Forms.Control.DragEnter>, <xref:System.Windows.Forms.Control.DragLeave>, и <xref:System.Windows.Forms.Control.DragDrop> события. Работая со сведениями, доступными через аргументы этих событий, можно значительно упростить операции перетаскивания.  
  
## <a name="dragging-data"></a>Перетаскивание данных  
 Все операции перетаскивания начинаются с переноса данных. Функции для включения данных, собираемых при начале перетаскивания реализуются в <xref:System.Windows.Forms.Control.DoDragDrop%2A> метод.  
  
 В следующем примере <xref:System.Windows.Forms.Control.MouseDown> событие используется для начала операции перетаскивания, так как он является самым удобным (большинство операций перетаскивания и вставки начинаются с кнопкой мыши). Однако не забывайте, что любое событие может использоваться для инициализации процедуры перетаскивания.  
  
> [!NOTE]
>  Некоторые элементы управления имеют собственные события перетаскивания. <xref:System.Windows.Forms.ListView> И <xref:System.Windows.Forms.TreeView> элементов управления, например, быть <xref:System.Windows.Forms.TreeView.ItemDrag> событий.  
  
#### <a name="to-start-a-drag-operation"></a>Начало операции перетаскивания  
  
1. В <xref:System.Windows.Forms.Control.MouseDown> событий для элемента управления, в котором начнется перетаскивание, используйте `DoDragDrop` будут иметь метод, чтобы задать данные для переноса и разрешенный результат перетаскивания. Дополнительные сведения см. в разделах <xref:System.Windows.Forms.DragEventArgs.Data%2A> и <xref:System.Windows.Forms.DragEventArgs.AllowedEffect%2A>.  
  
     В следующем примере показан запуск операции перетаскивания. Элемент управления, где начинается перетаскивание <xref:System.Windows.Forms.Button> элемента управления, перетаскиваемых данных является строка, представляющая <xref:System.Windows.Forms.Control.Text%2A> свойство <xref:System.Windows.Forms.Button> управления и разрешенные эффекты копирование или перемещение.  
  
    ```vb  
    Private Sub Button1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseDown  
       Button1.DoDragDrop(Button1.Text, DragDropEffects.Copy Or DragDropEffects.Move)  
    End Sub  
    ```  
  
    ```csharp  
    private void button1_MouseDown(object sender,   
    System.Windows.Forms.MouseEventArgs e)  
    {  
       button1.DoDragDrop(button1.Text, DragDropEffects.Copy |   
          DragDropEffects.Move);  
    }  
    ```  
  
    > [!NOTE]
    >  Любые данные, которые могут использоваться в качестве параметра `DoDragDrop` метод; в примере выше, <xref:System.Windows.Forms.Control.Text%2A> свойство <xref:System.Windows.Forms.Button> управления был использован (а не жестко запрограммированного значения или получение данных из набора данных), так как свойство было связано с расположение которого выполнялось перетаскивание ( <xref:System.Windows.Forms.Button> управления). Учитывайте это при реализации операций перетаскивания в приложениях Windows.  
  
 Во время операции перетаскивания по сути, можно обрабатывать <xref:System.Windows.Forms.Control.QueryContinueDrag> событие, которое «запрашивает разрешение» системы на продолжение операции перетаскивания. При обработке этого метода, он также является подходящей точкой для вызова методов, которые будет влиять на операцию перетаскивания, например расширение <xref:System.Windows.Forms.TreeNode> в <xref:System.Windows.Forms.TreeView> управления, когда курсор находится над ней.  
  
## <a name="dropping-data"></a>Завершение перетаскивания данных  
 После начала перетаскивания данных из расположения в форме Windows Forms или элементе управления их требуется куда-то поместить. При попадании курсора в область формы или элемента управления, которые правильно настроены для размещения данных, вид курсора изменится. Любую область формы Windows или элемента управления можно сделать для принятия перетаскиваемых данных, задав <xref:System.Windows.Forms.Control.AllowDrop%2A> свойство и обработка <xref:System.Windows.Forms.Control.DragEnter> и <xref:System.Windows.Forms.Control.DragDrop> события.  
  
#### <a name="to-perform-a-drop"></a>Завершение операции перетаскивания  
  
1. Задайте <xref:System.Windows.Forms.Control.AllowDrop%2A> присваивается значение true.  
  
2. В `DragEnter` событие элемента управления, в котором будет выполнено освобождение убедитесь, что перетаскиваемые данные к допустимому типу (в данном случае <xref:System.Windows.Forms.Control.Text%2A>). Затем код задает эффект, который будет происходить при завершении перетаскивания в значение <xref:System.Windows.Forms.DragDropEffects> перечисления. Дополнительные сведения см. в разделе <xref:System.Windows.Forms.DragEventArgs.Effect%2A>.  
  
    ```vb  
    Private Sub TextBox1_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles TextBox1.DragEnter  
       If (e.Data.GetDataPresent(DataFormats.Text)) Then  
         e.Effect = DragDropEffects.Copy  
       Else  
         e.Effect = DragDropEffects.None  
       End If  
    End Sub  
    ```  
  
    ```csharp  
    private void textBox1_DragEnter(object sender,   
    System.Windows.Forms.DragEventArgs e)  
    {  
       if (e.Data.GetDataPresent(DataFormats.Text))   
          e.Effect = DragDropEffects.Copy;  
       else  
          e.Effect = DragDropEffects.None;  
    }  
    ```  
  
    > [!NOTE]
    >  Можно определить собственные <xref:System.Windows.Forms.DataFormats> , указав собственный объект как <xref:System.Object> параметр <xref:System.Windows.Forms.DataObject.SetData%2A> метод. При этом необходимо убедиться, что указанный объект является сериализуемым. Дополнительные сведения см. в разделе <xref:System.Runtime.Serialization.ISerializable>.  
  
3. В <xref:System.Windows.Forms.Control.DragDrop> событий для элемента управления, в которых будет выполняться перетаскивания, используйте <xref:System.Windows.Forms.DataObject.GetData%2A> метод для получения перетаскиваемых данных. Дополнительные сведения см. в разделе <xref:System.Security.Cryptography.Xml.DataObject.Data%2A>.  
  
     В следующем примере <xref:System.Windows.Forms.TextBox> управления является элементом управления, на который переносятся данные (в котором будет выполнено освобождение данных). В коде устанавливается <xref:System.Windows.Forms.Control.Text%2A> свойство <xref:System.Windows.Forms.TextBox> управления равным перетаскиваемым данным.  
  
    ```vb  
    Private Sub TextBox1_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles TextBox1.DragDrop  
       TextBox1.Text = e.Data.GetData(DataFormats.Text).ToString  
    End Sub  
    ```  
  
    ```csharp  
    private void textBox1_DragDrop(object sender,   
    System.Windows.Forms.DragEventArgs e)  
    {  
       textBox1.Text = e.Data.GetData(DataFormats.Text).ToString();  
    }  
    ```  
  
    > [!NOTE]
    >  Кроме того, вы можете работать с <xref:System.Windows.Forms.DragEventArgs.KeyState%2A> свойство, поэтому, в зависимости от клавиш, нажатых во время операции перетаскивания и вставки, происходили определенные действия (например, происходит копирование переносимых данных при нажатии клавиши CTRL).  
  
## <a name="see-also"></a>См. также

- [Практическое руководство. Добавление данных в буфер обмена](how-to-add-data-to-the-clipboard.md)
- [Практическое руководство. Извлечение данных из буфера обмена](how-to-retrieve-data-from-the-clipboard.md)
- [Операции перетаскивания и поддержка буфера обмена](drag-and-drop-operations-and-clipboard-support.md)
