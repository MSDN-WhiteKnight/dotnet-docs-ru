---
title: Практическое руководство. Создание связанного элемента управления и форматирование отображаемых данных
ms.date: 03/30/2017
helpviewer_keywords:
- data [Windows Forms], formatting
- bound controls [Windows Forms], creating
- bound controls [Windows Forms], formatting data
ms.assetid: d5a56228-899d-41d9-8af8-87b3f4ec2f94
ms.openlocfilehash: f7f1ed2fbca4ab8892cb6c439ae8841fa8828bf0
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59302547"
---
# <a name="how-to-create-a-bound-control-and-format-the-displayed-data"></a>Практическое руководство. Создание связанного элемента управления и форматирование отображаемых данных
С помощью привязки данных Windows Forms можно форматировать данные, отображаемые в элементе управления с привязкой к данным с помощью **форматирование и дополнительная привязка** диалоговое окно.  
  
> [!NOTE]
>  Отображаемые диалоговые окна и команды меню могут отличаться от описанных в справке в зависимости от текущих параметров или выпуска. Чтобы изменить параметры, выберите в меню **Сервис** пункт **Импорт и экспорт параметров** . Дополнительные сведения см. в разделе [Персонализация интегрированной среды разработки Visual Studio](/visualstudio/ide/personalizing-the-visual-studio-ide).  
  
### <a name="to-bind-a-control-and-format-the-displayed-data"></a>Привязка элемента управления и форматирование отображаемых данных  
  
1. Подключение к источнику данных.  
  
     Дополнительные сведения см. в разделе [подключение к источнику данных](../data/adonet/connecting-to-a-data-source.md).  
  
2. Выберите элемент управления в форме и откройте окно "Свойства".  
  
3. Разверните **(DataBindings)** свойства, а затем в **(Дополнительно)** нажмите кнопку с многоточием (![экрана VisualStudioEllipsesButton](./media/vbellipsesbutton.png " vbEllipsesButton")) для отображения **форматирование и дополнительная привязка** диалоговое окно, имеющая полный список свойств этого элемента управления.  
  
4. Выберите свойство, чтобы привязать и нажмите кнопку **привязки** стрелку.  
  
     Отобразится список доступных источников данных.  
  
5. Разверните источник данных, к которому требуется привязаться, пока не найдете нужный одиночный элемент данных.  
  
     Например, при привязке к значению столбца в таблице набора данных разверните имя набора данных, а затем разверните имя таблицы для отображения имен столбцов.  
  
6. Щелкните имя элемента для привязки.  
  
7. В **формат типа** выберите формат, который следует применить к данным, отображаемым в элементе управления.  
  
     В каждом случае можно указать значение, отображаемое в элементе управления, если источник данных содержит <xref:System.DBNull>. В противном случае параметры будут немного отличаться в зависимости от выбранного типа формата. В таблице ниже приведены типы форматов и параметры.  
  
    |Тип формата|Параметр форматирования|  
    |-----------------|-----------------------|  
    |Без форматирования|Параметры отсутствуют.|  
    |Numeric|Укажите число десятичных разрядов, с помощью **десятичных разрядов** управления "вверх вниз".|  
    |Валюта|Укажите число десятичных разрядов, с помощью **десятичных разрядов** управления "вверх вниз".|  
    |Дата/время|Выберите способ отображения даты и времени, выбрав один из элементов в **тип** рамка выделения.|  
    |Экспоненциальный|Укажите число десятичных разрядов, с помощью **десятичных разрядов** управления "вверх вниз".|  
    |Другой|Укажите используемую строку пользовательского формата.<br /><br /> Дополнительные сведения см. в статье [Типы форматирования в .NET](../../standard/base-types/formatting-types.md). **Примечание.**  Строки пользовательского формата не гарантируют успешного цикла обработки между источником данных и связанным элементом управления. Вместо них в коде обработки событий для привязки и применения пользовательских форматов обрабатывайте событие <xref:System.Windows.Forms.Binding.Parse> или <xref:System.Windows.Forms.Binding.Format>.|  
  
8. Нажмите кнопку **ОК** закрыть **форматирование и дополнительная привязка** диалоговое окно и вернуться в окне «Свойства».  
  
## <a name="see-also"></a>См. также

- [Практическое руководство. Создание элемента управления с простой привязкой в форме Windows Forms](how-to-create-a-simple-bound-control-on-a-windows-form.md)
- [Проверка введенных пользователем данных в Windows Forms](user-input-validation-in-windows-forms.md)
- [Привязка данных Windows Forms](windows-forms-data-binding.md)
