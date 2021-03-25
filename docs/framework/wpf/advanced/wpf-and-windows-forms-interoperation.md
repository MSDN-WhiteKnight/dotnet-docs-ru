---
title: Взаимодействие WPF и Windows Forms
ms.date: 03/30/2017
helpviewer_keywords:
- Windows Forms [WPF], interoperability with
- nester interoperation [WPF]
- Windows Forms [WPF], WPF interoperation
- interoperability [WPF], Windows Forms
- hybrid control [WPF interoperability]
ms.assetid: 9e8aa6b6-112c-4579-98d1-c974917df499
ms.openlocfilehash: 2e3390c3e387e75168958f946472a5a24a4bd440
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59129276"
---
# <a name="wpf-and-windows-forms-interoperation"></a>Взаимодействие WPF и Windows Forms
WPF и [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] представляют две различные архитектуры для создания интерфейсов приложений. <xref:System.Windows.Forms.Integration?displayProperty=nameWithType> Пространство имен предоставляет классы, обеспечивающие общие сценарии взаимодействия. Ключевыми классами, реализующими возможности взаимодействия, <xref:System.Windows.Forms.Integration.WindowsFormsHost> и <xref:System.Windows.Forms.Integration.ElementHost>. В этом разделе описано, какие сценарии взаимодействия поддерживаются, а какие нет.  
  
> [!NOTE]
>  Особое внимание уделено сценарию *гибридного элемента управления*. Гибридный элемент управления — это элемент управления на основе одной технологии, в который вложен элемент управления на основе другой технологии. Это также называется *вложенным взаимодействием*. В *многоуровневом гибридном элементе управления* более одного уровня вложения. Примером многоуровневого вложенного взаимодействия является элемент управления [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)], который содержит элемент управления WPF, содержащий другой элемент управления [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)]. Многоуровневые гибридные элементы управления не поддерживаются.  

<a name="Windows_Presentation_Foundation_Application_Hosting"></a>   
## <a name="hosting-windows-forms-controls-in-wpf"></a>Размещение элементов управления Windows Forms в WPF  
 Поддерживаются следующие сценарии взаимодействия при WPF элемент управления размещает элемент управления Windows Forms:  
  
-   В элемент управления WPF с помощью XAML могут быть вложены один или несколько элементов управления [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)].  
  
-   С помощью кода в него могут быть вложены один или несколько элементов управления [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)].  
  
-   В него могут быть вложены контейнерные элементы управления [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)], содержащие элементы управления [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)].  
  
-   В него может быть вложена форма с отношением "главный-подчиненный" с главным элементом WPF и подчиненными элементами [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)].  
  
-   В него может быть вложена форма с отношением "главный-подчиненный" с главным элементом [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] и подчиненными элементами WPF.  
  
-   В него могут быть вложены один или несколько элементов [!INCLUDE[TLA2#tla_actx](../../../../includes/tla2sharptla-actx-md.md)].  
  
-   В него могут быть вложены один или несколько составных элементов управления.  
  
-   С помощью XAML в него могут быть вложены гибридные элементы управления.  
  
-   С помощью кода в него могут быть вложены гибридные элементы управления.  
  
### <a name="layout-support"></a>Поддержка макета  
 Ниже перечислены известные ограничения при <xref:System.Windows.Forms.Integration.WindowsFormsHost> пытается интегрировать вложенный элемент [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] управления в WPF системы макета.  
  
-   В некоторых случаях размеры элемента управления [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] изменять нельзя, или же их можно изменять, но только в фиксированных пределах. Например [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] <xref:System.Windows.Forms.ComboBox> элемент управления поддерживает только одну высоту, которая определяется размером шрифта элемента управления. В WPF динамический макет, где предполагается, что элементы можно растянуть по вертикали, вложенный <xref:System.Windows.Forms.ComboBox> управления не растягивается, как ожидалось.  
  
-   [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] элементы управления нельзя поворачивать или неравномерным. Например, при повороте пользовательского интерфейса на 90 градусов вложенные элементы управления [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] сохранят свое вертикальное положение.  
  
-   В большинстве случаев элементы управления [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] не поддерживают пропорциональное масштабирование. Несмотря на то, что общий размер элемента управления масштабируется, дочерние элементы управления и компоненты элемента управления могут изменять размеры не так, как ожидается. Это ограничение зависит от поддержки масштабирования каждым элементом управления [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)].  
  
-   В пользовательском интерфейсе WPF можно изменить z-порядок элементов для контроля поведения перекрывания. Вложенный элемент управления [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] рисуется в отдельном HWND, причем он всегда рисуется поверх элементов WPF.  
  
-   [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] элементы управления поддерживают автоматическое масштабирование в зависимости от размера шрифта. В пользовательском интерфейсе WPF изменение размера шрифта не влечет за собой изменение размера всего макета, хотя отдельные элементы могут динамически изменять размер.  
  
### <a name="ambient-properties"></a>Внешние свойства  
 Некоторые внешние свойства элементов управления WPF имеют эквиваленты [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)]. Эти внешние свойства распространяются на вложенные [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] управляет и предоставляются как общие свойства на <xref:System.Windows.Forms.Integration.WindowsFormsHost> элемента управления. <xref:System.Windows.Forms.Integration.WindowsFormsHost> Управления преобразует каждое WPF внешнее свойство в его [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] эквивалент.  
  
 Дополнительные сведения см. в разделе [Сопоставление свойств Windows Forms и WPF](windows-forms-and-wpf-property-mapping.md).  
  
