---
description: Дополнительные сведения см. в статье Поиск часовых поясов, определенных в локальной системе.
title: Поиск часового пояса, заданного в локальной системе
ms.date: 04/10/2017
helpviewer_keywords:
- time zones [.NET], local
- time zones [.NET], finding local system time zones
- time zone identifiers [.NET]
- local time zone access
- time zones [.NET], retrieving
- UTC times, finding local system time zones
- time zones [.NET], UTC
ms.assetid: 3f63b1bc-9a4b-4bde-84ea-ab028a80d3e1
ms.openlocfilehash: 1b7a4d1962adac42b47cda42d4d1223c4b79852a
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99702643"
---
# <a name="finding-the-time-zones-defined-on-a-local-system"></a>Поиск часового пояса, заданного в локальной системе

Класс <xref:System.TimeZoneInfo> не предоставляет открытый конструктор. В результате ключевое слово `new` невозможно использовать для создания нового объекта <xref:System.TimeZoneInfo>. Вместо этого экземпляры объектов <xref:System.TimeZoneInfo> создаются либо путем извлечения информации о предопределенных часовых поясах из реестра, либо путем создания пользовательского часового пояса. В этом разделе описывается создание экземпляра часового пояса из данных, хранимых в реестре. Кроме того, свойства `static` (`shared` в Visual Basic) класса <xref:System.TimeZoneInfo> предоставляют доступ к часовому поясу UTC и местному часовому поясу.

> [!NOTE]
> Для часовых поясов, которые не определены в реестре, можно создать пользовательские часовые пояса путем вызова перегрузок метода <xref:System.TimeZoneInfo.CreateCustomTimeZone%2A>. Создание настраиваемого часового пояса рассматривается в разделе [Практическое руководство. Создание часовых поясов без правил коррекции](create-time-zones-without-adjustment-rules.md) и [Практическое руководство. Создание часовых поясов с помощью правил коррекции](create-time-zones-with-adjustment-rules.md) . Кроме того, можно создать экземпляр объекта <xref:System.TimeZoneInfo>, восстановив его из сериализованной строки с использованием метода <xref:System.TimeZoneInfo.FromSerializedString%2A>. Сериализация и десериализация <xref:System.TimeZoneInfo> объекта обсуждается в разделе [Практическое руководство. Сохранение часовых поясов во внедренном ресурсе](save-time-zones-to-an-embedded-resource.md) и [Практическое руководство. Восстановление часовых поясов из разделов внедренных ресурсов](restore-time-zones-from-an-embedded-resource.md) .

## <a name="accessing-individual-time-zones"></a>Доступ к отдельным часовым поясам

Класс <xref:System.TimeZoneInfo> предоставляет два предопределенных объекта часовых поясов, которые представляют собой время UTC и местный часовой пояс. Они доступны из свойств <xref:System.TimeZoneInfo.Utc%2A> и <xref:System.TimeZoneInfo.Local%2A> соответственно. Инструкции по доступу к UTC или местным часовым поясам см. в разделе [как получить доступ к стандартным объектам времени в формате UTC и местному часовому поясу](access-utc-and-local.md).

Можно также создать экземпляр объекта <xref:System.TimeZoneInfo>, который представляет любой часовой пояс, определенный в реестре. Инструкции по созданию экземпляра определенного объекта часового пояса см. [в разделе инструкции. Создание экземпляра объекта TimeZoneInfo](instantiate-time-zone-info.md).

## <a name="time-zone-identifiers"></a>Идентификаторы часовых поясов

Идентификатор часового пояса — это важнейшее поле, которое уникально идентифицирует часовой пояс. Несмотря на то что большинство ключей являются относительно короткими, идентификатор часового пояса относительно длинный. В большинстве случаев его значение соответствует свойству <xref:System.TimeZoneInfo.StandardName%2A?displayProperty=nameWithType>, которое используется для предоставления имени стандартному времени часового пояса. Однако существуют исключения. Лучшим способом убедиться, что предоставлен действительный идентификатор, является выполнение перечисления доступных в системе часовых поясов и отслеживание связанных с ними идентификаторов.

## <a name="see-also"></a>См. также

- [Даты, время и часовые пояса](index.md)
- [Как получить доступ к стандартным объектам времени в формате UTC и местному часовому поясу](access-utc-and-local.md)
- [Как создать объект TimeZoneInfo](instantiate-time-zone-info.md)
- [Преобразование времени между часовыми поясами](converting-between-time-zones.md)
