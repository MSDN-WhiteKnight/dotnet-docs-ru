---
description: 'Узнайте подробнее о: Чтение реестра и запись в него с использованием пространства имен Microsoft.Win32 (Visual Basic)'
title: Чтение реестра и запись в него с использованием пространства имен Microsoft.Win32
ms.date: 07/20/2015
helpviewer_keywords:
- registry [Visual Basic]
ms.assetid: 4a0dcce0-c27b-4199-baa8-ee4528da6a56
ms.openlocfilehash: beb81a6385043011a37eee82f2036aca91382240
ms.sourcegitcommit: ddf7edb67715a5b9a45e3dd44536dabc153c1de0
ms.translationtype: HT
ms.contentlocale: ru-RU
ms.lasthandoff: 02/06/2021
ms.locfileid: "99701590"
---
# <a name="reading-from-and-writing-to-the-registry-using-the-microsoftwin32-namespace-visual-basic"></a>Чтение реестра и запись в него с использованием пространства имен Microsoft.Win32 (Visual Basic)

Хотя `My.Computer.Registry` должно хватать для удовлетворения основных потребностей при программировании в реестре, можно также использовать классы <xref:Microsoft.Win32.Registry> и <xref:Microsoft.Win32.RegistryKey> в пространстве имен <xref:Microsoft.Win32> .NET.
  
## <a name="keys-in-the-registry-class"></a>Разделы в классе Registry  

 Класс <xref:Microsoft.Win32.Registry> предоставляет основные разделы реестра, которые можно использовать для доступа к подразделам и их значениям. Сами основные разделы доступны только для чтения. В следующей таблице перечислены и описаны семь разделов, предоставляемых классом <xref:Microsoft.Win32.Registry>.  
  
|**Key**|**Описание**|  
|-------------|---------------------|  
|<xref:Microsoft.Win32.Registry.ClassesRoot>|Определяет типы документов и свойства, связанные с этими типами.|  
|<xref:Microsoft.Win32.Registry.CurrentConfig>|Содержит сведения о конфигурации оборудования, не относящиеся к пользователю.|  
|<xref:Microsoft.Win32.Registry.CurrentUser>|Содержит сведения о текущих настройках пользователя, таких как переменные среды.|  
|<xref:Microsoft.Win32.Registry.DynData>|Содержит динамические данные реестра, например, используемые драйверами виртуальных устройств.|  
|<xref:Microsoft.Win32.Registry.LocalMachine>|Включает в себя пять подразделов (оборудование, SAM, безопасность, программное обеспечение и система), содержащих данные о конфигурации для локального компьютера.|  
|<xref:Microsoft.Win32.Registry.PerformanceData>|Содержит сведения о производительности для компонентов программного обеспечения.|  
|<xref:Microsoft.Win32.Registry.Users>|Содержит сведения о настройках пользователя по умолчанию.|  
  
> [!IMPORTANT]
> Безопаснее записывать данные для текущего пользователя (<xref:Microsoft.Win32.Registry.CurrentUser>), чем для локального компьютера (<xref:Microsoft.Win32.Registry.LocalMachine>). Условие, которое обычно называют "захватом", возникает, если создаваемый вами раздел уже был создан другим, возможно вредоносным, процессом. Чтобы предотвратить это, используйте такой метод, как <xref:Microsoft.Win32.RegistryKey.GetValue%2A>, который возвращает `Nothing`, если ключ еще не существует.  
  
## <a name="reading-a-value-from-the-registry"></a>Чтение значения из реестра  

 В следующем коде показано, как считать строку из раздела HKEY_CURRENT_USER.  
  
 [!code-vb[VbResourceTasks#20](~/samples/snippets/visualbasic/VS_Snippets_VBCSharp/VbResourceTasks/VB/Class1.vb#20)]  
  
 Следующий код считывает, увеличивает, а затем записывает строку в раздел HKEY_CURRENT_USER.  
  
 [!code-vb[VbResourceTasks#21](~/samples/snippets/visualbasic/VS_Snippets_VBCSharp/VbResourceTasks/VB/Class1.vb#21)]  
  
## <a name="see-also"></a>См. также раздел

- <xref:System.SystemException>
- <xref:System.ApplicationException>
- <xref:Microsoft.VisualBasic.MyServices.RegistryProxy>
- [Оператор Try...Catch...Finally](../../../language-reference/statements/try-catch-finally-statement.md)
- [Чтение данных из реестра и запись в реестр](reading-from-and-writing-to-the-registry.md)
- [Безопасность и реестр](security-and-the-registry.md)
