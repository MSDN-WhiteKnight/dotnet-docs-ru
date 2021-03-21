---
title: Пошаговое руководство. Включение перетаскивания для пользовательского элемента управления
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- walkthrough [WPF], drag-and-drop
- drag-and-drop [WPF], walkthrough
ms.assetid: cc844419-1a77-4906-95d9-060d79107fc7
ms.openlocfilehash: a628665ccfa0a423667344b1fe81f132d6691b12
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59321683"
---
# <a name="walkthrough-enabling-drag-and-drop-on-a-user-control"></a>Пошаговое руководство. Включение перетаскивания для пользовательского элемента управления

В этом пошаговом руководстве демонстрируется создание настраиваемого пользовательского элемента управления, который может участвовать в переносе данных путем перетаскивания в [!INCLUDE[TLA#tla_winclient](../../../../includes/tlasharptla-winclient-md.md)].

В этом пошаговом руководстве вы создадите настраиваемый элемент управления WPF <xref:System.Windows.Controls.UserControl> , представляющий круг. Вы реализуете в этом элементе управления функциональность, позволяющую переносить данные посредством перетаскивания. Например, при перетаскивании из одного элемента управления Circle в другой данные цвета заливки копируются из исходного круга в целевой. Если перетащить элемент управления Circle на <xref:System.Windows.Controls.TextBox>, строковое представление цвета заливки копируется в <xref:System.Windows.Controls.TextBox>. Вы также создадите небольшое приложение, которое содержит два элемента управления панели и <xref:System.Windows.Controls.TextBox> для тестирования функциональности перетаскивания и вставки. Вы напишете код, позволяющий панелям обрабатывать перемещенные перетаскиванием данные Circle, в результате чего элементы управления Circle можно будет перемещать или копировать из дочерней коллекции на одной панели в другую.

В данном пошаговом руководстве рассмотрены следующие задачи:

-   Создание настраиваемого пользовательского элемента управления.

-   Включение пользовательского элемента управления в качестве источника перетаскивания.

-   Включение пользовательского элемента управления в качестве целевого объекта перетаскивания.

-   Включение панели для получения данных, перемещенных перетаскиванием из пользовательского элемента управления.

## <a name="prerequisites"></a>Предварительные требования

Для выполнения шагов, описанных в этом руководстве, вам понадобится Visual Studio.

## <a name="create-the-application-project"></a>Создание проекта приложения
 В этом разделе вы создадите инфраструктуру приложения, которая включает главную страницу с двумя панелями и <xref:System.Windows.Controls.TextBox>.

1. Создайте проект приложения WPF на Visual Basic или Visual C# с именем `DragDropExample`. Дополнительные сведения см. в разделе [Пошаговое руководство: Создание первого классического приложения WPF](../getting-started/walkthrough-my-first-wpf-desktop-application.md).

2. Откройте файл MainWindow.xaml.

3. Добавьте следующую разметку между открывающим и закрывающим <xref:System.Windows.Controls.Grid> теги.

     Эта разметка создает пользовательский интерфейс для тестового приложения.

     [!code-xaml[DragDropWalkthrough#PanelsStep1XAML](~/samples/snippets/csharp/VS_Snippets_Wpf/DragDropWalkthrough/CS/SnippetWindow.xaml#panelsstep1xaml)]

## <a name="add-a-new-user-control-to-the-project"></a>Добавьте в проект новый пользовательский элемент управления
 В этом разделе вы добавите в проект новый пользовательский элемент управления.

1. В меню "Проект" выберите пункт **Добавить пользовательский элемент управления**.

2. В **Добавление нового элемента** диалоговом окне измените имя на `Circle.xaml`и нажмите кнопку **добавить**.

     Circle.xaml и его код программной части добавляются в проект.

3. Откройте файл Circle.xaml.

     Этот файл будет содержать элементы пользовательского интерфейса пользовательского элемента управления.

4. Добавьте следующую разметку в корневой каталог <xref:System.Windows.Controls.Grid> создать простой пользовательский элемент управления, который представлен синим кругом, пользовательский интерфейс.

     [!code-xaml[DragDropWalkthrough#EllipseXAML](~/samples/snippets/csharp/VS_Snippets_Wpf/DragDropWalkthrough/CS/Circle.xaml#ellipsexaml)]

5. Откройте файл Circle.xaml.cs или Circle.xaml.vb.

6. В C# добавьте следующий код после конструктора по умолчанию, чтобы создать конструктор копии. В Visual Basic добавьте следующий код, чтобы создать конструктор по умолчанию и конструктор копии.

     Чтобы разрешить копирование пользовательского элемента управления, нужно добавить метод конструктора копии в файле кода программной части. В упрощенном пользовательском элементе управления Circle копируются только свойства Fill и размер пользовательского элемента управления.

     [!code-csharp[DragDropWalkthrough#CopyCtor](~/samples/snippets/csharp/VS_Snippets_Wpf/DragDropWalkthrough/CS/Circle.xaml.cs#copyctor)]
     

## <a name="add-the-user-control-to-the-main-window"></a>Добавление пользовательского элемента управления в главное окно

1. Откройте файл MainWindow.xaml.

2. Добавьте следующий XAML в открывающий <xref:System.Windows.Window> тег, чтобы создать ссылку на пространство имен XML для текущего приложения.

    ```
    xmlns:local="clr-namespace:DragDropExample"
    ```

3. В первом <xref:System.Windows.Controls.StackPanel>, добавьте следующий XAML для создания двух экземпляров пользовательского элемента управления Circle на первой панели.

     [!code-xaml[DragDropWalkthrough#CirclesXAML](~/samples/snippets/csharp/VS_Snippets_Wpf/DragDropWalkthrough/CS/SnippetWindow.xaml#circlesxaml)]

     Полный код XAML для панели выглядит следующим образом.

     [!code-xaml[DragDropWalkthrough#PanelsStep2XAML](~/samples/snippets/csharp/VS_Snippets_Wpf/DragDropWalkthrough/CS/SnippetWindow.xaml#panelsstep2xaml)]

## <a name="implement-drag-source-events-in-the-user-control"></a>Реализация событий источника перетаскивания для пользовательского элемента управления
 В этом разделе будут переопределены <xref:System.Windows.UIElement.OnMouseMove%2A> метод и инициирует операцию перетаскивания и вставки.

 Если перетаскивание начато (нажата кнопка мыши и перемещение мыши), позволяющий преобразовывать данные будут передаваться в <xref:System.Windows.DataObject>. В данном случае элемент управления Circle упаковывает три элемента данных; строковое представление цвета заливки, двойное представление высоты и копию самого себя.

### <a name="to-initiate-a-drag-and-drop-operation"></a>Запуск операции перетаскивания

1. Откройте файл Circle.xaml.cs или Circle.xaml.vb.

2. Добавьте следующий <xref:System.Windows.UIElement.OnMouseMove%2A> переопределение, чтобы обеспечить обработку класса для <xref:System.Windows.UIElement.MouseMove> событий.

     [!code-csharp[DragDropWalkthrough#OnMouseMove](~/samples/snippets/csharp/VS_Snippets_Wpf/DragDropWalkthrough/CS/Circle.xaml.cs#onmousemove)]
     

     Это <xref:System.Windows.UIElement.OnMouseMove%2A> переопределение выполняет следующие задачи:

    -   Проверяет, нажата ли левая кнопка мыши при перемещении мыши.

    -   Упаковывает данные Circle в <xref:System.Windows.DataObject>. В данном случае элемент управления Circle упакует три элемента данных; строковое представление цвета заливки, двойное представление высоты и копию самого себя.

    -   Вызывает статический <xref:System.Windows.DragDrop.DoDragDrop%2A?displayProperty=nameWithType> метода для инициации операции перетаскивания и вставки. Передайте следующие три параметра для <xref:System.Windows.DragDrop.DoDragDrop%2A> метод:

        -   `dragSource` — Ссылка на этот элемент управления.

        -   `data` — <xref:System.Windows.DataObject> Созданный в предыдущем коде.

        -   `allowedEffects` Разрешенные операции перетаскивания и вставки, которые являются <xref:System.Windows.DragDropEffects.Copy> или <xref:System.Windows.DragDropEffects.Move>.

3. Нажмите клавишу **F5**, чтобы выполнить сборку приложения и запустить его.

4. Выберите один из элементов управления Circle и перетащите его над панелями, другим элементом Circle и <xref:System.Windows.Controls.TextBox>. При перетаскивании над <xref:System.Windows.Controls.TextBox>, курсор изменяется, обозначая перемещение.

5. При перетаскивании элемента управления Circle над <xref:System.Windows.Controls.TextBox>, нажмите клавишу **Ctrl** ключ. Обратите внимание на то, как изменится курсор, обозначая копирование.

6. Перетащите элемент управления Circle на <xref:System.Windows.Controls.TextBox>. Строковое представление цвета заливки элемента управления Circle добавляется к <xref:System.Windows.Controls.TextBox>.

     ![Строковое представление цвета заливки элемента управления Circle](./media/dragdrop-colorstring.png "DragDrop_ColorString")

По умолчанию курсор изменяется во время операции перетаскивания, чтобы указать, какой результат даст перетаскивание данных в ту или иную точку. Можно настроить получаемую пользователем путем обработки <xref:System.Windows.UIElement.GiveFeedback> событий и настройки другого курсора.

## <a name="give-feedback-to-the-user"></a>Отправить отзыв для пользователя

1. Откройте файл Circle.xaml.cs или Circle.xaml.vb.

2. Добавьте следующий <xref:System.Windows.UIElement.OnGiveFeedback%2A> переопределение, чтобы обеспечить обработку класса для <xref:System.Windows.UIElement.GiveFeedback> событий.

     [!code-csharp[DragDropWalkthrough#OnGiveFeedback](~/samples/snippets/csharp/VS_Snippets_Wpf/DragDropWalkthrough/CS/Circle.xaml.cs#ongivefeedback)]
     

     Это <xref:System.Windows.UIElement.OnGiveFeedback%2A> переопределение выполняет следующие задачи:

    -   Проверяет <xref:System.Windows.GiveFeedbackEventArgs.Effects%2A> значения, заданные в цели перетаскивания <xref:System.Windows.UIElement.DragOver> обработчик событий.

    -   Задает пользовательский курсор на основе <xref:System.Windows.GiveFeedbackEventArgs.Effects%2A> значение. Курсор предназначен для предоставления визуальной обратной связи пользователю о том, какой результат будет иметь перетаскивание данных.

3. Нажмите клавишу **F5**, чтобы выполнить сборку приложения и запустить его.

4. Перетащите один из круга управляет над панелями, другим элементом Circle, и <xref:System.Windows.Controls.TextBox>. Обратите внимание, что курсоры созданы пользовательские курсоры, которые указаны в <xref:System.Windows.UIElement.OnGiveFeedback%2A> переопределить.

     ![Перетаскивание с использованием пользовательских курсоров](./media/dragdrop-customcursor.png "DragDrop_CustomCursor")

5. Выделите текст `green` из <xref:System.Windows.Controls.TextBox>.

6. Перетащите текст `green` в элемент управления Circle. Обратите внимание, что отображаются курсоры по умолчанию: они указывают на результаты операции перетаскивания. Курсор обратной связи всегда задается источником перетаскивания.

## <a name="implement-drop-target-events-in-the-user-control"></a>Реализация событий целевого объекта перетаскивания для пользовательского элемента управления
 Изучая этот раздел, вы укажете, что пользовательский элемент управления является целевым объектом перетаскивания, переопределите методы, позволяющие пользовательскому элементу управления функционировать в качестве целевого объекта перетаскивания, и обработаете перемещенные в него данные.

### <a name="to-enable-the-user-control-to-be-a-drop-target"></a>Чтобы включить пользовательский элемент управления в качестве целевого объекта перетаскивания, выполните следующие действия.

1. Откройте файл Circle.xaml.

2. В открывающем <xref:System.Windows.Controls.UserControl> , добавьте <xref:System.Windows.UIElement.AllowDrop%2A> свойство и присвойте ему значение `true`.

     [!code-xaml[DragDropWalkthrough#UCTagXAML](~/samples/snippets/csharp/VS_Snippets_Wpf/DragDropWalkthrough/CS/Circle.xaml#uctagxaml)]

<xref:System.Windows.UIElement.OnDrop%2A> Метод вызывается, когда <xref:System.Windows.UIElement.AllowDrop%2A> свойству `true` и удалении данных из источника перетаскивания в пользовательский элемент управления Circle. В этом методе вы обработаете перемещенные данные и примените их к элементу управления Circle.

### <a name="to-process-the-dropped-data"></a>Обработка вставляемых данных

1. Откройте файл Circle.xaml.cs или Circle.xaml.vb.

2. Добавьте следующий <xref:System.Windows.UIElement.OnDrop%2A> переопределение, чтобы обеспечить обработку класса для <xref:System.Windows.UIElement.Drop> событий.

     [!code-csharp[DragDropWalkthrough#OnDrop](~/samples/snippets/csharp/VS_Snippets_Wpf/DragDropWalkthrough/CS/Circle.xaml.cs#ondrop)]
     

     Это <xref:System.Windows.UIElement.OnDrop%2A> переопределение выполняет следующие задачи:

    -   Использует <xref:System.Windows.DataObject.GetDataPresent%2A> метод, чтобы проверить наличие перемещенные данные строковый объект.

    -   Использует <xref:System.Windows.DataObject.GetData%2A> метод для извлечения строковых данных в том случае, если он имеется.

    -   Использует <xref:System.Windows.Media.BrushConverter> для строки, преобразованные в <xref:System.Windows.Media.Brush>.

    -   Если преобразование прошло успешно, применяет кисть к <xref:System.Windows.Shapes.Shape.Fill%2A> из <xref:System.Windows.Shapes.Ellipse> , предоставляет пользовательский Интерфейс элемента управления Circle.

    -   Метки <xref:System.Windows.UIElement.Drop> событие как обработанное. Событие сброса необходимо пометить как обработанное, чтобы другие элементы, которые получают это событие, знали, что событие было обработано пользовательским элементом управления Circle.

3. Нажмите клавишу **F5**, чтобы выполнить сборку приложения и запустить его.

4. Выделите текст `green` в <xref:System.Windows.Controls.TextBox>.

5. Перетащите текст в элемент управления Circle. Элемент управления Circle поменяет цвет с синего на зеленый.

     ![Преобразование строки в кисть](./media/dragdrop-dropgreentext.png "DragDrop_DropGreenText")

6. Введите текст `green` в <xref:System.Windows.Controls.TextBox>.

7. Выделите текст `gre` в <xref:System.Windows.Controls.TextBox>.

8. Перетащите его в элемент управления Circle. Обратите внимание, что курсор изменяется, чтобы указать, что перенос разрешен, но цвет элемента управления Circle не меняется, потому что `gre` — недопустимый цвет.

9. Выполните перетаскивание с зеленого элемента управления Circle на синий. Элемент управления Circle поменяет цвет с синего на зеленый. Обратите внимание, что отображается курсор, который зависит от того <xref:System.Windows.Controls.TextBox> или элемент управления Circle является источником перетаскивания.

Установка <xref:System.Windows.UIElement.AllowDrop%2A> свойства `true` и обработка перенесенных данных — все, что требуется для включения элемента в качестве целевого объекта перетаскивания. Тем не менее, для повышения удобства работы пользователя, необходимо также обрабатывать <xref:System.Windows.UIElement.DragEnter>, <xref:System.Windows.UIElement.DragLeave>, и <xref:System.Windows.UIElement.DragOver> события. В этих событиях можно выполнять проверки и предоставлять дополнительную обратную связь пользователю до сброса данных.

При перетаскивании данных над пользовательским элементом управления Circle элемент управления должен уведомить источник перетаскивания, может ли он обработать переносимые данные. Если элемент управления не знает, как обрабатывать данные, он должен отклонить перетаскивание. Чтобы сделать это, будет обрабатывать <xref:System.Windows.UIElement.DragOver> событий и набор <xref:System.Windows.DragEventArgs.Effects%2A> свойство.

### <a name="to-verify-that-the-data-drop-is-allowed"></a>Проверка допустимости сброса данных

1. Откройте файл Circle.xaml.cs или Circle.xaml.vb.

2. Добавьте следующий <xref:System.Windows.UIElement.OnDragOver%2A> переопределение, чтобы обеспечить обработку класса для <xref:System.Windows.UIElement.DragOver> событий.

     [!code-csharp[DragDropWalkthrough#OnDragOver](~/samples/snippets/csharp/VS_Snippets_Wpf/DragDropWalkthrough/CS/Circle.xaml.cs#ondragover)]
     

     Это <xref:System.Windows.UIElement.OnDragOver%2A> переопределение выполняет следующие задачи:

    -   Задает для свойства <xref:System.Windows.DragEventArgs.Effects%2A> значение <xref:System.Windows.DragDropEffects.None>.

    -   Выполняет те же проверки, выполняемые в <xref:System.Windows.UIElement.OnDrop%2A> метод, чтобы определить, может ли пользовательский элемент управления Circle обработать перенесенные данные.

    -   Если пользовательский элемент управления может обработать данные, задает <xref:System.Windows.DragEventArgs.Effects%2A> свойства <xref:System.Windows.DragDropEffects.Copy> или <xref:System.Windows.DragDropEffects.Move>.

3. Нажмите клавишу **F5**, чтобы выполнить сборку приложения и запустить его.

4. Выделите текст `gre` в <xref:System.Windows.Controls.TextBox>.

5. Перетащите текст в элемент управления Circle. Обратите внимание, что курсор изменяется, чтобы указать, что перетаскивание не разрешено, потому что `gre` не является допустимым цветом.

 Использование предварительного просмотра при перетаскивании повышает удобство работы пользователей. Для пользовательского элемента управления Circle переопределяются <xref:System.Windows.UIElement.OnDragEnter%2A> и <xref:System.Windows.UIElement.OnDragLeave%2A> методы. Когда данные перетаскиваются над элементом управления, текущий фон <xref:System.Windows.Shapes.Shape.Fill%2A> сохраняется в переменной-заполнителе. Затем строка преобразуется в кисть и применяется к <xref:System.Windows.Shapes.Ellipse> , предоставляющий окружности пользовательского интерфейса. Если данные перетаскиваются за элемент управления Circle без сброса, исходное <xref:System.Windows.Shapes.Shape.Fill%2A> значение повторно применить к элементу управления Circle.

### <a name="to-preview-the-effects-of-the-drag-and-drop-operation"></a>Предварительный просмотр результатов операции перетаскивания

1. Откройте файл Circle.xaml.cs или Circle.xaml.vb.

2. В классе Circle объявите закрытую <xref:System.Windows.Media.Brush> переменную с именем `_previousFill` и инициализируйте его, чтобы `null`.

     [!code-csharp[DragDropWalkthrough#Brush](~/samples/snippets/csharp/VS_Snippets_Wpf/DragDropWalkthrough/CS/Circle.xaml.cs#brush)]
     

3. Добавьте следующий <xref:System.Windows.UIElement.OnDragEnter%2A> переопределение, чтобы обеспечить обработку класса для <xref:System.Windows.UIElement.DragEnter> событий.

     [!code-csharp[DragDropWalkthrough#OnDragEnter](~/samples/snippets/csharp/VS_Snippets_Wpf/DragDropWalkthrough/CS/Circle.xaml.cs#ondragenter)]
     

     Это <xref:System.Windows.UIElement.OnDragEnter%2A> переопределение выполняет следующие задачи:

    -   Сохраняет <xref:System.Windows.Shapes.Shape.Fill%2A> свойство <xref:System.Windows.Shapes.Ellipse> в `_previousFill` переменной.

    -   Выполняет те же проверки, выполняемые в <xref:System.Windows.UIElement.OnDrop%2A> метод, чтобы определить, может быть преобразован в данных <xref:System.Windows.Media.Brush>.

    -   Если данные преобразуются в допустимый <xref:System.Windows.Media.Brush>, применяемое к <xref:System.Windows.Shapes.Shape.Fill%2A> из <xref:System.Windows.Shapes.Ellipse>.

4. Добавьте следующий <xref:System.Windows.UIElement.OnDragLeave%2A> переопределение, чтобы обеспечить обработку класса для <xref:System.Windows.UIElement.DragLeave> событий.

     [!code-csharp[DragDropWalkthrough#OnDragLeave](~/samples/snippets/csharp/VS_Snippets_Wpf/DragDropWalkthrough/CS/Circle.xaml.cs#ondragleave)]
     

     Это <xref:System.Windows.UIElement.OnDragLeave%2A> переопределение выполняет следующие задачи:

    -   Применяет <xref:System.Windows.Media.Brush> сохранен в `_previousFill` переменной <xref:System.Windows.Shapes.Shape.Fill%2A> из <xref:System.Windows.Shapes.Ellipse> , предоставляющий пользовательского интерфейса пользовательского элемента управления Circle.

5. Нажмите клавишу **F5**, чтобы выполнить сборку приложения и запустить его.

6. Выделите текст `green` в <xref:System.Windows.Controls.TextBox>.

7. Перетащите текст над элементом управления Circle, не сбрасывая его. Элемент управления Circle поменяет цвет с синего на зеленый.

     ![Предварительный просмотр результатов операции перетаскивания](./media/dragdrop-previeweffects.png "DragDrop_PreviewEffects")

8. Перетащите текст от элемента управления Circle. Элемент управления Circle изменится с зеленого на синий.

## <a name="enable-a-panel-to-receive-dropped-data"></a>Включение панели для получения перетаскиваемых данных

В этом разделе описано как разрешить панелей, на которых размещены пользовательские элементы управления Circle в качестве целевых объектов перетаскивания для перемещенных данных Circle. Вы реализуете код, который позволяет переместить элемент Circle с одной панели в другую или скопировать элемент управления Circle, удерживая нажатой **Ctrl** ключа во время перетаскивания круг.

1. Откройте файл MainWindow.xaml.

2. Как показано в следующем XAML, в каждом из <xref:System.Windows.Controls.StackPanel> элементы управления, добавьте обработчики для <xref:System.Windows.UIElement.DragOver> и <xref:System.Windows.UIElement.Drop> события. Имя <xref:System.Windows.UIElement.DragOver> обработчик событий `panel_DragOver`и назовите <xref:System.Windows.UIElement.Drop> обработчик событий `panel_Drop`.

     [!code-xaml[DragDropWalkthrough#PanelsXAML](~/samples/snippets/csharp/VS_Snippets_Wpf/DragDropWalkthrough/CS/MainWindow.xaml#panelsxaml)]

3. Откройте файл MainWindows.xaml.cs или MainWindow.xaml.vb.

4. Добавьте следующий код для <xref:System.Windows.UIElement.DragOver> обработчик событий.

     [!code-csharp[DragDropWalkthrough#PanelDragOver](~/samples/snippets/csharp/VS_Snippets_Wpf/DragDropWalkthrough/CS/MainWindow.xaml.cs#paneldragover)]
     

     Это <xref:System.Windows.UIElement.DragOver> обработчик событий выполняет следующие задачи:

    -   Проверяет, что перетаскиваемые данные с данными «Объект», было упаковано в <xref:System.Windows.DataObject> с пользовательским элементом управления Circle и переданы в вызове <xref:System.Windows.DragDrop.DoDragDrop%2A>.

    -   Если данные «Объект» отсутствует, проверяет ли **Ctrl** клавиши.

    -   Если **Ctrl** клавиша нажата, задает <xref:System.Windows.DragEventArgs.Effects%2A> свойства <xref:System.Windows.DragDropEffects.Copy>. В противном случае значение <xref:System.Windows.DragEventArgs.Effects%2A> свойства <xref:System.Windows.DragDropEffects.Move>.

5. Добавьте следующий код для <xref:System.Windows.UIElement.Drop> обработчик событий.

     [!code-csharp[DragDropWalkthrough#PanelDrop](~/samples/snippets/csharp/VS_Snippets_Wpf/DragDropWalkthrough/CS/MainWindow.xaml.cs#paneldrop)]
     

     Это <xref:System.Windows.UIElement.Drop> обработчик событий выполняет следующие задачи:

    -   Проверяет ли <xref:System.Windows.UIElement.Drop> уже было обработано событие. Например, если элемент управления Circle перетаскивается на другом круг которого дескрипторы <xref:System.Windows.UIElement.Drop> событий, требуется панель, содержащую круг его.

    -   Если <xref:System.Windows.UIElement.Drop> событие не обработано, проверяет ли **Ctrl** клавиши.

    -   Если **Ctrl** при нажатии клавиши <xref:System.Windows.UIElement.Drop> происходит, создает копию круга управления и добавьте его в <xref:System.Windows.Controls.Panel.Children%2A> коллекцию <xref:System.Windows.Controls.StackPanel>.

    -   Если **Ctrl** клавиша не нажата, перемещает элемент управления Circle из <xref:System.Windows.Controls.Panel.Children%2A> коллекцию его родительской панели <xref:System.Windows.Controls.Panel.Children%2A> коллекцию на панели, который был сброшен.

    -   Наборы <xref:System.Windows.DragEventArgs.Effects%2A> свойства для уведомления <xref:System.Windows.DragDrop.DoDragDrop%2A> метод ли была выполнена операция перемещения или копирования.

6. Нажмите клавишу **F5**, чтобы выполнить сборку приложения и запустить его.

7. Выделите текст `green` из <xref:System.Windows.Controls.TextBox>.

8. Перетащите текст над элементом управления Circle и опустите его на элемент.

9. Перетащите элемент управления Circle из левой панели в правую панель и опустите его. Элемент управления Circle удаляется из <xref:System.Windows.Controls.Panel.Children%2A> коллекции левой панели и добавляется в коллекцию дочерних элементов на правой панели.

10. Перетащите элемент управления Circle из панели, он находится в на другую панель и опустите его удерживая нажатой клавишу **Ctrl** ключ. Элемент управления Circle копируется, и копия добавляется <xref:System.Windows.Controls.Panel.Children%2A> коллекцию принимающей панели.

     ![Перетаскивание элемента управления Circle с нажатой клавишей CTRL](./media/dragdrop-paneldrop.png "DragDrop_PanelDrop")

## <a name="see-also"></a>См. также

- [Общие сведения о перетаскивании](drag-and-drop-overview.md)