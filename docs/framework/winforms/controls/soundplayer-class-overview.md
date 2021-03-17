---
title: Общие сведения о классе SoundPlayer
ms.date: 03/30/2017
helpviewer_keywords:
- playing sounds [Windows Forms], SoundPlayer class
- SoundPlayer class [Windows Forms], about SoundPlayer class
- sounds [Windows Forms], playing
ms.assetid: fcebb938-62b9-4677-9cbe-6465bc863e22
ms.openlocfilehash: 3ff23cbfa78b803d4526e7a7c389fd5d458a967c
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59195011"
---
# <a name="soundplayer-class-overview"></a>Общие сведения о классе SoundPlayer
Класс <xref:System.Media.SoundPlayer> позволяет облегчить добавление звуков в приложениях.  
  
 <xref:System.Media.SoundPlayer> Класс может воспроизводить звуковые файлы в формате WAV из ресурса или расположения UNC или HTTP. Кроме того <xref:System.Media.SoundPlayer> класс позволяет загружать и воспроизводить звуки асинхронно.  
  
 Можно также использовать класс <xref:System.Media.SystemSounds> для воспроизведения системных звуков, в том числе звукового сигнала.  
  
## <a name="commonly-used-properties-methods-and-events"></a>Часто используемые свойства, методы и события  
  
|name|Описание|  
|----------|-----------------|  
|<xref:System.Media.SoundPlayer.SoundLocation%2A> свойство;|Путь к файлу или веб-адресу звука. Допустимые значения включают UNC- или HTTP-путь.|  
|<xref:System.Media.SoundPlayer.LoadTimeout%2A> свойство;|Время ожидания программой загрузки звука (в миллисекундах), прежде чем будет создано исключение. По умолчанию используется значение 10 секунд.|  
|<xref:System.Media.SoundPlayer.IsLoadCompleted%2A> свойство;|Логическое значение, показывающее, завершилась ли загрузка звука.|  
|<xref:System.Media.SoundPlayer.Load%2A> метод|Загружает звук синхронно.|  
|<xref:System.Media.SoundPlayer.LoadAsync%2A> метод|Начинает загрузку звука асинхронно. Когда загрузка завершена, он вызывает <xref:System.Media.SoundPlayer.OnLoadCompleted%2A> событий.|  
|<xref:System.Media.SoundPlayer.Play%2A> метод|Воспроизводит звук, указанный в <xref:System.Media.SoundPlayer.SoundLocation%2A> или <xref:System.Media.SoundPlayer.Stream%2A> свойство в новом потоке.|  
|<xref:System.Media.SoundPlayer.PlaySync%2A> метод|Воспроизводит звук, указанный в <xref:System.Media.SoundPlayer.SoundLocation%2A> или <xref:System.Media.SoundPlayer.Stream%2A> свойств в текущем потоке.|  
|<xref:System.Media.SoundPlayer.Stop%2A> метод|Останавливает воспроизведение звука.|  
|<xref:System.Media.SoundPlayer.LoadCompleted> событие|Возникает после попытки загрузки звука.|  
  
## <a name="see-also"></a>См. также

- <xref:System.Media.SoundPlayer>
- <xref:System.Media.SystemSounds>
