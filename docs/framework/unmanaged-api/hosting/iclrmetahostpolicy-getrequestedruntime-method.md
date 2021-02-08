---
description: 'Дополнительные сведения о методе: ICLRMetaHostPolicy:: GetRequestedRuntime'
title: Метод ICLRMetaHostPolicy::GetRequestedRuntime
ms.date: 03/30/2017
api_name:
- ICLRMetaHostPolicy.GetRequestedRuntime
api_location:
- mscoree.dll
api_type:
- COM
f1_keywords:
- ICLRMetaHostPolicy::GetRequestedRuntime
helpviewer_keywords:
- GetRequestedRuntime method [.NET Framework hosting]
- ICLRMetaHostPolicy::GetRequestedRuntime method [.NET Framework hosting]
ms.assetid: 59ec1832-9cc1-4b5c-983d-03407e51de56
topic_type:
- apiref
ms.openlocfilehash: 0e11694b0cb66ad7fc28abf7bb9f7fc8c6931a19
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99789844"
---
# <a name="iclrmetahostpolicygetrequestedruntime-method"></a>Метод ICLRMetaHostPolicy::GetRequestedRuntime

Предоставляет интерфейс для предпочитаемой версии общеязыковой среды выполнения (CLR) на основе политики размещения, управляемой сборки, строки версии и потока конфигурации. Этот метод не выполняет фактическую загрузку или активацию среды CLR, но просто возвращает интерфейс [ICLRRuntimeInfo](iclrruntimeinfo-interface.md) , представляющий результат политики. Этот метод заменяет методы [GetRequestedRuntimeInfo](getrequestedruntimeinfo-function.md), [жетрекуестедрунтимеверсион](getrequestedruntimeversion-function.md), [корбиндторунтимехост](corbindtoruntimehost-function.md), [корбиндторунтимебикфг](corbindtoruntimebycfg-function.md)и [жеткоррекуиредверсион](getcorrequiredversion-function.md) .

## <a name="syntax"></a>Синтаксис

```cpp
HRESULT GetRequestedRuntime(
    [in]  METAHOST_POLICY_FLAGS dwPolicyFlags,
    [in]  LPCWSTR pwzBinary,
    [in]  IStream *pCfgStream,
    [in, out, size_is(*pcchVersion)] LPWSTR pwzVersion,
    [in, out]  DWORD *pcchVersion,
    [out, size_is(*pcchImageVersion)] LPWSTR pwzImageVersion,
    [in, out]  DWORD *pcchImageVersion,
    [out] DWORD *pdwConfigFlags,
    [in]  REFIID  riid
    [out, iid_is(riid), retval] LPVOID *ppRuntime);
```

## <a name="parameters"></a>Параметры

|Имя|Описание|
|----------|-----------------|
|`dwPolicyFlags`|[in] Обязательный. Указывает элемент перечисления [METAHOST_POLICY_FLAGS](metahost-policy-flags-enumeration.md) , представляющий политику привязки, и любое количество модификаторов. Единственной доступной в данный момент политикой является [METAHOST_POLICY_HIGHCOMPAT](metahost-policy-flags-enumeration.md).<br /><br /> К модификаторам относятся [METAHOST_POLICY_EMULATE_EXE_LAUNCH](metahost-policy-flags-enumeration.md), [METAHOST_POLICY_APPLY_UPGRADE_POLICY](metahost-policy-flags-enumeration.md), [METAHOST_POLICY_SHOW_ERROR_DIALOG](metahost-policy-flags-enumeration.md), [METAHOST_POLICY_USE_PROCESS_IMAGE_PATH](metahost-policy-flags-enumeration.md)и [METAHOST_POLICY_ENSURE_SKU_SUPPORTED](metahost-policy-flags-enumeration.md).|
|`pwzBinary`|[в] Необязательно. Задает путь к файлу сборки.|
|`pCfgStream`|[в] Необязательно. Задает файл конфигурации в виде <xref:System.Runtime.InteropServices.ComTypes.IStream?displayProperty=nameWithType>.|
|`pwzVersion`|[in, out] Необязательный. Задает или возвращает предпочтительную версию среды CLR для загрузки.|
|`pcchVersion`|[in, out] Обязательный. Указывает ожидаемый размер `pwzVersion` в качестве входных данных для предотвращения переполнения буфера. Если `pwzVersion` имеет значение NULL, `pcchVersion` содержит ожидаемый размер `pwzVersion` при возвращении значения `GetRequestedRuntime`, чтобы разрешить предварительное выделение; в противном случае `pcchVersion` содержит число символов, записанных в `pwzVersion`.|
|`pwzImageVersion`|[out] Необязательный. При `GetRequestedRuntime` возврате содержит версию среды CLR, соответствующую возвращаемому интерфейсу [ICLRRuntimeInfo](iclrruntimeinfo-interface.md) .|
|`pcchImageVersion`|[in, out] Необязательный. Указывает размер `pwzImageVersion` в качестве входных данных для предотвращения переполнения буфера. Если `pwzImageVersion` имеет значение NULL, `pcchImageVersion` содержит требуемый размер `pwzImageVersion` при возвращении значения `GetRequestedRuntime`, чтобы разрешить предварительное выделение.|
|`pdwConfigFlags`|[out] Необязательный. Если в процессе `GetRequestedRuntime` привязки использует файл конфигурации, то при возвращении `pdwConfigFlags` содержит значение [METAHOST_CONFIG_FLAGS](metahost-config-flags-enumeration.md) , указывающее, задан ли атрибут для [\<startup>](../../configure-apps/file-schema/startup/startup-element.md) элемента `useLegacyV2RuntimeActivationPolicy` , и значение атрибута. Примените маску [METAHOST_CONFIG_FLAGS_LEGACY_V2_ACTIVATION_POLICY_MASK](metahost-config-flags-enumeration.md) к, чтобы `pdwConfigFlags` получить значения, относящиеся к `useLegacyV2RuntimeActivationPolicy` .|
|`riid`|окне Указывает идентификатор интерфейса IID_ICLRRuntimeInfo для запрошенного интерфейса [ICLRRuntimeInfo](iclrruntimeinfo-interface.md) .|
|`ppRuntime`|заполняет При `GetRequestedRuntime` возврате содержит указатель на соответствующий интерфейс [ICLRRuntimeInfo](iclrruntimeinfo-interface.md) .|

