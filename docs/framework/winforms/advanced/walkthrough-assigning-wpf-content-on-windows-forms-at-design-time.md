---
title: Пошаговое руководство. Назначение содержимого WPF для формы Windows Forms во время разработки
ms.date: 03/30/2017
helpviewer_keywords:
- WPF content [Windows Forms], assigning at design time
- ElementHost control [Windows Forms], assigning WPF content at design time
- interoperability [WPF]
- Windows Forms, content assignments
- WPF user control [Windows Forms], hosting in Windows Forms
ms.assetid: b3e9ef93-7e0f-4a2f-8f1e-3437609a1eb7
ms.openlocfilehash: b4efef869c96ddb4e58445e45ecad12b5658f9f4
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59343354"
---
# <a name="walkthrough-assigning-wpf-content-on-windows-forms-at-design-time"></a>Пошаговое руководство. Назначение содержимого WPF для формы Windows Forms во время разработки
В этом пошаговом руководстве показано, как выбрать типы элементов управления Windows Presentation Foundation (WPF), которые будут отображаться в форме. Можно выбрать любые типы элементов управления WPF, включенные в проект.

 В руководстве выполняются следующие задачи:

-   Создание проекта.

-   Создание типов элементов управления WPF.

-   Выбор элементов управления WPF.

> [!NOTE]
>  Отображаемые диалоговые окна и команды меню могут отличаться от описанных в справке в зависимости от текущих параметров или выпуска. Чтобы изменить параметры, выберите в меню **Сервис** пункт **Импорт и экспорт параметров** . Дополнительные сведения см. в разделе [Персонализация интегрированной среды разработки Visual Studio](/visualstudio/ide/personalizing-the-visual-studio-ide).  
  
## <a name="prerequisites"></a>Предварительные требования  
 Ниже приведены компоненты, необходимые для выполнения данного пошагового руководства.  
  
-   Visual Studio 2012.  
  
## <a name="creating-the-project"></a>Создание проекта  
 Первым шагом является создание проекта Windows Forms.  
  
> [!NOTE]
>  При размещении содержимого WPF поддерживаются только проекты C# и Visual Basic.  
  
#### <a name="to-create-the-project"></a>Создание проекта  
  
-   Создание нового проекта приложения Windows Forms в Visual Basic или Visual C# с именем `SelectingWpfContent`.  
  
## <a name="creating-the-wpf-control-types"></a>Создание типов элементов управления WPF  
 После добавления типов элементов управления WPF в проект их можно разместить в разных элементах управления <xref:System.Windows.Forms.Integration.ElementHost>.  
  
#### <a name="to-create-wpf-control-types"></a>Создание типов элементов управления WPF  
  
1. Добавьте в решение новый проект WPF <xref:System.Windows.Controls.UserControl>. Используйте имя по умолчанию для этого типа элемента управления (`UserControl1.xaml`). Дополнительные сведения см. в разделе [Пошаговое руководство: Создание нового содержимого WPF в формах Windows Forms во время разработки](walkthrough-creating-new-wpf-content-on-windows-forms-at-design-time.md).  
  
2. Убедитесь в том, что элемент `UserControl1` выбран в представлении конструирования. Дополнительные сведения см. в разделе [Как Выберите и перемещать элементы в области конструктора](https://docs.microsoft.com/previous-versions/visualstudio/visual-studio-2010/bb514527(v=vs.100)).  
  
3. В **свойства** окна, установите для параметра <xref:System.Windows.FrameworkElement.Width%2A> и <xref:System.Windows.FrameworkElement.Height%2A> свойства `200`.  
  
4. Добавить <xref:System.Windows.Controls.TextBox?displayProperty=nameWithType> управления <xref:System.Windows.Controls.UserControl> и установите для параметра <xref:System.Windows.Controls.TextBox.Text%2A> свойства **Hosted Content**.  
  
5. Добавьте в проект второй элемент управления WPF <xref:System.Windows.Controls.UserControl>. Используйте имя по умолчанию для этого типа элемента управления (`UserControl2.xaml`).  
  
6. В **свойства** окна, установите для параметра <xref:System.Windows.FrameworkElement.Width%2A> и <xref:System.Windows.FrameworkElement.Height%2A> свойства `200`.  
  
7. Добавить <xref:System.Windows.Controls.TextBox?displayProperty=nameWithType> управления <xref:System.Windows.Controls.UserControl> и установите для параметра <xref:System.Windows.Controls.TextBox.Text%2A> свойства **Hosted Content 2**.  
  
 **Примечание** в общем случае следует размещать более сложное содержимое WPF. Элемент управления <xref:System.Windows.Controls.TextBox?displayProperty=nameWithType> используется здесь в целях наглядности.  
  
1. Выполните построение проекта.  
  
## <a name="selecting-wpf-controls"></a>Выбор элементов управления WPF  
 Для элемента управления <xref:System.Windows.Forms.Integration.ElementHost>, в котором уже размещено содержимое, можно назначить различное содержимое WPF.  
  
#### <a name="to-select-wpf-controls"></a>Выбор элементов управления WPF  
  
1. Откройте `Form1` в конструкторе Windows Forms.  
  
2. В **элементов**, дважды щелкните `UserControl1` для создания экземпляра `UserControl1` в форме.  
  
     Экземпляр `UserControl1` размещается в новом элементе управления <xref:System.Windows.Forms.Integration.ElementHost> с именем `elementHost1`.  
  
3. В панели смарт-тега для `elementHost1`откройте **выбрать размещенное содержимое** стрелку раскрывающегося списка.  
  
4. Выберите **UserControl2** из раскрывающегося списка.  
  
     В элементе управления `elementHost1` теперь будет размещен экземпляр типа `UserControl2`.  
  
5. В **свойства** окна, убедитесь, что <xref:System.Windows.Forms.Integration.ElementHost.Child%2A> свойству **UserControl2**.  
  
6. Из **элементов**в **взаимодействие с WPF** группе, перетащите <xref:System.Windows.Forms.Integration.ElementHost> на форму.  
  
     Имя по умолчанию для нового элемента управления — `elementHost2`.  
  
7. В панели смарт-тега для `elementHost2`откройте **выбрать размещенное содержимое** стрелку раскрывающегося списка.  
  
8. Выберите **UserControl1** из раскрывающегося списка.  
  
9. В элементе управления `elementHost2` теперь будет размещен экземпляр типа `UserControl1`.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.Integration.ElementHost>
- <xref:System.Windows.Forms.Integration.WindowsFormsHost>
- [Миграция и взаимодействие систем](../../wpf/advanced/migration-and-interoperability.md)
- [Использование элементов управления WPF](using-wpf-controls.md)
- [Проектирование XAML в Visual Studio](/visualstudio/designers/designing-xaml-in-visual-studio)
