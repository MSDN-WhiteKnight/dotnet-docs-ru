---
description: 'Дополнительные сведения: Настройка операций с монопольным использованием хранимых процедур'
title: Настройка операций за счет исключительного использования хранимых процедур
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
ms.assetid: 441e8ef3-998c-4d12-8825-ce66a178f90f
ms.openlocfilehash: 4ddcc6b4face1abccb502e12617105a734bb5f0b
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99729553"
---
# <a name="customizing-operations-by-using-stored-procedures-exclusively"></a>Настройка операций за счет исключительного использования хранимых процедур

Распространенным сценарием является доступ к данным с использованием только хранимых процедур.  
  
## <a name="example"></a>Пример  
  
### <a name="description"></a>Описание  

 Вы можете изменить пример, предоставленный в разделе [Настройка операций, используя хранимые процедуры](customizing-operations-by-using-stored-procedures.md) , заменив даже первый запрос (который вызывает динамическое выполнение SQL) вызовом метода, который создает оболочку для хранимой процедуры.  
  
 Предположим, что `CustomersByCity` является методом, как в следующем примере.  
  
### <a name="code"></a>Код  

 [!code-csharp[DLinqOverrideDefaultSproc#4](../../../../../../samples/snippets/csharp/VS_Snippets_Data/DLinqOverrideDefaultSproc/cs/northwind.cs#4)]
 [!code-vb[DLinqOverrideDefaultSproc#4](../../../../../../samples/snippets/visualbasic/VS_Snippets_Data/DLinqOverrideDefaultSproc/vb/northwind.vb#4)]  
  
 Следующий код выполняется без динамического SQL.  
  
 [!code-csharp[DLinqOverrideDefaultSproc#5](../../../../../../samples/snippets/csharp/VS_Snippets_Data/DLinqOverrideDefaultSproc/cs/Program.cs#5)]
 [!code-vb[DLinqOverrideDefaultSproc#5](../../../../../../samples/snippets/visualbasic/VS_Snippets_Data/DLinqOverrideDefaultSproc/vb/Module1.vb#5)]  
  
## <a name="see-also"></a>См. также

- [Ответственность разработчика при переопределении поведения по умолчанию](responsibilities-of-the-developer-in-overriding-default-behavior.md)
