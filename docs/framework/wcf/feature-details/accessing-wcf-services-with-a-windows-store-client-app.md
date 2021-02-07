---
description: Дополнительные сведения см. в статье доступ к службам WCF с помощью клиентского приложения Магазина Windows.
title: Доступ к службам WCF из клиентского приложения Магазина Windows
ms.date: 03/30/2017
ms.assetid: e2002ef4-5dee-4a54-9d87-03b33d35fc52
ms.openlocfilehash: 6586b07e72749b0c136072474c27c264568ed3f7
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99705412"
---
# <a name="access-wcf-services-with-a-windows-store-client-app"></a>Доступ к службам WCF с помощью клиентского приложения Магазина Windows

В Windows 8 появился новый тип приложения - приложения Магазина Windows. Эти приложения предназначены для работы с сенсорным экраном. .NET Framework 4.5 позволяет приложениям Магазина Windows вызывать службы WCF.  
  
## <a name="wcf-support-in-windows-store-applications"></a>Поддержка WCF в приложениях Магазина Windows.  

 Подмножество функций WCF доступно из приложения Магазина Windows. Дополнительную информацию см. в следующих разделах.  
  
> [!IMPORTANT]
> Используйте API-синдикации WinRT вместо методов, доступных через службу WCF. Дополнительные сведения см. в разделе [API синдикации WinRT](xref:Windows.Web.Syndication)  
  
> [!WARNING]
> Использование Добавление ссылки на службу для добавления ссылки на веб-службу в компонент среда выполнения Windows не поддерживается.  
  
### <a name="supported-bindings"></a>Поддерживаемые привязки  

 Поддерживаются следующие привязки WCF в приложениях Магазина Windows:  
  
1. <xref:System.ServiceModel.BasicHttpBinding>  
  
2. <xref:System.ServiceModel.NetTcpBinding>  
  
3. <xref:System.ServiceModel.NetHttpBinding>  
  
4. <xref:System.ServiceModel.Channels.CustomBinding>
  
 Поддерживаются следующие элементы привязки в приложениях Магазина Windows  
  
1. <xref:System.ServiceModel.Channels.BinaryMessageEncodingBindingElement>  
  
2. <xref:System.ServiceModel.Channels.TextMessageEncodingBindingElement>  
  
3. <xref:System.ServiceModel.Channels.ConnectionOrientedTransportBindingElement>  
  
4. <xref:System.ServiceModel.Channels.SslStreamSecurityBindingElement>  
  
5. <xref:System.ServiceModel.Channels.WindowsStreamSecurityBindingElement>  
  
6. <xref:System.ServiceModel.Channels.TcpTransportBindingElement>  
  
7. <xref:System.ServiceModel.Channels.HttpTransportBindingElement>  
  
8. <xref:System.ServiceModel.Channels.HttpsTransportBindingElement>  
  
9. <xref:System.ServiceModel.Channels.TransportSecurityBindingElement>  
  
 Поддерживается текстовое и двоичное кодирование. Поддерживаются все режимы передачи WCF. Дополнительные сведения см. в разделе [Streaming Message Transfer](streaming-message-transfer.md).  
  
### <a name="add-service-reference"></a>Добавление ссылки на службу  

 Для вызова службы WCF из приложения Магазина Windows пользуйтесь функцией «Добавить ссылку на службу» среды Visual Studio 2012. Можно заметить небольшие изменения в работе функции «Добавить ссылку на службу» при работе с приложением Магазина Windows. Во-первых, не создается файл конфигурации. Приложения Магазина Windows не используют файлы конфигурации, поэтому их необходимо настраивать в коде. Код конфигурации можно найти в файле References.cs, который создается функцией «Добавить ссылку на службу». Чтобы просмотреть этот файл, выберите "Показать все файлы" в обозревателе решений. Файл будет расположен под пунктом «Ссылки на службу», а затем в узлах Reference.svcmap в рамках проекта. Все операции, созданные для служб WCF внутри приложения Магазина Windows, будут асинхронными, использующими асинхронную технологию на основе событий. Дополнительные сведения см. в разделе [Async Tasks — упрощение асинхронного программирования с помощью задач](/archive/msdn-magazine/2010/september/async-tasks-simplify-asynchronous-programming-with-tasks).  
  
 Поскольку конфигурация создается в коде, любые изменения, внесенные в файл Reference.cs, будут перезаписываться при каждом обновлении ссылки на службу. Чтобы исправить эту ситуацию, код конфигурации создается внутри разделяемого метода, который вы можно реализовать в клиентском прокси-классе. Разделяемый метод определяется следующим образом:  
  
```csharp  
static partial void Configure(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint,  
            System.ServiceModel.Description.ClientCredentials clientCredentials);  
```  
  
 Затем можно реализовать этот разделяемый метод и изменить привязку или конечную точку в клиентском прокси-классе следующим образом:  
  
