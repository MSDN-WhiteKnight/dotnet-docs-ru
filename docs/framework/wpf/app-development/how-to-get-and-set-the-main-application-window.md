---
title: Практическое руководство. Получение и задание главного окна приложения
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- windows objects [WPF], setting
- setting windows objects [WPF]
- windows objects [WPF], getting
- getting windows objects [WPF]
ms.assetid: ec902bc4-4a59-46f5-8ec1-963b46789356
ms.openlocfilehash: ea8333aa82f1159afb438215940ee1e7c2605e96
ms.sourcegitcommit: 0c48191d6d641ce88d7510e319cf38c0e35697d0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/05/2019
ms.locfileid: "57373560"
---
# <a name="how-to-get-and-set-the-main-application-window"></a>Практическое руководство. Получение и задание главного окна приложения
В этом примере показано, как получение и задание главного окна приложения.  
  
## <a name="example"></a>Пример  
 Первый <xref:System.Windows.Window> , созданный в Windows Presentation Foundation (WPF) приложение автоматически задается службой <xref:System.Windows.Application> как главное окно приложения. Первый <xref:System.Windows.Window> быть вероятнее всего экземпляра будет окон, который указан как на начальный URI (см. в разделе <xref:System.Windows.Application.StartupUri%2A>).  
  
 Первый <xref:System.Windows.Window> также могут создаваться с помощью кода. Одним из примеров является открытие окна во время запуска приложения, следующим образом:  
  
 [!code-csharp[HOWTOWindowManagementSnippets#FirstWindowUsingCodeCODEBEHIND](~/samples/snippets/csharp/VS_Snippets_Wpf/HOWTOWindowManagementSnippets/CSharp/App.xaml.cs#firstwindowusingcodecodebehind)]
   
  
 В некоторых случаях первый экземпляр <xref:System.Windows.Window> является фактически не главного окна приложения, например экрана-заставки. В этом случае можно указать в главное окно приложения с помощью разметки, следующим образом:  
  
 [!code-xaml[ApplicationMainWindowSnippets#SetApplicationMainWindowXAML](~/samples/snippets/xaml/VS_Snippets_Wpf/ApplicationMainWindowSnippets/XAML/App.xaml#setapplicationmainwindowxaml)]  
  
 Ли главное окно указан, автоматически или вручную, можно получить из главного окна <xref:System.Windows.Application.MainWindow%2A> используя следующий код, как показано ниже:  
  
 [!code-csharp[ApplicationMainWindowSnippets#GetApplicationMainWindowCODE](~/samples/snippets/csharp/VS_Snippets_Wpf/ApplicationMainWindowSnippets/CSharp/App.xaml.cs#getapplicationmainwindowcode)]
 
