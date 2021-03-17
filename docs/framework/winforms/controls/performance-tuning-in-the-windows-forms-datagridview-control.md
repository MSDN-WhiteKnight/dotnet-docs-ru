---
title: Оптимизация производительности элемента управления DataGridView в Windows Forms
ms.date: 03/30/2017
helpviewer_keywords:
- DataGridView control [Windows Forms], performance tuning
- performance [Windows Forms], DataGridView control
- performance tuning [Windows Forms], data grids
ms.assetid: 6ccbff28-a0ff-41e4-b601-61b31b61851d
ms.openlocfilehash: 79f74db4ebd095156207a6218f59c0e9ae423085
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59076598"
---
# <a name="performance-tuning-in-the-windows-forms-datagridview-control"></a>Оптимизация производительности элемента управления DataGridView в Windows Forms
При работе с большими объемами данных, `DataGridView` управления можно будет использовать большой объем памяти, если использовать осторожно. На клиентах с ограниченным объемом памяти некоторые из этих затрат можно избежать за счет отключения функций, имеющих требовательных к памяти. Вы также можете управлять, некоторые или все данные обслуживания и извлечения задач вручную с помощью виртуального режима для настройки использования памяти для вашего сценария.  
  
## <a name="in-this-section"></a>В этом разделе  
 [Масштабирование элемента управления DataGridView в Windows Forms](best-practices-for-scaling-the-windows-forms-datagridview-control.md)  
 Описывает использование `DataGridView` управления способом, который позволяет избежать ненужных памяти использования и снижения производительности при работе с большими объемами данных.  
  
 [Виртуальный режим элемента управления DataGridView в Windows Forms](virtual-mode-in-the-windows-forms-datagridview-control.md)  
 В этой статье описывается использование виртуального режима для добавления или замены стандартный механизм привязки данных.  
  
 [Пошаговое руководство. Реализация виртуального режима для элемента управления DataGridView в Windows Forms](implementing-virtual-mode-wf-datagridview-control.md)  
 В этой статье описывается реализация обработчиков для нескольких событий в виртуальном режиме. Также показано, как реализовать отката на уровне строк и фиксации для изменения пользователем.  
  
 [Реализация виртуального режима с JIT-загрузкой данных для элемента управления DataGridView в Windows Forms](implementing-virtual-mode-jit-data-loading-in-the-datagrid.md)  
 В этой статье описывается загрузка данных по требованию, что полезно при наличии дополнительных данных для отображения, чем может уместиться в памяти доступных клиентских.  
  
## <a name="reference"></a>Ссылка  
 <xref:System.Windows.Forms.DataGridView>  
 Справочная документация по элементу управления <xref:System.Windows.Forms.DataGridView>.  
  
 <xref:System.Windows.Forms.DataGridView.VirtualMode%2A>  
 Содержит справочную документацию по <xref:System.Windows.Forms.DataGridView.VirtualMode%2A> свойство.  
  
## <a name="see-also"></a>См. также

- [Элемент управления DataGridView](datagridview-control-windows-forms.md)
- [Режимы отображения данных в элементе управления DataGridView в Windows Forms](data-display-modes-in-the-windows-forms-datagridview-control.md)
