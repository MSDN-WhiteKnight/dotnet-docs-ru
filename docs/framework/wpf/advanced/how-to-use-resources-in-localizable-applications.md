---
title: Практическое руководство. Использование ресурсов в локализуемых приложениях
ms.date: 03/30/2017
helpviewer_keywords:
- applications [WPF], localizable
- localizable applications [WPF]
ms.assetid: 08539ad6-7fca-4f34-b82b-ff439e11dfa7
ms.openlocfilehash: ad257e7703bcee8f71da78ad5928d7999365c38f
ms.sourcegitcommit: 0c48191d6d641ce88d7510e319cf38c0e35697d0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/05/2019
ms.locfileid: "57376169"
---
# <a name="how-to-use-resources-in-localizable-applications"></a>Практическое руководство. Использование ресурсов в локализуемых приложениях
Локализация означает адаптацию UI для разных языков и региональных параметров. Для этого необходимо перевести названия, заголовки, элементы полей со списком и т. д. Чтобы облегчить перевод, переводимые элементы записываются в файлы ресурсов. См. в разделе [локализация приложения](how-to-localize-an-application.md) сведения о том, как создать файл ресурсов для локализации. Чтобы сделать WPF локализуемым, разработчикам нужно объединить все локализуемые ресурсы в сборку ресурсов приложения. Сборка ресурсов локализуется на разные языки, и код программной части использует модуль управления ресурсами [!INCLUDE[TLA#tla_api](../../../../includes/tlasharptla-api-md.md)] для загрузки. Один из файлов, необходимых для WPF приложения — это файл проекта (.proj). Все ресурсы, используемые в приложении, необходимо включить в файл проекта. Это показано в следующем примере кода.  
  
## <a name="example"></a>Пример  
 [!INCLUDE[TLA2#tla_xaml](../../../../includes/tla2sharptla-xaml-md.md)]  
  
 `<Resource Include="data\picture1.jpg"/>`  
  
 `<EmbeddedResource Include="data\stringtable.en-US.restext"/>`  
  
 Чтобы использовать ресурс в своем приложении, следует создать <xref:System.Resources.ResourceManager> и загрузки ресурсов, которые вы хотите использовать. Ниже показано, как это сделать.  
  
 [!code-csharp[LocalizationResources#2](~/samples/snippets/csharp/VS_Snippets_Wpf/LocalizationResources/CSharp/page1.xaml.cs#2)]
