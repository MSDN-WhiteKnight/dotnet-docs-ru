---
description: 'Дополнительные сведения о: <linkedConfiguration> element'
title: <linkedConfiguration> - элемент
ms.date: 03/30/2017
f1_keywords:
- http://schemas.microsoft.com/.NetConfiguration/v2.0#configuration/assemblyBinding/linkedConfiguration
- http://schemas.microsoft.com/.NetConfiguration/v2.0#linkedConfiguration
helpviewer_keywords:
- configuration files [.NET Framework],linked configuration files
- <linkedConfiguration> element
- including configuration files
- linked configuration files
- linkedConfiguration Element
ms.assetid: 8eb34f3b-427e-4288-a7ff-c73f489deb45
ms.openlocfilehash: e4312cf788784241efc35304b632dfe1fdef1bc4
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99698665"
---
# <a name="linkedconfiguration-element"></a>Элемент \<linkedConfiguration>

Указание файла конфигурации, который следует включить.

[**\<configuration>**](configuration-element.md)\
&nbsp;&nbsp;[**\<assemblyBinding>**](assemblybinding-element-for-configuration.md)\
&nbsp;&nbsp;&nbsp;&nbsp;**\<linkedConfiguration>**

## <a name="syntax"></a>Синтаксис

```xml
<linkedConfiguration href="URL of linked configuration file" />
```

## <a name="attribute"></a>attribute

|           | Описание |
| --------- | ----------- |
| **href**  | Обязательный атрибут.<br><br>URL-адрес файла конфигурации, который необходимо включить. Единственным форматом, поддерживаемым для атрибута **href** , является `file://` . Поддерживаются локальные файлы и файлы в формате UNC. |

## <a name="parent-element"></a>Родительский элемент

|     | Описание |
| --- | ----------- |
| [**\<assemblyBinding>** Элемент](assemblybinding-element-for-configuration.md) | Определяет политику привязки сборок на уровне конфигурации. |

## <a name="child-elements"></a>Дочерние элементы

None

## <a name="remarks"></a>Remarks

**\<linkedConfiguration>** Элемент упрощает обслуживание сборок компонентов. Если одно или несколько приложений используют сборку с файлом конфигурации, находящимся в хорошо известном расположении, файлы конфигурации приложений, использующих эту сборку, могут использовать этот **\<linkedConfiguration>** элемент для включения файла конфигурации сборки, вместо того чтобы включать сведения о конфигурации напрямую. При обслуживании сборки компонента обновление общего файла конфигурации предоставляет обновленные сведения о конфигурации всем приложениям, которые используют сборку.

> [!NOTE]
> **\<linkedConfiguration>** Элемент не поддерживается для приложений с параллельными манифестами Windows.

Следующие правила управляют использованием связанных файлов конфигурации:

- Параметры в включаемых файлах конфигурации влияют только на политику привязки загрузчика и используются только загрузчиком. Включаемые файлы конфигурации могут иметь параметры, отличные от политик привязки, но эти параметры не оказывают никакого влияния.

- Единственным форматом, поддерживаемым для `href` атрибута, является `file://` . Поддерживаются локальные файлы и файлы в формате UNC.

- Ограничений на количество связанных конфигураций для каждого файла конфигурации не существует.

- Все связанные файлы конфигурации объединяются в один файл, аналогично поведению `#include` директивы в C/C++.

- **\<linkedConfiguration>** Элемент разрешен только в файлах конфигурации приложения. он игнорируется в *Machine.config*.

- Обнаружены и завершаются циклические ссылки. То есть, если **\<linkedConfiguration>** элементы последовательности файлов конфигурации образуют цикл, цикл определяется и останавливается.

## <a name="example"></a>Пример

В следующем примере показано, как включить файл конфигурации с локального жесткого диска:

```xml
<configuration>
  <assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1">
    <linkedConfiguration href="file://c:\Program Files\Contoso\sharedConfig.xml"/>
  </assemblyBinding>
</configuration>
```

## <a name="see-also"></a>См. также

- [**\<assemblyBinding>** Элемент](assemblybinding-element-for-configuration.md)
- [Схема файла конфигурации для платформа .NET Framework](index.md)
