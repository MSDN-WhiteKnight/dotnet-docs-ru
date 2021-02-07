---
description: 'Дополнительные сведения: Fusion Global static functions'
title: Глобальные статические функции Fusion
ms.date: 03/30/2017
helpviewer_keywords:
- unmanaged global static functions [.NET Framework], fusion
- fusion global static functions [.NET Framework]
- global static functions [.NET Framework fusion]
ms.assetid: 229b2188-9168-4b44-a987-e1f515494688
ms.openlocfilehash: c696908f72d67ecff5e7383e7a2754dd5436b819
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99761087"
---
# <a name="fusion-global-static-functions"></a>Глобальные статические функции Fusion

В этом разделе описаны неуправляемые глобальные статические функции, используемые API Fusion.  
  
## <a name="in-this-section"></a>В этом разделе  

 [Функция ClearDownloadCache](cleardownloadcache-function.md)  
 Очищает глобальный кэш сборок скачанных сборок.  
  
 [Функция CompareAssemblyIdentity](compareassemblyidentity-function.md)  
 Сравнивает два идентификатора сборки, чтобы определить, являются ли они эквивалентными.  
  
 [Функция CreateApplicationContext](createapplicationcontext-function.md)  
 Только для внутреннего использования. (Эта функция поддерживает инфраструктуру платформа .NET Framework и не предназначена для непосредственного использования в коде.)  
  
 [Функция CreateAssemblyCache](createassemblycache-function.md)  
 Возвращает указатель на новый экземпляр [IAssemblyCache](iassemblycache-interface.md) , представляющий глобальный кэш сборок.  
  
 [Функция CreateAssemblyEnum](createassemblyenum-function.md)  
 Возвращает указатель на экземпляр [IAssemblyEnum](iassemblyenum-interface.md) , представляющий список объектов, существующих в указанной сборке.  
  
 [Функция CreateAssemblyNameObject](createassemblynameobject-function.md)  
 Возвращает указатель на экземпляр [IAssemblyName](iassemblyname-interface.md) , представляющий уникальный идентификатор сборки с указанным именем.  
  
 [Функция CreateHistoryReader](createhistoryreader-function.md)  
 Создает средство чтения журнала для указанного файла.  
  
 [Функция CreateInstallReferenceEnum](createinstallreferenceenum-function.md)  
 Возвращает указатель на экземпляр [IInstallReferenceEnum](iinstallreferenceenum-interface.md) , представляющий список ссылок приложения на указанную сборку.  
  
 [Функция GetAppIdAuthority](getappidauthority-function.md)  
 Возвращает указатель на экземпляр [иаппидаусорити](iappidauthority-interface.md) , который управляет ключами для удостоверений приложений и ссылок.  
  
 [Функция GetAssemblyIdentityFromFile](getassemblyidentityfromfile-function.md)  
 Возвращает указатель на `IUnknown` объект с указанным `IID` в сборке по указанному пути к файлу.  
  
 [Функция GetCachePath](getcachepath-function.md)  
 Возвращает путь к кэшированной сборке с использованием указанных флагов.  
  
 [Функция GetHistoryFileDirectory](gethistoryfiledirectory-function.md)  
 Возвращает путь к каталогу журнала приложения.  
  
 [Функция GetIdentityAuthority](getidentityauthority-function.md)  
 Возвращает указатель на экземпляр [IIdentityAuthority](iidentityauthority-interface.md) , который управляет ключами для объектов кода.  
  
 [Функция IsFrameworkAssembly](isframeworkassembly-function.md)  
 Возвращает значение, указывающее, является ли указанная сборка управляемой.  
  
 [Функция NukeDownloadedCache](nukedownloadedcache-function.md)  
 Удаляет кэш загрузки среды CLR.  
  
 [Функция PreBindAssemblyEx](prebindassemblyex-function.md)  
 Возвращает отображаемое имя после применения политики для сборки.  
  
## <a name="related-sections"></a>См. также  

 [Fusion-интерфейсы](fusion-interfaces.md)  
  
 [Перечисления Fusion](fusion-enumerations.md)  
  
 [Структуры Fusion](fusion-structures.md)  
  
 [Глобальный кэш сборок](../../app-domains/gac.md)
