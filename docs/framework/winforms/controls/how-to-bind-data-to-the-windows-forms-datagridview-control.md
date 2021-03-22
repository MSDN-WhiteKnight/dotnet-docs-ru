---
title: Практическое руководство. Привязка данных к элементу управления Windows Forms DataGridView
ms.date: 02/08/2019
dev_langs:
- csharp
- vb
helpviewer_keywords:
- data binding [Windows Forms], grids
- data binding [Windows Forms], DataGridView control
- DataGridView control [Windows Forms], data binding
ms.assetid: 1660f69c-5711-45d2-abc1-e25bc6779124
author: rpetrusha
ms.author: ronpet
ms.openlocfilehash: e147109a64687177f201ad1e312fab56ea61d604
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59160074"
---
# <a name="how-to-bind-data-to-the-windows-forms-datagridview-control"></a>Практическое руководство. Привязка данных к элементу управления Windows Forms DataGridView

<xref:System.Windows.Forms.DataGridView> Элемент управления поддерживает стандартную Windows Forms модель привязки данных, поэтому его можно привязать к различным источникам данных. Как правило, можно выполнить привязку к <xref:System.Windows.Forms.BindingSource> , управляет взаимодействием с источником данных. <xref:System.Windows.Forms.BindingSource> Может быть любой источник данных Windows Forms, который обеспечивает большую гибкость при выборе или изменении расположения ваших данных. Дополнительные сведения об источниках данных <xref:System.Windows.Forms.DataGridView> управления поддерживает, см. в разделе [Обзор элемента управления DataGridView](datagridview-control-overview-windows-forms.md).  

Visual Studio имеет расширенную поддержку привязки данных к элементу управления DataGridView. Дополнительные сведения см. в разделе [Как Привязка данных к элементу управления Windows Forms DataGridView, с помощью конструктора](bind-data-to-the-datagrid-using-the-designer.md).  

Для подключения элемента управления DataGridView к данным:

1. Реализуйте метод для обработки сведения о получении данных. В следующем коде реализуется пример `GetData` метод, который инициализирует <xref:System.Data.SqlClient.SqlDataAdapter>и использует его для заполнения <xref:System.Data.DataTable>. Затем он выполняет привязку <xref:System.Data.DataTable> для <xref:System.Windows.Forms.BindingSource>. 

2. В форме <xref:System.Windows.Forms.Form.Load> обработчик событий, привязка <xref:System.Windows.Forms.DataGridView> управления <xref:System.Windows.Forms.BindingSource>и вызовите `GetData` метод для извлечения данных.  

## <a name="example"></a>Пример

Это полный пример кода извлекает данные из базы данных для заполнения элемента управления DataGridView в форме Windows. В форме также находятся кнопки, чтобы перезагрузить данные и отправить изменения в базу данных.  

Для этого примера требуются: 

- Доступ на образец базы данных "Борей" SQL Server. Дополнительные сведения об установке образца базы данных "Борей" см. в разделе [получить образцы баз данных, примеры кода ADO.NET](../../data/adonet/sql/linq/downloading-sample-databases.md). 

- Ссылки на сборки System, System.Windows.Forms, System.Data и System.Xml.  

Чтобы построить и запустить этот пример, вставьте код в *Form1* файл кода в новый проект Windows Forms. Сведения о сборке из C# или командной строки Visual Basic, см. в разделе [сборка с помощью csc.exe из командной строки](../../../csharp/language-reference/compiler-options/command-line-building-with-csc-exe.md) или [построения из командной строки](../../../visual-basic/reference/command-line-compiler/building-from-the-command-line.md).  
  
Заполнение `connectionString` переменных в примере со значениями пример подключения к базе данных "Борей" SQL Server. Проверка подлинности Windows, также называемый встроенная безопасность является более безопасный способ подключения к базе данных, чем хранение пароля в строке подключения. Дополнительные сведения о безопасности подключения, см. в разделе [Защита сведений о подключении](../../data/adonet/protecting-connection-information.md).  

[!code-csharp[System.Windows.Forms.DataGridViewBoundEditable](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataGridViewBoundEditable/CS/datagridviewboundeditable.cs)]
  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.DataGridView>
- <xref:System.Windows.Forms.DataGridView.DataSource%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.BindingSource>
- [Отображение данных в элементе управления Windows Forms DataGridView](displaying-data-in-the-windows-forms-datagridview-control.md)
- [Защита сведений о подключении](../../data/adonet/protecting-connection-information.md)
