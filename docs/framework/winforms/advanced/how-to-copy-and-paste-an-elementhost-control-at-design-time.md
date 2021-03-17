---
title: Практическое руководство. Копирование и вставка элемента управления ElementHost во время разработки
ms.date: 03/30/2017
helpviewer_keywords:
- Windows Forms, content copying and pasting
- interoperability [WPF]
- ElementHost control [Windows Forms], copying and pasting at design time
- WPF user control [Windows Forms], hosting in Windows Forms
ms.assetid: e570375d-2a68-44ba-b4f7-c781af2d20e8
ms.openlocfilehash: e8bc4aa4ecd2bff2981b7d4faf1e270337f346e7
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59346214"
---
# <a name="how-to-copy-and-paste-an-elementhost-control-at-design-time"></a>Практическое руководство. Копирование и вставка элемента управления ElementHost во время разработки
Эта процедура показано, как скопировать элемент управления Windows Presentation Foundation (WPF) в Windows Forms.  
  
> [!NOTE]
>  Отображаемые диалоговые окна и команды меню могут отличаться от описанных в справке в зависимости от текущих параметров или выпуска. Чтобы изменить параметры, выберите в меню **Сервис** пункт **Импорт и экспорт параметров** . Дополнительные сведения см. в разделе [Персонализация интегрированной среды разработки Visual Studio](/visualstudio/ide/personalizing-the-visual-studio-ide).  
  
### <a name="to-copy-and-paste-an-elementhost-control-at-design-time"></a>Копирование и вставка элемента управления ElementHost во время разработки  
  
1. Добавить новый элемент управления WPF <xref:System.Windows.Controls.UserControl> в проект Windows Forms. Используйте имя по умолчанию для этого типа элемента управления (`UserControl1.xaml`). Дополнительные сведения см. в разделе [Пошаговое руководство: Создание нового содержимого WPF в формах Windows Forms во время разработки](walkthrough-creating-new-wpf-content-on-windows-forms-at-design-time.md).  
  
2. В **свойства** окна, установите для параметра <xref:System.Windows.FrameworkElement.Width%2A> и <xref:System.Windows.FrameworkElement.Height%2A> свойства `UserControl1` для `200`.  
  
3. Задайте для свойства <xref:System.Windows.Controls.Control.Background%2A> значение `Blue`.  
  
4. Выполните построение проекта.  
  
5. Откройте `Form1` в конструкторе Windows Forms.  
  
6. Из **элементов**, перетащите экземпляр `UserControl1` на форму.  
  
     Экземпляр `UserControl1` размещается в новом элементе управления <xref:System.Windows.Forms.Integration.ElementHost> с именем `elementHost1`.  
  
7. Выбрав элемент управления `elementHost1`, нажмите клавиши CTRL+C, чтобы скопировать его в буфер обмена.  
  
8. Нажмите клавиши CTRL + V, чтобы вставить скопированный элемент управления в форму.  
  
     Новый <xref:System.Windows.Forms.Integration.ElementHost> управления с именем `elementHost2` создается в форме.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.Integration.ElementHost>
- <xref:System.Windows.Forms.Integration.WindowsFormsHost>
- [Миграция и взаимодействие систем](../../wpf/advanced/migration-and-interoperability.md)
- [Использование элементов управления WPF](using-wpf-controls.md)
- [Проектирование XAML в Visual Studio](/visualstudio/designers/designing-xaml-in-visual-studio)
