---
title: Пошаговое руководство. Реализация виртуального режима для элемента управления DataGridView в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- data [Windows Forms], managing large data sets
- DataGridView control [Windows Forms], virtual mode
- virtual mode [Windows Forms], walkthroughs
- DataGridView control [Windows Forms], large data sets
- walkthroughs [Windows Forms], DataGridView control
ms.assetid: 74eb5276-5ab8-4ce0-8005-dae751d85f7c
ms.openlocfilehash: 7f6bf1703a6536f4d22b3a2fbe412579c59d39dd
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59344329"
---
# <a name="walkthrough-implementing-virtual-mode-in-the-windows-forms-datagridview-control"></a>Пошаговое руководство. Реализация виртуального режима для элемента управления DataGridView в Windows Forms
Если вы хотите отобразить очень большому количеству табличные данные в <xref:System.Windows.Forms.DataGridView> элемента управления, можно задать <xref:System.Windows.Forms.DataGridView.VirtualMode%2A> свойства `true` и явно управлять взаимодействием элемента управления с хранилищем данных. Это позволяет оптимизировать производительность элемента управления в этой ситуации.  
  
 <xref:System.Windows.Forms.DataGridView> Управления предусмотрено несколько событий, которые можно обрабатывать для взаимодействия с хранилищем пользовательских данных. В этом пошаговом руководстве поможет выполнить процесс реализации этих обработчиков событий. В примере кода в этом разделе используется очень простой источник данных для иллюстрации. На практике, обычно загружаются только те строки, необходимые для отображения в кэше и обрабатывать <xref:System.Windows.Forms.DataGridView> события для взаимодействия с кэшем и его обновления. Дополнительные сведения см. в разделе [реализация виртуального режима с JIT-загрузкой данных в элементе управления DataGridView Windows Forms](implementing-virtual-mode-jit-data-loading-in-the-datagrid.md)  
  
 Чтобы скопировать код из этого раздела единым блоком, см. раздел [Практическое руководство. Реализация виртуального режима в Windows Forms элемента управления DataGridView](how-to-implement-virtual-mode-in-the-windows-forms-datagridview-control.md).  
  
## <a name="creating-the-form"></a>Создание формы  
  
#### <a name="to-implement-virtual-mode"></a>Реализация виртуального режима  
  
