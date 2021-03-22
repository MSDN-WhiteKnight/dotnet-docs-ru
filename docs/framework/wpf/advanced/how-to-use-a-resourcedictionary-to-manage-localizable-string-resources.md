---
title: Практическое руководство. Использование ResourceDictionary для управления локализуемыми строковыми ресурсами
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- resources [WPF], packaging string resources
- packaging string resources [WPF]
- ResourceDictionary [WPF]
- localization [WPF], packaging string resources
ms.assetid: 19e7d9a5-20df-4ad3-b157-fe6515902e5e
ms.openlocfilehash: b56a307ed31fc8f7573215eac70350ac5e4b9de1
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59311322"
---
# <a name="how-to-use-a-resourcedictionary-to-manage-localizable-string-resources"></a>Практическое руководство. Использование ResourceDictionary для управления локализуемыми строковыми ресурсами
В этом примере показано, как использовать <xref:System.Windows.ResourceDictionary> для пакетов локализуемых строковых ресурсов для приложений Windows Presentation Foundation (WPF).  
  
### <a name="to-use-a-resourcedictionary-to-manage-localizable-string-resources"></a>Использование ResourceDictionary для управления локализуемыми строковыми ресурсами  
  
1. Создание <xref:System.Windows.ResourceDictionary> , содержащую строки, чтобы локализовать. Вот пример кода:  
  
     [!code-xaml[StringLocalizationSample#StringResourceDictionary](~/samples/snippets/csharp/VS_Snippets_Wpf/StringLocalizationSample/CSharp/StringResources.xaml#stringresourcedictionary)]  
  
     Этот код определяет строковый ресурс, `localizedMessage`, типа <xref:System.String>, из <xref:System> пространства имен в библиотеке mscorlib.dll.  
  
2. Добавление <xref:System.Windows.ResourceDictionary> для вашего приложения, используя следующий код.  
  
     [!code-xaml[StringLocalizationSample#ReferencingStringResourceDictionary](~/samples/snippets/csharp/VS_Snippets_Wpf/StringLocalizationSample/CSharp/App.xaml#referencingstringresourcedictionary)]  
  
3. Используйте строковый ресурс из разметки, используя [!INCLUDE[TLA#tla_xaml](../../../../includes/tlasharptla-xaml-md.md)] следующим образом.  
  
     [!code-xaml[StringLocalizationSample#GetLocalizedResourceFromMarkup](~/samples/snippets/csharp/VS_Snippets_Wpf/StringLocalizationSample/CSharp/MainWindow.xaml#getlocalizedresourcefrommarkup)]  
  
4. Используйте строковый ресурс из файла кода программной части с помощью следующего кода:  
  
     [!code-csharp[StringLocalizationSample#GetLocalizedResourceFromCode](~/samples/snippets/csharp/VS_Snippets_Wpf/StringLocalizationSample/CSharp/MainWindow.xaml.cs#getlocalizedresourcefromcode)]
       
  
5. Локализуйте приложение. Дополнительные сведения см. в разделе [локализация приложения](how-to-localize-an-application.md).
