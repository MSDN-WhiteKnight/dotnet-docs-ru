---
description: Дополнительные сведения см. в статье как вызвать процедуру свойства (Visual Basic).
title: Практическое руководство. Вызов процедуры свойства
ms.date: 07/20/2015
helpviewer_keywords:
- Visual Basic code, procedures
- Visual Basic code, properties
- procedures [Visual Basic], calling
- properties [Visual Basic], property procedures
- procedure calls [Visual Basic], property procedures
ms.assetid: 96bc4d74-d9c3-4b7a-954d-58ac8553cd94
ms.openlocfilehash: 541768cb6381aa3d2b1bf75267c5b34a82a3d2ab
ms.sourcegitcommit: 10e719780594efc781b15295e499c66f316068b8
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/14/2021
ms.locfileid: "100466761"
---
# <a name="how-to-call-a-property-procedure-visual-basic"></a>Практическое руководство. Вызов процедуры свойства (Visual Basic)

Процедура свойства вызывается путем сохранения значения в свойстве или извлечения его значения. Доступ к свойству осуществляется так же, как и к переменной.  
  
 `Set`Процедура свойства сохраняет значение, и его `Get` процедура получает значение. Однако эти процедуры не вызываются явным образом по имени. Свойство используется в операторе присваивания или в выражении так же, как и при хранении или извлечении значения переменной. Visual Basic выполняет вызовы процедур свойств.  
  
### <a name="to-call-a-propertys-get-procedure"></a>Вызов процедуры Get свойства  
  
1. Используйте имя свойства в выражении так же, как при использовании имени переменной. Свойство можно использовать в любом месте, где можно использовать переменную или константу.  
  
     -или-  
  
     Используйте имя свойства после знака равенства ( `=` ) в операторе присваивания.  
  
     В следующем примере считывается значение <xref:Microsoft.VisualBasic.DateAndTime.Now%2A> свойства, неявно вызывающего его `Get` процедуру.  
  
     [!code-vb[VbVbalrDateProperties#4](~/samples/snippets/visualbasic/VS_Snippets_VBCSharp/VbVbalrDateProperties/VB/Module1.vb#4)]  
  
2. Если свойство принимает аргументы, следует следовать имени свойства с круглыми скобками, чтобы заключить список аргументов. Если аргументы отсутствуют, можно дополнительно опустить круглые скобки.  
  
3. Поместите аргументы в список аргументов в круглых скобках, разделяя их запятыми. Убедитесь, что аргументы указываются в том же порядке, в котором свойство определяет соответствующие параметры.  
  
 Значение свойства участвует в выражении точно так же, как переменная или константа, либо хранится в переменной или свойстве в левой части оператора присваивания.  
  
### <a name="to-call-a-propertys-set-procedure"></a>Вызов процедуры Set свойства  
  
1. Используйте имя свойства в левой части оператора присваивания.  
  
     В следующем примере задается значение <xref:Microsoft.VisualBasic.DateAndTime.TimeOfDay%2A> свойства, которое неявно вызывает `Set` процедуру.  
  
     [!code-vb[VbVbcnProcedures#11](~/samples/snippets/visualbasic/VS_Snippets_VBCSharp/VbVbcnProcedures/VB/Class1.vb#11)]  
  
2. Если свойство принимает аргументы, следует следовать имени свойства с круглыми скобками, чтобы заключить список аргументов. Если аргументы отсутствуют, можно дополнительно опустить круглые скобки.  
  
3. Поместите аргументы в список аргументов в круглых скобках, разделяя их запятыми. Убедитесь, что аргументы указываются в том же порядке, в котором свойство определяет соответствующие параметры.  
  
 Значение, созданное в правой части оператора присваивания, хранится в свойстве.  
  
## <a name="see-also"></a>См. также раздел

- [Процедуры свойств](./property-procedures.md)
- [Параметры и аргументы процедуры](./procedure-parameters-and-arguments.md)
- [Property Statement](../../../language-reference/statements/property-statement.md)
- [Различия между свойствами и переменными в Visual Basic](./differences-between-properties-and-variables.md)
- [Практическое руководство. Создание свойства](./how-to-create-a-property.md)
- [Практическое руководство. Объявление свойства со смешанным уровнем доступа](./how-to-declare-a-property-with-mixed-access-levels.md)
- [Практическое руководство. Объявление и вызов свойства по умолчанию в Visual Basic](./how-to-declare-and-call-a-default-property.md)
- [Практическое руководство. Запись значения в свойство](./how-to-put-a-value-in-a-property.md)
- [Практическое руководство. Получение значения из свойства](./how-to-get-a-value-from-a-property.md)
- [Оператор Get](../../../language-reference/statements/get-statement.md)
- [Инструкция SET](../../../language-reference/statements/set-statement.md)
