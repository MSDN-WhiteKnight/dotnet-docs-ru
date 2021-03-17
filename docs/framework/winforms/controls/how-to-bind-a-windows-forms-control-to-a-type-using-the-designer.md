---
title: Практическое руководство. Привязка элемента управления Windows Forms к типу с помощью конструктора
ms.date: 03/30/2017
helpviewer_keywords:
- controls [Windows Forms], binding to a type
- BindingSource component [Windows Forms], binding to a type
- types [Windows Forms], binding controls to
ms.assetid: 5ab984b5-c2d0-4638-a572-1c84013e8746
ms.openlocfilehash: b298efb0494994659673f9bf9893b667f7eb0f8c
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59304218"
---
# <a name="how-to-bind-a-windows-forms-control-to-a-type-using-the-designer"></a>Практическое руководство. Привязка элемента управления Windows Forms к типу с помощью конструктора
При создании элементов управления, взаимодействующих с данными, иногда бывает нужно привязать элемент управления к типу, а не к объекту. Обычно подобная ситуация возникает на этапе разработки, когда данные недоступны, однако нужно, чтобы элементы управления с привязкой к данным отображали данные из открытого интерфейса типа. Ниже описано, как создать новый <xref:System.Windows.Forms.BindingSource> то есть связанного с типом, а затем привязать одно из свойств типа к <xref:System.Windows.Forms.TextBox.Text%2A> свойство <xref:System.Windows.Forms.TextBox>.  
  
### <a name="to-bind-the-bindingsource-to-a-type"></a>Привязка BindingSource к типу  
  
1. Создайте проект Windows Forms (**файл** > **New** > **проекта** > **Visual C#** или **Visual Basic** > **классический рабочий стол** > **Windows Forms Application**).  
  
2. В **разработки** Просмотр, перетащите <xref:System.Windows.Forms.BindingSource> компонента в форму.  
  
3. В **свойства** окно, нажмите кнопку со стрелкой <xref:System.Windows.Forms.BindingSource.DataSource%2A> свойство.  
  
4. В **редакторе типов пользовательского интерфейса DataSource** нажмите кнопку **Добавить источник данных проекта**.  
  
5. На странице **Выбор типа источника данных** выберите тип **Объект** и нажмите кнопку **Далее**.  
  
6. Выберите тип для привязки.  
  
    -   Если тип для привязки находится в текущем проекте либо сборка, содержащая этот тип, уже добавлена как ссылка, разверните узлы, а затем найдите и выберите желаемый тип.  
  
         -или-  
  
    -   Если тип для привязки находится в другой сборке, которой еще нет в списке ссылок, нажмите **Добавить ссылку** и выберите вкладку **Проекты**. Выберите проект, содержащий нужный вам бизнес-объект, и нажмите кнопку **ОК**. Этот проект будет отображаться в списке сборок, так что вы сможете развернуть узлы, а затем найти и выбрать желаемый тип.  
  
        > [!NOTE]
        >  Если тип, который нужно привязать, находится в инфраструктуре или сборке Майкрософт, снимите флажок **Скрыть сборки, начинающиеся с Microsoft или System**.  
  
7. Щелкните **Далее**и затем нажмите кнопку **Готово**.  
  
### <a name="to-bind-the-control-to-the-bindingsource"></a>Привязка элемента управления к BindingSource  
  
1. Добавьте на форму элемент <xref:System.Windows.Forms.TextBox>.  
  
2. В окне **Свойства** разверните узел **(DataBindings)**.  
  
3. Щелкните стрелку рядом с полем <xref:System.Windows.Forms.TextBox.Text%2A> свойство.  
  
4. В **редактора типов пользовательского интерфейса DataSource**, разверните узел для <xref:System.Windows.Forms.BindingSource> добавленной ранее и выберите свойство типа, необходимо выполнить привязку к <xref:System.Windows.Forms.TextBox.Text%2A> свойство <xref:System.Windows.Forms.TextBox>.  
  
## <a name="see-also"></a>См. также

- [Компонент BindingSource](bindingsource-component.md)
- [Практическое руководство. Связывание элемента управления с типом в Windows Forms](how-to-bind-a-windows-forms-control-to-a-type.md)
- [Привязка элементов управления к данным в Visual Studio](/visualstudio/data-tools/bind-controls-to-data-in-visual-studio)
