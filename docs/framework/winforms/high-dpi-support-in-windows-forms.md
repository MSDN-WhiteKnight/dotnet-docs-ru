---
title: Поддержка высокого DPI в Windows Forms
ms.date: 05/16/2017
helpviewer_keywords:
- High DPI in Windows Forms
- Dynamic rescaling in Windows Forms
- Windows Forms layout
- Windows Forms dynamic resizing
ms.assetid: 075ea4c3-900c-4f8a-9dd2-13ea6804346b
author: rpetrusha
ms.author: ronpet
ms.openlocfilehash: 1641702c7b1c3d3b0e83c59a96529de70f699d17
ms.sourcegitcommit: 69bf8b719d4c289eec7b45336d0b933dd7927841
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/14/2019
ms.locfileid: "57843613"
---
# <a name="high-dpi-support-in-windows-forms"></a>Поддержка высокого DPI в Windows Forms

Начиная с .NET Framework 4.7, Windows Forms включает усовершенствования для распространенных высокое разрешение и динамических сценариев точек на ДЮЙМ. Сюда входит следующее.

- Усовершенствования в масштабировании и макет ряд Windows Forms элементы управления, такие как <xref:System.Windows.Forms.MonthCalendar> управления и <xref:System.Windows.Forms.CheckedListBox> элемента управления.

- Один проход масштабирования.  В .NET Framework 4.6 и более ранних версий масштабирование было выполнено через несколько проходов, которые вызвала некоторые элементы управления масштабировать больше, чем была необходима.

- Поддержка динамических сценариев точек на ДЮЙМ, в которых пользователь изменяет идентификации точек на ДЮЙМ или масштаб после запуска приложения Windows Forms.

В версиях .NET Framework, начиная с .NET Framework 4.7 Улучшенная поддержка высокого Разрешения является дополнительной функции. Необходимо настроить приложение таким образом, чтобы воспользоваться его преимуществами.

## <a name="configuring-your-windows-forms-app-for-high-dpi-support"></a>Настройка поддержка высокого Разрешения в приложении Windows Forms

Новые функции Windows Forms, которые поддерживают высокий уровень поддержки определения DPI доступны только в приложениях, предназначенных для .NET Framework 4.7 и работают в операционных системах Windows, начиная с Windows 10 Creators Update.

Кроме того чтобы настроить поддержка высокого Разрешения в приложении Windows Forms, выполните следующие действия.

- Объявление совместимости с Windows 10.

  Чтобы сделать это, добавьте следующее в файл манифеста:

  ```xml
  <compatibility xmlns="urn:schemas-microsoft-com:compatibility.v1">
    <application>
      <!-- Windows 10 compatibility -->
      <supportedOS Id="{8e0f7a12-bfb3-4fe8-b9a5-48fd50a15a9a}" />
    </application>
  </compatibility>
  ```

- Включить awareness DPI для каждого монитора в *app.config* файл.

  Windows Forms вводится новый [ `<System.Windows.Forms.ApplicationConfigurationSection>` ](../configure-apps/file-schema/winforms/index.md) элемент для поддержки новых функций и добавлены сведения о настройках, начиная с .NET Framework 4.7. Чтобы воспользоваться преимуществами новых функций, которые поддерживают высокое разрешение, добавьте следующее в файл конфигурации приложения.

  ```xml
  <System.Windows.Forms.ApplicationConfigurationSection>
    <add key="DpiAwareness" value="PerMonitorV2" />
  </System.Windows.Forms.ApplicationConfigurationSection>
  ```

  > [!IMPORTANT]
  > В предыдущих версиях .NET Framework используемой манифест для добавления поддержка высокого Разрешения. Этот подход не рекомендуется, так как он переопределяет параметры, определенные в файле app.config.

- Вызовите статический <xref:System.Windows.Forms.Application.EnableVisualStyles%2A> метод.

  Это должен быть первый вызов метода в точку входа приложения. Пример:

  ```csharp
  static void Main()
  {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new Form2());
  }
  ```

## <a name="opting-out-of-individual-high-dpi-features"></a>Отказ от отдельных функций высокий DPI

