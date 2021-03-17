---
title: Отображение азиатских символов с помощью свойства ImeMode
ms.date: 03/30/2017
helpviewer_keywords:
- Asian languages [Windows Forms], displaying with ImeMode
- Chinese characters [Windows Forms], displaying with ImeMode
- IME mode
- Japanese characters [Windows Forms], displaying with ImeMode
- international applications [Windows Forms], character display
- international characters
- Korean characters
- Asian languages
- Input Method Editor (IME), mode
- localization [Windows Forms], character sets
- globalization [Windows Forms], character sets
ms.assetid: c60ae399-0dab-4f07-9dea-6dbfb15ec0ae
ms.openlocfilehash: 25602e1a878443bd54411dfd6481581abebda5c7
ms.sourcegitcommit: 6b308cf6d627d78ee36dbbae8972a310ac7fd6c8
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 01/23/2019
ms.locfileid: "54500529"
---
# <a name="display-of-asian-characters-with-the-imemode-property"></a>Отображение азиатских символов с помощью свойства ImeMode
<xref:System.Windows.Forms.Control.ImeMode%2A> Свойство используется форм и элементов управления для принудительного конкретный режим редактора метода ввода (IME). Редактор метода ввода — это необходимый компонент для написания сценариев на китайском, японском и корейском языках, так как количество символов в этих системах письменности превышает возможности кодирования обычной клавиатуры. Например, в определенном текстовом поле можно разрешить только символы ASCII. В этом случае можно задать <xref:System.Windows.Forms.Control.ImeMode%2A> свойства <xref:System.Windows.Forms.ImeMode> и пользователям будет только для ввода символов ASCII для это конкретное текстовое поле. Значение по умолчанию <xref:System.Windows.Forms.Control.ImeMode%2A> свойство <xref:System.Windows.Forms.ImeMode>, поэтому если задать свойство для формы, все элементы управления в форме унаследуют это значение. Дополнительные сведения см. в разделе <xref:System.Windows.Forms.Control.ImeMode%2A> ) и <xref:System.Windows.Forms.ImeMode>.  
  
## <a name="see-also"></a>См. также

- [Глобализация приложений Windows Forms](globalizing-windows-forms.md)
