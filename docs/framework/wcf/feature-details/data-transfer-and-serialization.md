---
description: 'Дополнительные сведения: Передача данных и сериализация'
title: Передача данных и сериализация
ms.date: 03/30/2017
helpviewer_keywords:
- data serialization [WCF]
- data transfer [WCF]
ms.assetid: 0f03c635-f3e7-4c5c-9463-3cb0135e221e
ms.openlocfilehash: 50e5068efc10d706fb9ce2634998408e48037ded
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99756569"
---
# <a name="data-transfer-and-serialization"></a>Передача данных и сериализация

В распределенных системах для выполнения каких-либо задач клиенты и службы обмениваются данными. Разработчику службы или клиента необходимо также понимать, как Windows Communication Foundation (WCF) обрабатывает данные и сериализацию данных для создания эффективных и удобных в обслуживании приложений.  
  
## <a name="in-this-section"></a>В этом разделе  

 [Задание передачи данных в контрактах служб](specifying-data-transfer-in-service-contracts.md)  
 Базовые принципы передачи данных в службах.  
  
 [Использование контрактов данных](using-data-contracts.md)  
 Понятие контрактов данных и процедур их создания и использования.  
  
 [Сериализатор контракта данных](data-contract-serializer.md)  
 Сериализация данных с помощью класса <xref:System.Runtime.Serialization.DataContractSerializer> и каких-либо расширений класса <xref:System.Runtime.Serialization.XmlObjectSerializer>.  
  
 [Использование класса XmlSerializer](using-the-xmlserializer-class.md)  
 Способы и причины использования класса <xref:System.Xml.Serialization.XmlSerializer> в качестве альтернативы классу <xref:System.Runtime.Serialization.DataContractSerializer>.  
  
 [Использование контрактов сообщений](using-message-contracts.md)  
 Точное управление сообщениями SOAP с помощью контрактов сообщений.  
  
 [Использование класса сообщений](using-the-message-class.md)  
 Использование возможностей класса Message.  
  
 [Фильтрация](filtering.md)  
 Фильтрация, позволяющая выполнять предварительную обработку сообщений на основе различных критериев.  
  
 [Большие наборы данных и потоковая передача](large-data-and-streaming.md)  
 Отправка больших фрагментов данных, например двоичных файлов.  
  
 [Вопросы безопасности для данных](security-considerations-for-data.md)  
 Вопросы, которые необходимо учитывать при решении задач сериализации и передачи данных.  
  
 [Общие сведения об архитектуре передачи данных](data-transfer-architectural-overview.md)  
 Описывает общие сведения о структуре обмена данными в WCF.  
  
## <a name="reference"></a>Справочник  

 <xref:System.ServiceModel>  
  
 <xref:System.Runtime.Serialization.DataContractSerializer>  
  
 <xref:System.Xml.Serialization.XmlSerializer>  
  
 <xref:System.Runtime.Serialization>  
  
 <xref:System.Xml.Serialization>  
  
## <a name="related-sections"></a>Связанные разделы  

 [Расширение кодировщиков и сериализаторов](../extending/extending-encoders-and-serializers.md)  
  
## <a name="see-also"></a>См. также

- [Рекомендации. Управление версиями контракта данных](../best-practices-data-contract-versioning.md)
- [Управление версиями службы](../service-versioning.md)
