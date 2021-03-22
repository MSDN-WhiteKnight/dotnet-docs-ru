---
title: Практическое руководство. Связывание элемента управления с типом в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- controls [Windows Forms], binding to a type
- BindingSource component [Windows Forms], binding to a type
- types [Windows Forms], binding controls to
ms.assetid: 94faeebb-d2bc-45d6-86d7-96a42661b43d
ms.openlocfilehash: f47090f5d0765833f7ac17a947691a4693d9923b
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59162494"
---
# <a name="how-to-bind-a-windows-forms-control-to-a-type"></a>Практическое руководство. Связывание элемента управления с типом в Windows Forms
При создании элементов управления, взаимодействующих с данными, иногда бывает нужно привязать элемент управления к типу, а не к объекту. Такая ситуация особенно часто возникает на этапе разработки, когда данные недоступны, но все равно нужно, чтобы элемент управления отображал данные из открытого интерфейса типа. Например, вы привязываете элемент управления <xref:System.Windows.Forms.DataGridView> к объекту, предоставляемому веб-службой, и хотите, чтобы во время разработки элемент управления <xref:System.Windows.Forms.DataGridView> помечал свои столбцы именами членов пользовательского типа.  
  
 Элемент управления можно легко привязать к типу с помощью компонента <xref:System.Windows.Forms.BindingSource>.  
  
## <a name="example"></a>Пример  
 В примере кода ниже показано, как привязать элемент управления <xref:System.Windows.Forms.DataGridView> к пользовательскому типу с помощью компонента <xref:System.Windows.Forms.BindingSource>. После запуска примера можно увидеть, что <xref:System.Windows.Forms.DataGridView> пометил столбцы, отражающие свойства объекта `Customer`, перед заполнением элемента управления данными. В примере есть кнопка Add Customer (Добавить клиента) для добавления данных в элемент управления <xref:System.Windows.Forms.DataGridView>. При нажатии на кнопку новый объект `Customer` добавляется в <xref:System.Windows.Forms.BindingSource>. В реальном сценарии данные можно было бы получить путем вызова веб-службы или другого источника данных.  
  
 [!code-csharp[System.Windows.Forms.DataConnector.BindingToType#1](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataConnector.BindingToType/CS/form1.cs#1)]
   
  
## <a name="compiling-the-code"></a>Компиляция кода  
 Для этого примера требуются:  
  
-   ссылки на сборки System и System.Windows.Forms;  
  
 Сведения о выполнении сборки этого примера из командной строки для Visual Basic или Visual C#, см. в разделе [построение из командной строки](../../../visual-basic/reference/command-line-compiler/building-from-the-command-line.md) или [командной строки создания с помощью csc.exe](../../../csharp/language-reference/compiler-options/command-line-building-with-csc-exe.md). Можно также сборке этого примера в Visual Studio путем вставки кода в новый проект.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.BindingNavigator>
- <xref:System.Windows.Forms.DataGridView>
- <xref:System.Windows.Forms.BindingSource>
- [Компонент BindingSource](bindingsource-component.md)
