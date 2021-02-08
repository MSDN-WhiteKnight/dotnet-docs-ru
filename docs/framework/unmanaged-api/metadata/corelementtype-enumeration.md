---
description: Дополнительные сведения о перечислении Корелементтипе
title: Перечисление CorElementType
ms.date: 03/30/2017
api_name:
- CorElementType
api_location:
- mscoree.dll
api_type:
- COM
f1_keywords:
- CorElementType
helpviewer_keywords:
- CorElementType enumeration [.NET Framework metadata]
ms.assetid: c3809c8f-1737-4f0f-9442-0c01ee689871
topic_type:
- apiref
ms.openlocfilehash: 3eaf75a6d2094ec875ab1861aac49e4382e65801
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99784539"
---
# <a name="corelementtype-enumeration"></a>Перечисление CorElementType

Задает среду CLR <xref:System.Type> , модификатор типа или сведения о типе в сигнатуре типа метаданных.

## <a name="syntax"></a>Синтаксис

```cpp
typedef enum CorElementType {
    ELEMENT_TYPE_END            = 0x0,
    ELEMENT_TYPE_VOID           = 0x1,
    ELEMENT_TYPE_BOOLEAN        = 0x2,
    ELEMENT_TYPE_CHAR           = 0x3,
    ELEMENT_TYPE_I1             = 0x4,
    ELEMENT_TYPE_U1             = 0x5,
    ELEMENT_TYPE_I2             = 0x6,
    ELEMENT_TYPE_U2             = 0x7,
    ELEMENT_TYPE_I4             = 0x8,
    ELEMENT_TYPE_U4             = 0x9,
    ELEMENT_TYPE_I8             = 0xa,
    ELEMENT_TYPE_U8             = 0xb,
    ELEMENT_TYPE_R4             = 0xc,
    ELEMENT_TYPE_R8             = 0xd,
    ELEMENT_TYPE_STRING         = 0xe,

    ELEMENT_TYPE_PTR            = 0xf,
    ELEMENT_TYPE_BYREF          = 0x10,

    ELEMENT_TYPE_VALUETYPE      = 0x11,
    ELEMENT_TYPE_CLASS          = 0x12,
    ELEMENT_TYPE_VAR            = 0x13,
    ELEMENT_TYPE_ARRAY          = 0x14,
    ELEMENT_TYPE_GENERICINST    = 0x15,
    ELEMENT_TYPE_TYPEDBYREF     = 0x16,

    ELEMENT_TYPE_I              = 0x18,
    ELEMENT_TYPE_U              = 0x19,
    ELEMENT_TYPE_FNPTR          = 0x1B,
    ELEMENT_TYPE_OBJECT         = 0x1C,
    ELEMENT_TYPE_SZARRAY        = 0x1D,
    ELEMENT_TYPE_MVAR           = 0x1e,

    ELEMENT_TYPE_CMOD_REQD      = 0x1F,
    ELEMENT_TYPE_CMOD_OPT       = 0x20,

    ELEMENT_TYPE_INTERNAL       = 0x21,
    ELEMENT_TYPE_MAX            = 0x22,

    ELEMENT_TYPE_MODIFIER       = 0x40,
    ELEMENT_TYPE_SENTINEL       = 0x01 | ELEMENT_TYPE_MODIFIER,
    ELEMENT_TYPE_PINNED         = 0x05 | ELEMENT_TYPE_MODIFIER

} CorElementType;
```

## <a name="members"></a>Члены

