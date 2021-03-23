---
title: Практическое руководство. Удаленный опрос состояний принтеров
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- surveying printer status remotely [WPF]
- printer status [WPF], surveying remotely
- remotely surveying printer status [WPF]
- status [WPF], printers [WPF], surveying remotely
ms.assetid: d6324759-8292-4c23-9584-9c708887dc94
ms.openlocfilehash: dc187a4ea120661e8118ce79a966d3d4a3b40711
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59340793"
---
# <a name="how-to-remotely-survey-the-status-of-printers"></a>Практическое руководство. Удаленный опрос состояний принтеров
В средних и крупных компаниях могут возникнуть ситуации, когда из-за замятия или отсутствия бумаги либо по иным причинам не работают сразу несколько принтеров. Широкий набор свойства принтеров в [!INCLUDE[TLA#tla_api#plural](../../../../includes/tlasharptla-apisharpplural-md.md)] платформы Microsoft .NET Framework предоставляют средства для выполнения быстрого опроса состояния принтеров.  
  
## <a name="example"></a>Пример  
 Ниже представлены основные этапы создания подобной служебной программы.  
  
1. Получите список всех серверов печати.  
  
2. Выполните циклический просмотр всех серверов, чтобы запросить их очереди печати.  
  
3. Для каждого сервера выполните циклический просмотр всех очередей сервера и прочтите каждое свойство, которое может указывать на то, что очередь в данный момент не работает.  
  
 Представленный ниже код представляет собой набор фрагментов. Для простоты в этом примере предполагается наличие списка серверов печати, разделенного символами перевода строки. Переменная `fileOfPrintServers` является <xref:System.IO.StreamReader> этого файла. Поскольку каждое имя сервера размещается на отдельной строке, любой вызов метода <xref:System.IO.StreamReader.ReadLine%2A> возвращает имя следующего сервера и перемещает <xref:System.IO.StreamReader>на курсор в начало следующей строки.  
  
 Во внешнем цикле в коде создается <xref:System.Printing.PrintServer> объекта для последнего сервера печати и указывает, что приложение должно обладать правами администратора на сервер.  
  
> [!NOTE]
>  При наличии большого количества серверов, можно повысить производительность с помощью <xref:System.Printing.PrintServer.%23ctor%28System.String%2CSystem.String%5B%5D%2CSystem.Printing.PrintSystemDesiredAccess%29> инициализирующих только свойства, которые вы собираетесь требуется.  
  
 Затем в примере используется <xref:System.Printing.PrintServer.GetPrintQueues%2A> создать коллекцию всех сервера и помещает в очередь и начинает организовать цикл по ним. Этот внутренний цикл содержит структуру ветвления, соответствующую двум способам проверки состояния принтера:  
  
-   Вы можете прочесть флаги из <xref:System.Printing.PrintQueue.QueueStatus%2A> свойства, которые имеют тип <xref:System.Printing.PrintQueueStatus>.  
  
-   Можно прочитать каждое соответствующее свойство, например <xref:System.Printing.PrintQueue.IsOutOfPaper%2A>, и <xref:System.Printing.PrintQueue.IsPaperJammed%2A>.  
  
 В этом примере демонстрируются оба метода, поскольку пользователь получил какой метод использовать и ответил «y», если хотите использовать флаги <xref:System.Printing.PrintQueue.QueueStatus%2A> свойство. Ниже представлены подробные сведения об этих двух методах.  
  
 В конечном итоге результаты предоставляются пользователю.  
  
 
 [!code-csharp[PrinterStatusSurvey#SurveyQueues](~/samples/snippets/csharp/VS_Snippets_Wpf/PrinterStatusSurvey/CSharp/Program.cs#surveyqueues)]
   
  
 Чтобы проверить состояние принтера, используя флаги <xref:System.Printing.PrintQueue.QueueStatus%2A> свойство, проверьте каждый соответствующий флаг включен. Обычно определить, задан ли один бит в наборе битовых флагов, позволяет логическая операция И с набором флагов в качестве одной операнды и самим флагом в качестве второй. Поскольку сам флаг имеет только один набор битов, результатом логической операции И может стать максимум установка самого бита. Чтобы определить, установлен ли этот бит, просто сравните результат логической операции И с самим флагом. Дополнительные сведения см. в разделе <xref:System.Printing.PrintQueueStatus>, [& оператор (C# ссылку)](~/docs/csharp/language-reference/operators/and-operator.md), и <xref:System.FlagsAttribute>.  
  
 Для каждого атрибута с установленным битом код добавляет уведомление в итоговый отчет, который будет представлен пользователю. (Метод **ReportAvailabilityAtThisTime**, вызываемый в конце кода, описывается ниже.)  
  
 
 [!code-csharp[PrinterStatusSurvey#SpotTroubleUsingQueueAttributes](~/samples/snippets/csharp/VS_Snippets_Wpf/PrinterStatusSurvey/CSharp/Program.cs#spottroubleusingqueueattributes)]
   
  
 Чтобы проверить состояние принтера с помощью каждого свойства, просто прочтите каждое свойство и добавьте примечание, если какое-либо свойство имеет значение `true`, в итоговый отчет для пользователя. (Метод **ReportAvailabilityAtThisTime**, вызываемый в конце кода, описывается ниже.)  
  
 
 [!code-csharp[PrinterStatusSurvey#SpotTroubleUsingQueueProperties](~/samples/snippets/csharp/VS_Snippets_Wpf/PrinterStatusSurvey/CSharp/Program.cs#spottroubleusingqueueproperties)]
   
  
 Метод **ReportAvailabilityAtThisTime** позволяет определить наличие очереди в текущее время суток.  
  
 Метод не выполняет никаких действий при <xref:System.Printing.PrintQueue.StartTimeOfDay%2A> и <xref:System.Printing.PrintQueue.UntilTimeOfDay%2A> свойства одинаковы, поскольку в этом случае принтер доступен все время. Если они отличаются, метод получает текущее время, которое затем должно быть преобразовано в общее число минут после полуночи, поскольку <xref:System.Printing.PrintQueue.StartTimeOfDay%2A> и <xref:System.Printing.PrintQueue.UntilTimeOfDay%2A> свойства являются <xref:System.Int32>, которые не представляют минут после полуночи, <xref:System.DateTime> объекты. В конечном итоге метод проверяет, находится ли текущее время в промежутке между временем начала и окончания.  
  
 
 [!code-csharp[PrinterStatusSurvey#UsingStartAndUntilTimes](~/samples/snippets/csharp/VS_Snippets_Wpf/PrinterStatusSurvey/CSharp/Program.cs#usingstartanduntiltimes)]
   
  
## <a name="see-also"></a>См. также

- <xref:System.Printing.PrintQueue.StartTimeOfDay%2A>
- <xref:System.Printing.PrintQueue.UntilTimeOfDay%2A>
- <xref:System.DateTime>
- <xref:System.Printing.PrintQueueStatus>
- <xref:System.FlagsAttribute>
- <xref:System.Printing.PrintServer.GetPrintQueues%2A>
- <xref:System.Printing.PrintServer>
- <xref:System.Printing.LocalPrintServer>
- <xref:System.Printing.EnumeratedPrintQueueTypes>
- <xref:System.Printing.PrintQueue>
- [Оператор & (Справочник по C#)](~/docs/csharp/language-reference/operators/and-operator.md)
- [Документы в WPF](documents-in-wpf.md)
- [Общие сведения о печати](printing-overview.md)
