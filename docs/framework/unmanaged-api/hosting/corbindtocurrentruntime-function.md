---
description: Дополнительные сведения о функции Корбиндтокуррентрунтиме
title: Функция CorBindToCurrentRuntime
ms.date: 03/30/2017
api_name:
- CorBindToCurrentRuntime
api_location:
- mscoree.dll
- mscoreei.dll
api_type:
- HeaderDef
f1_keywords:
- CorBindToCurrentRuntime
helpviewer_keywords:
- CorBindToCurrentRuntime function [.NET Framework hosting]
ms.assetid: 6105c13e-d9cd-44d2-a95a-924e042830c7
topic_type:
- apiref
ms.openlocfilehash: 7dd2ab7febf4b1f87265a670a1af5d54b1e1102e
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99790117"
---
# <a name="corbindtocurrentruntime-function"></a>Функция CorBindToCurrentRuntime

Загружает среду CLR в процесс с использованием сведений о версии, хранящихся в XML-файле. Формат XML-файла моделируется после стандартного файла конфигурации приложения. Дополнительные сведения о файлах конфигурации см. в разделе [Схема файла конфигурации](../../configure-apps/file-schema/index.md).  
  
 Эта функция является устаревшей в платформа .NET Framework 4. См. раздел [Загрузка среды CLR в процесс](/previous-versions/dotnet/netframework-4.0/01918c6x(v=vs.100)).  
  
## <a name="syntax"></a>Синтаксис  
  
```cpp  
HRESULT CorBindToCurrentRuntime (  
    [in]  LPCWSTR   pwszFileName,  
    [in]  REFCLSID  rclsid,  
    [in]  REFIID    riid,  
    [out] LPVOID    *ppv  
);  
```  
  
## <a name="parameters"></a>Параметры  

 `pwszFileName`  
 окне Имя файла конфигурации приложения, указывающего версию среды CLR для загрузки. Если имя файла не указано полностью, предполагается, что он находится в том же каталоге, что и исполняемый объект, вызывающий вызов.  
  
 Версия загружаемой среды выполнения описывается атрибутом Version в [\<requiredRuntime>](../../configure-apps/file-schema/startup/requiredruntime-element.md) элементе файла конфигурации.  
  
 Если версия не указана или `<requiredRuntime>` элемент не найден, загружается последняя версия среды CLR, установленная на компьютере.  
  
 `rclsid`  
 окне Объект `CLSID` coclass, реализующий интерфейс [ICorRuntimeHost](icorruntimehost-interface.md) или [ICLRRuntimeHost](iclrruntimehost-interface.md) . Поддерживаемые значения: CLSID_CorRuntimeHost или CLSID_CLRRuntimeHost.  
  
 `riid`  
 окне `IID` Запрашиваемый интерфейс. Поддерживаемые значения: IID_ICorRuntimeHost или IID_ICLRRuntimeHost.  
  
 `ppv`  
 заполняет Возвращаемый указатель интерфейса.  
  
## <a name="requirements"></a>Требования  

 **Платформы:** см. раздел [Требования к системе](../../get-started/system-requirements.md).  
  
 **Заголовок:** MSCorEE. h  
  
 **Библиотека:** MSCorEE.dll  
  
 **Платформа .NET Framework версии:**[!INCLUDE[net_current_v10plus](../../../../includes/net-current-v10plus-md.md)]  
  
## <a name="see-also"></a>См. также

- [Функция CorBindToRuntime](corbindtoruntime-function.md)
- [Функция CorBindToRuntimeByCfg](corbindtoruntimebycfg-function.md)
- [Функция CorBindToRuntimeEx](corbindtoruntimeex-function.md)
- [Функция CorBindToRuntimeHost](corbindtoruntimehost-function.md)
- [Интерфейс ICorRuntimeHost](icorruntimehost-interface.md)
- [Устаревшие функции размещения CLR](deprecated-clr-hosting-functions.md)
