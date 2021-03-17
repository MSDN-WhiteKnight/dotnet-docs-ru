---
title: Практическое руководство. Воспроизведение звука в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- playing sounds [Windows Forms], Windows Forms
- sounds [Windows Forms], playing
- sounds
- My.Computer.Audio object [Windows Forms], playing sounds
- examples [Windows Forms], sounds
ms.assetid: 3d3350b7-1ebd-4e05-a738-48ca1160a19d
ms.openlocfilehash: 3b9eb6f902d0d2193f0099f8e868e4ead347ce26
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59078685"
---
# <a name="how-to-play-a-sound-from-a-windows-form"></a>Практическое руководство. Воспроизведение звука в Windows Forms
В этом примере воспроизводится звук по заданному пути во время выполнения.  
  
## <a name="example"></a>Пример  
  
```vb  
Sub PlaySimpleSound()  
    My.Computer.Audio.Play("c:\Windows\Media\chimes.wav")  
End Sub  
```  
  
```csharp  
private void playSimpleSound()  
{  
    SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\chimes.wav");  
    simpleSound.Play();  
}  
```  
  
## <a name="compiling-the-code"></a>Компиляция кода  
 Для этого примера требуются:  
  
-   замена имени файла `"c:\Windows\Media\chimes.wav"` на допустимое имя файла.  
  
-   (C#) Ссылку на <xref:System.Media?displayProperty=nameWithType> пространства имен.  
  
## <a name="robust-programming"></a>Отказоустойчивость  
 Операции с файлами должны быть включены в соответствующие структурированные блоки обработки исключений.  
  
 При следующих условиях возможно возникновение исключения:  
  
-   Недопустимое имя пути Например, оно содержит недопустимые символы или состоит из одних пробелов (класс <xref:System.ArgumentException>).  
  
-   Путь доступен только для чтения (класс <xref:System.IO.IOException>).  
  
-   Имя пути — `null` (класс <xref:System.ArgumentNullException>).  
  
-   Указано слишком длинное имя пути (класс <xref:System.IO.PathTooLongException>).  
  
-   Недопустимый путь (класс <xref:System.IO.DirectoryNotFoundException>).  
  
-   Путь содержит только двоеточие, «:» (<xref:System.NotSupportedException> класса).  
  
## <a name="net-framework-security"></a>Безопасность платформы .NET Framework  
 По имени файла не всегда можно с уверенностью судить о его содержимом. Например, файл с именем `Form1.vb` может вовсе не быть исходным файлом Visual Basic. Следует проверять все входные данные перед использованием их в приложении.  
  
## <a name="see-also"></a>См. также

- <xref:System.Media.SoundPlayer>
- [Практическое руководство. Асинхронная загрузка звука в Windows Forms](how-to-load-a-sound-asynchronously-within-a-windows-form.md)
