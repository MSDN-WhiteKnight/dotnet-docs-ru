---
description: Дополнительные сведения о перечислении Коркаллингконвентион
title: Перечисление CorCallingConvention
ms.date: 03/30/2017
api_name:
- CorCallingConvention
api_location:
- mscoree.dll
api_type:
- COM
f1_keywords:
- CorCallingConvention
helpviewer_keywords:
- CorCallingConvention enumeration [.NET Framework metadata]
ms.assetid: 69156fbf-7219-43bf-b4b8-b13f1a2fcb86
topic_type:
- apiref
ms.openlocfilehash: 2e823fe3566ef7a54f759cd5debbbd7d5dcf3ceb
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99678449"
---
# <a name="corcallingconvention-enumeration"></a>Перечисление CorCallingConvention

Содержит значения, описывающие типы соглашений о вызовах, выполняемых в управляемом коде.  
  
## <a name="syntax"></a>Синтаксис  
  
```cpp  
typedef enum CorCallingConvention  
{  
    IMAGE_CEE_CS_CALLCONV_DEFAULT       = 0x0,  
  
    IMAGE_CEE_CS_CALLCONV_VARARG        = 0x5,  
    IMAGE_CEE_CS_CALLCONV_FIELD         = 0x6,  
    IMAGE_CEE_CS_CALLCONV_LOCAL_SIG     = 0x7,  
    IMAGE_CEE_CS_CALLCONV_PROPERTY      = 0x8,  
    IMAGE_CEE_CS_CALLCONV_UNMGD         = 0x9,  
    IMAGE_CEE_CS_CALLCONV_GENERICINST   = 0xa,  
    IMAGE_CEE_CS_CALLCONV_NATIVEVARARG  = 0xb,  
    IMAGE_CEE_CS_CALLCONV_MAX           = 0xc,  
  
    IMAGE_CEE_CS_CALLCONV_MASK          = 0x0f,  
    IMAGE_CEE_CS_CALLCONV_HASTHIS       = 0x20,  
    IMAGE_CEE_CS_CALLCONV_EXPLICITTHIS  = 0x40,  
    IMAGE_CEE_CS_CALLCONV_GENERIC       = 0x10  
  
} CorCallingConvention;  
```  
  
## <a name="members"></a>Члены  
  
|Член|Описание|  
|------------|-----------------|  
|`IMAGE_CEE_CS_CALLCONV_DEFAULT`|Указывает соглашение о вызовах по умолчанию.|  
|`IMAGE_CEE_CS_CALLCONV_VARARG`|Указывает, что метод принимает переменное число параметров.|  
|`IMAGE_CEE_CS_CALLCONV_FIELD`|Указывает, что вызов относится к полю.|  
|`IMAGE_CEE_CS_CALLCONV_LOCAL_SIG`|Указывает, что вызов осуществляется в локальный метод.|  
|`IMAGE_CEE_CS_CALLCONV_PROPERTY`|Указывает, что вызов относится к свойству.|  
|`IMAGE_CEE_CS_CALLCONV_UNMGD`|Указывает, что вызов является неуправляемым.|  
|`IMAGE_CEE_CS_CALLCONV_GENERICINST`|Указывает на создание экземпляра универсального метода.|  
|`IMAGE_CEE_CS_CALLCONV_NATIVEVARARG`|Обозначает 64-разрядный вызов PInvoke для метода, принимающего переменное число параметров.|  
|`IMAGE_CEE_CS_CALLCONV_MAX`|Описывает недопустимое 4-битовое значение.|  
|`IMAGE_CEE_CS_CALLCONV_MASK`|Указывает, что соглашение о вызовах описывается четырьмя нижними битами.|  
|`IMAGE_CEE_CS_CALLCONV_HASTHIS`|Указывает, что верхний бит описывает `this` параметр.|  
|`IMAGE_CEE_CS_CALLCONV_EXPLICITTHIS`|Указывает, что `this` параметр явно описан в сигнатуре.|  
|`IMAGE_CEE_CS_CALLCONV_GENERIC`|Указывает сигнатуру универсального метода с явным числом аргументов типа. Это значение предшествует обычному числу параметров.|  
  
## <a name="requirements"></a>Требования  

 **Платформы:** см. раздел [Требования к системе](../../get-started/system-requirements.md).  
  
 **Заголовок:** Корхдр. h  
  
 **Платформа .NET Framework версии:**[!INCLUDE[net_current_v10plus](../../../../includes/net-current-v10plus-md.md)]  
  
## <a name="see-also"></a>См. также

- [Перечисления метаданных](metadata-enumerations.md)
