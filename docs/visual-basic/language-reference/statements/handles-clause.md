---
description: 'Дополнительные сведения о предложении: Handles (Visual Basic)'
title: Предложение Handles
ms.date: 07/20/2015
f1_keywords:
- Handles
- vb.Handles
helpviewer_keywords:
- Handles keyword [Visual Basic]
ms.assetid: 1b051c0e-f499-42f6-acb5-6f4f27824b40
ms.openlocfilehash: 2bddfdecc163feacaaf042a7928ab16af324b0a3
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99769030"
---
# <a name="handles-clause-visual-basic"></a>Предложение Handles (Visual Basic)

Заявляет, что процедура обрабатывает указанное событие.  
  
## <a name="syntax"></a>Синтаксис  
  
```vb  
proceduredeclaration Handles eventlist  
```  
  
## <a name="parts"></a>Компоненты  

 `proceduredeclaration`  
 Объявление процедуры `Sub` для процедуры, которая будет обрабатывать событие.  
  
 `eventlist`  
 Список событий, обрабатываемых `proceduredeclaration`, с разделителями-запятыми. События должны вызываться базовым классом для текущего класса либо объектом, объявленным с помощью ключевого слова `WithEvents`.  
  
## <a name="remarks"></a>Remarks  

 Используйте ключевое слово `Handles` в конце объявления процедуры, чтобы она обрабатывала события, вызванные переменной объекта, которая объявлена с помощью ключевого слова `WithEvents` . Ключевое слово `Handles` может также использоваться в производном классе для обработки событий из базового класса.  
  
 Как ключевое слово `Handles` так и оператор `AddHandler` позволяют задать обработку определенных событий конкретными процедурами, но между ними существуют различия. Используйте ключевое слово `Handles` при определении процедуры, чтобы указать, что она обрабатывает определенное событие. Оператор `AddHandler` подключает процедуры к событиям во время выполнения. Дополнительные сведения см. в разделе [оператор AddHandler](addhandler-statement.md).  
  
 Для пользовательских событий приложение вызывает метод доступа `AddHandler` события во время добавления процедуры в качестве обработчика событий. Дополнительные сведения о пользовательских событиях см. в разделе [оператор Event](event-statement.md).  
  
## <a name="example"></a>Пример  

 [!code-vb[VbVbalrEvents#2](~/samples/snippets/visualbasic/VS_Snippets_VBCSharp/VbVbalrEvents/VB/Class1.vb#2)]  
  
 В следующем примере показано, как производный класс может использовать оператор `Handles` для обработки события из базового класса.  
  
 [!code-vb[VbVbalrEvents#3](~/samples/snippets/visualbasic/VS_Snippets_VBCSharp/VbVbalrEvents/VB/Class1.vb#3)]  
  
## <a name="example"></a>Пример  

 Следующий пример содержит два обработчика событий кнопки для проекта **приложения WPF** .  
  
 [!code-vb[VbVbalrEvents#41](~/samples/snippets/visualbasic/VS_Snippets_VBCSharp/VbVbalrEvents/VB/class3.vb#41)]  
  
## <a name="example"></a>Пример  

 Следующий пример эквивалентен предыдущему примеру: `eventlist` в предложении `Handles` содержит события для обеих кнопок.  
  
 [!code-vb[VbVbalrEvents#42](~/samples/snippets/visualbasic/VS_Snippets_VBCSharp/VbVbalrEvents/VB/class3.vb#42)]  
  
## <a name="see-also"></a>См. также

- [WithEvents](../modifiers/withevents.md)
- [Оператор AddHandler](addhandler-statement.md)
- [Оператор RemoveHandler](removehandler-statement.md)
- [Оператор Event](event-statement.md)
- [Оператор RaiseEvent](raiseevent-statement.md)
- [События](../../programming-guide/language-features/events/index.md)
