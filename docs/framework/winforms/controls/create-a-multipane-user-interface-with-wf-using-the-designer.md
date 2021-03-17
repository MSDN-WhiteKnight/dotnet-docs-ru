---
title: Практическое руководство. Создание пользовательского интерфейса с несколькими областями с использованием форм Windows Forms с помощью конструктора
ms.date: 03/30/2017
helpviewer_keywords:
- user interface [Windows Forms], multipane
- SplitContainer control [Windows Forms], using the designer
- multipane user interface
ms.assetid: c3f9294d-a26c-4198-9242-f237f55f7573
ms.openlocfilehash: 9f3350e32c0fbff58678052d26be954d30d512a7
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59301299"
---
# <a name="how-to-create-a-multipane-user-interface-with-windows-forms-using-the-designer"></a>Практическое руководство. Создание пользовательского интерфейса с несколькими областями с использованием форм Windows Forms с помощью конструктора
В следующей процедуре вы создадите несколькими областями пользовательский интерфейс, который аналогичен используемому в Microsoft Outlook с **папку** списке **сообщений** области и **предварительнойверсии** области. Это упорядочение достигается главным образом за счет закрепления элементов управления формы.  
  
 При закреплении элемента управления, вы можете определить, какие границы родительского контейнера элемента управления он прикреплен к. Таким образом Если задать <xref:System.Windows.Forms.SplitContainer.Dock%2A> свойства <xref:System.Windows.Forms.DockStyle.Right>, правый край элемента управления закрепляется по правому краю родительского элемента. Кроме того закрепленной края элемента управления изменяется в совпадали с элементом управления контейнера. Дополнительные сведения о том, как <xref:System.Windows.Forms.SplitContainer.Dock%2A> свойство работает, см. [как: Закрепление элементов управления в формах Windows Forms](how-to-dock-controls-on-windows-forms.md).  
  
 Эта процедура предназначена для расположения <xref:System.Windows.Forms.SplitContainer> и другие элементы управления в форме, а не на добавление функциональных возможностей для имитации Microsoft Outlook.  
  
 Чтобы создать этот пользовательский интерфейс, поместите все элементы управления внутри <xref:System.Windows.Forms.SplitContainer> управления, который содержит <xref:System.Windows.Forms.TreeView> элемента управления в левой панели. На правой панели <xref:System.Windows.Forms.SplitContainer> элемент управления содержит второй <xref:System.Windows.Forms.SplitContainer> было управлять с помощью <xref:System.Windows.Forms.ListView> управления выше <xref:System.Windows.Forms.RichTextBox> элемента управления. Эти <xref:System.Windows.Forms.SplitContainer> элементы управления позволяют размер других элементов управления в форме. Вы можете адаптировать способов, описанных в эту процедуру для создания пользовательских интерфейсов, собственным.  
  
> [!NOTE]
>  Отображаемые диалоговые окна и команды меню могут отличаться от описанных в справке в зависимости от текущих параметров или выпуска. Чтобы изменить параметры, выберите в меню **Сервис** пункт **Импорт и экспорт параметров** . Дополнительные сведения см. в разделе [Персонализация интегрированной среды разработки Visual Studio](/visualstudio/ide/personalizing-the-visual-studio-ide).  
  
### <a name="to-create-an-outlook-style-user-interface-at-design-time"></a>Чтобы создать пользовательский интерфейс в стиле Outlook во время разработки  
  
1. Создайте новый проект приложения Windows (**файл** > **New** > **проекта** > **Visual C#** или **Visual Basic** > **классический рабочий стол** > **Windows Forms Application**).  
  
2. Перетащите <xref:System.Windows.Forms.SplitContainer> управления из **элементов** в форму. В окне **Свойства** присвойте свойству <xref:System.Windows.Forms.SplitContainer.Dock%2A> значение <xref:System.Windows.Forms.DockStyle.Fill>.  
  
3. Перетащите <xref:System.Windows.Forms.TreeView> управления из **элементов** к левой панели <xref:System.Windows.Forms.SplitContainer> элемента управления. В **свойства** окне <xref:System.Windows.Forms.SplitContainer.Dock%2A> свойства <xref:System.Windows.Forms.DockStyle.Left> , нажав кнопку на панели слева в редакторе значений, открывается при нажатии кнопки со стрелкой вниз.  
  
4. Перетащите еще один <xref:System.Windows.Forms.SplitContainer> управления из **элементов**; поместите его в правой панели <xref:System.Windows.Forms.SplitContainer> добавленного в форму элемента управления. В **свойства** окне <xref:System.Windows.Forms.SplitContainer.Dock%2A> свойства <xref:System.Windows.Forms.DockStyle.Fill> и <xref:System.Windows.Forms.SplitContainer.Orientation%2A> свойства <xref:System.Windows.Forms.Orientation.Horizontal>.  
  
5. Перетащите <xref:System.Windows.Forms.ListView> управления из **элементов** на верхней панели второго <xref:System.Windows.Forms.SplitContainer> добавленного в форму элемента управления. Задайте для свойства <xref:System.Windows.Forms.SplitContainer.Dock%2A> элемента управления <xref:System.Windows.Forms.ListView> значение <xref:System.Windows.Forms.DockStyle.Fill>.  
  
6. Перетащите <xref:System.Windows.Forms.RichTextBox> управления из **элементов** нижней панели второго <xref:System.Windows.Forms.SplitContainer> элемента управления. Задайте для свойства <xref:System.Windows.Forms.SplitContainer.Dock%2A> элемента управления <xref:System.Windows.Forms.RichTextBox> значение <xref:System.Windows.Forms.DockStyle.Fill>.  
  
     На этом этапе Если нажать клавишу F5, чтобы запустить приложение, форма отображает трех частей пользовательского интерфейса, аналогичную Microsoft Outlook.  
  
    > [!NOTE]
    >  При переводе указатель мыши над любым из разделителей в пределах <xref:System.Windows.Forms.SplitContainer> элементов управления, вы можете изменить размер внутреннего измерений.  
  
     На этом этапе при разработке приложений, создания сложного пользовательского интерфейса. Следующим шагом является переходить к программированию самого приложения, возможно, подключив <xref:System.Windows.Forms.TreeView> управления и <xref:System.Windows.Forms.ListView> элементы управления, в каком-либо источника данных. Дополнительные сведения о подключении к данным элементы управления, см. в разделе [привязка данных и Windows Forms](../data-binding-and-windows-forms.md).  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.SplitContainer>
- [Элемент управления SplitContainer](splitcontainer-control-windows-forms.md)
