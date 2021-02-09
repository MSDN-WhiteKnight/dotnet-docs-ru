---
description: 'Подробнее о следующем: Пошаговое руководство. Определение места записи информации для My.Application.Log (Visual Basic)'
title: Определение места записи сведений для My.Application.Log
ms.date: 07/20/2015
helpviewer_keywords:
- My.Log object, output location
- output, application log location
- My.Application.Log object, output location
- event logs, determining output location
- application event logs, output location
- applications [Visual Basic], output location
ms.assetid: 5b70143a-7741-45f2-ae1d-03324a3a4189
ms.openlocfilehash: 4ddb5777bcbdde07069efd2fd3a66f0c220ee135
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: HT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99792288"
---
# <a name="walkthrough-determining-where-myapplicationlog-writes-information-visual-basic"></a>Пошаговое руководство. Определение места записи информации для My.Application.Log (Visual Basic)

Объект `My.Application.Log` может записывать информацию в несколько прослушивателей журналов. Прослушиватели журнала настраиваются в файле конфигурации компьютера и могут переопределяться в файле конфигурации приложения. В этом разделе описаны параметры по умолчанию и способ определения параметров для приложения.

Дополнительные сведения о расположении выходных данных по умолчанию см. в разделе [Работа с журналами приложения](working-with-application-logs.md).

### <a name="to-determine-the-listeners-for-myapplicationlog"></a>Определение прослушивателей для объекта My.Application.Log

1. Найдите файл конфигурации сборки. Во время разработки сборки доступ к файлу app.config в Visual Studio можно получить в **обозревателе решений**. В противном случае имя файла конфигурации — это имя сборки с расширением .config, а расположен он в том же каталоге, что и сборка.

    > [!NOTE]
    > Не каждая сборка имеет файл конфигурации.

    Файл конфигурации является XML-файлом.

2. Найдите раздел `<listeners>` в разделе `<source>` с атрибутом `name` , равным DefaultSource, в разделе `<sources>` . Раздел `<sources>` находится в разделе `<system.diagnostics>` в разделе `<configuration>` верхнего уровня.

    Если эти разделы не существуют, то настройка прослушивателей журнала `My.Application.Log` может быть задана в файле конфигурации компьютера. Далее описано, как выяснить, что определяется в файле конфигурации компьютера.

    1. Найдите файл machine.config компьютера. Как правило, он находится в каталоге *SystemRoot\Microsoft.NET\Framework\frameworkVersion\CONFIG*, где `SystemRoot` — каталог операционной системы, а `frameworkVersion` — версия .NET Framework.

        Параметры в файле machine.config могут быть переопределены файлом конфигурации приложения.

        Если необязательные элементы, перечисленные ниже, отсутствуют, их можно создать.

    2. Найдите раздел `<listeners>` в разделе `<source>` с атрибутом `name` , равным DefaultSource, в разделе `<sources>` раздела `<system.diagnostics>` в разделе `<configuration>` верхнего уровня.

        Если эти разделы не существуют, то в объекте `My.Application.Log` имеются только прослушиватели журнала по умолчанию.

3. Найдите элементы <`add>` в разделе <`listeners>`.

     Эти элементы добавляют именованные прослушиватели журнала в источник `My.Application.Log` .

4. Найдите элементы `<add>` с именами прослушивателей журнала в разделе `<sharedListeners>` раздела `<system.diagnostics>` в разделе `<configuration>` верхнего уровня.

5. Данные инициализации для многих типов общих прослушивателей включают описание того, куда прослушиватель направляет данные.

    - Прослушиватель <xref:Microsoft.VisualBasic.Logging.FileLogTraceListener?displayProperty=nameWithType> записывает данные в журнал файлов, как описано во введении.

    - Прослушиватель <xref:System.Diagnostics.EventLogTraceListener?displayProperty=nameWithType> записывает данные в журнал событий компьютера, определяемый параметром `initializeData` . Для просмотра журнала событий можно использовать **обозреватель сервера** или **средство просмотра событий Windows**. Дополнительные сведения см. в разделе [События трассировки событий Windows в .NET Framework](../../../../framework/performance/etw-events.md).

    - Прослушиватели <xref:System.Diagnostics.DelimitedListTraceListener?displayProperty=nameWithType> и <xref:System.Diagnostics.XmlWriterTraceListener?displayProperty=nameWithType> записывают данные в файл, указанный в параметре `initializeData` .

    - Прослушиватель <xref:System.Diagnostics.ConsoleTraceListener?displayProperty=nameWithType> выводит данные в консоль командной строки.

    - Сведения о том, куда записывают информацию другие типы прослушивателей журналов, приведены в документации по этим типам.

## <a name="see-also"></a>См. также

- <xref:Microsoft.VisualBasic.Logging.Log?displayProperty=nameWithType>
- <xref:System.Diagnostics.DefaultTraceListener>
- <xref:System.Diagnostics.EventLogTraceListener>
- <xref:System.Diagnostics.DelimitedListTraceListener>
- <xref:System.Diagnostics.XmlWriterTraceListener>
- <xref:System.Diagnostics.ConsoleTraceListener>
- <xref:System.Diagnostics>
- [Работа с журналами приложения](working-with-application-logs.md)
- [Практическое руководство. Исплючения журналов](how-to-log-exceptions.md)
- [Практическое руководство. Запись сообщений в журнал](how-to-write-log-messages.md)
- [Пошаговое руководство: Изменение места записи сведений для My.Application.Log](walkthrough-changing-where-my-application-log-writes-information.md)
- [ETW Events in the .NET Framework](../../../../framework/performance/etw-events.md)
- [Устранение неполадок. Прослушиватели журнала](troubleshooting-log-listeners.md)
