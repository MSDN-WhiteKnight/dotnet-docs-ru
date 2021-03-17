---
title: Практическое руководство. Переопределение логического дерева
ms.date: 03/30/2017
helpviewer_keywords:
- overriding the logical tree [WPF]
- logical tree [WPF], overriding
ms.assetid: 0ae4d074-8113-4b06-b4fa-e0f39d4967a6
ms.openlocfilehash: bf3459fff1a90326794d6713dd39c73596b0e960
ms.sourcegitcommit: 0c48191d6d641ce88d7510e319cf38c0e35697d0
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/05/2019
ms.locfileid: "57375231"
---
# <a name="how-to-override-the-logical-tree"></a>Практическое руководство. Переопределение логического дерева
Хотя в большинстве случаев это не требуется, разработчики улучшенных элементов управления могут переопределить логическое дерево.  
  
## <a name="example"></a>Пример  
 В этом примере описывается как подкласс <xref:System.Windows.Controls.StackPanel> переопределить логическое дерево, в этом случае для обеспечения поведения, что панель может иметь только и будет отображать только один дочерний элемент. Это поведение не является необходимым на практике, но представлено здесь, чтобы проиллюстрировать сценарий переопределения стандартного логического дерева элемента.  
  
 [!code-csharp[LogicalOverride#SingletonPanel](~/samples/snippets/csharp/VS_Snippets_Wpf/LogicalOverride/CSharp/SDKSampleLibrary/class1.cs#singletonpanel)]  
  
 Дополнительные сведения о логическом дереве см. в разделе [Деревья в WPF](trees-in-wpf.md).
