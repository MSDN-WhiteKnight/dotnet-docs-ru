---
description: Дополнительные сведения о том, как создать объект WindowsPrincipal.
title: Практическое руководство. Создание объекта WindowsPrincipal
ms.date: 07/15/2020
dev_langs:
- csharp
- vb
helpviewer_keywords:
- WindowsPrincipal objects, creating
- security [.NET], creating a WindowsPrincipal object
- security [.NET], principals
- principal objects, creating
ms.assetid: 56eb10ca-e61d-4ed2-af7a-555fc4c25a25
ms.openlocfilehash: eee33eb419e8626b8b7f627b9ab1e46ea8dceab5
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99685235"
---
# <a name="how-to-create-a-windowsprincipal-object"></a>Практическое руководство. Создание объекта WindowsPrincipal

> [!NOTE]
> Эта статья относится к Windows.
>
> Сведения о ASP.NET Core см. в разделе [ASP.NET Core Security](/aspnet/core/security/).

Существует два способа создания объекта <xref:System.Security.Principal.WindowsPrincipal> в зависимости от того, должен ли код выполнять проверку на основании ролей многократно или всего один раз.  
  
Если код должен многократно выполнять проверку на основе ролей, первая из следующих процедур создает меньше служебных данных. Если коду требуется выполнять проверку на основе ролей только один раз, можно создать объект <xref:System.Security.Principal.WindowsPrincipal> при помощи второй из приведенных ниже процедур.  
  
### <a name="to-create-a-windowsprincipal-object-for-repeated-validation"></a>Создание объекта WindowsPrincipal для повторяющейся проверки  
  
1. Вызовите метод <xref:System.AppDomain.SetPrincipalPolicy%2A> для объекта <xref:System.AppDomain>, возвращенного статическим свойством <xref:System.AppDomain.CurrentDomain%2A?displayProperty=nameWithType>, передав в метод <xref:System.Security.Principal.PrincipalPolicy> значение перечисления, которое указывает, какой должна быть новая политика. Поддерживаются значения <xref:System.Security.Principal.PrincipalPolicy.NoPrincipal>, <xref:System.Security.Principal.PrincipalPolicy.UnauthenticatedPrincipal> и <xref:System.Security.Principal.PrincipalPolicy.WindowsPrincipal>. Вызов этого метода демонстрируется в следующем коде.  
  
    ```csharp  
    AppDomain.CurrentDomain.SetPrincipalPolicy(  
        PrincipalPolicy.WindowsPrincipal);  
    ```  
  
    ```vb  
    AppDomain.CurrentDomain.SetPrincipalPolicy( _  
        PrincipalPolicy.WindowsPrincipal)  
    ```  
  
2. После задания политики используйте статическое свойство <xref:System.Threading.Thread.CurrentPrincipal%2A?displayProperty=nameWithType> для извлечения субъекта, инкапсулирующего текущего пользователя Windows. Поскольку возвращаемое свойство имеет тип <xref:System.Security.Principal.IPrincipal>, результат необходимо привести к типу <xref:System.Security.Principal.WindowsPrincipal>. Следующий код инициализирует новый объект <xref:System.Security.Principal.WindowsPrincipal> значением субъекта, связанного с текущим потоком.  
  
    ```csharp  
    WindowsPrincipal myPrincipal =
        (WindowsPrincipal) Thread.CurrentPrincipal;  
    ```  
  
    ```vb  
    Dim myPrincipal As WindowsPrincipal = _  
        CType(Thread.CurrentPrincipal, WindowsPrincipal)
    ```  
  
3. После создания объекта субъекта можно использовать один из нескольких методов для его проверки.  
  
### <a name="to-create-a-windowsprincipal-object-for-a-single-validation"></a>Создание объекта WindowsPrincipal для однократной проверки  
  
1. Инициализируйте новый объект <xref:System.Security.Principal.WindowsIdentity> путем вызова статического метода <xref:System.Security.Principal.WindowsIdentity.GetCurrent%2A?displayProperty=nameWithType>, который отправляет запрос в текущую учетную запись Windows и помещает сведения об этой учетной записи во вновь созданный объект идентификатора. Следующий код создает новый объект <xref:System.Security.Principal.WindowsIdentity> и инициализирует его текущим пользователем, прошедшим проверку подлинности.  
  
    ```csharp  
    WindowsIdentity myIdentity = WindowsIdentity.GetCurrent();  
    ```  
  
    ```vb  
    Dim myIdentity As WindowsIdentity = WindowsIdentity.GetCurrent()  
    ```  
  
2. Создайте новый объект <xref:System.Security.Principal.WindowsPrincipal> и передайте ему значение объекта <xref:System.Security.Principal.WindowsIdentity>, созданного в предыдущем шаге.  
  
    ```csharp  
    WindowsPrincipal myPrincipal = new WindowsPrincipal(myIdentity);  
    ```  
  
    ```vb  
    Dim myPrincipal As New WindowsPrincipal(myIdentity)  
    ```  
  
3. После создания объекта субъекта можно использовать один из нескольких методов для его проверки.  
  
## <a name="see-also"></a>См. также

- [Объекты Principal и Identity](principal-and-identity-objects.md)
- [Безопасность ASP.NET Core](/aspnet/core/security/)
