---
title: Свойства элементов управления Windows Forms
ms.date: 03/30/2017
helpviewer_keywords:
- custom controls [Windows Forms], properties overview (using code)
- controls [Windows Forms], properties
- properties [Windows Forms]
ms.assetid: 2785279b-fb57-4937-8f6b-2050e475db6f
ms.openlocfilehash: e531b80cffabb94d2589383936a425b740c9cc07
ms.sourcegitcommit: 160a88c8087b0e63606e6e35f9bd57fa5f69c168
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/09/2019
ms.locfileid: "57708916"
---
# <a name="properties-in-windows-forms-controls"></a>Свойства элементов управления Windows Forms
Элемент управления Windows Forms наследует многие свойства базового класса <xref:System.Windows.Forms.Control?displayProperty=nameWithType>. К ним относятся свойства, такие как <xref:System.Windows.Forms.Control.Font%2A>, <xref:System.Windows.Forms.Control.ForeColor%2A>, <xref:System.Windows.Forms.Control.BackColor%2A>, <xref:System.Windows.Forms.Control.Bounds%2A>, <xref:System.Windows.Forms.Control.ClientRectangle%2A>, <xref:System.Windows.Forms.Control.DisplayRectangle%2A>, <xref:System.Windows.Forms.Control.Enabled%2A>, <xref:System.Windows.Forms.Control.Focused%2A>, <xref:System.Windows.Forms.Control.Height%2A>, <xref:System.Windows.Forms.Control.Width%2A>, <xref:System.Windows.Forms.Control.Visible%2A>, <xref:System.Windows.Forms.Control.AutoSize%2A>и многие другие. Дополнительные сведения о наследуемых свойствах см. в разделе <xref:System.Windows.Forms.Control?displayProperty=nameWithType>.  
  
 Вы можете переопределять наследуемые свойства в элементе управления, а также задавать новые свойства.  
  
## <a name="in-this-section"></a>В этом разделе  
 [Определение свойства](defining-a-property-in-windows-forms-controls.md)  
 Показывает, как реализовать свойство настраиваемого элемента управления или компонента и интегрировать свойство в среду разработки.  
  
 [Определение значений по умолчанию с помощью методов ShouldSerialize и Reset](defining-default-values-with-the-shouldserialize-and-reset-methods.md)  
 Показывает, как определить значения свойства по умолчанию для настраиваемого элемента управления или компонента.  
  
 [События изменения свойств](property-changed-events.md)  
 Показывает, как включить уведомления об изменении свойств при изменении значения свойства.  
  
 [Практическое руководство. Обеспечение доступа к свойствам составных элементов управления](how-to-expose-properties-of-constituent-controls.md)  
 Показывает, как предоставить доступ к свойствам составных элементов управления в настраиваемом составном элементе управления.  
  
 [Реализация методов в специализированных элементах управления](method-implementation-in-custom-controls.md)  
 Показывает, как реализовывать методы в настраиваемых элементах управления и компонентах.  
  
## <a name="reference"></a>Ссылка  
 <xref:System.Windows.Forms.UserControl>  
 Описание базового класса для реализации составных элементов управления.  
  
 <xref:System.ComponentModel.TypeConverterAttribute>  
 Описывает атрибут, задающий <xref:System.ComponentModel.TypeConverter> для типа настраиваемого свойства.  
  
 <xref:System.ComponentModel.EditorAttribute>  
 Описывает атрибут, задающий <xref:System.Drawing.Design.UITypeEditor> для пользовательского свойства.  
  
## <a name="related-sections"></a>Связанные разделы  
 [Атрибуты в элементах управления Windows Forms](attributes-in-windows-forms-controls.md)  
 Описываются атрибуты, которые можно применять к свойствам или другим членам пользовательских элементов управления и компонентов.  
  
 [Атрибуты времени разработки для компонентов](https://docs.microsoft.com/previous-versions/visualstudio/visual-studio-2013/tk67c2t8(v=vs.120))  
 Перечислены атрибуты метаданных, которые нужно применить к компонентам и элементам управления, чтобы они корректно отображались в режиме разработки в визуальных конструкторах.  
  
 [Расширения поддержки времени разработки](https://docs.microsoft.com/previous-versions/visualstudio/visual-studio-2013/37899azc(v=vs.120))  
 Описывается, как реализовать такие классы, как редакторы и конструкторы, обеспечивающие поддержку во время разработки.
