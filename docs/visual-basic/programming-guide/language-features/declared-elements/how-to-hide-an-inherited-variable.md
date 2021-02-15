---
description: 'Дополнительные сведения: как скрыть унаследованную переменную (Visual Basic)'
title: Практическое руководство. Сокрытие наследуемой переменной
ms.date: 07/20/2015
helpviewer_keywords:
- qualification [Visual Basic], of element names
- element names [Visual Basic], qualification
- references [Visual Basic], declared elements
- declaration statements [Visual Basic], declared elements
- referencing declared elements [Visual Basic]
- declared elements [Visual Basic], referencing
- declared elements [Visual Basic], about declared elements
- variables [Visual Basic], hiding inherited
ms.assetid: 765728d9-7351-4a30-999d-b5f34f024412
ms.openlocfilehash: be2de980e27b318151c795ae36bd92a01d47d55e
ms.sourcegitcommit: 10e719780594efc781b15295e499c66f316068b8
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/14/2021
ms.locfileid: "100429901"
---
# <a name="how-to-hide-an-inherited-variable-visual-basic"></a>Практическое руководство. Сокрытие наследуемой переменной (Visual Basic)

Производный класс наследует все определения своего базового класса. Если необходимо определить переменную с тем же именем, что и у элемента базового класса, можно скрыть или *затенить* этот элемент базового класса при определении переменной в производном классе. В этом случае код в производном классе получает доступ к переменной, если только явно не обходит механизм теневого копирования.

Другой причиной, по которой может потребоваться скрыть унаследованную переменную, является защита от редакции базового класса. Базовый класс может повлиять на изменение, изменяющее элемент, который вы наследуете. Если это происходит, `Shadows` Модификатор заставляет ссылки из производного класса разрешаться в переменную, а не в элемент базового класса.

## <a name="to-hide-an-inherited-variable"></a>Скрытие унаследованной переменной

1. Убедитесь, что переменная, которую нужно скрыть, объявлена на уровне класса (вне любой процедуры). В противном случае скрыть ее не нужно.
  
2. Внутри производного класса напишите [оператор Dim](../../../language-reference/statements/dim-statement.md) , объявляющий переменную. Используйте то же имя, что и у унаследованной переменной.

3. Включите в объявление ключевое слово [Shadows](../../../language-reference/modifiers/shadows.md) .

     Если код в производном классе ссылается на имя переменной, компилятор разрешает ссылку на переменную.

     В следующем примере показано затенение наследуемой переменной.
  
    ```vb  
    Public Class ShadowBaseClass  
        Public shadowString As String = "This is the base class string."  
    End Class  
    Public Class ShadowDerivedClass  
        Inherits ShadowBaseClass  
        Public Shadows shadowString As String = "This is the derived class string."  
        Public Sub ShowStrings()  
            Dim s As String = $"Unqualified shadowString: {shadowString}{vbCrLf}MyBase.shadowString: {MyBase.shadowString}"
            MsgBox(s)  
        End Sub  
    End Class  
    ```  
  
     В предыдущем примере переменная объявляется `shadowString` в базовом классе и переобъявляется в производном классе. Процедура `ShowStrings` в производном классе отображает версию строки с тенью, если ее имя `shadowString` не является полным. После этого она отображает затененную версию, если `shadowString` дополнена `MyBase` ключевым словом.  
  
## <a name="robust-programming"></a>Отказоустойчивость

При затенении введено более одной версии переменной с тем же именем. Если инструкция Code ссылается на имя переменной, версия, на которую компилятор разрешает ссылку, зависит от таких факторов, как расположение инструкции Code и наличие подходящих строк. Это может увеличить риск обращения к непреднамеренной версии затененной переменной. Можно снизить этот риск, полностью подполняя все ссылки на затененную переменную.

## <a name="see-also"></a>См. также раздел

- [References to Declared Elements](references-to-declared-elements.md)
- [Сокрытие в Visual Basic](shadowing.md)
- [Различия между удаленным управлением и переопределением](differences-between-shadowing-and-overriding.md)
- [Практическое руководство. Сокрытие переменной с тем же именем, что и ваша переменная](how-to-hide-a-variable-with-the-same-name-as-your-variable.md)
- [Практическое руководство. Доступ к переменной, скрытой производным классом](how-to-access-a-variable-hidden-by-a-derived-class.md)
- [Переопределения](../../../language-reference/modifiers/overrides.md)
- [Me, My, MyBase и MyClass](../../program-structure/me-my-mybase-and-myclass.md)
- [Основы наследования](../objects-and-classes/inheritance-basics.md)
