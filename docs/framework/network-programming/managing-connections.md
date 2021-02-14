---
title: Управление подключениями
description: Узнайте, как приложения, использующие HTTP для ресурсов данных, используют классы .NET Framework ServicePoint и ServicePointManager для управления соединениями.
ms.date: 01/25/2021
dev_langs:
- csharp
- vb
helpviewer_keywords:
- Internet, connections
- HTTP, classes for connecting
- requesting data from Internet, connections
- sending data, connections
- receiving data, connections
- ServicePoint class, about ServicePoint class
- response to Internet request, connections
- connections [.NET Framework], classes
- network resources, connections
- downloading Internet resources, connections
- ServicePointManager class, about ServicePointManager class
ms.assetid: 9b3d3de7-189f-4f7d-81ae-9c29c441aaaa
ms.openlocfilehash: 9ea93c3a9c484fd2a3de58b4d484b1e8445da155
ms.sourcegitcommit: 4df8e005c074ceb1f978f007b222fe253be2baf3
ms.translationtype: HT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/04/2021
ms.locfileid: "99548062"
---
# <a name="managing-connections"></a>Управление подключениями

Приложения, которые используют протокол HTTP для подключения к ресурсам данных, могут использовать классы <xref:System.Net.ServicePoint> и <xref:System.Net.ServicePointManager> .NET Framework для управления подключением к Интернету и для оптимизации масштабирования и производительности.  

> [!NOTE]
> Классы `ServicePoint` и `ServicePointManager` считаются устаревшими в .NET Core, .NET 5 и более поздних версиях. Большинство их свойств и методов не реализованы в этих версиях. При реализации эти классы никак не влияют на сетевые интерфейсы API `HttpClient` и не отслеживают сведения о них.
  
 Класс **ServicePoint** предоставляет приложению конечную точку, которое оно может использовать для доступа к ресурсам в Интернете. Каждый экземпляр класса **ServicePoint** содержит сведения, которые помогают оптимизировать подключения к интернет-серверу с помощью анализа сведений о подключениях для повышения производительности.  
  
 Каждый класс **ServicePoint** определяется с помощью универсального кода ресурса (URI). Классы разбиваются на категории на основе идентификатора схемы и фрагмента узла URI. Например, один и тот же экземпляр **ServicePoint** может предоставлять запросы к URI `http://www.contoso.com/index.htm` и `http://www.contoso.com/news.htm?date=today`, так как в этих URI используется один и тот же идентификатор схемы (http) и фрагмент узла (`www.contoso.com`). Если у приложения уже есть постоянное подключение к серверу `www.contoso.com`, приложение использует это подключение для обработки обоих запросов, поэтому создавать два подключения не требуется.  
  
 **ServicePointManager** — статический класс, который управляет созданием и уничтожением экземпляров класса **ServicePoint**. Класс **ServicePointManager** создает класс **ServicePoint**, когда приложение запрашивает интернет-ресурс, не входящий в коллекцию существующих экземпляров классов **ServicePoint**. Классы **ServicePoint** уничтожаются, если превышается максимальное время ожидания или количество существующих экземпляров классов **ServicePoint** превышает максимальное количество экземпляров классов **ServicePoint** для приложения. Вы можете задать как максимальное время ожидания по умолчанию, так и максимальное количество экземпляров классов **ServicePoint**, установив свойства <xref:System.Net.ServicePointManager.MaxServicePointIdleTime%2A> и <xref:System.Net.ServicePointManager.MaxServicePoints%2A> для класса **ServicePointManager**.  
  
 Количество подключений между клиентом и сервером может оказывать большое влияние на пропускную способность приложения. По умолчанию приложение, в котором используется экземпляр класса <xref:System.Net.HttpWebRequest>, создает не более двух постоянных подключений к одному серверу, но вы можете установить максимальное количество приложений для отдельных приложений.  
  
> [!NOTE]
> Спецификация HTTP/1.1 ограничивает количество подключений для каждого приложения двумя подключениями к одному серверу.  
  
 Оптимальное количество подключений зависит от фактических условий, в которых запускается приложение. Увеличение количества доступных подключений для приложения может не влиять на производительность приложения. Для определения влияния дополнительных подключений на производительность приложения запустите тесты производительности, изменяя количество подключений. Вы можете изменить количество подключений, используемых приложением, изменив статическое свойство <xref:System.Net.ServicePointManager.DefaultConnectionLimit%2A> класса **ServicePointManager** при инициализации приложения, как показано в следующем примере кода.  
  
```csharp  
// Set the maximum number of connections per server to 4.  
ServicePointManager.DefaultConnectionLimit = 4;  
```  
  
```vb  
' Set the maximum number of connections per server to 4.  
ServicePointManager.DefaultConnectionLimit = 4  
```  
  
 Изменение свойства **ServicePointManager.DefaultConnectionLimit** не влияет на ранее инициализированные экземпляры класса **ServicePoint**. В следующем коде показано изменение количества подключений для существующего класса **ServicePoint** для сервера `http://www.contoso.com` на значение, которое хранится в `newLimit`.  
  
```csharp  
Uri uri = new Uri("http://www.contoso.com/");  
ServicePoint sp = ServicePointManager.FindServicePoint(uri);  
sp.ConnectionLimit = newLimit;  
```  
  
```vb  
Dim uri As New Uri("http://www.contoso.com/")  
Dim sp As ServicePoint = ServicePointManager.FindServicePoint(uri)  
sp.ConnectionLimit = newLimit  
```  
  
## <a name="see-also"></a>См. также

- [Группирование подключений](connection-grouping.md)
- [Использование протоколов приложений](using-application-protocols.md)
