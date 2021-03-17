---
title: Пошаговое руководство. Создание интерфейса в стиле проводника с использованием элементов управления ListView и TreeView с помощью конструктора
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- Explorer-style applications [Windows Forms], walkthroughs
- TreeView control [Windows Forms], ListView controls used with
- ListView control [Windows Forms], TreeView controls used with
- Explorer-style applications
- TreeView control [Windows Forms], using for explorer-style interface
- ListView control [Windows Forms], explorer style interface
- ListView control [Windows Forms], explorer-style interface
ms.assetid: 9e5e7721-19e2-4890-b273-a43589fe99ff
ms.openlocfilehash: 8192151aa7cd5eddd99d39adb485e460074fdb99
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59332122"
---
# <a name="walkthrough-creating-an-explorer-style-interface-with-the-listview-and-treeview-controls-using-the-designer"></a>Пошаговое руководство. Создание интерфейса в стиле проводника с использованием элементов управления ListView и TreeView с помощью конструктора
Одним из преимуществ Visual Studio является возможность создания профессиональных приложений Windows Forms в короткие сроки. Распространенным сценарием Создание пользовательского интерфейса (UI) с <xref:System.Windows.Forms.ListView> и <xref:System.Windows.Forms.TreeView> элементы управления похож на функцию Windows Explorer операционных систем Windows. Windows Explorer отображает иерархическую структуру файлов и папок на компьютере пользователя.  
  
> [!NOTE]
>  Отображаемые диалоговые окна и команды меню могут отличаться от описанных в справке в зависимости от текущих параметров или выпуска. Чтобы изменить параметры, выберите в меню **Сервис** пункт **Импорт и экспорт параметров** . Дополнительные сведения см. в разделе [Персонализация интегрированной среды разработки Visual Studio](/visualstudio/ide/personalizing-the-visual-studio-ide).  
  
### <a name="to-create-the-form-containing-a-listview-and-treeview-control"></a>Чтобы создать форму, содержащую элемент управления ListView и TreeView  
  
1. В меню **Файл** выберите пункт **Создать**, а затем команду **Проект**.  
  
2. В **новый проект** диалоговом окне сделайте следующее:  
  
    1.  В категориях, выбрав **Visual Basic** или **Visual C#**.  
  
    2.  В списке шаблонов выберите **приложение Windows Forms**.  
  
3. Нажмите кнопку **ОК**. Создается новый проект Windows Forms.  
  
4. Добавить <xref:System.Windows.Forms.SplitContainer> управления в форму и задайте его <xref:System.Windows.Forms.SplitContainer.Dock%2A> свойства <xref:System.Windows.Forms.DockStyle.Fill>.  
  
5. Добавить <xref:System.Windows.Forms.ImageList> с именем `imageList1` в форму и используйте окно свойств для добавления двух изображений: папки и документа, в указанном порядке.  
  
6. Добавить <xref:System.Windows.Forms.TreeView> управления с именем `treeview1` в форму и расположите его в левой части <xref:System.Windows.Forms.SplitContainer> элемента управления. В окне «Свойства» для `treeView1` выполните следующие действия:  
  
    1.  Задайте для свойства <xref:System.Windows.Forms.Control.Dock%2A> значение <xref:System.Windows.Forms.DockStyle.Fill>.  
  
    2.  Задать <xref:System.Windows.Forms.TreeView.ImageList%2A> свойства `imagelist1.`  
  
7. Добавить <xref:System.Windows.Forms.ListView> управления с именем `listView1` в форму и разместите его справа от <xref:System.Windows.Forms.SplitContainer> элемента управления. В окне «Свойства» для `listview1` выполните следующие действия:  
  
    1.  Задайте для свойства <xref:System.Windows.Forms.Control.Dock%2A> значение <xref:System.Windows.Forms.DockStyle.Fill>.  
  
    2.  Задайте для свойства <xref:System.Windows.Forms.ListView.View%2A> значение <xref:System.Windows.Forms.View.Details>.  
  
    3.  Откройте редактор коллекции заголовков столбцов, нажав кнопку с многоточием (![экрана VisualStudioEllipsesButton](../media/vbellipsesbutton.png "vbEllipsesButton")) в <xref:System.Windows.Forms.ListView.Columns%2A> свойство **.** Добавьте три столбца и задайте их <xref:System.Windows.Forms.ColumnHeader.Text%2A> свойства `Name`, `Type`, и `Last Modified`, соответственно. Нажмите кнопку **ОК**, чтобы закрыть диалоговое окно.  
  
    4.  Задать <xref:System.Windows.Forms.ListView.SmallImageList%2A> свойства `imageList1.`  
  
