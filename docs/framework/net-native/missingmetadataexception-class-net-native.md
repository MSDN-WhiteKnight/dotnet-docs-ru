---
description: 'Дополнительные сведения о классе: MissingMetadataException (.NET Native)'
title: Класс MissingMetadataException (машинный код .NET)
ms.date: 03/30/2017
ms.assetid: 408f25c4-6d60-475c-92b1-7b52b777c6db
ms.openlocfilehash: b5d93a8dc098a542791df303450d64e4abcc5de9
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99738654"
---
# <a name="missingmetadataexception-class-net-native"></a>Класс MissingMetadataException (машинный код .NET)

**.NET для приложений Windows для Windows 10, только .NET Native**

Исключение, возникающее при использовании отражения для извлечения метаданных, которые не существуют.

**Пространство имен:** System.Reflection

> [!IMPORTANT]
> `MissingMetadataException`Класс предназначен исключительно для внутреннего использования в цепочке инструментов .NET Native. Он не предназначен для использования в стороннем коде. Вам также не следует обрабатывать исключение в коде своего приложения. Вместо этого вы устраняете исключение, добавляя записи в [файл директив среды выполнения](runtime-directives-rd-xml-configuration-file-reference.md). Дополнительные сведения см. в разделе «Примечания».

## <a name="syntax"></a>Синтаксис

