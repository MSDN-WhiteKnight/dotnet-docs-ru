---
title: Создание собственных элементов управления
ms.date: 03/30/2017
helpviewer_keywords:
- controls [Windows Forms], user controls
- controls [Windows Forms], types of
- composite controls [Windows Forms]
- extended controls [Windows Forms]
- controls [Windows Forms], extended
- user controls [Windows Forms]
- custom controls [Windows Forms]
- controls [Windows Forms], composite
ms.assetid: 3cea09e5-4344-4ccb-9858-b66ccac210ff
ms.openlocfilehash: 765befcf88247e4b2101b13c4937352ba4b070fa
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59170711"
---
# <a name="varieties-of-custom-controls"></a>Создание собственных элементов управления
Платформа .NET Framework предоставляет возможности разработки и реализации новых элементов управления. С ее помощью можно расширить функциональные возможности привычных пользовательских элементов управления, а также уже существующих элементов управления через наследование. Кроме того, она позволяет писать настраиваемые элементы управления с собственной отрисовкой.  
  
 Выбор типа создаваемого элемента управления может быть затруднителен. В этом разделе описываются различия между типами элементов управления, которые можно использовать для наследования, и рассказывается, как выбрать тип элемента управления для конкретного проекта.  
  
> [!NOTE]
>  Дополнительные сведения о создании элемента управления для использования в Web Forms см. в разделе [Разработка пользовательских серверных элементов управления ASP.NET](https://docs.microsoft.com/previous-versions/aspnet/zt27tfhy(v=vs.100)).  
  
## <a name="base-control-class"></a>Базовый класс элемента управления  
 <xref:System.Windows.Forms.Control> Класс является базовым классом для элементов управления Windows Forms. Он обеспечивает инфраструктуру, необходимую для визуального отображения элементов управления в приложениях Windows Forms.  
  
 <xref:System.Windows.Forms.Control> Класс выполняет следующие задачи для обеспечения визуального отображения в приложениях Windows Forms:  
  
-   Обеспечивает обработку окон.  
  
-   Управляет маршрутизацией сообщений.  
  
-   Предоставляет события мыши и клавиатуры, а также многие другие события пользовательского интерфейса.  
  
-   Предоставляет расширенные функции размещения.  
  
-   Содержит многие свойства, связанные с визуальным отображением, такие как <xref:System.Windows.Forms.Control.ForeColor%2A>, <xref:System.Windows.Forms.Control.BackColor%2A>, <xref:System.Windows.Forms.Control.Height%2A>, и <xref:System.Windows.Forms.Control.Width%2A>.  
  
-   Обеспечивает безопасность и поддержку потоков, необходимые для того, чтобы элемент управления Windows Forms действовал как элемент управления Microsoft® ActiveX®.  
  
 Поскольку существенная часть инфраструктуры предоставляется базовым классом, разрабатывать собственные элементы управления Windows Forms довольно просто.  
  
## <a name="kinds-of-controls"></a>Типы элементов управления  
 Windows Forms поддерживает три типа элементов управления, определяемых пользователем: *составные*, *расширенные* и *настраиваемые*. В следующих разделах описывается каждый тип элемента управления и приводятся рекомендации по выбору типа для использования в проектах.  
  
### <a name="composite-controls"></a>Составные элементы управления  
 Составной элемент управления — это коллекция элементов управления Windows Forms, инкапсулированных в общий контейнер. Этот тип элементов управления иногда называют *пользовательским элементом управления*. Элементы, входящие в составной элемент управления, называются *составляющими*.  
  
 Составной элементе управления содержит все унаследованные функциональные возможности, связанные с каждым входящим в него элементом управления Windows Forms, и позволяет выборочно представлять и связывать их свойства. Кроме того, составной элемент управления предоставляет немало функций для обработки событий клавиатуры по умолчанию, не требуя дополнительной разработки с вашей стороны.  
  
 Например, составной элемент управления можно собрать таким образом, чтобы он отображал данные адреса клиента из базы данных. Этот элемент управления может включать <xref:System.Windows.Forms.DataGridView> управления для отображения полей базы данных, <xref:System.Windows.Forms.BindingSource> для обработки привязки к источнику данных и <xref:System.Windows.Forms.BindingNavigator> элемент управления для перемещения по записям. Вы можете выборочно предоставить свойства привязки данных, а также упаковать и повторно использовать весь элемент управления в других приложениях. Пример такого рода составного элемента управления, см. в разделе [как: Применение атрибутов в элементах управления Windows Forms](how-to-apply-attributes-in-windows-forms-controls.md).  
  
 Создание составного элемента управления, являются производными от <xref:System.Windows.Forms.UserControl> класса. <xref:System.Windows.Forms.UserControl> Базовый класс обеспечивает маршрутизацию клавиатуры для дочерних элементов управления и позволяет им работать сообща. Дополнительные сведения см. в разделе [Разработка составного элемента Windows Forms](developing-a-composite-windows-forms-control.md).  
  
 **Рекомендация**  
  
 Наследование класса <xref:System.Windows.Forms.UserControl> имеет смысл в следующих случаях:  
  
-   — если нужно объединить функциональные возможности нескольких элементов управления Windows Forms в один блок для повторного использования.  
  
### <a name="extended-controls"></a>Расширенные элементы управления  
 Элемент управления можно унаследовать от любого существующего элемента управления Windows Forms. Такой подход позволяет сохранить все функциональные возможности, унаследованные от элемента управления Windows Forms, и расширить их путем добавления пользовательских свойств, методов или других функций. С помощью этого параметра можно переопределить логику отрисовки базового элемента управления, а затем расширить его пользовательский интерфейс, изменив его внешний вид.  
  
 Например, можно создать элемент управления, производный от <xref:System.Windows.Forms.Button> она щелкнул элемент управления, который отслеживает, сколько раз пользователь.  
  
 В некоторых элементах графический пользовательский интерфейс элемента управления можно добавить пользовательское оформление путем переопределения <xref:System.Windows.Forms.Control.OnPaint%2A> метод базового класса. Кнопку, отслеживающую число нажатий, можно переопределить <xref:System.Windows.Forms.Control.OnPaint%2A> метод вызывать базовую реализацию <xref:System.Windows.Forms.Control.OnPaint%2A>, а затем отрисовать число нажатий в одном углу <xref:System.Windows.Forms.Button> клиентской области элемента управления.  
  
 **Рекомендация**  
  
 Наследование элементов управления Windows Forms имеет смысл в следующих случаях:  
  
-   — если большинство необходимых функций аналогичны функциям уже существующего элемента управления Windows Forms;  
  
-   — если нестандартный графический интерфейс не требуется или необходимо разработать новый интерфейс для существующего элемента управления.  
  
### <a name="custom-controls"></a>Пользовательские элементы управления  
 Другим способом разработки элемента управления является создание его практически с нуля путем наследования от <xref:System.Windows.Forms.Control>. <xref:System.Windows.Forms.Control> Класс обеспечивает всю основную функциональность, необходимую элементам управления, включая обработку событий, клавиатуры и мыши, но не функциональности элемента управления или графического интерфейса.  
  
 Создание элемента управления путем наследования от <xref:System.Windows.Forms.Control> класс требует гораздо больше внимания и усилий, чем наследование от <xref:System.Windows.Forms.UserControl> или существующего элемента управления Windows Forms. Поскольку значительную часть реализации вы выполняете сами, ваш элемент управления может быть более гибким, чем составной или расширенный, и вы можете его адаптировать к конкретным задачам.  
  
 Чтобы реализовать пользовательский элемент управления, необходимо написать код для <xref:System.Windows.Forms.Control.OnPaint%2A> событие элемента управления, а также любые определенные функции код, необходимый. Можно также переопределить <xref:System.Windows.Forms.Control.WndProc%2A> метод и обработать сообщения windows напрямую. Это самый эффективный способ создания элементов управления, однако для того, чтобы использовать его эффективно, необходимо знание API Microsoft Win32®.  
  
 Примером нестандартного элемента управления служит элемент управления "Часы", который выглядит и действует как часы со стрелками. Чтобы заставить стрелки часов двигаться в ответ на вызывается пользовательская отрисовка <xref:System.Windows.Forms.Timer.Tick> событий из внутреннего <xref:System.Windows.Forms.Timer> компонента. Дополнительные сведения см. в разделе [Как Разработка элемента управления форм Windows простой](how-to-develop-a-simple-windows-forms-control.md).  
  
 **Рекомендация**  
  
 Наследование класса <xref:System.Windows.Forms.Control> имеет смысл в следующих случаях:  
  
-   — если требуется создать пользовательское графическое представление элемента управления;  
  
-   — если требуется реализовать пользовательские функциональные возможности, которые недоступны в стандартных элементах управления.  
  
### <a name="activex-controls"></a>Элементы управления ActiveX  
 Несмотря на то что инфраструктура Windows Forms оптимизирована для размещения элементов управления Windows Forms, элементы управления ActiveX также можно использовать. Эта задача поддерживается в Visual Studio. Дополнительные сведения см. в разделе [Как Добавление элементов управления ActiveX в формы Windows Forms](how-to-add-activex-controls-to-windows-forms.md).  
  
### <a name="windowless-controls"></a>Элементы управления без окон  
 Технологии Microsoft Visual Basic® 6.0 и ActiveX поддерживают элементы управления *без окон*. В Windows Forms элементы управления без окон не поддерживаются.  
  
## <a name="custom-design-experience"></a>Пользовательская среда разработки  
 Если вам требуется пользовательская среда разработки, вы можете создать свой собственный конструктор. Для составных элементов управления, создайте производный пользовательский класс конструктора из <xref:System.Windows.Forms.Design.ParentControlDesigner> или <xref:System.Windows.Forms.Design.DocumentDesigner> классы. Для расширенных и настраиваемых элементов управления, создайте производный пользовательский класс конструктора из <xref:System.Windows.Forms.Design.ControlDesigner> класса.  
  
 Используйте <xref:System.ComponentModel.DesignerAttribute> должен быть сопоставлен конструктора элемента управления. Дополнительные сведения см. в разделе [расширение поддержки времени разработки](https://docs.microsoft.com/previous-versions/visualstudio/visual-studio-2013/37899azc(v=vs.120)) и [как: Создание элемента управления Windows Forms, используются преимущества функций разработки](https://docs.microsoft.com/previous-versions/visualstudio/visual-studio-2013/307hck25(v=vs.120)).  
  
## <a name="see-also"></a>См. также

- [Разработка пользовательских элементов управления Windows Forms в .NET Framework](developing-custom-windows-forms-controls.md)
- [Практическое руководство. Разработка простого элемента управления форм Windows Forms](how-to-develop-a-simple-windows-forms-control.md)
- [Разработка составного элемента Windows Forms](developing-a-composite-windows-forms-control.md)
- [Расширение поддержки времени разработки](https://docs.microsoft.com/previous-versions/visualstudio/visual-studio-2013/37899azc(v=vs.120))
- [Практическое руководство. Создание элемента управления Windows Forms, используются преимущества функций времени разработки](https://docs.microsoft.com/previous-versions/visualstudio/visual-studio-2013/307hck25(v=vs.120))
