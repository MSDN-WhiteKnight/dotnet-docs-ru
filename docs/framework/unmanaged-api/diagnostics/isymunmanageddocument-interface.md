---
description: 'Дополнительные сведения о: интерфейс ISymUnmanagedDocument'
title: Интерфейс ISymUnmanagedDocument
ms.date: 03/30/2017
api_name:
- ISymUnmanagedDocument
api_location:
- diasymreader.dll
api_type:
- COM
f1_keywords:
- ISymUnmanagedDocument
helpviewer_keywords:
- ISymUnmanagedDocument interface [.NET Framework debugging]
ms.assetid: 5c26b366-6e81-467c-9dd0-02dd26fee0a3
topic_type:
- apiref
ms.openlocfilehash: cd1907e570dd15ebcac3ee12aa09c626c9bb7787
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99710144"
---
# <a name="isymunmanageddocument-interface"></a>Интерфейс ISymUnmanagedDocument

Представляет документ, на который ссылается хранилище символов. Документ определяется по универсальному указателю ресурсов (URL-адрес) и GUID типа документа. Документ можно разместить независимо от того, как он хранится, используя URL-адрес и GUID типа документа. Вы можете сохранить источник документа в хранилище символов и получить его через этот интерфейс.  
  
## <a name="methods"></a>Методы  
  
|Метод|Описание|  
|------------|-----------------|  
|[Метод FindClosestLine](isymunmanageddocument-findclosestline-method.md)|Возвращает ближайшую строку, которая является точкой последовательности, с учетом строки в этом документе, которая может быть или не являться точкой последовательности.|  
|[Метод GetCheckSum](isymunmanageddocument-getchecksum-method.md)|Возвращает контрольную сумму.|  
|[Метод GetCheckSumAlgorithmId](isymunmanageddocument-getchecksumalgorithmid-method.md)|Возвращает идентификатор алгоритма контрольной суммы или возвращает идентификатор GUID всех нулей, если контрольная сумма отсутствует.|  
|[Метод GetDocumentType](isymunmanageddocument-getdocumenttype-method.md)|Возвращает тип документа этого документа.|  
|[Метод GetLanguage](isymunmanageddocument-getlanguage-method.md)|Возвращает идентификатор языка этого документа.|  
|[Метод GetLanguageVendor](isymunmanageddocument-getlanguagevendor-method.md)|Получает поставщика языка этого документа.|  
|[Метод GetSourceLength](isymunmanageddocument-getsourcelength-method.md)|Возвращает длину внедренного источника в байтах.|  
|[Метод GetSourceRange](isymunmanageddocument-getsourcerange-method.md)|Возвращает указанный диапазон внедренного источника в заданный буфер.|  
|[Метод GetURL](isymunmanageddocument-geturl-method.md)|Возвращает URL-адрес для этого документа.|  
|[Метод HasEmbeddedSource](isymunmanageddocument-hasembeddedsource-method.md)|Возвращает `true` , если документ имеет исходный код, внедренный в отладочные символы; в противном случае возвращает `false` .|  
  
## <a name="see-also"></a>См. также

- [Интерфейсы хранилища символов диагностики](diagnostics-symbol-store-interfaces.md)
