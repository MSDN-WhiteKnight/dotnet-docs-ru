---
description: 'Подробнее о: протокол надежного обмена сообщениями версии 1,0'
title: Протокол надежного обмена сообщениями, версия 1.0
ms.date: 03/30/2017
ms.assetid: a5509a5c-de24-4bc2-9a48-19138055dcce
ms.openlocfilehash: dbd0184fd6ea9f92c96639d71088ac61bec20f3e
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99793601"
---
# <a name="reliable-messaging-protocol-version-10"></a>Протокол надежного обмена сообщениями, версия 1.0

В этом разделе рассматриваются сведения о реализации Windows Communication Foundation (WCF) по протоколу WS-Reliable Messaging 2005 (версия 1,0), необходимый для взаимодействия с помощью транспорта HTTP. WCF использует спецификацию обмена сообщениями WS-Reliable с ограничениями и пояснениями, описанными в этом разделе. Обратите внимание, что протокол WS-ReliableMessaging версии 1,0 реализуется, начиная с WinFX.

Протокол WS-Reliable Messaging 2005 реализован в WCF с помощью <xref:System.ServiceModel.Channels.ReliableSessionBindingElement> .

Для удобства объяснения в этом разделе используются следующие роли:

- инициатор: клиент, инициирующий создание последовательности сообщений WS-Reliable;

- респондент: служба, получающая запросы инициатора.

В этом документе используются префиксы и пространства имен, описанные в следующей таблице.

|Prefix|Пространство имен|
|------------|---------------|
|wsrm|`http://schemas.xmlsoap.org/ws/2005/02/rm`|
|netrm|`http://schemas.microsoft.com/ws/2006/05/rm`|
|s|`http://www.w3.org/2003/05/soap-envelope`|
|wsa|`http://schemas.xmlsoap.org/ws/2005/08/addressing`|
|wsse|`http://docs.oasis-open.org/wss/2004/01/oasis-200401-wssecurity-secext-1.0.xsd`|

## <a name="messaging"></a>Обмен сообщениями

### <a name="sequence-establishment-messages"></a>Сообщения установления последовательности

WCF реализует `CreateSequence` и `CreateSequenceResponse` сообщения для установления надежной последовательности сообщений. Действуют следующие ограничения.

- B1101: инициатор WCF не создает необязательный элемент Expires в `CreateSequence` сообщении или, в случае, если `CreateSequence` сообщение содержит `Offer` элемент, необязательный `Expires` элемент в `Offer` элементе.

- B1102: при доступе к `CreateSequence` сообщению WCF `Responder` отправляет и получает оба `Expires` элемента, если они существуют, но не использует их значения.

Протокол WS-Reliable Messaging использует механизм `Offer` для формирования двух коррелированных встречных последовательностей, которые составляют сеанс.

- R1103: если сообщение `CreateSequence` содержит элемент `Offer`, респондент системы надежного обмена сообщениями должен либо принять последовательности и выдать ответ `CreateSequenceResponse`, который содержит элемент `wsrm:Accept`, образующий две коррелированных встречных последовательности, либо отклонить запрос `CreateSequence`.

- R1104: `SequenceAcknowledgement` и сообщения приложения, передаваемые во встречной последовательности, должны быть отправлены по адресу ссылки конечной последовательности `ReplyTo` в `CreateSequence`.

- R1105: адреса ссылок на конечные точки `AcksTo` и `ReplyTo` в сообщении `CreateSequence` должны совпадать на уровне октетов.

  Перед созданием последовательности в WCF-ответчике проверяется, что часть URI `AcksTo` и `ReplyTo` епрс идентичны.

- R1106: ссылки на конечные точки `AcksTo` и `ReplyTo` в сообщении `CreateSequence` должны иметь один и тот же набор параметров ссылок.

  WCF не применяет принудительное применение, но предполагает, что [параметры ссылки] в `AcksTo` и `ReplyTo` On `CreateSequence` идентичны, и использует [ссылочные параметры] из `ReplyTo` ссылки на конечную точку для подтверждения и последовательного обмена сообщениями.

