---
title: Пошаговое руководство. Применение стилей к содержимому WPF
ms.date: 03/30/2017
helpviewer_keywords:
- WPF Designer [Windows Forms], styling WPF content
- interoperability [WDF]
- styles [Windows Forms], WPF content
ms.assetid: e574aac7-7ea4-4cdb-8034-bab541f000df
ms.openlocfilehash: 887a157494c2992c1ae5868229c442f31fafb276
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59312154"
---
# <a name="walkthrough-styling-wpf-content"></a>Пошаговое руководство. Применение стилей к содержимому WPF
В этом пошаговом руководстве показано, как применить стили к элементу управления Windows Presentation Foundation (WPF), размещенному на форме Windows Forms.

 В руководстве выполняются следующие задачи:

-   Создание проекта.

-   создание элемента управления WPF;

-   применение стиля к элементу управления WPF.

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
  
-   Создание нового проекта приложения Windows Forms в Visual Basic или Visual C# с именем `StylingWpfContent`.  
  
## <a name="creating-the-wpf-control-types"></a>Создание типов элементов управления WPF  
 После добавления в проект типа элемента управления WPF можно разместить его в элементе управления <xref:System.Windows.Forms.Integration.ElementHost>.  
  
#### <a name="to-create-wpf-control-types"></a>Создание типов элементов управления WPF  
  
1. Добавьте в решение новый проект WPF <xref:System.Windows.Controls.UserControl>. Используйте имя по умолчанию для этого типа элемента управления (`UserControl1.xaml`). Дополнительные сведения см. в разделе [Пошаговое руководство: Создание нового содержимого WPF в формах Windows Forms во время разработки](walkthrough-creating-new-wpf-content-on-windows-forms-at-design-time.md).  
  
