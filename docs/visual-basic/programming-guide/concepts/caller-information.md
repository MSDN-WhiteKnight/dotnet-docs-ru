---
description: 'Дополнительные сведения: сведения о вызывающем объекте (Visual Basic)'
title: Сведения о вызывающем
ms.date: 07/20/2015
ms.assetid: 15d556eb-4d0c-4497-98a3-7f60abb7d6a1
ms.openlocfilehash: bcb4f553a9840a76f24825c3c2b7e2e98914abc2
ms.sourcegitcommit: 10e719780594efc781b15295e499c66f316068b8
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/14/2021
ms.locfileid: "100437713"
---
# <a name="caller-information-visual-basic"></a>Caller Information (Visual Basic) (Сведения о вызывающем (Visual Basic))

С помощью информационных атрибутов вызывающего объекта можно получить сведения о вызывающем объекте метода. Можно получить путь к файлу исходного кода, номер строки в исходном коде и имя вызывающего объекта. Эти сведения полезны для трассировки, отладки и создания средств диагностики.  
  
 Для получения этих сведений используются атрибуты, которые применяются к необязательным параметрам, каждый из которых имеет значение по умолчанию. В следующей таблице перечислены информационные атрибуты вызывающего объекта, которые определены в пространстве имен <xref:System.Runtime.CompilerServices?displayProperty=nameWithType>:  
  
|Атрибут|Описание|Type|  
|---|---|---|  
|<xref:System.Runtime.CompilerServices.CallerFilePathAttribute>|Полный путь исходного файла, содержащего вызывающий объект. Это путь к файлу во время компиляции.|`String`|  
|<xref:System.Runtime.CompilerServices.CallerLineNumberAttribute>|Номер строки в исходном файле, в которой вызывается метод.|`Integer`|  
|<xref:System.Runtime.CompilerServices.CallerMemberNameAttribute>|Имя свойства или метода вызывающего объекта. См. подраздел [Имена членов](#MEMBERNAMES) ниже.|`String`|  
  
## <a name="example"></a>Пример  

 В следующем примере показано, как использовать информационные атрибуты вызывающего объекта. При каждом вызове метода `TraceMessage` сведения о вызывающем объекте подставляются в качестве аргументов необязательных параметров.  
  
```vb  
Private Sub DoProcessing()  
    TraceMessage("Something happened.")  
End Sub  
  
Public Sub TraceMessage(message As String,  
        <System.Runtime.CompilerServices.CallerMemberName> Optional memberName As String = Nothing,  
        <System.Runtime.CompilerServices.CallerFilePath> Optional sourcefilePath As String = Nothing,  
        <System.Runtime.CompilerServices.CallerLineNumber()> Optional sourceLineNumber As Integer = 0)  
  
    System.Diagnostics.Trace.WriteLine("message: " & message)  
    System.Diagnostics.Trace.WriteLine("member name: " & memberName)  
    System.Diagnostics.Trace.WriteLine("source file path: " & sourcefilePath)  
    System.Diagnostics.Trace.WriteLine("source line number: " & sourceLineNumber)  
End Sub  
  
' Sample output:  
'   message: Something happened.  
'   member name: DoProcessing  
'   source file path: C:\Users\username\Documents\Visual Studio 2012\Projects\CallerInfoVB\CallerInfoVB\Form1.vb  
'   source line number: 15  
```  
  
## <a name="remarks"></a>Remarks  

 Для каждого необязательного параметра необходимо указать явное значение по умолчанию. Нельзя применять информационные атрибуты вызывающего объекта к параметрам, которые не были указаны как необязательные.  
  
 Информационные атрибуты вызывающего объекта не делают параметр необязательным. Вместо этого они влияют на значение по умолчанию, которое передается, если аргумент был опущен.  
  
 Информационные значения вызывающего объекта передаются как литералы в IL во время компиляции. В отличие от результатов свойства <xref:System.Exception.StackTrace%2A> для исключений, результаты не затрагиваются запутыванием кода.  
  
 Можно явно передать необязательные аргументы, чтобы управлять сведениями о вызывающем объекте или скрывать сведения о вызывающем объекте.  
  
### <a name="member-names"></a><a name="MEMBERNAMES"></a> Имена элементов  

 Можно использовать атрибут `CallerMemberName`, чтобы не указывать имя члена в виде аргумента `String` вызываемому методу. Этот прием позволяет избежать проблемы, заключающейся в том, что **операция рефакторинга и переименования** не изменяет значений `String`. Это особенно полезно при выполнении следующих задач:  
  
- Использование процедур трассировки и диагностики.  
  
- Реализация интерфейса <xref:System.ComponentModel.INotifyPropertyChanged> при привязке данных. Этот интерфейс позволяет свойству объекта уведомлять связанный элемент управления об изменении свойства, чтобы элемент управления мог отображать обновленные сведения. Если атрибут `CallerMemberName` не используется, необходимо указать имя свойства как литерал.  
  
 В следующей таблице представлены имена членов, возвращаемых при использовании атрибута `CallerMemberName`.  
  
|Фрагмент кода, в пределах которого происходит вызов|Результат имени члена|  
|-------------------------|------------------------|  
|Метод, свойство или событие|Имя метода, свойства или события, из которого происходил вызов.|  
|Конструктор|Строка ".ctor"|  
|Статический конструктор|Строка ".cctor"|  
|Деструктор|Строка "Finalize"|  
|Определяемые пользователем операторы и преобразования|Созданное имя члена, например, "op_Addition".|  
|Конструктора атрибута|Имя члена, к которому применяется атрибут. Если атрибут — любой элемент внутри члена (например, параметр, возвращаемое значение или параметр универсального типа), то результат — имя члена, который связан с этим элементом.|  
|Нет содержащего члена (например, уровень сборки или атрибуты, примененные к типам)|Значение необязательного параметра по умолчанию.|  
  
## <a name="see-also"></a>См. также

- [Атрибуты (Visual Basic)](../../language-reference/attributes.md)
- [Common Attributes (Visual Basic)](attributes/common-attributes.md) (Распространенные атрибуты (Visual Basic))
- [Необязательные параметры](../language-features/procedures/optional-parameters.md)
- [Основные понятия программирования (Visual Basic)](index.md)
