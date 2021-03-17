---
title: Пошаговое руководство. Создание структуры элементов управления Windows Forms с помощью свойств Padding, Margins и AutoSize
ms.date: 03/30/2017
f1_keywords:
- Margin.Bottom
- Margin.Left
- Margin.Top
- Margin.All
- Margin.Right
helpviewer_keywords:
- Margin property [Windows Forms], walkthroughs
- walkthroughs [Windows Forms], layout
- AutoSize property [Windows Forms], walkthroughs
- Padding property [Windows Forms], walkthroughs
- layout [Windows Forms], margins and padding
- Windows Forms, layout
ms.assetid: f8ae2a6b-db13-4630-8e25-d104091205c7
ms.openlocfilehash: 230c7cb80ce6b8a29f7334ed0f8d297fd829faf9
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59302469"
---
# <a name="walkthrough-laying-out-windows-forms-controls-with-padding-margins-and-the-autosize-property"></a>Пошаговое руководство. Создание структуры элементов управления Windows Forms с помощью свойств Padding, Margins и AutoSize
Точное расположение элементов управления на форме является важным для многих приложений. **Конструктор Windows Forms** предоставляет множество средств форматирования для выполнения этой задачи. Три наиболее важными являются <xref:System.Windows.Forms.Control.Margin%2A>, <xref:System.Windows.Forms.Control.Padding%2A>, и <xref:System.Windows.Forms.Control.AutoSize%2A> свойства, которые присутствуют на все элементы управления Windows Forms.  
  
 Свойство <xref:System.Windows.Forms.Control.Margin%2A> определяет поле вокруг элемента управления, благодаря которому обеспечивается определенное расстояние между границами этого элемента и другими элементами.  
  
 Свойство <xref:System.Windows.Forms.Control.Padding%2A> определяет поле внутри элемента управления, благодаря которому обеспечивается определенное расстояние между содержимым элемента управления (например, значением свойства <xref:System.Windows.Forms.Control.Text%2A>) и его границами.  
  
 На рисунке ниже демонстрируется значение свойств <xref:System.Windows.Forms.Control.Padding%2A> и <xref:System.Windows.Forms.Control.Margin%2A> элемента управления.  
  
 ![И заполнение для Windows Forms элементы управления](./media/vs-winformpadmargin.gif "VS_WinFormPadMargin")  
  
 <xref:System.Windows.Forms.Control.AutoSize%2A> Свойство сообщает автоматическое изменение размера к содержимому элемента управления. Его размер не будет превышать исходного значения <xref:System.Windows.Forms.Control.Size%2A> . оно будет учитывать значение его <xref:System.Windows.Forms.Control.Padding%2A> свойство.  
  
 В данном пошаговом руководстве представлены следующие задачи.  
  
-   Создание проекта Windows Forms  
  
-   Установка полей для элементов управления  
  
-   Установка заполнения элементов управления  
  
-   Автоматического изменения размеров элементов управления  
  
 После завершения вы будете понимать роль, которую играют эти важные функции макета.  
  
> [!NOTE]
>  Отображаемые диалоговые окна и команды меню могут отличаться от описанных в справке в зависимости от текущих параметров или выпуска. Чтобы изменить параметры, выберите в меню **Сервис** пункт **Импорт и экспорт параметров** . Дополнительные сведения см. в разделе [Персонализация интегрированной среды разработки Visual Studio](/visualstudio/ide/personalizing-the-visual-studio-ide).  
  
## <a name="prerequisites"></a>Предварительные требования  
 Для выполнения данного пошагового руководства требуется:  
  
-   Разрешения, необходимые для создания и выполнения проектов приложений Windows Forms на компьютере, на котором установлена Visual Studio.  
  
## <a name="creating-the-project"></a>Создание проекта  
 Первым шагом является создание проекта и настройка формы.  
  
#### <a name="to-create-the-project"></a>Создание проекта  
  
