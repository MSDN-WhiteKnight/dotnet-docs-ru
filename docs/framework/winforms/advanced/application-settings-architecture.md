---
title: Архитектура параметров приложения
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- application settings [Windows Forms], architecture
ms.assetid: c8eb2ad0-fac6-4ea2-9140-675a4a44d562
ms.openlocfilehash: c2a62b61cb7b31c978a84a3d3f41c24f9fafb84d
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59312570"
---
# <a name="application-settings-architecture"></a>Архитектура параметров приложения
В этом разделе описываются принципы работы архитектуры параметров приложения и рассматриваются дополнительные возможности архитектуры, такие как сгруппированные параметры и ключи параметров.  
  
 Архитектура параметров приложений позволяет определять строго типизированные параметры с областью приложения или пользователя и сохраняет параметры в сеансах приложения. Архитектура предоставляет механизм сохраняемости по умолчанию для сохранения параметров и их загрузки из локальной файловой системы. Она также определяет интерфейсы для предоставления пользовательских механизмов сохраняемости.  
  
 Эти интерфейсы позволяют пользовательским компонентам сохранять свои параметры, когда они размещаются в приложении. Благодаря ключам параметров компоненты могут раздельно хранить параметры для нескольких экземпляров компонента.  
  
## <a name="defining-settings"></a>Определение параметров  
 Архитектура параметров приложения используется внутри [!INCLUDE[vstecasp](../../../../includes/vstecasp-md.md)] и Windows Forms, и содержит ряд базовых классов, которые являются общими для обеих сред. Наиболее важным является <xref:System.Configuration.SettingsBase>, который предоставляет доступ к параметрам через коллекцию и предоставляет низкоуровневые методы для загрузки и сохранения параметров. Каждая среда реализует свой собственный класс, производный от <xref:System.Configuration.SettingsBase> для обеспечения дополнительных функциональных возможностей параметров для этой среды. В приложении Windows Forms все параметры приложения должны быть определены в классе, производном от <xref:System.Configuration.ApplicationSettingsBase> класс, который добавляет следующие функции базовому классу:  
  
-   Операции загрузки и сохранения более высокого уровня  
  
-   Поддержка параметров области пользователя  
  
-   Возврат для параметров пользователя предопределенных значений по умолчанию  
  
-   Обновление параметров из предыдущей версии приложения  
  
