---
title: Практическое руководство. Использование свойств Modifiers и GenerateMember
ms.date: 03/30/2017
dev_langs:
- csharp
- vb
f1_keywords:
- Designer_GenerateMember
- Designer_Modifiers
helpviewer_keywords:
- base forms
- inheritance [Windows Forms], forms
- inherited forms [Windows Forms], Windows Forms
- inherited forms
- form inheritance
- Windows Forms, inheritance
ms.assetid: 3381a5e4-e1a3-44e2-a765-a0b758937b85
ms.openlocfilehash: 6194ef288bd43267c2b00fa6d7c6250e90b37c75
ms.sourcegitcommit: 558d78d2a68acd4c95ef23231c8b4e4c7bac3902
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/09/2019
ms.locfileid: "59322645"
---
# <a name="how-to-use-the-modifiers-and-generatemember-properties"></a>Практическое руководство. Использование свойств Modifiers и GenerateMember
При размещении компонента в форму Windows, в среде разработки предоставляются два свойства: `GenerateMember` и `Modifiers`. `GenerateMember` Свойство указывает, когда конструктор Windows Forms создает переменную-член для компонента. `Modifiers` Свойство — это модификатор доступа, назначенный этой переменной члена. Если значение `GenerateMember` свойство `false`, значение `Modifiers` не оказывает никакого влияния.  
  
> [!NOTE]
>  Отображаемые диалоговые окна и команды меню могут отличаться от описанных в справке в зависимости от текущих параметров или выпуска. Чтобы изменить параметры, выберите в меню **Сервис** пункт **Импорт и экспорт параметров** . Дополнительные сведения см. в разделе [Персонализация интегрированной среды разработки Visual Studio](/visualstudio/ide/personalizing-the-visual-studio-ide).  
  
### <a name="to-specify-whether-a-component-is-a-member-of-the-form"></a>Для указания, является ли компонент членом формы  
  
1. В конструкторе Windows Forms откройте форму.  
  
2. Откройте **элементов**и в форме, поместите три <xref:System.Windows.Forms.Button> элементов управления.  
  
3. Задайте `GenerateMember` и `Modifiers` свойства для каждого <xref:System.Windows.Forms.Button> управления согласно следующей таблице.  
  
    |Имя кнопки|Значение GenerateMember|Значение модификаторов|  
    |-----------------|--------------------------|---------------------|  
    |`button1`|`true`|`private`|  
    |`button2`|`true`|`protected`|  
    |`button3`|`false`|Без изменений|  
  
4. Постройте решение.  
  
5. В **обозревателе решений** нажмите кнопку **Показать все файлы**.  
  
6. Откройте **Form1** узел и в **редактор кода**откройте **Form1.Designer.vb** или **Form1.Designer.cs** файл. Этот файл содержит код, созданный конструктором Windows Forms.  
  
7. Найдите объявления для содержатся три кнопки. В следующем примере кода показаны различия, определяемое `GenerateMember` и `Modifiers` свойства.  
  
     [!code-csharp[System.Windows.Forms.GenerateMember#3](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.GenerateMember/CS/Form1.cs#3)]
     [!code-vb[System.Windows.Forms.GenerateMember#3](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Windows.Forms.GenerateMember/VB/Form1.vb#3)]  
  
     [!code-csharp[System.Windows.Forms.GenerateMember#2](~/samples/snippets/csharp/VS_Snippets_Winforms/System.Windows.Forms.GenerateMember/CS/Form1.cs#2)]
     [!code-vb[System.Windows.Forms.GenerateMember#2](~/samples/snippets/visualbasic/VS_Snippets_Winforms/System.Windows.Forms.GenerateMember/VB/Form1.vb#2)]  
  
> [!NOTE]
>  По умолчанию назначается в конструкторе Windows Forms `private` (`Friend` в Visual Basic) модификатор контейнерные элементы управления, такие как <xref:System.Windows.Forms.Panel>. Если с основным <xref:System.Windows.Forms.UserControl> или <xref:System.Windows.Forms.Form> имеет контейнерного элемента управления, он не принимает новые дочерние объекты в наследуемых элементов управления и форм. Решение заключается в изменить модификатор элемента управления базового контейнера для `protected` или `public`.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.Button>
- [Визуальное наследование в Windows Forms](windows-forms-visual-inheritance.md)
- [Пошаговое руководство. Демонстрация визуального наследования](walkthrough-demonstrating-visual-inheritance.md)
- [Практическое руководство. Наследование форм Windows Forms](how-to-inherit-windows-forms.md)