```csharp  
public partial class Service1Client : System.ServiceModel.ClientBase<MetroWcfClient.ServiceRefMultiEndpt.IService1>, MetroWcfClient.ServiceRefMultiEndpt.IService1  
    {
        static partial void Configure(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint,
            System.ServiceModel.Description.ClientCredentials clientCredentials)  
        {  
            if (serviceEndpoint.Name ==
                    ServiceRefMultiEndpt.Service1Client.EndpointConfiguration.BasicHttpBinding_IService1.ToString())  
            {  
                serviceEndpoint.Binding.SendTimeout = new System.TimeSpan(0, 1, 0);  
            }  
            else if (serviceEndpoint.Name ==
                    ServiceRefMultiEndpt.Service1Client.EndpointConfiguration.BasicHttpBinding_IService11.ToString())  
            {  
                serviceEndpoint.Binding.SendTimeout = new System.TimeSpan(0, 1, 0);  
                clientCredentials.UserName.UserName = "username1";  
                clientCredentials.UserName.Password = "password";  
            }  
            else if (serviceEndpoint.Name ==
                    ServiceRefMultiEndpt.Service1Client.EndpointConfiguration.NetTcpBinding_IService1.ToString())  
            {  
                serviceEndpoint.Binding.Name = "MyTcpBinding";  
                serviceEndpoint.Address = new System.ServiceModel.EndpointAddress("net.tcp://localhost/tcp");  
            }  
        }  
    }  
```  
  
### <a name="serialization"></a>Сериализация  

 Поддерживаются следующие сериализаторы WCF в приложениях Магазина Windows:  
  
1. DataContractSerializer  
  
2. DataContractJsonSerializer  
  
3. XmlSerializer  
  
> [!WARNING]
> XmlDictionaryWriter.Write (DateTime) теперь записывает объект DateTime в виде строки.  
  
### <a name="security"></a>Безопасность  

В приложениях Магазина Windows поддерживаются следующие режимы безопасности:
  
1. <xref:System.ServiceModel.SecurityMode.None>  
  
2. <xref:System.ServiceModel.SecurityMode.Transport>  
  
3. <xref:System.ServiceModel.SecurityMode.TransportWithMessageCredential>
  
4. <xref:System.ServiceModel.SecurityMode.Message>
  
В приложениях Магазина Windows поддерживаются следующие типы учетных данных клиента:
  
1. None  
  
2. Основные  
  
3. Digest (дайджест)  
  
4. Согласование  
  
5. NTLM  
  
6. Windows  
  
7. Имя пользователя (безопасность сообщений)  
  
8. Windows (безопасность транспорта)  
  
 Чтобы приложения Магазина Windows могли получать и передавать учетные данные Windows по умолчанию, необходимо включить эту возможность в файле Package.appmanifest. Откройте этот файл и перейдите на вкладку "возможности" и выберите "учетные данные Windows по умолчанию". Это позволит приложению подключаться к ресурсам интрасети, для доступа к которым требуются учетные данные домена.  
  
> [!IMPORTANT]
> Чтобы приложения Магазина Windows могли выполнять вызовы между компьютерами, необходимо включить другую возможность, называемую "Домашняя или Рабочая сеть". Этот параметр также находится в файле Package. appmanifest на вкладке возможности. Установите флажок Домашняя или Рабочая сеть. Это позволит вашему приложению получать входящий и исходящий доступ к сетям доверенных мест пользователя, например домашних и рабочих. Важные входящие порты всегда заблокированы. Для доступа к службам в Интернете необходимо также включить возможность «Интернет (клиент)».  
  
### <a name="misc"></a>Разное  

 Поддерживается использование следующих классов для приложений Магазина Windows:  
  
1. <xref:System.ServiceModel.ChannelFactory>  
  
2. <xref:System.ServiceModel.DuplexChannelFactory%601>
  
3. <xref:System.ServiceModel.CallbackBehaviorAttribute>  
  
### <a name="defining-service-contracts"></a>Определение контрактов службы  

 Рекомендуется определять только асинхронные операции службы с помощью асинхронной модели на основе событий. Это гарантирует, что приложения Магазина Windows сохранят высокую скорость отклика при вызове операции службы.  
  
> [!WARNING]
> Хотя исключение не возникнет, если указать синхронную операцию, настоятельно рекомендуется определять только асинхронные операции.  
  
### <a name="calling-wcf-services-from-windows-store-applications"></a>Вызов служб WCF из приложений Магазина Windows  

 Как уже говорилось, вся настройка должна быть сделана в коде метода GetBindingForEndpoint в сформированном прокси-классе. Вызов операции службы выполняется точно так же, как и вызов любого асинхронного метода, как показано в следующем фрагменте кода.  
  
```csharp  
void async SomeMethod()  
{  
    ServiceClient proxy = new ServiceClient();  
    Task<T> results = await proxy.CallAsync(param1, param2);  
    T result = results.Result;  
    if (result.Success)  
    {  
       // Do something with result  
    }  
}  
```  
  
 Обратите внимание на использование ключевого слова async при асинхронном вызове, а также ключевого слова await при вызове асинхронного метода.  
  
## <a name="see-also"></a>См. также

- [Программирование безопасности WCF](programming-wcf-security.md)
- [Привязки](../bindings.md)
