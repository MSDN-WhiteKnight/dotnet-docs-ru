---
description: Дополнительные сведения о методах System. Object
title: Методы System.Object
ms.date: 03/30/2017
ms.assetid: 5397fca0-689e-443e-802f-e1cbdc866427
ms.openlocfilehash: 88ba4cf7cfc7dc9bea565b4689f77d088d424c44
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99681322"
---
# <a name="systemobject-methods"></a>Методы System.Object

[!INCLUDE[vbtecdlinq](../../../../../../includes/vbtecdlinq-md.md)] поддерживает следующие <xref:System.Object> методы.  
  
|||  
|-|-|  
|<xref:System.Object.Equals%28System.Object%29?displayProperty=nameWithType>|<xref:System.Object.Equals%28System.Object%2CSystem.Object%29?displayProperty=nameWithType>|  
|<xref:System.Object.ToString?displayProperty=nameWithType>||  
  
 [!INCLUDE[vbtecdlinq](../../../../../../includes/vbtecdlinq-md.md)] не поддерживает следующие методы <xref:System.Object>.  
  
|||  
|-|-|  
|<xref:System.Object.GetHashCode?displayProperty=nameWithType>|<xref:System.Object.ReferenceEquals%28System.Object%2CSystem.Object%29?displayProperty=nameWithType>|  
|<xref:System.Object.MemberwiseClone?displayProperty=nameWithType>|<xref:System.Object.GetType?displayProperty=nameWithType>|  
|<xref:System.Object.ToString?displayProperty=nameWithType> для двоичных типов, таких как `BINARY`, `VARBINARY`, `IMAGE` и `TIMESTAMP`.||  
  
## <a name="differences-from-net"></a>Отличия от платформы .NET  

 Выходные данные <xref:System.Object.ToString?displayProperty=nameWithType> для типа Double используют SQL `CONVERT` (nvarchar (30), @x , 2) в SQL. В этом случае SQL всегда использует 16 цифр и экспоненциальный формат (например, «0.000000000000000e+000» для 0). В результате преобразование <xref:System.Object.ToString?displayProperty=nameWithType> формирует строку, отличную от строки преобразования <xref:System.Convert.ToString%2A?displayProperty=nameWithType> на платформе .NET Framework.  
  
## <a name="see-also"></a>См. также

- [Типы данных и функции](data-types-and-functions.md)
