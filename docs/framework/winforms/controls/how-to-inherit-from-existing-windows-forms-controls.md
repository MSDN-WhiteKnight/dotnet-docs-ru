---
title: Практическое руководство. Наследование существующих элементов управления Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- inheritance [Windows Forms], Windows Forms custom controls
- custom controls [Windows Forms], inheritance
ms.assetid: 1e1fc8ea-c615-4cf0-a356-16d6df7444ab
ms.openlocfilehash: 788addee7c024577d029626da4aeb86d0ca9076a
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59300532"
---
# <a name="how-to-inherit-from-existing-windows-forms-controls"></a>Практическое руководство. Наследование существующих элементов управления Windows Forms
Чтобы расширить функциональные возможности существующего элемента управления, можно создать элемент управления, производный от существующего элемента управления, путем наследования. При наследовании из существующего элемента управления наследуются все его функциональные возможности и визуальные свойства. Например, если вы создаете элемент управления, который наследуется от <xref:System.Windows.Forms.Button>, новый элемент управления будет выглядеть и act, так же, как стандартный <xref:System.Windows.Forms.Button> элемента управления. После этого вы сможете расширить или изменить функциональность нового элемента управления, реализовав пользовательские методы и свойства. В некоторых элементах управления, можно также изменить внешний вид наследуемого элемента управления путем переопределения его <xref:System.Windows.Forms.Control.OnPaint%2A> метод.  
  
> [!NOTE]
>  Отображаемые диалоговые окна и команды меню могут отличаться от описанных в справке в зависимости от текущих параметров или выпуска. Чтобы изменить параметры, выберите в меню **Сервис** пункт **Импорт и экспорт параметров** . Дополнительные сведения см. в разделе [Персонализация интегрированной среды разработки Visual Studio](/visualstudio/ide/personalizing-the-visual-studio-ide).  
  
### <a name="to-create-an-inherited-control"></a>Создание наследуемого элемента управления  
  
1. Создайте проект **приложения Windows Forms**.  
  
2. В меню **Проект** выберите команду **Добавить новый элемент**.  
  
     Откроется диалоговое окно **Добавление нового элемента**.  
  
3. В диалоговом окне **Добавление нового элемента** дважды щелкните пункт **Пользовательский элемент управления**.  
  
     В ваш проект будет добавлен новый пользовательский элемент управления.  
  
4. Если используется Visual Basic, в верхней части окна **Обозреватель решений** щелкните параметр **Показать все файлы**. Разверните папку CustomControl1.vb и откройте файл CustomControl1.Designer.vb в редакторе кода.  
  
5. Если используется C#, откройте в редакторе кода файл CustomControl1.cs.  
  
6. Найдите объявление класса, который наследуется от <xref:System.Windows.Forms.Control>.  
  
7. Измените базовый класс для элемента управления, который нужно использовать для наследования.  
  
     Например, если вы хотите наследовать <xref:System.Windows.Forms.Button>, измените объявление класса следующим:  
  
    ```vb  
    Partial Class CustomControl1  
        Inherits System.Windows.Forms.Button  
    ```  
  
    ```csharp  
    public partial class CustomControl1 : System.Windows.Forms.Button  
    ```  
  
8. Если используется Visual Basic, сохраните и закройте файл CustomControl1.Designer.vb. Откройте файл CustomControl1.vb в редакторе кода.  
  
9. Реализуйте необходимые пользовательские методы или свойства, которые будут входить в ваш элемент управления.  
  
10. Если вы хотите изменить графический интерфейс элемента управления, переопределите <xref:System.Windows.Forms.Control.OnPaint%2A> метод.  
  
    > [!NOTE]
    >  Переопределение <xref:System.Windows.Forms.Control.OnPaint%2A> не позволит изменять внешний вид всех элементов управления. Элементы управления, оформленные средствами Windows (например, <xref:System.Windows.Forms.TextBox>) никогда не вызывать их <xref:System.Windows.Forms.Control.OnPaint%2A> метод и потому не использовать пользовательский код. См. в справочной документации для определенного элемента управления, нужно ли изменить <xref:System.Windows.Forms.Control.OnPaint%2A> метод доступен. Список всех элементов управления Windows Forms см. в разделе [Элементы управления для использования в формах Windows Forms](controls-to-use-on-windows-forms.md). Если элемент управления не имеет <xref:System.Windows.Forms.Control.OnPaint%2A> методов элемента в списке, вы не сможете изменить его внешний вид путем переопределения этого метода. Дополнительные сведения о пользовательском оформлении см. в разделе [Рисование и отрисовка пользовательского элемента управления](custom-control-painting-and-rendering.md).  
  
    ```vb  
    Protected Overrides Sub OnPaint(ByVal e As _  
       System.Windows.Forms.PaintEventArgs)  
       MyBase.OnPaint(e)  
       ' Insert code to do custom painting.   
       ' If you want to completely change the appearance of your control,  
       ' do not call MyBase.OnPaint(e).  
    End Sub  
    ```  
  
    ```csharp  
    protected override void OnPaint(PaintEventArgs pe)  
    {  
       base.OnPaint(pe);  
       // Insert code to do custom painting.  
       // If you want to completely change the appearance of your control,  
       // do not call base.OnPaint(pe).  
    }  
    ```  
  
11. Сохраните и проверьте элемент управления.  
  
## <a name="see-also"></a>См. также

- [Создание собственных элементов управления](varieties-of-custom-controls.md)
- [Практическое руководство. Наследование класса Control](how-to-inherit-from-the-control-class.md)
- [Практическое руководство. Наследование класса UserControl](how-to-inherit-from-the-usercontrol-class.md)
- [Практическое руководство. Создание элементов управления для форм Windows Forms](how-to-author-controls-for-windows-forms.md)
- [Устранение неполадок, связанных с унаследованными обработчиками событий, в Visual Basic](~/docs/visual-basic/programming-guide/language-features/events/troubleshooting-inherited-event-handlers.md)
- [Пошаговое руководство. Наследование элементов управления Windows Forms с помощью Visual Basic](walkthrough-inheriting-from-a-windows-forms-control-with-visual-basic.md)
- [Пошаговое руководство. Наследование элементов управления Windows Forms с помощью Visual C#](walkthrough-inheriting-from-a-windows-forms-control-with-visual-csharp.md)
