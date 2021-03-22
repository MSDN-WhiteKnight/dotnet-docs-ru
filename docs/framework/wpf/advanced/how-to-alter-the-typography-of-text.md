---
title: Практическое руководство. Изменение оформления текста
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- setting Typography attributes [WPF]
- Typography attribute [WPF], setting
ms.assetid: 19a3b49b-60a2-4c11-a786-e26b4c965588
ms.openlocfilehash: 4c027424632f8671ba8d7cae1c899ef3a53edc26
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59078867"
---
# <a name="how-to-alter-the-typography-of-text"></a>Практическое руководство. Изменение оформления текста
В следующем примере показано, как задать <xref:System.Windows.Documents.TextElement.Typography%2A> атрибут, с помощью <xref:System.Windows.Documents.Paragraph> качестве элемента примера.  
  
## <a name="example"></a>Пример  
 [!code-xaml[TextElementSnippets#_TextElement_TypogXAML](~/samples/snippets/csharp/VS_Snippets_Wpf/TextElementSnippets/CSharp/Window1.xaml#_textelement_typogxaml)]  
  
 На следующем рисунке показана отрисовка этого примера.  
  
 ![Снимок экрана: Текст с измененной типографией](./media/textelement-typog.png "TextElement_Typog")  
  
 Напротив, на следующем рисунке показано, как отрисовывается аналогичный пример с типографскими характеристиками по умолчанию.  
  
 ![Снимок экрана: Текст с измененной типографией](./media/textelement-typog-default.png "TextElement_Typog_Default")  
  
## <a name="example"></a>Пример  
 В следующем примере показано, как задать <xref:System.Windows.Controls.TextBox.Typography%2A> свойства программным способом.  
  
 [!code-csharp[TextElementSnippets#_TextElement_Typog](~/samples/snippets/csharp/VS_Snippets_Wpf/TextElementSnippets/CSharp/Window1.xaml.cs#_textelement_typog)]
   
  
## <a name="see-also"></a>См. также

- [Общие сведения о документах нефиксированного формата](flow-document-overview.md)
