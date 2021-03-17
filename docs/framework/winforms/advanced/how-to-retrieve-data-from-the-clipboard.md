---
title: Практическое руководство. Извлечение данных из буфера обмена
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- pasting Clipboard data
- Clipboard [Windows Forms], retrieving data
ms.assetid: 99612537-2c8a-449f-aab5-2b3b28d656e7
ms.openlocfilehash: e8f77a4fd1047598d51c2e0932d9c1309a305a86
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59295514"
---
# <a name="how-to-retrieve-data-from-the-clipboard"></a>Практическое руководство. Извлечение данных из буфера обмена
<xref:System.Windows.Forms.Clipboard> Класс предоставляет методы, которые можно использовать для взаимодействия с функцией буфер обмена операционной системы Windows. Многие приложения используют буфер обмена в качестве временного хранилища данных. Например текстовые редакторы использовать буфер обмена во время операций вырезания и вставки. Буфер обмена также полезен для передачи данных из одного приложения в другое.  
  
 Некоторые приложения сохраняют данные в буфер обмена в нескольких форматах, чтобы увеличить количество других приложений, которые потенциально могут использовать данные. Формат буфера обмена является строкой, которая определяет формат. Приложение, использующее указанный формат можно получить связанные данные в буфере обмена. <xref:System.Windows.Forms.DataFormats> Класс предоставляет имена стандартных форматов для использования. Можно также использовать собственные имена форматов или использовать тип объекта в качестве его формата. Сведения о добавлении данных в буфер обмена, см. в разделе [как: Добавление данных в буфер обмена](how-to-add-data-to-the-clipboard.md).  
  
 Чтобы определить, содержит ли буфер данных в определенном формате, используйте один из `Contains` *формат* методы или <xref:System.Windows.Forms.Clipboard.GetData%2A> метод. Чтобы извлечь данные из буфера обмена, используйте один из `Get` *формат* методы или <xref:System.Windows.Forms.Clipboard.GetData%2A> метод. Эти методы являются новыми в [!INCLUDE[dnprdnext](../../../../includes/dnprdnext-md.md)].  
  
 Для доступа к данным из буфера обмена с помощью версий более ранних, чем [!INCLUDE[dnprdnlong](../../../../includes/dnprdnlong-md.md)], использовать <xref:System.Windows.Forms.Clipboard.GetDataObject%2A> метод и вызывать методы возвращаемого <xref:System.Windows.Forms.IDataObject>. Чтобы определить, доступен ли определенный формат в возвращенном объекте, к примеру, вызовите <xref:System.Windows.Forms.IDataObject.GetDataPresent%2A> метод.  
  
> [!NOTE]
>  Все приложения Windows используют системного буфера обмена. Таким образом содержимое могут меняться при переходе в другое приложение.  
>   
>  <xref:System.Windows.Forms.Clipboard> Класс может использоваться только в потоках в однопотоковое подразделение (STA) режиме. Чтобы использовать этот класс, убедитесь, что ваш `Main` метод помечен атрибутом <xref:System.STAThreadAttribute> атрибута.  
  
### <a name="to-retrieve-data-from-the-clipboard-in-a-single-common-format"></a>Для получения данных из буфера обмена в виде единого  
  
1. Используйте <xref:System.Windows.Forms.Clipboard.GetAudioStream%2A>, <xref:System.Windows.Forms.Clipboard.GetFileDropList%2A>, <xref:System.Windows.Forms.Clipboard.GetImage%2A>, или <xref:System.Windows.Forms.Clipboard.GetText%2A> метод. При необходимости используйте соответствующий `Contains` *формат* методы, чтобы определить, доступен ли данные в определенном формате. Эти методы доступны только в [!INCLUDE[dnprdnext](../../../../includes/dnprdnext-md.md)].  
  
     [!code-csharp[System.Windows.Forms.Clipboard#2](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.Clipboard/CS/form1.cs#2)]
     [!code-vb[System.Windows.Forms.Clipboard#2](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Windows.Forms.Clipboard/vb/form1.vb#2)]  
  
### <a name="to-retrieve-data-from-the-clipboard-in-a-custom-format"></a>Для получения данных из буфера обмена в пользовательском формате  
  
1. Используйте <xref:System.Windows.Forms.Clipboard.GetData%2A> метод с именем пользовательского формата. Этот метод доступен только в [!INCLUDE[dnprdnext](../../../../includes/dnprdnext-md.md)].  
  
     Можно также использовать имена стандартных форматов с <xref:System.Windows.Forms.Clipboard.SetData%2A> метод. Дополнительные сведения см. в разделе <xref:System.Windows.Forms.DataFormats>.  
  
     [!code-csharp[System.Windows.Forms.Clipboard#3](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.Clipboard/CS/form1.cs#3)]
     [!code-vb[System.Windows.Forms.Clipboard#3](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Windows.Forms.Clipboard/vb/form1.vb#3)]  
    [!code-csharp[System.Windows.Forms.Clipboard#100](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.Clipboard/CS/form1.cs#100)]
    [!code-vb[System.Windows.Forms.Clipboard#100](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Windows.Forms.Clipboard/vb/form1.vb#100)]  
  
### <a name="to-retrieve-data-from-the-clipboard-in-multiple-formats"></a>Для получения данных из буфера обмена в нескольких форматах  
  
1. Воспользуйтесь методом <xref:System.Windows.Forms.Clipboard.GetDataObject%2A>. Этот метод следует использовать для получения данных из буфера обмена на версии более ранней, чем [!INCLUDE[dnprdnlong](../../../../includes/dnprdnlong-md.md)].  
  
     [!code-csharp[System.Windows.Forms.Clipboard#4](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.Clipboard/CS/form1.cs#4)]
     [!code-vb[System.Windows.Forms.Clipboard#4](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Windows.Forms.Clipboard/vb/form1.vb#4)]  
    [!code-csharp[System.Windows.Forms.Clipboard#100](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.Clipboard/CS/form1.cs#100)]
    [!code-vb[System.Windows.Forms.Clipboard#100](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Windows.Forms.Clipboard/vb/form1.vb#100)]  
  
## <a name="see-also"></a>См. также

- [Операции перетаскивания и поддержка буфера обмена](drag-and-drop-operations-and-clipboard-support.md)
- [Практическое руководство. Добавление данных в буфер обмена](how-to-add-data-to-the-clipboard.md)
