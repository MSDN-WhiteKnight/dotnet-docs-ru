---
description: 'Дополнительные сведения: <TimeSpan_LegacyFormatMode элемент>'
title: Элемент <TimeSpan_LegacyFormatMode>
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- <TimeSpan_LegacyFormatMode> element
- TimeSpan_LegacyFormatMode element
ms.assetid: 865e7207-d050-4442-b574-57ea29d5e2d6
ms.openlocfilehash: 1fa5c3a15941004ebab9e3622d4b3e7b27130e22
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99802389"
---
# <a name="timespan_legacyformatmode-element"></a>Элемент \<TimeSpan_LegacyFormatMode>

Определяет, сохраняет ли среда выполнения устаревшее поведение в операциях форматирования со <xref:System.TimeSpan?displayProperty=nameWithType> значениями.

[**\<configuration>**](../configuration-element.md)\
&nbsp;&nbsp;[**\<runtime>**](runtime-element.md)\
&nbsp;&nbsp;&nbsp;&nbsp;**\<TimeSpan_LegacyFormatMode>**  

## <a name="syntax"></a>Синтаксис

```xml
<TimeSpan_LegacyFormatMode
   enabled="true|false"/>
```

## <a name="attributes-and-elements"></a>Атрибуты и элементы

В следующих разделах описаны атрибуты, дочерние и родительские элементы.

### <a name="attributes"></a>Атрибуты

|Атрибут|Описание|
|---------------|-----------------|
|`enabled`|Обязательный атрибут.<br /><br /> Указывает, использует ли среда выполнения устаревшее поведение форматирования со <xref:System.TimeSpan?displayProperty=nameWithType> значениями.|

## <a name="enabled-attribute"></a>Атрибут enabled

|Значение|Описание|
|-----------|-----------------|
|`false`|Среда выполнения не восстанавливает устаревшее поведение форматирования.|
|`true`|Среда выполнения восстанавливает устаревшее поведение форматирования.|

### <a name="child-elements"></a>Дочерние элементы

Отсутствует.

### <a name="parent-elements"></a>Родительские элементы

|Элемент|Описание|
|-------------|-----------------|
|`configuration`|Корневой элемент в любом файле конфигурации, используемом средой CLR и приложениями .NET Framework.|
|`runtime`|Содержит сведения о параметрах инициализации среды выполнения.|

## <a name="remarks"></a>Remarks

Начиная с платформа .NET Framework 4 <xref:System.TimeSpan?displayProperty=nameWithType> структура реализует <xref:System.IFormattable> интерфейс и поддерживает операции форматирования со стандартными и пользовательскими строками формата. Если метод синтаксического анализа обнаруживает неподдерживаемый описатель формата или строку формата, он создает исключение <xref:System.FormatException> .

В предыдущих версиях платформа .NET Framework <xref:System.TimeSpan> структура не реализовала <xref:System.IFormattable> и не поддерживала строки формата. Однако многие разработчики ошибочно предполагали, что <xref:System.TimeSpan> поддерживало набор строк формата и использовали их в [операциях составного форматирования](../../../../standard/base-types/composite-formatting.md) с помощью таких методов, как <xref:System.String.Format%2A?displayProperty=nameWithType> . Обычно, если тип реализует <xref:System.IFormattable> и поддерживает строки формата, вызовы методов форматирования с неподдерживаемыми строками формата обычно создают исключение <xref:System.FormatException> . Однако, поскольку <xref:System.TimeSpan> не реализуется <xref:System.IFormattable> , среда выполнения игнорирует строку формата и вызывает <xref:System.TimeSpan.ToString?displayProperty=nameWithType> метод. Это означает, что, хотя строки формата не оказывают влияния на операцию форматирования, их присутствие не привело к созданию <xref:System.FormatException> .

Для случаев, когда устаревший код передает метод составного форматирования и недопустимую строку формата, и этот код нельзя перекомпилировать, можно использовать `<TimeSpan_LegacyFormatMode>` элемент для восстановления прежнего <xref:System.TimeSpan> поведения. Если `enabled` атрибуту этого элемента присвоить значение `true` , метод составного форматирования приводит к вызову <xref:System.TimeSpan.ToString?displayProperty=nameWithType> , а не <xref:System.TimeSpan.ToString%28System.String%2CSystem.IFormatProvider%29?displayProperty=nameWithType> , а <xref:System.FormatException> исключение не создается.

## <a name="example"></a>Пример

Следующий пример создает экземпляр <xref:System.TimeSpan> объекта и пытается отформатировать его с <xref:System.String.Format%28System.String%2CSystem.Object%29?displayProperty=nameWithType> помощью метода, используя неподдерживаемую строку стандартного формата.

[!code-csharp[TimeSpan.BreakingChanges#1](../../../../../samples/snippets/csharp/VS_Snippets_CLR/timespan.breakingchanges/cs/legacyformatmode1.cs#1)]
[!code-vb[TimeSpan.BreakingChanges#1](../../../../../samples/snippets/visualbasic/VS_Snippets_CLR/timespan.breakingchanges/vb/legacyformatmode1.vb#1)]

При запуске примера на платформа .NET Framework 3,5 или более ранней версии отображаются следующие выходные данные:

```console
12:30:45
```

При выполнении примера на платформа .NET Framework 4 или более поздней версии это отличает его от выходных данных.

```console
Invalid Format
```

Однако, если добавить в каталог примера следующий файл конфигурации, а затем запустить пример на платформа .NET Framework 4 или более поздней версии, то выходные данные идентичны тому, что был создан в примере, когда он выполняется в платформа .NET Framework 3,5.

```xml
<?xml version ="1.0"?>
<configuration>
   <runtime>
      <TimeSpan_LegacyFormatMode enabled="true"/>
   </runtime>
</configuration>
```

## <a name="see-also"></a>См. также

- [Схема параметров среды выполнения](index.md)
- [Схема файла конфигурации](../index.md)
