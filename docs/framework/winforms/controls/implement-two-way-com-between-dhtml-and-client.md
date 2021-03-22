---
title: Практическое руководство. Реализация двунаправленного взаимодействия между кодом DHTML и клиентским кодом приложений
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
f1_keywords:
- WebBrowser.ObjectForScripting
- WebBrowser.Document
helpviewer_keywords:
- WebBrowser control [Windows Forms], examples
- communications [Windows Forms], DHTML and client applications
- examples [Windows Forms], WebBrowser control
- WebBrowser control [Windows Forms], communication between DHTML and client application
- DHTML [Windows Forms], embedding in Windows Forms
ms.assetid: 55353a32-b09e-4479-a521-ff3a5ff9a708
ms.openlocfilehash: cf1391e88c03095e0851d75ae6d50f8e809d13e9
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59295618"
---
# <a name="how-to-implement-two-way-communication-between-dhtml-code-and-client-application-code"></a>Практическое руководство. Реализация двунаправленного взаимодействия между кодом DHTML и клиентским кодом приложений
Элемент управления <xref:System.Windows.Forms.WebBrowser> можно использовать для добавления существующего динамического кода веб-приложений HTML (DHTML) в клиентские приложения Windows Forms. Это полезно, если на разработку элементов управления DHTML затрачено немало времени и нужно воспользоваться широкими возможностями интерфейса Windows Forms, не тратя время на переписывание существующего кода.  
  
 Элемент управления <xref:System.Windows.Forms.WebBrowser> позволяет реализовать двусторонний обмен данными между кодом клиентского приложения и кодом скрипта веб-страницы с помощью свойств <xref:System.Windows.Forms.WebBrowser.ObjectForScripting%2A> и <xref:System.Windows.Forms.WebBrowser.Document%2A>. Кроме того, вы можете настроить элемент управления <xref:System.Windows.Forms.WebBrowser> так, чтобы веб-элементы управления выглядели точно так же, как другие элементы управления в форме приложения, то есть чтобы скрыть их реализацию посредством DHTML. Для одновременного использования элементов управления следует отформатировать страницу так, чтобы ее фоновый цвет и стиль оформления соответствовали остальной форме, и использовать свойства <xref:System.Windows.Forms.WebBrowser.AllowWebBrowserDrop%2A>, <xref:System.Windows.Forms.WebBrowser.IsWebBrowserContextMenuEnabled%2A> и <xref:System.Windows.Forms.WebBrowser.WebBrowserShortcutsEnabled%2A> для отключения стандартных функций браузера.  
  
### <a name="to-embed-dhtml-in-your-windows-forms-application"></a>Внедрение DHTML в приложение Windows Forms  
  
