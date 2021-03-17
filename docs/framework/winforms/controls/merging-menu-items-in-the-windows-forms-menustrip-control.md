---
title: Слияние элементов меню в элементе управления MenuStrip в Windows Forms
ms.date: 03/30/2017
helpviewer_keywords:
- MenuStrip [Windows Forms], merging
- merging [Windows Forms], general concepts
ms.assetid: 95e113ba-f362-4dda-8a76-6d95ddc45cee
ms.openlocfilehash: dbe1c0325499e7b925d504fc80f9034f9e387475
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59231569"
---
# <a name="merging-menu-items-in-the-windows-forms-menustrip-control"></a>Слияние элементов меню в элементе управления MenuStrip в Windows Forms
Если у вас есть приложения многодокументного интерфейса (MDI), можно объединить пункты меню или целые меню из дочерней формы в меню родительской формы.  
  
 В этом разделе описываются основные понятия, связанные с слияние элементов меню в приложении MDI.  
  
## <a name="general-concepts"></a>Общие понятия  
 Процедуры слияния охватывают целевого объекта и системы управления версиями:  
  
-   Целевой объект — <xref:System.Windows.Forms.MenuStrip> управления на главной или родительской MDI-формы, в которой выполняется слияние пунктов меню.  
  
-   Источником является <xref:System.Windows.Forms.MenuStrip> элемента управления в дочерней форме MDI, содержащий пункты меню, которые необходимо объединить в меню «цель».  
  
 <xref:System.Windows.Forms.MenuStrip.MdiWindowListItem%2A> Свойство идентифицирует элемент меню, в которых стрелку раскрывающегося списка, то вы заполните названия MDI текущей родительской дочерние формы MDI. Например, обычно список дочерние формы MDI, открытые в настоящий момент на **окно** меню.  
  
 <xref:System.Windows.Forms.ToolStripMenuItem.IsMdiWindowListEntry%2A> Свойство идентифицирует которого берутся элементы меню <xref:System.Windows.Forms.MenuStrip> на дочерней формы MDI.  
  
 Пункты меню можно объединить вручную или автоматически. Слияние элементов меню таким же образом, оба метода, но включается по-разному, как описано в разделах «Слияние вручную» и «Автоматическое слияние» далее в этом разделе. В процессе автоматического и ручного слияния каждое действие слияния затрагивает следующее.  
  
 <xref:System.Windows.Forms.MenuStrip> Слияние перемещает элементы меню из одного <xref:System.Windows.Forms.ToolStrip> в другую клонируются, как в случае с <xref:System.Windows.Forms.MainMenu>.  
  
## <a name="mergeaction-values"></a>Значения MergeAction  
 Задайте действие слияния пунктов меню в источнике <xref:System.Windows.Forms.MenuStrip> с помощью <xref:System.Windows.Forms.MergeAction> свойство.  
  
 В следующей таблице описаны значение и типичные случаи применения доступных операций слияния.  
  
