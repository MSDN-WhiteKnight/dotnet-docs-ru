---
title: Использование графических контейнеров
ms.date: 03/30/2017
helpviewer_keywords:
- graphics [Windows Forms], using containers
- graphics containers
- examples [Windows Forms], graphics containers
ms.assetid: 74632f91-cefa-4f51-ab7c-f9ac91942caf
ms.openlocfilehash: cfad7254057a31ea8268784cd4b6849850f3e2aa
ms.sourcegitcommit: 160a88c8087b0e63606e6e35f9bd57fa5f69c168
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/09/2019
ms.locfileid: "57704496"
---
# <a name="using-graphics-containers"></a>Использование графических контейнеров
Объект <xref:System.Drawing.Graphics> объект предоставляет методы, такие как <xref:System.Drawing.Graphics.DrawLine%2A>, <xref:System.Drawing.Graphics.DrawImage%2A>, и <xref:System.Drawing.Graphics.DrawString%2A> для отображения векторных изображений, растровых изображений и текста. Объект <xref:System.Drawing.Graphics> объект также имеет несколько свойств, которые влияют на качество и ориентацию элементов, которые являются производными. Например свойство сглаживания режим определяет ли применять сглаживание к линии и кривые и влияет на свойство "преобразование" world, положения и поворота элементов, которые являются производными.  
  
 Объект <xref:System.Drawing.Graphics> связывается с конкретного устройства отображения. При использовании <xref:System.Drawing.Graphics> для рисования в окне <xref:System.Drawing.Graphics> объект также связан с этого конкретного окна.  
  
 Объект <xref:System.Drawing.Graphics> объект может рассматриваться как контейнер так как он содержит набор свойств, влияющих на отображение, и привязывается к конкретному устройству. Можно создать дополнительный контейнер внутри существующего <xref:System.Drawing.Graphics> путем вызова метода <xref:System.Drawing.Graphics.BeginContainer%2A> , метод <xref:System.Drawing.Graphics> объекта.  
  
## <a name="in-this-section"></a>В этом разделе  
 [Управление состоянием графического объекта](managing-the-state-of-a-graphics-object.md)  
 Описывает управление параметрами качества, области отсечения и преобразования <xref:System.Drawing.Graphics> объекта.  
  
 [Использование вложенных графических контейнеров](using-nested-graphics-containers.md)  
 Показано, как использование контейнеров для управления состоянием <xref:System.Drawing.Graphics> объекта.
