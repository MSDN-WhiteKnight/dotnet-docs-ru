---
title: Практическое руководство. Связывание с веб-службой с помощью компонента BindingSource в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- Web services [Windows Forms], binding controls
- BindingSource component [Windows Forms], binding to a Web service
- examples [Windows Forms], BindingSource component
- controls [Windows Forms], binding to Web service
- BindingSource component [Windows Forms], examples
ms.assetid: ee261207-4573-4cb9-a8cb-5185037e0fba
ms.openlocfilehash: 2f97a8c9b0d3f29ada108afaea92f39af3ac6b3e
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59331004"
---
# <a name="how-to-bind-to-a-web-service-using-the-windows-forms-bindingsource"></a>Практическое руководство. Связывание с веб-службой с помощью компонента BindingSource в Windows Forms
Компонент <xref:System.Windows.Forms.BindingSource> можно использовать, если необходимо привязать элемент управления Windows Form к результатам вызова веб-служб XML.  Эта процедура аналогична привязке компонента <xref:System.Windows.Forms.BindingSource> к типу. Необходимо создать клиентский прокси, который содержит методы и типы, предоставляемые веб-службой. Клиентский прокси веб-службы можно создать либо непосредственно в самой веб-службе (ASMX-файл) или с помощью файла языка описания веб-служб (WSDL-файл). Кроме того, клиентский прокси должен предоставлять доступ к полям сложных типов, используемых веб-службой, в виде общих свойств. Затем <xref:System.Windows.Forms.BindingSource> привязывается к одному из типов, доступных в прокси веб-службы.  
  
### <a name="to-create-and-bind-to-a-client-side-proxy"></a>Создание и привязка к прокси на стороне клиента  
  
1. Создайте форму Windows Forms в каталоге по своему усмотрению с подходящим пространством имен.  
  
2. Добавьте в форму компонент <xref:System.Windows.Forms.BindingSource>.  
  
3. Откройте командную строку [!INCLUDE[winsdklong](../../../../includes/winsdklong-md.md)] и перейдите к каталогу, в котором расположена форма.  
  
4. С помощью средства WSDL введите `wsdl` и URL-адрес для ASMX- или WSDL-файла веб-службы, пространство имен приложения и при необходимости язык, с которым вы работаете.  
  
     В следующем примере кода используется веб-службы, расположенный `http://webservices.eraserver.net/zipcoderesolver/zipcoderesolver.asmx`. Например, для C# типа `wsdl http://webservices.eraserver.net.zipcoderesolver/zipcoderesolver.asmx /n:BindToWebService` или для Visual Basic введите `wsdl http://webservices.eraserver.net.zipcoderesolver/zipcoderesolver.asmx /n:BindToWebService /language:VB`. Передача пути в качестве аргумента для средства WSDL создаст клиентский прокси в том же каталоге и с тем пространством имен, что и у приложения, и на указанном языке. Если вы используете Visual Studio, добавьте файл в проект.  
  
5. Выберите тип для привязки в клиентском прокси.  
  
     Обычно это тип, возвращаемый методом, предлагаемым веб-службой. Поля выбранного типа должны предоставляться как общие свойства для привязки.  
  
     [!code-cpp[System.Windows.Forms.DataConnectorWebService#4](~/samples/snippets/cpp/VS_Snippets_Winforms/System.Windows.Forms.DataConnectorWebService/CPP/form1.cpp#4)]
     [!code-csharp[System.Windows.Forms.DataConnectorWebService#4](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataConnectorWebService/CS/form1.cs#4)]
       
  
6. Задайте для свойства <xref:System.Windows.Forms.BindingSource.DataSource%2A> в <xref:System.Windows.Forms.BindingSource> нужный тип, содержащийся в клиентском прокси веб-службы.  
  
     [!code-cpp[System.Windows.Forms.DataConnectorWebService#2](~/samples/snippets/cpp/VS_Snippets_Winforms/System.Windows.Forms.DataConnectorWebService/CPP/form1.cpp#2)]
     [!code-csharp[System.Windows.Forms.DataConnectorWebService#2](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataConnectorWebService/CS/form1.cs#2)]
       
  
### <a name="to-bind-controls-to-the-bindingsource-that-is-bound-to-a-web-service"></a>Привязка элементов управления к компоненту BindingSource, который привязан к веб-службе  
  
-   Привяжите элементы управления к <xref:System.Windows.Forms.BindingSource>, передав в качестве параметра общее свойство типа веб-службы.  
  
     [!code-cpp[System.Windows.Forms.DataConnectorWebService#3](~/samples/snippets/cpp/VS_Snippets_Winforms/System.Windows.Forms.DataConnectorWebService/CPP/form1.cpp#3)]
     [!code-csharp[System.Windows.Forms.DataConnectorWebService#3](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataConnectorWebService/CS/form1.cs#3)]
       
  
## <a name="example"></a>Пример  
 В следующем примере кода показано, как привязать компонент <xref:System.Windows.Forms.BindingSource> к веб-службе, а затем привязать текстовое поле к компоненту <xref:System.Windows.Forms.BindingSource>. При нажатии кнопки вызывается метод веб-службы, результаты будут отображаться в `textbox1`.  
  
 [!code-cpp[System.Windows.Forms.DataConnectorWebService#1](~/samples/snippets/cpp/VS_Snippets_Winforms/System.Windows.Forms.DataConnectorWebService/CPP/form1.cpp#1)]
 [!code-csharp[System.Windows.Forms.DataConnectorWebService#1](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataConnectorWebService/CS/form1.cs#1)]
   
  
## <a name="compiling-the-code"></a>Компиляция кода  
 Это завершенный пример, включающий метод `Main` и сокращенную версию кода клиентского прокси.  
  
 Для этого примера требуются:  
  
-   ссылки на сборки System, System.Drawing, System.Web.Services, System.Windows.Forms и System.XML.  
  
 Сведения о выполнении сборки этого примера из командной строки для Visual Basic или Visual C#, см. в разделе [построение из командной строки](../../../visual-basic/reference/command-line-compiler/building-from-the-command-line.md) или [командной строки создания с помощью csc.exe](../../../csharp/language-reference/compiler-options/command-line-building-with-csc-exe.md). Можно также сборке этого примера в Visual Studio путем вставки кода в новый проект.  
  
## <a name="see-also"></a>См. также

- [Компонент BindingSource](bindingsource-component.md)
- [Практическое руководство. Связывание элемента управления с типом в Windows Forms](how-to-bind-a-windows-forms-control-to-a-type.md)
