---
title: Общие сведения о печати
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- print path [WPF], XPS
- printers [WPF], XPSDrv-based
- printing [WPF]
- PrintQueue class PrintServer class [WPF]
- XML Paper Specification (XPS) file format
- XPS (XML Paper Specification) file format
- XPSDrv-based printers
- GDI print path [WPF]
ms.assetid: 0de8ac41-9aa6-413d-a121-7aa6f41539b1
ms.openlocfilehash: 2aeafa7065b587497fb6f3b23605c21dca291cd1
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59075864"
---
# <a name="printing-overview"></a>Общие сведения о печати
С помощью Microsoft .NET Framework, разработчики приложений с помощью Windows Presentation Foundation (WPF) имеют новый набор печати и управления печатью API. В [!INCLUDE[TLA#tla_winvista](../../../../includes/tlasharptla-winvista-md.md)] некоторые из усовершенствований управления печатью также доступны для разработчиков, создающих приложения [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)], и разработчиков, использующих неуправляемый код. В основе этой новой функциональности лежит новый формат файла [!INCLUDE[TLA#tla_xps](../../../../includes/tlasharptla-xps-md.md)] и способ печати [!INCLUDE[TLA2#tla_xps](../../../../includes/tla2sharptla-xps-md.md)].  
  
 В этом разделе содержатся следующие подразделы.  
  
<a name="introduction_to_XPS"></a>   
## <a name="about-xps"></a>О формате XPS  
 [!INCLUDE[TLA2#tla_metro](../../../../includes/tla2sharptla-metro-md.md)] — Это формат электронного документа, формат файла очереди и язык описания страницы. Это формат открытого документа, который использует [!INCLUDE[TLA#tla_xml](../../../../includes/tlasharptla-xml-md.md)], [!INCLUDE[TLA#tla_opc](../../../../includes/tlasharptla-opc-md.md)] и другие отраслевые стандарты для создания кроссплатформенных документов. [!INCLUDE[TLA2#tla_metro](../../../../includes/tla2sharptla-metro-md.md)] упрощает процесс создания, общие, печати, просматривать и архивирования цифровых документов. Дополнительные сведения о [!INCLUDE[TLA2#tla_metro](../../../../includes/tla2sharptla-metro-md.md)], см. в разделе [документы XPS](/windows/desktop/printdocs/documents).  
  
 Несколько методов печати содержимого на основе [!INCLUDE[TLA2#tla_metro](../../../../includes/tla2sharptla-metro-md.md)] с помощью WPF демонстрируются в разделе [Печать XPS-файлов программным способом](how-to-programmatically-print-xps-files.md). Ссылки на эти примеры могут оказаться полезными при просмотре содержимого этого раздела. (Разработчикам неуправляемого кода следует изучить документацию по [MXDC_ESCAPE функция](/windows/desktop/printdocs/mxdc-escape). Windows Forms разработчики приложений должны использовать API в <xref:System.Drawing.Printing> пространства имен, который не поддерживает полный [!INCLUDE[TLA2#tla_xps](../../../../includes/tla2sharptla-xps-md.md)] способ печати, но также поддерживает гибридные GDI в XPS путь печати. См. раздел **Архитектура способа печати** ниже.)  
  
<a name="XPS_print_path_intro"></a>   
## <a name="xps-print-path"></a>Способ печати XPS  
 [!INCLUDE[TLA#tla_metro](../../../../includes/tlasharptla-metro-md.md)] — Это новый способ печати Windows компонент, который переопределяет способ обработки печати в приложениях Windows. Поскольку [!INCLUDE[TLA2#tla_xps](../../../../includes/tla2sharptla-xps-md.md)] может заменить язык представления документов (например, RTF), формат очереди печати (например, WMF) и язык описания страницы (например, PCL или Postscript), новый способ печати поддерживает формат [!INCLUDE[TLA2#tla_metro](../../../../includes/tla2sharptla-metro-md.md)] от публикации приложения до последней обработки в драйвере печати или устройстве печати.  
  
 Способ печати [!INCLUDE[TLA2#tla_metro](../../../../includes/tla2sharptla-metro-md.md)] построен на основе модели драйвера печати [!INCLUDE[TLA2#tla_metro](../../../../includes/tla2sharptla-metro-md.md)] (XPSDrv), которая предоставляет разработчикам различные преимущества, такие как печать [!INCLUDE[TLA#tla_wys](../../../../includes/tlasharptla-wys-md.md)], улучшенная поддержка цвета и значительно повышенная производительность печати. (Сведения о XPSDrv см. в разделе [документации Windows Driver Kit](/windows-hardware/drivers/).)  
  
 Операция диспетчера очереди печати для [!INCLUDE[TLA2#tla_metro](../../../../includes/tla2sharptla-metro-md.md)] документов в основном одинаков как в предыдущих версиях Windows. Однако она была усовершенствована для поддержки способа печати [!INCLUDE[TLA2#tla_metro](../../../../includes/tla2sharptla-metro-md.md)] в дополнение к существующему способу печати [!INCLUDE[TLA2#tla_gdi](../../../../includes/tla2sharptla-gdi-md.md)]. Новый способ печати использует файл очереди [!INCLUDE[TLA2#tla_metro](../../../../includes/tla2sharptla-metro-md.md)]. Хотя драйверы принтеров пользовательского режима, написанные для предыдущих версий Windows, будут продолжать работать, [!INCLUDE[TLA2#tla_metro](../../../../includes/tla2sharptla-metro-md.md)] для использования способа печати [!INCLUDE[TLA2#tla_metro](../../../../includes/tla2sharptla-metro-md.md)] необходим драйвер принтера (XPSDrv).  
  
 Преимущества способа печати [!INCLUDE[TLA2#tla_metro](../../../../includes/tla2sharptla-metro-md.md)] являются существенными и включают следующее.  
  
-   [!INCLUDE[TLA2#tla_wys](../../../../includes/tla2sharptla-wys-md.md)] поддержка печати  
  
-   Встроенная поддержка дополнительных цветовых профилей, включая 32 бита на канал (bpc), CMYK, именованные цвета, n-краски и встроенную поддержку прозрачности и градиентов.  
  
-   Повышенная производительность печати для .NET Framework, так и [!INCLUDE[TLA#tla_win32](../../../../includes/tlasharptla-win32-md.md)] приложений на основе.  
  
-   Формат [!INCLUDE[TLA2#tla_metro](../../../../includes/tla2sharptla-metro-md.md)] отраслевого стандарта  
  
 Для базовых сценариев печати доступен простой и понятный API с одной точкой входа для пользовательского интерфейса, конфигурации и отправкой задания. Для расширенных сценариев добавлена дополнительная поддержка настройки UI  (или не UI вообще), синхронной или асинхронной печати и возможностей пакетной печати. Оба параметра обеспечивают поддержку печати в режиме полного или частичного доверия.  
  
 [!INCLUDE[TLA2#tla_metro](../../../../includes/tla2sharptla-metro-md.md)] была разработана с учетом возможности расширения. С помощью инфраструктуры расширяемости функции и возможности можно добавлять в [!INCLUDE[TLA2#tla_metro](../../../../includes/tla2sharptla-metro-md.md)] модульным способом. Функции расширяемости включают следующее.  
  
-   Схема печати. Общая схема обновляется регулярно и позволяет быстро расширять возможности устройства. (См. **PrintTicket и PrintCapabilities** ниже.)  
  
-   Расширяемый конвейер фильтра. Конвейер фильтра драйвера принтера [!INCLUDE[TLA2#tla_metro](../../../../includes/tla2sharptla-metro-md.md)] (XPSDrv) был разработан для включения как прямой, так и масштабируемой печати документов [!INCLUDE[TLA2#tla_metro](../../../../includes/tla2sharptla-metro-md.md)]. Дополнительные сведения см. в разделе [драйверы принтера XPSDrv](/windows-hardware/drivers/print/xpsdrv-printer-drivers). 
  
### <a name="print-path-architecture"></a>Архитектура способа печати  
 Хотя оба [!INCLUDE[TLA2#tla_win32](../../../../includes/tla2sharptla-win32-md.md)] и приложения .NET Framework поддерживают [!INCLUDE[TLA2#tla_metro](../../../../includes/tla2sharptla-metro-md.md)], [!INCLUDE[TLA2#tla_win32](../../../../includes/tla2sharptla-win32-md.md)] и приложения Windows Forms используют [!INCLUDE[TLA2#tla_gdi](../../../../includes/tla2sharptla-gdi-md.md)] для [!INCLUDE[TLA2#tla_metro](../../../../includes/tla2sharptla-metro-md.md)] преобразования для создания [!INCLUDE[TLA2#tla_metro](../../../../includes/tla2sharptla-metro-md.md)] форматированное содержимое для [!INCLUDE[TLA2#tla_metro](../../../../includes/tla2sharptla-metro-md.md)]драйвер принтера (XPSDrv). Эти приложения не обязаны использовать способ печати [!INCLUDE[TLA2#tla_metro](../../../../includes/tla2sharptla-metro-md.md)], и можно продолжать использовать печать на основе [!INCLUDE[TLA#tla_emf](../../../../includes/tlasharptla-emf-md.md)]. Однако большинство функций и усовершенствований [!INCLUDE[TLA2#tla_metro](../../../../includes/tla2sharptla-metro-md.md)] доступно только приложениям, предназначенным для способа печати [!INCLUDE[TLA2#tla_metro](../../../../includes/tla2sharptla-metro-md.md)].  
  
 Чтобы включить использование принтеров на основе XPSDrv [!INCLUDE[TLA2#tla_win32](../../../../includes/tla2sharptla-win32-md.md)] и приложения Windows Forms, [!INCLUDE[TLA2#tla_metro](../../../../includes/tla2sharptla-metro-md.md)] драйвер принтера (XPSDrv) поддерживает преобразование [!INCLUDE[TLA2#tla_gdi](../../../../includes/tla2sharptla-gdi-md.md)] для [!INCLUDE[TLA2#tla_metro](../../../../includes/tla2sharptla-metro-md.md)] формат. Модель XPSDrv также предоставляет преобразователь для [!INCLUDE[TLA2#tla_metro](../../../../includes/tla2sharptla-metro-md.md)] в формат [!INCLUDE[TLA2#tla_gdi](../../../../includes/tla2sharptla-gdi-md.md)], чтобы приложения [!INCLUDE[TLA2#tla_win32](../../../../includes/tla2sharptla-win32-md.md)] могли печатать документы [!INCLUDE[TLA2#tla_xps](../../../../includes/tla2sharptla-xps-md.md)]. Для WPF приложения, преобразование [!INCLUDE[TLA2#tla_metro](../../../../includes/tla2sharptla-metro-md.md)] для [!INCLUDE[TLA2#tla_gdi](../../../../includes/tla2sharptla-gdi-md.md)] формат выполняется автоматически <xref:System.Windows.Xps.XpsDocumentWriter.Write%2A> и <xref:System.Windows.Xps.XpsDocumentWriter.WriteAsync%2A> методы <xref:System.Windows.Xps.XpsDocumentWriter> каждый раз, когда целевой очереди печати операции записи не поддерживает драйвер XPSDrv. (Приложения Windows Forms не удается выполнить печать [!INCLUDE[TLA2#tla_xps](../../../../includes/tla2sharptla-xps-md.md)] документов.)  
  
 На следующем рисунке изображена подсистема печати и определяет части, предоставляемые [!INCLUDE[TLA#tla_ms](../../../../includes/tlasharptla-ms-md.md)]и части, определенные поставщиками программного обеспечения и оборудования:  
  
 ![Снимок экрана показывает, что система печати XPS.](./media/printing-overview/xml-paper-specification-print-system.png)  
  
### <a name="basic-xps-printing"></a>Базовая печать XPS  
 WPF определяет как базовый и расширенный [!INCLUDE[TLA#tla_api](../../../../includes/tlasharptla-api-md.md)]. Для приложений, которым не требуется настройка расширенной печати или доступ к полному набору функций [!INCLUDE[TLA2#tla_metro](../../../../includes/tla2sharptla-metro-md.md)], доступна базовая поддержка печати. Базовая поддержка печати предоставляется с помощью элемента управления диалогового окна печати, который требует минимальной конфигурации и представляет знакомый UI. С помощью этой упрощенной модели печати доступны многие функции [!INCLUDE[TLA2#tla_metro](../../../../includes/tla2sharptla-metro-md.md)].  
  
#### <a name="printdialog"></a>PrintDialog  
 Элемент управления <xref:System.Windows.Controls.PrintDialog?displayProperty=nameWithType> предоставляет единую точку входа для UI, конфигурации и отправки задания [!INCLUDE[TLA2#tla_metro](../../../../includes/tla2sharptla-metro-md.md)]. Сведения о том, как создать и использовать элемент управления, см. в разделе [Вызов диалогового окна печати](how-to-invoke-a-print-dialog.md).  
  
### <a name="advanced-xps-printing"></a>Расширенная печать XPS  
 Для доступа к полному набору функций [!INCLUDE[TLA2#tla_metro](../../../../includes/tla2sharptla-metro-md.md)] необходимо использовать API расширенной печати. Некоторые соответствующие API более подробно описываются ниже. Полный список [!INCLUDE[TLA2#tla_metro](../../../../includes/tla2sharptla-metro-md.md)] способ печати API, см. в разделе <xref:System.Windows.Xps> и <xref:System.Printing> ссылки на пространства имен.  
  
#### <a name="printticket-and-printcapabilities"></a>PrintTicket и PrintCapabilities  
 <xref:System.Printing.PrintTicket> И <xref:System.Printing.PrintCapabilities> классы являются основой дополнительных [!INCLUDE[TLA2#tla_metro](../../../../includes/tla2sharptla-metro-md.md)] функции. Оба типа объектов представляют собой форматированные структуры [!INCLUDE[TLA#tla_xml](../../../../includes/tlasharptla-xml-md.md)] возможностей печати, таких как сортировка, двусторонняя печать, сшивание и т. д. Эти структуры определяются схемой печати. Объект <xref:System.Printing.PrintTicket> указывает принтеру, как обрабатывать задание печати. Класс <xref:System.Printing.PrintCapabilities> определяет возможности принтера. Запрашивая возможности принтера, можно создать <xref:System.Printing.PrintTicket>, который использует все преимущества поддерживаемых возможностей принтера. Аналогичным образом можно избежать неподдерживаемых функций.  
  
 В следующем примере демонстрируется, как запрашивать <xref:System.Printing.PrintCapabilities> принтера и создавать <xref:System.Printing.PrintTicket> с помощью кода.  
  
 
 [!code-csharp[xpscreate#PrinterCapabilities](~/samples/snippets/csharp/VS_Snippets_Wpf/XpsCreate/CSharp/XpsCreate.cs#printercapabilities)]
   
  
#### <a name="printserver-and-printqueue"></a>PrintServer и PrintQueue  
 Класс <xref:System.Printing.PrintServer> представляет сетевой сервер печати, а класс <xref:System.Printing.PrintQueue> представляет принтер и связанную с ним очередь выходных заданий. Вместе эти API обеспечивают возможность расширенного управления заданиями печати сервера. Объект <xref:System.Printing.PrintServer> или один из его производных классов используется для управления <xref:System.Printing.PrintQueue>. Метод <xref:System.Printing.PrintQueue.AddJob%2A> используется для вставки нового задания печати в очередь.  
  
 В следующем примере демонстрируется создание <xref:System.Printing.LocalPrintServer> и доступ к его <xref:System.Printing.PrintQueue> по умолчанию с помощью кода.  
  
 [!code-csharp[xpsprint#PrintQueueSnip](~/samples/snippets/csharp/VS_Snippets_Wpf/XpsPrint/CSharp/XpsPrintHelper.cs#printqueuesnip)]
   
  
#### <a name="xpsdocumentwriter"></a>XpsDocumentWriter  
 Объект <xref:System.Windows.Xps.XpsDocumentWriter> и множество его методов <xref:System.Windows.Xps.XpsDocumentWriter.Write%2A> и <xref:System.Windows.Xps.XpsDocumentWriter.WriteAsync%2A> используются для записи документов [!INCLUDE[TLA2#tla_metro](../../../../includes/tla2sharptla-metro-md.md)] в <xref:System.Printing.PrintQueue>. Например, метод <xref:System.Windows.Xps.XpsDocumentWriter.Write%28System.Windows.Documents.FixedPage%2CSystem.Printing.PrintTicket%29> используется для синхронного вывода документа [!INCLUDE[TLA2#tla_metro](../../../../includes/tla2sharptla-metro-md.md)] и <xref:System.Printing.PrintTicket>. Метод <xref:System.Windows.Xps.XpsDocumentWriter.WriteAsync%28System.Windows.Documents.FixedDocument%2CSystem.Printing.PrintTicket%29> используется для асинхронного вывода документа [!INCLUDE[TLA2#tla_metro](../../../../includes/tla2sharptla-metro-md.md)] и <xref:System.Printing.PrintTicket>.  
  
 В следующем примере показывается, как создать <xref:System.Windows.Xps.XpsDocumentWriter> с помощью кода.  
  
 [!code-csharp[XpsPrint#PrintQueueSnip](~/samples/snippets/csharp/VS_Snippets_Wpf/XpsPrint/CSharp/XpsPrintHelper.cs#printqueuesnip)]
   
  
 Методы <xref:System.Printing.PrintQueue.AddJob%2A> также предоставляют способы печати. Дополнительные сведения см. в разделе [Печать XPS-файлов программным способом](how-to-programmatically-print-xps-files.md). .  
  
<a name="GDI_Print_Path_intro"></a>   
## <a name="gdi-print-path"></a>Способ печати GDI  
 Хотя WPF приложения поддерживают [!INCLUDE[TLA2#tla_metro](../../../../includes/tla2sharptla-metro-md.md)] способ печати [!INCLUDE[TLA2#tla_win32](../../../../includes/tla2sharptla-win32-md.md)] и приложений Windows Forms также можно использовать преимущества некоторых [!INCLUDE[TLA2#tla_metro](../../../../includes/tla2sharptla-metro-md.md)] функции. Драйвер принтера [!INCLUDE[TLA2#tla_metro](../../../../includes/tla2sharptla-metro-md.md)] (XPSDrv) может преобразовать [!INCLUDE[TLA2#tla_gdi](../../../../includes/tla2sharptla-gdi-md.md)] на основе выходных данных в формат [!INCLUDE[TLA2#tla_metro](../../../../includes/tla2sharptla-metro-md.md)]. Для более сложных сценариев поддерживается настраиваемое преобразование содержимого с помощью [конвертера документов XPS Microsoft (MXDC)](/windows/desktop/printdocs/microsoft-xps-document-converter--mxdc-). Аналогичным образом WPF приложения могут выполнять вывод [!INCLUDE[TLA2#tla_gdi](../../../../includes/tla2sharptla-gdi-md.md)] способ печати путем вызова одного из <xref:System.Windows.Xps.XpsDocumentWriter.Write%2A> или <xref:System.Windows.Xps.XpsDocumentWriter.WriteAsync%2A> методы <xref:System.Windows.Xps.XpsDocumentWriter> и назначения принтер XpsDrv в качестве целевого объекта очереди печати.  

Для приложений, которым не требуется функциональность или поддержка [!INCLUDE[TLA2#tla_metro](../../../../includes/tla2sharptla-metro-md.md)], текущий способ печати [!INCLUDE[TLA2#tla_gdi](../../../../includes/tla2sharptla-gdi-md.md)] остается неизменным.  
  
-   Дополнительные справочные материалы по [!INCLUDE[TLA2#tla_gdi](../../../../includes/tla2sharptla-gdi-md.md)] печать пути и различных [!INCLUDE[TLA2#tla_metro](../../../../includes/tla2sharptla-metro-md.md)] параметры преобразования, см. в разделе [конвертера документов XPS Microsoft (MXDC)](/windows/desktop/printdocs/microsoft-xps-document-converter--mxdc-) и [драйверы принтера XPSDrv](/windows-hardware/drivers/print/xpsdrv-printer-drivers).  
  
<a name="XPS_Driver_Model_intro"></a>   
## <a name="xpsdrv-driver-model"></a>Модель драйвера XPSDrv  
 Способ печати [!INCLUDE[TLA2#tla_metro](../../../../includes/tla2sharptla-metro-md.md)] повышает эффективность очереди печати путем использования [!INCLUDE[TLA2#tla_metro](../../../../includes/tla2sharptla-metro-md.md)] в качестве собственного формата очереди печати при печати в принтер или драйвер с поддержкой [!INCLUDE[TLA2#tla_metro](../../../../includes/tla2sharptla-metro-md.md)]. Упрощенный процесс постановки в очередь избавляет от необходимости создания промежуточных файлов очередей, таких как файл данных [!INCLUDE[TLA2#tla_emf](../../../../includes/tla2sharptla-emf-md.md)], до помещения документа в очередь. Благодаря меньшим размерам файлов очереди способ печати [!INCLUDE[TLA2#tla_metro](../../../../includes/tla2sharptla-metro-md.md)] может сократить сетевой трафик и повысить производительность печати.  
  
 [!INCLUDE[TLA2#tla_emf](../../../../includes/tla2sharptla-emf-md.md)] является закрытым форматом, представляющим вывод приложения как ряд вызовов в [!INCLUDE[TLA2#tla_gdi](../../../../includes/tla2sharptla-gdi-md.md)] для служб обработки. В отличие от [!INCLUDE[TLA2#tla_emf](../../../../includes/tla2sharptla-emf-md.md)],  формат очереди [!INCLUDE[TLA2#tla_metro](../../../../includes/tla2sharptla-metro-md.md)] представляет фактический документ без необходимости дальнейшей интерпретации при выводе в драйвер принтера на основе [!INCLUDE[TLA2#tla_metro](../../../../includes/tla2sharptla-metro-md.md)] (XPSDrv). Драйверы могут работать непосредственно с данными в этом формате. Эта возможность позволяет избежать преобразования данных и цветового пространства, необходимого при использовании файлов [!INCLUDE[TLA2#tla_emf](../../../../includes/tla2sharptla-emf-md.md)] и драйверов печати на основе [!INCLUDE[TLA2#tla_gdi](../../../../includes/tla2sharptla-gdi-md.md)].  
  
 Размеры файлов очереди обычно уменьшаются при использовании документов [!INCLUDE[TLA2#tla_metro](../../../../includes/tla2sharptla-metro-md.md)], предназначенных для драйвера принтера [!INCLUDE[TLA2#tla_metro](../../../../includes/tla2sharptla-metro-md.md)] (XPSDrv), по сравнению с их эквивалентами [!INCLUDE[TLA2#tla_emf](../../../../includes/tla2sharptla-emf-md.md)]; однако бывают следующие исключения.  
  
-   Очень сложная, многоуровневая или неэффективно созданная векторная графика может быть больше, чем растровая версия того же графического объекта.  
  
-   Для отображения экрана XPS-файлы внедряют шрифты устройства, а также шрифты на компьютере; тогда как файлы очереди GDI не внедряют шрифты устройства. Но оба типа шрифтов имеют поднаборы (см. ниже), и драйверы принтера могут удалить шрифты устройства до передачи файла на принтер.  
  
 Уменьшение размера очереди выполняется посредством нескольких механизмов.  
  
-   **Поднабор шрифта**. В файле [!INCLUDE[TLA2#tla_metro](../../../../includes/tla2sharptla-metro-md.md)] хранятся только символы, используемые в документе.  
  
-   **Поддержка расширенной графики**. Встроенная поддержка прозрачности и примитивов градиента позволяет избежать растризации содержимого в документе [!INCLUDE[TLA2#tla_xps](../../../../includes/tla2sharptla-xps-md.md)].  
  
-   **Идентификация общих ресурсов**. Ресурсы, которые используются несколько раз (например, изображение, представляющее эмблему организации), рассматриваются как общие ресурсы и загружаются только один раз.  
  
-   **Сжатие ZIP**. Все документы [!INCLUDE[TLA2#tla_metro](../../../../includes/tla2sharptla-metro-md.md)] используют сжатие ZIP.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Controls.PrintDialog>
- <xref:System.Windows.Xps.XpsDocumentWriter>
- <xref:System.Windows.Xps.Packaging.XpsDocument>
- <xref:System.Printing.PrintTicket>
- <xref:System.Printing.PrintCapabilities>
- <xref:System.Printing.PrintServer>
- <xref:System.Printing.PrintQueue>
- [Практические руководства](printing-how-to-topics.md)
- [Документы в WPF](documents-in-wpf.md)
- [XPS-документы](/windows/desktop/printdocs/documents)
- [Сериализация и хранение документов](document-serialization-and-storage.md)
- [Microsoft XPS-документов преобразователя (MXDC)](/windows/desktop/printdocs/microsoft-xps-document-converter--mxdc-)
