---
title: Использование стеклянной рамки в приложении WPF
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- applications [WPF], extending glass frames into
- graphics [WPF], extending glass frames into applications
- extending glass frames into applications [WPF]
- glass frames [WPF], extending into applications
ms.assetid: 74388a3a-4b69-4a9d-ba1f-e107636bd660
ms.openlocfilehash: 8da1f49bf5b7d3daf6319906fb49390c008d209c
ms.sourcegitcommit: 3630c2515809e6f4b7dbb697a3354efec105a5cd
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/25/2019
ms.locfileid: "58412218"
---
# <a name="extend-glass-frame-into-a-wpf-application"></a>Использование стеклянной рамки в приложении WPF

В этом разделе показано, как расширить Windows Vista стеклянную рамку на клиентскую область приложения Windows Presentation Foundation (WPF).

> [!NOTE]
> Этот пример будет работать только на компьютере под управлением Windows Vista, где работает диспетчер окон рабочего стола (DWM) с включенным эффектом прозрачного стекла. Windows Vista Home Basic edition не поддерживает эффект прозрачного стекла. Области, которые обычно отображаются с эффектом прозрачного стекла, в других выпусках Windows Vista отображаются непрозрачными.

## <a name="example"></a>Пример

На следующем рисунке показан Стеклянная рамка, расширенная в адресной строке Internet Explorer 7:

![Снимок экрана, показывающий стекла фреймом, расширенный за адресной строки обозревателя IE7.](./media/extend-glass-frame-into-a-wpf-application/internet-explorer-glass-frame-extended-address-bar.png)

