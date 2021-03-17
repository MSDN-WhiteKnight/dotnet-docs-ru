---
title: Общие сведения об элементе управления ProgressBar (Windows Forms)
ms.date: 03/30/2017
f1_keywords:
- ProgressBar
helpviewer_keywords:
- ProgressBar control [Windows Forms], about ProgressBar control
- progress controls [Windows Forms], about progress controls
ms.assetid: a05d9cba-3a6a-4f8f-94b8-8ec12799fb80
ms.openlocfilehash: 24b47669cdf8ed0a8f0f936b0b3b9c354e62445f
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59227500"
---
# <a name="progressbar-control-overview-windows-forms"></a>Общие сведения об элементе управления ProgressBar (Windows Forms)
> [!IMPORTANT]
>  Элемент управления <xref:System.Windows.Forms.ToolStripProgressBar> заменяет элемент управления <xref:System.Windows.Forms.ProgressBar> и расширяет его функциональные возможности; однако при необходимости элемент управления <xref:System.Windows.Forms.ProgressBar> можно сохранить для обратной совместимости и использования в будущем.  
  
 Windows Forms <xref:System.Windows.Forms.ProgressBar> элемент управления показывает ход выполнения процесса, отображение на соответствующее число прямоугольников, расположенных на горизонтальной полосе. По завершении процесса панели будет заполнено. Индикаторы выполнения обычно используются для предоставления пользователю представление о том, как долго ждать процесса для завершения; Например, при большой файл загрузке.  
  
> [!NOTE]
>  <xref:System.Windows.Forms.ProgressBar> Управления можно только быть горизонтальную ориентацию в форме.  
  
## <a name="key-properties-and-methods"></a>Ключевые свойства и методы  
 Ключевые свойства <xref:System.Windows.Forms.ProgressBar> управления <xref:System.Windows.Forms.ProgressBar.Value%2A>, <xref:System.Windows.Forms.ProgressBar.Minimum%2A>, и <xref:System.Windows.Forms.ProgressBar.Maximum%2A>. <xref:System.Windows.Forms.ProgressBar.Minimum%2A> И <xref:System.Windows.Forms.ProgressBar.Maximum%2A> свойства задать максимальное и минимальное значения, можно отобразить индикатор хода выполнения. <xref:System.Windows.Forms.ProgressBar.Value%2A> Свойство представляет ход выполнения, которые были сделаны работ по завершению операции. Так как строки, отображаемый в элементе управления состоит из блоков, значение, отображаемое <xref:System.Windows.Forms.ProgressBar> управления лишь приблизительно <xref:System.Windows.Forms.ProgressBar.Value%2A> текущее значение свойства. На основании размера <xref:System.Windows.Forms.ProgressBar> управления <xref:System.Windows.Forms.ProgressBar.Value%2A> свойство указывает, следует ли отображать следующий блок.  
  
 Наиболее распространенным способом для обновления текущего значения хода выполнения заключается в написании кода, чтобы задать <xref:System.Windows.Forms.ProgressBar.Value%2A> свойства. В примере загрузки большого файла можно задать максимальный размер файла в килобайтах. Например если <xref:System.Windows.Forms.ProgressBar.Maximum%2A> свойство имеет значение 100, <xref:System.Windows.Forms.ProgressBar.Minimum%2A> свойство имеет значение 10 и <xref:System.Windows.Forms.ProgressBar.Value%2A> свойство имеет значение 50, отображается 5 прямоугольников. Это половина номер, который может быть отображен.  
  
 Однако существуют другие способы изменения значения, отображаемого в <xref:System.Windows.Forms.ProgressBar> элемента управления, помимо параметр <xref:System.Windows.Forms.ProgressBar.Value%2A> свойство напрямую. <xref:System.Windows.Forms.ProgressBar.Step%2A> Свойство может использоваться для указания значения для увеличения <xref:System.Windows.Forms.ProgressBar.Value%2A> свойства. После этого вызова <xref:System.Windows.Forms.ProgressBar.PerformStep%2A> метод будет увеличивать значение. Для изменения значения приращения, можно использовать <xref:System.Windows.Forms.ProgressBar.Increment%2A> метод и указать значение, с которого следует выполнить приращение <xref:System.Windows.Forms.ProgressBar.Value%2A> свойство.  
  
 Является другим элементом управления для графического представления пользователю о текущем действии <xref:System.Windows.Forms.StatusBar> элемента управления.  
  
> [!IMPORTANT]
>  <xref:System.Windows.Forms.StatusStrip> И <xref:System.Windows.Forms.ToolStripStatusLabel> элементы управления заменяют и расширяют функциональные возможности для <xref:System.Windows.Forms.StatusBar> и <xref:System.Windows.Forms.StatusBarPanel> управляет; Однако <xref:System.Windows.Forms.StatusBar> и <xref:System.Windows.Forms.StatusBarPanel> элементы управления сохраняются для обеспечения обратной совместимости и использования в будущем, если вы Выберите этот параметр.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.ProgressBar>
- [Элемент управления ProgressBar](progressbar-control-windows-forms.md)
