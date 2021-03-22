---
title: Практическое руководство. Реализация уведомления об изменении свойства
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- notifications of change [WPF]
- data binding [WPF], property change notifications
- change notifications [WPF]
- properties [WPF], change notifications
ms.assetid: 30b59d9e-8c3a-4349-aa82-4be837e841cf
ms.openlocfilehash: d37d468acc94470be8c2afdc495b40168932ec83
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59204358"
---
# <a name="how-to-implement-property-change-notification"></a>Практическое руководство. Реализация уведомления об изменении свойства
Для поддержки <xref:System.Windows.Data.BindingMode.OneWay> или <xref:System.Windows.Data.BindingMode.TwoWay> привязки для включения свойства целевого объекта привязки автоматическое отражение динамических изменений источника привязки (например, область просмотра обновляется автоматически, когда пользователь редактирует форму), класс необходимо предоставлять уведомления соответствующие изменения свойства. В этом примере показано, как создать класс, реализующий <xref:System.ComponentModel.INotifyPropertyChanged>.  
  
## <a name="example"></a>Пример  
 Для реализации <xref:System.ComponentModel.INotifyPropertyChanged> необходимо объявить <xref:System.ComponentModel.INotifyPropertyChanged.PropertyChanged> событий и создайте `OnPropertyChanged` метод. Затем для каждого свойства, которому потребуются уведомления об изменениях, вы вызываете `OnPropertyChanged` при каждом обновлении свойства.  
  
 [!code-csharp[SimpleBinding#PersonClass](~/samples/snippets/csharp/VS_Snippets_Wpf/SimpleBinding/CSharp/Person.cs#personclass)]
   
  
 Пример того, как `Person` класс может использоваться для поддержки <xref:System.Windows.Data.BindingMode.TwoWay> привязки, см. в разделе [Управление обновлением источника текст в текстовом поле](how-to-control-when-the-textbox-text-updates-the-source.md).  
  
## <a name="see-also"></a>См. также

- [Общие сведения об источниках привязки](binding-sources-overview.md)
- [Общие сведения о привязке данных](data-binding-overview.md)
- [Практические руководства](data-binding-how-to-topics.md)
