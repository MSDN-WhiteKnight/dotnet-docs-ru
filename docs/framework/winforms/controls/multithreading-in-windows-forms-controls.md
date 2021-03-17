---
title: Многопоточность в элементах управления Windows Forms
ms.date: 03/30/2017
helpviewer_keywords:
- BackgroundWorker component
- threading [Windows Forms], controls
ms.assetid: c311d652-0f26-45fa-bdcc-b1615d73ce4e
ms.openlocfilehash: cc7f358a62c8057abb77e1f5a28544bb6c858d98
ms.sourcegitcommit: 160a88c8087b0e63606e6e35f9bd57fa5f69c168
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/09/2019
ms.locfileid: "57703326"
---
# <a name="multithreading-in-windows-forms-controls"></a>Многопоточность в элементах управления Windows Forms
Во многих приложениях можно сделать более быстро реагирующих пользовательский интерфейс (UI), выполнять длительные операции в другом потоке. Несколько средств, доступных для многопоточности элементов управления Windows Forms, включая <xref:System.Threading> пространства имен, <xref:System.Windows.Forms.Control.BeginInvoke%2A?displayProperty=nameWithType> метод и `BackgroundWorker` компонента.  
  
> [!NOTE]
>  `BackgroundWorker` Компонент заменяет и расширяет его функциональные возможности <xref:System.Threading> пространства имен и <xref:System.Windows.Forms.Control.BeginInvoke%2A?displayProperty=nameWithType> метода; тем не менее, их можно сохранить для обратной совместимости и использования в будущем, при выборе. Дополнительные сведения см. в разделе [Общие сведения о компоненте BackgroundWorker](backgroundworker-component-overview.md).  
  
## <a name="in-this-section"></a>В этом разделе  
 [Практическое руководство. Сделать потокобезопасных вызовов элементов управления Windows Forms](how-to-make-thread-safe-calls-to-windows-forms-controls.md)  
 Демонстрирует процесс создания потокобезопасных вызовов элементов управления Windows Forms.  
  
 [Практическое руководство. Используйте фоновый поток для поиска файлов](how-to-use-a-background-thread-to-search-for-files.md)  
 Демонстрируется использование <xref:System.Threading> пространства имен и <xref:System.Windows.Forms.Control.BeginInvoke%2A> метод для поиска файлов асинхронно.  
  
## <a name="reference"></a>Ссылка  
 <xref:System.ComponentModel.BackgroundWorker>  
 Описание компонента, инкапсулирующего рабочий поток для асинхронных операций.  
  
 <xref:System.Media.SoundPlayer.LoadAsync%2A>  
 Описание способа загрузки звука асинхронно.  
  
 <xref:System.Windows.Forms.PictureBox.LoadAsync%2A>  
 Описание способа асинхронной загрузки изображения.  
  
## <a name="related-sections"></a>Связанные разделы  
 [Практическое руководство. Фоновое выполнение операции](how-to-run-an-operation-in-the-background.md)  
 Как выполнять длительную операцию с <xref:System.ComponentModel.BackgroundWorker> компонента.  
  
 [Общие сведения о компоненте BackgroundWorker](backgroundworker-component-overview.md)  
 Разделы, описывающие способы использования <xref:System.ComponentModel.BackgroundWorker> компонент для асинхронных операций.
