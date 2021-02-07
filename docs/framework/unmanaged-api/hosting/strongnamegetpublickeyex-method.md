---
description: Дополнительные сведения о методе StrongNameGetPublicKeyEx
title: Метод StrongNameGetPublicKeyEx
ms.date: 03/30/2017
api_name:
- ICLRStrongName2.StrongNameGetPublicKeyEx
api_location:
- mscoree.dll
api_type:
- COM
f1_keywords:
- StrongNameGetPublicKeyEx
helpviewer_keywords:
- StrongNameGetPublicKeyEx method, ICLRStrongName2 interface [.NET Framework hosting]
- ICLRStrongName2::StrongNameGetPublicKeyEx method [.NET Framework hosting]
ms.assetid: 63d8260c-fb32-4f8f-a357-768afd570f68
topic_type:
- apiref
ms.openlocfilehash: bc9d40afc34509f852a0961823e264255125fa16
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99679307"
---
# <a name="strongnamegetpublickeyex-method"></a>Метод StrongNameGetPublicKeyEx

Получает открытый ключ из пары открытого и закрытого ключей и задает алгоритм хеширования и алгоритм подписи.  
  
## <a name="syntax"></a>Синтаксис  
  
```cpp  
HRESULT StrongNameGetPublicKey (
    [in]  LPCWSTR   pwzKeyContainer,  
    [in]  BYTE      *pbKeyBlob,  
    [in]  ULONG     cbKeyBlob,  
    [out] BYTE      **ppbPublicKeyBlob,  
    [out] ULONG     *pcbPublicKeyBlob  
    [in]  ULONG     uHashAlgId,  
    [in]  ULONG     uReserved,  
);  
```  
  
## <a name="parameters"></a>Параметры  

 `pwzKeyContainer`  
 окне Имя контейнера ключей, содержащего пару открытого и закрытого ключей. Если `pbKeyBlob` параметр имеет значение null, `szKeyContainer` необходимо указать допустимый контейнер в поставщике служб шифрования (CSP). В этом случае `StrongNameGetPublicKeyEx` метод извлекает открытый ключ из пары ключей, хранящихся в контейнере.  
  
 Если значение не равно `pbKeyBlob` null, предполагается, что пара ключей содержится в большом двоичном объекте Key (BLOB).  
  
 Ключи должны состоять из 1024-разрядных ключей подписывания Ривест-Шамир-Адельман (RSA). В настоящее время не поддерживаются никакие другие типы ключей.  
  
 `pbKeyBlob`  
 окне Указатель на пару открытого и закрытого ключей. Эта пара имеет формат, созданный `CryptExportKey` функцией Win32. Если аргумент `pbKeyBlob` имеет значение null, предполагается, что контейнер ключей, заданный параметром, `szKeyContainer` содержит пару ключей.  
  
 `cbKeyBlob`  
 окне Размер (в байтах) `pbKeyBlob` .  
  
 `ppbPublicKeyBlob`  
 заполняет Возвращенный большой двоичный объект открытого ключа. `ppbPublicKeyBlob`Параметр выделяется средой CLR и возвращается вызывающему объекту. Вызывающий объект должен освободить память с помощью метода [метод iclrstrongname:: StrongNameFreeBuffer](iclrstrongname-strongnamefreebuffer-method.md) .  
  
 `pcbPublicKeyBlob`  
 заполняет Размер возвращенного большого двоичного объекта открытого ключа.  
  
 `uHashAlgId`  
 окне Хэш-алгоритм сборки. Список допустимых значений см. в разделе "Примечания".  
  
 `uReserved`  
 окне Зарезервировано для будущего использования; по умолчанию принимает значение null.  
  
## <a name="return-value"></a>Возвращаемое значение  

 `S_OK` значение, если метод успешно выполнен; в противном случае — значение HRESULT, указывающее на сбой (см. раздел [Общие значения HRESULT](/windows/win32/seccrypto/common-hresult-values) для списка).  
  
## <a name="remarks"></a>Remarks  

 Открытый ключ содержится в структуре [публиккэйблоб](../strong-naming/publickeyblob-structure.md) .  
  
## <a name="remarks"></a>Remarks  

 В следующей таблице показан набор допустимых значений для `uHashAlgId` параметра.  
  
|Имя|Значение|  
|----------|-----------|  
|None|0|  
|SHA-1|0x8004|  
|SHA-256|0x800c|  
|SHA-384|0x800d|  
|SHA-512|0x800e|  
  
## <a name="requirements"></a>Требования  

 **Платформы:** см. раздел [Требования к системе](../../get-started/system-requirements.md).  
  
 **Заголовок:** Метахост. h  
  
 **Библиотека:** Включается в качестве ресурса в MSCorEE.dll  
  
 **Платформа .NET Framework версии:**[!INCLUDE[net_current_v45plus](../../../../includes/net-current-v45plus-md.md)]  
  
## <a name="see-also"></a>См. также

- [Метод StrongNameTokenFromPublicKey](iclrstrongname-strongnametokenfrompublickey-method.md)
- [Структура PublicKeyBlob](../strong-naming/publickeyblob-structure.md)
- [Интерфейс ICLRStrongName](iclrstrongname-interface.md)
- [Метод StrongNameGetPublicKey](iclrstrongname-strongnamegetpublickey-method.md)
