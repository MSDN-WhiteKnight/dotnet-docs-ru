---
title: Практическое руководство. Привязка элемента управления DataGrid в Windows Forms к источнику данных с помощью конструктора
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- datasets [Windows Forms], binding to DataGrid control
- data binding [Windows Forms], DataGrid control
- DataGrid control [Windows Forms], data binding
- Windows Forms controls, data binding
- bound controls [Windows Forms]
ms.assetid: 4e96e3d0-b1cc-4de1-8774-bc9970ec4554
ms.openlocfilehash: fe54c650e1d19f36d681053c7da47e12527c5827
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59320890"
---
# <a name="how-to-bind-the-windows-forms-datagrid-control-to-a-data-source-using-the-designer"></a>Практическое руководство. Привязка элемента управления DataGrid в Windows Forms к источнику данных с помощью конструктора

> [!NOTE]
>  Элемент управления <xref:System.Windows.Forms.DataGridView> заменяет элемент управления <xref:System.Windows.Forms.DataGrid> и расширяет его функциональные возможности; однако при необходимости элемент управления <xref:System.Windows.Forms.DataGrid> можно сохранить для обратной совместимости и использования в будущем. Дополнительные сведения см. в разделе [Различия элементов управления DataGridView и DataGrid в Windows Forms](differences-between-the-windows-forms-datagridview-and-datagrid-controls.md).  
  
 Windows Forms <xref:System.Windows.Forms.DataGrid> управления разработан специально для отображения сведений из источника данных. Привязка элемента управления во время разработки, установив <xref:System.Windows.Forms.DataGrid.DataSource%2A> и <xref:System.Windows.Forms.DataGrid.DataMember%2A> свойства, или во время выполнения путем вызова <xref:System.Windows.Forms.DataGrid.SetDataBinding%2A> метод. Несмотря на то, что можно отобразить данные из различных источников данных, наиболее обычные параметры являются наборы данных и представления данных.  
  
 Если источник данных доступен во время разработки, например, если форма содержит экземпляр набора данных или представлении данных — сетки можно привязать к источнику данных во время разработки. Затем можно просмотреть, как будет выглядеть данные в сетке.  
  
 Можно также программно, привязка сетки во время выполнения. Это полезно в том случае, если вы хотите указать источник данных, на основе сведений, получаемых во время выполнения. Например приложение может позволить пользователю указать имя таблицы для просмотра. Это также в некоторых ситуациях, где источник данных не существует во время разработки. Сюда входят источников данных, таких как массивы, коллекции, нетипизированные наборы данных и модули чтения данных.  
  
 Следующая процедура требуется **приложения Windows** проекта с формой, содержащей <xref:System.Windows.Forms.DataGrid> элемента управления. Сведения о настройке такого проекта см. в разделе [как: Создайте проект приложения Windows Forms](/visualstudio/ide/step-1-create-a-windows-forms-application-project) и [как: Добавление элементов управления в Windows Forms](how-to-add-controls-to-windows-forms.md). В Visual Studio 2005 <xref:System.Windows.Forms.DataGrid> элемент управления отсутствует в **элементов** по умолчанию. Сведения о его добавлении см. в разделе [как: Добавление элементов на панель инструментов](https://docs.microsoft.com/previous-versions/visualstudio/visual-studio-2010/ms165355(v=vs.100)). Кроме того в Visual Studio 2005, вы можете использовать **источников данных** окно для привязки данных во время разработки. Дополнительные сведения см. в разделе [привязка элементов управления к данным в Visual Studio](/visualstudio/data-tools/bind-controls-to-data-in-visual-studio).  
  
> [!NOTE]
>  Отображаемые диалоговые окна и команды меню могут отличаться от описанных в справке в зависимости от текущих параметров или выпуска. Чтобы изменить параметры, выберите в меню **Сервис** пункт **Импорт и экспорт параметров** . Дополнительные сведения см. в разделе [Персонализация интегрированной среды разработки Visual Studio](/visualstudio/ide/personalizing-the-visual-studio-ide).  
  
### <a name="to-data-bind-the-datagrid-control-to-a-single-table-in-the-designer"></a>Чтобы выполнить привязку данных элемента управления DataGrid к одной таблице в конструкторе  
  
1. Задайте в качестве <xref:System.Windows.Forms.DataGrid.DataSource%2A> объект, содержащие элементы данных, необходимо выполнить привязку к свойству.  
  
2. Если источник данных представляет собой набор данных, задайте <xref:System.Windows.Forms.DataGrid.DataMember%2A> имя таблицы для привязки.  
  
3. Если источником данных является набор данных или представление данных, на основе таблицы набора данных, добавьте код в форму для заполнения набора данных.  
  
     Использовании программы зависит от того, где данные поступают в набор. Если набор данных заполняется непосредственно из базы данных, обычно вызывается `Fill` метод адаптера данных, как показано в следующем примере кода, который заполняет набор данных с именем `DsCategories1`:  
  
    ```vb  
    sqlDataAdapter1.Fill(DsCategories1)  
    ```  
  
    ```csharp  
    sqlDataAdapter1.Fill(DsCategories1);  
    ```  
  
    ```cpp  
    sqlDataAdapter1->Fill(dsCategories1);  
    ```  
  
4. (Необязательно) Добавьте соответствующую таблицу стилей и столбцов в сетку.  
  
     Если стили таблиц отсутствуют, вы увидите таблицу с минимальным форматированием и со всеми столбцами видимым.  
  
### <a name="to-data-bind-the-datagrid-control-to-multiple-tables-in-a-dataset-in-the-designer"></a>Чтобы выполнить привязку данных элемента управления DataGrid с несколькими таблицами в наборе данных в конструкторе  
  
1. Задайте в качестве <xref:System.Windows.Forms.DataGrid.DataSource%2A> объект, содержащие элементы данных, необходимо выполнить привязку к свойству.  
  
2. Если набор данных содержит связанные таблицы (то есть, если он содержит объект связи), задайте <xref:System.Windows.Forms.DataGrid.DataMember%2A> имя родительской таблицы.  
  
3. Напишите код для заполнения набора данных.  
  
## <a name="see-also"></a>См. также

- [Общие сведения об элементе управления DataGrid](datagrid-control-overview-windows-forms.md)
- [Практическое руководство. Добавление таблиц и столбцов в элемент управления DataGrid в Windows Forms](how-to-add-tables-and-columns-to-the-windows-forms-datagrid-control.md)
- [Элемент управления DataGrid](datagrid-control-windows-forms.md)
- [Привязка данных Windows Forms](../windows-forms-data-binding.md)
- [Доступ к данным в Visual Studio](/visualstudio/data-tools/accessing-data-in-visual-studio)
