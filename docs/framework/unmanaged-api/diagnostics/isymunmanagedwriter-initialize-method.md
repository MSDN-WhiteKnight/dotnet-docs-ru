---
description: 'Дополнительные сведения о методе: ISymUnmanagedWriter:: Initialize'
title: Метод ISymUnmanagedWriter::Initialize
ms.date: 03/30/2017
api_name:
- ISymUnmanagedWriter.Initialize
api_location:
- diasymreader.dll
api_type:
- COM
f1_keywords:
- ISymUnmanagedWriter::Initialize
helpviewer_keywords:
- ISymUnmanagedWriter::Initialize method [.NET Framework debugging]
- Initialize method, ISymUnmanagedWriter interface [.NET Framework debugging]
ms.assetid: e0ebd793-3764-4df0-8f12-0e95f60b9eae
topic_type:
- apiref
ms.openlocfilehash: eab60e9539df3d43a1602268d704ac324f028915
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99762296"
---
# <a name="isymunmanagedwriterinitialize-method"></a>Метод ISymUnmanagedWriter::Initialize

Задает интерфейс передатчика метаданных, с которым будет связан этот модуль записи, и задает имя выходного файла, в который будут записываться отладочные символы.  
  
 Этот метод может быть вызван только один раз и должен вызываться перед любым другим методом записи. Некоторым модулям записи может потребоваться имя файла. Однако всегда можно передать имя файла этому методу без какого-либо негативного воздействия на модули записи, которые не используют имя файла.  
  
## <a name="syntax"></a>Синтаксис  
  
```cpp  
HRESULT Initialize(  
    [in] IUnknown     *emitter,  
    [in] const WCHAR  *filename,  
    [in] IStream      *pIStream,  
    [in] BOOL         fFullBuild);  
```  
  
## <a name="parameters"></a>Параметры  

 `emitter`  
 окне Указатель на интерфейс передатчика метаданных.  
  
 `filename`  
 окне Имя файла, в который записываются отладочные символы. Если имя файла задано для модуля записи, который не использует имена файлов, этот параметр пропускается.  
  
 `pIStream`  
 окне Если этот параметр указан, модуль записи символов выдает символы в заданный объект, а не в <xref:System.Runtime.InteropServices.ComTypes.IStream> файл, указанный в `filename` аргументе. Параметр `pIStream` не обязателен.  
  
 `fFullBuild`  
 [входные] `true` значение, если это полная перестроение; `false` если это инкрементная компиляция.  
  
## <a name="return-value"></a>Возвращаемое значение  

 S_OK, если метод выполнен. в противном случае E_FAIL или другой код ошибки.  
  
## <a name="requirements"></a>Требования  

 **Заголовок:** Корсим. idl, Корсим. h  
  
## <a name="see-also"></a>См. также

- [Интерфейс ISymUnmanagedWriter](isymunmanagedwriter-interface.md)
- [Метод Initialize2](isymunmanagedwriter-initialize2-method.md)
