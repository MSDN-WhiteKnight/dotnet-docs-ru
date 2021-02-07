---
description: 'Дополнительные сведения: пример Федерации'
title: Пример федерации
ms.date: 03/30/2017
ms.assetid: 7e9da0ca-e925-4644-aa96-8bfaf649d4bb
ms.openlocfilehash: a85a290988b6cbb4b30a1098f3558ec34ead1d50
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99704086"
---
# <a name="federation-sample"></a>Пример федерации

В данном примере демонстрируется федеративная безопасность.  
  
## <a name="sample-details"></a>Подробные сведения об образце  

 Windows Communication Foundation (WCF) обеспечивает поддержку развертывания федеративных архитектур безопасности с помощью `wsFederationHttpBinding` . Привязка `wsFederationHttpBinding` обеспечивает наличие безопасной и надежной привязки, которая поддерживает возможность взаимодействия. Данная привязка предполагает использование протокола HTTP в качестве базового транспортного механизма для взаимодействия типа "запрос-ответ" и текста/XML в качестве формата подключения для кодирования. Дополнительные сведения о Федерации в WCF см. в разделе [Федерация](../feature-details/federation.md).  
  
 Сценарий состоит из 4 частей:  
  
- служба BookStore;  
  
- служба маркеров безопасности BookStore;  
  
- служба маркеров безопасности HomeRealm;  
  
- клиент BookStore.  
  
 Служба BookStore поддерживает две операции: `BrowseBooks` и `BuyBook`. Служба позволяет выполнять анонимный доступ к операции `BrowseBooks`, но требует доступ с проверкой подлинности к операции `BuyBooks` . Проверка подлинности принимает форму маркера, выданного службой маркеров безопасности BookStore. Файл конфигурации службы BookStore указывает клиентам на службу маркеров безопасности BookStore с помощью `wsFederationHttpBinding`.  
  
```xml  
<wsFederationHttpBinding>  
<!-- This is the Service binding for the BuyBooks endpoint. It redirects clients to the BookStore STS -->  
    <binding name='BuyBookBinding'>  
        <security mode="Message">  
            <message>  
                <issuerMetadata  
  address='http://localhost/FederationSample/BookStoreSTS/STS.svc/mex' >  
                    <identity>  
                        <dns value ='BookStoreSTS.com'/>  
                    </identity>  
                </issuerMetadata>  
            </message>  
        </security>  
    </binding>  
</wsFederationHttpBinding>  
```  
  
 Затем служба маркеров безопасности BookStore требует, чтобы проверка подлинности клиента выполнялась с помощью маркера, выданного службой маркеров безопасности HomeRealm. И снова файл конфигурации службы маркеров безопасности BookStore указывает клиентам на службу маркеров безопасности HomeRealm с помощью `wsFederationHttpBinding`.  
  
```xml  
<wsFederationHttpBinding>  
 <!-- This is the binding for the clients requesting tokens from this STS. It redirects clients to the HomeRealm STS -->  
    <binding name='BookStoreSTSBinding'>  
        <security mode='Message'>  
            <message>  
                <issuerMetadata  
 address='http://localhost/FederationSample/HomeRealmSTS/STS.svc/mex' >  
                    <identity>  
                        <dns value ='HomeRealmSTS.com' />  
                    </identity>  
                </issuerMetadata>  
            </message>  
        </security>  
    </binding>  
</wsFederationHttpBinding>  
```  
  
 Ниже приведена последовательность событий при получении доступа к операции `BuyBook`.  
  
1. Клиент проходит проверку подлинности в службе маркеров безопасности HomeRealm с использованием учетных данных Windows.  
  
2. Служба маркеров безопасности HomeRealm выдает маркер, который может использоваться для проверки подлинности в службе маркеров безопасности BookStore.  
  
3. Клиент проходит проверку подлинности в службе маркеров безопасности BookStore с использованием маркера, выданного службой маркеров безопасности HomeRealm.  
  
4. Служба маркеров безопасности BookStore выдает маркер, который может использоваться для проверки подлинности в службе BookStore.  
  
5. Клиент проходит проверку подлинности в службе BookStore с использованием маркера, выданного службой маркеров безопасности BookStore.  
  
6. Клиент получает доступ к операции `BuyBook`.  
  
 В приведенных ниже инструкциях описаны настройка и запуск данного образца.  
  
> [!NOTE]
> Для запуска этого образца необходимо иметь разрешения на запись в каталог **wwwroot** .  
  
#### <a name="to-set-up-build-and-run-the-sample"></a>Настройка, сборка и выполнение образца  
  
1. Откройте окно командной строки SDK. Выполните Setup.bat в пути образца. При этом будут созданы требуемые для образца виртуальные каталоги и установлены необходимые сертификаты с соответствующими разрешениями.  
  
    > [!NOTE]
    > Пакетный файл Setup.bat предназначен для запуска из командной строки Windows SDK. Требуется, чтобы переменная среды MSSDK указывала на каталог, в котором установлен пакет SDK. Эта переменная среды автоматически устанавливается в командной строке Windows SDK. В Windows Vista необходимо убедиться, что установлена совместимость управления IIS 6,0, так как для установки используются сценарии администратора IIS. Для выполнения сценария установки в Windows Vista требуются права администратора.  
  
2. Откройте Федератионсампле. sln в Visual Studio и выберите в меню **Сборка** пункт **построить решение** . При этом будут построены и развернуты в IIS общие файлы проекта, служба Bookstore, служба маркеров безопасности Bookstore, служба маркеров безопасности HomeRealm. Кроме того, при этом будет построено клиентское приложение Bookstore. Его исполняемый файл BookStoreClient.exe будет размещен в папке FederationSample\BookStoreClient\bin\Debug.  
  
3. Дважды щелкните BookStoreClient.exe. Отобразится окно BookStoreClient.  
  
4. Чтобы просмотреть книги, доступные в книжном магазине, щелкните **Обзор книг**.  
  
5. Чтобы приобрести конкретную книгу, выберите книгу в списке и щелкните **купить книгу**. Приложение запустится и пройдет проверку подлинности с использованием проверки подлинности Windows со службой маркеров безопасности HomeRealm.  
  
     Конфигурация данного примера позволяет пользователям приобретать книги, которые стоят 15 долларов США или меньше. Попытка приобрести книгу, стоимость которой превышает 15 долларов США, приводит к тому, что клиент получает сообщение «Доступ запрещен» от службы Book Store.  
  
    > [!NOTE]
    > В данном примере кредитный лимит пользователя после покупки не обновляется. Вы можете повторно приобрести книги на сумму в пределах пользовательского (фиксированного) кредитного лимита.  
  
#### <a name="to-clean-up"></a>Очистка  
  
1. Запустите Cleanup.bat. При этом будут удалены виртуальные каталоги и сертификаты, созданные во время установки.  
  
> [!IMPORTANT]
> Образцы уже могут быть установлены на компьютере. Перед продолжением проверьте следующий каталог (по умолчанию).  
>
> `<InstallDrive>:\WF_WCF_Samples`  
>
> Если этот каталог не существует, перейдите к [примерам Windows Communication Foundation (WCF) и Windows Workflow Foundation (WF) для платформа .NET Framework 4](https://www.microsoft.com/download/details.aspx?id=21459) , чтобы скачать все Windows Communication Foundation (WCF) и [!INCLUDE[wf1](../../../../includes/wf1-md.md)] примеры. Этот образец расположен в следующем каталоге.  
>
> `<InstallDrive>:\WF_WCF_Samples\WCF\Scenario\Federation`  
