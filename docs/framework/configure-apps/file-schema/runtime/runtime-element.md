---
description: 'Дополнительные сведения о: <runtime> element'
title: Элемент <runtime>
ms.date: 03/30/2017
f1_keywords:
- http://schemas.microsoft.com/.NetConfiguration/v2.0#runtime
- http://schemas.microsoft.com/.NetConfiguration/v2.0#configuration/runtime
helpviewer_keywords:
- <runtime> element
- runtime element
- container tags, <runtime> element
ms.assetid: 1eb2fae3-de4b-45b6-852f-517c39b751bd
ms.openlocfilehash: eeffc8de4eeb6fb53ef3829b8c5b078be4cee83a
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99652774"
---
# <a name="runtime-element"></a>Элемент \<runtime>

Предоставляет сведения, используемые средой CLR для настройки приложений.

[\<configuration>](../configuration-element.md)\
&nbsp;&nbsp;\<runtime>

## <a name="syntax"></a>Синтаксис

```xml
<runtime>
</runtime>
```

## <a name="attributes-and-elements"></a>Атрибуты и элементы

В следующих разделах описываются дочерние элементы и родительские элементы.

### <a name="attributes"></a>Атрибуты

Отсутствует.

### <a name="child-elements"></a>Дочерние элементы

|Элемент|Описание|
|-------------|-----------------|
|[\<alwaysFlowImpersonationPolicy>](alwaysflowimpersonationpolicy-element.md)|Указывает, что удостоверение Windows всегда проходит через асинхронные точки, независимо от того, как было выполнено олицетворение.|
|[\<AppContextSwitchOverrides>](appcontextswitchoverrides-element.md)|Определяет один или несколько коммутаторов, используемых классом <xref:System.AppContext> для предоставления механизма отказа от новых функциональных возможностей.|
|[\<appDomainManagerAssembly>](appdomainmanagerassembly-element.md)|Указывает сборку, предоставляющую диспетчер домена приложения для домена приложения, по умолчанию используемого в процессе.|
|[\<appDomainManagerType>](appdomainmanagertype-element.md)|Указывает тип, который служит диспетчером домена приложения для домена приложения, используемого по умолчанию.|
|[\<appDomainResourceMonitoring>](appdomainresourcemonitoring-element.md)|Указывает среде собирать статистику для всех доменов приложений в процессе за весь период его существования.|
|[\<assemblyBinding>](assemblybinding-element-for-runtime.md)|Содержит сведения о перенаправлении версии сборки и о расположениях сборок.|
|[\<bypassTrustedAppStrongNames>](bypasstrustedappstrongnames-element.md)|Указывает, следует ли обходить проверку строгих имен для доверенных сборок.|
|[\<CompatSortNLSVersion>](compatsortnlsversion-element.md)|Указывает, что среда выполнения должна использовать устаревшее поведение сортировки при выполнении сравнения строк.|
|[\<developmentMode>](developmentmode-element.md)|Указывает, выполняет ли среда поиск сборок в каталогах, указанных в переменной среды DEVPATH.|
|[\<disableCachingBindingFailures>](disablecachingbindingfailures-element.md)|Указывает, отключено ли кэширование ошибок привязки, что является поведением по умолчанию в платформа .NET Framework версии 2,0.|
|[\<disableCommitThreadStack>](disablecommitthreadstack-element.md)|Указывает, фиксируется ли весь стек потоков при запуске потока.|
|[\<disableFusionUpdatesFromADManager>](disablefusionupdatesfromadmanager-element.md)|Указывает, отключено ли поведение по умолчанию, которое разрешает хост-приложению среды выполнения переопределять параметры конфигурации для домена приложения.|
|[\<EnableAmPmParseAdjustment>](enableampmparseadjustment-element.md)|Определяет, используют ли методы анализа даты и времени скорректированной набор правил для анализа строк даты, содержащих только день, месяц, час и указатель AM/PM.|
|[\<enforceFIPSPolicy>](enforcefipspolicy-element.md)|Указывает, нужно ли принудительно обеспечивать соблюдение требования конфигурации компьютера о том, что криптографические алгоритмы должны соответствовать стандартам FIPS.|
|[\<etwEnable>](etwenable-element.md)|Указывает, следует ли включить трассировку событий Windows для событий среды CLR.|
|[\<forcePerformanceCounterUniqueSharedMemoryReads>](forceperformancecounteruniquesharedmemoryreads-element.md)|Указывает, использует ли файл PerfCounter.dll параметр реестра CategoryOptions в приложении .NET Framework версии 1.1, чтобы определить, следует ли загружать данные счетчиков производительности из общей памяти конкретной категории или глобальной памяти.|
|[\<gcAllowVeryLargeObjects>](gcallowverylargeobjects-element.md)|На 64 разрядных платформах позволяет использовать массивы, размер которых превышает 2 гигабайта (ГБ).|
|[\<gcConcurrent>](gcconcurrent-element.md)|Указывает, должна ли среда CLR выполнять сборку мусора параллельно.|
|[\<GCCpuGroup>](gccpugroup-element.md)|Определяет, поддерживает ли сборка мусора несколько групп ЦП.|
|[\<GCHeapAffinitizeMask>](gcheapaffinitizemask-element.md)|Определяет сходство между кучами сборки мусора и отдельными процессорами.|
|[\<GCHeapCount>](gcheapcount-element.md)|Указывает число куч/потоков, используемых для сборки мусора сервера.|
|[\<GCLOHThreshold>](gclohthreshold-element.md)|Задает пороговый размер, который заставляет сборщик мусора разместить объекты в куче больших объектов.|
|[\<GCNoAffinitize>](gcnoaffinitize-element.md)|Указывает, следует ли привязать потоки сборки мусора сервера с процессорами.|
|[\<gcServer>](gcserver-element.md)|Указывает, выполняет ли среда CLR сборку мусора сервера.|
|[\<generatePublisherEvidence>](generatepublisherevidence-element.md)|Указывает, использует ли среда выполнения политику разграничения доступа кода, используемую издателем.|
|[\<legacyCorruptedStateExceptionsPolicy>](legacycorruptedstateexceptionspolicy-element.md)|Указывает, позволяет ли среда выполнения управляемому коду перехватывать нарушения прав доступа и другие исключения поврежденного состояния.|
|[\<legacyImpersonationPolicy>](legacyimpersonationpolicy-element.md)|Указывает, что удостоверение Windows не проходит через асинхронные точки, независимо от параметров потока для контекста выполнения в текущем потоке.|
|[\<loadfromRemoteSources>](loadfromremotesources-element.md)|Указывает, загружены ли сборки из удаленных источников как полностью доверенные.|
|[\<NetFx40_LegacySecurityPolicy>](netfx40-legacysecuritypolicy-element.md)|Указывает, использует ли среда выполнения устаревшую политику разграничения доступа кода.|
|[\<NetFx40_PInvokeStackResilience>](netfx40-pinvokestackresilience-element.md)|Указывает, исправляет ли автоматически среда выполнения неправильные объявления вызова неуправляемого кода во время выполнения за счет скорости перехода между управляемыми и неуправляемым кодом.|
|[\<NetFx45_CultureAwareComparerGetHashCode_LongStrings>](netfx45-cultureawarecomparergethashcode-longstrings-element.md)|Определяет, использует ли среда выполнения постоянный объем памяти для вычисления хэш-кодов методом <xref:System.StringComparer.GetHashCode%2A?displayProperty=nameWithType> .|
|[\<PreferComInsteadOfRemoting>](prefercominsteadofmanagedremoting-element.md)|Указывает, что среда выполнения должна использовать COM-взаимодействие вместо удаленного взаимодействия через границы домена приложения.|
|[\<relativeBindForResources>](relativebindforresources-element.md)|Оптимизирует поиск вспомогательных сборок.|
|[\<shadowCopyVerifyByTimeStamp>](shadowcopyverifybytimestamp-element.md)|Указывает, использует ли теневое копирование поведение при запуске по умолчанию, представленное в платформа .NET Framework 4, или возвращается к поведению при запуске более ранних версий платформа .NET Framework.|
|[\<supportPortability>](supportportability-element.md)|Указывает, что приложение может ссылаться на ту же сборку в двух различных реализациях .NET Framework, отключая поведение по умолчанию, которое рассматривает сборки как эквивалент для переносимости приложения.|
|[\<system.runtime.caching>](system-runtime-caching-element-cache-settings.md)|Указывает сведения о конфигурации кэша объектов в памяти, используемого по умолчанию.|
|[\<Thread_UseAllCpuGroups>](thread-useallcpugroups-element.md)|Указывает, распределяет ли среда выполнения управляемые потоки во всех группах ЦП.|
|[\<ThrowUnobservedTaskExceptions>](throwunobservedtaskexceptions-element.md)|Определяет, будут ли необработанные исключения задачи завершать выполняющийся процесс.|
|[\<TimeSpan_LegacyFormatMode>](timespan-legacyformatmode-element.md)|Указывает, использует ли среда выполнения устаревшее форматирование для значений <xref:System.TimeSpan>.|
|[\<useLegacyJit>](uselegacyjit-element.md)|Определяет, использует ли среда CLR устаревший 64-разрядный JIT-компилятор для JIT-компиляции.|
|[\<UseRandomizedStringHashAlgorithm>](userandomizedstringhashalgorithm-element.md)|Указывает, вычисляет ли среда выполнения хэш-коды для строк для каждого домена приложения.|
|[\<UseSmallInternalThreadStacks>](usesmallinternalthreadstacks-element.md)|Запрашивает использование средой выполнения явных размеров стека при создании определенных потоков, используемых для внутренних целей, вместо размер стека по умолчанию.|

