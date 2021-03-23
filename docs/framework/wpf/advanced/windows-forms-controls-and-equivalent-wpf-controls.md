---
title: Элементы управления Windows Forms и эквивалентные элементы управления WPF
ms.date: 03/30/2017
helpviewer_keywords:
- Windows Forms [WPF], interoperability with
- Windows Forms [WPF], WPF interoperation
- interoperability [WPF], Windows Forms
ms.assetid: 8a157e6b-8054-46db-a5cf-a78966acc7a1
ms.openlocfilehash: abfcb9f5398a6a8d264985543df585bea93a0446
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59075279"
---
# <a name="windows-forms-controls-and-equivalent-wpf-controls"></a>Элементы управления Windows Forms и эквивалентные элементы управления WPF
Многие [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] элементы управления имеют эквивалентные WPF элементов управления, однако некоторые [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] элементы не имеют эквивалентов в WPF. В этом разделе сравниваются типы элементов управления, предоставляемые эти две технологии.  
  
 Вы всегда можете использовать взаимодействие для размещения элементов управления [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)], которые не имеют эквивалентов, в ваших WPF-приложениях.   
  
 В следующей таблице показаны элементы управления и компоненты [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)], для которых имеются элементы эквивалентной функциональности вWPF  
  
|элемент управления Windows Forms|Эквивалентный элемент управления WPF|Примечания|  
|---------------------------|----------------------------|-------------|  
|<xref:System.Windows.Forms.BindingNavigator>|Эквивалент отсутствует.||  
|<xref:System.Windows.Forms.BindingSource>|<xref:System.Windows.Data.CollectionViewSource>||  
|<xref:System.Windows.Forms.Button>|<xref:System.Windows.Controls.Button>||  
|<xref:System.Windows.Forms.CheckBox>|<xref:System.Windows.Controls.CheckBox>||  
|<xref:System.Windows.Forms.CheckedListBox>|<xref:System.Windows.Controls.ListBox> с композицией.||  
|<xref:System.Windows.Forms.ColorDialog>|Эквивалент отсутствует.||  
|<xref:System.Windows.Forms.ComboBox>|<xref:System.Windows.Controls.ComboBox>|<xref:System.Windows.Controls.ComboBox> не поддерживает автоматическое завершение.|  
|<xref:System.Windows.Forms.ContextMenuStrip>|<xref:System.Windows.Controls.ContextMenu>||  
|<xref:System.Windows.Forms.DataGridView>|<xref:System.Windows.Controls.DataGrid>||  
|<xref:System.Windows.Forms.DateTimePicker>|<xref:System.Windows.Controls.DatePicker>||  
|<xref:System.Windows.Forms.DomainUpDown>|<xref:System.Windows.Controls.TextBox> и два <xref:System.Windows.Controls.Primitives.RepeatButton> элементов управления.||  
|<xref:System.Windows.Forms.ErrorProvider>|Эквивалент отсутствует.||  
|<xref:System.Windows.Forms.FlowLayoutPanel>|<xref:System.Windows.Controls.WrapPanel> или <xref:System.Windows.Controls.StackPanel>||  
|<xref:System.Windows.Forms.FolderBrowserDialog>|Эквивалент отсутствует.||  
|<xref:System.Windows.Forms.FontDialog>|Эквивалент отсутствует.||  
|<xref:System.Windows.Forms.Form>|<xref:System.Windows.Window>|<xref:System.Windows.Window> не поддерживает дочерние окна.|  
|<xref:System.Windows.Forms.GroupBox>|<xref:System.Windows.Controls.GroupBox>||  
|<xref:System.Windows.Forms.HelpProvider>|Эквивалент отсутствует.|Отсутствует справка F1. Справка "Что это такое" заменяется всплывающей подсказкой.|  
|<xref:System.Windows.Forms.HScrollBar>|<xref:System.Windows.Controls.Primitives.ScrollBar>|Прокрутка встроена в контейнерные элементы управления.|  
|<xref:System.Windows.Forms.ImageList>|Эквивалент отсутствует.||  
|<xref:System.Windows.Forms.Label>|<xref:System.Windows.Controls.Label>||  
|<xref:System.Windows.Forms.LinkLabel>|Эквивалент отсутствует.|Можно использовать класс <xref:System.Windows.Documents.Hyperlink> для хранения гиперссылок в содержимом нефиксированного формата.|  
|<xref:System.Windows.Forms.ListBox>|<xref:System.Windows.Controls.ListBox>||  
|<xref:System.Windows.Forms.ListView>|<xref:System.Windows.Controls.ListView>|<xref:System.Windows.Controls.ListView> Управления содержит представления сведения только для чтения.|  
|<xref:System.Windows.Forms.MaskedTextBox>|Эквивалент отсутствует.||  
|<xref:System.Windows.Forms.MenuStrip>|<xref:System.Windows.Controls.Menu>|<xref:System.Windows.Controls.Menu> стили элемента управления можно приблизительно реализовать поведение и внешний вид <xref:System.Windows.Forms.ToolStripProfessionalRenderer?displayProperty=nameWithType> класса.|  
|<xref:System.Windows.Forms.MonthCalendar>|<xref:System.Windows.Controls.Calendar>||  
|<xref:System.Windows.Forms.NotifyIcon>|Эквивалент отсутствует.||  
|<xref:System.Windows.Forms.NumericUpDown>|<xref:System.Windows.Controls.TextBox> и два <xref:System.Windows.Controls.Primitives.RepeatButton> элементов управления.||  
|<xref:System.Windows.Forms.OpenFileDialog>|<xref:Microsoft.Win32.OpenFileDialog>|<xref:Microsoft.Win32.OpenFileDialog>Класс WPF оболочка[!INCLUDE[TLA2#tla_win32](../../../../includes/tla2sharptla-win32-md.md)] для элемента управления |  
|<xref:System.Windows.Forms.PageSetupDialog>|Эквивалент отсутствует.||  
|<xref:System.Windows.Forms.Panel>|<xref:System.Windows.Controls.Canvas>||  
|<xref:System.Windows.Forms.PictureBox>|<xref:System.Windows.Controls.Image>||  
|<xref:System.Windows.Forms.PrintDialog>|<xref:System.Windows.Controls.PrintDialog>||  
|<xref:System.Drawing.Printing.PrintDocument>|Эквивалент отсутствует.||  
|<xref:System.Windows.Forms.PrintPreviewControl>|<xref:System.Windows.Controls.DocumentViewer>||  
|<xref:System.Windows.Forms.PrintPreviewDialog>|Эквивалент отсутствует.||  
|<xref:System.Windows.Forms.ProgressBar>|<xref:System.Windows.Controls.ProgressBar>||  
|<xref:System.Windows.Forms.PropertyGrid>|Эквивалент отсутствует.||  
|<xref:System.Windows.Forms.RadioButton>|<xref:System.Windows.Controls.RadioButton>||  
|<xref:System.Windows.Forms.RichTextBox>|<xref:System.Windows.Controls.RichTextBox>||  
|<xref:System.Windows.Forms.SaveFileDialog>|<xref:Microsoft.Win32.SaveFileDialog>|<xref:Microsoft.Win32.SaveFileDialog>Класс WPF оболочка[!INCLUDE[TLA2#tla_win32](../../../../includes/tla2sharptla-win32-md.md)] для элемента управления |  
|<xref:System.Windows.Forms.ScrollableControl>|<xref:System.Windows.Controls.ScrollViewer>||  
|<xref:System.Media.SoundPlayer>|<xref:System.Windows.Media.MediaPlayer>||  
|<xref:System.Windows.Forms.SplitContainer>|<xref:System.Windows.Controls.GridSplitter>||  
|<xref:System.Windows.Forms.StatusStrip>|<xref:System.Windows.Controls.Primitives.StatusBar>||  
|<xref:System.Windows.Forms.TabControl>|<xref:System.Windows.Controls.TabControl>||  
|<xref:System.Windows.Forms.TableLayoutPanel>|<xref:System.Windows.Controls.Grid>||  
|<xref:System.Windows.Forms.TextBox>|<xref:System.Windows.Controls.TextBox>||  
|<xref:System.Windows.Forms.Timer>|<xref:System.Windows.Threading.DispatcherTimer>||  
|<xref:System.Windows.Forms.ToolStrip>|<xref:System.Windows.Controls.ToolBar>||  
|<xref:System.Windows.Forms.ToolStripContainer>|<xref:System.Windows.Controls.ToolBar> с композицией.||  
|<xref:System.Windows.Forms.ToolStripDropDown>|<xref:System.Windows.Controls.ToolBar> с композицией.||  
|<xref:System.Windows.Forms.ToolStripDropDownMenu>|<xref:System.Windows.Controls.ToolBar> с композицией.||  
|<xref:System.Windows.Forms.ToolStripPanel>|<xref:System.Windows.Controls.ToolBar> с композицией.||  
|<xref:System.Windows.Forms.ToolTip>|<xref:System.Windows.Controls.ToolTip>||  
|<xref:System.Windows.Forms.TrackBar>|<xref:System.Windows.Controls.Slider>||  
|<xref:System.Windows.Forms.TreeView>|<xref:System.Windows.Controls.TreeView>||  
|<xref:System.Windows.Forms.UserControl>|<xref:System.Windows.Controls.UserControl>||  
|<xref:System.Windows.Forms.VScrollBar>|<xref:System.Windows.Controls.Primitives.ScrollBar>|Прокрутка встроена в контейнерные элементы управления.|  
|<xref:System.Windows.Forms.WebBrowser>|<xref:System.Windows.Controls.Frame>, <xref:System.Windows.Controls.WebBrowser?displayProperty=nameWithType>|<xref:System.Windows.Controls.Frame> Управления может разместить HTML-страницы.<br /><br /> Начиная с версии [!INCLUDE[net_v35SP1_short](../../../../includes/net-v35sp1-short-md.md)], <xref:System.Windows.Controls.WebBrowser?displayProperty=nameWithType> управления может разместить HTML-страницы, а также обратных <xref:System.Windows.Controls.Frame> элемента управления.|  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.Integration.ElementHost>
- <xref:System.Windows.Forms.Integration.WindowsFormsHost>
- [Конструктор WPF для Windows Forms разработчики](https://docs.microsoft.com/previous-versions/visualstudio/visual-studio-2010/cc165605(v=vs.100))
- [Пошаговое руководство. Размещение элементов управления Windows Forms в WPF](walkthrough-hosting-a-windows-forms-control-in-wpf.md)
- [Пошаговое руководство. Размещение составного элемента управления WPF в форме Windows Forms](walkthrough-hosting-a-wpf-composite-control-in-windows-forms.md)
- [Миграция и взаимодействие систем](migration-and-interoperability.md)
