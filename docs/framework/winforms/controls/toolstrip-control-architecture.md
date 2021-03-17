---
title: Архитектура элемента управления ToolStrip
ms.date: 03/30/2017
helpviewer_keywords:
- ToolStrip control [Windows Forms], architecture
ms.assetid: 71df2d18-862e-4701-9ff9-c1fe606f94f2
ms.openlocfilehash: 91813928344f9210ce1383daa9ba7f765117833a
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59296216"
---
# <a name="toolstrip-control-architecture"></a>Архитектура элемента управления ToolStrip
<xref:System.Windows.Forms.ToolStrip> И <xref:System.Windows.Forms.ToolStripItem> классы предоставляют гибкую, расширяемую систему для отображения элементов панели инструментов, состояния и меню. Все эти классы содержатся в <xref:System.Windows.Forms> пространство имен и они обычно именуются с префиксом «ToolStrip» (такие как <xref:System.Windows.Forms.ToolStripOverflow>) или с суффиксом «Лента» (такие как <xref:System.Windows.Forms.MenuStrip>).  
  
## <a name="toolstrip"></a>ToolStrip  
 В следующих разделах описываются <xref:System.Windows.Forms.ToolStrip> и элементов управления, которые являются производными от него.  
  
 <xref:System.Windows.Forms.ToolStrip> является абстрактным базовым классом для <xref:System.Windows.Forms.MenuStrip>, <xref:System.Windows.Forms.StatusStrip>, и <xref:System.Windows.Forms.ContextMenuStrip>. Следующий объект модели показана <xref:System.Windows.Forms.ToolStrip> иерархии наследования.  
  
 ![Схема, показывающая модель объекта ToolStrip.](./media/toolstrip-control-architecture/toolstrip-object-model.gif)  
  
 Вы можете получить доступ к все элементы в <xref:System.Windows.Forms.ToolStrip> через <xref:System.Windows.Forms.ToolStrip.Items%2A> коллекции. Вы можете получить доступ к все элементы в <xref:System.Windows.Forms.ToolStripDropDownItem> через <xref:System.Windows.Forms.ToolStripDropDownItem.DropDownItems%2A> коллекции. В классе, производном от <xref:System.Windows.Forms.ToolStrip>, можно также использовать <xref:System.Windows.Forms.ToolStrip.DisplayedItems%2A> свойство для доступа к только элементы, отображаемые в данный момент. Ниже приведены элементы, которые в настоящее время не находятся в меню переполнения.  
  
 Следующие элементы специально предназначены для эффективной работы с обоими <xref:System.Windows.Forms.ToolStripSystemRenderer> и <xref:System.Windows.Forms.ToolStripProfessionalRenderer> во всех направлениях. Они доступны по умолчанию во время разработки для <xref:System.Windows.Forms.ToolStrip> управления:  
  
-   <xref:System.Windows.Forms.ToolStripButton>  
  
-   <xref:System.Windows.Forms.ToolStripSeparator>  
  
-   <xref:System.Windows.Forms.ToolStripLabel>  
  
-   <xref:System.Windows.Forms.ToolStripDropDownButton>  
  
-   <xref:System.Windows.Forms.ToolStripSplitButton>  
  
-   <xref:System.Windows.Forms.ToolStripTextBox>  
  
-   <xref:System.Windows.Forms.ToolStripComboBox>  
  
### <a name="menustrip"></a>MenuStrip  
 <xref:System.Windows.Forms.MenuStrip> является контейнером верхнего уровня, которое заменяет <xref:System.Windows.Forms.MainMenu>. Она также предоставляет управления ключами и несколько документов интерфейса (MDI) функции. С функциональной точки зрения <xref:System.Windows.Forms.ToolStripDropDownItem> и <xref:System.Windows.Forms.ToolStripMenuItem> работают вместе с <xref:System.Windows.Forms.MenuStrip>, несмотря на то, что они являются производными от <xref:System.Windows.Forms.ToolStripItem>.  
  
 Следующие элементы специально предназначены для эффективной работы с обоими <xref:System.Windows.Forms.ToolStripSystemRenderer> и <xref:System.Windows.Forms.ToolStripProfessionalRenderer> во всех направлениях. Они доступны по умолчанию во время разработки для <xref:System.Windows.Forms.MenuStrip> управления:  
  
-   <xref:System.Windows.Forms.ToolStripMenuItem>  
  
-   <xref:System.Windows.Forms.ToolStripTextBox>  
  
-   <xref:System.Windows.Forms.ToolStripComboBox>  
  
### <a name="statusstrip"></a>StatusStrip  
 <xref:System.Windows.Forms.StatusStrip> заменяет <xref:System.Windows.Forms.StatusBar> элемента управления. Специальные возможности <xref:System.Windows.Forms.StatusStrip> включают макет пользовательской таблицы, поддержка изменения размера и перемещения захватов, формы и `Spring` свойство, которое позволяет <xref:System.Windows.Forms.ToolStripStatusLabel> для автоматического заполнения доступного пространства.  
  
 Следующие элементы специально предназначены для эффективной работы с обоими <xref:System.Windows.Forms.ToolStripSystemRenderer> и <xref:System.Windows.Forms.ToolStripProfessionalRenderer> во всех направлениях. Они доступны по умолчанию во время разработки для <xref:System.Windows.Forms.StatusStrip> управления:  
  
-   <xref:System.Windows.Forms.ToolStripStatusLabel>  
  
-   <xref:System.Windows.Forms.ToolStripDropDownButton>  
  
-   <xref:System.Windows.Forms.ToolStripSplitButton>  
  
-   <xref:System.Windows.Forms.ToolStripProgressBar>  
  
