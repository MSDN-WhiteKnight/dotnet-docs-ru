---
description: Дополнительные сведения см. в статье Настройка службы Windows Communication Foundation для использования общего доступа к портам.
title: Практическое руководство. Настройка службы Windows Communication Foundation на совместное использование портов
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
ms.assetid: 6400bc71-a858-4ac2-8d5a-caa72d3b5482
ms.openlocfilehash: 53fe3449ece5a5e545d7add5c4e6c7feebe5a8ff
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99780106"
---
# <a name="how-to-configure-a-windows-communication-foundation-service-to-use-port-sharing"></a>Практическое руководство. Настройка службы Windows Communication Foundation на совместное использование портов

Самый простой способ использовать NET. TCP://совместное использование портов в приложении Windows Communication Foundation (WCF) — предоставить службу с помощью <xref:System.ServiceModel.NetTcpBinding> .  
  
 Эта привязка предоставляет свойство <xref:System.ServiceModel.NetTcpBinding.PortSharingEnabled%2A>, которое определяет, включено ли совместное использование порта net.tcp:// для службы, настраиваемой с этой привязкой.  
  
 Следующая процедура показывает, как использовать класс <xref:System.ServiceModel.NetTcpBinding>, чтобы открыть конечную точку по универсальному коду ресурса (URI) net.tcp://localhost/MyService, сначала в коде, а затем с помощью элементов конфигурации.  
  
### <a name="to-enable-nettcp-port-sharing-on-a-nettcpbinding-in-code"></a>Включение совместного использования порта net.tcp:// в привязке NetTcpBinding с помощью кода  
  
1. Создайте службу для реализации контракта с именем `IMyService` и его вызова `MyService` ,.  
  
     [!code-csharp[c_ConfigurePortSharing#1](../../../../samples/snippets/csharp/VS_Snippets_CFX/c_configureportsharing/cs/source.cs#1)]
     [!code-vb[c_ConfigurePortSharing#1](../../../../samples/snippets/visualbasic/VS_Snippets_CFX/c_configureportsharing/vb/source.vb#1)]  
  
2. Создайте экземпляр класса <xref:System.ServiceModel.NetTcpBinding> и задайте для свойства <xref:System.ServiceModel.NetTcpBinding.PortSharingEnabled%2A> значение `true`.  
  
     [!code-csharp[c_ConfigurePortSharing#2](../../../../samples/snippets/csharp/VS_Snippets_CFX/c_configureportsharing/cs/source.cs#2)]
     [!code-vb[c_ConfigurePortSharing#2](../../../../samples/snippets/visualbasic/VS_Snippets_CFX/c_configureportsharing/vb/source.vb#2)]  
  
3. Создайте <xref:System.ServiceModel.ServiceHost> и добавьте в него конечную точку службы для `MyService`, использующей привязку <xref:System.ServiceModel.NetTcpBinding>, поддерживающую совместное использование порта, и ожидающей передачи данных по универсальному коду ресурса (URI) адреса конечной точки "net.tcp://localhost/MyService".  
  
     [!code-csharp[c_ConfigurePortSharing#3](../../../../samples/snippets/csharp/VS_Snippets_CFX/c_configureportsharing/cs/source.cs#3)]
     [!code-vb[c_ConfigurePortSharing#3](../../../../samples/snippets/visualbasic/VS_Snippets_CFX/c_configureportsharing/vb/source.vb#3)]  
  
    > [!NOTE]
    > В этом примере используется TCP-порт 808 по умолчанию, так как в универсальном коде ресурса (URI) адреса конечной точки не указан другой номер порта. Так как в транспортной привязке явно включено совместное использование порта, эта служба может использовать порт 808 совместно с другими службами в других процессах. Если бы совместное использование порта не было бы разрешено и порт 808 уже использовался бы другим приложением, то при открытии данной службы она бы создала исключение <xref:System.ServiceModel.AddressAlreadyInUseException>.  
  
### <a name="to-enable-nettcp-port-sharing-on-a-nettcpbinding-in-configuration"></a>Включение совместного использования порта net.tcp:// в привязке NetTcpBinding с помощью конфигурации  
  
1. В следующем примере показано, как включить совместное использование порта и добавить конечную точку службы с помощью элементов конфигурации.  
  
```xml  
<system.serviceModel>  
  <bindings>  
    <netTcpBinding name="portSharingBinding"
                   portSharingEnabled="true" />  
  </bindings>  
  <services>  
    <service name="MyService">  
        <endpoint address="net.tcp://localhost/MyService"  
                  binding="netTcpBinding"  
                  contract="IMyService"  
                  bindingConfiguration="portSharingBinding" />  
    </service>  
  </services>  
</system.serviceModel>  
```  
  
## <a name="see-also"></a>См. также

- [Совместное использование портов Net.TCP](net-tcp-port-sharing.md)
- [Практическое руководство. Включение службы совместного использования портов Net.TCP](how-to-enable-the-net-tcp-port-sharing-service.md)