## <a name="remarks"></a>Remarks

После успешного завершения этого метода имеет место его побочный эффект в виде объединения дополнительных флагов с текущими флагами запуска по умолчанию из возвращенного интерфейса среды выполнения тогда и только тогда, когда один или несколько из следующих элементов существуют в потоке конфигурации в разделе `<configuration><runtime>`.

- `<gcServer enabled="true"/>` приводит к заданию `STARTUP_SERVER_GC`.

- `<etwEnable enabled="true"/>` приводит к заданию `STARTUP_ETW`.

- `<appDomainResourceMonitoring enabled="true"/>` приводит к заданию `STARTUP_ARM`.

По умолчанию результирующее значение`STARTUP_FLAGS` является побитовым или сочетанием заданных значений из предыдущего списка с флагами запуска по умолчанию.

## <a name="return-value"></a>Возвращаемое значение

Этот метод возвращает следующие конкретные результаты HRESULT, а также ошибки HRESULT, которые указывают на сбой метода.

|HRESULT|Описание:|
|-------------|-----------------|
|S_OK|Метод завершился успешно.|
|E_POINTER|`pwzVersion` не равен NULL, а `pcchVersion` равен NULL.<br /><br /> -или-<br /><br /> `pwzImageVersion` не равен NULL, а `pcchImageVersion` равен NULL.|
|E_INVALIDARG|`dwPolicyFlags` не указывает `METAHOST_POLICY_HIGHCOMPAT`.|
|ERROR_INSUFFICIENT_BUFFER|Памяти, выделенной для `pwzVersion`, недостаточно.<br /><br /> -или-<br /><br /> Памяти, выделенной для `pwzImageVersion`, недостаточно.|
|CLR_E_SHIM_RUNTIMELOAD|`dwPolicyFlags` включает в себя METAHOST_POLICY_APPLY_UPGRADE_POLICY, а как `pwzVersion`, так и `pcchVersion` имеют значение NULL.|

## <a name="requirements"></a>Требования

**Платформы:** см. раздел [Требования к системе](../../get-started/system-requirements.md).

**Заголовок:** Метахост. h

**Библиотека:** Включается в качестве ресурса в MSCorEE.dll

**Платформа .NET Framework версии:**[!INCLUDE[net_current_v40plus](../../../../includes/net-current-v40plus-md.md)]

## <a name="see-also"></a>См. также

- [Интерфейс ICLRMetaHostPolicy](iclrmetahostpolicy-interface.md)
- [Интерфейсы размещения CLR, добавленные в версиях .NET Framework 4 и 4.5](clr-hosting-interfaces-added-in-the-net-framework-4-and-4-5.md)
- [Интерфейсы размещения](hosting-interfaces.md)
- [Размещение](index.md)
