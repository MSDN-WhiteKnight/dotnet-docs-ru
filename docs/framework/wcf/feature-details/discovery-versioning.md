---
description: Дополнительные сведения о версии обнаружения
title: Управление версиями обнаружения
ms.date: 03/30/2017
ms.assetid: f91c6d0a-3af2-45c5-9a5c-e75390619836
ms.openlocfilehash: 075fefce0477810336c8b857343984070ed89b37
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99743191"
---
# <a name="discovery-versioning"></a>Управление версиями обнаружения

В этом разделе приведены общие сведения о реализации некоторых новых возможностей обнаружения. Также приводятся общие сведения о выборе версии обнаружения.

## <a name="discovery-versioning"></a>Управление версиями обнаружения

Возможность обнаружения поддерживает три версии протокола обнаружения WS-Discovery. API обнаружения позволяют выбирать используемую версию протокола. В этом документе кратко описаны параметры, связанные с версиями.

У следующих классов Discovery теперь имеется свойство <xref:System.ServiceModel.Discovery.DiscoveryVersion>, их конструкторы также принимают аргумент <xref:System.ServiceModel.Discovery.DiscoveryVersion>:

- <xref:System.ServiceModel.Discovery.AnnouncementEndpoint>

- <xref:System.ServiceModel.Discovery.DiscoveryEndpoint>

- <xref:System.ServiceModel.Discovery.UdpDiscoveryEndpoint>

- <xref:System.ServiceModel.Discovery.UdpAnnouncementEndpoint>

### <a name="discoveryversionwsdiscoveryapril2005"></a>DiscoveryVersion.WSDiscoveryApril2005

Предоставление в <xref:System.ServiceModel.Discovery.DiscoveryVersion.WSDiscoveryApril2005> качестве параметра конструктора делает реализацию использовать April2005 версию протокола WS-Discovery. Эта версия соответствует опубликованной версии спецификации протокола WS-Discovery. Эту версию следует использовать для взаимодействия с приложениями прежних версий, использующими версию протокола WS-Discovery от апреля 2005 г.

### <a name="discoveryversionwsdiscovery11"></a>DiscoveryVersion.WSDiscovery11

Версия обнаружения по умолчанию, используемая API-интерфейсами, — <xref:System.ServiceModel.Discovery.DiscoveryVersion.WSDiscovery11> . Эта версия протокола обнаружения WS-Discovery на данный момент является стандартной.

## <a name="discoveryversionwsdiscoverycd1"></a>DiscoveryVersion.WSDiscoveryCD1

При указании параметра конструктора <xref:System.ServiceModel.Discovery.DiscoveryVersion.WSDiscoveryCD1> реализация будет использовать рассматриваемый соответствующим комитетом проект 1 версии протокола WS-Discovery. Эту версию протокола следует использовать для взаимодействия с реализациями, в которых применяется версия CD1 протокола WS-Discovery.

## <a name="supporting-multiple-udp-discovery-endpoints-for-different-discovery-versions-on-a-single-service-host"></a>Поддержка нескольких конечных точек обнаружения UDP с различными версиями обнаружения на одном узле службы

Может потребоваться предоставление доступа к нескольким конечным точкам обнаружения UDP с различными версиями обнаружения на одном узле службы. Для этого необходимо задать для каждой из конечных точек обнаружения UDP уникальный адрес. В приведенном ниже примере показано, как это сделать.

```csharp
UdpDiscoveryEndpoint newVersionUdpEndpoint = new UdpDiscoveryEndpoint(DiscoveryVersion.WSDiscovery11);
UdpDiscoveryEndpoint oldVersionUdpEndpoint = new UdpDiscoveryEndpoint(DiscoveryVersion.WSDiscoveryApril2005);

newVersionUdpEndpoint.Address = new EndpointAddress(newVersionUdpEndpoint.Address.Uri.ToString() + "/version11");
oldVersionUdpEndpoint.Address = new EndpointAddress(oldVersionUdpEndpoint.Address.Uri.ToString() + "/versionApril2005");

serviceHost.AddServiceEndpoint(newVersionUdpEndpoint);
serviceHost.AddServiceEndpoint(oldVersionUdpEndpoint);
```
