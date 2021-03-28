---
title: Практическое руководство. Создание стандартного диалогового окна пользовательского интерфейса с помощью сетки
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- dialog boxes [WPF], creating
- Grid control [WPF], creating [WPF], dialog box
ms.assetid: d6ac3d51-844b-4d29-96d8-81a696a7b960
ms.openlocfilehash: 0ade908e92e552017acb9ba242ccba2c28c3c995
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59149530"
---
# <a name="how-to-build-a-standard-ui-dialog-box-by-using-grid"></a>Практическое руководство. Создание стандартного диалогового окна пользовательского интерфейса с помощью сетки
В этом примере показано, как создать стандартную UI  диалоговое окно с помощью <xref:System.Windows.Controls.Grid> элемент.  
  
## <a name="example"></a>Пример  
 В следующем примере создается диалоговое окно, похожее **запуска** диалогового окна в Windows операционной системы.  
  
 В примере создается <xref:System.Windows.Controls.Grid> и использует <xref:System.Windows.Controls.ColumnDefinition> и <xref:System.Windows.Controls.RowDefinition> классам определять пятью столбцами и четырьмя строками.  
  
 Затем добавляет и помещает <xref:System.Windows.Controls.Image>, `RunIcon.png`, чтобы представить образ, который находится в диалоговом окне. Изображение размещается в первом столбце и строке <xref:System.Windows.Controls.Grid> (в левом верхнем углу).  
  
 Затем в примере добавляется <xref:System.Windows.Controls.TextBlock> элемент в первый столбец, который охватывает оставшиеся столбцы первой строки. Он добавляет другой <xref:System.Windows.Controls.TextBlock> элемент второй строки в первом столбце, для представления **откройте** текстовое поле. Объект <xref:System.Windows.Controls.TextBlock> с помощью которой представляет область ввода данных.  
  
 Наконец, в примере добавляется три <xref:System.Windows.Controls.Button> элементов в последнюю строку, которые представляют **ОК**, **отменить**, и **Обзор** события.  
  
 [!code-csharp[GridRunDialog#1](~/samples/snippets/csharp/VS_Snippets_Wpf/GridRunDialog/CSharp/window1.xaml.cs#1)]
   
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Controls.Grid>
- <xref:System.Windows.GridUnitType>
- [Общие сведения о панелях](panels-overview.md)
- [Практические руководства](grid-how-to-topics.md)
