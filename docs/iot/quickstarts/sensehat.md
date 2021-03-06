---
title: Краткое руководство. использование .NET для работы с Raspberry Пи (*)
description: Приступите к работе с библиотеками .NET IoT за 5 минут с помощью встроенной платы для Raspberry Pi.
author: camsoper
ms.author: casoper
ms.date: 11/13/2020
ms.topic: quickstart
ms.prod: dotnet
ms.openlocfilehash: 28d6650187bbf7b9ce91516f4da4d09b114c904a
ms.sourcegitcommit: 9c589b25b005b9a7f87327646020eb85c3b6306f
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/06/2021
ms.locfileid: "102259704"
---
# <a name="quickstart---use-net-to-drive-a-raspberry-pi-sense-hat"></a>Краткое руководство. использование .NET для работы с Raspberry Пи (*)

Raspberry Pi [*](https://www.raspberrypi.org/products/sense-hat/) (**H** Ардваре **A** ттачед On **T** op) — это надстройка для Raspberry Pi. У точки зрения установлена схема ИНДИКАТОРов RGB размером 8 × 8, джойстик с пятью кнопками, а также следующие датчики:

- Гироскоп
- Акселерометр
- Магнитометр
- температура;
- Barometric pressure давление
- влажность.

В этом кратком руководстве используется платформа .NET для извлечения значений датчиков с точки зрения, ответа на джойстик и последующей работы с матрицей индикатора.

## <a name="prerequisites"></a>Предварительные требования

- [!INCLUDE [prereq-rpi](../includes/prereq-rpi.md)]
- Сенсорная HAT

[!INCLUDE [prepare-pi-i2c](../includes/prepare-pi-i2c.md)]

## <a name="run-the-quickstart"></a>Запуск краткого руководства

Прикрепите к Raspberry Pi сенсорную HAT. В командной строке Bash в Raspberry Pi (локальный или удаленный) выполните следующую команду:

```bash
. <(wget -q -O - https://aka.ms/dotnet-iot-sensehat-quickstart)
```

Команда скачивает и запускает скрипт. Сценарий:

- Устанавливает пакет SDK для .NET.
- Клонирование репозитория GitHub, включающего проект быстрого запуска на базе примеров.
- Выполняет построение проекта.
- Запускает проект.

Обратите внимание, что вывод консоли отображается в виде данных датчика. В матрице ИНДИКАТОРов отображается желтый пиксель на поле синего цвета. Удержание джойстика в любом направлении перемещает желтый пиксел в этом направлении. Щелчок Центральной джойстика приводит к переключению фона с синего на красный.

## <a name="get-the-source-code"></a>Получение исходного кода

Источник этого краткого руководства [доступен на сайте GitHub](https://github.com/MicrosoftDocs/dotnet-iot-assets/tree/master/quickstarts/SenseHat.Quickstart).

## <a name="next-steps"></a>Дальнейшие действия

> [!div class="nextstepaction"]
> [Научитесь использовать общего назначения ввода-вывода для мигания индикатора](../tutorials/blink-led.md)
