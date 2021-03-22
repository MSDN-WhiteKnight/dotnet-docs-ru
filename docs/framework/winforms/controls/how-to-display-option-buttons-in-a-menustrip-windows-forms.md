---
title: Практическое руководство. Отображение переключателей в элементе управления MenuStrip (Windows Forms)
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- MenuStrip [Windows Forms], displaying option buttons
- displaying option buttons [Windows Forms], MenuStrip [Windows Forms]
- option buttons [Windows Forms], displaying in MenuStrip
ms.assetid: 8b596af2-9ff8-4f7b-93d7-cba830e167f4
ms.openlocfilehash: e764c7e181870d8faf6157cacc13164977ce2e3b
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59306239"
---
# <a name="how-to-display-option-buttons-in-a-menustrip-windows-forms"></a>Практическое руководство. Отображение переключателей в элементе управления MenuStrip (Windows Forms)
Похожи переключателей, также известный как переключатели, флажки, за исключением того, что пользователи могут выбрать только один раз. Несмотря на то что по умолчанию <xref:System.Windows.Forms.ToolStripMenuItem> класс не предоставляет поведение переключателей, класс обеспечивает поведение "флажок", которое можно настроить для реализации поведения переключателей для пунктов меню в <xref:System.Windows.Forms.MenuStrip> элемента управления.  
  
 Когда <xref:System.Windows.Forms.ToolStripMenuItem.CheckOnClick%2A> свойство пункта меню `true`, пользователь может щелкнуть элемент, чтобы показать или скрыть метку. <xref:System.Windows.Forms.ToolStripMenuItem.Checked%2A> Свойство указывает текущее состояние элемента. Для реализации поведения базовый переключатель, вы должны убедиться, что при выборе элемента <xref:System.Windows.Forms.ToolStripMenuItem.Checked%2A> свойство для ранее выбранный элемент в `false`.  
  
 Следующие процедуры описывают способы реализации это так и дополнительную функциональность в класс, наследующий <xref:System.Windows.Forms.ToolStripMenuItem> класса. `ToolStripRadioButtonMenuItem` Класс переопределяет члены, такие как <xref:System.Windows.Forms.ToolStripMenuItem.OnCheckedChanged%2A> и <xref:System.Windows.Forms.ToolStripMenuItem.OnPaint%2A> для предоставления выбора поведение и внешний вид кнопки. Кроме того, этот класс переопределяет <xref:System.Windows.Forms.ToolStripMenuItem.Enabled%2A> свойство, параметры в подменю отключены, если не выбран родительский элемент.  
  
### <a name="to-implement-option-button-selection-behavior"></a>Для реализации поведения выбора переключателей  
  
