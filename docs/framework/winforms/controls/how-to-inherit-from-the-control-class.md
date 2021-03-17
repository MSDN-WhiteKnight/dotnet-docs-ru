---
title: Практическое руководство. Наследование класса Control
ms.date: 03/30/2017
helpviewer_keywords:
- inheritance [Windows Forms], Windows Forms custom controls
- Control class [Windows Forms], inheriting from
- custom controls [Windows Forms], inheritance
- OnPaint method [Windows Forms]
- custom controls [Windows Forms], creating
ms.assetid: 46ba0df3-5cf7-443c-a3b4-a72660172476
ms.openlocfilehash: 14f225f5587379b3efa7b6dc2475f1b697ebb281
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59314221"
---
# <a name="how-to-inherit-from-the-control-class"></a>Практическое руководство. Наследование класса Control
Если вы хотите создать полностью пользовательский элемент управления для использования в Windows Forms, следует наследовать <xref:System.Windows.Forms.Control> класса. При наследовании <xref:System.Windows.Forms.Control> класса необходимо, чтобы выполнить более тщательного планирования и реализации также предоставляет широкий выбор вариантов. При наследовании от <xref:System.Windows.Forms.Control>, наследуются простейшие функции, обеспечивающие работоспособность элементов управления. Стандартные функции <xref:System.Windows.Forms.Control> класс обрабатывает входные данные с клавиатуры и мыши, определяют границы и размер элемента управления, обрабатывают окна и обеспечивают обработку сообщений и безопасность. Они не включают оформление (в данном случае отрисовку графического интерфейса элемента управления) или конкретные функции взаимодействия с пользователем. Все эти аспекты необходимо прописывать в пользовательском коде.  
  
> [!NOTE]
>  Отображаемые диалоговые окна и команды меню могут отличаться от описанных в справке в зависимости от текущих параметров или выпуска. Чтобы изменить параметры, выберите в меню **Сервис** пункт **Импорт и экспорт параметров** . Дополнительные сведения см. в разделе [Персонализация интегрированной среды разработки Visual Studio](/visualstudio/ide/personalizing-the-visual-studio-ide).  
  
### <a name="to-create-a-custom-control"></a>Создание пользовательского элемента управления  
  
1. Создайте проект **приложения Windows** или **библиотеки элементов управления Windows**.  
  
2. В меню **Проект** выберите команду **Добавить класс**.  
  
3. В диалоговом окне **Добавление нового элемента** щелкните пункт **Пользовательский элемент управления**.  
  
     В ваш проект будет добавлен новый пользовательский элемент управления.  
  
4. Нажмите клавишу F7, чтобы открыть **редактор кода** для пользовательского элемента управления.  
  
5. Найдите <xref:System.Windows.Forms.Control.OnPaint%2A> метод, который будет содержать только вызов <xref:System.Windows.Forms.Control.OnPaint%2A> метод базового класса.  
  
6. Измените код, добавив в него пользовательское оформление вашего элемента управления.  
  
     Сведения о написании кода для отрисовки графического интерфейса элементов управления см. в разделе [Рисование и отрисовка пользовательского элемента управления](custom-control-painting-and-rendering.md).  
  
7. Реализуйте необходимые пользовательские методы, свойства или события, которые будут входить в ваш элемент управления.  
  
8. Сохраните и проверьте элемент управления.  
  
## <a name="see-also"></a>См. также

- [Создание собственных элементов управления](varieties-of-custom-controls.md)
- [Практическое руководство. Наследование класса UserControl](how-to-inherit-from-the-usercontrol-class.md)
- [Практическое руководство. Наследование существующих элементов управления Windows Forms](how-to-inherit-from-existing-windows-forms-controls.md)
- [Практическое руководство. Создание элементов управления для форм Windows Forms](how-to-author-controls-for-windows-forms.md)
- [Устранение неполадок, связанных с унаследованными обработчиками событий, в Visual Basic](~/docs/visual-basic/programming-guide/language-features/events/troubleshooting-inherited-event-handlers.md)
- [Создание элементов управления Windows Forms во время разработки](developing-windows-forms-controls-at-design-time.md)
