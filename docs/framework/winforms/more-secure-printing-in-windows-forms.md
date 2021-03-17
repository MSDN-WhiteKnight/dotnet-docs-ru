---
title: Более безопасная печать в Windows Forms
ms.date: 03/30/2017
helpviewer_keywords:
- Windows Forms, printing
- PrintingPermission class [Windows Forms], Windows Forms security
- printing [Windows Forms], security
- security [Windows Forms], printing
ms.assetid: 48fd36ac-872f-4de0-902a-e52969cd4367
ms.openlocfilehash: 5ee170980ed02d90606c774e2a7055f047292e33
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59197364"
---
# <a name="more-secure-printing-in-windows-forms"></a>Более безопасная печать в Windows Forms
Приложения Windows Forms часто предусмотрена возможность печати. [!INCLUDE[dnprdnshort](../../../includes/dnprdnshort-md.md)] Использует <xref:System.Drawing.Printing.PrintingPermission> класс для управления доступом к возможностям печати и связанный <xref:System.Drawing.Printing.PrintingPermissionLevel> значение перечисления, указывающее уровень доступа. По умолчанию она разрешена по умолчанию в зонах локальной интрасети и Интернета; Тем не менее в обоих зон ограничено уровень доступа. Ли приложение может начать печать, требует взаимодействия с пользователем, или не зависит значение разрешения, предоставленные приложению. По умолчанию в зону локальной интрасети получает <xref:System.Drawing.Printing.PrintingPermissionLevel.DefaultPrinting> доступа и в зону интрасети получает <xref:System.Drawing.Printing.PrintingPermissionLevel.SafePrinting> доступа.  
  
 В следующей таблице показаны функциональные возможности, доступные в каждой печати уровень разрешений.  
  
|PrintingPermissionLevel|Описание|  
|-----------------------------|-----------------|  
|<xref:System.Drawing.Printing.PrintingPermissionLevel.AllPrinting>|Предоставляет полный доступ для всех установленных принтеров.|  
|<xref:System.Drawing.Printing.PrintingPermissionLevel.DefaultPrinting>|Обеспечивает программную печать на принтере по умолчанию и более безопасную печать через диалоговое окно печати. <xref:System.Drawing.Printing.PrintingPermissionLevel.DefaultPrinting> — Это подмножество <xref:System.Drawing.Printing.PrintingPermissionLevel.AllPrinting>.|  
|<xref:System.Drawing.Printing.PrintingPermissionLevel.SafePrinting>|Предоставляет возможность печати только из более ограниченного диалоговое окно. <xref:System.Drawing.Printing.PrintingPermissionLevel.SafePrinting> — Это подмножество <xref:System.Drawing.Printing.PrintingPermissionLevel.DefaultPrinting>.|  
|<xref:System.Drawing.Printing.PrintingPermissionLevel.NoPrinting>|Запрещает доступ к принтерам. <xref:System.Drawing.Printing.PrintingPermissionLevel.NoPrinting> — Это подмножество <xref:System.Drawing.Printing.PrintingPermissionLevel.SafePrinting>.|  
  
## <a name="see-also"></a>См. также

- [Более безопасный доступ к файлам и данным в Windows Forms](more-secure-file-and-data-access-in-windows-forms.md)
- [Дополнительные вопросы безопасности в формах Windows Forms](additional-security-considerations-in-windows-forms.md)
- [Общие сведения о безопасности в Windows Forms](security-in-windows-forms-overview.md)
- [Безопасность Windows Forms](windows-forms-security.md)
