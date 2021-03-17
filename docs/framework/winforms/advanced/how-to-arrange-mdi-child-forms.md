---
title: Практическое руководство. Упорядочение дочерних MDI-форм
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- child forms [Windows Forms], arranging
- MDI [Windows Forms], arranging child forms
ms.assetid: a0786378-3206-4ccc-898e-7d3b38cc5089
ms.openlocfilehash: c7a9d03ef60586e1162f088d662dfe44bbdcb591
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59317237"
---
# <a name="how-to-arrange-mdi-child-forms"></a>Практическое руководство. Упорядочение дочерних MDI-форм
Во многих случаях приложения будут иметь команды меню для таких действий как «Мозаика», «Каскад» и «Упорядочить», которые позволяют управлять компоновкой открытых дочерних MDI-форм. Для изменения порядка дочерних форм в родительской MDI-форме можно использовать метод <xref:System.Windows.Forms.Form.LayoutMdi%2A> с одним из значений перечисления <xref:System.Windows.Forms.MdiLayout>.  
  
 Значения перечисления <xref:System.Windows.Forms.MdiLayout> позволяют отображать дочерние формы в виде каскада, мозаично по вертикали или горизонтали, либо в виде значков форм, расположенных в нижней части MDI-формы. Эти значения имеют тот же эффект, что команды Windows **каскадом**, **отображать окна рядом**, **отображать окна стопкой**, и **отображает рабочий стол** , соответственно.  
  
 Эти методы часто используются в качестве обработчиков событий, вызываемых с помощью события <xref:System.Windows.Forms.Control.Click> пункта меню. Таким образом, пункт меню с текстом «Окна каскадом» может оказать требуемое воздействие на дочерние MDI-окна.  
  
### <a name="to-arrange-child-forms"></a>Упорядочение дочерних форм  
  
1. В методе для родительской MDI-формы используйте перечисление <xref:System.Windows.Forms.Form.LayoutMdi%2A> для задания метода<xref:System.Windows.Forms.MdiLayout>. В следующем примере используется значение перечисления <xref:System.Windows.Forms.MdiLayout.Cascade?displayProperty=nameWithType> для дочерних окон родительской MDI-формы (`Form1`). Перечисление используется в коде во время работы обработчика событий для <xref:System.Windows.Forms.Control.Click> событие **Cascade Windows** пункта меню.  
  
    ```vb  
    Protected Sub CascadeWindows_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)  
       Me.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade)  
    End Sub  
    ```  
  
    ```csharp  
    protected void CascadeWindows_Click(object sender, System.EventArgs e){  
       this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);  
    }  
    ```  
  
    > [!NOTE]
    >  Путем изменения значения перечисления <xref:System.Windows.Forms.MdiLayout> можно также мозаично размещать окна и упорядочивать их в виде значков.  
  
2. В случае использования Visual C# поместите следующий код в конструктор формы для регистрации обработчика событий.  
  
    ```csharp  
    this.button1.Click += new System.EventHandler(this.button1_Click);  
    ```  
  
## <a name="see-also"></a>См. также

- [Приложения с интерфейсом MDI](multiple-document-interface-mdi-applications.md)
- [Практическое руководство. Создание родительских MDI-форм](how-to-create-mdi-parent-forms.md)
- [Практическое руководство. Создание дочерних форм MDI](how-to-create-mdi-child-forms.md)
- [Практическое руководство. Определение активной дочерней MDI-формы](how-to-determine-the-active-mdi-child.md)
- [Практическое руководство. Отправка данных в активную дочернюю MDI-форму](how-to-send-data-to-the-active-mdi-child.md)
