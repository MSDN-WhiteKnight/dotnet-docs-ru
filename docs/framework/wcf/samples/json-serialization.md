---
description: 'Дополнительные сведения о: DataContractJsonSerializer Sample'
title: Пример DataContractJsonSerializer
ms.date: 03/30/2017
ms.assetid: 3c2c4747-7510-4bdf-b4fe-64f98428ef4a
ms.openlocfilehash: 258cd38f9ee532e5d750b4cabaa4214366835be7
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99726355"
---
# <a name="datacontractjsonserializer-sample"></a>Пример DataContractJsonSerializer

> [!NOTE]
> Этот пример предназначен для <xref:System.Runtime.Serialization.Json.DataContractJsonSerializer> . В большинстве сценариев, в которых участвует сериализация и десериализация JSON, мы рекомендуем использовать API в [System.Text.Jsпространства имен](../../../standard/serialization/system-text-json-overview.md).

<xref:System.Runtime.Serialization.Json.DataContractJsonSerializer> поддерживает те же типы, что и <xref:System.Runtime.Serialization.DataContractSerializer>. Формат данных JSON бывает особенно полезен при написании веб-приложений AJAX (Asynchronous JavaScript and XML). Поддержка AJAX в Windows Communication Foundation (WCF) оптимизирована для использования с ASP.NET AJAX через элемент управления ScriptManager. Примеры использования Windows Communication Foundation (WCF) с ASP.NET AJAX см. в разделе [примеры AJAX](ajax.md).  
  
Процедура настройки и инструкции по построению для данного образца приведены в конце этого раздела.  
  
В этом образце для демонстрации сериализации и десериализации используется контракт данных `Person`.  

```csharp
[DataContract]
class Person
{
    [DataMember]
    internal string name;

    [DataMember]
    internal int age;
}
```

 Чтобы сериализовать экземпляр типа `Person` в формат JSON, создайте объект <xref:System.Runtime.Serialization.Json.DataContractJsonSerializer> и с помощью метода `WriteObject` запишите данные JSON в поток.  

```csharp
Person p = new Person();
//Set up Person object...
MemoryStream stream1 = new MemoryStream();
DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Person));
ser.WriteObject(stream1, p);
```

 Поток памяти содержит допустимые данные JSON.
  
```json  
{"age":42,"name":"John"}  
```  
  
 В этом образце показана десериализация данных JSON в объект. Для этого необходимо перемотать назад поток и вызвать метод `ReadObject`.  

```csharp
Person p2 = (Person)ser.ReadObject(stream1);
```

 Проверка объекта `p2` позволяет понять, что данные JSON были десериализованы правильно.  
  
> [!IMPORTANT]
> Образцы уже могут быть установлены на компьютере. Перед продолжением проверьте следующий каталог (по умолчанию).  
>
> `<InstallDrive>:\WF_WCF_Samples`  
>
> Если этот каталог не существует, перейдите к [примерам Windows Communication Foundation (WCF) и Windows Workflow Foundation (WF) для платформа .NET Framework 4](https://www.microsoft.com/download/details.aspx?id=21459) , чтобы скачать все Windows Communication Foundation (WCF) и [!INCLUDE[wf1](../../../../includes/wf1-md.md)] примеры. Этот образец расположен в следующем каталоге.  
>
> `<InstallDrive>:\WF_WCF_Samples\WCF\Basic\Ajax\JsonSerialization`  
  
#### <a name="to-set-up-build-and-run-the-sample"></a>Настройка, построение и выполнение примера  
  
1. Создайте решение Жсонсериализатион. sln, как описано в разделе [Создание примеров Windows Communication Foundation](building-the-samples.md).  
  
2. Запустите получившееся консольное приложение.  
