---
description: Дополнительные сведения о привязке данных в клиенте Windows Presentation Foundation
title: Привязка данных в клиенте Windows Presentation Foundation
ms.date: 03/30/2017
ms.assetid: bb8c8293-5973-4aef-9b07-afeff5d3293c
ms.openlocfilehash: 8bab24dc8f3debb75ddfd712a06f2f035707d42f
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99755880"
---
# <a name="data-binding-in-a-windows-presentation-foundation-client"></a>Привязка данных в клиенте Windows Presentation Foundation

Этот образец демонстрирует использование привязки данных в клиенте Windows Presentation Foundation (WPF). В примере используется служба Windows Communication Foundation (WCF), которая случайным образом создает массив альбомов для возврата клиенту. Каждый альбом имеет имя, цену и список дорожек в альбоме. Каждая дорожка в альбоме имеет имя и длительность. Сведения, возвращаемые службой, автоматически привязываются к пользовательскому интерфейсу, предоставленному клиентом Windows Presentation Foundation (WPF).  
  
> [!NOTE]
> Процедура настройки и инструкции по построению для данного образца приведены в конце этого раздела.  
  
 Привязка данных позволяет автоматически привязывать источник данных к пользовательскому интерфейсу. Это упрощает модель программирования, устраняя необходимость программным способом обновлять каждый элемент пользовательского интерфейса данными из объекта данных или массива объектов данных. Можно как привязать объект к одному элементу пользовательского интерфейса, так и привязать массив к элементу управления, принимающему несколько входных объектов, такому как `ListBox`. В следующем примере кода показана привязка данных к контексту данных (`DataContext`) элемента пользовательского интерфейса.  
  
```csharp  
// Event handler executed when call is complete  
void client_GetAlbumListCompleted(object sender, GetAlbumListCompletedEventArgs e)  
{  
    // This is on the UI thread, myPanel can be accessed directly  
    myPanel.DataContext = e.Result;
}  
```  
  
 В предыдущем образце `DataContext` для элемента макета `grid` с именем `myPanel` получает в качестве значения данные, возвращаемые методом `GetAlbumList`. `DataContext` позволяет элементам наследовать от своих родительских элементов информацию об источнике данных, используемом для привязки, а также другие характеристики привязки, например путь. Эта строка кода должна выполняться при каждом обновлении данных на сервере. Например, она выполняется при инициализации окна и при добавлении нового альбома.  
  
 В следующем примере XAML-кода для элемента `ListBox` задано, что `ItemsSource="{Binding }"`.  
  
```xml  
<ListBox
          ItemTemplate="{StaticResource AlbumStyle}"  
          ItemsSource="{Binding }"
          IsSynchronizedWithCurrentItem="true" />  
```  
  
 Это указывает, что данные, привязываемые к элементу пользовательского интерфейса верхнего уровня, привязываются также к этому элементу управления (т. е. массиву альбомов). Кроме того, инструкция `ItemTemplate="{StaticResource AlbumStyle}"` задает шаблон данных, который должен использоваться для каждого элемента в `ListBox`. Можно также определять шаблоны данных для задания способа форматирования данных. Эти шаблоны данных можно использовать повторно - для других элементов пользовательского интерфейса в приложении, с тем преимуществом, что шаблон определяется и хранится в одном месте.  
  
 Шаблон данных `AlbumStyle` создает сетку, состоящую из двух расположенных бок о бок элементов `TextBlock`. В одном блоке текста указывается название альбома, а в другом количество дорожек в альбоме.  
  
```xaml  
<DataTemplate x:Key="AlbumStyle">  
    <Grid>  
        <Grid.ColumnDefinitions>  
            <ColumnDefinition Width="260" />  
            <ColumnDefinition Width="60" />  
        </Grid.ColumnDefinitions>  
        <TextBlock Grid.Column="0" TextContent="{Binding Path=Title}" />  
        <TextBlock Grid.Column="1" TextContent="{Binding Path=Tracks#.Count}" HorizontalAlignment="Right" />  
    </Grid>  
</DataTemplate>  
```  
  
 Следующий XAML-код создает второй `ListBox`.  
  
```xaml  
<ListBox Grid.Row="2"
            Grid.ColumnSpan="2"
            ItemTemplate="{StaticResource TrackStyle}"  
            ItemsSource="{Binding Path=Tracks}" />  
```  
  
 В коде задан путь к объекту `ItemsSource`. Это означает, что данные, привязываемые к этому элементу управления, являются не данными верхнего уровня, а свойством данных верхнего уровня с именем `Tracks`. Это свойство представляет собой массив дорожек, содержащихся в альбоме. Кроме того, задан другой шаблон данных `DataTemplate` с именем `TrackStyle`. Макет, создаваемый шаблоном `TrackStyle`, аналогичен макету шаблона `AlbumStyle`, однако элементы `TextBlock` привязаны к другим свойствам. Это связано с тем, что шаблоны используются для разных объектов данных.  
  
### <a name="to-set-up-build-and-run-the-sample"></a>Настройка, сборка и выполнение образца  
  
1. Убедитесь, что вы выполнили [однократную процедуру настройки для Windows Communication Foundation примеров](one-time-setup-procedure-for-the-wcf-samples.md).  
  
2. Чтобы создать выпуск решения на языке C# или Visual Basic .NET, следуйте инструкциям в разделе [Building the Windows Communication Foundation Samples](building-the-samples.md).  
  
3. Чтобы запустить пример в конфигурации с одним или несколькими компьютерами, следуйте инструкциям в разделе [выполнение примеров Windows Communication Foundation](running-the-samples.md).  
  
> [!IMPORTANT]
> Образцы уже могут быть установлены на компьютере. Перед продолжением проверьте следующий каталог (по умолчанию).  
>
> `<InstallDrive>:\WF_WCF_Samples`  
>
> Если этот каталог не существует, перейдите к [примерам Windows Communication Foundation (WCF) и Windows Workflow Foundation (WF) для платформа .NET Framework 4](https://www.microsoft.com/download/details.aspx?id=21459) , чтобы скачать все Windows Communication Foundation (WCF) и [!INCLUDE[wf1](../../../../includes/wf1-md.md)] примеры. Этот образец расположен в следующем каталоге.  
>
> `<InstallDrive>:\WF_WCF_Samples\WCF\Scenario\DataBinding\WPFDataBinding`  
