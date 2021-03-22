---
title: Практическое руководство. Добавление сведений о строках в элемент управления DataGrid
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- DataTemplate [WPF], DataGrid
- row details [WPF], DataGrid
- DataGrid [WPF], row details
ms.assetid: 0bdc6f50-9b4c-483f-9df6-a47a1fde998b
ms.openlocfilehash: d5b6539f3d379088528b9654861267988b6fc69b
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59317899"
---
# <a name="how-to-add-row-details-to-a-datagrid-control"></a>Практическое руководство. Добавление сведений о строках в элемент управления DataGrid
При использовании <xref:System.Windows.Controls.DataGrid> элемента управления, можно настраивать представление данных, добавив раздел сведений о строке. Добавление раздела сведений о строке позволяет группировать некоторые данные в шаблон, который при необходимости видима или свернута. Например, можно добавить сведения о строке в <xref:System.Windows.Controls.DataGrid> , представляющие только сводку данных для каждой строки в <xref:System.Windows.Controls.DataGrid>, но предоставляет дополнительные поля данных, когда пользователь выбирает строку. Необходимо задать шаблон для раздела сведений о строке в <xref:System.Windows.Controls.DataGrid.RowDetailsTemplate%2A> свойство. Ниже показан пример раздела сведений о строке.  
  
 ![Сетка DataGrid, показанная со сведениями в строке](./media/ndp-rowdetails.png "NDP_RowDetails")  
  
 Определение шаблона сведений о строке, либо как встроенный XAML или как ресурс. В следующих процедурах показаны оба подхода. Шаблон данных, который добавляется в качестве ресурса можно использовать в проекте без повторного создания шаблона. Шаблон данных, в который добавляется встроенный XAML доступен только из элемента управления, где он определен.  
  
### <a name="to-display-row-details-by-using-inline-xaml"></a>Отображение сведений о строке с помощью встроенного XAML  
  
1. Создание <xref:System.Windows.Controls.DataGrid> , отображающий данные из источника данных.  
  
2. В элементе <xref:System.Windows.Controls.DataGrid> добавьте элемент <xref:System.Windows.Controls.DataGrid.RowDetailsTemplate%2A>.  
  
3. Создание <xref:System.Windows.DataTemplate> , определяющий внешний вид раздела сведений о строке.  
  
     В следующем XAML показан <xref:System.Windows.Controls.DataGrid> и как определить <xref:System.Windows.Controls.DataGrid.RowDetailsTemplate%2A> встроенный. <xref:System.Windows.Controls.DataGrid> Отображает три значения в каждой строке и три дополнительные значения при выборе строки.  
  
     [!code-xaml[DataGrid_RowDetails#1](~/samples/snippets/csharp/VS_Snippets_Wpf/datagrid_rowdetails/cs/mainwindow.xaml#1)]  
  
     В следующем коде показано запрос, который используется для выбора данных, который отображается в <xref:System.Windows.Controls.DataGrid>. В этом примере запрос выбирает данные из сущности, содержащей сведения о клиенте.  
  
     [!code-csharp[DataGrid_RowDetails#2](~/samples/snippets/csharp/VS_Snippets_Wpf/datagrid_rowdetails/cs/mainwindow.xaml.cs#2)]
       
  
### <a name="to-display-row-details-by-using-a-resource"></a>Отображение сведений о строке с помощью ресурса  
  
1. Создание <xref:System.Windows.Controls.DataGrid> , отображающий данные из источника данных.  
  
2. Добавить <xref:System.Windows.FrameworkElement.Resources%2A> элемент к корневому элементу, такие как <xref:System.Windows.Window> управления или <xref:System.Windows.Controls.Page> , или же добавьте <xref:System.Windows.Application.Resources%2A> элемент <xref:System.Windows.Application> класс в файле App.xaml (или файл Application.xaml).  
  
3. В элементе ресурсов создайте <xref:System.Windows.DataTemplate> , определяющий внешний вид раздела сведений о строке.  
  
     В следующем XAML показан <xref:System.Windows.Controls.DataGrid.RowDetailsTemplate%2A> определенные в <xref:System.Windows.Application> класса.  
  
     [!code-xaml[DataGrid_RowDetails#3](~/samples/snippets/csharp/VS_Snippets_Wpf/datagrid_rowdetails/cs/app.xaml#3)]  
  
4. На <xref:System.Windows.DataTemplate>, задайте [директивы x: Key](../../xaml-services/x-key-directive.md) значение, которое однозначно определяет шаблон данных.  
  
5. В <xref:System.Windows.Controls.DataGrid> элемент, наборе <xref:System.Windows.Controls.DataGrid.RowDetailsTemplate%2A> свойство ресурс, определенный в предыдущих шагах. Назначьте универсальный код ресурса, как статический ресурс.  
  
     В следующем XAML показан <xref:System.Windows.Controls.DataGrid.RowDetailsTemplate%2A> свойство присвоен ресурс из предыдущего примера.  
  
     [!code-xaml[DataGrid_RowDetails#4](~/samples/snippets/csharp/VS_Snippets_Wpf/datagrid_rowdetails/cs/window2.xaml#4)]  
  
### <a name="to-set-visibility-and-prevent-horizontal-scrolling-for-row-details"></a>Чтобы задать видимость и предотвратить горизонтальная прокрутка сведений о строке  
  
1. При необходимости задайте <xref:System.Windows.Controls.DataGrid.RowDetailsVisibilityMode%2A> свойства <xref:System.Windows.Controls.DataGridRowDetailsVisibilityMode> значение.  
  
     По умолчанию, присваивается значение <xref:System.Windows.Controls.DataGridRowDetailsVisibilityMode.VisibleWhenSelected>. Можно задать значение <xref:System.Windows.Controls.DataGridRowDetailsVisibilityMode.Visible> для отображения сведений для всех строк или <xref:System.Windows.Controls.DataGridRowDetailsVisibilityMode.Collapsed> Чтобы скрыть сведения для всех строк.  
  
2. При необходимости задайте <xref:System.Windows.Controls.DataGrid.AreRowDetailsFrozen%2A> свойства `true` во избежание строки раздел горизонтальная прокрутка сведений о.
