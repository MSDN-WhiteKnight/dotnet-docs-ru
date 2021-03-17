---
title: Создание сложной сетки
description: Пример использования элемента управления сетки для создания макета, который выглядит как календарь.
ms.date: 03/30/2017
helpviewer_keywords:
- calendar [WPF], creating
- monthly calendar [WPF], creating
- Grid control [WPF], creating [WPF], complex grid
ms.assetid: 4ce3040a-a156-4364-9596-98ca1eca5550
ms.openlocfilehash: dd17dfeea85e2b404f7a284f93faceec63145b1f
ms.sourcegitcommit: 0c48191d6d641ce88d7510e319cf38c0e35697d0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/05/2019
ms.locfileid: "57355038"
---
# <a name="how-to-create-a-complex-grid"></a>Создание сложной сетки

В этом примере показано, как использовать <xref:System.Windows.Controls.Grid> управления для создания макета, который выглядит как календарь.

## <a name="example"></a>Пример

В следующем примере определяется восемь строк и восемь столбцов с помощью <xref:System.Windows.Controls.RowDefinition> и <xref:System.Windows.Controls.ColumnDefinition> классы. Она использует <xref:System.Windows.Controls.Grid.ColumnSpan%2A?displayProperty=nameWithType> и <xref:System.Windows.Controls.Grid.RowSpan%2A?displayProperty=nameWithType> присоединенных свойств, вместе с <xref:System.Windows.Shapes.Rectangle> элементы, которые заполняют фон различных столбцов и строк. Такой подход возможен, так как может существовать несколько элементов в каждой ячейке <xref:System.Windows.Controls.Grid>, принципиальное различие между <xref:System.Windows.Controls.Grid> и <xref:System.Windows.Documents.Table>.

В примере используется вертикальные градиенты к <xref:System.Windows.Shapes.Shape.Fill%2A> столбцы и строки, чтобы улучшить визуальное представление и удобочитаемость календаря. Стиль <xref:System.Windows.Controls.TextBlock> элементы представляют даты и дней недели. <xref:System.Windows.Controls.TextBlock> элементов абсолютного располагаются в пределах их ячеек с помощью <xref:System.Windows.FrameworkElement.Margin%2A> свойства и свойства выравнивания, которые определены в стиле для приложения.

[!code-xaml[GridComplex#1](~/samples/snippets/csharp/VS_Snippets_Wpf/GridComplex/CS/default.xaml#1)]

На следующем рисунке показана полученный элемент управления, настраиваемые календаря:

![Снимок экрана полученный элемент управления](././media/how-to-create-a-complex-grid/wpf-manual-calendar.png)

## <a name="see-also"></a>См. также

- <xref:System.Windows.Controls.Grid?displayProperty=nameWithType>
- <xref:System.Windows.Documents.TableCell?displayProperty=nameWithType>
- [Общие сведения о закраске сплошным цветом и градиентом](../graphics-multimedia/painting-with-solid-colors-and-gradients-overview.md)
- [Общие сведения о панелях](panels-overview.md)
- [Общие сведения о таблицах](../advanced/table-overview.md)