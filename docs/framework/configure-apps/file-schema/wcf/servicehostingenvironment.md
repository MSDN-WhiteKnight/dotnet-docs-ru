---
description: 'Дополнительные сведения: <serviceHostingEnvironment>'
title: <serviceHostingEnvironment>
ms.date: 03/30/2017
ms.assetid: 4f8a7c4f-e735-4987-979a-b74fcdae2652
ms.openlocfilehash: 95243a1cf9cea734b7f35a1400a8b5b865767976
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99786724"
---
# \<serviceHostingEnvironment>

Этот элемент определяет тип, который среда размещения служб создает для определенного транспорта. Если этот элемент является пустым, используется тип, применяемый по умолчанию. Этот элемент может применяться только на уровне файлов конфигурации приложения или компьютера.  
  
[**\<configuration>**](../configuration-element.md)\
&nbsp;&nbsp;[**\<system.serviceModel>**](system-servicemodel.md)\
&nbsp;&nbsp;&nbsp;&nbsp;**\<serviceHostingEnvironment>**  
  
## <a name="syntax"></a>Синтаксис  
  
```xml  
<serviceHostingEnvironment aspNetCompatibilityEnabled="Boolean"
                           minFreeMemoryPercentageToActivateService="Integer"
                           multipleSiteBindingsEnabled="Boolean">
  <baseAddressPrefixFilters>
    <add prefix="string" />
  </baseAddressPrefixFilters>
  <serviceActivations>
    <add factory="String"
         service="String" />
  </serviceActivations>
  <transportConfigurationTypes>
    <add name="String"
         transportConfigurationType="String" />
  </transportConfigurationTypes>
</serviceHostingEnvironment>
```  
  
## <a name="attributes-and-elements"></a>Атрибуты и элементы  

 В следующих разделах описаны атрибуты, дочерние и родительские элементы.  
  
### <a name="attributes"></a>Атрибуты  
  
|Атрибут|Описание|  
|---------------|-----------------|  
|aspNetCompatibilityEnabled|Логическое значение, указывающее, включен ли режим совместимости ASP.NET для текущего приложения. Значение по умолчанию — `false`.<br /><br /> Если этот атрибут имеет значение `true` , запросы к службам Windows Communication Foundation (WCF) проходят через конвейер HTTP ASP.NET, и связь по протоколам, отличным от HTTP, запрещена. Дополнительные сведения см. в разделе [WCF Services and ASP.NET](../../../wcf/feature-details/wcf-services-and-aspnet.md).|  
|minFreeMemoryPercentageToActivateService|Целое число, указывающее минимальный объем свободной памяти, который должен быть доступен системе, прежде чем служба WCF сможет быть активирована. **Внимание!**  Если указать этот атрибут вместе с частичным доверием в web.configном файле службы WCF, то при запуске службы будет возникать исключение <xref:System.Security.SecurityException> .|  
|multipleSiteBindingsEnabled|Логическое значение, которое определяет, разрешается ли использование нескольких привязок IIS для одного узла.<br /><br /> Службы IIS состоят из веб-узлов, являющихся контейнерами виртуальных приложений, содержащих виртуальные каталоги. Доступ к приложению на узле можно осуществлять через одну или несколько привязок IIS. Привязка IIS предоставляет два блока данных: протокол привязки и данные привязки. Протокол привязки определяет схему, посредством которой осуществляется связь, а данные привязки содержат сведения, используемые для доступа к узлу. Примером протокола привязки является HTTP, в котором данные привязки могут содержать IP-адрес, порт, заголовок узла и т. п.<br /><br /> IIS поддерживает задание нескольких привязок IIS для каждого узла, что позволяет использовать несколько базовых адресов для каждой схемы. Однако служба Windows Communication Foundation (WCF), размещенная на сайте, позволяет привязать только к одному baseAddress на схему.<br /><br /> Чтобы включить несколько привязок IIS на сайт для службы Windows Communication Foundation (WCF), присвойте этому атрибуту значение `true` . Следует иметь в виду, что привязки к нескольким узлам поддерживаются только в протоколе HTTP. Адрес конечной точки в файле конфигурации должен быть полным URI.|  
  
