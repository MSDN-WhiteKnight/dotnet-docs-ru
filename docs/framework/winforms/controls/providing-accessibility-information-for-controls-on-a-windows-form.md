---
title: Определение сведений, связанных со специальными возможностями, для элементов управления в Windows Forms
ms.date: 03/30/2017
helpviewer_keywords:
- Windows Forms controls, accessibility
- controls [Windows Forms], accessibility
- accessibility [Windows Forms], Windows Forms controls
ms.assetid: 887dee6f-5059-4d57-957d-7c6fcd4acb10
ms.openlocfilehash: 0f589f37d79c9ec8d55153aac4c846726a379055
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59218333"
---
# <a name="providing-accessibility-information-for-controls-on-a-windows-form"></a>Определение сведений, связанных со специальными возможностями, для элементов управления в Windows Forms
Специальные возможности — это специализированные программы и устройства, помогающие людям с ограниченными возможностями эффективнее использовать компьютеры. Примеры: средства чтения с экрана для слепых и служебные программы голосового ввода для людей, использующих голосовые команды вместо мыши и клавиатуры. Специальные возможности взаимодействуют со свойствами специальных возможностей, представленными элементами управления Windows Forms. К этим свойствам относятся следующие.  
  
-   **AccessibilityObject**  
  
-   **AccessibleDefaultActionDescription**  
  
-   **AccessibleDescription**  
  
-   **AccessibleName**  
  
-   **AccessibleRole**  
  
## <a name="accessibilityobject-property"></a>Свойство AccessibilityObject  
 Это свойство, доступное только для чтения, содержит экземпляр <xref:System.Windows.Forms.AccessibleObject> . **AccessibleObject** реализует интерфейс <xref:Accessibility.IAccessible> , предоставляющий описание элементов управления, расположение на экране, возможности навигации и значение. Конструктор задает это значение при добавлении элемента управления в форму.  
  
## <a name="accessibledefaultactiondescription-property"></a>Свойство AccessibleDefaultActionDescription  
 Эта строка описывает действие элемента управления. Она не отображается в окне "Свойства", и ее можно задать только в коде. В следующем примере это свойство задается для элемента управления "Кнопка".  
  
```  
' Visual Basic  
Button1.AccessibleDefaultActionDescription = _  
   "Closes the application."  
  
// C#  
Button1.AccessibleDefaultActionDescription =   
   "Closes the application.";  
  
// C++  
button1->AccessibleDefaultActionDescription =  
   "Closes the application.";  
```  
  
## <a name="accessibledescription-property"></a>Свойство AccessibleDescription  
 Эта строка описывает элемент управления. Его можно задать в окне "Свойства" или в коде следующим образом.  
  
```  
' Visual Basic  
Button1.AccessibleDescription = "A button with text 'Exit'."  
  
// C#  
Button1.AccessibleDescription = "A button with text 'Exit'";  
  
// C++  
button1->AccessibleDescription = "A button with text 'Exit'";  
```  
  
## <a name="accessiblename-property"></a>Свойство AccessibleName  
 Это имя элемента управления, переданное специальным возможностям. Его можно задать в окне "Свойства" или в коде следующим образом.  
  
```  
' Visual Basic  
Button1.AccessibleName = "Order"  
  
// C#  
Button1.AccessibleName = "Order";  
  
// C++  
button1->AccessibleName = "Order";  
```  
  
## <a name="accessiblerole-property"></a>Свойство AccessibleRole  
 Это свойство, содержащее <xref:System.Windows.Forms.AccessibleRole> , описывает роль пользовательского интерфейса для элемента управления. Для нового элемента управления задано значение `Default`. Это означает, что по умолчанию элемент управления **Кнопка** работает как **Кнопка**. Возможно, потребуется сбросить это свойство, если у элемента управления есть другая роль. Например, вы можете использовать элемент управления **PictureBox** в качестве **Chart**и вам может потребоваться, чтобы специальные возможности передавали роль как **Chart**, а не как **PictureBox**. Возможно, вы захотите указать это свойство для разработанных пользовательских элементов управления. Это свойство можно задать в окне "Свойства" или в коде следующим образом.  
  
```  
' Visual Basic  
PictureBox1.AccessibleRole = AccessibleRole.Chart  
  
// C#  
PictureBox1.AccessibleRole = AccessibleRole.Chart;  
  
// C++  
pictureBox1->AccessibleRole = AccessibleRole::Chart;  
```  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.AccessibleObject>
- <xref:System.Windows.Forms.Control.AccessibilityObject%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.Control.AccessibleDefaultActionDescription%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.Control.AccessibleDescription%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.Control.AccessibleName%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.Control.AccessibleRole%2A?displayProperty=nameWithType>
- <xref:System.Windows.Forms.AccessibleRole>
