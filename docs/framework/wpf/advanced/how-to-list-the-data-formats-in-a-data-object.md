---
title: Практическое руководство. Перечисление форматов данных в объекте данных
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- drag-and-drop [WPF], listing data formats
- DataFormats class [WPF]
- data formats [WPF], listing
ms.assetid: 18e7ba4b-ccef-4815-ae2d-3a32891010c0
ms.openlocfilehash: f8230eac33a18a0d99cc757d54c2b901c1afe977
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59077749"
---
# <a name="how-to-list-the-data-formats-in-a-data-object"></a>Практическое руководство. Перечисление форматов данных в объекте данных
Следующие примеры показывают, как использовать <xref:System.Windows.DataObject.GetFormats%2A> перегрузок метода получить массив строк, обозначающих каждого формата данных, который доступен в объекте данных.  
  
## <a name="example"></a>Пример  
  
### <a name="description"></a>Описание  
 В следующем примере кода используется <xref:System.Windows.DataObject.GetFormats%2A> перегрузки, чтобы получить массив строк, обозначающих все форматы данных, доступные в объекте данных (как собственные, так и автоматически преобразуемые).  
  
### <a name="code"></a>Код  
 [!code-csharp[DragDrop_DragDropMiscCode#_DragDrop_GetAllDataFormats](~/samples/snippets/csharp/VS_Snippets_Wpf/DragDrop_DragDropMiscCode/CSharp/Window1.xaml.cs#_dragdrop_getalldataformats)]
   
  
## <a name="example"></a>Пример  
  
### <a name="description"></a>Описание  
 В следующем примере кода используется <xref:System.Windows.DataObject.GetFormats%2A> перегрузку для получения массива строк, обозначающих только форматы данных, доступных в объекте данных (автоматически преобразуемые данные фильтруются форматы).  
  
### <a name="code"></a>Код  
 [!code-csharp[DragDrop_DragDropMiscCode#_DragDrop_GetAllDataFormats_NativeOnly](~/samples/snippets/csharp/VS_Snippets_Wpf/DragDrop_DragDropMiscCode/CSharp/Window1.xaml.cs#_dragdrop_getalldataformats_nativeonly)]
   
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.IDataObject>
- [Общие сведения о перетаскивании](drag-and-drop-overview.md)
