---
title: Практическое руководство. Перечисление подмножества очередей печати
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- enumerating [WPF], subset of print queues
- print queues [WPF], enumerating subset of
ms.assetid: cc4a1b5b-d46f-4c5e-bc26-22c226e4bee0
ms.openlocfilehash: adcfff0196bd0430ec1ae563fbd5489062de11f3
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59217189"
---
# <a name="how-to-enumerate-a-subset-of-print-queues"></a>Практическое руководство. Перечисление подмножества очередей печати
Это распространенная ситуация, которыми специалистов по информационным технологиям (ИТ), управляющая набором принтеры всей компании сталкиваются состоит в создании списка принтеров, имеющих определенные характеристики. Эта функциональность обеспечивается <xref:System.Printing.PrintServer.GetPrintQueues%2A> метод <xref:System.Printing.PrintServer> объекта и <xref:System.Printing.EnumeratedPrintQueueTypes> перечисления.  
  
## <a name="example"></a>Пример  
 В следующем примере код начинается с создания массив флагов, определяющих характеристики очередей печати, которые требуется внести в список. В этом примере мы ищем очередей печати, которые устанавливаются локально на сервере печати и являются общими. <xref:System.Printing.EnumeratedPrintQueueTypes> Перечисление предоставляет множество других возможностей.  
  
 Затем он создает <xref:System.Printing.LocalPrintServer> объект, производный от класса <xref:System.Printing.PrintServer>. Локальный сервер печати — это компьютер, на котором выполняется приложение.  
  
 Последним значительным шагом является передача массив, в который <xref:System.Printing.PrintServer.GetPrintQueues%2A> метод.  
  
 В конечном итоге результаты предоставляются пользователю.  
  
 [!code-cpp[EnumerateSubsetOfPrintQueues#ListSubsetOfPrintQueues](~/samples/snippets/cpp/VS_Snippets_Wpf/EnumerateSubsetOfPrintQueues/CPP/Program.cpp#listsubsetofprintqueues)]
 [!code-csharp[EnumerateSubsetOfPrintQueues#ListSubsetOfPrintQueues](~/samples/snippets/csharp/VS_Snippets_Wpf/EnumerateSubsetOfPrintQueues/CSharp/Program.cs#listsubsetofprintqueues)]
 [!code-vb[EnumerateSubsetOfPrintQueues#ListSubsetOfPrintQueues](~/samples/snippets/visualbasic/VS_Snippets_Wpf/EnumerateSubsetOfPrintQueues/visualbasic/program.vb#listsubsetofprintqueues)]  
  
 Вы можете расширить этот пример за счет `foreach` цикл, который проходит по каждой очереди печати для дальнейшей блокировки. Например, можно блокировать принтеры, которые не поддерживают двухсторонней печати, вызвав в цикле каждой очереди печати <xref:System.Printing.PrintQueue.GetPrintCapabilities%2A> метод и проверяйте возвращаемое значение наличие блока двусторонней печати.  
  
## <a name="see-also"></a>См. также

- <xref:System.Printing.PrintServer.GetPrintQueues%2A>
- <xref:System.Printing.PrintServer>
- <xref:System.Printing.LocalPrintServer>
- <xref:System.Printing.EnumeratedPrintQueueTypes>
- <xref:System.Printing.PrintQueue>
- <xref:System.Printing.PrintQueue.GetPrintCapabilities%2A>
- [Документы в WPF](documents-in-wpf.md)
- [Общие сведения о печати](printing-overview.md)
- [Средство записи XPS-документов (Майкрософт)](https://go.microsoft.com/fwlink/?LinkId=147319)
