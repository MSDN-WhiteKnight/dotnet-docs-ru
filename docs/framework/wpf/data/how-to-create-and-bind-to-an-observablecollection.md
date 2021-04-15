---
title: Практическое руководство. Создание и привязка ObservableCollection
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- data binding [WPF], ObservableCollection class
- notifications [WPF]
ms.assetid: 6cf7e275-df76-41c6-a611-53b889b8fd5a
ms.openlocfilehash: 45f8b097bfdb8d3d7994e53ea05146aa6de0fc21
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59188439"
---
# <a name="how-to-create-and-bind-to-an-observablecollection"></a>Практическое руководство. Создание и привязка ObservableCollection
В этом примере показано, как создать и выполнить привязку к коллекции, который является производным от <xref:System.Collections.ObjectModel.ObservableCollection%601> класс, который является классом коллекции, которая выдает уведомления при добавлении или удалении элементов.  
  
## <a name="example"></a>Пример  
 В следующем примере показана реализация коллекции `NameList`.  
  
```csharp  
public class NameList : ObservableCollection<PersonName>  
{  
    public NameList() : base()  
    {  
        Add(new PersonName("Willa", "Cather"));  
        Add(new PersonName("Isak", "Dinesen"));  
        Add(new PersonName("Victor", "Hugo"));  
        Add(new PersonName("Jules", "Verne"));  
    }  
  }  
  
  public class PersonName  
  {  
      private string firstName;  
      private string lastName;  
  
      public PersonName(string first, string last)  
      {  
          this.firstName = first;  
          this.lastName = last;  
      }  
  
      public string FirstName  
      {  
          get { return firstName; }  
          set { firstName = value; }  
      }  
  
      public string LastName  
      {  
          get { return lastName; }  
          set { lastName = value; }  
      }  
  }  
```  
  
```vb  
Public Class NameList  
    Inherits ObservableCollection(Of PersonName)  
  
    ' Methods  
    Public Sub New()  
        MyBase.Add(New PersonName("Willa", "Cather"))  
        MyBase.Add(New PersonName("Isak", "Dinesen"))  
        MyBase.Add(New PersonName("Victor", "Hugo"))  
        MyBase.Add(New PersonName("Jules", "Verne"))  
    End Sub  
  
End Class  
  
Public Class PersonName  
    ' Methods  
    Public Sub New(ByVal first As String, ByVal last As String)  
        Me._firstName = first  
        Me._lastName = last  
    End Sub  
  
    ' Properties  
    Public Property FirstName() As String  
        Get  
            Return Me._firstName  
        End Get  
        Set(ByVal value As String)  
            Me._firstName = value  
        End Set  
    End Property  
  
    Public Property LastName() As String  
        Get  
            Return Me._lastName  
        End Get  
        Set(ByVal value As String)  
            Me._lastName = value  
        End Set  
    End Property  
  
    ' Fields  
    Private _firstName As String  
    Private _lastName As String  
End Class  
```  
  
 Коллекции можно сделать доступными для привязки так же, как с другими объектами CLR, как описано в разделе [Обеспечение доступности данных для привязки в XAML](how-to-make-data-available-for-binding-in-xaml.md). Например, можно создать экземпляр коллекции в XAML и указать коллекцию в качестве ресурса, как показано ниже.  
  
```xaml  
<Window  
  xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"  
  xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"  
  xmlns:c="clr-namespace:SDKSample"  
  x:Class="SDKSample.Window1"  
  Width="400"  
  Height="280"  
  Title="MultiBinding Sample">  
  
  <Window.Resources>  
    <c:NameList x:Key="NameListData"/>  
  
...  
  
</Window.Resources>  
```  
  
 Затем можно выполнить привязку к коллекции:  
  
```xaml  
<ListBox Width="200"  
         ItemsSource="{Binding Source={StaticResource NameListData}}"  
         ItemTemplate="{StaticResource NameItemTemplate}"  
         IsSynchronizedWithCurrentItem="True"/>  
```  
  
 Определение `NameItemTemplate` здесь не показано.  
  
> [!NOTE]
>  Объекты в коллекции должны удовлетворять требованиям, описанным в разделе [Общие сведения об источниках привязки](binding-sources-overview.md). В частности, если вы используете <xref:System.Windows.Data.BindingMode.OneWay> или <xref:System.Windows.Data.BindingMode.TwoWay> (например, требуется вашей UI обновление при динамическом изменении свойств источника), необходимо реализовать механизм уведомлений об подходящий изменения свойств, таких как <xref:System.ComponentModel.INotifyPropertyChanged>интерфейс.  
  
 Дополнительные сведения см. в разделе "Привязка к коллекциям" в разделе [Общие сведения о привязке данных](data-binding-overview.md).  
  
## <a name="see-also"></a>См. также

- [Сортировка данных в представлении](how-to-sort-data-in-a-view.md)
- [Фильтрация данных в представлении](how-to-filter-data-in-a-view.md)
- [Сортировка и группировка данных с помощью представления в XAML](how-to-sort-and-group-data-using-a-view-in-xaml.md)
- [Общие сведения о привязке данных](data-binding-overview.md)
- [Практические руководства](data-binding-how-to-topics.md)
