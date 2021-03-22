---
title: Практическое руководство. Навигация по набору данных, отображаемых в форме Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- cursors [Windows Forms], data sources
- data sources [Windows Forms], Windows Forms
- Windows Forms, navigating
- CurrencyManager class [Windows Forms], navigating Windows Forms data
- data [Windows Forms], navigating
ms.assetid: 97360f7b-b181-4084-966a-4c62518f735b
ms.openlocfilehash: 2ba33f9ecb3a12a62c41af17d3f9ad6f6e3f8a5d
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59345005"
---
# <a name="how-to-navigate-data-in-windows-forms"></a>Практическое руководство. Навигация по набору данных, отображаемых в форме Windows Forms
Самый простой способ перемещения по записям в источнике данных в приложении Windows, является привязка <xref:System.Windows.Forms.BindingSource> компонент источника данных, а затем привязать элементы управления к <xref:System.Windows.Forms.BindingSource>. Затем можно использовать встроенные методы навигации на <xref:System.Windows.Forms.BindingSource> таких <xref:System.Windows.Forms.BindingSource.MoveNext%2A>, <xref:System.Windows.Forms.BindingSource.MoveLast%2A>, <xref:System.Windows.Forms.BindingSource.MovePrevious%2A> и <xref:System.Windows.Forms.BindingSource.MoveFirst%2A>. С помощью этих методов настроит <xref:System.Windows.Forms.BindingSource.Position%2A> и <xref:System.Windows.Forms.BindingSource.Current%2A> свойства <xref:System.Windows.Forms.BindingSource> соответствующим образом. Можно также найти элемент и задать его в качестве текущего элемента, задав <xref:System.Windows.Forms.BindingSource.Position%2A> свойство.  
  
### <a name="to-increment-the-position-in-a-data-source"></a>Увеличение позиции в источнике данных  
  
1. Задайте <xref:System.Windows.Forms.BindingSource.Position%2A> свойство <xref:System.Windows.Forms.BindingSource> связанных данных в позиции записи, чтобы перейти к. В следующем примере демонстрируется использование <xref:System.Windows.Forms.BindingSource.MoveNext%2A> метод <xref:System.Windows.Forms.BindingSource> для увеличения значения <xref:System.Windows.Forms.BindingSource.Position%2A> свойство при `nextButton` нажатии. <xref:System.Windows.Forms.BindingSource> Связан с `Customers` набора данных `Northwind`.  
  
    > [!NOTE]
    >  Установка <xref:System.Windows.Forms.BindingSource.Position%2A> значение за пределами первой или последней записи не приведет к ошибке, как [!INCLUDE[dnprdnshort](../../../includes/dnprdnshort-md.md)] не позволит вам задать положение значения, выходящего за границы списка. Если важно знать, достигнута ли первой или последней записи приложения, добавьте логику для проверки превышения количества элементов данных.  
  
     [!code-csharp[System.Windows.Forms.NavigatingData#4](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.NavigatingData/CS/Form1.cs#4)]
       
  
### <a name="to-check-whether-you-have-passed-the-end-or-beginning"></a>Чтобы проверить, является ли начало или конец  
  
1. Создайте обработчик событий для события <xref:System.Windows.Forms.BindingSource.PositionChanged>. В обработчике вы можете протестировать значение предлагаемом месте превысил количество элементов фактические данные.  
  
     В следующем примере показано, как вы можете протестировать достижения последнего элемента данных. В примере, если вы находитесь в последнего элемента **Далее** будет отключена кнопка в форме.  
  
    > [!NOTE]
    >  Имейте в виду, что при изменении списка, при перемещении в коде, необходимо включить **Далее** кнопку, чтобы пользователи могли просматривать всю длину нового списка. Кроме того, следует помнить, указанных выше <xref:System.Windows.Forms.BindingSource.PositionChanged> событий для конкретного <xref:System.Windows.Forms.BindingSource> вы работаете с должно быть связано со своим методом обработки событий. Ниже приведен пример метода обработки <xref:System.Windows.Forms.BindingSource.PositionChanged> событий:  
  
     [!code-csharp[System.Windows.Forms.NavigatingData#3](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.NavigatingData/CS/Form1.cs#3)]
       
  
### <a name="to-find-an-item-and-set-it-as-the-current-item"></a>Чтобы найти элемент и задать его в качестве текущего элемента  
  
1. Найдите запись, которую вы хотите задать в качестве текущего элемента. Это можно сделать с помощью <xref:System.Windows.Forms.BindingSource.Find%2A> метод <xref:System.Windows.Forms.BindingSource>, если источник данных реализует <xref:System.ComponentModel.IBindingList>. Вот некоторые примеры данных источников, реализующие <xref:System.ComponentModel.IBindingList> являются <xref:System.ComponentModel.BindingList%601> и <xref:System.Data.DataView>.  
  
     [!code-csharp[System.Windows.Forms.NavigatingData#2](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.NavigatingData/CS/Form1.cs#2)]
       
  
## <a name="see-also"></a>См. также

- [Источники данных, поддерживаемые Windows Forms](data-sources-supported-by-windows-forms.md)
- [Получение уведомления об изменении данных, связанных с элементом управления, в Windows Forms](change-notification-in-windows-forms-data-binding.md)
- [Связывание данных и Windows Forms](data-binding-and-windows-forms.md)
- [Привязка данных Windows Forms](windows-forms-data-binding.md)
