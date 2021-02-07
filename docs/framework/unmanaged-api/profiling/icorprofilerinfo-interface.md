---
description: 'Дополнительные сведения о: ICorProfilerInfo Interface'
title: Интерфейс ICorProfilerInfo
ms.date: 03/30/2017
api_name:
- ICorProfilerInfo
api_location:
- mscorwks.dll
api_type:
- COM
f1_keywords:
- ICorProfilerInfo
helpviewer_keywords:
- ICorProfilerInfo interface [.NET Framework profiling]
ms.assetid: eb4e4ce0-06e7-4469-bbc4-edc2eb5da4b1
topic_type:
- apiref
ms.openlocfilehash: d1da0f41a7c7358b7f71c8d931fff723b3144cdd
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99737393"
---
# <a name="icorprofilerinfo-interface"></a>Интерфейс ICorProfilerInfo

Предоставляет методы для использования профилировщиками кода для взаимодействия со средой CLR для управления мониторингом событий и сведениями о запросах.  
  
> [!NOTE]
> Каждый метод в `ICorProfilerInfo` интерфейсе возвращает значение HRESULT для обозначения успеха или неудачи. Список возможных кодов возврата см. в разделе CorError. h.  
  
## <a name="methods"></a>Методы  
  
|Метод|Описание|  
|------------|-----------------|  
|[Метод BeginInprocDebugging](icorprofilerinfo-begininprocdebugging-method.md)|Инициализирует поддержку внутрипроцессного отладки. Этот метод является устаревшим в платформа .NET Framework версии 2,0.|  
|[Метод EndInprocDebugging](icorprofilerinfo-endinprocdebugging-method.md)|Завершает работу внутрипроцессного сеанса отладки. Этот метод является устаревшим в платформа .NET Framework версии 2,0.|  
|[Метод ForceGC](icorprofilerinfo-forcegc-method.md)|Принудительное выполнение сборки мусора в среде выполнения.|  
|[Метод GetAppDomainInfo](icorprofilerinfo-getappdomaininfo-method.md)|Возвращает сведения об указанном домене приложения.|  
|[Метод GetAssemblyInfo](icorprofilerinfo-getassemblyinfo-method.md)|Возвращает сведения о указанной сборке.|  
|[Метод GetClassFromObject](icorprofilerinfo-getclassfromobject-method.md)|Возвращает объект `ClassID`<br /><br /> Объект, учитывая его свойство `ObjectID` .|  
|[Метод GetClassFromToken](icorprofilerinfo-getclassfromtoken-method.md)|Возвращает идентификатор класса по заданному маркеру метаданных. Этот метод является устаревшим в платформа .NET Framework версии 2,0. Используйте вместо этого метод [ICorProfilerInfo2:: GetClassFromTokenAndTypeArgs](icorprofilerinfo2-getclassfromtokenandtypeargs-method.md) .|  
|[Метод GetClassIDInfo](icorprofilerinfo-getclassidinfo-method.md)|Возвращает родительский модуль и маркер метаданных для указанного класса.|  
|[Метод GetCodeInfo](icorprofilerinfo-getcodeinfo-method.md)|Получает экстент машинного кода, связанного с указанным идентификатором функции. Этот метод устарел. Используйте вместо этого метод [ICorProfilerInfo2:: GetCodeInfo2](icorprofilerinfo2-getcodeinfo2-method.md) .|  
|[Метод GetCurrentThreadID](icorprofilerinfo-getcurrentthreadid-method.md)|Возвращает идентификатор текущего потока, если он является управляемым потоком.|  
|[Метод GetEventMask](icorprofilerinfo-geteventmask-method.md)|Возвращает текущие категории событий, для которых профилировщик хочет получать уведомления о событиях из среды CLR.|  
|[Метод GetFunctionFromIP](icorprofilerinfo-getfunctionfromip-method.md)|Сопоставляет указатель инструкции управляемого кода с `FunctionID` .|  
|[Метод GetFunctionFromToken](icorprofilerinfo-getfunctionfromtoken-method.md)|Возвращает идентификатор функции. Этот метод является устаревшим в платформа .NET Framework версии 2,0. Используйте вместо этого метод [ICorProfilerInfo2:: жетфунктионфромтокенандтипеаргс](icorprofilerinfo2-getfunctionfromtokenandtypeargs-method.md) .|  
|[Метод GetFunctionInfo](icorprofilerinfo-getfunctioninfo-method.md)|Возвращает родительский класс и токен метаданных для указанной функции.|  
|[Метод GetHandleFromThread](icorprofilerinfo-gethandlefromthread-method.md)|Сопоставляет идентификатор потока с обработчиком потока Win32.|  
|[Метод GetILFunctionBody](icorprofilerinfo-getilfunctionbody-method.md)|Возвращает указатель на тело метода в коде на языке MSIL, начиная с его заголовка.|  
|[Метод GetILFunctionBodyAllocator](icorprofilerinfo-getilfunctionbodyallocator-method.md)|Возвращает интерфейс, предоставляющий метод для выделения памяти, используемой для перекачки тела метода в коде MSIL.|  
|[Метод GetILToNativeMapping](icorprofilerinfo-getiltonativemapping-method.md)|Возвращает карту из смещений MSIL в машинные смещения для кода, содержащегося в указанной функции.|  
|[Метод GetInprocInspectionInterface](icorprofilerinfo-getinprocinspectioninterface-method.md)|Возвращает объект, к которому можно выполнить запрос для интерфейса ICorDebugProcess. Этот метод является устаревшим в платформа .NET Framework версии 2,0.|  
|[Метод GetInprocInspectionIThisThread](icorprofilerinfo-getinprocinspectionithisthread-method.md)|Возвращает объект, для которого можно запросить интерфейс ICorDebugThread. Этот метод является устаревшим в платформа .NET Framework версии 2,0.|  
|[Метод GetModuleInfo](icorprofilerinfo-getmoduleinfo-method.md)|Возвращает имя файла модуля и идентификатор его родительской сборки для указанного идентификатора модуля.|  
|[Метод GetModuleMetaData](icorprofilerinfo-getmodulemetadata-method.md)|Возвращает экземпляр интерфейса метаданных, сопоставляемый с указанным модулем.|  
|[Метод GetObjectSize](icorprofilerinfo-getobjectsize-method.md)|Возвращает размер указанного объекта.|  
|[Метод GetThreadContext](icorprofilerinfo-getthreadcontext-method.md)|Возвращает удостоверение контекста, которое в настоящее время связано с указанным потоком.|  
|[Метод GetThreadInfo](icorprofilerinfo-getthreadinfo-method.md)|Возвращает текущее удостоверение потока Win32 для указанного потока.|  
|[Метод GetTokenAndMetadataFromFunction](icorprofilerinfo-gettokenandmetadatafromfunction-method.md)|Возвращает маркер метаданных и экземпляр интерфейса метаданных, который может использоваться для токена указанной функции.|  
|[Метод IsArrayClass](icorprofilerinfo-isarrayclass-method.md)|Определяет, является ли указанный класс классом массива.|  
|[Метод SetEnterLeaveFunctionHooks](icorprofilerinfo-setenterleavefunctionhooks-method.md)|Задает реализованные профилировщиком функции, которые должны вызываться для обработчиков "Ввод", "Leave" и "таилкалл" управляемых функций.|  
|[Метод SetEventMask](icorprofilerinfo-seteventmask-method.md)|Задает значение, указывающее типы событий, для которых профилировщик хочет получать уведомления из среды CLR.|  
|[Метод SetFunctionIDMapper](icorprofilerinfo-setfunctionidmapper-method.md)|Задает реализуемую профилировщиком функцию, которая будет вызвана для сопоставления значений `FunctionID` с альтернативными значениями, передаваемыми обработчикам входа и выхода для функции профилировщика.|  
|[Метод SetFunctionReJIT](icorprofilerinfo-setfunctionrejit-method.md)|Не реализовано. Не используйте.|  
|[Метод SetILFunctionBody](icorprofilerinfo-setilfunctionbody-method.md)|Заменяет тело указанной функции в указанном модуле.|  
|[Метод SetILInstrumentedCodeMap](icorprofilerinfo-setilinstrumentedcodemap-method.md)|Указывает, каким способом смещений исходной схемы MSIL указанной функции к новым смещениям MSIL-кода, измененного профилировщиком функции.|  
  
