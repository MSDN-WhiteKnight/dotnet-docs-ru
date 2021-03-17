---
title: Практическое руководство. Определение способа изменения размеров и позиционирования в окне с перемещаемым разделителем
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- split windows [Windows Forms], resizing
- splitter windows [Windows Forms], resizing
- SplitContainer control [Windows Forms], resizing
ms.assetid: 9bf73f36-ed2d-4a02-b15a-0770eff4fdfa
ms.openlocfilehash: 8cdcfdfaa135a92ed6a6e96d4a72de2c97f2493d
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59328677"
---
# <a name="how-to-define-resize-and-positioning-behavior-in-a-split-window"></a>Практическое руководство. Определение способа изменения размеров и позиционирования в окне с перемещаемым разделителем
Панели элемента <xref:System.Windows.Forms.SplitContainer> управления поддаются, размеров и управлению пользователями. Тем не менее, будет существовать раз, когда необходимо программно управлять разделителем, где он размещается, и определить, каким образом его можно переместить.  
  
 <xref:System.Windows.Forms.SplitContainer.SplitterIncrement%2A> Свойства и другие свойства <xref:System.Windows.Forms.SplitContainer> управления позволяют точно контролировать поведение пользовательского интерфейса в соответствии с потребностями. Эти свойства перечислены в следующей таблице.  
  
|name|Описание|  
|----------|-----------------|  
|<xref:System.Windows.Forms.SplitContainer.IsSplitterFixed%2A> свойство;|Определяет, является ли разделитель при помощи клавиатуры или мыши.|  
|<xref:System.Windows.Forms.SplitContainer.SplitterDistance%2A> свойство;|Определяет расстояние в пикселях от левого или верхнего края для перемещаемой полосы-разделителя.|  
|<xref:System.Windows.Forms.SplitContainer.SplitterIncrement%2A> свойство;|Определяет минимальное расстояние в пикселях, что разделитель может быть перемещен пользователем.|  
  
 Следующий пример изменяет <xref:System.Windows.Forms.SplitContainer.SplitterIncrement%2A> свойство для создания эффекта «привязка разделителем»; когда пользователь перетаскивает разделитель, увеличивается в единицах 10 пикселей, а не по умолчанию 1.  
  
### <a name="to-define-splitcontainer-resize-behavior"></a>Для определения поведения размера SplitContainer  
  
1. В процедуре, задайте <xref:System.Windows.Forms.SplitContainer.SplitterIncrement%2A> свойство до нужного размера, таким образом, чтобы реализовать поведение «привязка» разделителя.  
  
     В следующем примере кода, в форме <xref:System.Windows.Forms.Form.Load> событие, разделителя в <xref:System.Windows.Forms.SplitContainer> элемента управления задано значение для перехода 10 пикселей при перетаскивании.  
  
    ```vb  
    Private Sub Form1_Load(ByVal sender As System.Object, _  
        ByVal e As System.EventArgs) Handles MyBase.Load  
        Dim splitSnapper as new SplitContainer()  
        splitSnapper.SplitterIncrement = 10  
        splitSnapper.Dock = DockStyle.Fill  
        splitSnapper.Parent = me  
    End Sub  
    ```  
  
    ```csharp  
    private void Form1_Load(System.Object sender, System.EventArgs e)  
    {  
        SplitContainer splitSnapper = new SplitContainer();  
        splitSnapper.SplitterIncrement = 10;  
        splitSnapper.Dock = DockStyle.Fill;  
        splitSnapper.Parent = this;  
    }  
    ```  
  
     (Visual C#) Поместите следующий код в конструктор формы для регистрации обработчика событий.  
  
    ```csharp  
    this.Load += new System.EventHandler(this.Form1_Load);  
    ```  
  
     Плавное перемещение влево или вправо разделителя не будет действовать ощутимого; Тем не менее когда указатель мыши выходит 10 точек в любом направлении, разделитель будет привязана к новой позиции.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.SplitContainer>
- <xref:System.Windows.Forms.SplitContainer.SplitterIncrement%2A>
