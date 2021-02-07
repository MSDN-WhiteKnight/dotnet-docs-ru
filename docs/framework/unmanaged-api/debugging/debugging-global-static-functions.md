---
description: 'Дополнительные сведения: отладка глобальных статических функций'
title: Глобальные статические функции отладки
ms.date: 03/30/2017
helpviewer_keywords:
- global static functions [.NET Framework debugging]
- debugging global static functions [.NET Framework]
- unmanaged global static functions [.NET Framework], debugging
ms.assetid: efc64414-77c3-48d0-881a-8594ed416aad
ms.openlocfilehash: efee1bfb6eb61ae2311320a4c12bf08ec0f9534b
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99661458"
---
# <a name="debugging-global-static-functions"></a>Глобальные статические функции отладки

В этом разделе описываются неуправляемые глобальные статистические функции, которые используют API отладки.  
  
## <a name="in-this-section"></a>В этом разделе  

 [Функция _EFN_GetManagedExcepStack](efn-getmanagedexcepstack-function.md)  
 Учитывая адрес объекта управляемого исключения, возвращает строковую версию трассировки стека, содержащейся внутри.  
  
 [Функция _EFN_GetManagedObjectFieldInfo](efn-getmanagedobjectfieldinfo-function.md)  
 Возвращает смещение от начала объекта до поля и значение поля, используя предоставленный указатель объекта и имя поля.  
  
 [Функция _EFN_GetManagedObjectName](efn-getmanagedobjectname-function.md)  
 Получает имя типа с помощью предоставленного указателя управляемого объекта.  
  
 [Функция _EFN_StackTrace](efn-stacktrace-function.md)  
 Предоставляет текстовое представление трассировки управляемого стека и массив записей `CONTEXT`, по одной для каждого перехода между неуправляемым и управляемым кодом.  
  
 [Функция CLRDataCreateInstance](clrdatacreateinstance-function.md)  
 Вызывается службами доступа к данным среды CLR для создания указанного объекта интерфейса для заданного целевого процесса.  
  
 [Указатель функции PFN_CLRDataCreateInstance](pfn-clrdatacreateinstance-function-pointer.md)  
 Указывает на функцию, вызываемую службами доступа к данным среды CLR, чтобы создать указанный объект интерфейса для заданного целевого процесса.  
  
## <a name="related-sections"></a>См. также  

 [Компонентные классы отладки](debugging-coclasses.md)  
  
 [Интерфейсы отладки](debugging-interfaces.md)  
  
 [Перечисления отладки](debugging-enumerations.md)  
  
 [Структуры отладки](debugging-structures.md)
