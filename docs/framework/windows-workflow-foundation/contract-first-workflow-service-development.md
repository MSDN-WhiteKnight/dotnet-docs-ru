---
description: 'Дополнительные сведения: разработка первой службы рабочих процессов на контрактах'
title: Разработка службы рабочих процессов на основе контракта
ms.date: 03/30/2017
ms.assetid: e5dbaa7b-005f-4330-848d-58ac4f42f093
ms.openlocfilehash: 54f6c0c5de45187bd65e45d22978e6e9b105f3e6
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99792717"
---
# <a name="contract-first-workflow-service-development"></a>Разработка службы рабочих процессов на основе контракта

Начиная с платформа .NET Framework 4,5, Windows Workflow Foundation (WF) обеспечивает лучшую интеграцию между веб-службами и рабочими процессами в виде разработки рабочих процессов на основе контрактов. Средство разработки рабочих процессов на основе контракта позволяет создать контракт в Code First. Затем это средство автоматически создает в области элементов шаблон действия для каждой операции в контракте. В этом разделе содержатся общие сведения о том, как действия и свойства в службе рабочих процессов сопоставляются с атрибутами контракта службы. Пошаговый пример создания службы рабочего процесса с контрактом [: создание службы рабочего процесса, которая использует существующий контракт службы](how-to-create-a-workflow-service-that-consumes-an-existing-service-contract.md).

## <a name="in-this-topic"></a>В этом разделе

