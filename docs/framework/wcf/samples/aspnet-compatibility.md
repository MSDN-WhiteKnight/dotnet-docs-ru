---
description: 'Дополнительные сведения: совместимость ASP.NET'
title: Совместимость с ASP.NET
ms.date: 03/30/2017
ms.assetid: c8b51f1e-c096-4c42-ad99-0519887bbbc5
ms.openlocfilehash: a5685481a16d87715d4fc9096055af5be479f459
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99778858"
---
# <a name="aspnet-compatibility"></a>Совместимость с ASP.NET

В этом примере показано, как включить режим совместимости ASP.NET в Windows Communication Foundation (WCF). Службы, работающие в режиме совместимости ASP.NET, полностью участвуют в конвейере приложений ASP.NET и могут использовать такие функции ASP.NET, как авторизация файлов и URL-адресов, состояние сеанса и <xref:System.Web.HttpContext> класс. <xref:System.Web.HttpContext>Класс предоставляет доступ к файлам cookie, сеансам и другим ASP.NET функциям. Для этого режима требуется, чтобы привязки использовали транспорт HTTP, а сами службы были размещены в службах IIS.

В этом примере клиентом является консольное приложение (как исполняемый файл), а служба размещается в службах IIS.

> [!NOTE]
> Процедура настройки и инструкции по построению для данного образца приведены в конце этого раздела.

Для запуска этого примера требуется пул приложений платформа .NET Framework 4. Чтобы создать новый пул приложений или изменить пул приложений по умолчанию, выполните следующие шаги.

1. Откройте **Панель управления**.  Откройте приложение **Администрирование** под заголовком **система и безопасность** . Откройте приложение **диспетчера службы IIS (IIS)** .

2. Разверните элемент TreeView в области **подключения** . Выберите узел **Пулы приложений** .

3. Чтобы настроить пул приложений по умолчанию для использования платформа .NET Framework 4 (что может привести к проблемам несовместимости с существующими сайтами), щелкните правой кнопкой мыши элемент списка **DefaultAppPool** и выберите пункт **Основные параметры...**. Задайте для **версии .NET Framework версию** **.NET Framework v 4.0.30128** (или более позднюю).

4. Чтобы создать новый пул приложений, использующий платформа .NET Framework 4 (чтобы сохранить совместимость для других приложений), щелкните правой кнопкой мыши узел **Пулы приложений** и выберите **Добавить пул приложений.**... Присвойте новому пулу приложений имя, а для параметра **версия .NET Framework** — значение **.NET Framework v 4.0.30128** (или более поздней версии). После выполнения приведенных ниже шагов настройки щелкните правой кнопкой мыши приложение **servicemodelsamples** и выберите **Управление приложением**, **Дополнительные параметры...**. Задайте для **пула приложений** новый пул приложений.

> [!IMPORTANT]
> Образцы уже могут быть установлены на компьютере. Перед продолжением проверьте следующий каталог (по умолчанию).
>
> `<InstallDrive>:\WF_WCF_Samples`
>
> Если этот каталог не существует, перейдите к [примерам Windows Communication Foundation (WCF) и Windows Workflow Foundation (WF) для платформа .NET Framework 4](https://www.microsoft.com/download/details.aspx?id=21459) , чтобы скачать все Windows Communication Foundation (WCF) и [!INCLUDE[wf1](../../../../includes/wf1-md.md)] примеры. Этот образец расположен в следующем каталоге.
>
> `<InstallDrive>:\WF_WCF_Samples\WCF\Basic\Services\Hosting\WebHost\ASPNetCompatibility`

Этот образец основан на [Начало работы](getting-started-sample.md), который реализует службу калькулятора. Контракт `ICalculator` был изменен в соответствии с контрактом `ICalculatorSession`, чтобы можно было выполнять набор операций с сохранением промежуточного результата.

```csharp
[ServiceContract(Namespace="http://Microsoft.ServiceModel.Samples")]
public interface ICalculatorSession
{
    [OperationContract]
    void Clear();
    [OperationContract]
    void AddTo(double n);
    [OperationContract]
    void SubtractFrom(double n);
    [OperationContract]
    void MultiplyBy(double n);
    [OperationContract]
    void DivideBy(double n);
    [OperationContract]
    double Result();
}
```

Благодаря использованию возможности служба поддерживает состояние клиента во время вызова нескольких операций для вычислений. Клиент может извлечь текущий результат путем вызова метода `Result` и очистить результат (сделать его равным нулю) путем вызова метода `Clear`.

Служба использует сеанс ASP.NET для хранения результатов для каждого сеанса клиента. Это позволяет службе поддерживать промежуточный результат для каждого клиента по мере множественных вызовов службы.

> [!NOTE]
> Состояние сеанса ASP.NET и сеансы WCF очень различны. Дополнительные сведения о сеансах WCF см. в разделе [сеанс](session.md) .

Служба имеет глубокую зависимость от состояния сеанса ASP.NET и требует режима совместимости ASP.NET для правильной работы. Такие требования выражаются декларативно путем применения атрибута `AspNetCompatibilityRequirements`.

```csharp
[AspNetCompatibilityRequirements(RequirementsMode =
                       AspNetCompatibilityRequirementsMode.Required)]
public class CalculatorService : ICalculatorSession
{
    double Result
    {  // store result in AspNet Session
       get {
          if (HttpContext.Current.Session["Result"] != null)
             return (double)HttpContext.Current.Session["Result"];
          return 0.0D;
       }
       set
       {
          HttpContext.Current.Session["Result"] = value;
       }
    }
    public void Clear()
    {
        Result = 0.0D;
    }
    public void AddTo(double n)
    {
        Result += n;
    }
    public void SubtractFrom(double n)
    {
        Result -= n;
    }
    public void MultiplyBy(double n)
    {
        Result *= n;
    }
    public void DivideBy(double n)
    {
        Result /= n;
    }
    public double Result()
    {
        return Result;
    }
}
```

При выполнении примера запросы и ответы операций отображаются в окне консоли клиента. Чтобы закрыть клиент, нажмите клавишу ВВОД в окне клиента.

```console
0, + 100, - 50, * 17.65, / 2 = 441.25
Press <ENTER> to terminate client.
```

### <a name="to-set-up-build-and-run-the-sample"></a>Настройка, сборка и выполнение образца

1. Убедитесь, что вы выполнили [однократную процедуру настройки для Windows Communication Foundation примеров](one-time-setup-procedure-for-the-wcf-samples.md).

2. Чтобы создать выпуск решения на языке C# или Visual Basic .NET, следуйте инструкциям в разделе [Building the Windows Communication Foundation Samples](building-the-samples.md).

3. После построения решения запустите Setup.bat, чтобы настроить приложение ServiceModelSamples в IIS 7,0. Теперь каталог ServiceModelSamples должен отображаться как приложение IIS 7,0.

4. Чтобы запустить пример в конфигурации с одним или несколькими компьютерами, следуйте инструкциям в разделе [выполнение примеров Windows Communication Foundation](running-the-samples.md).

## <a name="see-also"></a>См. также

- [Образцы размещения и сохраняемости AppFabric](/previous-versions/appfabric/ff383418(v=azure.10))
