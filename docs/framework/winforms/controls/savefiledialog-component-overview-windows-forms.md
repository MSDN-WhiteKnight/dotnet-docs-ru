---
title: Общие сведения о компоненте SaveFileDialog (Windows Forms)
ms.date: 03/30/2017
f1_keywords:
- SaveFileDialog
helpviewer_keywords:
- Save File dialog box [Windows Forms], displaying
- SaveFileDialog component [Windows Forms], about SaveFileDialog
ms.assetid: be7a625f-46fd-4d06-9985-b613dcbf9bd2
ms.openlocfilehash: b06c4d510cefdc7558944995594fd209b6121cb1
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59103050"
---
# <a name="savefiledialog-component-overview-windows-forms"></a>Общие сведения о компоненте SaveFileDialog (Windows Forms)
Компонент Windows Forms <xref:System.Windows.Forms.SaveFileDialog> является стандартным диалоговым окном. Это так же, как стандартный **сохранить файл** диалоговое окно, используемое с Windows. Он наследуется от класса <xref:System.Windows.Forms.CommonDialog>.  
  
## <a name="working-with-the-savefiledialog-component"></a>Работа с помощью компонента SaveFileDialog  
 Компонент используется в качестве простого решения для пользователям сохранять файлы вместо того чтобы настраивать собственные диалоговое окно. Опираясь на стандартные диалоговые окна Windows, основные функциональные возможности приложения, созданные хорошо знакомы пользователям. Однако имейте в виду, что при с помощью <xref:System.Windows.Forms.SaveFileDialog> компонента, необходимо написать свою собственную логику для сохранения файлов.  
  
 Можно использовать <xref:System.Windows.Forms.CommonDialog.ShowDialog%2A> метод, чтобы отобразить диалоговое окно во время выполнения. Файл можно открыть в режиме чтения и записи с помощью <xref:System.Windows.Forms.SaveFileDialog.OpenFile%2A> метод.  
  
 При добавлении в форму, <xref:System.Windows.Forms.SaveFileDialog> компонент появится в области в нижней части конструктора Windows Forms.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.SaveFileDialog>
- [Компонент SaveFileDialog](savefiledialog-component-windows-forms.md)
