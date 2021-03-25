---
title: Общие сведения о TextBox
ms.date: 03/30/2017
helpviewer_keywords:
- controls [WPF], TextBox
- TextBox control [WPF], about TextBox control
ms.assetid: 1ba6dc5b-11a7-4247-9213-36c6729ee35f
ms.openlocfilehash: 577a12a0c04e5e3bfbfecb2c45263b684f0ffc17
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59162650"
---
# <a name="textbox-overview"></a>Общие сведения о TextBox
<xref:System.Windows.Controls.TextBox> Класс позволяет отобразить или отредактировать неформатированный текст. Обычно используются <xref:System.Windows.Controls.TextBox> редактирование неформатированного текста в форме. Например, форма запроса имени пользователя, номера телефона и т.д может использовать <xref:System.Windows.Controls.TextBox> элементы управления для ввода текста. В данном разделе представлены <xref:System.Windows.Controls.TextBox> класса и приводятся примеры его использования в оба XAML и C#.  

<a name="textbox_or_richtextbox"></a>   
## <a name="textbox-or-richtextbox"></a>TextBox или RichTextBox?  
 Оба <xref:System.Windows.Controls.TextBox> и <xref:System.Windows.Controls.RichTextBox> позволяют пользователям вводить текст, но эти два элемента управления используются для разных сценариев. Объект <xref:System.Windows.Controls.TextBox> требует меньше системных ресурсов то <xref:System.Windows.Controls.RichTextBox> , это идеальный вариант, если необходимо изменить только обычный текст (т. е. для использования в форме). Объект <xref:System.Windows.Controls.RichTextBox> подходит лучше, когда это необходимо для пользователю необходимо отредактировать форматированный текст, изображения, таблицы или другие поддерживаемые содержимого. Например, редактирование документа, статьи или блога, для которых требуется форматирование, изображений, и т.д., лучше всего выполнять с помощью <xref:System.Windows.Controls.RichTextBox>. В следующей таблице перечислены основные возможности <xref:System.Windows.Controls.TextBox> и <xref:System.Windows.Controls.TextBox>.  
  
|Элемент управления|Проверка орфографии в режиме реального времени|Контекстное меню|Форматирование команд как <xref:System.Windows.Documents.EditingCommands.ToggleBold%2A> (CTRL + B)|<xref:System.Windows.Documents.FlowDocument> содержимого, например изображения, абзацы, таблицы, и т.д.|  
|-------------|------------------------------|------------------|------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|  
|<xref:System.Windows.Controls.TextBox>|Да|Да|Нет|Нет.|  
|<xref:System.Windows.Controls.RichTextBox>|Да|Да|Да (см. раздел [Общие сведения о RichTextBox](richtextbox-overview.md))|Да (см. раздел [Общие сведения о RichTextBox](richtextbox-overview.md))|  
  
> [!NOTE]
>  Несмотря на то что <xref:System.Windows.Controls.TextBox> выполняет команды поддерживает форматирование редактирования, связанные с образом <xref:System.Windows.Documents.EditingCommands.ToggleBold%2A> (CTRL + B), многие основные команды поддерживаются оба элемента управления, таких как <xref:System.Windows.Documents.EditingCommands.MoveToLineEnd%2A>. Дополнительные сведения см. в разделе <xref:System.Windows.Documents.EditingCommands>.  
  
 Возможности, поддерживаемые различными <xref:System.Windows.Controls.TextBox> рассматриваются в следующих разделах. Дополнительные сведения о <xref:System.Windows.Controls.RichTextBox>, см. в разделе [Общие сведения о RichTextBox](richtextbox-overview.md).  
  
