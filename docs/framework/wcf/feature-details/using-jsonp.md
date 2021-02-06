---
description: 'Дополнительные сведения о: использование JSONP'
title: Использование средства JSONP
ms.date: 03/30/2017
ms.assetid: f386718c-b4ba-4931-a610-40c27a46672a
ms.openlocfilehash: f4d21670cf468328b8579fa8a9cf2c2e06f09337
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99632195"
---
# <a name="using-jsonp"></a>Использование средства JSONP

JSONP - это механизм, используемый для поддержки межсайтовых скриптов в веб-браузерах. JSONP основан на возможности веб-браузеров загружать скрипты не с тех сайтов, с которых загружается исходный документ. Этот механизм работает посредством дополнения полезных данных JSON именем определяемой пользователем функции обратного вызова, как показано в следующем примере.

```javascript
callback({"a" = \\"b\\"});
```

В предыдущем примере полезные данные JSON, `{"a" = \\"b\\"}`, помещены в вызов функции `callback`. Функция обратного вызова должна быть уже определена на текущей веб-странице. Тип содержимого ответа JSONP — `application/javascript` .

JSONP не включается по умолчанию. Чтобы включить его, задайте для атрибута `javascriptCallbackEnabled` значение `true` в одной из стандартных конечных точек HTTP (<xref:System.ServiceModel.Description.WebHttpEndpoint> или <xref:System.ServiceModel.Description.WebScriptEndpoint>), как показано в следующем примере.

```xml
<system.serviceModel>
  <standardEndpoints>
    <webHttpEndpoint>
      <standardEndpoint name="" javascriptCallbackEnabled="true"/>
    </webHttpEndpoint>
  </standardEndpoints>
</system.serviceModel>
```

Имя функции обратного вызова может указываться в переменной запроса callback, как показано в следующем URL-адресе.

`http://baseaddress/Service/RestService?callback=functionName`

При вызове служба отправляет ответ следующего вида.

```javascript
functionName({"root":"Something"});
```  

Имя функции обратного вызова также можно указать с помощью применения атрибута <xref:System.ServiceModel.Web.JavascriptCallbackBehaviorAttribute> к классу службы, как показано в следующем примере.

```csharp
[ServiceContract]
[JavascriptCallbackBehavior(ParameterName = "$callback")]
public class Service1
{
    [OperationContract]
    [WebGet(ResponseFormat=WebMessageFormat.Json)]
    public string GetData()
    {
    }
}
```

Для показанной выше службы запрос выглядит следующим образом.

`http://baseaddress/Service/RestService?$callback=anotherFunction`

При вызове служба отправляет следующий ответ.

```javascript
anotherFunction ({"root":"Something"});
```

## <a name="http-status-codes"></a>Коды состояния HTTP

В ответах JSONP с кодом состояния HTTP, отличным от 200, содержится второй параметр - численное представление кода состояния HTTP, как показано в следующем примере.

```javascript
anotherFunction ({"root":"Something"}, 201);
```

## <a name="validations"></a>Проверки

При включении JSONP выполняются следующие проверки.

- Инфраструктура WCF формирует исключение, если `javascriptCallback` включен, указан параметр строки запроса обратного вызова, а формат ответа установлен в JSON.

- Если запрос содержит параметр строки запроса обратного вызова, но выполняется не операция HTTP GET, параметр обратного вызова не учитывается.

- Если имя обратного вызова равно `null` или пустой строке, то ответ не приводится к формату JSONP.

## <a name="see-also"></a>См. также

- [Общие сведения о модели программирования WCF Web HTTP](wcf-web-http-programming-model-overview.md)
