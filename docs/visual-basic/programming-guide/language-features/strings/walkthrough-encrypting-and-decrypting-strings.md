---
description: Дополнительные сведения см. в разделе Пошаговое руководство. шифрование и расшифровка строк в Visual Basic
title: Шифрование и расшифровка строк
ms.date: 07/20/2015
helpviewer_keywords:
- encryption [Visual Basic], strings
- strings [Visual Basic], encrypting
- decryption [Visual Basic], strings
- strings [Visual Basic], decrypting
ms.assetid: 1f51e40a-2f88-43e2-a83e-28a0b5c0d6fd
ms.openlocfilehash: afc1eeaec85b2e430aead7f16401289b6e2e9e49
ms.sourcegitcommit: 10e719780594efc781b15295e499c66f316068b8
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/14/2021
ms.locfileid: "100471088"
---
# <a name="walkthrough-encrypting-and-decrypting-strings-in-visual-basic"></a>Пошаговое руководство. Шифрование и расшифровка строк в Visual Basic

В этом пошаговом руководстве показано, как использовать <xref:System.Security.Cryptography.DESCryptoServiceProvider> класс для шифрования и расшифровки строк с помощью поставщика служб шифрования (CSP) алгоритма Triple Data Encryption Standard ( <xref:System.Security.Cryptography.TripleDES> ). Первым шагом является создание простого класса-оболочки, который инкапсулирует алгоритм 3DES и сохраняет зашифрованные данные в виде строки в кодировке Base-64. Затем эта оболочка используется для безопасного хранения личных данных пользователя в общедоступном текстовом файле.  
  
 Вы можете использовать шифрование для защиты секретов пользователя (например, пароли) и сделать учетные данные недоступными для чтения неавторизованными пользователями. Это может защитить удостоверение полномочного пользователя от кражи, что защищает ресурсы пользователя и обеспечивает неподдельность. Шифрование также может защитить данные пользователя от несанкционированного доступа неавторизованными пользователями.  
  
 Дополнительные сведения см. в разделе [Службы криптографии](../../../../standard/security/cryptographic-services.md).  
  
> [!IMPORTANT]
> Rijndael (теперь называется AES [AES]) и алгоритмы 3DES обеспечивают более высокий уровень безопасности, чем DES, так как они требуют более ресурсоемких вычислений. Дополнительные сведения см. в разделах <xref:System.Security.Cryptography.DES> и <xref:System.Security.Cryptography.Rijndael>.  
  
### <a name="to-create-the-encryption-wrapper"></a>Создание оболочки шифрования  
  
1. Создайте `Simple3Des` класс для инкапсуляции методов шифрования и расшифровки.  
  
     [!code-vb[VbVbalrStrings#38](~/samples/snippets/visualbasic/VS_Snippets_VBCSharp/VbVbalrStrings/VB/Class3.vb#38)]  
  
2. Добавьте импорт пространства имен криптографии в начало файла, содержащего `Simple3Des` класс.  
  
     [!code-vb[VbVbalrStrings#77](~/samples/snippets/visualbasic/VS_Snippets_VBCSharp/VbVbalrStrings/VB/Class3.vb#77)]  
  
3. В `Simple3Des` классе добавьте частное поле для хранения поставщика служб шифрования 3DES.  
  
     [!code-vb[VbVbalrStrings#39](~/samples/snippets/visualbasic/VS_Snippets_VBCSharp/VbVbalrStrings/VB/Class3.vb#39)]  
  
4. Добавьте закрытый метод, создающий массив байтов указанной длины из хэша указанного ключа.  
  
     [!code-vb[VbVbalrStrings#41](~/samples/snippets/visualbasic/VS_Snippets_VBCSharp/VbVbalrStrings/VB/Class3.vb#41)]  
  
5. Добавьте конструктор для инициализации поставщика служб шифрования 3DES.  
  
     `key`Параметр управляет `EncryptData` `DecryptData` методами и.  
  
     [!code-vb[VbVbalrStrings#40](~/samples/snippets/visualbasic/VS_Snippets_VBCSharp/VbVbalrStrings/VB/Class3.vb#40)]  
  
6. Добавьте открытый метод, который шифрует строку.  
  
     [!code-vb[VbVbalrStrings#42](~/samples/snippets/visualbasic/VS_Snippets_VBCSharp/VbVbalrStrings/VB/Class3.vb#42)]  
  
7. Добавьте открытый метод, который расшифровывает строку.  
  
     [!code-vb[VbVbalrStrings#43](~/samples/snippets/visualbasic/VS_Snippets_VBCSharp/VbVbalrStrings/VB/Class3.vb#43)]  
  
     Класс-оболочку теперь можно использовать для защиты пользовательских ресурсов. В этом примере он используется для безопасного хранения личных данных пользователя в общедоступном текстовом файле.  
  
### <a name="to-test-the-encryption-wrapper"></a>Тестирование оболочки шифрования  
  
1. В отдельном классе добавьте метод, который использует `EncryptData` метод оболочки для шифрования строки и записи ее в папку пользователя "Мои документы".  
  
     [!code-vb[VbVbalrStrings#78](~/samples/snippets/visualbasic/VS_Snippets_VBCSharp/VbVbalrStrings/VB/Class3.vb#78)]  
  
2. Добавьте метод, который считывает зашифрованную строку из папки пользователя "Мои документы" и расшифровывает строку с помощью `DecryptData` метода оболочки.  
  
     [!code-vb[VbVbalrStrings#79](~/samples/snippets/visualbasic/VS_Snippets_VBCSharp/VbVbalrStrings/VB/Class3.vb#79)]  
  
3. Добавьте код пользовательского интерфейса для вызова `TestEncoding` методов и `TestDecoding` .  
  
4. Запустите приложение.  
  
     При тестировании приложения Обратите внимание, что оно не будет расшифровывать данные, если указать неправильный пароль.  
  
## <a name="see-also"></a>См. также раздел

- <xref:System.Security.Cryptography>
- <xref:System.Security.Cryptography.DESCryptoServiceProvider>
- <xref:System.Security.Cryptography.DES>
- <xref:System.Security.Cryptography.TripleDES>
- <xref:System.Security.Cryptography.Rijndael>
- [службы шифрования](../../../../standard/security/cryptographic-services.md)