### <a name="behavior"></a>Поведение  
 В приведенной ниже таблице описаны возможности взаимодействия.  
  
|Поведение|Поддерживается|Не поддерживается|  
|--------------|---------------|-------------------|  
|Прозрачность|[!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] отрисовка элемента управления поддерживает прозрачность. Фон родительского элемента управления WPF может стать фоном вложенного элемента управления [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)].|Некоторые элементы управления [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] не поддерживают прозрачность. Например <xref:System.Windows.Forms.TextBox> и <xref:System.Windows.Forms.ComboBox> элементы управления не будут прозрачными при вложении в WPF.|  
|Переход по клавише TAB|Последовательность табуляции для вложенных элементов управления [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] та же, что и при вложении этих элементов управления в приложение, основанное на [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)].<br /><br /> Переход от элемента управления WPF к элементу управления [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] по клавишам TAB и SHIFT+TAB работает как обычно.<br /><br /> [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] элементы управления, имеющие <xref:System.Windows.Forms.Control.TabStop%2A> значение свойства `false` не получают фокус, когда пользователь переключается между элементами управления.<br /><br /> -Каждое <xref:System.Windows.Forms.Integration.WindowsFormsHost> элемент управления имеет <xref:System.Windows.Forms.Integration.WindowsFormsHost.TabIndex%2A> значение, которое определяет, когда, <xref:System.Windows.Forms.Integration.WindowsFormsHost> элемент управления получает фокус.<br />-   [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] элементы управления, содержащиеся внутри <xref:System.Windows.Forms.Integration.WindowsFormsHost> контейнера выполните порядке, указанном <xref:System.Windows.Forms.Control.TabIndex%2A> свойство. При переходе от последнего индекса табуляции фокус получает следующий элемент управления WPF, если таковой существует. Если нет других элементов управления WPF, принимающих фокус, то переход по табуляции переводит фокус на первый элемент управления [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] в последовательности табуляции.<br />-   <xref:System.Windows.Forms.Integration.WindowsFormsHost.TabIndex%2A> значения для элементов управления внутри <xref:System.Windows.Forms.Integration.WindowsFormsHost> устанавливаются относительно родственных [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] элементов управления, содержащихся в <xref:System.Windows.Forms.Integration.WindowsFormsHost> элемента управления.<br />— При переходе по табуляции учитывается модель поведения элемента управления. Например, нажатие клавиши TAB в <xref:System.Windows.Forms.TextBox> элемента управления, имеющего <xref:System.Windows.Forms.TextBoxBase.AcceptsTab%2A> значение свойства `true` вводит табуляции в текстовом поле вместо перемещения фокуса.|Неприменимо.|  
|Переход с помощью клавиш со стрелками|— Ключи переход с помощью стрелки в <xref:System.Windows.Forms.Integration.WindowsFormsHost> управления такое же, как обычный [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] контейнерного элемента управления: Стрелка вверх или Стрелка влево выберите предыдущий элемент управления, и клавиши Стрелка вниз и вправо, а также выбрать следующий элемент управления.<br />-Стрелками ключи из первого элемента управления, содержащийся в <xref:System.Windows.Forms.Integration.WindowsFormsHost> элемент управления выполняет те же действия, сочетание клавиш SHIFT + TAB. Если имеется принимающий фокус WPF управления фокус перемещается за пределы <xref:System.Windows.Forms.Integration.WindowsFormsHost> элемента управления. Это поведение отличается от стандартного <xref:System.Windows.Forms.ContainerControl> тем, что без перехода к последнему управления происходит. Если нет других элементов управления WPF, принимающих фокус, фокус возвращается к последнему элементу управления [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] в последовательности табуляции.<br />-НАЖАТЫМИ клавиши со стрелками и Стрелка вправо от последнего элемента управления, содержащийся в <xref:System.Windows.Forms.Integration.WindowsFormsHost> элемент управления выполняет те же действия, клавиши TAB. Если имеется принимающий фокус WPF управления фокус перемещается за пределы <xref:System.Windows.Forms.Integration.WindowsFormsHost> элемента управления. Это поведение отличается от стандартного <xref:System.Windows.Forms.ContainerControl> тем, что переноса на первый элемент управления не происходит. Если нет других элементов управления WPF, принимающих фокус, то фокус возвращается к первому элементу управления [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] в последовательности перехода.|Неприменимо.|  
|Клавиши быстрого доступа|Клавиши быстрого доступа работают как обычно, за исключением пунктов, оговоренных в столбце "Не поддерживается".|Повторяющиеся в различных технологиях клавиши быстрого доступа не работают как обычные повторяющиеся клавиши быстрого доступа. При дублировании клавиш быстрого доступа в различных технологиях по крайней мере для одного элемента управления [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] и одного элемента управления WPF клавиша быстрого доступа всегда присваивается элементу управления [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)]. Фокус не переключается между элементами управления с одинаковыми клавишами быстрого доступа.|  
|Сочетание клавиш|Сочетания клавиш работают как обычно, за исключением пунктов, оговоренных в столбце "Не поддерживается".|Сочетания клавиш -   [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)], заданные на этапе предварительной обработки, всегда имеют приоритет перед сочетаниями клавиш WPF. Например, если у вас есть <xref:System.Windows.Forms.ToolStrip> было управлять с помощью клавиш CTRL + S определены и WPF привязан к CTRL + S, команда <xref:System.Windows.Forms.ToolStrip> управления всегда вызывается обработчик во-первых, независимо от фокуса.<br />-   [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] сочетания клавиш, которые обрабатываются <xref:System.Windows.Forms.Control.KeyDown> событий, обрабатываются последними в WPF. Можно предотвратить такое поведение путем переопределения [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] элемента управления <xref:System.Windows.Forms.Control.IsInputKey%2A> метода или обработки <xref:System.Windows.Forms.Control.PreviewKeyDown> событий. Вернуть `true` из <xref:System.Windows.Forms.Control.IsInputKey%2A> метод, или установите для параметра <xref:System.Windows.Forms.PreviewKeyDownEventArgs.IsInputKey%2A?displayProperty=nameWithType> свойства `true` в вашей <xref:System.Windows.Forms.Control.PreviewKeyDown> обработчик событий.|  
|AcceptsReturn, AcceptsTab и другие специфические свойства элементов управления|Свойства, изменяющие стандартное поведение клавиатуры обычным образом, при условии, что [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] управления переопределений <xref:System.Windows.Forms.Control.IsInputKey%2A> метод для возврата `true`.|[!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] элементы управления, изменяющие стандартное поведение клавиатуры при обработке <xref:System.Windows.Forms.Control.KeyDown> событий, обрабатываются последними в узле WPF элемента управления. Так как эти элементы управления обрабатываются последними, они могут привести к непредвиденному поведению.|  
|События Enter и Leave|Когда фокус не переводится на содержащую <xref:System.Windows.Forms.Integration.ElementHost> управления, Enter и Leave событий как обычно при изменении фокуса в одном <xref:System.Windows.Forms.Integration.WindowsFormsHost> элемента управления.|События Enter и Leave не вызываются при следующих переводах фокуса:<br /><br /> -Из за <xref:System.Windows.Forms.Integration.WindowsFormsHost> элемента управления.<br />-Из внутрь <xref:System.Windows.Forms.Integration.WindowsFormsHost> элемента управления.<br />-Снаружи <xref:System.Windows.Forms.Integration.WindowsFormsHost> элемента управления.<br />-Из [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] размещение элементов управления в <xref:System.Windows.Forms.Integration.WindowsFormsHost> управления <xref:System.Windows.Forms.Integration.ElementHost> в тот же элемент управления <xref:System.Windows.Forms.Integration.WindowsFormsHost>.|  
|Многопоточность|Поддерживаются все возможности многопоточности.|И технология [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)], и технология WPF предполагают однопоточную модель параллелизма. Во время отладки вызовы объектов платформы из других потоков будут вызывать исключение для принудительного выполнения этого требования.|  
|Безопасность|Все сценарии взаимодействия требуют полного доверия.|Не допускаются сценарии взаимодействия с частичным доверием.|  
|Специальные возможности|Поддерживаются все сценарии специальных возможностей. Продукты вспомогательной технологии работают корректно, когда они используются для гибридных приложений, содержащих как элементы управления [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)], так и элементы управления WPF.|Неприменимо.|  
|буфер обмена|Все операции с буфером обмена работают обычным образом. Сюда относятся операции вырезания и вставки между элементами управления [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] и WPF.|Неприменимо.|  
|Функция перетаскивания|Все операции перетаскивания работают обычным образом. Сюда относятся операции перетаскивания между элементами управления [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] и WPF.|Неприменимо.|  
  
