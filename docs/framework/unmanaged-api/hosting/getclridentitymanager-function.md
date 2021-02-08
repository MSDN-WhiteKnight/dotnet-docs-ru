---
description: Дополнительные сведения о функции GetCLRIdentityManager
title: Функция GetCLRIdentityManager
ms.date: 03/30/2017
api_name:
- GetCLRIdentityManager
api_location:
- mscoree.dll
api_type:
- COM
f1_keywords:
- GetCLRIdentityManager
helpviewer_keywords:
- GetCLRIdentityManager function [.NET Framework hosting]
ms.assetid: 66eeca30-adb4-45f4-aff5-347564c95724
topic_type:
- apiref
ms.openlocfilehash: 483cf0499fa162da4c89e350198a5609f9f1bab6
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99785371"
---
# <a name="getclridentitymanager-function"></a>Функция GetCLRIdentityManager

Возвращает указатель на интерфейс, который позволяет среде CLR управлять удостоверениями.  
  
 Эта функция является устаревшей в платформа .NET Framework 4.  
  
## <a name="syntax"></a>Синтаксис  
  
```cpp  
STDAPI GetCLRIdentityManager(  
    [in]  REFIID      riid,  
    [out] IUnknown  **ppManager  
);  
```  
  
## <a name="parameters"></a>Параметры  

 `riid`  
 окне Объект `REFIID` (идентификатор интерфейса), указывающий, какой интерфейс следует получить. Это значение должно быть либо IID_ICLRAssemblyIdentityManager, либо IID_ICLRHostBindingPolicyManager.  
  
 `ppManager`  
 заполняет Указатель на адрес объекта [ICLRAssemblyIdentityManager](iclrassemblyidentitymanager-interface.md) или [ICLRHostBindingPolicyManager](iclrhostbindingpolicymanager-interface.md) .  
  
## <a name="remarks"></a>Remarks  

 Вызовите функцию [жетреалпрокаддресс](getrealprocaddress-function.md) , чтобы получить указатель на `GetCLRIdentityManager` функцию.  
  
## <a name="requirements"></a>Требования  

 **Платформы:** см. раздел [Требования к системе](../../get-started/system-requirements.md).  
  
 **Заголовок:** MSCorEE. h  
  
 **Библиотека:** MSCorWks.dll  
  
 **Платформа .NET Framework версии:**[!INCLUDE[net_current_v20plus](../../../../includes/net-current-v20plus-md.md)]  
  
## <a name="see-also"></a>См. также

- [Устаревшие функции размещения CLR](deprecated-clr-hosting-functions.md)
