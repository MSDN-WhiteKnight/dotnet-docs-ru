---
title: Практическое руководство. Создание формы «основной-подробности» с помощью двух элементов управления DataGridView Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- DataGridView control [Windows Forms], master/detail form
- parent-child tables [Windows Forms], displaying on Windows Forms
- master-details lists [Windows Forms], creating
ms.assetid: 99f6e876-3f7f-4139-9063-e36587c95b02
ms.openlocfilehash: ccd9354d623cf1b452bc3890b7fd9a5248cb69c8
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59088799"
---
# <a name="how-to-create-a-masterdetail-form-using-two-windows-forms-datagridview-controls"></a>Практическое руководство. Создание главного и подчиненного представлений данных с использованием двух элементов управления DataGridView в Windows Forms
В приведенном ниже примере кода создаются главная и подчиненная формы с использованием двух элементов управления <xref:System.Windows.Forms.DataGridView>, привязанных к двум компонентам <xref:System.Windows.Forms.BindingSource>. Источником данных является объект <xref:System.Data.DataSet>, содержащий таблицы `Customers` и `Orders` из образца базы данных SQL Server Northwind и объект <xref:System.Data.DataRelation>, связывающий таблицы через столбец `CustomerID`.  
  
 Один источник <xref:System.Windows.Forms.BindingSource> привязан к родительской таблице `Customers` в наборе данных. Эти данные отображаются в главном элементе управления <xref:System.Windows.Forms.DataGridView>. Другой источник <xref:System.Windows.Forms.BindingSource> привязан к первому соединителю данных. Свойству <xref:System.Windows.Forms.BindingSource.DataMember%2A> второго источника <xref:System.Windows.Forms.BindingSource> присвоено имя <xref:System.Data.DataRelation>. Это заставляет связанный подчиненный элемент управления <xref:System.Windows.Forms.DataGridView> отображать строки дочерней таблицы `Orders`, соответствующие текущей строке главного элемента управления <xref:System.Windows.Forms.DataGridView>.  
  
 Полное описание этого примера кода, см. в разделе [Пошаговое руководство: Создание формы «основной/подробности» с помощью двух Windows Forms элементов управления DataGridView](creating-a-master-detail-form-using-two-datagridviews.md).  
  
## <a name="example"></a>Пример  
 [!code-csharp[System.Windows.Forms.DataGridViewMasterDetails#00](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataGridViewMasterDetails/CS/masterdetails.cs#00)]
 [!code-vb[System.Windows.Forms.DataGridViewMasterDetails#00](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Windows.Forms.DataGridViewMasterDetails/VB/masterdetails.vb#00)]  
  
## <a name="compiling-the-code"></a>Компиляция кода  
 Для этого примера требуются:  
  
 ссылки на сборки System, System.Data, System.Windows.Forms и System.XML.  
  
-   Сведения о выполнении сборки этого примера из командной строки для Visual Basic или Visual C#, см. в разделе [построение из командной строки](../../../visual-basic/reference/command-line-compiler/building-from-the-command-line.md) или [командной строки создания с помощью csc.exe](../../../csharp/language-reference/compiler-options/command-line-building-with-csc-exe.md). Можно также сборке этого примера в Visual Studio путем вставки кода в новый проект.  
  
## <a name="net-framework-security"></a>Безопасность платформы .NET Framework  
 Хранение конфиденциальных сведений (например, пароля) в строке подключения может повлиять на безопасность приложения. Использование проверки подлинности Windows (также называемой встроенными средствами безопасности) — более безопасный способ управления доступом к базе данных. Дополнительные сведения см. в разделе [Защита сведений о подключении](../../data/adonet/protecting-connection-information.md).  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.DataGridView>
- <xref:System.Windows.Forms.BindingSource>
- [Пошаговое руководство. Создание главного и подчиненного представлений данных с использованием двух элементов управления DataGridView в Windows Forms](creating-a-master-detail-form-using-two-datagridviews.md)
- [Отображение данных с помощью элемента управления DataGridView в Windows Forms](displaying-data-in-the-windows-forms-datagridview-control.md)
- [Защита сведений о подключении](../../data/adonet/protecting-connection-information.md)
