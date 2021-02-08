---
description: Дополнительные сведения см. в статье сериализация в JSON с помощью программирования на уровне сообщений.
title: Сериализация в Json с помощью программирования на уровне сообщений
ms.date: 03/30/2017
ms.assetid: 5f940ba2-57ee-4c49-a779-957c5e7e71fa
ms.openlocfilehash: 715e44b0e2137197f5883e2327288555513f29cd
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99793549"
---
# <a name="serializing-in-json-with-message-level-programming"></a>Сериализация в Json с помощью программирования на уровне сообщений

WCF поддерживает сериализацию данных в формате JSON. В этом разделе описывается, как в WCF выполнить сериализацию типов с помощью <xref:System.Runtime.Serialization.Json.DataContractJsonSerializer>.  
  
## <a name="typed-message-programming"></a>Программирование типизированных сообщений  

 <xref:System.Runtime.Serialization.Json.DataContractJsonSerializer> используется, когда к операции службы применяется атрибут <xref:System.ServiceModel.Web.WebGetAttribute> или атрибут <xref:System.ServiceModel.Web.WebInvokeAttribute>. Оба атрибута позволяют задать формат запроса `RequestFormat` и формат ответа `ResponseFormat`. Для использования JSON в запросах и ответах. Задайте для обоих свойств значение `WebMessageFormat.Json` .  Чтобы использовать JSON, необходимо использовать <xref:System.ServiceModel.WebHttpBinding> , который автоматически настраивает <xref:System.ServiceModel.Description.WebHttpBehavior> . Дополнительные сведения о сериализации WCF см. в разделе [сериализация и десериализация](serialization-and-deserialization.md). Дополнительные сведения о JSON и WCF см. в разделе [служебная станция — введение в службы RESTful с помощью WCF](/archive/msdn-magazine/2009/january/service-station-an-introduction-to-restful-services-with-wcf).  
  
> [!IMPORTANT]
> Для использования с JSON требуется привязка <xref:System.ServiceModel.WebHttpBinding> и поведение <xref:System.ServiceModel.Description.WebHttpBehavior>, которые не поддерживают связь по протоколу SOAP. Службы, взаимодействующие с, <xref:System.ServiceModel.WebHttpBinding> не поддерживают предоставление метаданных службы, поэтому вы не сможете использовать функциональные возможности Visual Studio Добавление ссылки на службу или программу командной строки Svcutil для создания прокси на стороне клиента. Дополнительные сведения о программном вызове служб, использующих <xref:System.ServiceModel.WebHttpBinding> , см. в разделе Использование [служб RESTFUL с WCF](/archive/blogs/pedram/how-to-consume-rest-services-with-wcf).  
  
## <a name="untyped-message-programming"></a>Программирование нетипизированных сообщений  

 При работе напрямую с объектами нетипизированного сообщения следует явно задать свойства нетипизированного сообщения для его сериализации в виде JSON. В следующем фрагменте кода показано, как это сделать.  
  
```csharp
 Message response = Message.CreateMessage(  
                  MessageVersion.None,    // No SOAP message version  
                             "*",                     // SOAP action, ignored since this is JSON  
                             "Response string: JSON format specified", // Message body  
                             new DataContractJsonSerializer(typeof(string))); // Specify DataContractJsonSerializer  
      response.Properties.Add( WebBodyFormatMessageProperty.Name,
                    new WebBodyFormatMessageProperty(WebContentFormat.Json)); // Use JSON format  
```  
  
## <a name="see-also"></a>См. также

- [Интеграция с AJAX и поддержка JSON](ajax-integration-and-json-support.md)
- [Автономная сериализация JSON](stand-alone-json-serialization.md)
- [Сериализация JSON](../samples/json-serialization.md)
