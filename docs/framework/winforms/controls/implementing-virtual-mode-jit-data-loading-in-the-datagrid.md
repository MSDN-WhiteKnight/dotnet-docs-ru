---
title: Реализация виртуального режима с JIT-загрузкой данных для элемента управления DataGridView в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- examples [Windows Forms], just-in-time data loading
- data [Windows Forms], managing large data sets
- DataGridView control [Windows Forms], virtual mode
- just-in-time data loading
- DataGridView control [Windows Forms], large data sets
- virtual mode [Windows Forms], just-in-time data loading
ms.assetid: c2a052b9-423c-4ff7-91dc-d8c7c79345f6
ms.openlocfilehash: 641db19cc6493a20c9f9a34622f466e3623c32ad
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59088656"
---
# <a name="implementing-virtual-mode-with-just-in-time-data-loading-in-the-windows-forms-datagridview-control"></a>Реализация виртуального режима с JIT-загрузкой данных для элемента управления DataGridView в Windows Forms
Одна из причин для реализации виртуальный режим в <xref:System.Windows.Forms.DataGridView> элемент управления является получение данных только по мере необходимости. Это называется *загрузка данных just-in-time*.  
  
 Если вы работаете с очень большими таблицами в удаленной базе данных, например, можно избежать задержки при запуске, извлечение только данные, необходимые для отображения и получения дополнительных данных только в том случае, когда пользователь прокручивает новых строк в представление. Если клиентские компьютеры под управлением приложения имеют ограниченный объем памяти для хранения данных, можно также удалить неиспользуемые данные, при получении новых значений из базы данных.  
  
 В следующих разделах рассматривается использование <xref:System.Windows.Forms.DataGridView> элемента управления с кэшем just-in-time.  
  
 Чтобы скопировать код из этого раздела единым блоком, см. раздел [Практическое руководство. Реализация виртуального режима с JIT в загрузкой данных в Windows Forms элемента управления DataGridView](virtual-mode-with-just-in-time-data-loading-in-the-datagrid.md).  
  
## <a name="the-form"></a>Формы  
 В следующем примере кода определяется форму, содержащую только для чтения <xref:System.Windows.Forms.DataGridView> элемента управления, который взаимодействует с `Cache` объекта через <xref:System.Windows.Forms.DataGridView.CellValueNeeded> обработчик событий. `Cache` Объекта управляет значениями, хранящимися локально и использует `DataRetriever` объект для извлечения значения из таблицы Orders учебной базы данных "Борей". `DataRetriever` Объект, который реализует `IDataPageRetriever` интерфейс, необходимый `Cache` класса, также используется для инициализации <xref:System.Windows.Forms.DataGridView> управления строками и столбцами.  
  
 `IDataPageRetriever`, `DataRetriever`, И `Cache` типы описаны далее в этом разделе.  
  
