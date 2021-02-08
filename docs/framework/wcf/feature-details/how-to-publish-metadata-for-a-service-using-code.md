---
description: Дополнительные сведения см. в статье как опубликовать метаданные для службы с помощью кода.
title: Практическое руководство. Публикация метаданных для службы с использованием кода
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
ms.assetid: 51407e6d-4d87-42d5-be7c-9887b8652006
ms.openlocfilehash: 94939c77b1c66643b0cc378516479e35c41aefbb
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99793692"
---
# <a name="how-to-publish-metadata-for-a-service-using-code"></a>Практическое руководство. Публикация метаданных для службы с использованием кода

Это один из двух инструкций, посвященных публикации метаданных для службы Windows Communication Foundation (WCF). Существуют два способа указать, как служба должна публиковать метаданные: с помощью файла конфигурации и с помощью кода. В этом разделе показано, как публиковать метаданные для службы с помощью кода.  
  
> [!CAUTION]
> В этом разделе показано, как опубликовать метаданные незащищенным образом. Любой клиент может получить метаданные из службы. Если требуется защита данных при публикации метаданных службой, см. раздел [Настраиваемая конечная точка безопасных метаданных](../samples/custom-secure-metadata-endpoint.md).  
  
 Дополнительные сведения о публикации метаданных в файле конфигурации см. в разделе [инструкции. Публикация метаданных для службы с помощью файла конфигурации](how-to-publish-metadata-for-a-service-using-a-configuration-file.md). Публикация метаданных позволяет клиентам извлекать метаданные с помощью запроса WS-Transfer GET или запроса HTTP/GET, используя строку запроса `?wsdl`. Чтобы быть уверенным, что код работает, необходимо создать базовую службу WCF. Базовая резидентная служба представлена в следующем коде.  
  
 [!code-csharp[htPublishMetadataCode#0](../../../../samples/snippets/csharp/VS_Snippets_CFX/htpublishmetadatacode/cs/program.cs#0)]
 [!code-vb[htPublishMetadataCode#0](../../../../samples/snippets/visualbasic/VS_Snippets_CFX/htpublishmetadatacode/vb/program.vb#0)]  
  
### <a name="to-publish-metadata-in-code"></a>Публикация метаданных в коде  
  
1. В главном методе консольного приложения создайте экземпляр объекта <xref:System.ServiceModel.ServiceHost>, передав тип и базовый адрес службы.  
  
     [!code-csharp[htPublishMetadataCode#1](../../../../samples/snippets/csharp/VS_Snippets_CFX/htpublishmetadatacode/cs/program.cs#1)]
     [!code-vb[htPublishMetadataCode#1](../../../../samples/snippets/visualbasic/VS_Snippets_CFX/htpublishmetadatacode/vb/program.vb#1)]  
  
2. Создайте блок try сразу же после кода для шага 1, который перехватывает любые исключения, возникающие во время работы службы.  
  
     [!code-csharp[htPublishMetadataCode#2](../../../../samples/snippets/csharp/VS_Snippets_CFX/htpublishmetadatacode/cs/program.cs#2)]
     [!code-vb[htPublishMetadataCode#2](../../../../samples/snippets/visualbasic/VS_Snippets_CFX/htpublishmetadatacode/vb/program.vb#2)]  
  
     [!code-csharp[htPublishMetadataCode#3](../../../../samples/snippets/csharp/VS_Snippets_CFX/htpublishmetadatacode/cs/program.cs#3)]
     [!code-vb[htPublishMetadataCode#3](../../../../samples/snippets/visualbasic/VS_Snippets_CFX/htpublishmetadatacode/vb/program.vb#3)]  
  
3. Проверьте, не содержит ли ведущее приложение службы <xref:System.ServiceModel.Description.ServiceMetadataBehavior>; если не содержит, создайте новый экземпляр <xref:System.ServiceModel.Description.ServiceMetadataBehavior>.  
  
     [!code-csharp[htPublishMetadataCode#4](../../../../samples/snippets/csharp/VS_Snippets_CFX/htpublishmetadatacode/cs/program.cs#4)]
     [!code-vb[htPublishMetadataCode#4](../../../../samples/snippets/visualbasic/VS_Snippets_CFX/htpublishmetadatacode/vb/program.vb#4)]  
  
4. Задайте свойству <xref:System.ServiceModel.Description.ServiceMetadataBehavior.HttpGetEnabled%2A> значение `true.`  
  
     [!code-csharp[htPublishMetadataCode#5](../../../../samples/snippets/csharp/VS_Snippets_CFX/htpublishmetadatacode/cs/program.cs#5)]
     [!code-vb[htPublishMetadataCode#5](../../../../samples/snippets/visualbasic/VS_Snippets_CFX/htpublishmetadatacode/vb/program.vb#5)]  
  
5. <xref:System.ServiceModel.Description.ServiceMetadataBehavior> содержит свойство <xref:System.ServiceModel.Description.MetadataExporter>. <xref:System.ServiceModel.Description.MetadataExporter> содержит свойство <xref:System.ServiceModel.Description.MetadataExporter.PolicyVersion%2A>. Задайте для свойства <xref:System.ServiceModel.Description.MetadataExporter.PolicyVersion%2A> значение <xref:System.ServiceModel.Description.PolicyVersion.Policy15%2A>. Свойству <xref:System.ServiceModel.Description.MetadataExporter.PolicyVersion%2A> можно также присвоить значение <xref:System.ServiceModel.Description.PolicyVersion.Policy12%2A>. Если задано <xref:System.ServiceModel.Description.PolicyVersion.Policy15%2A> средство экспорта метаданных, создает сведения о политике с метаданными, которые соответствует WS-Policy 1,5. Если задано значение <xref:System.ServiceModel.Description.PolicyVersion.Policy12%2A>, модуль экспорта метаданных генерирует информацию о политике, соответствующую спецификации WS-Policy 1.2.  
  
     [!code-csharp[htPublishMetadataCode#6](../../../../samples/snippets/csharp/VS_Snippets_CFX/htpublishmetadatacode/cs/program.cs#6)]
     [!code-vb[htPublishMetadataCode#6](../../../../samples/snippets/visualbasic/VS_Snippets_CFX/htpublishmetadatacode/vb/program.vb#6)]  
  
6. Добавьте экземпляр <xref:System.ServiceModel.Description.ServiceMetadataBehavior> в коллекцию поведений ведущего приложения службы.  
  
     [!code-csharp[htPublishMetadataCode#7](../../../../samples/snippets/csharp/VS_Snippets_CFX/htpublishmetadatacode/cs/program.cs#7)]
     [!code-vb[htPublishMetadataCode#7](../../../../samples/snippets/visualbasic/VS_Snippets_CFX/htpublishmetadatacode/vb/program.vb#7)]  
  
7. Добавьте конечную точку обмена метаданными в ведущее приложение службы.  
  
     [!code-csharp[htPublishMetadataCode#8](../../../../samples/snippets/csharp/VS_Snippets_CFX/htpublishmetadatacode/cs/program.cs#8)]
     [!code-vb[htPublishMetadataCode#8](../../../../samples/snippets/visualbasic/VS_Snippets_CFX/htpublishmetadatacode/vb/program.vb#8)]  
  
8. Добавьте конечную точку приложения в ведущее приложение службы.  
  
     [!code-csharp[htPublishMetadataCode#9](../../../../samples/snippets/csharp/VS_Snippets_CFX/htpublishmetadatacode/cs/program.cs#9)]
     [!code-vb[htPublishMetadataCode#9](../../../../samples/snippets/visualbasic/VS_Snippets_CFX/htpublishmetadatacode/vb/program.vb#9)]  
  
    > [!NOTE]
    > Если в службу не добавлена ни одна конечная точка, то среда выполнения добавляет конечные точки по умолчанию. В этом примере, поскольку параметр <xref:System.ServiceModel.Description.ServiceMetadataBehavior> установлен в значение `true`, для службы включена публикация метаданных. Дополнительные сведения о конечных точках по умолчанию см. в разделе [упрощенная конфигурация](../simplified-configuration.md) и [упрощенная конфигурация для служб WCF](../samples/simplified-configuration-for-wcf-services.md).  
  
9. Откройте ведущее приложение службы и ожидайте входящие сообщения. Когда пользователь нажмет клавишу ВВОД, закройте ведущее приложение службы.  
  
     [!code-csharp[htPublishMetadataCode#10](../../../../samples/snippets/csharp/VS_Snippets_CFX/htpublishmetadatacode/cs/program.cs#10)]
     [!code-vb[htPublishMetadataCode#10](../../../../samples/snippets/visualbasic/VS_Snippets_CFX/htpublishmetadatacode/vb/program.vb#10)]  
  
10. Скомпилируйте и запустите консольное приложение.  
  
11. С помощью Internet Explorer перейдите к базовому адресу службы ( `http://localhost:8001/MetadataSample` в этом примере) и убедитесь, что публикация метаданных включена. Вверху веб-страницы должен отображаться заголовок «Простая служба», а сразу под ним - текст «Вы создали службу». В противном случае вверху страницы отображается сообщение "Публикация метаданных для этой службы в настоящее время отключена".  
  
## <a name="example"></a>Пример  

 В следующем примере кода показана реализация базовой службы WCF, которая публикует метаданные для службы в коде.  
  
 [!code-csharp[htPublishMetadataCode#11](../../../../samples/snippets/csharp/VS_Snippets_CFX/htpublishmetadatacode/cs/program.cs#11)]
 [!code-vb[htPublishMetadataCode#11](../../../../samples/snippets/visualbasic/VS_Snippets_CFX/htpublishmetadatacode/vb/program.vb#11)]  
  
## <a name="see-also"></a>См. также

- [Практическое руководство. Размещение службы WCF в управляемом приложении](../how-to-host-a-wcf-service-in-a-managed-application.md)
- [Резидентное размещение](../samples/self-host.md)
- [Общие сведения об архитектуре метаданных](metadata-architecture-overview.md)
- [Использование метаданных](using-metadata.md)
- [Практическое руководство. Публикация метаданных для службы с использованием файла конфигурации](how-to-publish-metadata-for-a-service-using-a-configuration-file.md)
