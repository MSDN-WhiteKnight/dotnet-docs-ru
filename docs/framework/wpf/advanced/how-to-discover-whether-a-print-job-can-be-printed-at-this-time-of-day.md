---
title: Практическое руководство. Определение возможности печати в заданное время суток
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- print queues [WPF], timing
- printers [WPF], availability
- print jobs [WPF], timing
ms.assetid: 7e9c8ec1-abf6-4b3d-b1c6-33b35d3c4063
ms.openlocfilehash: 7eed5400744f1010cbf52dc8d3b3d0bc24aa4371
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59326870"
---
# <a name="how-to-discover-whether-a-print-job-can-be-printed-at-this-time-of-day"></a>Практическое руководство. Определение возможности печати в заданное время суток
Очереди печати не всегда доступны для 24 часа в сутки. Они имеют свойства времени начала и окончания, которые могут устанавливаться отключив их в определенное время суток. Эту функцию можно, например, чтобы зарезервировать принтер для использования только определенным подразделением после 17: 00. Этот отдел будет иметь другой очереди обслуживания принтера от других отделов использовать. Устанавливается в очередь для других отделов станет недоступной после 17: 00, то время как очередь для привилегированного отдела может быть быть доступна в любое время.  
  
 Кроме того задания печати, сами можно задать для печати только в указанный промежуток времени.  
  
 <xref:System.Printing.PrintQueue> И <xref:System.Printing.PrintSystemJobInfo> классы представлены в [!INCLUDE[TLA#tla_api#plural](../../../../includes/tlasharptla-apisharpplural-md.md)] платформы Microsoft .NET Framework предоставляют средства для удаленной проверки, можно ли печати данного задания печати из данной очереди в настоящее время.  
  
## <a name="example"></a>Пример  
 В приведенном ниже примере приведен пример, можно диагностировать проблемы с заданием печати.  
  
 Существует два основных действия для этого вида функции следующим образом.  
  
1. Чтение <xref:System.Printing.PrintQueue.StartTimeOfDay%2A> и <xref:System.Printing.PrintQueue.UntilTimeOfDay%2A> свойства <xref:System.Printing.PrintQueue> для определения, является ли текущее время между ними.  
  
2. Чтение <xref:System.Printing.PrintSystemJobInfo.StartTimeOfDay%2A> и <xref:System.Printing.PrintSystemJobInfo.UntilTimeOfDay%2A> свойства <xref:System.Printing.PrintSystemJobInfo> для определения, является ли текущее время между ними.  
  
 Сложности возникают потому, что эти свойства не являются <xref:System.DateTime> объектов. Они представляют собой <xref:System.Int32> объекты, представляющие время суток, как количество минут после полуночи. Кроме того это не полночь в текущем часовом поясе, но полуночи в формате UTC (время по Гринвичу).  
  
 В первом примере кода представлен статический метод **ReportQueueAndJobAvailability**, который передается <xref:System.Printing.PrintSystemJobInfo> и вызывает вспомогательные методы для определения, является ли принтер может начать печать в настоящее время и, если нет, когда можно напечатать. Обратите внимание, что <xref:System.Printing.PrintQueue> не передается в метод. Это обусловлено <xref:System.Printing.PrintSystemJobInfo> включает ссылку на очередь в его <xref:System.Printing.PrintSystemJobInfo.HostingPrintQueue%2A> свойство.  
  
 Подчиненные методы включают перегруженных **ReportAvailabilityAtThisTime** метод, который может принимать либо <xref:System.Printing.PrintQueue> или <xref:System.Printing.PrintSystemJobInfo> как параметр. Имеется также **TimeConverter.ConvertToLocalHumanReadableTime**. Все эти методы описаны ниже.  
  
 **ReportQueueAndJobAvailability** метод начинает с проверки, если очереди или задания печати недоступен в данный момент. Если любой из них недоступен, он затем проверяет доступность очереди. Если она недоступна, метод сообщает, этот факт и время, когда очередь снова станут доступны. Затем он проверяет, задания и если он недоступен, он сообщает в следующий раз span, когда при печати. Наконец метод сообщает самое раннее время, когда принтер может начать печать. Это наиболее поздняя из следующих двух раз.  
  
-   Время, когда очередь печати Далее доступна.  
  
-   Время, когда задание печати Далее будет доступен.  
  
 При создании отчетов время суток, <xref:System.DateTime.ToShortTimeString%2A> метод называется также в том случае, так как этот метод подавляет лет, месяцев и дней из выходных данных. Его нельзя ограничить доступность очереди печати или печати для определенного года, месяцев или дней.  
  
 
 [!code-csharp[DiagnoseProblematicPrintJob#ReportQueueAndJobAvailability](~/samples/snippets/csharp/VS_Snippets_Wpf/DiagnoseProblematicPrintJob/CSharp/Program.cs#reportqueueandjobavailability)]
   
  
 Две перегруженные версии **ReportAvailabilityAtThisTime** метод идентичны, за исключением типа, переданные им, поэтому только <xref:System.Printing.PrintQueue> версии представлена ниже.  
  
> [!NOTE]
>  Тот факт, что методы идентичны за исключением типа возникает вопрос, почему в этом образце создаются универсального метода **ReportAvailabilityAtThisTime\<T >**. Причина заключается в том, что такой метод пришлось бы быть ограничен классом, имеющим **StartTimeOfDay** и **UntilTimeOfDay** только можно ограничить свойства, которые вызывает метод, но универсальный метод один класс и единственным классом, общие для обоих <xref:System.Printing.PrintQueue> и <xref:System.Printing.PrintSystemJobInfo> в наследовании дерево является <xref:System.Printing.PrintSystemObject> которого не имеет таких свойств.  
  
 **ReportAvailabilityAtThisTime** метод (представленный в следующем примере кода) начинается с инициализации <xref:System.Boolean> sentinel переменной `true`. Оно будет сброшено к `false`, если очередь не доступна.  
  
 Затем метод проверяет, если начало и «until» раз идентичны. Если Да, очередь доступна всегда, поэтому этот метод возвращает `true`.  
  
 Если очередь не доступны постоянно, данный метод использует статический <xref:System.DateTime.UtcNow%2A> свойство для получения текущего времени в формате <xref:System.DateTime> объекта. (Мы не требуется местное время, поскольку <xref:System.Printing.PrintQueue.StartTimeOfDay%2A> и <xref:System.Printing.PrintQueue.UntilTimeOfDay%2A> сами являются свойства в формате UTC.)  
  
 Тем не менее, эти два свойства ничем не <xref:System.DateTime> объектов. Они являются <xref:System.Int32>задающими время как количество минут после полуночи в формате UTC. Поэтому нам придется преобразовать наш <xref:System.DateTime> объект минут после полуночи. Когда это будет сделано, метод просто проверяет ли «сейчас» между начала очереди, а также время, устанавливает флаг в значение false, если «сейчас» не между двумя значениями времени и возвращает этот флаг «до».  
  
 
 [!code-csharp[DiagnoseProblematicPrintJob#PrintQueueStartUntil](~/samples/snippets/csharp/VS_Snippets_Wpf/DiagnoseProblematicPrintJob/CSharp/Program.cs#printqueuestartuntil)]
   
  
 **TimeConverter.ConvertToLocalHumanReadableTime** (представленный в следующем примере кода) метод не использует все методы, появившиеся в Microsoft .NET Framework, поэтому краткое обсуждение. Этот метод имеет задачу двойного преобразования: оно должно принимать целое число минут после полуночи в формате выражения и преобразовать его в удобное для восприятия времени, и его необходимо преобразовать в местное время. Он делает это, сначала создавая <xref:System.DateTime> объект, который устанавливается значение полуночи в формате UTC, а затем использует <xref:System.DateTime.AddMinutes%2A> метод, чтобы добавить минуты, которые были переданы в метод. Эта команда возвращает новый <xref:System.DateTime> содержащий исходное время, который был передан в метод. <xref:System.DateTime.ToLocalTime%2A> Метод затем преобразует это в местное время.  
  
 
 [!code-csharp[DiagnoseProblematicPrintJob#TimeConverter](~/samples/snippets/csharp/VS_Snippets_Wpf/DiagnoseProblematicPrintJob/CSharp/Program.cs#timeconverter)]
   
  
## <a name="see-also"></a>См. также

- <xref:System.DateTime>
- <xref:System.Printing.PrintSystemJobInfo>
- <xref:System.Printing.PrintQueue>
- [Документы в WPF](documents-in-wpf.md)
- [Общие сведения о печати](printing-overview.md)
