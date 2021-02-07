---
description: Дополнительные сведения о операторе GetType (Visual Basic)
title: GetType Operator
ms.date: 07/20/2015
f1_keywords:
- vb.GetType
helpviewer_keywords:
- GetType operator [Visual Basic]
- GetType keyword [Visual Basic]
ms.assetid: 4f733297-2503-4607-850c-15eba65fff90
ms.openlocfilehash: 15fe9c28997aa01527f23c0cc8fdbb0fe6cc53f7
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99665995"
---
# <a name="gettype-operator-visual-basic"></a>Оператор GetType (Visual Basic)

Возвращает <xref:System.Type> объект для указанного типа. <xref:System.Type>Объект предоставляет сведения о типе, например его свойства, методы и события.  
  
## <a name="syntax"></a>Синтаксис  
  
```vb  
GetType(typename)  
```  
  
## <a name="parameters"></a>Параметры  
  
|Параметр|Описание|  
|---|---|  
|`typename`|Имя типа, для которого требуется получить сведения.|  
  
## <a name="remarks"></a>Remarks  

 `GetType`Оператор возвращает <xref:System.Type> объект для указанного объекта `typename` . Имя любого определенного типа можно передать в `typename` . Например:  
  
- Любой тип данных Visual Basic, например `Boolean` или `Date` .  
  
- Любой платформа .NET Framework класс, структура, модуль или интерфейс, например <xref:System.ArgumentException?displayProperty=nameWithType> или <xref:System.Double?displayProperty=nameWithType> .  
  
- Любой класс, структура, модуль или интерфейс, определенный приложением.  
  
- Любой массив, определенный приложением.  
  
- Любой делегат, определенный приложением.  
  
- Любое перечисление, определенное Visual Basic, платформа .NET Framework или вашего приложения.  
  
 Если требуется получить объект типа объектной переменной, используйте <xref:System.Type.GetType%2A?displayProperty=nameWithType> метод.  
  
 `GetType`Оператор может быть полезен в следующих случаях:  
  
- Необходимо получить доступ к метаданным для типа во время выполнения. <xref:System.Type>Объект предоставляет метаданные, такие как члены типов и сведения о развертывании. Это необходимо, например, для отражения сборки. Для получения дополнительной информации см. <xref:System.Reflection?displayProperty=nameWithType>.  
  
- Необходимо сравнить две ссылки на объект, чтобы определить, ссылаются ли они на экземпляры одного типа. В противном случае `GetType` возвращает ссылки на один и тот же <xref:System.Type> объект.  
  
## <a name="example"></a>Пример  

 В следующих примерах показан используемый `GetType` оператор.  
  
 [!code-vb[VbVbalrOperators#26](~/samples/snippets/visualbasic/VS_Snippets_VBCSharp/VbVbalrOperators/VB/Class1.vb#26)]  
  
## <a name="see-also"></a>См. также

- [Порядок применения операторов в Visual Basic](operator-precedence.md)
- [Список операторов, сгруппированных по функциональному назначению](operators-listed-by-functionality.md)
- [Операторы и выражения](../../programming-guide/language-features/operators-and-expressions/index.md)
