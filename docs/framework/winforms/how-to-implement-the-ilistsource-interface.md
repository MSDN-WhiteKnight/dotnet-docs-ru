---
title: Практическое руководство. Реализация интерфейса IListSource
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- data binding [Windows Forms], implementing
- IListSource interface
ms.assetid: 63ce27aa-2e23-4fbd-8228-0c1726f6c421
ms.openlocfilehash: bd4e554b7e4be51847496307b50be3084d0115d5
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59159787"
---
# <a name="how-to-implement-the-ilistsource-interface"></a>Практическое руководство. Реализация интерфейса IListSource
Реализовать <xref:System.ComponentModel.IListSource> интерфейс, чтобы создать связываемый класс, который не реализует <xref:System.Collections.IList> , но вместо этого предоставляет список из другого расположения.  
  
## <a name="example"></a>Пример  
 В следующем примере кода показано, как реализовать <xref:System.ComponentModel.IListSource> интерфейс. Компонент с именем `EmployeeListSource` предоставляет <xref:System.Collections.IList> для привязки данных путем реализации <xref:System.ComponentModel.IListSource.GetList%2A> метод.  
  
 [!code-csharp[System.ComponentModel.IListSource#1](~/samples/snippets/csharp/VS_Snippets_Winforms/System.ComponentModel.IListSource/CS/EmployeeListSource.cs#1)]
   
  
 [!code-csharp[System.ComponentModel.IListSource#10](~/samples/snippets/csharp/VS_Snippets_Winforms/System.ComponentModel.IListSource/CS/Employee.cs#10)]
   
  
 [!code-csharp[System.ComponentModel.IListSource#100](~/samples/snippets/csharp/VS_Snippets_Winforms/System.ComponentModel.IListSource/CS/BusinessObjectBase.cs#100)]
   
  
 [!code-csharp[System.ComponentModel.IListSource#1000](~/samples/snippets/csharp/VS_Snippets_Winforms/System.ComponentModel.IListSource/CS/Form1.cs#1000)]
   
  
## <a name="compiling-the-code"></a>Компиляция кода  
 Для этого примера требуются:  
  
-   ссылки на сборки System.Drawing и System.Windows.Forms.  
  
## <a name="see-also"></a>См. также

- <xref:System.ComponentModel.IListSource>
- <xref:System.ComponentModel.ITypedList>
- <xref:System.ComponentModel.BindingList%601>
- <xref:System.ComponentModel.IBindingList>
- [Связывание данных и Windows Forms](data-binding-and-windows-forms.md)
