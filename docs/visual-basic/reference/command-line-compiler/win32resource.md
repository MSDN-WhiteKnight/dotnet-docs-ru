---
description: 'Дополнительные сведения: -win32resource'
title: -win32resource
ms.date: 03/13/2018
f1_keywords:
- -win32resource
- win32resource
helpviewer_keywords:
- /win32resource compiler option [Visual Basic]
- -win32resource compiler option [Visual Basic]
- win32resource compiler option [Visual Basic]
ms.assetid: e226946d-19ce-4cc9-91f5-aed24f77aa2b
ms.openlocfilehash: a6f14fd2eb1349940c1e208a5baaa4205647f666
ms.sourcegitcommit: 10e719780594efc781b15295e499c66f316068b8
ms.translationtype: HT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/14/2021
ms.locfileid: "100433488"
---
# <a name="-win32resource"></a>-win32resource

Вставляет файл ресурсов Win32 в выходной файл.  
  
## <a name="syntax"></a>Синтаксис  
  
```console  
-win32resource:filename  
```  
  
## <a name="arguments"></a>Аргументы  

 `filename`  
 Имя файла ресурсов, который требуется добавить в выходной файл. Если имя файла содержит пробел, заключите имя файла в кавычки (" ").  
  
## <a name="remarks"></a>Примечания  

 Вы можете создать файл ресурсов Win32 с помощью компилятора ресурсов Microsoft Windows (RC).  
  
 Ресурс Win32 может содержать сведения о версии или точечный рисунок (значок), который помогает идентифицировать приложение в **проводнике**. Если параметр `-win32resource` не задан, компилятор создаст сведения о версии на основе версии сборки. Параметры `-win32resource` и `-win32icon` являются взаимоисключающими.  
  
 Чтобы создать ссылку на файл ресурсов .NET Framework, обратитесь к разделу [-linkresource (Visual Basic)](linkresource.md). Чтобы присоединить файл ресурсов .NET, обратитесь к разделу [-resource (Visual Basic)](resource.md).  
  
> [!NOTE]
> Параметр `-win32resource` недоступен в среде разработки Visual Studio. Его можно использовать только при компиляции из командной строки.  
  
## <a name="example"></a>Пример  

 Следующий код компилирует `In.vb` и присоединяет файл ресурсов Win32 `Rf.res`:  
  
```console  
vbc -win32resource:rf.res in.vb  
```  
  
## <a name="see-also"></a>См. также

- [Компилятор Visual Basic с интерфейсом командной строки](index.md)
- [Примеры командных строк компиляции](sample-compilation-command-lines.md)
