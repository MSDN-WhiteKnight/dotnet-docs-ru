---
description: 'Дополнительные сведения: пользовательские модули форматирования сообщений'
title: Пользовательские модули форматирования сообщений
ms.date: 03/30/2017
ms.assetid: c07435f3-5214-4791-8961-2c2b61306d71
ms.openlocfilehash: 34d4eb1820ce57162c7ac4d97a85a409e27fc062
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99735274"
---
# <a name="custom-message-formatters"></a>Пользовательские модули форматирования сообщений

Содержимое сообщения зачастую представлено в XML-виде, который обычно является неудобным форматом для приложений. Приложения управляют объектами, получая и устанавливая их свойства. Windows Communication Foundation (WCF) использует *контракт данных* для преобразования <xref:System.ServiceModel.Channels.Message> объекта в объект, который легко обрабатывается приложением. Эти действия называются сериализацией и десериализацией. Обратите внимание, что данные термины также используются для описания сериализации и десериализации, выполненной транспортным слоем, в формат сообщений для передачи по линиям связи, что является несвязанным процессом.  
  
 Можно использовать пользовательский модуль форматирования сообщений, если требуется реализовать специализированное преобразование между сообщениями и объектами, которое не удается выполнить при помощи контракта данных. Это можно сделать путем изменения или расширения поведения выполнения определенной операции контракта на стороне клиента или службы.  
  
## <a name="custom-message-formatters-on-the-client"></a>Пользовательские модули форматирования сообщения на стороне клиента  

 Интерфейс <xref:System.ServiceModel.Dispatcher.IClientMessageFormatter> определяет методы, используемые для управления преобразованием сообщений в объекты и обратно для клиентских приложений.  
  
 Необходимо реализовать данный интерфейс. Сначала требуется переопределить метод <xref:System.ServiceModel.Dispatcher.IClientMessageFormatter.DeserializeReply%2A> для десериализации сообщения. Данный метод вызывается после получения входящего сообщения, но перед его отправкой операции клиента.  
  
 Затем переопределите метод <xref:System.ServiceModel.Dispatcher.IClientMessageFormatter.SerializeRequest%2A> для сериализации объекта. Данный метод вызывается перед отправкой исходящего сообщения.  
  
 Чтобы вставить пользовательский модуль форматирования в службу, назначьте объект <xref:System.ServiceModel.Dispatcher.IClientMessageFormatter> свойству <xref:System.ServiceModel.Dispatcher.ClientOperation.Formatter%2A> с помощью поведения операции. Сведения о поведении см. [в разделе Настройка и расширение среды выполнения с помощью поведений](configuring-and-extending-the-runtime-with-behaviors.md).  
  
## <a name="custom-message-formatters-on-the-service"></a>Пользовательские модули форматирования сообщения на стороне службы  

 Интерфейс <xref:System.ServiceModel.Dispatcher.IDispatchMessageFormatter> определяет методы, которые преобразовывают объект <xref:System.ServiceModel.Channels.Message> в параметры для операции и из параметров в объект <xref:System.ServiceModel.Channels.Message> в приложении службы.  
  
 Необходимо реализовать данный интерфейс. Сначала требуется переопределить метод <xref:System.ServiceModel.Dispatcher.IClientMessageFormatter.DeserializeReply%2A> для десериализации сообщения. Данный метод вызывается после получения входящего сообщения, но перед его отправкой операции клиента.  
  
 Затем переопределите метод <xref:System.ServiceModel.Dispatcher.IClientMessageFormatter.SerializeRequest%2A> для сериализации объекта. Данный метод вызывается перед отправкой исходящего сообщения.  
  
 Чтобы вставить пользовательский модуль форматирования в службу, назначьте объект <xref:System.ServiceModel.Dispatcher.IDispatchMessageFormatter> свойству <xref:System.ServiceModel.Dispatcher.DispatchOperation.Formatter%2A> с помощью поведения операции. Сведения о поведении см. [в разделе Настройка и расширение среды выполнения с помощью поведений](configuring-and-extending-the-runtime-with-behaviors.md).  
  
## <a name="see-also"></a>См. также

- <xref:System.ServiceModel.Dispatcher.IClientMessageFormatter>
- <xref:System.ServiceModel.Dispatcher.IDispatchMessageFormatter>
- [Настройка и расширение среды выполнения с помощью поведений](configuring-and-extending-the-runtime-with-behaviors.md)
