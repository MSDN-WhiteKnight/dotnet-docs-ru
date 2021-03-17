---
title: Функциональная классификация элементов управления Windows Forms
ms.date: 03/30/2017
helpviewer_keywords:
- controls [Windows Forms], by function
- Windows Forms, controls by function
- Windows Forms controls, list of
ms.assetid: 5e65a6c3-5d6f-480d-beb8-b28f865f07e3
ms.openlocfilehash: 3a82642c985b7ec1cee885cdda7b054adbe3dfee
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59115483"
---
# <a name="windows-forms-controls-by-function"></a>Функциональная классификация элементов управления Windows Forms
Windows Forms предоставляет элементы управления и компоненты, которые выполняют несколько функций. Ниже перечислены элементы управления Windows Forms и компоненты в соответствии с основной функцией. Кроме того Если существуют несколько элементов управления, которые выполняют одинаковую функцию, рекомендуемый элемент управления отображается с примечание, касающееся элемент управления, который он заменен. В отдельной таблице с их рекомендуемые замены перечислены устаревшие элементы управления.  
  
> [!NOTE]
>  В следующих таблицах перечислены не в случае, каждый элемент управления или компонента, которые можно использовать в Windows Forms; более полный список, см. в разделе [элементы управления для использования в формах Windows Forms](controls-to-use-on-windows-forms.md)  
  
## <a name="recommended-controls-and-components-by-function"></a>Рекомендуемые элементы управления и компоненты по функциям  
  