|Значение MergeAction|Описание|Типичные случаи использования|  
|-----------------------|-----------------|-----------------|  
|<xref:System.Windows.Forms.MergeAction.Append>|(По умолчанию) Добавляет исходный элемент в конец элемента целевой коллекции.|Добавление пунктов меню в конец меню при активации некоторые части программы.|  
|<xref:System.Windows.Forms.MergeAction.Insert>|Добавляет элемент источника конечный элемент коллекции, в расположении, заданном параметром <xref:System.Windows.Forms.ToolStripItem.MergeIndex%2A> свойство, заданное для исходного элемента.|Добавление пунктов меню в середину или начало меню при активации некоторые части программы.<br /><br /> Если значение <xref:System.Windows.Forms.ToolStripItem.MergeIndex%2A> одинаков для обеих пунктов меню, они добавляются в обратном порядке. Задайте <xref:System.Windows.Forms.ToolStripItem.MergeIndex%2A> соответствующим образом, чтобы восстановить исходный порядок.|  
|<xref:System.Windows.Forms.MergeAction.Replace>|Находит соответствие текст или использует <xref:System.Windows.Forms.ToolStripItem.MergeIndex%2A> значение, если текстовое совпадение найдено и заменит соответствующий конечный элемент меню с элементом меню источника.|Целевой элемент меню, заменив элемент меню источника с тем же именем, который делает что-то иное.|  
|<xref:System.Windows.Forms.MergeAction.MatchOnly>|Находит соответствие текст или использует <xref:System.Windows.Forms.ToolStripItem.MergeIndex%2A> значение, если совпадений текста найден, а затем добавляет все элементы раскрывающегося списка из источника в целевой объект.|Построение структуры меню, который вставляет или добавляются в подменю или удаляет элементы меню из вложенного меню. Например, можно добавить элемент меню из дочерней формы MDI в главное <xref:System.Windows.Forms.MenuStrip> **Сохранить как** меню.<br /><br /> <xref:System.Windows.Forms.MergeAction.MatchOnly> позволяет перемещаться по структуре меню без какого-либо действия. Он предоставляет способ оценки последующих элементов.|  
|<xref:System.Windows.Forms.MergeAction.Remove>|Находит соответствие текст или использует <xref:System.Windows.Forms.ToolStripItem.MergeIndex%2A> значение, если текстовое совпадение найдено и затем удаляет элемент из целевого объекта.|Удаление цели пункта меню <xref:System.Windows.Forms.MenuStrip>.|  
  
## <a name="manual-merging"></a>Слияние вручную  
 Только <xref:System.Windows.Forms.MenuStrip> элементы управления участвовать в процессе автоматического слияния. Для объединения элементов других элементов управления, таких как <xref:System.Windows.Forms.ToolStrip> и <xref:System.Windows.Forms.StatusStrip> элементов управления, необходимо осуществить слияние их вручную, путем вызова <xref:System.Windows.Forms.ToolStripManager.Merge%2A> и <xref:System.Windows.Forms.ToolStripManager.RevertMerge%2A> методы в коде при необходимости.  
  
## <a name="automatic-merging"></a>Автоматическое слияние  
 Можно использовать автоматическое слияние для приложения MDI, активировав исходной формы. Для использования <xref:System.Windows.Forms.MenuStrip> в приложении MDI, задайте <xref:System.Windows.Forms.Form.MainMenuStrip%2A> свойство в целевой объект <xref:System.Windows.Forms.MenuStrip> так, что операции слияния выполняются на исходном <xref:System.Windows.Forms.MenuStrip> отражаются в целевом объекте <xref:System.Windows.Forms.MenuStrip>.  
  
 Вы можете активировать автоматического слияния, активировав <xref:System.Windows.Forms.MenuStrip> в источнике MDI. После активации, источник <xref:System.Windows.Forms.MenuStrip> объединяются в целевую MDI. Когда новая форма становится активным, слияния отменяется на последней формы и запущено на новую форму. Этим поведением можно управлять, задав <xref:System.Windows.Forms.ToolStripItem.MergeAction%2A> свойства при необходимости на каждом <xref:System.Windows.Forms.ToolStripItem>и установив <xref:System.Windows.Forms.ToolStrip.AllowMerge%2A> свойство на каждом <xref:System.Windows.Forms.MenuStrip>.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.ToolStripManager>
- <xref:System.Windows.Forms.MenuStrip>
- [Элемент управления MenuStrip](menustrip-control-windows-forms.md)
- [Практическое руководство. Создание списка в окне интерфейса MDI с помощью MenuStrip](how-to-create-an-mdi-window-list-with-menustrip-windows-forms.md)
- [Практическое руководство. Автоматическое слияние меню в приложениях MDI](how-to-set-up-automatic-menu-merging-for-mdi-applications.md)
