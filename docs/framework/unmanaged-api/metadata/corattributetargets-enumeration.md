---
description: Дополнительные сведения о перечислении CorAttributeTargets
title: Перечисление CorAttributeTargets
ms.date: 03/30/2017
api_name:
- CorAttributeTargets
api_location:
- mscoree.dll
api_type:
- COM
f1_keywords:
- CorAttributeTargets
helpviewer_keywords:
- CorAttributeTargets enumeration [.NET Framework metadata]
ms.assetid: 694c0fa0-7011-41a9-9dfd-f0e16ea574b5
topic_type:
- apiref
ms.openlocfilehash: 6f80df31b9da8591fac3d979ede1e9bf0f8ecfc4
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99678501"
---
# <a name="corattributetargets-enumeration"></a>Перечисление CorAttributeTargets

Задает элементы приложения, в которых допустимо применять аргумент.  
  
## <a name="syntax"></a>Синтаксис  
  
```cpp  
typedef enum CorAttributeTargets  
{  
    catAssembly            = 0x0001,  
    catModule              = 0x0002,  
    catClass               = 0x0004,  
    catStruct              = 0x0008,  
    catEnum                = 0x0010,  
    catConstructor         = 0x0020,  
    catMethod              = 0x0040,  
    catProperty            = 0x0080,  
    catField               = 0x0100,  
    catEvent               = 0x0200,  
    catInterface           = 0x0400,  
    catParameter           = 0x0800,  
    catDelegate            = 0x1000,  
    catGenericParameter    = 0x4000,  
  
    catAll                 =
        catAssembly | catModule | catClass | catStruct |
        catEnum | catConstructor | catMethod | catProperty |
        catField | catEvent | catInterface | catParameter |
        catDelegate | catGenericParameter,  
  
    catClassMembers        =
        catClass | catStruct | catEnum | catConstructor |
        catMethod | catProperty | catField | catEvent |
        catDelegate | catInterface  
  
} CorAttributeTargets;  
```  
  
## <a name="members"></a>Члены  
  
|Член|Описание|  
|------------|-----------------|  
|`catAssembly`|Атрибут может быть применен к сборке.|  
|`catModule`|Атрибут может применяться к переносимому исполняемому модулю (DLL или exe).|  
|`catClass`|Атрибут может быть применен к классу.|  
|`catStruct`|Атрибут может быть применен к структуре, т.е. может являться типом значения.|  
|`catEnum`|Атрибут может быть применен к перечислению.|  
|`catConstructor`|Атрибут может быть применен к конструктору.|  
|`catMethod`|Атрибут может быть применен к методу.|  
|`catProperty`|Атрибут может быть применен к свойству.|  
|`catField`|Атрибут может быть применен к полю.|  
|`catEvent`|Атрибут может быть применен к событию.|  
|`catInterface`|Атрибут может быть применен к интерфейсу.|  
|`catParameter`|Атрибут может быть применен к параметру.|  
|`catDelegate`|Атрибут может быть применен к делегату.|  
|`catGenericParameter`|Атрибут может быть применен к универсальному параметру.|  
|`catAll`|Атрибут может быть применен к любому элементу приложения.|  
|`catClassMembers`|Атрибут может применяться к члену класса.|  
  
## <a name="remarks"></a>Remarks  

 `CorAttributeTargets`Значения перечисления можно комбинировать с помощью битовой операции OR для получения предпочтительного сочетания.  
  
 Объект `CorAttributeTargets` параллельно управляет <xref:System.AttributeTargets?displayProperty=nameWithType> перечислением.  
  
## <a name="requirements"></a>Требования  

 **Платформы:** см. раздел [Требования к системе](../../get-started/system-requirements.md).  
  
 **Заголовок:** Корхдр. h  
  
 **Платформа .NET Framework версии:**[!INCLUDE[net_current_v10plus](../../../../includes/net-current-v10plus-md.md)]  
  
## <a name="see-also"></a>См. также

- [Перечисления метаданных](metadata-enumerations.md)
