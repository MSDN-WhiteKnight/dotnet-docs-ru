---
description: Дополнительные сведения см. в статье как объявить пользовательские события, чтобы избежать блокировки (Visual Basic)
title: Практическое руководство. Объявление пользовательских событий для предотвращения блокировки
ms.date: 07/20/2015
helpviewer_keywords:
- declaring events [Visual Basic], custom
- events [Visual Basic], custom
- custom events [Visual Basic]
ms.assetid: 998b6a90-67c5-4d2c-8b11-366d3e355505
ms.openlocfilehash: a4ad3162e8f95ebbf7567d427ea00060b19b2235
ms.sourcegitcommit: 10e719780594efc781b15295e499c66f316068b8
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/14/2021
ms.locfileid: "100469725"
---
# <a name="how-to-declare-custom-events-to-avoid-blocking-visual-basic"></a>Практическое руководство. Объявление пользовательских событий для предотвращения блокировки (Visual Basic)

Существует несколько ситуаций, когда важно, чтобы один обработчик событий не блокировал последующие обработчики событий. Пользовательские события позволяют событию вызывать свои обработчики событий асинхронно.  
  
 По умолчанию поле резервного хранилища для объявления события является многоадресным делегатом, который последовательно объединяет все обработчики событий. Это означает, что если один обработчик занимает много времени, он блокирует другие обработчики до завершения его выполнения. (Правильно работающие обработчики событий не должны выполнять длительные или потенциально блокирующие операции.)  
  
 Вместо использования реализации по умолчанию событий, предоставляемых Visual Basic, можно использовать пользовательское событие для асинхронного выполнения обработчиков событий.  
  
## <a name="example"></a>Пример  

 В этом примере `AddHandler` метод доступа добавляет делегат для каждого обработчика `Click` события в объект, <xref:System.Collections.ArrayList> хранящийся в `EventHandlerList` поле.  
  
 Когда код вызывает `Click` событие, `RaiseEvent` метод доступа вызывает все делегаты обработчика событий асинхронно с помощью <xref:System.Web.Services.Protocols.LogicalMethodInfo.BeginInvoke%2A> метода. Этот метод вызывает каждый обработчик в рабочем потоке и сразу же возвращает, поэтому обработчики не могут блокировать друг друга.  
  
 [!code-vb[VbVbalrEvents#27](~/samples/snippets/visualbasic/VS_Snippets_VBCSharp/VbVbalrEvents/VB/Class1.vb#27)]  
  
## <a name="see-also"></a>См. также

- <xref:System.Collections.ArrayList>
- <xref:System.Web.Services.Protocols.LogicalMethodInfo.BeginInvoke%2A>
- [События](index.md)
- [Практическое руководство. Объявление пользовательских событий для экономии памяти](how-to-declare-custom-events-to-conserve-memory.md)
