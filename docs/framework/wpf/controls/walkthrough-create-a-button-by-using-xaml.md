---
title: Пошаговое руководство. Создание кнопки с помощью XAML
ms.date: 03/30/2017
helpviewer_keywords:
- buttons [WPF]
ms.assetid: 138c41c4-1759-4bbf-8d77-77031a06a8a0
ms.openlocfilehash: 908a38485c879e3f28399bb7dbc8303afd4505da
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59309502"
---
# <a name="walkthrough-create-a-button-by-using-xaml"></a>Пошаговое руководство. Создание кнопки с помощью XAML
Цель этого пошагового руководства — сведения о создании анимированной кнопки для использования в приложении Windows Presentation Foundation (WPF). В этом пошаговом руководстве используется стиль и шаблон для создания ресурса пользовательской кнопки, которая позволяет повторно использовать код и разделять логику от объявления кнопки. В этом пошаговом руководстве приведено полностью в XAML.  
  
> [!IMPORTANT]
>  В этом пошаговом руководстве поможет выполнить шаги для создания приложения путем ввода или копирования и вставки XAML в Microsoft Visual Studio. Если вы предпочитаете, чтобы научиться использовать это средство разработки (Microsoft Expression Blend) для создания того же приложения, см. в разделе [Создание кнопки с помощью Microsoft Expression Blend](walkthrough-create-a-button-by-using-microsoft-expression-blend.md).  
  
 Ниже показаны созданные кнопки.  
  
 ![Настраиваемые кнопки, созданные с помощью XAML](./media/custom-button-animatedbutton-5.gif "custom_button_AnimatedButton_5")  
  
## <a name="create-basic-buttons"></a>Создание простых кнопок  
 Давайте начнем с создания проекта и добавления нескольких кнопок в окно.  
  
#### <a name="to-create-a-new-wpf-project-and-add-buttons-to-the-window"></a>Чтобы создать новый проект WPF и добавление кнопок в окно  
  
1. Запустите Visual Studio.  
  
2. **Создайте новый проект WPF:** В меню **Файл** выберите пункт **Создать**, а затем команду **Проект**. Найти **приложения Windows (WPF)** шаблон и имя проекта «AnimatedButton». Будет создан каркас для приложения.  
  
3. **Добавление кнопок basic по умолчанию:** Все файлы, необходимые для этого пошагового руководства предоставленный шаблоном. Откройте файл Window1.xaml, дважды щелкнув его в обозревателе решений. По умолчанию — <xref:System.Windows.Controls.Grid> элемент в файле Window1.xaml. Удалить <xref:System.Windows.Controls.Grid> элемент и добавьте несколько кнопок на XAML странице введите или скопируйте и вставьте следующий выделенный код в Window1.xaml:  
  
    ```xaml  
    <Window x:Class="AnimatedButton.Window1"  
      xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"  
      xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"  
      Title="AnimatedButton" Height="300" Width="300"   
      Background="Black">
      <!-- Buttons arranged vertically inside a StackPanel. -->
      <StackPanel HorizontalAlignment="Left">
          <Button>Button 1</Button>
          <Button>Button 2</Button>
          <Button>Button 3</Button>
      </StackPanel>  
    </Window>  
    ```  
  
     Нажмите клавишу F5 для запуска приложения; Вы должны увидеть набор кнопок, который выглядит как на следующем рисунке.  
  
     ![Три основные кнопки](./media/custom-button-animatedbutton-1.gif "custom_button_AnimatedButton_1")  
  
     Теперь, когда вы создали основные кнопки, вы закончили работу в файле Window1.xaml. Остальная часть пошагового руководства посвящена файл app.xaml, определение стилей и шаблонов для кнопок.  
  
