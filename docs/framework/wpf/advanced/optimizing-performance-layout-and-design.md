---
title: 'Оптимизация производительности: Разметка и разработка'
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- layout [WPF], optimizing performance
- design considerations [WPF]
- layout pass [WPF]
ms.assetid: 005f4cda-a849-448b-916b-38d14d9a96fe
ms.openlocfilehash: 8a76dd5de9f374d77345eeab3d259624546fed7c
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59107072"
---
# <a name="optimizing-performance-layout-and-design"></a>Оптимизация производительности: Разметка и разработка
Разработка приложения WPF может повлиять на его производительность в результате создания ненужных служебных данных при вычислении макета и проверки ссылок на объекты. Конструирование объектов, особенно во время выполнения, может повлиять на характеристики производительности приложения.  
  
 В этом разделе даются рекомендации по производительности в этих областях.  
  
## <a name="layout"></a>Макет  
 Термин «проход разметки» описывает процесс измерения и упорядочения объекта <xref:System.Windows.Controls.Panel>-коллекции объектов производного объекта дочерних элементов, и затем рисование их на экране. Проход разметки представляет собой процесс интенсивной математической нагрузки: чем больше число дочерних объектов в коллекции, тем больше требуется вычислений. Например, каждый раз, когда дочерний элемент <xref:System.Windows.UIElement> объекта в коллекции изменяет свое положение, он имеет возможность запустить новый проход системы макета. Из-за разрыва отношения между характеристиками объекта и поведением разметки важно понимать тип событий, которые могут запустить систему разметки. Приложение будет выполняться лучше, если уменьшить, насколько возможно, ненужные вызовы прохода разметки.  
  
 Система разметки выполняет два прохода для каждого дочернего члена в коллекции: проход измерений и проход компоновки. Каждый дочерний объект предоставляет свою собственную переопределенную реализацию из <xref:System.Windows.UIElement.Measure%2A> и <xref:System.Windows.UIElement.Arrange%2A> методы, чтобы обеспечить собственное поведение конкретного макета. В самом простом случае макет является рекурсивной системой, в процессе которой программа изменяет размер и расположение элемента и отображает его на экране.  
  
-   Дочерний элемент <xref:System.Windows.UIElement> объект начинает процесс разметки первым, задав его основные измеряемые свойства.  
  
-   Объекта <xref:System.Windows.FrameworkElement> свойства, относящиеся к размеру, такие как <xref:System.Windows.FrameworkElement.Width%2A>, <xref:System.Windows.FrameworkElement.Height%2A>, и <xref:System.Windows.FrameworkElement.Margin%2A>, вычисляются.  
  
-   <xref:System.Windows.Controls.Panel>-применяется специальная логика, такие как <xref:System.Windows.Controls.DockPanel.Dock%2A> свойство <xref:System.Windows.Controls.DockPanel>, или <xref:System.Windows.Controls.StackPanel.Orientation%2A> свойство <xref:System.Windows.Controls.StackPanel>.  
  
-   Содержимое компонуется или размещается после всех дочерних объектов, которые были измерены.  
  
-   На экране отображается коллекция дочерних объектов.  
  
 Процесс прохода разметки вызывается снова при возникновении любого из следующих событий.  
  
-   Дочерний объект добавляется в коллекцию.  
  
-   Объект <xref:System.Windows.FrameworkElement.LayoutTransform%2A> применяется к дочернему объекту.  
  
-   <xref:System.Windows.UIElement.UpdateLayout%2A> Метод вызывается для дочернего объекта.  
  
-   При изменении значения свойства зависимости, которое помечено метаданными, влияющими на проход измерения и компоновки.  
  
### <a name="use-the-most-efficient-panel-where-possible"></a>Используйте наиболее эффективную панель там, где возможно  
 Сложность прохода разметки непосредственно основана на поведения <xref:System.Windows.Controls.Panel>-используемых элементов, производных. Например <xref:System.Windows.Controls.Grid> или <xref:System.Windows.Controls.StackPanel> элемент управления предоставляет гораздо больше возможностей, чем <xref:System.Windows.Controls.Canvas> элемента управления. Ценой этого значительного увеличения функциональности является увеличение затрат производительности. Тем не менее если не требуется функциональность, <xref:System.Windows.Controls.Grid> предоставляет элемент управления, следует использовать менее затратные варианты, например <xref:System.Windows.Controls.Canvas> или настраиваемую панель.  
  
 Дополнительные сведения см. в разделе [Общие сведения о панелях](../controls/panels-overview.md).  
  
### <a name="update-rather-than-replace-a-rendertransform"></a>Обновление вместо замены RenderTransform  
 Можно обновить <xref:System.Windows.Media.Transform> вместо замены его в качестве значения <xref:System.Windows.UIElement.RenderTransform%2A> свойство. Это особенно актуально в скриптах, включающих анимацию. Обновление существующего <xref:System.Windows.Media.Transform>, вы избегаете инициирования ненужных вычислений разметки.  
  
### <a name="build-your-tree-top-down"></a>Построение дерева сверху вниз  
 При добавлении или удалении узла из логического дерева свойство аннулирования вызывается на родительском узле и всех дочерних узлах. В результате всегда требуется следовать шаблону структуры сверху вниз, во избежание ненужных аннулирований на узлах, которые уже были проверены. В следующей таблице показаны разница в скорости выполнения между построением дерева сверху вниз или снизу вверх, где в дереве 150 уровней с одним <xref:System.Windows.Controls.TextBlock> и <xref:System.Windows.Controls.DockPanel> на каждом уровне.  
  
|**Действие**|**Построение дерева (мс)**|**Отрисовки — включает построение дерева (мс)**|  
|----------------|---------------------------------|-------------------------------------------------|  
|Снизу вверх|366|454|  
|Сверху вниз|11|96|  
  
 В следующем примере кода демонстрируется создание дерева сверху вниз.  
  
 [!code-csharp[Performance#PerformanceSnippet1](~/samples/snippets/csharp/VS_Snippets_Wpf/Performance/CSharp/Window1.xaml.cs#performancesnippet1)]
   
  
 Дополнительные сведения о логическом дереве см. в разделе [Деревья в WPF](trees-in-wpf.md).  
  
## <a name="see-also"></a>См. также

- [Улучшение производительности приложений WPF](optimizing-wpf-application-performance.md)
- [Планирование производительности приложения](planning-for-application-performance.md)
- [Использование преимуществ оборудования](optimizing-performance-taking-advantage-of-hardware.md)
- [Двумерная графика и изображения](optimizing-performance-2d-graphics-and-imaging.md)
- [Поведение объекта](optimizing-performance-object-behavior.md)
- [Ресурсы приложений](optimizing-performance-application-resources.md)
- [Текста](optimizing-performance-text.md)
- [Привязка данных](optimizing-performance-data-binding.md)
- [Дополнительные рекомендации по повышению производительности](optimizing-performance-other-recommendations.md)
- [Макет](layout.md)
