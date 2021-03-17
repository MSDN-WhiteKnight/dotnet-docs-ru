---
title: Практическое руководство. Переход по заданному URL с помощью элемента управления WebBrowser
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
f1_keywords:
- WebBrowser.Navigate
helpviewer_keywords:
- WebBrowser control [Windows Forms], examples
- URLs [Windows Forms], navigating to
- WebBrowser control [Windows Forms], navigating to URLs
- examples [Windows Forms], WebBrowser control
ms.assetid: b3ec38cb-f509-4d0b-bd79-9f3611259c62
ms.openlocfilehash: a174b6ae60f87e91e6f97e8fa7f8ad3892ef017a
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59132942"
---
# <a name="how-to-navigate-to-a-url-with-the-webbrowser-control"></a>Практическое руководство. Переход по заданному URL с помощью элемента управления WebBrowser
В следующем примере кода показано, как перемещаться <xref:System.Windows.Forms.WebBrowser> управления определенный URL-адрес.  
  
 Чтобы определить, когда новый документ загружен полностью, обрабатывать <xref:System.Windows.Forms.WebBrowser.DocumentCompleted> событий. Для демонстрации этого события, см. в разделе [как: Печать с элементом управления WebBrowser](how-to-print-with-a-webbrowser-control.md).  
  
## <a name="example"></a>Пример  
  
```vb  
Me.webBrowser1.Navigate("http://www.microsoft.com")  
```  
  
```csharp  
this.webBrowser1.Navigate("http://www.microsoft.com");  
```  
  
## <a name="compiling-the-code"></a>Компиляция кода  
 Для этого примера требуются:  
  
-   элемент управления <xref:System.Windows.Forms.WebBrowser> с именем `webBrowser1`;  
  
-   ссылки на сборки `System` и `System.Windows.Forms`.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.WebBrowser>
- <xref:System.Windows.Forms.WebBrowser.DocumentCompleted?displayProperty=nameWithType>
- <xref:System.Windows.Forms.WebBrowser.Navigating?displayProperty=nameWithType>
- <xref:System.Windows.Forms.WebBrowser.Navigated?displayProperty=nameWithType>
- [Элемент управления WebBrowser](webbrowser-control-windows-forms.md)
- [Практическое руководство. Печать с использованием элемента управления WebBrowser](how-to-print-with-a-webbrowser-control.md)
