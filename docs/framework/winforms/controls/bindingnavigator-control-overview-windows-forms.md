---
title: Общие сведения об элементе управления BindingNavigator (Windows Forms)
ms.date: 03/30/2017
f1_keywords:
- DataNavigator
helpviewer_keywords:
- BindingNavigator control [Windows Forms], about BindingNavigator control
- records [Windows Forms], navigating on a form
- data [Windows Forms], navigating
- data navigation
ms.assetid: 4423eede-f8d1-4d02-822f-5bf8432680d0
ms.openlocfilehash: ad63f622aae55cb4175eddc93ab5e086965a8fe8
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59109113"
---
# <a name="bindingnavigator-control-overview-windows-forms"></a>Общие сведения об элементе управления BindingNavigator (Windows Forms)
Элемент управления <xref:System.Windows.Forms.BindingNavigator> можно использовать для создания стандартных средств поиска и изменения данных в форме Windows Forms. Элемент управления <xref:System.Windows.Forms.BindingNavigator> часто используется с компонентом <xref:System.Windows.Forms.BindingSource>, позволяя пользователям переходить по записям данных в форме и взаимодействовать с ними.  
  
## <a name="how-the-bindingnavigator-works"></a>Как работает элемент управления BindingNavigator  

 Элемент управления <xref:System.Windows.Forms.BindingNavigator> состоит из элемента <xref:System.Windows.Forms.ToolStrip> с набором объектов <xref:System.Windows.Forms.ToolStripItem> для большинства обычных действий с данными: их добавления, удаления и перемещения по ним. По умолчанию элемент управления <xref:System.Windows.Forms.BindingNavigator> содержит эти стандартные кнопки. На следующем снимке экрана показан <xref:System.Windows.Forms.BindingNavigator> элемента управления в форме:
  
 ![Снимок экрана, показывающий элемент управления BindingNavigator.](./media/bindingnavigator-control-overview-windows-forms/bindingnavigator-control-form.gif)  
  
 В таблице ниже перечислены элементы управления и их функции.  
  
|Элемент управления|Функция|  
|-------------|--------------|  
|<xref:System.Windows.Forms.BindingNavigator.AddNewItem%2A> button|Вставляет новую строку в базовый источник данных.|  
|<xref:System.Windows.Forms.BindingNavigator.DeleteItem%2A> button|Удаляет текущую строку из базового источника данных.|  
|<xref:System.Windows.Forms.BindingNavigator.MoveFirstItem%2A> button|Переход к первому элементу базового источника данных.|  
|<xref:System.Windows.Forms.BindingNavigator.MoveLastItem%2A> button|Переход к последнему элементу базового источника данных.|  
|<xref:System.Windows.Forms.BindingNavigator.MoveNextItem%2A> button|Переход к следующему элементу базового источника данных.|  
|<xref:System.Windows.Forms.BindingNavigator.MovePreviousItem%2A> button|Переход к предыдущему элементу базового источника данных.|  
|<xref:System.Windows.Forms.BindingNavigator.PositionItem%2A> Текстовое поле|Возвращает текущую позицию в базовом источнике данных.|  
|<xref:System.Windows.Forms.BindingNavigator.CountItem%2A> Текстовое поле|Возвращает общее число элементов в базовом источнике данных.|  
  
 Каждому элементу управления этой коллекции соответствует член компонента <xref:System.Windows.Forms.BindingSource>, обеспечивающий ту же функциональность программным путем. Например, кнопка <xref:System.Windows.Forms.BindingNavigator.MoveFirstItem%2A> соответствует методу <xref:System.Windows.Forms.BindingSource.MoveFirst%2A> компонента <xref:System.Windows.Forms.BindingSource>, кнопка <xref:System.Windows.Forms.BindingNavigator.DeleteItem%2A> соответствует методу <xref:System.Windows.Forms.BindingSource.RemoveCurrent%2A> и т. д.  
  
 Если кнопки по умолчанию не удовлетворяют требованиям приложения или необходимо использовать дополнительные кнопки с иной функциональностью, можно создать собственные кнопки <xref:System.Windows.Forms.ToolStrip>. Также см. раздел [Как Добавление загрузки, сохранения и кнопки "Отмена" для Windows Forms элемента управления BindingNavigator](load-save-and-cancel-bindingnavigator.md).  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.BindingNavigator>
- <xref:System.Windows.Forms.BindingSource>
- [BindingNavigator — элемент управления](bindingnavigator-control-windows-forms.md)