### <a name="real-time-spellchecking"></a>Проверка орфографии в режиме реального времени  
 Вы можете включить в режиме реального времени проверка орфографии в <xref:System.Windows.Controls.TextBox> или <xref:System.Windows.Controls.RichTextBox>. При включенной проверке орфографии все слова с ошибками подчеркиваются красной линией (см. рисунок ниже).  
  
 ![Текстовое поле с проверкой орфо&#45;графии](./media/editing-textbox-with-spellchecking.png "Editing_TextBox_with_Spellchecking")  
  
 Чтобы научиться включать проверку правописания, см. раздел [Включение проверки орфографии в элементе управления редактирования текста](how-to-enable-spell-checking-in-a-text-editing-control.md).  
  
### <a name="context-menu"></a>Контекстное меню  
 По умолчанию оба <xref:System.Windows.Controls.TextBox> и <xref:System.Windows.Controls.RichTextBox> имеют контекстное меню, которое появляется, когда пользователь щелкает правой кнопкой мыши внутри элемента управления. Контекстное меню дает пользователю возможность вырезания, копирования и вставки (см. рисунок ниже).  
  
 ![TextBox с контекстным меню](./media/editing-textbox-with-context-menu.png "Editing_TextBox_with_Context_Menu")  
  
 Можно создать собственное пользовательское контекстное меню, чтобы переопределить поведение по умолчанию. Дополнительные сведения см. в разделе [Использование пользовательского контекстного меню с элементом TextBox](how-to-use-a-custom-context-menu-with-a-textbox.md).  
  
<a name="creating_textboxes"></a>   
## <a name="creating-textboxes"></a>Создание элементов TextBox  
 Объект <xref:System.Windows.Controls.TextBox> может находиться на одной строке, высоты или нескольких строк. Одна строка <xref:System.Windows.Controls.TextBox> лучше всего подходит для ввода небольшого объема обычного текста (т. е. "Имя", "Номер телефона" и т.д. в форме). Приведенный ниже показано, как создать одну строку <xref:System.Windows.Controls.TextBox>.  
  
 [!code-xaml[TextBoxMiscSnippets_snip#BasicTextBoxExampleWholePage](~/samples/snippets/csharp/VS_Snippets_Wpf/TextBoxMiscSnippets_snip/csharp/basictextboxexample.xaml#basictextboxexamplewholepage)]  
  
 Вы также можете создать <xref:System.Windows.Controls.TextBox> , позволяющий пользователю вводить несколько строк текста. Например, если форма запрашивает биографические сведения пользователя, то целесообразно использовать <xref:System.Windows.Controls.TextBox> , поддерживающий несколько строк текста. В следующем примере показано, как использовать XAML для определения <xref:System.Windows.Controls.TextBox> элемент управления, который автоматически расширяется, чтобы вместить несколько строк текста.  
  
 [!code-xaml[TextBox_MiscCode#_MultilineTextBoxXAML](~/samples/snippets/csharp/VS_Snippets_Wpf/TextBox_MiscCode/CSharp/Window1.xaml#_multilinetextboxxaml)]  
  
 Установка <xref:System.Windows.Controls.TextBox.TextWrapping%2A> атрибут `Wrap` текст программы-оболочки в новую строку при границе <xref:System.Windows.Controls.TextBox> будет достигнут элемент управления, автоматически расширяя <xref:System.Windows.Controls.TextBox> элемента управления, чтобы появилось место для новой строки, в том случае, при необходимости.  
  
 Установка <xref:System.Windows.Controls.Primitives.TextBoxBase.AcceptsReturn%2A> атрибут `true` приводит к новой строке должен быть вставлен при нажатии клавиши ВВОД, автоматически расширяя <xref:System.Windows.Controls.TextBox> чтобы появилось место для новой строки, в том случае, при необходимости.  
  
 <xref:System.Windows.Controls.Primitives.TextBoxBase.VerticalScrollBarVisibility%2A> Атрибут добавляет полосу прокрутки для <xref:System.Windows.Controls.TextBox>, так что содержимое <xref:System.Windows.Controls.TextBox> может прокручиваться до, если <xref:System.Windows.Controls.TextBox> превышает размеры рамки или окна, который его окружает.  
  
 Дополнительные сведения о различных задачах, связанных с использованием <xref:System.Windows.Controls.TextBox>, см. в разделе [разделы руководства, посвященные](textbox-how-to-topics.md).  
  
<a name="editing_commands"></a>   
## <a name="detect-when-content-changes"></a>Определение изменения содержимого  
 Обычно <xref:System.Windows.Controls.Primitives.TextBoxBase.TextChanged> событие должно использоваться, чтобы определить, когда текст в <xref:System.Windows.Controls.TextBox> или <xref:System.Windows.Controls.RichTextBox> изменяется, а не <xref:System.Windows.UIElement.KeyDown> как можно ожидать. Пример см. в разделе [Определение изменения текста в TextBox](how-to-detect-when-text-in-a-textbox-has-changed.md).  
  
## <a name="see-also"></a>См. также

- [Практические руководства](textbox-how-to-topics.md)
- [Общие сведения о RichTextBox](richtextbox-overview.md)
