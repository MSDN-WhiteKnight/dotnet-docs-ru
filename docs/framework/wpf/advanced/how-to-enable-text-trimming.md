---
title: Практическое руководство. Включение обрезки текста
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- text [WPF], trimming
- documents [WPF], trimming text
- trimming text [WPF]
ms.assetid: dd8c9191-d2be-45fd-9fb4-3c75b65578c5
ms.openlocfilehash: 25fff566868e792004a915fee195485c4a1f385f
ms.sourcegitcommit: 5137208fa414d9ca3c58cdfd2155ac81bc89e917
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/06/2019
ms.locfileid: "57474151"
---
# <a name="how-to-enable-text-trimming"></a>Практическое руководство. Включение обрезки текста

В этом примере демонстрируется использование и влияние значений, доступных в <xref:System.Windows.TextTrimming> перечисления.

## <a name="example"></a>Пример

В следующем примере определяется <xref:System.Windows.Controls.TextBlock> элемент с <xref:System.Windows.Controls.TextBlock.TextTrimming%2A> набором атрибутов.

[!code-xaml[TextTrimmingSnippets#_TextTrimmingXAML](~/samples/snippets/csharp/VS_Snippets_Wpf/TextTrimmingSnippets/CSharp/Window1.xaml#_texttrimmingxaml)]

Установка соответствующего <xref:System.Windows.TextTrimming> ниже показано свойство в коде.

[!code-csharp[TextTrimmingSnippets#_TextTrimmingSetTextTrimming](~/samples/snippets/csharp/VS_Snippets_Wpf/TextTrimmingSnippets/CSharp/Window1.xaml.cs#_texttrimmingsettexttrimming)]
[!code-vb[TextTrimmingSnippets#_TextTrimmingSetTextTrimming](~/samples/snippets/visualbasic/VS_Snippets_Wpf/TextTrimmingSnippets/VisualBasic/Window1.xaml.vb#_texttrimmingsettexttrimming)]

Существует в настоящее время три параметра обрезки текста: **CharacterEllipsis**, **WordEllipsis**, и **None**.

Когда <xref:System.Windows.Controls.TextBlock.TextTrimming%2A> присваивается **CharacterEllipsis**, текст обрезается и продолжается многоточием после символа, ближайшего к краю обрезки.  Эта настройка позволяет обрезать текст максимально близко к границе обрезки, однако иногда частично обрезаются слова.  На следующем рисунке показано влияние этой настройки на <xref:System.Windows.Controls.TextBlock> аналогичную определенным выше.

![Пример: TextTrimming.CharacterEllipsis](./media/texttrimming-character.png "TextTrimming_Character")

Когда <xref:System.Windows.Controls.TextBlock.TextTrimming%2A> присваивается **WordEllipsis**, текст обрезается и продолжается многоточием в конце первого полного слова, ближайшего к краю обрезки.  Этот параметр не будет отображаться частично обрезанные слова, но не текст обрезается так близко к краю обрезки, как **CharacterEllipsis** параметр.  На следующем рисунке показано влияние этой настройки на <xref:System.Windows.Controls.TextBlock> определенный выше.

![Пример: TextTrimming.WordEllipsis](./media/texttrimming-word.png "TextTrimming_Word")

Когда <xref:System.Windows.Controls.TextBlock.TextTrimming%2A> присваивается **None**, обрезка текста не выполняется.  В этом случае текст просто обрезается по границе родительского контейнера текста.  На следующем рисунке показано влияние этой настройки на <xref:System.Windows.Controls.TextBlock> аналогичную определенным выше.

![Пример: TextTrimming.None](./media/texttrimming-none.png "TextTrimming_None")
