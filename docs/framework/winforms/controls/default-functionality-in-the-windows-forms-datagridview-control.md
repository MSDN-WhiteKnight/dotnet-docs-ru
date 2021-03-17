---
title: Стандартная функциональность элемента управления DataGridView в Windows Forms
ms.date: 03/30/2017
helpviewer_keywords:
- data grids [Windows Forms], default functionality in DataGridView control
- DataGridView control [Windows Forms], default functionality
ms.assetid: 4405f697-cad1-4839-9bcd-8ddb09d9f00e
ms.openlocfilehash: 26633b0abaa8c1c2916153b2236ecf9e4982fd68
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59208869"
---
# <a name="default-functionality-in-the-windows-forms-datagridview-control"></a>Стандартная функциональность элемента управления DataGridView в Windows Forms
Windows Forms <xref:System.Windows.Forms.DataGridView> управления предоставляет пользователям широкую функциональность по умолчанию.  
  
## <a name="default-functionality"></a>Стандартная функциональность  
 По умолчанию <xref:System.Windows.Forms.DataGridView> управления:  
  
-   Автоматически отображает заголовки столбцов и заголовки строк, которые остаются видимыми при прокрутке таблицы по вертикали.  
  
-   Содержит заголовок строки, который содержит индикатор выделения для текущей строки.  
  
-   Имеет рамку выделения в первой ячейке.  
  
-   Содержит столбцы, которые могут изменяться автоматически при двойном щелчке разделителей столбцов.  
  
-   Автоматически поддерживает стили оформления Windows XP и семействе Windows Server 2003 при <xref:System.Windows.Forms.Application.EnableVisualStyles%2A> метод вызывается из приложения `Main` метод.  
  
 Кроме того, содержимое <xref:System.Windows.Forms.DataGridView> элемента управления можно изменить по умолчанию:  
  
-   Если пользователь дважды щелкает или нажимает клавишу F2 в ячейке, элемент управления автоматически переходит в режим редактирования и обновляет содержимое ячейки, когда пользователь вводит текст.  
  
-   Если пользователь выполняет прокрутку в конец сетки, пользователь будет видеть, что присутствует строка для добавления новых записей. Когда пользователь щелкает эту строку, добавляется новая строка <xref:System.Windows.Forms.DataGridView> управления со значениями по умолчанию. При нажатии клавиши ESC, новая строка удаляется.  
  
-   Если пользователь щелкает заголовок строки, выбирается целой строки.  
  
 При привязке <xref:System.Windows.Forms.DataGridView> элемента управления к источнику данных, задав его <xref:System.Windows.Forms.DataGridView.DataSource%2A> свойства:  
  
-   Автоматически использует имена столбцов источника данных в качестве текста заголовка столбца.  
  
-   Заполняется содержимым источника данных. <xref:System.Windows.Forms.DataGridView> столбцы создаются автоматически для каждого столбца в источнике данных.  
  
-   Создает строку для каждой видимой строки в таблице.  
  
-   Автоматически сортирует строки, на основе базовых данных, когда пользователь щелкает заголовок столбца.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.DataGridView>
- [Элемент управления DataGridView](datagridview-control-windows-forms.md)
