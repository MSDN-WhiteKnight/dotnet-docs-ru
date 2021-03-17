---
title: Реализация методов в специализированных элементах управления
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- user controls [Windows Forms], method implementation
- custom controls [Windows Forms], overloading methods
- custom controls [Windows Forms], method implementation
- methods [Windows Forms]
- methods [Windows Forms], custom controls
ms.assetid: 35d14fca-4bb4-4a27-8211-1f7a98ea27de
ms.openlocfilehash: 38dcad25af31b87afc1cc6ef4f89a1f7903bc0ed
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59117421"
---
# <a name="method-implementation-in-custom-controls"></a>Реализация методов в специализированных элементах управления
Метод применяется в элементе управления точно так же, как и в любом другом компоненте.  
  
 В Visual Basic, если метод требуется для возврата значения, он выполняется как `Public Function`. Если значение не возвращается, метод выполняется как `Public Sub`. Методы объявляются согласно следующему синтаксису:  
  
```vb  
Public Function ConvertMatterToEnergy(Matter as Integer) As Integer  
   ' Conversion code goes here.  
End Function  
```  
  
 Поскольку функции возвращают значения, в них необходимо указывать тип возвращаемого значения, например целое число, строка, объект и т. д. Также необходимо задавать аргументы `Function` или процедуры `Sub` (если есть).  
  
 В C# нет различий между функциями и процедурами, а Visual Basic — есть. Метод возвращает либо значение, либо ответ `void`. Синтаксис объявления открытого метода C# выглядит следующим образом:  
  
```csharp  
public int ConvertMatterToEnergy(int matter)  
{  
   // Conversion code goes here.  
}  
```  
  
 При объявлении метода необходимо по возможности объявить все его аргументы и явные типы данных. Аргументы с ссылками на объекты должны быть объявлены как особые типы классов, например `As Widget` вместо `As Object`. В Visual Basic настройка по умолчанию `Option Strict` применяет это правило автоматически.  
  
 Аргументы с типами позволяют компилятору выявлять ошибки разработчиков перед запуском, а не во время выполнения. Компилятор также отслеживает ошибки, а качество тестирования во время выполнения зависит от набора тестов.  
  
## <a name="overloaded-methods"></a>Перегруженные методы  
 Если вы хотите разрешить пользователям элемента управления задавать для метода комбинации параметров, подготовьте несколько перегрузок метода с использованием явных типов данных. Не создавайте параметры, которые объявляются как `As Object` и могут содержать любые типы данных, — это может привести к ошибкам, которые не будут обнаружены во время тестирования.  
  
> [!NOTE]
>  Универсальный тип данных в среде CLR — это `Object`, а не `Variant`. `Variant` удалено из языка.  
  
 Например, метод `Spin` гипотетического элемента управления `Widget` позволяет либо прямо определить направление и скорость вращения, либо определить другой объект `Widget`, вращательный момент которого поглощается.  
  
```vb  
Overloads Public Sub Spin( _  
   ByVal SpinDirection As SpinDirectionsEnum, _  
   ByVal RevolutionsPerSecond As Double)  
   ' Implementation code here.  
End Sub  
Overloads Public Sub Spin(ByVal Driver As Widget) _  
   ' Implementation code here.  
End Sub  
```  
  
```csharp  
public void Spin(SpinDirectionsEnum spinDirection, double revolutionsPerSecond)  
{  
   // Implementation code here.  
}  
  
public void Spin(Widget driver)  
{  
   // Implementation code here.  
}  
```  
  
## <a name="see-also"></a>См. также

- [События](../../../standard/events/index.md)
- [Свойства элементов управления Windows Forms](properties-in-windows-forms-controls.md)
