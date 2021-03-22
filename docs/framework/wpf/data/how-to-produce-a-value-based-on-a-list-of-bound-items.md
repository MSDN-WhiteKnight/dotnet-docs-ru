---
title: Практическое руководство. Создание значений на основе списка связанных элементов
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- data binding [WPF], MultiBinding
- Multibinding [WPF]
ms.assetid: b3d06378-b511-4181-95aa-316d60c9229b
ms.openlocfilehash: c2ec5ff26c89649294df266e790445e5aa5d08ae
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59200523"
---
# <a name="how-to-produce-a-value-based-on-a-list-of-bound-items"></a>Практическое руководство. Создание значений на основе списка связанных элементов
<xref:System.Windows.Data.MultiBinding> позволяет привязать целевое свойство привязки к списку свойств источника и затем применить логику для получения значения с заданными входными данными. В этом примере демонстрируется использование <xref:System.Windows.Data.MultiBinding>.  
  
## <a name="example"></a>Пример  
 В следующем примере `NameListData` ссылается на коллекцию объектов `PersonName`, которые являются объектами, содержащими два свойства, `firstName` и `lastName`. В следующем примере создается <xref:System.Windows.Controls.TextBlock> , показаны имена и фамилии человека с фамилией первого.  
  
 [!code-xaml[MultiBinding#Resources1](~/samples/snippets/csharp/VS_Snippets_Wpf/MultiBinding/CSharp/Window1.xaml#resources1)]  
[!code-xaml[MultiBinding#Resources2](~/samples/snippets/csharp/VS_Snippets_Wpf/MultiBinding/CSharp/Window1.xaml#resources2)]  
[!code-xaml[MultiBinding#MultiBindingTextBox2](~/samples/snippets/csharp/VS_Snippets_Wpf/MultiBinding/CSharp/Window1.xaml#multibindingtextbox2)]  
[!code-xaml[MultiBinding#Window](~/samples/snippets/csharp/VS_Snippets_Wpf/MultiBinding/CSharp/Window1.xaml#window)]  
  
 Чтобы понять, как получается формат фамилии-имени, рассмотрим реализацию `NameConverter`:  
  
 [!code-csharp[MultiBinding#3](~/samples/snippets/csharp/VS_Snippets_Wpf/MultiBinding/CSharp/NameConverter.cs#3)]
   
  
 `NameConverter` Реализует <xref:System.Windows.Data.IMultiValueConverter> интерфейс. `NameConverter` принимает значения от отдельных привязок и сохраняет их в массиве объектов значений. Порядок, в котором <xref:System.Windows.Data.Binding> элементы отображаются в разделе <xref:System.Windows.Data.MultiBinding> соответствует порядку, в которой хранятся эти значения в массиве. Значение <xref:System.Windows.Data.MultiBinding.ConverterParameter%2A> атрибут ссылается аргумент параметра <xref:System.Windows.Data.MultiBinding.Converter%2A> метод, который переключается на параметр для определения формата имени.  
  
## <a name="see-also"></a>См. также

- [Преобразование привязанных данных](how-to-convert-bound-data.md)
- [Общие сведения о привязке данных](data-binding-overview.md)
- [Практические руководства](data-binding-how-to-topics.md)
