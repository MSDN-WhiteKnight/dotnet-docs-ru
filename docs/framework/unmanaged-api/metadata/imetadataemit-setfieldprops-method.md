---
description: 'Дополнительные сведения: Метод IMetaDataEmit:: SetFieldProps'
title: Метод IMetaDataEmit::SetFieldProps
ms.date: 03/30/2017
api_name:
- IMetaDataEmit.SetFieldProps
api_location:
- mscoree.dll
api_type:
- COM
f1_keywords:
- IMetaDataEmit::SetFieldProps
helpviewer_keywords:
- IMetaDataEmit::SetFieldProps method [.NET Framework metadata]
- SetFieldProps method [.NET Framework metadata]
ms.assetid: 47132dda-fa92-4bd1-ae4b-24cd9a60665a
topic_type:
- apiref
ms.openlocfilehash: ee9964077e556a1d0666a836ca0c3bab92540252
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99658013"
---
# <a name="imetadataemitsetfieldprops-method"></a>Метод IMetaDataEmit::SetFieldProps

Задает или обновляет значение по умолчанию для поля, на которое ссылается заданный токен поля.  
  
## <a name="syntax"></a>Синтаксис  
  
```cpp  
HRESULT SetFieldProps (  
    [in]  mdFieldDef  fd,
    [in]  DWORD       dwFieldFlags,
    [in]  DWORD       dwCPlusTypeFlag,
    [in]  void const  *pValue,
    [in]  ULONG       cchValue
);  
```  
  
## <a name="parameters"></a>Параметры  

 `fd`  
 окне Токен для целевого поля.  
  
 `dwFieldFlags`  
 окне Атрибуты поля. Это битовая маска `CorFieldAttr` значений.  
  
 `dwCPlusTypeFlag`  
 окне `ELEMENT_TYPE_` *\** Значение для постоянного значения. Это `CorElementType` значение. Если константа не определена, присвойте этому параметру значение `ELEMENT_TYPE_END` .  
  
 `pValue`  
 окне Постоянное значение для поля.  
  
 `cchValue`  
 окне Размер (в символах Юникода) `pValue` .  
  
## <a name="requirements"></a>Требования  

 **Платформы:** см. раздел [Требования к системе](../../get-started/system-requirements.md).  
  
 **Заголовок:** COR. h  
  
 **Библиотека:** Используется в качестве ресурса в MSCorEE.dll  
  
 **Платформа .NET Framework версии:**[!INCLUDE[net_current_v10plus](../../../../includes/net-current-v10plus-md.md)]  
  
## <a name="see-also"></a>См. также

- [Интерфейс IMetaDataEmit](imetadataemit-interface.md)
- [Интерфейс IMetaDataEmit2](imetadataemit2-interface.md)