|Член|Описание|
|------------|-----------------|
|`ELEMENT_TYPE_END`|Для внутреннего использования.|
|`ELEMENT_TYPE_VOID`|Тип void.|
|`ELEMENT_TYPE_BOOLEAN`|Логический тип|
|`ELEMENT_TYPE_CHAR`|Тип символа.|
|`ELEMENT_TYPE_I1`|1-байтовое целое число со знаком.|
|`ELEMENT_TYPE_U1`|1-байтовое целое число без знака.|
|`ELEMENT_TYPE_I2`|2-байтовое целое число со знаком.|
|`ELEMENT_TYPE_U2`|2-байтовое целое число без знака.|
|`ELEMENT_TYPE_I4`|4-байтовое целое число со знаком.|
|`ELEMENT_TYPE_U4`|4-байтовое целое число без знака.|
|`ELEMENT_TYPE_I8`|8-байтовое целое число со знаком.|
|`ELEMENT_TYPE_U8`|8-байтовое целое число без знака.|
|`ELEMENT_TYPE_R4`|4-байтовое число с плавающей запятой.|
|`ELEMENT_TYPE_R8`|8-байтная плавающая точка.|
|`ELEMENT_TYPE_STRING`|Тип System. String.|
|`ELEMENT_TYPE_PTR`|Модификатор типа указателя.|
|`ELEMENT_TYPE_BYREF`|Модификатор ссылочного типа.|
|`ELEMENT_TYPE_VALUETYPE`|Модификатор типа значения.|
|`ELEMENT_TYPE_CLASS`|Модификатор типа класса.|
|`ELEMENT_TYPE_VAR`|Модификатор типа переменной класса.|
|`ELEMENT_TYPE_ARRAY`|Модификатор многомерного типа массива.|
|`ELEMENT_TYPE_GENERICINST`|Модификатор типа для универсальных типов.|
|`ELEMENT_TYPE_TYPEDBYREF`|Типизированная ссылка.|
|`ELEMENT_TYPE_I`|Размер собственного целого числа.|
|`ELEMENT_TYPE_U`|Размер целого числа без знака в машинном кодах.|
|`ELEMENT_TYPE_FNPTR`|Указатель на функцию.|
|`ELEMENT_TYPE_OBJECT`|Тип System. Object.|
|`ELEMENT_TYPE_SZARRAY`|Модификатор одномерного типа массива с нулевой нижней границей.|
|`ELEMENT_TYPE_MVAR`|Модификатор типа переменной метода.|
|`ELEMENT_TYPE_CMOD_REQD`|Обязательный модификатор языка C.|
|`ELEMENT_TYPE_CMOD_OPT`|Необязательный модификатор языка C.|
|`ELEMENT_TYPE_INTERNAL`|Для внутреннего использования.|
|`ELEMENT_TYPE_MAX`|Недопустимый тип.|
|`ELEMENT_TYPE_MODIFIER`|Для внутреннего использования.|
|`ELEMENT_TYPE_SENTINEL`|Модификатор типа, который является Sentinel для списка переменного числа параметров.|
|`ELEMENT_TYPE_PINNED`|Для внутреннего использования.|

## <a name="remarks"></a>Remarks

Модификаторы типа формируют базу для представления более сложных типов. `CorElementType`Значение модификатора типа применяется к значению, которое непосредственно следует за ним в сигнатуре типа. Значение, следующее за `CorElementType` значением модификатора типа, может быть `CorElementType` простым значением типа, маркером метаданных или другим значением, как указано в следующей таблице.

> [!NOTE]
> Все числа (*число*, число *аргументов*, *маркер метаданных*, *ранг*, *количество* и *граница*) хранятся в виде сжатых целых чисел. Дополнительные сведения см. в статье [стандартный ECMA-335-Common Language Infrastructure (CLI)](http://www.ecma-international.org/publications/standards/Ecma-335.htm) на веб-сайте ECMA.

|Модификатор типа|Формат|
|-------------------|------------|
|`ELEMENT_TYPE_PTR`|ELEMENT_TYPE_PTR \<a `CorElementType` value>|
|`ELEMENT_TYPE_BYREF`|ELEMENT_TYPE_BYREF \<a `CorElementType` value>|
|`ELEMENT_TYPE_VALUETYPE`|ELEMENT_TYPE_VALUETYPE \<an `mdTypeDef` metadata token>|
|`ELEMENT_TYPE_CLASS`|ELEMENT_TYPE_CLASS \<an `mdTypeDef` metadata token>|
|`ELEMENT_TYPE_VAR`|ELEMENT_TYPE_VAR \<number>|
|`ELEMENT_TYPE_ARRAY`|ELEMENT_TYPE_ARRAY \<a `CorElementType` value> \<rank> \<count1> \<bound1> ... \<countN>\<boundN>|
|`ELEMENT_TYPE_GENERICINST`|ELEMENT_TYPE_GENERICINST \<an `mdTypeDef` metadata token> \<argument Count> \<arg1> ... \<argN>|
|`ELEMENT_TYPE_FNPTR`|ELEMENT_TYPE_FNPTR \<complete signature for the function, including calling convention>|
|`ELEMENT_TYPE_SZARRAY`|ELEMENT_TYPE_SZARRAY \<a `CorElementType` value>|
|`ELEMENT_TYPE_MVAR`|ELEMENT_TYPE_MVAR \<number>|
|`ELEMENT_TYPE_CMOD_REQD`|ELEMENT_TYPE_\<a `mdTypeRef` or `mdTypeDef` metadata token>|
|`ELEMENT_TYPE_CMOD_OPT`|E_T_CMOD_OPT \<a `mdTypeRef` or `mdTypeDef` metadata token>|

## <a name="requirements"></a>Требования

**Платформы:** см. раздел [Требования к системе](../../get-started/system-requirements.md).

**Заголовок:** Корхдр. h

**Платформа .NET Framework версии:**[!INCLUDE[net_current_v10plus](../../../../includes/net-current-v10plus-md.md)]

## <a name="see-also"></a>См. также

- [Перечисления метаданных](metadata-enumerations.md)
