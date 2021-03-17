---
title: Практическое руководство. Создание привязки к методу
ms.date: 03/30/2017
helpviewer_keywords:
- data binding [WPF], binding to methods using ObjectDataProvider
- binding [WPF], to methods
- methods [WPF], binding to
ms.assetid: 5f55e71e-2182-42a0-88d1-700cc1427a7a
ms.openlocfilehash: 6cdad46fd6d9ef3bc4ce1a13fedb6ff1d639d93e
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59123244"
---
# <a name="how-to-bind-to-a-method"></a>Практическое руководство. Создание привязки к методу
В следующем примере показано, как для привязки к методу с помощью <xref:System.Windows.Data.ObjectDataProvider>.  
  
## <a name="example"></a>Пример  
 В этом примере `TemperatureScale` — это класс, у которого есть метод `ConvertTemp`, принимающий два параметра (один из `double` и один из `enum` типа `TempType)`) и преобразующий данное значение из одной температурной шкалы в другую. В следующем примере <xref:System.Windows.Data.ObjectDataProvider> используется для создания экземпляра `TemperatureScale` объекта. Метод `ConvertTemp` вызывается с двумя заданными параметрами.  
  
 [!code-xaml[BindToMethod#WindowResources](~/samples/snippets/csharp/VS_Snippets_Wpf/BindToMethod/CS/Window1.xaml#windowresources)]  
  
 Теперь, когда метод доступен как ресурс, вы можете привязывать к его результатам. В следующем примере <xref:System.Windows.Controls.TextBox.Text%2A> свойство <xref:System.Windows.Controls.TextBox> и <xref:System.Windows.Controls.Primitives.Selector.SelectedValue%2A> из <xref:System.Windows.Controls.ComboBox> связанных с двумя параметрами метода. Таким образом, пользователи могут указывать исходную и целевую температурную шкалу. Обратите внимание, что <xref:System.Windows.Data.Binding.BindsDirectlyToSource%2A> присваивается `true` так, как выполняется привязка к <xref:System.Windows.Data.ObjectDataProvider.MethodParameters%2A> свойство <xref:System.Windows.Data.ObjectDataProvider> экземпляр и не к свойствам объект, инкапсулированный с <xref:System.Windows.Data.ObjectDataProvider> ( `TemperatureScale` объекта).  
  
 <xref:System.Windows.Controls.ContentControl.Content%2A> Последнего <xref:System.Windows.Controls.Label> обновления, когда пользователь изменяет содержимое <xref:System.Windows.Controls.TextBox> или выбор <xref:System.Windows.Controls.ComboBox>.  
  
 [!code-xaml[BindToMethod#UI](~/samples/snippets/csharp/VS_Snippets_Wpf/BindToMethod/CS/Window1.xaml#ui)]  
  
 Преобразователь `DoubleToString` принимает значение типа double и преобразует его в строку в <xref:System.Windows.Data.IValueConverter.Convert%2A> направлении (от источника привязки к цели привязки, который является <xref:System.Windows.Controls.TextBox.Text%2A> свойства) и преобразует `string` для `double` в <xref:System.Windows.Data.IValueConverter.ConvertBack%2A> направление.  
  
 `InvalidationCharacterRule` Является <xref:System.Windows.Controls.ValidationRule> , проверяет наличие недопустимых символов. Шаблон ошибки по умолчанию, который представляет собой красную границу вокруг <xref:System.Windows.Controls.TextBox>, появляется для уведомления пользователей, если входное значение не является значением double.  
  
## <a name="see-also"></a>См. также

- [Практические руководства](data-binding-how-to-topics.md)
- [Привязка к перечислению](how-to-bind-to-an-enumeration.md)
