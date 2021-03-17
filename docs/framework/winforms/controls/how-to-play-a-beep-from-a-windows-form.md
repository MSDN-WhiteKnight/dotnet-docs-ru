---
title: Практическое руководство. Воспроизведение сигнала в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- sounds [Windows Forms], beep
- Windows Forms, sounds
- sounds [Windows Forms], playing
- forms [Windows Forms], sounds
- examples [Windows Forms], sounds
ms.assetid: 7ea5cded-4888-4f35-8f28-5cab1a55c973
ms.openlocfilehash: 0aa01f600873dd8853e1c33d5443448835e11455
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59146228"
---
# <a name="how-to-play-a-beep-from-a-windows-form"></a>Практическое руководство. Воспроизведение сигнала в Windows Forms
В этом примере воспроизводится звуковой сигнал во время выполнения.  
  
## <a name="example"></a>Пример  
  
```vb  
Public Sub OnePing()  
    Beep()  
End Sub  
```  
  
```csharp  
public void onePing()  
{  
    SystemSounds.Beep.Play();  
}  
```  
  
> [!NOTE]
>  Звук, воспроизводимый в C# пример кода определяется <xref:System.Media.SystemSounds.Beep%2A> параметр системы. Дополнительные сведения см. в разделе <xref:System.Media.SystemSounds>.  
  
## <a name="compiling-the-code"></a>Компиляция кода  
 Для C#, в этом примере требуется ссылка на <xref:System.Media?displayProperty=nameWithType> пространства имен.  
  
## <a name="see-also"></a>См. также

- <xref:Microsoft.VisualBasic.Interaction.Beep%2A>
- <xref:System.Media.SoundPlayer>
- [Практическое руководство. Воспроизведение системных звуков в Windows Forms](how-to-play-a-system-sound-from-a-windows-form.md)
- [Практическое руководство. Воспроизведение звука в Windows Forms](how-to-play-a-sound-from-a-windows-form.md)
