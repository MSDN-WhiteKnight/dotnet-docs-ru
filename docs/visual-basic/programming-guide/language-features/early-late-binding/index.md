---
description: 'Дополнительные сведения: раннее и позднее связывание (Visual Basic)'
title: Раннее и позднее связывание
ms.date: 07/20/2015
helpviewer_keywords:
- early binding [Visual Basic]
- objects [Visual Basic], late-bound
- objects [Visual Basic], early-bound
- objects [Visual Basic], late bound
- early binding [Visual Basic], Visual Basic compiler
- binding [Visual Basic], late and early
- objects [Visual Basic], early bound
- Visual Basic compiler, early and late binding
- late binding [Visual Basic]
- late binding [Visual Basic], Visual Basic compiler
ms.assetid: d6ff7f1e-b94f-4205-ab8d-5cfa91758724
ms.openlocfilehash: 1cdffe70035630ec56de04c54d7861283e1b5599
ms.sourcegitcommit: 10e719780594efc781b15295e499c66f316068b8
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/14/2021
ms.locfileid: "100475634"
---
# <a name="early-and-late-binding-visual-basic"></a>Раннее и позднее связывание (Visual Basic)

Компилятор Visual Basic выполняет процесс, вызываемый `binding` при назначении объекта переменной объекта. Объект является объектом *с ранним связыванием*, если он присвоен переменной, объявленной с определенным типом объекта. Объекты с ранним связыванием позволяют компилятору выделять память и выполнять оптимизацию еще до запуска приложения. Например, в следующем фрагменте кода объявляется переменная типа <xref:System.IO.FileStream>:  
  
 [!code-vb[VbVbalrOOP#90](~/samples/snippets/visualbasic/VS_Snippets_VBCSharp/VbVbalrOOP/VB/OOP.vb#90)]  
  
 Так как <xref:System.IO.FileStream> — это тип конкретного объекта, для присвоенного переменной `FS` экземпляра происходит раннее связывание.  
  
 И наоборот, объект является объектом *с поздним связыванием*, если он присваивается переменной, объявленной с типом `Object`. Объекты этого типа могут содержать ссылки на любой объект, но теряют многие преимущества раннего связывания. Например, следующий фрагмент кода объявляет переменную объекта для хранения объекта, возвращаемого функцией `CreateObject`:  
  
 [!code-vb[VbVbalrOOP#91](~/samples/snippets/visualbasic/VS_Snippets_VBCSharp/VbVbalrOOP/VB/LateBinding.vb#91)]  
  
## <a name="advantages-of-early-binding"></a>Преимущества раннего связывания  

 Раннее связывание объектов следует использовать везде, где это возможно, поскольку оно позволяет компилятору сделать важные оптимизации, повышающие эффективность приложений. Объекты с ранним связыванием работают значительно быстрее, чем объекты с поздним связыванием. Точное указание используемых объектов позволяет упростить чтение и обслуживание кода. Еще одним преимуществом раннего связывания является то, что он включает такие полезные функции, как автоматическое завершение кода и динамическая справка, поскольку интегрированная среда разработки (IDE) Visual Studio может точно определить тип объекта, с которым вы работаете при редактировании кода. Раннее связывание уменьшает количество и серьезность ошибок времени выполнения, так как позволяет компилятору фиксировать многие ошибки еще при компиляции программы.  
  
> [!NOTE]
> Позднее связывание применимо только для доступа к членам типа, объявленным как `Public`. Доступ к членам, объявленным как `Friend` или `Protected Friend`, приводит к ошибке времени выполнения.  
  
## <a name="see-also"></a>См. также раздел

- <xref:Microsoft.VisualBasic.Interaction.CreateObject%2A>
- [Время существования: создание и уничтожение объектов](../objects-and-classes/object-lifetime-how-objects-are-created-and-destroyed.md)
- [Object Data Type](../../../language-reference/data-types/object-data-type.md)
