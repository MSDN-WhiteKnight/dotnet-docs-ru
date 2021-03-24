---
title: Практическое руководство. Настройка уведомлений обновлений привязок
ms.date: 03/30/2017
helpviewer_keywords:
- notifications [WPF], binding updates
- data binding [WPF], notification of binding updates
- binding [WPF], updates [WPF], notifications of
ms.assetid: 5673073e-dbe1-49da-980a-484a88f9595a
ms.openlocfilehash: 4185198312ed98f9aaa1388626600d9f21abae55
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59213966"
---
# <a name="how-to-set-up-notification-of-binding-updates"></a>Практическое руководство. Настройка уведомлений обновлений привязок
В этом примере показано, как настроить уведомления об обновлении свойства цели привязки (целевой) или источника привязки (источник) для привязки.  
  
## <a name="example"></a>Пример  
 Windows Presentation Foundation (WPF) вызывает событие обновления данных каждый раз, что была обновлена источника или цели привязки. Внутри системы это событие используется для информирования [!INCLUDE[TLA#tla_ui](../../../../includes/tlasharptla-ui-md.md)], что он должен быть обновлен, поскольку связанные данные были изменены. Обратите внимание, что для работы этих событий, а также для односторонняя или двусторонняя привязка работала правильно, необходимо реализовать класс данных с помощью <xref:System.ComponentModel.INotifyPropertyChanged> интерфейс. Дополнительные сведения см. в разделе [Реализация уведомления об изменении свойств](how-to-implement-property-change-notification.md).  
  
 Задайте <xref:System.Windows.Data.Binding.NotifyOnTargetUpdated%2A> или <xref:System.Windows.Data.Binding.NotifyOnSourceUpdated%2A> (или оба) для `true` в привязке. Обработчик, который предоставляется для ожидания данного события, должен быть подключен непосредственно к элементу, где вы хотите получать сведения об изменениях, или к контексту общих данных, чтобы получить информацию о любом изменении в контексте.  
  
 Ниже приведен пример, в котором показано, как настроить уведомления при обновлении свойства цели привязки.  
  
 [!code-xaml[DirectionalBinding#2](~/samples/snippets/csharp/VS_Snippets_Wpf/DirectionalBinding/CSharp/Page1.xaml#2)]  
  
 Затем можно назначить обработчик, основанный на делегате EventHandler\<T>, в этом примере *OnTargetUpdated*, для обработки события:  
  
 [!code-csharp[DirectionalBinding#3](~/samples/snippets/csharp/VS_Snippets_Wpf/DirectionalBinding/CSharp/Page1.xaml.cs#3)]  
[!code-csharp[DirectionalBinding#EndEvent](~/samples/snippets/csharp/VS_Snippets_Wpf/DirectionalBinding/CSharp/Page1.xaml.cs#endevent)]  
  
 Параметры события можно использовать для задания сведений об измененном свойстве (например, типа или конкретного элемента, если один обработчик подключен к нескольким элементам), что может оказаться полезным в том случае, если существует несколько связанных свойств для одного элемента.  
  
## <a name="see-also"></a>См. также

- [Общие сведения о привязке данных](data-binding-overview.md)
- [Практические руководства](data-binding-how-to-topics.md)
