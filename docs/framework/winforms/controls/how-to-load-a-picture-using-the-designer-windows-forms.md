---
title: Практическое руководство. Загрузка изображения с помощью конструктора (Windows Forms)
ms.date: 03/30/2017
helpviewer_keywords:
- picture formats
- images [Windows Forms], displaying on Windows Forms
- pictures [Windows Forms], displaying
- forms [Windows Forms], displaying images
- PictureBox control [Windows Forms], adding pictures
ms.assetid: 4dc7b973-afb1-4276-8322-20825af96655
ms.openlocfilehash: 6bdf7c3df0ffd97dd88a4c442a8a73593a0447ee
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59336386"
---
# <a name="how-to-load-a-picture-using-the-designer-windows-forms"></a>Практическое руководство. Загрузка изображения с помощью конструктора (Windows Forms)
С помощью Windows Forms <xref:System.Windows.Forms.PictureBox> элемента управления, можно загружать и отображать изображение в форме во время разработки, установив <xref:System.Windows.Forms.PictureBox.Image%2A> свойство допустимого рисунка. В следующей таблице показаны допустимые типы файлов.  
  
|Тип|Расширение имени файла|  
|----------|-------------------------|  
|Bitmap|.bmp|  
|Значок|ICO|  
|GIF|GIF|  
|Метафайл|.wmf|  
|JPEG|.jpg|  
  
> [!NOTE]
>  Отображаемые диалоговые окна и команды меню могут отличаться от описанных в справке в зависимости от текущих параметров или выпуска. Чтобы изменить параметры, выберите в меню **Сервис** пункт **Импорт и экспорт параметров** . Дополнительные сведения см. в разделе [Персонализация интегрированной среды разработки Visual Studio](/visualstudio/ide/personalizing-the-visual-studio-ide).  
  
### <a name="to-display-a-picture-at-design-time"></a>Для отображения рисунка во время разработки  
  
1. Рисование <xref:System.Windows.Forms.PictureBox> управления на форме.  
  
2. В окне «Свойства» выберите <xref:System.Windows.Forms.PictureBox.Image%2A> свойства, а затем нажмите кнопку с многоточием для отображения **откройте** диалоговое окно.  
  
3. Если вы ищете файлов определенного типа (например, GIF-файлы), выберите ее в **файлы типа** поле.  
  
4. Выберите файл, который вы хотите отобразить.  
  
### <a name="to-clear-the-picture-at-design-time"></a>Чтобы очистить рисунок во время разработки  
  
1. На **свойства** выберите <xref:System.Windows.Forms.PictureBox.Image%2A> свойство и щелкните правой кнопкой мыши небольшой эскиза, который отображается слева от имени объекта образа. Выберите **сбросить**.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.PictureBox>
- [Общие сведения об элементе управления PictureBox](picturebox-control-overview-windows-forms.md)
- [Практическое руководство. Изменение размера или размещения изображения во время выполнения](how-to-modify-the-size-or-placement-of-a-picture-at-run-time-windows-forms.md)
- [Практическое руководство. Установка изображений во время выполнения](how-to-set-pictures-at-run-time-windows-forms.md)
- [Элемент управления PictureBox](picturebox-control-windows-forms.md)