### <a name="contextmenustrip"></a>ContextMenuStrip  
 <xref:System.Windows.Forms.ContextMenuStrip> заменяет <xref:System.Windows.Forms.ContextMenu>. Можно связать <xref:System.Windows.Forms.ContextMenuStrip> с любым элементом управления и правой кнопкой мыши щелкните автоматически отображает контекстное меню (или контекстное меню). Вы можете отобразить <xref:System.Windows.Forms.ContextMenuStrip> программно с помощью <xref:System.Windows.Forms.ToolStripDropDown.Show%2A> метод. <xref:System.Windows.Forms.ContextMenuStrip> поддерживает отменяемого <xref:System.Windows.Forms.ToolStripDropDown.Opening> и <xref:System.Windows.Forms.ToolStripDropDown.Closing> событий для обработки динамического заполнения и ситуации с несколькими щелчками. <xref:System.Windows.Forms.ContextMenuStrip> поддерживает образы, состояние пометки элемента меню, текст, клавиши доступа, сочетания клавиш и вложенные меню.  
  
 Следующие элементы специально предназначены для эффективной работы с обоими <xref:System.Windows.Forms.ToolStripSystemRenderer> и <xref:System.Windows.Forms.ToolStripProfessionalRenderer> во всех направлениях. Они доступны по умолчанию во время разработки для <xref:System.Windows.Forms.ContextMenuStrip> управления:  
  
-   <xref:System.Windows.Forms.ToolStripMenuItem>  
  
-   <xref:System.Windows.Forms.ToolStripSeparator>  
  
-   <xref:System.Windows.Forms.ToolStripTextBox>  
  
-   <xref:System.Windows.Forms.ToolStripComboBox>  
  
### <a name="toolstrip-generic-features"></a>Функции универсального элемента управления ToolStrip  
 Ниже описываются возможности и поведение, являющиеся общими для <xref:System.Windows.Forms.ToolStrip> и производных элементов управления.  
  
#### <a name="painting"></a>Рисование  
 Пользовательская отрисовка можно сделать в <xref:System.Windows.Forms.ToolStrip> элементы управления несколькими способами. Как и для других элементов управления Windows Forms, <xref:System.Windows.Forms.ToolStrip> и <xref:System.Windows.Forms.ToolStripItem> обладают переопределяемыми `OnPaint` методы и `Paint` события. Как при обычном рисовании система координат определяется относительно клиентской области элемента управления; левый верхний угол элемента управления является 0, 0. `Paint` Событий и `OnPaint` метод <xref:System.Windows.Forms.ToolStripItem> ведут себя как другие события рисования элемента управления.  
  
 <xref:System.Windows.Forms.ToolStrip> Элементы управления также предоставляет более подробный доступ к отрисовке элементов и контейнера с помощью <xref:System.Windows.Forms.ToolStripRenderer> класс, обладающий переопределяемые методы рисования фона, фоновый цвет элемента, изображения элемента, стрелки элемента, текста элемента и границу <xref:System.Windows.Forms.ToolStrip>. Аргументы события для этих методов предоставляют ряд свойств, таких как прямоугольники, цвета и текстовых форматов, которые можно настраивать при необходимости.  
  
 Чтобы настроить несколько аспектов способ рисования элемента, обычно следует переопределить <xref:System.Windows.Forms.ToolStripRenderer>.  
  
 Если вы создаете новый элемент и хотите управлять всеми аспектами заливку, переопределить `OnPaint` метод. Изнутри `OnPaint`, можно использовать методы из <xref:System.Windows.Forms.ToolStripRenderer>.  
  
 По умолчанию <xref:System.Windows.Forms.ToolStrip> включена двойная буферизация преимуществами <xref:System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer> параметр.  
  
#### <a name="parenting"></a>Родительские связи  
 Концепция контейнеров владения и родительские связи более сложен в <xref:System.Windows.Forms.ToolStrip> чем элементы управления других контейнерных элементов управления Windows Forms. Это необходимо для поддержки динамических сценариев, таких как переполнение, совместное использование элементов раскрывающегося списка в нескольких <xref:System.Windows.Forms.ToolStrip> элементов и для поддержки создания <xref:System.Windows.Forms.ContextMenuStrip> из элемента управления.  
  
 В следующем списке описаны элементы, связанные с родительской и объясняет их использование.  
  
-   <xref:System.Windows.Forms.ToolStripDropDown.OwnerItem%2A> Получает элемент, который является источником раскрывающегося элемента. Это похоже на <xref:System.Windows.Forms.ContextMenuStrip.SourceControl%2A>, но вместо возвращения элемента управления, он возвращает <xref:System.Windows.Forms.ToolStripItem>.  
  
-   <xref:System.Windows.Forms.ContextMenuStrip.SourceControl%2A> Определяет, какой элемент управления является источником объекта <xref:System.Windows.Forms.ContextMenuStrip> при нескольких элементов управления одного и того же <xref:System.Windows.Forms.ContextMenuStrip>.  
  
-   <xref:System.Windows.Forms.ToolStripItem.GetCurrentParent%2A> метод доступа только для чтения к <xref:System.Windows.Forms.ToolStripItem.Parent%2A> свойство. Родительский элемент отличается от владельца, что родительский элемент обозначает возвращаемый текущим <xref:System.Windows.Forms.ToolStrip> в котором отображается элемент, который может быть в области переполнения.  
  
-   <xref:System.Windows.Forms.ToolStripItem.Owner%2A> Возвращает <xref:System.Windows.Forms.ToolStrip> коллекция элементов которого содержит текущий <xref:System.Windows.Forms.ToolStripItem>. Это лучший способ ссылаться <xref:System.Windows.Forms.ToolStrip.ImageList%2A> или другие свойства верхнего уровня <xref:System.Windows.Forms.ToolStrip> без написания специального кода для обработки переполнения.  
  
#### <a name="behavior-of-inherited-controls"></a>Поведение унаследованных элементов управления  
 Следующие элементы управления заблокированы, каждый раз, когда они используются в наследования:  
  
-   <xref:System.Windows.Forms.ToolStrip>  
  
