---
description: Дополнительные сведения о свойстве индексатора расширения (Visual Basic)
title: Свойство индексатора расширения
ms.date: 07/20/2015
f1_keywords:
- vb.XmlPropertyExtensionIndexer
helpviewer_keywords:
- Visual Basic code, accessing XML
- XML extension indexer [Visual Basic]
- extension indexer [Visual Basic]
- XML [Visual Basic], accessing
ms.assetid: a16a4b13-54be-432c-82b3-a87091464ada
ms.openlocfilehash: ec165836f739db9a74ea266ebba32be5bb42cca6
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99700329"
---
# <a name="extension-indexer-property-visual-basic"></a>Свойство-индексатор расширения (Visual Basic)

Обеспечивает доступ к отдельным элементам коллекции.  
  
## <a name="syntax"></a>Синтаксис  
  
```vb  
object(index)  
```  
  
## <a name="parts"></a>Компоненты  
  
|Термин|Определение|  
|---|---|  
|`object`|Обязательный. Запрашиваемая коллекция. То есть коллекция, реализующая <xref:System.Collections.Generic.IEnumerable%601> или <xref:System.Linq.IQueryable%601> .|  
|(|Обязательный элемент. Обозначает начало свойства индексатора.|  
|`index`|Обязательный элемент. Целочисленное выражение, указывающее Отсчитываемая от нуля координату элемента коллекции.|  
|)|Обязательный элемент. Обозначает конец свойства индексатора.|  
  
## <a name="return-value"></a>Возвращаемое значение  

 Объект из указанного расположения в коллекции или значение, `Nothing` Если индекс выходит за пределы допустимого диапазона.  
  
## <a name="remarks"></a>Remarks  

 Свойство индексатора расширения можно использовать для доступа к отдельным элементам в коллекции. Это свойство индексатора обычно используется в выходных данных свойств оси XML. Свойства дочерней оси XML и XML-потомков возвращают коллекции <xref:System.Xml.Linq.XElement> объектов или значение атрибута.  
  
 Компилятор Visual Basic преобразует свойства индексатора расширения в вызовы `ElementAtOrDefault` метода. В отличие от индексатора массива, `ElementAtOrDefault` метод возвращает значение, `Nothing` Если индекс выходит за пределы диапазона. Такое поведение полезно в тех случаях, когда невозможно легко определить количество элементов в коллекции.  
  
 Это свойство индексатора похоже на свойство расширения для коллекций, реализующих <xref:System.Collections.Generic.IEnumerable%601> или <xref:System.Linq.IQueryable%601> : оно используется только в том случае, если коллекция не имеет индексатора или свойства по умолчанию.  
  
 Чтобы получить доступ к значению первого элемента в коллекции <xref:System.Xml.Linq.XElement> <xref:System.Xml.Linq.XAttribute> объектов или, можно использовать `Value` свойство XML. Дополнительные сведения см. в разделе [свойство значения XML](xml-value-property.md).  
  
## <a name="example"></a>Пример  

 В следующем примере показано, как использовать индексатор расширений для доступа ко второму дочернему узлу в коллекции <xref:System.Xml.Linq.XElement> объектов. Доступ к коллекции осуществляется с помощью свойства дочерней оси, которое получает все дочерние элементы, указанные `phone` в `contact` объекте.  
  
 [!code-vb[VbXMLSamples#24](~/samples/snippets/visualbasic/VS_Snippets_VBCSharp/VbXMLSamples/VB/XMLSamples11.vb#24)]  
  
 Этот пример кода отображает следующий текст:  
  
 `Second phone number: 425-555-0145`  
  
## <a name="see-also"></a>См. также

- <xref:System.Xml.Linq.XElement>
- [Свойства оси XML](index.md)
- [XML-литералы](../xml-literals/index.md)
- [Создание XML в Visual Basic](../../programming-guide/language-features/xml/creating-xml.md)
- [Свойство значения XML](xml-value-property.md)
