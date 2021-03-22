---
title: Использование вложенных графических контейнеров
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- graphics [Windows Forms], nested containers
- graphics [Windows Forms], clipping
- graphics [Windows Forms], transformations in nested objects
ms.assetid: a0d9f178-43a4-4323-bb5a-d3e3f77ae6c1
ms.openlocfilehash: 6bbf7918ccff184e597204b35aa005ab17d8d8af
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59104303"
---
# <a name="using-nested-graphics-containers"></a>Использование вложенных графических контейнеров
[!INCLUDE[ndptecgdiplus](../../../../includes/ndptecgdiplus-md.md)] предоставляет контейнеры, которые можно использовать для временно заменить или дополнить некоторую часть состояния в <xref:System.Drawing.Graphics> объекта. Вы создадите контейнер путем вызова <xref:System.Drawing.Graphics.BeginContainer%2A> метод <xref:System.Drawing.Graphics> объекта. Вы можете вызвать <xref:System.Drawing.Graphics.BeginContainer%2A> несколько раз для создания вложенных контейнеров. Каждый вызов <xref:System.Drawing.Graphics.BeginContainer%2A> должны быть связаны с вызовом <xref:System.Drawing.Graphics.EndContainer%2A>.  
  
## <a name="transformations-in-nested-containers"></a>Преобразования во вложенных контейнерах  
 В следующем примере создается <xref:System.Drawing.Graphics> объект и контейнер внутри этого <xref:System.Drawing.Graphics> объекта. Мировое преобразование объекта <xref:System.Drawing.Graphics> объект является сдвиг 100 единиц по оси x и на 80 единиц по оси y. Мировое преобразование контейнера является поворот на 30 градусов. Код выполняет вызов `DrawRectangle(pen, -60, -30, 120, 60)` дважды. Первый вызов <xref:System.Drawing.Graphics.DrawRectangle%2A> находится внутри контейнера; то есть происходит между вызовы <xref:System.Drawing.Graphics.BeginContainer%2A> и <xref:System.Drawing.Graphics.EndContainer%2A>. Второй вызов <xref:System.Drawing.Graphics.DrawRectangle%2A> — после вызова <xref:System.Drawing.Graphics.EndContainer%2A>.  
  
 [!code-csharp[System.Drawing.MiscLegacyTopics#61](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Drawing.MiscLegacyTopics/CS/Class1.cs#61)]
   
  
 В приведенном выше коде прямоугольника, отображаемые из контейнера, применяется сначала объемное преобразование контейнера (поворот), а затем по мировое преобразование объекта <xref:System.Drawing.Graphics> (сдвиг). Прямоугольник, извлеченных из вне контейнера, применяется только мировое преобразование объекта <xref:System.Drawing.Graphics> (сдвиг). На следующем рисунке показано два прямоугольника: 
  
 ![Рисунок, показывающий вложенные контейнеры.](./media/using-nested-graphics-containers/nested-containers-illustration.png)  
  
## <a name="clipping-in-nested-containers"></a>Обрезка во вложенных контейнерах  
 В следующем примере показано, как вложенные контейнеры обрабатывать отсеченных областей. Код создает <xref:System.Drawing.Graphics> объект и контейнер внутри этого <xref:System.Drawing.Graphics> объекта. Отсеченная область объекта <xref:System.Drawing.Graphics> объект представляет собой прямоугольник, а отсеченная область объекта контейнера — эллипс. Код делает два вызова <xref:System.Drawing.Graphics.DrawLine%2A> метод. Первый вызов <xref:System.Drawing.Graphics.DrawLine%2A> находится внутри контейнера, а второй вызов <xref:System.Drawing.Graphics.DrawLine%2A> выходит за пределы контейнера (после вызова <xref:System.Drawing.Graphics.EndContainer%2A>). Первая строка обрезается пересечение двух отсеченных областей. Вторая строка обрезается по прямоугольный вырезанной <xref:System.Drawing.Graphics> объекта.  
  
 [!code-csharp[System.Drawing.MiscLegacyTopics#62](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Drawing.MiscLegacyTopics/CS/Class1.cs#62)]
   
  
 На следующем рисунке показано два усеченные строки:
  
 ![Рисунок, показывающий вложенного контейнера с усеченные строки.](./media/using-nested-graphics-containers/nested-container-clipped-lines.png)  
  
 Как показано в двух приведенных выше примерах, преобразования и отсеченные области накапливаются в вложенные контейнеры. Если задать объемные преобразования контейнера и <xref:System.Drawing.Graphics> объекта, оба вида преобразований применяются к отображаемым внутри контейнера. Преобразование контейнера будут сначала применяется и преобразование <xref:System.Drawing.Graphics> объекта, которые будут применяться во-вторых. Если задать отсеченные области контейнера и <xref:System.Drawing.Graphics> объектов, отображаемых внутри контейнера будет обрезаться пересечение двух отсеченных областей.  
  
## <a name="quality-settings-in-nested-containers"></a>Параметры качества во вложенные контейнеры  
 Параметры качества (<xref:System.Drawing.Graphics.SmoothingMode%2A>, <xref:System.Drawing.Graphics.TextRenderingHint%2A>и ей подобные) в вложенные контейнеры не являются накопительными; вместо этого параметры качества контейнера временно Замените параметры качества <xref:System.Drawing.Graphics> объекта. При создании нового контейнера, параметры качества для этого контейнера присваиваются значения по умолчанию. Например, предположим, что у вас есть <xref:System.Drawing.Graphics> объект с режим сглаживания <xref:System.Drawing.Drawing2D.SmoothingMode.AntiAlias>. При создании контейнера, режим сглаживания в контейнер по умолчанию режим сглаживания. Вы можете задать режим сглаживания контейнера и все элементы, отображаемые из контейнера привязки будет рисоваться в соответствии с режимом, которые можно задать. Объекты, отображаемые после вызова <xref:System.Drawing.Graphics.EndContainer%2A> будут отображаться в соответствии с режимом сглаживания (<xref:System.Drawing.Drawing2D.SmoothingMode.AntiAlias>), которая была до вызова <xref:System.Drawing.Graphics.BeginContainer%2A>.  
  
## <a name="several-layers-of-nested-containers"></a>Несколько уровней вложенных контейнеров  
 Вы не ограничены один контейнер в <xref:System.Drawing.Graphics> объекта. Можно создать последовательность контейнеров, вложенных друг в друга, и можно указать мировое преобразование, отсеченной области и параметры качества для каждого из этих вложенных контейнеров. Если вызвать метод рисования из внутреннего контейнера, преобразования применяются в порядке, начиная с контейнером внутреннего и внешнего контейнера. Объекты, отображаемые из внутреннего контейнера обрезаются пересечением отсеченных областей.  
  
 В следующем примере создается <xref:System.Drawing.Graphics> и устанавливает его подсказка отрисовки текста <xref:System.Drawing.Drawing2D.SmoothingMode.AntiAlias>. Код создает два контейнеров — по одному вложен в другой. Подсказка по визуализации текста внешнего контейнера имеет значение <xref:System.Drawing.Text.TextRenderingHint.SingleBitPerPixel>, и подсказка по визуализации текста внутреннего контейнера имеет значение <xref:System.Drawing.Drawing2D.SmoothingMode.AntiAlias>. Код рисует три строки: одну из внутреннего контейнера, одну из внешнего контейнера и один из <xref:System.Drawing.Graphics> сам объект.  
  
 [!code-csharp[System.Drawing.MiscLegacyTopics#63](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Drawing.MiscLegacyTopics/CS/Class1.cs#63)]
   
  
 На следующем рисунке эти три строки. Строки, выводимые из внутреннего контейнера и <xref:System.Drawing.Graphics> объект Сглаживается, с помощью сглаживания. Строка, выводимая из внешнего контейнера не подвергается сглаживанию, так как <xref:System.Drawing.Graphics.TextRenderingHint%2A> свойству <xref:System.Drawing.Text.TextRenderingHint.SingleBitPerPixel>.  
  
 ![Рисунок, показывающий строк, извлеченных из вложенных контейнеров.](./media/using-nested-graphics-containers/nested-containers-three-strings.png)  
  
## <a name="see-also"></a>См. также

- <xref:System.Drawing.Graphics>
- [Управление состоянием объекта Graphics](managing-the-state-of-a-graphics-object.md)
