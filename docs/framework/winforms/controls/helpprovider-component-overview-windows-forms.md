---
title: Общие сведения о компоненте HelpProvider (Windows Forms)
ms.date: 03/30/2017
f1_keywords:
- HelpProvider
helpviewer_keywords:
- HelpProvider component [Windows Forms], about HelpProvider component
- Help [Windows Forms], adding to Windows applications
- F1 Help [Windows Forms], adding to Windows Forms
- dialog boxes [Windows Forms], context-sensitive Help
- Windows Forms, context-sensitive Help
ms.assetid: 6b10c2cc-c577-4cb5-9669-e37b33416af9
ms.openlocfilehash: 177b61cab99d21a844298632020244fa424d8d2a
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59176583"
---
# <a name="helpprovider-component-overview-windows-forms"></a>Общие сведения о компоненте HelpProvider (Windows Forms)
Windows Forms [HelpProvider](helpprovider-component-windows-forms.md) компонент используется для связывания файл HTML Help 1.x справки (CHM-файл, созданный с помощью HTML Help Workshop, или HTM-файл) с приложением Windows. Можно предоставить справку в различными способами:  
  
-   Укажите контекстной справки для элементов управления в формах Windows Forms.  
  
-   Предоставить контекстную справку для определенного диалогового или конкретных элементов управления в диалоговом окне.  
  
-   Откройте файл справки для конкретной области, например на главной странице оглавление, индекс или функция поиска.  
  
## <a name="using-the-help-provider"></a>С помощью поставщика по справке  
 Добавление <xref:System.Windows.Forms.HelpProvider> компонента в форму Windows позволяет других элементов управления в форме для предоставления справки свойства <xref:System.Windows.Forms.HelpProvider> компонента. Это позволяет предоставить справку для элементов управления в форме Windows. Можно связать файл справки с <xref:System.Windows.Forms.HelpProvider> компонента с помощью <xref:System.Windows.Forms.HelpProvider.HelpNamespace%2A> свойство. Укажите тип справки, получен с помощью вызова <xref:System.Windows.Forms.HelpProvider.SetHelpNavigator%2A> и указав значение от <xref:System.Windows.Forms.HelpNavigator> перечисления для указанного элемента управления. Укажите ключевое слово или раздел для справки, вызвав <xref:System.Windows.Forms.HelpProvider.SetHelpKeyword%2A> метод.  
  
 При необходимости, чтобы связать определенную строку справки с другим элементом управления, используйте <xref:System.Windows.Forms.HelpProvider.SetHelpString%2A> метод. Строка, которая будет связана с элементом управления, с помощью этого метода отображается во всплывающем окне, когда пользователь нажимает клавишу F1, элемент управления имеет фокус.  
  
 Если <xref:System.Windows.Forms.HelpProvider.HelpNamespace%2A> не был задан, необходимо использовать <xref:System.Windows.Forms.HelpProvider.SetHelpString%2A> для предоставления текста справки. Если вы настроили оба <xref:System.Windows.Forms.HelpProvider.HelpNamespace%2A> и строку справки на основе справки <xref:System.Windows.Forms.HelpProvider.HelpNamespace%2A> будет иметь приоритет.  
  
> [!NOTE]
>  Могут возникать проблемы, с помощью относительного пути, при задании пути к файлу справки, в <xref:System.Windows.Forms.Help.ShowHelp%2A> метод или <xref:System.Windows.Forms.HelpProvider.HelpNamespace%2A> свойство <xref:System.Windows.Forms.HelpProvider> элемента управления. Таким образом не забудьте указать абсолютный путь к файлу справки.  
  
## <a name="see-also"></a>См. также

- [Справочные системы в приложениях Windows Forms](../advanced/help-systems-in-windows-forms-applications.md)
