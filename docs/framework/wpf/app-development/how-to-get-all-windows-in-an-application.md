---
title: Практическое руководство. Получение всех Windows в приложении
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- window objects [WPF], getting
ms.assetid: f120f06e-993b-4a97-9657-af0d1986981f
ms.openlocfilehash: 34316f0c6f81b960a8e00131a30b9a237b9ca938
ms.sourcegitcommit: 0c48191d6d641ce88d7510e319cf38c0e35697d0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/05/2019
ms.locfileid: "57378843"
---
# <a name="how-to-get-all-windows-in-an-application"></a>Практическое руководство. Получение всех Windows в приложении
В этом примере показано, как получить все <xref:System.Windows.Window> объектов в приложении.  
  
## <a name="example"></a>Пример  
 Каждый экземпляр <xref:System.Windows.Window> объекта, является ли видимым или нет, автоматически добавляется в коллекцию ссылок на окно, управляется <xref:System.Windows.Application>и предоставлять их из <xref:System.Windows.Application.Windows%2A>.  
  
 Вы можете перечислить <xref:System.Windows.Application.Windows%2A> получить все экземпляры windows, используя следующий код:  
  
 [!code-csharp[HOWTOWindowManagementSnippets#GetAllWindows](~/samples/snippets/csharp/VS_Snippets_Wpf/HOWTOWindowManagementSnippets/CSharp/CustomWindow.xaml.cs#getallwindows)]
 
