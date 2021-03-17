---
title: Практическое руководство. Добавление элементов управления, для которых не существует пользовательского интерфейса, в формы Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
f1_keywords:
- NonVisualSelection
helpviewer_keywords:
- invisible controls [Windows Forms]
- Windows Forms controls, adding to form
- controls [Windows Forms], nonvisual
- Windows Forms controls, nonvisual
- nonvisual controls [Windows Forms]
ms.assetid: 52134d9c-cff6-4eed-8e2b-3d5eb3bd494e
ms.openlocfilehash: 0768f811653543b3370310ccc0b59890273baf52
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59330107"
---
# <a name="how-to-add-controls-without-a-user-interface-to-windows-forms"></a>Практическое руководство. Добавление элементов управления, для которых не существует пользовательского интерфейса, в формы Windows Forms
Невизуального элемента управления (или компонент) предоставляет функциональные возможности приложения. В отличие от других элементов управления компоненты не предоставляют пользовательский интерфейс для пользователя и таким образом не обязательно должны отображаться в рабочей области конструктора Windows Forms. При добавлении компонента в форму, в конструкторе Windows Forms отображает изменяемого в нижней части формы, в которой отображаются все компоненты. После добавления элемента управления в область компонентов, можно выбрать компонент и задайте свойства, как и любой другой элемент управления в форме.  
  
> [!NOTE]
>  Отображаемые диалоговые окна и команды меню могут отличаться от описанных в справке в зависимости от текущих параметров или выпуска. Чтобы изменить параметры, выберите в меню **Сервис** пункт **Импорт и экспорт параметров** . Дополнительные сведения см. в разделе [Персонализация интегрированной среды разработки Visual Studio](/visualstudio/ide/personalizing-the-visual-studio-ide).  
  
### <a name="to-add-a-component-to-a-windows-form"></a>Добавление компонента в форму Windows  
  
1. Откройте форму. Подробную информацию см. в разделе [Практическое руководство. Отображение в конструкторе Windows Forms](https://docs.microsoft.com/previous-versions/visualstudio/visual-studio-2010/w5yd62ts(v=vs.100)).  
  
2. На **панели элементов** щелкните компонент и перетащите его на форму.  
  
     Компонент появится в области компонентов.  
  
 Кроме того компоненты можно добавить в форму во время выполнения. Это распространенный сценарий, особенно в том случае, поскольку компоненты не имеют визуального выражения, в отличие от элементов управления, имеющих пользовательский интерфейс. В следующем примере <xref:System.Windows.Forms.Timer> компонент добавляется во время выполнения. (Обратите внимание на то, что Visual Studio содержит ряд различных таймеров; в этом случае используйте форм Windows <xref:System.Windows.Forms.Timer> компонента. Дополнительные сведения о различных таймеров в Visual Studio, см. в разделе [Общие сведения о серверных таймерах](https://docs.microsoft.com/previous-versions/visualstudio/visual-studio-2008/tb9yt5e6(v=vs.90)).)  
  
> [!CAUTION]
>  Компоненты часто имеют особые свойства, которые должны быть заданы для их эффективной работы. В случае использования компонента <xref:System.Windows.Forms.Timer> в приведенном ниже примере задается свойство `Interval`.  Убедитесь, что при добавлении компонентов в проект вы задаете необходимые свойства этих компонентов.  
  
#### <a name="to-add-a-component-to-a-windows-form-programmatically"></a>Добавление компонента в форму Windows программными средствами  
  
1. Создайте экземпляр класса <xref:System.Windows.Forms.Timer> в коде.  
  
2. Задайте свойство `Interval` для определения времени между тактами таймера.  
  
3. Настройте другие необходимые свойства компонента.  
  
     В следующем коде показано создание <xref:System.Windows.Forms.Timer> и установка его свойства `Interval`.  
  
    ```vb  
    Public Sub CreateTimer()  
       Dim timerKeepTrack As New System.Windows.Forms.Timer  
       timerKeepTrack.Interval = 1000  
    End Sub  
    ```  
  
    ```csharp  
    public void createTimer()  
    {  
       System.Windows.Forms.Timer timerKeepTrack = new  
           System.Windows.Forms.Timer();  
       timerKeepTrack.Interval = 1000;  
    }  
    ```  
  
    ```cpp  
    public:  
       void createTimer()  
       {  
          System::Windows::Forms::Timer^ timerKeepTrack = gcnew  
             System::Windows::Forms::Timer();  
          timerKeepTrack->Interval = 1000;  
       }  
    ```  
  
    > [!IMPORTANT]
    >  Создание ссылки на вредоносный элемент `UserControl` может поставить локальный компьютер под угрозу атаки по сети. Это может произойти только в том случае, если злоумышленник создаст небезопасный пользовательский элемент управления, а затем вы по ошибке добавите его в проект.  
  
## <a name="see-also"></a>См. также

- [Элементы управления Windows Forms](index.md)
- [Практическое руководство. Добавление элементов управления в формы Windows Forms](how-to-add-controls-to-windows-forms.md)
- [Практическое руководство. Добавление элементов управления ActiveX в формы Windows Forms](how-to-add-activex-controls-to-windows-forms.md)
- [Практическое руководство. Копирование элементов управления между формами Windows Forms](how-to-copy-controls-between-windows-forms.md)
- [Размещение элементов управления в формах Windows Forms](putting-controls-on-windows-forms.md)
- [Создание меток и назначение сочетаний клавиш для элементов управления Windows Forms](labeling-individual-windows-forms-controls-and-providing-shortcuts-to-them.md)
- [Элементы управления для использования в формах Windows Forms](controls-to-use-on-windows-forms.md)
- [Функциональная классификация элементов управления Windows Forms](windows-forms-controls-by-function.md)
