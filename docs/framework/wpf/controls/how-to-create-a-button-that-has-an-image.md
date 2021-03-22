---
title: Практическое руководство. Создание кнопки, содержащей изображение
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- Button controls [WPF], creating
ms.assetid: 607a193c-4098-4dd8-8dc0-51256cec2020
ms.openlocfilehash: 5be928ac75ad727feabcde07ac0c6dc76ed130e6
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59120727"
---
# <a name="how-to-create-a-button-that-has-an-image"></a>Практическое руководство. Создание кнопки, содержащей изображение
В этом примере показано, как включить изображение в <xref:System.Windows.Controls.Button>.  
  
## <a name="example"></a>Пример  
 В следующем примере создается два <xref:System.Windows.Controls.Button> элементов управления. Один <xref:System.Windows.Controls.Button> содержит текст, а другой образ. Изображение находится в папке Data, которая является подпапкой папки проекта в примере. Когда пользователь щелкает <xref:System.Windows.Controls.Button> имеет изображения, фон и текст другого <xref:System.Windows.Controls.Button> изменить.  
  
 В этом примере создается <xref:System.Windows.Controls.Button> элементы управления с помощью разметки, но использует код для записи <xref:System.Windows.Controls.Primitives.ButtonBase.Click> обработчики событий.  
  
 [!code-xaml[BtnColor#4](~/samples/snippets/csharp/VS_Snippets_Wpf/BtnColor/CSharp/Pane1.xaml#4)]  
  
 [!code-csharp[BtnColor#6](~/samples/snippets/csharp/VS_Snippets_Wpf/BtnColor/CSharp/Pane1.xaml.cs#6)]
   
  
## <a name="see-also"></a>См. также

- [Элементы управления](index.md)
- [Библиотека элементов управления](control-library.md)
