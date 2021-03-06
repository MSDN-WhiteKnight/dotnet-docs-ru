---
title: Blazor модели размещения приложений
description: Узнайте о различных способах размещения Blazor приложения, включая в браузере WebAssembly или на сервере.
author: danroth27
ms.author: daroth
no-loc:
- Blazor
- WebAssembly
ms.date: 11/20/2020
ms.openlocfilehash: 18258c54cffdc538ddd11ec1393639216f86f85a
ms.sourcegitcommit: 9c589b25b005b9a7f87327646020eb85c3b6306f
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/06/2021
ms.locfileid: "102255461"
---
# <a name="blazor-app-hosting-models"></a>Blazor модели размещения приложений

Blazor приложения могут размещаться одним из следующих способов:

- На стороне клиента в браузере WebAssembly .
- На стороне сервера в приложении ASP.NET Core.

## <a name="blazor-webassembly-apps"></a>BlazorWebAssemblyприложения

BlazorWebAssemblyприложения выполняются непосредственно в браузере в WebAssembly среде выполнения .NET на основе. BlazorWebAssemblyприложения работают аналогичным образом для интерфейсных платформ JavaScript, таких как угловая точка или реакция. Однако вместо написания кода JavaScript вы пишете код C#. Среда выполнения .NET загружается вместе с приложением вместе с сборкой приложения и необходимыми зависимостями. Подключаемые модули браузера или расширения не требуются.

Загруженные сборки являются обычными сборками .NET, как и в любом другом приложении .NET. Так как среда выполнения поддерживает .NET Standard, в приложении можно использовать существующие библиотеки .NET Standard Blazor WebAssembly . Однако эти сборки по-прежнему будут выполняться в песочнице безопасности браузера. Некоторые функции могут вызывать исключение <xref:System.PlatformNotSupportedException> , например попытку доступа к файловой системе или открытие произвольных сетевых подключений.

При загрузке приложения среда выполнения .NET запускается и указывает на сборку приложения. Выполняется логика запуска приложения, и отображаются корневые компоненты. Blazor Вычисляет обновления пользовательского интерфейса на основе отображаемых выходных данных компонентов. Затем будут применены обновления модели DOM.

![::: No-Loc (Блазор):::.:: No-Loc (сборка):::](media/hosting-models/blazor-webassembly.png)

BlazorWebAssemblyприложения выполняются исключительно на стороне клиента. Такие приложения можно развертывать на статических решениях размещения сайта, таких как страницы GitHub или размещение статических веб-сайтов Azure. Платформа .NET не требуется на сервере. Для глубокого связывания с частями приложения обычно требуется решение маршрутизации на сервере. Решение маршрутизации перенаправляет запросы в корневую папку приложения. Например, это перенаправление можно обработать с помощью правил переопределения URL-адресов в службах IIS.

Чтобы получить все преимущества Blazor и полноценную веб-разработку .NET, разместите Blazor WebAssembly приложение с помощью ASP.NET Core. Используя .NET как на клиенте, так и на сервере, вы можете легко обмениваться кодом и создавать приложения с помощью единого набора языков, платформ и средств. Blazor предоставляет удобные шаблоны для настройки решения, которое содержит как приложение, так Blazor WebAssembly и проект размещения ASP.NET Core. При построении решения созданные статические файлы из Blazor приложения размещаются в ASP.NET Core приложении, для которого уже настроена резервная маршрутизация.

## <a name="blazor-server-apps"></a>Blazor Серверные приложения

