---
title: События мыши в формах Windows Forms
ms.date: 03/30/2017
helpviewer_keywords:
- MouseLeave event [Windows Forms]
- events [Windows Forms], mouse
- Click event [Windows Forms], raising order
- Windows Forms controls, click events
- MouseDoubleClick event [Windows Forms]
- MouseEnter event [Windows Forms]
- MouseHover event [Windows Forms]
- MouseDown event [Windows Forms]
- MouseClick event [Windows Forms]
- MouseMove event [Windows Forms]
- mouse [Windows Forms], events
- MouseUp event
ms.assetid: 8cf0070d-793b-4876-b09e-d20d28280fab
ms.openlocfilehash: 671e37c7d6dc40046d6d717d7785b03b6b545c7e
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59333682"
---
# <a name="mouse-events-in-windows-forms"></a>События мыши в формах Windows Forms
При обработке ввода данных с помощью мыши обычно необходимо знать положение указателя и состояние кнопок мыши. В этом разделе приводится подробная информация о получении этих сведений из событий мыши и описывается порядок, в котором вызываются события щелчка мыши в элементах управления Windows Forms. Список и описание всех событий мыши, см. в разделе [принцип работы мыши ввода в Windows Forms](how-mouse-input-works-in-windows-forms.md).  Также см. в разделе [Обзор обработчиков событий (Windows Forms)](event-handlers-overview-windows-forms.md) и [Общие сведения о событиях (Windows Forms)](events-overview-windows-forms.md).  
  
## <a name="mouse-information"></a>Сведения о мыши  
 Объект <xref:System.Windows.Forms.MouseEventArgs> отправляется обработчикам событий мыши, связанных с нажатием кнопки мыши и отслеживанием ее движений. <xref:System.Windows.Forms.MouseEventArgs> сведения о текущем состоянии мыши, включая положение указателя мыши в клиентских координатах, какие кнопки мыши, а ли прокрутке колесика мыши. Некоторые события мыши, например те, которые просто уведомляют о том, что указатель мыши пересек границы элемента управления, отправляют обработчику событий объект <xref:System.EventArgs> без подробных сведений.  
  
 Если нужно знать текущее состояние кнопок мыши или положение ее указателя, но при этом избежать обработки события мыши, можно также использовать свойства <xref:System.Windows.Forms.Control.MouseButtons%2A> и <xref:System.Windows.Forms.Control.MousePosition%2A> класса <xref:System.Windows.Forms.Control>. <xref:System.Windows.Forms.Control.MouseButtons%2A> Возвращает сведения о том, какие кнопки мыши нажаты в данный момент. Свойство <xref:System.Windows.Forms.Control.MousePosition%2A> возвращает экранные координаты указателя мыши, которые эквивалентны значению, возвращаемому методом <xref:System.Windows.Forms.Cursor.Position%2A>.  
  
## <a name="converting-between-screen-and-client-coordinates"></a>Преобразование между экранными и клиентскими координатами  
 Так как некоторые сведения о положении мыши представлены в клиентских координатах, а другие — в экранных, может потребоваться преобразовать точку из одной системы координат в другую. Это легко сделать с помощью методов <xref:System.Windows.Forms.Control.PointToClient%2A> и <xref:System.Windows.Forms.Control.PointToScreen%2A>, доступных в классе <xref:System.Windows.Forms.Control>.  
  
## <a name="standard-click-event-behavior"></a>Стандартное поведение события щелчка  
 Если требуется обрабатывать события щелчка мыши в определенном порядке, необходимо знать порядок, в котором вызываются события щелчка в элементах управления Windows Forms. Когда кнопка мыши (любая) нажимается и отпускается, все элементы управления Windows Forms, кроме отмеченных в списке ниже, вызывают события щелчка в одном и том же порядке. Ниже приведен порядок событий, вызываемых одинарным щелчком мыши.  
  
1. <xref:System.Windows.Forms.Control.MouseDown> .  
  
2. <xref:System.Windows.Forms.Control.Click> .  
  
3. <xref:System.Windows.Forms.Control.MouseClick> .  
  
4. <xref:System.Windows.Forms.Control.MouseUp> .  
  
 Ниже приведен порядок событий, вызываемых двойным щелчком мыши.  
  
