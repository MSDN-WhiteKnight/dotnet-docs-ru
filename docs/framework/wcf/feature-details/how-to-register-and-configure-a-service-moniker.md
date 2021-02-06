---
description: Дополнительные сведения см. в статье как зарегистрировать и настроить моникер службы.
title: Практическое руководство. Регистрация и настройка моникера службы
ms.date: 03/30/2017
helpviewer_keywords:
- COM [WCF], configure service monikers
- COM [WCF], register service monikers
ms.assetid: e5e16c80-8a8e-4eef-af53-564933b651ef
ms.openlocfilehash: 9c6867941a5b96c6ced0f8e371e10697144bd121
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99643466"
---
# <a name="how-to-register-and-configure-a-service-moniker"></a>Практическое руководство. Регистрация и настройка моникера службы

Перед использованием моникера службы Windows Communication Foundation (WCF) в приложении COM с типизированным контрактом необходимо зарегистрировать необходимые типы с атрибутами в COM и настроить приложение COM и моникер с требуемой конфигурацией привязки.

## <a name="register-the-required-attributed-types-with-com"></a>Регистрация необходимых типов с атрибутами в COM

1. Используйте средство [служебной программы метаданных ServiceModel (Svcutil.exe)](../servicemodel-metadata-utility-tool-svcutil-exe.md) для получения контракта метаданных из службы WCF. При этом создается исходный код для клиентской сборки WCF и файла конфигурации клиентского приложения.

2. Убедитесь, что все типы в сборке имеют пометку `ComVisible`. Для этого добавьте следующий атрибут в файл *AssemblyInfo.CS* в проекте Visual Studio.

    ```csharp
    [assembly: ComVisible(true)]
    ```

3. Скомпилируйте управляемый клиент WCF как сборку со строгим именем. Для этого нужно подписать ее с помощью пары ключей шифрования. Дополнительные сведения см. в разделе [Подпись сборки строгим именем](../../../standard/assembly/sign-strong-name.md).

4. С помощью средства регистрации сборок (Regasm.exe) с параметром `-tlb` зарегистрируйте типы сборки в COM.

5. Чтобы добавить сборку в глобальный кэш сборок, используйте средство глобального кэша сборок (Gacutil.exe).

    > [!NOTE]
    > Подписывание сборки и ее добавление в глобальный кэш сборок являются необязательными шагами, однако они могут упростить процесс загрузки сборки из правильного расположения во время выполнения.

## <a name="configure-the-com-application-and-the-moniker-with-the-required-binding-configuration"></a>Настройка COM-приложения и моникера с требуемой конфигурацией привязки

- Разместите определения привязок (создаваемые [служебной программой метаданных ServiceModel (Svcutil.exe)](../servicemodel-metadata-utility-tool-svcutil-exe.md) в созданном файле конфигурации клиентского приложения) в файле конфигурации клиентского приложения. Например, для исполняемого файла Visual Basic 6.0 с именем CallCenterClient.exe конфигурацию необходимо помещать в файл с именем CallCenterConfig.exe.config в том же каталоге, что и исполняемый файл. Теперь клиентское приложение может использовать моникер. Обратите внимание, что настройка привязки не требуется, если используется один из стандартных типов привязки, предоставляемых WCF.

     Регистрируется следующий тип.

    ```csharp
    using System.ServiceModel;

    [ServiceContract]
    public interface IMathService
    {
        [OperationContract]
        public int Add(int x, int y);
        [OperationContract]
        public int Subtract(int x, int y);
    }
    ```

     Доступ к приложению предоставляется через следующую привязку `wsHttpBinding`. Для заданного типа и конфигурации приложения используются следующие примеры строк моникера.

    ```
    service4:address=http://localhost/MathService, binding=wsHttpBinding, bindingConfiguration=Binding1
    ```

     или

    ```
    service4:address=http://localhost/MathService, binding=wsHttpBinding, bindingConfiguration=Binding1, contract={36ADAD5A-A944-4d5c-9B7C-967E4F00A090}
    ```

     Можно использовать любую из этих строк моникера из приложения Visual Basic 6.0 после добавления ссылки на сборку, содержащую типы `IMathService`, как показано в следующем образце кода.

    ```vb
    Dim mathProxy As IMathService
    Dim result As Integer

    Set mathProxy = GetObject( _
            "service4:address=http://localhost/MathService, _
            binding=wsHttpBinding, _
            bindingConfiguration=Binding1")

    result = mathProxy.Add(3, 5)
    ```

     В этом примере определение конфигурации привязки хранится в соответствующем `Binding1` именованном файле конфигурации для клиентского приложения, например *vb6appname.exe.config*.

    > [!NOTE]
    > Аналогичный код можно использовать в C#, C++ или любом другом языке приложений .NET.

    > [!NOTE]
    > Если моникер имеет неправильный формат или если служба недоступна, вызов `GetObject` возвращает ошибку "Недопустимый синтаксис". При получении этой ошибки убедитесь, что используется правильный моникер, а служба доступна.

     Хотя в этом разделе основное внимание уделяется использованию моникера службы из кода Visual Basic 6,0, можно использовать моникер службы на других языках. При использовании моникера из кода C++ сбоку, созданную с помощью средства Svcutil.exe, необходимо импортировать с атрибутом "no_namespace named_guids raw_interfaces_only", как показано в следующем примере кода.

    ```cpp
    #import "ComTestProxy.tlb" no_namespace named_guids
    ```

     При этом изменяются определения импортированного интерфейса, чтобы все методы возвращали `HResult`. Все остальные возвращаемые значения преобразуются в выходные параметры. Общий процесс выполнения методов остается прежним. Это позволяет определить причину исключения при вызове метода в прокси. Эта функция доступна только в коде C++.

## <a name="see-also"></a>См. также

- [Служебное средство ServiceModel Metadata Utility Tool (Svcutil.exe)](../servicemodel-metadata-utility-tool-svcutil-exe.md)
