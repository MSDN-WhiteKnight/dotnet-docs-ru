---
description: 'Дополнительные сведения о методе: метод iclrstrongname:: StrongNameSignatureVerificationFromImage'
title: Метод ICLRStrongName::StrongNameSignatureVerificationFromImage
ms.date: 03/30/2017
api_name:
- ICLRStrongName.StrongNameSignatureVerificationFromImage
api_location:
- mscoree.dll
api_type:
- COM
f1_keywords:
- ICLRStrongName::StrongNameSignatureVerificationFromImage
helpviewer_keywords:
- ICLRStrongName::StrongNameSignatureVerificationFromImage method [.NET Framework hosting]
- StrongNameSignatureVerificationFromImage method, ICLRStrongName interface [.NET Framework hosting]
ms.assetid: da91c138-ee30-4fd4-a040-464d97d7e41a
topic_type:
- apiref
ms.openlocfilehash: 5c1c3568dd0ad506c478525503f168d8b8c2dfbc
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99781835"
---
# <a name="iclrstrongnamestrongnamesignatureverificationfromimage-method"></a>Метод ICLRStrongName::StrongNameSignatureVerificationFromImage

Проверяет допустимость сборки, которая уже была сопоставлена с памятью, для связанного открытого ключа.  
  
## <a name="syntax"></a>Синтаксис  
  
```cpp  
HRESULT StrongNameSignatureVerificationFromImage (  
    [in]  BYTE    *pbBase,  
    [in]  DWORD   dwLength,  
    [in]  DWORD   dwInFlags,  
    [out] DWORD   *pdwOutFlags  
);  
```  
  
## <a name="parameters"></a>Параметры  

 `pbBase`  
 окне Относительный виртуальный адрес сопоставленного манифеста сборки.  
  
 `dwLength`  
 окне Размер сопоставленного изображения в байтах.  
  
 `dwInFlags`  
 окне Флаги, влияющие на поведение при проверке. Поддерживаются следующие значения.  
  
- `SN_INFLAG_FORCE_VER` (0x00000001) — принудительная проверка, даже если необходимо переопределить параметры реестра.  
  
- `SN_INFLAG_INSTALL` (0x00000002) — указывает, что это первая проверка, выполняемая на этом образе.  
  
- `SN_INFLAG_ADMIN_ACCESS` (0x00000004) — указывает, что кэш будет разрешать доступ только тем пользователям, у которых есть права администратора.  
  
- `SN_INFLAG_USER_ACCESS` (0x00000008) — указывает, что сборка будет доступна только текущему пользователю.  
  
- `SN_INFLAG_ALL_ACCESS` (0x00000010) — указывает, что кэш не предоставляет никаких гарантий ограничения доступа.  
  
- `SN_INFLAG_RUNTIME` (0x80000000) — зарезервировано для внутренней отладки.  
  
 `pdwOutFlags`  
 заполняет Флаг для дополнительных выходных данных. Поддерживается следующее значение:  
  
- `SN_OUTFLAG_WAS_VERIFIED` (0x00000001) — это значение `false` указывает, что проверка прошла удачно из-за параметров реестра.  
  
## <a name="return-value"></a>Возвращаемое значение  

 `S_OK` значение, если метод успешно выполнен; в противном случае — значение HRESULT, указывающее на сбой (см. раздел [Общие значения HRESULT](/windows/win32/seccrypto/common-hresult-values) для списка).  
  
## <a name="requirements"></a>Требования  

 **Платформы:** см. раздел [Требования к системе](../../get-started/system-requirements.md).  
  
 **Заголовок:** Метахост. h  
  
 **Библиотека:** Включается в качестве ресурса в MSCorEE.dll  
  
 **Платформа .NET Framework версии:**[!INCLUDE[net_current_v40plus](../../../../includes/net-current-v40plus-md.md)]  
  
## <a name="see-also"></a>См. также раздел

- [Интерфейс ICLRStrongName](iclrstrongname-interface.md)