1. <xref:System.Windows.Forms.Control.MouseDown> .  
  
2. <xref:System.Windows.Forms.Control.Click> .  
  
3. <xref:System.Windows.Forms.Control.MouseClick> .  
  
4. <xref:System.Windows.Forms.Control.MouseUp> .  
  
5. <xref:System.Windows.Forms.Control.MouseDown> .  
  
6. <xref:System.Windows.Forms.Control.DoubleClick> . (Может изменяться в зависимости от того, установлено ли для бита стиля <xref:System.Windows.Forms.ControlStyles.StandardDoubleClick> элемента управления значение `true`. Подробнее о настройке бита <xref:System.Windows.Forms.ControlStyles> см. в разделе, посвященном методу <xref:System.Windows.Forms.Control.SetStyle%2A>.)  
  
7. <xref:System.Windows.Forms.Control.MouseDoubleClick> .  
  
8. <xref:System.Windows.Forms.Control.MouseUp> .  
  
 Пример кода, который демонстрирует порядок мыши события щелчка мыши, см. в разделе [как: Дескриптор пользовательского ввода, события в Windows Forms, элементы управления](how-to-handle-user-input-events-in-windows-forms-controls.md).  
  
### <a name="individual-controls"></a>Особые элементы управления  
 Поведение перечисленных ниже элементов управления при щелчке мыши не соответствует стандартному.  
  
-   <xref:System.Windows.Forms.Button>, <xref:System.Windows.Forms.CheckBox>, <xref:System.Windows.Forms.ComboBox>, и <xref:System.Windows.Forms.RadioButton> элементов управления  
  
    > [!NOTE]
    >  Если пользователь щелкает поле редактирования, кнопку или элемент в списке, то для элемента управления <xref:System.Windows.Forms.ComboBox> возникают описанные ниже события.  
  
    -   Щелчок левой кнопкой: <xref:System.Windows.Forms.Control.Click>, <xref:System.Windows.Forms.Control.MouseClick>  
  
    -   Щелкните правой кнопкой мыши: Событие щелчка не вызывается  
  
    -   Двойной щелчок левой: <xref:System.Windows.Forms.Control.Click>, <xref:System.Windows.Forms.Control.MouseClick>; <xref:System.Windows.Forms.Control.Click>, <xref:System.Windows.Forms.Control.MouseClick>  
  
    -   Дважды щелкните справа: Событие щелчка не вызывается  
  
-   <xref:System.Windows.Forms.TextBox>, <xref:System.Windows.Forms.RichTextBox>, <xref:System.Windows.Forms.ListBox>, <xref:System.Windows.Forms.MaskedTextBox>, и <xref:System.Windows.Forms.CheckedListBox> элементов управления  
  
    > [!NOTE]
    >  Если пользователь щелкает любое место внутри этих элементов управления, то возникают описанные ниже события.  
  
    -   Щелчок левой кнопкой: <xref:System.Windows.Forms.Control.Click>, <xref:System.Windows.Forms.Control.MouseClick>  
  
    -   Щелкните правой кнопкой мыши: Событие щелчка не вызывается  
  
    -   Двойной щелчок левой: <xref:System.Windows.Forms.Control.Click>, <xref:System.Windows.Forms.Control.MouseClick>, <xref:System.Windows.Forms.Control.DoubleClick>, <xref:System.Windows.Forms.Control.MouseDoubleClick>  
  
    -   Дважды щелкните справа: Событие щелчка не вызывается  
  
-   <xref:System.Windows.Forms.ListView> элемент управления  
  
    > [!NOTE]
    >  Указанные ниже события возникают только в том случае, если пользователь щелкает элементы в <xref:System.Windows.Forms.ListView>. Если пользователь щелкает мышью в любом другом месте элемента управления, то события не вызываются. В дополнение к событиям, описанным ниже, существуют события <xref:System.Windows.Forms.ListView.BeforeLabelEdit> и <xref:System.Windows.Forms.ListView.AfterLabelEdit>, которые могут представлять интерес, если нужно выполнять проверку с помощью элемента управления <xref:System.Windows.Forms.ListView>.  
  
    -   Щелчок левой кнопкой: <xref:System.Windows.Forms.Control.Click>, <xref:System.Windows.Forms.Control.MouseClick>  
  
    -   Щелкните правой кнопкой мыши: <xref:System.Windows.Forms.Control.Click>, <xref:System.Windows.Forms.Control.MouseClick>  
  
    -   Двойной щелчок левой: <xref:System.Windows.Forms.Control.Click>, <xref:System.Windows.Forms.Control.MouseClick>; <xref:System.Windows.Forms.Control.DoubleClick>, <xref:System.Windows.Forms.Control.MouseDoubleClick>  
  
    -   Справа дважды щелкните: <xref:System.Windows.Forms.Control.Click>, <xref:System.Windows.Forms.Control.MouseClick>; <xref:System.Windows.Forms.Control.DoubleClick>, <xref:System.Windows.Forms.Control.MouseDoubleClick>  
  
