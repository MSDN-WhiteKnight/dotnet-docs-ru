---
description: 'Дополнительные сведения: Добавление, изменение и удаление сущностей (службы данных WCF)'
title: Практическое руководство. Добавление, изменение и удаление сущностей (службы данных WCF)
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- WCF Data Services, changing data
ms.assetid: a00f8933-b232-4445-95ba-adc634f055d8
ms.openlocfilehash: 300ec4d710b376979b77c02b2831bb6b64393709
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99765741"
---
# <a name="how-to-add-modify-and-delete-entities-wcf-data-services"></a>Практическое руководство. Добавление, изменение и удаление сущностей (службы данных WCF)

[!INCLUDE [wcf-deprecated](~/includes/wcf-deprecated.md)]

С помощью клиентских библиотек службы данных WCF можно создавать, обновлять и удалять данные сущностей в службе данных, выполняя эквивалентные действия с объектами в <xref:System.Data.Services.Client.DataServiceContext> . Дополнительные сведения см. [в разделе Обновление службы данных](updating-the-data-service-wcf-data-services.md).  
  
 Пример в этом разделе использует образец службы данных Northwind и автоматически сформированные клиентские классы службы данных. Эта служба и классы данных клиента создаются при завершении [краткого руководства по службы данных WCF](quickstart-wcf-data-services.md).  
  
## <a name="example"></a>Пример  

 В следующем примере создается новый экземпляр объекта и вызывается метод <xref:System.Data.Services.Client.DataServiceContext.AddObject%2A> контекста <xref:System.Data.Services.Client.DataServiceContext> для создания в контексте нового элемента. Сообщение HTTP POST отправляется в службу данных при вызове метода <xref:System.Data.Services.Client.DataServiceContext.SaveChanges%2A>.  
  
 [!code-csharp[Astoria Northwind Client#AddProduct](../../../../samples/snippets/csharp/VS_Snippets_Misc/astoria_northwind_client/cs/source.cs#addproduct)]
 [!code-vb[Astoria Northwind Client#AddProduct](../../../../samples/snippets/visualbasic/VS_Snippets_Misc/astoria_northwind_client/vb/source.vb#addproduct)]  
  
## <a name="example"></a>Пример  

 Следующий пример извлекает и модифицирует существующий объект, после чего вызывает метод <xref:System.Data.Services.Client.DataServiceContext.UpdateObject%2A> в контексте <xref:System.Data.Services.Client.DataServiceContext>, чтобы пометить элемент контекста как обновленный. Сообщение HTTP MERGE отправляется в службу данных при вызове метода <xref:System.Data.Services.Client.DataServiceContext.SaveChanges%2A>.  
  
 [!code-csharp[Astoria Northwind Client#ModifyCustomer](../../../../samples/snippets/csharp/VS_Snippets_Misc/astoria_northwind_client/cs/source.cs#modifycustomer)]
 [!code-vb[Astoria Northwind Client#ModifyCustomer](../../../../samples/snippets/visualbasic/VS_Snippets_Misc/astoria_northwind_client/vb/source.vb#modifycustomer)]  
  
## <a name="example"></a>Пример  

 Следующий пример вызывает метод <xref:System.Data.Services.Client.DataServiceContext.DeleteObject%2A> объекта <xref:System.Data.Services.Client.DataServiceContext> для пометки элемента контекста как удаленного. Сообщение HTTP DELETE отправляется в службу данных при вызове метода <xref:System.Data.Services.Client.DataServiceContext.SaveChanges%2A>.  
  
 [!code-csharp[Astoria Northwind Client#DeleteProduct](../../../../samples/snippets/csharp/VS_Snippets_Misc/astoria_northwind_client/cs/source.cs#deleteproduct)]
 [!code-vb[Astoria Northwind Client#DeleteProduct](../../../../samples/snippets/visualbasic/VS_Snippets_Misc/astoria_northwind_client/vb/source.vb#deleteproduct)]  
  
## <a name="example"></a>Пример  

 В следующем примере создается новый экземпляр объекта и вызывается метод <xref:System.Data.Services.Client.DataServiceContext.AddRelatedObject%2A> контекста <xref:System.Data.Services.Client.DataServiceContext> для создания в контексте нового элемента и ссылки на связанный с ним заказ. Сообщение HTTP POST отправляется в службу данных при вызове метода <xref:System.Data.Services.Client.DataServiceContext.SaveChanges%2A>.  
  
 [!code-csharp[Astoria Northwind Client#AddOrderDetailToOrderAuto](../../../../samples/snippets/csharp/VS_Snippets_Misc/astoria_northwind_client/cs/source.cs#addorderdetailtoorderauto)]
 [!code-vb[Astoria Northwind Client#AddOrderDetailToOrderAuto](../../../../samples/snippets/visualbasic/VS_Snippets_Misc/astoria_northwind_client/vb/source.vb#addorderdetailtoorderauto)]  
  
## <a name="see-also"></a>См. также

- [Библиотека клиентов служб данных WCF](wcf-data-services-client-library.md)
- [Практическое руководство. Присоединение существующей сущности к контексту DataServiceContext](attach-an-existing-entity-to-dc-wcf-data.md)
- [Практическое руководство. Определение связей сущностей](how-to-define-entity-relationships-wcf-data-services.md)
- [Пакетные операции](batching-operations-wcf-data-services.md)