1. Создание **приложения Windows** проект с именем `LayoutExample`. Дополнительные сведения см. в разделе [Как Создайте проект приложения Windows Forms](/visualstudio/ide/step-1-create-a-windows-forms-application-project) .  
  
2. Выберите форму в **конструктор Windows Forms**.  
  
## <a name="setting-margins-for-your-controls"></a>Установка полей для элементов управления  
 Можно задать значение по умолчанию расстояние между элементами управления с помощью <xref:System.Windows.Forms.Control.Margin%2A> свойство. При перемещении элемента управления как можно ближе к другому элементу управления, вы увидите линии привязки, показывающий поля для двух элементов управления. Элемент управления, который вы перемещаете будет привязан к расстояние, определяемое поля.  
  
#### <a name="to-arrange-controls-on-your-form-using-the-margin-property"></a>Размещение элементов управления на форме с помощью свойства полей  
  
1. Перетащите два <xref:System.Windows.Forms.Button> управляет из **элементов** на форму.  
  
2. Выберите один из <xref:System.Windows.Forms.Button> управляет и переместите его к другому, пока они обращаются к почти.  
  
     Наблюдайте за привязки между ними. Это расстояние складывается из двух элементов управления <xref:System.Windows.Forms.Control.Margin%2A> значения. Элемент управления, который вы перемещаете привязывается это расстояние. Дополнительные сведения см. в разделе [Пошаговое руководство: Упорядочение элементов управления в Windows Forms с помощью линий привязки](walkthrough-arranging-controls-on-windows-forms-using-snaplines.md).  
  
3. Изменение <xref:System.Windows.Forms.Control.Margin%2A> свойство одного из элементов управления, развернув <xref:System.Windows.Forms.Control.Margin%2A> запись в **свойства** и установив <xref:System.Windows.Forms.Padding.All%2A> до 20.  
  
4. Выберите один из <xref:System.Windows.Forms.Button> управляет и переместите его к другому.  
  
     Линии привязки определение суммы значений полей длиннее и элемент управления привязывается к больше расстояние от другого элемента управления.  
  
5. Изменение <xref:System.Windows.Forms.Control.Margin%2A> свойства выделенного элемента управления, развернув <xref:System.Windows.Forms.Control.Margin%2A> запись в **свойства** и установив <xref:System.Windows.Forms.Padding.Top%2A> значение 5.  
  
6. Переместите выбранный элемент управления под другой элемент управления и обратите внимание, что линия привязки является более короткие. Переместите выбранный элемент управления слева от другого элемента управления и обратите внимание, что линии привязки сохраняет значение, наблюдаемое в шаге 4.  
  
7. Можно задать каждый из аспектов <xref:System.Windows.Forms.Control.Margin%2A> свойство, <xref:System.Windows.Forms.Padding.Left%2A>, <xref:System.Windows.Forms.Padding.Top%2A>, <xref:System.Windows.Forms.Padding.Right%2A>, <xref:System.Windows.Forms.Padding.Bottom%2A>, чтобы разные значения, или можно задать их все в то же значение, с помощью <xref:System.Windows.Forms.Padding.All%2A> свойство.  
  
## <a name="setting-padding-for-your-controls"></a>Установка заполнения элементов управления  
 Чтобы обеспечить точную разметку, необходимую для приложения, элементы управления часто будет содержать дочерние элементы управления. Если вы хотите указать расстояния от границы дочернего элемента управления к границе родительского элемента управления, использовать родительского элемента управления <xref:System.Windows.Forms.Control.Padding%2A> свойство в сочетании с дочернего элемента управления <xref:System.Windows.Forms.Control.Margin%2A> свойство. <xref:System.Windows.Forms.Control.Padding%2A> Свойство также используется для управления расстоянием между содержимым элемента управления (например, <xref:System.Windows.Forms.Button> элемента управления <xref:System.Windows.Forms.Control.Text%2A> свойства) и его границами.  
  
