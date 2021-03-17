---
title: Объекты Graphics и Drawing в Windows Forms
ms.date: 03/30/2017
helpviewer_keywords:
- graphics [Windows Forms]
- graphics [Windows Forms], using in Windows Forms
- GDI+, using in managed code
- drawing [Windows Forms]
ms.assetid: 362532c5-1a06-4257-bdc8-723461009ede
ms.openlocfilehash: 08f87436ade62bb54295b012a1c24dc177ea9667
ms.sourcegitcommit: 160a88c8087b0e63606e6e35f9bd57fa5f69c168
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/09/2019
ms.locfileid: "57705432"
---
# <a name="graphics-and-drawing-in-windows-forms"></a>Объекты Graphics и Drawing в Windows Forms
Среда CLR использует расширенную реализацию интерфейса графических устройств Windows ([!INCLUDE[ndptecgdi](../../../../includes/ndptecgdi-md.md)]) под названием [!INCLUDE[ndptecgdiplus](../../../../includes/ndptecgdiplus-md.md)]. С помощью [!INCLUDE[ndptecgdiplus](../../../../includes/ndptecgdiplus-md.md)] можно создавать графические элементы, рисовать текст и управлять графическими изображениями как объектами. Интерфейс [!INCLUDE[ndptecgdiplus](../../../../includes/ndptecgdiplus-md.md)] отличается высоким быстродействием и удобен в использовании. [!INCLUDE[ndptecgdiplus](../../../../includes/ndptecgdiplus-md.md)] можно использовать для отрисовки графических изображений в формах и элементах управления Windows Forms. Хотя [!INCLUDE[ndptecgdiplus](../../../../includes/ndptecgdiplus-md.md)] нельзя использовать непосредственно в веб-формах, графические изображения можно выводить через элемент управления веб-сервера Image.  
  
 В этом разделе описаны основы программирования с использованием [!INCLUDE[ndptecgdiplus](../../../../includes/ndptecgdiplus-md.md)]. Хотя он не является полным справочником, в нем содержатся сведения об объектах <xref:System.Drawing.Graphics>, <xref:System.Drawing.Pen>, <xref:System.Drawing.Brush> и <xref:System.Drawing.Color> и способах выполнения таких задач, как рисование фигур, создание текста, отображение рисунков. Дополнительные сведения см. в разделе [GDI + ссылку](/windows/desktop/gdiplus/-gdiplus-class-gdi-reference).  
  
 Если вы хотите немедленно приступить к работе, см. статью [Приступая к программированию графики](getting-started-with-graphics-programming.md). Она содержит разделы, посвященные использованию кода для рисования линий, фигур, текста и других элементов в формах Windows Forms.  
  
## <a name="in-this-section"></a>В этом разделе  
 [Общие сведения о графике](graphics-overview-windows-forms.md)  
 Общие сведения об управляемых классах, связанных с графикой.  
  
 [Управляемый код GDI+](about-gdi-managed-code.md)  
 Сведения об управляемых классах [!INCLUDE[ndptecgdiplus](../../../../includes/ndptecgdiplus-md.md)].  
  
 [Использование управляемых графических классов](using-managed-graphics-classes.md)  
 Демонстрируется выполнение различных задач с помощью управляемых классов [!INCLUDE[ndptecgdiplus](../../../../includes/ndptecgdiplus-md.md)].  
  
## <a name="reference"></a>Ссылка  
 <xref:System.Drawing>  
 Доступ к основным графическим функциям [!INCLUDE[ndptecgdiplus](../../../../includes/ndptecgdiplus-md.md)].  
  
 <xref:System.Drawing.Drawing2D>  
 Расширенные функциональные возможности для создания двухмерной и векторной графики.  
  
 <xref:System.Drawing.Imaging>  
 Расширенный набор графических функций [!INCLUDE[ndptecgdiplus](../../../../includes/ndptecgdiplus-md.md)].  
  
 <xref:System.Drawing.Text>  
 Расширенный набор типографических функций [!INCLUDE[ndptecgdiplus](../../../../includes/ndptecgdiplus-md.md)]. Классы в этом пространстве имен позволяют создавать и использовать коллекции шрифтов.  
  
 <xref:System.Drawing.Printing>  
 Функции печати.  
  
## <a name="related-sections"></a>Связанные разделы  
 [Рисование и отрисовка пользовательского элемента управления](../controls/custom-control-painting-and-rendering.md)  
 Подробные сведения о способах написания кода для рисования элементов управления.
