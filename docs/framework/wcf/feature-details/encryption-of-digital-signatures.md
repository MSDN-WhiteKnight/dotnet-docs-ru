---
description: Дополнительные сведения о шифровании цифровых подписей
title: Шифрование цифровых сигнатур
ms.date: 03/30/2017
helpviewer_keywords:
- encryption of digital signatures [WCF]
- digital signatures [WCF], encryption
- digital signatures [WCF]
ms.assetid: 0868866d-40b4-4341-8e42-eee3b7f15b69
ms.openlocfilehash: a68cea324fd5c2619f501eaf42bc518c17b89a6e
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99704853"
---
# <a name="encryption-of-digital-signatures"></a>Шифрование цифровых сигнатур

По умолчанию сообщение подписывается и шифруется, и цифровая подпись шифруется. Этим процессом можно управлять, создавая пользовательскую привязку с экземпляром элемента <xref:System.ServiceModel.Channels.AsymmetricSecurityBindingElement> или <xref:System.ServiceModel.Channels.SymmetricSecurityBindingElement> и затем присваивая свойству `MessageProtectionOrder` каждого класса значение перечисления <xref:System.ServiceModel.Security.MessageProtectionOrder>. Значение по умолчанию — <xref:System.ServiceModel.Security.MessageProtectionOrder.SignBeforeEncryptAndEncryptSignature>. Этот процесс занимает на 10 - 40 процентов больше времени, чем просто подписывание и шифрование. Однако в случае отключения шифрования подписи злоумышленник может распознать содержимое сообщения. Это обусловлено тем, что элемент подписи содержит хэш-код обычного текста каждой подписанной части сообщения. Например, хотя тело сообщения шифруется по умолчанию, нешифрованная подпись содержит хэш-код тела сообщения. Если сообщение короткое, злоумышленник может определить содержимое. Шифрование подписи уменьшает или исключает эту возможность.  
  
 Поэтому отключайте шифрование подписи только при малой важности содержимого и существенном повышении производительности в результате такого отключения, например при передаче больших двоичных файлов, не критичных к нарушениям безопасности.  
  
### <a name="to-disable-digital-signing"></a>Отключение цифровой подписи  
  
1. Создайте таблицу <xref:System.ServiceModel.Channels.CustomBinding>. Дополнительные сведения см. в разделе [инструкции. Создание пользовательской привязки с помощью SecurityBindingElement](how-to-create-a-custom-binding-using-the-securitybindingelement.md).  
  
2. Добавьте в коллекцию привязок элемент <xref:System.ServiceModel.Channels.AsymmetricSecurityBindingElement> или <xref:System.ServiceModel.Channels.SymmetricSecurityBindingElement>.  
  
3. Присвойте свойству <xref:System.ServiceModel.Channels.AsymmetricSecurityBindingElement.MessageProtectionOrder%2A?displayProperty=nameWithType> значение <xref:System.ServiceModel.Security.MessageProtectionOrder.SignBeforeEncrypt> или присвойте свойству <xref:System.ServiceModel.Channels.SymmetricSecurityBindingElement.MessageProtectionOrder%2A?displayProperty=nameWithType> значение <xref:System.ServiceModel.Security.MessageProtectionOrder.SignBeforeEncrypt>.  
  
 Дополнительные сведения о создании пользовательских привязок см. в разделе [Создание привязок User-Defined](../extending/creating-user-defined-bindings.md). Дополнительные сведения о создании пользовательской привязки для конкретного режима проверки подлинности см. [в разделе инструкции. Создание SecurityBindingElement для указанного режима проверки подлинности](how-to-create-a-securitybindingelement-for-a-specified-authentication-mode.md).  
  
## <a name="see-also"></a>См. также

- <xref:System.ServiceModel.Security.MessageProtectionOrder>
- <xref:System.ServiceModel.Channels.AsymmetricSecurityBindingElement>
- <xref:System.ServiceModel.Channels.SymmetricSecurityBindingElement>
- [Практическое руководство. Создание пользовательской привязки с использованием элемента SecurityBindingElement](how-to-create-a-custom-binding-using-the-securitybindingelement.md)
- [Создание пользовательских привязок](../extending/creating-user-defined-bindings.md)
- [Практическое руководство. Создание SecurityBindingElement для заданного режима проверки подлинности](how-to-create-a-securitybindingelement-for-a-specified-authentication-mode.md)