Установка `DpiAwareness` значение `PerMonitorV2` возможности все высокий DPI awareness поддерживается в версиях .NET Framework, начиная с .NET Framework 4.7. Как правило этого достаточно для большинства приложений Windows Forms. Тем не менее вы можете отказаться от один или несколько отдельных компонентов. Самой важной причиной для этого является то, что существующий код приложения уже обрабатывает эту функцию.  Например если приложение обрабатывает автоматическое масштабирование, может потребоваться отключить автоматическое изменение размеров следующим образом:

```xml
<System.Windows.Forms.ApplicationConfigurationSection>
  <add key="DpiAwareness" value="PerMonitorV2" />
  <add key="EnableWindowsFormsHighDpiAutoResizing" value="false" />
</System.Windows.Forms.ApplicationConfigurationSection>
```

Список отдельных ключей и их значения, см. в разделе [добавьте элемент конфигурации Windows Forms](../configure-apps/file-schema/winforms/windows-forms-add-configuration-element.md).

## <a name="new-dpi-change-events"></a>Новые события изменения DPI

Три новые события, начиная с .NET Framework 4.7, позволяют программным образом обрабатывать динамические изменения DPI.

- <xref:System.Windows.Forms.Control.DpiChangedAfterParent>, который срабатывает, когда настройка DPI для элемента управления изменяется программным образом после события изменения DPI для его родительского элемента управления или формы произошла.
- <xref:System.Windows.Forms.Control.DpiChangedBeforeParent>, который срабатывает, когда настройка DPI для элемента управления изменяется программным образом перед событием изменения DPI для его родительского элемента управления или формы произошла.
- <xref:System.Windows.Forms.Form.DpiChanged>, который возникает при изменении настройки DPI на устройстве отображения, где в данный момент отображается форма.

## <a name="new-helper-methods-and-properties"></a>Новые вспомогательные методы и свойства

.NET Framework 4.7 также добавляет новые вспомогательные методы и свойства, которые предоставляют сведения о масштабе DPI и позволяют выполнять масштабирование. Сюда входит следующее.

- <xref:System.Windows.Forms.Control.LogicalToDeviceUnits%2A>, который преобразует значение из логического устройства.

- <xref:System.Windows.Forms.Control.ScaleBitmapLogicalToDevice%2A>, которая пропорционально увеличивает растровое изображение логического значения DPI для устройства.

- <xref:System.Windows.Forms.Control.DeviceDpi%2A>, который возвращает значения DPI для текущего устройства.

## <a name="versioning-considerations"></a>Вопросы управления версиями

Помимо выполнения по .NET Framework 4.7 и Windows 10 Creators Update, приложение может также выполняться в среде, в которой он не совместим с высоким DPI улучшения. В этом случае необходимо разработать переход на резервный ресурс для вашего приложения. Это можно сделать для выполнения [нестандартных операций рисования](./controls/user-drawn-controls.md) для обработки масштабирования.

Чтобы сделать это, необходимо также определить операционную систему, на котором выполняется приложение. Это можно сделать с помощью следующего кода:

```csharp
// Create a reference to the OS version of Windows 10 Creators Update.
Version OsMinVersion = new Version(10, 0, 15063, 0);

// Access the platform/version of the current OS.
Console.WriteLine(Environment.OSVersion.Platform.ToString());
Console.WriteLine(Environment.OSVersion.VersionString);

// Compare the current version to the minimum required version.
Console.WriteLine(Environment.OSVersion.Version.CompareTo(OsMinVersion));
```

Обратите внимание на то, что приложение не будет определять успешно Windows 10, если он не был указан как поддерживаемой операционной системы в манифесте приложения.

Вы также можете проверить версию .NET Framework, в которой было создано приложение:

```csharp
Console.WriteLine(AppDomain.CurrentDomain.SetupInformation.TargetFrameworkName);
```

## <a name="see-also"></a>См. также

- [Windows Forms добавьте элемент конфигурации](../configure-apps/file-schema/winforms/windows-forms-add-configuration-element.md)
- [Настройка размера и масштаба формы Windows Forms](adjusting-the-size-and-scale-of-windows-forms.md)
