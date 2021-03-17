---
title: Получение необработанных устройств ввода
ms.date: 03/30/2017
helpviewer_keywords:
- raw input [WPF]
ms.assetid: c4d37ecd-065a-4d1c-9e6c-26804ae968ca
ms.openlocfilehash: 3531ff9f42289a3ad3b029f090f2dd4987e5886c
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59199408"
---
# <a name="getrawinputdevices"></a>Получение необработанных устройств ввода
Позволяет программе PresentationHost.exe обнаруживать устройства необработанного ввода (устройства HID), которые интересуют ведущее приложение.  
  
## <a name="syntax"></a>Синтаксис  
  
```  
HRESULT GetRawInputDevices( [out] IEnumRAWINPUTDEVICE **ppEnum );  
```  
  
## <a name="parameters"></a>Параметры  
 `ppEnum`  
  
 [out] Указатель на [IEnumRAWINPUTDEVICE](ienumrawinputdevice.md) для перечисления устройств необработанного ввода.  
  
## <a name="property-valuereturn-value"></a>Значение свойства, возвращаемое значение  
 HRESULT:  
  
 S_OK — [IEnumRAWINPUTDEVICE](ienumrawinputdevice.md) только будет использоваться программой PresentationHost.exe, если возвращается значение S_OK.  
  
 E_NOTIMPL  
  
## <a name="remarks"></a>Примечания  
 Устройства необработанного ввода — это ряд устройств, включающий клавиатуры, мышь и менее распространенные устройства, такие как устройства удаленного управления.  
  
 После получения списка устройств необработанного ввода программа PresentationHost.exe регистрируется в устройствах для получения уведомлений WM_INPUT.  
  
## <a name="see-also"></a>См. также

- [GetRawInputDeviceList](/windows/desktop/api/winuser/nf-winuser-getrawinputdevicelist)
- [FilterInputMessage](filterinputmessage.md)
