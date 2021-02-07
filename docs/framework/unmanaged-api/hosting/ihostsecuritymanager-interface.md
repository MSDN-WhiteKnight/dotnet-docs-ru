---
description: 'Дополнительные сведения о: интерфейс IHostSecurityManager'
title: Интерфейс IHostSecurityManager
ms.date: 03/30/2017
api_name:
- IHostSecurityManager
api_location:
- mscoree.dll
api_type:
- COM
f1_keywords:
- IHostSecurityManager
helpviewer_keywords:
- IHostSecurityManager interface [.NET Framework hosting]
ms.assetid: c3be2cbd-2d93-438b-9888-9a0251b63c03
topic_type:
- apiref
ms.openlocfilehash: 76ba26443fa2a4e65459dd073eb6d22031548112
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99671547"
---
# <a name="ihostsecuritymanager-interface"></a>Интерфейс IHostSecurityManager

Предоставляет методы, позволяющие получить доступ к контексту безопасности выполняющегося потока и управлять им.  
  
## <a name="methods"></a>Методы  
  
|Метод|Описание|  
|------------|-----------------|  
|[Метод GetSecurityContext](ihostsecuritymanager-getsecuritycontext-method.md)|Возвращает запрошенный [IHostSecurityContext](ihostsecuritycontext-interface.md) из узла.|  
|[Метод ImpersonateLoggedOnUser](ihostsecuritymanager-impersonateloggedonuser-method.md)|Запрашивает выполнение кода с использованием учетных данных удостоверения текущего пользователя.|  
|[Метод OpenThreadToken](ihostsecuritymanager-openthreadtoken-method.md)|Открывает маркер доступа на уровне пользователей, связанный с текущим потоком.|  
|[Метод RevertToSelf](ihostsecuritymanager-reverttoself-method.md)|Завершает олицетворение текущего удостоверения пользователя и возвращает исходный маркер потока.|  
|[Метод SetSecurityContext](ihostsecuritymanager-setsecuritycontext-method.md)|Задает контекст безопасности для выполняющегося в данный момент потока.|  
|[Метод SetThreadToken](ihostsecuritymanager-setthreadtoken-method.md)|Задает обработчик для текущего выполняющегося потока.|  
  
## <a name="remarks"></a>Remarks  

 Узел может управлять доступом кода к маркерам потоков как средой CLR, так и кодом пользователя. Он также может гарантировать, что полные сведения о контексте безопасности передаются по асинхронным операциям или кодовым точкам с ограниченным доступом к коду. `IHostSecurityContext` инкапсулирует эти сведения о контексте безопасности, которые непрозрачны для среды CLR.  
  
 Среда CLR внутренне обрабатывает контекст управляемого потока. Он запрашивает особенности конкретного процесса `IHostSecurityManager` в следующих ситуациях:  
  
- В потоке метода завершения во время выполнения метода завершения.  
  
- Во время выполнения конструктора класса и модуля.  
  
- В асинхронных точках в рабочем потоке при вызове метода [IHostThreadPoolManager:: QueueUserWorkItem](ihostthreadpoolmanager-queueuserworkitem-method.md) .  
  
- При обслуживании портов завершения ввода-вывода.  
  
## <a name="requirements"></a>Требования  

 **Платформы:** см. раздел [Требования к системе](../../get-started/system-requirements.md).  
  
 **Заголовок:** MSCorEE. h  
  
 **Библиотека:** Включается в качестве ресурса в MSCorEE.dll  
  
 **Платформа .NET Framework версии:**[!INCLUDE[net_current_v20plus](../../../../includes/net-current-v20plus-md.md)]  
  
## <a name="see-also"></a>См. также

- [Интерфейс IHostSecurityContext](ihostsecuritycontext-interface.md)
- [Интерфейсы размещения](hosting-interfaces.md)