<a name="Windows_Forms_Application_Hosting_Windows"></a>   
## <a name="hosting-wpf-controls-in-windows-forms"></a>Размещение элементов управления WPF в Windows Forms  
 Следующие сценарии взаимодействия поддерживаются в том случае, если узлы управления Windows Forms WPF управления:  
  
-   Вложение одного или нескольких элементов управления WPF с помощью кода.  
  
-   Связывание страницы свойств с одним или несколькими вложенными элементами управления WPF.  
  
-   Вложение одной или нескольких страниц WPF в форму.  
  
-   Запуск окна WPF.  
  
-   Вложение формы с отношением "главный-подчиненный" с главным элементом [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] и подчиненными элементами WPF.  
  
-   Вложение формы с отношением "главный-подчиненный" с главным элементом WPF и подчиненными элементами [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)].  
  
-   Вложение пользовательских элементов управления WPF.  
  
-   Вложение гибридных элементов управления.  
  
### <a name="ambient-properties"></a>Внешние свойства  
 Некоторые внешние свойства элементов управления [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] имеют эквиваленты WPF. Эти внешние свойства распространяются на вложенные WPF управляет и предоставляются как общие свойства на <xref:System.Windows.Forms.Integration.ElementHost> элемента управления. <xref:System.Windows.Forms.Integration.ElementHost> Управления преобразует каждое [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] внешнее свойство, чтобы его WPF эквивалент.  
  
 Дополнительные сведения см. в разделе [Сопоставление свойств Windows Forms и WPF](windows-forms-and-wpf-property-mapping.md).  
  
