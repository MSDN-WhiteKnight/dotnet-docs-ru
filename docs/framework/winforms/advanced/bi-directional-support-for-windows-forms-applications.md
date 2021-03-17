---
title: Поддержка двунаправленного письма для приложений Windows Forms
ms.date: 09/30/2017
helpviewer_keywords:
- globalization [Windows Forms], bi-directional support in Windows
- Windows Forms, international
- localization [Windows Forms], bi-directional support in Windows
- bi-directional language support [Windows Forms], Windows applications
- Windows Forms, bi-directional support
author: rpetrusha
ms.author: ronpet
ms.openlocfilehash: f494d3176d72563a82b50fd5e077917e46045b91
ms.sourcegitcommit: 160a88c8087b0e63606e6e35f9bd57fa5f69c168
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/09/2019
ms.locfileid: "57712295"
---
# <a name="bi-directional-support-for-windows-forms-applications"></a>Поддержка двунаправленного письма для приложений Windows Forms
Visual Studio можно использовать для создания приложений на основе Windows, которые поддерживают такие языки (справа налево), такие как арабский и иврит. Сюда входят стандартные формы, диалоговые окна, MDI-формы и все элементы управления, с которыми можно работать в этих формах, то есть все объекты в пространстве имен <xref:System.Windows.Forms.Control>.  
  
## <a name="culture-support"></a>Поддержка языка и региональных параметров  
 Язык и региональные параметры, в том числе язык и региональные параметры пользовательского интерфейса, определяют способы обработки приложением дат, времени, валют и других данных. Поддержка языка и региональных параметров, в том числе языка и региональных параметров пользовательского интерфейса, для языков с двунаправленным письмом соответствует поддержке для любых других языков. Дополнительные сведения см. в разделе [региональных классы для глобальных форм Windows forms и web forms](/visualstudio/ide/culture-specific-classes-for-global-windows-forms-and-web-forms).  
  
