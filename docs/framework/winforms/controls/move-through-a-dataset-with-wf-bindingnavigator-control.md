---
title: Практическое руководство. Перемещение по набору данных с помощью элемента управления BindingNavigator в Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- datasets [Windows Forms], moving through
- BindingNavigator control [Windows Forms], moving through datasets
- examples [Windows Forms], BindingNavigator control
ms.assetid: 146d97be-3d97-400e-accb-860bbf47729d
ms.openlocfilehash: d76c2e5882c9df94674294da00ba446dfbfd2b3a
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59086524"
---
# <a name="how-to-move-through-a-dataset-with-the-windows-forms-bindingnavigator-control"></a>Практическое руководство. Перемещение по набору данных с помощью элемента управления BindingNavigator в Windows Forms
При создании управляемых данными приложений часто необходимо показывать коллекции данных пользователям. Элемент управления <xref:System.Windows.Forms.BindingNavigator> в сочетании с компонентом <xref:System.Windows.Forms.BindingSource> обеспечивает удобное и расширяемое решение для перемещения по коллекции и последовательного отображения элементов.  
  
## <a name="example"></a>Пример  
 В примере кода ниже показано, как использовать элемент управления <xref:System.Windows.Forms.BindingNavigator> для перемещения по данным. Набор содержится в элементе <xref:System.Data.DataView>, который привязан к элементу управления <xref:System.Windows.Forms.TextBox> с компонентом <xref:System.Windows.Forms.BindingSource>.  
  
> [!NOTE]
>  Хранение конфиденциальных сведений (например, пароля) в строке подключения может повлиять на безопасность приложения. Использование проверки подлинности Windows (также называемой встроенными средствами безопасности) — более безопасный способ управления доступом к базе данных. Дополнительные сведения см. в разделе [Защита сведений о подключении](../../data/adonet/protecting-connection-information.md).  
  
 [!code-csharp[System.Windows.Forms.DataNavigator#1](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.DataNavigator/CS/form1.cs#1)]
 [!code-vb[System.Windows.Forms.DataNavigator#1](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Windows.Forms.DataNavigator/VB/form1.vb#1)]  
  
## <a name="compiling-the-code"></a>Компиляция кода  
 Для этого примера требуются:  
  
-   ссылки на сборки System, System.Data, System.Drawing, System.Windows.Forms и System.Xml.  
  
 Сведения о выполнении сборки этого примера из командной строки для Visual Basic или Visual C#, см. в разделе [построение из командной строки](../../../visual-basic/reference/command-line-compiler/building-from-the-command-line.md) или [командной строки создания с помощью csc.exe](../../../csharp/language-reference/compiler-options/command-line-building-with-csc-exe.md). Можно также сборке этого примера в Visual Studio путем вставки кода в новый проект.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.BindingSource>
- <xref:System.Windows.Forms.DataGridView>
- <xref:System.Windows.Forms.BindingSource>
- [BindingNavigator — элемент управления](bindingnavigator-control-windows-forms.md)
- [Компонент BindingSource](bindingsource-component.md)
- [Практическое руководство. Связывание элемента управления с типом в Windows Forms](how-to-bind-a-windows-forms-control-to-a-type.md)
