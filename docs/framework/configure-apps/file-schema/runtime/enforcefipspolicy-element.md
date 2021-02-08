---
description: 'Дополнительные сведения о: <enforceFIPSPolicy> element'
title: Элемент <enforceFIPSPolicy>
ms.date: 03/30/2017
helpviewer_keywords:
- enforceFIPSPolicy element
- FIPS
- <enforceFIPSPolicy> element
- Federal Information Processing Standards (FIPS)
ms.assetid: c35509c4-35cf-43c0-bb47-75e4208aa24e
ms.openlocfilehash: d445570db634867a15b6d97d4e20186bd0641c2d
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99787075"
---
# <a name="enforcefipspolicy-element"></a>Элемент \<enforceFIPSPolicy>

Указывает, нужно ли принудительно обеспечивать соблюдение требования конфигурации компьютера о том, что криптографические алгоритмы должны соответствовать стандартам FIPS.  
  
[**\<configuration>**](../configuration-element.md)\
&nbsp;&nbsp;[**\<runtime>**](runtime-element.md)\
&nbsp;&nbsp;&nbsp;&nbsp;**\<enforceFIPSPolicy>**  
  
## <a name="syntax"></a>Синтаксис  
  
```xml  
<enforceFIPSPolicy enabled="true|false" />  
```  
  
## <a name="attributes-and-elements"></a>Атрибуты и элементы  

 В следующих разделах описаны атрибуты, дочерние и родительские элементы.  
  
### <a name="attributes"></a>Атрибуты  
  
|Атрибут|Описание|  
|---------------|-----------------|  
|Включено|Обязательный атрибут.<br /><br /> Указывает, следует ли включить принудительное применение конфигурации компьютера, чтобы алгоритмы шифрования должны соответствовать стандарту FIPS.|  
  
## <a name="enabled-attribute"></a>Атрибут enabled  
  
|Значение|Описание|  
|-----------|-----------------|  
|`true`|Если компьютер настроен для использования алгоритмов шифрования, совместимых с FIPS, это требование применяется принудительно. Если класс реализует алгоритм, не соответствующий стандарту FIPS, конструкторы или `Create` методы этого класса создают исключения при запуске на этом компьютере. Это значение по умолчанию.|  
|`false`|Алгоритмы шифрования, используемые приложением, не должны соответствовать требованиям FIPS, независимо от конфигурации компьютера.|  
  
### <a name="child-elements"></a>Дочерние элементы  

 Отсутствует.  
  
### <a name="parent-elements"></a>Родительские элементы  
  
|Элемент|Описание|  
|-------------|-----------------|  
|`configuration`|Корневой элемент в любом файле конфигурации, используемом средой CLR и приложениями .NET Framework.|  
|`runtime`|Содержит сведения о привязке сборок и сборке мусора.|  
  
## <a name="remarks"></a>Remarks  

 Начиная с платформа .NET Framework 2,0, создание классов, реализующих алгоритмы шифрования, управляется конфигурацией компьютера. Если компьютер настроен на требование соответствия алгоритмам FIPS, а класс реализует алгоритм, который не соответствует стандарту FIPS, любая попытка создать экземпляр этого класса вызывает исключение. Конструкторы создают <xref:System.InvalidOperationException> исключение, а `Create` методы вызывают <xref:System.Reflection.TargetInvocationException> исключение с внутренним <xref:System.InvalidOperationException> исключением.  
  
 Если приложение выполняется на компьютерах, конфигурация которых требует соответствия стандарту FIPS, а приложение использует алгоритм, не соответствующий стандарту FIPS, этот элемент можно использовать в файле конфигурации, чтобы среда CLR не могла принудительно применять соответствие FIPS. Этот элемент появился в платформа .NET Framework 2,0 с пакетом обновления 1 (SP1).  
  
## <a name="example"></a>Пример  

 В следующем примере показано, как запретить среде CLR принудительно применять соответствие FIPS.  
  
```xml  
<configuration>  
    <runtime>  
        <enforceFIPSPolicy enabled="false"/>  
    </runtime>  
</configuration>  
```  
  
## <a name="see-also"></a>См. также

- [Схема параметров среды выполнения](index.md)
- [Схема файла конфигурации](../index.md)
- [Модель криптографии](../../../../standard/security/cryptography-model.md)
