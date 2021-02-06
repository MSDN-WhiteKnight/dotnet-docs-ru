---
description: Дополнительные сведения см. в статье как импортировать утверждения пользовательской политики.
title: Практическое руководство. Импорт проверочных утверждений пользовательской политики
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
ms.assetid: 1f41d787-accb-4a10-bfc6-a807671d1581
ms.openlocfilehash: e9190a97ed7d2d369b8f9ddc3d7fec71daf1e54f
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99644337"
---
# <a name="how-to-import-custom-policy-assertions"></a>Практическое руководство. Импорт проверочных утверждений пользовательской политики

В утверждениях политики описываются возможности и требования конечной точки службы.  Клиентские приложения могут использовать утверждения политики в метаданных службы для настройки привязки клиента или для настройки контракта службы для конечной точки службы.  
  
 Утверждения настраиваемой политики импортируются путем реализации интерфейса <xref:System.ServiceModel.Description.IPolicyImportExtension?displayProperty=nameWithType> и передачи этого объекта системе метаданных или путем регистрации типа реализации в файле конфигурации приложения.  Реализации <xref:System.ServiceModel.Description.IPolicyImportExtension> интерфейса должны предоставлять конструктор без параметров.  
  
### <a name="to-import-custom-policy-assertions"></a>Импорт утверждений настраиваемой политики  
  
1. Реализуйте интерфейс <xref:System.ServiceModel.Description.IPolicyImportExtension?displayProperty=nameWithType> в классе. См. описанные ниже действия.  
  
2. Вставьте импортер настраиваемой политики одним из следующих способов:  
  
3. Путем использования файла конфигурации. См. описанные ниже действия.  
  
4. Использование файла конфигурации со [служебной программой метаданных ServiceModel (Svcutil.exe)](../servicemodel-metadata-utility-tool-svcutil-exe.md). См. описанные ниже действия.  
  
5. Программным путем. См. описанные ниже действия.  
  
### <a name="to-implement-the-systemservicemodeldescriptionipolicyimportextension-interface-on-any-class"></a>Реализация интерфейса System.ServiceModel.Description.IPolicyImportExtension в любом классе  
  
1. В методе <xref:System.ServiceModel.Description.IPolicyImportExtension.ImportPolicy%2A?displayProperty=nameWithType> для каждого интересующего субъекта политики найдите утверждения политики, которые требуется импортировать, вызвав соответствующий метод (в зависимости от требуемой области утверждения) объекта <xref:System.ServiceModel.Description.PolicyConversionContext?displayProperty=nameWithType>, переданного методу. В следующем примере кода показано использование метода <xref:System.ServiceModel.Description.PolicyAssertionCollection.Remove%2A?displayProperty=nameWithType> для поиска утверждения настраиваемой политики и удаления его из коллекции за один шаг. Если использовать метод удаления для поиска и удаления утверждения, выполнять шаг 4 не потребуется.  
  
     [!code-csharp[CustomPolicySample#9](../../../../samples/snippets/csharp/VS_Snippets_CFX/custompolicysample/cs/policyimporter.cs#9)]
     [!code-vb[CustomPolicySample#9](../../../../samples/snippets/visualbasic/VS_Snippets_CFX/custompolicysample/vb/policyimporter.vb#9)]  
  
2. Обработайте утверждения политики. Обратите внимание, что система политики не нормализует вложенные политики и `wsp:optional`. Эти конструкции необходимо обработать в реализации расширения импорта политики.  
  
3. Настройте привязку или контракт, поддерживающие возможность или требование, задаваемое утверждением политики. Как правило, в утверждениях указывается, что привязка требует определенной конфигурации или определенного элемента привязки. Внесите эти изменения, обратившись к свойству <xref:System.ServiceModel.Description.PolicyConversionContext.BindingElements%2A?displayProperty=nameWithType>. Другие утверждения требуют изменения контракта.  Обратиться к контракту и внести в него изменения можно с помощью свойства <xref:System.ServiceModel.Description.PolicyConversionContext.Contract%2A?displayProperty=nameWithType>.  Обратите внимание, что импортер политики может вызываться несколько раз для одной и той же привязки и контракта, однако для разных альтернативных политик, если импортировать альтернативную политику не удается. Код должен быть устойчив к такому поведению.  
  
4. Удалите утверждение настраиваемой политики из коллекции утверждений. Если не удалить утверждение Windows Communication Foundation (WCF) не предполагает, что импорт политики завершился неудачно и не импортировал связанную привязку. Если использовался метод <xref:System.ServiceModel.Description.PolicyAssertionCollection.Remove%2A?displayProperty=nameWithType> для поиска утверждения настраиваемой политики и удаления его из коллекции за один шаг, выполнять этот шаг не требуется.  
  
### <a name="to-insert-the-custom-policy-importer-into-the-metadata-system-using-a-configuration-file"></a>Вставка импортера настраиваемой политики в систему метаданных с помощью файла конфигурации  
  
1. Добавьте тип средства импорта в `<extensions>` элемент внутри [\<policyImporters>](../../configure-apps/file-schema/wcf/policyimporters.md) элемента в файле конфигурации клиента.  
  
     [!code-xml[CustomPolicySample#7](../../../../samples/snippets/csharp/VS_Snippets_CFX/custompolicysample/cs/client.exe.config#7)]
  
2. В клиентском приложении используйте класс <xref:System.ServiceModel.Description.MetadataResolver?displayProperty=nameWithType> или <xref:System.ServiceModel.Description.WsdlImporter?displayProperty=nameWithType> для разрешения метаданных, и импортер будет вызываться автоматически.  
  
     [!code-csharp[CustomPolicySample#10](../../../../samples/snippets/csharp/VS_Snippets_CFX/custompolicysample/cs/client.cs#10)]
     [!code-vb[CustomPolicySample#10](../../../../samples/snippets/visualbasic/VS_Snippets_CFX/custompolicysample/vb/client.vb#10)]  
  
### <a name="to-insert-the-custom-policy-importer-into-the-metadata-system-using-svcutilexe"></a>Вставка импортера настраиваемой политики в систему метаданных с помощью Svcutil.exe  
  
1. Добавьте тип средства импорта в `<extensions>` элемент внутри [\<policyImporters>](../../configure-apps/file-schema/wcf/policyimporters.md) элемента в Svcutil.exe.config файле конфигурации. Также можно с помощью параметра `/svcutilConfig` дать Svcutil.exe указание загрузить типы импортеров политик, зарегистрированные в другом файле конфигурации.  
  
2. Используйте [средство служебной программы метаданных ServiceModel (Svcutil.exe)](../servicemodel-metadata-utility-tool-svcutil-exe.md) , чтобы импортировать метаданные, а импортер вызывается автоматически.  
  
### <a name="to-insert-the-custom-policy-importer-into-the-metadata-system-programmatically"></a>Вставка импортера настраиваемой политики в систему метаданных программным путем  
  
1. Добавьте импортер в свойство <xref:System.ServiceModel.Description.MetadataImporter.PolicyImportExtensions%2A?displayProperty=nameWithType> (например, если используется класс <xref:System.ServiceModel.Description.WsdlImporter?displayProperty=nameWithType>), прежде чем импортировать метаданные.  
  
## <a name="see-also"></a>См. также

- <xref:System.ServiceModel.Description.MetadataResolver?displayProperty=nameWithType>
- <xref:System.ServiceModel.Description.WsdlImporter?displayProperty=nameWithType>
- <xref:System.ServiceModel.Description.MetadataResolver?displayProperty=nameWithType>
- [Расширение системы метаданных](extending-the-metadata-system.md)
