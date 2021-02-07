---
description: 'Дополнительные сведения о методе: IMetaDataImport2:: EnumGenericParams'
title: Метод IMetaDataImport2::EnumGenericParams
ms.date: 03/30/2017
api_name:
- IMetaDataImport2.EnumGenericParams
api_location:
- mscoree.dll
api_type:
- COM
f1_keywords:
- IMetaDataImport2::EnumGenericParams
helpviewer_keywords:
- EnumGenericParams method [.NET Framework metadata]
- IMetaDataImport2::EnumGenericParams method [.NET Framework metadata]
ms.assetid: b50488a5-3cf0-483c-82dc-2892a3ec61ac
topic_type:
- apiref
ms.openlocfilehash: 9d4e9d163da07ec4a3af1aa628b8b6ec4b2338fe
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99720947"
---
# <a name="imetadataimport2enumgenericparams-method"></a>Метод IMetaDataImport2::EnumGenericParams

Возвращает перечислитель для массива маркеров универсальных параметров, связанных с указанным маркером TypeDef или MethodDef.  
  
## <a name="syntax"></a>Синтаксис  
  
```cpp
HRESULT EnumGenericParams (  
   [in, out] HCORENUM     *phEnum,
   [in]  mdToken          tk,  
   [out] mdGenericParam   rGenericParams[],
   [in]  ULONG            cMax,
   [out] ULONG            *pcGenericParams  
);  
```  
  
## <a name="parameters"></a>Параметры  

 `phEnum`  
 [вход, выход] Указатель на перечислитель.  
  
 `tk`  
 окне Маркер TypeDef или MethodDef, универсальные параметры которого необходимо перечислить.  
  
 `rGenericParams`  
 заполняет Массив универсальных параметров для перечисления.  
  
 `cMax`  
 окне Запрошенное максимальное число токенов для размещения в `rGenericParams` .  
  
 `pcGenericParams`  
 заполняет Возвращенное число токенов, помещенных в `rGenericParams` .  
  
## <a name="return-value"></a>Возвращаемое значение  
  
|HRESULT|Описание|  
|-------------|-----------------|  
|`S_OK`|`EnumGenericParams` успешно возвращено.|  
|`S_FALSE`|`phEnum` не содержит элементов Member. В этом случае `pcGenericParams` имеет значение 0 (ноль).|  
  
## <a name="requirements"></a>Требования  

 **Платформы:** см. раздел [Требования к системе](../../get-started/system-requirements.md).  
  
 **Заголовок:** COR. h  
  
 **Библиотека:** Используется в качестве ресурса в MsCorEE.dll  
  
 **Платформа .NET Framework версии:**[!INCLUDE[net_current_v20plus](../../../../includes/net-current-v20plus-md.md)]  
  
## <a name="see-also"></a>См. также

- [Интерфейс IMetaDataImport2](imetadataimport2-interface.md)
- [Интерфейс IMetaDataImport](imetadataimport-interface.md)