|Функция|Элемент управления|Описание|  
|--------------|-------------|-----------------|  
|Отображение данных|<xref:System.Windows.Forms.DataGridView> элемент управления|<xref:System.Windows.Forms.DataGridView> Управления предоставляет настраиваемую таблицу для отображения данных. <xref:System.Windows.Forms.DataGridView> Класс обеспечивает возможность настройки ячеек, строк, столбцов и границ. **Примечание.**  <xref:System.Windows.Forms.DataGridView> Элемент управления предоставляет множество основных и дополнительных компонентов, отсутствующих в <xref:System.Windows.Forms.DataGrid> элемента управления. Дополнительные сведения см. в разделе [различия между Windows Forms DataGridView и DataGrid-элементы управления](differences-between-the-windows-forms-datagridview-and-datagrid-controls.md)|  
|Привязка данных и навигации|<xref:System.Windows.Forms.BindingSource> component|Упрощает привязку элементов управления в форме к данным за счет управления валюты, уведомления об изменениях и другие службы.|  
||<xref:System.Windows.Forms.BindingNavigator> элемент управления|Предоставляет интерфейс тип панели инструментов для работы с данными в форме.|  
|Редактирование текста|<xref:System.Windows.Forms.TextBox> элемент управления|Отображает текст, введенный во время разработки, который может редактироваться пользователями во время выполнения или изменяться программно.|  
||<xref:System.Windows.Forms.RichTextBox> элемент управления|Позволяет текста, отображаемого с форматированием в виде обычного текста или rich text format (RTF).|  
||<xref:System.Windows.Forms.MaskedTextBox> элемент управления|Ограничивает формат вводимых пользователем данных|  
|Отображение информации (только для чтения)|<xref:System.Windows.Forms.Label> элемент управления|Отображает текст, недоступный для непосредственного изменения пользователем.|  
||<xref:System.Windows.Forms.LinkLabel> элемент управления|Отображает текст в виде веб-ссылки и вызывает событие, когда пользователь щелкает этот текст. Обычно текст является ссылкой на другое окно или веб-сайта.|  
||<xref:System.Windows.Forms.StatusStrip> элемент управления|Отображает сведения о текущем состоянии приложения в рамках области обычно в нижней части родительской формы.|  
||<xref:System.Windows.Forms.ProgressBar> элемент управления|Отображает текущее состояние операции для пользователя.|  
|Отображение веб-страницы|<xref:System.Windows.Forms.WebBrowser> элемент управления|Предоставляет пользователю возможность осуществлять навигацию по веб-страницам внутри формы.|  
|Выбор из списка|<xref:System.Windows.Forms.CheckedListBox> элемент управления|Отображает прокручиваемый список элементов с флажками.|  
||<xref:System.Windows.Forms.ComboBox> элемент управления|Отображает список элементов раскрывающегося списка.|  
||<xref:System.Windows.Forms.DomainUpDown> элемент управления|Отображение списка текстовых элементов, который можно прокручивать с помощью кнопок со стрелками.|  
||<xref:System.Windows.Forms.ListBox> элемент управления|Отображает список текстовых и графических элементов (значки).|  
||<xref:System.Windows.Forms.ListView> элемент управления|Отображает элементы в одном из четырех различных представлений. Включает в себя только текст, текст с маленькими значками, текст с крупные значки и представление сведений.|  
||<xref:System.Windows.Forms.NumericUpDown> элемент управления|Отображение списка чисел, который можно прокручивать с помощью кнопок со стрелками.|  
||<xref:System.Windows.Forms.TreeView> элемент управления|Отображает иерархическую коллекцию объектов-узлов, которые могут включать текст с помощью флажков и значков.|  
|Отображение графики|<xref:System.Windows.Forms.PictureBox> элемент управления|Отображает графические файлы, например точечные рисунки и значки, в кадре.|  
|Хранение графики|<xref:System.Windows.Forms.ImageList> элемент управления|Выступает в качестве репозитория для изображений. <xref:System.Windows.Forms.ImageList> элементы управления и образы, содержащиеся в них могут использоваться повторно из одного приложения к другому.|  
|Значение параметра|<xref:System.Windows.Forms.CheckBox> элемент управления|Отображает флажок и надпись для текста. Обычно используется для задания параметров.|  
||<xref:System.Windows.Forms.CheckedListBox> элемент управления|Отображает прокручиваемый список элементов с флажками.|  
||<xref:System.Windows.Forms.RadioButton> элемент управления|Отображает кнопку, можно включить или отключить.|  
||<xref:System.Windows.Forms.TrackBar> элемент управления|Позволяет пользователям задавать значения на шкале, перемещая «ползунок» на шкале.|  
|Настройка даты|<xref:System.Windows.Forms.DateTimePicker> элемент управления|Отображает графический календарь, позволяющий пользователю выбрать дату или время.|  
||<xref:System.Windows.Forms.MonthCalendar> элемент управления|Отображает графический календарь, чтобы разрешить пользователям выбирать диапазон дат.|  
|Диалоговые окна|<xref:System.Windows.Forms.ColorDialog> элемент управления|Отображает диалоговое окно выбора цвета, позволяющего задать цвет элемента интерфейса.|  
||<xref:System.Windows.Forms.FontDialog> элемент управления|Отображает диалоговое окно, которое позволяет задавать шрифт и его атрибуты.|  
||<xref:System.Windows.Forms.OpenFileDialog> элемент управления|Отображает диалоговое окно, которое позволяет пользователям перейдите и выберите файл.|  
||<xref:System.Windows.Forms.PrintDialog> элемент управления|Отображает диалоговое окно, которое позволяет пользователям выбирать принтер и задайте его атрибуты.|  
||<xref:System.Windows.Forms.PrintPreviewDialog> элемент управления|Отображает диалоговое окно, которое отображается как элемент управления <xref:System.Drawing.Printing.PrintDocument> компонент будет выглядеть при печати.|  
||<xref:System.Windows.Forms.FolderBrowserDialog> элемент управления|Отображает диалоговое окно, в котором пользователи могут просматривать, создавать и выбора папки.|  
||<xref:System.Windows.Forms.SaveFileDialog> элемент управления|Отображает диалоговое окно, которое позволяет пользователю сохранить файл.|  
|Элементы управления меню|<xref:System.Windows.Forms.MenuStrip> элемент управления|Создание пользовательских меню. **Примечание.**  <xref:System.Windows.Forms.MenuStrip> Предназначен для замены <xref:System.Windows.Forms.MainMenu> элемента управления.|  
||<xref:System.Windows.Forms.ContextMenuStrip> элемент управления|Создание пользовательского контекстного меню. **Примечание.**  <xref:System.Windows.Forms.ContextMenuStrip> Предназначен для замены <xref:System.Windows.Forms.ContextMenu> элемента управления.|  
|Команды|<xref:System.Windows.Forms.Button> элемент управления|Запускает, останавливает или прерывания процесса.|  
||<xref:System.Windows.Forms.LinkLabel> элемент управления|Отображает текст в виде веб-ссылки и вызывает событие, когда пользователь щелкает этот текст. Обычно текст является ссылкой на другое окно или веб-сайта.|  
||<xref:System.Windows.Forms.NotifyIcon> элемент управления|Отображает значок в области уведомлений панели задач, который представляет приложение, работающее в фоновом режиме.|  
||<xref:System.Windows.Forms.ToolStrip> элемент управления|Создание панелей инструментов, которые могут иметь Microsoft Windows XP, Microsoft Office, Microsoft Internet Explorer или пользовательский интерфейс, с или без темы и поддержка переполнения и переупорядочения элементов во время выполнения. **Примечание.**  <xref:System.Windows.Forms.ToolStrip> Элемент управления предназначен для замены <xref:System.Windows.Forms.ToolBar> элемента управления.|  
|Справка по пользовательскому|<xref:System.Windows.Forms.HelpProvider> component|Обеспечивает для элементов управления всплывающее окно справки или окно оперативной справки.|  
||<xref:System.Windows.Forms.ToolTip> component|Предоставляет всплывающее окно, которое отображает краткое описание назначения элемента управления при наведении указателя мыши на элементе управления.|  
|Группировки других элементов управления|<xref:System.Windows.Forms.Panel> элемент управления|Группирует набор элементов управления в прокручиваемый фрейм без подписи.|  
||<xref:System.Windows.Forms.GroupBox> элемент управления|Группирует набор элементов управления (например, переключателей) в непрокручиваемый фрейм.|  
||<xref:System.Windows.Forms.TabControl> элемент управления|Предоставляет страницы с вкладками для организации и доступ к сгруппированные объекты эффективно.|  
||<xref:System.Windows.Forms.SplitContainer> элемент управления|Предоставляет две панели, разделенных подвижной строки. **Примечание.**  <xref:System.Windows.Forms.SplitContainer> Элемент управления предназначен для замены <xref:System.Windows.Forms.Splitter> элемента управления.|  
||<xref:System.Windows.Forms.TableLayoutPanel> элемент управления|Представляет панель, в которой содержимое динамически отображается в сетке, состоящей из строк и столбцов.|  
||<xref:System.Windows.Forms.FlowLayoutPanel> элемент управления|Представляет панель, которая динамически располагает содержимое по горизонтали или вертикали.|  
|Звук|<xref:System.Media.SoundPlayer> элемент управления|Воспроизводит звук в формате WAV. Звуки можно загружать и воспроизводить асинхронно.|  
  