-   <xref:System.Windows.Forms.MenuStrip>  
  
-   <xref:System.Windows.Forms.ContextMenuStrip>  
  
-   <xref:System.Windows.Forms.StatusStrip>  
  
-   <xref:System.Windows.Forms.ToolStripPanel> включающий панелей в <xref:System.Windows.Forms.ToolStripContainer> а также отдельные <xref:System.Windows.Forms.ToolStripPanel> элементов управления.  
  
 Например можно создайте новое приложение Windows Forms с помощью одного или нескольких элементов управления в списке выше. Задайте модификатор доступа одного или нескольких элементов управления к `public` или `protected`, а затем постройте проект. Добавить форму, которая наследуется из первой формы, а затем выберите наследуемого элемента управления. Элемент управления выглядит заблокированным, как в случае его модификатор доступа `private`.  
  
#### <a name="toolstripcontainer-support-of-inheritance"></a>Поддержка наследования элемента управления ToolStripContainer  
 <xref:System.Windows.Forms.ToolStripContainer> Элемент управления поддерживает ограниченные сценарии наследования, аналогичный приведенному ниже:  
  
1. Создайте новое приложение Windows Forms.  
  
2. Добавьте на форму элемент <xref:System.Windows.Forms.ToolStripContainer>.  
  
3. Задайте модификатор доступа для <xref:System.Windows.Forms.ToolStripContainer> для `public` или `protected`.  
  
4. Добавлять любые сочетания <xref:System.Windows.Forms.ToolStrip>, <xref:System.Windows.Forms.MenuStrip>, и <xref:System.Windows.Forms.ContextMenuStrip> элементы управления <xref:System.Windows.Forms.ToolStripPanel> областей <xref:System.Windows.Forms.ToolStripContainer>.  
  
5. Выполните построение проекта.  
  
6. Добавите форму, которая наследуется из первой формы.  
  
7. Выберите наследуемого <xref:System.Windows.Forms.ToolStripContainer> в форме.  
  
#### <a name="inherited-behavior-of-child-controls"></a>Унаследованное поведение дочерних элементов управления  
 После выполнения предыдущих шагов, наследуемых происходит следующее:  
  
-   В конструкторе элемента управления отображается со значком, унаследованные.  
  
-   <xref:System.Windows.Forms.ToolStripPanel> Элементы управления заблокированы; нельзя выбрать или изменить порядок их содержимое.  
  
-   Элементы можно добавить <xref:System.Windows.Forms.ToolStripContentPanel>, переместите элементы управления и сделать их дочерние элементы управления <xref:System.Windows.Forms.ToolStripContentPanel>.  
  
-   Изменения сохраняются после создания формы.  
  
    > [!NOTE]
    >  Удалите модификатор доступа из всех <xref:System.Windows.Forms.ToolStripPanel> элементов управления, которые являются частью <xref:System.Windows.Forms.ToolStripContainer>. Модификатор доступа для <xref:System.Windows.Forms.ToolStripContainer> управляет элемента управления целиком.  
  
#### <a name="partial-trust"></a>Частичное доверие  
 Ограничения `ToolStrip`разработана при частичном доверии, чтобы предотвратить случайный ввод личных сведений, которые могут быть использованы неавторизованными пользователями или службами. Ниже приведены защитные меры.  
  
-   `ToolStripDropDown` элементы управления требуют <xref:System.Security.Permissions.UIPermissionWindow.AllWindows> для отображения элементов в <xref:System.Windows.Forms.ToolStripControlHost>. Это относится к обоих встроенные элементы управления, такие как <xref:System.Windows.Forms.ToolStripTextBox>, <xref:System.Windows.Forms.ToolStripComboBox>, и <xref:System.Windows.Forms.ToolStripProgressBar> как хорошо созданным пользователем элементы управления. Если это требование не удовлетворяется, эти элементы не отображаются. Исключение не возникает.  
  
-   Установка <xref:System.Windows.Forms.ToolStripDropDown.AutoClose%2A> свойства `false` не разрешен и поддерживающий отмену <xref:System.Windows.Forms.ToolStripDropDown.Closing> событий параметр учитывается. Это делает невозможным введите более одного нажатия клавиш без отключения раскрывающегося элемента. Если это требование не удовлетворяется, такие элементы не отображаются. Исключение не возникает.  
  
-   Многие регистрации нажатия клавиш, обработка событий не будет вызываться, если они встречаются в контексте с частичным доверием, отличных от <xref:System.Security.Permissions.UIPermissionWindow.AllWindows>.  
  
-   Ключи доступа не обрабатываются, если <xref:System.Security.Permissions.UIPermissionWindow.AllWindows> не предоставляется.  
  
#### <a name="usage"></a>Использование  
 Следующие шаблоны использования иметь влияют на <xref:System.Windows.Forms.ToolStrip> макет, взаимодействие с клавиатурой и пользовательское поведение:  
  
-   Пришел в <xref:System.Windows.Forms.ToolStripPanel>  
  
     <xref:System.Windows.Forms.ToolStrip> Может быть перемещен в <xref:System.Windows.Forms.ToolStripPanel> и по горизонтали <xref:System.Windows.Forms.ToolStripPanel>s. `Dock` Свойство игнорируется и если <xref:System.Windows.Forms.ToolStrip.Stretch%2A> свойство `false`, размер <xref:System.Windows.Forms.ToolStrip> увеличивается по мере добавления элементов <xref:System.Windows.Forms.ToolStripPanel>. Как правило <xref:System.Windows.Forms.ToolStrip> не участвует в последовательности табуляции.  
  
-   Закрепленное  
  
     <xref:System.Windows.Forms.ToolStrip> Помещается на одной стороне контейнера в фиксированное положение, а его размер увеличивается по всему краю, к которой она закреплена. Как правило <xref:System.Windows.Forms.ToolStrip> не участвует в последовательности табуляции.  
  
