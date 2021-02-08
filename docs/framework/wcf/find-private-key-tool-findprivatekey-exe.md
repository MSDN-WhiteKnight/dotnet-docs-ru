---
description: Дополнительные сведения о средстве "поиск закрытого ключа" (FindPrivateKey.exe)
title: Средство поиска закрытых ключей (FindPrivateKey.exe)
ms.date: 09/11/2017
ms.assetid: b8846a95-3fcc-4e8c-b9c0-128d975a6307
ms.openlocfilehash: 1d87d19e17c1de89c13db6d7ca092eedf630e6ca
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99793289"
---
# <a name="find-private-key-tool-findprivatekeyexe"></a>Средство поиска закрытых ключей (FindPrivateKey.exe)

Эта программа командной строки предназначена для извлечения закрытого ключа из хранилища сертификатов. Например, *FindPrivateKey.exe* можно использовать для поиска расположения и имени файла закрытого ключа, связанного с конкретным сертификатом X. 509 в хранилище сертификатов.

> [!IMPORTANT]
> Средство FindPrivateKey поставляется в качестве образца WCF. Дополнительные сведения о том, где найти пример и как его создать, см. в разделе [FindPrivateKey](./samples/findprivatekey.md).

## <a name="syntax"></a>Синтаксис

```console
FindPrivateKey<storeName> <storeLocation> [{ {-n <subjectName>} | {-t <thumbprint>} } [-f | -d | -a]]
```

## <a name="remarks"></a>Remarks

В следующих таблицах описаны аргументы и параметры, которые можно использовать со средством Find Private Key (FindPrivateKey.exe).

|Аргумент|Описание|
|--------------|-----------------|
|`storeName`|Имя хранилища сертификатов.|
|`storeLocation`|Расположение хранилища сертификатов.|

|Параметр|Описание|
|------------|-----------------|
|`/n <`*SubjectName*`>`|Задает имя субъекта сертификата.|
|`/t <`*отпечаток*`>`|Задает отпечаток сертификата. Используйте Certmgr.exe для извлечения отпечатка сертификата.|
|`/f`|Выводит только имя файла.|
|`/d`|Выводит только каталог.|
|`/a`|Выводит абсолютное имя файла.|

## <a name="examples"></a>Примеры

Следующая команда извлекает закрытый ключ для Джон Петров:

```console
FindPrivateKey My CurrentUser -n "CN=John Doe"
```

Следующая команда извлекает закрытый ключ для локального компьютера:

```console
FindPrivateKey My LocalMachine -t "03 33 98 63 d0 47 e7 48 71 33 62 64 76 5c 4c 9d 42 1d 6b 52" –a
```
