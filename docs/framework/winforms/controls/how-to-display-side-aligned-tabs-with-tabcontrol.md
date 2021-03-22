---
title: Практическое руководство. Отображение расположенных сбоку вкладок с помощью TabControl
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- tab pages [Windows Forms], displaying side-aligned tabs
- tabs [Windows Forms], displaying side-aligned tabs
- TabControl control [Windows Forms], displaying side-aligned tabs
ms.assetid: 110d5abd-3ae3-4ded-95bf-778aaac798a0
ms.openlocfilehash: d98c5906d99dff9371f8290e7dbc9c9011cd0c29
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59338791"
---
# <a name="how-to-display-side-aligned-tabs-with-tabcontrol"></a>Практическое руководство. Отображение расположенных сбоку вкладок с помощью TabControl
Свойство <xref:System.Windows.Forms.TabControl.Alignment%2A> элемента <xref:System.Windows.Forms.TabControl> поддерживает вертикальное отображение вкладок (вдоль левой или правой границы элемента управления), в отличие от горизонтального отображения (поперек верхней или нижней области элемента управления). Вертикальное отображение по умолчанию бывает неудобным для пользователя, так как свойство <xref:System.Windows.Forms.TabPage.Text%2A> объекта <xref:System.Windows.Forms.TabPage> не отображается на вкладке при включении стилей оформления. Также не предусмотрена возможность прямого управления направлением текста на вкладке. Для улучшения взаимодействия с пользователем можно использовать рисование владельцем на <xref:System.Windows.Forms.TabControl>.  
  
 Ниже описан порядок визуализации вкладок с выравниванием по правому краю, в которых текст располагается слева направо, с помощью возможности "рисование владельцем".  
  
### <a name="to-display-right-aligned-tabs"></a>Отображение вкладок с выравниванием по правому краю  
  
1. Добавьте элемент <xref:System.Windows.Forms.TabControl> в форму.  
  
2. Задайте для свойства <xref:System.Windows.Forms.TabControl.Alignment%2A> значение <xref:System.Windows.Forms.TabAlignment.Right>.  
  
3. Присвойте свойству <xref:System.Windows.Forms.TabControl.SizeMode%2A> значение <xref:System.Windows.Forms.TabSizeMode.Fixed> так, чтобы все вкладки имели одинаковую ширину.  
  
4. Для свойства <xref:System.Windows.Forms.TabControl.ItemSize%2A> установите необходимый фиксированный размер вкладок. Имейте в виду, что свойство <xref:System.Windows.Forms.TabControl.ItemSize%2A> ведет себя так, как если бы вкладки располагались вверху, несмотря на то что они выровнены по правому краю. Таким образом, чтобы увеличить ширину вкладок, нужно изменить свойство <xref:System.Drawing.Size.Height%2A>, а чтобы сделать их выше, изменить свойство <xref:System.Drawing.Size.Width%2A>.  
  
     Для получения оптимальных результатов в примере кода ниже свойство <xref:System.Drawing.Size.Width%2A> имеет значение 25, а <xref:System.Drawing.Size.Height%2A> — значение 100.  
  
5. Задайте для свойства <xref:System.Windows.Forms.TabControl.DrawMode%2A> значение <xref:System.Windows.Forms.TabDrawMode.OwnerDrawFixed>.  
  
6. Определите обработчик для события <xref:System.Windows.Forms.TabControl.DrawItem> элемента <xref:System.Windows.Forms.TabControl>, выводящий текст слева направо.  
  
     [!code-csharp[TabControl.RightAlignedTabs#1](~/samples/snippets/csharp/VS_Snippets_Winforms/TabControl.RightAlignedTabs/CS/Form1.cs#1)]
       
  
## <a name="see-also"></a>См. также

- [Элемент управления TabControl](tabcontrol-control-windows-forms.md)
