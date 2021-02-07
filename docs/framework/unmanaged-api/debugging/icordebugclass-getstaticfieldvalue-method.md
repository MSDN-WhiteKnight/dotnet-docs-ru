---
description: 'Дополнительные сведения о методе: ICorDebugClass:: GetStaticFieldValue'
title: Метод ICorDebugClass::GetStaticFieldValue
ms.date: 03/30/2017
api_name:
- ICorDebugClass.GetStaticFieldValue
api_location:
- mscordbi.dll
api_type:
- COM
f1_keywords:
- ICorDebugClass::GetStaticFieldValue
helpviewer_keywords:
- GetStaticFieldValue method, ICorDebugClass interface [.NET Framework debugging]
- ICorDebugClass::GetStaticFieldValue method [.NET Framework debugging]
ms.assetid: 56e718b4-fabd-418b-a5b3-3cc33c745683
topic_type:
- apiref
ms.openlocfilehash: a5406e44491ce89030731c35752066e4943cebfc
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99711527"
---
# <a name="icordebugclassgetstaticfieldvalue-method"></a>Метод ICorDebugClass::GetStaticFieldValue

Возвращает значение указанного статического поля.  
  
## <a name="syntax"></a>Синтаксис  
  
```cpp  
HRESULT GetStaticFieldValue (  
    [in]  mdFieldDef         fieldDef,  
    [in]  ICorDebugFrame     *pFrame,  
    [out] ICorDebugValue     **ppValue  
);  
```  
  
## <a name="parameters"></a>Параметры  

 `fieldDef`  
 окне Токен поля `Def` , ссылающийся на извлекаемое поле.  
  
 `pFrame`  
 окне Указатель на объект ICorDebugFrame, представляющий кадр, который будет использоваться для однозначного определения статических элементов потока, контекста или домена приложения.  
  
 Если статическое поле задается относительно потока, контекста или домена приложения, кадр определит правильное значение.  
  
 `ppValue`  
 заполняет Указатель на адрес объекта ICorDebugValue, который представляет значение статического поля.  
  
## <a name="remarks"></a>Remarks  

 Для параметризованных типов значение статического поля задается относительно конкретного экземпляра. Поэтому, если конструктор класса принимает параметры типа <xref:System.Type> , вызовите метод [ICorDebugType:: GetStaticFieldValue](icordebugtype-getstaticfieldvalue-method.md) вместо `ICorDebugClass::GetStaticFieldValue` .  
  
## <a name="requirements"></a>Требования  

 **Платформы:** см. раздел [Требования к системе](../../get-started/system-requirements.md).  
  
 **Заголовок:** CorDebug.idl, CorDebug.h  
  
 **Библиотека:** CorGuids.lib  
  
 **Платформа .NET Framework версии:**[!INCLUDE[net_current_v10plus](../../../../includes/net-current-v10plus-md.md)]
