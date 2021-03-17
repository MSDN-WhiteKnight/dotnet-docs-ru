---
title: Практическое руководство. Создание дочерних форм MDI
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- MDI [Windows Forms], creating forms
- child forms
ms.assetid: 164b69bb-2eca-4339-ada3-0679eb2c6dda
ms.openlocfilehash: 73f2004470d5d1da04199af75832cefd6348ce18
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59342483"
---
# <a name="how-to-create-mdi-child-forms"></a>Практическое руководство. Создание дочерних форм MDI
Дочерние формы MDI являются важным элементом [приложений многодокументного интерфейса (MDI)](multiple-document-interface-mdi-applications.md), как эти находятся в центре взаимодействия с пользователем.  
  
 С помощью описанной ниже процедуры создаются дочерние формы MDI, отображающие элемент управления <xref:System.Windows.Forms.RichTextBox> аналогично большинству текстовых приложений. Замена элемента управления <xref:System.Windows.Forms> на другие элементы управления, такие как <xref:System.Windows.Forms.DataGridView>, или на сочетание элементов управления позволяет создавать дочерние окна MDI (а также приложения MDI) с различными возможностями.  
  
> [!NOTE]
>  Отображаемые диалоговые окна и команды меню могут отличаться от описанных в справке в зависимости от текущих параметров или выпуска. Чтобы изменить параметры, выберите в меню **Сервис** пункт **Импорт и экспорт параметров** . Дополнительные сведения см. в разделе [Персонализация интегрированной среды разработки Visual Studio](/visualstudio/ide/personalizing-the-visual-studio-ide).  
  
### <a name="to-create-mdi-child-forms"></a>Создание дочерних форм MDI  
  
1. Создайте проект Windows Forms. В **Windows свойства** формы, задать его <xref:System.Windows.Forms.Form.IsMdiContainer%2A> свойства `true`и его `WindowsState` свойства `Maximized`.  
  
     При этом форма назначается в качестве MDI-контейнера для дочерних окон.  
  
2. Из `Toolbox` перетащите элемент управления <xref:System.Windows.Forms.MenuStrip> в форму. Задайте его `Text` свойства **файл**.  
  
3. Нажмите кнопку с многоточием (...) рядом с полем **элементы** свойство и нажмите кнопку **добавить** добавить два пункта меню дочерние средство ленты. Задайте `Text` свойства этих элементов значения **New** и **окно**.  
  
4. В **обозревателе решений**, щелкните правой кнопкой мыши проект, выберите пункт **добавить**, а затем выберите **Добавление нового элемента**.  
  
