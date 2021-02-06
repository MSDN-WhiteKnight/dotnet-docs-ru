---
description: Дополнительные сведения см. в статье как выполнять управление версиями служб.
title: 'Как выполнить: Управление версиями службы'
ms.date: 03/30/2017
ms.assetid: 4287b6b3-b207-41cf-aebe-3b1d4363b098
ms.openlocfilehash: d32ea2051783ccaec7a66bfffada7f08887f8559
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99643232"
---
# <a name="how-to-service-versioning"></a>Как выполнить: Управление версиями службы

В этом разделе описаны основные шаги, которые необходимо выполнить для создания конфигурации маршрутизации сообщений к разным версиям одной и той же службы. В этом примере сообщения направляются в две разные версии службы калькулятора: `roundingCalc` (v1) и `regularCalc` (v2). Обе реализации поддерживают одинаковые операции, однако старая версия службы `roundingCalc`, прежде чем вернуть результаты вычислений, округляет их до ближайшего целого числа. Клиентское приложение должно указать необходимость использования более новой версии службы `regularCalc`.  
  
> [!WARNING]
> Для передачи сообщения указанной версии службы служба маршрутизации определяет место назначения сообщения на основе его содержимого. В показанном ниже методе клиент указывает версию в заголовке сообщения. Существуют методы управления версиями служб, которые не требуют передачи дополнительных данных клиентом. Например, сообщение может быть отправлено самой последней или наиболее совместимой версии службы либо маршрутизатор может использовать часть стандартного конверта SOAP.  
  
 Операции, предоставляемые обеими службами:  
  
- Add  
  
- Subtract  
  
- Multiply  
  
- Divide  
  
 Поскольку обе реализации служб обрабатывают одни и те же операции и, в сущности, отличаются только возвращаемыми данных, базовые данные, содержащиеся в сообщениях, отправленных клиентскими приложениями, не являются достаточно уникальными, чтобы можно было определить способ маршрутизации запроса. Например, нельзя использовать фильтры действий, поскольку действия по умолчанию одинаковы для обеих служб.  
  
 Эту ситуацию можно разрешить несколькими способами, например сделав конкретную конечную точку доступной маршрутизатору для каждой версии службы или добавив в сообщение пользовательский элемент заголовка, указывающий версию службы.  Все эти подходы позволяют выполнять уникальную маршрутизацию входящих сообщений для указанной версии службы, но для разграничения запросов для разных версий служб рекомендуется использование уникального содержимого сообщения.  
  
 В данном примере клиентское приложение добавляет пользовательский заголовок CalcVer в сообщение запроса. Этот заголовок содержит значение, указывающее версию службы, которой должно быть передано сообщение. Значение «1» указывает на то, что сообщение должно быть обработано службой roundingCalc, а значение «2» - службой regularCalc. Это позволяет клиентскому приложению непосредственно управлять версиями службы, которые будут обрабатывать сообщение.  Поскольку пользовательский заголовок является значением, содержащимся в сообщении, можно использовать одну конечную точку для получения сообщений, предназначенных для обеих версий службы. Для добавления пользовательского заголовка сообщения включить в клиентское приложение следующий код:  
  
```csharp  
messageHeadersElement.Add(MessageHeader.CreateHeader("CalcVer", "http://my.custom.namespace/", "2"));  
```  
  
### <a name="implement-service-versioning"></a>Реализация управления версиями  
  
