---
title: Практическое руководство. Чтение метаданных изображения
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- metadata [Windows Forms], property item
- metadata [Windows Forms], reading image
ms.assetid: 72ec0b31-0be7-444a-9575-1dbcb864e0be
ms.openlocfilehash: 0a53e9b9d23c03715bf3088a4ae8577a39527995
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59173619"
---
# <a name="how-to-read-image-metadata"></a>Практическое руководство. Чтение метаданных изображения
Некоторые файлы изображений содержат метаданные, которые можно прочитать, чтобы определить возможности изображения. Например цифровой фотографии может содержать метаданные, которые можно прочитать, чтобы определить марки и модели фотоаппарата, использованного для создания образа. С помощью [!INCLUDE[ndptecgdiplus](../../../../includes/ndptecgdiplus-md.md)], можно считывать существующие метаданные, и можно также добавлять новые метаданные в файлы изображений.  
  
 [!INCLUDE[ndptecgdiplus](../../../../includes/ndptecgdiplus-md.md)] хранит каждый отдельный блок метаданных в <xref:System.Drawing.Imaging.PropertyItem> объекта. Можно прочитать <xref:System.Drawing.Image.PropertyItems%2A> свойство <xref:System.Drawing.Image> объекта для извлечения метаданных из файла. <xref:System.Drawing.Image.PropertyItems%2A> Свойство возвращает массив <xref:System.Drawing.Imaging.PropertyItem> объектов.  
  
 Объект <xref:System.Drawing.Imaging.PropertyItem> имеет следующие четыре свойства: `Id`, `Value`, `Len`, и `Type`.  
  
## <a name="id"></a>Идентификатор  
 Тег, определяющий элемент метаданных. Некоторые значения, которые могут быть назначены <xref:System.Drawing.Imaging.PropertyItem.Id%2A> показаны в следующей таблице.  
  
|Шестнадцатеричное значение|Описание|  
|-----------------------|-----------------|  
|0x0320<br /><br /> 0x010F<br /><br /> 0x0110<br /><br /> 0x9003<br /><br /> 0x829A<br /><br /> 0x5090<br /><br /> 0x5091|Изображение заголовка<br /><br /> Поставщик вычислительной техники<br /><br /> Модель оборудования<br /><br /> ExifDTOriginal<br /><br /> Время выдержки EXIF<br /><br /> Таблицы освещенности<br /><br /> Таблицы цветности|  
  
## <a name="value"></a>Значение  
 Массив значений. Формат значений определяется <xref:System.Drawing.Imaging.PropertyItem.Type%2A> свойство.  
  
## <a name="len"></a>Len  
 Размер (в байтах) массив значений, на который указывает <xref:System.Drawing.Imaging.PropertyItem.Value%2A> свойство.  
  
## <a name="type"></a>Тип  
 Тип значений в массиве, на который указывает `Value` свойство. Типы, определяемые по `Type` в следующей таблице показаны значения свойств  
  
|Числовое значение|Описание|  
|-------------------|-----------------|  
|1|А `Byte`|  
|2|Массив `Byte` объекты в кодировке ASCII|  
|3|16-разрядное целое число|  
|4|32-разрядное целое число|  
|5|Массив из двух `Byte` объекты, представляющие рациональное число|  
|6|Не используется|  
|7|Не определено|  
|8|Не используется|  
|9|`SLong`|  
|10|`SRational`|  
  
## <a name="example"></a>Пример  
  
### <a name="description"></a>Описание  
 В следующем примере кода считывает и отображает семи блоков метаданных в файле `FakePhoto.jpg`. Второй элемент свойства (индекс 1) в списке <xref:System.Drawing.Imaging.PropertyItem.Id%2A> 0x010F (производитель) и <xref:System.Drawing.Imaging.PropertyItem.Type%2A> 2 (массив байтов в кодировке ASCII). В примере кода отображает значение данного свойства.  
  
 В коде создается результат, аналогичный приведенному ниже:  
  
 `Property Item 0`  
  
 `id: 0x320`  
  
 `type: 2`  
  
 `length: 16 bytes`  
  
 `Property Item 1`  
  
 `id: 0x10f`  
  
 `type: 2`  
  
 `length: 17 bytes`  
  
 `Property Item 2`  
  
 `id: 0x110`  
  
 `type: 2`  
  
 `length: 7 bytes`  
  
 `Property Item 3`  
  
 `id: 0x9003`  
  
 `type: 2`  
  
 `length: 20 bytes`  
  
 `Property Item 4`  
  
 `id: 0x829a`  
  
 `type: 5`  
  
 `length: 8 bytes`  
  
 `Property Item 5`  
  
 `id: 0x5090`  
  
 `type: 3`  
  
 `length: 128 bytes`  
  
 `Property Item 6`  
  
 `id: 0x5091`  
  
 `type: 3`  
  
 `length: 128 bytes`  
  
 `The equipment make is Northwind Camera.`  
  
### <a name="code"></a>Код  
 [!code-csharp[System.Drawing.WorkingWithImages#51](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Drawing.WorkingWithImages/CS/Class1.cs#51)]
   
  
## <a name="compiling-the-code"></a>Компиляция кода  
 Предыдущий пример предназначен для работы с Windows Forms и требует <xref:System.Windows.Forms.PaintEventArgs> `e`, который является параметром <xref:System.Windows.Forms.Control.Paint> обработчик событий. Обработка формы <xref:System.Windows.Forms.Control.Paint> событий и вставьте этот код в обработчик событий paint. Необходимо заменить `FakePhoto.jpg` допустимы для системы и импорта путь и имя образа `System.Drawing.Imaging` пространства имен.  
  
## <a name="see-also"></a>См. также

- [Работа с растровыми и векторными изображениями с использованием классов Image, Bitmap и Metafile](images-bitmaps-and-metafiles.md)
- [Работа с растровыми и векторными изображениями](working-with-images-bitmaps-icons-and-metafiles.md)