[!code-csharp[ProjectN#4](../../../samples/snippets/csharp/VS_Snippets_CLR/projectn/cs/missingmetadataexception_syntax1.cs#4)]

Обратите внимание, что класс `MissingMetadataException` является производным от <xref:System.TypeAccessException>.

В классе `MissingMetadataException`представлены следующие члены:

## <a name="constructors"></a>Конструкторы

|Конструктор|Описание|
|-----------------|-----------------|
|`public MissingMetadataException()`|Инициализирует новый экземпляр класса `MissingMetadataException`, используя системное сообщение, содержащее описание ошибки.<br /><br /> Этот конструктор предназначен только для внутреннего использования в цепочке средств .NET Native.|
|`public MissingMetadataException(String message)`|Инициализирует новый экземпляр класса `MissingMetadataException` с указанным сообщением об ошибке.<br /><br /> Этот конструктор предназначен только для внутреннего использования в цепочке средств .NET Native.|

## <a name="properties"></a>Свойства

|Свойство|Описание|
|--------------|-----------------|
|`public IDictionary Data { get; }`|Возвращает коллекцию пар «ключ-значение», предоставляющую дополнительные сведения об исключении. (Является наследником <xref:System.Exception?displayProperty=nameWithType>)|
|`public string HelpLink { get; set; }`|Получает или задает ссылку на файл справки, связанный с этим исключением. (Является наследником <xref:System.Exception?displayProperty=nameWithType>)|
|`public int HResult { get; protected set; }`|Получает или задает `HRESULT`, закодированное числовое значение, присвоенное определенному исключению. (Является наследником <xref:System.Exception?displayProperty=nameWithType>)|
|`public Exception InnerException { get; }`|Получает исключение, которое вызвало текущее исключение. (Является наследником <xref:System.Exception?displayProperty=nameWithType>)|
|`public string Message { get; }`|Возвращает сообщение, описывающее текущее исключение. (Является наследником <xref:System.TypeLoadException>)|
|`public string Source { get; set; }`|Возвращает или задает имя приложения или объекта, вызвавшего ошибку. (Является наследником <xref:System.Exception?displayProperty=nameWithType>)|
|`public string StackTrace { get; }`|Получает строковое представление непосредственных кадров в стеке вызова. (Является наследником <xref:System.Exception?displayProperty=nameWithType>)|
|`public MethodBase TargetSite { get; }`|Возвращает метод, который вызвал текущее исключение. (Является наследником <xref:System.Exception?displayProperty=nameWithType>)|
|`public string TypeName { get; ]`|Получает полное имя типа, метаданные которого отсутствует. (Является наследником <xref:System.TypeLoadException>)|

## <a name="methods"></a>Методы

|Метод|Описание|
|------------|-----------------|
|`public bool Equals(Object obj)`|Определяет, равен ли указанный объект текущему объекту.  (Является наследником <xref:System.Exception?displayProperty=nameWithType>)|
|`protected void Finalize()`|Позволяет объекту попытаться освободить ресурсы и выполнить другие операции очистки, перед тем как он будет уничтожен во время сборки мусора. (Является наследником <xref:System.Object>)|
|`public Exception GetBaseException()`|Возвращает исключение, которое является первопричиной одного или нескольких исключений. (Является наследником <xref:System.Exception?displayProperty=nameWithType>)|
|`public int GetHashCode()`|Возвращает хэш-код для экземпляра`MissingMetadataException`.   (Является наследником <xref:System.Object>)|
|`public void GetObjectData(SerializationInfo info, StreamingContext context)`|Задает объект <xref:System.Runtime.Serialization.SerializationInfo>, содержащий информацию об исключении.  (Является наследником <xref:System.TypeLoadException>)|
|`public Type GetType()`|Возвращает тип среды выполнения текущего экземпляра. (Является наследником <xref:System.Exception?displayProperty=nameWithType>)|
|`protected Object MemberwiseClone()`|Создает неполную копию текущего объекта. (Является наследником <xref:System.Object>)|
|`public string ToString()`|Возвращает строковое представление текущего исключения. (Является наследником <xref:System.Exception?displayProperty=nameWithType>)|

## <a name="events"></a>События

|Событие|Описание|
|-----------|-----------------|
|`protected event EventHandler<SafeSerializationEventArgs> SerializeObjectState`|Возникает, когда исключение сериализовано для создания объекта состояния исключения, содержащего сериализованные данные об исключении. (Является наследником <xref:System.Exception?displayProperty=nameWithType>)|

## <a name="usage-details"></a>сведения о потреблении;

Исключение`MissingMetadataException` возникает, если использовать отражение для доступа к метаданным, которые не доступны в сборке.

Метаданные, доступные для приложения во время выполнения, определяются в файле конфигурации директив среды выполнения (XML), \*.rd.xml. Чтобы избежать возникновения этого исключения в приложении, необходимо изменить файл \*.rd.xml, чтобы определить метаданные, которые должны быть доступны во время выполнения. Сведения о формате файла rd.xml \* см. в разделе [Справочник по конфигурационному файлу директив среды выполнения (rd.xml)](runtime-directives-rd-xml-configuration-file-reference.md).

> [!IMPORTANT]
> Так как это исключение указывает, что метаданные, необходимые для приложения, недоступны во время выполнения, не следует обрабатывать это исключение в блоке `try`/`catch`. Вместо этого следует выяснить причины возникновения исключения и устранить ее с помощью файла директив среды выполнения. Чтобы получить запись, которую можно добавить в файл директив среды выполнения, устраняющий исключение, можно использовать одно из двух средств устранения неполадок.
>
> - [Средство устранения неполадок MissingMetadataException](https://dotnet.github.io/native/troubleshooter/type.html) для типов.
> - [Средство устранения неполадок MissingMetadataException](https://dotnet.github.io/native/troubleshooter/method.html) для методов.

Класс `MissingMetadataException` не содержит уникальных членов; все его члены наследуются от базового класса, <xref:System.TypeAccessException>.

## <a name="see-also"></a>См. также

- <xref:System.Exception?displayProperty=nameWithType>
- <xref:System.TypeAccessException>
- [Класс MissingInteropDataException](missinginteropdataexception-class-net-native.md)
- [Класс MissingRuntimeArtifactException](missingruntimeartifactexception-class-net-native.md)
- [Ссылка на файл конфигурации директив среды выполнения (rd.xml)](runtime-directives-rd-xml-configuration-file-reference.md)
