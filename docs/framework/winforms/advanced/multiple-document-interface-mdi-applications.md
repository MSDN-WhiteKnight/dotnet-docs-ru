---
title: Приложения с интерфейсом MDI
ms.date: 03/30/2017
helpviewer_keywords:
- forms [Windows Forms], MDI
- windows [Windows Forms], mDI
- Windows Forms, MDI applications
- MDI
ms.assetid: 599faf75-13cf-49cc-ad3c-255545e5cb97
ms.openlocfilehash: 0ce7c66946d03d566b21473711cb6b3315885236
ms.sourcegitcommit: 160a88c8087b0e63606e6e35f9bd57fa5f69c168
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 03/09/2019
ms.locfileid: "57717453"
---
# <a name="multiple-document-interface-mdi-applications"></a>Приложения с интерфейсом MDI
Приложения многодокументного интерфейса (MDI) позволяют отображать несколько документов в то же время, при этом каждый документ отображается в отдельном окне. MDI приложения часто попадают в окно меню с вложенными меню для переключения между окнами или документами.  
  
> [!NOTE]
>  Существуют некоторые поведения различия между MDI-форм и однооконным интерфейсом (SDI) windows в Windows Forms. `Opacity` Свойство не влияет на внешний вид дочерних MDI-форм. Кроме того <xref:System.Windows.Forms.Form.CenterToParent%2A> метод не влияет на поведение дочерних MDI-форм.  
  
## <a name="in-this-section"></a>В этом разделе  
 [Практическое руководство. Создание родительских MDI-форм](how-to-create-mdi-parent-forms.md)  
 Указания по созданию контейнера для нескольких документов в приложении MDI.  
  
 [Практическое руководство. Создание дочерних MDI-форм](how-to-create-mdi-child-forms.md)  
 Указания по созданию один или несколько окон, работающих в родительской формы MDI.  
  
 [Практическое руководство. Определить активную дочернюю форму MDI](how-to-determine-the-active-mdi-child.md)  
 Указания по проверке дочернее окно с фокусом (и отправка его содержимое в буфер обмена).  
  
 [Практическое руководство. Отправки данных в активную дочернюю форму MDI](how-to-send-data-to-the-active-mdi-child.md)  
 Указания по передаче сведений в активное дочернее окно.  
  
 [Практическое руководство. Упорядочение дочерних форм MDI](how-to-arrange-mdi-child-forms.md)  
 Инструкции для заполнения каскадных и упорядочивание дочерних окон MDI-приложения.
