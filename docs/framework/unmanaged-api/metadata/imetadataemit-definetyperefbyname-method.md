---
description: 'Дополнительные сведения: IMetaDataEmit::D метод Ефинетиперефбинаме'
title: Метод IMetaDataEmit::DefineTypeRefByName
ms.date: 03/30/2017
api_name:
- IMetaDataEmit.DefineTypeRefByName
api_location:
- mscoree.dll
api_type:
- COM
f1_keywords:
- IMetaDataEmit::DefineTypeRefByName
helpviewer_keywords:
- DefineTypeRefByName method [.NET Framework metadata]
- IMetaDataEmit::DefineTypeRefByName method [.NET Framework metadata]
ms.assetid: c30a4ce3-2d3e-411a-98df-e62ac4a5dd50
topic_type:
- apiref
ms.openlocfilehash: 836516e06105bb8ebc7c9bacf7b7d3837bf89eec
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99784019"
---
# <a name="imetadataemitdefinetyperefbyname-method"></a>Метод IMetaDataEmit::DefineTypeRefByName

Возвращает токен метаданных для типа, определенного в заданной области, которая находится за пределами текущей области.  
  
## <a name="syntax"></a>Синтаксис  
  
```cpp  
HRESULT DefineTypeRefByName (
    [in]  mdToken     tkResolutionScope,
    [in]  LPCWSTR     szName,
    [out] mdTypeRef   *ptr
);  
```  
  
## <a name="parameters"></a>Параметры  

 `tkResolutionScope`  
 окне Токен, указывающий область разрешения. Допустимы следующие типы токенов:  
  
- `mdModuleRef`значение, если тип определен в той же сборке, в которой определен вызывающий объект.  
  
- `mdAssemblyRef`значение, если тип определен в сборке, отличной от той, в которой определен вызывающий объект.  
  
- `mdTypeRef`, если тип является вложенным типом.  
  
- `mdModule`, если тип определен в том же модуле, в котором определен вызывающий объект.  
  
- Значение null, если тип определен глобально.  
  
 `szName`  
 окне Имя типа целевого объекта в Юникоде.  
  
 `ptr`  
 заполняет Указатель на `mdTypeRef` токен, назначенный типу.  
  
## <a name="requirements"></a>Требования  

 **Платформы:** см. раздел [Требования к системе](../../get-started/system-requirements.md).  
  
 **Заголовок:** COR. h  
  
 **Библиотека:** Используется в качестве ресурса в MSCorEE.dll  
  
 **Платформа .NET Framework версии:**[!INCLUDE[net_current_v10plus](../../../../includes/net-current-v10plus-md.md)]  
  
## <a name="see-also"></a>См. также

- [Интерфейс IMetaDataEmit](imetadataemit-interface.md)
- [Интерфейс IMetaDataEmit2](imetadataemit2-interface.md)
