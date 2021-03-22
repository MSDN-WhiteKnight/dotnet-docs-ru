---
title: Практическое руководство. Создание средства просмотра HTML-документов в приложении Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- WebBrowser control [Windows Forms], creating an HTML document viewer
- document viewers
- Windows Forms, creating document viewers
ms.assetid: 6a6338fe-f7ee-4f5e-9d8f-0465c57e9039
ms.openlocfilehash: 99609e4bf5a352c436986e0773375d1c8e15e790
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59340754"
---
# <a name="how-to-create-an-html-document-viewer-in-a-windows-forms-application"></a>Практическое руководство. Создание средства просмотра HTML-документов в приложении Windows Forms
Можно использовать <xref:System.Windows.Forms.WebBrowser> управления для отображения и печати HTML-документов с ограниченными возможностями обозревателя. Это полезно в том случае, если вы хотите воспользоваться преимуществами возможности форматирования HTML-кода, но запретить пользователям произвольным веб-страницам, которые могут содержать ненадежных веб-элементы управления или потенциально вредоносный код сценария. Может потребоваться ограничить возможность <xref:System.Windows.Forms.WebBrowser> управления таким образом, например, для использования в качестве средстве просмотра HTML по электронной почте или для предоставления справки формате HTML в приложении.  
  
### <a name="to-create-an-html-document-viewer"></a>Чтобы создать средство просмотра документа HTML  
  
1. Задайте <xref:System.Windows.Forms.WebBrowser.AllowWebBrowserDrop%2A> свойства `false` во избежание <xref:System.Windows.Forms.WebBrowser> управления открывать файлы, которые перетаскиваются на него.  
  
     [!code-csharp[WebBrowserMisc#20](~/samples/snippets/csharp/VS_Snippets_Winforms/WebBrowserMisc/CS/WebBrowserMisc.cs#20)]
       
  
2. Задайте <xref:System.Windows.Forms.WebBrowser.Url%2A> свойство в расположение исходного файла для отображения.  
  
     [!code-csharp[WebBrowserMisc#21](~/samples/snippets/csharp/VS_Snippets_Winforms/WebBrowserMisc/CS/WebBrowserMisc.cs#21)]
       
  
## <a name="compiling-the-code"></a>Компиляция кода  
 Для этого примера требуются:  
  
-   элемент управления <xref:System.Windows.Forms.WebBrowser> с именем `webBrowser1`;  
  
-   ссылки на сборки `System` и `System.Windows.Forms`.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.WebBrowser>
- <xref:System.Windows.Forms.WebBrowser.AllowWebBrowserDrop%2A>
- <xref:System.Windows.Forms.WebBrowser.Url%2A>
- [Общие сведения об элементе управления WebBrowser](webbrowser-control-overview.md)
- [Безопасность элемента управления WebBrowser](webbrowser-security.md)
- [Практическое руководство. Переход по заданному URL с помощью элемента управления WebBrowser](how-to-navigate-to-a-url-with-the-webbrowser-control.md)
- [Практическое руководство. Печать с использованием элемента управления WebBrowser](how-to-print-with-a-webbrowser-control.md)