## <a name="superseded-controls-and-components-by-function"></a>Устаревшие элементы управления и компоненты по функциям  
  
|Функция|Устаревший элемент управления|Рекомендуется на замену|  
|--------------|------------------------|-----------------------------|  
|Отображение данных|<xref:System.Windows.Forms.DataGrid>|<xref:System.Windows.Forms.DataGridView>|  
|Отображение информации (только для чтения элементы управления)|<xref:System.Windows.Forms.StatusBar>|<xref:System.Windows.Forms.StatusStrip>|  
|Элементы управления меню|<xref:System.Windows.Forms.ContextMenu>|<xref:System.Windows.Forms.ContextMenuStrip>|  
||<xref:System.Windows.Forms.MainMenu>|<xref:System.Windows.Forms.MenuStrip>|  
|Команды|<xref:System.Windows.Forms.ToolBar>|<xref:System.Windows.Forms.ToolStrip>|  
||<xref:System.Windows.Forms.StatusBar>|<xref:System.Windows.Forms.StatusStrip>|  
|Макет формы|<xref:System.Windows.Forms.Splitter>|<xref:System.Windows.Forms.SplitContainer>|  
  
## <a name="see-also"></a>См. также

- [Элементы управления для использования в формах Windows Forms](controls-to-use-on-windows-forms.md)
- [Разработка пользовательских элементов управления Windows Forms в .NET Framework](developing-custom-windows-forms-controls.md)
