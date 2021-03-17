---
title: Практическое руководство. Разработка простого элемента управления форм Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- controls [Windows Forms]
- custom controls [Windows Forms], creating simple controls using code
- Control class [Windows Forms], Windows Forms
ms.assetid: 86cbe435-45b7-4cb4-9b5a-47418369758d
ms.openlocfilehash: 457069cd7ac5af62e08115d84060c9c7fb25beee
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59328144"
---
# <a name="how-to-develop-a-simple-windows-forms-control"></a>Практическое руководство. Разработка простого элемента управления форм Windows Forms
В этом разделе рассматриваются основные этапы создания пользовательского элемента управления Windows Forms. Простой элемент управления, разработанный в этом пошаговом руководстве, позволяет изменять выравнивание его <xref:System.Windows.Forms.Control.Text%2A> значение изменяемого свойства. Он не вызывает и не обрабатывает события.  
  
### <a name="to-create-a-simple-custom-control"></a>Создание простого пользовательского элемента управления  
  
1. Определите класс, производный от класса <xref:System.Windows.Forms.Control?displayProperty=nameWithType>.  
  
    ```vb  
    Public Class FirstControl  
       Inherits Control  
  
    End Class  
    ```  
  
    ```csharp  
    public class FirstControl:Control {}  
    ```  
  
