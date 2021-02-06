---
description: 'Дополнительные сведения: объект My. WebService'
title: Объект My.WebServices
ms.date: 07/20/2015
f1_keywords:
- My.WebServices
- My.MyProject.WebServices
helpviewer_keywords:
- My.WebServices object
ms.assetid: f188dc05-2c75-41b6-bb68-122d1c3110a2
ms.openlocfilehash: e8d7ef8b349fef6d69b92d9df4a23222bd3c912e
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99640541"
---
# <a name="mywebservices-object"></a>Объект My.WebServices

Предоставляет свойства для создания и доступа к одному экземпляру каждой веб-службы XML, на которую ссылается текущий проект.  
  
## <a name="remarks"></a>Remarks  

 Объект `My.WebServices` предоставляет экземпляр каждой веб-службы, на которую ссылается текущий проект. Каждый экземпляр создается по запросу. Доступ к этим веб-службам можно получить через свойства объекта `My.WebServices`. Имя свойства совпадает с именем веб-службы, к которой обращается свойство. Любой класс, наследуемый от <xref:System.Web.Services.Protocols.SoapHttpClientProtocol>, является веб-службой. Сведения о добавлении веб-служб в проект см. в разделе [доступ к веб-службам приложений](../../developing-apps/programming/accessing-application-web-services.md).  
  
 `My.WebServices`Объект предоставляет только веб-службы, связанные с текущим проектом. Он не предоставляет доступ к веб-службам, объявленным в упоминаемых в них библиотеках DLL. Для доступа к веб-службе, предоставляемой библиотекой DLL, необходимо использовать полное имя веб-службы в формате *dllname*. *WebServiceName*. Дополнительные сведения см. в разделе [доступ к веб-службам приложений](../../developing-apps/programming/accessing-application-web-services.md).  
  
 Объект и его свойства недоступны для веб-приложений.  
  
## <a name="properties"></a>Свойства  

 Каждое свойство `My.WebServices` объекта предоставляет доступ к экземпляру веб-службы, на которую ссылается текущий проект. Имя свойства совпадает с именем веб-службы, к которой обращается свойство, а тип свойства совпадает с типом веб-службы.  
  
> [!NOTE]
> При конфликте имен имя свойства для доступа к веб-службе — *RootNamespace* _ *Namespace* \_ *ServiceName*. Например, рассмотрим две веб-службы с именем `Service1` . Если одна из этих служб находится в корневом пространстве имен `WindowsApplication1` и в пространстве имен `Namespace1` , доступ к этой службе будет осуществляться с помощью `My.WebServices.WindowsApplication1_Namespace1_Service1` .  
  
 При первом доступе к одному из `My.WebServices` свойств объекта он создает новый экземпляр веб-службы и сохраняет его. Последующие обращения к этому свойству возвращают этот экземпляр веб-службы.  
  
 Вы можете удалить веб-службу, назначив ей `Nothing` свойство для этой веб-службы. Метод задания свойства присваивает `Nothing` хранимому значению. Если присвоить значение, отличное от `Nothing` свойства, метод задания выдаст <xref:System.ArgumentException> исключение.  
  
 Можно проверить `My.WebServices` , сохраняет ли свойство объекта экземпляр веб-службы с помощью `Is` `IsNot` оператора или. С помощью этих операторов можно проверить, имеет ли свойство значение `Nothing` .  
  
> [!NOTE]
> Как правило, `Is` `IsNot` оператор или должен считывать значение свойства для выполнения сравнения. Однако если текущее свойство хранится `Nothing` , свойство создает новый экземпляр веб-службы, а затем возвращает этот экземпляр. Однако компилятор Visual Basic обрабатывает свойства `My.WebServices` объекта особым образом и позволяет `Is` `IsNot` оператору или проверить состояние свойства без изменения его значения.  
  
## <a name="example"></a>Пример  

 В этом примере вызывается `FahrenheitToCelsius` метод `TemperatureConverter` веб-службы XML и возвращается результат.  
  
 [!code-vb[VbVbalrMyWebService#1](~/samples/snippets/visualbasic/VS_Snippets_VBCSharp/VbVbalrMyWebService/VB/Form1.vb#1)]  
  
 Чтобы этот пример работал, проект должен ссылаться на веб-службу с именем `Converter` , и эта веб-служба должна предоставлять `ConvertTemperature` метод. Дополнительные сведения см. в разделе [доступ к веб-службам приложений](../../developing-apps/programming/accessing-application-web-services.md).  
  
 Этот код не работает в проекте веб-приложения.  
  
## <a name="requirements"></a>Требования  
  
### <a name="availability-by-project-type"></a>Доступность по типу проекта  
  
|Тип проекта|Доступно|  
|---|---|  
|Приложение Windows|**Да**|  
|Библиотека классов|**Да**|  
|Консольное приложение|**Да**|  
|Библиотека элементов управления Windows|**Да**|  
|Библиотека веб-элементов управления|**Да**|  
|Службы Windows|**Да**|  
|Веб-сайт|Нет|  
  
## <a name="see-also"></a>См. также раздел

- <xref:System.Web.Services.Protocols.SoapHttpClientProtocol>
- <xref:System.ArgumentException>
- [Доступ к веб-службам приложения](../../developing-apps/programming/accessing-application-web-services.md)
