---
description: 'Дополнительные сведения о: NotOverridable (Visual Basic)'
title: NotOverridable
ms.date: 07/20/2015
f1_keywords:
- vb.NotOverridable
- NotOverridable
helpviewer_keywords:
- sealed methods [Visual Basic]
- NotOverridable keyword [Visual Basic]
- properties [Visual Basic], redefining
- elements [Visual Basic], sealed
- sealed [elements VB]
- procedures [Visual Basic], overriding
- procedures [Visual Basic], redefining
- overriding
- methods [Visual Basic], sealed
- properties [Visual Basic], overriding
ms.assetid: 66ec6984-f5f5-4857-b362-6a3907aaf9e0
ms.openlocfilehash: f0363024aacc1ed6ab9d8820cc965b5b71e557b6
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99666099"
---
# <a name="notoverridable-visual-basic"></a>NotOverridable (Visual Basic)

Указывает, что свойство или процедура не могут быть переопределены в производном классе.  
  
## <a name="remarks"></a>Remarks  

 `NotOverridable`Модификатор предотвращает переопределение свойства или метода в производном классе.  Модификатор [Overridable](overridable.md) позволяет переопределять свойство или метод в производном классе. Дополнительные сведения см. в статье [Inheritance Basics (Visual Basic)](../../programming-guide/language-features/objects-and-classes/inheritance-basics.md) (Основная информация о наследовании в Visual Basic).  
  
 Если `Overridable` Модификатор или `NotOverridable` не задан, значение по умолчанию зависит от того, переопределяет ли свойство или метод свойство или метод базового класса. Если свойство или метод переопределяет свойство или метод базового класса, параметр по умолчанию имеет значение `Overridable` ; в противном случае — `NotOverridable` .  
  
 Элемент, который не может быть переопределен, иногда называется *запечатанным* элементом.  
  
 Можно использовать `NotOverridable` только в операторе объявления свойства или процедуры. Можно указать `NotOverridable` только для свойства или процедуры, которые переопределяют другое свойство или процедуру, то есть только в сочетании с `Overrides` .  
  
## <a name="combined-modifiers"></a>Комбинированные модификаторы  

 Нельзя указывать `Overridable` или `NotOverridable` для `Private` метода.  
  
 Нельзя указывать `NotOverridable` вместе с `MustOverride` , `Overridable` или `Shared` в одном объявлении.  
  
## <a name="usage"></a>Использование  

 Модификатор `NotOverridable` можно использовать в следующих контекстах:  
  
 [Оператор Function](../statements/function-statement.md)  
  
 [Property Statement](../statements/property-statement.md)  
  
 [Оператор Sub](../statements/sub-statement.md)  
  
## <a name="see-also"></a>См. также

- [Модификаторы](index.md)
- [Основы наследования](../../programming-guide/language-features/objects-and-classes/inheritance-basics.md)
- [MustOverride](mustoverride.md)
- [Overridable](overridable.md)
- [Переопределения](overrides.md)
- [Ключевые слова](../keywords/index.md)
- [Сокрытие в Visual Basic](../../programming-guide/language-features/declared-elements/shadowing.md)
