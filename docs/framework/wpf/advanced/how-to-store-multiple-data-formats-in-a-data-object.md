---
title: Практическое руководство. Хранение данных в нескольких форматах в объекте данных
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- DataObject class [WPF], storing multiple formats
- DataFormats class [WPF], storing multiple formats
- drag-and-drop [WPF], storing multiple formats
ms.assetid: 941ace29-29c4-4c26-b75b-ea7d06aa0d69
ms.openlocfilehash: 3f8e7233e1d28fec1f7dac114b04287aa3aff49f
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59085055"
---
# <a name="how-to-store-multiple-data-formats-in-a-data-object"></a>Практическое руководство. Хранение данных в нескольких форматах в объекте данных
В следующем примере показано, как использовать <xref:System.Windows.DataObject.SetData%28System.String%2CSystem.Object%29> метод для добавления данных в объект данных в нескольких форматах.  
  
## <a name="example"></a>Пример  
  
### <a name="description"></a>Описание  
  
### <a name="code"></a>Код  
 [!code-csharp[DragDrop_DragDropMiscCode#_DragDrop_StoreMultipleFormats](~/samples/snippets/csharp/VS_Snippets_Wpf/DragDrop_DragDropMiscCode/CSharp/Window1.xaml.cs#_dragdrop_storemultipleformats)]
   
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.IDataObject>
- [Общие сведения о перетаскивании](drag-and-drop-overview.md)
