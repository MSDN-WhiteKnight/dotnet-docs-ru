---
description: Дополнительные сведения см. в статье как выполнить параметризованную хранимую процедуру с помощью команды EntityCommand.
title: Практическое руководство. Выполнение параметризованной хранимой процедуры с использованием EntityCommand
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
ms.assetid: 4f5639bf-bb7f-4982-bb1d-c7caa4348888
ms.openlocfilehash: a45c9a276cc33037a4d353e05d1174c9748aab82
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99650694"
---
# <a name="how-to-execute-a-parameterized-stored-procedure-using-entitycommand"></a>Практическое руководство. Выполнение параметризованной хранимой процедуры с использованием EntityCommand

В данном разделе приведен пример выполнения параметризированной хранимой процедуры при помощи команды <xref:System.Data.EntityClient.EntityCommand>.  
  
### <a name="to-run-the-code-in-this-example"></a>Выполнение кода в этом примере  
  
1. Добавьте [модель School](/previous-versions/dotnet/netframework-4.0/bb896300(v=vs.100)) в проект и настройте проект для использования Entity Framework. Дополнительные сведения см. в разделе [инструкции. Использование мастера EDM](/previous-versions/dotnet/netframework-4.0/bb738677(v=vs.100)).  
  
2. На странице кода приложения добавьте следующие инструкции `using` (`Imports` в Visual Basic):  
  
     [!code-csharp[DP EntityServices Concepts#Namespaces](../../../../../samples/snippets/csharp/VS_Snippets_Data/dp entityservices concepts/cs/source.cs#namespaces)]
     [!code-vb[DP EntityServices Concepts#Namespaces](../../../../../samples/snippets/visualbasic/VS_Snippets_Data/dp entityservices concepts/vb/source.vb#namespaces)]  
  
3. Импортируйте хранимую процедуру `GetStudentGrades` и укажите сущности `CourseGrade` в качестве типа возвращаемого значения. Сведения о том, как импортировать хранимую процедуру, см. в разделе [инструкции. Импорт хранимой процедуры](/previous-versions/dotnet/netframework-4.0/bb896231(v=vs.100)).  
  
## <a name="example"></a>Пример  

 Следующий код выполняет хранимую процедуру `GetStudentGrades`, где параметр `StudentId` является обязательным. Затем результаты считываются объектом <xref:System.Data.EntityClient.EntityDataReader>.  
  
 [!code-csharp[DP EntityServices Concepts#StoredProcWithEntityCommand](../../../../../samples/snippets/csharp/VS_Snippets_Data/dp entityservices concepts/cs/source.cs#storedprocwithentitycommand)]
 [!code-vb[DP EntityServices Concepts#StoredProcWithEntityCommand](../../../../../samples/snippets/visualbasic/VS_Snippets_Data/dp entityservices concepts/vb/source.vb#storedprocwithentitycommand)]  
  
## <a name="see-also"></a>См. также

- [Поставщик EntityClient для Entity Framework](entityclient-provider-for-the-entity-framework.md)