## <a name="righttoleft-and-righttoleftlayout-properties"></a>Свойства RightToLeft и RightToLeftLayout  
 Базовый класс <xref:System.Windows.Forms.Control>, от которого наследуются формы, включает свойство <xref:System.Windows.Forms.Control.RightToLeft%2A>, которое можно задать, чтобы изменить порядок чтения формы и ее элементов управления. Если задать свойство <xref:System.Windows.Forms.Control.RightToLeft%2A> формы, по умолчанию элементы управления формы будут наследовать этот параметр. Однако свойство <xref:System.Windows.Forms.Control.RightToLeft%2A> можно также задать по отдельности для большинства элементов управления. Также см. раздел [Как Отображение текста справа налево в формах Windows Forms для глобализации](https://docs.microsoft.com/previous-versions/visualstudio/visual-studio-2010/7d3337xw(v=vs.100)).  
  
 Результат применения свойства <xref:System.Windows.Forms.Control.RightToLeft%2A> может отличаться в разных элементах управления. В некоторых элементах управления это свойство устанавливает только порядок чтения, например в элементах управления <xref:System.Windows.Forms.Button>, <xref:System.Windows.Forms.TreeView> и <xref:System.Windows.Forms.ToolTip>. В других элементах управления свойство <xref:System.Windows.Forms.Control.RightToLeft%2A> изменяет порядок чтения и макет. К ним относятся элементы управления <xref:System.Windows.Forms.RadioButton>, <xref:System.Windows.Forms.ComboBox> и <xref:System.Windows.Forms.CheckBox>. Другие элементы управления требуют применения свойства <xref:System.Windows.Forms.Form.RightToLeftLayout%2A> для зеркального отражения расположения справа налево. В следующей таблице приведены сведения о том, как свойства <xref:System.Windows.Forms.Control.RightToLeft%2A> и <xref:System.Windows.Forms.Form.RightToLeftLayout%2A> влияют на отдельные элементы управления Windows Forms.  
  
|Элемент управления или компонент|Влияние свойства RightToLeft|Влияние свойства RightToLeftLayout|Требуется ли отражение|  
|------------------------|------------------------------------|------------------------------------------|-------------------------|  
|<xref:System.Windows.Forms.Button>|Задает порядок чтения справа налево. Обращает значения <xref:System.Windows.Forms.ButtonBase.TextAlign%2A>, <xref:System.Windows.Forms.ButtonBase.ImageAlign%2A> и <xref:System.Windows.Forms.ButtonBase.TextImageRelation%2A>.|Не влияет.|Нет|  
|<xref:System.Windows.Forms.CheckBox>|Флажок отображается справа от текста.|Не влияет.|Нет|  
|<xref:System.Windows.Forms.CheckedListBox>|Все флажки отображаются справа от текста.|Не влияет.|Нет|  
|<xref:System.Windows.Forms.ColorDialog>|Не меняется; зависит от языка операционной системы.|Не влияет.|Нет|  
|<xref:System.Windows.Forms.ComboBox>|Элементы в поле со списком выравниваются по правому краю.|Не влияет.|Нет|  
|<xref:System.Windows.Forms.ContextMenu>|Отображается по правому краю с порядком чтения справа налево.|Не влияет.|Нет|  
|<xref:System.Windows.Forms.DataGrid>|Отображается по правому краю с порядком чтения справа налево.|Не влияет.|Нет|  
|<xref:System.Windows.Forms.DataGridView>|Влияет на расположение элемента управления и порядок чтения справа налево.|Не влияет.|Нет|  
|<xref:System.Windows.Forms.DateTimePicker>|Не меняется; зависит от языка операционной системы.|Зеркально отражает элемент управления.|Да|  
|<xref:System.Windows.Forms.DomainUpDown>|Выравнивание кнопок "вверх" и "вниз" по левому краю.|Не влияет.|Нет|  
|<xref:System.Windows.Forms.ErrorProvider>|Не поддерживается|Не влияет.|Нет|  
|<xref:System.Windows.Forms.FontDialog>|Зависит от языка операционной системы.|Не влияет.|Нет|  
|<xref:System.Windows.Forms.Form>|Задает порядок чтения справа налево и обращает полосы прокрутки.|Зеркально отражает форму.|Да|  
|<xref:System.Windows.Forms.GroupBox>|Подпись отображается по правому краю. Дочерние элементы управления могут наследовать это свойство.|Используйте <xref:System.Windows.Forms.TableLayoutPanel> в элементе управления для поддержки зеркального отображения справа налево.|Нет|  
|<xref:System.Windows.Forms.HScrollBar>|Запускается с полосой прокрутки (бегунком) по правому краю.|Не влияет.|Нет|  
|<xref:System.Windows.Forms.ImageList>|Не требуется.|Не влияет.|Нет|  
|<xref:System.Windows.Forms.Label>|Отображение по правому краю. Обращает значения <xref:System.Windows.Forms.Label.TextAlign%2A> и <xref:System.Windows.Forms.Label.ImageAlign%2A>.|Не влияет.|Нет|  
|<xref:System.Windows.Forms.LinkLabel>|Отображение по правому краю. Обращает значения <xref:System.Windows.Forms.Label.TextAlign%2A> и <xref:System.Windows.Forms.Label.ImageAlign%2A>.|Не влияет.|Нет|  
|<xref:System.Windows.Forms.ListBox>|Элементы выравниваются по правому краю.|Не влияет.|Нет|  
|<xref:System.Windows.Forms.ListView>|Устанавливает порядок чтения справа налево; элементы остаются выровненными по левому краю.|Зеркально отражает элемент управления.|Да|  
|<xref:System.Windows.Forms.MainMenu>|Отображение по правому краю с порядком чтения справа налево во время выполнения (не во время разработки).|Не влияет.|Нет|  
|<xref:System.Windows.Forms.MaskedTextBox>|Отображение текста справа налево.|Не влияет.|Нет|  
|<xref:System.Windows.Forms.MonthCalendar>|Не меняется; зависит от языка операционной системы.|Зеркально отражает элемент управления.|Да|  
|<xref:System.Windows.Forms.NotifyIcon>|Не поддерживается|Не поддерживается|Нет|  
|<xref:System.Windows.Forms.NumericUpDown>|Выравнивание кнопок "вверх" и "вниз" по левому краю.|Не влияет.|Нет|  
|<xref:System.Windows.Forms.OpenFileDialog>|В операционных системах справа налево, установка форме <xref:System.Windows.Forms.Control.RightToLeft> свойства <xref:System.Windows.Forms.RightToLeft.Yes?displayProperty=nameWithType> есть перевод диалогового окна |Не влияет.|Нет|  
|<xref:System.Windows.Forms.PageSetupDialog>|Не меняется; зависит от языка операционной системы.|Не влияет.|Нет|  
|<xref:System.Windows.Forms.Panel>|Дочерние элементы управления могут наследовать это свойство.|Используйте <xref:System.Windows.Forms.TableLayoutPanel> в элементе управления для поддержки отображения справа налево.|Да|  
|<xref:System.Windows.Forms.PictureBox>|Не поддерживается|Не влияет.|Нет|  
|<xref:System.Windows.Forms.PrintDialog>|Не меняется; зависит от языка операционной системы.|Не влияет.|Нет|  
|<xref:System.Drawing.Printing.PrintDocument>|Вертикальная полоса прокрутки располагается по левому краю, а горизонтальная полоса прокрутки начинается слева.|Не влияет.|Нет|  
|<xref:System.Windows.Forms.PrintPreviewDialog>|Не поддерживается|Не поддерживается|Нет|  
|<xref:System.Windows.Forms.ProgressBar>|Не изменяется этим свойством.|Зеркально отражает элемент управления.|Да|  
|<xref:System.Windows.Forms.RadioButton>|Переключатель отображается справа от текста.|Не влияет.|Нет|  
|<xref:System.Windows.Forms.RichTextBox>|Элементы управления, содержащие текст, отображаются справа налево с порядком чтения справа налево.|Не влияет.|Нет|  
|<xref:System.Windows.Forms.SaveFileDialog>|Не меняется; зависит от языка операционной системы.|Не влияет.|Нет|  
|<xref:System.Windows.Forms.SplitContainer>|Макет панели обращается; вертикальная полоса прокрутки отображается слева; горизонтальная полоса прокрутки начинается справа.|Используйте <xref:System.Windows.Forms.TableLayoutPanel>, чтобы отразить порядок чтения дочерних элементов управления.|Нет|  
|<xref:System.Windows.Forms.Splitter>|Не поддерживается|Не влияет.|Нет|  
|<xref:System.Windows.Forms.StatusBar>|Не поддерживается; используйте <xref:System.Windows.Forms.StatusStrip>.|Не виляет; используйте <xref:System.Windows.Forms.StatusStrip>.|Нет|  
|<xref:System.Windows.Forms.TabControl>|Не изменяется этим свойством.|Зеркально отражает элемент управления.|Да|  
|<xref:System.Windows.Forms.TextBox>|Отображение текста справа налево с порядком чтения справа налево.|Не влияет.|Нет|  
|<xref:System.Windows.Forms.Timer>|Не требуется.|Не требуется.|Нет|  
|<xref:System.Windows.Forms.ToolBar>|Не изменяется этим свойством; используйте <xref:System.Windows.Forms.ToolStrip>.|Не влияет; используйте <xref:System.Windows.Forms.ToolStrip>.|Да|  
|<xref:System.Windows.Forms.ToolTip>|Задает порядок чтения справа налево.|Не влияет.|Нет|  
|<xref:System.Windows.Forms.TrackBar>|Прокрутка или линейка начинается справа; если ориентация <xref:System.Windows.Forms.TrackBar.Orientation%2A> вертикальная, деления начинаются справа.|Не влияет.|Нет|  
|<xref:System.Windows.Forms.TreeView>|Задает только порядок чтения справа налево.|Зеркально отражает элемент управления.|Да|  
|<xref:System.Windows.Forms.UserControl>|Вертикальная полоса прокрутки отображается слева; бегунок горизонтальной полосы прокрутки находится справа.|Прямая поддержка отсутствует; используйте <xref:System.Windows.Forms.TableLayoutPanel>.|Нет|  
|<xref:System.Windows.Forms.VScrollBar>|Отображается не в правой, а в левой части элементов управления с прокруткой.|Не влияет.|Нет|  
  
## <a name="encoding"></a>кодировка  
 Windows Forms поддерживает Юникод, поэтому можно включить любой набор символов при создании приложений с двунаправленным письмом. Однако не все элементы управления Windows Forms поддерживают Юникод во всех платформах. Дополнительные сведения см. в разделе [Кодировка и глобализация Windows Forms](encoding-and-windows-forms-globalization.md).  
  
## <a name="gdi"></a>GDI+  
 [!INCLUDE[ndptecgdiplus](../../../../includes/ndptecgdiplus-md.md)] можно использовать для рисования текста с порядком чтения справа налево. Метод <xref:System.Drawing.Graphics.DrawString%2A>, используемый для отрисовки текста, поддерживает параметр `StringFormat`, который можно задать для члена <xref:System.Drawing.StringFormatFlags.DirectionRightToLeft> перечисления <xref:System.Drawing.StringFormatFlags>, чтобы обратить точку начала координат для текста.  
  
## <a name="common-dialog-boxes"></a>Общие диалоговые окна  
 Служебные программы, такие как диалоговое окно открытия файла, находятся под управлением Windows. Они наследуют элементы языка от операционной системы. При использовании версии Windows с нужными параметрами языка эти диалоговые окна будут правильно работать с двунаправленным письмом.  
  
 Окна сообщений также управляются операционной системой и поддерживают двунаправленный текст. Подписи кнопок в окнах сообщений основаны на текущих языковых параметрах. По умолчанию в окнах сообщений не используется порядок чтения справа налево, однако порядок чтения при отображении окон сообщений можно изменить с помощью параметра.  
  
## <a name="righttoleft-scrollbars-and-scrollablecontrol"></a>RightToLeft, полосы прокрутки и ScrollableControl  
 В настоящее время существует ограничение в Windows Forms, которое блокирует правильную работу всех классов, производных от <xref:System.Windows.Forms.ScrollableControl>, когда включено свойство <xref:System.Windows.Forms.Control.RightToLeft%2A> и для <xref:System.Windows.Forms.ScrollableControl.AutoScroll%2A> задано значение <xref:System.Windows.Forms.RightToLeft.Yes>. Предположим, что вы поместили элемент управления, например <xref:System.Windows.Forms.Panel>, или класс контейнера, производный от <xref:System.Windows.Forms.Panel> (такой как <xref:System.Windows.Forms.FlowLayoutPanel> или <xref:System.Windows.Forms.TableLayoutPanel>), в форму. Если задать значение <xref:System.Windows.Forms.RightToLeft.Yes> свойства <xref:System.Windows.Forms.ScrollableControl.AutoScroll%2A> для контейнера, а затем значение <xref:System.Windows.Forms.AnchorStyles.Right> свойства <xref:System.Windows.Forms.Control.Anchor%2A> для одного или нескольких элементов управления внутри контейнера, то полоса прокрутки не появится вовсе. Класс, производный от <xref:System.Windows.Forms.ScrollableControl>, действует, как если бы свойству <xref:System.Windows.Forms.ScrollableControl.AutoScroll%2A> было присвоено значение <xref:System.Windows.Forms.RightToLeft.No>.  
  
 В настоящее время единственным решением является вложение <xref:System.Windows.Forms.ScrollableControl> в другой <xref:System.Windows.Forms.ScrollableControl>. Например, если требуется, чтобы класс <xref:System.Windows.Forms.TableLayoutPanel> работал в такой ситуации, можно поместить его в элемент управления <xref:System.Windows.Forms.Panel> и задать для свойства <xref:System.Windows.Forms.ScrollableControl.AutoScroll%2A> в элементе <xref:System.Windows.Forms.Panel> значение <xref:System.Windows.Forms.RightToLeft.Yes>.  
  
## <a name="mirroring"></a>Зеркальное отображение  
 *Зеркальным отображением* называется обращение размещения элементов пользовательского интерфейса так, чтобы они следовали справа налево. Например, в зеркальной форме Windows Forms кнопки "Свернуть", "Развернуть" и "Закрыть" отображаются в левом, а не в правом углу заголовка окна.  
  
 Задание для свойства <xref:System.Windows.Forms.Control.RightToLeft%2A> формы или элемента управления значения `true` обращает порядок чтения элементов в форме, но не обращает макет для отображения справа налево, то есть не приводит к зеркальному отображению. Например, задание этого свойства не перемещает кнопки **Свернуть**, **Развернуть** и **Закрыть** в заголовке окна в левую часть формы. Аналогично, некоторые элементы управления, такие как <xref:System.Windows.Forms.TreeView>, требуют зеркального отображения для соответствия арабскому языку или ивриту. Отразить эти элементы управления можно, задав свойство <xref:System.Windows.Forms.Form.RightToLeftLayout%2A>.  
  
 Можно создать отраженные версии следующих элементов управления:  
  
-   <xref:System.Windows.Forms.ColumnHeader.ListView%2A>  
  
-   <xref:System.Windows.Forms.Panel>  
  
-   <xref:System.Windows.Forms.StatusBar>  
  
-   <xref:System.Windows.Forms.TabControl>  
  
-   <xref:System.Windows.Forms.TabPage>  
  
-   <xref:System.Windows.Forms.ToolBar>  
  
-   <xref:System.Windows.Forms.TreeView>  
  
 Некоторые элементы управления запечатаны. Как следствие, из них нельзя наследовать новый элемент управления. К ним относятся элементы управления <xref:System.Windows.Forms.ImageList> и <xref:System.Windows.Forms.ProgressBar>.  
  
## <a name="see-also"></a>См. также

- [Двухсторонний режим для веб-приложений ASP.NET](https://docs.microsoft.com/previous-versions/aspnet/6eedwbtt(v=vs.100))
- [Глобализация приложений Windows Forms](globalizing-windows-forms.md)
