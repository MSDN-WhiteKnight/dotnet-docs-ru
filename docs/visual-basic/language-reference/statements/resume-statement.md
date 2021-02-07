---
description: Дополнительные сведения о инструкции Resume
title: Оператор Resume
ms.date: 07/20/2015
f1_keywords:
- vb.Resume
- vb.ResumeNext
helpviewer_keywords:
- Next statement [Visual Basic], Resume
- Resume Next statement [Visual Basic]
- execution [Visual Basic], resuming
- run-time errors [Visual Basic], resuming after
- Resume statement [Visual Basic], syntax
- errors [Visual Basic], resuming after
- Error statement [Visual Basic], and Resume statement
- execution
- Resume statement [Visual Basic]
ms.assetid: e24d058b-1a5c-4274-acb9-7d295d3ea537
ms.openlocfilehash: fd3a02fc2606355d7e3a34f5c0d69eef577809de
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99741189"
---
# <a name="resume-statement"></a>Оператор Resume

Возобновляет выполнение по завершении подпрограммы обработки ошибок.  
  
 Мы рекомендуем использовать структурированную обработку исключений в коде, когда это возможно, вместо использования неструктурированной обработки исключений и `On Error` `Resume` инструкций и. Дополнительные сведения см. в разделе [Оператор Try...Catch...Finally](try-catch-finally-statement.md).  
  
## <a name="syntax"></a>Синтаксис  
  
```vb  
Resume [ Next | line ]  
```  
  
## <a name="parts"></a>Компоненты  

 `Resume`  
 Обязательный элемент. Если ошибка произошла в той же процедуре, что и обработчик ошибок, выполнение возобновляется с помощью инструкции, вызвавшей ошибку. Если ошибка произошла в вызванной процедуре, выполнение возобновляется с оператора, который последний раз вызывался из процедуры, содержащей подпрограмму обработки ошибок.  
  
 `Next`  
 Необязательный элемент. Если ошибка произошла в той же процедуре, что и обработчик ошибок, выполнение возобновляется с помощью инструкции, следующей за инструкцией, вызвавшей ошибку. Если ошибка произошла в вызванной процедуре, выполнение возобновляется с помощью инструкции, следующей за инструкцией, которая последний раз вызвала процедуру, содержащую подпрограмму обработки ошибок (или `On Error Resume Next` ).  
  
 `line`  
 Необязательный элемент. Выполнение возобновляется в строке, указанной в `line` аргументе Required. `line`Аргумент является меткой строки или номером строки и должен находиться в той же процедуре, что и обработчик ошибок.  
  
## <a name="remarks"></a>Remarks  
  
> [!NOTE]
> Рекомендуется использовать структурированную обработку исключений в коде, когда это возможно, вместо использования неструктурированной обработки исключений и `On Error` `Resume` инструкций и. Дополнительные сведения см. в разделе [Оператор Try...Catch...Finally](try-catch-finally-statement.md).  
  
 При использовании `Resume` инструкции в любом месте, кроме в подпрограммы обработки ошибок, возникает ошибка.  
  
 `Resume`Инструкция не может быть использована в любой процедуре, содержащей `Try...Catch...Finally` оператор.  
  
## <a name="example"></a>Пример  

 В этом примере `Resume` оператор используется для завершения обработки ошибок в процедуре, а затем возобновляется выполнение с инструкцией, вызвавшей ошибку. Номер ошибки 55 создается для демонстрации использования `Resume` инструкции.  
  
 [!code-vb[VbVbalrErrorHandling#16](~/samples/snippets/visualbasic/VS_Snippets_VBCSharp/VbVbalrErrorHandling/VB/Class1.vb#16)]  
  
## <a name="requirements"></a>Требования  

 **Пространство имен:** [Microsoft. VisualBasic](../runtime-library-members.md)  
  
 **Сборка:** Библиотека времени выполнения Visual Basic (в Microsoft.VisualBasic.dll)  
  
## <a name="see-also"></a>См. также раздел

- [Оператор Try...Catch...Finally](try-catch-finally-statement.md)
- [Оператор Error](error-statement.md)
- [Оператор On Error](on-error-statement.md)
