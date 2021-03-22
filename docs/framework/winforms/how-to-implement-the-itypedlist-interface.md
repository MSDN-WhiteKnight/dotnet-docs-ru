---
title: Практическое руководство. Реализация интерфейса ITypedList
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- ITypedList interface
- BindingList(Of T) class
- data binding [Windows Forms], implementing
- IBindingList interface
ms.assetid: 834cc15c-50bc-4a8b-a610-313d6a217357
ms.openlocfilehash: 2463a9c77a9836ff251e799056cc5131bf6c99e0
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59084934"
---
# <a name="how-to-implement-the-itypedlist-interface"></a>Практическое руководство. Реализация интерфейса ITypedList
Реализуйте <xref:System.ComponentModel.ITypedList> интерфейс, чтобы включить обнаружение схемы для связываемого списка.  
  
## <a name="example"></a>Пример  
 В следующем примере кода показано, как реализовать <xref:System.ComponentModel.ITypedList> интерфейс. Универсальный тип с именем `SortableBindingList` является производным от <xref:System.ComponentModel.BindingList%601> и реализующий <xref:System.ComponentModel.ITypedList> интерфейс. Простой класс с именем `Customer` данных, который привязан к заголовку <xref:System.Windows.Forms.DataGridView> элемента управления.  
  
 [!code-csharp[System.ComponentModel.ITypedList#1](~/samples/snippets/csharp/VS_Snippets_Winforms/System.ComponentModel.ITypedList/CS/SortableBindingList.cs#1)]
   
  
 [!code-csharp[System.ComponentModel.ITypedList#10](~/samples/snippets/csharp/VS_Snippets_Winforms/System.ComponentModel.ITypedList/CS/Customer.cs#10)]
   
  
 [!code-csharp[System.ComponentModel.ITypedList#100](~/samples/snippets/csharp/VS_Snippets_Winforms/System.ComponentModel.ITypedList/CS/Form1.cs#100)]
   
  
## <a name="compiling-the-code"></a>Компиляция кода  
 Для этого примера требуются:  
  
-   ссылки на сборки System.Drawing и System.Windows.Forms.  
  
## <a name="see-also"></a>См. также

- <xref:System.ComponentModel.ITypedList>
- <xref:System.ComponentModel.BindingList%601>
- <xref:System.ComponentModel.IBindingList>
- [Связывание данных и Windows Forms](data-binding-and-windows-forms.md)
