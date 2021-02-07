---
description: Дополнительные сведения о действиях конечного автомата в WF
title: Действия конечного автомата в WF
ms.date: 03/30/2017
ms.assetid: 93312eaf-07e0-4a55-b4f7-4cdbbc4dee2d
ms.openlocfilehash: 4571bdbabc30e721523ae18449454627c0bf7319
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99755256"
---
# <a name="state-machine-activities-in-wf"></a>Действия конечного автомата в WF

Платформа .NET Framework 4,5 предоставляет несколько предоставляемых системой действий и конструкторов действий для создания рабочих процессов конечного автомата.  
  
|||  
|-|-|  
|<xref:System.Activities.Statements.StateMachine>|Выполняет включенные действия на основе известной парадигмы конечного автомата.|  
|<xref:System.Activities.Statements.State>|Представляет состояние в конечном компьютере.|  
|<xref:System.Activities.Core.Presentation.FinalState>|Представляет завершающее состояние в конечном автомате. <xref:System.Activities.Core.Presentation.FinalState> - конструктор действий, который при использовании создает <xref:System.Activities.Statements.State>, предварительно настроенное как завершающие состояние. Дополнительные сведения см. в статье [FinalState Activity Designer](/visualstudio/workflow-designer/finalstate-activity-designer).|  
|<xref:System.Activities.Statements.Transition>|Представляет переход между двумя состояниями. Отсутствует элемент **панели элементов** для <xref:System.Activities.Statements.Transition> ; переходы создаются в конструкторе рабочих процессов путем перетаскивания строки между двумя состояниями или путем удаления состояния на треугольниках, появляющихся при наведении указателя мыши на другое состояние. Дополнительные сведения см. в разделе [конструктор действий перехода](/visualstudio/workflow-designer/transition-activity-designer).|  
  
## <a name="see-also"></a>См. также

- [Учебник по началу работы](getting-started-tutorial.md)
