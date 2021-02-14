---
description: 'Дополнительные сведения о: интерфейс Иенумреференцеидентити'
title: Интерфейс IEnumReferenceIdentity
ms.date: 03/30/2017
api_name:
- IEnumReferenceIdentity
api_location:
- fusion.dll
api_type:
- COM
f1_keywords:
- IEnumReferenceIdentity
helpviewer_keywords:
- IEnumReferenceIdentity interface [.NET Framework fusion]
ms.assetid: a17b3155-7216-4e16-8c9f-abce21f549e7
topic_type:
- apiref
ms.openlocfilehash: a7f17793fd737b5153c27dae59fb2aa87b46cf48
ms.sourcegitcommit: 10e719780594efc781b15295e499c66f316068b8
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/14/2021
ms.locfileid: "100465305"
---
# <a name="ienumreferenceidentity-interface"></a>Интерфейс IEnumReferenceIdentity

Служит в качестве перечислителя для коллекции `IReferenceIdentity` объектов.  
  
## <a name="methods"></a>Методы  
  
|Метод|Описание|  
|------------|-----------------|  
|`IEnumReferenceIdentity::Clone`|Возвращает указатель интерфейса на новый объект `IEnumReferenceIdentity` , содержащий те же элементы, что и этот объект `IEnumReferenceIdentity` .|  
|`IEnumReferenceIdentity::Next`|Возвращает указанное число `IReferenceIdentity` объектов, начиная с текущей позиции.|  
|`IEnumReferenceIdentity::Reset`|Перемещает указатель инструкций в начало `IEnumReferenceIdentity` .|  
|`IEnumReferenceIdentity::Skip`|Перемещает указатель инструкции вперед на указанное число элементов, начиная с текущей позиции.|  
  
## <a name="requirements"></a>Требования  

 **Платформы:** см. раздел [Требования к системе](../../get-started/system-requirements.md).  
  
 **Заголовок:** Изоляция. h  
  
 **Платформа .NET Framework версии:**[!INCLUDE[net_current_v20plus](../../../../includes/net-current-v20plus-md.md)]  
  
## <a name="see-also"></a>См. также раздел

- [Fusion-интерфейсы](fusion-interfaces.md)
- [Интерфейс IReferenceIdentity](ireferenceidentity-interface.md)