## <a name="set-basic-properties"></a>Набор основных свойств  
 Далее зададим некоторые свойства этих кнопок для управления макет и внешний вид кнопки. Вместо того чтобы задавать свойства кнопок по отдельности, будут использовать ресурсы для определения свойств кнопки для всего приложения. Ресурсы приложений похожи на внешние [!INCLUDE[TLA#tla_css](../../../../includes/tlasharptla-css-md.md)] для веб-страниц; Однако ресурсы являются гораздо эффективнее, чем [!INCLUDE[TLA#tla_css](../../../../includes/tlasharptla-css-md.md)], как можно будет увидеть в конце этого пошагового руководства. Дополнительные сведения о ресурсах см. в разделе [ресурсы XAML](../advanced/xaml-resources.md).  
  
#### <a name="to-use-styles-to-set-basic-properties-on-the-buttons"></a>Чтобы использовать стили для задания основных свойств на кнопках  
  
1. **Определение блока Application.Resources:** Откройте файл app.xaml и добавьте выделенную ниже разметку в том случае, если он еще не выбран.  
  
    ```xaml  
    <Application x:Class="AnimatedButton.App"  
      xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"  
      xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"  
      StartupUri="Window1.xaml"  
      >  
      <Application.Resources>
        <!-- Resources for the entire application can be defined here. -->
      </Application.Resources>  
    </Application>  
    ```  
  
     Область ресурса определяется определяется ресурс. Определение ресурсов в `Application.Resources` в app.xaml файл позволяет ресурсов для использования в любом месте в приложении. Дополнительные сведения об определении области ресурсов, см. в разделе [ресурсы XAML](../advanced/xaml-resources.md).  
  
2. **Создать стиль и определите значения основных свойств с ним:** Добавьте следующую разметку для `Application.Resources` блока. Эта разметка создает <xref:System.Windows.Style> , применимый ко всем кнопкам в приложении, устанавливая <xref:System.Windows.FrameworkElement.Width%2A> кнопок на 90 и <xref:System.Windows.FrameworkElement.Margin%2A> до 10:  
  
    ```xaml  
    <Application.Resources>  
      <Style TargetType="Button">
        <Setter Property="Width" Value="90" />
        <Setter Property="Margin" Value="10" />
      </Style>  
    </Application.Resources>  
    ```  
  
     <xref:System.Windows.Style.TargetType%2A> Свойство указывает, что стиль применяется ко всем объектам данного типа <xref:System.Windows.Controls.Button>. Каждый <xref:System.Windows.Setter> задает другое значение свойства для <xref:System.Windows.Style>. Таким образом на этом этапе все кнопки в приложении имеет шириной равной 90 и границей 10.  Если нажать клавишу F5, чтобы запустить приложение, вы увидите следующее окно.  
  
     ![Кнопки с шириной равной 90 и границей 10](./media/custom-button-animatedbutton-2.gif "custom_button_AnimatedButton_2")  
  
     Нет, можно сделать с помощью стилей, включая различные способы настройки целевых объектов, указание сложных значений свойств и даже использование стилей в качестве входных данных для других стилей гораздо больше. Более подробную информацию см. в разделе [Стилизация и использование шаблонов](styling-and-templating.md).  
  
3. **Задайте значение свойства стиля для ресурса:** Ресурсы позволяют легко повторное использование часто определяемых объектов и значений. Это особенно полезно для определения сложных значений, использование ресурсов, чтобы сделать код более удобным. Добавьте выделенную ниже разметку в файл app.xaml.  
  
    ```xaml  
    <Application.Resources>  
      <LinearGradientBrush x:Key="GrayBlueGradientBrush" StartPoint="0,0" EndPoint="1,1">
        <GradientStop Color="DarkGray" Offset="0" />
        <GradientStop Color="#CCCCFF" Offset="0.5" />
        <GradientStop Color="DarkGray" Offset="1" />
      </LinearGradientBrush>  
      <Style TargetType="{x:Type Button}">  
        <Setter Property="Background" Value="{StaticResource GrayBlueGradientBrush}" />  
        <Setter Property="Width" Value="80" />  
        <Setter Property="Margin" Value="10" />  
      </Style>  
    </Application.Resources>  
    ```  
  
     Непосредственно под `Application.Resources` блок, вы создали ресурс называется «GrayBlueGradientBrush». Этот ресурс определяет горизонтальный градиент. Этот ресурс может использоваться в качестве значения свойства из любого места в приложении, в том числе внутри метода задания стиля кнопки для <xref:System.Windows.Controls.Control.Background%2A> свойство. Теперь все кнопки имеют <xref:System.Windows.Controls.Control.Background%2A> значение свойства для этого градиента.  
  
     Нажмите клавишу F5 для запуска приложения. Он должен выглядеть следующим образом.  
  
     ![Кнопки с фоновым градиентом](./media/custom-button-animatedbutton-3.gif "custom_button_AnimatedButton_3")  
  
## <a name="create-a-template-that-defines-the-look-of-the-button"></a>Создать шаблон, который определяет внешний вид кнопки  
 В этом разделе создается шаблон, который настраивает внешний вид (presentation) кнопки. Представление кнопки состоит из нескольких объектов, включая прямоугольники и другие компоненты для предоставления уникального внешнего вида кнопки.  
  
 На данный момент элемент управления видом кнопок в приложении выполнялось с изменение свойств кнопки. Что делать, если вы хотите сделать кардинально изменить внешний вид кнопки? Шаблоны обеспечивают мощный управления представлением объекта. Поскольку шаблоны можно использовать в стилях, шаблон можно применить ко всем объектам, к которым применяется стиль, чтобы (в этом пошаговом руководстве, кнопки).  
  
#### <a name="to-use-the-template-to-define-the-look-of-the-button"></a>Чтобы использовать шаблон для определения внешнего вида кнопки  
  
1. **Настройка шаблона:** Так как элементы управления, такие как <xref:System.Windows.Controls.Button> имеют <xref:System.Windows.Controls.Control.Template%2A> можно определить значение свойства шаблона так же, как и другие значения свойств, мы задали в <xref:System.Windows.Style> с помощью <xref:System.Windows.Setter>. Добавьте выделенную ниже разметку в стиль кнопки.  
  
    ```xaml
    <Application.Resources>  
      <LinearGradientBrush x:Key="GrayBlueGradientBrush"   
        StartPoint="0,0" EndPoint="1,1">  
        <GradientStop Color="DarkGray" Offset="0" />  
        <GradientStop Color="#CCCCFF" Offset="0.5" />  
        <GradientStop Color="DarkGray" Offset="1" />  
      </LinearGradientBrush>  
      <Style TargetType="{x:Type Button}">  
        <Setter Property="Background" Value="{StaticResource GrayBlueGradientBrush}" />  
        <Setter Property="Width" Value="80" />  
        <Setter Property="Margin" Value="10" />  
        <Setter Property="Template">
          <Setter.Value>
            <!-- The button template is defined here. -->
          </Setter.Value>
        </Setter>  
      </Style>  
    </Application.Resources>  
    ```  
  
2. **Презентация кнопку ALTER.** На этом этапе необходимо определить шаблон. Добавьте выделенную ниже разметку. Эта разметка задает два <xref:System.Windows.Shapes.Rectangle> элементов при помощи прямоугольника с закругленными углами, за которым следует <xref:System.Windows.Controls.DockPanel>. <xref:System.Windows.Controls.DockPanel> Используется для размещения <xref:System.Windows.Controls.ContentPresenter> кнопки. Объект <xref:System.Windows.Controls.ContentPresenter> отображает содержимое кнопки. В этом пошаговом руководстве содержимым является текст («Кнопку 1», «Button 2», «Button 3»). Все компоненты шаблона (прямоугольников и <xref:System.Windows.Controls.DockPanel>) располагаются внутри <xref:System.Windows.Controls.Grid>.  
  
    ```xaml  
    <Setter.Value>  
      <ControlTemplate TargetType="Button">
        <Grid Width="{TemplateBinding Width}" Height="{TemplateBinding Height}" ClipToBounds="True">
          <!-- Outer Rectangle with rounded corners. -->
          <Rectangle x:Name="outerRectangle" HorizontalAlignment="Stretch" VerticalAlignment="Stretch" Stroke="{TemplateBinding Background}" RadiusX="20" RadiusY="20" StrokeThickness="5" Fill="Transparent" />
          <!-- Inner Rectangle with rounded corners. -->
          <Rectangle x:Name="innerRectangle" HorizontalAlignment="Stretch" VerticalAlignment="Stretch" Stroke="Transparent" StrokeThickness="20" Fill="{TemplateBinding Background}" RadiusX="20" RadiusY="20" />
          <!-- Present Content (text) of the button. -->
          <DockPanel Name="myContentPresenterDockPanel">
            <ContentPresenter x:Name="myContentPresenter" Margin="20" Content="{TemplateBinding  Content}" TextBlock.Foreground="Black" />
          </DockPanel>
        </Grid>
      </ControlTemplate>  
    </Setter.Value>  
    ```  
  
     Нажмите клавишу F5 для запуска приложения. Он должен выглядеть следующим образом.  
  
     ![](./media/custom-button-animatedbutton-4.gif "custom_button_AnimatedButton_4")  
  
3. **Добавление прозрачности в шаблон:** Далее добавим прозрачного стекла. Сначала создайте ресурсы, которые создают эффект градиента прозрачности. Добавьте эти градиентные ресурсы в любом месте в пределах `Application.Resources` блок:  
  
    ```xaml  
    <Application.Resources>  
      <GradientStopCollection x:Key="MyGlassGradientStopsResource">
        <GradientStop Color="WhiteSmoke" Offset="0.2" />     
        <GradientStop Color="Transparent" Offset="0.4" />    
        <GradientStop Color="WhiteSmoke" Offset="0.5" />     
        <GradientStop Color="Transparent" Offset="0.75" />     
        <GradientStop Color="WhiteSmoke" Offset="0.9" />     
        <GradientStop Color="Transparent" Offset="1" />   
      </GradientStopCollection>   
      <LinearGradientBrush x:Key="MyGlassBrushResource"    
        StartPoint="0,0" EndPoint="1,1" Opacity="0.75"
        GradientStops="{StaticResource MyGlassGradientStopsResource}" />  
    <!-- Styles and other resources below here. -->  
    ```  
  
     Эти ресурсы используются в качестве <xref:System.Windows.Shapes.Shape.Fill%2A> для прямоугольника, который вставляется в <xref:System.Windows.Controls.Grid> шаблона кнопки. Добавьте выделенную ниже разметку в шаблон.  
  
    ```xaml
    <Setter.Value>  
      <ControlTemplate TargetType="{x:Type Button}">  
        <Grid Width="{TemplateBinding Width}" Height="{TemplateBinding Height}"  
          ClipToBounds="True">  
  
        <!-- Outer Rectangle with rounded corners. -->  
        <Rectangle x:Name="outerRectangle" HorizontalAlignment="Stretch"   
          VerticalAlignment="Stretch" Stroke="{TemplateBinding Background}"   
          RadiusX="20" RadiusY="20" StrokeThickness="5" Fill="Transparent" />  
  
        <!-- Inner Rectangle with rounded corners. -->  
        <Rectangle x:Name="innerRectangle" HorizontalAlignment="Stretch"   
          VerticalAlignment="Stretch" Stroke="Transparent" StrokeThickness="20"   
          Fill="{TemplateBinding Background}" RadiusX="20" RadiusY="20" />  
  
        <!-- Glass Rectangle -->     
        <Rectangle x:Name="glassCube" HorizontalAlignment="Stretch"       
          VerticalAlignment="Stretch"       
          StrokeThickness="2" RadiusX="10" RadiusY="10" Opacity="0"       
          Fill="{StaticResource MyGlassBrushResource}"       
          RenderTransformOrigin="0.5,0.5">
          <Rectangle.Stroke>         
            <LinearGradientBrush StartPoint="0.5,0" EndPoint="0.5,1">
              <LinearGradientBrush.GradientStops>
                <GradientStop Offset="0.0" Color="LightBlue" />
                <GradientStop Offset="1.0" Color="Gray" />
              </LinearGradientBrush.GradientStops>
            </LinearGradientBrush>       
          </Rectangle.Stroke>       
          <!-- These transforms have no effect as they are declared here.
          The reason the transforms are included is to be targets
          for animation (see later). -->       
          <Rectangle.RenderTransform>
            <TransformGroup>
              <ScaleTransform />
              <RotateTransform />
            </TransformGroup>
          </Rectangle.RenderTransform>
          <!-- A BevelBitmapEffect is applied to give the button a "Beveled" look. -->
          <Rectangle.BitmapEffect>
            <BevelBitmapEffect />
          </Rectangle.BitmapEffect>
        </Rectangle>  
  
        <!-- Present Text of the button. -->  
        <DockPanel Name="myContentPresenterDockPanel">  
          <ContentPresenter x:Name="myContentPresenter" Margin="20"   
            Content="{TemplateBinding  Content}" TextBlock.Foreground="Black" />  
        </DockPanel>  
      </Grid>  
    </ControlTemplate>  
    </Setter.Value>  
    ```  
  
     Обратите внимание, что <xref:System.Windows.UIElement.Opacity%2A> прямоугольника с `x:Name` свойство «glassCube» задано значение 0, поэтому при запуске примера, вы не видите прозрачного прямоугольника в верхней части. Это так, как мы позже добавим триггеры в шаблон для взаимодействия пользователя с помощью кнопки. Тем не менее, можно увидеть, что кнопка выглядит, как теперь, изменив <xref:System.Windows.UIElement.Opacity%2A> значение 1 и запуска приложения. См. следующий рисунок. Прежде чем переходить к следующему шагу, изменить <xref:System.Windows.UIElement.Opacity%2A> значение 0.  
  
     ![Настраиваемые кнопки, созданные с помощью XAML](./media/custom-button-animatedbutton-5.gif "custom_button_AnimatedButton_5")  
  
## <a name="create-button-interactivity"></a>Создать интерактивную кнопку  
 В этом разделе вы создадите свойство триггеров и триггеров событий для изменения значений свойств и выполнения анимации в ответ на действия пользователя, таких как Наведение указателя мыши на кнопку и нажав кнопку.  
  
 Простой способ добавления интерактивности (Наведение указателя мыши, оставьте мыши, нажмите кнопку и т. д.) является определение триггеров в шаблоне или стиле. Чтобы создать <xref:System.Windows.Trigger>, вы определяете свойство «условие», такие как: Кнопки <xref:System.Windows.UIElement.IsMouseOver%2A> значение свойства равно `true`. Затем предстоит методов задания (действия), которые выполняются, если условие триггера истинно.  
  
#### <a name="to-create-button-interactivity"></a>Чтобы создать интерактивную кнопку  
  
1. **Добавление триггеров шаблона:** Добавьте выделенную разметку в шаблон.  
  
    ```xaml
    <Setter.Value>  
      <ControlTemplate TargetType="{x:Type Button}">  
        <Grid Width="{TemplateBinding Width}"   
          Height="{TemplateBinding Height}" ClipToBounds="True">  
  
          <!-- Outer Rectangle with rounded corners. -->  
          <Rectangle x:Name="outerRectangle" HorizontalAlignment="Stretch"   
          VerticalAlignment="Stretch" Stroke="{TemplateBinding Background}"   
          RadiusX="20" RadiusY="20" StrokeThickness="5" Fill="Transparent" />  
  
          <!-- Inner Rectangle with rounded corners. -->  
          <Rectangle x:Name="innerRectangle" HorizontalAlignment="Stretch"   
            VerticalAlignment="Stretch" Stroke="Transparent"   
            StrokeThickness="20"   
            Fill="{TemplateBinding Background}" RadiusX="20" RadiusY="20"   
          />  
  
          <!-- Glass Rectangle -->  
          <Rectangle x:Name="glassCube" HorizontalAlignment="Stretch"  
            VerticalAlignment="Stretch"  
            StrokeThickness="2" RadiusX="10" RadiusY="10" Opacity="0"  
            Fill="{StaticResource MyGlassBrushResource}"  
            RenderTransformOrigin="0.5,0.5">  
            <Rectangle.Stroke>  
              <LinearGradientBrush StartPoint="0.5,0" EndPoint="0.5,1">  
                <LinearGradientBrush.GradientStops>  
                  <GradientStop Offset="0.0" Color="LightBlue" />  
                  <GradientStop Offset="1.0" Color="Gray" />  
                </LinearGradientBrush.GradientStops>  
              </LinearGradientBrush>  
            </Rectangle.Stroke>  
  
            <!-- These transforms have no effect as they   
                 are declared here.   
                 The reason the transforms are included is to be targets   
                 for animation (see later). -->  
            <Rectangle.RenderTransform>  
              <TransformGroup>  
                <ScaleTransform />  
                <RotateTransform />  
              </TransformGroup>  
            </Rectangle.RenderTransform>  
  
              <!-- A BevelBitmapEffect is applied to give the button a   
                   "Beveled" look. -->  
            <Rectangle.BitmapEffect>  
              <BevelBitmapEffect />  
            </Rectangle.BitmapEffect>  
          </Rectangle>  
  
          <!-- Present Text of the button. -->  
          <DockPanel Name="myContentPresenterDockPanel">  
            <ContentPresenter x:Name="myContentPresenter" Margin="20"   
              Content="{TemplateBinding  Content}" TextBlock.Foreground="Black" />  
          </DockPanel>  
        </Grid>  
  
        <ControlTemplate.Triggers>       <!-- Set action triggers for the buttons and define            what the button does in response to those triggers. -->     </ControlTemplate.Triggers>  
      </ControlTemplate>  
    </Setter.Value>  
    ```  
  
2. **Добавьте триггеры свойств:** Добавьте выделенную разметку для `ControlTemplate.Triggers` блок:  
  
    ```xaml
    <ControlTemplate.Triggers>  
  
      <!-- Set properties when mouse pointer is over the button. -->   <Trigger Property="IsMouseOver" Value="True">     <!-- Below are three property settings that occur when the           condition is met (user mouses over button).  -->     <!-- Change the color of the outer rectangle when user           mouses over it. -->     <Setter Property ="Rectangle.Stroke" TargetName="outerRectangle"       Value="{DynamicResource {x:Static SystemColors.HighlightBrushKey}}" />     <!-- Sets the glass opacity to 1, therefore, the           glass "appears" when user mouses over it. -->     <Setter Property="Rectangle.Opacity" Value="1" TargetName="glassCube" />     <!-- Makes the text slightly blurry as though you           were looking at it through blurry glass. -->     <Setter Property="ContentPresenter.BitmapEffect"        TargetName="myContentPresenter">       <Setter.Value>         <BlurBitmapEffect Radius="1" />       </Setter.Value>     </Setter>   </Trigger>  
  
    <ControlTemplate.Triggers/>  
    ```  
  
     Нажмите клавишу F5, чтобы запустить приложение и увидеть результат, при выполнении указатель мыши над кнопками.  
  
3. **Добавление триггера фокус:** Далее мы добавим некоторые аналогичные методы задания для обработки случая, когда в фокусе кнопки (например, после ее нажатия).  
  
    ```xaml  
    <ControlTemplate.Triggers>  
  
      <!-- Set properties when mouse pointer is over the button. -->  
      <Trigger Property="IsMouseOver" Value="True">  
  
        <!-- Below are three property settings that occur when the   
             condition is met (user mouses over button).  -->  
        <!-- Change the color of the outer rectangle when user          mouses over it. -->  
        <Setter Property ="Rectangle.Stroke" TargetName="outerRectangle"  
          Value="{DynamicResource {x:Static SystemColors.HighlightBrushKey}}" />  
  
        <!-- Sets the glass opacity to 1, therefore, the          glass "appears" when user mouses over it. -->  
        <Setter Property="Rectangle.Opacity" Value="1"       TargetName="glassCube" />  
  
        <!-- Makes the text slightly blurry as though you were          looking at it through blurry glass. -->  
        <Setter Property="ContentPresenter.BitmapEffect"       TargetName="myContentPresenter">  
          <Setter.Value>  
            <BlurBitmapEffect Radius="1" />  
          </Setter.Value>  
        </Setter>  
      </Trigger>  
      <!-- Set properties when button has focus. -->   <Trigger Property="IsFocused" Value="true">     <Setter Property="Rectangle.Opacity" Value="1"       TargetName="glassCube" />     <Setter Property="Rectangle.Stroke" TargetName="outerRectangle"       Value="{DynamicResource {x:Static SystemColors.HighlightBrushKey}}" />     <Setter Property="Rectangle.Opacity" Value="1" TargetName="glassCube" />   </Trigger>  
  
    </ControlTemplate.Triggers>  
    ```  
  
     Нажмите клавишу F5, чтобы запустить приложение и щелкнуть одну из кнопок. Обратите внимание на то, что кнопка остается выделенной, после нажатия, так как он по-прежнему имеет фокус. Если щелкнуть еще одну кнопку "Создать" получает фокус, хотя его утрачивает последним.  
  
4. **Добавление анимации для** <xref:System.Windows.UIElement.MouseEnter> **и** <xref:System.Windows.UIElement.MouseLeave> **:** Далее мы добавим некоторые анимаций в триггерах. Добавьте следующую разметку в любое место `ControlTemplate.Triggers` блока.  
  
    ```xaml
    <!-- Animations that start when mouse enters and leaves button. -->  
    <EventTrigger RoutedEvent="Mouse.MouseEnter">  
      <EventTrigger.Actions>  
        <BeginStoryboard Name="mouseEnterBeginStoryboard">  
          <Storyboard>  
          <!-- This animation makes the glass rectangle shrink in the X direction. -->  
            <DoubleAnimation Storyboard.TargetName="glassCube"   
              Storyboard.TargetProperty=  
              "(Rectangle.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleX)"  
              By="-0.1" Duration="0:0:0.5" />  
            <!-- This animation makes the glass rectangle shrink in the Y direction. -->  
            <DoubleAnimation  
            Storyboard.TargetName="glassCube"   
              Storyboard.TargetProperty=  
              "(Rectangle.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleY)"   
              By="-0.1" Duration="0:0:0.5" />  
          </Storyboard>  
        </BeginStoryboard>  
      </EventTrigger.Actions>  
    </EventTrigger>  
    <EventTrigger RoutedEvent="Mouse.MouseLeave">  
      <EventTrigger.Actions>  
        <!-- Stopping the storyboard sets all animated properties back to default. -->  
        <StopStoryboard BeginStoryboardName="mouseEnterBeginStoryboard" />  
      </EventTrigger.Actions>  
    </EventTrigger>  
    ```  
  
     Прозрачный прямоугольник уменьшается, когда указатель мыши оказывается над кнопкой и возвращает в исходное состояние, когда указатель покидает.  
  
     Существуют две анимации, которые запускаются при наведении указателя мыши на кнопку (<xref:System.Windows.UIElement.MouseEnter> события). Эти анимации сжимают прозрачный прямоугольник по оси X и Y. Обратите внимание на <xref:System.Windows.Media.Animation.DoubleAnimation> элементов — <xref:System.Windows.Media.Animation.Timeline.Duration%2A> и <xref:System.Windows.Media.Animation.DoubleAnimation.By%2A>. <xref:System.Windows.Media.Animation.Timeline.Duration%2A> Указывает, что анимация возникает через полсекунды, и <xref:System.Windows.Media.Animation.DoubleAnimation.By%2A> указывает, что прозрачный элемент сжимается на 10%.  
  
     Второй триггер события (<xref:System.Windows.UIElement.MouseLeave>) просто останавливает первое из них. При остановке <xref:System.Windows.Media.Animation.Storyboard>, все анимированные свойства возвращаются к значениям по умолчанию. Таким образом когда пользователь перемещает указатель мыши за границы кнопки, кнопки возвращается так, как было до перемещения указателя мыши на кнопку. Дополнительные сведения об анимации см. в разделе [Общие сведения об анимации](../graphics-multimedia/animation-overview.md).  
  
5. **Добавление анимации для при нажатии кнопки:** Последним шагом является добавление триггера для, когда пользователь нажимает кнопку. Добавьте следующую разметку в любое место `ControlTemplate.Triggers` блок:  
  
    ```xaml
    <!-- Animation fires when button is clicked, causing glass to spin.  -->  
    <EventTrigger RoutedEvent="Button.Click">  
      <EventTrigger.Actions>  
        <BeginStoryboard>  
          <Storyboard>  
            <DoubleAnimation Storyboard.TargetName="glassCube"   
              Storyboard.TargetProperty=  
              "(Rectangle.RenderTransform).(TransformGroup.Children)[1].(RotateTransform.Angle)"   
              By="360" Duration="0:0:0.5" />  
          </Storyboard>  
        </BeginStoryboard>  
      </EventTrigger.Actions>  
    </EventTrigger>  
    ```  
  
     Нажмите клавишу F5, чтобы запустить приложение и щелкните одну из кнопок. При нажатии кнопки прозрачный прямоугольник повернется вокруг.  
  
## <a name="summary"></a>Сводка  
 В этом пошаговом руководстве вы выполнили следующие упражнения:  
  
-   Целевые <xref:System.Windows.Style> тип объекта (<xref:System.Windows.Controls.Button>).  
  
-   Управление основными свойствами всего приложения с помощью кнопок на <xref:System.Windows.Style>.  
  
-   Созданные ресурсы, такие как градиенты, для использования для значений свойств <xref:System.Windows.Style> методы задания.  
  
-   Настройка внешнего вида кнопки в всего приложения можно применить шаблон к кнопкам.  
  
-   Настройка поведения для кнопок в ответ на действия пользователя (таких как <xref:System.Windows.UIElement.MouseEnter>, <xref:System.Windows.UIElement.MouseLeave>, и <xref:System.Windows.Controls.Primitives.ButtonBase.Click>), которые включены эффекты анимации.  
  
## <a name="see-also"></a>См. также

- [Создание кнопки с помощью Microsoft Expression Blend](walkthrough-create-a-button-by-using-microsoft-expression-blend.md)
- [Стилизация и использование шаблонов](styling-and-templating.md)
- [Общие сведения об эффектах анимации](../graphics-multimedia/animation-overview.md)
- [Общие сведения о закраске сплошным цветом и градиентом](../graphics-multimedia/painting-with-solid-colors-and-gradients-overview.md)
- [Общие сведения об эффектах для точечных рисунков](../graphics-multimedia/bitmap-effects-overview.md)
