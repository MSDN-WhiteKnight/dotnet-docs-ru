---
title: Практическое руководство. Правильное позиционирование выделенной строки в дочерней таблице
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- master-details view
- row position [Windows Forms]
- parent/child view [Windows Forms]
- resetting child position
- data binding [.NET Framework], row selection
- caching [.NET Framework], child position
- child position
- master/details view [Windows Forms]
- child tables row selection
- current child position
ms.assetid: c5fa2562-43a4-46fa-a604-52d8526a87bd
ms.openlocfilehash: 891a9a4d092de35ceff2f5ceb6dbde77cf2ca2ce
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59303145"
---
# <a name="how-to-ensure-the-selected-row-in-a-child-table-remains-at-the-correct-position"></a>Практическое руководство. Правильное позиционирование выделенной строки в дочерней таблице
Зачастую при работе с привязкой данных в формах Windows Forms, данные будут отображаться в виде представлений «родительский-дочерний» или «основной-подробности». Это относится к сценариям привязки данных, где отображаются данные из одного источника в двух элементах управления. Изменение выделения в одном элементе управления вызывает изменение данных, отображаемых во втором элементе управления. Например, первый элемент управления может содержать список клиентов, а второй — список заказов, связанных с выбранным клиентом из первого элемента управления.  
  
 Начиная с .NET Framework версии 2.0, при отображении данных в представлении «родительский-дочерний» может потребоваться предпринять дополнительные действия, чтобы убедиться в том, что выбранная строка в дочерней таблице не сбрасывается на первую строку таблицы. Для этого необходимо кэшировать позицию дочерней таблицы и сбрасывать ее после изменения родительской таблицы. Обычно сброс дочерних таблиц происходит после первого изменения поля в строке родительской таблицы.  
  
### <a name="to-cache-the-current-child-position"></a>Кэширование текущей позиции дочерней таблицы  
  
1. Объявите целочисленную переменную для хранения позиции в дочернем списке и логическую переменную для хранения признака, следует ли кэшировать позицию дочерней таблицы.  
  
     [!code-csharp[System.Windows.Forms.CurrencyManagerReset#4](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.CurrencyManagerReset/CS/Form1.cs#4)]
       
  
2. Обработайте событие <xref:System.Windows.Forms.CurrencyManager.ListChanged> для привязки <xref:System.Windows.Forms.CurrencyManager> и проверьте значение <xref:System.ComponentModel.ListChangedType> из <xref:System.ComponentModel.ListChangedType.Reset>.  
  
3. Проверьте текущую позицию <xref:System.Windows.Forms.CurrencyManager>. Если она больше, чем первая запись в списке (обычно 0), сохраните ее в переменной.  
  
     [!code-csharp[System.Windows.Forms.CurrencyManagerReset#2](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.CurrencyManagerReset/CS/Form1.cs#2)]
       
  
4. Обработайте событие <xref:System.Windows.Forms.BindingManagerBase.CurrentChanged> родительского списка для родительского диспетчера денежного формата. В обработчике задайте логическое значение, указывающее, что он не относится к сценарию кэширования. Если возникает <xref:System.Windows.Forms.BindingManagerBase.CurrentChanged>, то в родительском объекте происходит изменение, которое  является изменением позиции в списке, а не изменением значения элемента.  
  
     [!code-csharp[System.Windows.Forms.CurrencyManagerReset#5](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.CurrencyManagerReset/CS/Form1.cs#5)]
       
  
### <a name="to-reset-the-child-position"></a>Сброс позиции дочерней таблицы  
  
1. Обработайте событие <xref:System.Windows.Forms.BindingManagerBase.PositionChanged> для дочерней привязки<xref:System.Windows.Forms.CurrencyManager>.  
  
2. Установите позицию в дочерней таблице на кэшированную позицию, сохраненную в предыдущей процедуре.  
  
     [!code-csharp[System.Windows.Forms.CurrencyManagerReset#3](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.CurrencyManagerReset/CS/Form1.cs#3)]
       
  
## <a name="example"></a>Пример  
 В следующем примере показано, как сохранить текущую позицию в <xref:System.Windows.Forms.CurrencyManager> для дочерней таблицы и сбросить позицию после завершения изменения родительской таблицы. Этот пример содержит два элемента управления <xref:System.Windows.Forms.DataGridView>, которые привязаны к двум таблицам в <xref:System.Data.DataSet> с помощью компонента <xref:System.Windows.Forms.BindingSource>. Между двумя таблицами установлено отношение, добавлено отношение к <xref:System.Data.DataSet>. В демонстрационных целях позиция дочерней таблицы изначально установлена на третью строку.  
  
 [!code-csharp[System.Windows.Forms.CurrencyManagerReset#1](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.CurrencyManagerReset/CS/Form1.cs#1)]
   
  
 Чтобы проверить пример кода, выполните следующие действия.  
  
1. Запустите пример.  
  
2. Убедитесь, что установлен флажок **Кэшировать и сбрасывать позицию**.  
  
3. Нажмите кнопку **Очистить родительское поле**, чтобы произвести изменение поля родительской таблицы. Обратите внимание, что выбранная строка в дочерней таблице не изменяется.  
  
4. Закройте и снова запустите пример. Это необходимо сделать, поскольку сброс происходит только при первом изменении в родительской строке.  
  
5. Сбросьте флажок **Кэшировать и сбрасывать позицию**.  
  
6. Нажмите кнопку **Очистить родительское поле**. Обратите внимание, что выбранная строка в дочерней таблице становится первой строкой.  
  
## <a name="compiling-the-code"></a>Компиляция кода  
 Для этого примера требуются:  
  
-   ссылки на сборки System, System.Data, System.Drawing, System.Windows.Forms и System.XML.  
  
 Сведения о выполнении сборки этого примера из командной строки для Visual Basic или Visual C#, см. в разделе [построение из командной строки](../../visual-basic/reference/command-line-compiler/building-from-the-command-line.md) или [командной строки построение с помощью csc.exe](../../csharp/language-reference/compiler-options/command-line-building-with-csc-exe.md). Можно также сборке этого примера в Visual Studio путем вставки кода в новый проект.  
  
## <a name="see-also"></a>См. также

- [Практическое руководство. Синхронизация элементов управления, связанных с одним источником данных](multiple-controls-bound-to-data-source-synchronized.md)
- [Компонент BindingSource](./controls/bindingsource-component.md)
- [Связывание данных и Windows Forms](data-binding-and-windows-forms.md)
