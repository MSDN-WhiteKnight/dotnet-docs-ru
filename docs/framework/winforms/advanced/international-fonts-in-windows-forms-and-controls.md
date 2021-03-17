---
title: Международные шрифты в Windows Forms и элементы управления
ms.date: 03/30/2017
helpviewer_keywords:
- fonts [Windows Forms], international
- international applications [Windows Forms], character display
- fonts [Windows Forms], globalization considerations
- localization [Windows Forms], fonts
- Windows Forms controls, labels
- font fallback in Windows Forms
- globalization [Windows Forms], character sets
dev_langs:
- csharp
- vb
ms.assetid: 2c3066df-9bac-479a-82b2-79e484b346a3
ms.openlocfilehash: 1f9afd575e2de04e0b11556ad34436839e13d968
ms.sourcegitcommit: 6b308cf6d627d78ee36dbbae8972a310ac7fd6c8
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 01/23/2019
ms.locfileid: "54693244"
---
# <a name="international-fonts-in-windows-forms-and-controls"></a>Международные шрифты в Windows Forms и элементы управления

В приложения на разных языках выбора шрифтов рекомендуется использовать откат шрифта, когда это возможно. Это означает что система определяет, что скрипт символ принадлежит.

## <a name="using-font-fallback"></a>С помощью откат шрифта

Чтобы воспользоваться преимуществами этой функции, не устанавливайте <xref:System.Drawing.Font> свойство для форм или любого другого элемента. Приложение будет автоматически использовать системный шрифт по умолчанию, который отличается от языка локализованной операционной системы в другую. При запуске приложения, система автоматически выбирает правильный шрифт для языка и региональных параметров, выбранных в операционной системе.

Имеется исключение из правила шрифта, который предназначен для изменения стиля шрифта. Это может оказаться важным для приложения, в котором пользователь нажимает кнопку, чтобы текст в текстовом поле отображаются полужирным шрифтом. Чтобы сделать это, следует написать функцию, чтобы изменить стиль шрифта текстового поля будут выводиться полужирным шрифтом, в зависимости от независимо от формы шрифта. Очень важно для вызова этой функции в двух местах: в кнопки <xref:System.Windows.Forms.Control.Click> обработчик событий и в <xref:System.Windows.Forms.Control.FontChanged> обработчик событий. Если функция вызывается только в <xref:System.Windows.Forms.Control.Click> обработчик событий и некоторых других фрагмент кода изменяет семейство шрифтов для всей формы, текстовое поле не изменяется с остальной частью формы.

```vb
Private Sub MakeBold()
   ' Change the TextBox to a bold version of the form font
   TextBox1.Font = New Font(Me.Font, FontStyle.Bold)
End Sub

Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
   ' Clicking this button makes the TextBox bold
   MakeBold()
End Sub

Private Sub Form1_FontChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.FontChanged
   ' If the TextBox is already bold and the form's font changes,
   ' change the TextBox to a bold version of the new form font
   If (TextBox1.Font.Style = FontStyle.Bold) Then
      MakeBold()
   End If
End Sub
```

```csharp
private void button1_Click(object sender, System.EventArgs e)
{
   // Clicking this button makes the TextBox bold
   MakeBold();
}

private void MakeBold()
{
   // Change the TextBox to a bold version of the form's font
   textBox1.Font = new Font(this.Font, FontStyle.Bold);
}

private void Form1_FontChanged(object sender, System.EventArgs e)
{
   // If the TextBox is already bold and the form's font changes,
   // change the TextBox to a bold version of the new form font
   if (textBox1.Font.Style == FontStyle.Bold)
   {
      MakeBold();
   }
}
```

Тем не менее при локализации приложения, полужирный шрифт может отображать плохо для определенных языков. Если это представляет собой проблему, вы локализаторам возможность переключения шрифта с жирного шрифта на обычный текст. Поскольку локализаторы обычно не являются разработчиками, а не имеют доступа к исходному коду, только с файлами ресурсов, этот параметр необходимо задать в файлах ресурсов. Чтобы сделать это, необходимо установить <xref:System.Drawing.Font.Bold%2A> свойства `true`. Результатом начертание шрифта, которая записывается в файлы ресурсов, где его можно изменить локализаторов. Затем написать код после `InitializeComponent` метод, который сбрасывает шрифт в зависимости от шрифта независимо от формы, но использует стиль шрифта, указанное в файле ресурсов.

```vb
TextBox1.Font = New System.Drawing.Font(Me.Font, TextBox1.Font.Style)
```

```csharp
textBox1.Font = new System.Drawing.Font(this.Font, textBox1.Font.Style);
```
  
## <a name="see-also"></a>См. также

- [Глобализация приложений Windows Forms](globalizing-windows-forms.md)
- [Работами со шрифтами и текстом](using-fonts-and-text.md)
