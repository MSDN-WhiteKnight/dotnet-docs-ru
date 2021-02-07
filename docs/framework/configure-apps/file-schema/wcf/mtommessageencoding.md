---
description: 'Дополнительные сведения: <mtomMessageEncoding>'
title: <mtomMessageEncoding>
ms.date: 03/30/2017
ms.assetid: 7865d171-cd1e-430a-8421-39cc13541d1b
ms.openlocfilehash: 37ac0be5f3de84a4c310b8ec2a09ed6f3c4def56
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99684117"
---
# \<mtomMessageEncoding>

Определяет метод шифрования и управления версиями сообщений для сообщений, использующих механизм оптимизации передачи сообщений SOAP (MTOM).  
  
[**\<configuration>**](../configuration-element.md)\
&nbsp;&nbsp;[**\<system.serviceModel>**](system-servicemodel.md)\
&nbsp;&nbsp;&nbsp;&nbsp;[**\<bindings>**](bindings.md)\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[**\<customBinding>**](custombinding.md)\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**\<binding>**\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**\<mtomMessageEncoding>**  
  
## <a name="syntax"></a>Синтаксис  
  
```xml  
<mtomMessageEncoding maxBufferSize="Integer"
                     maxReadPoolSize="Integer"
                     maxWritePoolSize="Integer"
                     messageVersion="Soap11Addressing1/Soap12Addressing10"
                     writeEncoding="UnicodeFffeTextEncoding/Utf16TextEncoding/Utf8TextEncoding" />
```  
  
## <a name="attributes-and-elements"></a>Атрибуты и элементы  

 В следующих разделах описаны атрибуты, дочерние и родительские элементы.  
  
### <a name="attributes"></a>Атрибуты  
  
|Атрибут|Описание|  
|---------------|-----------------|  
|maxBufferSize|Целое число, задающее максимальный допустимый размер буфера.|  
|maxReadPoolSize|Целое число, задающее количество сообщений, которые можно читать одновременно, не выделяя памяти для новых модулей чтения. Пул больших размеров повышает устойчивость системы при всплесках активности за счет большего рабочего набора. Значение по умолчанию — 64.|  
|maxWritePoolSize|Целое число, задающее количество сообщений, которые можно отправлять одновременно, не выделяя памяти для новых модулей записи. Пул больших размеров повышает устойчивость системы при всплесках активности за счет большего рабочего набора. Значение по умолчанию равно 16.|  
|messageVersion|Задает версию SOAP сообщений, отправленных с помощью привязки. Допустимы следующие значения:<br /><br /> - Soap11Addressing1<br />- Soap12Addressing10<br /><br /> Значение по умолчанию - Soap12Addressing10. Это атрибут типа <xref:System.ServiceModel.Channels.MessageVersion>.|  
|writeEncoding|Задает кодировку, используемую при отправке сообщений через привязку. Допустимы следующие значения:<br /><br /> -Уникодефффетекстенкодинг: Юникод байтов кодировка<br />-Utf16TextEncoding: Кодировка Юникода<br />-Utf8TextEncoding: 8-разрядная кодировка<br /><br /> Значение по умолчанию - Utf8TextEncoding. Это атрибут типа <xref:System.Text.Encoding>.|  
  
### <a name="child-elements"></a>Дочерние элементы  
  
|Элемент|Описание|  
|-------------|-----------------|  
|[\<readerQuotas>](/previous-versions/dotnet/netframework-4.0/ms731325(v=vs.100))|Определяет ограничения по сложности сообщений SOAP, которые могут обрабатываться конечными точками, настроенными с использованием этой привязки. Это элемент типа <xref:System.ServiceModel.Configuration.XmlDictionaryReaderQuotasElement>.|  
  
### <a name="parent-elements"></a>Родительские элементы  
  
|Элемент|Описание|  
|-------------|-----------------|  
|[\<binding>](bindings.md)|Определяет все возможности пользовательской привязки.|  
  
## <a name="remarks"></a>Remarks  

 Кодирование — это процесс преобразования сообщения в последовательность байтов. Декодирование представляет собой обратный процесс. В Windows Communication Foundation (WCF) имеется три типа кодирования для сообщений SOAP: Text, Binary и MTOM.  
  
 Элемент `MtomMessageEncoding` указывает кодировку символов, управление версиями сообщений и другие параметры для сообщений, использующих кодировку MTOM. MTOM - это эффективный способ передачи двоичных данных в сообщениях WCF. Кодировщик MTOM пытается сохранить баланс между эффективностью и совместимостью. При кодировке MTOM большая часть XML-кода передается в текстовой форме, однако выполняется оптимизация больших блоков двоичных данных путем передачи их в исходном виде, без преобразования их в базовый формат base64.  
  
## <a name="example"></a>Пример  
  
```xml  
<mtomMessageEncoding maxReadPoolSize="211"
                     maxWritePoolSize="2132"
                     messageVersion="Soap11Addressing10"
                     textEncoding="utf-8" />
```  
  
## <a name="see-also"></a>См. также

- <xref:System.ServiceModel.Configuration.MtomMessageEncodingElement>
- <xref:System.ServiceModel.Channels.CustomBinding>
- <xref:System.ServiceModel.Channels.MessageEncodingBindingElement>
- <xref:System.ServiceModel.Channels.MtomMessageEncodingBindingElement>
- [Message Encoding](message-encoding.md)
- [Выбор кодировщика сообщений](../../../wcf/feature-details/choosing-a-message-encoder.md)
- [Привязки](../../../wcf/bindings.md)
- [Расширение привязок](../../../wcf/extending/extending-bindings.md)
- [Пользовательские привязки](../../../wcf/extending/custom-bindings.md)
- [\<customBinding>](custombinding.md)
