---
title: Практическое руководство. Наследование форм Windows Forms
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- inherited forms [Windows Forms], creating at run-time
- inheritance [Windows Forms], forms
- Windows Forms, inheritance
ms.assetid: cb3e1c0f-3d2a-4cdc-b0d1-c92eae567ffb
ms.openlocfilehash: 0d8799359a12b9bb64331d83df2500bede8c0ff2
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59314548"
---
# <a name="how-to-inherit-windows-forms"></a>Практическое руководство. Наследование форм Windows Forms
Создание новых форм Windows Forms путем наследования базовых форм является удобным способом для дублирования уже созданного, минуя процесс повторного создания формы с нуля каждый раз, когда она необходима.  
  
 Дополнительные сведения о наследовании форм во время разработки с помощью **Выбор компонентов для наследования** диалоговое окно и как визуально различать уровни безопасности производных элементов управления, см. в разделе [как: Наследование форм с помощью диалогового окна выбора наследования](how-to-inherit-forms-using-the-inheritance-picker-dialog-box.md).  
  
 **Примечание** Чтобы произвести наследование от формы, файл или пространство имен, содержащие форму, должны быть встроены в исполняемый файл или библиотеку DLL. Для сборки проекта выберите в меню **Сборка** пункт **Собрать**. Кроме того необходимо добавить ссылку на пространство имен к классу, наследующему форму. Отображаемые диалоговые окна и команды меню могут отличаться от описанных в справке в зависимости от текущих параметров или выпуска. Чтобы изменить параметры, выберите в меню **Сервис** пункт **Импорт и экспорт параметров** . Дополнительные сведения см. в разделе [Персонализация интегрированной среды разработки Visual Studio](/visualstudio/ide/personalizing-the-visual-studio-ide).  
  
### <a name="to-inherit-a-form-programmatically"></a>Наследование формы программными средствами  
  
1. В классе добавьте ссылку на пространство имен, содержащее форму, которую вы хотите наследовать.  
  
2. В определении класса добавьте ссылку на форму для наследования. Ссылка должна содержать пространство имен, в котором содержится форма, точку, а затем имя базовой формы.  
  
    ```vb  
    Public Class Form2  
        Inherits Namespace1.Form1  
    ```  
  
    ```csharp  
    public class Form2 : Namespace1.Form1  
    ```  
  
 При наследовании форм следует помнить, что могут возникнуть проблемы с обработчиками событий, которые вызываются дважды, так как каждое событие обрабатывается базовым классом и производным классом. Дополнительные сведения о том, как избежать этой проблемы, см. в разделе [Устранение неполадок, связанных с унаследованными обработчиками событий в Visual Basic](~/docs/visual-basic/programming-guide/language-features/events/troubleshooting-inherited-event-handlers.md).  
  
## <a name="see-also"></a>См. также

- [Inherits Statement](~/docs/visual-basic/language-reference/statements/inherits-statement.md)
- [Оператор Imports (пространство имен .NET и тип)](~/docs/visual-basic/language-reference/statements/imports-statement-net-namespace-and-type.md)
- [using](~/docs/csharp/language-reference/keywords/using.md)
- [Влияние изменения внешнего вида базовой формы](effects-of-modifying-base-form-appearance.md)
- [Визуальное наследование в Windows Forms](windows-forms-visual-inheritance.md)
