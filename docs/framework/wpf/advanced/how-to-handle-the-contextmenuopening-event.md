---
title: Практическое руководство. Обработка события ContextMenuOpening
ms.date: 03/30/2017
helpviewer_keywords:
- ContextMenuOpening properties [WPF]
ms.assetid: 789652fb-1951-4217-934a-7843e355adf4
ms.openlocfilehash: 65a1e34d5b078c49bf59c2d9787812940c9a7494
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59340403"
---
# <a name="how-to-handle-the-contextmenuopening-event"></a>Практическое руководство. Обработка события ContextMenuOpening
<xref:System.Windows.FrameworkElement.ContextMenuOpening> Событие может быть обработано в приложении, либо для корректировки существующего контекстного меню перед для отображения или подавления меню, которое будет отображаться в противном случае, задав <xref:System.Windows.RoutedEventArgs.Handled%2A> свойства `true` в данных события. Типичной причиной для параметра <xref:System.Windows.RoutedEventArgs.Handled%2A> для `true` событий данных — замена меню полностью новый <xref:System.Windows.Controls.ContextMenu> объекта, который иногда требует отмены операции и запуска нового открытия. Если создать обработчики для <xref:System.Windows.FrameworkElement.ContextMenuOpening> событий, следует иметь в виду проблемы синхронизации между <xref:System.Windows.Controls.ContextMenu> control и служба, которая отвечает за открытие и позиционирование контекстных меню для элементов управления в целом. В этом разделе показаны некоторые методы кода для различных скриптов открытия контекстного меню и показан случай, где ошибки синхронизации вступает в действие.  
  
 Существует несколько сценариев для обработки <xref:System.Windows.FrameworkElement.ContextMenuOpening> событий:  
  
-   Настройка пунктов меню перед отображением.  
  
-   Замена всего меню перед отображением.  
  
-   Полностью подавление любых существующих контекстных меню и отсутствие отображения контекстного меню.  
  
## <a name="example"></a>Пример  
  
