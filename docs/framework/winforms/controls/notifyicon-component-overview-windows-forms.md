---
title: Общие сведения о компоненте NotifyIcon (Windows Forms)
ms.date: 03/30/2017
f1_keywords:
- NotifyIcon
helpviewer_keywords:
- NotifyIcon component [Windows Forms], about NotifyIcon component
- system tray icons [Windows Forms], about system tray icons
- system tray icons [Windows Forms], using in Windows Forms
ms.assetid: 5b9189fa-d4ae-41a6-9b97-eb1f44bb1a69
ms.openlocfilehash: 430d869265b9add34c6de617a178aa27af6218f3
ms.sourcegitcommit: 160a88c8087b0e63606e6e35f9bd57fa5f69c168
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/09/2019
ms.locfileid: "57707629"
---
# <a name="notifyicon-component-overview-windows-forms"></a>Общие сведения о компоненте NotifyIcon (Windows Forms)

Компонент <xref:System.Windows.Forms.NotifyIcon> Windows Forms обычно используется для отображения значков процессов, выполняемых в фоновом режиме и большую часть времени не выводящих пользовательский интерфейс. Примером такого процесса является антивирусная программа, доступ к которой можно получить, щелкнув значок в области уведомлений о состоянии на панели задач.

## <a name="key-properties-of-notifyicons"></a>Основные свойства компонентов NotifyIcon

Каждый компонент <xref:System.Windows.Forms.NotifyIcon> выводит один значок в области состояния. Если для каждого из трех процессов, выполняемых в фоновом режиме, нужно показывать значок, добавьте три компонента <xref:System.Windows.Forms.NotifyIcon> в форму. Основные свойства компонента <xref:System.Windows.Forms.NotifyIcon> — это <xref:System.Windows.Forms.NotifyIcon.Icon%2A> и <xref:System.Windows.Forms.NotifyIcon.Visible%2A>. Свойство <xref:System.Windows.Forms.NotifyIcon.Icon%2A> определяет значок, отображающийся в области состояния. Чтобы значок отображался, необходимо присвоить свойству <xref:System.Windows.Forms.NotifyIcon.Visible%2A> значение `true`.

## <a name="notifyicons-options"></a>Параметры компонентов NotifyIcon

Для упрощения работы пользователя можно связать всплывающие подсказки, сообщения и контекстные меню с <xref:System.Windows.Forms.NotifyIcon>.

Чтобы показать всплывающую подсказку для <xref:System.Windows.Forms.NotifyIcon>, вызовите метод <xref:System.Windows.Forms.NotifyIcon.ShowBalloonTip%2A>, указав длительность отображения подсказки. Также можно указать текст, значок и заголовок подсказки с помощью свойств <xref:System.Windows.Forms.NotifyIcon.BalloonTipText%2A>, <xref:System.Windows.Forms.NotifyIcon.BalloonTipIcon%2A> и <xref:System.Windows.Forms.NotifyIcon.BalloonTipTitle%2A> соответственно. Компоненты <xref:System.Windows.Forms.NotifyIcon> также могут иметь связанные всплывающие подсказки и контекстные меню. Дополнительные сведения см. в разделе [Общие сведения о компоненте ToolTip](tooltip-component-overview-windows-forms.md) и [Общие сведения о компоненте ContextMenu](contextmenu-component-overview-windows-forms.md).

## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.NotifyIcon>
- [Компонент NotifyIcon](notifyicon-component-windows-forms.md)