1. Инициализировать <xref:System.Windows.Forms.ToolStripMenuItem.CheckOnClick%2A> свойства `true` Включение выбора элемента.  
  
     [!code-csharp[ToolStripRadioButtonMenuItem#110](~/samples/snippets/csharp/VS_Snippets_Winforms/ToolStripRadioButtonMenuItem/cs/ToolStripRadioButtonMenuItem.cs#110)]
       
  
2. Переопределить <xref:System.Windows.Forms.ToolStripMenuItem.OnCheckedChanged%2A> метод, чтобы снять выделение ранее выбранного элемента, если элемент выбран.  
  
     [!code-csharp[ToolStripRadioButtonMenuItem#120](~/samples/snippets/csharp/VS_Snippets_Winforms/ToolStripRadioButtonMenuItem/cs/ToolStripRadioButtonMenuItem.cs#120)]
       
  
3. Переопределить <xref:System.Windows.Forms.ToolStripMenuItem.OnClick%2A> метод, чтобы гарантировать, что нажатие кнопки элемента, который уже был выбран не очищает выделение.  
  
     [!code-csharp[ToolStripRadioButtonMenuItem#130](~/samples/snippets/csharp/VS_Snippets_Winforms/ToolStripRadioButtonMenuItem/cs/ToolStripRadioButtonMenuItem.cs#130)]
       
  
### <a name="to-modify-the-appearance-of-the-option-button-items"></a>Чтобы изменить внешний вид элементов переключателей  
  
1. Переопределить <xref:System.Windows.Forms.ToolStripMenuItem.OnPaint%2A> метод для замены по умолчанию — флажок кнопки выбора параметра с помощью <xref:System.Windows.Forms.RadioButtonRenderer> класса.  
  
     [!code-csharp[ToolStripRadioButtonMenuItem#140](~/samples/snippets/csharp/VS_Snippets_Winforms/ToolStripRadioButtonMenuItem/cs/ToolStripRadioButtonMenuItem.cs#140)]
       
  
2. Переопределить <xref:System.Windows.Forms.ToolStripMenuItem.OnMouseEnter%2A>, <xref:System.Windows.Forms.ToolStripMenuItem.OnMouseLeave%2A>, <xref:System.Windows.Forms.ToolStripMenuItem.OnMouseDown%2A>, и <xref:System.Windows.Forms.ToolStripMenuItem.OnMouseUp%2A> методы для отслеживания состояния мыши и убедитесь, что <xref:System.Windows.Forms.ToolStripMenuItem.OnPaint%2A> метод рисует состояния правильный переключателя.  
  
     [!code-csharp[ToolStripRadioButtonMenuItem#150](~/samples/snippets/csharp/VS_Snippets_Winforms/ToolStripRadioButtonMenuItem/cs/ToolStripRadioButtonMenuItem.cs#150)]
       
  
### <a name="to-disable-options-on-a-submenu-when-the-parent-item-is-not-selected"></a>Отключение пунктов подменю, если родительский элемент не выбран  
  
1. Переопределить <xref:System.Windows.Forms.ToolStripMenuItem.Enabled%2A> свойства таким образом, элемент остается недоступной, если он имеет родительский элемент с обоими <xref:System.Windows.Forms.ToolStripMenuItem.CheckOnClick%2A> значение `true` и <xref:System.Windows.Forms.ToolStripMenuItem.Checked%2A> значение `false`.  
  
     [!code-csharp[ToolStripRadioButtonMenuItem#160](~/samples/snippets/csharp/VS_Snippets_Winforms/ToolStripRadioButtonMenuItem/cs/ToolStripRadioButtonMenuItem.cs#160)]
       
  
2. Переопределить <xref:System.Windows.Forms.ToolStripMenuItem.OnOwnerChanged%2A> метод подписаться на <xref:System.Windows.Forms.ToolStripMenuItem.CheckedChanged> событий родительского элемента.  
  
     [!code-csharp[ToolStripRadioButtonMenuItem#170](~/samples/snippets/csharp/VS_Snippets_Winforms/ToolStripRadioButtonMenuItem/cs/ToolStripRadioButtonMenuItem.cs#170)]
       
  
3. В обработчике родительского элемента <xref:System.Windows.Forms.ToolStripMenuItem.CheckedChanged> событий, сделайте элемент для обновления экрана с новым состоянием включено.  
  
     [!code-csharp[ToolStripRadioButtonMenuItem#180](~/samples/snippets/csharp/VS_Snippets_Winforms/ToolStripRadioButtonMenuItem/cs/ToolStripRadioButtonMenuItem.cs#180)]
       
  
## <a name="example"></a>Пример  
 В следующем примере кода приводится полное описание `ToolStripRadioButtonMenuItem` класса и <xref:System.Windows.Forms.Form> класса и `Program` для демонстрации поведения переключателей.  
  
 [!code-csharp[ToolStripRadioButtonMenuItem#000](~/samples/snippets/csharp/VS_Snippets_Winforms/ToolStripRadioButtonMenuItem/cs/ToolStripRadioButtonMenuItem.cs#000)]
   
  
## <a name="compiling-the-code"></a>Компиляция кода  
 Для этого примера требуются:  
  
-   ссылки на сборки System, System.Drawing и System.Windows.Forms.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.MenuStrip>
- <xref:System.Windows.Forms.ToolStripMenuItem>
- <xref:System.Windows.Forms.ToolStripMenuItem.CheckOnClick%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.ToolStripMenuItem.Checked%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.ToolStripMenuItem.OnCheckedChanged%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.ToolStripMenuItem.OnPaint%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.ToolStripMenuItem.Enabled%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.RadioButtonRenderer>
- [Элемент управления MenuStrip](menustrip-control-windows-forms.md)
- [Практическое руководство. Реализация пользовательского класса, производного от ToolStripRenderer](how-to-implement-a-custom-toolstriprenderer.md)
