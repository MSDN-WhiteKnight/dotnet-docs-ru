---
title: Практическое руководство. Использование словаря ресурсов области определения приложения
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- dictionaries [WPF], resource
- resource dictionaries [WPF], application-scope
- application-scope resource dictionaries
ms.assetid: 53857682-bd2c-4f2c-8f25-1307d0b451a2
ms.openlocfilehash: 589e28b3c05496e3fc17055b98240e389faed068
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59125383"
---
# <a name="how-to-use-an-application-scope-resource-dictionary"></a>Практическое руководство. Использование словаря ресурсов области определения приложения
В этом примере показано, как определить и использовать пользовательский словарь ресурсов области определения приложения.  
  
## <a name="example"></a>Пример  
 <xref:System.Windows.Application> предоставляет хранилище области приложения для общих ресурсов: <xref:System.Windows.Application.Resources%2A>. По умолчанию <xref:System.Windows.Application.Resources%2A> свойство инициализируется с помощью экземпляра <xref:System.Windows.ResourceDictionary> типа. Этот экземпляр используется при получении и установке свойств области определения приложения, с помощью <xref:System.Windows.Application.Resources%2A>. Дополнительные сведения см. в разделе [Как Получение и задание ресурсов области определения приложения](https://docs.microsoft.com/previous-versions/dotnet/netframework-4.0/aa348547(v=vs.100)).
  
 Если имеется несколько ресурсов, которые задаются с помощью <xref:System.Windows.Application.Resources%2A>, вместо этого можно использовать пользовательский словарь ресурсов для хранения этих ресурсов и задать <xref:System.Windows.Application.Resources%2A> с ним вместо этого. Ниже показано, как объявить пользовательский словарь ресурсов с помощью XAML.
  
 [!code-xaml[HOWTOResourceDictionaries#1](~/samples/snippets/csharp/VS_Snippets_Wpf/HowToResourceDictionaries/CSharp/MyResourceDictionary.xaml#1)]  
  
 Замена целых словарей ресурсов с помощью <xref:System.Windows.Application.Resources%2A> позволяет поддерживать темы области приложения, когда каждая тема инкапсулируется одним словарем ресурсов. В следующем примере показано, как задать свойство <xref:System.Windows.ResourceDictionary>.  
  
 [!code-xaml[HOWTOResourceDictionaries#2](~/samples/snippets/csharp/VS_Snippets_Wpf/HowToResourceDictionaries/CSharp/App.xaml#2)]  
  
 Далее показано, как можно получить ресурсы области приложения из словаря ресурсов, предоставляемых <xref:System.Windows.Application.Resources%2A> в XAML.  
  
 [!code-xaml[HOWTOResourceDictionaries#4](~/samples/snippets/csharp/VS_Snippets_Wpf/HowToResourceDictionaries/CSharp/MainWindow.xaml#4)]  
  
 Ниже показано, как можно получить ресурсы в коде.  
  
 [!code-csharp[HOWTOResourceDictionaries#3](~/samples/snippets/csharp/VS_Snippets_Wpf/HowToResourceDictionaries/CSharp/MainWindow.xaml.cs#3)]
   
  
 Есть две рекомендации при использовании <xref:System.Windows.Application.Resources%2A>. Во-первых, словарь *ключ* является объектом, поэтому необходимо использовать один и тот же экземпляр объекта при установке и получении значения свойства. (Обратите внимание, что при использовании строки в ключе учитывается регистр.) Во-вторых, словарь *значение* является объектом, поэтому необходимо преобразовать значение в требуемый тип при получении значения свойства.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.ResourceDictionary>
- <xref:System.Windows.Application.Resources%2A>
- [Ресурсы XAML](../advanced/xaml-resources.md)
- [Объединенные словари ресурсов](../advanced/merged-resource-dictionaries.md)