1. Создайте класс, производный от <xref:System.Windows.Forms.Form> и содержит <xref:System.Windows.Forms.DataGridView> элемента управления.  
  
     Следующий код содержит некоторые основные инициализации. Он объявляется несколько переменных, которые будут использоваться на последующих этапах, предоставляет `Main` метод и предоставляет простой макет формы в конструкторе класса.  
  
     [!code-cpp[System.Windows.Forms.DataGridView.VirtualMode#001](~/samples/snippets/cpp/VS_Snippets_Winforms/System.Windows.Forms.DataGridView.VirtualMode/CPP/virtualmode.cpp#001)]
     [!code-csharp[System.Windows.Forms.DataGridView.VirtualMode#001](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataGridView.VirtualMode/CS/virtualmode.cs#001)]
       
    [!code-cpp[System.Windows.Forms.DataGridView.VirtualMode#002](~/samples/snippets/cpp/VS_Snippets_Winforms/System.Windows.Forms.DataGridView.VirtualMode/CPP/virtualmode.cpp#002)]
    [!code-csharp[System.Windows.Forms.DataGridView.VirtualMode#002](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataGridView.VirtualMode/CS/virtualmode.cs#002)]
      
  
2. Реализовать обработчик для формы <xref:System.Windows.Forms.Form.Load> событие, которое инициализирует <xref:System.Windows.Forms.DataGridView> управления и заполняет хранилище данных с помощью образцов значений.  
  
     [!code-cpp[System.Windows.Forms.DataGridView.VirtualMode#110](~/samples/snippets/cpp/VS_Snippets_Winforms/System.Windows.Forms.DataGridView.VirtualMode/CPP/virtualmode.cpp#110)]
     [!code-csharp[System.Windows.Forms.DataGridView.VirtualMode#110](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataGridView.VirtualMode/CS/virtualmode.cs#110)]
       
  
3. Реализовать обработчик для <xref:System.Windows.Forms.DataGridView.CellValueNeeded> событие, которое извлекает запрошенное значение ячейки из хранилища данных или `Customer` объекта, находящегося в режиме редактирования.  
  
     Это событие возникает каждый раз, когда <xref:System.Windows.Forms.DataGridView> элемента управления требуется прорисовать ячейку.  
  
     [!code-cpp[System.Windows.Forms.DataGridView.VirtualMode#120](~/samples/snippets/cpp/VS_Snippets_Winforms/System.Windows.Forms.DataGridView.VirtualMode/CPP/virtualmode.cpp#120)]
     [!code-csharp[System.Windows.Forms.DataGridView.VirtualMode#120](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataGridView.VirtualMode/CS/virtualmode.cs#120)]
       
  
4. Реализовать обработчик для <xref:System.Windows.Forms.DataGridView.CellValuePushed> события, которое сохраняет измененное значение ячейки в `Customer` объект, представляющий редактируемой строки. Это событие возникает каждый раз, когда пользователь фиксирует изменение значения ячейки.  
  
     [!code-cpp[System.Windows.Forms.DataGridView.VirtualMode#130](~/samples/snippets/cpp/VS_Snippets_Winforms/System.Windows.Forms.DataGridView.VirtualMode/CPP/virtualmode.cpp#130)]
     [!code-csharp[System.Windows.Forms.DataGridView.VirtualMode#130](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataGridView.VirtualMode/CS/virtualmode.cs#130)]
       
  
5. Реализовать обработчик для <xref:System.Windows.Forms.DataGridView.NewRowNeeded> событие, которое создает новый `Customer` объект, представляющий только что созданной строки.  
  
     Это событие возникает каждый раз, когда пользователь вводит строку для новых записей.  
  
     [!code-cpp[System.Windows.Forms.DataGridView.VirtualMode#140](~/samples/snippets/cpp/VS_Snippets_Winforms/System.Windows.Forms.DataGridView.VirtualMode/CPP/virtualmode.cpp#140)]
     [!code-csharp[System.Windows.Forms.DataGridView.VirtualMode#140](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataGridView.VirtualMode/CS/virtualmode.cs#140)]
       
  
6. Реализовать обработчик для <xref:System.Windows.Forms.DataGridView.RowValidated> событие, которое сохраняет новые или измененные строки в хранилище данных.  
  
     Это событие возникает каждый раз, когда пользователь изменяет текущую строку.  
  
     [!code-cpp[System.Windows.Forms.DataGridView.VirtualMode#150](~/samples/snippets/cpp/VS_Snippets_Winforms/System.Windows.Forms.DataGridView.VirtualMode/CPP/virtualmode.cpp#150)]
     [!code-csharp[System.Windows.Forms.DataGridView.VirtualMode#150](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataGridView.VirtualMode/CS/virtualmode.cs#150)]
       
  
7. Реализовать обработчик для <xref:System.Windows.Forms.DataGridView.RowDirtyStateNeeded> событие, указывающее, является ли <xref:System.Windows.Forms.DataGridView.CancelRowEdit> событие произойдет в том случае, если пользователь восстанавливает строку, нажав клавишу ESC, дважды в режиме редактирования или один раз в другом режиме.  
  
     По умолчанию <xref:System.Windows.Forms.DataGridView.CancelRowEdit> происходит при восстановлении строки, если ни одной из ячеек в текущей строке были изменены, если не <xref:System.Windows.Forms.QuestionEventArgs.Response%2A?displayProperty=nameWithType> свойству `true` в <xref:System.Windows.Forms.DataGridView.RowDirtyStateNeeded> обработчик событий. Это событие полезно в тех случаях, когда область фиксации определяется во время выполнения.  
  
     [!code-cpp[System.Windows.Forms.DataGridView.VirtualMode#160](~/samples/snippets/cpp/VS_Snippets_Winforms/System.Windows.Forms.DataGridView.VirtualMode/CPP/virtualmode.cpp#160)]
     [!code-csharp[System.Windows.Forms.DataGridView.VirtualMode#160](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataGridView.VirtualMode/CS/virtualmode.cs#160)]
       
  
8. Реализовать обработчик для <xref:System.Windows.Forms.DataGridView.CancelRowEdit> событий, который удаляет значения `Customer` объект, представляющий текущую строку.  
  
     Это событие происходит, если пользователь восстанавливает строку, нажав клавишу ESC, дважды в режиме редактирования или один раз в другом режиме. Это событие не происходит, если ячейки отсутствуют в текущей строке были изменены или если значение <xref:System.Windows.Forms.QuestionEventArgs.Response%2A?displayProperty=nameWithType> было присвоено свойство `false` в <xref:System.Windows.Forms.DataGridView.RowDirtyStateNeeded> обработчик событий.  
  
     [!code-cpp[System.Windows.Forms.DataGridView.VirtualMode#170](~/samples/snippets/cpp/VS_Snippets_Winforms/System.Windows.Forms.DataGridView.VirtualMode/CPP/virtualmode.cpp#170)]
     [!code-csharp[System.Windows.Forms.DataGridView.VirtualMode#170](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataGridView.VirtualMode/CS/virtualmode.cs#170)]
       
  
9. Реализовать обработчик для <xref:System.Windows.Forms.DataGridView.UserDeletingRow> событие, которое удаляет существующий `Customer` объекта из хранилища данных или отменяет несохраненный `Customer` объект, представляющий только что созданной строки.  
  
     Это событие возникает каждый раз, когда пользователь удаляет строку, при щелчке заголовка строки и нажав клавишу DELETE.  
  
     [!code-cpp[System.Windows.Forms.DataGridView.VirtualMode#180](~/samples/snippets/cpp/VS_Snippets_Winforms/System.Windows.Forms.DataGridView.VirtualMode/CPP/virtualmode.cpp#180)]
     [!code-csharp[System.Windows.Forms.DataGridView.VirtualMode#180](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataGridView.VirtualMode/CS/virtualmode.cs#180)]
       
  
10. Реализовать простой `Customers` класс для представления элементов данных, используемых в этом примере кода.  
  
     [!code-cpp[System.Windows.Forms.DataGridView.VirtualMode#200](~/samples/snippets/cpp/VS_Snippets_Winforms/System.Windows.Forms.DataGridView.VirtualMode/CPP/virtualmode.cpp#200)]
     [!code-csharp[System.Windows.Forms.DataGridView.VirtualMode#200](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataGridView.VirtualMode/CS/virtualmode.cs#200)]
       
  
## <a name="testing-the-application"></a>Тестирование приложения  
 Теперь можно проверить форму, чтобы убедиться, что она правильно работает.  
  
#### <a name="to-test-the-form"></a>Чтобы проверить форму  
  
-   Скомпилируйте и запустите приложение.  
  
     Вы увидите <xref:System.Windows.Forms.DataGridView> управления с тремя записями клиентов. Можно изменить значения нескольких ячеек в строке и нажмите клавишу ESC, дважды в режиме редактирования и один раз за пределами режим редактирования, чтобы вернуть всю строку к исходным значениям. Когда изменения, добавления или удаления строк в элементе управления `Customer` объектов в хранилище данных будут изменены, добавлены или удалены.  
  
## <a name="next-steps"></a>Следующие шаги  
 Это приложение позволяет основные события, необходимо обработать для реализации виртуального режима в <xref:System.Windows.Forms.DataGridView> элемента управления. Вы можете улучшить это основное приложение несколькими способами:  
  
-   Реализуйте хранилище данных, которое кэширует значения из внешней базы данных. Кэш извлекает и отменяет по необходимости, чтобы он содержал только необходимые для отображения при использовании небольшой объем памяти на клиентском компьютере.  
  
-   Оптимизировать производительность хранилища данных в зависимости от требований. Например можно компенсировать медленные сетевые подключения, а не ограничения памяти клиентского компьютера с помощью большего размера кэша, сводя к минимуму число запросов к базе данных.  
  
 Дополнительные сведения о кэшировании значений из внешней базы данных, см. в разделе [как: Реализация виртуального режима с JIT в загрузкой данных в Windows Forms элемента управления DataGridView](virtual-mode-with-just-in-time-data-loading-in-the-datagrid.md).  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.DataGridView>
- <xref:System.Windows.Forms.DataGridView.VirtualMode%2A>
- <xref:System.Windows.Forms.DataGridView.CellValueNeeded>
- <xref:System.Windows.Forms.DataGridView.CellValuePushed>
- <xref:System.Windows.Forms.DataGridView.NewRowNeeded>
- <xref:System.Windows.Forms.DataGridView.RowValidated>
- <xref:System.Windows.Forms.DataGridView.RowDirtyStateNeeded>
- <xref:System.Windows.Forms.DataGridView.CancelRowEdit>
- <xref:System.Windows.Forms.DataGridView.UserDeletingRow>
- [Оптимизация производительности элемента управления DataGridView в Windows Forms](performance-tuning-in-the-windows-forms-datagridview-control.md)
- [Масштабирование элемента управления DataGridView в Windows Forms](best-practices-for-scaling-the-windows-forms-datagridview-control.md)
- [Реализация виртуального режима с JIT-загрузкой данных для элемента управления DataGridView в Windows Forms](implementing-virtual-mode-jit-data-loading-in-the-datagrid.md)
- [Практическое руководство. Реализация виртуального режима для элемента управления DataGridView в Windows Forms](how-to-implement-virtual-mode-in-the-windows-forms-datagridview-control.md)