- R1107: при установке двух встречных последовательностей с помощью механизма `Offer` сообщение `SequenceAcknowledgement` и сообщения приложения во встречных последовательностях должны отправляться по ссылке на конечную точку `ReplyTo` в сообщении `CreateSequence`.

- R1108: при установке двух встречных последовательностей с помощью механизма "Offer" свойство `[address]` дочернего элемента ссылки на конечную точку `wsrm:AcksTo` элемента `wsrm:Accept` в сообщении `CreateSequenceResponse` должно с точностью до байта совпадать с универсальным кодом ресурса (URI) назначения сообщения `CreateSequence`.

- R1109: при установке двух встречных последовательностей с помощью механизма `Offer` сообщения, отправленные инициатором, и подтверждения на сообщения респондента должны отправляться по одной и той же ссылке на конечную точку.

  WCF использует WS-Reliable обмена сообщениями для установления надежных сеансов между инициатором и ответчиком. Реализация обмена сообщениями WS-Reliable WCF обеспечивает надежный сеанс для односторонних, однонаправленных и полноценных шаблонов обмена сообщениями. Механизм обмена сообщениями WS-Reliable `Offer` в `CreateSequence` / `CreateSequenceResponse` позволяет установить две коррелированные последовательности обратной связи и предоставляет протокол сеанса, подходящий для всех конечных точек сообщений. Поскольку WCF предоставляет гарантию безопасности для такого сеанса, включая сквозную защиту для целостности сеанса, целесообразно убедиться, что сообщения, предназначенные для одной и той же стороны, поступают в одно и то же место назначения. Кроме того, это делает возможным передачу подтверждений последовательностей в сообщениях приложений. Таким образом, ограничения R1104, R1105 и R1108 применяются к WCF.

Пример сообщения `CreateSequence`.

```xml
<s:Envelope>
  <s:Header>
    <a:Action s:mustUnderstand="1">
      http://schemas.xmlsoap.org/ws/2005/02/rm/CreateSequence
    </a:Action>
    <a:ReplyTo>
      <a:Address>
         http://Business456.com/clientA
      </a:Address>
    </a:ReplyTo>
    <a:MessageID>
      urn:uuid:addabbbf-60cb-44d3-8c5b-9e0841629a36
    </a:MessageID>
    <a:To s:mustUnderstand="1">
      http://Business456.com/clientA
    </a:To>
  </s:Header>
  <s:Body>
    <wsrm:CreateSequence>
      <wsrm:AcksTo>
       <wsa:Address>
         http://Business456.com/clientA
       </wsa:Address>
     </wsrm:AcksTo>
     <wsrm:Offer>
      <wsrm:Identifier>
        urn:uuid:0afb8d36-bf26-4776-b8cf-8c91fddb5496
      </wsrm:Identifier>
     </wsrm:Offer>
   </wsrm:CreateSequence>
  </s:Body>
</s:Envelope>
```

 Пример сообщения `CreateSequenceResponse`.

```xml
<s:Envelope>
  <s:Header>
    <a:Action s:mustUnderstand="1">
      http://schemas.xmlsoap.org/ws/2005/02/rm/CreateSequenceResponse
    </a:Action>
    <a:RelatesTo>
      urn:uuid:addabbbf-60cb-44d3-8c5b-9e0841629a36
    </a:RelatesTo>
    <a:To s:mustUnderstand="1">
      http://Business456.com/clientA
    </a:To>
  </s:Header>
  <s:Body>
   <wsrm:CreateSequenceResponse>
    <Identifier>
     urn:uuid:eea0a36c-b38a-43e8-8c76-2fabe2d76386
    </Identifier>
    <Accept>
    <AcksTo>
      <a:Address>
        http://BusinessABC.com/serviceA
      </a:Address>
    </AcksTo>
    </Accept>
   </wsrm:CreateSequenceResponse>
  </s:Body>
</s:Envelope>
```

### <a name="sequence"></a>Последовательность

Ниже приведен список ограничений, относящихся к последовательностям.

- B1201: WCF создает и обращается к порядковым номерам не выше `xs:long` максимального включительного значения 9223372036854775807.

