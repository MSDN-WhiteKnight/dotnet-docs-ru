---
title: Практическое руководство. Добавление столбцов в элемент управления ListView в формах Windows Forms с помощью конструктора
ms.date: 03/30/2017
helpviewer_keywords:
- ListView control [Windows Forms], adding column headers
- columns [Windows Forms], adding to ListView controls
ms.assetid: 5b1a8b4d-587e-479a-95c1-f9b90884f13a
ms.openlocfilehash: 48fd223c8e770e64513d79ef9d24f93321c98332
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59322099"
---
# <a name="how-to-add-columns-to-the-windows-forms-listview-control-using-the-designer"></a>Практическое руководство. Добавление столбцов в элемент управления ListView в формах Windows Forms с помощью конструктора
Windows Forms <xref:System.Windows.Forms.ListView> элемент управления может отображать несколько столбцов для каждого списка элемента, когда в **сведения** представления. Можно использовать столбцы для отображения нескольких типов данных о каждом элементе списка. Например в списке файлов можно отображать имя файла, тип файла, размер и Дата последнего изменения файла. Сведения о заполнении столбцов после их создания см. в разделе [как: Отображение дополнительных данных в столбцах с помощью Windows Forms элемента управления ListView](how-to-display-subitems-in-columns-with-the-windows-forms-listview-control.md).  
  
 Следующая процедура требуется **приложения Windows** проекта с формой, содержащей <xref:System.Windows.Forms.ListView> элемента управления. Сведения о настройке такого проекта см. в разделе [как: Создайте проект приложения Windows Forms](/visualstudio/ide/step-1-create-a-windows-forms-application-project) и [как: Добавление элементов управления в Windows Forms](how-to-add-controls-to-windows-forms.md).  
  
> [!NOTE]
>  Отображаемые диалоговые окна и команды меню могут отличаться от описанных в справке в зависимости от текущих параметров или выпуска. Чтобы изменить параметры, выберите в меню **Сервис** пункт **Импорт и экспорт параметров** . Дополнительные сведения см. в разделе [Персонализация интегрированной среды разработки Visual Studio](/visualstudio/ide/personalizing-the-visual-studio-ide).  
  
### <a name="to-add-columns-in-the-designer"></a>Чтобы добавить столбцы в конструкторе  
  
1. В **свойства** окна, задайте в качестве <xref:System.Windows.Forms.ListView.View%2A> свойства <xref:System.Windows.Forms.View.Details>.  
  
2. В **свойства** окно, нажмите кнопку **кнопку с многоточием** кнопки (![экрана VisualStudioEllipsesButton](../media/vbellipsesbutton.png "vbEllipsesButton")) рядом с полем <xref:System.Windows.Forms.ListView.Columns%2A> свойство.  
  
     **ColumnHeader-редактор коллекций** отображается.  
  
3. Используйте **добавить** кнопку, чтобы добавить новые столбцы. Затем можно выбрать заголовок столбца и задать его текст (заголовок столбца), выравнивание текста и ширины.  
  
## <a name="see-also"></a>См. также

- [Общие сведения об элементе управления ListView](listview-control-overview-windows-forms.md)
- [Практическое руководство. Добавление и удаление элементов с помощью элемента управления ListView в Windows Forms](how-to-add-and-remove-items-with-the-windows-forms-listview-control.md)
- [Практическое руководство. Отображение дополнительных данных в столбцах элемента управления ListView в Windows Forms](how-to-display-subitems-in-columns-with-the-windows-forms-listview-control.md)
- [Практическое руководство. Отображение значков в элементе управления ListView в Windows Forms](how-to-display-icons-for-the-windows-forms-listview-control.md)
- [Практическое руководство. Добавление пользовательских данных в элемент управления TreeView или ListView (Windows Forms)](add-custom-information-to-a-treeview-or-listview-control-wf.md)
