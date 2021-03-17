---
title: Практическое руководство. Добавление данных пользователя в данные рукописного ввода
ms.date: 03/30/2017
helpviewer_keywords:
- ink data [WPF], adding custom data
- InkCanvas [WPF], displaying
ms.assetid: f02aac6f-3436-4f7c-b6ea-0452cba5332c
ms.openlocfilehash: c524e30943a21426e2e5e8fe6ae009999924fead
ms.sourcegitcommit: 0c48191d6d641ce88d7510e319cf38c0e35697d0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/05/2019
ms.locfileid: "57361672"
---
# <a name="how-to-add-custom-data-to-ink-data"></a>Практическое руководство. Добавление данных пользователя в данные рукописного ввода
Можно добавить пользовательские данные для рукописного ввода, который будет сохранен при сохранении рукописного ввода в форме рукописного ввода сериализации формат ISF.  Можно сохранить пользовательские данные для <xref:System.Windows.Ink.DrawingAttributes>, <xref:System.Windows.Ink.StrokeCollection>, или <xref:System.Windows.Ink.Stroke>.  Возможность сохранить пользовательские данные в трех объектов дает возможность выбрать лучшее место для сохранения данных.  Все три класса используйте аналогичные методы для хранения и доступа к пользовательским данным.  
  
 Как пользовательские данные могут сохраняться только следующие типы:  
  
-   <xref:System.Boolean>  
  
-   <xref:System.Boolean>[]  
  
-   <xref:System.Byte>  
  
-   <xref:System.Byte>[]  
  
-   <xref:System.Char>  
  
-   <xref:System.Char>[]  
  
-   <xref:System.DateTime>  
  
-   <xref:System.DateTime>[]  
  
-   <xref:System.Decimal>  
  
-   <xref:System.Decimal>[]  
  
-   <xref:System.Double>  
  
-   <xref:System.Double>[]  
  
-   <xref:System.Int16>  
  
-   <xref:System.Int16>[]  
  
-   <xref:System.Int32>  
  
-   <xref:System.Int32>[]  
  
-   <xref:System.Int64>  
  
-   <xref:System.Int64>[]  
  
-   <xref:System.Single>  
  
-   <xref:System.Single>[]  
  
-   <xref:System.String>  
  
-   <xref:System.UInt16>  
  
-   <xref:System.UInt16>[]  
  
-   <xref:System.UInt32>  
  
-   <xref:System.UInt32>[]  
  
-   <xref:System.UInt64>  
  
-   <xref:System.UInt64>[]  
  
## <a name="example"></a>Пример  
 Следующий пример демонстрирует добавление и извлечение пользовательских данных из <xref:System.Windows.Ink.StrokeCollection>.  
  
 [!code-csharp[HowToAddCustomDataToInk#1](~/samples/snippets/csharp/VS_Snippets_Wpf/HowToAddCustomDataToInk/CSharp/Window1.xaml.cs#1)]  
  
 В следующем примере создается приложение, отображающее <xref:System.Windows.Controls.InkCanvas> и две кнопки.  Кнопки, `switchAuthor`, позволяет использовать два разных авторов два пера.  Кнопки `changePenColors` изменяет цвет всех рукописных на <xref:System.Windows.Controls.InkCanvas> в соответствии с автором.  Приложение определяет два <xref:System.Windows.Ink.DrawingAttributes> объектов и добавляет пользовательское свойство для каждого из них, указывающее, какой автор рисовал <xref:System.Windows.Ink.Stroke>.  Когда пользователь щелкает `changePenColors`, приложение не меняет внешний вид штриха в соответствии с значением настраиваемого свойства.  
  
 [!code-xaml[HowToAddCustomDataToInk#2](~/samples/snippets/csharp/VS_Snippets_Wpf/HowToAddCustomDataToInk/CSharp/Window1.xaml#2)]  
  
 [!code-csharp[HowToAddCustomDataToInk#3](~/samples/snippets/csharp/VS_Snippets_Wpf/HowToAddCustomDataToInk/CSharp/Window1.xaml.cs#3)]
