---
description: Дополнительные сведения см. в статье Настройка поведения привязки данных (службы данных WCF).
title: Практическое руководство. Настройка поведения привязки данных (службы данных WCF)
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
helpviewer_keywords:
- WCF Data Services, customizing
- WCF Data Services, data binding
ms.assetid: 40476b89-8941-4771-8d21-2fe430c85a9d
ms.openlocfilehash: 60c8808f90f8e0a824a8b2b641508c0fe33f14cc
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99765689"
---
# <a name="how-to-customize-data-binding-behaviors-wcf-data-services"></a>Практическое руководство. Настройка поведения привязки данных (службы данных WCF)

[!INCLUDE [wcf-deprecated](~/includes/wcf-deprecated.md)]

С помощью службы данных WCF можно указать пользовательскую логику, вызываемую, <xref:System.Data.Services.Client.DataServiceCollection%601> когда объект добавляется в коллекцию привязки или удаляется из нее или когда обнаруживается изменение свойства. Эта пользовательская логика предоставляется в виде методов, на которые ссылаются как <xref:System.Func%602> делегаты, которые возвращают значение, `false` Если поведение по умолчанию по-прежнему должно быть выполнено при завершении пользовательского метода, и `true` когда должна быть остановлена последующая обработка события.  
  
 Примеры в этом разделе добавляют специализированные методы для обоих параметров `entityChanged` и `entityCollectionChanged` коллекции <xref:System.Data.Services.Client.DataServiceCollection%601>. Примеры в этом разделе используют образец службы данных Northwind и автоматически сформированные клиентские классы службы данных. Эта служба и классы данных клиента создаются при завершении [краткого руководства по службы данных WCF](quickstart-wcf-data-services.md).  
  
## <a name="example"></a>Пример  

 Следующая страница с выделенным кодом для файла XAML создает коллекцию <xref:System.Data.Services.Client.DataServiceCollection%601> со специализированными методами, которые вызываются при внесении изменений в данные, привязанные к коллекции. При возникновении события <xref:System.Collections.ObjectModel.ObservableCollection%601.CollectionChanged> добавленный метод предотвращает удаление из службы данных элемента, удаленного из коллекции привязок. При возникновении события <xref:System.Collections.ObjectModel.ObservableCollection%601.PropertyChanged> значение `ShipDate` проверяется, чтобы изменения не проводились над заказами, которые уже были доставлены.  
  
 [!code-csharp[Astoria Northwind Client#WpfDataBindingCustom](../../../../samples/snippets/csharp/VS_Snippets_Misc/astoria_northwind_client/cs/customerorderscustom.xaml.cs#wpfdatabindingcustom)]
 [!code-vb[Astoria Northwind Client#WpfDataBindingCustom](../../../../samples/snippets/visualbasic/VS_Snippets_Misc/astoria_northwind_client/vb/customerorderscustom.xaml.vb#wpfdatabindingcustom)]
 [!code-vb[Astoria Northwind Client#WpfDataBindingCustom](../../../../samples/snippets/visualbasic/VS_Snippets_Misc/astoria_northwind_client/vb/customerorderscustom2.xaml.vb#wpfdatabindingcustom)]  
  
## <a name="example"></a>Пример  

 Следующий код XAML определяет окно для предыдущего примера.  
  
 [!code-xaml[Astoria Northwind Client#WpfDataBindingCustomXaml](../../../../samples/snippets/visualbasic/VS_Snippets_Misc/astoria_northwind_client/vb/customerorderscustom.xaml#wpfdatabindingcustomxaml)]  
  
## <a name="see-also"></a>См. также

- [Библиотека клиентов служб данных WCF](wcf-data-services-client-library.md)
