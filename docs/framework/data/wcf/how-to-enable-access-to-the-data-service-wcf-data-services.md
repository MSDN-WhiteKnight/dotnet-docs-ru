---
description: Дополнительные сведения см. в статье Включение доступа к службе данных (службы данных WCF).
title: Как включить доступ к службе данных (службы WCF Data Services)
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- WCF Data Services, configuring
ms.assetid: 3d830bcd-32b4-4f26-9287-d58a071452c6
ms.openlocfilehash: 42be9c4c31da7bbbfef07958deef685d52df597b
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99765429"
---
# <a name="how-to-enable-access-to-the-data-service-wcf-data-services"></a>Как включить доступ к службе данных (службы WCF Data Services)

[!INCLUDE [wcf-deprecated](~/includes/wcf-deprecated.md)]

В службы данных WCF необходимо явно предоставить доступ к ресурсам, предоставляемым службой данных. Это значит, что после создания новой службы данных все равно требуется явно предоставлять доступ к отдельным ресурсам в виде набора сущностей. В этом разделе показано, как включить доступ на чтение и запись к пяти наборам сущностей в службе данных Northwind, которая создается при завершении [краткого руководства](quickstart-wcf-data-services.md). Поскольку перечисление <xref:System.Data.Services.EntitySetRights> определяется с помощью <xref:System.FlagsAttribute>, для указания нескольких разрешений для одного набора сущностей или операции можно использовать логический оператор OR.  
  
> [!NOTE]
> Любой клиент, имеющий доступ к приложению ASP.NET, имеет также доступ к ресурсам, предоставляемым службой данных. Для предотвращения несанкционированного доступа к ресурсам производственной службы данных необходимо также установить защиту самого приложения. Дополнительные сведения см. в статье [Защита веб-сайтов ASP.NET](/previous-versions/aspnet/91f66yxt(v=vs.100)).  
  
### <a name="to-enable-access-to-the-data-service"></a>Включение доступа к службе данных  
  
- В коде службы данных замените код местозаполнителя в функции `InitializeService` следующим текстом:  
  
     [!code-csharp[Astoria Quickstart Service#AllReadConfig](../../../../samples/snippets/csharp/VS_Snippets_Misc/astoria_quickstart_service/cs/northwind.svc.cs#allreadconfig)]
     [!code-vb[Astoria Quickstart Service#AllReadConfig](../../../../samples/snippets/visualbasic/VS_Snippets_Misc/astoria_quickstart_service/vb/northwind.svc.vb#allreadconfig)]  
  
     Это обеспечивает клиентам доступ для чтения и записи к наборам сущностей `Orders` и `Order_Details` и доступ только для чтения к наборам сущностей `Customers`.  
  
## <a name="see-also"></a>См. также

- [Практическое руководство. Разработка службы данных WCF Data Service, работающей на IIS](how-to-develop-a-wcf-data-service-running-on-iis.md)
- [Настройка службы данных](configuring-the-data-service-wcf-data-services.md)
