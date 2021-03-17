---
title: Пошаговое руководство. Упорядочение элементов управления в формах Windows Forms с помощью элемента TableLayoutPanel
ms.date: 03/30/2017
helpviewer_keywords:
- controls [Windows Forms], arranging with TableLayoutPanel
- TableLayoutPanel control [Windows Forms], walkthroughs
- Windows Forms controls, arranging
ms.assetid: d474885e-12cc-4ab7-b997-2a23a643049b
ms.openlocfilehash: 392d548a5f89c31d94af9134b8cc3a37b28d8c6c
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59341625"
---
# <a name="walkthrough-arranging-controls-on-windows-forms-using-a-tablelayoutpanel"></a>Пошаговое руководство. Упорядочение элементов управления в формах Windows Forms с помощью элемента TableLayoutPanel
В некоторых приложениях требуется форма, макет которой изменяется надлежащим образом при изменении размера формы или содержимого. Если необходим динамический макет и вы не хотите обрабатывать события <xref:System.Windows.Forms.Control.Layout> явно в коде, рассмотрите возможность использования панели макета.  
  
 Элементы управления <xref:System.Windows.Forms.FlowLayoutPanel> и <xref:System.Windows.Forms.TableLayoutPanel> предоставляют удобные способы упорядочения элементов управления в форме. Они обеспечивают автоматическую настраиваемую возможность управления относительным положением содержащихся в них дочерних элементов управления и предоставляют функции динамического макета во время выполнения и таким образом могут изменять размер и положение дочерних элементов управления по мере измерения размеров родительской формы. Панели макета могут быть вложенными в других панелях макета, что позволяет реализовывать сложные пользовательские интерфейсы.  
  
 Элемент управления <xref:System.Windows.Forms.FlowLayoutPanel> упорядочивает свое содержимое в определенном направлении, горизонтальном или вертикальном. Его содержимое может быть перенесено из одной строки в следующую или из одного столбца в следующий. Кроме того, вместо переноса содержимое может обрезаться. Дополнительные сведения см. в разделе [Пошаговое руководство: Упорядочение элементов управления в Windows Forms, с помощью элемента FlowLayoutPanel](walkthrough-arranging-controls-on-windows-forms-using-a-flowlayoutpanel.md).  
  
 <xref:System.Windows.Forms.TableLayoutPanel> Упорядочивает свое содержимое в сетке, обеспечивая функциональные возможности, аналогичные HTML \<таблицы > элемента. <xref:System.Windows.Forms.TableLayoutPanel> Элемент управления позволяет размещать элементы управления в виде сетки без необходимости точного указания положения каждого отдельного элемента управления. Его ячейки организованы в строки и столбцы, и они могут быть разного размера. Ячейки могут быть объединены между строками и столбцами. Ячейки могут содержать что-либо формы может содержать и ведут себя во многих отношениях как контейнеры.  
  
 <xref:System.Windows.Forms.TableLayoutPanel> Элемент управления также предоставляет возможность пропорционального изменения размера во время выполнения, то макет можно без проблем при изменении размера формы. Это делает <xref:System.Windows.Forms.TableLayoutPanel> управления хорошо подходит для форм ввода данных и локализованных приложений. Дополнительные сведения см. в разделе [Пошаговое руководство: Создание переменного размера Windows формы для ввода данных](https://docs.microsoft.com/previous-versions/visualstudio/visual-studio-2010/991eahec(v=vs.100)) и [Пошаговое руководство: Создание формы Windows локализуемые](https://docs.microsoft.com/previous-versions/visualstudio/visual-studio-2010/7k9fa71y(v=vs.100)).  
  
 В общем случае не следует использовать <xref:System.Windows.Forms.TableLayoutPanel> управления как контейнер для всего макета. Используйте <xref:System.Windows.Forms.TableLayoutPanel> элементы управления для предоставления возможностей пропорционального изменения размера его части.  
  
 В данном пошаговом руководстве представлены следующие задачи.  
  
-   Создание проекта Windows Forms  
  
-   Упорядочение элементов управления в строках и столбцах  
  
-   Параметр строки и свойств столбца  
  
-   Объединение строк и столбцов с элементом управления  
  
-   Автоматическая обработка переполнения  
  
-   Вставка элементов управления двойным щелчком по ним в панели элементов  
  
-   Вставка элемента управления путем рисования его контура  
  
-   Переназначение существующих элементов управления другим родительским элементам  
  
 После завершения вы будете понимать роль, которую играют эти важные функции макета.  
  
> [!NOTE]
>  Отображаемые диалоговые окна и команды меню могут отличаться от описанных в справке в зависимости от текущих параметров или выпуска. Чтобы изменить параметры, выберите в меню **Сервис** пункт **Импорт и экспорт параметров** . Дополнительные сведения см. в разделе [Персонализация интегрированной среды разработки Visual Studio](/visualstudio/ide/personalizing-the-visual-studio-ide).  
  
## <a name="creating-the-project"></a>Создание проекта  
 Первым шагом является создание проекта и настройка формы.  
  
#### <a name="to-create-the-project"></a>Создание проекта  
  
1. Создайте проект приложения Windows с именем «TableLayoutPanelExample». Дополнительные сведения см. в разделе [Как Создайте проект приложения Windows Forms](/visualstudio/ide/step-1-create-a-windows-forms-application-project) .  
  
2. Выберите форму в **Windows** **конструктора**.  
  
## <a name="arranging-controls-in-rows-and-columns"></a>Упорядочение элементов управления в строках и столбцах  
 <xref:System.Windows.Forms.TableLayoutPanel> Элемент управления позволяет легко размещать элементы управления по строкам и столбцам.  
  
#### <a name="to-arrange-controls-in-rows-and-columns-using-a-tablelayoutpanel"></a>Размещение элементов управления в строках и столбцах, с помощью элемента управления TableLayoutPanel  
  
1. Перетащите элемент управления <xref:System.Windows.Forms.TableLayoutPanel> из **панели элементов** в свою форму. Обратите внимание, что по умолчанию <xref:System.Windows.Forms.TableLayoutPanel> элемент управления имеет четыре ячейки.  
  
2. Перетащите <xref:System.Windows.Forms.Button> управления из **элементов** в <xref:System.Windows.Forms.TableLayoutPanel> управления и поместите его в одну из ячеек. Обратите внимание, что <xref:System.Windows.Forms.Button> создается элемент управления в ячейке, вы выбрали.  
  
3. Перетащите три дополнительные <xref:System.Windows.Forms.Button> управляет из **элементов** в <xref:System.Windows.Forms.TableLayoutPanel> таким образом, чтобы каждая ячейка содержит кнопки.  
  
4. Захватите маркер изменения размера по вертикали между двумя столбцами и переместите его влево. Обратите внимание, что <xref:System.Windows.Forms.Button> элементов управления в первом столбце изменяются уменьшите ширину, а размер <xref:System.Windows.Forms.Button> элементов управления во втором столбце не изменяется.  
  
5. Захватите маркер изменения размера по вертикали между двумя столбцами и переместите ее вправо. Обратите внимание, что <xref:System.Windows.Forms.Button> элементов управления в первом столбце вернуть их первоначальный размер, тогда как <xref:System.Windows.Forms.Button> перемещении элементов управления во втором столбце справа.  
  
6. Переместите маркер изменения размера по горизонтали вверх и вниз, чтобы увидеть соответствующий эффект в элементы управления на панели.  
  
## <a name="positioning-controls-within-cells-using-docking-and-anchoring"></a>Размещение элементов управления внутри ячеек с использованием закрепления и привязки  
 Функции привязки дочерних элементов управления в <xref:System.Windows.Forms.TableLayoutPanel> отличается от поведения других контейнерных элементов управления. Закрепление дочерних элементов совпадает со значением других контейнерных элементов управления.  
  
#### <a name="positioning-controls-within-cells"></a>Размещение элементов управления в ячейках  
  
1. Выберите первую <xref:System.Windows.Forms.Button> элемента управления. Измените значение его свойства <xref:System.Windows.Forms.Control.Dock%2A> на <xref:System.Windows.Forms.DockStyle.Fill>. Обратите внимание, что <xref:System.Windows.Forms.Button> управления занимает свою ячейку.  
  
2. Выберите один из других <xref:System.Windows.Forms.Button> элементов управления. Измените значение его свойства <xref:System.Windows.Forms.Control.Anchor%2A> на <xref:System.Windows.Forms.AnchorStyles.Right>. Обратите внимание на то, что он перемещается так, чтобы ее правую границу рядом с правой границы ячейки. Расстояние между границами представляет собой сумму <xref:System.Windows.Forms.Button> элемента управления <xref:System.Windows.Forms.Control.Margin%2A> свойство и панели <xref:System.Windows.Forms.Control.Padding%2A> свойство.  
  
3. Измените значение свойства <xref:System.Windows.Forms.Button> элемента управления <xref:System.Windows.Forms.Control.Anchor%2A> свойства <xref:System.Windows.Forms.AnchorStyles.Right> и <xref:System.Windows.Forms.AnchorStyles.Left>. Обратите внимание, что элемент управления имеет размер по ширине ячейки с <xref:System.Windows.Forms.Control.Margin%2A> и <xref:System.Windows.Forms.Control.Padding%2A> значения, взятые в учетную запись.  
  
4. Повторите шаги 2 и 3 с <xref:System.Windows.Forms.AnchorStyles.Top> и <xref:System.Windows.Forms.AnchorStyles.Bottom> стили.  
  
## <a name="setting-row-and-column-properties"></a>Параметр строки и свойств столбца  
 Отдельные свойства из строк и столбцов можно задать с помощью <xref:System.Windows.Forms.TableLayoutPanel.RowStyles%2A> и <xref:System.Windows.Forms.TableLayoutPanel.ColumnStyles%2A> коллекций.  
  
#### <a name="to-set-row-and-column-properties"></a>Чтобы задать свойства строк и столбцов  
  
1. Выберите <xref:System.Windows.Forms.TableLayoutPanel> контролировать **конструктор Windows Forms**.  
  
2. В **свойства** открытых окон <xref:System.Windows.Forms.TableLayoutPanel.ColumnStyles%2A> коллекции, нажав кнопку с многоточием (![экрана VisualStudioEllipsesButton](../media/vbellipsesbutton.png "vbEllipsesButton")) кнопку рядом с полем **столбцы** запись.  
  
3. Выберите первый столбец и измените значение его <xref:System.Windows.Forms.TableLayoutStyle.SizeType%2A> свойства <xref:System.Windows.Forms.SizeType.AutoSize>. Нажмите кнопку **ОК** чтобы принять изменение. Обратите внимание, что ширина первого столбца уменьшается в соответствии с <xref:System.Windows.Forms.Button> элемента управления. Обратите внимание на то, что ширина столбца не является изменяемым размером.  
  
4. В **свойства** открытое окно <xref:System.Windows.Forms.TableLayoutPanel.ColumnStyles%2A> коллекции и выберите первый столбец. Измените значение его свойства <xref:System.Windows.Forms.TableLayoutStyle.SizeType%2A> на <xref:System.Windows.Forms.SizeType.Percent>. Нажмите кнопку **ОК** чтобы принять изменение. Изменение размера <xref:System.Windows.Forms.TableLayoutPanel> управления на увеличение ширины и обратите внимание на то, что расширяет ширину первого столбца. Изменение размера <xref:System.Windows.Forms.TableLayoutPanel> управления уменьшите ширину и обратите внимание на то, что кнопки в первом столбце подгоняются под размеры ячейки. Также Обратите внимание, что ширина столбца можно изменять.  
  
5. В **свойства** открытое окно <xref:System.Windows.Forms.TableLayoutPanel.ColumnStyles%2A> коллекции и выберите все перечисленные столбцы. Установите для параметра каждый <xref:System.Windows.Forms.TableLayoutStyle.SizeType%2A> свойства <xref:System.Windows.Forms.SizeType.Percent>. Нажмите кнопку **ОК** чтобы принять изменение. Повторите процедуру, используя <xref:System.Windows.Forms.TableLayoutPanel.RowStyles%2A> коллекции.  
  
6. Щелкните один из угловых маркеров изменения размера и изменить ширину и высоту <xref:System.Windows.Forms.TableLayoutPanel> элемента управления. Обратите внимание, что строки и столбцы изменяются как <xref:System.Windows.Forms.TableLayoutPanel> изменения размера элемента управления. Также Обратите внимание, что строк и столбцов можно изменять с горизонтальной и вертикальной маркеры изменения размера.  
  
## <a name="spanning-rows-and-columns-with-a-control"></a>Объединение строк и столбцов с элементом управления  
 <xref:System.Windows.Forms.TableLayoutPanel> Управления добавляет несколько новых свойств для элементов управления во время разработки. Два из этих свойств — `RowSpan` и `ColumnSpan`. Эти свойства можно использовать, чтобы сделать элемент управления диапазона больше, чем одну строку или столбец.  
  
#### <a name="to-span-rows-and-columns-with-a-control"></a>Чтобы объединение строк и столбцов с элементом управления  
  
1. Выберите <xref:System.Windows.Forms.Button> элемента управления в первой строке и первом столбце.  
  
2. В **свойства** windows, измените значение свойства `ColumnSpan` свойства **2**. Обратите внимание, что <xref:System.Windows.Forms.Button> управления заполняет первый столбец и втором столбце. Обратите внимание на то, чем дополнительную строку был добавлен для реализации этого изменения.  
  
3. Повторите шаг 2 для `RowSpan` свойство.  
  
## <a name="inserting-controls-by-double-clicking-them-in-the-toolbox"></a>Вставка элементов управления двойным щелчком по ним в панели элементов  
 Вы можете заполнять свой элемент управления <xref:System.Windows.Forms.TableLayoutPanel> , дважды щелкая элементы управления в **панели элементов**.  
  
#### <a name="to-insert-controls-by-double-clicking-in-the-toolbox"></a>Вставка элементов управления двойным щелчком по ним в панели элементов  
  
1. Перетащите элемент управления <xref:System.Windows.Forms.TableLayoutPanel> из **панели элементов** в свою форму.  
  
2. Дважды щелкните значок элемента управления <xref:System.Windows.Forms.Button> в **панели элементов**. Обратите внимание, что отображается новый элемент управления button в <xref:System.Windows.Forms.TableLayoutPanel> первой ячейке элемента управления.  
  
3. Дважды щелкните несколько других элементов управления в **панели элементов**. Обратите внимание, что новые элементы управления последовательно появляются в <xref:System.Windows.Forms.TableLayoutPanel> пустых ячейках элемента управления. Также Обратите внимание, что <xref:System.Windows.Forms.TableLayoutPanel> управления расширяется, чтобы вместить новые элементы управления, если доступны открытых ячеек.  
  
## <a name="automatic-handling-of-overflows"></a>Автоматическая обработка переполнения  
 При вставке элементов управления в <xref:System.Windows.Forms.TableLayoutPanel> элемента управления, вы можете исчерпать пустые ячейки для новых элементов управления. <xref:System.Windows.Forms.TableLayoutPanel> Управления автоматически обрабатывает эту ситуацию, увеличив количество ячеек.  
  
#### <a name="to-observe-automatic-handling-of-overflows"></a>Чтобы наблюдать автоматическую обработку переполнений  
  
1. Если по-прежнему пустые ячейки в <xref:System.Windows.Forms.TableLayoutPanel> управления, по-прежнему вставки нового <xref:System.Windows.Forms.Button> управляет до <xref:System.Windows.Forms.TableLayoutPanel> заполнения элемента управления.  
  
2. Один раз <xref:System.Windows.Forms.TableLayoutPanel> заполнения элемента управления, дважды щелкните <xref:System.Windows.Forms.Button> значок в **элементов** вставляемый другой <xref:System.Windows.Forms.Button> элемента управления. Обратите внимание, что <xref:System.Windows.Forms.TableLayoutPanel> элемент управления создает новые ячейки для размещения нового элемента управления. Вставьте несколько дополнительных элементов управления и наблюдать за поведением изменения размера.  
  
3. Измените значение свойства <xref:System.Windows.Forms.TableLayoutPanel> элемента управления <xref:System.Windows.Forms.TableLayoutPanel.GrowStyle%2A> на <xref:System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize>. Дважды щелкните <xref:System.Windows.Forms.Button> значок в **элементов** вставляемый <xref:System.Windows.Forms.Button> управляет до <xref:System.Windows.Forms.TableLayoutPanel> заполнения элемента управления. Дважды щелкните <xref:System.Windows.Forms.Button> значок в **элементов** еще раз. Обратите внимание, что появляется сообщение об ошибке из **конструктор Windows Forms** информируют о том, что дополнительные строки и столбцы не могут создаваться.  
  
## <a name="inserting-a-control-by-drawing-its-outline"></a>Вставка элемента управления путем рисования его контура  
 Вы можете вставить элемент управления в элемент управления <xref:System.Windows.Forms.TableLayoutPanel> и задать его размер, нарисовав его контур в ячейке.  
  
#### <a name="to-insert-a-control-by-drawing-its-outline"></a>Вставка элемента управления путем рисования его контура  
  
1. Перетащите элемент управления <xref:System.Windows.Forms.TableLayoutPanel> из **панели элементов** в свою форму.  
  
2. В **панели элементов**щелкните значок элемента управления <xref:System.Windows.Forms.Button> . Не перетаскивайте его в форму.  
  
3. Наведите указатель мыши на элемент управления <xref:System.Windows.Forms.TableLayoutPanel> . Обратите внимание, что указатель превратился в перекрестие с прикрепленным значком элемента управления <xref:System.Windows.Forms.Button> .  
  
4. Нажмите и удерживайте кнопку мыши.  
  
5. Перемещайте указатель мыши, чтобы нарисовать контур элемента управления <xref:System.Windows.Forms.Button> . Когда вас устроит размер, отпустите кнопку мыши. Обратите внимание, что <xref:System.Windows.Forms.Button> создается элемент управления в ячейке, в котором нарисован контур элемента управления.  
  
## <a name="multiple-controls-within-cells-are-not-permitted"></a>Несколько элементов управления в ячейках не допускаются.  
 <xref:System.Windows.Forms.TableLayoutPanel> Элемент управления может содержать только один дочерний элемент управления в ячейке.  
  
#### <a name="to-demonstrate-that-multiple-controls-within-cells-are-not-permitted"></a>Чтобы продемонстрировать, что нескольких элементов управления в ячейках не разрешены  
  
-   Перетащите <xref:System.Windows.Forms.Button> управления из **элементов** в <xref:System.Windows.Forms.TableLayoutPanel> управления и вставьте его в одну из заполненных ячеек. Обратите внимание, что <xref:System.Windows.Forms.TableLayoutPanel> управления не позволяет удалить <xref:System.Windows.Forms.Button> элемента управления в заполненную ячейку.  
  
## <a name="swapping-controls"></a>Перестановки элементов управления  
 <xref:System.Windows.Forms.TableLayoutPanel> Элемент управления позволяет поменять местами элементы управления, занимающий две разные ячейки.  
  
#### <a name="to-swap-controls"></a>Для замены элементов управления  
  
-   Перетащите один из <xref:System.Windows.Forms.Button> элементы управления из заполненную ячейку и drop в на другой заполненную ячейку. Обратите внимание на то, что эти два элемента управления перемещаются из одной ячейки в другую.  
  
## <a name="next-steps"></a>Следующие шаги  
 Используя сочетание панелей макета и элементов управления, можно создавать сложные макеты. Рекомендуется также дополнительно исследовать следующие моменты.  
  
-   Попробуйте <xref:System.Windows.Forms.Button> элементы управления для большего размера и Примечание отразится на макете.  
  
-   Вставьте выделение нескольких элементов управления в <xref:System.Windows.Forms.TableLayoutPanel> управления и обратите внимание на то, как вставляются элементы управления.  
  
-   Панели макета могут содержать другие панели макета. Попробуйте вставить элемент управления <xref:System.Windows.Forms.TableLayoutPanel> в существующий элемент управления.  
  
-   Закрепите элемент управления <xref:System.Windows.Forms.TableLayoutPanel> в родительской форме. Измените размер этой формы и обратите внимание, как это отражается на макете.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.FlowLayoutPanel>
- <xref:System.Windows.Forms.TableLayoutPanel>
- [Пошаговое руководство. Упорядочение элементов управления в формах Windows Forms с помощью элемента FlowLayoutPanel](walkthrough-arranging-controls-on-windows-forms-using-a-flowlayoutpanel.md)
- [Пошаговое руководство. Упорядочение элементов управления в формах Windows Forms с помощью линий привязки](walkthrough-arranging-controls-on-windows-forms-using-snaplines.md)
- [Взаимодействие с пользователем в Microsoft Windows, официальные рекомендации для разработчиков и конструкторов пользовательских интерфейсов. Редмонд, штат Вашингтон: Microsoft Press, 1999. (USBN: 0-7356-0566-1)](https://www.microsoft.com/mspress/southpacific/books/book11588.htm)
- [Пошаговое руководство. Создание переменного размера Windows формы для ввода данных](https://docs.microsoft.com/previous-versions/visualstudio/visual-studio-2010/991eahec(v=vs.100))
- [Пошаговое руководство. Создание формы локализуемые Windows](https://docs.microsoft.com/previous-versions/visualstudio/visual-studio-2010/7k9fa71y(v=vs.100))
- [Советы по использованию элемента управления TableLayoutPanel](best-practices-for-the-tablelayoutpanel-control.md)
- [Свойство AutoSize](autosize-property-overview.md)
- [Практическое руководство. Закрепление элементов управления в формах Windows Forms](how-to-dock-controls-on-windows-forms.md)
- [Практическое руководство. Привязка элементов управления в формах Windows Forms](how-to-anchor-controls-on-windows-forms.md)
- [Пошаговое руководство. Создание структуры элементов управления Windows Forms с помощью свойств Padding, Margins и AutoSize](windows-forms-controls-padding-autosize.md)
