---
description: 'Узнайте подробнее о: Устранение неполадок: прослушиватели журнала (Visual Basic)'
title: 'Устранение неполадок: Прослушиватели журнала'
ms.date: 07/20/2015
helpviewer_keywords:
- event logs, troubleshooting
- troubleshooting Visual Basic, event logs
- troubleshooting event logs
ms.assetid: ac6eb760-3d5d-461e-aedd-40599ee22e49
ms.openlocfilehash: dc40f88a19e9cb205c6adb290c1ed48d40eabf5b
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: HT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99775049"
---
# <a name="troubleshooting-log-listeners-visual-basic"></a>Устранение неполадок, связанных с прослушивателями журнала (Visual Basic)

Объекты `My.Application.Log` и `My.Log` можно использовать для записи в журнал информации о событиях, происходящих в приложении.  
  
 Чтобы определить, какие прослушиватели журналов получают эти сообщения, см. раздел [Пошаговое руководство. Определение места записи информации для My.Application.Log](walkthrough-determining-where-my-application-log-writes-information.md).  
  
 Объект `Log` может использовать фильтрацию журнала для ограничения объема данных, регистрируемых в журнале. Если фильтры настроены неправильно, журналы могут содержать неверные данные. Дополнительные сведения см. в разделе [Пошаговое руководство. Фильтрация вывода My.Application.Log](walkthrough-filtering-my-application-log-output.md).  
  
 Однако если журнал настроен неправильно, необходима дополнительная информация о его текущей конфигурации. Эту информацию можно получить с помощью расширенного свойства журнала `TraceSource`.  
  
### <a name="to-determine-the-log-listeners-for-the-log-object-in-code"></a>Определение прослушивателей журнала для объекта Log в коде  
  
1. Импортируйте пространство имен <xref:System.Diagnostics> в начало файла кода. Дополнительные сведения см. в статье [Оператор Imports (пространство имен .NET и тип)](../../../language-reference/statements/imports-statement-net-namespace-and-type.md).  
  
     [!code-vb[VbVbalrMyApplicationLog#13](~/samples/snippets/visualbasic/VS_Snippets_VBCSharp/VbVbalrMyApplicationLog/VB/Form1.vb#13)]  
  
2. Создайте функцию, которая возвращает строку, состоящую из информации о каждом из прослушивателей журнала.  
  
     [!code-vb[VbVbalrMyApplicationLog#14](~/samples/snippets/visualbasic/VS_Snippets_VBCSharp/VbVbalrMyApplicationLog/VB/Form1.vb#14)]  
  
3. Передайте коллекцию прослушивателей журнала трассировки в функцию `GetListeners` и отобразите возвращаемое значение.  
  
     [!code-vb[VbVbalrMyApplicationLog#19](~/samples/snippets/visualbasic/VS_Snippets_VBCSharp/VbVbalrMyApplicationLog/VB/Form1.vb#19)]  
  
     Для получения дополнительной информации см. <xref:Microsoft.VisualBasic.Logging.Log.TraceSource%2A>.  
  
## <a name="see-also"></a>См. также

- <xref:Microsoft.VisualBasic.Logging.Log?displayProperty=nameWithType>
- [Работа с журналами приложения](working-with-application-logs.md)
- [Пошаговое руководство: Определение места записи сведений для My.Application.Log](walkthrough-determining-where-my-application-log-writes-information.md)
