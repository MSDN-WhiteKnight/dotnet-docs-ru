---
title: Практическое руководство. Удаление декоративного объекта из элемента
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- adorners [WPF], removing
ms.assetid: 97cf4d9f-0596-429e-8526-32a30aa4ae99
ms.openlocfilehash: 256dd6fa0117f88aec2ef6b60c6dcd4c33b57855
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59212405"
---
# <a name="how-to-remove-an-adorner-from-an-element"></a>Практическое руководство. Удаление декоративного объекта из элемента
В этом примере показано, как программными средствами удалить определенный декоративный элемент из указанного <xref:System.Windows.UIElement>.  
  
## <a name="example"></a>Пример  
 Этот подробный пример кода удаляет первый декоративный элемент в массиве декоративных элементов, возвращенных <xref:System.Windows.Documents.AdornerLayer.GetAdorners%2A>.  В этом примере происходит с графические <xref:System.Windows.UIElement> с именем *myTextBox*.  Если этот элемент указан в вызове <xref:System.Windows.Documents.AdornerLayer.GetAdorners%2A> нет графических объектов, `null` возвращается.  Этот код явно проверяет пустой массив и лучше всего подходит для приложений, где должен быть относительно распространенную пустой массив.  
  
 [!code-csharp[AdornersMiscCode#_RemoveSpecificAdornerLong](~/samples/snippets/csharp/VS_Snippets_Wpf/AdornersMiscCode/CSharp/Window1.xaml.cs#_removespecificadornerlong)]
 [!code-vb[AdornersMiscCode#_RemoveSpecificAdornerLong](~/samples/snippets/visualbasic/VS_Snippets_Wpf/AdornersMiscCode/visualbasic/window1.xaml.vb#_removespecificadornerlong)]  
  
## <a name="example"></a>Пример  
 Данный сжатый пример кода функционально эквивалентен подробному примеру, приведенному выше. Этот код явно не проверяет пустой массив, так что вполне возможно, <xref:System.NullReferenceException> может быть вызвано исключение.  Этот код лучше всего подходит для приложений, где ожидается пустой массив довольно редки.  
  
 [!code-csharp[AdornersMiscCode#_RemoveSpecificAdornerShort](~/samples/snippets/csharp/VS_Snippets_Wpf/AdornersMiscCode/CSharp/Window1.xaml.cs#_removespecificadornershort)]
 [!code-vb[AdornersMiscCode#_RemoveSpecificAdornerShort](~/samples/snippets/visualbasic/VS_Snippets_Wpf/AdornersMiscCode/visualbasic/window1.xaml.vb#_removespecificadornershort)]  
  
## <a name="see-also"></a>См. также

- [Общие сведения о декоративных элементах](adorners-overview.md)
