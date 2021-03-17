---
title: Общие сведения об элементе управления Label (Windows Forms)
ms.date: 03/30/2017
f1_keywords:
- Label
helpviewer_keywords:
- images [Windows Forms], displaying in labels
- labels
- Label control [Windows Forms], about Label control
ms.assetid: dcad7f44-11b7-4c55-b0c0-d984ade43d7d
ms.openlocfilehash: cc38b0f3ded9e3c2a5a4146eb6bb474921d1e19f
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59210097"
---
# <a name="label-control-overview-windows-forms"></a>Общие сведения об элементе управления Label (Windows Forms)
Windows Forms <xref:System.Windows.Forms.Label> элементы управления используются для отображения текста или изображений, которые не может быть изменено пользователем. Они используются для идентификации объектов в форме, чтобы дать описание какие определенный элемент управления будет делать, если нажата, например или для отображения сведений в ответ на событие во время выполнения или процесс в приложении. Например можно использовать метки для добавления описательных заголовков в текстовые поля, списки, поля со списком и т. д. Можно также написать код, который изменяет текст, отображаемый меткой в ответ на события во время выполнения. Например если приложения занимает несколько минут на обработку изменения, можно отобразить сообщение о состоянии обработки в метке.  
  
## <a name="working-with-the-label-control"></a>Работа с элементом управления Label  
 Так как <xref:System.Windows.Forms.Label> элемент управления не может получать фокус, он может также использоваться для создания ключей доступа для других элементов управления. Ключ доступа позволяет пользователю выбрать другой элемент управления, нажав клавишу ALT ключом доступа. Дополнительные сведения см. в разделе [Создание сочетаний клавиш для элементов управления Windows Forms](how-to-create-access-keys-for-windows-forms-controls.md) и [как: Создание ключей доступа с помощью элементов управления Label в Windows Forms](how-to-create-access-keys-with-windows-forms-label-controls.md).  
  
 Заголовок, отображаемый в метке, содержащийся в <xref:System.Windows.Forms.Label.Text%2A> свойство. <xref:System.Windows.Forms.Label.TextAlign%2A> Свойство позволяет задать способ выравнивания текста в метке. Дополнительные сведения см. в разделе [Как Задать текст, отображаемый элементом управления форм Windows](how-to-set-the-text-displayed-by-a-windows-forms-control.md).  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.Label>
- [Практическое руководство. Приведение размера элемента управления Label в соответствие с его содержимым в Windows Forms](how-to-size-a-windows-forms-label-control-to-fit-its-contents.md)
- [Практическое руководство. Определение клавиш доступа с помощью элементов управления Label в Windows Forms](how-to-create-access-keys-with-windows-forms-label-controls.md)
