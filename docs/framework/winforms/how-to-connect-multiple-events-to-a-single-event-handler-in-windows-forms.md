---
title: Практическое руководство. Подключение нескольких событий к одному обработчику в Windows Forms
ms.date: 03/30/2017
dev_langs:
- vb
helpviewer_keywords:
- events [Windows Forms], connecting multiple to single event handler
- event handlers [Windows Forms], connecting events to
- menus [Windows Forms], event-handling methods for multiple menu items
- Windows Forms controls, events
- menu items [Windows Forms], multicasting event-handling methods
ms.assetid: 5a20749a-41b5-4acc-8eb1-9e5040b0a2c4
ms.openlocfilehash: eec6a754b885cd169e5542221caefb3233c4c8af
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59300727"
---
# <a name="how-to-connect-multiple-events-to-a-single-event-handler-in-windows-forms"></a>Практическое руководство. Подключение нескольких событий к одному обработчику в Windows Forms
При разработке приложения вам может понадобиться один обработчик событий, для нескольких событий, или несколько событий выполните ту же процедуру. Например часто бывает мощные-экономии времени была команда меню для вызова того же события, что кнопки на форме они предоставляют одинаковую функциональность. Это можно сделать с помощью представления "события" окна свойств в C# или с помощью `Handles` ключевое слово и **имя класса** и **имя метода** раскрывающиеся списки в редакторе кода Visual Basic.  
  
### <a name="to-connect-multiple-events-to-a-single-event-handler-in-visual-basic"></a>Для подключения нескольких событий к одному обработчику в Visual Basic  
  
1. Щелкните форму правой кнопкой мыши и выберите **Просмотр кода**.  
  
2. Из **имя класса** раскрывающегося списка, выберите один из элементов управления, которые требуется обработка обработчика событий.  
  
3. Из **имя метода** раскрывающегося списка, выберите один из события, которые обработчик событий для обработки.  
  
4. Редактор кода вставляет соответствующий обработчик событий и помещает курсор в методе. В приведенном ниже примере это <xref:System.Windows.Forms.Control.Click> событие для <xref:System.Windows.Forms.Button> элемента управления.  
  
    ```vb  
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click  
    ' Add event-handler code here.  
    End Sub  
    ```  
  
5. Добавьте другие события, хотелось бы обрабатывается для `Handles` предложение.  
  
    ```vb  
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click, Button2.Click  
    ' Add event-handler code here.  
    End Sub  
    ```  
  
6. Добавьте соответствующий код в обработчик событий.  
  
### <a name="to-connect-multiple-events-to-a-single-event-handler-in-c"></a>Для подключения нескольких событий к одному обработчику в C\#
  
1. Выберите элемент управления, к которому вы хотите подключить обработчик событий.  
  
2. В окне «Свойства» щелкните **события** кнопки (![кнопки событий](./media/vxeventsbutton-propertieswindow.png "vxEventsButton_PropertiesWindow")).  
  
3. Щелкните имя события, которое необходимо обработать.  
  
4. В разделе значений рядом с именем события нажмите кнопку раскрывающегося списка для отображения списка существующих обработчиков событий, которые соответствуют сигнатуре метода события, которое необходимо обработать.  
  
5. Выберите соответствующий обработчик событий из списка.  
  
     Код добавляется в форму для привязки события в существующий обработчик событий.  
  
## <a name="see-also"></a>См. также

- [Создание обработчиков событий в Windows Forms](creating-event-handlers-in-windows-forms.md)
- [Общие сведения об обработчиках событий](event-handlers-overview-windows-forms.md)