## <a name="remarks"></a>Remarks  

 Профилировщик вызывает метод в `ICorProfilerInfo` интерфейсе, чтобы взаимодействовать со средой CLR для управления мониторингом событий и сведениями о запросах.  
  
 Методы `ICorProfilerInfo` интерфейса реализуются средой CLR с помощью модели свободных потоков. Каждый метод возвращает значение HRESULT, указывающее на успешное выполнение или сбой. Список возможных кодов возврата см. в разделе CorError. h.  
  
 Среда CLR передается через реализацию метода [ICorProfilerCallback:: Initialize](icorprofilercallback-initialize-method.md)в профилировщике, `ICorProfilerInfo` интерфейс к каждому профилировщику кода во время инициализации. Профилировщик кода может затем вызывать методы `ICorProfilerInfo` интерфейса для получения сведений об управляемом коде, выполняемом под управлением среды CLR.  
  
## <a name="requirements"></a>Требования  

 **Платформы:** см. раздел [Требования к системе](../../get-started/system-requirements.md).  
  
 **Заголовок:** CorProf.idl, CorProf.h  
  
 **Библиотека:** CorGuids.lib  
  
 **Платформа .NET Framework версии:**[!INCLUDE[net_current_v20plus](../../../../includes/net-current-v20plus-md.md)]  
  
## <a name="see-also"></a>См. также

- [Профилирующие интерфейсы](profiling-interfaces.md)
- [Интерфейс ICorProfilerInfo2](icorprofilerinfo2-interface.md)
