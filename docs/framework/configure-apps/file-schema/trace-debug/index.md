---
description: 'Дополнительные сведения: схема параметров трассировки и отладки'
title: Схема параметров трассировки и отладки
ms.date: 03/30/2017
helpviewer_keywords:
- tracing [.NET Framework], trace and debug settings schema
- configuration schema [.NET Framework], trace and debug settings
- configuration settings [.NET Framework], tracing
- schema configuration settings
- configuration settings [.NET Framework], debugging
- trace listeners, trace and debug settings schema
- configuration sections [.NET Framework]
- elements [.NET Framework], trace and debug settings
ms.assetid: 277ca5f6-e1c4-41b6-a47f-3a67ce5b94ac
ms.openlocfilehash: 2429585c44952d2ee12547dab8f51662295bf02f
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99639656"
---
# <a name="trace-and-debug-settings-schema"></a>Схема параметров трассировки и отладки

Параметры трассировки и отладки определяют прослушиватели трассировки, собирающие, хранящие и маршрутизирующие сообщения, а также уровень, на котором установлен ключ трассировки.  
  
 В приведенной ниже таблице описывается назначение каждого элемента параметров трассировки и отладки.  
  
|Элемент|Описание|  
|-------------|-----------------|  
|[\<add>](add-element-for-listeners-for-source.md)|Добавляет прослушиватель в коллекцию `Listeners` для источника трассировки.|  
|[\<add>](add-element-for-listeners-for-trace.md)|Добавляет прослушиватель в коллекцию `Listeners`.|  
|[\<add>](add-element-for-sharedlisteners.md)|Добавляет прослушиватель в коллекцию `sharedListeners`.|  
|[\<add>](add-element-for-switches.md)|Задает уровень, на котором установлен ключ трассировки.|  
|[\<assert>](assert-element.md)|Определяет, должно ли выводиться окно сообщения при вызове метода <xref:System.Diagnostics.Debug.Assert%2A?displayProperty=nameWithType>. Кроме того, задает имя файла, в который записываются сообщения.|  
|[\<clear>](clear-element-for-listeners-for-source.md)|Очищает коллекцию `Listeners` для источника трассировки.|  
|[\<clear>](clear-element-for-listeners-for-trace.md)|Очищает коллекцию `Listeners` для трассировки.|  
|[\<filter>](filter-element-for-add-for-listeners-for-source.md)|Добавляет фильтр к прослушивателю в коллекции `Listeners` для источника трассировки.|  
|[\<filter>](filter-element-for-add-for-listeners-for-trace.md)|Добавляет фильтр к прослушивателю в коллекции `Listeners` для трассировки.|  
|[\<filter>](filter-element-for-add-for-sharedlisteners.md)|Добавляет фильтр к прослушивателю в коллекции `sharedListeners`.|  
|[\<listeners>](listeners-element-for-source.md)|Определяет прослушиватели в коллекции `Listeners` для источника трассировки.|  
|[\<listeners>](listeners-element-for-trace.md)|Определяет прослушиватели в коллекции `Listeners` для трассировки.|  
|[\<performanceCounters>](performancecounters-element.md)|Задает размер глобальной памяти, совместно используемой счетчиками производительности.|  
|[\<remove>](remove-element-for-listeners-for-trace.md)|Удаляет прослушиватель из коллекции `Listeners` для трассировки.|  
|[\<remove>](remove-element-for-listeners-for-source.md)|Удаляет прослушиватель из коллекции `Listeners` для источника трассировки.|  
|[\<sharedListeners>](sharedlisteners-element.md)|Содержит прослушиватели, на которые может ссылаться любой источник или элемент трассировки.|  
|[\<sources>](sources-element.md)|Содержит источники трассировки, которые инициируют сообщения трассировки.|  
|[\<source>](source-element.md)|Содержит источник трассировки, который инициирует сообщения трассировки.|  
|[\<switches>](switches-element.md)|Содержит ключи трассировки и уровень, на котором они установлены.|  
|[\<system.diagnostics>](system-diagnostics-element.md)|Задает прослушиватели трассировки, собирающие, хранящие и маршрутизирующие сообщения, а также уровень, на котором установлен ключ трассировки.|  
|[\<trace>](trace-element.md)|Содержит прослушиватели, которые собирают, хранят и маршрутизируют сообщения трассировки.|  
  
## <a name="see-also"></a>См. также

- <xref:System.Diagnostics.Trace>
- <xref:System.Diagnostics.TraceSource>
- <xref:System.Diagnostics.Debug>
- [Схема файла конфигурации](../index.md)