2. Убедитесь в том, что элемент `UserControl1` выбран в представлении конструирования. Дополнительные сведения см. в разделе [Как Выберите и перемещать элементы в области конструктора](https://docs.microsoft.com/previous-versions/visualstudio/visual-studio-2010/bb514527(v=vs.100)).  
  
3. В **свойства** окна, установите для параметра <xref:System.Windows.FrameworkElement.Width%2A> и <xref:System.Windows.FrameworkElement.Height%2A> свойства `200`.  
  
4. Добавить <xref:System.Windows.Controls.Button?displayProperty=nameWithType> управления <xref:System.Windows.Controls.UserControl> и установите для параметра <xref:System.Windows.Controls.ContentControl.Content%2A> свойства **отменить**.  
  
5. Добавьте второй <xref:System.Windows.Controls.Button?displayProperty=nameWithType> управления <xref:System.Windows.Controls.UserControl> и установите для параметра <xref:System.Windows.Controls.ContentControl.Content%2A> свойства **ОК**.  
  
6. Выполните построение проекта.  
  
## <a name="applying-a-style-to-a-wpf-control"></a>Применение стиля к элементу управления WPF  
 Для изменения внешнего вида и поведения элемента управления WPF к нему можно применить различные стили.  
  
#### <a name="to-apply-a-style-to-a-wpf-control"></a>Применение стиля к элементу управления WPF  
  
1. Откройте `Form1` в конструкторе Windows Forms.  
  
2. В **элементов**, дважды щелкните `UserControl1` для создания экземпляра `UserControl1` в форме.  
  
     Экземпляр `UserControl1` размещается в новом элементе управления <xref:System.Windows.Forms.Integration.ElementHost> с именем `elementHost1`.  
  
3. В панели смарт-тега для `elementHost1`, нажмите кнопку **редактировать содержимое** из раскрывающегося списка.  
  
     `UserControl1` Открывает в [!INCLUDE[wpfdesigner_current_short](../../../../includes/wpfdesigner-current-short-md.md)].  
  
4. В представлении XAML вставьте следующий код XAML после открывающего тега `<UserControl>` .  
  
     Этот код XAML создает градиент с контрастной градиентной границей. При нажатии на элемент управления градиенты изменяются, формируя образ нажатой кнопки. Более подробную информацию см. в разделе [Стилизация и использование шаблонов](../../wpf/controls/styling-and-templating.md).  
  
```xaml  
<UserControl.Resources>  
    <LinearGradientBrush x:Key="NormalBrush" EndPoint="0,1" StartPoint="0,0">  
        <GradientStop Color="#FFF" Offset="0.0"/>  
        <GradientStop Color="#CCC" Offset="1.0"/>  
    </LinearGradientBrush>  
    <LinearGradientBrush x:Key="PressedBrush" EndPoint="0,1" StartPoint="0,0">  
        <GradientStop Color="#BBB" Offset="0.0"/>  
        <GradientStop Color="#EEE" Offset="0.1"/>  
        <GradientStop Color="#EEE" Offset="0.9"/>  
        <GradientStop Color="#FFF" Offset="1.0"/>  
    </LinearGradientBrush>  
    <LinearGradientBrush x:Key="NormalBorderBrush" EndPoint="0,1" StartPoint="0,0">  
        <GradientStop Color="#CCC" Offset="0.0"/>  
        <GradientStop Color="#444" Offset="1.0"/>  
    </LinearGradientBrush>  
    <LinearGradientBrush x:Key="BorderBrush" EndPoint="0,1" StartPoint="0,0">  
        <GradientStop Color="#CCC" Offset="0.0"/>  
        <GradientStop Color="#444" Offset="1.0"/>  
    </LinearGradientBrush>  
    <LinearGradientBrush x:Key="PressedBorderBrush" EndPoint="0,1" StartPoint="0,0">  
        <GradientStop Color="#444" Offset="0.0"/>  
        <GradientStop Color="#888" Offset="1.0"/>  
    </LinearGradientBrush>  
  
    <Style x:Key="SimpleButton" TargetType="{x:Type Button}" BasedOn="{x:Null}">  
        <Setter Property="Background" Value="{StaticResource NormalBrush}"/>  
        <Setter Property="BorderBrush" Value="{StaticResource NormalBorderBrush}"/>  
        <Setter Property="Template">  
            <Setter.Value>  
                <ControlTemplate TargetType="{x:Type Button}">  
                    <Grid x:Name="Grid">  
                        <Border x:Name="Border" Background="{TemplateBinding Background}" BorderBrush="{TemplateBinding BorderBrush}" BorderThickness="{TemplateBinding BorderThickness}" Padding="{TemplateBinding Padding}"/>  
                        <ContentPresenter HorizontalAlignment="{TemplateBinding HorizontalContentAlignment}" Margin="{TemplateBinding Padding}" VerticalAlignment="{TemplateBinding VerticalContentAlignment}" RecognizesAccessKey="True"/>  
                    </Grid>  
                    <ControlTemplate.Triggers>  
                        <Trigger Property="IsPressed" Value="true">  
                            <Setter Property="Background" Value="{StaticResource PressedBrush}" TargetName="Border"/>  
                            <Setter Property="BorderBrush" Value="{StaticResource PressedBorderBrush}" TargetName="Border"/>  
                        </Trigger>  
                    </ControlTemplate.Triggers>  
                </ControlTemplate>  
            </Setter.Value>  
        </Setter>  
    </Style>  
</UserControl.Resources>  
```  
  
1. Примените стиль `SimpleButton`, определенный на предыдущем шаге, к кнопке "Отмена", вставив следующий код XAML в `<Button>` тег кнопки "Отмена".  
  
    ```  
    Style="{StaticResource SimpleButton}  
    ```  
  
     Объявление кнопки будет выглядеть так, как в XAML ниже.  
  
```xaml  
<Button Height="23" Margin="41,52,98,0" Name="button1" VerticalAlignment="Top"  
                Style="{StaticResource SimpleButton}">Cancel</Button>  
```  
  
1. Выполните построение проекта.  
  
2. Откройте `Form1` в конструкторе Windows Forms.  
  
3. Новый стиль применяется для элемента управления button.  
  
4. Из **Отладка** меню, выберите **начать отладку** для запуска приложения.  
  
5. Нажмите кнопки OK и Отмена и просмотрите  различия.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.Integration.ElementHost>
- <xref:System.Windows.Forms.Integration.WindowsFormsHost>
- [Миграция и взаимодействие систем](../../wpf/advanced/migration-and-interoperability.md)
- [Использование элементов управления WPF](using-wpf-controls.md)
- [Проектирование XAML в Visual Studio](/visualstudio/designers/designing-xaml-in-visual-studio)
- [Обзор XAML (WPF)](../../wpf/advanced/xaml-overview-wpf.md)
- [Стилизация и использование шаблонов](../../wpf/controls/styling-and-templating.md)
