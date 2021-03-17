---
title: Справочные системы в приложениях Windows Forms
ms.date: 03/30/2017
helpviewer_keywords:
- Help [Windows Forms], adding to Windows applications
- Windows applications [Windows Forms], providing Help systems
- What's This? Help
- Help [Windows Forms], Windows Forms
- HelpProvider component [Windows Forms], providing Help in Windows applications
ms.assetid: 2a96a278-432c-41fc-9e3c-5bfedf5e1267
ms.openlocfilehash: 1a02271d59a59f0a6e06a652a34922ba5dcdf1f3
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59087278"
---
# <a name="help-systems-in-windows-forms-applications"></a>Справочные системы в приложениях Windows Forms
Один из наиболее важных преимуществ, как разработчик приложений, можно предоставить пользователям является исчерпывающая справочная система. Это, где они будет включить, когда они становятся путать или затруднений. Справочную систему в приложении Windows легко выполняется с помощью [компонент HelpProvider](../controls/helpprovider-component-windows-forms.md).  
  
## <a name="different-types-of-help"></a>Различные типы справки  
 Компонент <xref:System.Windows.Forms.HelpProvider> Windows Forms позволяет связать HTML-файл справки версии 1.x (CHM-файл, созданный с помощью средства HTML Help Workshop, или HTM-файл) с приложением Windows. <xref:System.Windows.Forms.HelpProvider> Компонент может использоваться для предоставления контекстной справки для элементов управления в формах Windows Forms или определенных элементов управления. Кроме того <xref:System.Windows.Forms.HelpProvider> компонента можно открыть файл справки для конкретной области, например на главную страницу содержимого, индекса или для функции поиска. Общие сведения о <xref:System.Windows.Forms.HelpProvider> компонента, см. в разделе [Общие сведения о компоненте HelpProvider](../controls/helpprovider-component-overview-windows-forms.md). Сведения о том, как использовать <xref:System.Windows.Forms.HelpProvider> компонент для отображения всплывающей справки в формах Windows Forms, см. в разделе [как: Отображение всплывающей справки](how-to-display-pop-up-help.md). Дополнительные сведения об использовании <xref:System.Windows.Forms.ToolTip> компонент для отображения справки для элемента управления, см. в разделе [подсказки справки с помощью элемента управления](control-help-using-tooltips.md).  
  
 Можно создать файлы HTML Help 1.x с HTML Help Workshop. Дополнительные сведения о HTML-справки см. в разделе «HTML Help Workshop» или в других разделах «HTML Help» в библиотеке MSDN.  
  
## <a name="see-also"></a>См. также

- [Интеграция справки пользователя в формы Windows Forms](integrating-user-help-in-windows-forms.md)
- [Компонент HelpProvider](../controls/helpprovider-component-windows-forms.md)
- [Компонент ToolTip](../controls/tooltip-component-windows-forms.md)
- [Общие сведения о Windows Forms](../windows-forms-overview.md)
- [Windows Forms](../index.md)