-   Абсолютное положение  
  
     <xref:System.Windows.Forms.ToolStrip> — Как и другие элементы управления, в том, что он помещает <xref:System.Windows.Forms.Control.Location%2A> свойство, имеет фиксированный размер и обычно участвует в последовательности табуляции.  
  
#### <a name="keyboard-interaction"></a>Взаимодействие с клавиатурой  
  
##### <a name="access-keys"></a>Ключи доступа  
 Вместе с или после клавишу ALT, ключи доступа являются одним из способов активации элемента управления с помощью клавиатуры. <xref:System.Windows.Forms.ToolStrip> поддерживает оба явные и неявные комбинации клавиш. Явное определение использует символ амперсанда (&) перед буквой. Неявное определение использует алгоритм, который пытается найти соответствующий элемент на основе порядка символов в заданной `Text` свойство.  
  
##### <a name="shortcut-keys"></a>Сочетания клавиш  
 Сочетания клавиш, используемые <xref:System.Windows.Forms.MenuStrip> сочетанием <xref:System.Windows.Forms.Keys> перечисления (который не от заказа) для определения сочетания клавиш. Можно также использовать <xref:System.Windows.Forms.ToolStripMenuItem.ShortcutKeyDisplayString%2A> свойство для отображения сочетания клавиш только с текстом, например при отображении «Del» вместо «Удалить».  
  
##### <a name="navigation"></a>Навигация  
 Клавиша ALT активирует <xref:System.Windows.Forms.MenuStrip> , на которые указывают <xref:System.Windows.Forms.Form.MainMenuStrip%2A>. После этого сочетания клавиш CTRL + TAB переходит между <xref:System.Windows.Forms.ToolStrip> внутри элементов управления `ToolStripPanel`s. Клавиши TAB и клавиш со стрелками на цифровой клавиатуре переходить между элементами в <xref:System.Windows.Forms.ToolStrip>. Специальный алгоритм обрабатывает навигации в области переполнения. Выбирает пробел <xref:System.Windows.Forms.ToolStripButton>, <xref:System.Windows.Forms.ToolStripDropDownButton>, или <xref:System.Windows.Forms.ToolStripSplitButton>.  
  
##### <a name="focus-and-validation"></a>Фокус и проверки  
 При активации клавишей ALT, <xref:System.Windows.Forms.MenuStrip> или <xref:System.Windows.Forms.ToolStrip> обычно не переключает фокус от элемента управления, который в данный момент имеет фокус. Если имеется элемент управления, размещенные на <xref:System.Windows.Forms.MenuStrip> или раскрывающегося списка <xref:System.Windows.Forms.MenuStrip>, элемент управления получает фокус, когда пользователь нажимает клавишу TAB. В общем случае <xref:System.Windows.Forms.Control.GotFocus>, <xref:System.Windows.Forms.Control.LostFocus>, <xref:System.Windows.Forms.Control.Enter>, и <xref:System.Windows.Forms.Control.Leave> события <xref:System.Windows.Forms.MenuStrip> могут не вызываться при активации с помощью клавиатуры. В таких случаях используйте <xref:System.Windows.Forms.MenuStrip.MenuActivate> и <xref:System.Windows.Forms.MenuStrip.MenuDeactivate> события вместо этого.  
  
 По умолчанию <xref:System.Windows.Forms.ToolStrip.CausesValidation%2A> является `false`. Вызовите <xref:System.Windows.Forms.ContainerControl.Validate%2A> явным образом в форме для выполнения проверки.  
  
#### <a name="layout"></a>Макет  
 Вы управляете <xref:System.Windows.Forms.ToolStrip> макет, выбрав один из членов <xref:System.Windows.Forms.ToolStripLayoutStyle> с <xref:System.Windows.Forms.ToolStrip.LayoutStyle%2A> свойство.  
  
##### <a name="stack-layouts"></a>Размещение в стопку  
 Размещение в стопку — это расположение элементов рядом друг с другом на обоих концах <xref:System.Windows.Forms.ToolStrip>. Ниже перечислены макеты стека.  
  
-   <xref:System.Windows.Forms.ToolStripLayoutStyle.StackWithOverflow> значение по умолчанию. Этот параметр задан, то <xref:System.Windows.Forms.ToolStrip> к изменению макета автоматически в соответствии с <xref:System.Windows.Forms.ToolStrip.Orientation%2A> свойства для обработки скриптов перетаскивания и закрепления.  
  
-   <xref:System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow> Выполняет визуализацию <xref:System.Windows.Forms.ToolStrip> элементы рядом друг с другом по вертикали.  
  
-   <xref:System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow> Выполняет визуализацию <xref:System.Windows.Forms.ToolStrip> элементы рядом друг с другом по горизонтали.  
  
##### <a name="other-features-of-stack-layouts"></a>Другие функции размещения в стопку  
 <xref:System.Windows.Forms.ToolStripItem.Alignment%2A> Определяет конец <xref:System.Windows.Forms.ToolStrip> выравнивание элемента.  
  
 Если элементы не соответствуют размерам <xref:System.Windows.Forms.ToolStrip>, автоматически отображается кнопка переполнения. <xref:System.Windows.Forms.ToolStripItem.Overflow%2A> Параметр свойства определяет, отображается ли элемент в области переполнения при необходимости или никогда.  
  
 В <xref:System.Windows.Forms.ToolStrip.LayoutCompleted> событий, вы можете проверить <xref:System.Windows.Forms.ToolStripItem.Placement%2A> свойства, чтобы определить, был ли элемент расположен в основном <xref:System.Windows.Forms.ToolStrip>, переполнение <xref:System.Windows.Forms.ToolStrip>, или если она не отображается в данный момент вообще. Типичные причины, почему не отображается элемент, что он не помещается в основном <xref:System.Windows.Forms.ToolStrip> и его <xref:System.Windows.Forms.ToolStripItem.Overflow%2A> было установлено на <xref:System.Windows.Forms.ToolStripItemOverflow.Never>.  
  
 Сделать <xref:System.Windows.Forms.ToolStrip> подвижной, поместив ее в <xref:System.Windows.Forms.ToolStripPanel> и установив его <xref:System.Windows.Forms.ToolStrip.GripStyle%2A> для <xref:System.Windows.Forms.ToolStripGripStyle.Visible>.  
  
