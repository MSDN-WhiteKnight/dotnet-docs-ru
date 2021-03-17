---
title: Использование элементов управления WPF
ms.date: 03/30/2017
helpviewer_keywords:
- Windows Forms Designer [Windows Forms], interoperability with WPF
- interoperability [WPF]
ms.assetid: 03c85dce-26ad-44cd-bc1d-8e0cb56de096
ms.openlocfilehash: 24b88e456628c5a0bdc3cded60b0e52a92057851
ms.sourcegitcommit: 160a88c8087b0e63606e6e35f9bd57fa5f69c168
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/09/2019
ms.locfileid: "57713804"
---
# <a name="using-wpf-controls"></a>Использование элементов управления WPF
Элементы управления Windows Presentation Foundation (WPF) можно использовать в приложениях Windows Forms. Несмотря на то, что они являются две различные технологии, они взаимодействуют.  
  
 В конструкторе Windows Forms предоставляет среду визуальной разработки для размещения элементов управления Windows Presentation Foundation. Элемент управления WPF размещается в специальный элемент управления Windows Forms с именем <xref:System.Windows.Forms.Integration.ElementHost>. Этот элемент управления включает элемент управления WPF в участвуют в макете формы и получать сообщения клавиатуры и мыши. Во время разработки, можно упорядочить <xref:System.Windows.Forms.Integration.ElementHost> управления так же, как и любой элемент управления Windows Forms.  
  
 Можно также использовать элементы управления Windows Forms в WPF-приложениях. Дополнительные сведения см. в разделе [конструктора XAML в Visual Studio](/visualstudio/designers/designing-xaml-in-visual-studio).  
  
## <a name="in-this-section"></a>В этом разделе  
 [Практическое руководство. Копирование и вставка элемента управления ElementHost во время разработки](how-to-copy-and-paste-an-elementhost-control-at-design-time.md)  
 Показано, как скопировать элемент управления Windows Presentation Foundation в Windows Forms.  
  
 [Пошаговое руководство: Упорядочение содержимого WPF в формах Windows Forms во время разработки](walkthrough-arranging-wpf-content-on-windows-forms-at-design-time.md)  
 Показано, как использовать возможности макета Windows Forms, такие как закрепление и линии привязки, для размещения элементов управления Windows Presentation Foundation.
  
 [Пошаговое руководство: Создание нового содержимого WPF в формах Windows Forms во время разработки](walkthrough-creating-new-wpf-content-on-windows-forms-at-design-time.md)  
 В этой статье демонстрируется создание элемента управления Windows Presentation Foundation для использования в приложениях Windows Forms.
  
 [Пошаговое руководство: Назначение содержимого WPF в формах Windows Forms во время разработки](walkthrough-assigning-wpf-content-on-windows-forms-at-design-time.md)  
 Показано, как выбрать типы элементов управления Windows Presentation Foundation, который будет отображаться в форме.  
  
 [Пошаговое руководство: Применение стилей к содержимому WPF](walkthrough-styling-wpf-content.md)  
 Показывает рабочий процесс между в конструкторе Windows Forms и [!INCLUDE[wpfdesigner_current_short](../../../../includes/wpfdesigner-current-short-md.md)] применения стилей к элементам управления Windows Presentation Foundation.  
  
## <a name="reference"></a>Ссылка  
 <xref:System.Windows.Forms.Integration.ElementHost>  
 Описывает класс, который можно использовать для размещения элементов управления Windows Presentation Foundation в приложениях Windows Forms.  
  
 <xref:System.Windows.Forms.Integration.WindowsFormsHost>  
 Описывает класс, который можно использовать для размещения элементов управления Windows Forms в приложении Windows Presentation Foundation.  
  
## <a name="related-sections"></a>Связанные разделы  
 [Миграция и взаимодействие систем](../../wpf/advanced/migration-and-interoperability.md)  
 Содержит описание взаимодействия между технологиями Windows Presentation Foundation и Windows Forms.  
  
 [Проектирование XAML в Visual Studio](/visualstudio/designers/designing-xaml-in-visual-studio)  
 Инструкции по разработке элементов управления Windows Presentation Foundation в Visual Studio.
