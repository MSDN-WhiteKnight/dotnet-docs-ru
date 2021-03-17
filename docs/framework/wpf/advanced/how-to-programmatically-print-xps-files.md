---
title: Практическое руководство. Печать XPS-файлов программным способом
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- printing XPS files programmatically [WPF]
- XPS files [WPF], printing programmatically
ms.assetid: 0b1c0a3f-b19e-43d6-bcc9-eb3ec4e555ad
ms.openlocfilehash: 1d6d45289c9278271a7c7bef5225ad024a5ab0fe
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59312076"
---
# <a name="how-to-programmatically-print-xps-files"></a>Практическое руководство. Печать XPS-файлов программным способом
Можно использовать перегрузку <xref:System.Printing.PrintQueue.AddJob%2A> способ печати [!INCLUDE[TLA#tla_xps](../../../../includes/tlasharptla-xps-md.md)] файлы, не открывая <xref:System.Windows.Controls.PrintDialog> или, в принципе, все [!INCLUDE[TLA#tla_ui](../../../../includes/tlasharptla-ui-md.md)] вообще.  
  
 Можно также распечатать [!INCLUDE[TLA#tla_xps](../../../../includes/tlasharptla-xps-md.md)] файлов с помощью многочисленных <xref:System.Windows.Xps.XpsDocumentWriter.Write%2A> и <xref:System.Windows.Xps.XpsDocumentWriter.WriteAsync%2A> методы <xref:System.Windows.Xps.XpsDocumentWriter>. Дополнительные сведения см. в разделе [Печать документа XPS](https://docs.microsoft.com/previous-versions/dotnet/netframework-3.5/ms771525(v=vs.90)).  
  
 Еще один способ печати [!INCLUDE[TLA#tla_xps](../../../../includes/tlasharptla-xps-md.md)] заключается в использовании <xref:System.Windows.Controls.PrintDialog.PrintDocument%2A> или <xref:System.Windows.Controls.PrintDialog.PrintVisual%2A> методы <xref:System.Windows.Controls.PrintDialog> элемента управления. См. раздел [Вызов диалогового окна печати](how-to-invoke-a-print-dialog.md).  
  
## <a name="example"></a>Пример  
 Основные действия с помощью с тремя параметрами <xref:System.Printing.PrintQueue.AddJob%28System.String%2CSystem.String%2CSystem.Boolean%29> метод, как показано ниже. Подробные сведения см. в примере.  
  
1. Определите, является ли принтер принтером XPSDrv. (Дополнительные сведения о XPSDrv см. в разделе [Обзор печати](printing-overview.md).)  
  
2. Если принтер не является принтером XPSDrv, задайте однопотоковое подразделение потока.  
  
3. Создайте экземпляр сервера печати и объект очереди печати.  
  
4. Вызовите метод, указав имя задания, файл для печати и <xref:System.Boolean> флаг, указывающий, будет ли принтер принтером XPSDrv.  
  
 В приведенном ниже примере показано, как выполнить пакетную печать всех файлов [!INCLUDE[TLA2#tla_xps](../../../../includes/tla2sharptla-xps-md.md)] в каталоге. Несмотря на то, что приложение предлагает пользователю указать каталог, с тремя параметрами <xref:System.Printing.PrintQueue.AddJob%28System.String%2CSystem.String%2CSystem.Boolean%29> метод не требует [!INCLUDE[TLA#tla_ui](../../../../includes/tlasharptla-ui-md.md)]. Его можно использовать в любом пути кода при условии, что вы знаете имя файла [!INCLUDE[TLA2#tla_xps](../../../../includes/tla2sharptla-xps-md.md)] и путь, который вы можете ему передать.  
  
 С тремя параметрами <xref:System.Printing.PrintQueue.AddJob%28System.String%2CSystem.String%2CSystem.Boolean%29> перегрузки <xref:System.Printing.PrintQueue.AddJob%2A> должна выполняться в однопотоковом подразделении всякий раз, когда <xref:System.Boolean> параметр `false`, который он должен быть, если используется принтер XPSDrv. Однако по умолчанию состояние подразделения для [!INCLUDE[TLA#tla_net](../../../../includes/tlasharptla-net-md.md)] многопотоковое. Данное значение по умолчанию должно быть обращено, поскольку в этом примере предполагается, что принтер не является принтером XPSDrv.  
  
 Изменить значение по умолчанию можно одним из двух способов. Первый способ — просто добавьте <xref:System.STAThreadAttribute> (то есть "`[System.STAThreadAttribute()]`«) непосредственно над первой строки приложения `Main` метод (обычно"`static void Main(string[] args)`«). Тем не менее, многие приложения требуют `Main` метод имеют состояние многопотокового подразделения, поэтому второй метод: поместить вызов <xref:System.Printing.PrintQueue.AddJob%28System.String%2CSystem.String%2CSystem.Boolean%29> в отдельном потоке, имеющий состояние подразделения присваивается <xref:System.Threading.ApartmentState.STA> с <xref:System.Threading.Thread.SetApartmentState%2A>. В следующем примере используется второй метод.  
  
 Соответственно, пример начинается с создания экземпляра <xref:System.Threading.Thread> объекта и его передачи **PrintXPS** метод как <xref:System.Threading.ThreadStart> параметр. (Метод **PrintXPS** определяется ниже в этом примере.) Затем для потока устанавливается однопотоковое подразделение. Остальной код метода `Main` начинается с нового потока.  
  
 Основу этого примера составляет метод `static` **BatchXPSPrinter.PrintXPS**. После создания сервера и очереди печати метод предлагает пользователю выбрать каталог, содержащий файлы [!INCLUDE[TLA2#tla_xps](../../../../includes/tla2sharptla-xps-md.md)]. После проверки существования каталога и наличие \*.xps файлы в ней, метод добавляет каждый такой файл в очередь печати. В примере предполагается, что принтер не является принтером XPSDrv, поэтому мы передаем `false` для последнего параметра <xref:System.Printing.PrintQueue.AddJob%28System.String%2CSystem.String%2CSystem.Boolean%29> метод. В связи с этим метод проверит разметку [!INCLUDE[TLA2#tla_xps](../../../../includes/tla2sharptla-xps-md.md)] в файле и только после этого конвертирует его в язык описания страниц принтера. Если проверка завершается ошибкой, выдается исключение. Код в примере перехватит исключение, сообщит о нем пользователю, а затем перейдет к обработке следующего файла [!INCLUDE[TLA2#tla_xps](../../../../includes/tla2sharptla-xps-md.md)].  
  
 [!code-csharp[BatchPrintXPSFiles#BatchPrintXPSFiles](~/samples/snippets/csharp/VS_Snippets_Wpf/BatchPrintXPSFiles/CSharp/Program.cs#batchprintxpsfiles)]
 [!code-vb[BatchPrintXPSFiles#BatchPrintXPSFiles](~/samples/snippets/visualbasic/VS_Snippets_Wpf/BatchPrintXPSFiles/visualbasic/program.vb#batchprintxpsfiles)]  
  
 Если вы используете принтер XPSDrv, последнему параметру можно присвоить значение `true`. В этом случае, поскольку [!INCLUDE[TLA2#tla_xps](../../../../includes/tla2sharptla-xps-md.md)] является языком описания страниц принтера, метод отправляет файл на принтер без проверки или преобразования в другой язык описания страниц. Если вы не уверены во время разработки ли приложение будет использовать принтер XPSDrv, можно изменить приложение, чтобы оно считывало <xref:System.Printing.PrintQueue.IsXpsDevice%2A> свойство и ветви, оно читало.  
  
 Так как изначально потребуется всего несколько принтеров доступны сразу же после выпуска [!INCLUDE[TLA#tla_winvista](../../../../includes/tlasharptla-winvista-md.md)] и Microsoft .NET Framework, может потребоваться маскировка принтер XPSDrv, как принтер XPSDrv. Для этого добавьте файл Pipelineconfig.xml в список файлов в следующем разделе реестра компьютера, на котором выполняется ваше приложение:  
  
 HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Print\Environments\Windows NT x86\Drivers\Version-3\\*\<PseudoXPSPrinter>* \DependentFiles  
  
 где  *\<PseudoXPSPrinter>*  — это любая очередь печати. После этого компьютер необходимо перезагрузить.  
  
 Эта маскировка позволит передавать `true` как последний параметр <xref:System.Printing.PrintQueue.AddJob%28System.String%2CSystem.String%2CSystem.Boolean%29> без возникновения исключения, но поскольку  *\<PseudoXPSPrinter >* деле не является принтером XPSDrv, будет распечатан только мусор.  
  
 **Примечание** для простоты в примере выше используется наличие \*.xps расширения в качестве проверки того, что файл [!INCLUDE[TLA2#tla_xps](../../../../includes/tla2sharptla-xps-md.md)]. При этом файлы [!INCLUDE[TLA2#tla_xps](../../../../includes/tla2sharptla-xps-md.md)] не обязательно должны иметь такое расширение. [isXPS.exe (isXPS Conformance Tool)](https://docs.microsoft.com/previous-versions/dotnet/netframework-4.0/aa348104(v=vs.100)) является одним из способов проверки файла на соответствие [!INCLUDE[TLA2#tla_xps](../../../../includes/tla2sharptla-xps-md.md)].  
  
## <a name="see-also"></a>См. также

- <xref:System.Printing.PrintQueue>
- <xref:System.Printing.PrintQueue.AddJob%2A>
- <xref:System.Threading.ApartmentState>
- <xref:System.STAThreadAttribute>
- [XPS-документы](/windows/desktop/printdocs/documents)
- [Печать документа XPS](https://docs.microsoft.com/previous-versions/dotnet/netframework-3.5/ms771525(v=vs.90))
- [Управляемые и неуправляемые потоки](https://docs.microsoft.com/previous-versions/dotnet/netframework-4.0/5s8ee185(v=vs.100))
- [isXPS.exe (средство проверки соответствия isXPS)](https://docs.microsoft.com/previous-versions/dotnet/netframework-4.0/aa348104(v=vs.100))
- [Документы в WPF](documents-in-wpf.md)
- [Общие сведения о печати](printing-overview.md)