#### <a name="to-arrange-controls-on-your-form-using-padding"></a>Размещение элементов управления в форме с помощью заполнения  
  
1. Перетащите элемент управления <xref:System.Windows.Forms.Button> из **панели элементов** в свою форму.  
  
2. Измените значение свойства <xref:System.Windows.Forms.Button> элемента управления <xref:System.Windows.Forms.Control.AutoSize%2A> на `true`.  
  
3. Изменение <xref:System.Windows.Forms.Control.Padding%2A> , развернув <xref:System.Windows.Forms.Control.Padding%2A> запись в **свойства** и установив <xref:System.Windows.Forms.Padding.All%2A> значение 5.  
  
     Элемент управления расширяется для предоставления места для новых внутренних полей.  
  
4. Перетащите элемент управления <xref:System.Windows.Forms.GroupBox> из **панели элементов** в свою форму. Перетащите <xref:System.Windows.Forms.Button> управления из **элементов** в <xref:System.Windows.Forms.GroupBox> элемента управления. Позиция <xref:System.Windows.Forms.Button> управления его записи на диск с в правом нижнем углу <xref:System.Windows.Forms.GroupBox> элемента управления.  
  
     Обратите внимание на линии привязки, как <xref:System.Windows.Forms.Button> управления приближается к нижней и правой границам <xref:System.Windows.Forms.GroupBox> элемента управления. Эти линии привязки соответствуют <xref:System.Windows.Forms.Control.Margin%2A> свойство <xref:System.Windows.Forms.Button>.  
  
5. Изменение <xref:System.Windows.Forms.GroupBox> элемента управления <xref:System.Windows.Forms.Control.Padding%2A> , развернув <xref:System.Windows.Forms.Control.Padding%2A> запись в **свойства** и установив <xref:System.Windows.Forms.Padding.All%2A> до 20.  
  
6. Выберите <xref:System.Windows.Forms.Button> элементе управления <xref:System.Windows.Forms.GroupBox> управления и переместите его к центру <xref:System.Windows.Forms.GroupBox>.  
  
     В появляются линии привязки на большем расстоянии от границ элемента <xref:System.Windows.Forms.GroupBox> элемента управления. Это расстояние равно сумме <xref:System.Windows.Forms.Button> элемента управления <xref:System.Windows.Forms.Control.Margin%2A> свойство и <xref:System.Windows.Forms.GroupBox> элемента управления <xref:System.Windows.Forms.Control.Padding%2A> свойство.  
  
## <a name="automatically-sizing-your-controls"></a>Автоматического изменения размеров элементов управления  
 В некоторых приложениях размер элемента управления не будет же во время выполнения во время разработки. Текст <xref:System.Windows.Forms.Button> элемента управления, например, могут быть извлечены из базы данных, а его длина не будет известна заранее.  
  
 Когда <xref:System.Windows.Forms.Control.AutoSize%2A> свойству `true`, элемент управления будет размер самого к его содержимому. Дополнительные сведения см. в разделе [Общие](autosize-property-overview.md).  
  
#### <a name="to-arrange-controls-on-your-form-using-the-autosize-property"></a>Размещение элементов управления на форме с помощью свойства AutoSize  
  
1. Перетащите элемент управления <xref:System.Windows.Forms.Button> из **панели элементов** в свою форму.  
  
2. Измените значение свойства <xref:System.Windows.Forms.Button> элемента управления <xref:System.Windows.Forms.Control.AutoSize%2A> на `true`.  
  
3. Изменение <xref:System.Windows.Forms.Button> элемента управления <xref:System.Windows.Forms.Control.Text%2A> свойства "**на этой кнопке изображен длинную строку для свойства Text**.»  
  
     При фиксации изменений, <xref:System.Windows.Forms.Button> элемент управления изменяет свои размеры в соответствии с новым текстом.  
  
