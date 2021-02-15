---
description: 'Подробнее: объектные переменные в Visual Basic'
title: Объектные переменные
ms.date: 07/20/2015
helpviewer_keywords:
- object variables [Visual Basic], about object variables
- variables [Visual Basic], object
- objects [Visual Basic], accessing
- object variables [Visual Basic]
ms.assetid: 6169a196-2b13-4ba5-a205-154bc1b87844
ms.openlocfilehash: 7c50dcbac32cdc841e513765d62f6ee711fc6049
ms.sourcegitcommit: 10e719780594efc781b15295e499c66f316068b8
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/14/2021
ms.locfileid: "100478845"
---
# <a name="object-variables-in-visual-basic"></a>Объектные переменные в Visual Basic

Помимо непосредственного хранения значений, переменная может ссылаться на объект. Объект присваивается переменной по тем же причинам, что вы присваиваете переменной значение.

- Имя переменной часто короче и проще в запоминании, чем полный путь к методам и свойствам, необходимым для доступа к самому объекту.

- Использование переменной, ссылающейся на объект, является более эффективным, чем многократный доступ к самому объекту через необходимые методы или свойства.

- Вы можете изменить переменную, чтобы она ссылалась на другие объекты во время выполнения кода.

## <a name="making-code-shorter"></a>Сокращение кода

Переменные объекта можно использовать для сокращения кода, который необходимо ввести. В следующем примере используется полный путь к методам и свойствам для доступа к <xref:System.Windows.Forms.Control> объекту.

```vb
' Assume Me is a valid Form, or replace Me with a valid Form.
Me.ActiveForm.ActiveControl.Text = "Test"
Me.ActiveForm.ActiveControl.Location = New Point(100, 100)
Me.ActiveForm.ActiveControl.Show()
```

Этот код можно сократить и ускорить выполнение, если для элемента управления используется объектная переменная. Необходимо объявить объектную переменную с конкретным классом, который вы хотите присвоить ему ( `Control` в данном случае). После присвоения объекта переменной ее можно обрабатывать точно так же, как и объект, к которому он относится. Можно задать или получить свойства объекта или использовать любой из его методов. В следующем примере используется объектная переменная для упрощения кода в предыдущем примере.

```vb
Dim ctrlActv As System.Windows.Forms.Control = Me.ActiveForm.ActiveControl
ctrlActv.Text = "Test"
ctrlActv.Location = New Point(100, 100)
ctrlActv.Show()
```

## <a name="see-also"></a>См. также раздел

- [Объявление переменной](variable-declaration.md)
- [Практическое руководство. Увеличение скорости доступа к объекту с длинным классификационным путем](how-to-speed-up-access-to-an-object-with-a-long-qualification-path.md)
- [Объявление объектной переменной](object-variable-declaration.md)
- [Присваивание объектных переменных](object-variable-assignment.md)
- [Значения объектных переменных](object-variable-values.md)
