---
title: Практическое руководство. Пользовательская прорисовка элемента управления ToolStrip
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- toolbars [Windows Forms], custom drawing
- drawing [Windows Forms], owner
- ProfessionalColorTable class [Windows Forms], overriding
- examples [Windows Forms], toolbars
- drawing [Windows Forms], custom
- toolbars [Windows Forms], changing colors
- ToolStrip control [Windows Forms], drawing
- ToolStrip control [Windows Forms], changing colors
- custom drawing
- owner drawing
ms.assetid: 94e7d7bd-a752-441c-b5b3-7acf98881163
ms.openlocfilehash: 9b3d6b9391971d4c2d012345b96c2ed64d33a998
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59311049"
---
# <a name="how-to-custom-draw-a-toolstrip-control"></a>Практическое руководство. Пользовательская прорисовка элемента управления ToolStrip
Элементы управления <xref:System.Windows.Forms.ToolStrip> имеют следующие связанные классы отрисовки:  
  
-   <xref:System.Windows.Forms.ToolStripSystemRenderer> предоставляет внешний вид и стиль операционной системы.  
  
-   <xref:System.Windows.Forms.ToolStripProfessionalRenderer> предоставляет внешний вид и стиль Microsoft Office.  
  
-   <xref:System.Windows.Forms.ToolStripRenderer> является абстрактным базовым классом для двух других классов отрисовки.  
  
 Для настраиваемой отрисовки (также известной как рисование владельцем) элемента управления <xref:System.Windows.Forms.ToolStrip> можно переопределить один из классов отрисовки и изменить перспективу логики отрисовки.  
  
 В приведенных ниже процедурах описаны различные аспекты настраиваемой отрисовки.  
  
### <a name="to-switch-between-the-provided-renderers"></a>Переключение между доступными средствами отрисовки  
  
-   Задайте для свойства <xref:System.Windows.Forms.ToolStrip.RenderMode%2A> требуемое значение <xref:System.Windows.Forms.ToolStripRenderMode>.  
  
     Для <xref:System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode> статический режим <xref:System.Windows.Forms.ToolStrip.RenderMode%2A> определяет средство отрисовки для приложения. Другие значения <xref:System.Windows.Forms.ToolStripRenderMode>: <xref:System.Windows.Forms.ToolStripRenderMode.Custom>, <xref:System.Windows.Forms.ToolStripRenderMode.Professional> и <xref:System.Windows.Forms.ToolStripRenderMode.System>.  
  
### <a name="to-change-the-microsoft-officestyle-borders-to-straight"></a>Изменение границ в стиле Microsoft Office на прямые  
  
-   Переопределите <xref:System.Windows.Forms.ToolStripProfessionalRenderer.OnRenderToolStripBorder%2A?displayProperty=nameWithType>, но не вызывайте базовый класс.  
  
> [!NOTE]
>  Существуют версии этого метода для <xref:System.Windows.Forms.ToolStripRenderer>, <xref:System.Windows.Forms.ToolStripSystemRenderer> и <xref:System.Windows.Forms.ToolStripProfessionalRenderer>.  
  
### <a name="to-change-the-professionalcolortable"></a>Изменение ProfessionalColorTable  
  
-   Переопределите <xref:System.Windows.Forms.ProfessionalColorTable> и измените нужные цвета.  
  
    ```vb  
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As _  
    System.EventArgs) Handles Me.Load  
        Dim t As MyColorTable = New MyColorTable  
        ToolStrip1.Renderer = New ToolStripProfessionalRenderer(t)  
    End Sub  
  
    Class MyColorTable   
    Inherits ProfessionalColorTable  
  
    Public Overrides ReadOnly Property ButtonPressedGradientBegin() As Color  
        Get  
            Return Color.Red  
        End Get  
    End Property  
  
    Public Overrides ReadOnly Property ButtonPressedGradientMiddle() _  
    As System.Drawing.Color  
        Get  
            Return Color.Blue  
        End Get  
            End Property  
  
    Public Overrides ReadOnly Property ButtonPressedGradientEnd() _  
    As System.Drawing.Color  
        Get  
            Return Color.Green  
        End Get  
    End Property  
  
    Public Overrides ReadOnly Property ButtonSelectedGradientBegin() _  
    As Color  
        Get  
            Return Color.Yellow  
        End Get  
    End Property  
  
    Public Overrides ReadOnly Property ButtonSelectedGradientMiddle() As System.Drawing.Color  
        Get  
            Return Color.Orange  
        End Get  
    End Property  
  
    Public Overrides ReadOnly Property ButtonSelectedGradientEnd() _  
    As System.Drawing.Color  
        Get  
            Return Color.Violet  
        End Get  
    End Property  
    End Class  
    ```  
  
### <a name="to-change-the-rendering-for-all-toolstrip-controls-in-your-application"></a>Изменение отрисовки для всех элементов управления ToolStrip в приложении  
  
1. С помощью свойства <xref:System.Windows.Forms.ToolStripManager.RenderMode%2A?displayProperty=nameWithType> выберите одно из доступных средств отрисовки.  
  
2. Используйте <xref:System.Windows.Forms.ToolStripManager.Renderer%2A?displayProperty=nameWithType> для назначения пользовательского средства отрисовки.  
  
3. Убедитесь в том, что свойству <xref:System.Windows.Forms.ToolStrip.RenderMode%2A?displayProperty=nameWithType> присвоено значение по умолчанию <xref:System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode>.  
  
### <a name="to-turn-off-the-microsoft-office-colors-for-the-entire-application"></a>Отключение цветов в стиле Microsoft Office для всего приложения  
  
-   Присвойте свойству <xref:System.Windows.Forms.ToolStripManager.VisualStylesEnabled%2A?displayProperty=nameWithType> значение `false`.  
  
### <a name="to-turn-off-the-microsoft-office-colors-for-one-toolstrip-control"></a>Отключение цветов в стиле Microsoft Office для одного элемента управления ToolStrip  
  
-   Используйте код, аналогичный приведенному ниже.  
  
    ```vb  
    Dim colorTable As ProfessionalColorTable()  
    colorTable.UseSystemColors = True  
    Dim toolStrip.Renderer As ToolStripProfessionalRenderer(colorTable)  
    ```  
  
    ```csharp  
    ProfessionalColorTable colorTable = new ProfessionalColorTable();  
    colorTable.UseSystemColors = true;  
    toolStrip.Renderer = new ToolStripProfessionalRenderer(colorTable);  
    ```  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.ToolStripSystemRenderer>
- <xref:System.Windows.Forms.ToolStripProfessionalRenderer>
- <xref:System.Windows.Forms.ToolStripRenderer>
- [Элементы управления Windows Forms со встроенной поддержки рисования владельцем](controls-with-built-in-owner-drawing-support.md)
- [Практическое руководство. Создание и определение пользовательского средства визуализации для элемента управления ToolStrip в Windows Forms](create-and-set-a-custom-renderer-for-the-toolstrip-control-in-wf.md)
- [Общие сведения об элементе управления ToolStrip](toolstrip-control-overview-windows-forms.md)
