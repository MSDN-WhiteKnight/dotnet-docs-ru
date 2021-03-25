---
title: Общие сведения о RichTextBox
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- controls [WPF], RichTextBox
- RichTextBox control [WPF], about RichTextBox control
ms.assetid: c94548b2-c1e9-4b62-b10c-dd8740eb23d8
ms.openlocfilehash: 9aa0d33b3cb2c15ba9c1cb7e7d7be9a3125f66d3
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59162715"
---
# <a name="richtextbox-overview"></a>Общие сведения о RichTextBox
<xref:System.Windows.Controls.RichTextBox> Элемент управления позволяет отображать или изменять Подвижное содержимое, включая абзацы, изображения, таблицы и многое другое. В данном разделе представлены <xref:System.Windows.Controls.TextBox> класса и приводятся примеры его использования в оба XAML и C#.  

<a name="textbox_or_richtextbox"></a>   
## <a name="textbox-or-richtextbox"></a>TextBox или RichTextBox?  
 Оба <xref:System.Windows.Controls.RichTextBox> и <xref:System.Windows.Controls.TextBox> разрешить пользователям изменять текст, однако два элемента управления используются в различных сценариях. Объект <xref:System.Windows.Controls.RichTextBox> подходит лучше, когда это необходимо для пользователю необходимо отредактировать форматированный текст, изображения, таблицы или другое форматированное содержимое. Например, редактирование документа, статьи или блога, для которых требуется форматирование, изображений, и т.д., лучше всего выполнять с помощью <xref:System.Windows.Controls.RichTextBox>. Объект <xref:System.Windows.Controls.TextBox> требует меньше системных ресурсов то <xref:System.Windows.Controls.RichTextBox> и это идеальный вариант, если только обычный текст должен быть изменена (т. е. для использования в формах). См. в разделе [Общие сведения о TextBox](textbox-overview.md) Дополнительные сведения о <xref:System.Windows.Controls.TextBox>. В следующей таблице перечислены основные возможности <xref:System.Windows.Controls.TextBox> и <xref:System.Windows.Controls.RichTextBox>.  
  
|Элемент управления|Проверка орфографии в режиме реального времени|Контекстное меню|Форматирование команд как <xref:System.Windows.Documents.EditingCommands.ToggleBold%2A> (CTRL + B)|<xref:System.Windows.Documents.FlowDocument> содержимого, например изображения, абзацы, таблицы, и т.д.|  
|-------------|------------------------------|------------------|------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|  
|<xref:System.Windows.Controls.TextBox>|Да|Да|Нет|Нет.|  
|<xref:System.Windows.Controls.RichTextBox>|Да|Да|Да|Да|  
  
 **Примечание.** Несмотря на то что <xref:System.Windows.Controls.TextBox> , не поддерживает связанные команды, такие как <xref:System.Windows.Documents.EditingCommands.ToggleBold%2A> (CTRL + B), многие основные команды поддерживаются оба элемента управления, таких как <xref:System.Windows.Documents.EditingCommands.MoveToLineEnd%2A>.  
  
 Функции из приведенной выше таблицы будут подробно рассматриваться далее.  
  
