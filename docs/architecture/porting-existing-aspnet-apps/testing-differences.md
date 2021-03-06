---
title: Сравнение вариантов тестирования между ASP.NET MVC и ASP.NET Core
description: Чем отличается тестирование между приложениями ASP.NET MVC и ASP.NET Core приложениями?
author: ardalis
ms.date: 11/13/2020
ms.openlocfilehash: f0907d09df058c07ed993c251868f00bc28b0736
ms.sourcegitcommit: 42d436ebc2a7ee02fc1848c7742bc7d80e13fc2f
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/04/2021
ms.locfileid: "102401690"
---
# <a name="compare-testing-options-between-aspnet-mvc-and-aspnet-core"></a>Сравнение вариантов тестирования между ASP.NET MVC и ASP.NET Core

Приложения ASP.NET MVC поддерживают модульное тестирование контроллеров, но этот подход часто исключает многие функции MVC, такие как маршрутизация, авторизация, привязка модели, проверка модели, фильтры и многое другое. Чтобы протестировать эти компоненты MVC в дополнение к логике в самом действии контроллера, часто требуется развернуть приложение, а затем проверить его с помощью такого средства, как Selenium. Эти тесты являются значительно более затратными, более нестабильным и медленнее, чем обычные модульные тесты, которые можно выполнять без необходимости размещения и запуска всего приложения.

[Контроллеры ASP.NET Core могут быть протестированы](/aspnet/core/mvc/controllers/testing) так же, как и контроллеры ASP.NET MVC, но с одинаковыми ограничениями. Однако [ASP.NET Core поддерживает быстрые и простые в разработке тесты интеграции](/aspnet/core/test/integration-tests) . Интеграционные тесты размещаются в `TestHost` классе и обычно настраиваются в пользовательском `WebApplicationFactory` , который может переопределять или заменять зависимости приложений. Например, часто во время интеграционных тестов приложение будет нацелено на другой источник данных и может заменить службы, отправляющие сообщения электронной почты с помощью фиктивных или макетных реализаций.

ASP.NET MVC и веб-API не поддерживали все подобные сценарии тестирования интеграции, доступные в ASP.NET Core. При любых усилиях по миграции следует выделить время для написания некоторых интеграционных тестов для вновь перенесенной системы, чтобы убедиться, что она работает должным образом и продолжить работу. Даже если вы не записываете тесты логики веб-приложения перед миграцией, настоятельно рекомендуем сделать это при переходе на ASP.NET Core.

## <a name="references"></a>Ссылки

- [Создание модульных тестов для приложений ASP.NET MVC](/aspnet/mvc/overview/older-versions-1/unit-testing/creating-unit-tests-for-asp-net-mvc-applications-cs)
- [Модульное тестирование логики контроллера в ASP.NET Core](/aspnet/core/mvc/controllers/testing)
- [Интеграционные тесты на платформе ASP.NET Core](/aspnet/core/test/integration-tests)

>[!div class="step-by-step"]
>[Назад](signalr-differences.md)
>[Вперед](migrate-large-solutions.md)
