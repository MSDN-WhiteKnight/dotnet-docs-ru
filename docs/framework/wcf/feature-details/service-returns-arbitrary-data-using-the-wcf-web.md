---
description: Дополнительные сведения см. в статье как создать службу, возвращающую произвольные данные с помощью модели программирования WCF Web HTTP.
title: Практическое руководство. Как создать службу, возвращающую произвольные данные, с использованием модели программирования WCF Web HTTP
ms.date: 03/30/2017
ms.assetid: 0283955a-b4ae-458d-ad9e-6fbb6f529e3d
ms.openlocfilehash: aeb03e0dad6c63c463db419027f5556922b2f160
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99793536"
---
# <a name="how-to-create-a-service-that-returns-arbitrary-data-using-the-wcf-web-http-programming-model"></a>Практическое руководство. Как создать службу, возвращающую произвольные данные, с использованием модели программирования WCF Web HTTP

Иногда разработчики должны полностью управлять тем, как данные возвращаются из операции службы. Так происходит, когда операция службы должна возвращать данные в формате, не поддерживаемом WCF. В этом разделе обсуждается использование модели программирования WCF WEB HTTP для создания такой службы. В этой службе имеется одна операция, которая возвращает поток.  
  
### <a name="to-implement-the-service-contract"></a>Реализация контракта службы  
  
1. Определите контракт службы. Контракт называется `IImageServer` и в нем имеется один метод под названием `GetImage`, который возвращает поток <xref:System.IO.Stream>.  
  
    ```csharp  
    [ServiceContract]  
        public interface IImageServer  
        {  
            [WebGet]  
            Stream GetImage(int width, int height);  
        }  
    ```  
  
     Поскольку метод возвращает <xref:System.IO.Stream> , WCF предполагает, что операция имеет полный контроль над байтами, возвращаемыми операцией службы, и не применяет форматирование к возвращаемым данным.  
  
2. Реализуйте контракт службы. В контракте есть только одна операция (`GetImage`). Этот метод создает растровое изображение и сохраняет его в потоке <xref:System.IO.MemoryStream> в формате JPG. Операция затем возвращает этот поток вызывающему объекту.  
  
    ```csharp
    public class Service : IImageServer
    {
        public Stream GetImage(int width, int height)
        {
            Bitmap bitmap = new Bitmap(width, height);
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    bitmap.SetPixel(i, j, (Math.Abs(i - j) < 2) ? Color.Blue : Color.Yellow);
                }
            }
            MemoryStream ms = new MemoryStream();
            bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            ms.Position = 0;
            WebOperationContext.Current.OutgoingResponse.ContentType = "image/jpeg";
            return ms;
        }
    }
    ```  
  
     Взгляните на последнюю строку кода: `WebOperationContext.Current.OutgoingResponse.ContentType = "image/jpeg";`  
  
     При этом задается заголовок типа содержимого `"image/jpeg"` . Хотя в этом образце показано, как вернуть JPG-файл, данный образец можно изменить для возврата любого типа необходимых данных в любом формате. Операция должна получить или создать данные и затем записать их в поток.  
  
### <a name="to-host-the-service"></a>Размещение службы  
  
1. Создайте консольное приложение для размещения службы.  
  
    ```csharp
    class Program  
    {  
        static void Main(string[] args)  
        {  
        }
    }  
    ```  
  
2. Создайте переменную для хранения базового адреса службы в методе `Main`.  
  
    ```csharp
    string baseAddress = "http://" + Environment.MachineName + ":8000/Service";  
    ```  
  
3. Создайте экземпляр <xref:System.ServiceModel.ServiceHost> для службы, задав класс службы и базовый адрес.  
  
    ```csharp
    ServiceHost host = new ServiceHost(typeof(Service), new Uri(baseAddress));  
    ```  
  
4. Добавьте конечную точку, используя <xref:System.ServiceModel.WebHttpBinding> и <xref:System.ServiceModel.Description.WebHttpBehavior>.  
  
    ```csharp  
    host.AddServiceEndpoint(typeof(IImageServer), new WebHttpBinding(), "").Behaviors.Add(new WebHttpBehavior());  
    ```  
  
5. Откройте узел службы.  
  
    ```csharp  
    host.Open();  
    ```  
  
6. Подождите, пока пользователь нажмет клавишу ВВОД, чтобы завершить работу службы.  
  
    ```csharp
    Console.WriteLine("Service is running");  
    Console.Write("Press ENTER to close the host");  
    Console.ReadLine();  
    host.Close();  
    ```  
  
### <a name="to-call-the-raw-service-using-internet-explorer"></a>Вызов необработанной службы с помощью Internet Explorer  
  
1. Запустите службу. От службы должно появиться следующее сообщение: `Service is running Press ENTER to close the host`  
  
2. Откройте Internet Explorer и введите `http://localhost:8000/Service/GetImage?width=50&height=40`. Должен появиться желтый прямоугольник с синей диагональной линией, проходящей через центр.  
  
## <a name="example"></a>Пример  

 Ниже приведен полный листинг кода для данного раздела.  
  
```csharp  
using System;  
using System.Collections.Generic;  
using System.Text;  
using System.ServiceModel;  
using System.ServiceModel.Web;  
using System.ServiceModel.Description;  
using System.IO;  
using System.Drawing;  
  
namespace RawImageService  
{  
    // Define the service contract  
    [ServiceContract]  
    public interface IImageServer  
    {  
        [WebGet]  
        Stream GetImage(int width, int height);  
    }  
  
    // implement the service contract  
    public class Service : IImageServer  
    {  
        public Stream GetImage(int width, int height)  
        {  
            // Although this method returns a jpeg, it can be  
            // modified to return any data you want within the stream  
            Bitmap bitmap = new Bitmap(width, height);  
            for (int i = 0; i < bitmap.Width; i++)  
            {  
                for (int j = 0; j < bitmap.Height; j++)  
                {  
                    bitmap.SetPixel(i, j, (Math.Abs(i - j) < 2) ? Color.Blue : Color.Yellow);  
                }  
            }  
            MemoryStream ms = new MemoryStream();  
            bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);  
            ms.Position = 0;  
            WebOperationContext.Current.OutgoingResponse.ContentType = "image/jpeg";  
            return ms;  
        }  
    }  
  
    class Program  
    {  
        static void Main(string[] args)  
        {  
            string baseAddress = "http://" + Environment.MachineName + ":8000/Service";  
            ServiceHost host = new ServiceHost(typeof(Service), new Uri(baseAddress));  
            host.AddServiceEndpoint(typeof(IImageServer), new WebHttpBinding(), "").Behaviors.Add(new WebHttpBehavior());  
            host.Open();  
            Console.WriteLine("Service is running");  
            Console.Write("Press ENTER to close the host");  
            Console.ReadLine();  
            host.Close();  
  
        }  
    }  
}  
```  
  
## <a name="compiling-the-code"></a>Компиляция кода  
  
- При компиляции образец кода обращается к файлам System.ServiceModel.dll и System.ServiceModel.Web.dll.  
  
## <a name="see-also"></a>См. также

- [Модель веб-программирования HTTP WCF](wcf-web-http-programming-model.md)
