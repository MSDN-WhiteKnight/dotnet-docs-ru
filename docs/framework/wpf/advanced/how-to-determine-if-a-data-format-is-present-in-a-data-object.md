---
title: Практическое руководство. Определение присутствия формата данных в объекте данных
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- DataFormats class [WPF]
- drag-and-drop [WPF], data formats present
- data formats [WPF], determining if present
ms.assetid: e487a454-c9fc-4e53-aeaa-c458d059ad4c
ms.openlocfilehash: 4cec733490e2a9dc5d54b3b253ac38a5090ac885
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59207972"
---
# <a name="how-to-determine-if-a-data-format-is-present-in-a-data-object"></a>Практическое руководство. Определение присутствия формата данных в объекте данных
Следующие примеры показывают, как использовать различные <xref:System.Windows.DataObject.GetDataPresent%2A> перегрузки метода к запросу ли определенного формата данных присутствует в объекте данных.  
  
## <a name="example"></a>Пример  
  
### <a name="description"></a>Описание  
 В следующем примере кода используется <xref:System.Windows.DataObject.GetDataPresent%28System.String%29> перегрузки для запроса на наличие определенного формата данных, строки дескриптора.  
  
### <a name="code"></a>Код  
 [!code-csharp[DragDrop_DragDropMiscCode#_DragDrop_QueryDataFormats_String](~/samples/snippets/csharp/VS_Snippets_Wpf/DragDrop_DragDropMiscCode/CSharp/Window1.xaml.cs#_dragdrop_querydataformats_string)]
 [!code-vb[DragDrop_DragDropMiscCode#_DragDrop_QueryDataFormats_String](~/samples/snippets/visualbasic/VS_Snippets_Wpf/DragDrop_DragDropMiscCode/visualbasic/window1.xaml.vb#_dragdrop_querydataformats_string)]  
  
## <a name="example"></a>Пример  
  
### <a name="description"></a>Описание  
 В следующем примере кода используется <xref:System.Windows.DataObject.GetDataPresent%28System.Type%29> перегрузки для запроса на наличие определенного формата данных по типу.  
  
### <a name="code"></a>Код  
 [!code-csharp[DragDrop_DragDropMiscCode#_DragDrop_QueryDataFormats_Type](~/samples/snippets/csharp/VS_Snippets_Wpf/DragDrop_DragDropMiscCode/CSharp/Window1.xaml.cs#_dragdrop_querydataformats_type)]
 [!code-vb[DragDrop_DragDropMiscCode#_DragDrop_QueryDataFormats_Type](~/samples/snippets/visualbasic/VS_Snippets_Wpf/DragDrop_DragDropMiscCode/visualbasic/window1.xaml.vb#_dragdrop_querydataformats_type)]  
  
## <a name="example"></a>Пример  
  
### <a name="description"></a>Описание  
 В следующем примере кода используется <xref:System.Windows.DataObject.GetDataPresent%28System.String%2CSystem.Boolean%29> перегрузки для запроса к данным по строке дескриптора и указать способ обрабатывать форматы автоматически преобразуемые данные.  
  
### <a name="code"></a>Код  
 [!code-csharp[DragDrop_DragDropMiscCode#_DragDrop_QueryDataFormats_Autoconvert](~/samples/snippets/csharp/VS_Snippets_Wpf/DragDrop_DragDropMiscCode/CSharp/Window1.xaml.cs#_dragdrop_querydataformats_autoconvert)]
 [!code-vb[DragDrop_DragDropMiscCode#_DragDrop_QueryDataFormats_Autoconvert](~/samples/snippets/visualbasic/VS_Snippets_Wpf/DragDrop_DragDropMiscCode/visualbasic/window1.xaml.vb#_dragdrop_querydataformats_autoconvert)]  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.IDataObject>
