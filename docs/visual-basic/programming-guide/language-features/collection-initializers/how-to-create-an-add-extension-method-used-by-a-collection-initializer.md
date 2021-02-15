---
description: Дополнительные сведения см. в статье как создать метод расширения, используемый инициализатором коллекции (Visual Basic)
title: Практическое руководство. Создание метода добавления расширения, используемого инициализатором коллекции
ms.date: 07/20/2015
helpviewer_keywords:
- collection initializers [Visual Basic]
ms.assetid: f64b52c7-8b11-4410-93a6-cb3aeebcc772
ms.openlocfilehash: 1fbe6f438c4761ae668a6bd6a0a2c38c8efdb439
ms.sourcegitcommit: 10e719780594efc781b15295e499c66f316068b8
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/14/2021
ms.locfileid: "100475478"
---
# <a name="how-to-create-an-add-extension-method-used-by-a-collection-initializer-visual-basic"></a>Практическое руководство. Создание метода расширения Add, используемого инициализатором набора (Visual Basic)

При использовании инициализатора коллекции для создания коллекции компилятор Visual Basic выполняет поиск `Add` метода типа коллекции, для которого параметры `Add` метода соответствуют типам значений в инициализаторе коллекции. Этот `Add` метод используется для заполнения коллекции значениями из инициализатора коллекции.  
  
 Если соответствующий `Add` метод не существует и вы не можете изменить код для коллекции, можно добавить метод расширения `Add` с именем, принимающий параметры, необходимые инициализатору коллекции. Обычно это необходимо сделать при использовании инициализаторов коллекций для универсальных коллекций.  
  
## <a name="example"></a>Пример  

 В следующем примере показано, как добавить метод расширения в универсальный тип, <xref:System.Collections.Generic.List%601> чтобы инициализатор коллекции можно было использовать для добавления объектов типа `Employee` . Метод расширения позволяет использовать сокращенный синтаксис инициализатора коллекции.  
  
 [!code-vb[VbVbalrCollectionInitializersHowTo1#1](~/samples/snippets/visualbasic/VS_Snippets_VBCSharp/VbVbalrCollectionInitializersHowTo1/VB/Module1.vb#1)]  
  
 [!code-vb[VbVbalrCollectionInitializersHowTo1#2](~/samples/snippets/visualbasic/VS_Snippets_VBCSharp/VbVbalrCollectionInitializersHowTo1/VB/Module1.vb#2)]  
  
 [!code-vb[VbVbalrCollectionInitializersHowTo1#3](~/samples/snippets/visualbasic/VS_Snippets_VBCSharp/VbVbalrCollectionInitializersHowTo1/VB/Module1.vb#3)]  
  
## <a name="see-also"></a>См. также раздел

- [Инициализаторы коллекций](index.md)
- [Практическое руководство. Создание коллекции с помощью инициализатора набора](how-to-create-a-collection-used-by-a-collection-initializer.md)