##### <a name="other-layout-options"></a>Другие параметры макета  
 Параметры макета, являются <xref:System.Windows.Forms.ToolStripLayoutStyle.Flow> и <xref:System.Windows.Forms.ToolStripLayoutStyle.Table>.  
  
##### <a name="flow-layout"></a>Потоковый макет  
 <xref:System.Windows.Forms.ToolStripLayoutStyle.Flow> макет по умолчанию для <xref:System.Windows.Forms.ContextMenuStrip>, <xref:System.Windows.Forms.ToolStripDropDownMenu>, и <xref:System.Windows.Forms.ToolStripOverflow>. Это похоже на <xref:System.Windows.Forms.FlowLayoutPanel>. Возможности <xref:System.Windows.Forms.ToolStripLayoutStyle.Flow> макета, следующим образом:  
  
-   Все функции <xref:System.Windows.Forms.FlowLayoutPanel> предоставляемых <xref:System.Windows.Forms.ToolStrip.LayoutSettings%2A> свойство. Необходимо привести <xref:System.Windows.Forms.LayoutSettings> класс <xref:System.Windows.Forms.FlowLayoutSettings> класса.  
  
-   Можно использовать <xref:System.Windows.Forms.ToolStripItem.Dock%2A> и <xref:System.Windows.Forms.ToolStripItem.Anchor%2A> свойства в коде для выравнивания элементов в строке.  
  
-   Свойство <xref:System.Windows.Forms.ToolStripItem.Alignment%2A> не учитывается.  
  
-   В <xref:System.Windows.Forms.ToolStrip.LayoutCompleted> событий, вы можете проверить <xref:System.Windows.Forms.ToolStripItem.Placement%2A> свойства, чтобы определить, был ли элемент расположен в основном <xref:System.Windows.Forms.ToolStrip> или не поместились.  
  
-   Захват не отображается и поэтому <xref:System.Windows.Forms.ToolStrip> в <xref:System.Windows.Forms.ToolStripLayoutStyle.Flow> стиль макета в <xref:System.Windows.Forms.ToolStripPanel> нельзя переместить.  
  
-   <xref:System.Windows.Forms.ToolStrip> Не отображается кнопка переполнения, и <xref:System.Windows.Forms.ToolStripItem.Overflow%2A> учитывается.  
  
##### <a name="table-layout"></a>Табличный макет  
 <xref:System.Windows.Forms.ToolStripLayoutStyle.Table> макет по умолчанию для <xref:System.Windows.Forms.StatusStrip>. Это похоже на <xref:System.Windows.Forms.TableLayoutPanel>. Возможности <xref:System.Windows.Forms.ToolStripLayoutStyle.Flow> макета, следующим образом:  
  
-   Все функции <xref:System.Windows.Forms.TableLayoutPanel> предоставляемых <xref:System.Windows.Forms.ToolStrip.LayoutSettings%2A> свойство. Необходимо привести <xref:System.Windows.Forms.LayoutSettings> класс <xref:System.Windows.Forms.TableLayoutSettings> класса.  
  
-   Можно использовать <xref:System.Windows.Forms.ToolStripItem.Dock%2A> и <xref:System.Windows.Forms.ToolStripItem.Anchor%2A> свойства в коде для выравнивания элементов в пределах ячейки таблицы.  
  
-   Свойство <xref:System.Windows.Forms.ToolStripItem.Alignment%2A> не учитывается.  
  
-   В <xref:System.Windows.Forms.ToolStrip.LayoutCompleted> событий, вы можете проверить <xref:System.Windows.Forms.ToolStripItem.Placement%2A> свойства, чтобы определить, был ли элемент расположен в основном <xref:System.Windows.Forms.ToolStrip> или не поместились.  
  
-   Захват не отображается и поэтому <xref:System.Windows.Forms.ToolStrip> в <xref:System.Windows.Forms.ToolStripLayoutStyle.Table> стиль макета в <xref:System.Windows.Forms.ToolStripPanel> нельзя переместить.  
  
-   <xref:System.Windows.Forms.ToolStrip> Не отображается кнопка переполнения, и <xref:System.Windows.Forms.ToolStripItem.Overflow%2A> учитывается.  
  
## <a name="toolstripitem"></a>ToolStripItem  
 В следующих разделах описываются <xref:System.Windows.Forms.ToolStripItem> и элементов управления, которые являются производными от него.  
  
 <xref:System.Windows.Forms.ToolStripItem> — Абстрактный базовый класс для всех элементов, входящих в <xref:System.Windows.Forms.ToolStrip>. Следующий объект модели показана <xref:System.Windows.Forms.ToolStripItem> иерархии наследования.  
  
 ![Схема, показывающая модель объекта ToolStripItem.](./media/toolstrip-control-architecture/toolstripitem-object-model.gif)  
  
 <xref:System.Windows.Forms.ToolStripItem> классы, которые наследуются непосредственно из <xref:System.Windows.Forms.ToolStripItem>, или они неявно наследуют от <xref:System.Windows.Forms.ToolStripItem> через <xref:System.Windows.Forms.ToolStripControlHost> или <xref:System.Windows.Forms.ToolStripDropDownItem>.  
  
 <xref:System.Windows.Forms.ToolStripItem> элементы управления должны размещаться в <xref:System.Windows.Forms.ToolStrip>, <xref:System.Windows.Forms.MenuStrip>, <xref:System.Windows.Forms.StatusStrip>, или <xref:System.Windows.Forms.ContextMenuStrip> и не может быть добавлен непосредственно в форму. Различные классы контейнеров предназначены для размещения соответствующего подмножества <xref:System.Windows.Forms.ToolStripItem> элементов управления.  
  
 В следующей таблице перечислены акции <xref:System.Windows.Forms.ToolStripItem> элементы управления и контейнеры, в которых они лучше всего выглядят. Хотя любой <xref:System.Windows.Forms.ToolStrip> элемент можно разместить в любом <xref:System.Windows.Forms.ToolStrip>-контейнере, производном эти элементы были разработаны для поиска рекомендации в следующих контейнерах:  
  
