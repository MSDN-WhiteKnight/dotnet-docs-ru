---
description: 'Дополнительные сведения: -utf8output (Visual Basic)'
title: -utf8output
ms.date: 07/20/2015
helpviewer_keywords:
- -utf8output compiler option [Visual Basic]
- utf8output compiler option [Visual Basic]
- /utf8output compiler option [Visual Basic]
ms.assetid: 8ab36b1e-027a-49ac-85b4-f48997d9e4d6
ms.openlocfilehash: 317c1be3f18150ae88bb8e95927d9f5faf0e4f3c
ms.sourcegitcommit: 10e719780594efc781b15295e499c66f316068b8
ms.translationtype: HT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/14/2021
ms.locfileid: "100461896"
---
# <a name="-utf8output-visual-basic"></a>-utf8output (Visual Basic)

Отображает выходные данные компилятора в кодировке UTF-8.  
  
## <a name="syntax"></a>Синтаксис  
  
```console  
-utf8output[+ | -]  
```  
  
## <a name="arguments"></a>Аргументы  

 `+` &#124; `-`  
 Необязательный элемент. Значением по умолчанию для этого параметра является `-utf8output-`, то есть выходные данные компилятора не используют кодировку UTF-8. Указание `-utf8output` дает тот же результат, что и указание `-utf8output+`.  
  
## <a name="remarks"></a>Примечания  

 В некоторых конфигурациях для различных языков выходные данные компилятора отображаются в консоли некорректно. В таких ситуациях используйте `-utf8output` и перенаправьте выходные данные компилятора в файл.  
  
> [!NOTE]
> Параметр `-utf8output` недоступен в среде разработки Visual Studio. Его можно использовать только при компиляции из командной строки.  
  
## <a name="example"></a>Пример  

 Следующий код компилирует `In.vb` и предписывает компилятору отобразить выходные данные с использованием кодировки UTF-8.  
  
```console  
vbc -utf8output in.vb  
```  
  
## <a name="see-also"></a>См. также

- [Компилятор Visual Basic с интерфейсом командной строки](index.md)
- [Примеры командных строк компиляции](sample-compilation-command-lines.md)
