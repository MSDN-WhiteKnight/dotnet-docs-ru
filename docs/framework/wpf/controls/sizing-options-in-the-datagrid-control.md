---
title: Параметры изменения размеров элемента управления DataGrid
ms.date: 03/30/2017
helpviewer_keywords:
- DataGrid control [WPF], sizing
- size [WPF], DataGrid
- automatically size DataGrid [WPF]
ms.assetid: 96a0e47e-b010-4302-98ef-2daac446d8db
ms.openlocfilehash: 6d100fb17b1ee3e652985a637d333d9f65e20d36
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59219204"
---
# <a name="sizing-options-in-the-datagrid-control"></a>Параметры изменения размеров элемента управления DataGrid
Доступны различные варианты для управления как <xref:System.Windows.Controls.DataGrid> изменяет свой размер. <xref:System.Windows.Controls.DataGrid>, А отдельные строки и столбцы в <xref:System.Windows.Controls.DataGrid>, можно задать для определения размера их содержимое автоматически или могут быть присвоены определенные значения. По умолчанию <xref:System.Windows.Controls.DataGrid> будут увеличиваться и уменьшаться в соответствии с размером его содержимого.  
  
## <a name="sizing-the-datagrid"></a>Изменение размера DataGrid  
  
### <a name="cautions-when-using-automatic-sizing"></a>Меры предосторожности при использовании автоматического изменения размера  
 По умолчанию <xref:System.Windows.FrameworkElement.Height%2A> и <xref:System.Windows.FrameworkElement.Width%2A> свойства <xref:System.Windows.Controls.DataGrid> присваивается <xref:System.Double.NaN?displayProperty=nameWithType> («`Auto`"в XAML) и <xref:System.Windows.Controls.DataGrid> настроит размеру его содержимого.  
  
 При размещении внутри контейнера, который не ограничивает размер своих дочерних элементов, таких как <xref:System.Windows.Controls.Canvas> или <xref:System.Windows.Controls.StackPanel>, <xref:System.Windows.Controls.DataGrid> будет растягиваться за пределы видимой границы контейнера, и полосы прокрутки не отображаются. Эта проблема влияет на производительность и удобство использования.  
  
 При привязке к набору данных, если <xref:System.Windows.FrameworkElement.Height%2A> из <xref:System.Windows.Controls.DataGrid> является не ограничено, она будет продолжать добавьте строку для каждого элемента данных в привязанного набора данных. Это может привести к <xref:System.Windows.Controls.DataGrid> увеличиваться за пределами видимых границ приложения по мере добавления строк. <xref:System.Windows.Controls.DataGrid> Не покажет полосы прокрутки в данном случае из-за его <xref:System.Windows.FrameworkElement.Height%2A> будет продолжать расти для размещения новых строк.  
  
 Объект создается для каждой строки в <xref:System.Windows.Controls.DataGrid>. Если вы работаете с большим набором данных, и вы разрешаете <xref:System.Windows.Controls.DataGrid> автоматическое изменение размера, создание большого числа объектов может повлиять на производительность приложения.  
  
 Чтобы избежать этих проблем при работе с большими наборами данных, рекомендуется специально настроены <xref:System.Windows.FrameworkElement.Height%2A> из <xref:System.Windows.Controls.DataGrid> или поместить его в контейнер, который ограничит его <xref:System.Windows.FrameworkElement.Height%2A>, такие как <xref:System.Windows.Controls.Grid>. Когда <xref:System.Windows.FrameworkElement.Height%2A> ограничен, <xref:System.Windows.Controls.DataGrid> создает только строки, соответствующие указанным в <xref:System.Windows.FrameworkElement.Height%2A>и будет повторно использовать эти строки при необходимости для отображения новых данных.  
  
### <a name="setting-the-datagrid-size"></a>Задание размера DataGrid  
 <xref:System.Windows.Controls.DataGrid> Можно задать автоматическое изменение размеров в пределах указанных границ или <xref:System.Windows.Controls.DataGrid> может быть присвоено определенного размера. Ниже приведены свойства, которые можно задать для элемента управления <xref:System.Windows.Controls.DataGrid> размер.  
  
|Свойство|Описание|  
|--------------|-----------------|  
|<xref:System.Windows.FrameworkElement.Height%2A>|Задает определенную высоту <xref:System.Windows.Controls.DataGrid>.|  
|<xref:System.Windows.FrameworkElement.MaxHeight%2A>|Задает верхнюю границу высоту <xref:System.Windows.Controls.DataGrid>. <xref:System.Windows.Controls.DataGrid> Будет увеличиваться по вертикали до достижения этой высоты.|  
|<xref:System.Windows.FrameworkElement.MinHeight%2A>|Задает нижнюю границу для высоты <xref:System.Windows.Controls.DataGrid>. <xref:System.Windows.Controls.DataGrid> Приведет к сжатию по вертикали до достижения этой высоты.|  
|<xref:System.Windows.FrameworkElement.Width%2A>|Задает ширину для <xref:System.Windows.Controls.DataGrid>.|  
|<xref:System.Windows.FrameworkElement.MaxWidth%2A>|Задает верхнюю границу ширину <xref:System.Windows.Controls.DataGrid>. <xref:System.Windows.Controls.DataGrid> Увеличивается по горизонтали до достижения этой ширины.|  
|<xref:System.Windows.FrameworkElement.MinWidth%2A>|Задает нижнюю границу для ширину <xref:System.Windows.Controls.DataGrid>. <xref:System.Windows.Controls.DataGrid> Уменьшается по горизонтали до достижения этой ширины.|  
  
## <a name="sizing-rows-and-row-headers"></a>Изменение размера строк и заголовки строк  
  
### <a name="datagrid-rows"></a>Строки DataGrid  
 По умолчанию <xref:System.Windows.Controls.DataGrid> строки <xref:System.Windows.FrameworkElement.Height%2A> свойству <xref:System.Double.NaN?displayProperty=nameWithType> (»`Auto`"в XAML), высота строки будет увеличиваться по размеру его содержимого. Высоту всех строк в <xref:System.Windows.Controls.DataGrid> можно указать, задав <xref:System.Windows.Controls.DataGrid.RowHeight%2A?displayProperty=nameWithType> свойство. Пользователи могут изменять высоту строк путем перетаскивания разделителей строк заголовка.  
  
### <a name="datagrid-row-headers"></a>Заголовки строк DataGrid  
 Отображение заголовков строк, <xref:System.Windows.Controls.DataGrid.HeadersVisibility%2A> свойству должно быть присвоено <xref:System.Windows.Controls.DataGridHeadersVisibility.Row?displayProperty=nameWithType> или <xref:System.Windows.Controls.DataGridHeadersVisibility.All?displayProperty=nameWithType>. По умолчанию отображаются заголовки строк, и они автоматически масштабироваться в соответствии с содержимым. Заголовки строк можно фиксированную ширину, задав <xref:System.Windows.Controls.DataGrid.RowHeaderWidth%2A?displayProperty=nameWithType> свойство.  
  
## <a name="sizing-columns-and-column-headers"></a>Изменение размеров столбцов и заголовков столбцов  
  
### <a name="datagrid-columns"></a>DataGrid, столбцы  
 <xref:System.Windows.Controls.DataGrid> Использует значения <xref:System.Windows.Controls.DataGridLength> и <xref:System.Windows.Controls.DataGridLengthUnitType> структура для указания режимов абсолютный или автоматическое изменение размеров.  
  
 Ниже приведены значения, предоставленные <xref:System.Windows.Controls.DataGridLengthUnitType> структуры.  
  
|name|Описание|  
|----------|-----------------|  
|<xref:System.Windows.Controls.DataGridLengthUnitType.Auto>|По умолчанию автоматическое изменение размера размеры режим <xref:System.Windows.Controls.DataGrid> столбцы на основе содержимого ячеек и заголовков столбцов.|  
|<xref:System.Windows.Controls.DataGridLengthUnitType.SizeToCells>|Основе ячеек автоматическое изменение размера размеры режим <xref:System.Windows.Controls.DataGrid> столбцы на основе содержимого ячеек в столбце, не включая заголовки столбцов.|  
|<xref:System.Windows.Controls.DataGridLengthUnitType.SizeToHeader>|На основе заголовков автоматическое изменение размера размеры режим <xref:System.Windows.Controls.DataGrid> столбцы на основе содержимого заголовков столбцов.|  
|<xref:System.Windows.Controls.DataGridLengthUnitType.Pixel>|Точечных изменения размера размеры режим <xref:System.Windows.Controls.DataGrid> столбцы на основе числового значения предоставляются.|  
|<xref:System.Windows.Controls.DataGridLengthUnitType.Star>|Режим изменения размера типа "звезда" используется для распределения доступное пространство взвешенного пропорции.<br /><br /> В XAML значения типа "звезда" выражаются в виде n *, где n представляет числовое значение. 1\* эквивалентен \*. Например, если два столбцы в <xref:System.Windows.Controls.DataGrid> имеют ширину \* и 2\*, первый столбец получит одну часть доступного пространства и второй столбец получит две части доступное пространство.|  
  
 <xref:System.Windows.Controls.DataGridLengthConverter> Класс может использоваться для преобразования данных между числовыми или строковыми значениями и <xref:System.Windows.Controls.DataGridLength> значения.  
  
 По умолчанию <xref:System.Windows.Controls.DataGrid.ColumnWidth%2A?displayProperty=nameWithType> свойству <xref:System.Windows.Controls.DataGridLength.SizeToHeader%2A>и <xref:System.Windows.Controls.DataGridColumn.Width%2A?displayProperty=nameWithType> свойству <xref:System.Windows.Controls.DataGridLength.Auto%2A>. Если присвоить режим изменения размеров <xref:System.Windows.Controls.DataGridLength.Auto%2A> или <xref:System.Windows.Controls.DataGridLength.SizeToCells%2A>, столбцы будет увеличиваться до ширины их самого широкого отображаемого содержимого. Во время прокрутки эти режимы изменения размеров приведет к столбцы для отображения содержимого, которые больше, чем текущий размер столбца в области просмотра. Столбец не приведет к сжатию после содержимого находится вне области просмотра.  
  
 Столбцы в <xref:System.Windows.Controls.DataGrid> можно также задать автоматическое изменение размеров только в пределах указанных границ, или столбцы, которые можно установить значение определенного размера. Ниже приведены свойства, которые могут устанавливаться для управления размером столбцов.  
  
|Свойство|Описание|  
|--------------|-----------------|  
|<xref:System.Windows.Controls.DataGrid.MaxColumnWidth%2A?displayProperty=nameWithType>|Задает верхнюю границу для всех столбцов в <xref:System.Windows.Controls.DataGrid>.|  
|<xref:System.Windows.Controls.DataGridColumn.MaxWidth%2A?displayProperty=nameWithType>|Задает верхнюю границу для отдельного столбца. Переопределяет <xref:System.Windows.Controls.DataGrid.MaxColumnWidth%2A?displayProperty=nameWithType>.|  
|<xref:System.Windows.Controls.DataGrid.MinColumnWidth%2A?displayProperty=nameWithType>|Задает нижнюю границу для всех столбцов в <xref:System.Windows.Controls.DataGrid>.|  
|<xref:System.Windows.Controls.DataGridColumn.MinWidth%2A?displayProperty=nameWithType>|Задает нижнюю границу для отдельного столбца. Переопределяет <xref:System.Windows.Controls.DataGrid.MinColumnWidth%2A?displayProperty=nameWithType>.|  
|<xref:System.Windows.Controls.DataGrid.ColumnWidth%2A?displayProperty=nameWithType>|Задает ширину для всех столбцов в <xref:System.Windows.Controls.DataGrid>.|  
|<xref:System.Windows.Controls.DataGridColumn.Width%2A?displayProperty=nameWithType>|Задает ширину для отдельного столбца. Переопределяет <xref:System.Windows.Controls.DataGrid.ColumnWidth%2A?displayProperty=nameWithType>.|  
  
### <a name="datagrid-column-headers"></a>Заголовки столбцов DataGrid  
 По умолчанию <xref:System.Windows.Controls.DataGrid> отображаются заголовки столбцов. Чтобы скрыть заголовки столбцов, <xref:System.Windows.Controls.DataGrid.HeadersVisibility%2A> свойству должно быть присвоено <xref:System.Windows.Controls.DataGridHeadersVisibility.Row?displayProperty=nameWithType> или <xref:System.Windows.Controls.DataGridHeadersVisibility.None?displayProperty=nameWithType>. По умолчанию при отображении заголовков столбцов, они автоматически меняют размер в соответствии с содержимым. Заголовки столбцов можно задать высоту, задав <xref:System.Windows.Controls.DataGrid.ColumnHeaderHeight%2A?displayProperty=nameWithType> свойство.  
  
### <a name="resizing-with-the-mouse"></a>Изменение размеров с помощью мыши  
 Пользователь может изменять размер <xref:System.Windows.Controls.DataGrid> строк и столбцов, перетаскивая разделители заголовков строк или столбцов. <xref:System.Windows.Controls.DataGrid> Также поддерживает автоматическое изменение размера строк и столбцов, дважды щелкнув разделитель заголовка строки или столбца. Чтобы предотвратить изменение размеров определенных столбцов, задайте <xref:System.Windows.Controls.DataGridColumn.CanUserResize%2A?displayProperty=nameWithType> свойства `false` для каждого столбца. Чтобы запретить пользователям изменять размеры всех столбцов, задайте <xref:System.Windows.Controls.DataGrid.CanUserResizeColumns%2A?displayProperty=nameWithType> свойства `false`. Чтобы запретить пользователям изменять размеры всех строк, задайте <xref:System.Windows.Controls.DataGrid.CanUserResizeRows%2A?displayProperty=nameWithType> свойства `false`.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Controls.DataGrid>
- <xref:System.Windows.Controls.DataGridColumn>
- <xref:System.Windows.Controls.DataGridLength>
- <xref:System.Windows.Controls.DataGridLengthConverter>