4. Перетащите еще один <xref:System.Windows.Forms.Button> управления из **элементов** на форму.  
  
5. Изменение <xref:System.Windows.Forms.Button> элемента управления <xref:System.Windows.Forms.Control.Text%2A> свойства "**на этой кнопке изображен длинную строку для свойства Text.**"  
  
     При фиксации изменений, <xref:System.Windows.Forms.Button> элемент управления не будет изменен автоматически, и текст обрезается по правому краю элемента управления.  
  
6. Изменение <xref:System.Windows.Forms.Control.Padding%2A> , развернув <xref:System.Windows.Forms.Control.Padding%2A> запись в **свойства** и установив <xref:System.Windows.Forms.Padding.All%2A> значение 5.  
  
     Текст элемента управления обрезается по всем четырем сторонам.  
  
7. Изменение <xref:System.Windows.Forms.Button> элемента управления <xref:System.Windows.Forms.Control.AutoSize%2A> свойства `true`.  
  
     <xref:System.Windows.Forms.Button> Элемент управления изменяет свои размеры вплоть до охватывающих всю строку. Кроме того, был добавлен внутренние поля вокруг текста, вызывая <xref:System.Windows.Forms.Button> элемента управления, чтобы развернуть во всех четырех направлениях.  
  
8. Перетащите элемент управления <xref:System.Windows.Forms.Button> из **панели элементов** в свою форму. Разместите его в правом нижнем углу формы.  
  
9. Измените значение свойства <xref:System.Windows.Forms.Button> элемента управления <xref:System.Windows.Forms.Control.AutoSize%2A> на `true`.  
  
10. Задайте <xref:System.Windows.Forms.Button> элемента управления <xref:System.Windows.Forms.Control.Anchor%2A> свойства <xref:System.Windows.Forms.AnchorStyles.Right>, <xref:System.Windows.Forms.AnchorStyles.Bottom>.  
  
11. Изменение <xref:System.Windows.Forms.Button> элемента управления <xref:System.Windows.Forms.Control.Text%2A> свойства "**на этой кнопке изображен длинную строку для свойства Text.**"  
  
     При фиксации изменений, <xref:System.Windows.Forms.Button> элемент управления изменяет свои размеры налево. Как правило, автоматическое изменение размеров приведет к увеличению размера элемента управления в направлении, противоположном его <xref:System.Windows.Forms.Control.Anchor%2A> значение свойства.  
  
## <a name="autosize-and-autosizemode-properties"></a>AutoSize и AutoSizeMode свойства  
 Некоторые элементы управления поддерживают `AutoSizeMode` свойство, которое дает более точный контроль над поведением автоматического изменения размеров элемента управления.  
  
#### <a name="to-use-the-autosizemode-property"></a>Чтобы использовать AutoSizeMode-свойство  
  
1. Перетащите элемент управления <xref:System.Windows.Forms.Panel> из **панели элементов** в свою форму.  
  
2. Установите для параметра <xref:System.Windows.Forms.Panel> элемента управления <xref:System.Windows.Forms.Control.AutoSize%2A> свойства `true`.  
  
3. Перетащите <xref:System.Windows.Forms.Button> управления из **элементов** в <xref:System.Windows.Forms.Panel> элемента управления.  
  
4. Место <xref:System.Windows.Forms.Button> элемента управления в правом нижнем углу <xref:System.Windows.Forms.Panel> элемента управления.  
  
5. Выберите <xref:System.Windows.Forms.Panel> управления и изменения размера нижний правый маркер захвата. Изменение размера <xref:System.Windows.Forms.Panel> элемент управления будет более крупные и мелкие.  
  
    > [!NOTE]
    >  Вы можете свободно изменить размер <xref:System.Windows.Forms.Panel> элемента управления, но размер не может быть он меньше, чем положение <xref:System.Windows.Forms.Button> нижний правый угол элемента управления. Такое поведение определяется по значению по умолчанию `AutoSizeMode` свойство, являющееся <xref:System.Windows.Forms.AutoSizeMode.GrowOnly>.  
  
