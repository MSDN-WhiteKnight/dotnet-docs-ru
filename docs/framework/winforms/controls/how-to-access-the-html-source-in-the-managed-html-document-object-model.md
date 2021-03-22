---
title: Практическое руководство. Доступ к исходному коду HTML с использованием управляемой объектной модели документов HTML
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- managed HTML DOM
- HTML [Windows Forms], accessing in Windows Forms
ms.assetid: 53db79fa-8a5e-448e-88c2-f54ace3860b6
ms.openlocfilehash: f2306e3405aa0ff37060d987bdc82b58fbaa7784
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59345564"
---
# <a name="how-to-access-the-html-source-in-the-managed-html-document-object-model"></a>Практическое руководство. Доступ к исходному коду HTML с использованием управляемой объектной модели документов HTML
Свойства <xref:System.Windows.Forms.WebBrowser.DocumentStream%2A> и <xref:System.Windows.Forms.WebBrowser.DocumentText%2A> в элементе управления <xref:System.Windows.Forms.WebBrowser> возвращают HTML текущего документа в том виде, в котором он существовал при первом отображении. Если вы измените страницу, используя вызовы таких методов и свойств, как <xref:System.Windows.Forms.HtmlElement.AppendChild%2A> и <xref:System.Windows.Forms.HtmlElement.InnerHtml%2A>, то при вызове <xref:System.Windows.Forms.WebBrowser.DocumentStream%2A> и <xref:System.Windows.Forms.WebBrowser.DocumentText%2A> эти изменения отображаться на будут. Чтобы получить актуальный HTML-источник DOM, необходимо вызвать свойство <xref:System.Windows.Forms.HtmlElement.OuterHtml%2A> по элементу HTML.  
  
 В следующей процедуре показано, как получить динамический источник и отобразить его в отдельном контекстном меню.  
  
### <a name="retrieving-the-dynamic-source-with-the-outerhtml-property"></a>Получение динамического источника с помощью свойства OuterHtml.  
  
1. Создайте новое приложение Windows Forms. Создайте одну <xref:System.Windows.Forms.Form>и назовите его `Form1`.  
  
2. Узел <xref:System.Windows.Forms.WebBrowser> управлять в приложении Windows Forms и назовите его `WebBrowser1`. Дополнительные сведения см. в разделе [Как Добавление функциональности веб-браузера в приложения Windows Forms](how-to-add-web-browser-capabilities-to-a-windows-forms-application.md).  
  
3. Создайте вторую <xref:System.Windows.Forms.Form> с именем `CodeForm`.  
  
4. Добавить <xref:System.Windows.Forms.RichTextBox> управления `CodeForm` и задайте его <xref:System.Windows.Forms.Control.Dock%2A> свойства `Fill`.  
  
5. Создайте общедоступное свойство на `CodeForm` вызывается `Code`.  
  
     [!code-csharp[DisplayWebBrowserCode#1](~/samples/snippets/csharp/VS_Snippets_Winforms/DisplayWebBrowserCode/CS/CodeForm.cs#1)]
       
  
6. Добавить <xref:System.Windows.Forms.Button> управления с именем `Button1` для вашей <xref:System.Windows.Forms.Form>и отслеживать состояние <xref:System.Windows.Forms.Control.Click> событий. Дополнительные сведения о мониторинге событий см. в разделе [события](../../../standard/events/index.md).  
  
7. Добавьте следующий код в обработчик событий <xref:System.Windows.Forms.Control.Click>.  
  
     [!code-csharp[DisplayWebBrowserCode#2](~/samples/snippets/csharp/VS_Snippets_Winforms/DisplayWebBrowserCode/CS/Form1.cs#2)]
       
  
## <a name="robust-programming"></a>Отказоустойчивость  
 Всегда тестируйте значение <xref:System.Windows.Forms.WebBrowser.Document%2A>, прежде чем пытаться его извлечь. Если текущая страница не закончила загружаться, значит, <xref:System.Windows.Forms.WebBrowser.Document%2A> либо один или несколько дочерних объектов еще не инициализированы.  
  
## <a name="see-also"></a>См. также

- [Использование управляемой объектной модели HTML-документов](using-the-managed-html-document-object-model.md)
- [Общие сведения об элементе управления WebBrowser](webbrowser-control-overview.md)
