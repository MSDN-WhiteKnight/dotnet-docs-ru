---
title: Информация о системе и Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- domain names [Windows Forms], retrieving
- SystemInformation class [Windows Forms]
- user names [Windows Forms], retrieving
- system information [Windows Forms]
ms.assetid: 30cf43a3-8cb2-4ff3-862b-6c34576616a8
ms.openlocfilehash: eeb469dbf4553634aa50d0a9ea17e9b2464defb4
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59228904"
---
# <a name="system-information-and-windows-forms"></a>Информация о системе и Windows Forms
Иногда бывает необходимо собрать сведения о компьютере, на котором приложение выполняется на для принятия решений в коде. Например возможно, функция, которая применяется только при подключении к конкретному сетевому домену; в этом случае требуется способ определения домена и отключить функцию, если домен не существует.  
  
 Можно использовать в приложениях Windows Forms <xref:System.Windows.Forms.SystemInformation> класс, чтобы определить количество сведения о компьютере во время выполнения. В следующем примере показано использование <xref:System.Windows.Forms.SystemInformation> класса для извлечения <xref:System.Windows.Forms.SystemInformation.UserName%2A> и <xref:System.Windows.Forms.SystemInformation.UserDomainName%2A>:  
  
```vb  
Dim User As String = Windows.Forms.SystemInformation.UserName  
Dim Domain As String = Windows.Forms.SystemInformation.UserDomainName  
  
MessageBox.Show("Good morning " & User & ". You are connected to " _  
& Domain)  
```  
  
```csharp  
string User = SystemInformation.UserName;  
string Domain = SystemInformation.UserDomainName;  
  
MessageBox.Show("Good morning " + User + ". You are connected to " _  
+ Domain)  
```  
  
 Все члены <xref:System.Windows.Forms.SystemInformation> , доступны только для чтения; невозможно изменить параметры пользователя. Существует более 100 членов класса, возвращение сведений обо всем из число мониторов, подключенные к компьютеру (<xref:System.Windows.Forms.SystemInformation.MonitorCount%2A>) для интервала между значками в проводнике Windows (<xref:System.Windows.Forms.SystemInformation.IconHorizontalSpacing%2A> и <xref:System.Windows.Forms.SystemInformation.IconVerticalSpacing%2A>).  
  
 Некоторые из наиболее полезными членами <xref:System.Windows.Forms.SystemInformation> класс включать <xref:System.Windows.Forms.SystemInformation.ComputerName%2A>, <xref:System.Windows.Forms.SystemInformation.DbcsEnabled%2A>, <xref:System.Windows.Forms.SystemInformation.PowerStatus%2A>, и <xref:System.Windows.Forms.SystemInformation.TerminalServerSession%2A>.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.SystemInformation>
- [Управление питанием в Windows Forms](power-management-in-windows-forms.md)
