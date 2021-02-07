---
description: 'Подробнее: Устранение неполадок при установке'
title: Устранение неполадок с установкой
ms.date: 03/30/2017
ms.assetid: 1644f885-c408-4d5f-a5c7-a1a907bc8acd
ms.openlocfilehash: 8beb404040c15ade8f435772fe1b947eef766702
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99703475"
---
# <a name="troubleshoot-setup-issues"></a>Устранение неполадок при установке

В этой статье описывается, как устранять неполадки при установке Windows Communication Foundation (WCF).  
  
## <a name="some-windows-communication-foundation-registry-keys-are-not-repaired-by-performing-an-msi-repair-operation-on-the-net-framework-30"></a>Некоторые разделы реестра Windows Communication Foundation невозможно восстановить с помощью операции восстановления MSI в .NET Framework 3.0  

 Если удалить какие-либо разделы реестра из следующего списка:  
  
- HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\ServiceModelService 3.0.0.0  
  
- HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\ServiceModelOperation 3.0.0.0  
  
- HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\ServiceModelEndpoint 3.0.0.0  
  
- HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\SMSvcHost 3.0.0.0  
  
- HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\MSDTC Bridge 3.0.0.0  
  
 Ключи не создаются повторно, если вы запускаете восстановление с помощью установщика платформа .NET Framework 3,0, запускаемого из программы установки **и удаления программ** на **панели управления**. Чтобы правильно восстановить эти разделы, необходимо удалить платформу .NET Framework 3.0, а затем установить ее снова.  
  
## <a name="wmi-service-corruption-blocks-installation-of-the-wmi-provider"></a>Повреждение службы WMI блокирует установку поставщика WMI

 Повреждение службы WMI может заблокировать установку поставщика Windows Communication Foundation WMI при установке пакета платформа .NET Framework 3,0. Во время установки Windows Communication Foundation Installer не удается зарегистрировать файл WCF *. mof* с помощью компонента *mofcomp.exe* . Ниже приведен список признаков возникновения такой ситуации.  
  
1. Установка .NET Framework 3.0 завершается успешно, но поставщик инструментария WMI для WCF не зарегистрирован.  
  
2. В журнале событий приложения появляется запись об ошибке, связанной с проблемами при регистрации поставщика инструментария WMI для WCF или при запуске средства mofcomp.exe.  
  
3. В файле журнала установки с именем dd_wcf_retCA* в каталоге %temp% пользователя содержатся сведения о том, что не удалось зарегистрировать поставщик инструментария WMI для WCF.  
  
4. В журнале событий или в файле журнала трассировки установки может быть зарегистрировано исключение, например одно из приведенных ниже.  
  
     ServiceModelReg [11:09:59:046]: System.ApplicationException: Неожиданный результат 3, ожидается E:\WINDOWS\system32\wbem\mofcomp.exe с «E:\WINDOWS\Microsoft.NET\Framework\v3.0\Windows Communication Foundation\ServiceModel.mof»  
  
     или  
  
     ServiceModelReg [07:19:33:843]: System.TypeInitializationException: Инициализатор типа 'System.Management.ManagementPath' выдал исключение. ---> System. Runtime. InteropServices. COMException (0x80040154): не удалось получить фабрику класса COM для компонента с CLSID {CF4CC405-E2C5-4DDD-B3CE-5E7582D8C9FA} из-за следующей ошибки: 80040154.  
  
     или  
  
     ServiceModelReg [07:19:32:750]: System.IO.FileNotFoundException: Невозможно загрузить файл или сборку 'C:\WINDOWS\system32\wbem\mofcomp.exe' или один из зависимых от них компонентов. Системе не удается найти указанный файл.  
  
     Имя файла: 'C:\WINDOWS\system32\wbem\mofcomp.exe  
  
 Чтобы решить описанную выше проблему, необходимо выполнить следующие действия.  
  
1. Запустите служебная программа для диагностики WMI, чтобы восстановить службу WMI. Дополнительные сведения об использовании этого средства см. в разделе [служебная программа для диагностики WMI](/previous-versions/tn-archive/ff404265(v%3dmsdn.10)).  
  
 Восстановите установку платформа .NET Framework 3,0 с помощью приложения **Установка и удаление программ** , расположенного в **панели управления**, или удалите или переустановите платформа .NET Framework 3,0.  
  
## <a name="repair-net-framework-30-after-net-framework-35-installation"></a>Исправление платформа .NET Framework 3,0 после установки платформа .NET Framework 3,5

 При восстановлении платформа .NET Framework 3,0 после установки платформа .NET Framework 3,5 элементы конфигурации, появившиеся платформа .NET Framework 3,5 в *machine.config* , удаляются. Однако файл *web.config* остается неизменным. Чтобы решить эту проблему, восстановите платформа .NET Framework 3,5 после этого через ARP или используйте [средство регистрации службы рабочего процесса (WFServicesReg.exe)](workflow-service-registration-tool-wfservicesreg-exe.md) с `/c` параметром.  
  
 [Средство регистрации служб рабочего процесса (WFServicesReg.exe)](workflow-service-registration-tool-wfservicesreg-exe.md) можно найти по адресу%windir%\Microsoft.NET\framework\v3.5\ или%WINDIR%\Microsoft.NET\framework64\v3.5\.  
  
## <a name="configure-iis-properly-for-wcfwf-webhost-after-installing-net-framework-35"></a>Правильная настройка узла WCF/WF в службах IIS после установки .NET Framework 3.5  

 Если при установке платформа .NET Framework 3,5 не удается настроить дополнительные параметры конфигурации IIS, связанные с WCF, в журнал установки заносится ошибка и выполняется продолжение. Все попытки запуска приложений WorkflowServices будут неудачными, поскольку отсутствуют обязательные параметры конфигурации. Например, не удастся загрузить службы правил или XOML.  
  
 Чтобы решить эту проблему, используйте [средство регистрации службы рабочего процесса (WFServicesReg.exe)](workflow-service-registration-tool-wfservicesreg-exe.md) с `/c` параметром, чтобы правильно настроить карты сценариев IIS на компьютере. [Средство регистрации служб рабочего процесса (WFServicesReg.exe)](workflow-service-registration-tool-wfservicesreg-exe.md) можно найти по адресу%windir%\Microsoft.NET\framework\v3.5\ или%WINDIR%\Microsoft.NET\framework64\v3.5\.  
  
## <a name="could-not-load-type-systemservicemodelactivationhttpmodule"></a>Не удалось загрузить тип "System. ServiceModel. Activation. HttpModule"

**Не удалось загрузить тип "System. ServiceModel. Activation. HttpModule" из сборки "System. ServiceModel, версия 3.0.0.0, язык и региональные параметры = нейтральный, PublicKeyToken = b77a5c561934e089»"**

 Эта ошибка возникает, если установлена платформа .NET Framework 4, а затем включена активация WCF HTTP. Чтобы устранить эту проблему, выполните следующую команду в Командная строка разработчика для Visual Studio:  
  
```console
aspnet_regiis.exe -i -enable  
```  
  
## <a name="see-also"></a>См. также

- [Инструкции по установке](./samples/set-up-instructions.md)
