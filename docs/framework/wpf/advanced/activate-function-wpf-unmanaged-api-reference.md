---
title: Функция Activate (WPF Справочник по неуправляемым API)
ms.date: 03/30/2017
dev_langs:
- cpp
api_name:
- Activate
api_location:
- PresentationHost_v0400.dll
ms.assetid: 1400329c-b598-465f-80f2-e3dabf044811
ms.openlocfilehash: ee231653815bd5ef75d58979034e3b3be9f5ba54
ms.sourcegitcommit: 5137208fa414d9ca3c58cdfd2155ac81bc89e917
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/06/2019
ms.locfileid: "57480784"
---
# <a name="activate-function-wpf-unmanaged-api-reference"></a>Функция Activate (WPF Справочник по неуправляемым API)

Этот API поддерживает инфраструктуру Windows Presentation Foundation (WPF) и не предназначен для использования непосредственно из программного кода.

Используется инфраструктурой Windows Presentation Foundation (WPF) для управления windows.

## <a name="syntax"></a>Синтаксис

```cpp
void Activate(
    const ActivateParameters* pParameters,
    __deref_out_ecount(1) LPUNKNOWN* ppInner,
    );
```

## <a name="parameters"></a>Параметры

`pParameters`\
Указатель на параметры активации окна.

`ppInner`\
Указатель на адрес буфера одного элемента, который содержит указатель на <xref:Microsoft.VisualStudio.OLE.Interop.IOleDocument> объект.

## <a name="requirements"></a>Требования

**Платформы:** См. в разделе [системные требования .NET Framework](../../get-started/system-requirements.md).

**БИБЛИОТЕКА DLL:**

В .NET Framework 3.0 и 3.5: PresentationHostDLL.dll

В .NET Framework 4 и более поздних версий: PresentationHost_v0400.dll

**Версии платформы .NET framework:** [!INCLUDE[net_current_v30plus](../../../../includes/net-current-v30plus-md.md)]

## <a name="see-also"></a>См. также

- [Справочник по неуправляемым API WPF](wpf-unmanaged-api-reference.md)
