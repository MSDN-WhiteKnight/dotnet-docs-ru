---
title: Практическое руководство. Реагирование на изменения схемы шрифтов в приложениях Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- Windows Forms, font scheme changes
ms.assetid: 4db27702-22e7-43bf-a07d-9a004549853c
ms.openlocfilehash: 6aad851770fb886de5d5c00b544ac6eac2857e42
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59339051"
---
# <a name="how-to-respond-to-font-scheme-changes-in-a-windows-forms-application"></a>Практическое руководство. Реагирование на изменения схемы шрифтов в приложениях Windows Forms
В операционных системах Windows пользователь может изменить параметры шрифта во всей системе, чтобы проверить шрифт по умолчанию отображаются, больше или меньше. Изменение этих параметров шрифта важно для пользователей с нарушениями зрения и требуют более длинный тип для чтения текста на экране компьютера. Вы можете настроить приложение Windows Forms реагировать на эти изменения путем увеличения или уменьшения размера формы и все содержащиеся в нем текст при каждом изменении шрифтовой схемы. Если требуется, чтобы формы в соответствии с изменениями в размерах шрифта динамически, можно добавить код в форму.  
  
 Как правило, шрифт по умолчанию, используемые в Windows Forms используется шрифт, возвращенный <xref:Microsoft.Win32> вызов пространства имен `GetStockObject(DEFAULT_GUI_FONT)`. Шрифт, возвращаемый при вызове этого метода изменяется только при изменении разрешения экрана. Как показано в следующей процедуре, ваш код должен изменить шрифт по умолчанию для <xref:System.Drawing.SystemFonts.IconTitleFont%2A> реагировать на изменения размера шрифта.  
  
### <a name="to-use-the-desktop-font-and-respond-to-font-scheme-changes"></a>Чтобы использовать шрифт рабочего стола и реагировать на изменения схемы шрифтов  
  
1. Создайте форму и добавьте элементы управления к нему. Дополнительные сведения см. в разделе [Как Создание приложения Windows Forms из командной строки](how-to-create-a-windows-forms-application-from-the-command-line.md) и [элементы управления для использования в формах Windows Forms](./controls/controls-to-use-on-windows-forms.md).  
  
2. Добавьте ссылку на <xref:Microsoft.Win32> пространства имен в код.  
  
     [!code-csharp[WinFormsAutoScaling#2](~/samples/snippets/csharp/VS_Snippets_Winforms/WinFormsAutoScaling/CS/Form1.cs#2)]
     [!code-vb[WinFormsAutoScaling#2](~/samples/snippets/visualbasic/VS_Snippets_Winforms/WinFormsAutoScaling/VB/Form1.vb#2)]  
  
3. Добавьте следующий код в конструктор формы для привязки обработчиков событий, а также изменять шрифт по умолчанию используется для формы.  
  
     [!code-csharp[WinFormsAutoScaling#3](~/samples/snippets/csharp/VS_Snippets_Winforms/WinFormsAutoScaling/CS/Form1.cs#3)]
     [!code-vb[WinFormsAutoScaling#3](~/samples/snippets/visualbasic/VS_Snippets_Winforms/WinFormsAutoScaling/VB/Form1.vb#3)]  
  
4. Реализовать обработчик для <xref:Microsoft.Win32.SystemEvents.UserPreferenceChanged> событие, которое приводит к автоматическому масштабированию формы при <xref:Microsoft.Win32.UserPreferenceCategory.Window> категории изменения.  
  
     [!code-csharp[WinFormsAutoScaling#4](~/samples/snippets/csharp/VS_Snippets_Winforms/WinFormsAutoScaling/CS/Form1.cs#4)]
     [!code-vb[WinFormsAutoScaling#4](~/samples/snippets/visualbasic/VS_Snippets_Winforms/WinFormsAutoScaling/VB/Form1.vb#4)]  
  
5. Наконец, Реализуйте обработчик для <xref:System.Windows.Forms.Form.FormClosing> событие, которое отсоединяет <xref:Microsoft.Win32.SystemEvents.UserPreferenceChanged> обработчик событий.  
  
     > [!IMPORTANT]
     > Если не добавить этот код вызовет утечка памяти.  
  
     [!code-csharp[WinFormsAutoScaling#5](~/samples/snippets/csharp/VS_Snippets_Winforms/WinFormsAutoScaling/CS/Form1.cs#5)]
     [!code-vb[WinFormsAutoScaling#5](~/samples/snippets/visualbasic/VS_Snippets_Winforms/WinFormsAutoScaling/VB/Form1.vb#5)]  
  
6. Скомпилируйте и запустите код.  
  
### <a name="to-manually-change-the-font-scheme-in-windows-xp"></a>Для ручного изменения схемы шрифтов в Windows XP  
  
1. Пока выполняется приложение Windows Forms, щелкните правой кнопкой мыши рабочий стол Windows и выберите **свойства** в контекстном меню.  
  
2. В **свойства отображения** диалоговом окне щелкните **внешний вид** вкладки.  
  
3. Из **размер шрифта** раскрывающемся списке выберите новый размер шрифта.  
  
     Вы заметите, что форма теперь реагирует на изменения схемы шрифтов рабочего стола во время выполнения. Когда пользователь изменяет между **обычный**, **крупного шрифта**, и **Огромный шрифт**, форма изменяет шрифт и корректно масштабируется.  
  
## <a name="example"></a>Пример  
 [!code-csharp[WinFormsAutoScaling#1](~/samples/snippets/csharp/VS_Snippets_Winforms/WinFormsAutoScaling/CS/Form1.cs#1)]
 [!code-vb[WinFormsAutoScaling#1](~/samples/snippets/visualbasic/VS_Snippets_Winforms/WinFormsAutoScaling/VB/Form1.vb#1)]  
  
 Конструктор в этом примере код содержит вызов `InitializeComponent`, который определяется при создании нового проекта Windows Forms в Visual Studio. Удалите эту строку кода, при создании приложения в командной строке.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.ContainerControl.PerformAutoScale%2A>
- [Автоматическое масштабирование в Windows Forms](automatic-scaling-in-windows-forms.md)