### <a name="behavior"></a>Поведение  
 В приведенной ниже таблице описаны возможности взаимодействия.  
  
|Поведение|Поддерживается|Не поддерживается|  
|--------------|---------------|-------------------|  
|Прозрачность|WPF отрисовка элемента управления поддерживает прозрачность. Фон родительского элемента управления [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] может стать фоном вложенного элемента управления WPF.|Неприменимо.|  
|Многопоточность|Поддерживаются все возможности многопоточности.|И технология [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)], и технология WPF предполагают однопоточную модель параллелизма. Во время отладки вызовы объектов платформы из других потоков будут вызывать исключение для принудительного выполнения этого требования.|  
|Безопасность|Все сценарии взаимодействия требуют полного доверия.|Не допускаются сценарии взаимодействия с частичным доверием.|  
|Специальные возможности|Поддерживаются все сценарии специальных возможностей. Продукты вспомогательной технологии работают корректно, когда они используются для гибридных приложений, содержащих как элементы управления [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)], так и элементы управления WPF.|Неприменимо.|  
|буфер обмена|Все операции с буфером обмена работают обычным образом. Сюда относятся операции вырезания и вставки между элементами управления [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] и WPF.|Неприменимо.|  
|Функция перетаскивания|Все операции перетаскивания работают обычным образом. Сюда относятся операции перетаскивания между элементами управления [!INCLUDE[TLA#tla_winforms](../../../../includes/tlasharptla-winforms-md.md)] и WPF.|Неприменимо.|  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.Integration.ElementHost>
- <xref:System.Windows.Forms.Integration.WindowsFormsHost>
- [Пошаговое руководство. Размещение элементов управления Windows Forms в WPF](walkthrough-hosting-a-windows-forms-control-in-wpf.md)
- [Пошаговое руководство. Размещение составного элемента управления Windows Forms в приложении WPF](walkthrough-hosting-a-windows-forms-composite-control-in-wpf.md)
- [Пошаговое руководство. Размещение составного элемента управления WPF в форме Windows Forms](walkthrough-hosting-a-wpf-composite-control-in-windows-forms.md)
- [Сопоставление свойств Windows Forms и WPF](windows-forms-and-wpf-property-mapping.md)
