---
description: 'Узнайте подробнее о: Обход NAT с помощью IPv6 и Teredo'
title: Обход NAT с помощью IPv6 и Teredo
ms.date: 03/30/2017
ms.assetid: 568cd245-3300-49ef-a995-d81bf845d961
ms.openlocfilehash: 4ff7f273c01ef52f4d307cbd3e0698c5cc2ead4d
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: HT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99785748"
---
# <a name="nat-traversal-using-ipv6-and-teredo"></a>Обход NAT с помощью IPv6 и Teredo

Были внесены улучшения, которые предоставляют поддержку обхода преобразования сетевых адресов (NAT). Эти изменения предназначены для использования с IPv6 и Teredo, но также могут применяться к другим технологиям туннелирования IP-адресов. Эти улучшения влияют на классы в <xref:System.Net> и соответствующие пространства имен.  
  
 Эти изменения могут повлиять на клиентские и серверные приложения, в которых планируется использовать технологии туннелирования IP-адресов.  
  
 Изменения для поддержки обхода NAT доступны только для приложений, которые используют платформу .NET Framework 4. Эти функции недоступны в более ранних версиях .NET Framework.  
  
## <a name="overview"></a>Обзор  

 В протоколе IP версии 4 (IPv4) длина IP-адреса IPv4 составляет 32 бита. Следовательно, IPv4 поддерживает примерно 4 миллиарда уникальных IP-адресов (2 в 32-й степени). С увеличением количества компьютеров и сетевых устройств в Интернете в девяностые годы XX века ограничения адресного пространства IPv4 стали очевидными.  
  
 Одна из несколько методик, используемых для увеличения времени существования адреса IPv4, — развертывание NAT, благодаря которому один общедоступный IP-адрес может представлять большое количество частных IP-адресов (частную интрасеть). Частные IP-адреса, находящиеся за устройством NAT, соответствуют одному и тому же общедоступному IP-адресу IPv4. В качестве устройства NAT может использоваться специализированное аппаратное устройство (например, точка беспроводного доступа и маршрутизатор) или компьютер, на котором запущена служба NAT. Устройство или служба для этого общедоступного IP-адреса преобразует сетевые пакеты IP между общедоступным Интернетом и частной интрасетью.  
  
 Эта схема подходит для клиентских приложений в частной интрасети, которые отправляют запросы к другим IP-адресам (обычно серверам) в Интернете. Устройство NAT или сервер может содержать сведения о сопоставлении клиентских запросов, чтобы при получении ответа определить место назначения для этого ответа. Однако эта схема создает проблемы для приложений, работающих в частной интрасети за устройством NAT, которым необходимо предоставлять службы, прослушивать пакеты и отправлять ответы. Это особенно актуально в случае с одноранговыми приложениями.  
  
 В протоколе IPv6 длина адреса IPv4 составляет 128 бит. Поэтому протокол IPv6 поддерживает очень большое количество IP-адресов — 3.2x10 в 38-й степени уникальных адресов (2 в 128-й степени). С адресным пространством такого размера можно предоставить уникальный адрес для каждого устройства, подключенного к Интернету. Но существуют проблемы. На большей части компьютеров во всем мире все еще используются только адреса IPv4. В частности, многие из существующих маршрутизаторов и точек беспроводного доступа, которые используются в небольших организациях и дома, не поддерживают IPv6. Также некоторые поставщики услуг Интернета, которые обслуживают этих клиентов, не поддерживают IPv6 либо у них не настроена поддержка IPv6.  
  
 Было разработано несколько технологий туннелирования адресов IPv6 в пакет IPv4. Эти технологии включают 6to4, ISATAP и туннели Teredo, которые предоставляют назначение адресов и автоматическое туннелирование одноадресного трафика IPv6 между узлами, при котором узлы IPv6 должны проходить по сетям IPv4, чтобы достичь других сетей IPv6. Пакеты IPv6 отправляются c туннелированием в пакетах IPv4. Существует несколько методов туннелирования, которые позволяют обойти NAT для адресов IPv6 через устройство NAT.  
  
 Teredo — одна из технологий туннелирования IPv6, которая позволяет использовать адреса IPv6 в сетях IPv4. Спецификация Teredo приведена в стандарте RFC 4380, опубликованном IETF. В Windows XP с пакетом обновления 2 (SP2) и более поздней версии поддерживается виртуальный адаптер Teredo, который позволяет получить общедоступный адрес IPv6 в диапазоне 2001:0::/32. Этот адрес IPv6 можно использовать для прослушивания входящих подключений из Интернета. Его можно предоставить клиентам с поддержкой IPv6, которые хотят подключиться к службе прослушивания. Это позволяет приложению не беспокоиться об адресации компьютера за устройством NAT, так как приложение может просто подключиться к нему по адресу IPv6 Teredo.  
  
