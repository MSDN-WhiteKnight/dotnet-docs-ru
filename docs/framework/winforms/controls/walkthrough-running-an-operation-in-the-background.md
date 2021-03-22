---
title: Пошаговое руководство. Фоновое выполнение операции
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- background tasks
- forms [Windows Forms], multithreading
- forms [Windows Forms], background operations
- background threads
- BackgroundWorker class [Windows Forms], examples
- threading [Windows Forms], background operations
- background operations
ms.assetid: 1b9a4e0a-f134-48ff-a1be-c461446a31ba
ms.openlocfilehash: c1881ffa1c6fca546b086efea59d2263af853949
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59308449"
---
# <a name="walkthrough-running-an-operation-in-the-background"></a>Пошаговое руководство. Фоновое выполнение операции
Если какая-либо операция будет выполняться в течение долгого времени и при этом требуется не допустить задержек в работе пользовательского интерфейса, можно использовать класс <xref:System.ComponentModel.BackgroundWorker> для выполнения операции в другом потоке.  
  
 Полный код, используемый в этом примере, см. в разделе [как: Фоновое выполнение операции](how-to-run-an-operation-in-the-background.md).  
  
> [!NOTE]
>  Отображаемые диалоговые окна и команды меню могут отличаться от описанных в справке в зависимости от текущих параметров или выпуска. Чтобы изменить параметры, выберите в меню **Сервис** пункт **Импорт и экспорт параметров** . Дополнительные сведения см. в разделе [Персонализация интегрированной среды разработки Visual Studio](/visualstudio/ide/personalizing-the-visual-studio-ide).  
  
### <a name="to-run-an-operation-in-the-background"></a>Для запуска операции в фоновом режиме  
  
1. Форма будет открыта в конструкторе Windows Forms, перетащите два <xref:System.Windows.Forms.Button> управляет из **элементов** форму, а затем задайте `Name` и <xref:System.Windows.Forms.Control.Text%2A> свойства кнопок согласно следующей таблице.  
  
    |Кнопка|name|Текста|  
    |------------|----------|----------|  
    |`button1`|`startBtn`|**Запуск**|  
    |`button2`|`cancelBtn`|**Отмена**|  
  
2. Откройте **элементов**, нажмите кнопку **компоненты** вкладке, а затем перетащите <xref:System.ComponentModel.BackgroundWorker> в форму компонент.  
  
     `backgroundWorker1` Компонент появится в **область компонентов**.  
  
3. В окне **Свойства** присвойте свойству <xref:System.ComponentModel.BackgroundWorker.WorkerSupportsCancellation%2A> значение `true`.  
  
4. В **свойства** щелкните **события** кнопку, а затем дважды щелкните <xref:System.ComponentModel.BackgroundWorker.DoWork> и <xref:System.ComponentModel.BackgroundWorker.RunWorkerCompleted> событий, чтобы создать обработчики событий.  
  
5. Вставьте код требует много времени в <xref:System.ComponentModel.BackgroundWorker.DoWork> обработчик событий.  
  
6. Извлечение всех параметров, необходимые для операции из <xref:System.ComponentModel.DoWorkEventArgs.Argument%2A> свойство <xref:System.ComponentModel.DoWorkEventArgs> параметр.  
  