- B1202: WCF всегда создает Последнее сообщение Empty-воплощающего с универсальным кодом ресурса (URI) действия `http://schemas.xmlsoap.org/ws/2005/02/rm/LastMessage` .

- B1203: WCF получает и доставляет сообщение с заголовком последовательности, содержащим `LastMessage` элемент, если URI действия не имеет значение `http://schemas.xmlsoap.org/ws/2005/02/rm/LastMessage` .

Пример заголовка последовательности.

```xml
<wsrm:Sequence>
  <wsrm:Identifier>
    urn:uuid:addabbbf-60cb-44d3-8c5b-9e0841629a36
  </wsrm:Identifier>
  <wsrm:MessageNumber>
    10
  </wsrm:MessageNumber>
  <wsrm:LastMessage/>
 </wsrm:Sequence>
```

### <a name="ackrequested-header"></a>Заголовок AckRequested

WCF использует `AckRequested` заголовок в качестве механизма поддержания активности. WCF не создает необязательный `MessageNumber` элемент. При получении сообщения с `AckRequested` заголовком, содержащим `MessageNumber` элемент, WCF игнорирует `MessageNumber` значение элемента, как показано в следующем примере.

```xml
<wsrm:AckRequested>
  <wsrm:Identifier>
    urn:uuid:addabbbf-60cb-44d3-8c5b-9e0841629a36
  </wsrm:Identifier>
</wsrm:AckRequested>
```

### <a name="sequenceacknowledgement-header"></a>Заголовок SequenceAcknowledgement

WCF использует механизм свинка для подтверждения последовательностей, предоставляемых в WS-Reliable Messaging.

- R1401: при установке двух встречных последовательностей с помощью механизма `Offer` заголовок `SequenceAcknowledgement` может включаться в любое сообщение приложения, передаваемое определенному получателю.

- B1402: когда WCF должен создать подтверждение перед получением любых сообщений последовательности (например, для удовлетворения `AckRequested` сообщения), WCF создает `SequenceAcknowledgement` заголовок, содержащий диапазон 0-0, как показано в следующем примере.

  ```xml
  <wsrm:SequenceAcknowledgement>
    <wsrm:Identifier>
      urn:uuid:addabbbf-60cb-44d3-8c5b-9e0841629a36
    </wsrm:Identifier>
    <wsrm:AcknowledgementRange Upper="0" Lower="0"/>
  </wsrm:SequenceAcknowledgement>
  ```

- B1403: WCF не создает `SequenceAcknowledgement` заголовки, содержащие элемент, `Nack` но поддерживает `Nack` элементы.

### <a name="ws-reliablemessaging-faults"></a>Ошибки протокола WS-ReliableMessaging

Ниже приведен список ограничений, которые применяются к реализации WCF ошибок обмена сообщениями WS-Reliable.

- B1501: WCF не создает `MessageNumberRollover` ошибки.

- B1502: в конечной точке WCF могут возникать `CreateSequenceRefused` ошибки, описанные в спецификации.

- B1503: когда конечная точка службы достигает предельного числа подключений и не может обработать новые соединения, WCF создает дополнительный `CreateSequenceRefused` код ошибки, `netrm:ConnectionLimitReached` как показано в следующем примере.

  ```xml
  <s:Envelope>
    <s:Header>
      <wsa:Action>
        http://schemas.xmlsoap.org/ws/2005/08/addressing/fault
      </wsa:Action>
    </s:Header>
    <s:Body>
      <s:Fault>
        <s:Code>
          <s:Value>
            s:Receiver
          </s:Value>
          <s:Subcode>
            <s:Value>
              wsrm:CreateSequenceRefused
            </s:Value>
            <s:Subcode>
              <s:Value>
                netrm:ConnectionLimitReached
              </s:Value>
            </s:Subcode>
          </s:Subcode>
        </s:Code>
        <s:Reason>
          <s:Text xml:lang="en">
            [Reason]
          </s:Text>
        </s:Reason>
      </s:Fault>
    </s:Body>
  </s:Envelope>
  ```

