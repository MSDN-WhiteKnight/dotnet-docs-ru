---
description: Дополнительные сведения см. в статье как использовать конфигурацию для добавления конечной точки ASP.NET AJAX.
title: Практическое руководство. Использование конфигурации для добавления конечной точки ASP.NET AJAX
ms.date: 03/30/2017
ms.assetid: 7cd0099e-dc3a-47e4-a38c-6e10f997f6ea
ms.openlocfilehash: 629df635e9b19148db317a2d953bed9034556cd2
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99734351"
---
# <a name="how-to-use-configuration-to-add-an-aspnet-ajax-endpoint"></a>Практическое руководство. Использование конфигурации для добавления конечной точки ASP.NET AJAX

Windows Communication Foundation (WCF) позволяет создать службу, которая делает доступной конечную точку ASP.NET с поддержкой AJAX, которую можно вызывать из JavaScript на веб-сайте клиента. Чтобы создать такую конечную точку, можно использовать файл конфигурации, как и для всех остальных конечных точек Windows Communication Foundation (WCF), или использовать метод, который не требует каких-либо элементов конфигурации. В этом разделе показано выполнение этой задачи с помощью файла конфигурации.  
  
 Часть процедуры, которая позволяет сделать конечную точку службы доступной для ASP.NET AJAX, состоит в настройке конечной точки для использования <xref:System.ServiceModel.WebHttpBinding> и для добавления [\<enableWebScript>](../../configure-apps/file-schema/wcf/enablewebscript.md) поведения конечной точки. После настройки конечной точки действия по внедрению и размещению службы похожи на те, которые используются любой службой WCF. Рабочий пример см. в разделе [Служба AJAX, использующая HTTP POST](../samples/ajax-service-using-http-post.md).  
  
 Дополнительные сведения о настройке конечной точки ASP.NET AJAX без использования конфигурации см. [в разделе инструкции. Добавление конечной точки ASP.NET AJAX без использования конфигурации](how-to-add-an-aspnet-ajax-endpoint-without-using-configuration.md).  
  
## <a name="to-create-a-basic-wcf-service"></a>Создание базовой службы WCF  
  
1. Определите базовый контракт службы WCF с интерфейсом, помеченным <xref:System.ServiceModel.ServiceContractAttribute> атрибутом. Пометьте каждую операцию атрибутом <xref:System.ServiceModel.OperationContractAttribute>. Не забудьте задать свойство <xref:System.ServiceModel.ServiceContractAttribute.Namespace%2A>.  
  
    ```csharp
    [ServiceContract(Namespace = "MyService")]  
    public interface ICalculator  
    {  
        [OperationContract]  
         // This operation returns the sum of d1 and d2.  
        double Add(double n1, double n2);  
  
        //Other operations omitted…  
  
    }  
    ```  
  
2. Реализуйте контракт службы `ICalculator` с помощью класса `CalculatorService`.  
  
    ```csharp
    public class CalculatorService : ICalculator  
    {  
        public double Add(double n1, double n2)  
        {  
            return n1 + n2;  
        }
        // Other operations omitted…
    }
    ```  
  
3. Определите пространство имен для реализаций `ICalculator` и `CalculatorService`, заключив их в блок пространства имен.  
  
    ```csharp
    namespace Microsoft.Ajax.Samples
    {  
        //Include the code for ICalculator and Caculator here.  
    }  
    ```  
  
## <a name="to-create-an-aspnet-ajax-endpoint-for-the-service"></a>Создание конечной точки ASP.NET AJAX для службы  
  
1. Создайте конфигурацию поведения и укажите [\<enableWebScript>](../../configure-apps/file-schema/wcf/enablewebscript.md) поведение для конечных точек службы ASP.NET с поддержкой AJAX.  
  
    ```xml  
    <system.serviceModel>  
        <behaviors>  
            <endpointBehaviors>  
                <behavior name="AspNetAjaxBehavior">  
                    <enableWebScript />  
                </behavior>  
            </endpointBehaviors>  
        </behaviors>  
    </system.serviceModel>  
    ```  
  
2. Создайте конечную точку для службы, использующую <xref:System.ServiceModel.WebHttpBinding> и поведение ASP.NET AJAX, определенное на предыдущем шаге.  
  
    ```xml  
    <system.serviceModel>  
        <services>  
            <service name="Microsoft.Ajax.Samples.CalculatorService">  
                <endpoint address=""  
                    behaviorConfiguration="AspNetAjaxBehavior"
                    binding="webHttpBinding"  
                    contract="Microsoft.Ajax.Samples.ICalculator" />  
            </service>  
        </services>  
    </system.serviceModel>
    ```  
  
## <a name="to-host-the-service-in-iis"></a>Размещение службы в IIS  
  
1. Чтобы разместить службу в IIS, создайте в приложении файл с именем, соответствующем имени службы, и с расширением SVC. Измените этот файл, добавив соответствующие сведения об директиве [ \@ ServiceHost](../../configure-apps/file-schema/wcf-directive/servicehost.md) для службы. Например, файл службы для нашего примера `CalculatorService` содержит следующую информацию.  
  
    ```aspx-csharp
    <%@ServiceHost
    language=c#
    Debug="true"
    Service="Microsoft.Ajax.Samples.CalculatorService"  
    %>  
    ```  
  
2. Дополнительные сведения о размещении в службах IIS см. в разделе [как разместить службу WCF в IIS](how-to-host-a-wcf-service-in-iis.md).  
  
## <a name="to-call-the-service"></a>Вызов службы  
  
1. Конечная точка настраивается по пустому адресу относительно SVC-файла, поэтому служба доступна и может быть вызвана путем отправки запросов к службе. svc/-например \<operation> , Service. svc/Add для `Add` операции. Для этого укажите URL-адрес конечной точки в коллекции "Скрипты" в диспетчере скриптов ASP.NET AJAX. Пример см. в разделе [Служба AJAX, использующая HTTP POST](../samples/ajax-service-using-http-post.md).  
  
## <a name="see-also"></a>См. также

- [Создание служб WCF для ASP.NET AJAX](creating-wcf-services-for-aspnet-ajax.md)
- [Практическое руководство. Миграция веб-служб ASP.NET с поддержкой AJAX на платформу WCF](how-to-migrate-ajax-enabled-aspnet-web-services-to-wcf.md)
