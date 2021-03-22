---
title: Практическое руководство. Управление обновлением источника из поля TextBox
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- source updates [WPF], timing of
- data binding [WPF], timing of source updates
- timing of source updates [WPF]
ms.assetid: ffb7b96a-351d-4c68-81e7-054033781c64
ms.openlocfilehash: 5272a19f69b3caf80fd7d5187c9a6a386cd44621
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59143277"
---
# <a name="how-to-control-when-the-textbox-text-updates-the-source"></a>Практическое руководство. Управление обновлением источника из поля TextBox
В этом разделе описывается использование <xref:System.Windows.Data.Binding.UpdateSourceTrigger%2A> свойство, чтобы управлять временем обновлений источника привязки. В этом разделе используются <xref:System.Windows.Controls.TextBox> элемента управления в качестве примера.  
  
## <a name="example"></a>Пример  
 <xref:System.Windows.Controls.TextBox>.<xref:System.Windows.Controls.TextBox.Text%2A> свойство имеет значение по умолчанию <xref:System.Windows.Data.Binding.UpdateSourceTrigger%2A> значение <xref:System.Windows.Data.UpdateSourceTrigger.LostFocus>. Это означает, что если приложение имеет <xref:System.Windows.Controls.TextBox> с привязкой к данным <xref:System.Windows.Controls.TextBox>.<xref:System.Windows.Controls.TextBox.Text%2A> свойство, введенный текст в <xref:System.Windows.Controls.TextBox> обновляет источник до <xref:System.Windows.Controls.TextBox> теряет фокус (например, при нажатии кнопки с <xref:System.Windows.Controls.TextBox>).  
  
 Источник обновляться по мере ввода, задайте <xref:System.Windows.Data.Binding.UpdateSourceTrigger%2A> привязки <xref:System.Windows.Data.UpdateSourceTrigger.PropertyChanged>. В следующем примере, выделенные строки кода показывают, что `Text` свойствах обоих <xref:System.Windows.Controls.TextBox> и <xref:System.Windows.Controls.TextBlock> привязаны к тому же свойству источника. <xref:System.Windows.Data.Binding.UpdateSourceTrigger%2A> Свойство <xref:System.Windows.Controls.TextBox> привязки имеет значение <xref:System.Windows.Data.UpdateSourceTrigger.PropertyChanged>.  
  
 [!code-xaml[SimpleBinding#USTHowTo](~/samples/snippets/visualbasic/VS_Snippets_Wpf/SimpleBinding/VisualBasic/Page1.xaml?highlight=33-39,41-42)]  
  
 В результате <xref:System.Windows.Controls.TextBlock> отображается тот же текст (поскольку источник изменяется), который пользователь вводит текст в <xref:System.Windows.Controls.TextBox>, как показано на следующем снимке экрана примера:  
  
 ![Снимок экрана примера привязки простых данных](./media/databindingsimplebindingsample2.png "DataBindingSimpleBindingSample2")  
  
 Если у вас есть диалоговое окно или редактируемая пользователем форма и требуется отложить обновление источника, пока пользователь не завершит редактирование поля и нажимает кнопку «ОК», можно задать <xref:System.Windows.Data.Binding.UpdateSourceTrigger%2A> значение привязки в <xref:System.Windows.Data.UpdateSourceTrigger.Explicit>, как показано в следующем примере:  
  
 [!code-xaml[UpdateSource#2](~/samples/snippets/csharp/VS_Snippets_Wpf/UpdateSource/CSharp/Window1.xaml#2)]  
  
 При задании <xref:System.Windows.Data.Binding.UpdateSourceTrigger%2A> значение <xref:System.Windows.Data.UpdateSourceTrigger.Explicit>, исходное значение изменяется, только когда приложение вызывает <xref:System.Windows.Data.BindingExpression.UpdateSource%2A> метод. В следующем примере показан вызов <xref:System.Windows.Data.BindingExpression.UpdateSource%2A> для `itemNameTextBox`:  
  
 [!code-csharp[UpdateSource#1](~/samples/snippets/csharp/VS_Snippets_Wpf/UpdateSource/CSharp/Window1.xaml.cs#1)]
   
  
> [!NOTE]
>  Можно использовать ту же методику для свойств других элементов управления, но имейте в виду, что для большинства других свойств по умолчанию <xref:System.Windows.Data.Binding.UpdateSourceTrigger%2A> значение <xref:System.Windows.Data.UpdateSourceTrigger.PropertyChanged>. Дополнительные сведения см. в разделе <xref:System.Windows.Data.Binding.UpdateSourceTrigger%2A> страницу свойств.  
  
> [!NOTE]
>  <xref:System.Windows.Data.Binding.UpdateSourceTrigger%2A> Свойство относится к обновлению источника и поэтому подходит только для <xref:System.Windows.Data.BindingMode.TwoWay> или <xref:System.Windows.Data.BindingMode.OneWayToSource> привязки. Для <xref:System.Windows.Data.BindingMode.TwoWay> и <xref:System.Windows.Data.BindingMode.OneWayToSource> привязки для работы, исходный объект должен предоставить уведомление об изменениях свойств. Можно изучить примеры, приведенные в этом разделе, для получения дополнительной информации. Кроме того, см. раздел [Реализация уведомления об изменении свойства](how-to-implement-property-change-notification.md).  
  
## <a name="see-also"></a>См. также

- [Практические руководства](data-binding-how-to-topics.md)
