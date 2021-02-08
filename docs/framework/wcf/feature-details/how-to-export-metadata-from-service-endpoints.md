---
description: Дополнительные сведения см. в статье как экспортировать метаданные из конечных точек службы.
title: Практическое руководство. Экспорт метаданных из конечных точек службы
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
ms.assetid: b6c4dfd0-f270-43ec-961a-e16eb6af2f2c
ms.openlocfilehash: f690d2dc0bd3ac0f89e527412a63ce0967daa8f6
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99802883"
---
# <a name="how-to-export-metadata-from-service-endpoints"></a>Практическое руководство. Экспорт метаданных из конечных точек службы

В этом разделе объясняется, как экспортировать метаданные из конечных точек службы.  
  
### <a name="to-export-metadata-from-service-endpoints"></a>Экспорт метаданных из конечных точек службы  
  
1. Создайте новый проект "Консольное приложение" в Visual Studio. Добавьте в созданный внутри метода main() файл Program.cs приведенный в описании следующих шагов код.  
  
2. Создайте таблицу <xref:System.ServiceModel.Description.WsdlExporter>.  
  
     [!code-csharp[S_UEWsdlExporter#1](../../../../samples/snippets/csharp/VS_Snippets_CFX/s_uewsdlexporter/cs/program.cs#1)]
     [!code-vb[S_UEWsdlExporter#1](../../../../samples/snippets/visualbasic/VS_Snippets_CFX/s_uewsdlexporter/vb/program.vb#1)]  
  
3. Присвойте свойству <xref:System.ServiceModel.Description.MetadataExporter.PolicyVersion%2A> одно из значений из перечисления <xref:System.ServiceModel.Description.PolicyVersion>. В этом примере свойству задается значение <xref:System.ServiceModel.Description.PolicyVersion.Policy15%2A>, что соответствует WS-Policy 1.5.  
  
     [!code-csharp[S_UEWsdlExporter#2](../../../../samples/snippets/csharp/VS_Snippets_CFX/s_uewsdlexporter/cs/program.cs#2)]
     [!code-vb[S_UEWsdlExporter#2](../../../../samples/snippets/visualbasic/VS_Snippets_CFX/s_uewsdlexporter/vb/program.vb#2)]  
  
4. Создайте массив объектов <xref:System.ServiceModel.Description.ServiceEndpoint>.  
  
     [!code-csharp[S_UEWsdlExporter#3](../../../../samples/snippets/csharp/VS_Snippets_CFX/s_uewsdlexporter/cs/program.cs#3)]
     [!code-vb[S_UEWsdlExporter#3](../../../../samples/snippets/visualbasic/VS_Snippets_CFX/s_uewsdlexporter/vb/program.vb#3)]  
  
5. Экспортируйте метаданные для каждой конечной точки службы.  
  
     [!code-csharp[S_UEWsdlExporter#4](../../../../samples/snippets/csharp/VS_Snippets_CFX/s_uewsdlexporter/cs/program.cs#4)]
     [!code-vb[S_UEWsdlExporter#4](../../../../samples/snippets/visualbasic/VS_Snippets_CFX/s_uewsdlexporter/vb/program.vb#4)]  
  
6. Убедитесь, что в процессе экспорта не произошло ошибок, и извлеките метаданные.  
  
     [!code-csharp[S_UEWsdlExporter#5](../../../../samples/snippets/csharp/VS_Snippets_CFX/s_uewsdlexporter/cs/program.cs#5)]
     [!code-vb[S_UEWsdlExporter#5](../../../../samples/snippets/visualbasic/VS_Snippets_CFX/s_uewsdlexporter/vb/program.vb#5)]  
  
7. После этого можно использовать метаданные, например записать их в файл, вызвав метод <xref:System.ServiceModel.Description.MetadataSet.WriteTo%28System.Xml.XmlWriter%29>.  
  
## <a name="example"></a>Пример  

 Ниже приведен полный код этого примера.  
  
 [!code-csharp[S_UEWsdlExporter#0](../../../../samples/snippets/csharp/VS_Snippets_CFX/s_uewsdlexporter/cs/program.cs#0)]
 [!code-vb[S_UEWsdlExporter#0](../../../../samples/snippets/visualbasic/VS_Snippets_CFX/s_uewsdlexporter/vb/program.vb#0)]  
  
## <a name="compiling-the-code"></a>Компиляция кода  

 При компиляции файла Program.cs необходимо сослаться на System.ServiceModel.dll.  
  
## <a name="see-also"></a>См. также

- [Общие сведения об архитектуре метаданных](metadata-architecture-overview.md)
- [Использование метаданных](using-metadata.md)
- [Конечные точки: адреса, привязки и контракты](endpoints-addresses-bindings-and-contracts.md)
