---
title: Критическое изменение. Свойству OutputType задано значение WinExe для приложений WPF и WinForms
description: Сведения о критическом изменении в пакете SDK для .NET 5.0.100, где свойству OutputType автоматически задается значение WinExe для приложений Windows Forms.
ms.date: 02/08/2021
ms.openlocfilehash: 565007e9ce6be289456afc9facbd4c555a1110bd
ms.sourcegitcommit: 9c589b25b005b9a7f87327646020eb85c3b6306f
ms.translationtype: HT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/06/2021
ms.locfileid: "102256184"
---
# <a name="outputtype-set-to-winexe-for-wpf-and-winforms-apps"></a>Свойству OutputType задано значение WinExe для приложений WPF и WinForms

Свойству `OutputType` автоматически задано значение `WinExe` для приложений Windows Presentation Foundation (WPF) и Windows Forms. Если свойство `OutputType` имеет значение `WinExe`, окно консоли не открывается при выполнении приложения.

## <a name="change-description"></a>Описание изменений

В предыдущих версиях пакета SDK для .NET используется значение, указанное для `OutputType` в файле проекта. Пример:

```xml
<PropertyGroup>
  <OutputType>Exe</OutputType>
</PropertyGroup>
```

Начиная с версии 5.0.100 пакета SDK для .NET, когда параметру `OutputType` присвоено значение `Exe`, оно автоматически заменяется на значение `WinExe` для приложений WPF и Windows Forms, предназначенных для любой версии платформы, включая .NET Framework.

```xml
<PropertyGroup>
  <OutputType>WinExe</OutputType>
</PropertyGroup>
```

 Если в файле проекта не указан параметр `OutputType`, по умолчанию используется `Library` и это значение не изменяется.

## <a name="reason-for-change"></a>Причина изменения

Предполагается, что большинство пользователей не хотят, чтобы окно консоли открывалось при выполнении приложения WPF или Windows Forms. Кроме того, [поскольку теперь эти типы приложений используют пакет SDK для .NET](sdk-and-target-framework-change.md) вместо пакета SDK для Windows Desktop, будет задано правильное значение по умолчанию. При добавлении поддержки для использования iOS и Android в качестве целевых платформ будет проще работать с несколькими платформами, если все они используют один и тот же тип выходных данных.

## <a name="version-introduced"></a>Представленная версия

.NET 5.0.100

## <a name="recommended-action"></a>Рекомендованное действие

Никаких действий выполнять не требуется. Однако если вы хотите восстановить старое поведение, задайте свойству `DisableWinExeOutputInference` значение `true` в файле проекта.

```xml
<DisableWinExeOutputInference>true</DisableWinExeOutputInference>
```

## <a name="affected-apis"></a>Затронутые API

Невозможно обнаружить с помощью анализа API.

<!--

### Affected APIs

Not detectable via API analysis.

### Category

- Windows Forms
- Windows Presentation Framework (WPF)

-->
