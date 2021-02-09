---
description: 'Подробнее о следующем: Практическое руководство. Чтение значения из раздела реестра в Visual Basic'
title: Практическое руководство. Чтение значения из раздела реестра
ms.date: 07/20/2015
helpviewer_keywords:
- registry keys [Visual Basic], determining if a value exists in
- My.Computer.Registry object, examples
- registry [Visual Basic], determining if values exist
- registry keys [Visual Basic], reading from
- registry [Visual Basic], reading
ms.assetid: 775d0a57-68c9-464e-8949-9a39bd29cc64
ms.openlocfilehash: e062e40fe1c8876864e633079fc22e2c83cfb5d8
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: HT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99797683"
---
# <a name="how-to-read-a-value-from-a-registry-key-in-visual-basic"></a>Практическое руководство. Чтение значения из раздела реестра в Visual Basic

Для чтения значений из реестра Windows можно использовать метод `GetValue` объекта `My.Computer.Registry`.  
  
 Если раздел (в данном случае "Software\MyApp") не существует, возникает исключение. Если `ValueName` (в данном случае "Name") не существует, возвращается `Nothing`.  
  
 Метод `GetValue` также можно использовать для определения наличия заданного значения в определенном разделе реестра.  
  
 Когда код считывает реестр из веб-приложения, текущий пользователь определяется путем проверки подлинности и олицетворения, реализованного в веб-приложении.  
  
### <a name="to-read-a-value-from-a-registry-key"></a>Чтение значения из раздела реестра  
  
- Для чтения значения из раздела реестра используйте метод `GetValue`, указав путь и имя. В следующем примере считывается значение `Name` из раздела `HKEY_CURRENT_USER\Software\MyApp`, после чего оно отображается в окне сообщения.  
  
     [!code-vb[VbResourceTasks#4](~/samples/snippets/visualbasic/VS_Snippets_VBCSharp/VbResourceTasks/VB/Class1.vb#4)]  
  
 Этот пример кода также доступен в качестве фрагмента кода IntelliSense. В средстве выбора фрагмента кода он расположен в разделе **Операционная система Windows > Реестр**. Дополнительные сведения см. в статье [Фрагменты кода](/visualstudio/ide/code-snippets).  
  
### <a name="to-determine-whether-a-value-exists-in-a-registry-key"></a>Определение наличия значения в разделе реестра  
  
- Чтобы получить значение, используйте метод `GetValue`. В следующем коде проверяется наличие значения и возвращается сообщение, если значение отсутствует.  
  
     [!code-vb[VbResourceTasks#12](~/samples/snippets/visualbasic/VS_Snippets_VBCSharp/VbResourceTasks/VB/Class1.vb#12)]  
  
## <a name="robust-programming"></a>Отказоустойчивость  

 Реестр содержит разделы верхнего уровня или корневые разделы, которые используются для хранения данных. Например, корневой раздел HKEY_LOCAL_MACHINE используется для хранения параметров уровня компьютера, используемых всеми пользователями, тогда как HKEY_CURRENT_USER используется для хранения данных для отдельного пользователя.  
  
 При следующих условиях возможно возникновение исключения:  
  
- Имя раздела — `Nothing` (<xref:System.ArgumentNullException>).  
  
- У пользователя нет разрешений на создание разделов реестра (<xref:System.Security.SecurityException>).  
  
- Имя раздела превышает ограничение в 255 символов (<xref:System.ArgumentException>).  
  
## <a name="net-framework-security"></a>Безопасность .NET Framework  

 Для запуска этого процесса сборке нужен уровень привилегий, предоставляемый классом <xref:System.Security.Permissions.RegistryPermission>. Если процесс выполняется в контексте с частичным доверием, он может сгенерировать исключение из-за недостатка привилегий. Аналогичным образом пользователь должен иметь правильные ACL для создания и записи параметров. Например, локальное приложение, имеющее разрешение на доступ к коду, может не иметь разрешения операционной системы. Дополнительные сведения см. в разделе [Code Access Security Basics](../../../../framework/misc/code-access-security-basics.md).  
  
## <a name="see-also"></a>См. также раздел

- <xref:Microsoft.VisualBasic.MyServices.RegistryProxy>
- <xref:Microsoft.Win32.RegistryHive>
- [Чтение данных из реестра и запись в реестр](reading-from-and-writing-to-the-registry.md)