5. В **Добавление нового элемента** выберите **формы Windows** (в Visual Basic или Visual C#) или **приложение Windows Forms (.NET)** (в [!INCLUDE[vcprvc](../../../../includes/vcprvc-md.md)]) из  **Шаблоны** области. В **имя** окне имя формы **Form2**. Нажмите кнопку **откройте** кнопку, чтобы добавить форму в проект.  
  
    > [!NOTE]
    >  Дочерняя форма MDI, созданная на этом этапе, является стандартной формой Windows Forms. Таким образом, у нее есть свойство <xref:System.Windows.Forms.Form.Opacity%2A>, которое позволяет управлять прозрачностью формы. Однако свойство <xref:System.Windows.Forms.Form.Opacity%2A> предназначено для окон верхнего уровня. Его не следует использовать в дочерних формах MDI, иначе могут возникнуть проблемы с рисованием.  
  
     Эта форма будет шаблоном для дочерних форм MDI.  
  
     **Конструктор Windows Forms** откроется, отображение **Form2**.  
  
6. Из **элементов**, перетащите **RichTextBox** на форму элемент управления.  
  
7. В **свойства** окне `Anchor` свойства **верхней, левой** и `Dock` свойства **заполнения**.  
  
     В результате элемент управления <xref:System.Windows.Forms.RichTextBox> будет целиком заполнять область дочерней формы MDI, даже если ее размеры изменятся.  
  
8. Дважды щелкните **New** пункт меню, чтобы создать <xref:System.Windows.Forms.Control.Click> для него обработчик событий.  
  
9. Вставьте код, аналогичный приведенному ниже, чтобы создать новую дочернюю форму MDI, когда пользователь щелкает **New** пункта меню.  
  
    > [!NOTE]
    >  В примере ниже обработчик событий обрабатывает событие <xref:System.Windows.Forms.Control.Click> для `MenuItem2`. Имейте в виду, что в зависимости от особенностей архитектуры приложения, ваш **New** пункт меню может быть `MenuItem2`.  
  
    ```vb  
    Protected Sub MDIChildNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click  
       Dim NewMDIChild As New Form2()  
       'Set the Parent Form of the Child window.  
       NewMDIChild.MdiParent = Me  
       'Display the new form.  
       NewMDIChild.Show()  
    End Sub  
    ```  
  
    ```csharp  
    protected void MDIChildNew_Click(object sender, System.EventArgs e){  
       Form2 newMDIChild = new Form2();  
       // Set the Parent Form of the Child window.  
       newMDIChild.MdiParent = this;  
       // Display the new form.  
       newMDIChild.Show();  
    }  
    ```  
  
    ```cpp  
    private:  
       void menuItem2_Click(System::Object ^ sender,  
          System::EventArgs ^ e)  
       {  
          Form2^ newMDIChild = gcnew Form2();  
          // Set the Parent Form of the Child window.  
          newMDIChild->MdiParent = this;  
          // Display the new form.  
          newMDIChild->Show();  
       }  
    ```  
  
     При использовании [!INCLUDE[vcprvc](../../../../includes/vcprvc-md.md)] добавьте следующую директиву `#include` в начало формы Form1.h:  
  
    ```cpp  
    #include "Form2.h"  
    ```  
  
10. В раскрывающемся списке в верхней части **свойства** окно, выберите пункт меню, соответствующий **файл** меню и набор <xref:System.Windows.Forms.MenuStrip.MdiWindowListItem%2A> свойство в окно <xref:System.Windows.Forms.ToolStripMenuItem>.  
  
     Это позволит **окно** меню, чтобы поддерживать список открытых дочерних окон MDI с флажком рядом с активным окном.  
  
11. Нажмите клавишу F5 для запуска приложения. Выбрав **New** из **файл** меню, можно создать дочерние формы MDI, которыми будут храниться в **окно** пункта меню.  
  
    > [!NOTE]
    >  Когда в дочерней форме MDI есть компонент <xref:System.Windows.Forms.MainMenu> (обычно обладающий структурой пунктов меню) и он открыт внутри родительской формы MDI, также имеющей компонент <xref:System.Windows.Forms.MainMenu> (обычно обладающий структурой пунктов меню), пункты меню будут объединены автоматически, если задано свойство <xref:System.Windows.Forms.MenuItem.MergeType%2A> (и, возможно, свойство <xref:System.Windows.Forms.MenuItem.MergeOrder%2A>). Установите для свойства <xref:System.Windows.Forms.MenuItem.MergeType%2A> обоих компонентов <xref:System.Windows.Forms.MainMenu> и всех пунктов меню дочерней формы значение <xref:System.Windows.Forms.MenuMerge.MergeItems>. Кроме того, установите свойство <xref:System.Windows.Forms.MenuItem.MergeOrder%2A> таким образом, чтобы пункты обоих меню приводились в нужном порядке. Необходимо помнить, что при закрытии родительской формы MDI каждая из дочерних форм MDI создает событие <xref:System.Windows.Forms.Form.Closing> до создания события <xref:System.Windows.Forms.Form.Closing> для родительской формы MDI. Отмена события <xref:System.Windows.Forms.Form.Closing> дочерней формы MDI не отменяет событие <xref:System.Windows.Forms.Form.Closing> родительской формы MDI. Однако для аргумента <xref:System.ComponentModel.CancelEventArgs> для события <xref:System.Windows.Forms.Form.Closing> родительской формы MDI будет установлено значение `true`. Чтобы принудительно закрыть родительскую и все дочерние формы MDI, задайте для аргумента <xref:System.ComponentModel.CancelEventArgs> значение `false`.  
  
## <a name="see-also"></a>См. также

- [Приложения с интерфейсом MDI](multiple-document-interface-mdi-applications.md)
- [Практическое руководство. Создание родительских MDI-форм](how-to-create-mdi-parent-forms.md)
- [Практическое руководство. Определение активной дочерней MDI-формы](how-to-determine-the-active-mdi-child.md)
- [Практическое руководство. Отправка данных в активную дочернюю MDI-форму](how-to-send-data-to-the-active-mdi-child.md)
- [Практическое руководство. Упорядочение дочерних MDI-форм](how-to-arrange-mdi-child-forms.md)
