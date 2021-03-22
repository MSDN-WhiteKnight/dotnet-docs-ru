---
title: Данные и объекты данных
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- data transfer [WPF], drag-and-drop
- DataFormats class [WPF]
- DataObject class [WPF]
ms.assetid: 5967d557-1867-420f-a524-ae3af78402da
ms.openlocfilehash: 9dc195ece60739cf0c137a2893c9e9150e0d4d3f
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59312063"
---
# <a name="data-and-data-objects"></a>Данные и объекты данных
Данные, передаваемые как часть операции перетаскивания и вставки хранятся в объекте данных.  Концептуально объект данных состоит из одного или нескольких из следующих пар:  
  
-   <xref:System.Object> , Содержит фактические данные.  
  
-   Соответствующий идентификатор формата данных.  
  
 Сами данные могут состоять из всего, который может быть представлен в качестве основы <xref:System.Object>.  Соответствующий формат данных является строкой или <xref:System.Type> , предоставляет подсказку о формате в.  Объекты данных поддерживают размещение нескольких пар формат данных/данные; Это позволяет один объект данных для предоставления данных в нескольких форматах.  
  
<a name="Data_and_Data_Objects"></a>   
## <a name="data-objects"></a>Объекты данных  
 Все объекты данных должны реализовывать <xref:System.Windows.IDataObject> интерфейс, который предоставляет следующий стандартный набор методов для включения и упрощения передачи данных.  
  
