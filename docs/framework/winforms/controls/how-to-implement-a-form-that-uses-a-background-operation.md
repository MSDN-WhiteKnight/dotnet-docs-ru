---
title: Практическое руководство. Реализация формы, в которой выполняется фоновая операция
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- threading [Windows Forms], forms
- BackgroundWorker component
- background tasks
- forms [Windows Forms], multithreading
- components [Windows Forms], asynchronous
- forms [Windows Forms], background operations
- background threads
- threading [Windows Forms], background operations
- background operations
ms.assetid: 9f483f93-1613-4be1-a021-b4934e9c78f3
ms.openlocfilehash: 98d51f9c6465186e77784aba080130110545f399
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59192164"
---
# <a name="how-to-implement-a-form-that-uses-a-background-operation"></a>Практическое руководство. Реализация формы, в которой выполняется фоновая операция
В примере ниже программа создает форму, которая вычисляет числа Фибоначчи. Вычисление выполняется в потоке, отдельном от потока пользовательского интерфейса, поэтому в ходе вычисления пользовательский интерфейс продолжает выполняться без задержек.  
  
 В Visual Studio предусмотрена расширенная поддержка данной задачи.  
  
 Также см. в разделе [Пошаговое руководство: Реализация формы, в который выполняется фоновая операция](walkthrough-implementing-a-form-that-uses-a-background-operation.md).  
  
## <a name="example"></a>Пример  
 [!code-cpp[System.ComponentModel.BackgroundWorker#1](~/samples/snippets/cpp/VS_Snippets_Winforms/System.ComponentModel.BackgroundWorker/CPP/fibonacciform.cpp#1)]
 [!code-csharp[System.ComponentModel.BackgroundWorker#1](~/samples/snippets/csharp/VS_Snippets_Winforms/System.ComponentModel.BackgroundWorker/CS/fibonacciform.cs#1)]
 [!code-vb[System.ComponentModel.BackgroundWorker#1](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.ComponentModel.BackgroundWorker/VB/fibonacciform.vb#1)]  
  
## <a name="compiling-the-code"></a>Компиляция кода  
 Для этого примера требуются:  
  
-   ссылки на сборки System, System.Drawing и System.Windows.Forms.  
  
 Сведения о выполнении сборки этого примера из командной строки для Visual Basic или Visual C#, см. в разделе [построение из командной строки](../../../visual-basic/reference/command-line-compiler/building-from-the-command-line.md) или [командной строки создания с помощью csc.exe](../../../csharp/language-reference/compiler-options/command-line-building-with-csc-exe.md). Можно также сборке этого примера в Visual Studio путем вставки кода в новый проект.  
  
## <a name="robust-programming"></a>Отказоустойчивость  
  
> [!CAUTION]
>  При использовании любой многопоточности существует потенциальная возможность возникновения серьезных ошибок. Перед реализацией любого решения, в котором используется многопоточность, ознакомьтесь с разделом [Рекомендации по работе с потоками](../../../standard/threading/managed-threading-best-practices.md).  
  
## <a name="see-also"></a>См. также

- <xref:System.ComponentModel.BackgroundWorker>
- <xref:System.ComponentModel.DoWorkEventArgs>
- [Обзор асинхронной модели, основанной на событиях](../../../standard/asynchronous-programming-patterns/event-based-asynchronous-pattern-overview.md)
- [Рекомендации по работе с потоками](../../../standard/threading/managed-threading-best-practices.md)
