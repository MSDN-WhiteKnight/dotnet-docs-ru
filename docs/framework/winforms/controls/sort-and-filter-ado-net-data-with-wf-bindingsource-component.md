---
title: Практическое руководство. Сортировка и фильтрация данных ADO.NET с помощью компонента BindingSource в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- sorting data
- data sorting [Windows Forms], ADO.NET
- data [Windows Forms], filtering
- BindingSource component [Windows Forms], sorting and filtering data
- filtering [Windows Forms], ADO.NET
- data [Windows Forms], sorting
- ADO.NET [Windows Forms]
ms.assetid: 6c206daf-d706-4602-9dbe-435343052063
ms.openlocfilehash: 8904eff39b7278b2a185cc5e2f738ece1e8e88e4
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59306512"
---
# <a name="how-to-sort-and-filter-adonet-data-with-the-windows-forms-bindingsource-component"></a>Практическое руководство. Сортировка и фильтрация данных ADO.NET с помощью компонента BindingSource в Windows Forms
Можно предоставить возможность фильтрации и сортировки <xref:System.Windows.Forms.BindingSource> управлять через <xref:System.Windows.Forms.BindingSource.Sort%2A> и <xref:System.Windows.Forms.BindingSource.Filter%2A> свойства. Можно применить простую сортировку, когда в источнике данных <xref:System.ComponentModel.IBindingList>, и можно применить фильтрацию и если источником данных является <xref:System.ComponentModel.IBindingListView>. <xref:System.Windows.Forms.BindingSource.Sort%2A> Свойства требуется стандартный [!INCLUDE[vstecado](../../../../includes/vstecado-md.md)] синтаксис: строка, представляющая имя столбца данных в источнике данных, за которым следует `ASC` или `DESC` для указания ли списка должны быть отсортированы в порядке возрастания или убывания. Можно задать дополнительные возможности сортировки или несколько столбцов сортировки, каждый столбец отделяется разделителем запятой. <xref:System.Windows.Forms.BindingSource.Filter%2A> Свойство принимает строковое выражение.  
  
> [!NOTE]
>  Хранение конфиденциальных сведений (например, пароля) в строке подключения может повлиять на безопасность приложения. Использование проверки подлинности Windows (также называемой встроенными средствами безопасности) — более безопасный способ управления доступом к базе данных. Дополнительные сведения см. в разделе [Защита сведений о подключении](../../data/adonet/protecting-connection-information.md).  
  
### <a name="to-filter-data-with-the-bindingsource"></a>Для фильтрации данных с использованием компонента BindingSource  
  
-   Задать <xref:System.Windows.Forms.BindingSource.Filter%2A> свойства необходимое выражение.  
  
     В следующем примере выражение является именем столбца, за которым следует значение для столбца.  
  
 [!code-csharp[System.Windows.Forms.DataConnectorFilterAndSort#11](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataConnectorFilterAndSort/CS/form1.cs#11)]
   
  
### <a name="to-sort-data-with-the-bindingsource"></a>Для сортировки данных с использованием компонента BindingSource  
  
1. Задайте <xref:System.Windows.Forms.BindingSource.Sort%2A> свойства к имени столбца, который будет следуют `ASC` или `DESC` для указания по возрастанию или убыванию.  
  
2. Несколько столбцов разделяются запятыми.  
  
 [!code-csharp[System.Windows.Forms.DataConnectorFilterAndSort#12](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataConnectorFilterAndSort/CS/form1.cs#12)]
   
  
## <a name="example"></a>Пример  
 В следующем примере кода загружает данные из образца базы данных "Борей" в таблице Customers <xref:System.Windows.Forms.DataGridView> и фильтрует и сортирует отображаемых данных.  
  
 [!code-csharp[System.Windows.Forms.DataConnectorFilterAndSort#1](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataConnectorFilterAndSort/CS/form1.cs#1)]
   
  
## <a name="compiling-the-code"></a>Компиляция кода  
 Чтобы выполнить этот пример, вставьте код в форму, содержащую <xref:System.Windows.Forms.BindingSource> с именем `BindingSource1` и <xref:System.Windows.Forms.DataGridView> с именем `dataGridView1`. Обрабатывать <xref:System.Windows.Forms.Form.Load> событие для форму и вызовите `InitializeSortedFilteredBindingSource` в методе обработчика событий загрузки.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.BindingSource.Sort%2A>
- <xref:System.Windows.Forms.BindingSource.Filter%2A>
- [Практическое руководство. Установка образцов баз данных](https://docs.microsoft.com/previous-versions/visualstudio/visual-studio-2013/8b6y4c7s(v=vs.120))
- [Компонент BindingSource](bindingsource-component.md)
