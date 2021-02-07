---
description: 'Дополнительные сведения: <webMessageEncoding>'
title: <webMessageEncoding>
ms.date: 03/30/2017
ms.assetid: 892ca485-e21a-4a44-8e40-633161ef6796
ms.openlocfilehash: fb52de348ed20963a66081ac78180557f92e5e30
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99682570"
---
# \<webMessageEncoding>

Обеспечивает чтение и запись сообщений в виде обычного текста XML, сообщений в кодировке JSON (нотация объектов JavaScript), а также необработанного двоичного содержимого, используемого в привязке Windows Communication Foundation (WCF).  
  
[**\<configuration>**](../configuration-element.md)\
&nbsp;&nbsp;[**\<system.serviceModel>**](system-servicemodel.md)\
&nbsp;&nbsp;&nbsp;&nbsp;[**\<bindings>**](bindings.md)\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[**\<customBinding>**](custombinding.md)\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**\<binding>**\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**\<webMessageEncoding>**  
  
## <a name="syntax"></a>Синтаксис  
  
```xml  
<webMessageEncoding maxReadPoolSize="Integer"
                    maxWritePoolSize="Integer"
                    writeEncoding="UnicodeFffeTextEncoding/Utf16TextEncoding/Utf8TextEncoding" />
```  
  
## <a name="attributes-and-elements"></a>Атрибуты и элементы  

 В следующих разделах описаны атрибуты, дочерние и родительские элементы.  
  
### <a name="attributes"></a>Атрибуты  
  
|Атрибут|Описание|  
|---------------|-----------------|  
|`maxReadPoolSize`|Количество сообщений, которые можно читать одновременно, не выделяя памяти для новых обработчиков чтения. Пул больших размеров повышает устойчивость системы при всплесках активности за счет большего рабочего набора. Значение по умолчанию - 64 обработчика чтения для каждого из внутренних кодировщиков (простой текст, JSON, двоичное содержимое).<br /><br /> Увеличение этого числа увеличивает объем используемой памяти, однако подготавливает кодировщик к резким увеличениям количества входящих сообщений, позволяя использовать уже созданные обработчики чтения из пула, а не создавать новые.|  
|`maxWritePoolSize`|Количество сообщений, которые можно отправить одновременно, не выделяя памяти для новых обработчиков записи. Пул больших размеров повышает устойчивость системы при всплесках активности за счет большего рабочего набора. Значение по умолчанию - 16 обработчиков записи для каждого из внутренних кодировщиков (простой текст, JSON, двоичное содержимое).<br /><br /> Увеличение этого числа увеличивает объем используемой памяти, однако подготавливает кодировщик к резким увеличениям количества исходящих сообщений, позволяя использовать уже созданные обработчики записи из пула, а не создавать новые.|  
|`writeEncoding`|Задает кодировку, используемую при отправке сообщений через привязку. Допустимые значения:<br /><br /> -Уникодефффетекстенкодинг: кодировка с обратным порядком байтов Юникода.<br />-Utf16TextEncoding: Кодировка Юникода.<br />-Utf8TextEncoding: 8-разрядная кодировка.<br /><br /> Значение по умолчанию - Utf8TextEncoding. Это атрибут типа <xref:System.Text.Encoding>.|  
  
### <a name="child-elements"></a>Дочерние элементы  
  
|Элемент|Описание|  
|-------------|-----------------|  
|[\<readerQuotas>](/previous-versions/dotnet/netframework-4.0/ms731325(v=vs.100))|Определяет ограничения по сложности сообщений SOAP, которые могут обрабатываться конечными точками, настроенными с использованием этой привязки. Это элемент типа <xref:System.ServiceModel.Configuration.XmlDictionaryReaderQuotasElement>.|  
  
### <a name="parent-elements"></a>Родительские элементы  
  
|Элемент|Описание|  
|-------------|-----------------|  
|[\<binding>](bindings.md)|Определяет все возможности пользовательской привязки.|  
  
## <a name="remarks"></a>Remarks  

 Кодирование — это процесс преобразования сообщения в последовательность байтов. Декодирование представляет собой обратный процесс. Эти процессы требуют определения кодировки символов.  
  
 Элемент `webMessageEncoding` работает путем делегирования набору внутренних кодировщиков обработки кодировок XML (в формате обычного текста), JSON и двоичных данных. Делегирование выполняется с помощью составного кодировщика сообщений.  
  
 Этот элемент привязки и его составной кодировщик используются для управления кодировкой в тех сценариях, где не применяется обмен сообщениями по протоколу SOAP, используемый элементом `webHttpBinding`. К таким сценариям относятся: Plain Old XML (POX), REST (Representational State Transfer), RSS (Really Simple Syndication), синдикация Atom и AJAX (Asynchronous JavaScript and XML). Составной кодировщик сообщений не поддерживает SOAP и WS-Addressing.  
  
 В элементе привязки можно задать кодировку записи с помощью атрибута `writeEncoding`. Предоставленное значение <xref:System.Text.Encoding> задает поведение при записи для форматов JSON и XML в текстовом виде. Для чтения поддерживается любая допустимая кодировка сообщений и кодировка текста.  
  
 Атрибуты `maxReadPoolSize` и `maxWritePoolSize` также могут использоваться для установки максимального количества выделяемых обработчиков чтения и записи соответственно. По умолчанию выделяется 64 обработчика чтения и 16 обработчиков записи.  
  
 Ограничения сложности по умолчанию также устанавливаются с помощью [\<readerQuotas>](/previous-versions/dotnet/netframework-4.0/ms731325(v=vs.100)) элемента для защиты от атак типа "отказ в обслуживании" (DOS), которые пытаются использовать сложность сообщения для связывания ресурсов обработки конечных точек.  
  
## <a name="example"></a>Пример  
  
```xml  
<webMessageEncoding maxReadPoolSize="256"
                    maxWritePoolSize="128"
                    messageVersion="None"
                    textEncoding="utf-8" />
```  
  
## <a name="see-also"></a>См. также

- <xref:System.ServiceModel.Configuration.WebMessageEncodingElement>
- <xref:System.ServiceModel.Channels.CustomBinding>
- <xref:System.ServiceModel.Channels.MessageEncodingBindingElement>
- <xref:System.ServiceModel.Channels.WebMessageEncodingBindingElement>
- [Message Encoding](message-encoding.md)
- [Выбор кодировщика сообщений](../../../wcf/feature-details/choosing-a-message-encoder.md)
- [Привязки](../../../wcf/bindings.md)
- [Расширение привязок](../../../wcf/extending/extending-bindings.md)
- [Пользовательские привязки](../../../wcf/extending/custom-bindings.md)
- [\<customBinding>](custombinding.md)
