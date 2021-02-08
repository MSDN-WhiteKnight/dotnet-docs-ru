---
description: 'Дополнительные сведения: функции (Entity SQL)'
title: Функции (Entity SQL)
ms.date: 03/30/2017
ms.assetid: 52b3d776-5acc-4f69-b614-5a43ce56ef9f
ms.openlocfilehash: c557d264587a1d40194971d756e6b5c75a3856aa
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99786307"
---
# <a name="functions-entity-sql"></a>Функции (Entity SQL)

Язык Entity SQL поддерживает определяемые пользователем функции и функции поставщиков. Определяемые пользователем функции определяются в концептуальной модели либо внутри запроса. Дополнительные сведения см. в разделе [определяемые пользователем функции](user-defined-functions-entity-sql.md).  
  
 Канонические функции встроены в платформу Entity Framework и должны поддерживаться поставщиками данных. Команды Entity SQL завершатся ошибкой, если пользователь вызывает функции, которые не поддерживаются поставщиком данных. Поэтому, как правило, рекомендуется использовать канонические функции, а не функции, зависящие от хранилища и находящиеся в пространстве имен поставщика данных. Дополнительные сведения см. в разделе [канонические функции](canonical-functions.md).  
  
 Управляемый поставщик клиента Microsoft SQL предоставляет набор функций для поставщика. Дополнительные сведения см. в разделе [SqlClient для функций Entity Framework](../sqlclient-for-ef-functions.md).  
  
## <a name="in-this-section"></a>В этом разделе  

 [Определяемые пользователем функции](user-defined-functions-entity-sql.md)  
  
 [Разрешение перегрузки функций](function-overload-resolution-entity-sql.md)  
  
 [Агрегатные функции](../aggregate-functions-sqlclient-for-entity-framework.md)  
  
## <a name="see-also"></a>См. также

- [Общие сведения об Entity SQL](entity-sql-overview.md)
