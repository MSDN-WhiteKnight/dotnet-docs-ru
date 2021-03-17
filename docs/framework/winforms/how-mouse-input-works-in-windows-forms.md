---
title: Осуществление ввода мышью в Windows Forms
ms.date: 03/30/2017
helpviewer_keywords:
- Windows Forms, mouse input
- mouse [Windows Forms], input
ms.assetid: 48fc5240-75a6-44bf-9fce-6aa21b49705a
ms.openlocfilehash: c9193ffa9ef34f1e43a92feec230fa2282264147
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59203019"
---
# <a name="how-mouse-input-works-in-windows-forms"></a>Осуществление ввода мышью в Windows Forms
Получение и обработка ввода с мыши является важной частью каждое приложение Windows. Можно обработать события мыши для выполнения действий в приложении, или использовать сведения о расположении мыши для проверки нажатия или других действий. Кроме того можно изменить способ, элементы управления в приложении обрабатывать ввод от мыши. В этом разделе описываются события мыши в подробности, а также как получать и изменять параметры системы для мыши. Дополнительные сведения о данных, передаваемых с помощью мыши вызываются события и порядок, в котором события щелчка мыши, см. в разделе [события мыши в Windows Forms](mouse-events-in-windows-forms.md).  
  
## <a name="mouse-location-and-hit-testing"></a>Положение указателя мыши и попадания  
 Когда пользователь перемещает мышь, операционная система перемещает указатель мыши. Указатель содержит один пиксель, называется активной точкой, которой операционная система отслеживает и распознает как положения указателя. Когда пользователь перемещает мышь или нажимает кнопку мыши, <xref:System.Windows.Forms.Control> , содержащий <xref:System.Windows.Forms.Cursor.HotSpot%2A> вызывает соответствующее событие мыши. Вы можете получить текущее положение мыши с <xref:System.Windows.Forms.MouseEventArgs.Location%2A> свойство <xref:System.Windows.Forms.MouseEventArgs> при обработке события мыши или с помощью <xref:System.Windows.Forms.Cursor.Position%2A> свойство <xref:System.Windows.Forms.Cursor> класса. Можно впоследствии использовать сведения о расположении мыши для проверки нажатия и затем выполнить действие на основе расположения указателя мыши. Проверка нажатия возможности встроены некоторые элементы управления Windows Forms такие как <xref:System.Windows.Forms.ListView>, <xref:System.Windows.Forms.TreeView>, <xref:System.Windows.Forms.MonthCalendar> и <xref:System.Windows.Forms.DataGridView> элементов управления. Используется с соответствующее событие мыши, <xref:System.Windows.Forms.Control.MouseHover> к примеру, попадания очень полезен для определения, когда приложение должно выполнить определенное действие.  
  
## <a name="mouse-events"></a>События мыши  
 Для обработки событий мыши является основным способом реагировать на ввод с помощью мыши. В следующей таблице перечислены события мыши и описывает, когда они вызываются.  
  
|Событие мыши|Описание|  
|-----------------|-----------------|  
|<xref:System.Windows.Forms.Control.Click>|Это событие происходит при отпускании кнопки мыши, обычно перед <xref:System.Windows.Forms.Control.MouseUp> событий. Обработчик этого события принимает аргумент типа <xref:System.EventArgs>. Обработайте это событие, когда нужно только определить, когда происходит щелчок.|  
|<xref:System.Windows.Forms.Control.MouseClick>|Это событие происходит, когда пользователь щелкает мышью элемент управления. Обработчик этого события принимает аргумент типа <xref:System.Windows.Forms.MouseEventArgs>. Обработайте это событие, когда требуется получить сведения о мыши, когда происходит щелчок.|  
|<xref:System.Windows.Forms.Control.DoubleClick>|Это событие возникает при двойном щелчке элемента управления. Обработчик этого события принимает аргумент типа <xref:System.EventArgs>. Обработайте это событие, когда нужно только определить, когда происходит двойной щелчок.|  
|<xref:System.Windows.Forms.Control.MouseDoubleClick>|Это событие происходит, когда пользователь дважды щелкает мышью элемент управления. Обработчик этого события принимает аргумент типа <xref:System.Windows.Forms.MouseEventArgs>. Обработайте это событие, когда требуется получить сведения о мыши, когда происходит двойной щелчок.|  
|<xref:System.Windows.Forms.Control.MouseDown>|Это событие происходит, когда указатель мыши находится над элементом управления, и пользователь нажимает кнопку мыши. Обработчик этого события принимает аргумент типа <xref:System.Windows.Forms.MouseEventArgs>.|  
|<xref:System.Windows.Forms.Control.MouseEnter>|Это событие происходит, когда указатель мыши пересекает границы или клиентскую область элемента управления, в зависимости от типа элемента управления. Обработчик этого события принимает аргумент типа <xref:System.EventArgs>.|  
|<xref:System.Windows.Forms.Control.MouseHover>|Это событие происходит, когда указатель мыши останавливается и над элементом управления. Обработчик этого события принимает аргумент типа <xref:System.EventArgs>.|  
|<xref:System.Windows.Forms.Control.MouseLeave>|Это событие происходит, когда указатель мыши покидает границы или клиентскую область элемента управления, в зависимости от типа элемента управления. Обработчик этого события принимает аргумент типа <xref:System.EventArgs>.|  
|<xref:System.Windows.Forms.Control.MouseMove>|Это событие возникает при перемещении указателя мыши, когда оно находится над элементом управления. Обработчик этого события принимает аргумент типа <xref:System.Windows.Forms.MouseEventArgs>.|  
|<xref:System.Windows.Forms.Control.MouseUp>|Это событие происходит, когда указатель мыши находится над элементом управления и пользователь отпускается кнопку мыши. Обработчик этого события принимает аргумент типа <xref:System.Windows.Forms.MouseEventArgs>.|  
|<xref:System.Windows.Forms.Control.MouseWheel>|Это событие происходит при вращении колесика мыши, когда элемент управления имеет фокус. Обработчик этого события принимает аргумент типа <xref:System.Windows.Forms.MouseEventArgs>. Можно использовать <xref:System.Windows.Forms.MouseEventArgs.Delta%2A> свойство <xref:System.Windows.Forms.MouseEventArgs> для определения того, насколько прокручена мышь.|  
  
