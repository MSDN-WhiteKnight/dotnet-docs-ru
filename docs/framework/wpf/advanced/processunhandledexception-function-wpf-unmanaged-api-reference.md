---
title: Функция ProcessUnhandledException (WPF Справочник по неуправляемым API)
ms.date: 03/30/2017
dev_langs:
- cpp
api_name:
- ProcessUnhandledException
api_location:
- PresentationHost_v0400.dll
ms.assetid: 495ce5f6-bb4d-4b30-807a-c3c35f1ca95c
ms.openlocfilehash: 0c8751454be6e0eed547c38e9d0bc7931abaec3d
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59196974"
---
# <a name="processunhandledexception-function-wpf-unmanaged-api-reference"></a>Функция ProcessUnhandledException (WPF Справочник по неуправляемым API)
Этот API поддерживает инфраструктуру Windows Presentation Foundation (WPF) и не предназначен для использования непосредственно из программного кода.  
  
 Используется инфраструктурой Windows Presentation Foundation (WPF) для обработки исключений.  
  
## <a name="syntax"></a>Синтаксис  
  
```cpp  
void __stdcall ProcessUnhandledException(  
   __in_ecount(1) BSTR errorMsg  
)  
```  
  
## <a name="parameters"></a>Параметры  
 errorMsg  
 Сообщение об ошибке.  
  
## <a name="requirements"></a>Требования  
 **Платформы:** См. в разделе [системные требования .NET Framework](../../get-started/system-requirements.md).  
  
 **БИБЛИОТЕКА DLL:**  
  
 В .NET Framework 3.0 и 3.5: PresentationHostDLL.dll  
  
 В .NET Framework 4 и более поздних версий: PresentationHost_v0400.dll  
  
 **Версии платформы .NET framework:** [!INCLUDE[net_current_v30plus](../../../../includes/net-current-v30plus-md.md)]  
  
## <a name="see-also"></a>См. также

- [Справочник по неуправляемым API WPF](wpf-unmanaged-api-reference.md)
