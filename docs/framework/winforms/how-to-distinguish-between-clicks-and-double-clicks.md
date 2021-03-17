---
title: Практическое руководство. Распознавание одиночных и двойных щелчков
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
- cpp
helpviewer_keywords:
- mouse [Windows Forms], click
- mouse [Windows Forms], double-click
- mouse clicks [Windows Forms], single versus double
ms.assetid: d836ac8c-85bc-4f3a-a761-8aee03dc682c
ms.openlocfilehash: 26b3a64533747e80c7b9270918030da76d5e00c9
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59139403"
---
# <a name="how-to-distinguish-between-clicks-and-double-clicks"></a>Практическое руководство. Распознавание одиночных и двойных щелчков
Как правило, одиночное событие *щелчок* инициирует действие пользовательского интерфейса, а событие *двойной щелчок* расширяет его. Например, одним щелчком мыши обычно выбирается элемент, а двойным щелчком мыши этот элемент изменяется. Однако события щелчков Windows Forms непросто приспособить к сценарию, в котором щелчок и двойной щелчок выполняют несовместимые действия, поскольку действие, привязанное к событию <xref:System.Windows.Forms.Control.Click> или <xref:System.Windows.Forms.Control.MouseClick>, выполняется перед действием, привязанным к событию <xref:System.Windows.Forms.Control.DoubleClick> или <xref:System.Windows.Forms.Control.MouseDoubleClick>. В этом разделе показаны два способа решения этой проблемы. Одним из решений является обработка события двойного щелчка и откат действий при обработке события щелчка. В редких случаях может потребоваться имитировать поведение при одинарном и двойном щелчке при обработке событий <xref:System.Windows.Forms.Control.MouseDown> и с помощью свойств <xref:System.Windows.Forms.SystemInformation.DoubleClickTime%2A> и <xref:System.Windows.Forms.SystemInformation.DoubleClickSize%2A> класса <xref:System.Windows.Forms.SystemInformation>. Производится измерение времени между щелчками мышью и, если второе нажатие происходит до того, как <xref:System.Windows.Forms.SystemInformation.DoubleClickTime%2A> достигнет значения и кнопка мыши была нажата, когда курсор находился в прямоугольнике, заданном <xref:System.Windows.Forms.SystemInformation.DoubleClickSize%2A>, то выполняется действие двойного щелчка; в противном случае выполняется действие щелчка.  
  
### <a name="to-roll-back-a-click-action"></a>Выполнение отката щелчка кнопкой мыши  
  
-   Убедитесь, что элемент управления, с которым вы работаете, имеет стандартное поведение при двойном щелчке мышью. В противном случае задействуйте элемент управления с помощью метода <xref:System.Windows.Forms.Control.SetStyle%2A>. Обработайте событие двойного щелчка и откат к одиночному щелчку кнопкой мыши, а также действие двойного щелчка. В следующем примере кода показано, как создать пользовательскую кнопку с включенным двойным щелчком мыши, а также как откатить к одиночному щелчку в коде обработки событий двойного щелчка.  
  
     [!code-csharp[System.Windows.Forms.ButtonDoubleClick#1](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.ButtonDoubleClick/CS/Form1.cs#1)]
     [!code-vb[System.Windows.Forms.ButtonDoubleClick#1](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Windows.Forms.ButtonDoubleClick/VB/Form1.vb#1)]  
  
### <a name="to-distinguish-between-clicks-in-the-mousedown-event"></a>Различение щелчков в событии MouseDown  
  
-   Обработайте событие <xref:System.Windows.Forms.Control.MouseDown> и определите расположение и временной интервал между щелчками с помощью соответствующего свойства <xref:System.Windows.Forms.SystemInformation> и компонента <xref:System.Windows.Forms.Timer>. Выполните необходимые действия в зависимости от того, имеет ли место щелчок или двойной щелчок кнопкой мыши. В следующем примере кода показано, как это сделать.  
  
     [!code-cpp[System.Windows.Forms.SingleVersusDoubleClick#0](~/samples/snippets/cpp/VS_Snippets_Winforms/System.Windows.Forms.SingleVersusDoubleClick/cpp/form1.cpp#0)]
     [!code-csharp[System.Windows.Forms.SingleVersusDoubleClick#0](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.SingleVersusDoubleClick/CS/form1.cs#0)]
     [!code-vb[System.Windows.Forms.SingleVersusDoubleClick#0](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Windows.Forms.SingleVersusDoubleClick/VB/form1.vb#0)]  
  
## <a name="compiling-the-code"></a>Компиляция кода  
 Для этих примеров требуются:  
  
-   ссылки на сборки System, System.Drawing и System.Windows.Forms.  
  
 Сведения о сборке этих примеров из командной строки для Visual Basic или Visual C#, см. в разделе [построение из командной строки](../../visual-basic/reference/command-line-compiler/building-from-the-command-line.md) или [командной строки создания с помощью csc.exe](../../csharp/language-reference/compiler-options/command-line-building-with-csc-exe.md). Следующие примеры в Visual Studio можно также создать, вставив код в новый проект.  
  
## <a name="see-also"></a>См. также

- [Ввод данных мышью в приложении Windows Forms](mouse-input-in-a-windows-forms-application.md)
