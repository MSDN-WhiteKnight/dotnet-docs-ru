---
title: Практическое руководство. Сохранение и восстановление свойств области определения приложения в сеансах приложения
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- application-scope properties [WPF], persisting
- persisting application-scope properties [WPF]
- properties [WPF], persisting
- restoring application-scope properties [WPF]
- properties [WPF], restoring
- application-scope properties [WPF], restoring
ms.assetid: 55d5904a-f444-4eb5-abd3-6bc74dd14226
ms.openlocfilehash: 99b04060d4e7c14313655010dc4fbd5ce1c90487
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59134957"
---
# <a name="how-to-persist-and-restore-application-scope-properties-across-application-sessions"></a>Практическое руководство. Сохранение и восстановление свойств области определения приложения в сеансах приложения
В этом примере показано, как для сохранения свойств области приложения при завершении работы приложения и восстановление свойств области приложения, когда приложение следующего запуска.  
  
## <a name="example"></a>Пример  
 Приложение сохраняет свойства области определения приложения для и восстанавливает их из изолированного хранилища. Изолированное хранилище — это область защищенного хранилища, может безопасно использоваться приложениями без разрешения доступа к файлу.  *App.xaml* файл определяет `App_Startup` метода как обработчика для <xref:System.Windows.Application.Startup?displayProperty=nameWithType> событий и `App_Exit` метода как обработчика для <xref:System.Windows.Application.Exit?displayProperty=nameWithType> событий, как показано на выделенные строки из первого примера. Во втором примере показана часть *App.xaml.cs* и *App.xaml.vb* файлы, которые выделяет код `App_Startup` метод, который восстанавливает свойств области приложения и `App_Exit` метод, который сохраняет свойств области приложения.

 [!code-xaml[HOWTOApplicationModelSnippets#PersistRestoreAppScopePropertiesXAML1](~/samples/snippets/csharp/VS_Snippets_Wpf/HOWTOApplicationModelSnippets/CSharp/App.xaml?highlight=1-7)]
  
 [!code-csharp[HOWTOApplicationModelSnippets#PersistRestoreAppScopePropertiesCODEBEHIND1](~/samples/snippets/csharp/VS_Snippets_Wpf/HOWTOApplicationModelSnippets/CSharp/App.xaml.cs?highlight=17-55)]
 