-   <xref:System.Windows.Forms.TreeView> элемент управления  
  
    > [!NOTE]
    >  Указанные ниже события возникают только в том случае, если пользователь щелкает сами элементы или справа от них в элементе управления <xref:System.Windows.Forms.TreeView>. Если пользователь щелкает мышью в любом другом месте элемента управления, то события не вызываются. В дополнение к событиям, описанным ниже, существуют события <xref:System.Windows.Forms.TreeView.BeforeCheck>, <xref:System.Windows.Forms.TreeView.BeforeSelect>, <xref:System.Windows.Forms.TreeView.BeforeLabelEdit>, <xref:System.Windows.Forms.TreeView.AfterSelect>, <xref:System.Windows.Forms.TreeView.AfterCheck> и <xref:System.Windows.Forms.TreeView.AfterLabelEdit>, которые могут представлять интерес, если нужно выполнять проверку с помощью элемента управления <xref:System.Windows.Forms.TreeView>.  
  
    -   Щелчок левой кнопкой: <xref:System.Windows.Forms.Control.Click>, <xref:System.Windows.Forms.Control.MouseClick>  
  
    -   Щелкните правой кнопкой мыши: <xref:System.Windows.Forms.Control.Click>, <xref:System.Windows.Forms.Control.MouseClick>  
  
    -   Двойной щелчок левой: <xref:System.Windows.Forms.Control.Click>, <xref:System.Windows.Forms.Control.MouseClick>; <xref:System.Windows.Forms.Control.DoubleClick>, <xref:System.Windows.Forms.Control.MouseDoubleClick>  
  
    -   Справа дважды щелкните: <xref:System.Windows.Forms.Control.Click>, <xref:System.Windows.Forms.Control.MouseClick>; <xref:System.Windows.Forms.Control.DoubleClick>, <xref:System.Windows.Forms.Control.MouseDoubleClick>  
  
### <a name="painting-behavior-of-toggle-controls"></a>Поведение отрисовки для переключателей  
 Переключатели, такие как элементы управления, производные от класса <xref:System.Windows.Forms.ButtonBase>, имеют описанное ниже нестандартное поведение отрисовки в сочетании с событиями щелчка.  
  
1. Пользователь нажимает кнопку мыши.  
  
2. Элемент управления отрисовывается в состоянии "нажато".  
  
3. Возникает событие <xref:System.Windows.Forms.Control.MouseDown>.  
  
4. Пользователь отпускает кнопку мыши.  
  
5. Элемент управления отрисовывается в состоянии "отпущено".  
  
6. Возникает событие <xref:System.Windows.Forms.Control.Click>.  
  
7. Возникает событие <xref:System.Windows.Forms.Control.MouseClick>.  
  
8. Возникает событие <xref:System.Windows.Forms.Control.MouseUp>.  
  
    > [!NOTE]
    >  Если пользователь перемещает указатель за границы переключателя при нажатой кнопке мыши (например, перемещает указатель мыши за границы элемента управления <xref:System.Windows.Forms.Button>, когда он нажат), переключатель будет отрисовываться в состоянии "отпущено" и происходит только событие <xref:System.Windows.Forms.Control.MouseUp>. События <xref:System.Windows.Forms.Control.Click> и <xref:System.Windows.Forms.Control.MouseClick> в этой ситуации не наступают.  
  
## <a name="see-also"></a>См. также

- [Ввод данных мышью в приложении Windows Forms](mouse-input-in-a-windows-forms-application.md)
