---
title: Пошаговое руководство. Упорядочение элементов управления в формах Windows Forms с помощью элемента FlowLayoutPanel
ms.date: 03/30/2017
helpviewer_keywords:
- FlowLayoutPanel control [Windows Forms], walkthroughs
- Windows Forms controls, arranging
- controls [Windows Forms], arranging with FlowLayoutPanel
- layout [Windows Forms], walkthroughs
ms.assetid: a1744323-0316-49c2-992e-ebfc0a976b85
ms.openlocfilehash: 81a19d063f31b3c28fc15a061b5173495e83f6fc
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59321891"
---
# <a name="walkthrough-arranging-controls-on-windows-forms-using-a-flowlayoutpanel"></a>Пошаговое руководство. Упорядочение элементов управления в формах Windows Forms с помощью элемента FlowLayoutPanel
В некоторых приложениях требуется форма, макет которой изменяется надлежащим образом при изменении размера формы или содержимого. Если необходим динамический макет и вы не хотите обрабатывать события <xref:System.Windows.Forms.Control.Layout> явно в коде, рассмотрите возможность использования панели макета.  
  
 Элементы управления <xref:System.Windows.Forms.FlowLayoutPanel> и <xref:System.Windows.Forms.TableLayoutPanel> предоставляют удобные способы упорядочения элементов управления в форме. Они обеспечивают автоматическую настраиваемую возможность управления относительным положением содержащихся в них дочерних элементов управления и предоставляют функции динамического макета во время выполнения и таким образом могут изменять размер и положение дочерних элементов управления по мере измерения размеров родительской формы. Панели макета могут быть вложенными в других панелях макета, что позволяет реализовывать сложные пользовательские интерфейсы.  
  
 <xref:System.Windows.Forms.TableLayoutPanel> Упорядочивает свое содержимое в сетке, обеспечивая функциональные возможности, аналогичные HTML \<таблицы > элемента. Его ячейки организованы в строки и столбцы, и они могут быть разного размера. Дополнительные сведения см. в разделе [Пошаговое руководство: Упорядочение элементов управления в Windows Forms, с помощью элемента управления TableLayoutPanel](walkthrough-arranging-controls-on-windows-forms-using-a-tablelayoutpanel.md).  
  
 Элемент управления <xref:System.Windows.Forms.FlowLayoutPanel> упорядочивает свое содержимое в определенном направлении, горизонтальном или вертикальном. Его содержимое может быть перенесено из одной строки в следующую или из одного столбца в следующий. Кроме того, вместо переноса содержимое может обрезаться. В данном пошаговом руководстве представлены следующие задачи.  
  
-   Создание проекта Windows Forms  
  
-   Упорядочивание элементов управления по горизонтали и по вертикали  
  
-   Изменение направления потока  
  
-   Вставка разрывов потока  
  
-   Упорядочивание элементов управления с использованием отбивки и полей  
  
-   Вставка элементов управления двойным щелчком по ним в панели элементов  
  
-   Вставка элемента управления путем рисования его контура  
  
-   Вставка элементов управления с помощью курсора  
  
-   Переназначение существующих элементов управления другим родительским элементам  
  
 После завершения вы будете понимать роль, которую играют эти важные функции макета.  
  
> [!NOTE]
>  Отображаемые диалоговые окна и команды меню могут отличаться от описанных в справке в зависимости от текущих параметров или выпуска. Чтобы изменить параметры, выберите в меню **Сервис** пункт **Импорт и экспорт параметров** . Дополнительные сведения см. в разделе [Персонализация интегрированной среды разработки Visual Studio](/visualstudio/ide/personalizing-the-visual-studio-ide).  
  
## <a name="creating-the-project"></a>Создание проекта  
 Первым шагом является создание проекта и настройка формы.  
  
#### <a name="to-create-the-project"></a>Создание проекта  
  