### <a name="ws-addressing-faults"></a>Ошибки WS-Addressing

Поскольку WS-Reliable Messaging использует WS-Addressing, реализация WCF WS-Reliable Messaging может формировать WS-Addressing ошибок. В этом разделе рассматриваются ошибки WS-Addressing, которые WCF явно создает на уровне WS-Reliable Messaging:

- B1601: WCF создает заголовок адресации сообщения об ошибке, если выполняется одно из следующих условий.

  - в сообщении отсутствуют заголовки `Sequence` и `Action`;

  - в сообщении `CreateSequence` отсутствует заголовок `MessageId`.

  - в сообщении `CreateSequence` отсутствует заголовок `ReplyTo`.

- B1602: WCF создает действие сбоя, не поддерживаемое в ответ на сообщение, в котором отсутствует `Sequence` заголовок и `Action` заголовок, который не распознается в спецификации обмена сообщениями WS-Reliable.

- B1603: WCF создает конечную точку сбоя, чтобы указать, что конечная точка не обрабатывает последовательность на основе проверки `CreateSequence` заголовков адресации сообщения.

## <a name="protocol-composition"></a>Сочетаемость протокола

### <a name="composition-with-ws-addressing"></a>Сочетаемость с WS-Addressing

WCF поддерживает две версии WS-Addressing: WS-Addressing 2004/08 [WS-ADDR] и рекомендации КОНСОРЦИУМа WS-Addressing 1,0 [WS-ADDR-CORE] и [WS-ADDR-SOAP].

Поскольку в спецификации протокола WS-Reliable Messaging указана только версия WS-Addressing 2004/08, он не накладывает ограничений на используемую версию WS-Addressing. Ниже приведен список ограничений, применяемых к WCF.

- R2101:с протоколом WS-Reliable Messaging можно использовать как версию WS-Addressing 2004/08, так и версию WS-Addressing 1.0.

- R2102: одна версия WS-Addressing должна использоваться во всей заданной последовательности сообщений WS-Reliable или парой обратных последовательностей, коррелированных с помощью `wsrm:Offer` механизма.

### <a name="composition-with-soap"></a>Сочетаемость с SOAP

WCF поддерживает использование SOAP 1,1 и SOAP 1,2 с WS-Reliable Messaging.

### <a name="composition-with-ws-security-and-ws-secureconversation"></a>Сочетаемость с WS-Security и WS-SecureConversation

WCF обеспечивает защиту для последовательностей обмена сообщениями WS-Reliable с помощью защищенного транспорта (HTTPS), композиции с WS-Security и компоновки с WS-Secure диалога. Ниже приведен список ограничений, применяемых к WCF.

- R2301. чтобы защитить целостность последовательности обмена сообщениями WS-Reliable в дополнение к целостности и конфиденциальности отдельных сообщений, WCF требует, чтобы использовался WS-Secure диалог.

- R2302:перед установкой последовательностей WS-Reliable Messaging должен быть установлен сеанс WS-Secure Conversation.

- R2303: если время существования последовательности WS-Reliable Messaging превышает время существования сеанса WS-Secure Conversation, необходимо с помощью привязки обновления WS-Secure Conversation обновить маркер `SecurityContextToken`, созданный протоколом WS-Secure Conversation.

- B2304:последовательность WS-Reliable Messaging или пара встречных последовательностей всегда ограничены одним сеансом WS-SecureConversation.

  Источник WCF создает `wsse:SecurityTokenReference` элемент в разделе "Расширяемость элементов" `CreateSequence` сообщения.

- R2305: при составлении с WS-Secure диалога `CreateSequence` сообщение должно содержать `wsse:SecurityTokenReference` элемент.

## <a name="ws-reliable-messaging-ws-policy-assertion"></a>Утверждение WS-Reliable Messaging WS-Policy

`wsrm:RMAssertion`Для описания возможностей конечных точек WCF использует утверждение WS-Policy Messaging WS-Reliable. Ниже приведен список ограничений, применяемых к WCF.

