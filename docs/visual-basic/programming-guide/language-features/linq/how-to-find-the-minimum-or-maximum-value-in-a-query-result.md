---
description: Дополнительные сведения см. в статье как найти минимальное или максимальное значение в результатах запроса с помощью LINQ (Visual Basic).
title: Практическое руководство. Поиск минимального или максимального значения в результатах запроса с помощью LINQ
ms.date: 07/20/2015
helpviewer_keywords:
- max operator [LINQ in Visual Basic]
- aggregate operator [LINQ in Visual Basic]
- aggregate queries
- minimum values [LINQ in Visual Basic]
- min operator [LINQ in Visual Basic]
- queries [LINQ in Visual Basic], minimum and maximum values
- Max property
- maximum values [LINQ in Visual Basic]
- Aggregate clause [Visual Basic]
- queries [LINQ in Visual Basic], aggregate queries
- queries [LINQ in Visual Basic], how-to topics
ms.assetid: 238b763b-7dcd-4b14-8050-b65500a4f71c
ms.openlocfilehash: e6337b61b01d720bd37390f61e4e285aa150ec3a
ms.sourcegitcommit: 10e719780594efc781b15295e499c66f316068b8
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/14/2021
ms.locfileid: "100422811"
---
# <a name="how-to-find-the-minimum-or-maximum-value-in-a-query-result-by-using-linq-visual-basic"></a>Практическое руководство. Поиск минимального или максимального значения в результатах запроса с помощью LINQ (Visual Basic)

Language-Integrated query (LINQ) упрощает доступ к сведениям о базе данных и выполнение запросов.  
  
 В следующем примере показано, как создать новое приложение, которое выполняет запросы к базе данных SQL Server. Образец определяет минимальное и максимальное значения для результатов с помощью `Aggregate` `Group By` предложений и. Дополнительные сведения см. в разделе [предложение Aggregate](../../../language-reference/queries/aggregate-clause.md) и [предложение GROUP BY](../../../language-reference/queries/group-by-clause.md).  
  
 В примерах этого раздела используется учебная база данных Northwind. Если база данных не установлена на компьютере разработчика, загрузите ее с веб-узла Центра загрузки Майкрософт. Инструкции см. в разделе [Загрузка образцов баз данных](../../../../framework/data/adonet/sql/linq/downloading-sample-databases.md).  
  
[!INCLUDE[note_settings_general](~/includes/note-settings-general-md.md)]  
  
## <a name="create-a-connection-to-a-database"></a>Создание соединения с базой данных  
  
1. В Visual Studio откройте **Обозреватель сервера** / **Обозреватель базы данных** , выбрав в  / меню **вид** пункт Обозреватель сервера **Обозреватель базы данных** .  
  
2. Щелкните правой кнопкой мыши элемент **подключения к данным** в **Обозреватель сервера** / **Обозреватель базы данных** а затем выберите команду **Добавить подключение**.  
  
3. Укажите допустимое соединение с образцом базы данных Northwind.  
  
### <a name="to-add-a-project-that-contains-a-linq-to-sql-file"></a>Добавление проекта, содержащего файл LINQ to SQL  
  
1. В меню **Файл** окна Visual Studio наведите указатель мыши на пункт **Создать** и щелкните **Проект**. Выберите Visual Basic **Windows Forms приложение** в качестве типа проекта.  
  
2. В меню **Проект** выберите **Добавить новый элемент**. Выберите шаблон элемента **LINQ to SQL классы** .  
  
3. Задайте файлу имя `northwind.dbml`. Нажмите кнопку **Добавить**. Для файла Northwind. dbml открыт реляционный конструктор объектов (реляционный конструктор R).  
  
## <a name="add-tables-to-query-to-the-or-designer"></a>Добавление таблиц в запрос в реляционный конструктор O/R  
  
1. В **Обозреватель сервера** / **Обозреватель базы данных** разверните подключение к базе данных Northwind. Разверните папку **Таблицы**.  
  
     Если вы закрыли конструктор O/R, его можно открыть повторно, дважды щелкнув файл Northwind. dbml, который вы добавили ранее.  
  
2. Щелкните таблицу Customers (клиенты) и перетащите ее на левую панель конструктора. Щелкните таблицу Orders и перетащите ее на левую панель конструктора.  
  
     Конструктор создает `Customer` `Order` для проекта новые объекты и. Обратите внимание, что конструктор автоматически обнаруживает связи между таблицами и создает дочерние свойства для связанных объектов. Например, IntelliSense покажет, что `Customer` объект имеет `Orders` свойство для всех заказов, связанных с этим клиентом.  
  
3. Сохраните изменения и закройте конструктор.  
  
4. Сохраните проект.  
  
## <a name="add-code-to-query-the-database-and-display-the-results"></a>Добавление кода для запроса к базе данных и отображение результатов  
  
1. Перетащите элемент управления из **области элементов** в <xref:System.Windows.Forms.DataGridView> форму Windows по умолчанию для проекта, Form1.  
  
2. Дважды щелкните Form1, чтобы добавить код в `Load` событие в форме.  
  
3. При добавлении таблиц в реляционный конструктор объектов конструктор добавил <xref:System.Data.Linq.DataContext> объект для проекта. Этот объект содержит код, который необходим для доступа к этим таблицам, в дополнение к отдельным объектам и коллекциям для каждой таблицы. Имя <xref:System.Data.Linq.DataContext> объекта для проекта определяется на основе имени DBML-файла. Для этого проекта объект называется <xref:System.Data.Linq.DataContext> `northwindDataContext` .  
  
     В коде можно создать экземпляр класса <xref:System.Data.Linq.DataContext> и запросить таблицы, заданные конструктором O/R.  
  
     Добавьте следующий код в `Load` событие. Этот код запрашивает таблицы, предоставляемые как свойства контекста данных, и определяет минимальное и максимальное значения для результатов. В примере предложение используется `Aggregate` для запроса одного результата, а предложение — для `Group By` отображения среднего для сгруппированных результатов.  
  
     [!code-vb[VbLINQToSQLHowTos#14](~/samples/snippets/visualbasic/VS_Snippets_VBCSharp/VbLINQtoSQLHowTos/VB/Form7.vb#14)]  
  
4. Нажмите клавишу **F5** , чтобы запустить проект и просмотреть результаты.  
  
## <a name="see-also"></a>См. также раздел

- [LINQ](index.md)
- [Запросы](../../../language-reference/queries/index.md)
- [LINQ to SQL](../../../../framework/data/adonet/sql/linq/index.md)
- [Методы DataContext (реляционный конструктор объектов)](/visualstudio/data-tools/datacontext-methods-o-r-designer)