6. Установите для параметра <xref:System.Windows.Forms.Panel> элемента управления `AutoSizeMode` свойства <xref:System.Windows.Forms.AutoSizeMode.GrowAndShrink>.  
  
     <xref:System.Windows.Forms.Panel> Размера элемента управления вокруг <xref:System.Windows.Forms.Button> элемента управления. Нельзя изменить размер <xref:System.Windows.Forms.Panel> элемента управления.  
  
7. Перетащите <xref:System.Windows.Forms.Button> управления сторону в верхнем левом углу <xref:System.Windows.Forms.Panel> элемента управления.  
  
     <xref:System.Windows.Forms.Panel> Изменение размера элемента управления <xref:System.Windows.Forms.Button> новое положение элемента управления.  
  
## <a name="next-steps"></a>Следующие шаги  
 Существует множество других возможностей компоновки для упорядочивания элементов управления в приложениях Windows Forms. Ниже приведены некоторые сочетания методов, которые можно попробовать.  
  
-   Создайте форму с помощью <xref:System.Windows.Forms.TableLayoutPanel> элемента управления. Дополнительные сведения см. в разделе [Пошаговое руководство: Упорядочение элементов управления в Windows Forms, с помощью элемента управления TableLayoutPanel](walkthrough-arranging-controls-on-windows-forms-using-a-tablelayoutpanel.md). Попробуйте изменить значения <xref:System.Windows.Forms.TableLayoutPanel> элемента управления <xref:System.Windows.Forms.Control.Padding%2A> свойства, а также <xref:System.Windows.Forms.Control.Margin%2A> свойства дочерних элементов управления.  
  
-   Повторите ту же эксперимент с помощью <xref:System.Windows.Forms.FlowLayoutPanel> элемента управления. Дополнительные сведения см. в разделе [Пошаговое руководство: Упорядочение элементов управления в Windows Forms, с помощью элемента FlowLayoutPanel](walkthrough-arranging-controls-on-windows-forms-using-a-flowlayoutpanel.md).  
  
-   Поэкспериментируйте с закреплением дочерних элементов управления в <xref:System.Windows.Forms.Panel> элемента управления. <xref:System.Windows.Forms.Control.Padding%2A> Свойство является более общей реализацией <xref:System.Windows.Forms.ScrollableControl.DockPadding%2A> , а также может удовлетворять самостоятельно это так, поместив дочернего элемента управления <xref:System.Windows.Forms.Panel> управления и задание дочернего элемента управления <xref:System.Windows.Forms.Control.Dock%2A> свойства <xref:System.Windows.Forms.DockStyle.Fill>. Задайте <xref:System.Windows.Forms.Panel> элемента управления <xref:System.Windows.Forms.Control.Padding%2A> свойство различные значения и Примечание эффект.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.Control.AutoSize%2A>
- <xref:System.Windows.Forms.ScrollableControl.DockPadding%2A>
- <xref:System.Windows.Forms.Control.Margin%2A>
- <xref:System.Windows.Forms.Control.Padding%2A>
- [Свойство AutoSize](autosize-property-overview.md)
- [Пошаговое руководство. Упорядочение элементов управления в формах Windows Forms с помощью элемента TableLayoutPanel](walkthrough-arranging-controls-on-windows-forms-using-a-tablelayoutpanel.md)
- [Пошаговое руководство. Упорядочение элементов управления в формах Windows Forms с помощью элемента FlowLayoutPanel](walkthrough-arranging-controls-on-windows-forms-using-a-flowlayoutpanel.md)
- [Пошаговое руководство. Упорядочение элементов управления в формах Windows Forms с помощью линий привязки](walkthrough-arranging-controls-on-windows-forms-using-snaplines.md)