Вспомним о [ Blazor архитектуре](architecture-comparison.md#blazor) , что Blazor компоненты отображают свои выходные данные в промежуточную абстракцию, называемую `RenderTree` . BlazorЗатем платформа сравнивает то, что было подготовлено к просмотру ранее. Различия применяются к модели DOM. Blazor компоненты отделены от того, как применяются выходные данные, готовые к просмотру. Следовательно, сами компоненты не должны выполняться в том же процессе, что и процесс обновления пользовательского интерфейса. На самом деле они даже не должны выполняться на одном и том же компьютере.

В Blazor серверных приложениях компоненты выполняются на сервере, а не на стороне клиента в браузере. События пользовательского интерфейса, происходящие в браузере, отправляются на сервер через подключение в режиме реального времени. События отправляются в правильные экземпляры компонента. Компоненты визуализируются, а вычисленное различие пользовательского интерфейса сериализуется и отправляется в браузер, где он применяется к модели DOM.

![::: No-Loc (Блазор)::: сервер](media/hosting-models/blazor-server.png)

BlazorМодель размещения сервера может показаться знакомой, если вы использовали ASP.NET AJAX и <xref:System.Web.UI.UpdatePanel> элемент управления. `UpdatePanel`Элемент управления обрабатывает применение частичных обновлений страницы в ответ на события триггера на странице. При запуске `UpdatePanel` запрос запрашивает частичное обновление, а затем применяет его без необходимости обновлять страницу. Состояние пользовательского интерфейса управляется с помощью `ViewState` . Blazor Серверные приложения немного отличаются тем, что приложению требуется активное соединение с клиентом. Кроме того, все состояния пользовательского интерфейса сохраняются на сервере. Помимо этих различий, две модели концептуально похожи.

## <a name="how-to-choose-the-right-blazor-hosting-model"></a>Выбор правильной Blazor модели размещения

Как описано в документации по [ Blazor модели размещения](/aspnet/core/blazor/hosting-models), различные Blazor модели размещения имеют разные компромиссы.

Blazor WebAssembly Модель размещения имеет следующие преимущества.

- Отсутствует зависимость от .NET на стороне сервера. Приложение полностью работает после загрузки на клиент.
- Ресурсы и возможности клиента используются полностью.
- Рабочая нагрузка переносится с сервера на клиент.
- Для размещения приложения не требуется веб-сервер ASP.NET Core. Возможны сценарии бессерверного развертывания (например, обслуживание приложения из CDN).

Недостатки Blazor WebAssembly модели размещения:

- Возможности браузера ограничивают приложение.
- Требуется поддерживающее клиентское и программное обеспечение (например, WebAssembly Поддержка).
- Больше размер скачивания и время загрузки приложения.
- Поддержка среды выполнения .NET и инструментария менее развита. Например, существуют ограничения на поддержку и отладку [.NET Standard](../../standard/net-standard.md) .

И наоборот, Blazor модель размещения сервера предоставляет следующие преимущества:

- Размер скачивания гораздо меньше клиентского приложения, и приложение загружается гораздо быстрее.
- Приложение обладает всеми преимуществами серверных возможностей, включая использование любых API-интерфейсов, совместимых с .NET.
- .NET на сервере используется для запуска приложения, поэтому существующие инструменты .NET, такие как отладка, работают должным образом.
- Поддерживаются тонкие клиенты. Например, серверные приложения работают с браузерами, которые не поддерживают WebAssembly и на устройствах с ограниченным доступом к ресурсам.
- База кода приложения .NET/C#, включая код компонента приложения, не отправляется клиентам.

Недостатки Blazor модели размещения сервера:

- Более высокая задержка пользовательского интерфейса. Каждое взаимодействие с пользователем включает передачу данных по сети.
- Автономная работа не поддерживается. Если происходит сбой клиентского подключения, приложение перестает работать.
- Масштабируемость сложна для приложений со многими пользователями. Сервер должен управлять несколькими клиентскими подключениями и обрабатывать состояние клиента.
- Для обслуживания приложения требуется сервер ASP.NET Core. Сценарии бессерверного развертывания невозможны. Например, вы не можете обслуживать приложение из CDN.

Приведенный выше список компромиссов может быть вас затруднительным, но модель размещения можно изменить позже. Независимо от Blazor выбранной модели размещения, модель компонентов *одинакова*. В принципе, одни и те же компоненты можно использовать с любой моделью размещения. Код приложения не изменяется; Однако рекомендуется представить абстракции, чтобы компоненты оставались независимыми от модели. Абстракции позволяют приложению упростить внедрение другой модели размещения.

## <a name="deploy-your-app"></a>Развертывание приложения

Приложения веб-форм ASP.NET обычно размещаются в службах IIS на компьютере или в кластере Windows Server. Blazor приложения также могут:

- Размещаться в IIS либо как статические файлы, либо как приложение ASP.NET Core.
- Используйте гибкость ASP.NET Core для размещения на различных платформах и серверных инфраструктурах. Например, можно разместить Blazor приложение с помощью [nginx](/aspnet/core/host-and-deploy/linux-nginx) или [Apache](/aspnet/core/host-and-deploy/linux-apache) в Linux. Дополнительные сведения о публикации и развертывании Blazor приложений см. в документации по Blazor [размещению и развертыванию](/aspnet/core/host-and-deploy/blazor/) .

В следующем разделе мы рассмотрим, как Blazor WebAssembly настраиваются проекты для и Blazor серверных приложений.

>[!div class="step-by-step"]
>[Назад](architecture-comparison.md)
>[Вперед](project-structure.md)
