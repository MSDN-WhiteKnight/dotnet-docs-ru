---
title: Советы по использованию элемента управления TableLayoutPanel
ms.date: 03/30/2017
helpviewer_keywords:
- layout [Windows Forms]
- TableLayoutPanel control [Windows Forms], best practices
- forms [Windows Forms], best practices
- AutoSize property [Windows Forms], tableLayoutPanel control
- controls [Windows Forms], sizing
- TableLayoutPanel control [Windows Forms], AutoSize behavior
- layout [Windows Forms], AutoSize
- layout [Windows Forms], best practices
- best practices [Windows Forms], tableLayoutPanel control
- sizing [Windows Forms], automatic
- automatic sizing
ms.assetid: b6706efb-d7a4-45ec-8cf4-08fa993e3afb
ms.openlocfilehash: 57abf3527af146f1ce918bcabbc6a5a34bfb9b34
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59222332"
---
# <a name="best-practices-for-the-tablelayoutpanel-control"></a>Советы по использованию элемента управления TableLayoutPanel
<xref:System.Windows.Forms.TableLayoutPanel> Элемент управления предоставляет набор мощных функций, которые следует внимательно рассмотреть перед использованием в формах Windows.  
  
## <a name="recommendations"></a>Рекомендации  
 Следующие рекомендации помогут вам использовать <xref:System.Windows.Forms.TableLayoutPanel> управления его преимущества.  
  
### <a name="targeted-use"></a>Целевое использование  
 Используйте <xref:System.Windows.Forms.TableLayoutPanel> управлять только в случае необходимости. Его не следует использовать во всех ситуациях, для создания макетов. В следующем списке описываются макеты, наиболее полезным использование <xref:System.Windows.Forms.TableLayoutPanel> управления:  
  
-   Макеты, в которых имеется несколько областей формы, которые изменяют размер пропорционально друг к другу.  
  
-   Макеты, которые будут изменены или создается динамически во время выполнения, например формы ввода данных, которые имеют настраиваемые поля, добавляется или вычитается на основе параметров.  
  
-   Макеты, которые должны оставаться в общую фиксированного размера. Например имеется диалоговое окно, которое должно остаться меньше, чем 800 x 600, но необходима поддержка локализованных строк.  
  
 В следующем списке описываются макеты, которые не выигрывают от использования значительно <xref:System.Windows.Forms.TableLayoutPanel> управления:  
  
-   Простые формы ввода данных с одним столбцом меток и один столбец из областей ввода текста.  
  
-   Формы с одной большой областью отображения, которая должна заполнить все доступное пространство, при изменении размера. Пример этого — это форма, отображается одна <xref:System.Windows.Forms.PropertyGrid> элемента управления. В этом случае используйте привязку, так как ничего должен расширяться при изменении размера формы.  
  
 Тщательно выбирайте, какие элементы управления должны находиться в <xref:System.Windows.Forms.TableLayoutPanel> элемента управления. Если у вас достаточно места для текста, чтобы увеличить на 30% с использованием привязки, рассмотрите возможность использования <xref:System.Windows.Forms.Control.Anchor%2A> только свойство. Если можно оценить пространство, необходимое для макета, использование <xref:System.Windows.Forms.Control.Dock%2A> и <xref:System.Windows.Forms.Control.Anchor%2A> проще, чем оценка сведения оставшегося пространства и <xref:System.Windows.Forms.Control.AutoSize%2A> поведение.  
  
 В целом при разработке макета с <xref:System.Windows.Forms.TableLayoutPanel> управления, простоту архитектуры.  
  
### <a name="use-the-document-outline-window"></a>Используйте окно "Структура документа"  
 Окно "Структура документа" дает древовидным представлением макета, в котором можно использовать для управления z порядок и иерархические связи для элементов управления. Из **меню "Вид"** выберите **Other Windows**, а затем выберите **Структура документа**.  
  
### <a name="avoid-nesting"></a>Старайтесь не использовать  
 Старайтесь не использовать другие <xref:System.Windows.Forms.TableLayoutPanel> внутри элементов управления <xref:System.Windows.Forms.TableLayoutPanel> элемента управления. Отладка вложенных макетов может быть затруднено.  
  
### <a name="avoid-visual-inheritance"></a>Избегайте визуального наследования  
 <xref:System.Windows.Forms.TableLayoutPanel> Управления не поддерживает визуальное наследование в конструкторе Windows Forms. Объект <xref:System.Windows.Forms.TableLayoutPanel> элемента управления в производном классе отображается как «заблокирован» во время разработки.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.TableLayoutPanel>
- <xref:System.Windows.Forms.FlowLayoutPanel>
