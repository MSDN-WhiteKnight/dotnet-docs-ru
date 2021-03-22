---
title: Практическое руководство. Создание приложения Windows Forms из командной строки
ms.date: 03/14/2018
dev_langs:
- csharp
- vb
helpviewer_keywords:
- Windows Forms, application development from command line
- Windows Forms, getting started
- Windows Forms, creating basic form
ms.assetid: 45ad3f8b-1c26-4c9f-91a9-3bb0759a47a4
author: rpetrusha
ms.author: ronpet
ms.openlocfilehash: ce97089ec71fc910079910957e784605387f3e06
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59299877"
---
# <a name="how-to-create-a-windows-forms-application-from-the-command-line"></a>Практическое руководство. Создание приложения Windows Forms из командной строки
В процедурах ниже описаны основные шаги, которые необходимо выполнить для создания и запуска приложения Windows Forms из командной строки. Visual Studio предлагает расширенную поддержку этих процедур.  Также см. в разделе [Пошаговое руководство: Размещение Windows Forms элемента управления в WPF](../wpf/advanced/walkthrough-hosting-a-windows-forms-control-in-wpf.md).  
  
## <a name="procedure"></a>Процедура  
  
#### <a name="to-create-the-form"></a>Создание формы  
  
1. В пустом файле кода введите следующие операторы import или using:  
  
     [!code-csharp[System.Windows.Forms.BasicForm#2](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.BasicForm/CS/Form1.cs#2)]
       
  
2. Объявите класс с именем `Form1`, наследуемый от класса Form.  
  
     [!code-csharp[System.Windows.Forms.BasicForm#3](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.BasicForm/CS/Form1.cs#3)]
       
  
3. Создайте конструктор по умолчанию для класса `Form1`.  
  
     В следующий процедуре будет добавлен дополнительный код конструктора.  
  
     [!code-csharp[System.Windows.Forms.BasicForm#4](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.BasicForm/CS/Form1.cs#4)]
       
  
4. Добавьте в класс метод `Main`.  
  
    1.  Применить <xref:System.STAThreadAttribute> в C# `Main` метод, чтобы указать приложения Windows Forms является однопотоковое подразделение. (Атрибут не требуется в Visual Basic, так как приложения Windows forms разработанных с помощью Visual Basic используйте модели однопотоковое подразделение по умолчанию.)  
  
    2.  Вызовите <xref:System.Windows.Forms.Application.EnableVisualStyles%2A> применение стилей операционной системы для приложения.  
  
    3.  Создайте экземпляр формы и запустите его.  
  
     [!code-csharp[System.Windows.Forms.BasicForm#5](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.BasicForm/CS/Form1.cs#5)]
       
  
#### <a name="to-compile-and-run-the-application"></a>Компиляция и запуск приложения  
  
1. В командной строке .NET Framework перейдите к папке, в которой содержится класс `Form1`.  
  
2. Скомпилируйте форму.  
  
    -   Если вы используете C#, введите: `csc form1.cs`  
  
         `-or-`  
  
    -   Если вы используете Visual Basic, введите: `vbc form1.vb`  
  
3. В командной строке введите следующее: `Form1.exe`  
  
## <a name="adding-a-control-and-handling-an-event"></a>Добавление элемента управления и обработка события  
 В предыдущей процедуре продемонстрировано, как создать простейшую форму Windows Forms, скомпилировать и запустить ее. В следующей процедуре будет показано, как создать и добавить в форму элемент управления и как обрабатывать событие для него. Дополнительные сведения об элементах управления, можно добавить в формы Windows Forms, см. в разделе [элементов управления Windows Forms](./controls/index.md).  
  
 Помимо понимания способов создания приложений Windows Forms, следует обладать общими знаниями о программировании на основе событий и способах обработки данных, введенных пользователем. Дополнительные сведения см. в разделе [Создание обработчиков событий в Windows Forms](creating-event-handlers-in-windows-forms.md), и [Обработка введенных пользователем данных](./controls/handling-user-input.md)  
  
#### <a name="to-declare-a-button-control-and-handle-its-click-event"></a>Объявление элемента управления типа "Кнопка" и обработка событий щелчка мышью для нее  
  
1. Объявите элемент управления типа "Кнопка" с именем `button1`.  
  
2. В конструкторе создайте кнопку и задайте ее свойства <xref:System.Windows.Forms.Control.Size%2A>, <xref:System.Windows.Forms.Control.Location%2A> и <xref:System.Windows.Forms.Control.Text%2A>.  
  
3. Добавьте кнопку в форму.  
  
     В примере кода ниже показано, как объявить элемент управления типа "Кнопка".  
  
     [!code-csharp[System.Windows.Forms.FormWithButton#2](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.FormWithButton/CS/Form1.cs#2)]
       
  
4. Создайте метод для обработки события <xref:System.Windows.Forms.Control.Click> для кнопки.  
  
5. В обработчике событий щелчка мышью выведите элемент управления <xref:System.Windows.Forms.MessageBox> с сообщением "Здравствуй, мир".  
  
     В примере кода ниже демонстрируется, как обрабатывать событие щелчка мышью для элемента управления типа "Кнопка".  
  
     [!code-csharp[System.Windows.Forms.FormWithButton#3](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.FormWithButton/CS/Form1.cs#3)]
       
  
6. Свяжите событие <xref:System.Windows.Forms.Control.Click> с созданным методом.  
  
     В примере кода ниже показано, как связать событие с методом.  
  
     [!code-csharp[System.Windows.Forms.FormWithButton#4](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.FormWithButton/CS/Form1.cs#4)]
       
  
7. Скомпилируйте и запустите приложение, как описано в предыдущей процедуре.  
  
## <a name="example"></a>Пример  
 В примере кода ниже полностью представлены все предыдущие процедуры.  
  
 [!code-csharp[System.Windows.Forms.FormWithButton#1](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.FormWithButton/CS/Form1.cs#1)]
   
  
## <a name="compiling-the-code"></a>Компиляция кода  
  
-   Для компиляции кода следуйте инструкциям из предыдущей процедуры, описывающим, как скомпилировать и запустить приложение.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.Form>
- <xref:System.Windows.Forms.Control>
- [Изменение внешнего вида Windows Forms](changing-the-appearance-of-windows-forms.md)
- [Усовершенствование приложений Windows Forms](./advanced/index.md)
- [Приступая к работе с Windows Forms](getting-started-with-windows-forms.md)
