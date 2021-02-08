---
description: 'Дополнительные сведения о: MustOverride (Visual Basic)'
title: MustOverride
ms.date: 07/20/2015
f1_keywords:
- vb.MustOverride
- MustOverride
helpviewer_keywords:
- virtual elements [Visual Basic], pure
- elements [Visual Basic], pure virtual
- properties [Visual Basic], redefining
- procedures [Visual Basic], overriding
- overriding, MustOverride keyword
- procedures [Visual Basic], redefining
- pure virtual elements [Visual Basic]
- MustOverride keyword [Visual Basic]
- properties [Visual Basic], overriding
ms.assetid: 6e9d9ad6-bb64-433f-b32b-3ef84293bf96
ms.openlocfilehash: df7200a7f7ec4bfda34765747d6318bc50a38dd1
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99774529"
---
# <a name="mustoverride-visual-basic"></a>MustOverride (Visual Basic)

Указывает, что свойство или процедура не реализованы в этом классе и должны быть переопределены в производном классе, прежде чем его можно будет использовать.  
  
## <a name="remarks"></a>Remarks  

 Можно использовать `MustOverride` только в операторе объявления свойства или процедуры. Свойство или процедура, указывающие, `MustOverride` должен быть членом класса, а класс должен быть помечен как [MustInherit](mustinherit.md).  
  
## <a name="rules"></a>Правила  
  
- **Неполное объявление.** При указании `MustOverride` не предоставляется никаких дополнительных строк кода для свойства или процедуры, а не `End Function` `End Property` инструкции, или `End Sub` .  
  
- **Комбинированные модификаторы.** Нельзя указывать `MustOverride` вместе с `NotOverridable` , `Overridable` или `Shared` в одном объявлении.  
  
- **Сокрытие и переопределение.** Сокрытие и переопределение заменяют наследуемый элемент, но между этими подходами существуют значительные различия. Дополнительные сведения см. [в разделе теневая поддержка в Visual Basic](../../programming-guide/language-features/declared-elements/shadowing.md).  
  
- **Альтернативные условия.** Элемент, который нельзя использовать, за исключением переопределения, иногда называют *чисто виртуальным* элементом.  
  
 Модификатор `MustOverride` можно использовать в следующих контекстах:  
  
 [Оператор Function](../statements/function-statement.md)  
  
 [Property Statement](../statements/property-statement.md)  
  
 [Оператор Sub](../statements/sub-statement.md)  
  
## <a name="see-also"></a>См. также

- [NotOverridable](notoverridable.md)
- [Overridable](overridable.md)
- [Переопределения](overrides.md)
- [MustInherit](mustinherit.md)
- [Ключевые слова](../keywords/index.md)
- [Сокрытие в Visual Basic](../../programming-guide/language-features/declared-elements/shadowing.md)
