---
title: Практическое руководство. Использование объекта ThicknessConverter
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- border thickness [WPF]
- ThicknessConverter objects [WPF]
ms.assetid: 52682194-d7fd-499c-8005-73fcc84e7b2c
ms.openlocfilehash: ebfb8642a01f6d602f4e5ffa58fde6a8ee0b4e1f
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59075955"
---
# <a name="how-to-use-a-thicknessconverter-object"></a>Практическое руководство. Использование объекта ThicknessConverter
## <a name="example"></a>Пример  
 В этом примере показано, как создать экземпляр <xref:System.Windows.ThicknessConverter> и использовать его для изменения толщины границы.  
  
 В примере определяется пользовательский метод с именем `changeThickness`; этот метод сначала преобразует содержимое <xref:System.Windows.Controls.ListBoxItem>, как определено в отдельном [!INCLUDE[TLA#tla_xaml](../../../../includes/tlasharptla-xaml-md.md)] файл, чтобы экземпляр <xref:System.Windows.Thickness>, а затем преобразует содержимое в <xref:System.String>. Этот метод передает <xref:System.Windows.Controls.ListBoxItem> для <xref:System.Windows.ThicknessConverter> объект, который преобразует <xref:System.Windows.Controls.ContentControl.Content%2A> из <xref:System.Windows.Controls.ListBoxItem> к экземпляру <xref:System.Windows.Thickness>. Это значение затем передается обратно в качестве значения <xref:System.Windows.Controls.Border.BorderThickness%2A> свойство <xref:System.Windows.Controls.Border>.  
  
 Этот пример не запускается.  
  
 [!code-csharp[ThicknessConverter#1](~/samples/snippets/csharp/VS_Snippets_Wpf/ThicknessConverter/CSharp/Window1.xaml.cs#1)]
   
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Thickness>
- <xref:System.Windows.ThicknessConverter>
- <xref:System.Windows.Controls.Border>
- [Практическое руководство. Изменить свойства полей](https://docs.microsoft.com/previous-versions/dotnet/netframework-3.5/ms750561(v=vs.90))
- [Практическое руководство. Преобразовать в новый тип данных элемента ListBoxItem](https://docs.microsoft.com/previous-versions/dotnet/netframework-3.5/ms749147(v=vs.90))
- [Общие сведения о панелях](../controls/panels-overview.md)
