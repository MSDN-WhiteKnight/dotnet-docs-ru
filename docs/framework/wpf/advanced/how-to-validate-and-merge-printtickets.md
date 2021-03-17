---
title: Практическое руководство. Проверка и слияние PrintTickets
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- merging PrintTickets [WPF]
- PrintTicket [WPF], merging
- validation of PrintTickets [WPF]
- PrintTicket [WPF], validation
ms.assetid: 4fe2d501-d0b0-4fef-86af-6ffe6c162532
ms.openlocfilehash: be8b299c99515394bc676cfd7a715cb82ac4d58c
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59301156"
---
# <a name="how-to-validate-and-merge-printtickets"></a>Практическое руководство. Проверка и слияние PrintTickets
[!INCLUDE[TLA#tla_win](../../../../includes/tlasharptla-win-md.md)] [Print Schema](https://go.microsoft.com/fwlink/?LinkId=186397) включает гибкой и расширяемой <xref:System.Printing.PrintCapabilities> и <xref:System.Printing.PrintTicket> элементы. Первый элемент перечисляет возможности устройства печати, а второй указывает, как устройство должно использовать эти возможности по отношению к определенной последовательности документов, отдельному документу или отдельной страницы.  
  
 Типичная последовательность задач для приложения, которое поддерживает печать будет выглядеть следующим образом.  
  
1. Определите возможности принтера.  
  
2. Настройка <xref:System.Printing.PrintTicket> для использования этих возможностей.  
  
3. Проверка <xref:System.Printing.PrintTicket>.  
  
 В этой статье показано, как это сделать.  
  
## <a name="example"></a>Пример  
 В простом примере нас интересуют только может ли принтер поддерживает двухстороннюю печать — двухсторонней печати. Ниже приведены основные шаги.  
  
1. Получить <xref:System.Printing.PrintCapabilities> со <xref:System.Printing.PrintQueue.GetPrintCapabilities%2A> метод.  
  
2. Для проверки наличия нужные возможности. В приведенном ниже примере мы проверить <xref:System.Printing.PrintCapabilities.DuplexingCapability%2A> свойство <xref:System.Printing.PrintCapabilities> объекта на наличие возможности печати на обеих сторонах листа бумаги с «Включение страницы» вдоль длинной стороны листа. Так как <xref:System.Printing.PrintCapabilities.DuplexingCapability%2A> является коллекцией, мы используем `Contains` метод <xref:System.Collections.ObjectModel.ReadOnlyCollection%601>.  
  
    > [!NOTE]
    >  Этот шаг не является обязательным. <xref:System.Printing.PrintQueue.MergeAndValidatePrintTicket%2A> Ниже использован метод будет проверять каждый запрос <xref:System.Printing.PrintTicket> от возможностей используемого принтера. Если запрошенная возможность не поддерживается принтером, драйвер принтера заменит альтернативный запрос в <xref:System.Printing.PrintTicket> возвращаемых методом.  
  
3. Если принтер поддерживает двусторонней печати, в примере кода создается <xref:System.Printing.PrintTicket> , запрашивающий двусторонней печати. Но приложение не указывает каждый возможный параметр в принтера <xref:System.Printing.PrintTicket> элемент. Это было бы расточительно для программиста и программа время. Вместо этого код задает только запрос двусторонней печати, а затем выполняет слияние этого <xref:System.Printing.PrintTicket> с существующим, полностью настроенную и проверки <xref:System.Printing.PrintTicket>, в этом случае пользователя по умолчанию <xref:System.Printing.PrintTicket>.  
  
4. Соответственно, в образце вызывается <xref:System.Printing.PrintQueue.MergeAndValidatePrintTicket%2A> метод для слияния нового, минимальным, <xref:System.Printing.PrintTicket> пользователя имеет значения по умолчанию <xref:System.Printing.PrintTicket>. Эта команда возвращает <xref:System.Printing.ValidationResult> , содержащий новый <xref:System.Printing.PrintTicket> как один из его свойств.  
  
5. Затем образец тестирует, новый <xref:System.Printing.PrintTicket> запрашивает двусторонней печати. Если это так, то в этом образце он новый билет печати по умолчанию для пользователя. Если шаг 2 был пропущен и принтера не поддерживали дуплексная вдоль длинной стороны, то тест привела бы к `false`. (См. Примечание выше).  
  
6. Последний значительный шаг заключается в фиксации, чтобы изменения <xref:System.Printing.PrintQueue.UserPrintTicket%2A> свойство <xref:System.Printing.PrintQueue> с <xref:System.Printing.PrintQueue.Commit%2A> метод.  
  
 [!code-csharp[PrintTicketManagment#UsingMergeAndValidate](~/samples/snippets/csharp/VS_Snippets_Wpf/PrintTicketManagment/CSharp/printticket.cs#usingmergeandvalidate)]
 [!code-vb[PrintTicketManagment#UsingMergeAndValidate](~/samples/snippets/visualbasic/VS_Snippets_Wpf/PrintTicketManagment/visualbasic/printticket.vb#usingmergeandvalidate)]  
  
 Таким образом, вы можете быстро проверить в этом примере, его оставшаяся часть представлена ниже. Создание проекта и пространство имен, а затем вставьте фрагменты кода в этой статье, в блок пространства имен.  
  
 [!code-csharp[PrintTicketManagment#UIForMergeAndValidatePTUtility](~/samples/snippets/csharp/VS_Snippets_Wpf/PrintTicketManagment/CSharp/printticket.cs#uiformergeandvalidateptutility)]
 [!code-vb[PrintTicketManagment#UIForMergeAndValidatePTUtility](~/samples/snippets/visualbasic/VS_Snippets_Wpf/PrintTicketManagment/visualbasic/printticket.vb#uiformergeandvalidateptutility)]  
  
## <a name="see-also"></a>См. также

- <xref:System.Printing.PrintCapabilities>
- <xref:System.Printing.PrintTicket>
- <xref:System.Printing.PrintServer.GetPrintQueues%2A>
- <xref:System.Printing.PrintServer>
- <xref:System.Printing.EnumeratedPrintQueueTypes>
- <xref:System.Printing.PrintQueue>
- <xref:System.Printing.PrintQueue.GetPrintCapabilities%2A>
- [Документы в WPF](documents-in-wpf.md)
- [Общие сведения о печати](printing-overview.md)
- [Схема печати](https://go.microsoft.com/fwlink/?LinkId=186397)
