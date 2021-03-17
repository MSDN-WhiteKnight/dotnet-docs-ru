---
title: Общие сведения об элементе управления LinkLabel (Windows Forms)
ms.date: 03/30/2017
f1_keywords:
- LinkLabel
helpviewer_keywords:
- links [Windows Forms], LinkLabel control
- Label control [Windows Forms], about Label control
- LinkLabel control [Windows Forms], about LinkLabel control
ms.assetid: 9e248549-10ca-43a3-bb5e-60f583d369f1
ms.openlocfilehash: 541467b0f1285d372e5f6d502d9d8f28c8c6333e
ms.sourcegitcommit: 5b6d778ebb269ee6684fb57ad69a8c28b06235b9
ms.translationtype: MT
ms.contentlocale: ru-RU
ms.lasthandoff: 04/08/2019
ms.locfileid: "59083131"
---
# <a name="linklabel-control-overview-windows-forms"></a>Общие сведения об элементе управления LinkLabel (Windows Forms)
Windows Forms <xref:System.Windows.Forms.LinkLabel> управления позволяет добавлять веб-ссылок для приложений Windows Forms. Можно использовать <xref:System.Windows.Forms.LinkLabel> управления для всех элементов, можно использовать <xref:System.Windows.Forms.Label> управления для; часть текста можно задать как ссылку на файл, папку или веб-страницы.  
  
## <a name="what-you-can-do-with-the-linklabel-control"></a>Что можно сделать с помощью элемента управления LinkLabel  
 В дополнение к все свойства, методы и события объекта <xref:System.Windows.Forms.Label> элемента управления, <xref:System.Windows.Forms.LinkLabel> элемент управления имеет свойства для гиперссылок и цвета связей. <xref:System.Windows.Forms.LinkLabel.LinkArea%2A> Свойство задает область текста, который активирует ссылку. <xref:System.Windows.Forms.LinkLabel.LinkColor%2A>, <xref:System.Windows.Forms.LinkLabel.VisitedLinkColor%2A>, И <xref:System.Windows.Forms.LinkLabel.ActiveLinkColor%2A> свойства задать цвета ссылки. <xref:System.Windows.Forms.LinkLabel.LinkClicked> Событий определяет, что произойдет, если выбран текст ссылки.  
  
 Простейшее использование <xref:System.Windows.Forms.LinkLabel> управления является отображение одной ссылки, используя <xref:System.Windows.Forms.LinkLabel.LinkArea%2A> свойство, но можно также отобразить несколько гиперссылок с помощью <xref:System.Windows.Forms.LinkLabel.Links%2A> свойство. <xref:System.Windows.Forms.LinkLabel.Links%2A> Свойство позволяет получить доступ к коллекции ссылок. Можно также указать данные в <xref:System.Windows.Forms.LinkLabel.Link.LinkData%2A> свойства каждого отдельного <xref:System.Windows.Forms.LinkLabel.Link> объекта. Значение <xref:System.Windows.Forms.LinkLabel.Link.LinkData%2A> свойство может использоваться для хранения, расположение файла для отображения или адрес веб-сайта.  
  
## <a name="see-also"></a>См. также

- <xref:System.Windows.Forms.LinkLabel>
- [Общие сведения об элементе управления Label](label-control-overview-windows-forms.md)
- [Практическое руководство. Создание связи с объектом или веб-страницей с помощью элемента управления LinkLabel в Windows Forms](link-to-an-object-or-web-page-with-wf-linklabel-control.md)
- [Практическое руководство. Изменение внешнего вида элемента управления LinkLabel в Windows Forms](how-to-change-the-appearance-of-the-windows-forms-linklabel-control.md)
