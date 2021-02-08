---
description: 'Дополнительные сведения: <NetFx40_LegacySecurityPolicy элемент>'
title: Элемент <NetFx40_LegacySecurityPolicy>
ms.date: 03/30/2017
helpviewer_keywords:
- <NetFx40_LegacySecurityPolicy> element
- NetFx40_LegacySecurityPolicy element
ms.assetid: 07132b9c-4a72-4710-99d7-e702405e02d4
ms.openlocfilehash: 6be520d4cfd4f9ec05f4aceec82e4fef5440f55d
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99782316"
---
# <a name="netfx40_legacysecuritypolicy-element"></a>Элемент \<NetFx40_LegacySecurityPolicy>

Указывает, использует ли среда выполнения устаревшую политику разграничения доступа кода.

[**\<configuration>**](../configuration-element.md)\
&nbsp;&nbsp;[**\<runtime>**](runtime-element.md)\
&nbsp;&nbsp;&nbsp;&nbsp;**\<NetFx40_LegacySecurityPolicy>**  

## <a name="syntax"></a>Синтаксис

```xml
<NetFx40_LegacySecurityPolicy
   enabled="true|false"/>
```

## <a name="attributes-and-elements"></a>Атрибуты и элементы

В следующих разделах описаны атрибуты, дочерние и родительские элементы.

### <a name="attributes"></a>Атрибуты

|Атрибут|Описание|
|---------------|-----------------|
|`enabled`|Обязательный атрибут.<br /><br /> Указывает, использует ли среда выполнения устаревшую политику разграничения доступа кода.|

## <a name="enabled-attribute"></a>Атрибут enabled

|Значение|Описание|
|-----------|-----------------|
|`false`|Среда выполнения не использует устаревшую политику разграничения доступа кода. Это значение по умолчанию.|
|`true`|Среда выполнения использует устаревшую политику разграничения доступа кода.|

### <a name="child-elements"></a>Дочерние элементы

Отсутствует.

### <a name="parent-elements"></a>Родительские элементы

|Элемент|Описание|
|-------------|-----------------|
|`configuration`|Корневой элемент в любом файле конфигурации, используемом средой CLR и приложениями .NET Framework.|
|`runtime`|Содержит сведения о параметрах инициализации среды выполнения.|

## <a name="remarks"></a>Remarks

В платформа .NET Framework версии 3,5 и более ранних версиях политика CAS действует всегда. В платформа .NET Framework 4 политика CAS должна быть включена.

Политика CAS зависит от версии. Пользовательские политики CAS, существующие в более ранних версиях платформа .NET Framework, должны быть указаны в платформа .NET Framework 4.

Применение `<NetFx40_LegacySecurityPolicy>` элемента к сборке платформа .NET Framework 4 не влияет на прозрачный для [безопасности код](../../../misc/security-transparent-code.md); правила прозрачности по-прежнему применяются.

> [!IMPORTANT]
> Применение `<NetFx40_LegacySecurityPolicy>` элемента может привести к значительному снижению производительности для сборок образов в машинном кодах, созданных [генератором образов в машинном кодах (Ngen.exe)](../../../tools/ngen-exe-native-image-generator.md) , которые не установлены в [глобальном кэше сборок](../../../app-domains/gac.md). Снижение производительности вызвано невозможностью загрузки средой выполнения сборок в качестве образов в машинном код при применении атрибута, что приводит к их загрузке как JIT-сборки.

> [!NOTE]
> Если указать целевую версию платформа .NET Framework более раннюю, чем платформа .NET Framework 4 в параметрах проекта для проекта Visual Studio, будет включена политика CAS, включая любые пользовательские политики CAS, указанные для этой версии. Однако вы не сможете использовать новые типы и члены платформа .NET Framework 4. Можно также указать более раннюю версию платформа .NET Framework с помощью [ \<supportedRuntime> элемента](../startup/supportedruntime-element.md) в схеме параметров запуска в [файле конфигурации приложения](../../index.md).

> [!NOTE]
> В синтаксисе файла конфигурации учитывается регистр. Следует использовать синтаксис, указанный в разделах синтаксис и пример.

## <a name="configuration-file"></a>Файл конфигурации

Этот элемент может использоваться только в файле конфигурации приложения.

## <a name="example"></a>Пример

В следующем примере показано, как включить устаревшую политику CAS для приложения.

```xml
<configuration>
   <runtime>
      <NetFx40_LegacySecurityPolicy enabled="true"/>
   </runtime>
</configuration>
```

## <a name="see-also"></a>См. также

- [Схема параметров среды выполнения](index.md)
- [Схема файла конфигурации](../index.md)