2. Определите свойства. (Не является обязательным для определения свойств, так как элемент управления наследует многие свойства из <xref:System.Windows.Forms.Control> класс, но большинство пользовательских элементов управления обычно определяются дополнительные свойства.) В следующем фрагменте кода определяется свойство с именем `TextAlignment` , `FirstControl` используется для форматирования отображения <xref:System.Windows.Forms.Control.Text%2A> свойство унаследовано от <xref:System.Windows.Forms.Control>. Дополнительные сведения об определении свойств см. в разделе [Общие сведения о свойствах](https://docs.microsoft.com/previous-versions/visualstudio/visual-studio-2013/65zdfbdt(v%3dvs.120)).  
  
     [!code-csharp[System.Windows.Forms.FirstControl#3](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.FirstControl/CS/FirstControl.cs#3)]
     [!code-vb[System.Windows.Forms.FirstControl#3](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Windows.Forms.FirstControl/VB/FirstControl.vb#3)]  
  
     Устанавливая свойство, изменяющее визуальное отображение элемента управления, необходимо вызвать <xref:System.Windows.Forms.Control.Invalidate%2A> метод для перерисовки элемента управления. <xref:System.Windows.Forms.Control.Invalidate%2A> определен в базовом классе <xref:System.Windows.Forms.Control>.  
  
3. Переопределите защищенный <xref:System.Windows.Forms.Control.OnPaint%2A> наследует метод <xref:System.Windows.Forms.Control> для предоставления логику отрисовки элемента управления. Если не переопределить <xref:System.Windows.Forms.Control.OnPaint%2A>, элемент управления не будет возможность рисования самого себя. В следующем фрагменте кода <xref:System.Windows.Forms.Control.OnPaint%2A> метод выводит <xref:System.Windows.Forms.Control.Text%2A> свойство унаследовано от <xref:System.Windows.Forms.Control> , а его выравнивание по `alignmentValue` поля.  
  
     [!code-csharp[System.Windows.Forms.FirstControl#4](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.FirstControl/CS/FirstControl.cs#4)]
     [!code-vb[System.Windows.Forms.FirstControl#4](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Windows.Forms.FirstControl/VB/FirstControl.vb#4)]  
  
4. Укажите атрибуты для своего элемента управления. Атрибуты позволяют визуальному конструктору адекватно отображать ваш элемент управления, а также его свойства и события во время разработки. Код в следующем фрагменте применяет атрибуты к свойству `TextAlignment`. В конструкторе, например Visual Studio <xref:System.ComponentModel.CategoryAttribute.Category%2A> атрибут (показанный в фрагменте кода) вызывает отображение свойства для отображения логической категории. <xref:System.ComponentModel.DescriptionAttribute.Description%2A> Атрибут приводит к строку описания, которое должно отображаться в нижней части **свойства** окно при `TextAlignment` было выбрано свойство. Дополнительные сведения об атрибутах см. в разделе [Атрибуты времени разработки для компонентов](https://docs.microsoft.com/previous-versions/visualstudio/visual-studio-2013/tk67c2t8(v=vs.120)).  
  
     [!code-csharp[System.Windows.Forms.FirstControl#5](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.FirstControl/CS/FirstControl.cs#5)]
     [!code-vb[System.Windows.Forms.FirstControl#5](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Windows.Forms.FirstControl/VB/FirstControl.vb#5)]  
  
5. (Необязательно.) Предоставьте элементу управления ресурсы. Чтобы предоставить элементу управления ресурс, такой как растровое изображение, можно использовать параметр компилятора (`/res` для C#), позволяющий упаковать ресурсы с элементом управления. Во время выполнения ресурс можно получить с помощью методов класса <xref:System.Resources.ResourceManager> класса. Более подробную информацию о создании и использовании ресурсов см. в разделе [Ресурсы в приложениях для настольных систем](../../resources/index.md).  
  
6. Скомпилируйте и разверните элемент управления. Чтобы скомпилировать и развернуть `FirstControl,`, выполните следующие действия.  
  
    1.  Сохраните код из представленного ниже примера в исходный файл (например, FirstControl.cs или FirstControl.vb).  
  
    2.  Скомпилируйте исходный код в сборку и сохраните его в каталог приложения. Для этого выполните следующую команду из каталога, содержащего исходный файл.  
  
        ```console  
        vbc -t:library -out:[path to your application's directory]/CustomWinControls.dll -r:System.dll -r:System.Windows.Forms.dll -r:System.Drawing.dll FirstControl.vb  
        ```  
  
        ```console 
        csc -t:library -out:[path to your application's directory]/CustomWinControls.dll -r:System.dll -r:System.Windows.Forms.dll -r:System.Drawing.dll FirstControl.cs  
        ```  
  
         Параметр компилятора `/t:library` сообщает компилятору, что создаваемая сборка является библиотекой (а не исполняемым файлом). Параметр `/out` определяет путь и имя сборки. Параметр `/r` определяет имена сборок, на которые ссылается код. В этом примере создается закрытая сборка, которую могут использовать только ваши приложения. Это значит, что сохранить ее в каталог приложения нельзя. Дополнительные сведения об упаковке и развертывании элемента управления, который нужно распределить, см. в разделе [Развертывание](../../deployment/index.md).  
  
 В следующем примере показан код для `FirstControl`. Элемент управления помещается в пространство имен `CustomWinControls`. Это пространство имен обеспечивает логическое группирование связанных типов. Элемент управления можно создавать в новом или в уже существующем пространстве имен. В C# объявление `using` (в Visual Basic `Imports`) обеспечивает доступ к типам из пространства имен без использования полного имени типа. В следующем примере `using` объявление позволяет коду получать доступ к классу <xref:System.Windows.Forms.Control> из <xref:System.Windows.Forms?displayProperty=nameWithType> просто <xref:System.Windows.Forms.Control> вместо того чтобы использовать полное доменное имя <xref:System.Windows.Forms.Control?displayProperty=nameWithType>.  
  
 [!code-csharp[System.Windows.Forms.FirstControl#1](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.FirstControl/CS/FirstControl.cs#1)]
 [!code-vb[System.Windows.Forms.FirstControl#1](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Windows.Forms.FirstControl/VB/FirstControl.vb#1)]  
  
## <a name="using-the-custom-control-on-a-form"></a>Использование пользовательского элемента управления в форме  
 В следующем примере показана простая форма с использованием `FirstControl`. Она создает три экземпляра `FirstControl` с разными значениями свойства `TextAlignment`.  
  
#### <a name="to-compile-and-run-this-sample"></a>Компиляция и выполнение примера  
  
1. Сохраните код в следующем примере в исходный файл (SimpleForm.cs или SimpleForms.vb).  
  
2. Скомпилируйте исходный код в исполняемую сборку, выполнив следующую команду из каталога, содержащего исходный файл.  
  
    ```console  
    vbc -r:CustomWinControls.dll -r:System.dll -r:System.Windows.Forms.dll -r:System.Drawing.dll SimpleForm.vb  
    ```  
  
    ```console 
    csc -r:CustomWinControls.dll -r:System.dll -r:System.Windows.Forms.dll -r:System.Drawing.dll SimpleForm.cs  
    ```  
  
     Customwincontrols.dll — это сборка, содержащая класс `FirstControl`. Эта сборка должна находиться в том же каталоге, что и исходный файл для формы, которая к ней обращается (SimpleForm.cs или SimpleForms.vb).  
  
3. Выполните файла SimpleForm.exe с помощью следующей команды.  
  
    ```console
    SimpleForm  
    ```  
  
 [!code-csharp[System.Windows.Forms.FirstControl#10](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.FirstControl/CS/SimpleForm.cs#10)]
 [!code-vb[System.Windows.Forms.FirstControl#10](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Windows.Forms.FirstControl/VB/SimpleForm.vb#10)]  
  
## <a name="see-also"></a>См. также

- [Свойства элементов управления Windows Forms](properties-in-windows-forms-controls.md)
- [События элементов управления Windows Forms](events-in-windows-forms-controls.md)
