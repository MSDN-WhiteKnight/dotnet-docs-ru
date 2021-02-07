---
description: Дополнительные сведения см. в статье Пошаговое руководство. выполнение запросов между связями (C#)
title: Пошаговое руководство. Запросы по связям (C#)
ms.date: 03/30/2017
ms.assetid: 552abeb1-18f2-4e93-a9c6-ef7b2db30c32
ms.openlocfilehash: 35811043ddd7ecc9aca5e1bd87a370abebf90853
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99729449"
---
# <a name="walkthrough-querying-across-relationships-c"></a>Пошаговое руководство. Запросы по связям (C#)

В этом пошаговом руководстве демонстрируется использование [!INCLUDE[vbtecdlinq](../../../../../../includes/vbtecdlinq-md.md)] *ассоциаций* для представления связей внешнего ключа в базе данных.  
  
 [!INCLUDE[note_settings_general](../../../../../../includes/note-settings-general-md.md)]  
  
 Это пошаговое руководство было написано с использованием параметров разработки Visual C#.  
  
## <a name="prerequisites"></a>Предварительные требования  

 Необходимо выполнить [Пошаговое руководство: простая модель объектов и запрос (C#)](walkthrough-simple-object-model-and-query-csharp.md). В основе данного пошагового руководства лежит руководство, описываемое в данном разделе; кроме того, в компьютере должен быть файл northwnd.mdf в папке c:\linqtest5.  
  
## <a name="overview"></a>Обзор  

 Данное пошаговое руководство состоит из трех основных задач.  
  
- Добавление класса сущности, который представляет таблицу "Orders" в базе данных "Northwind".  
  
- Добавление примечаний к классу `Customer`, чтобы расширить связи между классами `Customer` и `Order`.  
  
- Создание и выполнение запроса для тестирования процесса получения сведений о классе `Order` с помощью класса `Customer`.  
  
## <a name="mapping-relationships-across-tables"></a>Сопоставление связей между таблицами  

 После определения класса `Customer` создайте определение класса сущностей `Order`, включающее следующий код, который указывает, что свойство `Order.Customer` связано как внешний ключ со свойством `Customer.CustomerID`.  
  
### <a name="to-add-the-order-entity-class"></a>Добавление класса сущностей "Order"  
  
- Введите или вставьте следующий код после определения класса `Customer`.  
  
     [!code-csharp[DLinqWalk2CS#1](../../../../../../samples/snippets/csharp/VS_Snippets_Data/DLinqWalk2CS/cs/Program.cs#1)]  
  
## <a name="annotating-the-customer-class"></a>Добавление примечаний к классу "Customer"  

 На этом этапе добавляются примечания к классу `Customer`, чтобы указать его связь с классом `Order`. (Это добавление не является обязательным, поскольку для создания связи достаточно создать определение связи в любом направлении. Однако добавление этого примечания позволит с легкостью переходить по объектам в любом направлении.)  
  
### <a name="to-annotate-the-customer-class"></a>Добавление примечаний к классу "Customer"  
  
- Введите или вставьте следующий код в класс `Customer`.  
  
     [!code-csharp[DLinqWalk2CS#2](../../../../../../samples/snippets/csharp/VS_Snippets_Data/DLinqWalk2CS/cs/Program.cs#2)]  
  
## <a name="creating-and-running-a-query-across-the-customer-order-relationship"></a>Создание и выполнение запроса в рамках связи "Customer-Order"  

 Теперь можно получить доступ к объектам `Order` непосредственно из объектов `Customer` или в обратном направлении. Явное *соединение* между клиентами и заказами не требуется.  
  
### <a name="to-access-order-objects-by-using-customer-objects"></a>Получение доступа к объектам "Order" с помощью объектов "Customer"  
  
1. Измените метод `Main` посредством ввода или вставки в метод следующего кода:  
  
     [!code-csharp[DLinqWalk2CS#3](../../../../../../samples/snippets/csharp/VS_Snippets_Data/DLinqWalk2CS/cs/Program.cs#3)]  
  
2. Нажмите клавишу F5, чтобы начать отладку приложения.  
  
    > [!NOTE]
    > Чтобы избежать отображения кода SQL в окне "Консоль", преобразуйте `db.Log = Console.Out;` в комментарий.  
  
3. Чтобы остановить отладку, в окне консоли нажмите клавишу ВВОД.  
  
## <a name="creating-a-strongly-typed-view-of-your-database"></a>Создание строго типизированного представления базы данных  

 Общая процедура становится гораздо проще, если в начале использовать строго типизированное представление базы данных. Задавая строгую типизацию объекта <xref:System.Data.Linq.DataContext>, можно избежать вызовов метода <xref:System.Data.Linq.DataContext.GetTable%2A>. Строго типизированные таблицы можно использовать в запросах только при использовании строго типизированного объекта <xref:System.Data.Linq.DataContext>.  
  
 В представленных ниже шагах создается объект `Customers` в качестве строго типизированной таблицы, которая сопоставляется с таблицей "Customers" в базе данных.  
  
### <a name="to-strongly-type-the-datacontext-object"></a>Установка строгой типизации объекта "DataContext"  
  
1. Добавьте следующий код непосредственно перед объявлением класса `Customer`.  
  
     [!code-csharp[DLinqWalk2CS#4](../../../../../../samples/snippets/csharp/VS_Snippets_Data/DLinqWalk2CS/cs/Program.cs#4)]  
  
2. Измените метод `Main`, чтобы использовать строго типизированный объект <xref:System.Data.Linq.DataContext>, как показано далее.  
  
     [!code-csharp[DLinqWalk2CS#5](../../../../../../samples/snippets/csharp/VS_Snippets_Data/DLinqWalk2CS/cs/Program.cs#5)]  
  
3. Нажмите клавишу F5, чтобы начать отладку приложения.  
  
     В окне «Консоль"» отобразится следующее.  
  
     `ID=WHITC`  
  
4. Чтобы остановить отладку, в окне консоли нажмите клавишу ВВОД.  
  
## <a name="next-steps"></a>Следующие шаги  

 В следующем пошаговом руководстве ([Пошаговое руководство. манипулирование данными (C#)](walkthrough-manipulating-data-csharp.md)) показано, как управлять данными. Для этого пошагового руководства не требуется сохранять два пошаговых руководства, которые уже выполнены в этой серии.  
  
## <a name="see-also"></a>См. также

- [Обучение с использованием пошаговых руководств](learning-by-walkthroughs.md)
