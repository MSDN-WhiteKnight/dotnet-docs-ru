---
title: Практическое руководство. Изменение внешнего вида элемента управления TabControl в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- icons [Windows Forms], displaying on tabs
- TabControl control [Windows Forms], changing page appearance
- tabs [Windows Forms], controlling appearance
- buttons [Windows Forms], displaying tabs as
ms.assetid: 7c6cc443-ed62-4d26-b94d-b8913b44f773
ms.openlocfilehash: 05df05a52914f27a4b62cf7bde92e5d942b6ea06
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59331342"
---
# <a name="how-to-change-the-appearance-of-the-windows-forms-tabcontrol"></a>Практическое руководство. Изменение внешнего вида элемента управления TabControl в Windows Forms
Можно изменить внешний вид вкладок в формах Windows Forms с помощью свойств объекта <xref:System.Windows.Forms.TabControl> и <xref:System.Windows.Forms.TabPage> объекты, составляющие отдельные вкладки в элементе управления. Задавая эти свойства, можно отображать изображения на вкладках, отображение вкладок вертикально, отображения нескольких рядов и также включить или отключить вкладки программными средствами.  
  
### <a name="to-display-an-icon-on-the-label-part-of-a-tab"></a>Для отображения значка со стороны метка вкладки  
  
1. Добавление <xref:System.Windows.Forms.ImageList> на форму элемент управления.  
  
2. Добавление изображений в списке изображений.  
  
     Дополнительные сведения о списках изображений, см. в разделе [компонента ImageList](imagelist-component-windows-forms.md) и [как: Добавление и удаление изображений с помощью Windows Forms компонента ImageList](how-to-add-or-remove-images-with-the-windows-forms-imagelist-component.md).  
  
3. Задайте <xref:System.Windows.Forms.TabControl.ImageList%2A> свойство <xref:System.Windows.Forms.TabControl> для <xref:System.Windows.Forms.ImageList> элемента управления.  
  
4. Задайте <xref:System.Windows.Forms.TabPage.ImageIndex%2A> свойство <xref:System.Windows.Forms.TabPage> к индексу соответствующего изображения в списке.  
  
### <a name="to-create-multiple-rows-of-tabs"></a>Чтобы создать несколько строк вкладок  
  
1. Добавите число страниц вкладок, которые нужно.  
  
2. Задайте <xref:System.Windows.Forms.TabControl.Multiline%2A> свойство <xref:System.Windows.Forms.TabControl> для `true`.  
  
3. Если вкладки не отображается в нескольких строках, задайте <xref:System.Windows.Forms.Control.Width%2A> свойство <xref:System.Windows.Forms.TabControl> быть уже, чем все знаки табуляции.  
  
### <a name="to-arrange-tabs-on-the-side-of-the-control"></a>Расположение вкладок вдоль края элемента управления  
  
-   Задайте <xref:System.Windows.Forms.TabControl.Alignment%2A> свойство <xref:System.Windows.Forms.TabControl> для <xref:System.Windows.Forms.TabAlignment.Left> или <xref:System.Windows.Forms.TabAlignment.Right>.  
  
### <a name="to-programmatically-enable-or-disable-all-controls-on-a-tab"></a>Чтобы включить или отключить все элементы управления на вкладке  
  
1. Задайте <xref:System.Windows.Forms.TabPage.Enabled%2A> свойство <xref:System.Windows.Forms.TabPage> для `true` или `false`.  
  
    ```vb  
    TabPage1.Enabled = False  
    ```  
  
    ```csharp  
    tabPage1.Enabled = false;  
    ```  
  
    ```cpp  
    tabPage1->Enabled = false;  
    ```  
  
### <a name="to-display-tabs-as-buttons"></a>Отображение вкладок как кнопки  
  
-   Задайте <xref:System.Windows.Forms.TabControl.Appearance%2A> свойство <xref:System.Windows.Forms.TabControl> для <xref:System.Windows.Forms.TabAppearance.Buttons> или <xref:System.Windows.Forms.TabAppearance.FlatButtons>.  
  
## <a name="see-also"></a>См. также

- [Элемент управления TabControl](tabcontrol-control-windows-forms.md)
- [Общие сведения об элементе управления TabControl](tabcontrol-control-overview-windows-forms.md)
- [Практическое руководство. Добавление элемента управления на вкладку](how-to-add-a-control-to-a-tab-page.md)
- [Практическое руководство. Блокировка доступа ко вкладкам](how-to-disable-tab-pages.md)
- [Практическое руководство. Добавление и удаление вкладок с помощью элемента управления TabControl в Windows Forms](how-to-add-and-remove-tabs-with-the-windows-forms-tabcontrol.md)