> [!NOTE]
>  <xref:System.Windows.Forms.ToolStripDropDown> не отображается в области элементов конструктора.  
  
|Элемент в контейнере|ToolStrip|MenuStrip|ContextMenuStrip|StatusStrip|ToolStripDropDown|  
|--------------------|---------------|---------------|----------------------|-----------------|-----------------------|  
|<xref:System.Windows.Forms.ToolStripButton>|Да|Нет|Нет|Нет|Да|  
|<xref:System.Windows.Forms.ToolStripComboBox>|Да|Да|Да|Нет|Да|  
|<xref:System.Windows.Forms.ToolStripSplitButton>|Да|Нет|Нет|Да|Да|  
|<xref:System.Windows.Forms.ToolStripLabel>|Да|Нет|Нет|Да|Да|  
|<xref:System.Windows.Forms.ToolStripSeparator>|Да|Да|Да|Нет|Да|  
|<xref:System.Windows.Forms.ToolStripDropDownButton>|Да|Нет|Нет|Да|Да|  
|<xref:System.Windows.Forms.ToolStripTextBox>|Да|Да|Да|Нет|Да|  
|<xref:System.Windows.Forms.ToolStripMenuItem>|Нет|Да|Да|Нет|Нет|  
|<xref:System.Windows.Forms.ToolStripStatusLabel>|Нет|Нет|Нет|Да|Нет|  
|<xref:System.Windows.Forms.ToolStripProgressBar>|Да|Нет|Нет|Да|Нет|  
|<xref:System.Windows.Forms.ToolStripControlHost>|Да|Да|Нет|Да|Да|  
  
### <a name="toolstripbutton"></a>ToolStripButton  
 <xref:System.Windows.Forms.ToolStripButton> элемент кнопки для <xref:System.Windows.Forms.ToolStrip>. Можно отобразить его с различными стилями границы, и его можно использовать для представления и активировать операционные состояния. Можно также определить, оно должно иметь фокус по умолчанию.  
  
### <a name="toolstriplabel"></a>ToolStripLabel  
 <xref:System.Windows.Forms.ToolStripLabel> Предоставляет функциональные возможности метки в <xref:System.Windows.Forms.ToolStrip> элементов управления. <xref:System.Windows.Forms.ToolStripLabel> Аналогичен <xref:System.Windows.Forms.ToolStripButton> , не получает фокус по умолчанию и не отображается в нажатом или выделенном.  
  
 <xref:System.Windows.Forms.ToolStripLabel> в качестве размещенный элемент поддерживает ключи доступа.  
  
 Используйте <xref:System.Windows.Forms.LinkLabel.LinkColor%2A>, <xref:System.Windows.Forms.LinkLabel.LinkVisited%2A>, и <xref:System.Windows.Forms.LinkLabel.LinkBehavior%2A> свойства <xref:System.Windows.Forms.ToolStripLabel> для поддержки элемента управления ссылки в <xref:System.Windows.Forms.ToolStrip>.  
  
### <a name="toolstripstatuslabel"></a>ToolStripStatusLabel  
 <xref:System.Windows.Forms.ToolStripStatusLabel> — Это версия <xref:System.Windows.Forms.ToolStripLabel> разработан специально для использования в <xref:System.Windows.Forms.StatusStrip>. Число специальных функций входят <xref:System.Windows.Forms.ToolStripStatusLabel.BorderStyle%2A>, <xref:System.Windows.Forms.ToolStripStatusLabel.BorderSides%2A>, и <xref:System.Windows.Forms.ToolStripStatusLabel.Spring%2A>.  
  
### <a name="toolstripseparator"></a>ToolStripSeparator  
 <xref:System.Windows.Forms.ToolStripSeparator> Добавляет вертикальной или горизонтальной линией, панели инструментов или меню, в зависимости от ориентации. Он предоставляет, группирование или разделение элементов, например пунктов меню.  
  
 Вы можете добавить <xref:System.Windows.Forms.ToolStripSeparator> во время разработки, выбрав его из раскрывающегося списка. Тем не менее, можно автоматически создать <xref:System.Windows.Forms.ToolStripSeparator> , введя дефис (-) в узле шаблона конструктора или в <xref:System.Windows.Forms.ToolStripItemCollection.Add%2A> метод.  
  
### <a name="toolstripcontrolhost"></a>Руководство.  
 <xref:System.Windows.Forms.ToolStripControlHost> является абстрактным базовым классом для <xref:System.Windows.Forms.ToolStripComboBox>, <xref:System.Windows.Forms.ToolStripTextBox>, и <xref:System.Windows.Forms.ToolStripProgressBar>. <xref:System.Windows.Forms.ToolStripControlHost> можно размещать другие элементы управления, включая пользовательские элементы управления, двумя способами:  
  
-   Создать <xref:System.Windows.Forms.ToolStripControlHost> с классом, который является производным от <xref:System.Windows.Forms.Control>. Для полного доступа к размещенным элементом управления и свойства, необходимо привести <xref:System.Windows.Forms.ToolStripControlHost.Control%2A> свойство обратно к реальному класса, он представляет.  
  
-   Расширить <xref:System.Windows.Forms.ToolStripControlHost>и в конструктор по умолчанию наследуемого класса, вызывает конструктор базового класса, передав класс, производный от <xref:System.Windows.Forms.Control>. Этот параметр позволяет включить общие методы управления и свойства для быстрого доступа в <xref:System.Windows.Forms.ToolStrip>.  
  
