---
title: Практическое руководство. Настройка интервалов между абзацами
ms.date: 03/30/2017
helpviewer_keywords:
- spacing between paragraphs [WPF]
- paragraphs [WPF], spacing between
- documents [WPF], adjusting spacing between paragraphs
ms.assetid: 7cd2f2ac-0e19-4587-bfb6-7f5b18c9536e
ms.openlocfilehash: e2a6ba34e3ab15eb316671fef7c11bea03d53c73
ms.sourcegitcommit: 0c48191d6d641ce88d7510e319cf38c0e35697d0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/05/2019
ms.locfileid: "57367483"
---
# <a name="how-to-adjust-spacing-between-paragraphs"></a>Практическое руководство. Настройка интервалов между абзацами
В этом примере показано, как Настройка или устранение интервалов между абзацами в содержимом нефиксированного формата.  
  
 В содержимом нефиксированного формата дополнительное пространство между абзацами является результатом поля этих абзацев. Таким образом интервалов между абзацами можно управлять с помощью полей этих абзацев.  Чтобы полностью убрать дополнительное расстояние между двумя абзацами, установите поля для абзаца для **0**.  Для достижения одинакового интервала между абзацами во всем <xref:System.Windows.Documents.FlowDocument>, используйте стилизацию для установки одинакового значения поля для всех абзацев в <xref:System.Windows.Documents.FlowDocument>.  
  
 Важно отметить, что поля для двух соседних абзацев будет «свернуть» большее из двух полей, а не вдвое. Поэтому, если два соседних абзаца имеют поля 20 пикселей и 40 пикселей соответственно, полученное в результате пространство между абзацами 40 пикселей, большее из двух значений полей.  
  
## <a name="example"></a>Пример  
 В следующем примере используется стиль, чтобы задать поля для всех <xref:System.Windows.Documents.Paragraph> элементов в <xref:System.Windows.Documents.FlowDocument> для **0**, что эффективно устраняет дополнительный интервал между абзацами в <xref:System.Windows.Documents.FlowDocument>.  
  
 [!code-xaml[BlockSnippets#_ParagraphSpacingXAML](~/samples/snippets/csharp/VS_Snippets_Wpf/BlockSnippets/CSharp/Window1.xaml#_paragraphspacingxaml)]