|Метод|Сводка|  
|------------|-------------|  
|<xref:System.Windows.IDataObject.GetData%2A>|Извлекает объект данных в указанном формате данных.|  
|<xref:System.Windows.IDataObject.GetDataPresent%2A>|Проверяет наличие данных в, или можно преобразовать в указанный формат.|  
|<xref:System.Windows.IDataObject.GetFormats%2A>|Возвращает список форматов, которые хранятся в данные в этом объекте данных, или может быть преобразован в.|  
|<xref:System.Windows.IDataObject.SetData%2A>|Сохраняет указанные данные в этом объекте данных.|  
  
 [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)] Предоставляет базовую реализацию <xref:System.Windows.IDataObject> в <xref:System.Windows.DataObject> класса. Акции <xref:System.Windows.DataObject> класс является достаточным для многих распространенных сценариев передачи данных.  
  
 Существует несколько предварительно определенных форматов, таких как растровое изображение, CSV, файл, HTML, RTF, строки, текст и аудио. Сведения о преопределенных форматах данных в состав [!INCLUDE[TLA2#tla_winclient](../../../../includes/tla2sharptla-winclient-md.md)], см. в разделе <xref:System.Windows.DataFormats> класс справочном разделе.  
  
 Объекты данных обычно включают средства для автоматического преобразования данных, хранящихся в одного формата в другой формат при извлечении данных; Это средство называется автоматический переход. При запросе форматов данных, доступных в объекте данных, автоматически преобразуемые форматы могут фильтроваться из собственных форматов данных, вызвав <xref:System.Windows.DataObject.GetFormats%28System.Boolean%29> или <xref:System.Windows.DataObject.GetDataPresent%28System.String%2CSystem.Boolean%29> и задав `autoConvert` параметра в виде `false`.  При добавлении данных в объект данных с <xref:System.Windows.DataObject.SetData%28System.String%2CSystem.Object%2CSystem.Boolean%29> метод, автоматическое преобразование данных может быть запрещено, задав `autoConvert` параметр `false`.  
  
<a name="Working_with_Data_Objects"></a>   
## <a name="working-with-data-objects"></a>Работа с объектами данных  
 В этом разделе описаны общие методы для создания и работы с объектами данных.  
  
### <a name="creating-new-data-objects"></a>Создание новых объектов данных  
 <xref:System.Windows.DataObject> Класс предоставляет несколько перегруженных конструкторов, предназначенных для упрощения заполнение нового <xref:System.Windows.DataObject> экземпляра с парой формат единый данных.  
  
 В следующем примере кода создается новый объект данных и использует один из перегруженных конструкторов <xref:System.Windows.DataObject.%23ctor%2A>(<xref:System.Windows.DataObject.%23ctor(System.String,System.Object)>) для инициализации объекта данных со строкой и заданного формата данных.  В этом случае формат данных задается строкой. <xref:System.Windows.DataFormats> класс предоставляет набор предопределенных типов строк. По умолчанию разрешен автоматического преобразования хранимых данных.  
  
 [!code-csharp[DragDrop_DragDropMiscCode#_DragDrop_CreateDataObject_TypeString](~/samples/snippets/csharp/VS_Snippets_Wpf/DragDrop_DragDropMiscCode/CSharp/Window1.xaml.cs#_dragdrop_createdataobject_typestring)]
   
  
 Дополнительные примеры кода, который создает объект данных, см. в разделе [создать объект данных](how-to-create-a-data-object.md).  
  
### <a name="storing-data-in-multiple-formats"></a>Хранение данных в нескольких форматах  
 Один объект данных имеет возможность хранения данных в нескольких форматах.   Стратегического использования данных в нескольких форматах в одном объекте данных делает объект данных множеством разных мест перетаскивания, чем шире, если только может быть представлен только один формат данных.  Обратите внимание на то, что, как правило, источником перетаскивания не должны зависеть о форматах данных, которые могут использоваться возможные конечные расположения сброса.  
  
 В следующем примере показано, как использовать <xref:System.Windows.DataObject.SetData%28System.String%2CSystem.Object%29> метод для добавления данных в объект данных в нескольких форматах.  
  
 [!code-csharp[DragDrop_DragDropMiscCode#_DragDrop_StoreMultipleFormats](~/samples/snippets/csharp/VS_Snippets_Wpf/DragDrop_DragDropMiscCode/CSharp/Window1.xaml.cs#_dragdrop_storemultipleformats)]
   
  
### <a name="querying-a-data-object-for-available-formats"></a>Опрашивается объект данных для доступных форматов  
 Так как один объект данных может содержать произвольное число форматов данных, объекты данных включают средства для получения списка доступных форматов данных.  
  
 В следующем примере кода используется <xref:System.Windows.DataObject.GetFormats%2A> перегрузки, чтобы получить массив строк, обозначающих все форматы данных, доступные в объекте данных (собственный и с автоматическим преобразованием).  
  
 [!code-csharp[DragDrop_DragDropMiscCode#_DragDrop_GetAllDataFormats](~/samples/snippets/csharp/VS_Snippets_Wpf/DragDrop_DragDropMiscCode/CSharp/Window1.xaml.cs#_dragdrop_getalldataformats)]
   
  
 Дополнительные примеры кода, который запрашивает объект данных, доступные форматы данных, см. в разделе [перечисление форматов данных в объекте данных](how-to-list-the-data-formats-in-a-data-object.md).  Примеры запросов объектов данных на наличие определенного формата данных, см. в разделе [Определение присутствия формата данных в объекте данных](how-to-determine-if-a-data-format-is-present-in-a-data-object.md).  
  
### <a name="retrieving-data-from-a-data-object"></a>Извлечение данных из объекта данных  
 Извлечение данных из объекта данных в определенном формате необходимо просто вызвать один из <xref:System.Windows.DataObject.GetData%2A> методы и указав требуемый формат данных.  Один из <xref:System.Windows.DataObject.GetDataPresent%2A> методы могут использоваться для проверки на наличие определенного формата данных.  <xref:System.Windows.DataObject.GetData%2A> Возвращает данные в <xref:System.Object>; в зависимости от формата данных, этот объект может быть приведен к контейнеру определенного типа.  
  
 В следующем примере кода используется <xref:System.Windows.DataObject.GetDataPresent%28System.String%29> перегрузки, чтобы проверить, доступно ли заданного формата данных (встроенный или с автоматическим преобразованием). Если доступен указанный формат, данные извлекаются с помощью <xref:System.Windows.DataObject.GetData%28System.String%29> метод.  
  
 [!code-csharp[DragDrop_DragDropMiscCode#_DragDrop_GetSpecificDataFormat](~/samples/snippets/csharp/VS_Snippets_Wpf/DragDrop_DragDropMiscCode/CSharp/Window1.xaml.cs#_dragdrop_getspecificdataformat)]
   
  
 Дополнительные примеры кода, который извлекает данные из объекта данных, см. в разделе [получение данных в определенном формате данных](how-to-retrieve-data-in-a-particular-data-format.md).  
  
### <a name="removing-data-from-a-data-object"></a>Удаление данных из объекта данных  
 Невозможно удалить данные непосредственно из объекта данных.  Для эффективного удаления данных из объекта данных, выполните следующие действия.  
  
1. Создайте новый объект данных, который будет содержать только данные, которые вы хотите сохранить.  
  
2. «Копировать» необходимых данных из старых объектов данных в новый объект данных.  Чтобы скопировать данные, используйте один из <xref:System.Windows.DataObject.GetData%2A> методы для получения <xref:System.Object> содержит необработанные данные и затем воспользуйтесь одним из <xref:System.Windows.DataObject.SetData%2A> методы для добавления данных в новый объект данных.  
  
3. Замените старый объект данных новым.  
  
> [!NOTE]
>  <xref:System.Windows.DataObject.SetData%2A> Методы добавлять только данные в объект данных; они не избавляют данных, даже если в данных и формат данных точно так же, как в предыдущем вызове. Вызов <xref:System.Windows.DataObject.SetData%2A> дважды, чтобы те же данные и данные формат приведет к формат данных и данных, они отсутствуют в объекте данных дважды.
