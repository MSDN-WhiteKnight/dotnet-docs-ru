---
title: Практическое руководство. Изменение внешнего вида компонента ColorDialog в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- ColorDialog component [Windows Forms], examples
- ColorDialog component [Windows Forms], formatting appearance
- color dialog box [Windows Forms], configuring appearance
ms.assetid: bba4e262-1cd7-4f63-89cf-330a36f7b539
ms.openlocfilehash: d2bb9e06d9d84a9b61c67510e9c012066f69d55e
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59329236"
---
# <a name="how-to-change-the-appearance-of-the-windows-forms-colordialog-component"></a>Практическое руководство. Изменение внешнего вида компонента ColorDialog в Windows Forms
Можно настроить внешний вид форм Windows <xref:System.Windows.Forms.ColorDialog> компонент с номером из его свойств. Диалоговое окно состоит из двух разделов — один из них основных цветов, а второй пользователь может определить собственные цвета.  
  
 Большинство свойств ограничивают набор цветов, пользователь может выбрать в диалоговом окне. Если <xref:System.Windows.Forms.ColorDialog.AllowFullOpen%2A> свойству `true`, пользователь может определить собственные цвета. <xref:System.Windows.Forms.ColorDialog.FullOpen%2A> Свойство `true` Если диалоговое окно будет расширен, чтобы определить собственные цвета; в противном случае пользователь должен нажать кнопку «Определить цвет». Когда <xref:System.Windows.Forms.ColorDialog.AnyColor%2A> свойству `true`, диалоговое окно отображает все доступные цвета в наборе основных цветов. Если <xref:System.Windows.Forms.ColorDialog.SolidColorOnly%2A> свойству `true`, пользователь может выбрать сглаживания цвета; для выбора доступны только сплошные цвета.  
  
 Если <xref:System.Windows.Forms.ColorDialog.ShowHelp%2A> свойству `true`, кнопка справки отображается в диалоговом окне. Когда пользователь нажимает кнопку "Справка" <xref:System.Windows.Forms.ColorDialog> компонента <xref:System.Windows.Forms.CommonDialog.HelpRequest> события.  
  
### <a name="to-configure-the-appearance-of-the-color-dialog-box"></a>Чтобы настроить внешний вид диалогового окна «цвет»  
  
1. Задайте <xref:System.Windows.Forms.ColorDialog.AllowFullOpen%2A>, <xref:System.Windows.Forms.ColorDialog.AnyColor%2A>, <xref:System.Windows.Forms.ColorDialog.SolidColorOnly%2A>, и <xref:System.Windows.Forms.ColorDialog.ShowHelp%2A> свойства требуемыми значениями.  
  
    ```vb  
    ColorDialog1.AllowFullOpen = True  
    ColorDialog1.AnyColor = True  
    ColorDialog1.SolidColorOnly = False  
    ColorDialog1.ShowHelp = True  
    ```  
  
    ```csharp  
    colorDialog1.AllowFullOpen = true;  
    colorDialog1.AnyColor = true;  
    colorDialog1.SolidColorOnly = false;  
    colorDialog1.ShowHelp = true;  
    ```  
  
    ```cpp  
    colorDialog1->AllowFullOpen = true;  
    colorDialog1->AnyColor = true;  
    colorDialog1->SolidColorOnly = false;  
    colorDialog1->ShowHelp = true;  
    ```  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.ColorDialog>
- [Компонент ColorDialog](colordialog-component-windows-forms.md)
- [Общие сведения о компоненте ColorDialog](colordialog-component-overview-windows-forms.md)