### <a name="toolstripcombobox"></a>ToolStripComboBox  
 <xref:System.Windows.Forms.ToolStripComboBox> — <xref:System.Windows.Forms.ComboBox> оптимизированная для размещения в <xref:System.Windows.Forms.ToolStrip>. Подмножество свойств размещаемого элемента управления и события представлены на <xref:System.Windows.Forms.ToolStripComboBox> уровень, но базовый <xref:System.Windows.Forms.ComboBox> управления полностью доступен через <xref:System.Windows.Forms.ToolStripComboBox.ComboBox%2A> свойство.  
  
### <a name="toolstriptextbox"></a>ToolStripTextBox пространства  
 <xref:System.Windows.Forms.ToolStripTextBox> — <xref:System.Windows.Forms.TextBox> оптимизированная для размещения в <xref:System.Windows.Forms.ToolStrip>. Подмножество свойств размещаемого элемента управления и события представлены на <xref:System.Windows.Forms.ToolStripTextBox> уровень, но базовый <xref:System.Windows.Forms.TextBox> управления полностью доступен через <xref:System.Windows.Forms.ToolStripTextBox.TextBox%2A> свойство.  
  
### <a name="toolstripprogressbar"></a>ToolStripProgressBar  
 <xref:System.Windows.Forms.ToolStripProgressBar> — <xref:System.Windows.Forms.ProgressBar> оптимизированная для размещения в <xref:System.Windows.Forms.ToolStrip>. Подмножество свойств размещаемого элемента управления и события представлены на <xref:System.Windows.Forms.ToolStripProgressBar> уровень, но базовый <xref:System.Windows.Forms.ProgressBar> управления полностью доступен через <xref:System.Windows.Forms.ToolStripProgressBar.ProgressBar%2A> свойство.  
  
### <a name="toolstripdropdownitem"></a>ToolStripDropDownItem  
 <xref:System.Windows.Forms.ToolStripDropDownItem> является абстрактным базовым классом для <xref:System.Windows.Forms.ToolStripMenuItem>, <xref:System.Windows.Forms.ToolStripDropDownButton>, и <xref:System.Windows.Forms.ToolStripSplitButton>, который можно разместить элементы непосредственно или узла дополнительные элементы в контейнере раскрывающегося списка. Это можно сделать, задав <xref:System.Windows.Forms.ToolStripDropDownItem.DropDown%2A> свойства <xref:System.Windows.Forms.ToolStripDropDown> и параметр <xref:System.Windows.Forms.ToolStrip.Items%2A> свойство <xref:System.Windows.Forms.ToolStripDropDown>. Доступ к этим напрямую с помощью раскрывающегося списка элементам <xref:System.Windows.Forms.ToolStripDropDownItem.DropDownItems%2A> свойство.  
  
### <a name="toolstripmenuitem"></a>ToolStripMenuItem  
 <xref:System.Windows.Forms.ToolStripMenuItem> — <xref:System.Windows.Forms.ToolStripDropDownItem> , работающее с <xref:System.Windows.Forms.ToolStripDropDownMenu> и <xref:System.Windows.Forms.ContextMenuStrip> для обработки специальных выделение, макета и расположения столбцов для меню.  
  
### <a name="toolstripdropdownbutton"></a>ToolStripDropDownButton  
 <xref:System.Windows.Forms.ToolStripDropDownButton> как выглядит <xref:System.Windows.Forms.ToolStripButton>, но он показывает раскрывающейся области, когда пользователь щелкает его. Скрыть или отобразить стрелку раскрывающегося списка, задав <xref:System.Windows.Forms.ToolStripDropDownButton.ShowDropDownArrow%2A> свойство. <xref:System.Windows.Forms.ToolStripDropDownButton> Узлы <xref:System.Windows.Forms.ToolStripOverflowButton> , отображающий элементы, которые вызывают переполнение <xref:System.Windows.Forms.ToolStrip>.  
  
### <a name="toolstripsplitbutton"></a>ToolStripSplitButton  
 <xref:System.Windows.Forms.ToolStripSplitButton> объединяет кнопку и кнопку раскрывающегося списка функциональные возможности.  
  
 Используйте <xref:System.Windows.Forms.ToolStripSplitButton.DefaultItem%2A> свойство для синхронизации <xref:System.Windows.Forms.Control.Click> событие выбранный элемент списка с элемента, отображаемое на кнопке.  
  
### <a name="toolstripitem-generic-features"></a>Функции универсальный элемент ToolStripItem  
 <xref:System.Windows.Forms.ToolStripItem> предоставляет следующие общие возможности и параметры для наследуемые элементы управления:  
  
-   Основные события  
  
-   Обработки изображений  
  
-   Выравнивание  
  
-   Связь текста и изображений  
  
-   Стиль отображения  
  
#### <a name="core-events"></a>Основные события  
 <xref:System.Windows.Forms.ToolStripItem> элементы управления получают свои собственные нажмите кнопку мыши и события paint и можно выполнить предварительную обработку также клавиатуры.  
  
#### <a name="image-handling"></a>Обработки изображений  
 <xref:System.Windows.Forms.ToolStripItem.Image%2A>, <xref:System.Windows.Forms.ToolStripItem.ImageAlign%2A>, <xref:System.Windows.Forms.ToolStripItem.ImageIndex%2A>, <xref:System.Windows.Forms.ToolStripItem.ImageKey%2A>, И <xref:System.Windows.Forms.ToolStripItem.ImageScaling%2A> свойства относятся к различным функциям обработки изображений. Использование изображений в <xref:System.Windows.Forms.ToolStrip> элементов управления с такими значениями этих свойств напрямую или задав выполнения — только во время <xref:System.Windows.Forms.ToolStrip.ImageList%2A> свойство.  
  
 Масштабирование определяется взаимодействие свойств в <xref:System.Windows.Forms.ToolStrip> и <xref:System.Windows.Forms.ToolStripItem>, как показано ниже:  
  
