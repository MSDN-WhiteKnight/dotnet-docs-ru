---
description: 'Дополнительные сведения о: WithEvents (Visual Basic)'
title: WithEvents
ms.date: 07/20/2015
f1_keywords:
- vb.WithEvents
- WithEvents
helpviewer_keywords:
- WithEvents keyword [Visual Basic]
ms.assetid: 19d461f5-d72f-4de9-8c1d-0a6650316990
ms.openlocfilehash: b27f84fe54aaa10bc9b2359cd74fad3d3ace1ad5
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99674770"
---
# <a name="withevents-visual-basic"></a>WithEvents (Visual Basic)

Указывает, что одна или несколько объявленных переменных-членов ссылаются на экземпляр класса, который может создавать события.

## <a name="remarks"></a>Remarks

Если переменная определена с помощью `WithEvents` , можно декларативно указать, что метод обрабатывает события переменной с помощью `Handles` ключевого слова.

Можно использовать `WithEvents` только на уровне класса или модуля. Это означает, что контекст объявления для `WithEvents` переменной должен быть классом или модулем и не может быть исходным файлом, пространством имен, структурой или процедурой.

Нельзя использовать `WithEvents` в члене структуры.

Можно объявлять только отдельные переменные, а не массивы, с помощью `WithEvents` .

## <a name="rules"></a>Правила

**Типы элементов.** Переменные должны быть объявлены как `WithEvents` переменные объекта, чтобы они могли принимать экземпляры класса. Однако их нельзя объявить как `Object` . Их необходимо объявить в качестве конкретного класса, который может вызывать события.

`WithEvents`Модификатор можно использовать в этом контексте: [оператор Dim](../statements/dim-statement.md)

## <a name="example"></a>Пример

```vb
Dim WithEvents app As Application
```

## <a name="see-also"></a>См. также

- [Маркеры](../statements/handles-clause.md)
- [Ключевые слова](../keywords/index.md)
- [События](../../programming-guide/language-features/events/index.md)
