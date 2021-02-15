---
description: 'Дополнительные сведения: массивы параметров (Visual Basic)'
title: Массивы параметров
ms.date: 07/20/2015
helpviewer_keywords:
- parameter arrays [Visual Basic], about parameter arrays
- ParamArray keyword [Visual Basic], parameter arrays
- Visual Basic code, procedures
- parameters [Visual Basic], parameter arrays
- arguments [Visual Basic], parameter arrays
- procedures [Visual Basic], indefinite number of argument values
- arrays [Visual Basic], parameter arrays
ms.assetid: c43edfae-9114-4096-9ebc-8c5c957a1067
ms.openlocfilehash: e71524d9d62f0ece3a8310934eba15e9db16aaa1
ms.sourcegitcommit: 10e719780594efc781b15295e499c66f316068b8
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/14/2021
ms.locfileid: "100427587"
---
# <a name="parameter-arrays-visual-basic"></a>Массивы параметров (Visual Basic)

Как правило, процедуру нельзя вызывать с дополнительными аргументами, чем указано в объявлении процедуры. Если требуется неопределенное число аргументов, можно объявить *массив параметров*, который позволяет процедуре принимать массив значений для параметра. При определении процедуры вам не нужно было узнать число элементов в массиве параметров. Размер массива определяется отдельно при каждом вызове процедуры.  
  
## <a name="declaring-a-paramarray"></a>Объявление ParamArray  

 Используйте ключевое слово [ParamArray](../../../language-reference/modifiers/paramarray.md) для обозначения массива параметров в списке параметров. Применяются следующие правила.  
  
- Процедура может определять только один массив параметров и должен быть последним параметром в определении процедуры.  
  
- Массив параметров должен передаваться по значению. Рекомендуется явно включать в определение процедуры ключевое слово [ByVal](../../../language-reference/modifiers/byval.md) .  
  
- Массив параметров является автоматически необязательным. Его значением по умолчанию является пустой одномерный массив типа элемента массива параметров.  
  
- Должны быть необходимы все параметры, предшествующие массиву параметров. Массив параметров должен быть единственным необязательным параметром.  
  
## <a name="calling-a-paramarray"></a>Вызов метода ParamArray  

 При вызове процедуры, определяющей массив параметров, можно указать аргумент одним из следующих способов:  
  
- Нет, то есть можно опустить аргумент [ParamArray](../../../language-reference/modifiers/paramarray.md) . В этом случае в процедуру передается пустой массив. При явном передаче ключевого слова [Nothing](../../../language-reference/nothing.md) в процедуру передается пустой массив, который может привести к NullReferenceException, если вызываемая процедура не проверяет это условие.
  
- Список произвольного числа аргументов, разделенных запятыми. Тип данных каждого аргумента должен быть неявно преобразован в `ParamArray` тип элемента.  
  
- Массив с тем же типом элемента, что и у типа элемента массива параметров.  
  
 Во всех случаях код в процедуре обрабатывает массив параметров как одномерный массив с элементами того же типа данных, что и `ParamArray` тип данных.  
  
> [!IMPORTANT]
> Всякий раз при работе с массивом, который может быть неограниченным большим, существует риск перегрузки внутренней емкости приложения. Если вы принимаете массив параметров, следует проверить размер массива, которому был передан вызывающий код. Выполните соответствующие действия, если оно слишком велико для вашего приложения. Дополнительные сведения см. в статье [Arrays (C++/CLI and C++/CX)](../arrays/index.md) (Массивы (C++/CLI и C++/CX)).  
  
## <a name="example"></a>Пример  

 В следующем примере определяется и вызывается функция `calcSum` . `ParamArray`Модификатор для параметра `args` позволяет функции принимать переменное число аргументов.  
  
 [!code-vb[VbVbalrStatements#26](~/samples/snippets/visualbasic/VS_Snippets_VBCSharp/VbVbalrStatements/VB/Class1.vb#26)]  
  
 В следующем примере определяется процедура с массивом параметров и выводятся значения всех элементов массива, переданных в массив параметров.  
  
 [!code-vb[VbVbcnProcedures#48](~/samples/snippets/visualbasic/VS_Snippets_VBCSharp/VbVbcnProcedures/VB/Class1.vb#48)]  
  
 [!code-vb[VbVbcnProcedures#49](~/samples/snippets/visualbasic/VS_Snippets_VBCSharp/VbVbcnProcedures/VB/Class1.vb#49)]  
  
## <a name="see-also"></a>См. также раздел

- <xref:Microsoft.VisualBasic.Information.UBound%2A>
- [Процедуры](./index.md)
- [Параметры и аргументы процедуры](./procedure-parameters-and-arguments.md)
- [Передача аргументов по значению и по ссылке](./passing-arguments-by-value-and-by-reference.md)
- [Передача аргументов по позиции и по имени](./passing-arguments-by-position-and-by-name.md)
- [Необязательные параметры](./optional-parameters.md)
- [Перегрузка процедур](./procedure-overloading.md)
- [Массивы](../arrays/index.md)
- [Необязательно](../../../language-reference/modifiers/optional.md)