7. Присвоить результат вычисления <xref:System.ComponentModel.DoWorkEventArgs.Result%2A> свойство <xref:System.ComponentModel.DoWorkEventArgs>.  
  
     Это будет предоставляться <xref:System.ComponentModel.BackgroundWorker.RunWorkerCompleted> обработчик событий.  
  
     [!code-csharp[System.ComponentModel.BackgroundWorker.Example#2](~/samples/snippets/csharp/VS_Snippets_Winforms/System.ComponentModel.BackgroundWorker.Example/CS/Form1.cs#2)]
       
  
8. Вставьте код для получения результата операции в <xref:System.ComponentModel.BackgroundWorker.RunWorkerCompleted> обработчик событий.  
  
     [!code-csharp[System.ComponentModel.BackgroundWorker.Example#3](~/samples/snippets/csharp/VS_Snippets_Winforms/System.ComponentModel.BackgroundWorker.Example/CS/Form1.cs#3)]
       
  
9. Выполните метод `TimeConsumingOperation`.  
  
     [!code-csharp[System.ComponentModel.BackgroundWorker.Example#4](~/samples/snippets/csharp/VS_Snippets_Winforms/System.ComponentModel.BackgroundWorker.Example/CS/Form1.cs#4)]
       
  
10. В конструкторе Windows Forms дважды щелкните `startButton` для создания <xref:System.Windows.Forms.Control.Click> обработчик событий.  
  
11. Вызовите <xref:System.ComponentModel.BackgroundWorker.RunWorkerAsync%2A> метод в <xref:System.Windows.Forms.Control.Click> обработчик событий для `startButton`.  
  
     [!code-csharp[System.ComponentModel.BackgroundWorker.Example#5](~/samples/snippets/csharp/VS_Snippets_Winforms/System.ComponentModel.BackgroundWorker.Example/CS/Form1.cs#5)]
       
  
12. В конструкторе Windows Forms дважды щелкните `cancelButton` для создания <xref:System.Windows.Forms.Control.Click> обработчик событий.  
  
13. Вызовите <xref:System.ComponentModel.BackgroundWorker.CancelAsync%2A> метод в <xref:System.Windows.Forms.Control.Click> обработчик событий для `cancelButton`.  
  
     [!code-csharp[System.ComponentModel.BackgroundWorker.Example#6](~/samples/snippets/csharp/VS_Snippets_Winforms/System.ComponentModel.BackgroundWorker.Example/CS/Form1.cs#6)]
       
  
14. В верхней части файла импортируйте пространства имен System.ComponentModel и System.Threading.  
  
     [!code-csharp[System.ComponentModel.BackgroundWorker.Example#7](~/samples/snippets/csharp/VS_Snippets_Winforms/System.ComponentModel.BackgroundWorker.Example/CS/Form1.cs#7)]
       
  
15. Нажмите клавишу F6 для построения решения и нажмите клавишу CTRL + F5, чтобы запустить приложение вне отладчика.  
  
> [!NOTE]
>  Если нажать клавишу F5 для запуска приложения в отладчике, то исключение, возникающее в `TimeConsumingOperation` метод перехватывается и отображается отладчиком. При запуске приложения вне отладчика, <xref:System.ComponentModel.BackgroundWorker> обрабатывает исключение и кэширует его в <xref:System.ComponentModel.AsyncCompletedEventArgs.Error%2A> свойство <xref:System.ComponentModel.RunWorkerCompletedEventArgs>.  
  
1. Нажмите кнопку **запустить** для запуска асинхронной операции, а затем нажмите кнопку **отменить** кнопка для остановки асинхронной операции.  
  
     Результат каждой операции выводится в элементе <xref:System.Windows.Forms.MessageBox>.  
  
## <a name="next-steps"></a>Следующие шаги  
  
-   Реализация формы, в которой отображается ход выполнения асинхронной операции. Дополнительные сведения см. в разделе [Как Реализация формы, в который выполняется фоновая операция](how-to-implement-a-form-that-uses-a-background-operation.md).  
  
-   Реализуйте класс, поддерживающий асинхронную модель для компонентов. Дополнительные сведения см. в разделе [реализации асинхронной модели на основе событий](../../../standard/asynchronous-programming-patterns/implementing-the-event-based-asynchronous-pattern.md).  
  
## <a name="see-also"></a>См. также

- <xref:System.ComponentModel.BackgroundWorker>
- <xref:System.ComponentModel.DoWorkEventArgs>
- [Практическое руководство. Реализация формы, в которой выполняется фоновая операция](how-to-implement-a-form-that-uses-a-background-operation.md)
- [Практическое руководство. Фоновое выполнение операции](how-to-run-an-operation-in-the-background.md)
- [Компонент BackgroundWorker](backgroundworker-component.md)
