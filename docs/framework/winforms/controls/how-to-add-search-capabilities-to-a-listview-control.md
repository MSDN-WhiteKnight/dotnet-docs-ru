---
title: Практическое руководство. Добавление в элемент управления ListView возможностей поиска
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- lists [Windows Forms], enabling searching
- list views [Windows Forms], enabling searching
- ListView control [Windows Forms], adding search capabilities
- searching [Windows Forms], adding search capabilities to ListView control
ms.assetid: 557782d9-b705-4bab-b496-9938afddac82
ms.openlocfilehash: d5d4dae55fc9f0613ab6535b2fe57e262d0ef141
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59314026"
---
# <a name="how-to-add-search-capabilities-to-a-listview-control"></a>Практическое руководство. Добавление в элемент управления ListView возможностей поиска
Иногда при работе с большой список элементов в <xref:System.Windows.Forms.ListView> элемента управления, необходимо предоставить пользователям возможности поиска. <xref:System.Windows.Forms.ListView> Управления обеспечивает такую функцию двумя разными способами: совпадений текста и поиск расположения.  
  
 <xref:System.Windows.Forms.ListView.FindItemWithText%2A> Метод позволяет выполнять поиск текста на <xref:System.Windows.Forms.ListView> в представлении списка или подробных сведений, учитывая строку поиска и необязательного начального и конечного индекса. Напротив <xref:System.Windows.Forms.ListView.FindNearestItem%2A> метод позволяет находить элементы в <xref:System.Windows.Forms.ListView> в представлении значок или элемент, определенный набор координат x и y и направление для поиска.  
  
### <a name="to-find-an-item-using-text"></a>Чтобы найти элемент с использованием текста  
  
1. Создание <xref:System.Windows.Forms.ListView> с <xref:System.Windows.Forms.ListView.View%2A> свойству присвоено <xref:System.Windows.Forms.View.Details> или <xref:System.Windows.Forms.View.List>, а затем заполнить <xref:System.Windows.Forms.ListView> с элементами.  
  
2. Вызовите <xref:System.Windows.Forms.ListView.FindItemWithText%2A> , передавая текст элемента, который вы хотите найти.  
  
3. В следующем примере кода показано, как создать простую <xref:System.Windows.Forms.ListView>, заполнить его элементами и использовать введенный текст от пользователя для поиска элемента в списке.  
  
 [!code-cpp[System.Windows.Forms.ListViewFindItems#1](~/samples/snippets/cpp/VS_Snippets_Winforms/System.Windows.Forms.ListViewFindItems/cpp/form1.cpp#1)]
 [!code-csharp[System.Windows.Forms.ListViewFindItems#1](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.ListViewFindItems/CS/form1.cs#1)]
 [!code-vb[System.Windows.Forms.ListViewFindItems#1](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Windows.Forms.ListViewFindItems/VB/form1.vb#1)]  
  
### <a name="to-find-an-item-using-x--and-y-coordinates"></a>Чтобы найти элемент с помощью координат x и y  
  
1. Создание <xref:System.Windows.Forms.ListView> с <xref:System.Windows.Forms.View> свойству присвоено <xref:System.Windows.Forms.View.SmallIcon> или <xref:System.Windows.Forms.View.LargeIcon>, а затем заполнить <xref:System.Windows.Forms.ListView> с элементами.  
  
2. Вызовите <xref:System.Windows.Forms.ListView.FindNearestItem%2A> , передавая нужные координаты x и y- и направление, нужно выполнить поиск.  
  
3. В следующем примере кода показано, как создать базовый значков <xref:System.Windows.Forms.ListView>, заполнить его элементами и захватите <xref:System.Windows.Forms.Control.MouseDown> событий для поиска ближайшего элемента по оси вверх.  
  
 [!code-cpp[System.Windows.Forms.ListViewFindItems#2](~/samples/snippets/cpp/VS_Snippets_Winforms/System.Windows.Forms.ListViewFindItems/cpp/form1.cpp#2)]
 [!code-csharp[System.Windows.Forms.ListViewFindItems#2](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.ListViewFindItems/CS/form1.cs#2)]
 [!code-vb[System.Windows.Forms.ListViewFindItems#2](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Windows.Forms.ListViewFindItems/VB/form1.vb#2)]  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.ListView>
- <xref:System.Windows.Forms.ListView.FindItemWithText%2A>
- <xref:System.Windows.Forms.ListView.FindNearestItem%2A>
- [Элемент управления ListView](listview-control-windows-forms.md)
- [Общие сведения об элементе управления ListView](listview-control-overview-windows-forms.md)
- [Практическое руководство. Добавление и удаление элементов с помощью элемента управления ListView в Windows Forms](how-to-add-and-remove-items-with-the-windows-forms-listview-control.md)
