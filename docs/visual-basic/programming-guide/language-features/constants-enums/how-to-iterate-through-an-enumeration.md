---
description: Дополнительные сведения см. в статье как выполнить итерацию перечисления в Visual Basic
title: Практическое руководство. Перебор элементов перечисления
ms.date: 07/20/2015
helpviewer_keywords:
- arrays [Visual Basic], iterating
- enumerations [Visual Basic], iterating
- ListBox control [Windows Forms], populating from an enumeration
ms.assetid: e5aa10eb-cfcd-4a3b-8e76-f06b8f2002be
ms.openlocfilehash: a14d65a33e8a2f7872203a6a332dec1e753704f8
ms.sourcegitcommit: 10e719780594efc781b15295e499c66f316068b8
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/14/2021
ms.locfileid: "100471569"
---
# <a name="how-to-iterate-through-an-enumeration-in-visual-basic"></a>Практическое руководство. Перебор элементов перечисления в Visual Basic

Перечисления — это удобный способ работать с наборами связанных констант и связывать постоянные значения с именами. Чтобы выполнить итерацию по перечислению, можно переместить его в массив с помощью <xref:System.Enum.GetValues%2A> метода. Можно также выполнить итерацию перечисления с помощью `For...Each` инструкции, используя <xref:System.Enum.GetNames%2A> <xref:System.Enum.GetValues%2A> метод или для извлечения строкового или числового значения.  
  
### <a name="to-iterate-through-an-enumeration"></a>Перебор перечислений  
  
- Объявите массив и преобразуйте перечисление в него с помощью <xref:System.Enum.GetValues%2A> метода, прежде чем передавать массив, как и любую другую переменную. В следующем примере отображается каждый элемент перечисления по <xref:Microsoft.VisualBasic.FirstDayOfWeek> мере его итерации по перечислению.  
  
     [!code-vb[VbEnumsTask#7](~/samples/snippets/visualbasic/VS_Snippets_VBCSharp/VbEnumsTask/VB/Class2.vb#7)]  
  
## <a name="see-also"></a>См. также раздел

- [Общие сведения о перечислениях](enumerations-overview.md)
- [Практическое руководство. Объявление перечисления](how-to-declare-enumerations.md)
- [Когда следует использовать перечисление](when-to-use-an-enumeration.md)
- [Практическое руководство. Определение строки, связанной со значением из перечисления](how-to-determine-the-string-associated-with-an-enumeration-value.md)
- [Практическое руководство. Ссылка на элемент перечисления](how-to-refer-to-an-enumeration-member.md)
- [Перечисления и уточнение имен](enumerations-and-name-qualification.md)
- [Массивы](../arrays/index.md)
