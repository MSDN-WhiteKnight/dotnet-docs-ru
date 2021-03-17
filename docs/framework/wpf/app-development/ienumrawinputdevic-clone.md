---
title: IEnumRAWINPUTDEVIC:Clone
ms.date: 03/30/2017
helpviewer_keywords:
- Clone method [WPF]
ms.assetid: 2a6a1900-aa55-45fa-9382-241d569a2dc4
ms.openlocfilehash: abc8a6e4780c8fe50afcf1b04f7e14aeb6452704
ms.sourcegitcommit: 5137208fa414d9ca3c58cdfd2155ac81bc89e917
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/06/2019
ms.locfileid: "57485412"
---
# <a name="ienumrawinputdevicclone"></a>IEnumRAWINPUTDEVIC:Clone
Создает другой перечислитель устройств необработанного ввода с же состоянием, что и текущий перечислитель, для прохода по тому же списку.  
  
## <a name="syntax"></a>Синтаксис  
  
```  
HRESULT Clone( [out] IEnumRAWINPUTDEVICE **ppenum);  
```  
  
## <a name="parameters"></a>Параметры  
 `ppenum`  
  
 [out] Адрес выходной переменной, которая получает [IEnumRAWINPUTDEVICE](ienumrawinputdevice.md) указатель на интерфейс. Если метод выполняется неудачно, значение этой переменной выходных данных не определено.  
  
## <a name="property-valuereturn-value"></a>Значение свойства, возвращаемое значение  
 HRESULT: Этот метод поддерживает стандартные возвращаемые значения E_INVALIDARG, E_UNEXPECTED и E_OUTOFMEMORY.  
  
## <a name="remarks"></a>Примечания  
 Этот метод дает возможность записать позицию в последовательности перечисления для возврата в эту точку в дальнейшем. Вызывающий объект должен освободить этот новый перечислитель отдельно от первого перечислителя.