8. Реализуйте код для заполнения <xref:System.Windows.Forms.TreeView> с узлов и подузлов. Добавьте следующий код в `Form1` класса.  
  
     [!code-csharp[System.Windows.Forms.ExplorerStyleInterface#1](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.ExplorerStyleInterface/CS/Form1.cs#1)]
     [!code-vb[System.Windows.Forms.ExplorerStyleInterface#1](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Windows.Forms.ExplorerStyleInterface/VB/Form1.vb#1)]  
  
9. Так как предыдущий код использует пространство имен System.IO, добавьте соответствующий или импортировать инструкцию в верхней части формы.  
  
     [!code-csharp[System.Windows.Forms.ExplorerStyleInterface#4](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.ExplorerStyleInterface/CS/Form1.cs#4)]
     [!code-vb[System.Windows.Forms.ExplorerStyleInterface#4](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Windows.Forms.ExplorerStyleInterface/VB/Form1.vb#4)]  
  
10. Вызовите метод настройки из предыдущего шага в конструкторе формы или <xref:System.Windows.Forms.Form.Load> метод обработки событий. Добавьте следующий код в конструктор формы.  
  
     [!code-csharp[System.Windows.Forms.ExplorerStyleInterface#2](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.ExplorerStyleInterface/CS/Form1.cs#2)]
     [!code-vb[System.Windows.Forms.ExplorerStyleInterface#2](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Windows.Forms.ExplorerStyleInterface/VB/Form1.vb#2)]  
  
11. Обрабатывать <xref:System.Windows.Forms.TreeView.NodeMouseClick> событие для `treeview1` **,** и реализации кода для заполнения `listview1` содержимое узла, при щелчке узла. Добавьте следующий код в `Form1` класса.  
  
     [!code-csharp[System.Windows.Forms.ExplorerStyleInterface#3](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.ExplorerStyleInterface/CS/Form1.cs#3)]
     [!code-vb[System.Windows.Forms.ExplorerStyleInterface#3](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Windows.Forms.ExplorerStyleInterface/VB/Form1.vb#3)]  
  
     Если вы используете C#, убедитесь, что у вас есть <xref:System.Windows.Forms.TreeView.NodeMouseClick> событие, связанное со своим методом обработки событий. Добавьте следующий код в конструктор формы.  
  
     [!code-csharp[System.Windows.Forms.ExplorerStyleInterface#5](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.ExplorerStyleInterface/CS/Form1.cs#5)]  
  
## <a name="testing-the-application"></a>Тестирование приложения  
 Теперь можно проверить форму, чтобы убедиться, что она правильно работает.  
  
#### <a name="to-test-the-form"></a>Чтобы проверить форму  
  
-   Нажмите клавишу F5 для запуска приложения.  
  
     Вы увидите разбиения форму, содержащую <xref:System.Windows.Forms.TreeView> элемент управления, отображающий каталог проекта на левой стороне, и <xref:System.Windows.Forms.ListView> управления справа от оператора с тремя столбцами. Вы сможете просматривать <xref:System.Windows.Forms.TreeView> , выбрав узлы каталога и <xref:System.Windows.Forms.ListView> заполняется содержимое выбранного каталога.  
  
## <a name="next-steps"></a>Следующие шаги  
 Это приложение служит примером способом, можно использовать <xref:System.Windows.Forms.TreeView> и <xref:System.Windows.Forms.ListView> вместе элементы управления. Дополнительные сведения об этих элементах управления см. в разделах:  
  
-   [Практическое руководство. Добавление пользовательских данных в элемент управления TreeView или ListView (Windows Forms)](add-custom-information-to-a-treeview-or-listview-control-wf.md)  
  
-   [Практическое руководство. Добавление в элемент управления ListView возможностей поиска](how-to-add-search-capabilities-to-a-listview-control.md)  
  
-   [Практическое руководство. Подключение контекстного меню к узлу элемента управления TreeView](how-to-attach-a-shortcut-menu-to-a-treeview-node.md)  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.ListView>
- <xref:System.Windows.Forms.TreeView>
- [Элемент управления ListView](listview-control-windows-forms.md)
- [Практическое руководство. Добавление и удаление узлов элемента управления TreeView в Windows Forms](how-to-add-and-remove-nodes-with-the-windows-forms-treeview-control.md)
- [Практическое руководство. Добавление и удаление элементов с помощью элемента управления ListView в Windows Forms](how-to-add-and-remove-items-with-the-windows-forms-listview-control.md)
- [Практическое руководство. Добавление столбцов в элемент управления ListView в Windows Forms](how-to-add-columns-to-the-windows-forms-listview-control.md)