## <a name="adjusting-the-menu-items-before-display"></a>Корректировка перед отображением элементов меню  
 Настройка существующих элементов меню достаточно проста и, вероятно, является наиболее распространенным сценарием. Это может сделать для добавления или удаления параметры контекстного меню в ответ на сведения о текущем состоянии приложения или конкретном состоянии, доступной как свойство в объекте, где запрашивается в контекстном меню.  
  
 Основным методом является источник события, который является конкретного элемента управления, который щелкнули, и получите <xref:System.Windows.FrameworkElement.ContextMenu%2A> свойство из него. Как правило, чтобы убедиться, <xref:System.Windows.Controls.ItemsControl.Items%2A> коллекции элементов контекстного меню уже существует в меню и затем добавьте или удалите соответствующие новые <xref:System.Windows.Controls.MenuItem> элементы из коллекции.  
  
 [!code-csharp[ContextMenuOpeningHandlers#AddItemNoHandle](~/samples/snippets/csharp/VS_Snippets_Wpf/ContextMenuOpeningHandlers/CSharp/Pane1.xaml.cs#additemnohandle)]  
  
## <a name="replacing-the-entire-menu-before-display"></a>Замена всего меню перед отображением  
 Альтернативный сценарий —, если вы хотите заменить контекстное меню целиком. Само собой может также использовать вариант предыдущего кода для удаления каждого элемента существующего контекстного меню и добавления новых решений, начиная с нулевого элемента. Но более интуитивный подход для замены всех элементов в контекстном меню, чтобы создать новую <xref:System.Windows.Controls.ContextMenu>, заполнить его с элементами и задайте <xref:System.Windows.FrameworkElement.ContextMenu%2A?displayProperty=nameWithType> свойства элемента управления для нового <xref:System.Windows.Controls.ContextMenu>.  
  
 Ниже приведен код простого обработчика для замены <xref:System.Windows.Controls.ContextMenu>. Код ссылается на пользовательский `BuildMenu` метод, который отделяется, так как он вызывается более чем один из обработчиков, пример.  
  
 [!code-csharp[ContextMenuOpeningHandlers#ReplaceNoReopen](~/samples/snippets/csharp/VS_Snippets_Wpf/ContextMenuOpeningHandlers/CSharp/Pane1.xaml.cs#replacenoreopen)]  
  
 [!code-csharp[ContextMenuOpeningHandlers#BuildMenu](~/samples/snippets/csharp/VS_Snippets_Wpf/ContextMenuOpeningHandlers/CSharp/Pane1.xaml.cs#buildmenu)]  
  
 Тем не менее при использовании этого стиля обработчика для <xref:System.Windows.FrameworkElement.ContextMenuOpening>, потенциально возникновения проблем синхронизации, если объект, где задаются <xref:System.Windows.Controls.ContextMenu> имеет уже существующего контекстного меню. Когда пользователь щелкает правой кнопкой мыши элемент управления <xref:System.Windows.FrameworkElement.ContextMenuOpening> возникает даже в том случае, если существующий <xref:System.Windows.Controls.ContextMenu> пуст или равен null. Но в этом случае любое новое <xref:System.Windows.Controls.ContextMenu> установленное на исходном элементе, поступает слишком поздно для отображения. Кроме того, если пользователь щелкнет правой кнопкой мыши второй раз, это время ваш новый <xref:System.Windows.Controls.ContextMenu> откроется, имеет значение не null, и ваш обработчик правильно заменит и в открывшемся меню при выполнении обработчика во второй раз. Это предполагает два возможных решения:  
  
1. Убедитесь, что <xref:System.Windows.FrameworkElement.ContextMenuOpening> обработчики, всегда запускать для элементов управления, которые имеют по крайней мере заполнитель <xref:System.Windows.Controls.ContextMenu> доступны, который вы собираетесь заменить код обработчика. В этом случае можно по-прежнему использовать обработчика, показанного в предыдущем примере, но обычно требуется назначить заполнитель <xref:System.Windows.Controls.ContextMenu> в первоначальном макете:  
  
     [!code-xaml[ContextMenuOpeningHandlers#XAMLWithInitCM](~/samples/snippets/csharp/VS_Snippets_Wpf/ContextMenuOpeningHandlers/CSharp/Pane1.xaml#xamlwithinitcm)]  
  
2. Предполагается, что начальный <xref:System.Windows.Controls.ContextMenu> значение может иметь значение null, на основе определенной логики предварительной. Можно либо проверить <xref:System.Windows.Controls.ContextMenu> на null, либо использовать флаг в коде, чтобы проверить, была ли ваш обработчик запустить по крайней мере один раз. Так как предполагается, что <xref:System.Windows.Controls.ContextMenu> о будет отображаться, ваш обработчик в затем задает <xref:System.Windows.RoutedEventArgs.Handled%2A> для `true` в данных события. Чтобы <xref:System.Windows.Controls.ContextMenuService> , отвечает за отображение контекстного меню, `true` значение <xref:System.Windows.RoutedEventArgs.Handled%2A> событий данных представляет собой запрос элемента управления сочетание, которое вызвало событие / отмена отображения для контекстного меню.  
  
 Теперь, когда вы отменили потенциально подозрительные контекстного меню, следующим шагом является предоставление нового, затем отобразить ее. Настройка нового одним по сути является таким же, как предыдущий обработчик: выполняется построение новой <xref:System.Windows.Controls.ContextMenu> и в качестве источника указывается управления <xref:System.Windows.FrameworkElement.ContextMenu%2A?displayProperty=nameWithType> свойство с ним. Дополнительный шаг обусловлено тем, что принудительное отображение контекстного меню, первая попытка подавляется. Чтобы принудительно отображение, необходимо задать <xref:System.Windows.Controls.Primitives.Popup.IsOpen%2A?displayProperty=nameWithType> свойства `true` обработчика. Следите за при этом, так как Открытие контекстного меню в обработчике вызывает <xref:System.Windows.FrameworkElement.ContextMenuOpening> событий снова. Если вы вводите Ваш обработчик, он бесконечной рекурсии. Именно по этой причине необходимо всегда проверять для `null` или использовать флаг, если открыть контекстное меню из среды <xref:System.Windows.FrameworkElement.ContextMenuOpening> обработчик событий.  
  
## <a name="suppressing-any-existing-context-menu-and-displaying-no-context-menu"></a>Подавление любых существующих контекстных меню и отсутствие отображения контекстного меню  
 Последний сценарий — написание обработчика, который полностью, подавляет меню используется редко. Если данный элемент управления не предназначен для вызова контекстного меню, чтобы обеспечить это, чем подавление меню только в том случае, когда пользователь запрашивает его, вероятно, более подходящим способами. Но если вы хотите использовать обработчик для подавления контекстного меню без отображения, то обработчик просто должен задавать <xref:System.Windows.RoutedEventArgs.Handled%2A> для `true` в данных события. <xref:System.Windows.Controls.ContextMenuService> , Отвечает за отображение контекстного меню будет проверять данные события, возникшего в элементе управления. Если событие было помечено как <xref:System.Windows.RoutedEventArgs.Handled%2A> в любом месте в маршруте, то действие по открытию контекстного меню, инициировавшего событие будет подавляться.  
  
 [!code-csharp[ContextMenuOpeningHandlers#ReplaceReopen](~/samples/snippets/csharp/VS_Snippets_Wpf/ContextMenuOpeningHandlers/CSharp/Pane1.xaml.cs#replacereopen)]  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Controls.ContextMenu>
- <xref:System.Windows.FrameworkElement.ContextMenu%2A?displayProperty=nameWithType>
- [Общие сведения о базовых элементах](base-elements-overview.md)
- [Общие сведения о ContextMenu](../controls/contextmenu-overview.md)
