---
description: 'Дополнительные сведения: запись содержимого набора данных в виде XML-данных'
title: Запись содержимого набора как данных XML
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
ms.assetid: fd15f8a5-3b4c-46d0-a561-4559ab2a4705
ms.openlocfilehash: 0ad232f744f69f822d09c0af6c4374b6e5f0147d
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99651370"
---
# <a name="writing-dataset-contents-as-xml-data"></a>Запись содержимого набора как данных XML

В ADO.NET можно записать XML-представление объекта <xref:System.Data.DataSet> вместе со схемой или без нее. Если информация схемы встраивается внутрь XML, она записываются на языке XSD. Схема содержит определения таблиц для <xref:System.Data.DataSet>, а также определения связей и ограничений.  
  
 Если <xref:System.Data.DataSet> записан как XML-данные, строки в <xref:System.Data.DataSet> записываются в своей текущей версии. Однако <xref:System.Data.DataSet> может быть записан как DiffGram, так что будут включены и текущие, и исходные данные строк.  
  
 XML-представление <xref:System.Data.DataSet> может быть записано в файл, в поток, в **XmlWriter** или в строку. Эти возможности обеспечивают большую гибкость способа переноса XML-представления для <xref:System.Data.DataSet>. Чтобы получить XML-представление в <xref:System.Data.DataSet> виде строки, используйте метод **getXML** , как показано в следующем примере.  
  
```vb  
Dim xmlDS As String = custDS.GetXml()  
```  
  
```csharp  
string xmlDS = custDS.GetXml();  
```  
  
 **GetXML** возвращает XML-представление <xref:System.Data.DataSet> без сведений о схеме. Чтобы записать сведения о схеме из <xref:System.Data.DataSet> (в виде XML-схемы) в строку, используйте параметр GetSchema.  
  
 Для записи в <xref:System.Data.DataSet> файл, поток или **XmlWriter** используйте метод **WriteXml** . Первым параметром, который передается в **WriteXml** , является назначение выходных данных в формате XML. Например, передайте строку, содержащую имя файла, объект **System. IO. TextWriter** и т. д. Можно передать необязательный второй параметр **ксмлвритемоде** , чтобы указать способ записи выходных данных XML.  
  
 В следующей таблице показаны параметры для **ксмлвритемоде**.  
  
|Параметр XmlWriteMode|Описание|  
|-------------------------|-----------------|  
|**IgnoreSchema**|Записывает текущее содержимое <xref:System.Data.DataSet> как XML-данные, без схемы XML. Это значение по умолчанию.|  
|**WriteSchema**|Записывает текущее содержимое <xref:System.Data.DataSet> в виде XML-данных с реляционной структурой в виде встроенной схемы XML.|  
|**DiffGram**|Записывает весь <xref:System.Data.DataSet> как DiffGram, включая исходные и текущие значения. Дополнительные сведения см. в разделе [дельтами](diffgrams.md).|  
  
 При написании XML-представления объекта <xref:System.Data.DataSet> , содержащего объекты **DataRelation** , скорее всего потребуется, чтобы результирующий XML имели дочерние строки каждой связи, вложенные в соответствующие им родительские элементы. Для этого присвойте свойству **Nested** объекта **DataRelation** значение **true** при добавлении объекта **DataRelation** в коллекцию <xref:System.Data.DataSet> . Дополнительные сведения см. в разделе [вложенность связей](nesting-datarelations.md)данных.  
  
 Ниже приведены два примера того, как записать XML-представление в <xref:System.Data.DataSet> файл. В первом примере имя файла для результирующего XML передается в **WriteXml** в виде строки. Во втором примере передается объект **System. IO. StreamWriter** .
  
```vb  
custDS.WriteXml("Customers.xml", XmlWriteMode.WriteSchema)  
```  
  
```csharp  
custDS.WriteXml("Customers.xml", XmlWriteMode.WriteSchema);  
```  
  
```vb  
Dim xmlSW As System.IO.StreamWriter = New System.IO.StreamWriter("Customers.xml")  
custDS.WriteXml(xmlSW, XmlWriteMode.WriteSchema)  
xmlSW.Close()  
```  
  
```csharp  
System.IO.StreamWriter xmlSW = new System.IO.StreamWriter("Customers.xml");  
custDS.WriteXml(xmlSW, XmlWriteMode.WriteSchema);  
xmlSW.Close();  
```  
  
## <a name="mapping-columns-to-xml-elements-attributes-and-text"></a>Сопоставление столбцов с XML-элементами, атрибутами и текстом  

 Можно указать способ представления столбца таблицы в XML с помощью свойства **ColumnMapping** объекта **DataColumn** . В следующей таблице показаны различные значения **MappingType** для свойства **ColumnMapping** столбца таблицы и результирующий XML.  
  
|Значение MappingType|Описание|  
|-----------------------|-----------------|  
|**Элемент**|Это значение по умолчанию. Столбец записывается как XML-элемент, где ColumnName - имя элемента, а содержимое столбца записывается как текст элемента. Пример:<br /><br /> `<ColumnName>Column Contents</ColumnName>`|  
|**Attribute**|Столбец записывается как XML-атрибут XML-элемента для текущей строки, где ColumnName - это имя атрибута, а содержимое столбца записывается как значение атрибута. Пример:<br /><br /> `<RowElement ColumnName="Column Contents" />`|  
|**SimpleContent**|Содержимое столбца записывается как текст в XML-элементе для текущей строки. Пример:<br /><br /> `<RowElement>Column Contents</RowElement>`<br /><br /> Обратите внимание, что значение **SimpleContent** не может быть задано для столбца таблицы, имеющей столбцы **элементов** или вложенные отношения.|  
|**Скрыта**|Столбец не записывается в выводимый XML.|  
  
## <a name="see-also"></a>См. также

- [Использование XML в наборах данных](using-xml-in-a-dataset.md)
- [DiffGrams](diffgrams.md)
- [Вложение отношений DataRelation](nesting-datarelations.md)
- [Запись сведений о схеме набора данных как XSD](writing-dataset-schema-information-as-xsd.md)
- [Наборы данных, таблицы данных и объекты DataView](index.md)
- [Общие сведения об ADO.NET](../ado-net-overview.md)
