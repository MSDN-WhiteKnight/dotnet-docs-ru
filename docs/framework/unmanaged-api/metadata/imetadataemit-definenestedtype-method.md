---
description: 'Дополнительные сведения: IMetaDataEmit::D метод Ефиненестедтипе'
title: Метод IMetaDataEmit::DefineNestedType
ms.date: 03/30/2017
api_name:
- IMetaDataEmit.DefineNestedType
api_location:
- mscoree.dll
api_type:
- COM
f1_keywords:
- IMetaDataEmit::DefineNestedType
helpviewer_keywords:
- IMetaDataEmit::DefineNestedType method [.NET Framework metadata]
- DefineNestedType method [.NET Framework metadata]
ms.assetid: 1e994de6-4628-459c-b967-b34be1e9fe4f
topic_type:
- apiref
ms.openlocfilehash: 1b0c5c8d1bffa425b2019a4434042c84a0069907
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99753384"
---
# <a name="imetadataemitdefinenestedtype-method"></a>Метод IMetaDataEmit::DefineNestedType

Создает сигнатуру метаданных определения типа, возвращает `mdTypeDef` маркер для этого типа и указывает, что определенный тип является членом типа, на который ссылается `tdEncloser` параметр.  
  
## <a name="syntax"></a>Синтаксис  
  
```cpp  
HRESULT DefineNestedType (
    [in]  LPCWSTR     szTypeDef,  
    [in]  DWORD       dwTypeDefFlags,
    [in]  mdToken     tkExtends,
    [in]  mdToken     rtkImplements[],
    [in]  mdTypeDef   tdEncloser,
    [out] mdTypeDef   *ptd  
);  
```  
  
## <a name="parameters"></a>Параметры  

 `szTypeDef`  
 окне Имя типа в Юникоде.  
  
 `dwTypeDefFlags`  
 [входные] `TypeDef` атрибута. Это битовая маска `CorTypeAttr` значений.  
  
 `tkExtends`  
 окне Маркер базового класса. Это либо маркер, либо `mdTypeDef` `mdTypeRef` .  
  
 `rtkImplements`[]  
 окне Массив токенов, задающих интерфейсы, реализуемые этим классом или интерфейсом.  
  
 `tdEncloser`  
 окне Токен включающего типа. Последний элемент массива должен быть `mdTokenNil` .  
  
 `ptd`  
 заполняет `mdTypeDef` Назначенный маркер.  
  
## <a name="requirements"></a>Требования  

 **Платформы:** см. раздел [Требования к системе](../../get-started/system-requirements.md).  
  
 **Заголовок:** COR. h  
  
 **Библиотека:** Используется в качестве ресурса в MSCorEE.dll  
  
 **Платформа .NET Framework версии:**[!INCLUDE[net_current_v10plus](../../../../includes/net-current-v10plus-md.md)]  
  
## <a name="see-also"></a>См. также

- [Интерфейс IMetaDataEmit](imetadataemit-interface.md)
- [Интерфейс IMetaDataEmit2](imetadataemit2-interface.md)