1. Создайте базовую конфигурацию службы маршрутизации, указав конечную точку службы, предоставленную службой. В следующем примере определяется отдельная конечная точка службы, которая будет использоваться для получения сообщений. Также определяются конечные точки клиента, которые используются для передачи сообщений службам `roundingCalc` (v1) и `regularCalc` (v2).  
  
    ```xml  
    <services>  
        <service behaviorConfiguration="routingConfiguration"  
                 name="System.ServiceModel.Routing.RoutingService">  
          <host>  
            <baseAddresses>  
              <add baseAddress="http://localhost/routingservice/router" />  
            </baseAddresses>  
          </host>  
          <!--Set up the inbound endpoint for the Routing Service-->  
          <endpoint address="calculator"  
                    binding="wsHttpBinding"  
                    name="routerEndpoint"  
                    contract="System.ServiceModel.Routing.IRequestReplyRouter" />  
        </service>  
    </services>  
    <client>  
    <!--set up the destination endpoints-->  
          <endpoint name="regularCalcEndpoint"  
                    address="net.tcp://localhost:9090/servicemodelsamples/service/"  
                    binding="netTcpBinding"  
                    contract="*" />  
  
          <endpoint name="roundingCalcEndpoint"  
                    address="http://localhost:8080/servicemodelsamples/service/"  
                    binding="wsHttpBinding"  
                    contract="*" />  
        </client>  
    ```  
  
2. Определите фильтры, используемые для маршрутизации сообщений до конечных точек назначения.  В этом примере фильтр XPath используется для обнаружения значения пользовательского заголовка "Калквер", чтобы определить версию, к которой должно быть направлено сообщение. Фильтр XPath также используется для обнаружения сообщений, которые не содержат заголовок "Калквер". В следующем примере определяются необходимые фильтры и таблица пространства имен.  
  
    ```xml  
    <!-- use the namespace table element to define a prefix for our custom namespace-->  
    <namespaceTable>  
      <add prefix="custom" namespace="http://my.custom.namespace/"/>  
    </namespaceTable>  
    <filters>  
      <!--define the different message filters-->  
      <!--define an xpath message filter to look for the  
          custom header containing a value of 2-->  
      <filter name="XPathFilterRegular" filterType="XPath"  
              filterData="sm:header()/custom:CalcVer = '2'"/>  
      <!--define an xpath message filter to look for the  
          custom header containing a value of 1-->  
      <filter name="XPathFilterRounding" filterType="XPath"  
              filterData="sm:header()/custom:CalcVer = '1'"/>  
       <!--define an xpath message filter to look for  
           messages that do not contain the custom header-->  
       <filter name="XPathFilterNoHeader" filterType="XPath"  
               filterData="count(sm:header()/custom:CalcVer)=0"/>  
    </filters>
    ```  
  
    > [!NOTE]
    > Префикс пространства имен s12 определяется по умолчанию в таблице пространства имен и представляет пространство имен `http://www.w3.org/2003/05/soap-envelope` .
  
3. Определите таблицу фильтров, которая связывает каждый фильтр с клиентской конечной точкой. Если сообщение содержит заголовок «Калквер» со значением 1, он будет отправлен в службу Регуларкалк. Если сообщение содержит заголовок CalcVer со значением «2», то оно будет передано службе roundingCalc. Если заголовок отсутствует, то сообщение будет передано regularCalc.  
  
     Далее будет определена таблица фильтров, а также добавлены определенные ранее фильтры.  
  
    ```xml  
    <filterTables>  
      <filterTable name="filterTable1">  
          <!--add the filters to the message filter table-->  
          <!--look for the custom header = 1, and if we find it,  
              send the message to the rounding calc endpoint-->  
          <add filterName="XPathFilterRounding" endpointName="roundingCalcEndpoint"/>  
          <!--look for the custom header = 2, and if we find it,  
              send the message to the rounding calc endpoint-->  
          <add filterName="XPathFilterRegular" endpointName="regularCalcEndpoint"/>  
          <!--look for the absence of the custom header, and if  
              it is not present, assume the v1 endpoint-->  
          <add filterName="XPathFilterNoHeader" endpointName="roundingCalcEndpoint"/>  
      </filterTable>  
    </filterTables>  
    ```  
  
4. Для оценки входящих сообщений с помощью фильтров, содержащихся в таблице фильтров, следует связать таблицу фильтров с конечными точками службы при помощи поведения маршрутизации. В следующем примере показано связывание `filterTable1` с конечными точками службы.  
  
    ```xml  
    <behaviors>  
      <!--default routing service behavior definition-->  
      <serviceBehaviors>  
        <behavior name="routingConfiguration">  
          <routing filterTableName="filterTable1" />  
        </behavior>  
      </serviceBehaviors>  
    </behaviors>  
    ```  
  