<a name="creating_a_richtextbox"></a>   
## <a name="creating-a-richtextbox"></a>Создание элемента управления RichTextBox  
 В приведенном ниже коде показано, как создать <xref:System.Windows.Controls.RichTextBox> , пользователь может редактировать форматированное содержимое в.  
  
 [!code-xaml[RichTextBoxMiscSnippets_snip#BasicRichTextBoxExampleWholePage](~/samples/snippets/csharp/VS_Snippets_Wpf/RichTextBoxMiscSnippets_snip/CSharp/BasicRichTextBoxExample.xaml#basicrichtextboxexamplewholepage)]  
  
 В частности, изменить содержимое в <xref:System.Windows.Controls.RichTextBox> является подвижным содержимым. Содержимое нефиксированного формата может включать множество типов элементов, в том числе форматированный текст, изображения, списки и таблицы. См. более подробные сведения о потоковых документах в разделе [Общие сведения о потоковых документах](../advanced/flow-document-overview.md). Чтобы иметь Подвижное содержимое <xref:System.Windows.Controls.RichTextBox> узлы <xref:System.Windows.Documents.FlowDocument> объект, который в свою очередь содержит редактируемое содержимое. Для демонстрации подвижного содержимого в <xref:System.Windows.Controls.RichTextBox>, приведенный ниже показано, как создать <xref:System.Windows.Controls.RichTextBox> с абзацем и полужирным текстом.  
  
 [!code-xaml[RichTextBoxMiscSnippets_snip#RichTextBoxWithContentExampleWholePage](~/samples/snippets/csharp/VS_Snippets_Wpf/RichTextBoxMiscSnippets_snip/CSharp/RichTextBoxWithContentExample.xaml#richtextboxwithcontentexamplewholepage)]  
  
 [!code-csharp[RichTextBoxMiscSnippets_procedural_snip#BasicRichTextBoxWithContentCodeOnlyExample](~/samples/snippets/csharp/VS_Snippets_Wpf/RichTextBoxMiscSnippets_procedural_snip/CSharp/BasicRichTextBoxWithContentExample.cs#basicrichtextboxwithcontentcodeonlyexample)]
   
  
 На рисунке ниже показано, как будет выглядеть этот пример.  
  
 ![RichTextBox с содержимым](./media/editing-richtextbox-with-content.png "Editing_RichTextBox_with_Content")  
  
 Элементы, такие как <xref:System.Windows.Documents.Paragraph> и <xref:System.Windows.Documents.Bold> определить, каким образом содержимое внутри <xref:System.Windows.Controls.RichTextBox> отображается. Когда пользователь редактирует <xref:System.Windows.Controls.RichTextBox> содержимого, они изменяют содержимое потока. Дополнительные сведения о возможностях подвижного содержимого и способах работы с ним см. в разделе [Общие сведения о потоковых документах](../advanced/flow-document-overview.md).  
  
 **Примечание.** Содержимое внутри потока <xref:System.Windows.Controls.RichTextBox> работать не так, как в других элементах управления. Например, отсутствуют столбцы в <xref:System.Windows.Controls.RichTextBox> и поэтому не автоматического изменения размеров. Кроме того, встроенные функции, такие как поиск, режим просмотра, навигация по страницам и увеличение, не доступны в <xref:System.Windows.Controls.RichTextBox>.  
  
<a name="realtime_spellechecking"></a>   
## <a name="real-time-spell-checking"></a>Проверка орфографии в режиме реального времени  
 Вы можете включить проверка орфографии в режиме реального времени <xref:System.Windows.Controls.TextBox> или <xref:System.Windows.Controls.RichTextBox>. При включенной проверке орфографии все слова с ошибками подчеркиваются красной линией (см. рисунок ниже).  
  
 ![Текстовое поле с проверкой орфо&#45;графии](./media/editing-textbox-with-spellchecking.png "Editing_TextBox_with_Spellchecking")  
  
 Чтобы научиться включать проверку правописания, см. раздел [Включение проверки орфографии в элементе управления редактирования текста](how-to-enable-spell-checking-in-a-text-editing-control.md).  
  
<a name="context_menu"></a>   
## <a name="context-menu"></a>Контекстное меню  
 По умолчанию оба <xref:System.Windows.Controls.TextBox> и <xref:System.Windows.Controls.RichTextBox> имеют контекстное меню, которое появляется, когда пользователь щелкает правой кнопкой мыши внутри элемента управления. Контекстное меню дает пользователю возможность вырезания, копирования и вставки (см. рисунок ниже).  
  
 ![TextBox с контекстным меню](./media/editing-textbox-with-context-menu.png "Editing_TextBox_with_Context_Menu")  
  
 Можно создать собственное пользовательское контекстное меню, чтобы переопределить меню по умолчанию. Дополнительные сведения см. в разделе [Расположение пользовательского контекстного меню в RichTextBox](how-to-position-a-custom-context-menu-in-a-richtextbox.md).  
  
<a name="detect_when_content_changes"></a>   
## <a name="editing-commands"></a>Команды редактирования  
 Команды редактирования позволяют пользователям форматировать редактируемое содержимое в <xref:System.Windows.Controls.RichTextBox>. Помимо основных команд редактирования, <xref:System.Windows.Controls.RichTextBox> включает команды форматирования, которые <xref:System.Windows.Controls.TextBox> не поддерживает. Например, при редактировании в <xref:System.Windows.Controls.RichTextBox>, пользователь может нажать CTRL + B, чтобы переключить форматирование текста полужирным шрифтом. См. в разделе <xref:System.Windows.Documents.EditingCommands> полный список доступных команд. Помимо использования сочетания клавиш, можно подключать команды к другим элементам управления, таким как кнопки. В следующем примере показано, как создать простую панель инструментов, содержащую кнопки, с помощью которых пользователь может изменять форматирование текста.  
  
 [!code-xaml[RichTextBox_InputPanel_snip#RichTextBoxWithToolBarExampleWholePage](~/samples/snippets/csharp/VS_Snippets_Wpf/RichTextBox_InputPanel_snip/CS/Window1.xaml#richtextboxwithtoolbarexamplewholepage)]  
  
 На следующем рисунке показано, как будет выглядеть этот пример.  
  
 ![RichTextBox с панелью инструментов](./media/editing-richtextbox-with-toobar.gif "Editing_RichTextBox_with_TooBar")  
  
<a name="editing_commands"></a>   
## <a name="detect-when-content-changes"></a>Определение изменения содержимого  
 Обычно <xref:System.Windows.Controls.Primitives.TextBoxBase.TextChanged> событие должно использоваться, чтобы определить, когда текст в <xref:System.Windows.Controls.TextBox> или <xref:System.Windows.Controls.RichTextBox> изменится, то вместо <xref:System.Windows.UIElement.KeyDown> как можно ожидать. Пример см. в разделе [Определение изменения текста в TextBox](how-to-detect-when-text-in-a-textbox-has-changed.md).  
  
<a name="save_load_and_print_richtextbox_content"></a>   
## <a name="save-load-and-print-richtextbox-content"></a>Сохранение, загрузка и печать содержимого RichTextBox  
 В следующем примере показано, как сохранить содержимое <xref:System.Windows.Controls.RichTextBox> в файл, загрузить это содержимое обратно в <xref:System.Windows.Controls.RichTextBox>и напечатать содержимое. Ниже для примера приведена разметка.  
  
 [!code-xaml[RichTextBoxMiscSnippets_snip#SaveLoadPrintRTBExampleWholePage](~/samples/snippets/csharp/VS_Snippets_Wpf/RichTextBoxMiscSnippets_snip/CSharp/SaveLoadPrintRTB.xaml#saveloadprintrtbexamplewholepage)]  
  
 Ниже для примера приведен код.  
  
 [!code-csharp[RichTextBoxMiscSnippets_snip#SaveLoadPrintRTBCodeExampleWholePage](~/samples/snippets/csharp/VS_Snippets_Wpf/RichTextBoxMiscSnippets_snip/CSharp/SaveLoadPrintRTB.xaml.cs#saveloadprintrtbcodeexamplewholepage)]
   
  
## <a name="see-also"></a>См. также

- [Практические руководства](richtextbox-how-to-topics.md)
- [Общие сведения о TextBox](textbox-overview.md)