## <a name="enhancements-to-support-nat-traversal-and-teredo"></a>Улучшения поддержки обхода NAT и Teredo  

 В пространства имен <xref:System.Net>, <xref:System.Net.NetworkInformation> и <xref:System.Net.Sockets> добавлены улучшения для поддержки обхода преобразования сетевых адресов (NAT) с помощью IPv6 и Teredo.  
  
 В класс <xref:System.Net.NetworkInformation.IPGlobalProperties?displayProperty=nameWithType> добавлены несколько методов для получения списка IP-адресов одноадресной рассылки на узле. Метод <xref:System.Net.NetworkInformation.IPGlobalProperties.BeginGetUnicastAddresses%2A> отправляет асинхронный запрос для получения таблицы стабильных IP-адресов одноадресной рассылки на локальном компьютере. Метод <xref:System.Net.NetworkInformation.IPGlobalProperties.EndGetUnicastAddresses%2A> завершает ожидающий асинхронный запрос для получения таблицы стабильных IP-адресов одноадресной рассылки на локальном компьютере. Метод <xref:System.Net.NetworkInformation.IPGlobalProperties.GetUnicastAddresses%2A> отправляет синхронный запрос на получение таблицы стабильных IP-адресов одноадресной рассылки на локальном компьютере, при необходимости ожидая, пока таблица стабилизируется.  
  
 Чтобы определить, является ли <xref:System.Net.IPAddress> IP-адресом IPv6 Teredo, можно использовать свойство <xref:System.Net.IPAddress.IsIPv6Teredo%2A?displayProperty=nameWithType>.  
  
 Используя эти новые методы класса <xref:System.Net.NetworkInformation.IPGlobalProperties> в сочетании со свойством <xref:System.Net.IPAddress.IsIPv6Teredo%2A>, приложение может легко определить адрес Teredo. Для связи с удаленными приложениями приложению обычно необходим только локальный адрес Teredo. Например, одноранговое приложение может отправлять все IP-адреса IPv6 координирующему серверу, который затем может перенаправлять их другим одноранговым узлам для прямого взаимодействия.  
  
 В службе прослушивания приложения необходимо настроить прослушивание <xref:System.Net.IPAddress.IPv6Any?displayProperty=nameWithType>, а не локального адреса Teredo. Это позволит удаленному клиенту или одноранговому узлу, у которого есть прямой маршрут IPv6 для службы прослушивания, подключиться напрямую с помощью протокола IPv6 и не использовать Teredo для туннелирования пакетов.  
  
 Для включения обхода NAT в приложениях TCP используется метод <xref:System.Net.Sockets.TcpListener.AllowNatTraversal%2A> класса <xref:System.Net.Sockets.TcpListener?displayProperty=nameWithType>. Для включения обхода NAT в приложениях UDP используется метод <xref:System.Net.Sockets.UdpClient.AllowNatTraversal%2A> класса <xref:System.Net.Sockets.UdpClient?displayProperty=nameWithType>.  
  
 Для отправки запросов для обхода NAT, а также для включения или отключения обхода NAT в приложениях, в которых используется класс <xref:System.Net.Sockets.Socket?displayProperty=nameWithType> и связанные классы, можно использовать методы <xref:System.Net.Sockets.Socket.GetSocketOption%2A> и <xref:System.Net.Sockets.Socket.SetSocketOption%2A> с параметром сокета <xref:System.Net.Sockets.SocketOptionName.IPProtectionLevel?displayProperty=nameWithType>.  
  
## <a name="see-also"></a>См. также раздел

- <xref:System.Net.IPAddress.IsIPv6Teredo%2A?displayProperty=nameWithType>
- <xref:System.Net.NetworkInformation.IPGlobalProperties.BeginGetUnicastAddresses%2A?displayProperty=nameWithType>
- <xref:System.Net.NetworkInformation.IPGlobalProperties.EndGetUnicastAddresses%2A?displayProperty=nameWithType>
- <xref:System.Net.NetworkInformation.IPGlobalProperties.GetUnicastAddresses%2A?displayProperty=nameWithType>
- <xref:System.Net.Sockets.IPProtectionLevel?displayProperty=nameWithType>
- <xref:System.Net.Sockets.Socket.SetIPProtectionLevel%2A?displayProperty=nameWithType>
- <xref:System.Net.Sockets.TcpListener.AllowNatTraversal%2A?displayProperty=nameWithType>
- <xref:System.Net.Sockets.UdpClient.AllowNatTraversal%2A?displayProperty=nameWithType>
