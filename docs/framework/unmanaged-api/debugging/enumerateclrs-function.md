---
description: Дополнительные сведения о функции EnumerateCLRs
title: Функция EnumerateCLRs
ms.date: 03/30/2017
api_name:
- EnumerateCLRs
api_location:
- dbgshim.dll
api_type:
- COM
f1_keywords:
- EnumerateCLRs
helpviewer_keywords:
- debugging API [Silverlight]
- Silverlight, debugging
- EnumerateCLRs function
ms.assetid: f8d50cb3-ec4f-4529-8fe3-bd61fd28e13c
topic_type:
- apiref
ms.openlocfilehash: 75124ef1e1e8588cb3d709161c3c1119e960be9e
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99637785"
---
# <a name="enumerateclrs-function"></a>Функция EnumerateCLRs

Предоставляет механизм для перечисления сред CLR в процессе.  
  
## <a name="syntax"></a>Синтаксис  
  
```cpp  
HRESULT EnumerateCLRs (  
    [in]  DWORD      debuggeePID,  
    [out] HANDLE**   ppHandleArrayOut,  
    [out] LPWSTR**   ppStringArrayOut,  
    [out] DWORD*     pdwArrayLengthOut  
);  
```  
  
## <a name="parameters"></a>Параметры  

 `debuggeePID`  
 [in] Идентификатор процесса, из которого будут перечислены загруженные среды CLR.  
  
 `ppHandleArrayOut`  
 [out] Указатель на массив, содержащий дескрипторы событий, которые используются для продолжения запуска среды CLR. Не все дескрипторы в массиве могут быть допустимыми. Если дескриптор допустимый, его следует использовать как событие  продолжения запуска для соответствующей среды выполнения, находящейся по тому же индексу `ppStringArrayOut`.  
  
 `ppStringArrayOut`  
 [out] Указатель на массив строк, определяющих полные пути к средам CLR, загруженным в процессе.  
  
 `pdwArrayLengthOut`  
 [out] Указатель на значение DWORD, содержащее длину одинакового размера массивов `ppHandleArrayOut` и `pdwArrayLengthOut`.  
  
## <a name="return-value"></a>Возвращаемое значение  

 S_OK  
 Количество сред CLR в процессе успешно определено, и соответствующие массивы дескрипторов и путей заполнены должным образом.  
  
 E_INVALIDARG  
 Либо `ppHandleArrayOut`, либо `ppStringArrayOut` имеет значение null, или `pdwArrayLengthOut` имеет значение null.  
  
 E_OUTOFMEMORY  
 Функции не удалось выделить достаточно памяти для массивов дескрипторов и путей.  
  
 E_FAIL (или другие коды возврата E_)  
 Не удалось перечислить загруженные среды CLR.  
  
## <a name="remarks"></a>Remarks  

 Для целевого процесса, который определяется идентификатором `debuggeePID`, функция возвращает массив путей `ppStringArrayOut` в среды CLR, загруженные в процесс; массив дескрипторов событий `ppHandleArrayOut`, который может содержать событие продолжения запуска для среды CLR с тем же индексом, и размер массивов `pdwArrayLengthOut`, который задает число загружаемых CLR.  
  
 В операционной системе Windows `debuggeePID` сопоставляется с идентификатором процесса ОС.  
  
 Память для `ppHandleArrayOut` и `ppStringArrayOut` выделяется этой функцией. Чтобы освободить выделенную память, необходимо вызвать [функцию клосеклренумератион](closeclrenumeration-function.md).  
  
 Эта функция может вызываться с параметрами обоих массивов, имеющими значение null, для возврата числа CLR в целевом процессе. Из этого числа вызывающий объект может определить размер буфера, который будет создан: `(sizeof(HANDLE) * count) + (sizeof(LPWSTR) * count) + (sizeof(WCHAR*) * count * MAX_PATH)`.  
  
## <a name="requirements"></a>Требования  

 **Платформы:** см. раздел [Требования к системе](../../get-started/system-requirements.md).  
  
 **Заголовок:** dbgshim. h  
  
 **Библиотека:** dbgshim.dll  
  
 **Платформа .NET Framework версии:** 3,5 SP1
