---
description: 'Дополнительные сведения о: <add> Element для NameValueSectionHandler и DictionarySectionHandler'
title: <add> элемент для NameValueSectionHandler и DictionarySectionHandler
ms.date: 05/01/2017
f1_keywords:
- http://schemas.microsoft.com/.NetConfiguration/v2.0#configuration/sectionName/add
helpviewer_keywords:
- add Element
- <add> Element
ms.assetid: 0d4ddb53-eb2b-49c0-9c33-a8dec5c39b46
ms.openlocfilehash: 5a8cf22b21370e60086408f792f8137386d07aa3
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99713056"
---
# <a name="add-element-for-namevaluesectionhandler-and-dictionarysectionhandler"></a>\<add> элемент для NameValueSectionHandler и DictionarySectionHandler

Добавляет настраиваемые параметры приложения. Каждый **\<add>** тег содержит пару "ключ-значение".

[**\<configuration>**](configuration-element.md)\
&nbsp;&nbsp;[**\<sectionName>**](custom-element-2.md)\
&nbsp;&nbsp;&nbsp;&nbsp;**\<add>**

## <a name="syntax"></a>Синтаксис

```xml
<add key="key" value="value" />
```

## <a name="attributes"></a>Атрибуты

| Атрибут | Описание |
| --------- | ----------- |
| **key**   | Обязательный атрибут.<br><br>Задает имя параметра. |
| **value** | Обязательный атрибут.<br><br>Задает значение параметра. |

## <a name="parent-element"></a>Родительский элемент

| Элемент | Описание |
| ------- | ------------|
| [**\<sectionName>** Элемент](custom-element-2.md) | Определяет параметры для пользовательских разделов конфигурации, использующих <xref:System.Configuration.NameValueSectionHandler> <xref:System.Configuration.DictionarySectionHandler> классы и. |

## <a name="child-elements"></a>Дочерние элементы

None

## <a name="example"></a>Пример

В следующем примере показано, как определить пользовательский раздел конфигурации и использовать **\<add>** элемент для помещения параметров в раздел:

```xml
<configuration>
  <configSections>
    <section name="dictionarySample" type="System.Configuration.DictionarySectionHandler,System" />
  </configSections>
  <dictionarySample>
    <add key="myKey" value="myValue" />
  </dictionarySample>
</configuration>
```

## <a name="configuration-file"></a>Файл конфигурации

Этот элемент можно использовать в файле конфигурации приложения, файле конфигурации компьютера (*Machine.config*) и *Web.config* файлах, которые не находятся на уровне каталога приложений.

## <a name="see-also"></a>См. также

- [Схема файла конфигурации для платформа .NET Framework](index.md)
