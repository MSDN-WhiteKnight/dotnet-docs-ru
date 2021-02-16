---
description: Дополнительные сведения о структурах и других элементах программирования (Visual Basic)
title: Структуры и другие элементы программирования
ms.date: 07/20/2015
helpviewer_keywords:
- structures [Visual Basic], arrays
- procedures [Visual Basic], structures as arguments to
- objects [Visual Basic], structure elements
- arrays [Visual Basic], structure elements
- nested structures [Visual Basic]
ms.assetid: 0f849313-ccd2-4c9a-acb9-69de6751c088
ms.openlocfilehash: 62052389b617849566a3cd0c475a2eb5da9e61ca
ms.sourcegitcommit: 10e719780594efc781b15295e499c66f316068b8
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/14/2021
ms.locfileid: "100430590"
---
# <a name="structures-and-other-programming-elements-visual-basic"></a>Структуры и другие элементы программирования (Visual Basic)

Структуры можно использовать совместно с массивами, объектами и процедурами, а также друг с другом. При взаимодействии используется тот же синтаксис, что и при использовании этих элементов по отдельности.  
  
> [!NOTE]
> Нельзя инициализировать какие либо элементы структуры в объявлении структуры. Значения можно назначать только элементам переменной, объявленным как тип структуры.  
  
## <a name="structures-and-arrays"></a>Структуры и массивы  

 Структура может содержать массив в качестве одного или нескольких элементов. Это показано в следующем примере.  
  
```vb  
Public Structure systemInfo  
    Public cPU As String  
    Public memory As Long  
    Public diskDrives() As String  
    Public purchaseDate As Date  
End Structure
```  
  
 Доступ к значениям массива в структуре осуществляется так же, как и к свойству объекта. Это показано в следующем примере.  
  
```vb  
Dim mySystem As systemInfo  
ReDim mySystem.diskDrives(3)  
mySystem.diskDrives(0) = "1.44 MB"  
```  
  
 Можно также объявить массив структур. Это показано в следующем примере.  
  
```vb  
Dim allSystems(100) As systemInfo  
```  
  
 Для доступа к компонентам этой архитектуры данных следуйте тем же правилам. Это показано в следующем примере.  
  
```vb  
ReDim allSystems(5).diskDrives(3)  
allSystems(5).CPU = "386SX"  
allSystems(5).diskDrives(2) = "100M SCSI"  
```  
  
## <a name="structures-and-objects"></a>Структуры и объекты  

 Структура может содержать объект в качестве одного или нескольких его элементов. Это показано в следующем примере.  
  
```vb  
Protected Structure userInput  
    Public userName As String  
    Public inputForm As System.Windows.Forms.Form  
    Public userFileNumber As Integer  
End Structure  
```  
  
 В таком объявлении следует использовать конкретный класс объекта, а не `Object` .  
  
## <a name="structures-and-procedures"></a>Структуры и процедуры  

 Структуру можно передать в качестве аргумента процедуры. Это показано в следующем примере.  
  
```vb  
Public currentCPUName As String = "700MHz Pentium compatible"  
Public currentMemorySize As Long = 256  
Public Sub fillSystem(ByRef someSystem As systemInfo)  
    someSystem.cPU = currentCPUName  
    someSystem.memory = currentMemorySize  
    someSystem.purchaseDate = Now  
End Sub  
```  
  
 В предыдущем примере структура передается *по ссылке*, что позволяет процедуре изменять ее элементы, чтобы изменения вступили в силу в вызывающем коде. Если необходимо защитить структуру от таких изменений, передайте ее по значению.  
  
 Можно также вернуть структуру из `Function` процедуры. Это показано в следующем примере.  
  
```vb  
Dim allSystems(100) As systemInfo  
Function findByDate(ByVal searchDate As Date) As systemInfo  
    Dim i As Integer  
    For i = 1 To 100  
        If allSystems(i).purchaseDate = searchDate Then Return allSystems(i)  
    Next i  
   ' Process error: system with desired purchase date not found.  
End Function  
```  
  
## <a name="structures-within-structures"></a>Структуры внутри структур  

 Структуры могут содержать другие структуры. Это показано в следующем примере.  
  
```vb  
Public Structure driveInfo  
    Public type As String  
    Public size As Long  
End Structure  
Public Structure systemInfo  
    Public cPU As String  
    Public memory As Long  
    Public diskDrives() As driveInfo  
    Public purchaseDate As Date  
End Structure  
```  
  
```vb  
Dim allSystems(100) As systemInfo  
ReDim allSystems(1).diskDrives(3)  
allSystems(1).diskDrives(0).type = "Floppy"  
```  
  
 Эту методику также можно использовать для инкапсуляции структуры, определенной в одном модуле, в структуре, определенной в другом модуле.  
  
 Структуры могут содержать другие структуры для произвольной глубины.  
  
## <a name="see-also"></a>См. также раздел

- [Типы данных](index.md)
- [Простые типы данных](elementary-data-types.md)
- [Составные типы данных](composite-data-types.md)
- [Value Types and Reference Types](value-types-and-reference-types.md)
- [Структуры](structures.md)
- [Устранение неполадок, связанных с типами данных](troubleshooting-data-types.md)
- [Практическое руководство. Объявление структуры](how-to-declare-a-structure.md)
- [Переменные структуры](structure-variables.md)
- [Структуры и классы](structures-and-classes.md)
- [Оператор Structure](../../../language-reference/statements/structure-statement.md)