- [Сопоставление атрибутов контракта службы с атрибутами рабочего процесса](contract-first-workflow-service-development.md#MappingAttributes)

  - [Атрибуты контракта службы](contract-first-workflow-service-development.md#ServiceContract)

  - [Атрибуты контракта операции](contract-first-workflow-service-development.md#OperationContract)

  - [Атрибуты контракта сообщения](contract-first-workflow-service-development.md#MessageContract)

  - [Атрибуты контракта данных](contract-first-workflow-service-development.md#DataContract)

  - [Атрибуты контракта ошибок](contract-first-workflow-service-development.md#FaultContract)

- [Дополнительные сведения о поддержке и реализации](contract-first-workflow-service-development.md#AdditionalSupport)

  - [Неподдерживаемые функции контракта службы](contract-first-workflow-service-development.md#UnsupportedFeatures)

  - [Создание настроенных действий по обмену сообщениями](contract-first-workflow-service-development.md#ActivityGeneration)

## <a name="mapping-service-contract-attributes-to-workflow-attributes"></a><a name="MappingAttributes"></a> Сопоставление атрибутов контракта службы с атрибутами рабочего процесса

Таблицы в следующих разделах показывают различные атрибуты и свойства WCF, а также как они сопоставляются с действиями по обмену сообщениями и их свойствами в рабочем процессе на основе контракта.

- [Атрибуты контракта службы](contract-first-workflow-service-development.md#ServiceContract)

- [Атрибуты контракта операции](contract-first-workflow-service-development.md#OperationContract)

- [Атрибуты контракта сообщения](contract-first-workflow-service-development.md#MessageContract)

- [Атрибуты контракта данных](contract-first-workflow-service-development.md#DataContract)

- [Атрибуты контракта ошибок](contract-first-workflow-service-development.md#FaultContract)

### <a name="service-contract-attributes"></a><a name="ServiceContract"></a> Атрибуты контракта службы

|Имя свойства|Поддерживается|Описание|Проверка рабочего процесса|
|-------------------|---------------|-----------------|-------------------|
|CallbackContract|Нет|Возвращает или задает тип контракта обратного вызова, если контракт является дуплексным.|(не определено)|
|ConfigurationName|Нет|Возвращает или задает имя, используемое для поиска службы в файле конфигурации приложения.|(не определено)|
|HasProtectionLevel|Да|Возвращает значение, указывающее, присвоен ли участнику уровень защиты.|Свойство Receive.ProtectionLevel не должно иметь значение NULL.|
|name|Да|Возвращает или задает имя элемента \<portType> в языке WSDL.|Свойство Receive.ServiceContractName.LocalName должно согласовываться.|
|Пространство имен|Да|Возвращает или задает пространство имен элемента \<portType> в языке WSDL.|Свойство Receive.ServiceContractName.NameSpace должно согласовываться.|
|ProtectionLevel|Да|Указывает, должна ли привязка для контракта поддерживать значение свойства ProtectionLevel.|Свойство Receive.ProtectionLevel должно согласовываться.|
|SessionMode|Нет|Возвращает или задает значение, указывающее, разрешены, запрещены или требуются ли сеансы.|(не определено)|
|TypeId|Нет|Возвращает уникальный идентификатор для этого атрибута при реализации в производном классе. (Наследуется от атрибута.)|(не определено)|

Вставьте сюда основную часть подраздела.

### <a name="operation-contract-attributes"></a><a name="OperationContract"></a> Атрибуты контракта операции

|Имя свойства|Поддерживается|Описание|Проверка рабочего процесса|
|-------------------|---------------|-----------------|-------------------|
|Действие|Да|Возвращает или задает действие WS-Addressing сообщения запроса.|Свойство Receive.Action должно согласовываться.|
|AsyncPattern|Нет|Указывает, что операция реализуется асинхронно с помощью \<methodName> пары методов Begin и End \<methodName> в контракте службы.|(не определено)|
|HasProtectionLevel|Да|Возвращает значение, указывающее, должны ли сообщения этой операции шифроваться, подписываться или шифроваться и подписываться.|Свойство Receive.ProtectionLevel не должно иметь значение NULL.|
|IsInitiating|Нет|Возвращает или задает значение, указывающее, реализует ли метод операцию, которая может инициировать сеанс на сервере (если такой сеанс существует).|(не определено)|
|IsOneWay|Да|Возвращает или задает значение, указывающее, возвращает ли операция ответное сообщение.|(Не существует SendReply для этого Receive ИЛИ ReceiveReply для этого Send.)|
|IsTerminating|Нет|Возвращает или задает значение, указывающее, приводит ли операция службы к закрытию сеанса сервером после отправки ответного сообщения, если оно есть.|(не определено)|
|name|Да|Возвращает или задает имя операции.|Свойство Receive.OperationName должно согласовываться.|
|ProtectionLevel|Да|Возвращает или задает значение, указывающее, должны ли сообщения операции шифроваться, подписываться или шифроваться и подписываться.|Свойство Receive.ProtectionLevel должно согласовываться.|
|ReplyAction|Да|Возвращает или задает значение действия SOAP для ответного сообщения операции.|Свойство SendReply.Action должно согласовываться.|
|TypeId|Нет|Возвращает уникальный идентификатор для этого атрибута при реализации в производном классе. (Наследуется от атрибута.)|(не определено)|

### <a name="message-contract-attributes"></a><a name="MessageContract"></a> Атрибуты контракта сообщения

|Имя свойства|Поддерживается|Описание|Проверка рабочего процесса|
|-------------------|---------------|-----------------|-------------------|
|HasProtectionLevel|Да|Возвращает значение, указывающее, присвоен ли сообщению уровень защиты.|Проверка не выполняется (Receive.Content и SendReply.Content должны согласовываться с типом контракта сообщения).|
|IsWrapped|Да|Возвращает или задает значение, указывающее, имеет ли текст сообщения элемент программы-оболочки.|Проверка не выполняется (Receive.Content и Sendreply.Content должны согласовываться с типом контракта сообщения).|
|ProtectionLevel|Нет|Возвращает или задает значение, указывающее, необходимо ли шифровать сообщение, подписывать его или и то и другое.|(не определено)|
|TypeId|Да|Возвращает уникальный идентификатор для этого атрибута при реализации в производном классе. (Наследуется от атрибута.)|Проверка не выполняется (Receive.Content и SendReply.Content должны согласовываться с типом контракта сообщения).|
|WrapperName|Да|Возвращает или задает имя элемента программы-оболочки текста сообщения.|Проверка не выполняется (Receive.Content и SendReply.Content должны согласовываться с типом контракта сообщения).|
|WrapperNamespace|Нет|Возвращает или задает пространство имен элемента программы-оболочки текста сообщения.|(не определено)|

### <a name="data-contract-attributes"></a><a name="DataContract"></a> Атрибуты контракта данных

|Имя свойства|Поддерживается|Описание|Проверка рабочего процесса|
|-------------------|---------------|-----------------|-------------------|
|IsReference|Нет|Возвращает или задает значение, указывающее, следует ли сохранять данные ссылки на объект.|(не определено)|
|name|Да|Возвращает или задает имя для контракта данных типа.|Проверка не выполняется (Receive.Content и SendReply.Content должны согласовываться с типом контракта сообщения).|
|Пространство имен|Да|Возвращает или задает пространство имен для контракта данных типа.|Проверка не выполняется (Receive.Content и SendReply.Content должны согласовываться с типом контракта сообщения).|
|TypeId|Нет|Возвращает уникальный идентификатор для этого атрибута при реализации в производном классе. (Наследуется от атрибута.)|(не определено)|

### <a name="fault-contract-attributes"></a><a name="FaultContract"></a> Атрибуты контракта сбоя

|Имя свойства|Поддерживается|Описание|Проверка рабочего процесса|
|-------------------|---------------|-----------------|-------------------|
|Действие|Да|Возвращает или задает действие сообщения об ошибке SOAP, которое задается как компонент контракта операции.|Свойство SendReply.Action должно согласовываться.|
|DetailType|Да|Возвращает тип сериализуемого объекта, который содержит информацию об ошибке.|Свойство SendReply.Content должно согласовываться с типом.|
|HasProtectionLevel|Нет|Возвращает значение, указывающее, присвоен ли сообщению об ошибке SOAP уровень защиты.|(не определено)|
|Имя|Нет|Возвращает или задает имя сообщения об ошибке в языке WSDL.|(не определено)|
|Пространство имен|Нет|Возвращает или задает пространство имен ошибки SOAP.|(не определено)|
|ProtectionLevel|Нет|Задает уровень защиты, который требуется от привязки для ошибки SOAP.|(не определено)|
|TypeId|Нет|Возвращает уникальный идентификатор для этого атрибута при реализации в производном классе. (Наследуется от атрибута.)|(не определено)|

## <a name="additional-support-and-implementation-information"></a><a name="AdditionalSupport"></a> Дополнительные сведения о поддержке и реализации

- [Неподдерживаемые функции контракта службы](contract-first-workflow-service-development.md#UnsupportedFeatures)

- [Создание настроенных действий по обмену сообщениями](contract-first-workflow-service-development.md#ActivityGeneration)

### <a name="unsupported-service-contract-features"></a><a name="UnsupportedFeatures"></a> Неподдерживаемые функции контракта службы

- Использовать библиотеку параллельных задач (TPL) в контрактах невозможно.

- Наследование в контрактах службы не поддерживается.

### <a name="generation-of-configured-messaging-activities"></a><a name="ActivityGeneration"></a> Создание настроенных действий обмена сообщениями

Два общих статических метода добавляются в действия <xref:System.ServiceModel.Activities.Receive> и <xref:System.ServiceModel.Activities.SendReply> для поддержки создания предварительно настроенных действий сообщения, если используются службы рабочих процессов на основе контракта.

- <xref:System.ServiceModel.Activities.Receive.FromOperationDescription%2A?displayProperty=nameWithType>

- <xref:System.ServiceModel.Activities.SendReply.FromOperationDescription%2A?displayProperty=nameWithType>

Действие, созданное этими методами, должно пройти проверку по контракту и поэтому используется как часть логики проверки для <xref:System.ServiceModel.Activities.Receive> и <xref:System.ServiceModel.Activities.SendReply>. Действия <xref:System.ServiceModel.Activities.Receive.OperationName%2A>, <xref:System.ServiceModel.Activities.Receive.ServiceContractName%2A>, <xref:System.ServiceModel.Activities.Receive.Action%2A>, <xref:System.ServiceModel.Activities.Receive.SerializerOption%2A>, <xref:System.ServiceModel.Activities.Receive.ProtectionLevel%2A> и <xref:System.ServiceModel.Activities.Receive.KnownTypes%2A> предварительно настроены для соответствия импортированному контракту. На странице свойств содержимого для действий в конструкторе рабочих процессов разделы **сообщения** или **параметров** предварительно настроены для сопоставления с контрактом.

Контракты ошибок WCF также обрабатываются путем возвращения отдельного набора настроенных <xref:System.ServiceModel.Activities.SendReply> действий для каждой ошибки, отображаемой в <xref:System.ServiceModel.Description.OperationDescription.Faults%2A> <xref:System.ServiceModel.Description.FaultDescriptionCollection> .

Для других частей <xref:System.ServiceModel.Description.OperationDescription> , которые не поддерживаются в настоящее время СЛУЖБАМИ WF (например, поведения WebGet/вызывает или пользовательских операций), API будет игнорировать эти значения как часть создания и настройки. Исключения не формируются.
