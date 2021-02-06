---
description: 'Дополнительные сведения: <behaviorExtensions>'
title: <behaviorExtensions>
ms.date: 03/30/2017
ms.assetid: 59f2791a-c78f-40d7-aa80-0d9cd10135d9
ms.openlocfilehash: 0bd641f8e26d309c592c07bcc19ff02897fe71cd
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99639527"
---
# \<behaviorExtensions>

Расширения поведений позволяют пользователям создавать пользовательские элементы поведений. Эти элементы могут использоваться вместе со стандартными элементами поведений Windows Communication Foundation (WCF). В разделе `behaviorExtensions` определяется элемент, который может использоваться в конфигурации. Далее приведен пример типичного расширения поведения.  
  
```xml  
<system.serviceModel>
  <extensions>
    <behaviorExtensions>
      <add name="myBehavior"
           type="Microsoft.ServiceModel.Samples.MyBehaviorSection, MyBehavior,
                 Version=1.0.0.0, Culture=neutral, PublicKeyToken=null" />
    </behaviorExtensions>
  </extensions>
</system.serviceModel>
```  
  
 Чтобы добавить в элемент возможности конфигурации, нужно записать и зарегистрировать элемент конфигурации. Дополнительные сведения об этом см. в документации по <xref:System.Configuration>.  
  
 После определения элемента и его типа конфигурации поведение можно использовать, как показано в следующем примере.  
  
```xml  
<behaviors>
  <behavior configurationName="testChannelBehavior">
    <myBehavior />
    <channelSecurity cacheCookies="false"
                     detectReplays="false"
                     maxCachedNonces="9"
                     maxClockSkew="00:00:03"
                     maxCookieCachingTime="00:07:24"
                     replayWindow="00:07:22.2190000" />
  </behavior>
</behaviors>
```  
  
## <a name="security"></a>Безопасность  

 Настоятельно рекомендуется использовать полные имена сборок при регистрации типов в файлах `machine.config` и `app.config`. Если тип определен неоднозначно, загрузчик типов среды CLR ищет его в следующих местоположениях в заданном порядке:  
  
 Если сборка типа известна, загрузчик ищет в местах перенаправления файла конфигурации, в глобальном кэше сборок, в текущей сборке, используя данные конфигурации, и в базовой папке приложения. Если сборка неизвестна, загрузчик ищет в текущей сборке, в библиотеке mscorlib и в месте, возвращаемом обработчиком событий `TypeResolve`. Порядок поиска в среде CLR может быть изменен с помощью таких средств, как механизм пересылки типа и событие AppDomain.TypeResolve.  
  
 Злоумышленник может использовать порядок поиска в среде CLR и выполнить неавторизованный код. Использование полных (надежных) имен однозначно определяет тип и повышает безопасность системы.  
  
 Дополнительные сведения см. [в разделе как среда выполнения находит сборки](../../../deployment/how-the-runtime-locates-assemblies.md) и <xref:System.AppDomain.TypeResolve> .  
  
## <a name="see-also"></a>См. также

- <xref:System.ServiceModel.Configuration.BehaviorExtensionElement>
- [Настройка и расширение среды выполнения с помощью поведений](../../../wcf/extending/configuring-and-extending-the-runtime-with-behaviors.md)
