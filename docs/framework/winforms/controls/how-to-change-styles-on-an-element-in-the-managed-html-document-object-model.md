---
title: Практическое руководство. Изменение стилей элемента в управляемой объектной модели HTML-документов
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- managed HTML DOM [Windows Forms], changing styles on elements
ms.assetid: 154e8d9f-3e2d-4e8b-a6f3-c85a070e9cc1
ms.openlocfilehash: 804041991199dd2722e3a0f38800bafd8933bbab
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59333669"
---
# <a name="how-to-change-styles-on-an-element-in-the-managed-html-document-object-model"></a>Практическое руководство. Изменение стилей элемента в управляемой объектной модели HTML-документов

Стили в формате HTML можно использовать для управления внешним видом документа и его элементов. <xref:System.Windows.Forms.HtmlDocument> и <xref:System.Windows.Forms.HtmlElement> поддержки <xref:System.Windows.Forms.HtmlElement.Style%2A> свойств, которые принимают строки в следующем формате:

`name1:value1;...;nameN:valueN;`

Вот `DIV` с стиля строка, задающая шрифт Arial и весь текст, будут выводиться полужирным шрифтом:

`<DIV style="font-face:arial;font-weight:bold;">`

`Hello, world!`

`</DIV>`

Проблема при управлении стилей с помощью <xref:System.Windows.Forms.HtmlElement.Style%2A> свойство является то, что он может оказаться нелегкой задачей Добавление и удаление отдельных параметров стилей из строки. Например, он стал бы сложная процедура для отображение текста курсивом, при наведении курсора на `DIV`и отключение курсивного начертания, когда курсор покидает `DIV`. Время может стать проблемой, если необходимо управлять большим числом стили таким образом.

Следующая процедура содержит код, который можно использовать, чтобы упростить управление стилями в HTML-документы и элементы. Процедура требует, что вы знаете, как для выполнения основных задач в Windows Forms, таких как создание нового проекта и добавление элемента управления в форму.

### <a name="to-process-style-changes-in-a-windows-forms-application"></a>Для обработки изменений стилей в приложении Windows Forms

1. Создайте проект Windows Forms.

2. Создайте новый файл класса с расширением соответствующие для используемого языка программирования.

3. Копировать `StyleGenerator` код в разделе "Пример" в этом разделе класса в файл класса и сохраните код.

4. Сохраните следующий код HTML в файл с именем отнести.

    ```html
    <HTML>
        <BODY>

            <DIV style="font-face:arial;font-weight:bold;">
                Hello, world!
            </DIV><P>

            <DIV>
                Hello again, world!
            </DIV><P>

        </BODY>
    </HTML>
    ```

5. Добавить <xref:System.Windows.Forms.WebBrowser> управления с именем `webBrowser1` в главную форму проекта.

6. Добавьте следующий код в файл кода проекта.

    > [!IMPORTANT]
    >  Убедитесь, что `webBrowser1_DocumentCompleted` обработчик событий работает в режиме прослушивателя для <xref:System.Windows.Forms.WebBrowser.DocumentCompleted> событий. В Visual Studio, дважды щелкните <xref:System.Windows.Forms.WebBrowser> управления; в текстовом редакторе, настройте прослушиватель программными средствами.  
  
     [!code-csharp[ManagedDOMStyles#2](~/samples/snippets/csharp/VS_Snippets_Winforms/ManagedDOMStyles/CS/Form1.cs#2)]
       
  
7. Запустите проект. Наведите курсор на первый `DIV` Обратите внимание на действия кода.  
  
## <a name="example"></a>Пример  
 В следующем примере кода показан полный код для `StyleGenerator` класс, который выполняет синтаксический анализ значение существующего стиля, поддерживает добавление, изменение и удаление стилей и возвращает новое значение стиля с требуемыми изменениями.  
  
 [!code-csharp[ManagedDOMStyles#1](~/samples/snippets/csharp/VS_Snippets_Winforms/ManagedDOMStyles/CS/StyleGenerator.cs#1)]
   
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.HtmlElement>
