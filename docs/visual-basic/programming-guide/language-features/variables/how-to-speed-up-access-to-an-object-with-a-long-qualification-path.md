---
description: Дополнительные сведения о том, как ускорить доступ к объекту с длинным квалификационным путем (Visual Basic).
title: Практическое руководство. Увеличение скорости доступа к объекту с длинным классификационным путем
ms.date: 07/20/2015
helpviewer_keywords:
- variables [Visual Basic], accessing
- variables [Visual Basic], object
- With statement [Visual Basic]
- With block
- object variables [Visual Basic], accessing
ms.assetid: 3eb7657f-c9fe-4e05-8bc3-4bb14d5ae585
ms.openlocfilehash: 8e0b5dc2ab6c23d57a4e9d905cfd711a79843185
ms.sourcegitcommit: 10e719780594efc781b15295e499c66f316068b8
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/14/2021
ms.locfileid: "100467047"
---
# <a name="how-to-speed-up-access-to-an-object-with-a-long-qualification-path-visual-basic"></a>Практическое руководство. Увеличение скорости доступа к объекту с длинным классификационным путем (Visual Basic)

При частом доступе к объекту, для которого требуется квалификация пути нескольких методов и свойств, можно ускорить код, не повторив классификационный путь.

Существует два способа избежать повторения пути для уточнения. Объект можно назначить переменной или использовать в `With` блоке.... `End With`

### <a name="to-speed-up-access-to-a-heavily-qualified-object-by-assigning-it-to-a-variable"></a>Ускорение доступа к сильно известному объекту путем присвоения его переменной

1. Объявите переменную типа объекта, к которому часто осуществляется доступ. Укажите классификационный путь в части инициализации объявления.

    ```vb
    Dim ctrlActv As Control = someForm.ActiveForm.ActiveControl
    ```

2. Используйте переменную для доступа к членам объекта.

    ```vb
    ctrlActv.Text = "Test"
    ctrlActv.Location = New Point(100, 100)
    ctrlActv.Show()
    ```

### <a name="to-speed-up-access-to-a-heavily-qualified-object-by-using-a-withend-with-block"></a>Для ускорения доступа к сильно известному объекту с помощью метода with... Конец блока

1. Укажите классификационный путь в `With` операторе.

    ```vb
    With someForm.ActiveForm.ActiveControl
    ```

2. Получите доступ к членам объекта внутри `With` блока перед `End With` инструкцией.

    ```vb
        .Text = "Test"
        .Location = New Point(100, 100)
        .Show()
    End With
    ```

## <a name="see-also"></a>См. также раздел

- [Объектные переменные](object-variables.md)
- [Оператор With…End With](../../../language-reference/statements/with-end-with-statement.md)