## <a name="example"></a>Пример  

 Далее приведен полный листинг файла конфигурации.  
  
```xml  
<?xml version="1.0" encoding="utf-8" ?>  
<!-- Copyright (c) Microsoft Corporation. All rights reserved -->  
<configuration>  
  <system.serviceModel>  
    <services>  
      <service behaviorConfiguration="routingConfiguration"  
               name="System.ServiceModel.Routing.RoutingService">  
        <host>  
          <baseAddresses>  
            <add baseAddress="http://localhost/routingservice/router" />  
          </baseAddresses>  
        </host>  
        <!--Set up the inbound endpoint for the Routing Service-->  
        <endpoint address="calculator"  
                  binding="wsHttpBinding"  
                  name="routerEndpoint"  
                  contract="System.ServiceModel.Routing.IRequestReplyRouter" />  
      </service>  
    </services>  
    <behaviors>  
      <!--default routing service behavior definition-->  
      <serviceBehaviors>  
        <behavior name="routingConfiguration">  
          <routing filterTableName="filterTable1" />  
        </behavior>  
      </serviceBehaviors>  
    </behaviors>  
  
    <client>  
<!--set up the destination endpoints-->  
      <endpoint name="regularCalcEndpoint"  
                address="net.tcp://localhost:9090/servicemodelsamples/service/"  
                binding="netTcpBinding"  
                contract="*" />  
  
      <endpoint name="roundingCalcEndpoint"  
                address="http://localhost:8080/servicemodelsamples/service/"  
                binding="wsHttpBinding"  
                contract="*" />  
    </client>  
    <routing>  
      <!-- use the namespace table element to define a prefix for our custom namespace-->  
      <namespaceTable>  
        <add prefix="custom" namespace="http://my.custom.namespace/"/>  
      </namespaceTable>  
      <filters>  
        <!--define the different message filters-->  
        <!--define an xpath message filter to look for the  
            custom header containing a value of 2-->  
        <filter name="XPathFilterRegular" filterType="XPath"  
                filterData="sm:header()/custom:CalcVer = '2'"/>  
        <!--define an xpath message filter to look for the  
            custom header containing a value of 1-->  
        <filter name="XPathFilterRounding" filterType="XPath"  
                filterData="sm:header()/custom:CalcVer = '1'"/>  
        <!--define an xpath message filter to look for  
            messages that do not contain the custom header-->  
        <filter name="XPathFilterNoHeader" filterType="XPath"  
                filterData="count(sm:header()/custom:CalcVer)=0"/>  
      </filters>  
      <filterTables>  
        <filterTable name="filterTable1">  
            <!--add the filters to the message filter table-->  
            <!--look for the custom header = 1, and if we find it,  
                send the message to the rounding calc endpoint-->  
            <add filterName="XPathFilterRounding" endpointName="roundingCalcEndpoint"/>  
            <!--look for the custom header = 2, and if we find it,  
                send the message to the rounding calc endpoint-->  
            <add filterName="XPathFilterRegular" endpointName="regularCalcEndpoint"/>  
            <!--look for the absence of the custom header, and if  
                it is not present, assume the v1 endpoint-->  
            <add filterName="XPathFilterNoHeader" endpointName="roundingCalcEndpoint"/>  
        </filterTable>  
      </filterTables>  
    </routing>  
  </system.serviceModel>  
</configuration>  
```  
  
## <a name="example"></a>Пример  

 Ниже приведен полный листинг клиентского приложения.  
  
