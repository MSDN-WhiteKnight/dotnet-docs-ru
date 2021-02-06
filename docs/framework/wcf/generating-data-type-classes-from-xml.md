---
description: 'Дополнительные сведения: создание классов типов данных из XML'
title: Формирование классов типов данных из XML
ms.date: 03/30/2017
ms.assetid: e4e5e4e8-527f-44d1-92fa-8904a08784ea
ms.openlocfilehash: c79550b1e4804426267aef33860bc49d5d3b5efa
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99632143"
---
# <a name="generating-data-type-classes-from-xml"></a>Формирование классов типов данных из XML

Платформа .NET Framework 4,5 включает новую функцию для создания классов типов данных из XML. В этом разделе описывается автоматическое создание типов данных для RSS-канала блога .NET.  
  
### <a name="obtaining-the-xml-from-the-net-blog-rss-feed"></a>Получение XML из RSS-канала блога .NET  
  
1. В Internet Explorer перейдите к RSS- [каналу блога в блоге .NET](https://devblogs.microsoft.com/dotnet/feed/).  
  
2. Щелкните страницу правой кнопкой мыши и выберите пункт **Просмотр источника**.  
  
3. Скопируйте текст веб-канала, нажав клавиши **CTRL + A** , чтобы выделить весь текст, и **CTRL + C** для копирования.  
  
### <a name="creating-the-data-types"></a>Создание типов данных  
  
1. Откройте файл кода, в котором будет использоваться прокси. Этот файл должен быть частью проекта платформа .NET Framework 4,5.  
  
2. Поместите курсор в такое место в файле, чтобы он был вне пределов описанных в файле классов.  
  
3. Выберите **Правка**, **Специальная вставка**, **Вставить XML как классы**.  
  
4. Классы с именами,,, `link` `rss` `rssChannel` `rssChannelImage` `rssChannelItem` и `rssChannelItemGuid` создаются с необходимыми элементами для доступа к элементам RSS-канала.  
  
### <a name="using-the-generated-classes"></a>Использование созданных классов  
  
1. После создания классов их можно использовать в коде так же, как и любые другие классы. В следующем примере кода показана инициализация нового экземпляра класса `rssChannelImage`.  
  
    ```csharp
    var channelImage = new rssChannelImage()
    {
        title = "MyImage",
        link = "http://www.contoso.com/images/channelImage.jpg",
        url = "http://www.contoso.com/entries/myEntry.html"
    };  
    ```