1. Присвойте свойству <xref:System.Windows.Forms.WebBrowser.AllowWebBrowserDrop%2A> элемента управления <xref:System.Windows.Forms.WebBrowser> значение `false`, чтобы элемент управления <xref:System.Windows.Forms.WebBrowser> не открывал файлы, которые перетаскиваются в него мышью.  
  
     [!code-csharp[System.Windows.Forms.WebBrowser.ObjectForScripting#1](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.WebBrowser.ObjectForScripting/CS/form1.cs#1)]
       
  
2. Присвойте свойству <xref:System.Windows.Forms.WebBrowser.IsWebBrowserContextMenuEnabled%2A> значение `false`, чтобы элемент управления <xref:System.Windows.Forms.WebBrowser> не выводил контекстное меню при щелчке правой кнопкой мыши.  
  
     [!code-csharp[System.Windows.Forms.WebBrowser.ObjectForScripting#2](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.WebBrowser.ObjectForScripting/CS/form1.cs#2)]
       
  
3. Присвойте свойству <xref:System.Windows.Forms.WebBrowser.WebBrowserShortcutsEnabled%2A> значение `false`, чтобы элемент управления <xref:System.Windows.Forms.WebBrowser> не отвечал на нажатие сочетаний клавиш.  
  
     [!code-csharp[System.Windows.Forms.WebBrowser.ObjectForScripting#3](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.WebBrowser.ObjectForScripting/CS/form1.cs#3)]
       
  
4. Задайте свойство <xref:System.Windows.Forms.WebBrowser.ObjectForScripting%2A> в конструкторе формы или в обработчике событий <xref:System.Windows.Forms.Form.Load>.  
  
     В приведенном ниже коде для объекта скрипта используется класс формы.  
  
    > [!NOTE]
    >  Модель COM должна иметь доступ к объекту скрипта. Чтобы сделать форму доступной для COM, добавьте в класс формы атрибут <xref:System.Runtime.InteropServices.ComVisibleAttribute>.  
  
     [!code-csharp[System.Windows.Forms.WebBrowser.ObjectForScripting#4](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.WebBrowser.ObjectForScripting/CS/form1.cs#4)]
       
  
5. Реализуйте в коде приложения открытые свойства или методы, которые будет использовать код скрипта.  
  
     Например, если для объекта скрипта используется класс формы, добавьте в этот класс приведенный ниже код.  
  
     [!code-csharp[System.Windows.Forms.WebBrowser.ObjectForScripting#5](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.WebBrowser.ObjectForScripting/CS/form1.cs#5)]
       
  
6. Используйте объект `window.external` в коде скрипта для доступа к открытым свойствам и методам указанного объекта.  
  
     Во фрагменте кода HTML ниже показано, как вызвать метод объекта скрипта после нажатия на кнопку. Скопируйте этот код в элемент BODY документа HTML, загруженного с помощью метода <xref:System.Windows.Forms.WebBrowser.Navigate%2A> элемента управления или назначенного свойству <xref:System.Windows.Forms.WebBrowser.DocumentText%2A>.  
  
    ```  
    <button onclick="window.external.Test('called from script code')">  
        call client code from script code  
    </button>  
    ```  
  
7. Реализуйте в коде скрипта функции, которые будет использовать код приложения.  
  
     Пример такой функции представлен в HTML-элементе SCRIPT ниже. Скопируйте этот код в элемент HEAD документа HTML, загруженного с помощью метода <xref:System.Windows.Forms.WebBrowser.Navigate%2A> элемента управления или назначенного свойству <xref:System.Windows.Forms.WebBrowser.DocumentText%2A>.  
  
    ```  
    <script>  
    function test(message) {   
        alert(message);   
    }  
    </script>  
    ```  
  
8. Используйте свойство <xref:System.Windows.Forms.WebBrowser.Document%2A> для доступа к коду скрипта из кода клиентского приложения.  
  
     Например, добавьте приведенный ниже код в обработчик событий кнопки <xref:System.Windows.Forms.Control.Click>.  
  
     [!code-csharp[System.Windows.Forms.WebBrowser.ObjectForScripting#8](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.WebBrowser.ObjectForScripting/CS/form1.cs#8)]
       
  
9. По окончании отладки кода DHTML присвойте свойству <xref:System.Windows.Forms.WebBrowser.ScriptErrorsSuppressed%2A> значение `true`, чтобы элемент управления <xref:System.Windows.Forms.WebBrowser> не выводил сообщения об ошибках в коде скрипта.  
  
     [!code-csharp[System.Windows.Forms.WebBrowser.ObjectForScripting#9](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.WebBrowser.ObjectForScripting/CS/form1.cs#9)]
       
  
## <a name="example"></a>Пример  
 В примере ниже приводится полный код демонстрационного приложения, которое поможет лучше разобраться в описываемой возможности. Код HTML загружается в элемент управления <xref:System.Windows.Forms.WebBrowser> посредством свойства <xref:System.Windows.Forms.WebBrowser.DocumentText%2A> вместо загрузки из отдельного HTML-файла.  
  
 [!code-csharp[System.Windows.Forms.WebBrowser.ObjectForScripting#0](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.WebBrowser.ObjectForScripting/CS/form1.cs#0)]
   
  
## <a name="compiling-the-code"></a>Компиляция кода  
 Для этого примера кода требуются:  
  
-   ссылки на сборки System и System.Windows.Forms;  
  
 Сведения о выполнении сборки этого примера из командной строки для Visual Basic или Visual C#, см. в разделе [построение из командной строки](../../../visual-basic/reference/command-line-compiler/building-from-the-command-line.md) или [командной строки создания с помощью csc.exe](../../../csharp/language-reference/compiler-options/command-line-building-with-csc-exe.md). Можно также сборке этого примера в Visual Studio путем вставки кода в новый проект.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.WebBrowser>
- <xref:System.Windows.Forms.WebBrowser.Document%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.WebBrowser.ObjectForScripting%2A?displayProperty=nameWithType>
- [Элемент управления WebBrowser](webbrowser-control-windows-forms.md)
