---
title: Доступ к членам управляемой объектной модели документов HTML, доступ к которым не предоставляется явно
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- unexposed members
- managed HTML DOM [Windows Forms], accessing unexposed members
ms.assetid: 762295bd-2355-4aa7-b43c-5bff997a33e6
ms.openlocfilehash: 20341a44eb8a43a9d130e0b76d23b513738c6782
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59129510"
---
# <a name="accessing-unexposed-members-on-the-managed-html-document-object-model"></a>Доступ к членам управляемой объектной модели документов HTML, доступ к которым не предоставляется явно
Управляемые объектной модели (DOM) HTML документа содержит класс с именем <xref:System.Windows.Forms.HtmlElement> , предоставляющая свойства, методы и события, общие для всех элементов HTML. Иногда тем не менее, необходимо будет получить доступ к членам, которые управляемый интерфейс не предоставляется напрямую. В этом разделе рассматриваются два способа получения доступа к членам, не предоставленным явно, включая [!INCLUDE[jsprjscript](../../../../includes/jsprjscript-md.md)] и функции VBScript, определенные внутри веб-страницы.  
  
## <a name="accessing-unexposed-members-through-managed-interfaces"></a>Доступ к членам, не предоставленным явно с помощью управляемых интерфейсов  
 <xref:System.Windows.Forms.HtmlDocument> и <xref:System.Windows.Forms.HtmlElement> предоставляют четыре метода, которые обеспечивают доступ к членам, не предоставленным явно. Ниже приведены типы и соответствующие методы.  
  
|Тип члена|Методы|  
|-----------------|-----------------|  
|Свойства (<xref:System.Windows.Forms.HtmlElement>)|<xref:System.Windows.Forms.HtmlElement.GetAttribute%2A><br /><br /> <xref:System.Windows.Forms.HtmlElement.SetAttribute%2A>|  
|Методы|<xref:System.Windows.Forms.HtmlElement.InvokeMember%2A>|  
|События (<xref:System.Windows.Forms.HtmlDocument>)|<xref:System.Windows.Forms.HtmlDocument.AttachEventHandler%2A><br /><br /> <xref:System.Windows.Forms.HtmlDocument.DetachEventHandler%2A>|  
|События (<xref:System.Windows.Forms.HtmlElement>)|<xref:System.Windows.Forms.HtmlElement.AttachEventHandler%2A><br /><br /> <xref:System.Windows.Forms.HtmlElement.DetachEventHandler%2A>|  
|События (<xref:System.Windows.Forms.HtmlWindow>)|<xref:System.Windows.Forms.HtmlWindow.AttachEventHandler%2A><br /><br /> <xref:System.Windows.Forms.HtmlWindow.DetachEventHandler%2A>|  
  
 При использовании этих методов, предполагается, что имеется элемент Неправильный базовый тип. Предположим, что требуется ожидать передачи данных для `Submit` событие `FORM` на HTML-странице, чтобы выполнить предварительную обработку `FORM`его значения перед их отправкой на сервер. В идеале, если у вас есть контроль над HTML, необходимо определить `FORM` уникальный `ID` атрибута.  
  
```  
<HTML>  
  
    <HEAD>  
        <TITLE>Form Page</TITLE>  
    </HEAD>  
  
    <BODY>  
        <FORM ID="form1">  
             ... form fields defined here ...  
        </FORM>  
    </BODY>  
  
</HTML>  
```  
  
 После загрузки этой страницы в <xref:System.Windows.Forms.WebBrowser> элемента управления, можно использовать <xref:System.Windows.Forms.HtmlDocument.GetElementById%2A> метод для извлечения `FORM` во время выполнения с помощью `form1` в качестве аргумента.  
  
 [!code-csharp[System.Windows.Forms.HtmlElement#10](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.HtmlElement/CS/Form1.cs#10)]
 [!code-vb[System.Windows.Forms.HtmlElement#10](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Windows.Forms.HtmlElement/VB/Form1.vb#10)]  
  
## <a name="accessing-unmanaged-interfaces"></a>Доступ к неуправляемым интерфейсам  
 Можно также получить доступ к членов, не предоставленные явно в управляемая модель HTML DOM, используя неуправляемые интерфейсы компонента объекта модели (COM), предоставляемых каждый класс DOM. Это рекомендуется, если у вас есть несколько вызовов к которым не предоставляется явно членов или не предоставленным явно члены возвращают неуправляемые интерфейсы, не заключаются в оболочку управляемому HTML DOM  
  
 В следующей таблице показаны все неуправляемые интерфейсы, предоставляемые через управляемому HTML DOM Щелкните ссылку Описание его использования и пример кода.  
  
|Тип|Неуправляемый интерфейс|  
|----------|-------------------------|  
|<xref:System.Windows.Forms.HtmlDocument>|<xref:System.Windows.Forms.HtmlDocument.DomDocument%2A>|  
|<xref:System.Windows.Forms.HtmlElement>|<xref:System.Windows.Forms.HtmlElement.DomElement%2A>|  
|<xref:System.Windows.Forms.HtmlWindow>|<xref:System.Windows.Forms.HtmlWindow.DomWindow%2A>|  
|<xref:System.Windows.Forms.HtmlHistory>|<xref:System.Windows.Forms.HtmlHistory.DomHistory%2A>|  
  
 Самый простой способ использования интерфейсов COM является добавление ссылки на неуправляемую библиотеку HTML DOM (MSHTML.dll) из своего приложения, несмотря на то, что это не поддерживается. Дополнительные сведения см. в разделе [934368 статьи базы знаний](https://support.microsoft.com/kb/934368).  
  
## <a name="accessing-script-functions"></a>Функции доступа к скрипту  
 HTML-страницы можно определить одну или несколько функций с помощью языка сценариев, таких как [!INCLUDE[jsprjscript](../../../../includes/jsprjscript-md.md)] или VBScript. Эти функции помещаются внутри `SCRIPT` страницы на странице и могут выполняться по запросу или в ответ на событие в модели DOM.  
  
 Можно вызвать любую функцию скрипта, определяются в HTML-страницы с использованием <xref:System.Windows.Forms.HtmlDocument.InvokeScript%2A> метод. Если в метод скрипта возвращает HTML-элемент, можно использовать приведение преобразовать этот возвращаемый результат <xref:System.Windows.Forms.HtmlElement>. Дополнительные сведения и пример кода, см. в разделе <xref:System.Windows.Forms.HtmlDocument.InvokeScript%2A>.  
  
## <a name="see-also"></a>См. также

- [Использование управляемой объектной модели HTML-документов](using-the-managed-html-document-object-model.md)
