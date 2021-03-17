---
title: Практическое руководство. Создание объекта данных
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- DataObject class [WPF], creating
- data objects [WPF], creating
- drag-and-drop [WPF], creating data objects
ms.assetid: 022fa142-717d-4fea-a53c-3b52e9d91aff
ms.openlocfilehash: deae8751518d9322e8d924a1b1fcbc20e25b35ed
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59121796"
---
# <a name="how-to-create-a-data-object"></a>Практическое руководство. Создание объекта данных
Ниже приведены примеры различных способов создания объекта данных, с помощью конструкторов, предоставляемые <xref:System.Windows.DataObject> класса.  
  
## <a name="example"></a>Пример  
  
### <a name="description"></a>Описание  
 В следующем примере кода создается новый объект данных и использует один из перегруженных конструкторов (<xref:System.Windows.DataObject.%23ctor%28System.Object%29>) для инициализации объекта данных со строкой.  В этом случае соответствующий формат данных определяется автоматически в соответствии с типом сохраненных данных и автоматическое преобразование сохраненных данных разрешено по умолчанию.  
  
### <a name="code"></a>Код  
 [!code-csharp[DragDrop_DragDropMiscCode#_DragDrop_CreateDataObject_Simple](~/samples/snippets/csharp/VS_Snippets_Wpf/DragDrop_DragDropMiscCode/CSharp/Window1.xaml.cs#_dragdrop_createdataobject_simple)]
 [!code-vb[DragDrop_DragDropMiscCode#_DragDrop_CreateDataObject_Simple](~/samples/snippets/visualbasic/VS_Snippets_Wpf/DragDrop_DragDropMiscCode/visualbasic/window1.xaml.vb#_dragdrop_createdataobject_simple)]  
  
### <a name="description"></a>Описание  
 В следующем примере кода — это сокращенный вариант приведенного выше кода.  
  
### <a name="code"></a>Код  
 [!code-csharp[DragDrop_DragDropMiscCode#_DragDrop_CreateDataObject_Simple_Condensed](~/samples/snippets/csharp/VS_Snippets_Wpf/DragDrop_DragDropMiscCode/CSharp/Window1.xaml.cs#_dragdrop_createdataobject_simple_condensed)]
 [!code-vb[DragDrop_DragDropMiscCode#_DragDrop_CreateDataObject_Simple_Condensed](~/samples/snippets/visualbasic/VS_Snippets_Wpf/DragDrop_DragDropMiscCode/visualbasic/window1.xaml.vb#_dragdrop_createdataobject_simple_condensed)]  
  
## <a name="example"></a>Пример  
  
### <a name="description"></a>Описание  
 В следующем примере кода создается новый объект данных и использует один из перегруженных конструкторов (<xref:System.Windows.DataObject.%23ctor%28System.String%2CSystem.Object%29>) для инициализации объекта данных со строкой и заданного формата данных.  В этом случае формат данных задается строкой. <xref:System.Windows.DataFormats> класс предоставляет набор предопределенных типов строк. По умолчанию разрешено автоматическое преобразование сохраненных данных.  
  
### <a name="code"></a>Код  
 [!code-csharp[DragDrop_DragDropMiscCode#_DragDrop_CreateDataObject_TypeString](~/samples/snippets/csharp/VS_Snippets_Wpf/DragDrop_DragDropMiscCode/CSharp/Window1.xaml.cs#_dragdrop_createdataobject_typestring)]
 [!code-vb[DragDrop_DragDropMiscCode#_DragDrop_CreateDataObject_TypeString](~/samples/snippets/visualbasic/VS_Snippets_Wpf/DragDrop_DragDropMiscCode/visualbasic/window1.xaml.vb#_dragdrop_createdataobject_typestring)]  
  
### <a name="description"></a>Описание  
 В следующем примере кода — это сокращенный вариант приведенного выше кода.  
  
### <a name="code"></a>Код  
 [!code-csharp[DragDrop_DragDropMiscCode#_DragDrop_CreateDataObject_TypeString_Condensed](~/samples/snippets/csharp/VS_Snippets_Wpf/DragDrop_DragDropMiscCode/CSharp/Window1.xaml.cs#_dragdrop_createdataobject_typestring_condensed)]
 [!code-vb[DragDrop_DragDropMiscCode#_DragDrop_CreateDataObject_TypeString_Condensed](~/samples/snippets/visualbasic/VS_Snippets_Wpf/DragDrop_DragDropMiscCode/visualbasic/window1.xaml.vb#_dragdrop_createdataobject_typestring_condensed)]  
  
## <a name="example"></a>Пример  
  
### <a name="description"></a>Описание  
 В следующем примере кода создается новый объект данных и использует один из перегруженных конструкторов (<xref:System.Windows.DataObject.%23ctor%2A>) для инициализации объекта данных со строкой и заданного формата данных.  В этом случае формат данных задается <xref:System.Type> параметра.  По умолчанию разрешено автоматическое преобразование сохраненных данных.  
  
### <a name="code"></a>Код  
 [!code-csharp[DragDrop_DragDropMiscCode#_DragDrop_CreateDataObject_Type](~/samples/snippets/csharp/VS_Snippets_Wpf/DragDrop_DragDropMiscCode/CSharp/Window1.xaml.cs#_dragdrop_createdataobject_type)]
 [!code-vb[DragDrop_DragDropMiscCode#_DragDrop_CreateDataObject_Type](~/samples/snippets/visualbasic/VS_Snippets_Wpf/DragDrop_DragDropMiscCode/visualbasic/window1.xaml.vb#_dragdrop_createdataobject_type)]  
  
### <a name="description"></a>Описание  
 В следующем примере кода — это сокращенный вариант приведенного выше кода.  
  
### <a name="code"></a>Код  
 [!code-csharp[DragDrop_DragDropMiscCode#_DragDrop_CreateDataObject_Type_Condensed](~/samples/snippets/csharp/VS_Snippets_Wpf/DragDrop_DragDropMiscCode/CSharp/Window1.xaml.cs#_dragdrop_createdataobject_type_condensed)]
 [!code-vb[DragDrop_DragDropMiscCode#_DragDrop_CreateDataObject_Type_Condensed](~/samples/snippets/visualbasic/VS_Snippets_Wpf/DragDrop_DragDropMiscCode/visualbasic/window1.xaml.vb#_dragdrop_createdataobject_type_condensed)]  
  
## <a name="example"></a>Пример  
  
### <a name="description"></a>Описание  
 В следующем примере кода создается новый объект данных и использует один из перегруженных конструкторов (<xref:System.Windows.DataObject.%23ctor%28System.String%2CSystem.Object%2CSystem.Boolean%29>) для инициализации объекта данных со строкой и заданного формата данных.  В этом случае формат данных задается строкой. <xref:System.Windows.DataFormats> класс предоставляет набор предопределенных типов строк. Этот перегруженный конструктор позволяет вызывающему объекту указать, разрешено ли автоматическое преобразование.  
  
### <a name="code"></a>Код  
 [!code-csharp[DragDrop_DragDropMiscCode#_DragDrop_CreateDataObject_AutoConvert](~/samples/snippets/csharp/VS_Snippets_Wpf/DragDrop_DragDropMiscCode/CSharp/Window1.xaml.cs#_dragdrop_createdataobject_autoconvert)]
 [!code-vb[DragDrop_DragDropMiscCode#_DragDrop_CreateDataObject_AutoConvert](~/samples/snippets/visualbasic/VS_Snippets_Wpf/DragDrop_DragDropMiscCode/visualbasic/window1.xaml.vb#_dragdrop_createdataobject_autoconvert)]  
  
### <a name="description"></a>Описание  
 В следующем примере кода — это сокращенный вариант приведенного выше кода.  
  
### <a name="code"></a>Код  
 [!code-csharp[DragDrop_DragDropMiscCode#_DragDrop_CreateDataObject_AutoConvert_Condensed](~/samples/snippets/csharp/VS_Snippets_Wpf/DragDrop_DragDropMiscCode/CSharp/Window1.xaml.cs#_dragdrop_createdataobject_autoconvert_condensed)]
 [!code-vb[DragDrop_DragDropMiscCode#_DragDrop_CreateDataObject_AutoConvert_Condensed](~/samples/snippets/visualbasic/VS_Snippets_Wpf/DragDrop_DragDropMiscCode/visualbasic/window1.xaml.vb#_dragdrop_createdataobject_autoconvert_condensed)]  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.IDataObject>