- B3001: WCF присоединяет `wsrm:RMAssertion` WS-Policy утверждения к `wsdl:binding` элементам. WCF поддерживает как вложения, так `wsdl:binding` и `wsdl:port` элементы.

- B3002: WCF поддерживает следующие необязательные свойства утверждения сообщений WS-Reliable и обеспечивает контроль над ними в WCF `ReliableMessagingBindingElement` :

  - `wsrm:InactivityTimeout`

  - `wsrm:AcknowledgementInterval`

  Пример.

  ```xml
  <wsrm:RMAssertion>
    <wsrm:InactivityTimeout Milliseconds="600000" />
    <wsrm:AcknowledgementInterval Milliseconds="200" />
  </wsrm:RMAssertion>
  ```

## <a name="flow-control-ws-reliable-messaging-extension"></a>Расширение WS-Reliable Messaging для управления потоком

WCF использует WS-Reliable расширяемости обмена сообщениями для предоставления дополнительного более строгого контроля над потоком сообщений последовательности.

Управление потоком включается путем присвоения <xref:System.ServiceModel.Channels.ReliableSessionBindingElement.FlowControlEnabled?displayProperty=nameWithType> свойству значения `true` . Ниже приведен список ограничений, применяемых к WCF.

- B4001. Если включен механизм надежного управления потоком сообщений, WCF создает `netrm:BufferRemaining` элемент в расширяемости элемента `SequenceAcknowledgement` заголовка.

- B4002: при включении управления потоком надежного обмена сообщениями WCF не требует наличия `netrm:BufferRemaining` элемента в `SequenceAcknowledgement` заголовке, как показано в следующем примере.

  ```xml
  <wsrm:SequenceAcknowledgement>
    <wsrm:Identifier>
      http://fabrikam123.com/abc
    </wsrm:Identifier>
    <wsrm:AcknowledgementRange Upper="1" Lower="1"/>
    <netrm:BufferRemaining>
      8
    </netrm:BufferRemaining>
  </wsrm:SequenceAcknowledgement>
  ```

- B4003: WCF использует `netrm:BufferRemaining` , чтобы указать, сколько новых сообщений может быть помещено в буфер назначения надежного обмена сообщениями.

- B4004. служба надежного обмена сообщениями WCF регулирует количество сообщений, передаваемых, когда приложение назначения надежного обмена сообщениями не может быстро получить сообщения. Точка назначения системы надежного обмена сообщениями помещает сообщения в буфер, и значение элемента снижается до 0.

- B4005: WCF создает `netrm:BufferRemaining` целочисленные значения от 0 до 4096 включительно и считывает целочисленные значения от 0 до `xs:int` `maxInclusive` значения 214748364 включительно.

## <a name="message-exchange-patterns"></a>Шаблоны обмена сообщениями

В этом разделе описывается поведение WCF при использовании WS-Reliable обмена сообщениями для различных шаблонов обмена сообщениями. Для каждого шаблона обмена сообщениями рассматриваются два варианта развертывания:

- неадресуемый инициатор - инициатор расположен за брандмауэром, респондент может отправлять инициатору сообщения только с HTTP-ответами;

- адресуемый инициатор - как инициатор, так и респондент могут принимать HTTP-запросы, т. е. можно установить два встречных HTTP-подключения.

### <a name="one-way-non-addressable-initiator"></a>Односторонний неадресуемый инициатор

#### <a name="binding"></a>Привязка

WCF предоставляет односторонний шаблон обмена сообщениями, используя одну последовательность по одному каналу HTTP. WCF использует HTTP-запросы для передачи всех сообщений из RMS в панель RMD и HTTP-ответ для передачи всех сообщений из панели RMD в RMS.

#### <a name="createsequence-exchange"></a>Обмен сообщениями CreateSequence

Инициатор WCF создает сообщение без `CreateSequence` предложения. WCF-ответчик `CreateSequence` перед созданием последовательности гарантирует, что не имеет предложения. WCF-ответчик отвечает на `CreateSequence` запрос с `CreateSequenceResponse` сообщением.

#### <a name="sequenceacknowledgement"></a>SequenceAcknowledgement

