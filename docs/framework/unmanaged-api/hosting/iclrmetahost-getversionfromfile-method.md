---
description: 'Дополнительные сведения о методе: ICLRMetaHost:: Жетверсионфромфиле'
title: Метод ICLRMetaHost::GetVersionFromFile
ms.date: 03/30/2017
api_name:
- ICLRMetaHost.GetVersionFromFile
api_location:
- mscoree.dll
api_type:
- COM
f1_keywords:
- ICLRMetaHost::GetVersionFromFile
helpviewer_keywords:
- ICLRMetaHost::GetVersionFromFile method [.NET Framework hosting]
- GetVersionFromFile method [.NET Framework hosting]
ms.assetid: 55bb3eb4-f665-42fc-973c-465567570e82
topic_type:
- apiref
ms.openlocfilehash: 0122c4aba3b8454a84540b22e815c61a2cb25df8
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99689057"
---
# <a name="iclrmetahostgetversionfromfile-method"></a>Метод ICLRMetaHost::GetVersionFromFile

Возвращает исходную версию компиляции платформа .NET Framework сборки (хранящейся в метаданных) по указанному пути к файлу. Этот метод заменяет функцию [жетфилеверсион](getfileversion-function.md) .  
  
## <a name="syntax"></a>Синтаксис  
  
```cpp  
HRESULT GetVersionFromFile (  
    [in] LPCWSTR pwzFilePath,  
    [out, size_is(*pcchBuffer)] LPWSTR pwzBuffer,  
    [in, out] DWORD *pcchBuffer);  
);  
```  
  
## <a name="parameters"></a>Параметры  

 `pwzFilePath`  
 окне Полный путь к файлу сборки.  
  
 `pwzbuffer`  
 заполняет Версия компиляции платформа .NET Framework, хранящаяся в метаданных, в формате "v *A*. *B*[.*X*] ". *A*, *B* и *X* — это десятичные числа, соответствующие основной версии, дополнительной версии и номеру сборки. Длина этой строки ограничена MAX_PATH.  
  
> [!NOTE]
> Эти выходные данные соответствуют имени каталога для платформа .NET Framework версии, как отображается в разделе К:\виндовс\микрософт.нет\фрамеворк.  
  
 Примеры значений: "v 1.0.3705", "v 1.1.4322", "v 2.0.50727" и "v 4.0. *X*", где *X* зависит от установленного номера сборки. Обратите внимание, что требуется префикс "v".  
  
 `pcchBuffer`  
 [вход, выход] Размер `pwzbuffer` во избежание переполнения буфера.  
  
## <a name="return-value"></a>Возвращаемое значение  

 Этот метод возвращает следующие конкретные результаты HRESULT, а также ошибки HRESULT, которые указывают на сбой метода.  
  
|HRESULT|Описание:|  
|-------------|-----------------|  
|S_OK|Метод завершился успешно.|  
|E_POINTER|`pwzbuffer` или `pcchBuffer` равно null.|  
|HRESULT_FROM_WIN32(ERROR_INSUFFICIENT_BUFFER)|Буфер слишком мал.|  
  
## <a name="requirements"></a>Требования  

 **Платформы:** см. раздел [Требования к системе](../../get-started/system-requirements.md).  
  
 **Заголовок:** Метахост. h  
  
 **Библиотека:** Включается в качестве ресурса в MSCorEE.dll  
  
 **Платформа .NET Framework версии:**[!INCLUDE[net_current_v40plus](../../../../includes/net-current-v40plus-md.md)]  
  
## <a name="see-also"></a>См. также

- [Интерфейс ICLRMetaHost](iclrmetahost-interface.md)
- [Размещение](index.md)