## <a name="changing-mouse-input-and-detecting-system-settings"></a>Изменение ввода мыши и определение системных параметров  
 Можно определить и изменить способ, элемент управления обрабатывает ввод от мыши путем создания производного элемента управления и использования <xref:System.Windows.Forms.Control.GetStyle%2A> и <xref:System.Windows.Forms.Control.SetStyle%2A> методы. <xref:System.Windows.Forms.Control.SetStyle%2A> Метод принимает побитовое сочетание <xref:System.Windows.Forms.ControlStyles> значения, чтобы определить, будет ли элемент управления иметь стандартный щелкните или дважды щелкните поведение, или если элемент управления будет обрабатывать обработку. Кроме того <xref:System.Windows.Forms.SystemInformation> класс включает свойства, которые описывают возможности мыши и укажите, как мышь взаимодействует с операционной системой. В следующей таблице перечислены эти свойства.  
  
|Свойство|Описание|  
|--------------|-----------------|  
|<xref:System.Windows.Forms.SystemInformation.DoubleClickSize%2A>|Получает размеры в пикселях, области, в котором пользователь должен щелкнуть дважды, чтобы операционная система обработала два щелчка как двойной щелчок.|  
|<xref:System.Windows.Forms.SystemInformation.DoubleClickTime%2A>|Получает максимальное число миллисекунд, которое может пройти между первым и вторым щелчком, чтобы операционная система обработала действия мыши как двойной щелчок.|  
|<xref:System.Windows.Forms.SystemInformation.MouseButtons%2A>|Возвращает число кнопок мыши.|  
|<xref:System.Windows.Forms.SystemInformation.MouseButtonsSwapped%2A>|Возвращает значение, указывающее, могут ли меняться местами функции левой и правой кнопок мыши.|  
|<xref:System.Windows.Forms.SystemInformation.MouseHoverSize%2A>|Возвращает размеры прямоугольника (в пикселях), в котором должен находиться указатель мыши в течение времени наведения мыши перед тем, как создается сообщение о наведении мыши.|  
|<xref:System.Windows.Forms.SystemInformation.MouseHoverTime%2A>|Возвращает интервал времени (в миллисекундах), в течение которого указатель мыши должен оставаться в прямоугольнике наведения перед тем, как вызывается сообщение о наведении мыши.|  
|<xref:System.Windows.Forms.SystemInformation.MousePresent%2A>|Получает значение, указывающее, установлена ли мышь.|  
|<xref:System.Windows.Forms.SystemInformation.MouseSpeed%2A>|Получает значение, указывающее текущую скорость мыши от 1 до 20.|  
|<xref:System.Windows.Forms.SystemInformation.MouseWheelPresent%2A>|Возвращает значение, указывающее, установлена ли мышь с колесом прокрутки.|  
|<xref:System.Windows.Forms.SystemInformation.MouseWheelScrollDelta%2A>|Получает значение приращения одном повороте колесика мыши.|  
|<xref:System.Windows.Forms.SystemInformation.MouseWheelScrollLines%2A>|Возвращает число строк, прокручиваемых при вращении колесика мыши.|  
  
## <a name="see-also"></a>См. также

- [Ввод данных мышью в приложении Windows Forms](mouse-input-in-a-windows-forms-application.md)
- [Захват мыши в Windows Forms](mouse-capture-in-windows-forms.md)
- [Указатели мыши в Windows Forms](mouse-pointers-in-windows-forms.md)