Чтобы расширить стеклянную рамку в приложении WPF, требуется доступ к неуправляемому [!INCLUDE[TLA#tla_api](../../../../includes/tlasharptla-api-md.md)]. В следующем примере кода выполняется платформенный вызов (pinvoke) для двух API, необходимых для расширения рамки на клиентскую область. Каждый из этих API объявляется в классе с именем **NonClientRegionAPI**.

```csharp
[StructLayout(LayoutKind.Sequential)]
public struct MARGINS
{
    public int cxLeftWidth;      // width of left border that retains its size
    public int cxRightWidth;     // width of right border that retains its size
    public int cyTopHeight;      // height of top border that retains its size
    public int cyBottomHeight;   // height of bottom border that retains its size
};

[DllImport("DwmApi.dll")]
public static extern int DwmExtendFrameIntoClientArea(
    IntPtr hwnd,
    ref MARGINS pMarInset);
```

```vb
<StructLayout(LayoutKind.Sequential)>
Public Structure MARGINS
    Public cxLeftWidth As Integer ' width of left border that retains its size
    Public cxRightWidth As Integer ' width of right border that retains its size
    Public cyTopHeight As Integer ' height of top border that retains its size
    Public cyBottomHeight As Integer ' height of bottom border that retains its size
End Structure

<DllImport("DwmApi.dll")>
Public Shared Function DwmExtendFrameIntoClientArea(ByVal hwnd As IntPtr, ByRef pMarInset As MARGINS) As Integer
End Function
```

[DwmExtendFrameIntoClientArea](/windows/desktop/api/dwmapi/nf-dwmapi-dwmextendframeintoclientarea) — функция DWM, которая расширяет рамку на клиентскую область. Она принимает два параметра — дескриптор окна и структуру [MARGINS](/windows/desktop/api/uxtheme/ns-uxtheme-_margins). [MARGINS](/windows/desktop/api/uxtheme/ns-uxtheme-_margins) используется для сообщения DWM, насколько следует расширить рамку в клиентской области.

## <a name="example"></a>Пример

Для использования функции [DwmExtendFrameIntoClientArea](/windows/desktop/api/dwmapi/nf-dwmapi-dwmextendframeintoclientarea) необходимо получить дескриптор окна. В WPF, дескриптор окна может быть получен из <xref:System.Windows.Interop.HwndSource.Handle%2A> свойство <xref:System.Windows.Interop.HwndSource>. В следующем примере рамка расширяется на клиентскую область на <xref:System.Windows.FrameworkElement.Loaded> событий окна.

```csharp
void OnLoaded(object sender, RoutedEventArgs e)
{
   try
   {
      // Obtain the window handle for WPF application
      IntPtr mainWindowPtr = new WindowInteropHelper(this).Handle;
      HwndSource mainWindowSrc = HwndSource.FromHwnd(mainWindowPtr);
      mainWindowSrc.CompositionTarget.BackgroundColor = Color.FromArgb(0, 0, 0, 0);

      // Get System Dpi
      System.Drawing.Graphics desktop = System.Drawing.Graphics.FromHwnd(mainWindowPtr);
      float DesktopDpiX = desktop.DpiX;
      float DesktopDpiY = desktop.DpiY;

      // Set Margins
      NonClientRegionAPI.MARGINS margins = new NonClientRegionAPI.MARGINS();

      // Extend glass frame into client area
      // Note that the default desktop Dpi is 96dpi. The  margins are
      // adjusted for the system Dpi.
      margins.cxLeftWidth = Convert.ToInt32(5 * (DesktopDpiX / 96));
      margins.cxRightWidth = Convert.ToInt32(5 * (DesktopDpiX / 96));
      margins.cyTopHeight = Convert.ToInt32(((int)topBar.ActualHeight + 5) * (DesktopDpiX / 96));
      margins.cyBottomHeight = Convert.ToInt32(5 * (DesktopDpiX / 96));

      int hr = NonClientRegionAPI.DwmExtendFrameIntoClientArea(mainWindowSrc.Handle, ref margins);
      //
      if (hr < 0)
      {
         //DwmExtendFrameIntoClientArea Failed
      }
   }
   // If not Vista, paint background white.
   catch (DllNotFoundException)
   {
      Application.Current.MainWindow.Background = Brushes.White;
   }
}
```

## <a name="example"></a>Пример

В следующем примере показано простое окно, в котором рамка расширяется на клиентскую область. Рамка расширяется за пределы верхней границы, содержащей два <xref:System.Windows.Controls.TextBox> объектов.

```xaml
<Window x:Class="SDKSample.Window1"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    Title="Extended Glass in WPF" Height="300" Width="400"
    Loaded="OnLoaded" Background="Transparent"
    >
  <Grid ShowGridLines="True">
    <DockPanel Name="mainDock">
      <!-- The border is used to compute the rendered height with margins.
           topBar contents will be displayed on the extended glass frame.-->
      <Border Name="topBar" DockPanel.Dock="Top" >
        <Grid Name="grid">
          <Grid.ColumnDefinitions>
            <ColumnDefinition MinWidth="100" Width="*"/>
            <ColumnDefinition Width="Auto"/>
          </Grid.ColumnDefinitions>
          <TextBox Grid.Column="0" MinWidth="100" Margin="0,0,10,5">Path</TextBox>
          <TextBox Grid.Column="1" MinWidth="75" Margin="0,0,0,5">Search</TextBox>
        </Grid>
      </Border>
      <Grid DockPanel.Dock="Top" >
        <Grid.ColumnDefinitions>
          <ColumnDefinition/>
        </Grid.ColumnDefinitions>
        <TextBox Grid.Column="0" AcceptsReturn="True"/>
      </Grid>
    </DockPanel>
  </Grid>
</Window>
```

На следующем рисунке показан Стеклянная рамка, расширенная в WPF приложения:

![Снимок экрана, показывающий Стеклянная рамка, расширенная в приложение WPF.](./media/extend-glass-frame-into-a-wpf-application/glass-frame-extended-wpf-application.png)

## <a name="see-also"></a>См. также

- [Общие сведения о диспетчере окон рабочего стола](/windows/desktop/dwm/dwm-overview)
- [Общие сведения о размытии для диспетчера окон рабочего стола](/windows/desktop/dwm/blur-ovw)
- [DwmExtendFrameIntoClientArea](/windows/desktop/api/dwmapi/nf-dwmapi-dwmextendframeintoclientarea)
