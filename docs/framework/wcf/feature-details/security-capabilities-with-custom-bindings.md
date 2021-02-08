---
description: Дополнительные сведения см. в статье возможности безопасности с помощью пользовательских привязок.
title: Возможности безопасности при использовании пользовательских привязок
ms.date: 03/30/2017
ms.assetid: a2425679-484a-4e6c-9c98-7da7304f1516
ms.openlocfilehash: 0d4298bcb0b22d607c4abb15d879e3b093394bad
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99779846"
---
# <a name="security-capabilities-with-custom-bindings"></a>Возможности безопасности при использовании пользовательских привязок

Основные задачи обеспечения безопасности можно выполнить, используя одну из предоставляемых системой привязок. Однако при необходимости в дополнительных элементах управления можно создать пользовательскую привязку с помощью элемента <xref:System.ServiceModel.Channels.SecurityBindingElement>, следуя объяснениям в этом разделе. Дополнительные сведения о пользовательских привязках см. в разделе [пользовательские привязки](../extending/custom-bindings.md).  
  
## <a name="in-this-section"></a>В этом разделе  

 [Режимы проверки подлинности SecurityBindingElement](securitybindingelement-authentication-modes.md)  
 Содержит описание режимов проверки подлинности, которые возможны для пользовательской привязки.  
  
 [Практическое руководство. Создание пользовательской привязки с использованием элемента SecurityBindingElement](how-to-create-a-custom-binding-using-the-securitybindingelement.md)  
 Содержит описание основных шагов, которые необходимо предпринять для создания пользовательской привязки к элементу безопасности.  
  
 [Практическое руководство. Создание SecurityBindingElement для заданного режима проверки подлинности](how-to-create-a-securitybindingelement-for-a-specified-authentication-mode.md)  
 Описывается, как создать элемент безопасности для заданного режима проверки подлинности.  
  
 [Практическое руководство. Порядок отключения безопасных сеансов в WSFederationHttpBinding](how-to-disable-secure-sessions-on-a-wsfederationhttpbinding.md)  
 Описывается, как отключить безопасные сеансы при создании службы федерации.  
  
 [Практическое руководство. Включение обнаружения повтора сообщений](how-to-enable-message-replay-detection.md)  
 Описывается, как определить, когда будет осуществлена атака воспроизведения.  
  
 [Практическое руководство. Создание подтверждающих учетных данных](how-to-create-a-supporting-credential.md)  
 Описывается, как предоставить службе подтверждающие учетные данные при необходимости.  
  
 [Практическое руководство. Настройка подтверждения сигнатуры](how-to-set-up-a-signature-confirmation.md)  
 Содержит описание шагов, которые необходимо предпринять для подтверждения подписей при использовании цифровых подписей сообщений.  
  
 [Практическое руководство. Установка максимальной разницы в показаниях часов](how-to-set-a-max-clock-skew.md)  
 Описывается, как настроить максимально допустимую разницу во времени между службой и клиентом.  
  
 [Практическое руководство. Выключение шифрования цифровых сигнатур](how-to-disable-encryption-of-digital-signatures.md)  
 Описывается, как отключение шифрования цифровых подписей может увеличить производительность.  
  
## <a name="reference"></a>Справочник  

 <xref:System.ServiceModel.Channels.SecurityBindingElement>  
  
 [\<security>](../../configure-apps/file-schema/wcf/security-of-custombinding.md)  
  
## <a name="related-sections"></a>Связанные разделы  

 [Основные сведения об уровне защиты](../understanding-protection-level.md)  
  
 [Защита служб и клиентов](securing-services-and-clients.md)  
  
## <a name="see-also"></a>См. также

- [Привязки и безопасность](bindings-and-security.md)
- [Обзор безопасности](security-overview.md)
- [Привязки, предоставляемые системой](../system-provided-bindings.md)
