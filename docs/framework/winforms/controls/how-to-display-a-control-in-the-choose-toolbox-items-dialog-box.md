---
title: Практическое руководство. Отображение элемента управления в диалоговом окне выбора элементов панели элементов
ms.date: 03/30/2017
helpviewer_keywords:
- global assembly cache [Windows Forms], Choose Toolbox Items dialog box
- AssemblyFoldersEx [Windows Forms], Choose Toolbox Items dialog box
- controls [Windows Forms], display in Choose Toolbox Items dialog box
- assembly folder registration [Windows Forms], Choose Toolbox Items dialog box
- Choose Toolbox Items dialog box [Windows Forms], display control
ms.assetid: 01ef6eba-d044-40f0-951d-78eff7ebd9a9
ms.openlocfilehash: d504ace9e5571246ae0e78e165a7ad2bc23fa481
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59085302"
---
# <a name="how-to-display-a-control-in-the-choose-toolbox-items-dialog-box"></a>Практическое руководство. Отображение элемента управления в диалоговом окне выбора элементов панели элементов
При разработке и распределить элементы управления, вы можете эти элементы управления отображались в **Выбор элементов панели элементов** диалоговое окно, которое отображается при щелчке правой кнопкой мыши **элементов** и выберите  **Выбор элементов**. Вы можете включить элемент управления появился в этом диалоговом окне, используя процедуру регистрации AssemblyFoldersEx.  
  
### <a name="to-display-your-control-in-the-choose-toolbox-items-dialog-box"></a>Отображение элемента управления в диалоговом окне Выбор элементов панели элементов  
  
-   Установите сборку элемента управления в глобальном кэше сборок. Дополнительные сведения см. в разделе [Как Установка сборки в глобальный кэш сборок](../../app-domains/how-to-install-an-assembly-into-the-gac.md)  
  
     -или-  
  
-   Зарегистрируйте элемент управления и его связанные сборки времени разработки, используя процедуру регистрации AssemblyFoldersEx. AssemblyFoldersEx находится в расположении реестра, где сторонние поставщики сохраняют пути для каждой версии платформы, на которой они поддерживают. Разрешение во время разработки можно искать в этом расположении реестра поиск эталонных сборок. Скрипт реестра можно указать элементы управления, которые должны отображаться на панели элементов. Дополнительные сведения см. в разделе [развертывание пользовательского элемента управления и сборки времени разработки](https://docs.microsoft.com/previous-versions/visualstudio/visual-studio-2010/ee849818(v=vs.100)).  
  
## <a name="see-also"></a>См. также

- [Выбор элементов панели элементов-диалоговое окно (Visual Studio)](https://docs.microsoft.com/previous-versions/visualstudio/visual-studio-2010/dyca0t6t(v=vs.100))
- [Развертывание пользовательского элемента управления и сборки времени разработки](https://docs.microsoft.com/previous-versions/visualstudio/visual-studio-2010/ee849818(v=vs.100))
- [Создание элементов управления Windows Forms во время разработки](developing-windows-forms-controls-at-design-time.md)
- [Практическое руководство. Установка сборки в глобальный кэш сборок](../../app-domains/how-to-install-an-assembly-into-the-gac.md)
- [Пошаговое руководство. Автоматическое заполнение панели элементов пользовательскими компонентами](walkthrough-automatically-populating-the-toolbox-with-custom-components.md)
