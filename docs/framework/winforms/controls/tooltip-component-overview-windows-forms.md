---
title: Общие сведения о компоненте ToolTip (Windows Forms)
ms.date: 03/30/2017
f1_keywords:
- ToolTip
helpviewer_keywords:
- tooltips [Windows Forms], about tooltips
- ToolTip component [Windows Forms], about ToolTip component
ms.assetid: 3fbc6f08-c882-4acd-a960-a08efe3c7e6e
ms.openlocfilehash: 3fbe883501d1ce36ca25ea07631f98042f451e07
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59197312"
---
# <a name="tooltip-component-overview-windows-forms"></a>Общие сведения о компоненте ToolTip (Windows Forms)
Компонент <xref:System.Windows.Forms.ToolTip> в Windows Forms отображает текст при наведении указателя мыши на элементы управления. Компонент ToolTip можно связать с любым элементом управления. Пример использования этого компонента: для экономии места в форме, Отображение маленького значка на кнопке и использовать компонент ToolTip для объяснения ее функции.  
  
## <a name="working-with-the-tooltip-component"></a>Работа с компонентом ToolTip  
 Объект <xref:System.Windows.Forms.ToolTip> компонент предоставляет `ToolTip` свойства для нескольких элементов управления в форму Windows или другой контейнер. Например, если одна помещается <xref:System.Windows.Forms.ToolTip> компонент на форме, можно отобразить «Введите название своей» для <xref:System.Windows.Forms.TextBox> управления и «Щелкните здесь, чтобы сохранить изменения» для <xref:System.Windows.Forms.Button> элемента управления.  
  
 Основные методы класса <xref:System.Windows.Forms.ToolTip> компонент <xref:System.Windows.Forms.ToolTip.SetToolTip%2A> и <xref:System.Windows.Forms.ToolTip.GetToolTip%2A>. Можно использовать <xref:System.Windows.Forms.ToolTip.SetToolTip%2A> метод для задания подсказки, отображаемый для элементов управления. Дополнительные сведения см. в разделе [Как Определение всплывающих подсказок для элементов управления формы Windows во время разработки](how-to-set-tooltips-for-controls-on-a-windows-form-at-design-time.md). Ключевые свойства являются <xref:System.Windows.Forms.ToolTip.Active%2A>, которой должно быть присвоено `true` для подсказки, которая отображается, и <xref:System.Windows.Forms.ToolTip.AutomaticDelay%2A>, который задает продолжительность времени, которое отображается строка подсказки, как долго пользователь должен указывать на элемент управления для подсказки, которая отображается и как сколько на это проводит для следующего окна всплывающей подсказки для отображения. Дополнительные сведения см. в разделе [Как Изменение значения задержки для компонента ToolTip в Windows Forms](how-to-change-the-delay-of-the-windows-forms-tooltip-component.md).  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.ToolTip>
- [Практическое руководство. Определение всплывающих подсказок для элементов управления в Windows Forms во время разработки](how-to-set-tooltips-for-controls-on-a-windows-form-at-design-time.md)
- [Практическое руководство. Изменение значения задержки для компонента ToolTip в Windows Forms](how-to-change-the-delay-of-the-windows-forms-tooltip-component.md)
