---
title: Практическое руководство. Добавление данных в буфер обмена
ms.date: 03/30/2017
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.lasthandoff: 04/09/2019
---
# <a name="how-to-add-data-to-the-clipboard"></a>Практическое руководство. Добавление данных в буфер обмена
Класс <xref:System.Windows.Forms.Clipboard> предоставляет методы, которые можно использовать для взаимодействия с буфером обмена операционной системы Windows. Многие приложения используют буфер обмена в качестве временного хранилища данных. Например текстовые редакторы используют буфер обмена во время операций вырезания и вставки. Буфер обмена также полезен для передачи данных из одного приложения в другое.  
  
 При добавлении данных в буфер обмена, можно указать формат данных, таким образом другие приложения могут распознать данные, если они поддерживают этот формат. Можно также добавить данные в буфер обмена в нескольких различных форматах, чтобы увеличить число приложений, которые потенциально могут использовать эти данные.  
  
 *Формат буфера обмена* — это строка, которая определяет имя формата данных, с помощью которой приложения могут получить данные нужного формата из буфера обмена. Класс <xref:System.Windows.Forms.DataFormats> предоставляет имена стандартных форматов. Можно также использовать собственные имена форматов или использовать тип объекта в качестве его формата.  
  
 Чтобы добавить данные в буфер обмена в одном или нескольких форматах, используйте метод <xref:System.Windows.Forms.Clipboard.SetDataObject%2A>. В этот метод можно передать любой сериализуемый объект, но для добавления данных в нескольких форматах, необходимо поместить данные в объект, предназначенный для работы с несколькими форматами. Как правило, для этого используется тип <xref:System.Windows.Forms.DataObject>, но вы можете использовать любой тип, реализующий интерфейс <xref:System.Windows.Forms.IDataObject>.  
  
Для добавления данных в одном из стандартных форматов можно использовать метод, соответствующий этому формату. Например, для текста это <xref:System.Windows.Forms.Clipboard.SetText%2A>.
  
> [!NOTE]
>  Все приложения Windows используют буфер обмена. Таким образом, его содержимое может меняться при переходе в другое приложение.  
>   
>  Класс <xref:System.Windows.Forms.Clipboard> может использоваться только в однопотоковом режиме (STA). Чтобы использовать этот класс, убедитесь, что ваш метод `Main` помечен атрибутом <xref:System.STAThreadAttribute>.
> 
>  Объект должен поддерживать сериализацию для помещения в буфер обмена. Чтобы сделать тип сериализуемым, необходимо отметить его атрибутом <xref:System.SerializableAttribute>. Если методу буфера обмена передается несериализуемый объект, метод завершится с ошибкой без выдачи исключения. Дополнительные сведения о сериализации см. в разделе <xref:System.Runtime.Serialization>.
  
### <a name="to-add-data-to-the-clipboard-in-a-single-common-format"></a>Для добавления данных в буфер обмена в одном стандартном формате  
  
1. Используйте методы <xref:System.Windows.Forms.Clipboard.SetAudio%2A>, <xref:System.Windows.Forms.Clipboard.SetFileDropList%2A>, <xref:System.Windows.Forms.Clipboard.SetImage%2A>, или <xref:System.Windows.Forms.Clipboard.SetText%2A>.
  
     [!code-csharp[System.Windows.Forms.Clipboard#2](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.Clipboard/CS/form1.cs#2)]
       
  
### <a name="to-add-data-to-the-clipboard-in-a-custom-format"></a>Для добавления данных в буфер обмена в пользовательском формате  
  
1. Используйте метод <xref:System.Windows.Forms.Clipboard.SetData%2A>, передавая в него имя пользовательского формата.
  
     В метод <xref:System.Windows.Forms.Clipboard.SetData%2A> можно также передавать имена стандартных форматов. Дополнительные сведения см. в разделе <xref:System.Windows.Forms.DataFormats>.  
  
     [!code-csharp[System.Windows.Forms.Clipboard#3](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.Clipboard/CS/form1.cs#3)]
       
    [!code-csharp[System.Windows.Forms.Clipboard#100](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.Clipboard/CS/form1.cs#100)]
      
  
### <a name="to-add-data-to-the-clipboard-in-multiple-formats"></a>Для добавления данных в буфер обмена в нескольких форматах  
  
1. Используйте метод <xref:System.Windows.Forms.Clipboard.SetDataObject%2A> и передайте в него <xref:System.Windows.Forms.DataObject>, содержащий нужные данные.
  
     [!code-csharp[System.Windows.Forms.Clipboard#4](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.Clipboard/CS/form1.cs#4)]
       
    [!code-csharp[System.Windows.Forms.Clipboard#100](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.Clipboard/CS/form1.cs#100)]
      
  
## <a name="see-also"></a>См. также

- [Операции перетаскивания и поддержка буфера обмена](drag-and-drop-operations-and-clipboard-support.md)
- [Практическое руководство. Извлечение данных из буфера обмена](how-to-retrieve-data-from-the-clipboard.md)
