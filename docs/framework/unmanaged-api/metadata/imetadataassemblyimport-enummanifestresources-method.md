---
description: 'Дополнительные сведения о методе: IMetaDataAssemblyImport:: Енумманифестресаурцес'
title: Метод IMetaDataAssemblyImport::EnumManifestResources
ms.date: 03/30/2017
api_name:
- IMetaDataAssemblyImport.EnumManifestResources
api_location:
- mscoree.dll
api_type:
- COM
f1_keywords:
- IMetaDataAssemblyImport::EnumManifestResources
helpviewer_keywords:
- IMetaDataAssemblyImport::EnumManifestResources method [.NET Framework metadata]
- EnumManifestResources method [.NET Framework metadata]
ms.assetid: 9543b111-5705-40c9-935c-a3ffc7a581aa
topic_type:
- apiref
ms.openlocfilehash: ff819ebb575626af6049558656637e7fabcbc322
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99677986"
---
# <a name="imetadataassemblyimportenummanifestresources-method"></a>Метод IMetaDataAssemblyImport::EnumManifestResources

Возвращает указатель на перечислитель для ресурсов, указанных в текущем манифесте сборки.  
  
## <a name="syntax"></a>Синтаксис  
  
```cpp  
HRESULT EnumManifestResources (  
    [in, out] HCORENUM         *phEnum,
    [out] mdManifestResource   rManifestResources[],
    [in]  ULONG                cMax,
    [out] ULONG                *pcTokens  
);
```  
  
## <a name="parameters"></a>Параметры  

 `phEnum`  
 [вход, выход] Указатель на перечислитель. Это значение должно быть null, если `EnumManifestResources` метод вызывается в первый раз.  
  
 `rManifestResources`  
 заполняет Массив, используемый для хранения `mdManifestResource` маркеров метаданных.  
  
 `cMax`  
 окне Максимальное число `mdManifestResource` токенов, которые могут быть помещены в `rManifestResources` .  
  
 `pcTokens`  
 заполняет Количество маркеров, которые `mdManifestResource` в действительности помещаются в `rManifestResources` .  
  
## <a name="return-value"></a>Возвращаемое значение  
  
|HRESULT|Описание|  
|-------------|-----------------|  
|`S_OK`|`EnumManifestResources` успешно возвращено.|  
|`S_FALSE`|Нет токенов для перечисления. В этом случае `pcTokens` имеет значение 0.|  
  
## <a name="requirements"></a>Требования  

 **Платформы:** см. раздел [Требования к системе](../../get-started/system-requirements.md).  
  
 **Заголовок:** COR. h  
  
 **Библиотека:** Используется в качестве ресурса в MsCorEE.dll  
  
 **Платформа .NET Framework версии:**[!INCLUDE[net_current_v10plus](../../../../includes/net-current-v10plus-md.md)]  
  
## <a name="see-also"></a>См. также

- [Интерфейс IMetaDataAssemblyImport](imetadataassemblyimport-interface.md)