Инициатор WCF обрабатывает подтверждения по ответу всех сообщений, за исключением `CreateSequence` сообщений и сообщений об ошибках. WCF-ответчик всегда создает изолированное подтверждение в ответ на как последовательность, так и `AckRequested` сообщения.

#### <a name="terminatesequence-message"></a>Сообщение TerminateSequence

WCF обрабатывается `TerminateSequence` как односторонняя операция, то есть HTTP-ответ содержит пустой текст и код состояния HTTP 202.

### <a name="one-way-addressable-initiator"></a>Односторонний адресуемый инициатор

#### <a name="binding"></a>Привязка

WCF предоставляет односторонний шаблон обмена сообщениями, используя одну последовательность для входящего и исходящего HTTP-канала. WCF использует HTTP-запросы для передачи всех сообщений. Все HTTP-ответы имеют пустое тело и код состояния HTTP 202.

#### <a name="createsequence-exchange"></a>Обмен сообщениями CreateSequence

Инициатор WCF создает сообщение без `CreateSequence` предложения. WCF-ответчик гарантирует, что `CreateSequence` перед созданием последовательности предложение не будет иметь предложения. Приложение WCF передает `CreateSequenceResponse` сообщение по HTTP-запросу, адресованному по ссылке на `ReplyTo` конечную точку.

### <a name="duplex-addressable-initiator"></a>Дуплексный адресуемый инициатор

#### <a name="binding"></a>Привязка

WCF предоставляет полностью асинхронный шаблон обмена сообщениями с использованием двух последовательностей через входящий и исходящий канал HTTP. WCF использует HTTP-запросы для передачи всех сообщений. Все HTTP-ответы имеют пустое тело и код состояния HTTP 202.

#### <a name="createsequence-exchange"></a>Обмен сообщениями CreateSequence

Инициатор WCF создает `CreateSequence` сообщение с предложением. WCF-ответчик обеспечивает наличие `CreateSequence` предложения перед созданием последовательности. WCF отправляет в `CreateSequenceResponse` HTTP-запрос, адресованный в `CreateSequence` `ReplyTo` ссылку на конечную точку.

#### <a name="sequence-lifetime"></a>Время существования последовательности

WCF рассматривает две последовательности как один полностью дуплексный сеанс.

При создании ошибки, которая не выполняет одну последовательность, WCF ждет, что удаленная конечная точка будет выполнять обе последовательности. При чтении ошибки, которая не выполняет одну последовательность, WCF завершает обе последовательности.

WCF может закрыть свою исходящую последовательность и продолжить обработку сообщений на его входящей последовательности. И наоборот, WCF может обработать закрытие входящей последовательности и продолжить отправку сообщений по исходящей последовательности.

### <a name="request-reply-non-addressable-initiator"></a>Обмен сообщениями запрос-ответ, неадресуемый инициатор

#### <a name="binding"></a>Привязка

WCF предоставляет односторонний шаблон обмена сообщениями типа «запрос-ответ» с использованием двух последовательностей по одному каналу HTTP. WCF использует HTTP-запросы для передачи сообщений последовательности запросов и использует HTTP-ответы для передачи сообщений последовательности ответов.

#### <a name="createsequence-exchange"></a>Обмен сообщениями CreateSequence

Инициатор WCF создает `CreateSequence` сообщение с предложением. WCF-ответчик обеспечивает наличие `CreateSequence` предложения перед созданием последовательности. WCF-ответчик отвечает на `CreateSequence` запрос с `CreateSequenceResponse` сообщением.

#### <a name="one-way-message"></a>Односторонний обмен сообщениями

Чтобы успешно завершить односторонний протокол обмена сообщениями, инициатор WCF передает сообщение последовательности запросов по HTTP-запросу и получает отдельное `SequenceAcknowledgement` сообщение для HTTP-ответа. Сообщение `SequenceAcknowledgement` должно подтвердить передачу сообщения.

WCF-ответчик может ответить на запрос с помощью подтверждения, ошибки или ответа с пустым телом и кодом состояния HTTP 202.

