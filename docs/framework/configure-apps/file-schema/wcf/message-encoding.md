---
description: 'Дополнительные сведения: кодирование сообщений'
title: Message Encoding
ms.date: 03/30/2017
ms.assetid: f30ee941-aca9-4c67-82a5-421568496f07
ms.openlocfilehash: 6c0afd61bbdb28c9bcf4dee662b31d93c590c464
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99725354"
---
# <a name="message-encoding"></a>Message Encoding

Кодирование - это процесс преобразования набора символов Юникода в последовательность байтов. Декодирование представляет собой обратный процесс. В Windows Communication Foundation (WCF) имеется три типа кодирования для сообщений SOAP: Text, Binary и MTOM.  
  
 В разделе конфигурации `binaryMessageEncoding` указывается кодировка символов и управление версиями сообщений, используемые для двоичных сообщений XML. Кодировщик двоичных сообщений кодирует сообщения Windows Communication Foundation (WCF) в двоичном формате в сети. Результатом этой кодировки является очень быстрая передача сообщений, однако вследствие этого теряются возможности взаимодействия, основанные на стандартах WS-*.  
  
 В разделе конфигурации `mtomMessageEncoding` указывается кодировка символов и управление версиями сообщений, используемые для сообщения с помощью кодирования MTOM (Message Transmission Optimization Mechanism). MTOM - это эффективная технология для передачи двоичных данных в сообщениях Windows Communication Foundation. Кодировщик MTOM предпринимает попытку соблюсти баланс между эффективностью и взаимодействием. Кодирование MTOM передает большую часть XML-данных в текстовой форме, но оптимизирует большие блоки двоичных данных путем передачи их в исходном виде, без преобразования в текст.  
  
 В разделе конфигурации `textMessageEncoding` указывается кодировщик текста, используемый для создания текстовых сообщений в сети. Сообщения, созданные этим кодировщиком, подходят для взаимодействия на базе +WS-*. Веб-служба или клиент веб-службы в общем могут понимать XML в текстовом виде. Однако передача больших блоков двоичных данных в виде текста является наименее эффективным методом для кодировки сообщений XML.  
  
## <a name="see-also"></a>См. также

- <xref:System.ServiceModel.Channels.CustomBinding>
- <xref:System.ServiceModel.Channels.MessageEncodingBindingElement>
- [Привязки](../../../wcf/bindings.md)
- [Расширение привязок](../../../wcf/extending/extending-bindings.md)
- [Пользовательские привязки](../../../wcf/extending/custom-bindings.md)
- [\<customBinding>](custombinding.md)
- [Выбор кодировщика сообщений](../../../wcf/feature-details/choosing-a-message-encoder.md)
