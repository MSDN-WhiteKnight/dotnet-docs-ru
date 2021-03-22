---
title: Практическое руководство. Получение элемента ListBoxItem
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- ListBox controls [WPF], getting a ListBoxItem
- ListBoxItem [WPF]
ms.assetid: da877c6f-5fd8-40cb-8909-225cbfd99aa5
ms.openlocfilehash: 27a435feb4a941c77af221ab25bd63ea98b16e92
ms.sourcegitcommit: 0c48191d6d641ce88d7510e319cf38c0e35697d0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/05/2019
ms.locfileid: "57360502"
---
# <a name="how-to-get-a-listboxitem"></a>Практическое руководство. Получение элемента ListBoxItem
Если вам нужно получить определенный <xref:System.Windows.Controls.ListBoxItem> с определенного индекса в <xref:System.Windows.Controls.ListBox>, можно использовать <xref:System.Windows.Controls.ItemContainerGenerator>.  
  
## <a name="example"></a>Пример  
 В следующем примере показан <xref:System.Windows.Controls.ListBox> и ее элементов.  
  
 [!code-xaml[ListBoxItems#1](~/samples/snippets/csharp/VS_Snippets_Wpf/ListBoxItems/CSharp/Window1.xaml#1)]  
  
 Приведенный ниже показано, как способ получения элемента путем указания индекс элемента в <xref:System.Windows.Controls.ItemContainerGenerator.ContainerFromIndex%2A> свойство <xref:System.Windows.Controls.ItemContainerGenerator>.  
  
 [!code-csharp[ListBoxItems#2](~/samples/snippets/csharp/VS_Snippets_Wpf/ListBoxItems/CSharp/Window1.xaml.cs#2)]
   
  
 После извлечения элемента списка, можно отобразить содержимое элемента, как показано в следующем примере.  
  
 [!code-csharp[ListBoxItems#3](~/samples/snippets/csharp/VS_Snippets_Wpf/ListBoxItems/CSharp/Window1.xaml.cs#3)]
 
