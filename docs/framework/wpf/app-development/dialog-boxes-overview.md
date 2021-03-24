---
title: Общие сведения о диалоговых окнах
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- modeless dialog boxes [WPF]
- dialog boxes [WPF]
- message boxes [WPF]
- modal dialog boxes [WPF]
ms.assetid: 0d23d544-a393-4a02-a3aa-d8cd5d3d6511
ms.openlocfilehash: 162414dbd4b0f5e15eceaf73c87c122701fefc4e
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59177415"
---
# <a name="dialog-boxes-overview"></a>Общие сведения о диалоговых окнах
Автономные приложения обычно имеют главное окно, отображающее основные данные, по которому приложение работает и предоставляет функциональные возможности для обработки этих данных через [!INCLUDE[TLA#tla_ui](../../../../includes/tlasharptla-ui-md.md)] такие механизмы, как строки меню, панелей инструментов и строки состояния. Нетривиальное приложение может также отображать дополнительные окна для следующих целей:  
  
-   отображения определенных сведений для пользователей;  
  
-   сбора сведений от пользователей;  
  
-   сбора и отображения сведений.  
  
 Такие типы окон называются *диалоговым окнам*, и двух типов: модальные и немодальные.  
  
 Объект *модального* диалоговое окно отображается функцией, когда функция требует дополнительные данные от пользователя для продолжения. Поскольку функция зависит от модального диалогового окна для сбора данных, это окно также не разрешает пользователю активизировать другие окна в приложении, пока остается открытым. В большинстве случаев модальное диалоговое окно разрешает пользователю сообщать о завершении работы с модальным диалоговым окном можно нажать клавишу **ОК** или **отменить** кнопки. Нажав клавишу **ОК** кнопка обозначает, что пользователь ввел данные и желает, чтобы функция продолжила работу с этим данным. Нажав клавишу **отменить** кнопка обозначает, что пользователь хочет остановить выполнение функции. Наиболее распространенными примерами модальных диалоговых окон являются окна, которые отображаются для открытия, сохранения и печати данных.  
  
 Объект *немодальное* диалоговое окно, с другой стороны, не запрещает пользователю активацию других окон, когда он открыт. Например, если пользователь хочет найти вхождения конкретного слова в документе, главное окно часто открывает диалоговое окно с запросом слова для поиска. Так как поиск слова не мешает пользователю редактировать документ, диалоговое окно не обязательно должно быть модальным. Немодальное диалоговое окно содержит по крайней **закрыть** кнопку, чтобы закрыть диалоговое окно и может предоставлять дополнительные кнопки для выполнения определенных функций, таких как **Найти далее** кнопку, чтобы найти Далее, word соответствует критерию поиска.  
  
 Windows Presentation Foundation (WPF) позволяет создавать несколько типов диалоговых окон, включая окна сообщений, общие диалоговые окна и пользовательские диалоговые окна. В этом разделе обсуждаются и [пример диалогового окна](https://go.microsoft.com/fwlink/?LinkID=159984) приводятся соответствующие примеры.  

<a name="Message_Boxes"></a>   
## <a name="message-boxes"></a>Окна сообщений  
 Объект *окно сообщения* является диалоговым окном, которое может использоваться для отображения текстовых данных и разрешить пользователям принимать решения с помощью кнопок. На следующем рисунке показано окно сообщения, в котором отображается текстовая информация, задается вопрос и предоставляются три кнопки для ответа на этот вопрос.  
  
 ![Закрывает текстовый процессор диалоговое окно с запросом, если вы хотите сохранить изменения в документе перед приложения.](./media/dialog-boxes-overview/word-processor-dialog.png)  
  
 Для создания окна сообщения, используйте <xref:System.Windows.MessageBox> класса. <xref:System.Windows.MessageBox> позволяет настроить текст в окне сообщения, заголовок, значок и кнопки с помощью следующего кода.  
  
 [!code-csharp[DialogBoxesOverviewSnippets#MsgBoxConfigureCODEBEHIND](~/samples/snippets/csharp/VS_Snippets_Wpf/DialogBoxesOverviewSnippets/CSharp/Window1.xaml.cs#msgboxconfigurecodebehind)]
   
  
 Чтобы отобразить окно сообщения, вызовите `static`<xref:System.Windows.MessageBox.Show%2A> метод, как показано в следующем коде.  
  
 [!code-csharp[DialogBoxesOverviewSnippets#MsgBoxShowCODEBEHIND](~/samples/snippets/csharp/VS_Snippets_Wpf/DialogBoxesOverviewSnippets/CSharp/Window1.xaml.cs#msgboxshowcodebehind)]
   
  
 Когда коду, который показывает окно сообщения, нужно определить и обработать решение пользователя (какая кнопка была нажата), он может проверить результат окна сообщения, как показано в следующем коде.  
  
 [!code-csharp[DialogBoxesOverviewSnippets#MsgBoxShowAndResultCODEBEHIND1](~/samples/snippets/csharp/VS_Snippets_Wpf/DialogBoxesOverviewSnippets/CSharp/Window1.xaml.cs#msgboxshowandresultcodebehind1)]
   
  
 Дополнительные сведения об использовании окон сообщений см. в разделе <xref:System.Windows.MessageBox>, [пример MessageBox](https://go.microsoft.com/fwlink/?LinkID=160023), и [пример диалогового окна](https://go.microsoft.com/fwlink/?LinkID=159984).  
  
 Несмотря на то что <xref:System.Windows.MessageBox> может предложить в простое диалоговое окно пользовательском интерфейсе, преимущество использования <xref:System.Windows.MessageBox> является это единственный тип окна, который может отображать приложения, работающие в песочнице с частичным доверием (см. в разделе [безопасности](../security-wpf.md)), такие как XAML-приложения браузера (XBAP).  
  
 Большинство диалоговых окон отображают и собирают более сложные данные, чем результат окна сообщения, в том числе текст, выбранные варианты (флажки), взаимоисключающий выбор (переключатели) и списки выбора (списки, поля со списком, поля с раскрывающимся списком). Для этого Windows Presentation Foundation (WPF) предоставляет несколько общих диалоговых окон и позволяет создавать пользовательские диалоговые окна, несмотря на то, что их использование возможно только для приложений, выполняемый с полным доверием.  
  
<a name="Common_Dialogs"></a>   
## <a name="common-dialog-boxes"></a>Общие диалоговые окна  
 Windows реализует различные, многократно используемые диалоговые окна, которые являются общими для всех приложений, включая диалоговые окна для открытия, сохранения файлов и печати. Поскольку эти диалоговые окна реализованы операционной системой, они могут совместно использоваться всеми приложениями, работающими в операционной системе, что помогает поддерживать единообразие пользовательского интерфейса; если пользователи знакомы с диалоговым окном, предоставляемым операционной системой в одном приложении, им не нужно учиться пользоваться этим диалоговым окном в других приложениях. Поскольку эти диалоговые доступны для всех приложений и обеспечивают согласованный пользовательский интерфейс, они называются *окон*.  
  
 Windows Presentation Foundation (WPF) инкапсулирует открытый файл, сохраните файл и печать общих диалоговых окон и предоставляет их как управляемые классы для использования в автономных приложениях. В этом разделе приводится краткий обзор каждого типа диалоговых окон.  
  
<a name="Open_File_Dialog"></a>   
### <a name="open-file-dialog"></a>Диалоговое окно открытия файлов  
 Диалоговое окно открытия файлов, показанное на следующем рисунке, используется функциональностью открытия файла для получения имени открываемого файла.  
  
 ![Откройте диалоговое окно с указанием места, чтобы получить файл.](./media/dialog-boxes-overview/open-file-dialog-box.png)  
  
 Общее диалоговое окно открытия файла реализуется как <xref:Microsoft.Win32.OpenFileDialog> класса, который расположен в <xref:Microsoft.Win32> пространства имен. Следующий код показывает, как создавать, настраивать и отображать такое окно, а также как обрабатывать результат.  
  
 [!code-csharp[DialogBoxesOverviewSnippets#OpenFileDialogBoxCODEBEHIND](~/samples/snippets/csharp/VS_Snippets_Wpf/DialogBoxesOverviewSnippets/CSharp/Window1.xaml.cs#openfiledialogboxcodebehind)]
   
  
 Дополнительные сведения о диалоговом окне открытия файла, см. в разделе <xref:Microsoft.Win32.OpenFileDialog?displayProperty=nameWithType>.  
  
> [!NOTE]
>  <xref:Microsoft.Win32.OpenFileDialog> может использоваться для безопасного извлечения имен файлов приложениями, выполняющимися с частичным доверием (см. в разделе [безопасности](../security-wpf.md)).  
  
<a name="Save_File_Dialog"></a>   
### <a name="save-file-dialog-box"></a>Диалоговое окно сохранения файлов  
 Диалоговое окно сохранения файлов, показанное на следующем рисунке, используется функциональностью сохранения файла для получения имени сохраняемого файла.  
  
 ![Сохранить как диалоговое окно расположение для сохранения файла.](./media/dialog-boxes-overview/save-file-dialog-box.png)  
  
 Общее диалоговое окно сохранения файла реализуется как <xref:Microsoft.Win32.SaveFileDialog> класса и находится в <xref:Microsoft.Win32> пространства имен. Следующий код показывает, как создавать, настраивать и отображать такое окно, а также как обрабатывать результат.  
  
 [!code-csharp[DialogBoxesOverviewSnippets#SaveFileDialogBoxCODEBEHIND](~/samples/snippets/csharp/VS_Snippets_Wpf/DialogBoxesOverviewSnippets/CSharp/Window1.xaml.cs#savefiledialogboxcodebehind)]
   
  
 Дополнительные сведения о сохранения диалоговое окно файла, см. в разделе <xref:Microsoft.Win32.SaveFileDialog?displayProperty=nameWithType>.  
  
<a name="Print_Dialog"></a>   
### <a name="print-dialog-box"></a>Диалоговое окно печати  
 Диалоговое окно печати, показанное на следующем рисунке, используется функциональными возможностями печати для выбора и настройки принтера, на котором пользователь хочет печатать данные.  
  
 ![Снимок экрана: диалоговое окно печати.](./media/dialog-boxes-overview/print-data-dialog-box.png)  
  
 Общее диалоговое окно печати реализуется как <xref:System.Windows.Controls.PrintDialog> класса и находится в <xref:System.Windows.Controls> пространства имен. Следующий код показывает, как создавать, настраивать и отображать такое окно.  
  
 [!code-csharp[DialogBoxesOverviewSnippets#PrintDialogBoxCODEBEHIND](~/samples/snippets/csharp/VS_Snippets_Wpf/DialogBoxesOverviewSnippets/CSharp/Window1.xaml.cs#printdialogboxcodebehind)]
   
  
 Дополнительные сведения о диалоговом окне печати см. в разделе <xref:System.Windows.Controls.PrintDialog?displayProperty=nameWithType>. Подробное описание печати в WPF, см. в разделе [Обзор печати](../advanced/printing-overview.md).  
  
<a name="Custom_Dialog_Boxes"></a>   
## <a name="custom-dialog-boxes"></a>Пользовательские диалоговые окна  
 Хотя общие диалоговые окна полезны и должны использоваться, когда это возможно, они не поддерживают требований диалоговых окон отдельного домена. В этих случаях необходимо создавать собственные диалоговые окна. Как мы увидим, диалоговое окно является окном со специальным поведением. <xref:System.Windows.Window> Это поведение реализуется и, следовательно, использовании <xref:System.Windows.Window> для создания пользовательских модальных и немодальных диалоговых окон.  
  
<a name="Creating_a_Modal_Custom_Dialog_Box"></a>   
### <a name="creating-a-modal-custom-dialog-box"></a>Создание модального пользовательского диалогового окна  
 В этом разделе показано, как использовать <xref:System.Windows.Window> создать реализацию поле типичное модальное диалоговое окно, с помощью `Margins` диалоговое окно, в качестве примера (см. в разделе [пример диалогового окна](https://go.microsoft.com/fwlink/?LinkID=159984)). `Margins` На следующем рисунке показано диалоговое окно.  
  
 ![Диалоговое окно поля с полями для определения левое поле, верхнее поле, правое и нижнее поле.](./media/dialog-boxes-overview/margin-size-dialog-box.png)  
  
#### <a name="configuring-a-modal-dialog-box"></a>Настройка модального диалогового окна  
 Пользовательский интерфейс для типичного диалогового окна включает следующее.  
  
-   Различные элементы управления, которые необходимы для сбора нужных данных.  
  
-   Отображение **ОК** кнопки, что пользователи, щелкните, чтобы закрыть диалоговое окно возврата в функцию и продолжить обработку.  
  
-   Отображение **отменить** кнопки, закройте диалоговое окно и остановить дальнейшую обработку функции.  
  
-   Отображение **закрыть** кнопки в заголовке окна.  
  
-   Отображение значка.  
  
-   Отображение **свернуть**, **развернуть**, и **восстановить** кнопки.  
  
-   Отображение **системы** меню, чтобы свести к минимуму, максимально увеличить, восстановление и закрыть диалоговое окно.  
  
-   Открытие выше и в центре окна, которое открывает диалоговое окно.  
  
-   Диалоговые окна должны быть регулируемого размера, где это возможно, и чтобы предотвратить появление окна слишком малого размера, а также предоставить пользователю удобный размер по умолчанию, необходимо установить минимальные размеры окна и размеры по умолчанию.  
  
-   Нажатие клавиши ESC следует настроить как сочетание клавиш, которое вызывает **отменить** нажатие кнопки. Это достигается путем установки <xref:System.Windows.Controls.Button.IsCancel%2A> свойство **отменить** кнопки `true`.  
  
-   Нажатие клавиши ВВОД (или RETURN) следует настроить как сочетание клавиш, которое вызывает **ОК** нажатие кнопки. Это достигается путем установки <xref:System.Windows.Controls.Button.IsDefault%2A> свойство **ОК** кнопку `true`.  
  
 Следующий код демонстрирует такую конфигурацию.  
  
 [!code-xaml[DialogBoxSample#MarginsDialogBoxMainBitsMARKUP1](~/samples/snippets/csharp/VS_Snippets_Wpf/DialogBoxSample/CSharp/MarginsDialogBox.xaml#marginsdialogboxmainbitsmarkup1)]  
[!code-xaml[DialogBoxSample#MarginsDialogBoxMainBitsMARKUP2](~/samples/snippets/csharp/VS_Snippets_Wpf/DialogBoxSample/CSharp/MarginsDialogBox.xaml#marginsdialogboxmainbitsmarkup2)]  
  
 [!code-csharp[DialogBoxSample#MarginsDialogBoxMainBitsCODEBEHIND1](~/samples/snippets/csharp/VS_Snippets_Wpf/DialogBoxSample/CSharp/MarginsDialogBox.xaml.cs#marginsdialogboxmainbitscodebehind1)]
   
[!code-csharp[DialogBoxSample#MarginsDialogBoxMainBitsCODEBEHIND2](~/samples/snippets/csharp/VS_Snippets_Wpf/DialogBoxSample/CSharp/MarginsDialogBox.xaml.cs#marginsdialogboxmainbitscodebehind2)]
  
  
 Пользовательский интерфейс для диалогового окна также распространяется в строку меню окна, открывающего диалоговое окно. Если пункт меню вызывает функцию, которая перед продолжением выполнения требует взаимодействия с пользователем посредством диалогового окна, то в названии этого пункта меню будет многоточие в заголовке, как показано ниже.  
  
 [!code-xaml[DialogBoxSample#MainWindowMarginsDialogBoxMenuItemMARKUP1](~/samples/snippets/csharp/VS_Snippets_Wpf/DialogBoxSample/CSharp/MainWindow.xaml#mainwindowmarginsdialogboxmenuitemmarkup1)]  
[!code-xaml[DialogBoxSample#MainWindowMarginsDialogBoxMenuItemMARKUP2](~/samples/snippets/csharp/VS_Snippets_Wpf/DialogBoxSample/CSharp/MainWindow.xaml#mainwindowmarginsdialogboxmenuitemmarkup2)]  
  
 Если пункт меню вызывает функцию, которая отображает диалоговое окно, не требующее взаимодействия с пользователем, например диалоговое окно "О программе", многоточие не требуется.  
  
#### <a name="opening-a-modal-dialog-box"></a>Открытие модального диалогового окна  
 Диалоговое окно обычно отображается в результате выбора пользователем пункта меню для выполнения доменной функции, такой как установка полей документа в текстовом процессоре. Отображение диалогового окна похоже на отображение обычного окна, хотя требуется дополнительная настройка для диалогового окна. Весь процесс создания, настройки и открытия диалогового окна показан в следующем коде.  
  
 [!code-csharp[DialogBoxSample#OpenMarginsDialogCODEBEHIND1](~/samples/snippets/csharp/VS_Snippets_Wpf/DialogBoxSample/CSharp/MainWindow.xaml.cs#openmarginsdialogcodebehind1)]
   
[!code-csharp[DialogBoxSample#OpenMarginsDialogCODEBEHIND2](~/samples/snippets/csharp/VS_Snippets_Wpf/DialogBoxSample/CSharp/MainWindow.xaml.cs#openmarginsdialogcodebehind2)]
  
[!code-csharp[DialogBoxSample#OpenMarginsDialogCODEBEHIND3](~/samples/snippets/csharp/VS_Snippets_Wpf/DialogBoxSample/CSharp/MainWindow.xaml.cs#openmarginsdialogcodebehind3)]
  
[!code-csharp[DialogBoxSample#OpenMarginsDialogCODEBEHIND4](~/samples/snippets/csharp/VS_Snippets_Wpf/DialogBoxSample/CSharp/MainWindow.xaml.cs#openmarginsdialogcodebehind4)]
  
  
 Здесь код передает в диалоговое окно сведения по умолчанию (о текущих полях). Он также задает <xref:System.Windows.Window.Owner%2A?displayProperty=nameWithType> свойство со ссылкой на окно, которое отображает диалоговое окно. Как правило, следует всегда устанавливать владельца для диалогового окна, чтобы задать поведения, связанные с состоянием окна, которые являются общими для всех диалоговых окнах (см. в разделе [Общие сведения о Windows WPF](wpf-windows-overview.md) Дополнительные сведения).  
  
> [!NOTE]
>  Необходимо указать владельца для поддержки [!INCLUDE[TLA#tla_ui](../../../../includes/tlasharptla-ui-md.md)] автоматизации для диалоговых окон (см. в разделе [обзор автоматизации пользовательского интерфейса](../../ui-automation/ui-automation-overview.md)).  
  
 После настройки диалоговое окно, оно отображается как модальное путем вызова <xref:System.Windows.Window.ShowDialog%2A> метод.  
  
#### <a name="validating-user-provided-data"></a>Проверка пользовательских данных  
 Если открывается диалоговое окно и пользователь предоставляет требуемые данные, диалоговое окно отвечает за проверку допустимости предоставленных данных по следующим причинам.  
  
-   С точки зрения безопасности следует проверять все входные данные.  
  
-   С точки зрения конкретного домена проверка данных предотвращает обработку в коде ошибочных данных, которые могут вызывать исключения.  
  
-   С точки зрения взаимодействия с пользователем диалоговое окно может помочь пользователям, показывая, какие введенные ими данные являются недопустимыми.  
  
-   С точки зрения производительности проверка данных в многоуровневом приложении может уменьшить количество циклов обработки между уровнями клиента и приложения, особенно в том случае, если в приложение входят веб-службы или серверные базы данных.  
  
 Чтобы проверить связанный элемент управления в WPF, необходимо определить правило проверки и связать его с привязкой. Правило проверки — пользовательский класс, производный от <xref:System.Windows.Controls.ValidationRule>. В следующем примере показано правило проверки, `MarginValidationRule`, которое проверяет, что связанным значением является <xref:System.Double> и находится в пределах указанного диапазона.  
  
 [!code-csharp[DialogBoxSample#MarginValidationRuleCODE](~/samples/snippets/csharp/VS_Snippets_Wpf/DialogBoxSample/CSharp/MarginValidationRule.cs#marginvalidationrulecode)]
   
  
 В этом коде логика правила проверки реализована путем переопределения <xref:System.Windows.Controls.ValidationRule.Validate%2A> метод, который проверяет данные и возвращает соответствующий <xref:System.Windows.Controls.ValidationResult>.  
  
 Чтобы сопоставить это правило проверки со связанным элементом управления, используется следующая разметка.  
  
 [!code-xaml[DialogBoxSample#MarginsValidationMARKUP1](~/samples/snippets/csharp/VS_Snippets_Wpf/DialogBoxSample/CSharp/MarginsDialogBox.xaml#marginsvalidationmarkup1)]  
[!code-xaml[DialogBoxSample#MarginsValidationMARKUP2](~/samples/snippets/csharp/VS_Snippets_Wpf/DialogBoxSample/CSharp/MarginsDialogBox.xaml#marginsvalidationmarkup2)]  
[!code-xaml[DialogBoxSample#MarginsValidationMARKUP3](~/samples/snippets/csharp/VS_Snippets_Wpf/DialogBoxSample/CSharp/MarginsDialogBox.xaml#marginsvalidationmarkup3)]  
  
 После связывания, правила проверки WPF автоматически применять его при вводе данных в связанном элементе управления. Если элемент управления содержит недопустимые данные WPF отобразит красные границы вокруг недопустимого элемента, как показано на рисунке ниже.  
  
 ![Диалоговое окно поля с красной границей вокруг значения недопустимое значение левого поля.](./media/dialog-boxes-overview/invalid-left-margin-dialog.png)  
  
 WPF не ограничивает пользователя из недопустимого элемента управления, пока не будут введены допустимые данные. Это правильное поведение диалогового окна; пользователь должен иметь возможность свободно перемещаться по элементам управления в диалоговом окне, независимо от того, правильны ли введенные данные. Тем не менее, это означает, что пользователь может ввести недопустимые данные и нажмите клавишу **ОК** кнопки. По этой причине код также должен проверить все элементы управления в диалоговом окне окно при **ОК** нажатии путем обработки <xref:System.Windows.Controls.Primitives.ButtonBase.Click> событий.  
  
 [!code-csharp[DialogBoxSample#MarginsDialogBoxValidationCODEBEHIND1](~/samples/snippets/csharp/VS_Snippets_Wpf/DialogBoxSample/CSharp/MarginsDialogBox.xaml.cs#marginsdialogboxvalidationcodebehind1)]
   
[!code-csharp[DialogBoxSample#MarginsDialogBoxValidationCODEBEHIND2](~/samples/snippets/csharp/VS_Snippets_Wpf/DialogBoxSample/CSharp/MarginsDialogBox.xaml.cs#marginsdialogboxvalidationcodebehind2)]
  
[!code-csharp[DialogBoxSample#MarginsDialogBoxValidationCODEBEHIND3](~/samples/snippets/csharp/VS_Snippets_Wpf/DialogBoxSample/CSharp/MarginsDialogBox.xaml.cs#marginsdialogboxvalidationcodebehind3)]
  
  
 Этот код перечисляет все объекты зависимости в окне, и, если какой-либо недопустимые (возвращенная <xref:System.Windows.Controls.Validation.GetHasError%2A>, недопустимый элемент управления получает фокус, `IsValid` возвращает метод `false`, и окно считается недопустимым.  
  
 Если диалоговое окно является допустимым, оно может быть безопасно закрыто и выполнен возврат. В рамках процесса возврата необходимо возвращать результат в вызывающую функцию.  
  
#### <a name="setting-the-modal-dialog-result"></a>Установка результата модального диалогового окна  
 Открытие диалогового окна при помощи <xref:System.Windows.Window.ShowDialog%2A> — это по сути, аналогично вызову метода: код, открывающий диалоговое окно с помощью <xref:System.Windows.Window.ShowDialog%2A> ожидает <xref:System.Windows.Window.ShowDialog%2A> возвращает. Когда <xref:System.Windows.Window.ShowDialog%2A> возвращает, код, который его вызвал, должен решить, будет ли продолжить или прекратить обработку, в зависимости от нажатой клавише **ОК** кнопку или **отменить** кнопки. Для облегчения принятия этого решения, диалоговое окно должно возвращать Выбор пользователя в виде <xref:System.Boolean> значение, возвращаемое из <xref:System.Windows.Window.ShowDialog%2A> метод.  
  
 Когда **ОК** кнопки, <xref:System.Windows.Window.ShowDialog%2A> должен возвращать `true`. Это достигается путем установки <xref:System.Windows.Window.DialogResult%2A> свойство диалога окно при **ОК** кнопки.  
  
 [!code-csharp[DialogBoxSample#MarginsDialogBoxOKResultSetCODEBEHIND1](~/samples/snippets/csharp/VS_Snippets_Wpf/DialogBoxSample/CSharp/MarginsDialogBox.xaml.cs#marginsdialogboxokresultsetcodebehind1)]
   
[!code-csharp[DialogBoxSample#MarginsDialogBoxOKResultSetCODEBEHIND2](~/samples/snippets/csharp/VS_Snippets_Wpf/DialogBoxSample/CSharp/MarginsDialogBox.xaml.cs#marginsdialogboxokresultsetcodebehind2)]
  
[!code-csharp[DialogBoxSample#MarginsDialogBoxOKResultSetCODEBEHIND3](~/samples/snippets/csharp/VS_Snippets_Wpf/DialogBoxSample/CSharp/MarginsDialogBox.xaml.cs#marginsdialogboxokresultsetcodebehind3)]
  
[!code-csharp[DialogBoxSample#MarginsDialogBoxOKResultSetCODEBEHIND4](~/samples/snippets/csharp/VS_Snippets_Wpf/DialogBoxSample/CSharp/MarginsDialogBox.xaml.cs#marginsdialogboxokresultsetcodebehind4)]
  
  
 Обратите внимание, что <xref:System.Windows.Window.DialogResult%2A> также вызывает автоматическое закрытие окна, что устраняет необходимость явно вызывать <xref:System.Windows.Window.Close%2A>.  
  
 Когда **отменить** кнопки, <xref:System.Windows.Window.ShowDialog%2A> должен возвращать `false`, что также требует настройки <xref:System.Windows.Window.DialogResult%2A> свойство.  
  
 [!code-csharp[DialogBoxSample#MarginsDialogBoxCancelResultSetCODEBEHIND1](~/samples/snippets/csharp/VS_Snippets_Wpf/DialogBoxSample/CSharp/MarginsDialogBox.xaml.cs#marginsdialogboxcancelresultsetcodebehind1)]
   
[!code-csharp[DialogBoxSample#MarginsDialogBoxCancelResultSetCODEBEHIND2](~/samples/snippets/csharp/VS_Snippets_Wpf/DialogBoxSample/CSharp/MarginsDialogBox.xaml.cs#marginsdialogboxcancelresultsetcodebehind2)]
  
[!code-csharp[DialogBoxSample#MarginsDialogBoxCancelResultSetCODEBEHIND3](~/samples/snippets/csharp/VS_Snippets_Wpf/DialogBoxSample/CSharp/MarginsDialogBox.xaml.cs#marginsdialogboxcancelresultsetcodebehind3)]
  
  
 Когда <xref:System.Windows.Controls.Button.IsCancel%2A> свойству `true` и пользователь нажимает кнопку **отменить** кнопки или клавиши ESC, <xref:System.Windows.Window.DialogResult%2A> автоматически присваивается `false`. Следующая разметка действует так же, как предыдущий код, без необходимости обрабатывать <xref:System.Windows.Controls.Primitives.ButtonBase.Click> событий.  
  
 [!code-xaml[DialogBoxSample#MarginsDialogDefaultCancelMARKUP](~/samples/snippets/csharp/VS_Snippets_Wpf/DialogBoxSample/CSharp/MarginsDialogBox.xaml#marginsdialogdefaultcancelmarkup)]  
  
 Диалоговое окно автоматически возвращает `false` когда пользователь нажимает **закрыть** кнопки в строке заголовка или выбирает **закрыть** элемент меню из **системы** меню.  
  
#### <a name="processing-data-returned-from-a-modal-dialog-box"></a>Обработка данных, возвращенных из модального диалогового окна  
 Когда <xref:System.Windows.Window.DialogResult%2A> устанавливается диалоговым окном, функция, которая его открыла можно получить результат диалогового окна, проверив <xref:System.Windows.Window.DialogResult%2A> свойство при <xref:System.Windows.Window.ShowDialog%2A> возвращает.  
  
 [!code-csharp[DialogBoxSample#OpenMarginsDialogProcessReturnCODEBEHIND1](~/samples/snippets/csharp/VS_Snippets_Wpf/DialogBoxSample/CSharp/MainWindow.xaml.cs#openmarginsdialogprocessreturncodebehind1)]
   
[!code-csharp[DialogBoxSample#OpenMarginsDialogProcessReturnCODEBEHIND2](~/samples/snippets/csharp/VS_Snippets_Wpf/DialogBoxSample/CSharp/MainWindow.xaml.cs#openmarginsdialogprocessreturncodebehind2)]
  
[!code-csharp[DialogBoxSample#OpenMarginsDialogProcessReturnCODEBEHIND3](~/samples/snippets/csharp/VS_Snippets_Wpf/DialogBoxSample/CSharp/MainWindow.xaml.cs#openmarginsdialogprocessreturncodebehind3)]
  
[!code-csharp[DialogBoxSample#OpenMarginsDialogProcessReturnCODEBEHIND4](~/samples/snippets/csharp/VS_Snippets_Wpf/DialogBoxSample/CSharp/MainWindow.xaml.cs#openmarginsdialogprocessreturncodebehind4)]
  
  
 Если результатом диалогового окна является `true`, функция использует его в качестве подсказки для получения и обработки данных, предоставленных пользователем.  
  
> [!NOTE]
>  После <xref:System.Windows.Window.ShowDialog%2A> вернулся, диалоговое окно нельзя открыть повторно. Вместо этого придется создать новый экземпляр.  
  
 Если результатом диалогового окна является `false`, функция должна соответствующим образом завершить обработку.  
  
<a name="Creating_a_Modeless_Custom_Dialog_Box"></a>   
### <a name="creating-a-modeless-custom-dialog-box"></a>Создание немодального пользовательского диалогового окна  
 Немодальное диалоговое окно, например диалоговое окно поиска, показанное на следующем рисунке, в основном имеет такой же внешний вид, как и модальное диалоговое окно.  
  
 ![Снимок экрана: диалоговое окно поиска.](./media/dialog-boxes-overview/find-modeless-dialog-box.png)  
  
 Однако поведение несколько отличается, как показано в следующих разделах.  
  
#### <a name="opening-a-modeless-dialog-box"></a>Открытие немодального диалогового окна  
 Немодальное диалоговое окно открывается путем вызова <xref:System.Windows.Window.Show%2A> метод.  
  
 [!code-xaml[DialogBoxSample#OpenFindDialogMARKUP1](~/samples/snippets/csharp/VS_Snippets_Wpf/DialogBoxSample/CSharp/MainWindow.xaml#openfinddialogmarkup1)]  
  
 [!code-csharp[DialogBoxSample#OpenFindDialogCODEBEHIND1](~/samples/snippets/csharp/VS_Snippets_Wpf/DialogBoxSample/CSharp/MainWindow.xaml.cs#openfinddialogcodebehind1)]
   
[!code-csharp[DialogBoxSample#OpenFindDialogCODEBEHIND2](~/samples/snippets/csharp/VS_Snippets_Wpf/DialogBoxSample/CSharp/MainWindow.xaml.cs#openfinddialogcodebehind2)]
  
[!code-csharp[DialogBoxSample#OpenFindDialogCODEBEHIND3](~/samples/snippets/csharp/VS_Snippets_Wpf/DialogBoxSample/CSharp/MainWindow.xaml.cs#openfinddialogcodebehind3)]
  
  
 В отличие от <xref:System.Windows.Window.ShowDialog%2A>, <xref:System.Windows.Window.Show%2A> возвращается немедленно. Следовательно, вызывающее окно не может определить, когда немодальное диалоговое окно закрывается, и поэтому не знает, когда следует проверить результат диалогового окна или получить данные из диалогового окна для дальнейшей обработки. Поэтому диалоговому окну необходимо создать альтернативный способ возврата данных в вызывающее окно для обработки.  
  
#### <a name="processing-data-returned-from-a-modeless-dialog-box"></a>Обработка данных, возвращенных из немодального диалогового окна  
 В этом примере `FindDialogBox` могут возвращать один или несколько результатов в главное окно, в зависимости от искомого текста, без определенного интервала поиска. Как и в случае с модальным диалоговым окном, немодальное диалоговое окно может возвращать результаты с помощью свойств. Однако окну, которому принадлежит данное диалоговое окно, нужно знать, когда следует проверять эти свойства. Один из способов сделать это — реализовать для диалогового окна событие, которое возникает всякий раз, когда текст найден. `FindDialogBox` реализует `TextFoundEvent` для этой цели, для чего сначала требуется делегат.  
  
 [!code-csharp[DialogBoxSample#TextFoundEventHandlerCODE](~/samples/snippets/csharp/VS_Snippets_Wpf/DialogBoxSample/CSharp/TextFoundEventHandler.cs#textfoundeventhandlercode)]
   
  
 С помощью `TextFoundEventHandler` делегировать, `FindDialogBox` реализует `TextFoundEvent`.  
  
 [!code-csharp[DialogBoxSample#TextFoundEventCODEBEHIND1](~/samples/snippets/csharp/VS_Snippets_Wpf/DialogBoxSample/CSharp/FindDialogBox.xaml.cs#textfoundeventcodebehind1)]
   
[!code-csharp[DialogBoxSample#TextFoundEventCODEBEHIND2](~/samples/snippets/csharp/VS_Snippets_Wpf/DialogBoxSample/CSharp/FindDialogBox.xaml.cs#textfoundeventcodebehind2)]
  
  
 Следовательно `Find` может создать событие, когда найден результат поиска.  
  
 [!code-csharp[DialogBoxSample#TextFoundEventRaiseCODEBEHIND1](~/samples/snippets/csharp/VS_Snippets_Wpf/DialogBoxSample/CSharp/FindDialogBox.xaml.cs#textfoundeventraisecodebehind1)]
   
[!code-csharp[DialogBoxSample#TextFoundEventRaiseCODEBEHIND2](~/samples/snippets/csharp/VS_Snippets_Wpf/DialogBoxSample/CSharp/FindDialogBox.xaml.cs#textfoundeventraisecodebehind2)]
  
[!code-csharp[DialogBoxSample#TextFoundEventRaiseCODEBEHIND3](~/samples/snippets/csharp/VS_Snippets_Wpf/DialogBoxSample/CSharp/FindDialogBox.xaml.cs#textfoundeventraisecodebehind3)]
  
[!code-csharp[DialogBoxSample#TextFoundEventRaiseCODEBEHIND4](~/samples/snippets/csharp/VS_Snippets_Wpf/DialogBoxSample/CSharp/FindDialogBox.xaml.cs#textfoundeventraisecodebehind4)]
  
[!code-csharp[DialogBoxSample#TextFoundEventRaiseCODEBEHIND5](~/samples/snippets/csharp/VS_Snippets_Wpf/DialogBoxSample/CSharp/FindDialogBox.xaml.cs#textfoundeventraisecodebehind5)]
  
  
 Затем окну-владельцу нужно зарегистрировать и обработать это событие.  
  
 [!code-csharp[DialogBoxSample#OpenFindDialogResultCODEBEHIND1](~/samples/snippets/csharp/VS_Snippets_Wpf/DialogBoxSample/CSharp/MainWindow.xaml.cs#openfinddialogresultcodebehind1)]
   
[!code-csharp[DialogBoxSample#OpenFindDialogResultCODEBEHIND2](~/samples/snippets/csharp/VS_Snippets_Wpf/DialogBoxSample/CSharp/MainWindow.xaml.cs#openfinddialogresultcodebehind2)]
  
  
#### <a name="closing-a-modeless-dialog-box"></a>Закрытие немодального диалогового окна  
 Так как <xref:System.Windows.Window.DialogResult%2A> не требуется устанавливать, немодальное диалоговое окно можно закрыть с помощью системы предоставляют механизмы, включая следующие:  
  
-   Щелкнув **закрыть** кнопки в заголовке окна.  
  
-   Нажатие клавиш ALT+F4.  
  
-   Выбор **закрыть** из **системы** меню.  
  
 Кроме того, код может вызвать <xref:System.Windows.Window.Close%2A> при **закрыть** кнопки.  
  
 [!code-csharp[DialogBoxSample#FindDialogCloseCODEBEHIND1](~/samples/snippets/csharp/VS_Snippets_Wpf/DialogBoxSample/CSharp/FindDialogBox.xaml.cs#finddialogclosecodebehind1)]
   
[!code-csharp[DialogBoxSample#FindDialogCloseCODEBEHIND2](~/samples/snippets/csharp/VS_Snippets_Wpf/DialogBoxSample/CSharp/FindDialogBox.xaml.cs#finddialogclosecodebehind2)]
  
  
## <a name="see-also"></a>См. также

- [Общие сведения о контекстном меню](../controls/popup-overview.md)
- [Пример диалогового окна](https://go.microsoft.com/fwlink/?LinkID=159984)
- [Пример элемента управления ColorPicker пользовательской](https://go.microsoft.com/fwlink/?LinkID=159977)