```csharp  
using System;  
using System.ServiceModel;  
using System.ServiceModel.Channels;  
  
namespace Microsoft.Samples.AdvancedFilters  
{  
    //The service contract is defined in generatedClient.cs, generated from the service by the svcutil tool.  
  
    //Client implementation code.  
    class Client  
    {  
        static void Main()  
        {  
            //Print out the welcome text  
            Console.WriteLine("This sample routes the Calculator Sample through the new WCF RoutingService");  
            Console.WriteLine("Wait for all the services to indicate that they've started, then press");  
            Console.WriteLine("<ENTER> to start the client.");  
  
            while (Console.ReadLine() != "quit")  
            {  
                //Offer the Address configuration for the client  
                Console.WriteLine("");  
                Console.WriteLine("Welcome to the Calculator Client!");  
  
                EndpointAddress epa;  
                //set the default address as the general router endpoint  
                epa = new EndpointAddress("http://localhost/routingservice/router/calculator");  
  
                //set up the CalculatorClient with the EndpointAddress, the WSHttpBinding, and the ICalculator contract  
                //We use the WSHttpBinding so that the outgoing has a message envelope, which we'll manipulate in a minute  
                CalculatorClient client = new CalculatorClient(new WSHttpBinding(), epa);  
                //client.Endpoint.Contract = ContractDescription.GetContract(typeof(ICalculator));  
  
                //Ask the customer if they want to add a custom header to the outgoing message.  
                //The Router will look for this header, and if so ignore the endpoint the message was  
                //received on, and instead direct the message to the RoundingCalcService.  
                Console.WriteLine("");  
                Console.WriteLine("Which calculator service should be used?");  
                Console.WriteLine("Enter 1 for the rounding calculator, 2 for the regular calculator.");  
                Console.WriteLine("[1] or [2]?");  
  
                string header = Console.ReadLine();  
  
                //get the current operationContextScope from the client's inner channel  
                using (OperationContextScope ocs = new OperationContextScope((client.InnerChannel)))  
                {  
                    //get the outgoing message headers element (collection) from the context  
                    MessageHeaders messageHeadersElement = OperationContext.Current.OutgoingMessageHeaders;  
  
                    //if they wanted to create the header, go ahead and add it to the outgoing message  
                    if (header != null && (header=="1" || header=="2"))  
                    {  
                        //create a new header "RoundingCalculator", no specific namespace, and set the value to
                        //the value of header.  
                        //the Routing Service will look for this header in order to determine if the message  
                        //should be routed to the RoundingCalculator  
                        messageHeadersElement.Add(MessageHeader.CreateHeader("CalcVer", "http://my.custom.namespace/", header));  
                    }  
                    else //incorrect choice, no header added  
                    {  
                        Console.WriteLine("Incorrect value entered, not adding a header");  
                    }  
  
                        //call the client operations  
                        CallClient(client);  
                }  
  
                //close the client to clean it up  
                client.Close();  
                Console.WriteLine();  
                Console.WriteLine("Press <ENTER> to run the client again or type 'quit' to quit.");  
            }  
        }  
  
        private static void CallClient(CalculatorClient client)  
        {  
            Console.WriteLine("");  
            Console.WriteLine("Sending!");  
            // Call the Add service operation.  
            double value1 = 100.00D;  
            double value2 = 15.99D;  
            double result = client.Add(value1, value2);  
            Console.WriteLine("Add({0},{1}) = {2}", value1, value2, result);  
  
            // Call the Subtract service operation.  
            value1 = 145.00D;  
            value2 = 76.54D;  
            result = client.Subtract(value1, value2);  
            Console.WriteLine("Subtract({0},{1}) = {2}", value1, value2, result);  
  
            // Call the Multiply service operation.  
            value1 = 9.00D;  
            value2 = 81.25D;  
            result = client.Multiply(value1, value2);  
            Console.WriteLine("Multiply({0},{1}) = {2}", value1, value2, result);  
  
            // Call the Divide service operation.  
            value1 = 22.00D;  
            value2 = 7.00D;  
            result = client.Divide(value1, value2);  
            Console.WriteLine("Divide({0},{1}) = {2}", value1, value2, result);  
  
        }  
    }  
}  
```  
  
## <a name="see-also"></a>См. также

- [Службы маршрутизации](../samples/routing-services.md)