> [!NOTE]
>  Хранение конфиденциальных сведений (например, пароля) в строке подключения может повлиять на безопасность приложения. Использование проверки подлинности Windows (также называемой встроенными средствами безопасности) — более безопасный способ управления доступом к базе данных. Дополнительные сведения см. в разделе [Защита сведений о подключении](../../data/adonet/protecting-connection-information.md).  
  
 [!code-csharp[System.Windows.Forms.DataGridView.Virtual_lazyloading#100](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataGridView.Virtual_lazyloading/CS/lazyloading.cs#100)]
   
  
## <a name="the-idatapageretriever-interface"></a>Интерфейс IDataPageRetriever  
 В следующем примере кода определяется `IDataPageRetriever` интерфейс, который реализуется `DataRetriever` класса. — Единственный метод, объявленный в этом интерфейсе `SupplyPageOfData` метод, который требуется индекс начальной строки и число строк на одной странице данных. Эти значения используются средством реализации для извлечения подмножества данных из источника данных.  
  
 Объект `Cache` использует реализацию этого интерфейса во время построения для загрузки двух начальных страниц данных. Каждый раз, когда требуется значение без кэширования, отменяет одну из этих страниц и запрашивает новую страницу с значением из кэша `IDataPageRetriever`.  
  
 [!code-csharp[System.Windows.Forms.DataGridView.Virtual_lazyloading#201](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataGridView.Virtual_lazyloading/CS/lazyloading.cs#201)]
   
  
## <a name="the-dataretriever-class"></a>Класс DataRetriever  
 В следующем примере кода определяется `DataRetriever` класса, который реализует `IDataPageRetriever` интерфейс для извлечения страниц данных с сервера. `DataRetriever` Класс также предоставляет `Columns` и `RowCount` свойства, который <xref:System.Windows.Forms.DataGridView> элемент управления использует для создания необходимых столбцов и добавьте соответствующее количество пустых строк <xref:System.Windows.Forms.DataGridView.Rows%2A> коллекции. Добавление пустых строк необходим, чтобы элемент управления будет действовать как если бы, если он содержит все данные в таблице. Это означает, что бегунка полосы прокрутки будет иметь соответствующий размер, что пользователь сможет получить доступ к любой строки в таблице. Строки заполняются <xref:System.Windows.Forms.DataGridView.CellValueNeeded> обработчик событий только в том случае, если они оказались в представление.  
  
 [!code-csharp[System.Windows.Forms.DataGridView.Virtual_lazyloading#200](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataGridView.Virtual_lazyloading/CS/lazyloading.cs#200)]
   
  
## <a name="the-cache-class"></a>Класс кэша  
 В следующем примере кода определяется `Cache` класс, который управляет двумя страницами данных, которое заполняется с помощью `IDataPageRetriever` реализации. `Cache` Класс определяет внутреннее `DataPage` структуру, которая содержит <xref:System.Data.DataTable> для хранения значений в одном кэше страницы и которая вычисляет индексы строк, представляющих верхнюю и нижнюю границы страницы.  
  
 `Cache` Класс загружает две страницы данных во время построения. Каждый раз, когда <xref:System.Windows.Forms.DataGridView.CellValueNeeded> событий запрашивает значение, `Cache` объект определяет, если значение доступно в одной из двух его страниц и если да, то возвращает его. Если значение не доступен локально, `Cache` определяет, какой из двух страниц дальше всего от текущей строки и заменяет страницу с запрошенным значением, которое затем возвращается новый.  
  
 Предположим, что количество строк на странице данных является таким же, как количество строк, которые могут отображаться на экране за один раз, эта модель позволяет пользователям, разбиение по страницам в таблице, эффективно вернуться на последнюю просмотренную страницу.  
  
 [!code-csharp[System.Windows.Forms.DataGridView.Virtual_lazyloading#300](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataGridView.Virtual_lazyloading/CS/lazyloading.cs#300)]
   
  
## <a name="additional-considerations"></a>Дополнительные сведения  
 Приведенные выше примеры кода предоставляются в качестве демонстрации загрузки данных just-in-time. Необходимо будет изменить код для ваших нужд для достижения максимальной эффективности. Как минимум необходимо будет выбрать соответствующее значение для числа строк на одной странице данных в кэше. Это значение передается в `Cache` конструктор. Количество строк на странице должно быть не меньше, чем количество строк, которые могут отображаться одновременно в вашей <xref:System.Windows.Forms.DataGridView> элемента управления.  
  
 Для получения наилучших результатов необходимо провести тестирование производительности для определения требований системы и пользователей. Несколько факторов, которые необходимо принять во внимание включают в себя объем памяти в клиентских компьютеров под управлением приложения, доступная пропускная способность сетевого подключения и задержки сервера, используемого. Значения пропускной способности и задержки должно определяться во время активного использования.  
  
 Для повышения быстродействия приложения, можно увеличить объем данных, хранящихся локально. Для сокращения времени запуска, однако следует загружать слишком много данных изначально. Может потребоваться изменить `Cache` класса, чтобы увеличить число страниц данных, оно может хранить. С помощью нескольких страниц данных повышает эффективность прокрутки, но вам потребуется определить оптимальное количество строк на странице данных, в зависимости от доступной пропускной способности и задержки сервера. С помощью страницы меньшего размера сервер будет осуществляться чаще, но займет меньше времени для возврата запрошенных данных. Если задержки более критичны, чем пропускная способность, можно использовать страниц данных большего размера.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.DataGridView>
- <xref:System.Windows.Forms.DataGridView.VirtualMode%2A>
- [Оптимизация производительности элемента управления DataGridView в Windows Forms](performance-tuning-in-the-windows-forms-datagridview-control.md)
- [Масштабирование элемента управления DataGridView в Windows Forms](best-practices-for-scaling-the-windows-forms-datagridview-control.md)
- [Виртуальный режим элемента управления DataGridView в Windows Forms](virtual-mode-in-the-windows-forms-datagridview-control.md)
- [Пошаговое руководство. Реализация виртуального режима для элемента управления DataGridView в Windows Forms](implementing-virtual-mode-wf-datagridview-control.md)
- [Практическое руководство. Реализация виртуального режима с JIT-загрузкой данных для элемента управления DataGridView в Windows Forms](virtual-mode-with-just-in-time-data-loading-in-the-datagrid.md)
