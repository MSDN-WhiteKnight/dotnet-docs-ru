---
title: Общие сведения об элементе управления PrintPreviewDialog (Windows Forms)
ms.date: 01/08/2018
f1_keywords:
- PrintPreviewDialog
helpviewer_keywords:
- PrintPreviewDialog control (using designer), about PrintPreviewDialog
ms.assetid: efd4ee8d-6edd-47ec-88e4-4a4759bd2384
author: rpetrusha
ms.author: ronpet
ms.openlocfilehash: 961b3c852f60a0917707bef07d4e26fc4215acca
ms.sourcegitcommit: 438919211260bb415fc8f96ca3eabc33cf2d681d
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/16/2019
ms.locfileid: "59611124"
---
# <a name="printpreviewdialog-control-overview-windows-forms"></a>Обзор управления PrintPreviewDialog (Windows Forms)

Windows Forms <xref:System.Windows.Forms.PrintPreviewDialog> элемент управления является стандартным диалоговым окном, используемый для отображения как [PrintDocument](printdocument-component-windows-forms.md) будет выглядеть при печати. Используется в качестве простого решения вместо настройки собственного диалогового приложения на базе Windows. Элемент управления содержит кнопки для печати, увеличения масштаба, отображения одной или нескольких страниц и закрытия диалогового окна.

## <a name="key-properties-and-methods"></a>Ключевые свойства и методы

Ключевое свойство элемента управления — <xref:System.Windows.Forms.PrintPreviewDialog.Document%2A>, который задает документ, который необходимо просмотреть. Документ должен быть <xref:System.Drawing.Printing.PrintDocument> объекта. Чтобы отобразить диалоговое окно, необходимо вызвать его <xref:System.Windows.Forms.Form.ShowDialog%2A> метод. Сглаживание может сделать текст более однородным, но оно может привести к замедлению отображения; Чтобы использовать его, задайте <xref:System.Windows.Forms.PrintPreviewDialog.UseAntiAlias%2A> свойства `true`.

Некоторые свойства доступны через <xref:System.Windows.Forms.PrintPreviewControl> , <xref:System.Windows.Forms.PrintPreviewDialog> содержит. (Нет необходимости добавить <xref:System.Windows.Forms.PrintPreviewControl> форме; он автоматически содержится <xref:System.Windows.Forms.PrintPreviewDialog> при добавлении диалогового окна в форму.) Примеры свойств, доступных через <xref:System.Windows.Forms.PrintPreviewControl> являются <xref:System.Windows.Forms.PrintPreviewControl.Columns%2A> и <xref:System.Windows.Forms.PrintPreviewControl.Rows%2A> свойства, которые определяют количество страниц, отображаемых по горизонтали и вертикали в элементе управления. Вы можете получить доступ к <xref:System.Windows.Forms.PrintPreviewControl.Columns%2A> свойство как `PrintPreviewDialog1.PrintPreviewControl.Columns` в Visual Basic, `printPreviewDialog1.PrintPreviewControl.Columns` в визуальном элементе C#, или `printPreviewDialog1->PrintPreviewControl->Columns` в [!INCLUDE[vcprvc](../../../../includes/vcprvc-md.md)].

## <a name="printpreviewdialog-performance"></a>Производительность PrintPreviewDialog

При следующих условиях <xref:System.Windows.Forms.PrintPreviewDialog> управления инициализирует очень медленно:

- Используется сетевого принтера.
- Изменяются настройки пользователя для этого принтера, например параметры двусторонней печати.

Для приложений, выполняющихся в .NET Framework 4.5.2, можно добавить следующий ключ \<appSettings > раздела файла конфигурации для повышения производительности <xref:System.Windows.Forms.PrintPreviewDialog> управления инициализации:

```xml
<appSettings>
   <add key="EnablePrintPreviewOptimization" value="true" />
</appSettings>
```

Если `EnablePrintPreviewOptimization` ключа задано любое другое значение, или если ключ отсутствует, оптимизация не применяется.

Для приложений, выполняющихся в .NET Framework 4.6 или более поздней версии, можно добавить следующий параметр в [ \<AppContextSwitchOverrides >](../../configure-apps/file-schema/runtime/appcontextswitchoverrides-element.md) элемент в [ \<среды выполнения >](../../configure-apps/file-schema/runtime/index.md) раздел файла конфигурации приложения:

```xml
<runtime >
   <!-- AppContextSwitchOverrides values are in the form of 'key1=true|false;key2=true|false -->
   <AppContextSwitchOverrides value = "Switch.System.Drawing.Printing.OptimizePrintPreview=true" />
</runtime >
```

Если параметр не указан или если он имеет значение любое другое значение, оптимизация не применяется.

Если вы используете <xref:System.Drawing.Printing.PrintDocument.QueryPageSettings> событие, чтобы изменить параметры принтера, производительность <xref:System.Windows.Forms.PrintPreviewDialog> управления не улучшит, даже если задан параметр конфигурации оптимизации.

## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.PrintPreviewDialog>
- [Общие сведения об элементе управления PrintPreviewControl](printpreviewcontrol-control-overview-windows-forms.md)
- [Элемент управления PrintPreviewDialog](printpreviewdialog-control-windows-forms.md)
- [Элементы управления и компоненты диалоговых окон](dialog-box-controls-and-components-windows-forms.md)
