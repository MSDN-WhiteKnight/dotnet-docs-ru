---
description: Дополнительные сведения о том, как создать службу с помощью интерфейса контракта.
title: Практическое руководство. Создание службы с помощью интерфейса контракта
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
ms.assetid: 7b6803f6-d6f9-4cc2-9f1b-6f4c920475d5
ms.openlocfilehash: 5080f6bb45030811b87f952fb62a74801bc1ef88
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99793835"
---
# <a name="how-to-create-a-service-with-a-contract-interface"></a>Практическое руководство. Создание службы с помощью интерфейса контракта

Предпочтительный способ создания контракта Windows Communication Foundation (WCF) — использование интерфейса. Такой контракт определяет набор и структуру сообщений, необходимых для доступа к операциям, предлагаемым службой. Этот интерфейс определяет типы входных и выходных данных путем применения класса <xref:System.ServiceModel.ServiceContractAttribute> к интерфейсу и класса <xref:System.ServiceModel.OperationContractAttribute> к методам, которые требуется предоставить.  
  
 Дополнительные сведения о контрактах служб см. в разделе [Разработка контрактов служб](../designing-service-contracts.md).  
  
### <a name="creating-a-wcf-contract-with-an-interface"></a>Создание контракта WCF с интерфейсом  
  
1. Создайте новый интерфейс, используя Visual Basic, C# или любой другой язык среды CLR.  
  
2. Примените класс <xref:System.ServiceModel.ServiceContractAttribute> к интерфейсу.  
  
3. Определите методы интерфейса.  
  
4. Примените <xref:System.ServiceModel.OperationContractAttribute> класс к каждому методу, который должен быть предоставлен как часть общедоступного контракта WCF.  
  
## <a name="example"></a>Пример  

 В следующем примере кода показан интерфейс, определяющий контракт службы.  
  
 [!code-csharp[c_HowTo_CreateContractWithInterface#1](../../../../samples/snippets/csharp/VS_Snippets_CFX/c_howto_createcontractwithinterface/cs/source.cs#1)]
 [!code-vb[c_HowTo_CreateContractWithInterface#1](../../../../samples/snippets/visualbasic/VS_Snippets_CFX/c_howto_createcontractwithinterface/vb/source.vb#1)]  
  
 Методы, к которым применен класс <xref:System.ServiceModel.OperationContractAttribute>, по умолчанию используют шаблон обмена сообщениями «запрос-ответ». Дополнительные сведения об этом шаблоне сообщений см. [в разделе инструкции. создание Request-Reply контракта](how-to-create-a-request-reply-contract.md). Кроме того, можно создать и использовать другие шаблоны сообщений путем задания свойств атрибута. Дополнительные примеры см. в разделе [как создать One-Wayный контракт](how-to-create-a-one-way-contract.md) и [как создать дуплексный контракт](how-to-create-a-duplex-contract.md).  
  
## <a name="see-also"></a>См. также

- <xref:System.ServiceModel.ServiceContractAttribute>
- <xref:System.ServiceModel.OperationContractAttribute>