1. Создайте проект приложения на основе Windows с именем «FlowLayoutPanelExample» (**файл** > **New** > **проекта**  >  **Visual C#** или **Visual Basic** > **классический рабочий стол** > **Windows Forms Application**).  
  
2. Выберите форму в **конструкторе форм**.  
  
## <a name="arranging-controls-horizontally-and-vertically"></a>Упорядочивание элементов управления по горизонтали и по вертикали  
 Элемент управления <xref:System.Windows.Forms.FlowLayoutPanel> позволяет размещать элементы управления в строках или столбцах без необходимости точного указания положения каждого отдельного элемента управления.  
  
 Элемент управления <xref:System.Windows.Forms.FlowLayoutPanel> может изменять размер или положение своих дочерних элементов управления по мере измерения размеров родительской формы.  
  
#### <a name="to-arrange-controls-horizontally-and-vertically-using-a-flowlayoutpanel"></a>Размещение элементов управления по горизонтали или по вертикали с помощью FlowLayoutPanel  
  
1. Перетащите элемент управления <xref:System.Windows.Forms.FlowLayoutPanel> из **панели элементов** в свою форму.  
  
2. Перетащите элемент управления <xref:System.Windows.Forms.Button> из **панели элементов** в <xref:System.Windows.Forms.FlowLayoutPanel>. Обратите внимание, что он автоматически перемещается в левый верхний угол элемента управления <xref:System.Windows.Forms.FlowLayoutPanel> .  
  
3. Перетащите другой элемент управления <xref:System.Windows.Forms.Button> из **панели элементов** в <xref:System.Windows.Forms.FlowLayoutPanel>. Обратите внимание, что элемент управления <xref:System.Windows.Forms.Button> автоматически перемещается в место рядом с первым элементом управления <xref:System.Windows.Forms.Button> . Если ваша панель <xref:System.Windows.Forms.FlowLayoutPanel> слишком узка для размещения двух элементов управления в одной строке, то новый элемент управления <xref:System.Windows.Forms.Button> автоматически переносится на следующую строку.  
  
4. Перетащите еще несколько элементов управления <xref:System.Windows.Forms.Button> из **панели элементов** в <xref:System.Windows.Forms.FlowLayoutPanel>. Продолжайте размещать элементы управления <xref:System.Windows.Forms.Button> , пока один из них не переместится в следующую строку.  
  
5. Измените значение свойства <xref:System.Windows.Forms.FlowLayoutPanel> элемента управления <xref:System.Windows.Forms.FlowLayoutPanel.WrapContents%2A> на `false`. Обратите внимание, что дочерние элементы управления больше не помещаются в следующую строку. Вместо этого они перемещаются в первую строку и обрезаются.  
  
6. Измените значение свойства <xref:System.Windows.Forms.FlowLayoutPanel> элемента управления <xref:System.Windows.Forms.FlowLayoutPanel.WrapContents%2A> на `true`. Обратите внимание, что дочерние элементы управления снова переносятся в следующую строку.  
  
7. Уменьшите ширину элемента управления <xref:System.Windows.Forms.FlowLayoutPanel> , пока все элементы управления <xref:System.Windows.Forms.Button> не переместятся в первый столбец.  
  
8. Увеличьте ширину элемента управления <xref:System.Windows.Forms.FlowLayoutPanel> , пока все элементы управления <xref:System.Windows.Forms.Button> не переместятся в первую строку. Может потребоваться изменить размер формы, чтобы она вмещала большую ширину.  
  
## <a name="changing-flow-direction"></a>Изменение направления потока  
 Свойство <xref:System.Windows.Forms.FlowLayoutPanel.FlowDirection%2A> позволяет изменить направление расположения элементов управления. Вы можете размещать дочерние элементы управления слева направо, справа налево, сверху вниз или снизу вверх.  
  
#### <a name="to-change-the-flow-direction-in-a-flowlayoutpanel"></a>Изменение направления потока в элементе управления FlowLayoutPanel  
  
1. Измените значение свойства <xref:System.Windows.Forms.FlowLayoutPanel> элемента управления <xref:System.Windows.Forms.FlowLayoutPanel.FlowDirection%2A> на <xref:System.Windows.Forms.FlowDirection.TopDown>. Обратите внимание, что дочерние элементы управления перестраиваются в один или несколько столбцов, в зависимости от высоты данного элемента управления.  
  
2. Измените размер <xref:System.Windows.Forms.FlowLayoutPanel> , чтобы его высота была меньше, чем столбец элементов управления <xref:System.Windows.Forms.Button> . Обратите внимание, что <xref:System.Windows.Forms.FlowLayoutPanel> перестраивает дочерние элементы управления, чтобы они перешли в следующий столбец. Продолжайте уменьшать высоту и обратите внимание, что дочерние элементы управления перемещаются в последующие столбцы. Измените значение свойства <xref:System.Windows.Forms.FlowLayoutPanel> элемента управления <xref:System.Windows.Forms.FlowLayoutPanel.FlowDirection%2A> на <xref:System.Windows.Forms.FlowDirection.RightToLeft>. Обратите внимание, что позиции дочерних элементов управления изменяются в обратном направлении. Проследите за макетом при изменении значения свойства <xref:System.Windows.Forms.FlowLayoutPanel.FlowDirection%2A> на <xref:System.Windows.Forms.FlowDirection.BottomUp>.  
  
## <a name="inserting-flow-breaks"></a>Вставка разрывов потока  
 Элемент управления <xref:System.Windows.Forms.FlowLayoutPanel> предоставляет свойство FlowBreak своим дочерним элементам управления. Если свойству FlowBreak присвоено значение `true`, элементы управления внутри элемента <xref:System.Windows.Forms.FlowLayoutPanel> перестают размещаться в текущем направлении и переносятся на следующую строку или в следующий столбец.  
  
#### <a name="to-insert-flow-breaks"></a>Вставка разрывов потока  
  
1. Измените значение свойства <xref:System.Windows.Forms.FlowLayoutPanel> элемента управления <xref:System.Windows.Forms.FlowLayoutPanel.FlowDirection%2A> на <xref:System.Windows.Forms.FlowDirection.TopDown>.  
  
2. Выберите один из элементов управления <xref:System.Windows.Forms.Button> в середине самого левого столбца.  
  
3. Измените значение свойства FlowBreak элемента управления <xref:System.Windows.Forms.Button> на `true`. Обратите внимание, что столбец разрывается и элементы управления, следующие за выбранным элементом управления <xref:System.Windows.Forms.Button>, переносятся в следующий столбец. Задайте для свойства FlowBreak элемента управления <xref:System.Windows.Forms.Button> значение `false` , чтобы вернуться к исходному поведению.  
  
## <a name="positioning-controls-using-docking-and-anchoring"></a>Размещение элементов управления с использованием закрепления и привязки  
 Функциональные возможности закрепления и привязки дочерних элементов управления отличаются от их функциональных возможностей в других контейнерных элементах управления. И закрепление, и привязка относятся к самому крупному элементу управления в направлении потока.  
  
#### <a name="to-position-controls-using-docking-and-anchoring"></a>Размещение элементов управления с использованием закрепления и привязки  
  
1. Увеличивайте размер <xref:System.Windows.Forms.FlowLayoutPanel> , пока все элементы управления <xref:System.Windows.Forms.Button> не будут расположены в столбце.  
  
2. Выберите верхний элемент управления <xref:System.Windows.Forms.Button> . Увеличьте его ширину, чтобы он стал примерно вдвое шире других элементов управления <xref:System.Windows.Forms.Button> .  
  
3. Выберите второй элемент управления <xref:System.Windows.Forms.Button> . Измените значение его свойства <xref:System.Windows.Forms.Control.Anchor%2A> на <xref:System.Windows.Forms.AnchorStyles.Right>. Обратите внимание, что он перемещается так, чтобы его правая граница выровнялась с правой границей первого элемента управления <xref:System.Windows.Forms.Button> .  
  
4. Измените значение его свойства <xref:System.Windows.Forms.Control.Anchor%2A> на <xref:System.Windows.Forms.AnchorStyles.Right> и <xref:System.Windows.Forms.AnchorStyles.Left>. Обратите внимание, что он принимает ту же ширину, что и первый элемент управления <xref:System.Windows.Forms.Button> .  
  
5. Выберите третий элемент управления <xref:System.Windows.Forms.Button> . Измените значение его свойства <xref:System.Windows.Forms.Control.Dock%2A> на <xref:System.Windows.Forms.DockStyle.Fill>. Обратите внимание, что он принимает ту же ширину, что и первый элемент управления <xref:System.Windows.Forms.Button> .  
  
## <a name="arranging-controls-using-padding-and-margins"></a>Упорядочивание элементов управления с использованием отбивки и полей  
 Можно также упорядочивать элементы управления в вашем элементе управления <xref:System.Windows.Forms.FlowLayoutPanel> , изменяя свойства <xref:System.Windows.Forms.Control.Padding%2A> и <xref:System.Windows.Forms.Control.Margin%2A> .  
  
 Свойство <xref:System.Windows.Forms.Control.Padding%2A> позволяет управлять расположением элементов управления в ячейке <xref:System.Windows.Forms.FlowLayoutPanel> элемента управления. Оно задает расстояние между дочерними элементами управления и границей элемента управления <xref:System.Windows.Forms.FlowLayoutPanel> .  
  
 Свойство <xref:System.Windows.Forms.Control.Margin%2A> позволяет управлять расстоянием между элементами управления.  
  
#### <a name="to-arrange-controls-using-the-padding-and-margin-properties"></a>Размещение элементов управления с помощью свойств Padding и Margin  
  
1. Измените значение свойства <xref:System.Windows.Forms.FlowLayoutPanel> элемента управления <xref:System.Windows.Forms.Control.Dock%2A> на <xref:System.Windows.Forms.DockStyle.Fill>. Если ваша форма достаточно большая, элементы управления <xref:System.Windows.Forms.Button> будут перемещены в первый столбец элемента управления <xref:System.Windows.Forms.FlowLayoutPanel> .  
  
2. Измените значение свойства <xref:System.Windows.Forms.FlowLayoutPanel> элемента управления <xref:System.Windows.Forms.Control.Padding%2A> , развернув запись <xref:System.Windows.Forms.Control.Padding%2A> в окне **Свойства** и установив для свойства <xref:System.Windows.Forms.Padding.All%2A> значение **20**. Дополнительные сведения см. в разделе [Пошаговое руководство: Размещение Windows Forms элементы управления с помощью свойств Padding, Margins и свойство AutoSize](windows-forms-controls-padding-autosize.md). Обратите внимание, что дочерние элементы управления перемещаются к центру элемента управления <xref:System.Windows.Forms.FlowLayoutPanel> . Увеличенное значение свойства <xref:System.Windows.Forms.Control.Padding%2A> отодвигает дочерние элементы управления от границ элемента управления <xref:System.Windows.Forms.FlowLayoutPanel> .  
  
3. Выберите все элементы управления <xref:System.Windows.Forms.Button> в <xref:System.Windows.Forms.FlowLayoutPanel> и задайте в свойстве <xref:System.Windows.Forms.Control.Margin%2A> значение **20**. Обратите внимание, что расстояние между элементами управления <xref:System.Windows.Forms.Button> увеличивается, поэтому они раздвигаются. Может потребоваться изменить размер элемента управления <xref:System.Windows.Forms.FlowLayoutPanel> , чтобы увидеть все дочерние элементы управления.  
  
## <a name="inserting-controls-by-double-clicking-them-in-the-toolbox"></a>Вставка элементов управления двойным щелчком по ним в панели элементов  
 Вы можете заполнять свой элемент управления <xref:System.Windows.Forms.FlowLayoutPanel> , дважды щелкая элементы управления в **панели элементов**.  
  
#### <a name="to-insert-controls-by-double-clicking-in-the-toolbox"></a>Вставка элементов управления двойным щелчком по ним в панели элементов  
  
1. Дважды щелкните значок элемента управления <xref:System.Windows.Forms.Button> в **панели элементов**. Обратите внимание, что в элементе управления <xref:System.Windows.Forms.Button> появился новый элемент управления <xref:System.Windows.Forms.FlowLayoutPanel> .  
  
2. Дважды щелкните несколько других элементов управления в **панели элементов**. Обратите внимание, что новые элементы управления последовательно появляются в элементе управления <xref:System.Windows.Forms.FlowLayoutPanel> .  
  
## <a name="inserting-a-control-by-drawing-its-outline"></a>Вставка элемента управления путем рисования его контура  
 Вы можете вставить элемент управления в элемент управления <xref:System.Windows.Forms.FlowLayoutPanel> и задать его размер, нарисовав его контур в ячейке.  
  
#### <a name="to-insert-a-control-by-drawing-its-outline"></a>Вставка элемента управления путем рисования его контура  
  
1. В **панели элементов**щелкните значок элемента управления <xref:System.Windows.Forms.Button> . Не перетаскивайте его в форму.  
  
2. Наведите указатель мыши на элемент управления <xref:System.Windows.Forms.FlowLayoutPanel> . Обратите внимание, что указатель превратился в перекрестие с прикрепленным значком элемента управления <xref:System.Windows.Forms.Button> .  
  
3. Нажмите и удерживайте кнопку мыши.  
  
4. Перемещайте указатель мыши, чтобы нарисовать контур элемента управления <xref:System.Windows.Forms.Button> . Когда вас устроит размер, отпустите кнопку мыши. Обратите внимание, что элемент управления <xref:System.Windows.Forms.Button> создается в следующем пустом месте элемента управления <xref:System.Windows.Forms.FlowLayoutPanel> .  
  
## <a name="inserting-controls-using-the-insertion-bar"></a>Вставка элементов управления с помощью полосы вставки  
 Вы можете вставлять элементы управления в определенном месте в элементе управления <xref:System.Windows.Forms.FlowLayoutPanel> . При перетаскивании элемента управления в клиентскую область элемента управления <xref:System.Windows.Forms.FlowLayoutPanel> появляется полоса вставки, указывающая место, куда будет вставлен элемент управления.  
  
#### <a name="to-insert-a-control-using-the-caret"></a>Вставка элемента управления с помощью курсора  
  
1. Перетащите элемент управления <xref:System.Windows.Forms.Button> из **панели элементов** в элемент управления <xref:System.Windows.Forms.FlowLayoutPanel> и укажите место между двумя элементами управления <xref:System.Windows.Forms.Button> . Обратите внимание, что выводится полоса вставки, показывающая, где <xref:System.Windows.Forms.Button> помещаются при его вставке в <xref:System.Windows.Forms.FlowLayoutPanel> элемента управления. Прежде чем вставить новый элемент управления <xref:System.Windows.Forms.Button> в элемент управления <xref:System.Windows.Forms.FlowLayoutPanel> , перемещайте указатель мыши, чтобы понаблюдать за перемещением полосы вставки.  
  
2. Вставьте новый элемент управления <xref:System.Windows.Forms.Button> в элемент управления <xref:System.Windows.Forms.FlowLayoutPanel> . Обратите внимание, что новый элемент управления <xref:System.Windows.Forms.Button> не выравнивается с другими, так как его свойство <xref:System.Windows.Forms.Control.Margin%2A> имеет другое значение.  
  
## <a name="reassigning-existing-controls-to-a-different-parent"></a>Переназначение существующих элементов управления другим родительским элементам  
 Вы можете назначать элементы управления, существующие в вашей форме, новому элементу управления <xref:System.Windows.Forms.FlowLayoutPanel> .  
  
#### <a name="to-reparent-existing-controls"></a>Изменение родительского объекта существующих элементов управления  
  
1. Перетащите три элемента управления <xref:System.Windows.Forms.Button> с **панели элементов** в форму. Расположите их рядом друг с другом, но не выравнивайте.  
  
2. В **панели элементов**щелкните значок элемента управления <xref:System.Windows.Forms.FlowLayoutPanel> . Не перетаскивайте его в форму.  
  
3. Переместите указатель мыши к трем элементам управления <xref:System.Windows.Forms.Button> . Обратите внимание, что указатель превратился в перекрестие с прикрепленным значком элемента управления <xref:System.Windows.Forms.FlowLayoutPanel> .  
  
4. Нажмите и удерживайте кнопку мыши.  
  
5. Перемещайте указатель мыши, чтобы нарисовать контур элемента управления <xref:System.Windows.Forms.FlowLayoutPanel> . Обведите таким образом три элемента управления <xref:System.Windows.Forms.Button> .  
  
6. Отпустите кнопку мыши. Теперь эти три элемента управления <xref:System.Windows.Forms.Button> вставлены в элемент управления <xref:System.Windows.Forms.FlowLayoutPanel> .  
  
## <a name="next-steps"></a>Следующие шаги  
 Используя сочетание панелей макета и элементов управления, можно создавать сложные макеты. Рекомендуется также дополнительно исследовать следующие моменты.  
  
-   Увеличьте размер элемента управления <xref:System.Windows.Forms.Button> и отметьте, как это отразится на макете.  
  
-   Панели макета могут содержать другие панели макета. Попробуйте вставить элемент управления <xref:System.Windows.Forms.TableLayoutPanel> в существующий элемент управления.  
  
-   Закрепите элемент управления <xref:System.Windows.Forms.FlowLayoutPanel> в родительской форме. Измените размер этой формы и обратите внимание, как это отражается на макете.  
  
-   Задайте для свойства <xref:System.Windows.Forms.Control.Visible%2A> одного из элементов управления значение `false` и обратите внимание, как в ответ перестраивается <xref:System.Windows.Forms.FlowLayoutPanel> .  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.FlowLayoutPanel>
- <xref:System.Windows.Forms.TableLayoutPanel>
- [Пошаговое руководство. Упорядочение элементов управления в формах Windows Forms с помощью элемента TableLayoutPanel](walkthrough-arranging-controls-on-windows-forms-using-a-tablelayoutpanel.md)
- [Пошаговое руководство. Упорядочение элементов управления в формах Windows Forms с помощью линий привязки](walkthrough-arranging-controls-on-windows-forms-using-snaplines.md)
- [Взаимодействие с пользователем в Microsoft Windows, официальные рекомендации для разработчиков и конструкторов пользовательских интерфейсов. Редмонд, штат Вашингтон: Microsoft Press, 1999. (USBN: 0-7356-0566-1)](https://www.microsoft.com/mspress/southpacific/books/book11588.htm)
- [Свойство AutoSize](autosize-property-overview.md)
- [Практическое руководство. Закрепление элементов управления в формах Windows Forms](how-to-dock-controls-on-windows-forms.md)
- [Практическое руководство. Привязка элементов управления в формах Windows Forms](how-to-anchor-controls-on-windows-forms.md)
- [Пошаговое руководство. Создание структуры элементов управления Windows Forms с помощью свойств Padding, Margins и AutoSize](windows-forms-controls-padding-autosize.md)
