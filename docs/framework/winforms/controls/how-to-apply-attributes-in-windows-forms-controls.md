---
title: Практическое руководство. Применение атрибутов к элементам управления Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- controls [Windows Forms], applying attributes
- attributes [Windows Forms], applying
- Windows Forms controls, applying attributes
ms.assetid: af0a3f7f-155b-4ba1-83c4-9cf721331a06
ms.openlocfilehash: e86277c06e515b28bada3331cf4fd63e536319a4
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59079595"
---
# <a name="how-to-apply-attributes-in-windows-forms-controls"></a>Практическое руководство. Применение атрибутов к элементам управления Windows Forms
Для разработки компонентов и элементов управления, которые правильно взаимодействуют со средой разработки и правильно выполнять во время выполнения, необходимо правильно применять атрибуты к классам и членам.  
  
## <a name="example"></a>Пример  
 В следующем примере кода демонстрируется использование нескольких атрибутов в пользовательский элемент управления. Элемент управления демонстрирует возможности простые операции ведения журнала. Когда элемент управления привязан к источнику данных, он отображает значения, отправленные источником данных в <xref:System.Windows.Forms.DataGridView> элемента управления. Если значение превышает значение, заданное параметром `Threshold` свойства `ThresholdExceeded` события.  
  
 `AttributesDemoControl` Записывает значения с `LogEntry` класса. `LogEntry` Класс — это класс шаблона, который означает, что он параметризован в типе, который он входит в систему. Например если `AttributesDemoControl` записывает значения типа `float`, каждая `LogEntry` экземпляра объявляется и используется следующим образом.  
  
 [!code-csharp[System.ComponentModel.AttributesDemoControl#110](~/samples/snippets/csharp/VS_Snippets_Winforms/System.ComponentModel.AttributesDemoControl/CS/form1.cs#110)]
 [!code-vb[System.ComponentModel.AttributesDemoControl#110](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.ComponentModel.AttributesDemoControl/VB/form1.vb#110)]  
  
> [!NOTE]
>  Так как `LogEntry` параметризован произвольным типом, он должен использовать отражение для работы с типом параметра. Функция порогового значения для работы, тип параметра `T` должен реализовывать <xref:System.IComparable> интерфейс.  
  
 Форма, содержащая `AttributesDemoControl` периодически опрашивает счетчик производительности. Каждое значение упаковывается в `LogEntry` соответствующего типа и добавления в форму <xref:System.Windows.Forms.BindingSource>. `AttributesDemoControl` Получает значение через свою привязку данных и отображает значение в <xref:System.Windows.Forms.DataGridView> элемента управления.  
  
 [!code-csharp[System.ComponentModel.AttributesDemoControl#1](~/samples/snippets/csharp/VS_Snippets_Winforms/System.ComponentModel.AttributesDemoControl/CS/attributesdemocontrol.cs#1)]
 [!code-vb[System.ComponentModel.AttributesDemoControl#1](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.ComponentModel.AttributesDemoControl/VB/attributesdemocontrol.vb#1)]  
  
 [!code-csharp[System.ComponentModel.AttributesDemoControl#100](~/samples/snippets/csharp/VS_Snippets_Winforms/System.ComponentModel.AttributesDemoControl/CS/form1.cs#100)]
 [!code-vb[System.ComponentModel.AttributesDemoControl#100](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.ComponentModel.AttributesDemoControl/VB/form1.vb#100)]  
  
 В первом примере кода — `AttributesDemoControl` реализации. Во втором примере кода демонстрируется форму, которая использует `AttributesDemoControl`.  
  
## <a name="class-level-attributes"></a>Атрибуты уровня класса  
 Некоторые атрибуты применяются на уровне класса. В следующем примере кода показаны атрибуты, которые обычно применяются к элементу управления Windows Forms.  
  
 [!code-csharp[System.ComponentModel.AttributesDemoControl#20](~/samples/snippets/csharp/VS_Snippets_Winforms/System.ComponentModel.AttributesDemoControl/CS/attributesdemocontrol.cs#20)]
 [!code-vb[System.ComponentModel.AttributesDemoControl#20](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.ComponentModel.AttributesDemoControl/VB/attributesdemocontrol.vb#20)]  
  
### <a name="typeconverter-attribute"></a>Атрибут TypeConverter  
 <xref:System.ComponentModel.TypeConverterAttribute> является еще одним часто используемые атрибутом уровня класса. В следующем примере кода показано его использование для `LogEntry` класса. В этом примере также показана реализация <xref:System.ComponentModel.TypeConverter> для `LogEntry` тип с именем `LogEntryTypeConverter`.  
  
 [!code-csharp[System.ComponentModel.AttributesDemoControl#5](~/samples/snippets/csharp/VS_Snippets_Winforms/System.ComponentModel.AttributesDemoControl/CS/attributesdemocontrol.cs#5)]
 [!code-vb[System.ComponentModel.AttributesDemoControl#5](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.ComponentModel.AttributesDemoControl/VB/attributesdemocontrol.vb#5)]  
  
## <a name="member-level-attributes"></a>Атрибуты на уровне элемента  
 Некоторые атрибуты применяются на уровне членов. В следующих примерах кода некоторые атрибуты, которые обычно применяются к свойствам элементов управления Windows Forms.  
  
 [!code-csharp[System.ComponentModel.AttributesDemoControl#21](~/samples/snippets/csharp/VS_Snippets_Winforms/System.ComponentModel.AttributesDemoControl/CS/attributesdemocontrol.cs#21)]
 [!code-vb[System.ComponentModel.AttributesDemoControl#21](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.ComponentModel.AttributesDemoControl/VB/attributesdemocontrol.vb#21)]  
  
### <a name="ambientvalue-attribute"></a>Атрибут AmbientValue  
 В следующем примере демонстрируется <xref:System.ComponentModel.AmbientValueAttribute> ; содержит код, поддерживающий взаимодействие со средой разработки. Это взаимодействие называется *окружением*.  
  
 [!code-csharp[System.ComponentModel.AttributesDemoControl#23](~/samples/snippets/csharp/VS_Snippets_Winforms/System.ComponentModel.AttributesDemoControl/CS/attributesdemocontrol.cs#23)]
 [!code-vb[System.ComponentModel.AttributesDemoControl#23](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.ComponentModel.AttributesDemoControl/VB/attributesdemocontrol.vb#23)]  
  
### <a name="databinding-attributes"></a>Атрибуты привязки данных  
 В следующих примерах показано реализацию сложную привязку данных. Уровня класса <xref:System.ComponentModel.ComplexBindingPropertiesAttribute>, показанный ранее, указывает `DataSource` и `DataMember` свойства, используемые для привязки данных. <xref:System.ComponentModel.AttributeProviderAttribute> Указывает тип, к которому `DataSource` будет привязано свойство.  
  
 [!code-csharp[System.ComponentModel.AttributesDemoControl#25](~/samples/snippets/csharp/VS_Snippets_Winforms/System.ComponentModel.AttributesDemoControl/CS/attributesdemocontrol.cs#25)]
 [!code-vb[System.ComponentModel.AttributesDemoControl#25](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.ComponentModel.AttributesDemoControl/VB/attributesdemocontrol.vb#25)]  
  
 [!code-csharp[System.ComponentModel.AttributesDemoControl#26](~/samples/snippets/csharp/VS_Snippets_Winforms/System.ComponentModel.AttributesDemoControl/CS/attributesdemocontrol.cs#26)]
 [!code-vb[System.ComponentModel.AttributesDemoControl#26](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.ComponentModel.AttributesDemoControl/VB/attributesdemocontrol.vb#26)]  
  
## <a name="compiling-the-code"></a>Компиляция кода  
  
-   Форма, содержащая `AttributesDemoControl` необходима ссылка на `AttributesDemoControl` сборки для сборки.  
  
## <a name="see-also"></a>См. также

- <xref:System.IComparable>
- <xref:System.Windows.Forms.DataGridView>
- [Разработка пользовательских элементов управления Windows Forms в .NET Framework](developing-custom-windows-forms-controls.md)
- [Атрибуты в элементах управления Windows Forms](attributes-in-windows-forms-controls.md)
- [Практическое руководство. Сериализация коллекций стандартных типов с использованием атрибута DesignerSerializationVisibilityAttribute](https://docs.microsoft.com/previous-versions/visualstudio/visual-studio-2013/ms171833(v=vs.120))
