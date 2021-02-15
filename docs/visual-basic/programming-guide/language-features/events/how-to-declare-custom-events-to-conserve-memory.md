---
description: Дополнительные сведения см. в статье как объявить пользовательские события для экономии памяти (Visual Basic)
title: Практическое руководство. Объявление пользовательских событий для экономии памяти
ms.date: 07/20/2015
helpviewer_keywords:
- declaring events [Visual Basic], custom
- events [Visual Basic], custom
- custom events [Visual Basic]
ms.assetid: 87ebee87-260c-462f-979c-407874debd19
ms.openlocfilehash: 7371ec3df41ad0efd4598e0902f6937881d1e1a2
ms.sourcegitcommit: 10e719780594efc781b15295e499c66f316068b8
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/14/2021
ms.locfileid: "100460089"
---
# <a name="how-to-declare-custom-events-to-conserve-memory-visual-basic"></a>Практическое руководство. Объявление пользовательских событий для экономии памяти (Visual Basic)

Существует несколько ситуаций, когда важно, чтобы приложение продолжало использовать память в низком объеме. Пользовательские события позволяют приложению использовать память только для обрабатываемых событий.  
  
 По умолчанию, когда класс объявляет событие, компилятор выделяет память для поля, в котором хранятся сведения о событии. Если класс содержит много неиспользуемых событий, они не занимают память.  
  
 Вместо использования реализации по умолчанию событий, предоставляемых Visual Basic, можно использовать пользовательские события для более тщательного управления использованием памяти.  
  
## <a name="example"></a>Пример  

 В этом примере класс использует один экземпляр <xref:System.ComponentModel.EventHandlerList> класса, хранящийся в `Events` поле, для хранения сведений об используемых событиях. <xref:System.ComponentModel.EventHandlerList>Класс является оптимизированным классом списка, предназначенным для хранения делегатов.  
  
 Все события в классе используют `Events` поле для наблюдения за тем, какие методы обрабатывают каждое событие.  
  
 [!code-vb[VbVbalrEvents#22](~/samples/snippets/visualbasic/VS_Snippets_VBCSharp/VbVbalrEvents/VB/Class1.vb#22)]  
  
## <a name="see-also"></a>См. также

- <xref:System.ComponentModel.EventHandlerList>
- [События](index.md)
- [Практическое руководство. Объявление пользовательских событий для предотвращения блокировки](how-to-declare-custom-events-to-avoid-blocking.md)
