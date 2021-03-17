---
title: Практическое руководство. Разделение окна по горизонтали
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- SplitContainer control [Windows Forms], horizontal splitter
- splitter windows [Windows Forms], changing splitter orientation
- splitter windows [Windows Forms], horizontal
- windows [Windows Forms], splitting horizontally
ms.assetid: a1f74f29-048c-4723-85fa-b9d375ab8f4b
ms.openlocfilehash: a43d632a82678f362a1cdf6b3ee4486a8db5adde
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59321085"
---
# <a name="how-to-split-a-window-horizontally"></a>Практическое руководство. Разделение окна по горизонтали
В следующем примере кода делает разделитель <xref:System.Windows.Forms.SplitContainer> элемента управления по горизонтали.  
  
> [!NOTE]
>  <xref:System.Windows.Forms.SplitContainer.Orientation%2A> Свойство <xref:System.Windows.Forms.SplitContainer> управления определяет направление разделителя, а не сам элемент управления.  
  
### <a name="to-split-a-window-horizontally"></a>Разделение окна по горизонтали  
  
1. В рамках процедуры, задать <xref:System.Windows.Forms.SplitContainer.Orientation%2A> свойство <xref:System.Windows.Forms.SplitContainer> управления <xref:System.Windows.Forms.Orientation.Horizontal>.  
  
    ```vb  
    Sub ShowSplitContainer()  
        Dim splitContainer1 as new SplitContainer()  
        splitContainer1.BorderStyle = BorderStyle.Fixed3D  
        splitContainer1.Location = New System.Drawing.Point(74, 20)  
        splitContainer1.Name = "DemoSplitContainer"  
        splitContainer1.Size = New System.Drawing.Size(212, 435)  
        splitContainer1.TabIndex = 0  
        splitContainer1.Orientation = Orientation.Horizontal  
        Controls.Add(splitContainer1)  
    End Sub  
    ```  
  
    ```csharp  
    public void showSplitContainer()  
    {  
        SplitContainer splitContainer1 = new SplitContainer ();  
        splitContainer1.BorderStyle = BorderStyle.Fixed3D;  
        splitContainer1.Location = new System.Drawing.Point (74, 20);  
        splitContainer1.Name = "DemoSplitContainer";  
        splitContainer1.Size = new System.Drawing.Size (212, 435);  
        splitContainer1.TabIndex = 0;  
        splitContainer1.Orientation = Orientation.Horizontal;  
        this.Controls.Add (splitContainer1);  
  
    }  
    ```  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.SplitContainer>
- [Элемент управления SplitContainer](splitcontainer-control-windows-forms.md)
