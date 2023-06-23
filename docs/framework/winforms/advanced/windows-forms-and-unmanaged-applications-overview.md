---
title: Общие сведения о Windows Forms и неуправляемых приложениях
ms.date: 03/30/2017
helpviewer_keywords:
- COM [Windows Forms]
- Windows Forms, unmanaged
- COM interop
- ActiveX controls [Windows Forms], about ActiveX controls
- Windows Forms, interop
ms.assetid: 0a26d99d-8135-4895-8760-c9a2b5f67f14
ms.openlocfilehash: 63631378911a9ba95713e68fb19d8d08176c7562
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59195648"
---
# <a name="windows-forms-and-unmanaged-applications-overview"></a>Общие сведения о Windows Forms и неуправляемых приложениях
Приложения и элементы управления Windows Forms могут взаимодействовать с неуправляемыми приложениями, но с некоторыми оговорками. В следующих разделах описываются сценарии и конфигурации, которые поддерживаются и не поддерживаются элементами управления и приложениями Windows Forms.  
  
## <a name="windows-forms-controls-and-activex-applications"></a>Элементы управления Windows Forms и приложения ActiveX  
 За исключением Microsoft Internet Explorer и Microsoft Foundation Classes (MFC), элементы управления Windows Forms не поддерживаются в приложениях, предназначенных для размещения элементов управления ActiveX. Другие приложения и средства разработки, способные размещать элементы управления ActiveX, включая контейнеры для тестирования ActiveX из версий Visual Studio, предшествующих Visual Studio .NET 2003, не поддерживают размещение элементов управления Windows Forms.  
  
 Эти ограничения также применимы к использованию элементов управления Windows Forms посредством COM-взаимодействия. Использование элемента управления Windows Forms с помощью вызываемой оболочки COM (CCW) поддерживается только в Internet Explorer. Подробнее о COM-взаимодействии см. в разделе  
  
 [COM Interop](../../../visual-basic/programming-guide/com-interop/index.md).  
  
 В таблице ниже показаны доступные средства размещения ActiveX для элементов управления Windows Forms.  
  
|Версия Windows Forms|Поддержка|  
|---------------------------|-------------|  
|.NET Framework 1.0|Internet Explorer 5.01 и более поздние версии|  
|.NET Framework 1.1 и более поздние версии|Internet Explorer 5.01 и более поздние версии<br /><br /> Microsoft Foundation Classes (MFC) 7.0 и более поздние версии|  
  
## <a name="hosting-windows-forms-components-as-activex-controls"></a>Размещение компонентов Windows Forms в качестве элементов управления ActiveX  
 В .NET Framework 1.1 поддержка была расширена для включения MFC 7.0 и более поздних версий. Эта поддержка включает в себя любой контейнер, полностью совместимый с MFC 7.0 или с более поздней версией контейнера элементов управления ActiveX.  
  
 Однако регистрация элементов управления Windows Forms как элементов управления ActiveX не поддерживается. Также не поддерживается вызов метода `com.ms.win32.Ole32.CoCreateInstance` для элементов управления Windows Forms. Поддерживается только управляемая активация элементов управления Windows Forms. После создания элемента управления Windows Forms его можно размещать в приложении MFC так же, как элемент управления ActiveX.  
  
 Чтобы использовать элементы управления Windows Forms в неуправляемом приложении, необходимо либо разместить среду CLR с помощью неуправляемых интерфейсов API размещения среды CLR, либо использовать возможности взаимодействия C++. Рекомендуемым решением является использование возможностей взаимодействия C++.  
  
## <a name="windows-forms-in-com-client-applications"></a>Windows Forms в клиентских приложениях COM  
 При открытии формы Windows Forms из клиентского приложения COM, такого как приложение Visual Basic 6.0 или приложение MFC, форма может вести себя не так, как ожидается. Например, при нажатии клавиши TAB фокус не переходит от одного элемента управления к другому. При нажатии клавиши ВВОД, если фокус установлен на кнопке, событие кнопки <xref:System.Windows.Forms.Control.Click> не возникает. Также может наблюдаться и другое неожиданное поведение при нажатии клавиш или действиях мышью.  
  
 Это происходит из-за того, что неуправляемое приложение не реализует поддержку цикла обработки сообщений, которая необходима для правильной работы формы Windows Forms. Цикл обработки сообщений, реализуемый в клиентском приложении COM, существенно отличается от цикла обработки сообщений Windows Forms.  
  
 Цикл обработки сообщений приложения является внутренним циклом программы, который получает сообщения из очереди сообщений потока, преобразует их и отправляет приложению для обработки. Архитектура цикла обработки сообщений для формы Windows Forms отличается от архитектуры, используемой в более ранних приложениях, таких как приложения Visual Basic 6.0 и приложения MFC. Сообщения окна, которые отправляются в цикл обработки сообщений, могут обрабатываться не так, как ожидает форма Windows Forms. Таким образом, может наблюдаться неожиданное поведение. Могут не работать некоторые сочетания клавиш и некоторые действия мыши, а также могут не возникать некоторые события.  
  
## <a name="resolving-interoperability-issues"></a>Устранение проблем взаимодействия  
 Эти проблемы можно устранить путем отображения формы в цикле обработки сообщений .NET Framework , который создается с помощью метода <xref:System.Windows.Forms.Application.Run%2A?displayProperty=nameWithType> .  
  
 Чтобы исправить работу формы Windows Forms из клиентского приложения COM, необходимо запустить его в цикле обработки сообщений Windows Forms. Для этого воспользуйтесь одним из перечисленных ниже подходов.  
  
-   Используйте метод <xref:System.Windows.Forms.Form.ShowDialog%2A?displayProperty=nameWithType> для отображения Windows Form. Дополнительные сведения см. в разделе [Как Поддержка COM-взаимодействия путем отображения формы Windows Forms с помощью метода ShowDialog](com-interop-by-displaying-a-windows-form-shadow.md).  
  
-   Запускайте каждую форму Windows Forms в новом потоке. Дополнительные сведения см. в разделе [Как Поддержка COM-взаимодействия путем отображения каждой формы Windows Forms в отдельном потоке](how-to-support-com-interop-by-displaying-each-windows-form-on-its-own-thread.md).  
  
## <a name="see-also"></a>См. также

- [Windows Forms и неуправляемые приложения](windows-forms-and-unmanaged-applications.md)
- [COM-взаимодействие](../../../visual-basic/programming-guide/com-interop/index.md)
- [COM-взаимодействие в приложениях .NET Framework](../../../visual-basic/programming-guide/com-interop/com-interoperability-in-net-framework-applications.md)
- [Примеры COM-взаимодействия](https://docs.microsoft.com/previous-versions/visualstudio/visual-studio-2008/cxcz83xf(v=vs.90))
- [Aximp.exe (программа импорта элементов ActiveX форм Windows)](../../tools/aximp-exe-windows-forms-activex-control-importer.md)
- [Предоставление COM-клиентам доступа к компонентам .NET Framework](../../interop/exposing-dotnet-components-to-com.md)
- [Упаковка сборки для модели COM](../../interop/packaging-an-assembly-for-com.md)
- [Регистрация сборок в COM](../../interop/registering-assemblies-with-com.md)
- [Практическое руководство. Обеспечение поддержки COM-взаимодействия путем отображения формы Windows Forms с помощью метода ShowDialog](com-interop-by-displaying-a-windows-form-shadow.md)
- [Практическое руководство. Поддержка COM-взаимодействия путем отображения каждой формы Windows Forms в отдельном потоке](how-to-support-com-interop-by-displaying-each-windows-form-on-its-own-thread.md)