-   Проверка параметров, либо до их изменения, либо до их сохранения  
  
 Параметры можно описать с помощью нескольких атрибутов, определенных в <xref:System.Configuration> пространству имен; они описаны в [атрибуты параметров приложения](application-settings-attributes.md). При определении параметра его необходимо применить с помощью <xref:System.Configuration.ApplicationScopedSettingAttribute> или <xref:System.Configuration.UserScopedSettingAttribute>, которая описывает, применяется ли параметр ко всему приложению, или просто для текущего пользователя.  
  
 В следующем примере кода определяется пользовательский класс параметров с одним параметром `BackgroundColor`.  
  
 [!code-csharp[ApplicationSettings.Create#1](~/samples/snippets/csharp/VS_Snippets_Winforms/ApplicationSettings.Create/CS/MyAppSettings.cs#1)]
   
  
## <a name="settings-persistence"></a>Сохраняемость параметров  
 <xref:System.Configuration.ApplicationSettingsBase> Класс не сохраняемость или загрузку параметров; это выполняет поставщик параметров, а класс, производный от <xref:System.Configuration.SettingsProvider>. Если класс, производный от <xref:System.Configuration.ApplicationSettingsBase> не указывает поставщика параметров посредством <xref:System.Configuration.SettingsProviderAttribute>, а затем поставщика по умолчанию, <xref:System.Configuration.LocalFileSettingsProvider>, используется.  
  
 Система конфигурации, которая была первоначально выпущена с [!INCLUDE[dnprdnshort](../../../../includes/dnprdnshort-md.md)], поддерживает предоставление статических данных конфигурации приложения через файл machine.config локального компьютера или в файле `app.`exe.config, развертываемого вместе с приложением. <xref:System.Configuration.LocalFileSettingsProvider> Класс расширяет эту встроенную поддержку одним из следующих способов:  
  
-   Параметры области приложения могут храниться в файле machine.config или `app.`exe.config. Файл machine.config всегда предназначен только для чтения, тогда как `app`.exe.config для большинства приложений рекомендуется использовать только для чтения с точки зрения безопасности.  
  
-   Параметры области пользователя могут храниться в файлах `app`.exe.config. В этом случае они обрабатываются как статические значения по умолчанию.  
  
-   Параметры области пользователя не по умолчанию хранятся в новом файле — *пользователь*.config, где *пользователь* — имя пользователя, который в данный момент выполняет приложение. Можно указать значение по умолчанию для параметра области пользователя с <xref:System.Configuration.DefaultSettingValueAttribute>. Так как во время выполнения приложения параметры области пользователя часто изменяются, файл `user`.config всегда доступен для чтения и записи.  
  
 Во всех трех файлах конфигурации параметры хранятся в формате XML. Элементом XML верхнего уровня для параметров области приложения является `<appSettings>`, а `<userSettings>` используется для параметров области пользователя. Файл `app`.exe.config, содержащий как параметры области приложения, так и значения по умолчанию для параметров области пользователя, выглядит следующим образом:  
  
```xml  
<?xml version="1.0" encoding="utf-8" ?>  
<configuration>  
    <configSections>  
        <sectionGroup name="applicationSettings" type="System.Configuration.ApplicationSettingsGroup, System, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" >  
            <section name="WindowsApplication1.Properties.Settings" type="System.Configuration.ClientSettingsSection, System, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" />  
        </sectionGroup>  
        <sectionGroup name="userSettings" type="System.Configuration.UserSettingsGroup, System, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" >  
            <section name="WindowsApplication1.Properties.Settings" type="System.Configuration.ClientSettingsSection, System, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" allowExeDefinition="MachineToLocalUser" />  
        </sectionGroup>  
    </configSections>  
    <applicationSettings>  
        <WindowsApplication1.Properties.Settings>  
            <setting name="Cursor" serializeAs="String">  
                <value>Default</value>  
            </setting>  
            <setting name="DoubleBuffering" serializeAs="String">  
                <value>False</value>  
            </setting>  
        </WindowsApplication1.Properties.Settings>  
    </applicationSettings>  
    <userSettings>  
        <WindowsApplication1.Properties.Settings>  
            <setting name="FormTitle" serializeAs="String">  
                <value>Form1</value>  
            </setting>  
            <setting name="FormSize" serializeAs="String">  
                <value>595, 536</value>  
            </setting>  
        </WindowsApplication1.Properties.Settings>  
    </userSettings>  
</configuration>  
```  
  
 Определение элементов в разделе параметров приложения файла конфигурации см. в разделе [Схема параметров приложения](../../configure-apps/file-schema/application-settings-schema.md).  
  
### <a name="settings-bindings"></a>Привязки параметров  
 Параметры приложения используют архитектуру привязки данных Windows Forms для обеспечения двустороннего обмена обновлениями параметров между объектом параметров и компонентами. Если для создания параметров приложения и их назначения свойствам компонентов используется Visual Studio, эти привязки создаются автоматически.  
  
 Параметр приложения можно привязать только к компонента, поддерживающего <xref:System.Windows.Forms.IBindableComponent> интерфейс. Кроме того, компонент должен реализовывать событие изменения для конкретного связанного свойства или уведомлять параметры приложений об изменении свойства с помощью <xref:System.ComponentModel.INotifyPropertyChanged> интерфейс. Если компонент не реализует <xref:System.Windows.Forms.IBindableComponent> и привязка выполняется с помощью Visual Studio, то свойства привязки будут установлены в первый раз, но не будут обновляться. Если компонент реализует <xref:System.Windows.Forms.IBindableComponent> , но уведомления об изменении не поддержки свойств, привязка не будет обновлять файл параметров, при изменении свойства.  
  
 Некоторые компоненты Windows Forms, такие как <xref:System.Windows.Forms.ToolStripItem>, не поддерживают привязку параметров.  
  
### <a name="settings-serialization"></a>Сериализация параметров  
 Когда <xref:System.Configuration.LocalFileSettingsProvider> необходимо сохранить параметры на диск, он выполняет следующие действия:  
  
1. Использует отражение для проверки всех свойств, определенных для вашего <xref:System.Configuration.ApplicationSettingsBase> производного класса, поиск, примененные с помощью <xref:System.Configuration.ApplicationScopedSettingAttribute> или <xref:System.Configuration.UserScopedSettingAttribute>.  
  
2. Сериализует свойство на диск. Сначала пытается вызвать <xref:System.ComponentModel.TypeConverter.ConvertToString%2A> или <xref:System.ComponentModel.TypeConverter.ConvertFromString%2A> на тип, связанного с <xref:System.ComponentModel.TypeConverter>. Если это не удается, использует XML-сериализацию.  
  
3. Распределяет параметры по файлам на основе атрибута параметра.  
  
 При реализации собственного класса параметров можно использовать <xref:System.Configuration.SettingsSerializeAsAttribute> чтобы отметить параметр для настраиваемой или двоичной сериализации с помощью <xref:System.Configuration.SettingsSerializeAs> перечисления. Дополнительные сведения о создании собственных классов параметров в коде, см. в разделе [как: Создание параметров приложения](how-to-create-application-settings.md).  
  
### <a name="settings-file-locations"></a>Расположение файлов параметров  
 Расположение файлов `app`.exe.config и *user*.config зависит от способа установки приложения. Для приложения на базе Windows Forms, скопировать на локальном компьютере `app`. exe.config будет находиться в той же папке, что базовый каталог основного исполняемого файла приложения, и *пользователя*.config будет находиться в расположение которого задается <xref:System.Windows.Forms.Application.LocalUserAppDataPath%2A?displayProperty=nameWithType> свойство. Для приложения, установленного с помощью ClickOnce, оба этих файла будут находиться в каталоге данных ClickOnce в каталоге %InstallRoot%\Documents and Settings\\*имя_пользователя*\Local Settings.  
  
 Место хранения этих файлов будет другим, если пользователь включил перемещаемые профили, что позволит ему определять разные настройки Windows и приложения в случае использования им других компьютеров в домене. В этом случае для приложений ClickOnce и не ClickOnce их файлы `app`.exe.config и *user*.config будут находиться в каталоге %InstallRoot%\Documents and Settings\\*имя_пользователя*\Application Data.  
  
 Дополнительные сведения о том, как параметры приложения работают с новой технологией развертывания, см. в разделе [ClickOnce и параметры приложения](/visualstudio/deployment/clickonce-and-application-settings). Дополнительные сведения о каталоге данных ClickOnce см. в разделе [Доступ к локальным и удаленным данным в приложениях ClickOnce](/visualstudio/deployment/accessing-local-and-remote-data-in-clickonce-applications).  
  
## <a name="application-settings-and-security"></a>Параметры приложения и безопасность  
 Параметры приложения предназначены для работы в режиме частичного доверия, то есть в среде с ограниченным доступом, которая используется по умолчанию для приложений Windows Forms, размещенных в Интернете или интрасети. Для использования параметров приложения с поставщиком параметров по умолчанию специальные разрешения, выходящие за рамки частичного доверия, не нужны.  
  
 При использовании параметров приложения в приложенииClickOnce файл `user`.config хранится в каталоге данных ClickOnce. Размер файла `user`.config приложения не может превышать квоту каталога данных, заданную в ClickOnce. Дополнительные сведения см. в разделе [ClickOnce и параметры приложения](/visualstudio/deployment/clickonce-and-application-settings).  
  
## <a name="custom-settings-providers"></a>Поставщики пользовательских настроек  
 В архитектуре параметров приложений, есть слабую связь между параметрами приложения класс-оболочку, производный от <xref:System.Configuration.ApplicationSettingsBase>, и связанный поставщик параметров или поставщиков, производный от <xref:System.Configuration.SettingsProvider>. Эта связь определяется только <xref:System.Configuration.SettingsProviderAttribute> применен к классу-оболочке или его отдельным свойствам. Если параметры, поставщик явно не указано, поставщик по умолчанию, <xref:System.Configuration.LocalFileSettingsProvider>, используется. В результате такая архитектура позволяет создавать и использовать поставщиков настраиваемых параметров.  
  
 Предположим, что требуется разработать и использовать `SqlSettingsProvider`, то есть поставщика, который будет хранить все данные параметров в базе данных Microsoft SQL Server. Ваш <xref:System.Configuration.SettingsProvider>-получит эти сведения в производном классе его `Initialize` методу в качестве параметра типа <xref:System.Collections.Specialized.NameValueCollection?displayProperty=nameWithType>. Затем вы реализуете <xref:System.Configuration.SettingsProvider.GetPropertyValues%2A> метод для получения параметров из хранилища данных, и <xref:System.Configuration.SettingsProvider.SetPropertyValues%2A> для их сохранения. Поставщик может использовать <xref:System.Configuration.SettingsPropertyCollection> передаваемое <xref:System.Configuration.SettingsProvider.GetPropertyValues%2A> чтобы определить имя свойства, тип и область, а также любые другие атрибуты параметров, определенных для этого свойства.  
  
 Вашему поставщику будет необходимо реализовать одно свойство и один метод, реализация которых может оказаться сложной. <xref:System.Configuration.SettingsProvider.ApplicationName%2A> Свойство является абстрактным свойством класса <xref:System.Configuration.SettingsProvider>; оно для возврата следующее:  
  
 [!code-csharp[ApplicationSettings.Architecture#2](~/samples/snippets/csharp/VS_Snippets_Winforms/ApplicationSettings.Architecture/CS/DummyClass.cs#2)]
   
  
 Ваш производный класс также должен реализовать метод `Initialize`, который не принимает аргументы и не возвращает значения. Этот метод не определяется <xref:System.Configuration.SettingsProvider>.  
  
 Наконец, необходимо реализовать <xref:System.Configuration.IApplicationSettingsProvider> на поставщика, чтобы обеспечить поддержку обновления параметров, Возврат параметров по умолчанию и обновление параметров из одной версии приложения в другой.  
  
 После реализации и компиляции поставщика необходимо указать, что класс параметров должен использовать этого поставщика вместо значения по умолчанию. Для этого через <xref:System.Configuration.SettingsProviderAttribute>. Если применяется ко всему классу параметров поставщик используется для каждого параметра, который определяется в классе; Если применяется к отдельным параметрам архитектура параметров приложения использует этого поставщика только для этих параметров и использует <xref:System.Configuration.LocalFileSettingsProvider> для остальных. В следующем примере кода показано, как указать классу параметров, что необходимо использовать пользовательского поставщика.  
  
 [!code-csharp[ApplicationSettings.Architecture#1](~/samples/snippets/csharp/VS_Snippets_Winforms/ApplicationSettings.Architecture/CS/DummyClass.cs#1)]
   
  
 Поставщик можно вызывать одновременно из нескольких потоков, но он всегда будет выполнять запись данных в одно место хранения. Таким образом, архитектура параметров приложения будет всегда создавать только один экземпляр класса поставщика.  
  
> [!IMPORTANT]
>  Следует убедиться, что поставщик является потокобезопасным и позволяет выполнять запись в файлы конфигурации только одному потоку за раз.  
  
 Поставщик должен поддерживать все атрибуты, определенные в параметры <xref:System.Configuration?displayProperty=nameWithType> пространства имен, хотя необходимо по меньшей мере поддерживать <xref:System.Configuration.ApplicationScopedSettingAttribute> и <xref:System.Configuration.UserScopedSettingAttribute>и также должен поддерживать <xref:System.Configuration.DefaultSettingValueAttribute>. Для тех атрибутов, которые он не поддерживает, поставщик должен завершаться ошибкой без уведомления. Он не должен создавать исключение. Если класс параметров использует Недопустимое сочетание атрибутов, тем не менее, такие как применение <xref:System.Configuration.ApplicationScopedSettingAttribute> и <xref:System.Configuration.UserScopedSettingAttribute> тот же параметр — ваш поставщик должен исключение и прервать операцию.  
  
## <a name="see-also"></a>См. также

- <xref:System.Configuration.ApplicationSettingsBase>
- <xref:System.Configuration.SettingsProvider>
- <xref:System.Configuration.LocalFileSettingsProvider>
- [Общие сведения о параметрах приложений](application-settings-overview.md)
- [Параметры приложения для пользовательских элементов управления](application-settings-for-custom-controls.md)
- [ClickOnce и параметры приложения](/visualstudio/deployment/clickonce-and-application-settings)
- [Схема параметров приложения](../../configure-apps/file-schema/application-settings-schema.md)
