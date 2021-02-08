---
description: 'Дополнительные сведения: IMetaDataEmit::D метод Ефинепинвокемап'
title: Метод IMetaDataEmit::DefinePinvokeMap
ms.date: 03/30/2017
api_name:
- IMetaDataEmit.DefinePinvokeMap
api_location:
- mscoree.dll
api_type:
- COM
f1_keywords:
- IMetaDataEmit::DefinePinvokeMap
helpviewer_keywords:
- DefinePinvokeMap method [.NET Framework metadata]
- IMetaDataEmit::DefinePinvokeMap method [.NET Framework metadata]
ms.assetid: 03abf921-5154-4070-88fa-10b7092901fb
topic_type:
- apiref
ms.openlocfilehash: 7b0477ca603241e773a67f335da579daa2ed3d30
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99784071"
---
# <a name="imetadataemitdefinepinvokemap-method"></a>Метод IMetaDataEmit::DefinePinvokeMap

Задает функции сигнатуры PInvoke метода, на который ссылается указанный токен.  
  
## <a name="syntax"></a>Синтаксис  
  
```cpp  
HRESULT DefinePinvokeMap (
    [in]  mdToken            tk,
    [in]  DWORD              dwMappingFlags,
    [in]  LPCWSTR            szImportName,
    [in]  mdModuleRef        mrImportDLL
);  
```  
  
## <a name="parameters"></a>Параметры  

 `tk`  
 окне Токен для целевого метода.  
  
 `dwMappingFlags`  
 окне Флаги, используемые PInvoke для сопоставления.  
  
 `szImportName`  
 окне Имя целевого метода экспорта в неуправляемой библиотеке DLL.  
  
 `mrImportDLL`  
 окне Токен для собственной DLL-библиотеки целевого объекта.  
  
## <a name="requirements"></a>Требования  

 **Платформы:** см. раздел [Требования к системе](../../get-started/system-requirements.md).  
  
 **Заголовок:** COR. h  
  
 **Библиотека:** Используется в качестве ресурса в MSCorEE.dll  
  
 **Платформа .NET Framework версии:**[!INCLUDE[net_current_v10plus](../../../../includes/net-current-v10plus-md.md)]  
  
## <a name="see-also"></a>См. также

- [Интерфейс IMetaDataEmit](imetadataemit-interface.md)
- [Интерфейс IMetaDataEmit2](imetadataemit2-interface.md)
