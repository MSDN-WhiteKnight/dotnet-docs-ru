---
title: Критическое изменение. Символ препроцессора NETCOREAPP3_1 не определен при нацеливании на .NET 5
description: Сведения о критическом изменении в .NET 5, где проекты больше не определяют символы препроцессора для более ранних версий.
ms.date: 09/17/2020
ms.openlocfilehash: 390c8f5af97510db4652f3f42db577e6de158020
ms.sourcegitcommit: 9c589b25b005b9a7f87327646020eb85c3b6306f
ms.translationtype: HT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/06/2021
ms.locfileid: "102256534"
---
# <a name="netcoreapp3_1-preprocessor-symbol-is-not-defined-when-targeting-net-5"></a>Символ препроцессора NETCOREAPP3_1 не определен при нацеливании на .NET 5

В .NET 5 RC2 и более поздних версиях в проектах больше не определяются символы препроцессора для более ранних версий. Определяются символы препроцессора только для целевой версии. Это то же самое поведение, что и в .NET Core 1.0–3.1.

## <a name="version-introduced"></a>Представленная версия

5.0 RC2

## <a name="change-description"></a>Описание изменений

В версиях .NET 5 с предварительной версии 7 до RC1 в проектах, предназначенных для `net5.0`, определяются символы препроцессора `NETCOREAPP3_1` и `NET5_0`. Цель этого изменения поведения заключается в том, чтобы начиная с .NET 5 символы условной компиляции [были накопительными](https://github.com/dotnet/designs/blob/main/accepted/2020/net5/net5.md#preprocessor-symbols).

В .NET 5 RC2 и более поздних версиях в проектах определяются только символы для моникеров целевой платформы (TFM), для которой она предназначена, а не для предыдущих версий.

## <a name="reason-for-change"></a>Причина изменения

Изменение из предварительной версии 7 было отменено из-за отзывов пользователей. Определение символов для более ранних версий удивило и запутало пользователей, и некоторые предположили, что это ошибка в компиляторе C#.

## <a name="recommended-action"></a>Рекомендованное действие

Убедитесь, что в логике `#if` не предполагается определение `NETCOREAPP3_1`, если проект предназначен для `net5.0` или более поздней версии. Вместо этого сделайте так, чтобы `NETCOREAPP3_1` определялся только в том случае, если проект явно предназначен для `netcoreapp3.1`.

Например, если проект предназначен для нескольких платформ (.NET Core 2.1 и .NET Core 3.1) и вы вызываете API, которые появились в .NET Core 3.1, то логика `#if` должна выглядеть следующим образом:

```csharp
#if NETCOREAPP2_1 || NETCOREAPP3_0
    // Fallback behavior for old versions.
#elif NETCOREAPP
    // Behavior for .NET Core 3.1 and later.
#endif
```

## <a name="affected-apis"></a>Затронутые API

Н/Д

<!--

### Affected APIs

Not detectable via API analysis.

### Category

MSBuild

-->
