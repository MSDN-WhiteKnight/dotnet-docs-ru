---
title: Общие сведения о компоненте ErrorProvider (Windows Forms)
ms.date: 03/30/2017
f1_keywords:
- ErrorProvider
helpviewer_keywords:
- errors [Windows Forms], displaying to users
- error messages [Windows Forms], displaying
- ErrorProvider component [Windows Forms], about ErrorProvider component
ms.assetid: ced189f2-b5c8-46a7-a6f1-37f5af95dc99
ms.openlocfilehash: 485e7a17073d72618b9599113179cddde748e697
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59181185"
---
# <a name="errorprovider-component-overview-windows-forms"></a>Общие сведения о компоненте ErrorProvider (Windows Forms)
Windows Forms [ErrorProvider](errorprovider-component-windows-forms.md) компонент используется для проверки пользовательского ввода в форме или элементе управления. Обычно используется в сочетании с проверка вводимых пользователем данных в форме или отображение ошибок в наборе данных. Поставщик ошибка — лучшую альтернативу по сравнению с сообщением об ошибке в окне сообщения, так как после закрытия окно сообщения, сообщение об ошибке больше не отображается. <xref:System.Windows.Forms.ErrorProvider> Компонент отображает значок ошибки (![значок ErrorProvider](./media/vberrorprovidericon.gif "vbErrorProviderIcon")) рядом с соответствующим элементом управления, например при наведении пользователем указателя мыши на текстовое поле значок ошибки появляется ToolTip, отображающий строку сообщения об ошибке.  
  
## <a name="key-properties"></a>Ключевые свойства  
 <xref:System.Windows.Forms.ErrorProvider> Ключевые свойства компонента — <xref:System.Windows.Forms.ErrorProvider.DataSource%2A>, <xref:System.Windows.Forms.ErrorProvider.ContainerControl%2A>, и <xref:System.Windows.Forms.ErrorProvider.Icon%2A>. При использовании <xref:System.Windows.Forms.ErrorProvider> компонент с привязкой к данным элементы управления, <xref:System.Windows.Forms.ErrorProvider.ContainerControl%2A> свойство должно быть присвоено подходящего контейнера (как правило, форма Windows) в порядке для компонента, чтобы отобразить значок ошибки в форме. При добавлении компонента в конструкторе <xref:System.Windows.Forms.ErrorProvider.ContainerControl%2A> свойству форме; при добавлении элемента управления в коде, необходимо установить его самостоятельно.  
  
 <xref:System.Windows.Forms.ErrorProvider.Icon%2A> Свойство может быть присвоено значок в виде пользовательских ошибок вместо значения по умолчанию. Когда <xref:System.Windows.Forms.ErrorProvider.DataSource%2A> свойство задано, <xref:System.Windows.Forms.ErrorProvider> компонент может отображать сообщения об ошибках для набора данных. Основной метод <xref:System.Windows.Forms.ErrorProvider> компонент является <xref:System.Windows.Forms.ErrorProvider.SetError%2A> метод, который указывает строку сообщения об ошибке и где должен отображаться значок ошибки.  
  
> [!NOTE]
>  <xref:System.Windows.Forms.ErrorProvider> Компонент не предоставляет встроенную поддержку для клиенты специальных возможностей. Чтобы сделать приложение доступным при использовании этого компонента, необходимо предоставить механизм обратной связи дополнительные, доступны.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.ErrorProvider>
- [Практическое руководство. Индикация ошибок данных, содержащихся в объекте DataSet, с помощью компонента ErrorProvider в Windows Forms](view-errors-within-a-dataset-with-wf-errorprovider-component.md)
- [Практическое руководство. Отображение значков ошибок при проверке введенных в форму данных с помощью компонента ErrorProvider в Windows Forms](display-error-icons-for-form-validation-with-wf-errorprovider.md)