-   <xref:System.Windows.Forms.ToolStrip.ImageScalingSize%2A> Масштаб конечного изображения определяется сочетанием изображения <xref:System.Windows.Forms.ToolStripItem.ImageScaling%2A> и параметра контейнера <xref:System.Windows.Forms.ToolStrip.AutoSize%2A> параметр.  
  
    -   Если <xref:System.Windows.Forms.ToolStrip.AutoSize%2A> — `true` (по умолчанию) и <xref:System.Windows.Forms.ToolStripItemImageScaling> — <xref:System.Windows.Forms.ToolStripItemImageScaling.SizeToFit>, происходит без масштабирования изображения и <xref:System.Windows.Forms.ToolStrip> является размер самого большого элемента или предписанный минимальный размер.  
  
    -   Если <xref:System.Windows.Forms.ToolStrip.AutoSize%2A> — `false` и <xref:System.Windows.Forms.ToolStripItemImageScaling> — <xref:System.Windows.Forms.ToolStripItemImageScaling.None>, ни изображения, ни <xref:System.Windows.Forms.ToolStrip> масштабирование происходит.  
  
#### <a name="alignment"></a>Выравнивание  
 Значение <xref:System.Windows.Forms.ToolStripItem.Alignment%2A> свойство определяет конец <xref:System.Windows.Forms.ToolStrip> в которой появляется элемент. <xref:System.Windows.Forms.ToolStripItem.Alignment%2A> Работает только тогда, когда свойство стиля макета <xref:System.Windows.Forms.ToolStrip> присваивается одно из значений переполнения стека.  
  
 Элементы размещаются на <xref:System.Windows.Forms.ToolStrip> в порядке, в котором элементы отображаются в коллекции элементов. Чтобы программно изменить, где располагается элемент, используйте <xref:System.Windows.Forms.ToolStripItemCollection.Insert%2A> метод, чтобы переместить элемент в коллекции. Этот метод перемещает элемент, но не является его копией.  
  
#### <a name="text-and-image-relationship"></a>Текст и изображение связи  
 <xref:System.Windows.Forms.ToolStripItem.TextImageRelation%2A> Свойство определяет относительное расположение изображения относительно текста на <xref:System.Windows.Forms.ToolStripItem>. Элементы, в которых отсутствует изображение и текст, рассматриваются как особые случаи, чтобы <xref:System.Windows.Forms.ToolStripItem> не отображает пустую область на месте отсутствует один или несколько элементов.  
  
#### <a name="display-style"></a>Стиль отображения  
 <xref:System.Windows.Forms.ToolStripItem.DisplayStyle%2A> позволяет задать значения свойств элемента текста и изображения при отображении только то, что нужно. Обычно это используется для изменения только стиль отображения при отображении и тот же элемент в другом контексте.  
  
## <a name="accessory-classes"></a>Вспомогательные классы  
 Классы, которые предоставляют различные дополнительные функциональные возможности:  
  
-   <xref:System.Windows.Forms.ToolStripManager> поддерживает <xref:System.Windows.Forms.ToolStrip>-связанные задачи для всего приложения, такие как слияние, параметры и модуль подготовки отчетов.  
  
-   <xref:System.Windows.Forms.ToolStripRenderer> позволяет применить определенный стиль или тему <xref:System.Windows.Forms.ToolStrip> легко.  
  
-   <xref:System.Windows.Forms.ToolStripProfessionalRenderer> создает перья и кисти, на основе таблицы можно заменить цвета (<xref:System.Windows.Forms.ProfessionalColorTable>).  
  
-   <xref:System.Windows.Forms.ToolStripSystemRenderer> применяет системных цветов и плоского визуального стиля для <xref:System.Windows.Forms.ToolStrip> приложений.  
  
-   <xref:System.Windows.Forms.ToolStripContainer> аналогичен <xref:System.Windows.Forms.SplitContainer>. Она использует четыре закрепленные боковые панели (экземпляры <xref:System.Windows.Forms.ToolStripPanel>) и одна центральная панель (экземпляр <xref:System.Windows.Forms.ToolStripContentPanel>) для создания типового расположения. Не удается удалить на боковой панели, но их можно скрыть. Можно удалить ни скрыть центральную панель. Можно упорядочить один или несколько <xref:System.Windows.Forms.ToolStrip>, <xref:System.Windows.Forms.MenuStrip>, или <xref:System.Windows.Forms.StatusStrip> элементов управления в на боковой панели, а также можно использовать центральную панель для других элементов управления. <xref:System.Windows.Forms.ToolStripContentPanel> Также предоставляет способ для получения поддержки модуля подготовки отчетов в текст формы для согласованного внешнего вида. <xref:System.Windows.Forms.ToolStripContainer> не поддерживает многодокументного интерфейса (MDI).  
  
-   <xref:System.Windows.Forms.ToolStripPanel> Предоставляет место для перемещения и расположения <xref:System.Windows.Forms.ToolStrip> элементов управления. Если это необходимо, можно использовать только одну панель и <xref:System.Windows.Forms.ToolStripPanel> хорошо работает в сценариях MDI.  
  
## <a name="see-also"></a>См. также

- [Общие сведения об элементе управления ToolStrip](toolstrip-control-overview-windows-forms.md)
- [Технологии, положенные в основу работы элемента управления ToolStrip](toolstrip-technology-summary.md)
- [Элемент управления ToolStrip](toolstrip-control-windows-forms.md)
- [Элемент управления MenuStrip](menustrip-control-windows-forms.md)
- [Элемент управления StatusStrip](statusstrip-control.md)
- [Элемент управления ContextMenuStrip](contextmenustrip-control.md)
- [BindingNavigator — элемент управления](bindingnavigator-control-windows-forms.md)
