---
title: IEnumRAWINPUTDEVIC:SKIP
ms.date: 03/30/2017
helpviewer_keywords:
- Skip method [WPF]
ms.assetid: c967b0f8-1c6a-459c-8c16-d4f08918ab65
ms.openlocfilehash: f7d7df77c54d4551025aa5a344c96083c263f455
ms.sourcegitcommit: 5137208fa414d9ca3c58cdfd2155ac81bc89e917
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/06/2019
ms.locfileid: "57467172"
---
# <a name="ienumrawinputdevicskip"></a>IEnumRAWINPUTDEVIC:SKIP
Указывает перечислителю пропустить следующий `celt` элементов в перечислении, чтобы следующий вызов [IEnumRAWINPUTDEVIC: Next](ienumrawinputdevic-next.md) не возвращал эти элементы.  
  
## <a name="syntax"></a>Синтаксис  
  
```  
HRESULT Skip( [in] ULONG celt);  
```  
  
## <a name="parameters"></a>Параметры  
 `celt`  
  
 [in] Число элементов, которые нужно пропустить.  
  
## <a name="property-valuereturn-value"></a>Значение свойства, возвращаемое значение  
 HRESULT: Значение S_OK, если число предоставленных элементов является `celt`; В противном случае значение S_FALSE.
