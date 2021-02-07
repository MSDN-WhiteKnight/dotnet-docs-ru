---
description: 'Дополнительные сведения о: XmlDictionaryReaderQuotas'
title: XmlDictionaryReaderQuotas
ms.date: 03/30/2017
ms.assetid: 9b4ca8b4-0a89-4758-97ab-528a8ce18f07
ms.openlocfilehash: d1450051e7107e9b92f848d26e6b182bfd2f2340
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99756868"
---
# <a name="xmldictionaryreaderquotas"></a>XmlDictionaryReaderQuotas

XmlDictionaryReaderQuotas  
  
## <a name="syntax"></a>Синтаксис  
  
```csharp
class XmlDictionaryReaderQuotas  
{  
  sint32 MaxArrayLength;  
  sint32 MaxBytesPerRead;  
  sint32 MaxDepth;  
  sint32 MaxNameTableCharCount;  
  sint32 MaxStringContentLength;  
};  
```  
  
## <a name="methods"></a>Методы  

 Класс XmlDictionaryReaderQuotas не определяет никаких методов.  
  
## <a name="properties"></a>Свойства  

 Класс XmlDictionaryReaderQuotas имеет следующие свойства:  
  
### <a name="maxarraylength"></a>MaxArrayLength  

 Тип данных: sint32  
  
 Тип доступа: только для чтения  
  
 Максимально допустимая длина массива.  
  
### <a name="maxbytesperread"></a>MaxBytesPerRead  

 Тип данных: sint32  
  
 Тип доступа: только для чтения  
  
 Максимально допустимое число байтов, возвращаемых для каждой операции чтения.  
  
### <a name="maxdepth"></a>MaxDepth  

 Тип данных: sint32  
  
 Тип доступа: только для чтения  
  
 Максимальная глубина вложенного узла для каждого чтения.  
  
### <a name="maxnametablecharcount"></a>MaxNameTableCharCount  

 Тип данных: sint32  
  
 Тип доступа: только для чтения  
  
 Максимально допустимое количество символов в имени таблицы.  
  
### <a name="maxstringcontentlength"></a>MaxStringContentLength  

 Тип данных: sint32  
  
 Тип доступа: только для чтения  
  
 Максимальное допустимое число символов в содержимом элемента XML.  
  
## <a name="requirements"></a>Требования  
  
|MOF|Объявлено в файле Servicemodel.mof.|  
|---------|-----------------------------------|  
|Пространство имен|Определено в root\ServiceModel.|  
  
## <a name="see-also"></a>См. также

- <xref:System.Xml.XmlDictionaryReaderQuotas>
- <xref:System.ServiceModel.Configuration.XmlDictionaryReaderQuotasElement>