### <a name="child-elements"></a>Дочерние элементы  
  
|Элемент|Описание|  
|-------------|-----------------|  
|[\<baseAddressPrefixFilters>](baseaddressprefixfilters.md)|Коллекция элементов конфигурации, которые задают префиксные фильтры для базовых адресов, используемых узлом службы.|  
|[\<serviceActivations>](serviceactivations.md)|Раздел конфигурации, в котором описываются параметры активации.|  
|[\<transportConfigurationTypes>](transportconfigurationtypes.md)|Коллекция элементов конфигурации, которые определяют тип конкретного транспорта.|  
  
### <a name="parent-elements"></a>Родительские элементы  
  
|Элемент|Описание|  
|-------------|-----------------|  
|serviceModel|Корневой элемент всех элементов конфигурации Windows Communication Foundation (WCF).|  
  
## <a name="remarks"></a>Remarks  

 По умолчанию службы WCF выполняются параллельно с ASP.NET в размещенных доменах приложений (AppDomain). Хотя WCF и ASP.NET могут существовать вместе в одном домене приложений, по умолчанию конвейер HTTP ASP.NET не обрабатывает запросы WCF. В результате несколько элементов платформы приложений ASP.NET будут недоступны службам WCF. К ним относятся  
  
- Авторизация файла/URL-адреса ASP.NET  
  
- Олицетворение ASP.NET  
  
- Состояние сеанса на основании файлов Cookie  
  
- HttpContext.Current  
  
- Расширяемость конвейера через настраиваемый элемент HttpModule  
  
 Если службам WCF нужно функционировать в контексте ASP.NET и взаимодействовать только по протоколу HTTP, можно использовать режим совместимости ASP.NET WCF. Этот режим включается, когда атрибут `aspNetCompatibilityEnabled` имеет значение `true` на уровне приложения. В реализации службы должна быть объявлена возможность выполнения в режиме совместимости с помощью класса <xref:System.ServiceModel.Activation.AspNetCompatibilityRequirementsAttribute>. Если режим совместимости включен, это приводит к следующему.  
  
- Авторизация файла/URL-адреса ASP.NET принудительно выполняется до авторизации WCF. Решение об авторизации основано на удостоверении запроса уровня транспорта. Удостоверения уровня сообщения не учитываются.  
  
- Операции служб WCF начинают выполняться в контексте олицетворения ASP.NET. Если для конкретной службы включены и олицетворение ASP.NET, и олицетворение WCF, применяется контекст олицетворения WCF.  
  
- HttpContext.Current может использоваться из кода службы WCF, и предотвращается представление службами конечных точек, работающих по протоколу, отличному от HTTP.  
  
- Запросы WCF обрабатываются конвейером ASP.NET. Элемент HttpModules, заданный для обработки входящих запросов, также может обрабатывать запросы WCF. Они могут включать компоненты платформы ASP.NET (например, <xref:System.Web.SessionState.SessionStateModule>), а также настраиваемые модули сторонних поставщиков.  
  
## <a name="example"></a>Пример  

 В следующем образце кода показано, как включить режим совместимости ASP.  
  
## <a name="code"></a>Код  
  
```xml  
<serviceHostingEnvironment aspNetCompatibilityEnabled="true"/>
```  
  
## <a name="see-also"></a>См. также

- <xref:System.ServiceModel.Configuration.ServiceHostingEnvironmentSection>
- <xref:System.ServiceModel.ServiceHostingEnvironment>
- [Размещение](../../../wcf/feature-details/hosting.md)
- [Службы WCF и ASP.NET](../../../wcf/feature-details/wcf-services-and-aspnet.md)
