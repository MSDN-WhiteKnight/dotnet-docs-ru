---
title: Практическое руководство. Привязка элемента управления DataGrid в Windows Forms к источнику данных
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- datasets [Windows Forms], binding to DataGrid control
- data binding [Windows Forms], DataGrid control
- DataGrid control [Windows Forms], data binding
- bound controls [Windows Forms], DataGrid control
- Windows Forms controls, data binding
- bound controls [Windows Forms]
- data-bound controls [Windows Forms], DataGrid
ms.assetid: 128cdb07-dfd3-4d60-9d6a-902847667c36
ms.openlocfilehash: 920a93894cc126f85bc6b618efbe6e9cedea4881
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59332577"
---
# <a name="how-to-bind-the-windows-forms-datagrid-control-to-a-data-source"></a>Практическое руководство. Привязка элемента управления DataGrid в Windows Forms к источнику данных
> [!NOTE]
>  Элемент управления <xref:System.Windows.Forms.DataGridView> заменяет элемент управления <xref:System.Windows.Forms.DataGrid> и расширяет его функциональные возможности; однако при необходимости элемент управления <xref:System.Windows.Forms.DataGrid> можно сохранить для обратной совместимости и использования в будущем. Дополнительные сведения см. в разделе [Различия элементов управления DataGridView и DataGrid в Windows Forms](differences-between-the-windows-forms-datagridview-and-datagrid-controls.md).  
  
 Windows Forms <xref:System.Windows.Forms.DataGrid> управления разработан специально для отображения сведений из источника данных. Привязка элемента управления во время выполнения путем вызова <xref:System.Windows.Forms.DataGrid.SetDataBinding%2A> метод. Несмотря на то, что можно отобразить данные из различных источников данных, наиболее обычные параметры являются наборы данных и представления данных.  
  
### <a name="to-data-bind-the-datagrid-control-programmatically"></a>Для привязки данных элемента управления DataGrid программным способом  
  
1. Напишите код для заполнения набора данных.  
  
     Если источником данных является набор данных или представление данных, на основе таблицы набора данных, добавьте код в форму для заполнения набора данных.  
  
     Использовании программы зависит от того, где данные поступают в набор. Если набор данных заполняется непосредственно из базы данных, обычно вызывается `Fill` метод адаптера данных, как показано в следующем примере, который заполняет набор данных с именем `DsCategories1`:  
  
    ```vb  
    sqlDataAdapter1.Fill(DsCategories1)  
    ```  
  
    ```csharp  
    sqlDataAdapter1.Fill(DsCategories1);  
    ```  
  
    ```cpp  
    sqlDataAdapter1->Fill(dsCategories1);  
    ```  
  
     Если набор данных заполняется из XML-веб-службы, вы обычно создается экземпляр службы в коде, а затем вызовите один из его методов для возврата набора данных. Затем объедините dataset из XML-веб-службы в локальный набор данных. В следующем примере показано, как можно создать экземпляр XML-веб-службы с именем `CategoriesService`, вызовите его `GetCategories` метод и слияния, результирующий набор данных в локальный набор данных называется `DsCategories1`:  
  
    ```vb  
    Dim ws As New MyProject.localhost.CategoriesService()  
    ws.Credentials = System.Net.CredentialCache.DefaultCredentials  
    DsCategories1.Merge(ws.GetCategories())  
    ```  
  
    ```csharp  
    MyProject.localhost.CategoriesService ws = new MyProject.localhost.CategoriesService();  
    ws.Credentials = System.Net.CredentialCache.DefaultCredentials;  
    DsCategories1.Merge(ws.GetCategories());  
    ```  
  
    ```cpp  
    MyProject::localhost::CategoriesService^ ws =   
       new MyProject::localhost::CategoriesService();  
    ws->Credentials = System::Net::CredentialCache::DefaultCredentials;  
    dsCategories1->Merge(ws->GetCategories());  
    ```  
  
2. Вызовите <xref:System.Windows.Forms.DataGrid> элемента управления <xref:System.Windows.Forms.DataGrid.SetDataBinding%2A> метод, передав ему в источнике данных и элемент данных. Если вам не нужно явным образом передать данные-член, передайте пустую строку.  
  
    > [!NOTE]
    >  При привязке сетки в первый раз, можно задать элемент управления <xref:System.Windows.Forms.DataGrid.DataSource%2A> и <xref:System.Windows.Forms.DataGrid.DataMember%2A> свойства. Тем не менее нельзя восстановить эти свойства, как только они были заданы. Таким образом, рекомендуется всегда использовать <xref:System.Windows.Forms.DataGrid.SetDataBinding%2A> метод.  
  
     В следующем примере показано, как программным способом можно привязать к таблице Customers в набор данных с именем `DsCustomers1`:  
  
    ```vb  
    DataGrid1.SetDataBinding(DsCustomers1, "Customers")  
    ```  
  
    ```csharp  
    DataGrid1.SetDataBinding(DsCustomers1, "Customers");  
    ```  
  
    ```cpp  
    dataGrid1->SetDataBinding(dsCustomers1, "Customers");  
    ```  
  
     Если в таблице Customers только таблицу в наборе данных, можно также привязать сетке таким образом:  
  
    ```vb  
    DataGrid1.SetDataBinding(DsCustomers1, "")  
    ```  
  
    ```csharp  
    DataGrid1.SetDataBinding(DsCustomers1, "");  
    ```  
  
    ```cpp  
    dataGrid1->SetDataBinding(dsCustomers1, "");  
    ```  
  
3. (Необязательно) Добавьте соответствующую таблицу стилей и столбцов в сетку. Если стили таблиц отсутствуют, вы увидите таблицу с минимальным форматированием и со всеми столбцами видимым.  
  
## <a name="see-also"></a>См. также

- [Общие сведения об элементе управления DataGrid](datagrid-control-overview-windows-forms.md)
- [Практическое руководство. Добавление таблиц и столбцов в элемент управления DataGrid в Windows Forms](how-to-add-tables-and-columns-to-the-windows-forms-datagrid-control.md)
- [Элемент управления DataGrid](datagrid-control-windows-forms.md)
- [Привязка данных Windows Forms](../windows-forms-data-binding.md)
