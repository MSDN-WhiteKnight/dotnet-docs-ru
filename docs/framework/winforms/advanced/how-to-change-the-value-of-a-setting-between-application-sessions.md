---
title: 'Как выполнить: Изменение значения параметра между сеансами приложения'
ms.date: 03/30/2017
helpviewer_keywords:
- application settings [Windows Forms], changing
- application settings [Windows Forms], between application sessions
ms.assetid: 1a85911f-97b2-476c-930b-83379edd890c
ms.openlocfilehash: 95e613cb280813cd75d887d3cf147d7c897bc2e6
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59318906"
---
# <a name="how-to-change-the-value-of-a-setting-between-application-sessions"></a>Как выполнить: Изменение значения параметра между сеансами приложения
В некоторых случаях может потребоваться изменить значение параметра между сеансами приложения после компиляции и развертывания приложения. Например может потребоваться изменить строку подключения, чтобы он указывал на правильное расположение базы данных. Так как средства разработки недоступны после компиляции и развертывания приложения, необходимо изменить значение параметра в соответствующем файле вручную.  
  
### <a name="to-change-the-value-of-a-setting-between-application-sessions"></a>Чтобы изменить значение параметра между сеансами приложения  
  
1. В Блокнот (Майкрософт) или некоторые другие текстовом редакторе или редакторе XML, откройте файл .config, связанный с приложением.  
  
2. Найдите запись для параметра, который вы хотите изменить. Он должен выглядеть аналогично приведенному ниже примеру.  
  
    ```xml  
    <setting name="Setting1" serializeAs="String" >  
       <value>My Setting Value</value>  
    </setting>  
    ```  
  
3. Введите новое значение параметра и сохраните файл.  
  
## <a name="see-also"></a>См. также

- [Использование параметров приложения и параметров пользователя](using-application-settings-and-user-settings.md)
- [Общие сведения о параметрах приложений](application-settings-overview.md)