### <a name="parent-elements"></a>Родительские элементы

|Элемент|Описание|
|-------------|-----------------|
|`configuration`|Корневой элемент в любом файле конфигурации, используемом средой CLR и приложениями .NET Framework.|

## <a name="remarks"></a>Remarks

Дочерние элементы в [\<runtime>](runtime-element.md) разделе файла конфигурации используются средой CLR для настройки способа выполнения приложения. Например, [\<gcServer>](gcserver-element.md) элемент определяет, использует ли сборщик мусора рабочую станцию для сборки мусора рабочей станции или сборки мусора сервера, [\<UseRandomizedStringHashAlgorithm>](userandomizedstringhashalgorithm-element.md) элемент определяет, вычисляет ли среда CLR хэш-коды для каждого приложения или домена приложения, и `AppContextSwitchOverrides` элемент позволяет пользователям библиотек выбрать или отказаться от измененных функциональных возможностей, предоставляемых библиотекой.

Элементы в [\<runtime>](runtime-element.md) разделе автоматически считываются средой CLR при запуске приложения. Можно также определить файл конфигурации для домена приложения, не используемого по умолчанию, указав его имя для <xref:System.AppDomainSetup.ConfigurationFile%2A?displayProperty=nameWithType> Свойства. его параметры считываются автоматически при загрузке домена приложения. Если когда-либо в любом случае, необходимо напрямую считывать параметры в [\<runtime>](runtime-element.md) разделе файла конфигурации приложения.

## <a name="see-also"></a>См. также

- [Схема параметров среды выполнения](index.md)
- [Схема файла конфигурации](../index.md)
