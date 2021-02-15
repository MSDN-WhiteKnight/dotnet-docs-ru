---
description: 'Дополнительные сведения: как вызвать процедуру, которая не возвращает значение (Visual Basic).'
title: Практическое руководство. Вызов процедуры, которая не возвращает значение
ms.date: 07/20/2015
helpviewer_keywords:
- procedure calls [Visual Basic], returning values
- Visual Basic code, procedures
- procedures [Visual Basic], calling
ms.assetid: 259b49a3-a3c1-4254-ba8c-73cdc4127703
ms.openlocfilehash: 3aaa6b4358f0585323e6c8321eea7dbaa4906a44
ms.sourcegitcommit: 10e719780594efc781b15295e499c66f316068b8
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/14/2021
ms.locfileid: "100466774"
---
# <a name="how-to-call-a-procedure-that-does-not-return-a-value-visual-basic"></a>Практическое руководство. Вызов процедуры, которая не возвращает значение (Visual Basic)

`Sub`Процедура не возвращает значение в вызывающий код. Он вызывается явным образом с помощью изолированного вызывающего оператора. Его нельзя вызвать, просто используя его имя в выражении.  
  
### <a name="to-call-a-sub-procedure"></a>Вызов процедуры подпрограммы  
  
1. Укажите имя `Sub` процедуры.  
  
2. Чтобы заключить список аргументов, выполните имя процедуры с круглыми скобками. Если аргументы отсутствуют, можно дополнительно опустить круглые скобки. Однако использование круглых скобок упрощает чтение кода.  
  
3. Поместите аргументы в список аргументов в круглых скобках, разделяя их запятыми. Убедитесь, что аргументы указываются в том же порядке, в котором `Sub` процедура определяет соответствующие параметры.  
  
     В следующем примере вызывается <xref:Microsoft.VisualBasic.Interaction.AppActivate%2A> функция Visual Basic для активации окна приложения. <xref:Microsoft.VisualBasic.Interaction.AppActivate%2A> принимает заголовок окна в качестве единственного аргумента. Он не возвращает значение в вызывающий код. Если процесс «Блокнот» не выполняется, в примере создается исключение <xref:System.ArgumentException> . `Shell`Процедура предполагает, что приложения находятся в указанных путях.  
  
     [!code-vb[VbVbalrCatRef#11](~/samples/snippets/visualbasic/VS_Snippets_VBCSharp/VbVbalrCatRef/VB/Class1.vb#11)]  
  
## <a name="see-also"></a>См. также раздел

- <xref:Microsoft.VisualBasic.Interaction.Shell%2A>
- <xref:System.ArgumentException>
- [Процедуры](./index.md)
- [Подпрограммы](./sub-procedures.md)
- [Параметры и аргументы процедуры](./procedure-parameters-and-arguments.md)
- [Оператор Sub](../../../language-reference/statements/sub-statement.md)
- [Практическое руководство. Создание процедуры](./how-to-create-a-procedure.md)
- [Практическое руководство. Вызов процедуры, возвращающей значение](./how-to-call-a-procedure-that-returns-a-value.md)
- [Практическое руководство. Вызов обработчика событий в Visual Basic](./how-to-call-an-event-handler.md)
