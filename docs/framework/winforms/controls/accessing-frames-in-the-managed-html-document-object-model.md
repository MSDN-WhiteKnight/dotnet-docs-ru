---
title: Доступ к фреймам с использованием управляемой объектной модели HTML-документов
ms.date: 03/30/2017
helpviewer_keywords:
- HTML [Windows Forms], dOM
- managed HTML DOM
- HTML [Windows Forms], managed
- HTML DOM [Windows Forms], managed
- frames [Windows Forms], accessing
- DOM [Windows Forms], accessing frames in managed HTML
ms.assetid: cdeeaa22-0be4-4bbf-9a75-4ddc79199f8d
ms.openlocfilehash: 9b2719ca000ab86b9ca40f9e78af46cbf598d16e
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59337634"
---
# <a name="accessing-frames-in-the-managed-html-document-object-model"></a>Доступ к фреймам с использованием управляемой объектной модели HTML-документов
Некоторые HTML-документы состоят из *кадров*, или windows, которые могут содержать другие документы HTML. Использование фреймов упрощает создание HTML-страниц, в которых одна или несколько частей страницы остаются статичными, например панель навигации, а в остальных фреймах содержимое постоянно изменяется.  
  
 Авторы HTML-кода могут создавать фреймы одним из двух способов:  
  
-   С помощью тегов `FRAMESET` и `FRAME`, которые создают фиксированные окна.  
  
 -или-  
  
-   С помощью тега `IFRAME`, он создает плавающее окно, которое может быть перемещено во время выполнения.  
  
1. Так как фреймы содержат HTML-документы, то в объектной модели документа (DOM) они представлены и как элементы-окна и как элементы-фреймы.  
  
2. При доступе к тегу `FRAME` или `IFRAME` с использованием коллекции Frames <xref:System.Windows.Forms.HtmlWindow>, необходимо извлечь элемент-окно, соответствующий фрейму. Он представляет все динамические свойства фрейма, такие как текущий URL-адрес, документ и размер.  
  
3. При доступе к тегу `FRAME` или `IFRAME` с помощью свойства <xref:System.Windows.Forms.HtmlWindow.WindowFrameElement%2A><xref:System.Windows.Forms.HtmlWindow>, коллекции <xref:System.Windows.Forms.HtmlElement.Children%2A> или таких методов, как <xref:System.Windows.Forms.HtmlElementCollection.GetElementsByName%2A> или <xref:System.Windows.Forms.HtmlDocument.GetElementById%2A>, происходит извлечение элемента фрейма. Он представляет статические свойства фрейма, включая URL-адрес, указанный в исходном HTML-файле.  
  
## <a name="frames-and-security"></a>Фреймы и безопасность  
 Доступ к фреймам усложняется тем фактом, что управляемая модель HTML DOM реализует меры безопасности, называемые *сценария безопасности между рамками*. Если документ содержит `FRAMESET` с двумя или более `FRAME` в различных доменах, эти `FRAME` не смогут взаимодействовать друг с другом. Другими словами `FRAME` , отображает содержимое с веб-сайт не может получить доступ к `FRAME` , на котором размещается сторонний сайт например `http://www.adatum.com/`. Безопасность реализуется на уровне класса <xref:System.Windows.Forms.HtmlWindow>. Можно получать общие сведения о размещении другого веб-сайта в `FRAME`, например его URL-адрес, но невозможно получить доступ к его <xref:System.Windows.Forms.HtmlWindow.Document%2A>, изменить размер или расположение `FRAME` или `IFRAME`, в которых он размещен.  
  
 Это правило также применяется к окнам, которые можно открыть с помощью методов <xref:System.Windows.Forms.HtmlWindow.Open%2A> и <xref:System.Windows.Forms.HtmlWindow.OpenNew%2A>. Если открываемое окно относится к другому домену, отличающемуся от домена страницы, размещенной в элементе управления <xref:System.Windows.Forms.WebBrowser>, то перемещение окна или доступ к его содержимому невозможны. Эти ограничения также применяются принудительно при использовании элемента управления <xref:System.Windows.Forms.WebBrowser> для отображения веб-сайта, который отличается от веб-сайта, на котором развернуто приложение Windows Forms. Если используется технология развертывания [!INCLUDE[ndptecclick](../../../../includes/ndptecclick-md.md)] для установки приложения с веб-сайта A и используется <xref:System.Windows.Forms.WebBrowser> для отображения веб-сайта Б, то доступ к данным веб-сайта Б будет отсутствовать.  
  
## <a name="see-also"></a>См. также

- [\<кадр > элемент](https://developer.mozilla.org/docs/Web/HTML/Element/frame)
- [Использование управляемой объектной модели HTML-документов](using-the-managed-html-document-object-model.md)