#### <a name="two-way-messages"></a>Двусторонний обмен сообщениями

Для успешного завершения двустороннего обмена сообщениями инициатор WCF передает сообщение последовательности запросов по HTTP-запросу и получает сообщение последовательности ответов в ответе HTTP. Ответ должен содержать подтверждение `SequenceAcknowledgement` того, что сообщение последовательности запросов было передано.

WCF-ответчик может ответить на запрос с ответом на приложение, ошибку или ответ с пустым телом и кодом состояния HTTP 202.

Из-за наличия односторонних сообщений и временных параметров ответов приложения номера последовательности запросов и номера последовательности ответов не коррелируют между собой.

#### <a name="retrying-replies"></a>Повторные попытки ответов

WCF использует корреляцию HTTP-ответа "запрос — ответ" для двусторонней корреляции протокола обмена сообщениями. По этой причине инициатор WCF не прекращает повторную попытку сообщения последовательности запроса, когда сообщение последовательностей запроса подтверждено, а когда HTTP-ответ содержит подтверждение, сообщение пользователя или сбой. WCF-ответчик повторяет ответы на стороне запроса HTTP, к которому коррелирован ответ.

#### <a name="lastmessage-exchange"></a>Обмен сообщениями LastMessage

Инициатор WCF создает и передает пустое Последнее сообщение воплощающего в конце HTTP-запроса. WCF требует ответа, но не учитывает фактическое ответное сообщение. WCF-ответчик отвечает на Последнее сообщение воплощающего последовательности запросов с последним сообщением о последовательности ответов Empty-воплощающего.

Если WCF-ответчик получает Последнее сообщение, в котором нет URI действия `http://schemas.xmlsoap.org/ws/2005/02/rm/LastMessage` , WCF отправляет ответ с последним сообщением. В случае протокола двустороннего обмена сообщениями последнее сообщение содержит сообщение приложения, а в случае протокола одностороннего обмена сообщениями последнее сообщение будет пустым.

В WCF-ответчике не требуется подтверждение для последнего сообщения воплощающего последовательности ответов.

#### <a name="terminatesequence-exchange"></a>Обмен сообщениями TerminateSequence

Когда все запросы получили допустимый ответ, инициатор WCF создает и передает сообщение последовательности запроса `TerminateSequence` на стороне HTTP-запроса. WCF требует ответа, но не учитывает фактическое ответное сообщение. WCF отвечает на сообщение последовательности запросов `TerminateSequence` с `TerminateSequence` сообщением последовательности ответов.

В обычной последовательности отключения оба сообщения `TerminateSequence` содержат полный набор `SequenceAcknowledgement`.

### <a name="requestreply-addressable-initiator"></a>Обмен сообщениями запрос-ответ, адресуемый инициатор

#### <a name="binding"></a>Привязка

WCF предоставляет шаблон обмена сообщениями типа «запрос-ответ» с использованием двух последовательностей для входящего и исходящего HTTP-канала. WCF использует HTTP-запросы для передачи всех сообщений. Все HTTP-ответы имеют пустое тело и код состояния HTTP 202.

#### <a name="createsequence-exchange"></a>Обмен сообщениями CreateSequence

Инициатор WCF создает `CreateSequence` сообщение с предложением. WCF-ответчик обеспечивает наличие `CreateSequence` предложения перед созданием последовательности. WCF отправляет в `CreateSequenceResponse` HTTP-запрос, адресованный в `CreateSequence` `ReplyTo` ссылку на конечную точку.

#### <a name="requestreply-correlation"></a>Корреляция запросов и ответов

Инициатор WCF гарантирует, что все сообщения запроса приложения поставили `MessageId` и `ReplyTo` ссылку на конечную точку. Инициатор WCF применяет `CreateSequence` ссылку на `ReplyTo` конечную точку сообщения для каждого сообщения запроса приложения. Для WCF-ответчика требуется, чтобы входящие сообщения запроса представили a `MessageId` и `ReplyTo` . WCF обеспечивает идентичность универсального кода ресурса (URI) ссылки на конечную точку для `CreateSequence` всех сообщений запроса приложения и.
